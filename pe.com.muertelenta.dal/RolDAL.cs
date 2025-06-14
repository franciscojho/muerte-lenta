using pe.com.muertelenta.bo;
using System.Data;

namespace pe.com.muertelenta.dal
{
    public class RolDAL
    {
        private SetupLookupItemDAL ProviderSetup = new SetupLookupItemDAL();
        private LookupItemDAL LookupProvider;

        public RolDAL()
        {
            ProviderSetup.GetLookupItemsCommandText = "SP_MostrarRol";
            ProviderSetup.GetAllLookupItemsCommandText = "SP_MostrarTodoRol";
            ProviderSetup.AddLookupItemCommandText = "SP_RegistrarRol";
            ProviderSetup.UpdateLookupItemCommandText = "SP_ActualizarRol";
            ProviderSetup.EnableLookupItemCommandText = "SP_HabilitarRol";
            ProviderSetup.DeleteLookupItemCommandText = "SP_EliminarRol";
            ProviderSetup.DbSuffix = "rol";
            LookupProvider = new LookupItemDAL(ProviderSetup);
        }

        public List<RolBO> ShowRol()
        {
            List<LookupItemBO> items = LookupProvider.GetLookupItems();
            List<RolBO> roles = items.Select(item => new RolBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return roles;
        }

        public List<RolBO> ShowAllRol()
        {
            List<LookupItemBO> items = LookupProvider.GetAllLookupItems();
            List<RolBO> roles = items.Select(item => new RolBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return roles;
        }

        public bool AddRol(RolBO role)
        {
            return LookupProvider.AddLookupItem(role);
        }

        public bool UpdateRol(RolBO role)
        {
            return LookupProvider.UpdateLookupItem(role);
        }

        public bool EnableRol(RolBO role)
        {
            return LookupProvider.EnableLookupItem(role);
        }

        public bool DeleteRol(RolBO role)
        {
            return LookupProvider.DeleteLookupItem(role);
        }
    }
}
