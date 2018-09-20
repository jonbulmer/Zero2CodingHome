/*
Anonymous
Write a function that, when passed a list and a target sum, returns two distinct zero-based indices of any two of
the numbers, whose sum is equal to the target sum.If there are no two numbers, the function should return  null.

For example, FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10) should return a Tuple<int, int> containing any 

0 = 3
1 = 1
2 = 5
3 = 7
4 = 5
5 = 9

of the following pairs of indices:

0 and 3 (or 3 and 0) as 3 + 7 = 10
1 and 5 (or 5 and 1) as 1 + 9 = 10
2 and 4 (or 4 and 2) as 5 + 5 = 10

 */


using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneralProblems
{
    class TwoSum
    {

        public static Tuple<int, int> FindTwoSum_Ian(List<int> input, int Sum)
        {
            // output all elements of the the lists that can be fit into the list of tuple
            var listOfAllCombos = input.SelectMany(i => input.Select(j => new Tuple<int, int>(i, j)));
            //populate the first instance that equals sum  
            var firstEqualTen = listOfAllCombos.FirstOrDefault(t => t.Item1 + t.Item2 == 10);
            // and return
            return firstEqualTen;
        }

        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            // loop through list when x + y = sum add the values to the tuple and return
            int x;
            int y;
            for (int i = 0; i < list.Count - 1; i++)
            {
                x = list[i];
                for (int j = i + 1; j < list.Count; j++)
                {
                    y = list[j];
                    if ((x + y) == sum)
                    {
                        var result = new Tuple<int, int>(x, y);
                        return result;
                    }

                }
            }
            //if we are out the loop with no result return null if you can do that with a tuple 
            return null;
        }
    }
}