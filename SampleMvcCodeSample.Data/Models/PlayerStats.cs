using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvcCodeSample.Data.Models
{
    public class PlayerStats
    {
        public int Year { get; set; }
        public string Club { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesStarted { get; set; }
        public int GoalsScored { get; set; }
        public int Minutes { get; set; }
        public int Assists { get; set; }
        public int Shots { get; set; }
        public int ShotsOnGoal { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
    }
}
