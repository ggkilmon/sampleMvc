using SampleMvcCodeSample.Data.Models;
using SampleMvcCodeSample.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvcCodeSample.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private List<Player> playerData = new List<Player>();

        public PlayerRepository()
        {
            Player p = new Player{
                Age = 26,
                BirthPlace = "Accra, Ghana",
                FirstName = "David",
                Height = new PlayerHeight(){ Feet = 5, Inches = 9},
                Id = 1,
                JerseyNumber = 11,
                LastName = "Accam",
                Position = PlayerPosition.Forward,
                Weight = 154,
                Stats = new List<PlayerStats>(),
                Classification = PlayerClassification.DesignatedPlayer
            };
            p.Stats.Add(new PlayerStats(){ Assists = 7, Club = "Chicago Fire", GamesPlayed = 20, GamesStarted = 16, GoalsScored = 12, Minutes = 1408, RedCards = 0, Shots = 41, ShotsOnGoal = 24, Year = 2017, YellowCards = 2});
            p.Stats.Add(new PlayerStats(){ Assists = 5, Club = "Chicago Fire", GamesPlayed = 24, GamesStarted = 21, GoalsScored = 9, Minutes = 1935, RedCards = 0, Shots = 71, ShotsOnGoal = 28, Year = 2016, YellowCards = 4});
            p.Stats.Add(new PlayerStats(){ Assists = 2, Club = "Chicago Fire", GamesPlayed = 24, GamesStarted = 21, GoalsScored = 10, Minutes = 1865, RedCards = 1, Shots = 67, ShotsOnGoal = 35, Year = 2015, YellowCards = 4});
            playerData.Add(p);

            p = new Player{
                Age = 32,
                BirthPlace = "Houston, Texas",
                FirstName = "Arturo",
                Height = new PlayerHeight(){ Feet = 5, Inches = 9},
                Hometown = "Houston, Texas",
                Id = 2,
                JerseyNumber = 12,
                LastName = "Alvarez",
                Position = PlayerPosition.Midfielder,
                Weight = 170,
                Stats = new List<PlayerStats>(),
            };
            p.Stats.Add(new PlayerStats(){ Assists = 1, Club = "Chicago Fire", GamesPlayed = 15, GamesStarted = 7, GoalsScored = 3, Minutes = 546, RedCards = 0, Shots = 14, ShotsOnGoal = 5, Year = 2017, YellowCards = 0});
            p.Stats.Add(new PlayerStats(){ Assists = 9, Club = "Chicago Fire", GamesPlayed = 30, GamesStarted = 24, GoalsScored = 5, Minutes = 1923, RedCards = 0, Shots = 39, ShotsOnGoal = 9, Year = 2016, YellowCards = 2});
            p.Stats.Add(new PlayerStats(){ Assists = 1, Club = "Real Salt Lake", GamesPlayed = 16, GamesStarted = 8, GoalsScored = 0, Minutes = 724, RedCards = 0, Shots = 18, ShotsOnGoal = 1, Year = 2011, YellowCards = 0});
            p.Stats.Add(new PlayerStats(){ Assists = 1, Club = "San Jose Earthquakes", GamesPlayed = 19, GamesStarted = 11, GoalsScored = 3, Minutes = 1210, RedCards = 0, Shots = 26, ShotsOnGoal = 12, Year = 2010, YellowCards = 3});
            p.Stats.Add(new PlayerStats(){ Assists = 2, Club = "San Jose Earthquakes", GamesPlayed = 23, GamesStarted = 20, GoalsScored = 5, Minutes = 1848, RedCards = 0, Shots = 53, ShotsOnGoal = 22, Year = 2009, YellowCards = 5});
            p.Stats.Add(new PlayerStats(){ Assists = 3, Club = "San Jose Earthquakes", GamesPlayed = 12, GamesStarted = 11, GoalsScored = 3, Minutes = 864, RedCards = 0, Shots = 18, ShotsOnGoal = 10, Year = 2008, YellowCards = 0});
            p.Stats.Add(new PlayerStats(){ Assists = 3, Club = "FC Dallas", GamesPlayed = 20, GamesStarted = 10, GoalsScored = 3, Minutes = 931, RedCards = 0, Shots = 22, ShotsOnGoal = 11, Year = 2008, YellowCards = 2});
            p.Stats.Add(new PlayerStats(){ Assists = 3, Club = "FC Dallas", GamesPlayed = 24, GamesStarted = 21, GoalsScored = 3, Minutes = 1898, RedCards = 0, Shots = 61, ShotsOnGoal = 30, Year = 2007, YellowCards = 2});
            p.Stats.Add(new PlayerStats(){ Assists = 1, Club = "FC Dallas", GamesPlayed = 24, GamesStarted = 6, GoalsScored = 3, Minutes = 578, RedCards = 0, Shots = 17, ShotsOnGoal = 11, Year = 2006, YellowCards = 2});
            p.Stats.Add(new PlayerStats(){ Assists = 4, Club = "FC Dallas", GamesPlayed = 20, GamesStarted = 15, GoalsScored = 2, Minutes = 1282, RedCards = 0, Shots = 31, ShotsOnGoal = 14, Year = 2005, YellowCards = 2});
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "San Jose Earthquakes", GamesPlayed = 11, GamesStarted = 2, GoalsScored = 1, Minutes = 373, RedCards = 0, Shots = 7, ShotsOnGoal = 4, Year = 2004, YellowCards = 3});
            p.Stats.Add(new PlayerStats(){ Assists = 1, Club = "San Jose Earthquakes", GamesPlayed = 15, GamesStarted = 5, GoalsScored = 1, Minutes = 651, RedCards = 0, Shots = 6, ShotsOnGoal = 2, Year = 2003, YellowCards = 2});
            playerData.Add(p);

            p = new Player{
                Age = 22,
                BirthPlace = "Saint Petersburg, Russia",
                FirstName = "David",
                Height = new PlayerHeight(){ Feet = 6, Inches = 4},
                Hometown = "Saint Petersburg, Russia",
                Id = 3,
                JerseyNumber = 10,
                LastName = "Arshakyan",
                Position = PlayerPosition.Forward,
                Weight = 190,
                Stats = new List<PlayerStats>(),
                Classification = PlayerClassification.International,
            };
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 3, GamesStarted = 0, GoalsScored = 0, Minutes = 16, RedCards = 0, Shots = 1, ShotsOnGoal = 0, Year = 2017, YellowCards = 1});
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 9, GamesStarted = 3, GoalsScored = 0, Minutes = 324, RedCards = 0, Shots = 9, ShotsOnGoal = 2, Year = 2016, YellowCards = 0});
            playerData.Add(p);

            p = new Player{
                Age = 36,
                BirthPlace = "Montevideo, Uruguay",
                FirstName = "Jorge Rodrigo",
                Height = new PlayerHeight(){ Feet = 6, Inches = 4},
                Id = 4,
                JerseyNumber = 1,
                LastName = "Bava",
                Position = PlayerPosition.Goalkeeper,
                Weight = 188,
                Stats = new List<PlayerStats>(),
                Classification = PlayerClassification.International,
            };
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 8, GamesStarted = 8, GoalsScored = 0, Minutes = 720, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2017, YellowCards = 0});
            playerData.Add(p);

            p = new Player{
                Age = 22,
                BirthPlace = "Westminster, MD",
                FirstName = "Brandt",
                Height = new PlayerHeight(){ Feet = 5, Inches = 8},
                Hometown = "High Point",
                Id = 5,
                JerseyNumber = 13,
                LastName = "Bronico",
                Position = PlayerPosition.Midfielder,
                Weight = 155,
                Stats = new List<PlayerStats>(),
            };
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 2, GamesStarted = 0, GoalsScored = 0, Minutes = 29, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2017, YellowCards = 0});
            playerData.Add(p);

            p = new Player{
                Age = 23,
                FirstName = "Joey",
                Height = new PlayerHeight(){ Feet = 5, Inches = 10},
                Hometown = "Deerfield, IL",
                Id = 6,
                JerseyNumber = 15,
                LastName = "Calistri",
                Position = PlayerPosition.Forward,
                Weight = 160,
                Stats = new List<PlayerStats>(),
                Classification = PlayerClassification.Homegrown,
            };
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 0, GamesStarted = 0, GoalsScored = 0, Minutes = 0, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2017, YellowCards = 0});
            p.Stats.Add(new PlayerStats(){ Assists = 1, Club = "Chicago Fire", GamesPlayed = 14, GamesStarted = 2, GoalsScored = 1, Minutes = 348, RedCards = 0, Shots = 5, ShotsOnGoal = 4, Year = 2016, YellowCards = 0});
            playerData.Add(p);

            p = new Player{
                Age = 24,
                FirstName = "Jonathan",
                Height = new PlayerHeight(){ Feet = 6, Inches = 2},
                Hometown = "Greensboro, NC",
                Id = 7,
                JerseyNumber = 16,
                LastName = "Campbell",
                Position = PlayerPosition.Defender,
                Weight = 188,
                Stats = new List<PlayerStats>(),
            };
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 14, GamesStarted = 2, GoalsScored = 0, Minutes = 407, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2017, YellowCards = 1});
            p.Stats.Add(new PlayerStats(){ Assists = 1, Club = "Chicago Fire", GamesPlayed = 33, GamesStarted = 30, GoalsScored = 1, Minutes = 2823, RedCards = 0, Shots = 9, ShotsOnGoal = 2, Year = 2016, YellowCards = 1});
            playerData.Add(p);

            p = new Player{
                Age = 23,
                FirstName = "Stefan",
                Height = new PlayerHeight(){ Feet = 6, Inches = 2},
                Hometown = "Dayton, OH",
                Id = 8,
                JerseyNumber = 30,
                LastName = "Cleveland",
                Position = PlayerPosition.Goalkeeper,
                Weight = 185,
                Stats = new List<PlayerStats>(),
            };
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 0, GamesStarted = 0, GoalsScored = 0, Minutes = 0, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2017, YellowCards = 0});
            playerData.Add(p);

            p = new Player{
                Age = 23,
                FirstName = "Drew",
                Height = new PlayerHeight(){ Feet = 5, Inches = 11},
                Hometown = "Cary, IL",
                Id = 9,
                JerseyNumber = 18,
                LastName = "Conner",
                Position = PlayerPosition.Midfielder,
                Weight = 165,
                Stats = new List<PlayerStats>(),
            };
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 13, GamesStarted = 3, GoalsScored = 0, Minutes = 441, RedCards = 0, Shots = 2, ShotsOnGoal = 1, Year = 2017, YellowCards = 0});
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 0, GamesStarted = 0, GoalsScored = 0, Minutes = 0, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2016, YellowCards = 0});
            playerData.Add(p);

            p = new Player{
                Age = 30,
                FirstName = "Michael",
                Height = new PlayerHeight(){ Feet = 5, Inches = 10},
                Hometown = "Goirle, Netherlands",
                Id = 10,
                JerseyNumber = 8,
                LastName = "de Leeuw",
                Position = PlayerPosition.Forward,
                Weight = 148,
                Stats = new List<PlayerStats>(),
                Classification = PlayerClassification.International,
            };
            p.Stats.Add(new PlayerStats(){ Assists = 5, Club = "Chicago Fire", GamesPlayed = 21, GamesStarted = 18, GoalsScored = 2, Minutes = 1515, RedCards = 0, Shots = 21, ShotsOnGoal = 8, Year = 2017, YellowCards = 3});
            p.Stats.Add(new PlayerStats(){ Assists = 3, Club = "Chicago Fire", GamesPlayed = 18, GamesStarted = 17, GoalsScored = 7, Minutes = 1465, RedCards = 0, Shots = 25, ShotsOnGoal = 12, Year = 2016, YellowCards = 2});
            playerData.Add(p);

            p = new Player{
                Age = 23,
                BirthPlace = "Zagreb, Croatia",
                FirstName = "Matej",
                Height = new PlayerHeight(){ Feet = 6, Inches = 2},
                Hometown = "Zagreb, Croatia",
                Id = 11,
                JerseyNumber = 33,
                LastName = "Dekovic",
                Position = PlayerPosition.Defender,
                Weight = 180,
                Stats = new List<PlayerStats>(),
            };
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 0, GamesStarted = 0, GoalsScored = 0, Minutes = 0, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2017, YellowCards = 0});
            playerData.Add(p);

            p = new Player{
                Age = 25,
                BirthPlace = "Naperville, IL",
                FirstName = "Patrick",
                Height = new PlayerHeight(){ Feet = 6, Inches = 0},
                Hometown = "Naperville, IL",
                Id = 12,
                JerseyNumber = 22,
                LastName = "Doody",
                Position = PlayerPosition.Defender,
                Weight = 180,
                Stats = new List<PlayerStats>(),
            };
            p.Stats.Add(new PlayerStats(){ Assists = 4, Club = "Chicago Fire", GamesPlayed = 2, GamesStarted = 2, GoalsScored = 0, Minutes = 180, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2017, YellowCards = 0});
            p.Stats.Add(new PlayerStats(){ Assists = 0, Club = "Chicago Fire", GamesPlayed = 0, GamesStarted = 0, GoalsScored = 0, Minutes = 0, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2016, YellowCards = 0});
            p.Stats.Add(new PlayerStats(){ Assists = 1, Club = "Chicago Fire", GamesPlayed = 7, GamesStarted = 6, GoalsScored = 0, Minutes = 558, RedCards = 0, Shots = 0, ShotsOnGoal = 0, Year = 2015, YellowCards = 1});
            playerData.Add(p);
        }

        public List<Player> GetAllPlayers()
        {
            if (playerData != null)
            {
                return playerData.ToList();
            }

            return null;
        }

        public Player GetPlayer(int id)
        {
            if (playerData != null)
            {
                return playerData.Where(p => p.Id == id).FirstOrDefault();
            }

            return null;
        }
    }
}
