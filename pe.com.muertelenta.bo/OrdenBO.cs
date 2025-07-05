using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.muertelenta.bo
{
    public class OrdenBO
    {
        public int code { get; set; }
        public DateTime date { get; set; }
        public int clientId { get; set; }
        public int employeeId { get; set; }
        public double total { get; set; }
        public int state { get; set; }
    }
}
