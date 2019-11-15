using BiscuitBattle.Players;
using System;
using System.Collections.Generic;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Game
{
    public interface IGameController
    {
        IList<IBiscuitCard> PlayerOneDeck { get; set; }
        IList<IBiscuitCard> PlayerTwoDeck { get; set; }

        IPlayer PlayerOne { get; set; }
        IPlayer PlayerTwo { get; set; }

        void Begin();
    }
}
