using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   
    public class Clientes
    {
        //seccion clientes
        public int flag  { get;  set; }
        public int cliente_rut { get;  set; }
	    public char cliente_dv { get;  set; }
	    public string cliente_nombre { get;  set; }
	    public string cliente_paterno { get;  set; }
	    public string cliente_materno { get;  set; }
        public DateTime	cliente_nacimiento { get;  set; }
	    public int id_user { get;  set; }
        //seccion datos_clientes
        public string datos_cliente_celular { get; set; }
        public string datos_cliente_fono { get; set; }
        public string datos_cliente_email { get; set; }


    }

    
}

