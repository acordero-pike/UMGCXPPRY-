using System;
using System.Collections.Generic;
using System.Text;

namespace cxp.Model
{
    public class Productos
    {
        public int idproducto { get; set; }
        public string nombreproducto { get; set; }
        public int idtipoproducto { get; set; } 
        public int stock { get; set; }
        public decimal precio { get; set; }
    }
}
