using System;
using System.Collections.Generic;
using System.Text;

namespace BiscuitBattle.ServiceLocator
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}
