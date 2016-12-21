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
    public class Bu_Rutas
    {
        public DataSet CargaGrid(int id_tecnico)
        {
            return new Co_Rutas().CargaGrid(id_tecnico);
        }
        public int RegistroRutaTecnico(Rutas r)
        {
            return new Co_Rutas().RegistroRutaTecnico(r);
        }
        public DataSet CantidadRutasTecnico()
        {
            return new Co_Rutas().CantidadRutasTecnico();
        }
    }
}
