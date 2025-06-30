using Microsoft.Data.SqlClient;

namespace pe.com.muertelenta.dal
{
    public class ConnectionDAL
    {
        private SqlConnection sqlConnection;

        public SqlConnection? connect()
        {
            string dbSettings =
                "Data Source=DESKTOP-RFDMQII\\SQLEXPRESS;" +
                "Initial Catalog=bdmuertelenta2025;" +
                "Integrated Security=SSPI;" +
                "TrustServerCertificate=true;";
            // "Data Source=DESKTOP-RFDMQII\\SQLEXPRESS;Initial Catalog=bdmuertelenta2025;Integrated Security=SSPI;TrustServerCertificate=true;";
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
