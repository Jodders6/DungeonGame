using System;
using System.Collections.Generic;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        private bool playing;
        private Dictionary<string, Room> rooms; // Creates a dictionary for the rooms allowing them to be stored in an array.

        public Game()
        {
            // Initialize the game with one room and one player
            Console.WriteLine("Player! Enter your name here: ");
            string playerName = Console.ReadLine();
            player = new Player(playerName, 100); // Sets the player's name to the user's input. Also declares the Player's health to be 100.

            rooms = new Dictionary<string, Room> // The rooms dictionary containing the two rooms with their description. This can be called by the player at any time.
            {
                {"Room A", new Room("A small square room, a few barrels littered around with some rat-like noises from the dark corners.", "Room B") },
                {"Room B", new Room("A larger rectangle-shaped room. This one is laden with scrap and junk.", null) }
            };

            currentRoom = rooms["Room A"]; // Starts the player in Room A.
            Console.WriteLine("Welcome adventurer!");
        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                //Gives player different options within the current room
                Console.WriteLine("|||What would you like to do?|||");
                Console.WriteLine("A. Explore the room(Descritpion)");
                Console.WriteLine("B. Move to the connecting room");
                Console.WriteLine("C. Open your inventory");
                Console.Write("What is your decision adventurer?: ");

                string choice = Console.ReadLine(); // Sets the choice as what the player enters into the terminal.
                PlayerChoice(choice); // Calls the PlayerChoice private void with the "choice" variable that was set above.
                
            }
        }
        
        private void MoveToNextRoom() // Handles the move to next room function that the player is given.
        {
            if (string.IsNullOrEmpty(currentRoom.NextRoom)) 
            {
                Console.WriteLine("You have completed the dungeon!"); //Checks to see if the player is attempting to move into a room that doesn't exist. Masks error checking as apart of the game.
                return;
            }

            if (rooms.ContainsKey(currentRoom.NextRoom))
            {
                currentRoom = rooms[currentRoom.NextRoom];
                Console.WriteLine("You enter the next room."); // Allows player to progress to the next room.
            }
        }
        private void PlayerChoice(string choice)
        {
            switch (choice)
            //Delivers the different choices to the player. Uses A, B and C for the three different choices.
            {
                case "A":
                    Console.WriteLine("You explore the room:" + currentRoom.GetDescription()); // Prints the current room's description to the user.
                    break;

                case "B":
                    Console.WriteLine("You carefully step into the connecting room"); // Utilises the MoveToNextRoom public void.
                    MoveToNextRoom();
                    break;
                case "C":
                    Console.WriteLine("Inventory: " + (player.InventoryContents() == "" ? "is Empty" : player.InventoryContents())); // Checks the player inventory, if empty it outputs that it is empty.
                    break;
                
            }
        }
    }
}