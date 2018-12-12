using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam.Objective2_7
{
    class ManipulatingStrings
{
        // https://www.dotnetperls.com/stringbuilder-capacity
        public static void StringBuilderCapacity()
        {
            using (var writer = new StreamWriter("data.txt"))
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < 256; i++)
                {
                    writer.Write(builder.Capacity);
                    writer.Write(builder.Length);
                    writer.WriteLine();
                    builder.Append("1");
                }
            }
        }
}
}
