using pe.com.muertelenta.bo;
using System.Data;

namespace pe.com.muertelenta.dal
{
    public class TipoDocumentoDAL
    {
        private SetupLookupItemDAL ProviderSetup = new SetupLookupItemDAL();
        private LookupItemDAL LookupProvider;

        public TipoDocumentoDAL()
        {
            ProviderSetup.GetLookupItemsCommandText = "SP_MostrartTipoDocumento";
            ProviderSetup.GetAllLookupItemsCommandText = "SP_MostrarTipoDocumentoTodo";
            ProviderSetup.AddLookupItemCommandText = "SP_RegistrarTipoDocumento";
            ProviderSetup.UpdateLookupItemCommandText = "SP_ActualizarTipoDocumento";
            ProviderSetup.EnableLookupItemCommandText = "SP_HabilitarTipoDocumento";
            ProviderSetup.DeleteLookupItemCommandText = "SP_EliminarTipoDocumento";
            ProviderSetup.DbSuffix = "tipd";
            LookupProvider = new LookupItemDAL(ProviderSetup);
        }

        public List<TipoDocumentoBO> ShowTipoDocumento()
        {
            List<LookupItemBO> items = LookupProvider.GetLookupItems();
            List<TipoDocumentoBO> documentTypes = items.Select(item => new TipoDocumentoBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return documentTypes;
        }

        public List<TipoDocumentoBO> ShowAllTipoDocumento()
        {
            List<LookupItemBO> items = LookupProvider.GetAllLookupItems();
            List<TipoDocumentoBO> documentTypes = items.Select(item => new TipoDocumentoBO
            {
                code = item.code,
                name = item.name,
                state = item.state
            }).ToList();

            return documentTypes;
        }

        public bool AddTipoDocumento(TipoDocumentoBO documentType)
        {
            return LookupProvider.AddLookupItem(documentType);
        }

        public bool UpdateTipoDocumento(TipoDocumentoBO documentType)
        {
            return LookupProvider.UpdateLookupItem(documentType);
        }

        public bool EnableTipoDocumento(TipoDocumentoBO documentType)
        {
            return LookupProvider.EnableLookupItem(documentType);
        }

        public bool DeleteTipoDocumento(TipoDocumentoBO documentType)
        {
            return LookupProvider.DeleteLookupItem(documentType);
        }
    }
}
