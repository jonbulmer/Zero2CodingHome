using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Objective1_2
{
    class ManageMultithreading
    {
        //Listing 1-35 Accessing shared data in a multithreaded application
        /// <summary>
        /// Non atomic
        /// </summary>
        public static void AccessingSharedDataInMultithreadedApplication()
        {
            int n = 0;
            Task myTask = Task.Run(() =>
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        n++;
                    }
                });
            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }

            myTask.Wait(n);
            Console.WriteLine(n);
        }

        // Listing 1-36 Using the lock keyword
        public static void UsingTheLockKeyword()
        {
            int n = 0;

            object _lock = new object();

            Task myTask = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock (_lock)
                    {
                        n++;
                    }
                }
            });
            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                {
                    n--;
                }
            }

            myTask.Wait(n);
            Console.WriteLine(n);
        }

        // Listing 1-37 Creating a deadlock
        public static void CreatingDeadlock()
        {
            object lockA = new object();
            object lockB = new object();

            Task myTask = Task.Run(() =>
               {
                   lock (lockA)
                   {;
                       lock (lockB)
                       {
                           Console.WriteLine("Locked A and B");
                       }
                   }
               });
            lock (lockB)
            {
                Thread.Sleep(1000);
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }
            myTask.Wait();
        }

        // Listing 1-38 Generated code from a lock statment
        public static void GeneratedCodeFromLockStatment()
        {
            object gate = new object();
            bool __lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref __lockTaken);
            }
            finally
            {
                if (__lockTaken)
                {
                    Monitor.Exit(gate);
                }
            }
        }


        class Volatile
        {
            // Listing 1-39 A potential problem with multithreaded code

            private static int _flag = 0;
            private static volatile int _value = 0;

            public static void Thread1()
            {
                _value = 5;
                _flag = 1;
            }

            public static void Thread2()
            {
                if (_flag == 1)
                {
                    Console.WriteLine(_value);
                }
            }
    }
    }
}
