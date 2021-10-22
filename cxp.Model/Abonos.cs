using System;
using System.Collections.Generic;
using System.Text;

namespace cxp.Model
{
   public class Abonos
    {
       
        public int No_Factura { get; set; }

        public decimal Cantidad_cargo_Abono { get; set; }

        public DateTime Fecha_Pago { get; set; }

        public string Tipo_C_A { get; set; }
        public int ID_Cargo_Abono { get; set; }
        public string No_Boleta { get; set; }

    }
}
