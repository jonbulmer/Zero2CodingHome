using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class PinkWaferBiscuit : IBiscuitCard
    {
        public string Name { get; set; }
        public Dictionary<BiscuitAttribute, int> Stats { get; set; }
        public int Quality => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public PinkWaferBiscuit()
        {
            Stats = new Dictionary<BiscuitAttribute, int>
            {
                { BiscuitAttribute.DunkIntegrity, 10 },
                { BiscuitAttribute.Moistness, 70 },
                { BiscuitAttribute.Snap, 10 },
                { BiscuitAttribute.Sweetness, 90 },
                { BiscuitAttribute.Texture, 90 }
            };

            Name = "Pink Wafer";
            Description = "The ultimate in gaudy, nouveau riche dining. A favourite of the intelligentsia.";
        }
    }
}
