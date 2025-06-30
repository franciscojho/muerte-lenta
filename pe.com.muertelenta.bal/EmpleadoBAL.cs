using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;

namespace pe.com.muertelenta.bal
{
    public class EmpleadoBAL
    {
        private EmpleadoDAL empleadoDAL = new EmpleadoDAL();

        public List<EmpleadoBO> GetEmployees()
        {
            return empleadoDAL.ShowEmpleado();
        }


        public bool AddEmployee(EmpleadoBO empleadoBO)
        {
            return empleadoDAL.AddEmpleado(empleadoBO);
        }

        public bool ValidateEmployee(EmpleadoBO empleadoBO)
        {
            return empleadoDAL.ValidateEmployee(empleadoBO);
        }
    }
}
