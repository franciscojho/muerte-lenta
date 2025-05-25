using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace pe.com.muertelenta.dal
{
    public class ConnectionDAL
    {
        private string dbSettings = "Data Source=DESKTOP-RFDMQII\\SQLEXPRESS;Initial Catalog=bdmuertelenta2025;Integrated Security=SSPI;TrustServerCertificate=true;";
        private SqlConnection sqlConnection;

        public SqlConnection? connect()
        {
            try
            {
                sqlConnection = new SqlConnection(dbSettings);
                sqlConnection.Open();
                return sqlConnection;
            } catch(SqlException error)
            {
                Console.WriteLine(error.ToString());
                return null;
            }
        }

        public void closeConnection()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
    }
}
