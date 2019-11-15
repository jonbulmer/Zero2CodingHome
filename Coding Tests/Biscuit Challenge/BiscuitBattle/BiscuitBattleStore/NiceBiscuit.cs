using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class NiceBiscuit : IBiscuitCard
    {
        public string Name { get; set; }
        public Dictionary<BiscuitAttribute, int> Stats { get; set; }
        public int Quality => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public NiceBiscuit()
        {
            Stats = new Dictionary<BiscuitAttribute, int>
            {
                { BiscuitAttribute.DunkIntegrity, 40 },
                { BiscuitAttribute.Moistness, 20 },
                { BiscuitAttribute.Snap, 60 },
                { BiscuitAttribute.Sweetness, 60 },
                { BiscuitAttribute.Texture, 60 }
            };

            Name = "Nice Biscuit";
            Description = "Dependable, reliable and a favourite of older people everywhere. The nice biscuit is a modern classic";
        }
    }
}
