using AbstractFactoryDemo.Interfaces;

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
