using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Controller;
using System.Data;

namespace Business
{
    public class Bu_Contactos
    {
        public DataSet CargaCombos(int flag, int ddlFlag)
        {
            return new Co_Contactos().CargarComboBox(flag, ddlFlag);
        }

        public int IngresaContactos(Contactos c)
        {
            return new Co_Contactos().IngresaContactos(c);
        }
    }
}
