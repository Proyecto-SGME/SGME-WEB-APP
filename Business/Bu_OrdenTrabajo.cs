using Controller;
using Entity;
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
        public int RegistrarOT(OT ot)
        {
            return new Co_OrdenTrabajo().RegistrarOT(ot);
        }
    }
}
