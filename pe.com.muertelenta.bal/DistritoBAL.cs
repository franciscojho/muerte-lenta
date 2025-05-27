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

        public bool addDistrito(DistritoBO distritoBO)
        {
            return distritoDAL.addDistrito(distritoBO);
        }
    }
}
