using System;
using System.Collections.Generic;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Players
{
    public interface IPlayer
    {
        (BiscuitAttribute Attr, int Score) DecideAttributeToPlay(IBiscuitCard m);
    }
}
