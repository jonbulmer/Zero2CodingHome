using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    class MacAddress : IUserIdentity
    {
        public string RawAddress { get; set; }
    }
}
