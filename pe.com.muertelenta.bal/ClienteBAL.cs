using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;

namespace pe.com.muertelenta.bal
{
    public class ClienteBAL
    {
        private ClienteDAL clienteDAL = new ClienteDAL();

        public List<ClienteBO> GetCustomers()
        {
            return clienteDAL.ShowCliente();
        }


        public bool AddCustomer(ClienteBO clienteBO)
        {
            return clienteDAL.AddCliente(clienteBO);
        }
    }
}
