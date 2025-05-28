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
    public class SexoDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;

        public List<SexoBO> ShowSexo() {
            List<SexoBO> sexoBOs = new List<SexoBO>();
            try {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarSexo";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    SexoBO sexo = new SexoBO();
                    sexo.code = Convert.ToInt32(reader["codsex"].ToString());
                    sexo.name = reader["nomsex"].ToString();
                    sexo.state = Convert.ToBoolean(reader["estsex"].ToString());
                    sexoBOs.Add(sexo);
                }
                return sexoBOs;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public List<SexoBO> ShowAllSexo()
        {
            List<SexoBO> sexoBOs = new List<SexoBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarTodoSexo";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    SexoBO sexo = new SexoBO();
                    sexo.code = Convert.ToInt32(reader["codsex"].ToString());
                    sexo.name = reader["nomsex"].ToString();
                    sexo.state = Convert.ToBoolean(reader["estsex"].ToString());
                    sexoBOs.Add(sexo);
                }
                return sexoBOs;
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

        public bool addSexo(SexoBO sexo)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_RegistrarSexo";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@nombre", sexo.name);
                sqlCommand.Parameters.AddWithValue("@estado", sexo.state);
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
