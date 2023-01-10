using System;
using System.Collections.Generic;
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
          
            DbInteraction.DbInteractor interactor = new DbInteractor(conn);
       

            String query = "SELECT id, name FROM measures";
            String response = interactor.ExecuteQueryWithResponse(query);
            Console.WriteLine(JsonSerializer.Deserialize<Templates.MeasureAndId>(response));


            return null; 
        }
    }
}
