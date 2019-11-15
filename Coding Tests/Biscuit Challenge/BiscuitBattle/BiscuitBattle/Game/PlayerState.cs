using BiscuitBattle.Players;
using System;
using System.Collections.Generic;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Game
{
    public class PlayerState
    {
        public IPlayer Player { get; set; }
        public IBiscuitCard CurrentCard { get; set; }
        public IList<IBiscuitCard> Deck { get; set; }
        public string Label { get; set; }
    }
}
