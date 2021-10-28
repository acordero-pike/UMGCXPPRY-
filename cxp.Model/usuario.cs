using System;
using System.Collections.Generic;
using System.Text;

namespace cxp.Model
{
    public class usuario
    {
        public int ID_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido_P { get; set; }
        public string Apellido_S { get; set; }
        public string Correo { get; set; }
        public string Tipo_Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
