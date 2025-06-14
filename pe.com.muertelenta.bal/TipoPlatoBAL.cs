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

        public bool AddTipoPlato(TipoPlatoBO tipoPlatoBO)
        {
            return tipoPlatoDal.AddTipoPlato(tipoPlatoBO);
        }

        public bool UpdateTipoPlato(TipoPlatoBO tipoPlatoBO)
        {
            return tipoPlatoDal.UpdateTipoPlato(tipoPlatoBO);
        }

        public bool DeleteTipoPlato(TipoPlatoBO tipoPlatoBO)
        {
            return tipoPlatoDal.DeleteTipoPlato(tipoPlatoBO);
        }

        public bool EnableTipoPlato(TipoPlatoBO tipoPlatoBO)
        {
            return tipoPlatoDal.EnableTipoPlato(tipoPlatoBO);
        }
    }
}
