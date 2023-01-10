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
    }
}
