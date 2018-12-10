#define MySymbol
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace Exam.Objective3_1
{
    public class UsingParseTryParseAndConvert
    {
        // Listing 3-4 Using Parse
        public static void UsingParse()
        {
            string value = "true";
            bool b = bool.Parse(value);
            Console.WriteLine(b);
        }

        //Listing 3-5 Using TryParse
        public static void UsingTryPase()
        {
            string value = "1";
            int result;
            bool success = int.TryParse(value, out result);
            if (success)
            {
                Console.WriteLine($"Value is a valid Integer {value}");
            }
            else
            {
                Console.WriteLine();
            }
        }

        // Listing 3-6 Using configuration options when parsing a number
        public static void UsingConfigurationOptionsWhenParsingNumber()
        {
            CultureInfo english = new CultureInfo("En");
            CultureInfo dutch = new CultureInfo("Nl");

            string value = "$19,50";
            decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);
            Console.WriteLine(d.ToString(english));
        }

        //Listing 3-8 Using Convert to convert from double to int
        public static void UsingConvertToConvertFromDoubleToInt()
        {
            double d = 23.45;
            int i = Convert.ToInt32(d);
            Console.WriteLine($"i is now an int with a value of : {i}");
        }
    }
}
