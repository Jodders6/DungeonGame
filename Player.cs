using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<string> inventory = new List<string>(); // Creats a list for the player's inventory.

        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }
        public void PickUpItem(string item)
        {
            inventory.Add(item);
            Console.WriteLine("You have obtained: " + item); // Simple "Pick up" feature allowing the player to interact with items.
        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory); // Saves the items that have been collected to the player's inventory. 
        }
    }
}