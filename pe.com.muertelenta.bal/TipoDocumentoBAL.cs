using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;

namespace pe.com.muertelenta.bal
{
    public class TipoDocumentoBAL
    {
        private TipoDocumentoDAL provider = new TipoDocumentoDAL();

        public List<TipoDocumentoBO> ShowTipoDocumento()
        {
            return provider.ShowTipoDocumento();
        }

        public List<TipoDocumentoBO> ShowAllTipoDocumento()
        {
            return provider.ShowAllTipoDocumento();
        }

        public bool AddTipoDocumento(TipoDocumentoBO documentType)
        {
            return provider.AddTipoDocumento(documentType);
        }

        public bool UpdateTipoDocumento(TipoDocumentoBO documentType)
        {
            return provider.UpdateTipoDocumento(documentType);
        }

        public bool DeleteTipoDocumento(TipoDocumentoBO documentType)
        {
            return provider.DeleteTipoDocumento(documentType);
        }

        public bool EnableTipoDocumento(TipoDocumentoBO documentType)
        {
            return provider.EnableTipoDocumento(documentType);
        }
    }
}
