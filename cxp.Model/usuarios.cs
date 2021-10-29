using System;
using System.Collections.Generic;
using System.Text;

namespace cxp.Model
{
    public class usuarios
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellidop { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public int id_tipo_usuario { get; set; }
        public string password { get; set; }
    }
}
