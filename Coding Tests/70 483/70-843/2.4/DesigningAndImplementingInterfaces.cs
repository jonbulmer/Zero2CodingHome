using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective2_4
{
    class DesigningAndImplementingInterfaces
    {
        // Listing 2-41 Creating and implementing an interface
        interface IExample
        {
            string GetResults();
            int Value { get; set; }
            event EventHandler ResultRetrieved;
            int this[string index] { get; set; }
        }

        class ExampleImplementation : IExample
        {
            public int this[string index]
            {
                get
                {
                    return 42;
                }
                set { }
            }

            public int Value { get; set; }

            public event EventHandler CalculationPerformed;

            public event EventHandler ResultRetrieved;

            public string GetResults()
            {
                return "result";
            }
        }

        // Listing 2-42 Adding a set accessor to an implemented interface

        interface IReadOnlyInterface
        {
            int Value { get; }
        }

        struct ReadAndWriteImplementation : IReadOnlyInterface
        {
            public int Value { get; set; }
        }

        // Listing 2-43 Creating an interface with a generic type
        interface IRepository<T>
        {
            T FindById(int id);
            IEnumerable<T> All();
        }

        // Listing 2-44 Instantiating a concreat type that implemnts an interface
        interface IAnimal
        {
            void Move();
        }

        class Dog : IAnimal
        {
            public void Move() { }
            
            public void Bark() { }
        }

        IAnimal animal = new Dog();


        static void Vanimal(IAnimal animal)
        {
            Dog dog = new Dog();
            dog = (Dog)animal;
            dog.Bark();
        }
    }



}
