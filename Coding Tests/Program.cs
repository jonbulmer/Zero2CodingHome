using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coeus
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "aaabbbbcdeeffggggg";
            StringConverter stringConvert = new StringConverter();

            Console.WriteLine(stringConvert.ConvertString(input)); 
            Console.ReadKey();

            var chicken1 = new ChickenEgg.Chicken();
            var egg = chicken1.Lay();
            var childChicken = egg.Hatch();
            var childChicken2 = egg.Hatch();

        }

    }

    public class StringConverter
    {
        public string ConvertString(string input)
        {

            StringBuilder output = new StringBuilder();
            // set it all up
            int chrCount = 0;
            var compareLetter = "";
            // loop through all the string 
            foreach (char c in input)
            {
                //GetHashCode the first character
                if (compareLetter == "")
                {
                    compareLetter = c.ToString();
                    chrCount = 1;
                }
                else
                {
                    //if we are just counting add to count and change char 
                    if (c.ToString() == compareLetter)
                    {
                        chrCount = chrCount += 1;
                        compareLetter = c.ToString();
                    }
                    else
                    {
                        //write the output  
                        compareLetter = chrCount == 1 ? compareLetter : chrCount.ToString() + compareLetter;
                        output.Append(compareLetter);
                        // set everything back to start counting
                        compareLetter = c.ToString();
                        chrCount = 1;
                    }
                }
            }
            // Think hard about DRY in this case 2 lines repeated once is ok 
            compareLetter = chrCount == 1 ? compareLetter : chrCount.ToString() + compareLetter;
            output.Append(compareLetter);
            // return the result
            return output.ToString();
        }
    }

}
