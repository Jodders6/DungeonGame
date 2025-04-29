using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class GameMap
    {
        public Room CurrentRoom { get; set; }
        private List<Room> rooms;
        private int currentRoomIndex;

        public GameMap()
        {
            rooms = new List<Room>
            {
                // Uses for classes like Weapon, Potion, or KeyItem
                new Room("A dark, damp room.", new Monster("Goblin", 50), new List<Item>
                {
                    new Weapons("Sword", 20),
                    new Potions("Health Potion", 30)
                }
                ),
                new Room("A dusty storage room with a large box... Maybe something is inside?", new Monster("Troll", 80), new List<Item>
                {
                    new KeyItem("Gold Key") // Uses a KeyItem instead of a standard item.
                }
                ),
                new Room("A small and cramped room. A large door that appears to have sunlight seeping from under it!", null, new List<Item>
                {
                    new Weapons("Shield", 10)
                }
                )
            };
            
            
            currentRoomIndex = 0;
            CurrentRoom = rooms[currentRoomIndex];
        }

        public bool MoveToNextRoom() //Movement action. If there are no other rooms to move to the dungeon end statement is printed.
        {
            if (currentRoomIndex + 1 < rooms.Count)
            {
                currentRoomIndex++;
                CurrentRoom = rooms[currentRoomIndex];
                return true;
            }
            else
            {
                Console.WriteLine("You've reached the end of the dungeon!");
                return false;
            }
        }

        public bool MoveToPreviousRoom() //Allows the player to move back to the previous room. Not integrated with choices yet. It does print telling the player once there are no more rooms to move back to.
        {
            if (currentRoomIndex - 1 >= 0)
            {
                currentRoomIndex--;
                CurrentRoom = rooms[currentRoomIndex];
                return true;
            }
            else
            {
                Console.WriteLine("You're at what seems to be the start of the dungeon.");
                return false;
            }
        }
    }
}
