using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class GingernutBiscuit : IBiscuitCard
    {
        public string Name { get; set; }
        public Dictionary<BiscuitAttribute, int> Stats { get; set; }
        public int Quality => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public GingernutBiscuit()
        {
            Stats = new Dictionary<BiscuitAttribute, int>
            {
                { BiscuitAttribute.DunkIntegrity, 90 },
                { BiscuitAttribute.Moistness, 10 },
                { BiscuitAttribute.Snap, 90 },
                { BiscuitAttribute.Sweetness, 30 },
                { BiscuitAttribute.Texture, 30 }
            };

            Name = "Ginger Nut Biscuit";
            Description =
                "Sat in the back of your cupboard for months. No one really likes them. Why are they still made?";
        }
    }
}
