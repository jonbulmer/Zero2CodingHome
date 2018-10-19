using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Interfaces
{
    public interface ITicketHolder
    {
    }

    public interface IUser : ITicketHolder
    {
        void SetIdentity(IUserIdentity identity);
    }
}
