using System.Data;
using pe.com.muertelenta.bo;


namespace pe.com.muertelenta.dal
{
    public class SexoDAL
    {
        private SetupLookupItemDAL ProviderSetup = new SetupLookupItemDAL();
        private LookupItemDAL LookupProvider;

        public SexoDAL()
        {
            ProviderSetup.GetLookupItemsCommandText = "SP_MostrarSexo";
            ProviderSetup.GetAllLookupItemsCommandText = "SP_MostrartTodoSexo";
            ProviderSetup.AddLookupItemCommandText = "SP_RegistrarSexo";
            ProviderSetup.UpdateLookupItemCommandText = "SP_ActualizarSexo";
            ProviderSetup.EnableLookupItemCommandText = "SP_HabilitarSexo";
            ProviderSetup.DeleteLookupItemCommandText = "SP_EliminarSexo";
            ProviderSetup.DbSuffix = "sex";
            LookupProvider = new LookupItemDAL(ProviderSetup);
        }

        public List<SexoBO> ShowSexo()
        {
            List<LookupItemBO> items = LookupProvider.GetLookupItems();
            List<SexoBO> genders = items.Select(item => new SexoBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return genders;
        }

        public List<SexoBO> ShowAllSexo()
        {
            List<LookupItemBO> items = LookupProvider.GetAllLookupItems();
            List<SexoBO> genders = items.Select(item => new SexoBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return genders;
        }

        public bool AddSexo(SexoBO gender)
        {
            return LookupProvider.AddLookupItem(gender);
        }

        public bool UpdateSexo(SexoBO gender)
        {
            return LookupProvider.UpdateLookupItem(gender);
        }

        public bool EnableSexo(SexoBO gender)
        {
            return LookupProvider.EnableLookupItem(gender);
        }

        public bool DeleteSexo(SexoBO gender)
        {
            return LookupProvider.DeleteLookupItem(gender);
        }
    }
}
