using Microsoft.Data.SqlClient;
using pe.com.muertelenta.bo;
using System.Data;

namespace pe.com.muertelenta.dal
{
    public class PlatoDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;

        public List<PlatoBO> ShowPlato()
        {
            List<PlatoBO> PlatoBOs = new List<PlatoBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarPlato";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    PlatoBO platoBO = new PlatoBO();
                    TipoPlatoBO tipoPlatoBO = new TipoPlatoBO();

                    platoBO.code = Convert.ToInt32(reader["codplat"].ToString());
                    platoBO.name = reader["nomplat"].ToString();
                    platoBO.description = reader["desplat"].ToString();
                    platoBO.price = Convert.ToDouble(reader["preplat"].ToString());
                    platoBO.quantity = Convert.ToInt32(reader["canplat"].ToString());
                    platoBO.state = Convert.ToBoolean(reader["estplat"].ToString());

                    tipoPlatoBO.code = Convert.ToInt32(reader["codtipp"].ToString());
                    tipoPlatoBO.name = reader["nomtipp"].ToString();
                    platoBO.dishType = tipoPlatoBO;

                    PlatoBOs.Add(platoBO);
                }
                return PlatoBOs;
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

        public List<PlatoBO> ShowAllPlato()
        {
            List<PlatoBO> PlatoBOs = new List<PlatoBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarPlatoTodo";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    PlatoBO platoBO = new PlatoBO();
                    TipoPlatoBO tipoPlatoBO = new TipoPlatoBO();

                    platoBO.code = Convert.ToInt32(reader["codplat"].ToString());
                    platoBO.name = reader["nomplat"].ToString();
                    platoBO.description = reader["desplat"].ToString();
                    platoBO.price = Convert.ToDouble(reader["preplat"].ToString());
                    platoBO.quantity = Convert.ToInt32(reader["canplat"].ToString());
                    platoBO.state = Convert.ToBoolean(reader["estplat"].ToString());

                    tipoPlatoBO.code = Convert.ToInt32(reader["codtipp"].ToString());
                    tipoPlatoBO.name = reader["nomtipp"].ToString();
                    platoBO.dishType = tipoPlatoBO;

                    PlatoBOs.Add(platoBO);
                }
                return PlatoBOs;
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

        public bool AddPlato(PlatoBO platoBO)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_RegistrarPlato";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@nombre", platoBO.name);
                sqlCommand.Parameters.AddWithValue("@descripcion", platoBO.description);
                sqlCommand.Parameters.AddWithValue("@precio", platoBO.price);
                sqlCommand.Parameters.AddWithValue("@cantidad", platoBO.quantity);
                sqlCommand.Parameters.AddWithValue("@estado", platoBO.state);
                sqlCommand.Parameters.AddWithValue("@codtipp", platoBO.dishType.code);
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

        public bool UpdatePlato(PlatoBO platoBO)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_ActualizarPlato";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@codigo", platoBO.code);
                sqlCommand.Parameters.AddWithValue("@nombre", platoBO.name);
                sqlCommand.Parameters.AddWithValue("@descripcion", platoBO.description);
                sqlCommand.Parameters.AddWithValue("@precio", platoBO.price);
                sqlCommand.Parameters.AddWithValue("@cantidad", platoBO.quantity);
                sqlCommand.Parameters.AddWithValue("@estado", platoBO.state);
                sqlCommand.Parameters.AddWithValue("@codtipp", platoBO.dishType.code);
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

        public bool DeletePlato(PlatoBO platoBO)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_EliminarPlato";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@codigo", platoBO.code);
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

        public bool EnablePlato(PlatoBO tipoPlato)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_HabilitarPlato";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@codigo", tipoPlato.code);
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
