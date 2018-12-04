using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam.Objective1_5
{
    class ThrowExceptions
    {
        //Listing 1-94 Throwing an ArgumentNullException
        public static string ThrowingAnArgumentNullException(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("fileName", "Filename is required ");
            }
            return File.ReadAllText(fileName);
        }

        // Listing 1-96 Thowinga new exception that points to the original one
        public static void CallAbove()
        {
            try
            {
                string s = ThrowingAnArgumentNullException(null);
            }
            catch (ArgumentNullException e)
            {

                Console.WriteLine("Arg null ex: " + e.Message); ;
            }
        }
    }
}
