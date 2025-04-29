using System;
using System.Collections;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Inventory : IEnumerable<Item>
    {
        private List<Item> items = new List<Item>();

        // Allows access to the item list
        public List<Item> Items
        {
            get { return items; }
        }

        // When the player used the "pick up item" function this will add it to their inventory.
        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"A {item.Name}, has been added to your inventory!");
        }

        // This will remove an item from the player's inventory. Used for consumables.
        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        // Handles players using items from their inventory. 
        public void UseItem(string itemName, Player player)
        {
            // Find the item by name
            Item item = items.Find(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));

            if (item != null)
            {
                item.Use(player); // Uses the item.
                items.Remove(item); // Remove the item after use for consumables.
            }
            else
            {
                Console.WriteLine($"Item '{itemName}' not found in your inventory.");
            }
        }

        // Implementation of IEnumerable<Item> to allow for each loop
        public IEnumerator<Item> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        // Non standard type of GetEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
