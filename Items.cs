using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public abstract class Item
    {
        public string Name { get; private set; }

        public Item(string name)
        {
            Name = name;
        }

        // Abstract method to be used by subclasses
        public abstract void Use(Player player);
    }

}