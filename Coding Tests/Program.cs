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
            //GeneralProblems.Palindrom.PalindromCheck("racecar");
            //GeneralProblems.Problems.GeneralProblems1();
            //string input = "aaabbbbcdeeffggggg";
            //StringConverter stringConvert = new StringConverter();

            //Console.WriteLine(stringConvert.ConvertString(input)); 


            //  var chicken1 = new ChickenEgg.Chicken();
            //  var egg = chicken1.Lay();
            //  var childChicken = egg.Hatch();
            //  var childChicken2 = egg.Hatch();
            //GeneralProblems.TextInput input = new GeneralProblems.NumericInput();
            //input.Add('1');
            //input.Add('a');
            //input.Add('0');
            //Console.WriteLine(input.GetValue());
            //Tuple<int, int> indices = GeneralProblems.TwoSum.FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            //if (indices != null)
            //{
            //    Console.WriteLine(indices.Item1 + " " + indices.Item2);
            //}

            GeneralProblems.TrainComposition buildTrain = new GeneralProblems.TrainComposition();
            buildTrain.AttachWagonFromLeft(7);
            buildTrain.AttachWagonFromLeft(13);
            Console.WriteLine(buildTrain.DetachWagonFromRight()); // 7 
            Console.WriteLine(buildTrain.DetachWagonFromLeft()); // 13

            Console.WriteLine(GeneralProblems.SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));

            Console.ReadKey();
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
