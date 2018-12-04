using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective1_5
{
    class HandlingExceptions
    {
        //Listing 1-88 Parsing an invailid number
        public static void ParsingAnInvailidNumber()
        {
            string s = "Hello";
            int i = int.Parse(s);
        }

        // Listing 1-92 Using Environment.FailFast
        public static void UsingEnvironmentFailFast()
        {
            string s = Console.ReadLine();
            try
            {
                int i = int.Parse(s);
                if (i == 42)
                {
                    Environment.FailFast("Special number entered");
                }
            }
            finally
            {
                Console.WriteLine("Program Complete."); ;
            }
        }

    }
}
