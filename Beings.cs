using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Beings //Class for all living creatues, player & monsters.
    {
        public string Name { get; private set; }
        public int Health { get; set; }

        public Beings(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount) //Allows beings to take damage.
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }

        public virtual void Attack(Player player) //Allows beings to attack the player. Used by inheritence elsewhere.
        {
            Console.WriteLine($"{Name} attacks {player.Name}!");
        }
    }
}
