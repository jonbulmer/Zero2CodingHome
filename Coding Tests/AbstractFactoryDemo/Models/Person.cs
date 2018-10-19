using System;
using System.Collections.Generic;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    class Person: IUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
