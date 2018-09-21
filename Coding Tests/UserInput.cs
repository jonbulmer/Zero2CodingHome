/*
User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, 
which accepts only digits.

Implement the class TextInput that contains:

Public method void Add(char c) - adds the given character to the current value
Public method string GetValue() - returns the current value
Implement the class NumericInput that:

Inherits TextInput
Overrides the Add method so that each non-numeric character is ignored
For example, the following code should output "10":
*/



using System;

namespace GeneralProblems
{

    public class TextInput
    {
        // this is the string where we store the output
        protected string currentValue;
        

        public virtual void Add(char c)
        {
            currentValue += c.ToString();
        }

        public string GetValue()
        {
            // return the value entered into the 
            return currentValue;
        }
    }

    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if(c >= '0' && c <= '9')
            {
                currentValue += c.ToString();
            }
        }
    }
    public class UserInput
    {
    }
}
/*

/*
    public static void Main(string[] args)
    {
        //TextInput input = new NumericInput();
        //input.Add('1');
        //input.Add('a');
        //input.Add('0');
        //Console.WriteLine(input.GetValue());
    }
}
*/
