using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidoneDataCleaner.Classes.Templates
{
    internal class Sample : Classes.Interfaces.Sample
    {
        public string name { get; set; }
        public int id { get; set; }
        public DateTime datetime { get; set; }
        public string stationName { get; set; }
        public int Flag { get; set; }
        public double value { get; set; }
    }
}
