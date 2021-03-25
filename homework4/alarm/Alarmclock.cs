using System;
namespace alarm
{
    public delegate void TickHandler(object sender, Alarmclock.TimeArgs tickArgs);

    public delegate void AlarmHandler(object sender, Alarmclock.TimeArgs eventArgs);
    public class Alarmclock
    {
        public event TickHandler Tick;
        public event AlarmHandler Alarm;
        public Alarmclock()
        {

        }
        private void OnTick(TimeArgs tickArgs)
        {
            Tick?.Invoke(this, tickArgs);
        }

        public void Start(TimeArgs timeArgs)
        {
            //获取当前时间
            DateTime now = DateTime.Now;
            var eventArgs = new TimeArgs(now.Hour, now.Minute, now.Second);

            while (true)
            {
                eventArgs.Seconds++;
                OnTick(eventArgs);


            }
        }
        public class TimeArgs : EventArgs
        {
            private int hours;
            private int minutes;
            private int seconds;

            public TimeArgs(int hour, int minute, int second)
            {
                hours = hour;
                minutes = minute;
                seconds = second;
            }

            public TimeArgs()
            {
            }

            public int Hours
            {
                get => hours;
                set
                {
                    hours = value;
                    if (hours == 24)
                    {
                        hours = 0;
                    }
                }
            }


            public int Minutes
            {
                get => minutes;
                set
                {
                    minutes = value;
                    if (minutes != 60) return;
                    minutes = 0;
                    Hours++;
                }
            }


            public int Seconds
            {
                get => seconds;
                set
                {
                    seconds = value;
                    if (seconds != 60) return;
                    seconds = 0;
                    Minutes++;
                }
            }

            public override bool Equals(object obj)
            {
                TimeArgs timeArgs = obj as TimeArgs;
                if (timeArgs == null)
                {
                    return false;
                }

                return Hours == timeArgs.Hours &&
                       Minutes == timeArgs.Minutes &&
                       Seconds == timeArgs.Seconds;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Hours, Minutes, Seconds);
            }
        }
    }
}