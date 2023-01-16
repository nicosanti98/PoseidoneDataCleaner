using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PoseidoneDataCleaner.Classes.DbInteraction
{
    class MenervaDbComponent
    {
        public MenervaDbComponent()
        {

        }

        //Gets id and related names from associated db
        public List<Templates.MeasureAndId> getMeasureIdAndNames(OdbcConnection conn)
        {

            List<Templates.MeasureAndId> list = new List<Templates.MeasureAndId>();
            DbInteraction.DbInteractor interactor = new DbInteractor(conn);
       

            String query = "SELECT measures.id, measures.name, stations.name, stations.id FROM measures, stations WHERE measures.stationid = stations.id";
            Task<DbDataReader> reader = interactor.ExecuteQueryWithResponse(query);

            int i = 0 ; 

            while (reader.Result.Read())
            {
                Classes.Templates.MeasureAndId item = new Templates.MeasureAndId();
                item.stationName = reader.Result[2].ToString();
                item.id = int.Parse(reader.Result[0].ToString());
                item.name = reader.Result[1].ToString();
                item.stationId = int.Parse(reader.Result[3].ToString());
                list.Add(item); 
            }

            return list ; 
        }



        public List<Classes.Templates.Sample> GetSamples(OdbcConnection conn, int sampleID, DateTime start, DateTime stop, bool notnull)
        {

            List<Classes.Templates.Sample> list = new List<Classes.Templates.Sample>();
            DbInteraction.DbInteractor interactor = new DbInteractor(conn);

            string startDate = start.Year.ToString() +
                                (start.Month > 9 ? start.Month.ToString() : "0" + start.Month.ToString()) +
                                (start.Day > 9 ? start.Day.ToString() : "0" + start.Day.ToString()) +
                                " " +
                                (start.Hour > 9 ? start.Hour.ToString() : "0" + start.Hour.ToString()) +
                                ":" +
                                (start.Minute > 9 ? start.Minute.ToString() : "0" + start.Minute.ToString()) +
                                ":" +
                                (start.Second > 9 ? start.Second.ToString() : "0" + start.Second.ToString());
            string endDate = stop.Year.ToString() +
                                (stop.Month > 9 ? stop.Month.ToString() : "0" + stop.Month.ToString()) +
                                (stop.Day > 9 ? stop.Day.ToString() : "0" + stop.Day.ToString()) +
                                " " +
                                (stop.Hour > 9 ? stop.Hour.ToString() : "0" + stop.Hour.ToString()) +
                                ":" +
                                (stop.Minute > 9 ? stop.Minute.ToString() : "0" + stop.Minute.ToString()) +
                                ":" +
                                (stop.Second > 9 ? stop.Second.ToString() : "0" + stop.Second.ToString());

            String query = "";

            if (notnull)
            {
                query = "SELECT SAMPLETIME, SAMPLEVALUE, SAMPLEFLAG FROM MEASURE#" + sampleID + " WHERE SAMPLETIME BETWEEN '" + startDate + "' AND '" + endDate + "'" ;
            }
            else
            {
                query = "SELECT SAMPLETIME, SAMPLEVALUE, SAMPLEFLAG FROM MEASURE#" + sampleID + " WHERE SAMPLETIME BETWEEN '" + startDate + "' AND '" + endDate + "'" + " AND SAMPLEVALUE IS NOT NULL AND SAMPLEFLAG IS NOT NULL"; 
            }
            
            Task<DbDataReader> reader = interactor.ExecuteQueryWithResponse(query);
            
            int i = 0;

            while (reader.Result.Read())
            {
                Classes.Templates.Sample item = new Classes.Templates.Sample();
                item.datetime = DateTime.Parse(reader.Result[0].ToString());
                if(notnull) {
                    if(reader.Result[1].ToString() == "NULL")
                    {
                        item.value = 0;
                    }
                    else
                    {
                        item.value = double.Parse(reader.Result[1].ToString());
                    }
                    if(reader.Result[2].ToString() == "NULL")
                    {
                        item.Flag = 0;
                    }
                    else
                    {
                        item.Flag = int.Parse(reader.Result[2].ToString());
                    }
                    
                }
                else
                {
                    item.value = double.Parse(reader.Result[1].ToString());
                    item.Flag = int.Parse(reader.Result[2].ToString());

                }
                
               
                item.id = sampleID;
                list.Add(item);
            }


            return list;

        }


    }
}
