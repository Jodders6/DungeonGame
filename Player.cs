using DungeonExplorer;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DungeonExplorer
{
    public class Player : Beings
    {
        public Inventory Inventory { get; private set; }

        public Player(string name, int health) : base(name, health)
        {
            Inventory = new Inventory();
        }

        // Adds items to inventory, players can pick up all of the items in a room.
        public void PickUpItem(Item item)
        {
            Inventory.AddItem(item);
        }

        // Uses an item specific to its name, player will enter the name of the item.
        public void UseItem(string itemName)
        {
            Inventory.UseItem(itemName, this);
        }

        // Shows the current inventory of the player
        public void ShowInventory()
        {
            Console.WriteLine("Your inventory:");
            foreach (var item in Inventory.Items)
            {
                Console.WriteLine($"{item.Name}");
            }
        }

        // Adds health to player, can be done through items or cheats.
        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} healed for {amount}. Total health: {Health}");
        }
    }
}
