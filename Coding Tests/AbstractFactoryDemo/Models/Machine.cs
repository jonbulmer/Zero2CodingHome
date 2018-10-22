using System;
using System.Collections.Generic;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    class Machine : IUser
    {
        public Producer Producer { get; set; }
        public string Model { get; set; }

        public void SetIdentity(IUserIdentiy identity)
        {
            // identity must by MacAddress
            // access identity.NicPart
        }

        public Machine(Producer producer, string model)
        {
            if (producer == null)
            {
                throw new AggregateException(); 
            }
        }
    }
}
