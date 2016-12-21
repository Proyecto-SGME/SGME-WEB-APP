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
    public class Bu_Ubicaciones
    {
        public DataSet CargarComboBox(int flag, int ddlFlag)
        {
            return new Co_Ubicaciones().CargarComboBox(flag, ddlFlag);
        }
        public int IngresaHorarios(Ubicaciones u)
        {
            return new Co_Ubicaciones().IngresaHorarios(u);
        }
        public DataSet CargaGridHorarios()
        {
            return new Co_Ubicaciones().CargaGridHorarios();
        }
        public int IngresaUbicacion(Ubicaciones u)
        {
            return new Co_Ubicaciones().IngresaUbicacion(u);
        }
        public DataSet CargaGridUbicaciones()
        {
            return new Co_Ubicaciones().CargaGridUbicaciones();
        }
        
    }
}
