using System;
using System.Collections.Generic;
using System.Text;

namespace cxp.Model
{
    public class Pedidos
    {
        public int NoFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int IDUsuario { get; set; }
        public int IDProveedor { get; set; }
        public float Total { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreProveedor { get; set; }
    }
}
