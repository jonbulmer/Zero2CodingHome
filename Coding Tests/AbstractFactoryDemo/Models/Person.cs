using System;
using System.Collections.Generic;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    class Person: IUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArithmeticException("First name must be non-empty.");
            if (string.IsNullOrEmpty(surname))
                throw new ArithmeticException("Last name must be non-empty.");

            this.Name = name;
            this.Surname = surname;
        }

        public void SetIdentity(IUserIdentity identity)
        {
        }

        public override string ToString() => $"{this.Name} {this.Surname}";
    }
}
