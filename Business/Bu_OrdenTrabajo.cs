using Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Bu_OrdenTrabajo
    {
        public DataSet CargaCombos(int flag, int ddlFlag)
        {
            return new Co_OrdenTrabajo().CargarComboBox(flag, ddlFlag);
        }
    }
}
