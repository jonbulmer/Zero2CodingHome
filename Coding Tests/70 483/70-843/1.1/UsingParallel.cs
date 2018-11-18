using System;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Objective1_1
{
    class UsingParallel
    {
        public static void ParallelFor()
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
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
