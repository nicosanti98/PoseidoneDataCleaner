using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PoseidoneDataCleaner.Classes.DbInteraction
{
    class DbInteractor
    {
        OdbcConnection connection; 

        public DbInteractor(OdbcConnection conn)
        {
            this.connection = conn; 
        }

        public void openConnection()
        {
            try
            {
                this.connection.Open();
            }
            catch(Exception ex)
            {
                throw new Exception("Error during db connection opening");
            }
        }

        public void closeConnection()
        {
            this.connection.Close();
        }

        public void ExecuteQueryWithoutResponse(String queryString)
        {
            
        }

        //Execute query with return object
        public string ExecuteQueryWithResponse(String queryString)
        {
            List<object> response = new List<object>(); 
            openConnection();
            OdbcCommand cmd = new OdbcCommand(queryString, this.connection);
            OdbcDataReader rd = cmd.ExecuteReader();

            //Gets the number of columns of the result
            int numberOfColumns = rd.VisibleFieldCount;

            int j = 0; 
            while (rd.Read())
            {
               
                object item;
                List<object> listItems = new List<object>();
                for (int i = 0; i < numberOfColumns; i++)
                {
                    listItems.Add(rd[i]);
                }
                item = new { progr = j, data = listItems };
                j++;
                response.Add(item);
            }
            
            //is returned a value of this form: {"progr": num, {"val":val,"val1":val1, ..., "valn":valn}}
            return JsonSerializer.Serialize(response); 
        }
    }
}
