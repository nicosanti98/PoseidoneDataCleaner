using PoseidoneDataCleaner.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidoneDataCleaner.Classes.StatisticsTools
{
    class SampleStatistic
    {
        public Sample sample { get; set; }

        public float lowTreshold { get; set; }
        public float highTreshold { get; set; }

        public int SamplesRange { get; set; }

    }
}
