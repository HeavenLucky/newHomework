using System;

namespace alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarmclock alarm = new Alarmclock();
            alarm.Tick += ShowTime;
            alarm.Alarm += Alarm;
            alarm.Start(new Alarmclock.TimeArgs(2, 33, 2));
          
        }

        private static void ShowTime(object sender, Alarmclock.TimeArgs eventArgs)
        {
            Console.WriteLine("现在的时间是" +
                              $"{eventArgs.Hours}点{eventArgs.Minutes}分{eventArgs.Seconds}秒");
        }

        private static void Alarm(object sender, Alarmclock.TimeArgs eventArgs)
        {
            Console.WriteLine("Alarm");
        }
    

        
    }

}
