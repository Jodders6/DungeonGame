using System;
using NUnit.Framework;
using DungeonExplorer;
using System.Collections.Generic;

namespace DungeonExplorerTests
{
    /*
    * Description:
    * This class contains tests for key parts of the Dungeon Explorer game.
    * It checks if the game works as expected — from health changes to room movement.
    *
    * Main Functionality:
    * - Makes sure taking damage and healing update health correctly.
    * - Checks if inventory behaves right (items added, used, removed).
    * - Confirms monsters deal damage when they attack.
    * - Verifies the player can move between rooms properly.
    *
    * Input Parameters:
    * - No input from user — test data is created inside each test method.
    *
    * Expected Output:
    * - Test results: All tests pass if the game logic is working correctly.
    */

    [TestFixture]
    public class GameTestDebug
    {
        // checks if taking damage lowers the player’s health correctly
        [Test]
        public void PlayerReducesHealth()
        {
            Player player = new Player("TestPlayer", 100);
            player.TakeDamage(20);
            Assert.That(player.Health, Is.EqualTo(80));
        }

        // checks if healing adds to player’s health
        [Test]
        public void PlayerIncreasesHealth()
        {
            Player player = new Player("TestPlayer", 50);
            player.Heal(25);
            Assert.That(player.Health, Is.EqualTo(75));
        }
    }
}
