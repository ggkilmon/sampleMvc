using System.Collections.Generic;
using System.Linq;
using SampleMvcCodeSample.Data.Models;
using SampleMvcCodeSample.Data.Repositories.Interfaces;

namespace SampleMvcCodeSample.Tests
{
    public class TestPlayerRepository : IPlayerRepository
    {
        private List<Player> playerData = new List<Player>();

        public TestPlayerRepository()
        {
            playerData.Add(new Player()
            {
                Age = 10,
                BirthPlace = "test birth",
                Classification = PlayerClassification.DesignatedPlayer,
                FirstName = "TestFirst",
                Height = new PlayerHeight() { Feet = 6, Inches = 0 },
                Hometown = "test home",
                Id = 1,
                JerseyNumber = 10,
                LastName = "TestLast",
                Nickname = "TestNick",
                Position = PlayerPosition.Forward,
                Stats = new List<PlayerStats>() { new PlayerStats() { Assists = 0, Club = "test club", GamesPlayed = 1, GamesStarted = 1, GoalsScored = 10, Minutes = 120, RedCards = 0, Shots = 10, ShotsOnGoal = 10, Year = 2019, YellowCards = 0 } },
                Weight = 170,
            });
        }

        public List<Player> GetAllPlayers()
        {
            return playerData;
        }

        public Player GetPlayer(int id)
        {
            return playerData.Where(p => p.Id == id).First();
        }
    }
}