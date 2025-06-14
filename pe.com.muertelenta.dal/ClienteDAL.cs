using Microsoft.Data.SqlClient;
using pe.com.muertelenta.bo;
using System.Data;

namespace pe.com.muertelenta.dal
{
    public class ClienteDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;

        public List<ClienteBO> ShowCliente()
        {
            List<ClienteBO> customerPayload = new List<ClienteBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarCliente";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClienteBO customer = new ClienteBO();
                    customer.code = Convert.ToInt32(reader["codcli"].ToString());
                    customer.name = reader["nomcli"].ToString();
                    customer.firstLastName = reader["apepcli"].ToString();
                    customer.secondLastName = reader["apemcli"].ToString();
                    customer.dni = reader["dnicli"].ToString();
                    customer.birthDate = DateTime.Parse(reader["feccli"].ToString());
                    customer.address = reader["dircli"].ToString();
                    customer.phone = reader["telcli"].ToString();
                    customer.mobile = reader["celcli"].ToString();
                    customer.email = reader["corcli"].ToString();
                    customer.state = Convert.ToBoolean(reader["estcli"].ToString());
                    customer.codeDistrict = Convert.ToInt32(reader["coddis"].ToString());
                    customer.codeGender = Convert.ToInt32(reader["codsex"].ToString());
                    customer.codeDocumentType = Convert.ToInt32(reader["codtipd"].ToString());
                    customerPayload.Add(customer);
                }
                return customerPayload;
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

        public bool AddCliente(ClienteBO customerData)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_RegistrarCliente";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@nombre", customerData.name);
                sqlCommand.Parameters.AddWithValue("@apellidoparterno", customerData.firstLastName);
                sqlCommand.Parameters.AddWithValue("@apellidomaterno", customerData.secondLastName);
                sqlCommand.Parameters.AddWithValue("@dni", customerData.dni);
                sqlCommand.Parameters.AddWithValue("@fecha", customerData.birthDate);
                sqlCommand.Parameters.AddWithValue("@direccion", customerData.address);
                sqlCommand.Parameters.AddWithValue("@telefono", customerData.phone);
                sqlCommand.Parameters.AddWithValue("@celular", customerData.mobile);
                sqlCommand.Parameters.AddWithValue("@correo", customerData.email);
                sqlCommand.Parameters.AddWithValue("@estado", customerData.state);
                sqlCommand.Parameters.AddWithValue("@codigodistrito", customerData.codeDistrict);
                sqlCommand.Parameters.AddWithValue("@codigosexo", customerData.codeGender);
                sqlCommand.Parameters.AddWithValue("@codigotipodocumento", customerData.codeDocumentType);
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
