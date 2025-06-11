using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;

namespace pe.com.muertelenta.bal
{
    public class PlatoBAL
    {
        private PlatoDAL platoDAL = new PlatoDAL();

        public List<PlatoBO> ShowPlato()
        {
            return platoDAL.ShowPlato();
        }

        public List<PlatoBO> ShowAllPlato()
        {
            return platoDAL.ShowAllPlato();
        }

        public bool AddPlato(PlatoBO platoBO)
        {
            return platoDAL.AddPlato(platoBO);
        }

        public bool UpdatePlato(PlatoBO platoBO)
        {
            return platoDAL.UpdatePlato(platoBO);
        }

        public bool DeletePlato(PlatoBO platoBO)
        {
            return platoDAL.DeletePlato(platoBO);
        }

        public bool EnablePlato(PlatoBO platoBO)
        {
            return platoDAL.EnablePlato(platoBO);
        }
    }
}
