using System;



namespace DungeonExplorer
{
    public class Weapons : Item //One of many examples of inheritence throught the various classes in the code.
    {
        public int AttackPower { get; private set; }

        public Weapons(string name, int attackPower) : base(name)
        {
            AttackPower = attackPower;
        }

        // Overrides the abstract use method from the Item Class.
        public override void Use(Player player)
        {
            Console.WriteLine($"You wield the {Name} with {AttackPower} attack power.");
            // Creates and informs the user of the stats of the weapon if applicable.
            // Depending on the attack power the amount of damage can be either higher or lower.
           
        }
    }
}
