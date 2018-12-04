using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective1_3
{
    class IteratingAcrossCollections
    {
        // Listing 1-64 basicfor loop 
        public static void BasicLoop()
        {
            int[] values = { 1,2,3,4,5,6 };
            for (int index = 0; index < values.Length; index++)
            {
                Console.WriteLine(values[index]);
            }
        }

        // Listing 1-68 A for loop with a continue statement
        public static void ForLoopWithContinueStatement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index++)
            {
                if (values[i] == 4)
                {
                    continue;
                }
                Console.WriteLine(values[index]);
            }
        }

    }
}
