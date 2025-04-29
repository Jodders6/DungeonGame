using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public static class Behaviour
    {
        // Gives the monster some realisim. If the monster is low or high hp.
        public static void React(Beings monster)
        {
            if (monster.Health < 20)
            {
                Console.WriteLine($"{monster.Name} looks frightened and tries to retreat!");
            }
            else
            {
                Console.WriteLine($"{monster.Name} prepares a counterattack.");
            }
        }
    }
}
