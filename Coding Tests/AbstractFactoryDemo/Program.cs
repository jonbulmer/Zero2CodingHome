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

        static void Main(string[] args)
        {
        }
    }
}
