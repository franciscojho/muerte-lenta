using Microsoft.Data.SqlClient;
using pe.com.muertelenta.bo;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace pe.com.muertelenta.dal
{
    public class DistritoDAL
    {
        private SetupLookupItemDAL ProviderSetup = new SetupLookupItemDAL();
        private LookupItemDAL LookupProvider;


        public DistritoDAL()
        {
            ProviderSetup.GetLookupItemsCommandText = "SP_MostrarDistrito";
            ProviderSetup.GetAllLookupItemsCommandText = "SP_MostrartTodoDistrito";
            ProviderSetup.AddLookupItemCommandText = "SP_RegistrarDistrito";
            ProviderSetup.UpdateLookupItemCommandText = "SP_ActualizarDistrito";
            ProviderSetup.EnableLookupItemCommandText = "SP_HabilitarDistrito";
            ProviderSetup.DeleteLookupItemCommandText = "SP_EliminarDistrito";
            ProviderSetup.DbSuffix = "dis";
            LookupProvider = new LookupItemDAL(ProviderSetup);
        }

        public List<DistritoBO> ShowDistrito() 
        {
            List<LookupItemBO> items = LookupProvider.GetLookupItems();
            List<DistritoBO> districts = items.Select(item => new DistritoBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return districts;
        }

        public List<DistritoBO> ShowAllDistrito()
        {
            List<LookupItemBO> items = LookupProvider.GetAllLookupItems();
            List<DistritoBO> districts = items.Select(item => new DistritoBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return districts;
        }

        public bool AddDistrito(DistritoBO district)
        {
            return LookupProvider.AddLookupItem(district);
        }

        public bool UpdateDistrito(DistritoBO district)
        {
            return LookupProvider.UpdateLookupItem(district);
        }

        public bool EnableDistrito(DistritoBO district)
        {
            return LookupProvider.EnableLookupItem(district);
        }

        public bool DeleteDistrito(DistritoBO district)
        {
            return LookupProvider.DeleteLookupItem(district);
        }
    }
}
