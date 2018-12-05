using System;
using System.Collections.Generic;
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
    }

    class Animal
    {
        public string Name { get; set; }
    }

    class Dog : Animal
    {
        public void Bark()
        {
        }
    }
}
