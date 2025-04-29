using DungeonExplorer;
using System;

public class KeyItem : Item
{
    public KeyItem(string name) : base(name) 
    { }
    

    public override void Use(Player player)
    {
        Console.WriteLine($"You use the {Name}. It might open something...");
    }
}
