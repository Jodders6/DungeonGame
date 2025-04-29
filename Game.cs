using System;

namespace DungeonExplorer
{
    public class Game
    {
        private Player player;
        private GameMap map;
        private bool playing;

        public Game()
        {
            Console.WriteLine("Player! Enter your name here: ");
            string playerName = Console.ReadLine();
            player = new Player(playerName, 100);
            map = new GameMap();
            playing = true;
        }

        public void Start()
        {
            while (playing)
            {
                Console.WriteLine("1. View Room Info");
                Console.WriteLine("2. Pick up an item");
                Console.WriteLine("3. Use an item");
                Console.WriteLine("4. Move");
                Console.WriteLine("5. Fight");
                Console.WriteLine("6. Inventory");
                Console.WriteLine("7. Exit");
                Console.Write("Choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine(map.CurrentRoom.GetInfo());
                        break;

                    case "2":
                        foreach (var item in map.CurrentRoom.Items)
                        {
                            player.PickUpItem(item);
                        }
                        map.CurrentRoom.Items.Clear();
                        break;

                    case "3":
                        Console.Write("What Item: ");
                        string itemName = Console.ReadLine();
                        UseItem(itemName);
                        break;

                    case "4":
                        map.MoveToNextRoom();
                        break;

                    case "5":
                        Combat();
                        break;

                    case "6":
                        player.ShowInventory();
                        break;

                    case "7":
                        playing = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        private void Combat()
        {
            var monster = map.CurrentRoom.Monster;
            if (monster == null)
            {
                Console.WriteLine("You don't see anything out of the ordinary.");
                return;
            }

            Console.WriteLine($"A foul {monster.Name} appears!");

            while (player.Health > 0 && monster.Health > 0)
            {
                Console.Write("Attack (y/n)? ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine("You strike!");
                    monster.TakeDamage(20);
                    if (monster.Health > 0)
                    {
                        monster.Attack(player);
                    }
                }
                else
                {
                    Console.WriteLine("Your inaction causes the monster to attack!");
                    monster.Attack(player);
                }
            }

            if (monster.Health <= 0)
            {
                Console.WriteLine($"You defeated the foul {monster.Name}!");
                map.CurrentRoom.Monster = null;
            }
            else
            {
                Console.WriteLine("You have died. Try again!");
                playing = false;
            }
        }

        private void UseItem(string itemName)
        {
            Item item = player.Inventory.Items.Find(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
            if (item == null)
            {
                Console.WriteLine("No item matching this name found in your inventory, perhaps you should check it first?");
                return;
            }

            item.Use(player);
        }
    }
}
