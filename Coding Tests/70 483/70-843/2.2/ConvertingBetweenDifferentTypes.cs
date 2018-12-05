using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http;
using System.Text;

namespace Exam.Objective2_2
{
    class ConvertingBetweenDifferentTypes
    {
        // Listing 2-20 Implicity converting an integer to a double
        public static void ImplicityConvertingAnIntegerToDouble()
        {
            int i = 42;
            double d = i;
        }

        // Listing 2-21 Implicitly converting an object to a base type
        public static void ImplicityConvertingObjectToBaseType()
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;
        }

        // Listing 2-22 Casting a double to an integer
        public static void CastingDoubleToAnInteger()
        {
            double x = 1234.7;
            int a;
            // Cast double to int
            a = (int)x;
        }

        //Listing 2-23 Explicitly casting a base toye to a derived type
        public static void ExplicitlyCastingBaseTypeToDerivedType()
        {
            Object Stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)Stream;

            Animal a = new Dog();

            Dog d1 = (Dog)a;
        }

        //Listing2-25 Using an implicit and explicit cast operator on a custom type
        public static void UsingAnImplicitAndExplicitCastOperatorOnCustomType()
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            int truncteAmount = (int)m;
        }

        // Listing 2-26 Using the built-in Convert and Parse method
        public static void UsingTheBuildinConvertAndParseMethod()
        {
            int value = Convert.ToInt32("42");
            value = int.Parse("42");
            bool success = int.TryParse("42", out value);
        }

        // List 2-27 Using the is and as operator
        public static void UsingTheIsAndAsOperator(DbConnection connection)
        {
            Animal a = new Animal();
            if (a is Dog)
            {
                Dog d1 = (Dog)a;
            }

            Dog d = a as Dog;
            if (d != null)
            {
                d.Bark();
            }


            // Listing 2-29 Creating a custom DynamicObject
        }
    }


    class Animal
    {
        public string Name { get; set; }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("woof");
        }
    }

    // Listing 2-24 Implement an implicit and explicit convertion operator
    public class Money
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }


}
