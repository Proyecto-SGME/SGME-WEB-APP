using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

namespace SMVM_1.view._00_Metricas
{
    public partial class frmReportesTecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaChart();
            CargaTabla();
        }
        private void CargaChart()
        {
            Bu_Rutas b = new Bu_Rutas();
            Chart1.DataSource = b.CantidadRutasTecnico();
            Chart1.DataBind();
        }
        private void CargaTabla()
        {
            Bu_Rutas b = new Bu_Rutas();
            DataSet ds = new DataSet();
            ds = b.CantidadRutasTecnico();

            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th>ID</th><th>CANTIDAD DE RUTAS</th><th>TÉCNICO</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["ID"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["CANTIDAD DE RUTAS"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["TÉCNICO"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListarTecnico.InnerHtml = cadena;
            }
            else
            {
                ListarTecnico.InnerHtml = "";
            }


        }
    }
}