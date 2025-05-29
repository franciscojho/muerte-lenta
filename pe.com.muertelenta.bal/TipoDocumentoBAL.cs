using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.muertelenta.bal
{
    public class TipoDocumentoBAL
    {
        private TipoDocumentoDAL tipoDocumentoDAL = new TipoDocumentoDAL();

        public List<TipoDocumentoBO> ShowTipoDocumento()
        {
            return tipoDocumentoDAL.ShowTipoDocumento();
        }

        public List<TipoDocumentoBO> ShowAllTipoDocumento()
        {
            return tipoDocumentoDAL.ShowAllTipoDocumento();
        }

        public bool AddTipoDocumento(TipoDocumentoBO tipoDocumentoBO)
        {
            return tipoDocumentoDAL.AddTipoDocumento(tipoDocumentoBO);
        }
    }
}
