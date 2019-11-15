using System;
using System.Collections.Generic;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public abstract class BaseBiscuitFactory
    {
        public abstract IBiscuitCard GetCard();
    }
}
