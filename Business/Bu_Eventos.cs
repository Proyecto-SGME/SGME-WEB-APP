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
    public class Bu_Eventos
    {
        public DataSet CargaCombos(int flag, int ddlFlag)
        {
            return new Co_Eventos().CargarComboBox(flag, ddlFlag);
        }

        public int IngresaEventos(Eventos e)
        {
            return new Co_Eventos().IngresaEventos(e);
        }

        public DataSet CargaGrid(int id_evento)
        {
            return new Co_Eventos().CargaGrid(id_evento);
        }
        public int IngresaDetalleEventos(DetallesEventos de)
        {
            return new Co_Eventos().IngresaDetalleEventos(de);
        }
        public int CierraEventos(DetallesEventos de)
        {
            return new Co_Eventos().CierraEventos(de);
        }
        public DataSet CargarListadoEventos(int id_evento)
        {
            return new Co_Eventos().CargarListadoEventos(id_evento);
        }
    }
}
