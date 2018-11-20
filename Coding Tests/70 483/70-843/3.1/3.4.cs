using System;
using System.Threading;

namespace Exam.Objective3_4
{
    /// <summary>
    /// This code demonstrates the difference on how Debug and relise 
    /// handle a build.
    /// In debug mode the Timer fires every 2 mins
    /// In relise mode the complier will only once.
    /// </summary>
    class DebugAnApplication
    {
        public static void MainCall()
        {
            Timer t = new Timer(TimerCallback, null, 0, 2000);
            Console.ReadLine();
        }

        public static void TimerCallback(Object o)
        {
            Console.WriteLine("In TimerCallback: " + 
                DateTime.Now);
            GC.Collect();
        }
    }
}
