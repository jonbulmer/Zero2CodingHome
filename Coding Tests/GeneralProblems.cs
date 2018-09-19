using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralProblems
{
    class Problems
    {

        public static void GeneralProblems1()
        {
            // I don't know what is happening with /=
            // So after some reading /= with try and dived but if the result is
            // less than 1 it will return 0 to an integer 
            int x = 4, b = 2; x -= b /= x * b;
            Console.WriteLine(x + " " + b);
            Console.ReadLine();
            //output is 4 0
        }
    }
}
