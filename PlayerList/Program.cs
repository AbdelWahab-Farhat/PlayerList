using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayerList
{
    public class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Team { get; set; }
    }

    public class PlayerHandler
    {
        private List<Player> players = new List<Player>
        {
            new Player { Id = 1, Name = "John", Team = "A" },
            new Player { Id = 2, Name = "Jane", Team = "B" },
            new Player { Id = 3, Name = "Jack", Team = "A" },
            new Player { Id = 4, Name = "Jill", Team = "B" },
            new Player { Id = 5, Name = "Joe", Team = "A" }
        };

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }

        public List<Player> GetPlayers()
        {
            return players;
        }

        public List<Player> GetPlayersByTeam(string team)
        {
            return players.Where(p => p.Team == team).ToList();
        }

        public void GetPlayerById(int id)
        {
            Player? player = players.FirstOrDefault(p => p.Id == id);
            if (player != null)
            {
                Console.WriteLine($"Id: {player.Id}, Name: {player.Name}, Team: {player.Team}");
            }
            else
            {
                Console.WriteLine("Player not found");
            }
        }

        public void ShowPlayers()
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Id: {player.Id}, Name: {player.Name}, Team: {player.Team}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var playerHandler = new PlayerHandler(); 
            playerHandler.ShowPlayers(); 
        }
    }
}
