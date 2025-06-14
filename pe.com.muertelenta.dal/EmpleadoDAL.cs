using Microsoft.Data.SqlClient;
using pe.com.muertelenta.bo;
using System.Data;

namespace pe.com.muertelenta.dal
{
    public class EmpleadoDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;

        public List<EmpleadoBO> ShowEmpleado()
        {
            List<EmpleadoBO> employeePayload = new List<EmpleadoBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_MostrarEmpleado";
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    EmpleadoBO employee = new EmpleadoBO();
                    employee.code = Convert.ToInt32(reader["codemp"].ToString());
                    employee.name = reader["nomemp"].ToString();
                    employee.firstLastName = reader["apepemp"].ToString();
                    employee.secondLastName = reader["apememp"].ToString();
                    employee.dni = reader["dniemp"].ToString();
                    employee.birthDate = DateTime.Parse(reader["fecemp"].ToString());
                    employee.address = reader["diremp"].ToString();
                    employee.phone = reader["telemp"].ToString();
                    employee.mobile = reader["celemp"].ToString();
                    employee.email = reader["coremp"].ToString();
                    employee.username = reader["usuemp"].ToString();
                    employee.password = reader["claemp"].ToString();
                    employee.state = Convert.ToBoolean(reader["estemp"].ToString());
                    employee.codeDistrict = Convert.ToInt32(reader["coddis"].ToString());
                    employee.codeGender = Convert.ToInt32(reader["codsex"].ToString());
                    employee.codeRole = Convert.ToInt32(reader["codrol"].ToString());
                    employee.codeDocumentType = Convert.ToInt32(reader["codtipd"].ToString());
                    employeePayload.Add(employee);
                }
                return employeePayload;
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

        public bool AddEmpleado(EmpleadoBO empleadoData)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_RegistrarDistrito";
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@nombre", empleadoData.name);
                sqlCommand.Parameters.AddWithValue("@apellidoparterno", empleadoData.firstLastName);
                sqlCommand.Parameters.AddWithValue("@apellidomaterno", empleadoData.secondLastName);
                sqlCommand.Parameters.AddWithValue("@dni", empleadoData.dni);
                sqlCommand.Parameters.AddWithValue("@fecha", empleadoData.birthDate);
                sqlCommand.Parameters.AddWithValue("@direccion", empleadoData.address);
                sqlCommand.Parameters.AddWithValue("@telefono", empleadoData.phone);
                sqlCommand.Parameters.AddWithValue("@celular", empleadoData.mobile);
                sqlCommand.Parameters.AddWithValue("@correo", empleadoData.email);
                sqlCommand.Parameters.AddWithValue("@usuario", empleadoData.username);
                sqlCommand.Parameters.AddWithValue("@clave", empleadoData.password);
                sqlCommand.Parameters.AddWithValue("@estado", empleadoData.state);
                sqlCommand.Parameters.AddWithValue("@codigodistrito", empleadoData.codeDistrict);
                sqlCommand.Parameters.AddWithValue("@codigosexo", empleadoData.codeGender);
                sqlCommand.Parameters.AddWithValue("@codigotipodocumento", empleadoData.codeDocumentType);
                sqlCommand.Parameters.AddWithValue("@codigorol", empleadoData.state);
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
