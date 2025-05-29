using Microsoft.Data.SqlClient;
using pe.com.muertelenta.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.muertelenta.dal
{
    public class RolDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;

        public List<RolBO> ShowRol()
        {
            List<RolBO> rolBOs = new List<RolBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarRol";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    RolBO rol= new RolBO();
                    rol.code = Convert.ToInt32(reader["codrol"].ToString());
                    rol.name = reader["nomrol"].ToString();
                    rol.state = Convert.ToBoolean(reader["estrol"].ToString());
                    rolBOs.Add(rol);
                }
                return rolBOs;
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

        public List<RolBO> ShowAllRol()
        {
            List<RolBO> rolBOs = new List<RolBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarTodoRol";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    RolBO rol = new RolBO();
                    rol.code = Convert.ToInt32(reader["codrol"].ToString());
                    rol.name = reader["nomrol"].ToString();
                    rol.state = Convert.ToBoolean(reader["estrol"].ToString());
                    rolBOs.Add(rol);
                }
                return rolBOs;
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

        public bool AddRol(RolBO rol)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_RegistrarRol";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@nombre", rol.name);
                sqlCommand.Parameters.AddWithValue("@estado", rol.state);
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
