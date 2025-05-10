using System;
using NUnit.Framework;
using DungeonExplorer;
using System.Collections.Generic;

namespace DungeonExplorerTests
{
    

    [TestFixture]
    public class GameTestDebug
    {
        //Ensures that damage is dealt to the player when theya re attacked, uses a test player to check.
        [Test]
        public void PlayerReducesHealth()
        {
            Player player = new Player("TestPlayer", 100);
            player.TakeDamage(20);
            Assert.That(player.Health, Is.EqualTo(80));
        }

        // Checks if healing adds to player’s health using a test player.
        [Test]
        public void PlayerIncreasesHealth()
        {
            Player player = new Player("TestPlayer", 50);
            player.Heal(25);
            Assert.That(player.Health, Is.EqualTo(75));
        }
    }
}
