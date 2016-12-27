// AccurateTimer.cs
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClawController
{
    class AccurateTimer
    {
        private delegate void TimerEventDel(int id, int msg, IntPtr user, int dw1, int dw2);
        private const int TIME_PERIODIC = 1;
        private const int EVENT_TYPE = TIME_PERIODIC;// + 0x100;  // TIME_KILL_SYNCHRONOUS causes a hang ?!
        [DllImport("winmm.dll")]
        private static extern int timeBeginPeriod(int msec);
        [DllImport("winmm.dll")]
        private static extern int timeEndPeriod(int msec);
        [DllImport("winmm.dll")]
        private static extern int timeSetEvent(int delay, int resolution, TimerEventDel handler, IntPtr user, int eventType);
        [DllImport("winmm.dll")]
        private static extern int timeKillEvent(int id);

        Form _mForm;
        private int _mTimerId;
        private TimerEventDel mHandler;  // NOTE: declare at class scope so garbage collector doesn't release it!!!

        public EventHandler Tick { get; set; }

        private int _delay = 1000;
        bool _updateTimerInterval = false;
        public bool IsRunning { private set; get; }

        public int Interval {
            get { return _delay; }
            set {
                _delay = value;
                _updateTimerInterval = true;
            }
        }

        public AccurateTimer(Form form)
        {
            _mForm = form;
        }

        public AccurateTimer(Form form, int delay)
        {
            _mForm = form;
            _delay = delay;
        }

        public void Start()
        {
            timeBeginPeriod(1);
            mHandler = new TimerEventDel(TimerCallback);

            _updateTimerInterval = false;
            IsRunning = true;
            _mTimerId = timeSetEvent(_delay, 0, mHandler, IntPtr.Zero, EVENT_TYPE);
            
        }

        public void Stop()
        {
            int err = timeKillEvent(_mTimerId);
            IsRunning = false;
            timeEndPeriod(1);

            // Ensure callbacks are drained
            System.Threading.Thread.Sleep(100);
        }

        private void TimerCallback(int id, int msg, IntPtr user, int dw1, int dw2)
        {
            if (_mTimerId != 0)
            {
                _mForm.BeginInvoke(Tick);
                if (_updateTimerInterval)
                {
                    int err = timeKillEvent(_mTimerId);
                    Start();
                }
            }
        }
    }
}