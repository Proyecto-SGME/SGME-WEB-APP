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
    public class Bu_Usuario
    {
        public DataSet CargaCombos(int flag, int ddlFlag)
        {
            return new Co_Usuario().CargarComboBox(flag, ddlFlag);
        }
        public int IngresaUsuario(Usuarios u)
        {
            return new Co_Usuario().IngresaUsuario(u);
        }
        public int IngresTipoaUsuario(Usuarios u)
        {
            return new Co_Usuario().IngresTipoaUsuario(u);
        }
        public int CambiaClave(Usuarios u)
        {
            return new Co_Usuario().CambiaClave(u);
        }
        public DataSet CargaGrid()
        {
            return new Co_Usuario().CargaGrid();
        }
        public DataSet CargaGridListarUsuarios()
        {
            return new Co_Usuario().CargaGridListarUsuarios();
        }
    }
}
