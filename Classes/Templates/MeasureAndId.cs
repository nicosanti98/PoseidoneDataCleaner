﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidoneDataCleaner.Classes.Templates
{
    public class MeasureAndId : Interfaces.Sample
    {
        public string name { get; set; }
        public int id { get; set;  }
        public DateTime datetime { get; set; }

        public int stationId { get; set; }
        public int Flag { get; set; }
        public string stationName { get; set; }
        public double value { get; set; }
    }
}
