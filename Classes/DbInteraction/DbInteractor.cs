using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Data.Common;

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
        public async Task<DbDataReader> ExecuteQueryWithResponse(String queryString)
        {
            List<object> response = new List<object>(); 
            openConnection();
            OdbcCommand cmd = new OdbcCommand(queryString, this.connection);
            var rd = await cmd.ExecuteReaderAsync();

            
            //is returned a value of this form: {"progr": num, {"val":val,"val1":val1, ..., "valn":valn}}
            return rd; 
        }
    }
}
