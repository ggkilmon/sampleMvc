using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizStreamCodeSample.Model
{
    public class StatsModel
    {
        public int Year { get; set; }
        public string Club { get; set; }
        public int GamesPlayed { get; set; }
        public int Goals { get; set; }
        public int Minutes { get; set; }
        public int Shots { get; set; }
    }
}
