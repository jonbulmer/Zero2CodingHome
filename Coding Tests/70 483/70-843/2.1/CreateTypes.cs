using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective2_1
{
    public static class ChoosingTypeToCreate
    {
        public static class ImportanceEnum
        {
            enum Importance
            {
                None,
                Trivial,
                Regular,
                Important,
                Critical
            }

            public static void EnumMain()
            {
                // ... An enum local variable.

                Importance value = Importance.Critical;

                //
                if (value == Importance.Trivial)
                {
                    Console.WriteLine($"You can do this later as it is {value} ");
                }
                else if (value == Importance.Critical)
                {
                    Console.WriteLine($"You must do this now as it is {value} ");
                }
            }
        }
    }

    // Lsting 2-2 Creatinga custom strut
    public struct Point
    {
        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}
}
