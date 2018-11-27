using System;
using System.Threading;

namespace Exam.Objective1_1
{
    //Listing 1-1 Creating a thread with the Thread class
    public static class UsingThreads
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        public static void CallThreadMethod()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }

            t.Join();
        }

        //Listing 1-3 Using the parametereizedThreadStart
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        public static void CallParamThreadMethod()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(15);
            t.Join();
        }


        //Listing 1-4 Stopping a thread
        public static void StoppingThread()
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
                {
                    while (!stopped)
                    {
                        Console.WriteLine("Running...");
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine("Thread is about to close");
                }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }

        //Listing 1-5 Using the ThreadStaticAttribute
        public static void CallThreadStaticAttibutte()
        {
        }
    }

    //Listing 1-5 Using the ThreadStaticAttribute
    public static class UsingThreadStaticAttribute
    {
        [ThreadStatic]
        public static int _field;

        public static void CallThreadStaticAttibutte()
        {
            Thread t1 = new Thread(new ThreadStart(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        _field++;
                        Console.WriteLine($"Thread A: {_field}");
                    }
                }));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread B: {_field}");
                }
            }));
            t2.Start();
        }
    }
}
