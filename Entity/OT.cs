using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OT
    {
        public DateTime fecha_trabajo { get; set; }
        public string hora_inicio { get; set; }
        public string hora_fin { get; set; }
        public int cantidad_hora { get; set; }
        public string requerimiento { get; set; }
        public string solucion { get; set; }
        public int contacto_empresa_id { get; set; }
        public int id_user { get; set; }

    }
}
