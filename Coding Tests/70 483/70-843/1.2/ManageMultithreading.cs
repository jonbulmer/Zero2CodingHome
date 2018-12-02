using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
