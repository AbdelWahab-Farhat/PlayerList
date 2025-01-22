using Xunit;
using System.Linq;
using PlayerList;
using System.Collections.Generic;

namespace PlayerList.Tests
{
    public class UnitTest1
    {
        private PlayerHandler playerHandler;

        public UnitTest1()
        {
            // Arrange: Initialize the PlayerHandler with some sample data
            playerHandler = new PlayerHandler();
        }

        [Fact]
        public void UniqueIdTest()
        {
            var players = playerHandler.GetPlayers();

            foreach (var player in players)
            {
                Assert.True(players.Count(p => p.Id == player.Id) == 1, 
                            $"Player with ID {player.Id} is not unique.");
            }
        }

        [Fact]
        public void SearchByIdTest_PlayerExists()
        {
            var player = playerHandler.GetPlayers().FirstOrDefault(p => p.Id == 1);

            Assert.NotNull(player);
            Assert.Equal(1, player.Id);
            Assert.Equal("John", player.Name);
            Assert.Equal("A", player.Team);
        }

        [Fact]
        public void SearchByIdTest_PlayerNotFound()
        {
            var player = playerHandler.GetPlayers().FirstOrDefault(p => p.Id == 999);

            Assert.Null(player);
        }
    }
}
