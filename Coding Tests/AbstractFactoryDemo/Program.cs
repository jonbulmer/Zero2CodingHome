using System;
using AbstractFactoryDemo.Factories.Interface;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void RegisterUser(IUserFactory userFactory)
        {
            ITicketHolder holder = userFactory.CreateUser();
        }

        static void ConfigureUser()
        {
            IUserFactory factory = new PersonFactory();

            IUser user = factory.CreateUser("Jon", "Bulmer");

            IUserIdentiy id = factory.CreateIdentity();
        }

        static void Main(string[] args)
        {
            ConfigureUser();
            Console.WriteLine("Reached the end of the demo...");
            Console.ReadLine();
        }
    }
}
