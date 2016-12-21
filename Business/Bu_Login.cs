using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace Business
{
    public class Bu_Login
    {
        public int Obtiene_Usuarios(string us, string pw)
        {
            return new Co_Login().Obtiene_Usuarios(us,pw);
        }
    }
}
