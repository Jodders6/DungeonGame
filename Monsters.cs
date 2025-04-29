using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonExplorer
{
    public class Monster : Beings
    {
        public Monster(string name, int health) : base(name, health) { }

        public void Attack(Player player) //Monser attacks the player.
        {
            Console.WriteLine($"{Name} attacks {player.Name}! 10 damage recieved...");
            player.TakeDamage(10);  // Generic amount of damage.    
        }
    }


}
