using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OT
    {
        public DateTime fecha_inicio { get; set; }
        public DateTime hora_inicio { get; set; }
        public DateTime hora_fin { get; set; }
        public int cantidad_hora { get; set; }
        public string requerimiento { get; set; }
        public string solucion { get; set; }
        public int empresa_rut { get; set; }
        public int usuario_rut { get; set; }

    }
}
