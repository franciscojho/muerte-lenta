using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;

namespace pe.com.muertelenta.bal
{
    public class SexoBAL
    {
        private SexoDAL provider = new SexoDAL();

        public List<SexoBO> ShowSexo()
        {
            return provider.ShowSexo();
        }

        public List<SexoBO> ShowAllSexo()
        {
            return provider.ShowAllSexo();
        }

        public bool AddSexo(SexoBO rolBO)
        {
            return provider.AddSexo(rolBO);
        }
        public bool UpdateSexo(SexoBO rolBO)
        {
            return provider.UpdateSexo(rolBO);
        }

        public bool DeleteSexo(SexoBO rolBO)
        {
            return provider.DeleteSexo(rolBO);
        }

        public bool EnableSexo(SexoBO rolBO)
        {
            return provider.EnableSexo(rolBO);
        }
    }
}
