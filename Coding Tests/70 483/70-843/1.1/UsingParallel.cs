using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Objective1_1
{
    class UsingParallel
    {
        // Listing 1-16 Using Parallel.For and ForEach
        public static void ParallelFor()
        {
            Parallel.For(0, 10, (i) =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
             {
                 Thread.Sleep(1000);
             });
        }

        //Listing 1-17 Using Parallel.Break
        public static void UsingParallelBreak()
        {
            ParallelLoopResult result = Parallel.
                For(0, 1000, (int i, ParallelLoopState loopState) =>
                {
                    if (i == 500)
                    {
                        Console.WriteLine("Breaking loop");
                        loopState.Break();
                    }
                    return;
                });
        }

        public static void ParallelBreak()
        {
            ParallelLoopResult result = Parallel.
                For(0, 1000, (int i, ParallelLoopState
                    loopState) =>
                {
                    if (i == 500)
                    {
                        Console.WriteLine("Breaking loop");
                        loopState.Break();
                    }
                return;
                });
        }

        public static void UsingBackgroundThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(1000);
            }
        }

        public static void CallUsingBackgroundThread()
        {
            Thread t = new Thread(new ThreadStart(UsingBackgroundThread));
            t.IsBackground = true;
            t.Start();
        }
    }
}
