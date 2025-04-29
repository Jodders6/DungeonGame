using System;

namespace DungeonExplorer
{
    public class Potions : Item
    {
        public int HealAmount { get; private set; }

        public Potions(string name, int healAmount) : base(name)
        {
            HealAmount = healAmount;
        }

        // Overrides the abstract Use method from Item class for the healing potion as it requires the addition of extra health.
        public override void Use(Player player)
        {
            player.Heal(HealAmount);
            Console.WriteLine($"You drink the {Name}. You heal for {HealAmount} points.");
        }
    }
}
