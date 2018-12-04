using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective1_4
{
    class UseDelegate
    {
        public delegate int Calculate(int x, int y);

        public int Add(int x, int y)
        {
            return x = y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public UseDelegate()
        {
            Calculate calc = Add;

            Console.WriteLine(calc(3, 4));

            // pointing the calc function at muliply
            calc = Multiply;
            Console.WriteLine(calc(3,4));
        }
    }

    // Listing 1-81 Using the Action delegate
    class UseActionDelegate {
        public UseActionDelegate()
        {
            Action<int, int> calc = (int x, int y) =>
            {
                Console.WriteLine(x + y);
            };
            calc(5, 5);
        }
    }
}
