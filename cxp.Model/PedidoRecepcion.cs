using System;
using System.Collections.Generic;
using System.Text;

namespace cxp.Model
{
    public class PedidoRecepcion
    {
        public int pedido { get; set; }
        public string proveedor { get; set; }
        public float deuda { get; set; }

        public DateTime Fecha  { get; set; }

        public bool Recibido { get; set; }

    }
}
