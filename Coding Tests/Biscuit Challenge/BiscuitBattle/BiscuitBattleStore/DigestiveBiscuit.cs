using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class DigestiveBiscuit : IBiscuitCard
    {
        public string Name { get; set; }
        public Dictionary<BiscuitAttribute, int> Stats { get; set; }
        public int Quality => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public DigestiveBiscuit()
        {
            Stats = new Dictionary<BiscuitAttribute, int>
            {
                { BiscuitAttribute.DunkIntegrity, 50 },
                { BiscuitAttribute.Moistness, 20 },
                { BiscuitAttribute.Snap, 40 },
                { BiscuitAttribute.Sweetness, 60 },
                { BiscuitAttribute.Texture, 60 }
            };

            Name = "Digestive";
            Description =
                "The digestive conjures up memories of summers past. Hazy evenings by an open fire. Pops toasting marshmallows.";
        }
    }
}
