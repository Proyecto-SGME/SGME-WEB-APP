using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Entity;

namespace Business
{
    public class Bu_Maquinas
    {
        public DataSet CargaCombos(int flag, int ddlFlag)
        {
            return new Co_Maquinas().CargarComboBox(flag, ddlFlag);
        }

        public int IngresaMaquinas(Maquinas m)
        {
            return new Co_Maquinas().IngresaMaquinas(m);
        }

        public int IngresaMarca(Maquinas m)
        {
            return new Co_Maquinas().IngresaMarca(m);
        }
        public int IngresaModelo(Maquinas m)
        {
            return new Co_Maquinas().IngresaModelo(m);
        }

        public int RegistraInstalacionMaquina(Maquinas m)
        {
            return new Co_Maquinas().RegistraInstalacionMaquina(m);
        }

    }
}
