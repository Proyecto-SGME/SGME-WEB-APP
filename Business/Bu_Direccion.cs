using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Controller;

namespace Business
{
    public class Bu_Direccion
    {
        public DataSet CargarComboBox(int flag, int ddlFlag)
        {
            return new Co_Direccion().CargarComboBox(flag, ddlFlag);
        }
        public int RegistraDireccion(Direcciones d)
        {
            return new Co_Direccion().RegistraDireccion(d);
        }
    }
}
