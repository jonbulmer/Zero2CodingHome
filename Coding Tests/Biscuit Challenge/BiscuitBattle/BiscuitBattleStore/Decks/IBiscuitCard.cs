using System.Collections.Generic;
namespace BiscuitBattle.Store.Decks
{
    public interface IBiscuitCard
    {
        string Name { get; set; }
        Dictionary<BiscuitAttribute, int> Stats { get; set; }
        int Quality { get; }
        string Description { get; set; }
    }
}
