using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.dal
{
    public class DistritoDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;

        public List<DistritoBO> ShowDistrito() 
        {
            List<DistritoBO> distritoBOs = new List<DistritoBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarDistrito";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    DistritoBO distrito = new DistritoBO();
                    distrito.code = Convert.ToInt32(reader["coddis"].ToString());
                    distrito.name = reader["nomdis"].ToString();
                    distrito.state = Convert.ToBoolean(reader["estdis"].ToString());
                    distritoBOs.Add(distrito);
                }   
                return distritoBOs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public List<DistritoBO> ShowAllDistrito()
        {
            List<DistritoBO> distritoBOs = new List<DistritoBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarDistritoTodo";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    DistritoBO distrito = new DistritoBO();
                    distrito.code = Convert.ToInt32(reader["coddis"].ToString());
                    distrito.name = reader["nomdis"].ToString();
                    distrito.state = Convert.ToBoolean(reader["estdis"].ToString());
                    distritoBOs.Add(distrito);
                }
                return distritoBOs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public bool addDistrito(DistritoBO distrito)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_RegistrarDistrito";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@nombre", distrito.name);
                sqlCommand.Parameters.AddWithValue("@estado", distrito.state);
                responseCode = sqlCommand.ExecuteNonQuery();
                if (responseCode == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                connection.closeConnection();
            }
        }
    }
}
