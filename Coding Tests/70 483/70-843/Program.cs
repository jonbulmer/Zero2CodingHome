using System;
using Exam;

namespace _70_843
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the objective number you want to run:");

            var cki = Console.ReadKey();
            var check_chr = cki.KeyChar;
            switch (check_chr)
            {
                case '1':
                    Exam.Objective1_1.UsingThreads.CallThreadMethod();
                    break;
                case '2':
                case '3':
                    Exam.Objective3_1.WorkingWithEncryption.EncryptSomeText();
                    break;
                case '4':
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
