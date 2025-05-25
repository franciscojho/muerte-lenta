using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;

namespace pe.com.muertelenta.bal
{
    public class TipoPlatoBAL
    {
        private TipoPlatoDAL tipoPlatoDal = new TipoPlatoDAL();

        public List<TipoPlatoBO> ShowTipoPlato()
        {
            return tipoPlatoDal.ShowTipoPlato();
        }

        public List<TipoPlatoBO> ShowAllTipoPlato()
        {
            return tipoPlatoDal.ShowAllTipoPlato();
        }
        public bool addTipoPlato(TipoPlatoBO tipoPlatoBO)
        {
            return tipoPlatoDal.addTipoPlato(tipoPlatoBO);
        }
    }
}
