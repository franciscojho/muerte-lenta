using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.dal
{
    public class OrdenDAL
    {
        private ConnectionDAL connection = new ConnectionDAL();
        private SqlCommand sqlCommand;
        private SqlDataReader reader;

        public bool AddOrden(OrdenBO orden)
        {
            return true;
        }
    }
}
