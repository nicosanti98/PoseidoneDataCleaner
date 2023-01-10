using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidoneDataCleaner.Classes.Interfaces
{
    interface Sample
    {
        String name { get; set; }
        int id { get; set; }
        DateTime datetime { get; set; }
        String stationName { get; set; }
        int Flag { get; set; }

    }
}
