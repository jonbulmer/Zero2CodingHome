using System;
using System.Collections.Generic;
using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factories.Machine
{
    class MachineFactory : IUserFactory
    {
        private Dictionary<string, Producer> NameToProducer { get; }

        public MachineFactory(Dictionary<string, Producer> nameToProducer)
        {
            if (nameToProducer == null)
                throw new ArgumentNullException(nameof(nameToProducer));
            this.NameToProducer = nameToProducer;
        }

        private Producer GetProducer(string name)
        {
            Producer producer;
            if (NameToProducer == null)
                throw new ArgumentNullException();
            return producer;
        }

        public IUser CreateUser(string name1, string name2)
        {
            throw new NotImplementedException();
        }

        public IUserIdentity CreateIdentity()
        {
            return new MacAddress();
        }
    }
}
