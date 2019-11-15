using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class BalancedBiscuit : IBiscuitCard
    {
        public string Name { get; set; }
        public Dictionary<BiscuitAttribute, int> Stats { get; set; }
        public int Quality => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public BalancedBiscuit()
        {
            Stats = new Dictionary<BiscuitAttribute, int>
            {
                { BiscuitAttribute.DunkIntegrity, 20 },
                { BiscuitAttribute.Moistness, 20 },
                { BiscuitAttribute.Snap, 30 },
                { BiscuitAttribute.Sweetness, 30 },
                { BiscuitAttribute.Texture, 30 }
            };

            Name = "Balanced Biscuit";
        }
    }
}
