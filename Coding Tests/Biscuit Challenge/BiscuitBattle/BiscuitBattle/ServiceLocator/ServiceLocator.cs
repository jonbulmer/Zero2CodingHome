using BiscuitBattle.Game;
using BiscuitBattle.Players;
using System;
using System.Collections.Generic;
using System.Text;
using BiscuitBattle.Store;

namespace BiscuitBattle.ServiceLocator
{
    public class ServiceLocator : IServiceLocator
    {
        // map that contains pairs of interfaces and
        // references to concrete implementations
        private readonly IDictionary<object, object> _services;

        public ServiceLocator()
        {
            _services = new Dictionary<object, object>();

            // fill the map
            this._services.Add(typeof(IGameController), new GameController());
            this._services.Add(typeof(IPlayer), new BasicAI());
            this._services.Add(typeof(BaseBiscuitFactory), new RandomBiscuitCardFactory());
        }

        public T GetService<T>()
        {
            try
            {
                return (T)_services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new Exception("The requested service is not registered");
            }
        }
    }
}
