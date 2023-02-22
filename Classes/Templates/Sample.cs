using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PoseidoneDataCleaner.Classes.Templates
{
    public class Sample : Classes.Interfaces.Sample
    {
        public string name { get; set; }
        public int id { get; set; }
        public DateTime datetime { get; set; }
        public string stationName { get; set; }
        public int Flag { get; set; }
        public double value { get; set; }


        public static List<Sample> NormalizeDates(List<Sample> samples)
        {
            StreamReader sr = new StreamReader("../../usefulFiles/Dates.txt");
            List<DateTime> dates = new List<DateTime>();
            string date;

            while ((date = sr.ReadLine()) != null)
            {
                dates.Add(DateTime.Parse(date));
                
            }

            
            for(int i = 0; i < dates.Count; i++) { 
            
                if (samples[i].datetime.Year != dates[i].Year || 
                    samples[i].datetime.Month != dates[i].Month ||
                    samples[i].datetime.Day != dates[i].Day ||
                    samples[i].datetime.Hour != dates[i].Hour ||
                    samples[i].datetime.Minute != dates[i].Minute)
                
                //if (!samples.Exists(x => x.datetime.Day == dates.ElementAt(i).Day &&
                //x.datetime.Year == dates.ElementAt(i).Year
                //&& x.datetime.Month == dates.ElementAt(i).Month
                //&& x.datetime.Hour == dates.ElementAt(i).Hour
                //&& x.datetime.Minute == dates.ElementAt(i).Minute))
                {
                    Sample s = new Sample();
                    s.datetime = dates.ElementAt(i);
                    s.value = 0;
                    s.stationName = samples.ElementAt(i).stationName;
                    s.name = samples.ElementAt(i).stationName;
                    samples.Insert(i, s);
                }

                //if ((samples.ElementAt(i).datetime.Day != dates.ElementAt(i).Day)
                //    && (samples.ElementAt(i).datetime.Month != dates.ElementAt(i).Month)
                //    &&(samples.ElementAt(i).datetime.Year != dates.ElementAt(i).Year)
                //    && (samples.ElementAt(i).datetime.Hour != dates.ElementAt(i).Hour)
                //    && (samples.ElementAt(i).datetime.Minute != dates.ElementAt(i).Minute))
                //{
                //    Sample s = new Sample();
                //    s.datetime = dates.ElementAt(i);
                //    s.value = 0;
                //    s.stationName = samples.ElementAt(i).stationName;
                //    s.name = samples.ElementAt(i).stationName;
                //    samples.Insert(i, s);
                //}

            }


            return samples;


        }

    }
}
