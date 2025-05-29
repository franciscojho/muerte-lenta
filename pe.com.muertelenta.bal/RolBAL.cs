using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
