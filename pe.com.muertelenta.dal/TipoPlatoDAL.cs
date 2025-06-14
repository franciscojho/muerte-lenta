using System.Data;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.dal
{
    public class TipoPlatoDAL
    {
        private SetupLookupItemDAL ProviderSetup = new SetupLookupItemDAL();
        private LookupItemDAL LookupProvider;

        public TipoPlatoDAL()
        {
            ProviderSetup.GetLookupItemsCommandText = "SP_MostrarTipoPlato";
            ProviderSetup.GetAllLookupItemsCommandText = "SP_MostrarTipoPlatoTodo";
            ProviderSetup.AddLookupItemCommandText = "SP_RegistrarTipoPlato";
            ProviderSetup.UpdateLookupItemCommandText = "SP_ActualizarTipoPlato";
            ProviderSetup.EnableLookupItemCommandText = "SP_HabilitarTipPlato";
            ProviderSetup.DeleteLookupItemCommandText = "SP_EliminarTipoPlato";
            ProviderSetup.DbSuffix = "tipp";
            LookupProvider = new LookupItemDAL(ProviderSetup);
        }

        public List<TipoPlatoBO> ShowTipoPlato()
        {
            List<LookupItemBO> items = LookupProvider.GetLookupItems();
            List<TipoPlatoBO> dishTypes = items.Select(item => new TipoPlatoBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return dishTypes;
        }

        public List<TipoPlatoBO> ShowAllTipoPlato()
        {
            List<LookupItemBO> items = LookupProvider.GetAllLookupItems();
            List<TipoPlatoBO> dishTypes = items.Select(item => new TipoPlatoBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return dishTypes;
        }

        public bool AddTipoPlato(TipoPlatoBO dishType)
        {
            return LookupProvider.AddLookupItem(dishType);
        }

        public bool UpdateTipoPlato(TipoPlatoBO dishType)
        {
            return LookupProvider.UpdateLookupItem(dishType);
        }

        public bool EnableTipoPlato(TipoPlatoBO dishType)
        {
            return LookupProvider.EnableLookupItem(dishType);
        }

        public bool DeleteTipoPlato(TipoPlatoBO dishType)
        {
            return LookupProvider.DeleteLookupItem(dishType);
        }
    }
}
