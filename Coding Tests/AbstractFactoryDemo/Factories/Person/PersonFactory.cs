using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factories.Person
{
    class PersonFactory : IUserFactory
    {
        public IUserIdentity CreateIdentity()
        {
            return new Models.Person(name1, name2);
        }

        public IUser CreateUser(string name1, string name2)
        {
            return new IdentityCard();
        }
    }
}
