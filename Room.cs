using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Room
    {
        public string Description { get; private set; }
        public Beings Monster { get; set; }
        public List<Item> Items { get; private set; }

        public Room(string description, Beings monster = null, List<Item> items = null) //Sets up each basic room, checks if it contains a description, monster and any items.
        {
            Description = description;
            Monster = monster;
            Items = items ?? new List<Item>();
        }

        // Get information about the room, including monster presence and items
        public string GetInfo()
        {
            return Description + (Monster != null ? "\nYou catch strange movements in the corner of your eye..." : "");
        }
    }
}
