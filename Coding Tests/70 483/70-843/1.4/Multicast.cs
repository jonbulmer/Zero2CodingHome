using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective1_4
{
    class MulticastClass
    {
        public delegate void Del();

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            // I can call this as a function
            d();
        }
    }
}
