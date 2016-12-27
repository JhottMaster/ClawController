using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;

namespace ClawController
{
    public partial class ClawControllerForm : Form
    {
        private SerialPort serialPort;
        private List<ArmPosition> currentPath = new List<ArmPosition>();

        private Timer autoKeyFrameTimer = new Timer();
        private AccurateTimer playbackPathTimer;
        private AccurateTimer interpolationTimer;
        private Stopwatch interpolationStopWatch = new Stopwatch();
        private Stopwatch playbackStopWatch = new Stopwatch();
               

        #region "Properties"
        public string COMPort
        {
            get {
                if (cmbBxPort.Items.Count == 0)
                    throw new Exception("No COM ports available!");
                return cmbBxPort.SelectedItem.ToString();
            }
        }

        public int COMBaudRate
        {
            get
            {
                if (cmbBxRate.Items.Count == 0)
                    throw new Exception("No baud rates specified...?");
                return Convert.ToInt32(cmbBxRate.SelectedItem.ToString());
            }
        }

        public int InterpolationFrequency
        {
            get {
                try { return Convert.ToInt32(txtBxInterpolationFrequency.Text); }
                catch { }
                return playbackPathTimer.Interval / 2;
            }
        }

        public int AutoKeyFrequency
        {
            get
            {
                try { return Convert.ToInt32(txtBxAutoKeyFrequency.Text); }
                catch { }
                return playbackPathTimer.Interval;
            }
        }

        public int PlaybackFrequency
        {
            get
            {
                try { return Convert.ToInt32(txtBxPlaybackFrequency.Text); }
                catch { }
                return 2000;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
                Connect();
            else
                Disconnect();
        }
        #endregion


        public ClawControllerForm()
        {
            InitializeComponent();
            btnAutoGenKeyFrameOriginalText = btnAutoGenKeyFrame.Text;
            btnPlayPauseOriginalText = btnPlayPause.Text;

            autoKeyFrameTimer.Tick += AutoKeyFrameTimer_Tick;

            playbackPathTimer = new AccurateTimer(this);
            playbackPathTimer.Tick += PlaybackPathTimer_Tick;
            interpolationTimer = new AccurateTimer(this);
            interpolationTimer.Tick += InterpolationTimer_Tick;

            cmbBxPort.Items.Clear();
            cmbBxPort.Items.AddRange(SerialPort.GetPortNames());

            if (cmbBxPort.SelectedItem == null) cmbBxPort.SelectedIndex = cmbBxPort.Items.Count - 1;
            if (cmbBxRate.SelectedItem == null) cmbBxRate.SelectedIndex = 0; ;
        }

        private void Connect()
        {
            Disconnect();
            try
            {
                serialPort = new SerialPort(COMPort, COMBaudRate);
                serialPort.Open();
                Text = "Claw Controller - Connected";
                btnConnect.Text = "Disconnect";
            }
            catch (Exception er)
            {
                MessageBox.Show($"Error when connection to device: {er.Message}", "Connection Error");
            }
        }

        private void Disconnect()
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                    serialPort.Close();
                serialPort.Dispose();
                Text = "Claw Controller - Disconnected";
                btnConnect.Text = "Connect";
            }
        }

        private void SendPositionMessage(ArmPosition position)
        {
            if (serialPort == null || !serialPort.IsOpen) return;
            serialPort.Write(position.GetStringCommand(chkBxPrecisionSignal.Checked));
        }

        private ArmPosition GetArmPositionFromUI()
        {
            var pos = new ArmPosition();
            pos.ClawPosition = GetServoPositionFromControls(trkBarClaw, chkBxReverseClaw);
            pos.HeightArmPosition = GetServoPositionFromControls(trkBarHeight, chkBxReverseHeight);
            pos.DistanceArmPosition = GetServoPositionFromControls(trkBarDistance, chkBxReverseDistance);
            pos.BasePosition = GetServoPositionFromControls(trkBarBase, chkBxReverseBase);
            return pos;
        }

        private int GetServoPositionFromControls(TrackBar tb, CheckBox cb)
        {
            if (cb.Checked) return 180-tb.Value;
            return tb.Value;
        }

        private void trkBar_Scroll(object sender, EventArgs e)
        {
            SendPositionMessage(GetArmPositionFromUI());
        }

        private void btnCreateKeyFrame_Click(object sender, EventArgs e)
        {
            int idx = lstBoxPath.SelectedIndex + 1;
            if (idx < 0) idx = 0;
            currentPath.Insert(idx, GetArmPositionFromUI());
            ReDrawPathList();
            lstBoxPath.SelectedIndex = idx;
        }

        private void ReDrawPathList()
        {
            lstBoxPath.Items.Clear();
            currentPath.ForEach(p => lstBoxPath.Items.Add(p));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentPath.Clear();
            ReDrawPathList();
        }

        private string btnPlayPauseOriginalText;
        int currentPlayPosition = 0;
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (btnPlayPause.Text == btnPlayPauseOriginalText)
            {
                playbackPathTimer.Interval = PlaybackFrequency;
                btnPlayPause.Text = "PAUSE";

                if (chkbBxInterpolate.Checked)
                {
                    interpolationTimer.Interval = InterpolationFrequency;
                    if (interpolationTimer.Interval < ((playbackPathTimer.Interval / 2) + 1))
                        interpolationTimer.Start();
                }

                SetControlsEnabled(false);
                PlaybackPathTimer_Tick(null, null);
                playbackPathTimer.Start();
            }
            else
            {
                SetControlsEnabled(true);

                playbackPathTimer.Stop();
                interpolationTimer.Stop();
                btnPlayPause.Text = btnPlayPauseOriginalText;
            }
        }

        private void SetControlsEnabled(bool IsEnabled)
        {
            btnAutoGenKeyFrame.Enabled = IsEnabled;
            btnCreateKeyFrame.Enabled = IsEnabled;
            btnClear.Enabled = IsEnabled;
            btnLoad.Enabled = IsEnabled;
            trkBarBase.Enabled = IsEnabled;
            trkBarClaw.Enabled = IsEnabled;
            trkBarDistance.Enabled = IsEnabled;
            trkBarHeight.Enabled = IsEnabled;
        }

        private int interpolationFrameIndex = 0;
        private int interpolationRunTime = 0;
        private int pathCommandRunTime = 0;
        private void InterpolationTimer_Tick(object sender, EventArgs e)
        {
            interpolationStopWatch.Restart();
            var currentPos = (currentPlayPosition - 1);
            if (currentPos >= currentPath.Count)
                currentPos = (currentPath.Count - 1);

            var lastPos = currentPath[currentPos];
            currentPos++;

            int calculatedInterpolationFrequency = InterpolationFrequency + interpolationRunTime;
            double frames = Convert.ToDouble(PlaybackFrequency - pathCommandRunTime) / Convert.ToDouble(calculatedInterpolationFrequency) - 1;
            interpolationTimer.Interval = calculatedInterpolationFrequency;
            int frameIdx = interpolationFrameIndex;
            ArmPosition nextPos;
            if (currentPos >= currentPath.Count)
                nextPos = currentPath[0];
            else
                nextPos = currentPath[currentPos];
            
            var interpolatedFrame = Interpolate(frameIdx, frames, lastPos, nextPos);
            SendPositionMessage(interpolatedFrame);
            Debug.WriteLine($"Sent *interpolated* frame position: {interpolatedFrame.ToString()};    ({frames:n0} frames - index {frameIdx})");
            interpolationFrameIndex++;
            interpolationStopWatch.Stop();
            interpolationRunTime = Convert.ToInt32(interpolationStopWatch.ElapsedMilliseconds);
        }

        private ArmPosition Interpolate(int index, double frames, ArmPosition prevKey, ArmPosition nextKey)
        {
            double baseDif = nextKey.BasePosition - prevKey.BasePosition;
            double clawDif = nextKey.ClawPosition - prevKey.ClawPosition;
            double heightDif = nextKey.HeightArmPosition - prevKey.HeightArmPosition;
            double distanceDif = nextKey.DistanceArmPosition - prevKey.DistanceArmPosition;

            return new ArmPosition() {
                BasePosition = (baseDif / frames) * index + prevKey.BasePosition,
                ClawPosition = (clawDif / frames) * index + prevKey.ClawPosition,
                HeightArmPosition = (heightDif / frames) * index + prevKey.HeightArmPosition,
                DistanceArmPosition = (distanceDif / frames) * index + prevKey.DistanceArmPosition
            };
        }

        private void PlaybackPathTimer_Tick(object sender, EventArgs e)
        {
            playbackPathTimer.Interval = PlaybackFrequency;
            playbackStopWatch.Restart();
            interpolationFrameIndex = 1;
            if (currentPlayPosition >= currentPath.Count)
                currentPlayPosition = 0;

            SendPositionMessage(currentPath[currentPlayPosition]);
            Debug.WriteLine("Sent KEY frame position: " + currentPath[currentPlayPosition].ToString());
            lstBoxPath.SelectedIndex = currentPlayPosition;
            currentPlayPosition++;

            if (chkbBxInterpolate.Checked)
            {
                interpolationTimer.Stop();
                interpolationTimer.Start();
            }
            playbackStopWatch.Stop();
            pathCommandRunTime = Convert.ToInt32(playbackStopWatch.ElapsedMilliseconds);
        }

        private string btnAutoGenKeyFrameOriginalText;
        private void btnAutoGenKeyFrame_Click(object sender, EventArgs e)
        {
            if (btnAutoGenKeyFrame.Text == btnAutoGenKeyFrameOriginalText)
            {
                autoKeyFrameTimer.Interval = AutoKeyFrequency;

                btnAutoGenKeyFrame.Text = "STOP";
                btnCreateKeyFrame_Click(null, null);
                autoKeyFrameTimer.Start();
            }
            else
            {
                autoKeyFrameTimer.Stop();
                btnAutoGenKeyFrame.Text = btnAutoGenKeyFrameOriginalText;
            }
        }
                     

        private void lstBoxPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxPath.SelectedItem != null && lstBoxPath.SelectedItem is ArmPosition)
            {
                ArmPosition armPos = (ArmPosition)lstBoxPath.SelectedItem;
                trkBarBase.Value = Convert.ToInt32(armPos.BasePosition);
                trkBarClaw.Value = Convert.ToInt32(armPos.ClawPosition);
                trkBarDistance.Value = Convert.ToInt32(armPos.DistanceArmPosition);
                trkBarHeight.Value = Convert.ToInt32(armPos.HeightArmPosition);

                if (!playbackPathTimer.IsRunning)
                    SendPositionMessage(armPos);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.ShowDialog();
            if (!string.IsNullOrEmpty(saveFileDialogMain.FileName))
            {
                System.IO.File.WriteAllLines(saveFileDialogMain.FileName, currentPath.ConvertAll(p => p.GetStringCommand(chkBxPrecisionSignal.Checked)).ToArray());
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialogMain.FileName) && System.IO.File.Exists(openFileDialogMain.FileName))
            {
                string[] paths = System.IO.File.ReadAllLines(openFileDialogMain.FileName);
                currentPath.Clear();
                foreach (string path in paths)
                {
                    currentPath.Add(new ArmPosition(path));
                }
                ReDrawPathList();
            }
                
        }

        private void lstBoxPath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selLoc = lstBoxPath.SelectedIndex;
                currentPath.RemoveAt(selLoc);
                ReDrawPathList();

                if (lstBoxPath.Items.Count > 0 && selLoc >= 0)
                {
                    if (selLoc >= lstBoxPath.Items.Count && selLoc > 0)
                        selLoc--;

                    lstBoxPath.SelectedIndex = selLoc;
                }
            }
        }

        private void AutoKeyFrameTimer_Tick(object sender, EventArgs e)
        {
            btnCreateKeyFrame_Click(null, null);
        }

        private void trckBrAutoKeyFrequency_Scroll(object sender, EventArgs e)
        {
            txtBxAutoKeyFrequency.Text = trkAutoKeyFrequency.Value.ToString();
            trkPlaybackFrequency.Value = trkAutoKeyFrequency.Value;
            trkPlaybackFrequency_Scroll(null, null);
        }

        private void txtBxAutoKeyFrequency_Validating(object sender, CancelEventArgs e)
        {
            SyncTextBoxAndTrackBar(trkAutoKeyFrequency, txtBxAutoKeyFrequency);
        }

        private void trkPlaybackFrequency_Validating(object sender, CancelEventArgs e)
        {
            SyncTextBoxAndTrackBar(trkPlaybackFrequency, txtBxPlaybackFrequency);
        }

        private void trkPlaybackFrequency_Scroll(object sender, EventArgs e)
        {
            txtBxPlaybackFrequency.Text = trkPlaybackFrequency.Value.ToString();
        }

        private void ckbBxInterpolate_CheckedChanged(object sender, EventArgs e)
        {
            trkInterpolationFrequency.Enabled = chkbBxInterpolate.Checked;
            txtBxInterpolationFrequency.Enabled = chkbBxInterpolate.Checked;
        }

        private void txtBxInterpolationFrequency_Validating(object sender, CancelEventArgs e)
        {
            SyncTextBoxAndTrackBar(trkInterpolationFrequency, txtBxInterpolationFrequency);
        }

        private void trkInterpolationFrequency_Scroll(object sender, EventArgs e)
        {
            txtBxInterpolationFrequency.Text = trkInterpolationFrequency.Value.ToString();
        }

        private void SyncTextBoxAndTrackBar(TrackBar trakbar, TextBox textbox)
        {
            try
            {
                int val = Convert.ToInt32(textbox.Text);

                if (val > trakbar.Maximum) val = trakbar.Maximum;
                if (val < trakbar.Minimum)
                {
                    val = trakbar.Minimum;
                    textbox.Text = val.ToString();
                }
                trakbar.Value = val;
            }
            catch { }
        }
    }
    
}
