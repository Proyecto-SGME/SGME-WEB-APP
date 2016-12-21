using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Maquinas
    {
        public int maquina_id { get; set; }
        public string serie { get; set; }
        public int modelo_id { get; set; }
        public DateTime dateFabricacion { get; set; }
        public int id_user { get; set; }
        public int marca_id { get; set; }
        public string descripcion { get; set; }
        public int ubicacion_id { get; set; }
    }
}
