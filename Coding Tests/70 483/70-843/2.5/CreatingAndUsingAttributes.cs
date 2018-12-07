using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Exam.Objective2_5
{
    class CreatingAndUsingAttributes
    {


        // Listing 2-58 Applying an attribute
        [Serializable]
        class Person
        {
            public string FirstName { get; set; }
            public string Lastname { get; set; }

            // Listing 2-61 Seeing wether an attribute is defined
            static void SeeingWhetherAnAttributeIsDefined()
            {
                if (Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute)))
                {
                    Console.WriteLine("This will always run but it is only to demonstrate syntax");
                }
            }

            // Listing 2-59 Using multiple attributes
            [Conditional("CONDITION1")]
            [Conditional("CONDITION1")]

            //Listing 2-62 Getting a specific attribute instance
            static void GettingSpecificAttributeInstance()
            {
                ConditionalAttribute conditionalAttribute = (ConditionalAttribute)Attribute.GetCustomAttributes(
                              typeof(ConditionalAttribute)).First();
            }
        }

        // Listing 2-68 Adding properties to a custom attribute
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
        class CompleteCutomAttribute : Attribute
        {
            public string Description { get; set; }
            public CompleteCutomAttribute(string description)
            {
                description = Description;
            }
        }

    }
}