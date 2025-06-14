using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pe.com.muertelenta.bo
{
    public class EmpleadoBO : PersonBO
    {
        public string userName { get; set; }
        public string password { get; set; }
        public int codeRole { get; set; }
    }
}
