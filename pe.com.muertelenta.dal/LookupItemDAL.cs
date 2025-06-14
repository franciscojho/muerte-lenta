using Microsoft.Data.SqlClient;
using pe.com.muertelenta.bo;
using System.Data;

namespace pe.com.muertelenta.dal
{
    public class SetupLookupItemDAL
    {
        public string GetLookupItemsCommandText { get; set; }
        public string GetAllLookupItemsCommandText { get; set; }
        public string AddLookupItemCommandText { get; set; }
        public string UpdateLookupItemCommandText { get; set; }
        public string DeleteLookupItemCommandText { get; set; }
        public string EnableLookupItemCommandText { get; set; }
        public string DbSuffix { get; set; }
    }

    public class LookupItemDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;
        private SetupLookupItemDAL _config = new SetupLookupItemDAL();

        public LookupItemDAL(SetupLookupItemDAL config)
        {
            _config = config;
        }

        public List<LookupItemBO> GetLookupItems(string? commandText = null)
        {
            List<LookupItemBO> lookupItems = new List<LookupItemBO>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = !string.IsNullOrEmpty(commandText) ? commandText : _config.GetLookupItemsCommandText;
                sqlCommand.Connection = connection.connect();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    LookupItemBO lookupItem = new LookupItemBO();
                    lookupItem.code = Convert.ToInt32(reader[$"cod{_config.DbSuffix}"].ToString());
                    lookupItem.name = reader[$"nom{_config.DbSuffix}"].ToString();
                    lookupItem.state = Convert.ToBoolean(reader[$"est{_config.DbSuffix}"].ToString());
                    lookupItems.Add(lookupItem);
                }
                return lookupItems;
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

        public List<LookupItemBO> GetAllLookupItems()
        {
            return GetLookupItems(_config.GetAllLookupItemsCommandText);
        }

        public bool AddLookupItem(LookupItemBO lookupItem)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = _config.AddLookupItemCommandText;
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@nombre", lookupItem.name);
                sqlCommand.Parameters.AddWithValue("@estado", lookupItem.state);
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

        public bool UpdateLookupItem(LookupItemBO lookupItem)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = _config.UpdateLookupItemCommandText;
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@codigo", lookupItem.code);
                sqlCommand.Parameters.AddWithValue("@nombre", lookupItem.name);
                sqlCommand.Parameters.AddWithValue("@estado", lookupItem.state);
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

        public bool EnableLookupItem(LookupItemBO lookupItem, string? commandText = null)
        {
            int responseCode = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = !string.IsNullOrEmpty(commandText) ? commandText : _config.EnableLookupItemCommandText;
                sqlCommand.Connection = connection.connect();
                sqlCommand.Parameters.AddWithValue("@codigo", lookupItem.code);
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

        public bool DeleteLookupItem(LookupItemBO lookupItem)
        {
            return EnableLookupItem(lookupItem, _config.DeleteLookupItemCommandText);
        }
    }
}
