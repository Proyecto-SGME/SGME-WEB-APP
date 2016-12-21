using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class Ubicaciones
    {
        public int horario_id { get; set; }
        public int ubicacion_id { get; set; }
        public string descripcion { get; set; }
        public DateTime hApertura { get; set; }
        public DateTime hCierre { get; set; }
        public int id_user { get; set; }
        public int direccion_id { get; set; }
    }
}
