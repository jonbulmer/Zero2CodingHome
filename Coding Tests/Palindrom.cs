using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralProblems
{
    public class Palindrom
    {
        public static bool PalindromCheck(string wordToCheck)
        {
            wordToCheck = wordToCheck.ToLower();
            int halfWordCount = (int)Math.Floor(wordToCheck.Length / 2f);
            for (int i = 0; i < halfWordCount; i++)
            {
                char firstLetter = wordToCheck[i];
                char lastLetter = wordToCheck[wordToCheck.Length - (1+i)];
                // check the first + i and last -i are equals
                if (firstLetter != lastLetter)
                {
                    return false;
                } 
            }
            return true;
        }
    }
}