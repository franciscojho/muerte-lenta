using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.muertelenta.bal
{
    public class DistritoBAL
    {
        private DistritoDAL distritoDAL = new DistritoDAL();

        public List<DistritoBO> ShowDistrito()
        {
            return distritoDAL.ShowDistrito();
        }

        public List<DistritoBO> ShowAllDistrito()
        {
            return distritoDAL.ShowAllDistrito();
        }

        public bool AddDistrito(DistritoBO distritoBO)
        {
            return distritoDAL.AddDistrito(distritoBO);
        }

        public bool UpdateDistrito(DistritoBO distritoBO)
        {
            return distritoDAL.UpdateDistrito(distritoBO);
        }

        public bool DeleteDistrito(DistritoBO distritoBO)
        {
            return distritoDAL.DeleteDistrito(distritoBO);
        }

        public bool EnableDistrito(DistritoBO distritoBO)
        {
            return distritoDAL.EnableDistrito(distritoBO);
        }
    }
}
