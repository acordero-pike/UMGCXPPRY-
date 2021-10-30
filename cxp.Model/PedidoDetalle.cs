using System;
using System.Collections.Generic;
using System.Text;

namespace cxp.Model
{
    public class PedidoDetalle
    {
        public int iddetalle { get; set; }
        public long idpedido { get; set; }
        public int idproducto { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
        public decimal total { get; set; }
        public decimal totalFactura { get; set; }
        public DateTime fechaFactura { get; set; }
        public string NombreProveedor { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioProd { get; set; }
    }
}

