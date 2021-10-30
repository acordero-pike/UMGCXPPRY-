using System;
using System.Collections.Generic;
using System.Text;

namespace cxp.Model
{
    public class Pedidopagar
    {
        public long pedido { get; set; }
        public string proveedor { get; set; }
        public float deuda { get; set; }
        public int dias_R { get; set; }

        public DateTime Fecha_Max { get; set;  }
    }

    }
