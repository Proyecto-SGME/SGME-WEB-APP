using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Direcciones
    {
       

        public int comuna_id { get; set; }
        public string direccion_des { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
        public int id_user { get; set; }
        
    }
}
