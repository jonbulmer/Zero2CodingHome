/*
 Implement function CountNumbers that accepts a sorted array of unique integers and counts the number of 
 array elements that are less than the parameter lessThan.

For example, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2 because there are two 
array elements less than 4.
 */
using System;
namespace GeneralProblems
{
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            int intCount = 0;
            // loop  through the array while the index value < lessThan
            foreach (var item in sortedArray)
            {
                if (item < lessThan)
                {
                    intCount += 1;
                }
                else
                {
                    return intCount;
                }
            }
            return intCount;
        }
    }
}