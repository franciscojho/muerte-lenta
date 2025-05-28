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
    public class TipoDocumentoDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;

        public List<TipoDocumentoBO> ShowTipoDocumento()
        {
            List<TipoDocumentoBO> tipòDocumentoBOs= new List<TipoDocumentoBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrartTipoDocumento";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    TipoDocumentoBO tipoDocumento = new TipoDocumentoBO();
                    tipoDocumento.code = Convert.ToInt32(reader["codtipd"].ToString());
                    tipoDocumento.name = reader["nomtipd"].ToString();
                    tipoDocumento.state = Convert.ToBoolean(reader["esttipd"].ToString());
                    tipòDocumentoBOs.Add(tipoDocumento);
                }
                return tipòDocumentoBOs;
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

        public List<TipoDocumentoBO> ShowAllTipoDocumento()
        {
            List<TipoDocumentoBO> tipòDocumentoBOs = new List<TipoDocumentoBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrartTodoTipoDocumento";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    TipoDocumentoBO tipoDocumento = new TipoDocumentoBO();
                    tipoDocumento.code = Convert.ToInt32(reader["codtipd"].ToString());
                    tipoDocumento.name = reader["nomtipd"].ToString();
                    tipoDocumento.state = Convert.ToBoolean(reader["esttipd"].ToString());
                    tipòDocumentoBOs.Add(tipoDocumento);
                }
                return tipòDocumentoBOs;
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

        public bool addTipoDocumento(TipoDocumentoBO tipoDocumentoBO)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_RegistrarTipoDocumento";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@nombre", tipoDocumentoBO.name);
                sqlCommand.Parameters.AddWithValue("@estado", tipoDocumentoBO.state);
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
