using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;

namespace pe.com.muertelenta.bal
{
    public class SexoBAL
    {
        private SexoDAL sexoDAL = new SexoDAL();

        public List<SexoBO> ShowSexo()
        {
            return sexoDAL.ShowSexo();
        }

        public List<SexoBO> ShowAllSexo()
        {
            return sexoDAL.ShowAllSexo();
        }

        public bool addSexo(SexoBO sexo)
        {
            return sexoDAL.addSexo(sexo);
        }
    }
}
