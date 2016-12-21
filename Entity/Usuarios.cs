using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuarios
    {
        public int usuario_rut { get; set; }
        public char usuario_dv { get; set; }
        public string usuario_nombre { get; set; }
        public string usuario_paterno { get; set; }
        public string usuario_materno { get; set; }
        public string usuario_us { get; set; }
        public string usuario_pw { get; set; }
        public string usuario_pw_2 { get; set; }
        public DateTime usuario_nacimiento { get; set; }
        public int id_user { get; set; }
        public int tipo_usuario_id { get; set; }
        public string descripcion { get; set; }
    }
}
