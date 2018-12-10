using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace Exam.Objective3_4
{
    class CreatingAndMappingCompilerDirectives
{

    public class DebugAnApplication
    {

        //#warning This code is obsolete
        //#if DEBUG
        //#error Debug build is not allowed
        //#endif

#line 200 "OtherFileName"
        int a; // line 200
#line default
        int b; //line 4
#line hidden
        int c; //hidden
        int d; //line 7

        public System.Reflection.Assembly LoadAssembly<T>()
        {
#if !WINRT
               Assembly assembly = typeof(T).Assembly;
#else
            Assembly assembly = typeof(T).GetTypeInfo().Assembly;   
#endif
#pragma warning disable
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore

#pragma warning disable 0162, 0168
            int i;
#pragma warning restore 0162
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore

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


        public static void SomeMethod()
        {
#if DEBUG
            Log("Step1");
#endif
        }

        private static void Log(string message)
        {
            Console.WriteLine(message);
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

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class LogDerived : DebugAnApplication
    {
        [Conditional("DEBUG")]
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

}
}
