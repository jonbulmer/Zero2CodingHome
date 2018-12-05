using System;
using System.Collections.Generic;
using System.Text;
using 





namespace Exam.Objective2_1
{

    public class Customer
    {
        public string Fistname { get; set; }
        public int XCoOrd { get; set; }
        public int yCoOrd { get; set; }
    }

    public static class GivingTypesBody
    {
        // Listing 2-3 Calling a method 
        public static void CallHelloWorld()
        {
            Console.WriteLine("Hello world");
        }

        // Listing 2-4 Creating a method
        public static int Add(int x, int y)
        {
            
            return x + y;
        }

        // Listing 2-5 Passing a complete customer to a method

        public static Point CalculateDistanceTo(Customer customer)
        {
            Point result;
            result.x = customer.XCoOrd;
            result.y = customer.yCoOrd;
           return result;
        }

        // Listing 2-13 Generic Nullable<T> implementation
    }

    // Listing 2-4 Craeting a method
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    // Listing 2-13 Generic Nullable<T> implementation
    public struct Nullable<T> where T : struct
    {
        private bool hasValue;
        private T value;

        public Nullable(T value)
        {
            this.hasValue = true;
            this.value = value;
        }

        public bool HasValue { get { return this.hasValue; } }
        public T Value
        {
            get
            {
                if (!this.HasValue)
                {
                    throw new ArgumentException();
                }
                return this.value;
            }
        }
    }





}
