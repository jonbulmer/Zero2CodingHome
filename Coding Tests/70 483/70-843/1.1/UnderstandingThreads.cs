﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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

        //Listing 1-7 Queuing some work to the Thread pool
        public static void QueuingThreadpool()
        {
            ThreadPool.QueueUserWorkItem((s) =>
                {
                    Console.WriteLine("Working on a thread on the ThreadPool");
                });
            Console.ReadLine();
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

    public class TaskDemos
    {

        //listing 1-8 Starting a new Task
        public static void NewTask()
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("*");
                }
            });
            t.Wait();
        }

        public static void StartThreadMethod1_8()
        {
            Task t = Task.Run(action: ThreadMethod1_8);

            t.Wait();
        }

        public static void ThreadMethod1_8()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("*");
            }
        }

        // Listing 1-9 using a Task that returns a value
        public static void UsingTaskReturnValue()
        {
            Task<int> t = Task.Run(() =>
                {
                    return 42;
                });
            Console.WriteLine(t.Result);
        }

        // Listing 1-10 Adding Continuation
        public static void AddingContinuation()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
                {
                    return i.Result * 2;
                });
            Console.WriteLine(t.Result);

            t.ContinueWith((i) =>
                {
                    return i.Result * 2;
                });
            Console.WriteLine(t.Result);

            t = t.ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result);
        }

        // Listing 1-11 Scheduling different continuation tasks
        public static void SchedulingDifferentContinuationTasks()
        {
            Task<int> t = Task.Run(() =>
                {
                    return 42;
                });
            t.ContinueWith((i) =>
                {
                    Console.WriteLine("Faulted");
                },TaskContinuationOptions.OnlyOnFaulted);
        }

        public class TaskContinuationOption
        {
            //Listing 1-12 Attaching child task to parent task
            public static void AttachingChildToParentTask()
            {
                Task<Int32[]> parent = Task.Run(() =>
                {
                    var result = new Int32[3];
                    new Task(() => result[0] = 0,
                        TaskCreationOptions.AttachedToParent).Start();
                    new Task(() => result[1] = 1,
                         TaskCreationOptions.AttachedToParent).Start();
                    new Task(() => result[2] = 2,
                         TaskCreationOptions.AttachedToParent).Start();

                    return result;
                });

                var finalTask = parent.ContinueWith(
                    parentTask => {
                        foreach(int i in parentTask.Result)
                            Console.WriteLine(i);
                    });

                finalTask.Wait();
            }

            //Listing 1-13 Using a TaskFactory 
            public static void UsingTaskFactory()
            {
                Task<Int32[]> parent = Task.Run(() =>
                {
                    var result = new Int32[3];
                    TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                        TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => result[0] = 0);
                tf.StartNew(() => result[1] = 1);
                tf.StartNew(() => result[2] = 2);
                
                return result;
                });

                var finalTask = parent.ContinueWith(
                    parentTask => {
                        foreach (int i in parentTask.Result)
                            Console.WriteLine(i);
                    });

                finalTask.Wait();
            }
        }

        // Listing 1-14 Using Task.WaitAll
        public static void UsingTaskWaitAll()
        {
            Task[] tasks = new Task[3];

            tasks[0] =  Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("1");
                    return 1;
                });
            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 1;
            });
            tasks[3] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 1;
            });
            Task.WaitAll();
        }

        // Listing 1-15 Using Task.WaitAny
        public static void UsingTaskWaitAny()
        {
            Task<int>[] tasks = new Task<int>[3];
            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(2000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(2000); return 3; });

            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];
                Console.WriteLine(completedTask.Result);
                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }
        }
    }



}
