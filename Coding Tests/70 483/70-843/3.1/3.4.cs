#define MySymbol
using System;
using System.Reflection;
using System.Threading;

namespace Exam.Objective3_4
{

    class DebugAnApplication
    {

        public Assembly LoadAssembly<T>()
        {
#if !WINRT
            Assembly assembly = typeof(T).Assembly;
#else
            Assembly assembly = typeof(T).GetTypeInfo().Assembly;   
#endif

        return assembly;
        }

        public static void UseCustomSymbol()
        {
#if MySymbol
            Console.WriteLine("Custom symbol is defined");
#endif
        }

        public static void MainCall()
        {
            Timer t = new Timer(TimerCallback, null, 0, 2000);
            Console.ReadLine();
        }


        /// <summary>
        /// This code demonstrates the difference on how Debug and relise 
        /// handle a build.
        /// In debug mode the Timer fires every 2 mins
        /// In relise mode the complier will only once.
        /// </summary>
        public static void TimerCallback(Object o)
        {
            Console.WriteLine("In TimerCallback: " + 
                DateTime.Now);
            GC.Collect();
        }

        public void DebugDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else
            Console.WriteLine("Not Debug");
#endif
        }


    }
}
