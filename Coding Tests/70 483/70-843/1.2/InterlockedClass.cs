using System.Threading;
using System.Threading.Tasks;
using System;

namespace Exam.Objective1_2
{
    public static class InterlockedClass
    {
        // Listing 1-40 Using the Interlocked class
        public static void UsingTheInterlockedClass()
        {
            int n = 0;
            Task myTask = Task.Run(() =>
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        Interlocked.Increment(ref n);
                    }
                });
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Decrement(ref n);
            }
            myTask.Wait();
            Console.WriteLine(n);
        }

        static int value = 1;
        //Listing 1-41 Compare and exchange as a nonatomic operation
        public static void CompareAndExchangeAsNonatomicOperation()
        {
            Task t1 = Task.Run(() =>
                {
                    // To avoid this use
                    //Interlocked.CompareExchange(ref value,newValue,compareTo);
                    if (value == 1)
                    {
                        Thread.Sleep(1000);
                        value = 2;
                    }
                });

            Task t2 = Task.Run(() =>
               {
                   value = 3;
               });
            Task.WaitAll(t1, t2);
            Console.WriteLine(value); // displays 2
        }
    }
}
