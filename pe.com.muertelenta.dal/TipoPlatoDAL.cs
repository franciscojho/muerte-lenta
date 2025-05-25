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
    public class TipoPlatoDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;

        public List<TipoPlatoBO> ShowTipoPlato() {
            List<TipoPlatoBO> tipoPlatoBOs = new List<TipoPlatoBO>();
            try {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarTipoPlato";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    TipoPlatoBO tipoPlato = new TipoPlatoBO();
                    tipoPlato.code = Convert.ToInt32(reader["codtipp"].ToString());
                    tipoPlato.name = reader["nomtipp"].ToString();
                    tipoPlato.state = Convert.ToBoolean(reader["esttipp"].ToString());
                    tipoPlatoBOs.Add(tipoPlato);
                }
                return tipoPlatoBOs;
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

        public List<TipoPlatoBO> ShowAllTipoPlato()
        {
            List<TipoPlatoBO> tipoPlatoBOs = new List<TipoPlatoBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarTipoPlatoTodo";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    TipoPlatoBO tipoPlato = new TipoPlatoBO();
                    tipoPlato.code = Convert.ToInt32(reader["codtipp"].ToString());
                    tipoPlato.name = reader["nomtipp"].ToString();
                    tipoPlato.state = Convert.ToBoolean(reader["esttipp"].ToString());
                    tipoPlatoBOs.Add(tipoPlato);
                }
                return tipoPlatoBOs;
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

        public bool addTipoPlato(TipoPlatoBO tipoPlato)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_RegistrarTipoPlato";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@nombre", tipoPlato.name);
                sqlCommand.Parameters.AddWithValue("@estado", tipoPlato.state);
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
