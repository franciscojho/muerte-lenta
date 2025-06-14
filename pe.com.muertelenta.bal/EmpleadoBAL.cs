using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;

namespace pe.com.muertelenta.bal
{
    public class EmpleadoBAL
    {
        private EmpleadoDAL empleadoDAL = new EmpleadoDAL();

        public List<EmpleadoBO> ShowShowEmpleado()
        {
            return empleadoDAL.ShowEmpleado();
        }


        public bool AddEmpleado(EmpleadoBO empleadoBO)
        {
            return empleadoDAL.AddEmpleado(empleadoBO);
        }
    }
}
