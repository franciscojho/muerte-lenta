using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.muertelenta.bo
{
    public class PlatoBO
    {
        public int code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public bool state { get; set; }
        public TipoPlatoBO? dishType { get; set; }
    }
}
