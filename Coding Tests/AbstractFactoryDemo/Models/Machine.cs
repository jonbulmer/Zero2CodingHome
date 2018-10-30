using System;
using System.Collections.Generic;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    class Machine : IUser
    {
        public Producer Producer { get; set; }
        public string Model { get; set; }

        public Machine(Producer producer, string model)
        {
            if (producer == null)
            {
                if (producer == null)
                    throw new AggregateException(nameof(producer));
                if (string.IsNullOrEmpty(model))
                    throw new AggregateException("Model name must be non-empty."); 
            }
        }
        public void SetIdentity(IUserIdentity identity)
        {
            throw new System.NotImplementedException();
        }

    }
}
