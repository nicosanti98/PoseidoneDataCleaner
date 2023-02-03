using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArpaDataParser
{
    class RowElement
    {
        public RowElement()
        {

        }

        public int Year;
        public int Month;
        public int Day;
        public int Hour;
        public int Minute;
        public DateTime date;
        public List<String> measures; 


        public void ConvertToDateTime()
        {
            this.date = new DateTime(Year, Month, Day, Hour, Minute, 0);
        }


    }
}
