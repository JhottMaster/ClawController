namespace ClawController
{
    partial class ClawControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBxPrecisionSignal = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbBxRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBxPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trkBarBase = new System.Windows.Forms.TrackBar();
            this.trkBarDistance = new System.Windows.Forms.TrackBar();
            this.trkBarHeight = new System.Windows.Forms.TrackBar();
            this.chkBxReverseBase = new System.Windows.Forms.CheckBox();
            this.chkBxReverseDistance = new System.Windows.Forms.CheckBox();
            this.chkBxReverseHeight = new System.Windows.Forms.CheckBox();
            this.chkBxReverseClaw = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trkBarClaw = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBxAutoKeyFrequency = new System.Windows.Forms.TextBox();
            this.trkAutoKeyFrequency = new System.Windows.Forms.TrackBar();
            this.btnCreateKeyFrame = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAutoGenKeyFrame = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkbBxInterpolate = new System.Windows.Forms.CheckBox();
            this.txtBxInterpolationFrequency = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.trkInterpolationFrequency = new System.Windows.Forms.TrackBar();
            this.txtBxPlaybackFrequency = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trkPlaybackFrequency = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.lstBoxPath = new System.Windows.Forms.ListBox();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarClaw)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkAutoKeyFrequency)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkInterpolationFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPlaybackFrequency)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkBxPrecisionSignal);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cmbBxRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBxPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            // 
            // chkBxPrecisionSignal
            // 
            this.chkBxPrecisionSignal.AutoSize = true;
            this.chkBxPrecisionSignal.Location = new System.Drawing.Point(408, 26);
            this.chkBxPrecisionSignal.Name = "chkBxPrecisionSignal";
            this.chkBxPrecisionSignal.Size = new System.Drawing.Size(101, 17);
            this.chkBxPrecisionSignal.TabIndex = 6;
            this.chkBxPrecisionSignal.Text = "Precision Signal";
            this.chkBxPrecisionSignal.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(534, 23);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbBxRate
            // 
            this.cmbBxRate.FormattingEnabled = true;
            this.cmbBxRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800"});
            this.cmbBxRate.Location = new System.Drawing.Point(270, 24);
            this.cmbBxRate.Name = "cmbBxRate";
            this.cmbBxRate.Size = new System.Drawing.Size(100, 21);
            this.cmbBxRate.TabIndex = 3;
            this.cmbBxRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate:";
            // 
            // cmbBxPort
            // 
            this.cmbBxPort.FormattingEnabled = true;
            this.cmbBxPort.Location = new System.Drawing.Point(41, 24);
            this.cmbBxPort.Name = "cmbBxPort";
            this.cmbBxPort.Size = new System.Drawing.Size(121, 21);
            this.cmbBxPort.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.trkBarBase);
            this.groupBox2.Controls.Add(this.trkBarDistance);
            this.groupBox2.Controls.Add(this.trkBarHeight);
            this.groupBox2.Controls.Add(this.chkBxReverseBase);
            this.groupBox2.Controls.Add(this.chkBxReverseDistance);
            this.groupBox2.Controls.Add(this.chkBxReverseHeight);
            this.groupBox2.Controls.Add(this.chkBxReverseClaw);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.trkBarClaw);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 224);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // trkBarBase
            // 
            this.trkBarBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkBarBase.Location = new System.Drawing.Point(64, 171);
            this.trkBarBase.Maximum = 180;
            this.trkBarBase.Name = "trkBarBase";
            this.trkBarBase.Size = new System.Drawing.Size(468, 45);
            this.trkBarBase.TabIndex = 14;
            this.trkBarBase.Value = 90;
            this.trkBarBase.Scroll += new System.EventHandler(this.trkBar_Scroll);
            // 
            // trkBarDistance
            // 
            this.trkBarDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkBarDistance.Location = new System.Drawing.Point(64, 120);
            this.trkBarDistance.Maximum = 180;
            this.trkBarDistance.Name = "trkBarDistance";
            this.trkBarDistance.Size = new System.Drawing.Size(468, 45);
            this.trkBarDistance.TabIndex = 13;
            this.trkBarDistance.Value = 90;
            this.trkBarDistance.Scroll += new System.EventHandler(this.trkBar_Scroll);
            // 
            // trkBarHeight
            // 
            this.trkBarHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkBarHeight.Location = new System.Drawing.Point(64, 69);
            this.trkBarHeight.Maximum = 180;
            this.trkBarHeight.Name = "trkBarHeight";
            this.trkBarHeight.Size = new System.Drawing.Size(466, 45);
            this.trkBarHeight.TabIndex = 12;
            this.trkBarHeight.Value = 90;
            this.trkBarHeight.Scroll += new System.EventHandler(this.trkBar_Scroll);
            // 
            // chkBxReverseBase
            // 
            this.chkBxReverseBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBxReverseBase.AutoSize = true;
            this.chkBxReverseBase.Location = new System.Drawing.Point(538, 177);
            this.chkBxReverseBase.Name = "chkBxReverseBase";
            this.chkBxReverseBase.Size = new System.Drawing.Size(66, 17);
            this.chkBxReverseBase.TabIndex = 11;
            this.chkBxReverseBase.Text = "Reverse";
            this.chkBxReverseBase.UseVisualStyleBackColor = true;
            this.chkBxReverseBase.CheckedChanged += new System.EventHandler(this.trkBar_Scroll);
            // 
            // chkBxReverseDistance
            // 
            this.chkBxReverseDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBxReverseDistance.AutoSize = true;
            this.chkBxReverseDistance.Location = new System.Drawing.Point(538, 128);
            this.chkBxReverseDistance.Name = "chkBxReverseDistance";
            this.chkBxReverseDistance.Size = new System.Drawing.Size(66, 17);
            this.chkBxReverseDistance.TabIndex = 10;
            this.chkBxReverseDistance.Text = "Reverse";
            this.chkBxReverseDistance.UseVisualStyleBackColor = true;
            this.chkBxReverseDistance.CheckedChanged += new System.EventHandler(this.trkBar_Scroll);
            // 
            // chkBxReverseHeight
            // 
            this.chkBxReverseHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBxReverseHeight.AutoSize = true;
            this.chkBxReverseHeight.Location = new System.Drawing.Point(536, 77);
            this.chkBxReverseHeight.Name = "chkBxReverseHeight";
            this.chkBxReverseHeight.Size = new System.Drawing.Size(66, 17);
            this.chkBxReverseHeight.TabIndex = 9;
            this.chkBxReverseHeight.Text = "Reverse";
            this.chkBxReverseHeight.UseVisualStyleBackColor = true;
            this.chkBxReverseHeight.CheckedChanged += new System.EventHandler(this.trkBar_Scroll);
            // 
            // chkBxReverseClaw
            // 
            this.chkBxReverseClaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBxReverseClaw.AutoSize = true;
            this.chkBxReverseClaw.Location = new System.Drawing.Point(536, 23);
            this.chkBxReverseClaw.Name = "chkBxReverseClaw";
            this.chkBxReverseClaw.Size = new System.Drawing.Size(66, 17);
            this.chkBxReverseClaw.TabIndex = 8;
            this.chkBxReverseClaw.Text = "Reverse";
            this.chkBxReverseClaw.UseVisualStyleBackColor = true;
            this.chkBxReverseClaw.CheckedChanged += new System.EventHandler(this.trkBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Base:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Claw:";
            // 
            // trkBarClaw
            // 
            this.trkBarClaw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkBarClaw.Location = new System.Drawing.Point(64, 18);
            this.trkBarClaw.Maximum = 180;
            this.trkBarClaw.Name = "trkBarClaw";
            this.trkBarClaw.Size = new System.Drawing.Size(468, 45);
            this.trkBarClaw.TabIndex = 0;
            this.trkBarClaw.Value = 90;
            this.trkBarClaw.Scroll += new System.EventHandler(this.trkBar_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 356);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automated Path";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBxAutoKeyFrequency);
            this.groupBox6.Controls.Add(this.trkAutoKeyFrequency);
            this.groupBox6.Controls.Add(this.btnCreateKeyFrame);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.btnAutoGenKeyFrame);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(306, 143);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Path Recording";
            // 
            // txtBxAutoKeyFrequency
            // 
            this.txtBxAutoKeyFrequency.Location = new System.Drawing.Point(238, 51);
            this.txtBxAutoKeyFrequency.Name = "txtBxAutoKeyFrequency";
            this.txtBxAutoKeyFrequency.Size = new System.Drawing.Size(47, 20);
            this.txtBxAutoKeyFrequency.TabIndex = 4;
            this.txtBxAutoKeyFrequency.Text = "2000";
            this.txtBxAutoKeyFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.txtBxAutoKeyFrequency_Validating);
            // 
            // trkAutoKeyFrequency
            // 
            this.trkAutoKeyFrequency.LargeChange = 500;
            this.trkAutoKeyFrequency.Location = new System.Drawing.Point(11, 80);
            this.trkAutoKeyFrequency.Maximum = 5000;
            this.trkAutoKeyFrequency.Minimum = 100;
            this.trkAutoKeyFrequency.Name = "trkAutoKeyFrequency";
            this.trkAutoKeyFrequency.Size = new System.Drawing.Size(274, 45);
            this.trkAutoKeyFrequency.SmallChange = 100;
            this.trkAutoKeyFrequency.TabIndex = 3;
            this.trkAutoKeyFrequency.TickFrequency = 100;
            this.trkAutoKeyFrequency.Value = 2000;
            this.trkAutoKeyFrequency.Scroll += new System.EventHandler(this.trckBrAutoKeyFrequency_Scroll);
            // 
            // btnCreateKeyFrame
            // 
            this.btnCreateKeyFrame.Location = new System.Drawing.Point(11, 19);
            this.btnCreateKeyFrame.Name = "btnCreateKeyFrame";
            this.btnCreateKeyFrame.Size = new System.Drawing.Size(119, 23);
            this.btnCreateKeyFrame.TabIndex = 0;
            this.btnCreateKeyFrame.Text = "Create Keyframe";
            this.btnCreateKeyFrame.UseVisualStyleBackColor = true;
            this.btnCreateKeyFrame.Click += new System.EventHandler(this.btnCreateKeyFrame_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Auto Keyframe creation frequency:";
            // 
            // btnAutoGenKeyFrame
            // 
            this.btnAutoGenKeyFrame.Location = new System.Drawing.Point(136, 19);
            this.btnAutoGenKeyFrame.Name = "btnAutoGenKeyFrame";
            this.btnAutoGenKeyFrame.Size = new System.Drawing.Size(149, 23);
            this.btnAutoGenKeyFrame.TabIndex = 1;
            this.btnAutoGenKeyFrame.Text = "Auto Generate Keyframe";
            this.btnAutoGenKeyFrame.UseVisualStyleBackColor = true;
            this.btnAutoGenKeyFrame.Click += new System.EventHandler(this.btnAutoGenKeyFrame_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.chkbBxInterpolate);
            this.groupBox5.Controls.Add(this.txtBxInterpolationFrequency);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.trkInterpolationFrequency);
            this.groupBox5.Controls.Add(this.txtBxPlaybackFrequency);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.trkPlaybackFrequency);
            this.groupBox5.Location = new System.Drawing.Point(6, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 182);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Path Playback";
            // 
            // chkbBxInterpolate
            // 
            this.chkbBxInterpolate.AutoSize = true;
            this.chkbBxInterpolate.Checked = true;
            this.chkbBxInterpolate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbBxInterpolate.Location = new System.Drawing.Point(14, 99);
            this.chkbBxInterpolate.Name = "chkbBxInterpolate";
            this.chkbBxInterpolate.Size = new System.Drawing.Size(76, 17);
            this.chkbBxInterpolate.TabIndex = 11;
            this.chkbBxInterpolate.Text = "Interpolate";
            this.chkbBxInterpolate.UseVisualStyleBackColor = true;
            this.chkbBxInterpolate.CheckedChanged += new System.EventHandler(this.ckbBxInterpolate_CheckedChanged);
            // 
            // txtBxInterpolationFrequency
            // 
            this.txtBxInterpolationFrequency.Location = new System.Drawing.Point(238, 97);
            this.txtBxInterpolationFrequency.Name = "txtBxInterpolationFrequency";
            this.txtBxInterpolationFrequency.Size = new System.Drawing.Size(47, 20);
            this.txtBxInterpolationFrequency.TabIndex = 10;
            this.txtBxInterpolationFrequency.Text = "100";
            this.txtBxInterpolationFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.txtBxInterpolationFrequency_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Interpolation frequency:";
            // 
            // trkInterpolationFrequency
            // 
            this.trkInterpolationFrequency.LargeChange = 500;
            this.trkInterpolationFrequency.Location = new System.Drawing.Point(11, 126);
            this.trkInterpolationFrequency.Maximum = 1000;
            this.trkInterpolationFrequency.Minimum = 50;
            this.trkInterpolationFrequency.Name = "trkInterpolationFrequency";
            this.trkInterpolationFrequency.Size = new System.Drawing.Size(274, 45);
            this.trkInterpolationFrequency.TabIndex = 9;
            this.trkInterpolationFrequency.TickFrequency = 10;
            this.trkInterpolationFrequency.Value = 100;
            this.trkInterpolationFrequency.Scroll += new System.EventHandler(this.trkInterpolationFrequency_Scroll);
            // 
            // txtBxPlaybackFrequency
            // 
            this.txtBxPlaybackFrequency.Location = new System.Drawing.Point(238, 23);
            this.txtBxPlaybackFrequency.Name = "txtBxPlaybackFrequency";
            this.txtBxPlaybackFrequency.Size = new System.Drawing.Size(47, 20);
            this.txtBxPlaybackFrequency.TabIndex = 7;
            this.txtBxPlaybackFrequency.Text = "2000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Path playback speed: (key frequency)";
            // 
            // trkPlaybackFrequency
            // 
            this.trkPlaybackFrequency.LargeChange = 500;
            this.trkPlaybackFrequency.Location = new System.Drawing.Point(11, 52);
            this.trkPlaybackFrequency.Maximum = 5000;
            this.trkPlaybackFrequency.Minimum = 100;
            this.trkPlaybackFrequency.Name = "trkPlaybackFrequency";
            this.trkPlaybackFrequency.Size = new System.Drawing.Size(274, 45);
            this.trkPlaybackFrequency.SmallChange = 100;
            this.trkPlaybackFrequency.TabIndex = 6;
            this.trkPlaybackFrequency.TickFrequency = 100;
            this.trkPlaybackFrequency.Value = 2000;
            this.trkPlaybackFrequency.Scroll += new System.EventHandler(this.trkPlaybackFrequency_Scroll);
            this.trkPlaybackFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.trkPlaybackFrequency_Validating);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnLoad);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnPlayPause);
            this.groupBox4.Controls.Add(this.lstBoxPath);
            this.groupBox4.Location = new System.Drawing.Point(318, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 331);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Path Information";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(7, 303);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(67, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(228, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(80, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayPause.Location = new System.Drawing.Point(147, 303);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // lstBoxPath
            // 
            this.lstBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxPath.FormattingEnabled = true;
            this.lstBoxPath.Location = new System.Drawing.Point(6, 19);
            this.lstBoxPath.Name = "lstBoxPath";
            this.lstBoxPath.Size = new System.Drawing.Size(285, 277);
            this.lstBoxPath.TabIndex = 1;
            this.lstBoxPath.SelectedIndexChanged += new System.EventHandler(this.lstBoxPath_SelectedIndexChanged);
            this.lstBoxPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstBoxPath_KeyUp);
            // 
            // saveFileDialogMain
            // 
            this.saveFileDialogMain.FileName = "clawPath.txt";
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "clawPath.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 708);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "Form1";
            this.Text = "Claw Controller - Disconnected";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarClaw)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkAutoKeyFrequency)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkInterpolationFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPlaybackFrequency)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbBxRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBxPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkBarClaw;
        private System.Windows.Forms.CheckBox chkBxReverseBase;
        private System.Windows.Forms.CheckBox chkBxReverseDistance;
        private System.Windows.Forms.CheckBox chkBxReverseHeight;
        private System.Windows.Forms.CheckBox chkBxReverseClaw;
        private System.Windows.Forms.TrackBar trkBarBase;
        private System.Windows.Forms.TrackBar trkBarDistance;
        private System.Windows.Forms.TrackBar trkBarHeight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBxAutoKeyFrequency;
        private System.Windows.Forms.TrackBar trkAutoKeyFrequency;
        private System.Windows.Forms.Button btnCreateKeyFrame;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAutoGenKeyFrame;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.ListBox lstBoxPath;
        private System.Windows.Forms.TextBox txtBxPlaybackFrequency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trkPlaybackFrequency;
        private System.Windows.Forms.CheckBox chkbBxInterpolate;
        private System.Windows.Forms.TextBox txtBxInterpolationFrequency;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trkInterpolationFrequency;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.CheckBox chkBxPrecisionSignal;
    }
}

