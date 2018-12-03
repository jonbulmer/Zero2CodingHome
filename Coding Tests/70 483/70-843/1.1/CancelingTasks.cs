using System;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Objective1_2
{
    public static class CancelingTasks
    {

        // Listing 1-42 Using a CancellationTocken
        public static void UsingCancellationTocken()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task myTask = Task.Run(() =>
               {
                   while (!token.IsCancellationRequested)
                   {
                       Console.Write("*");
                       Thread.Sleep(1000);
                   }
               }, token);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();

            Console.WriteLine("Press enter to end the program");
            Console.ReadLine();
        }
    }
}
