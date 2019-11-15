using System;
using System.Collections.Generic;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class RandomBiscuitCardFactory : BaseBiscuitFactory
    {
        public override IBiscuitCard GetCard()
        {
            var ran = new Random();
            var choose = ran.Next(1, 5);
            switch (choose)
            {
                case 1:
                    return new NiceBiscuit();
                case 2:
                    return new DigestiveBiscuit();
                case 3:
                    return new PinkWaferBiscuit();
                case 4:
                    return new BalancedBiscuit();
                case 5:
                    return new GingernutBiscuit();
                default:
                    return new BalancedBiscuit();
            }
        }
    }
}
