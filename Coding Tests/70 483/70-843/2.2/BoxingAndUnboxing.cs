using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective2_2
{
    // Converting a value type to a reference type
    class BoxingAndUnboxing
    {
        // Listing 2-19 Boxing an integer value
        public static void BoxingAnIntegerValue()
        {
            int i = 42;
            object o = i;
            int x = (int)o;

            string.Concat("To box or not box", 42, true);
            string s = "To box or not box" + 42 + true;
        }
    }
}
