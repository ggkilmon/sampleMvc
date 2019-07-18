﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvcCodeSample.Data.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public PlayerPosition Position { get; set; }
        public PlayerHeight Height { get; set; }
        public int Weight { get; set; }
        public string BirthPlace { get; set; }
        public string Hometown { get; set; }
        public int JerseyNumber { get; set; }
        public PlayerClassification Classification { get; set; }
        public List<PlayerStats> Stats { get; set; }
    }
}
