using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Configuration;

namespace Controller
{
    public class Co_Conexion
    {
        public string LeerConexion()
        {
            try
            {
                return

                    ConfigurationManager.ConnectionStrings["sgme"].ConnectionString;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
