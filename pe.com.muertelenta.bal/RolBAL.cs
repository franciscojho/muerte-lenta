using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;

namespace pe.com.muertelenta.bal
{
    public class RolBAL
    {
        private RolDAL rolDAL = new RolDAL();

        public List<RolBO> ShowRol()
        {
            return rolDAL.ShowRol();
        }

        public List<RolBO> ShowAllRol()
        {
            return rolDAL.ShowAllRol();
        }

        public bool AddRol(RolBO rolBO)
        {
            return rolDAL.AddRol(rolBO);
        }
        public bool UpdateRol(RolBO rolBO)
        {
            return rolDAL.UpdateRol(rolBO);
        }

        public bool DeleteRol(RolBO rolBO)
        {
            return rolDAL.DeleteRol(rolBO);
        }
    }
}
