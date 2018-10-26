using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Factories.Interfaces
{
    public interface IUserFactory
    {
        IUser CreateUser(string name1, string name2);
        IUserIdentity CreateIdentity();
    }
}
