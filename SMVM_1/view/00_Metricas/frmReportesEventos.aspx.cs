using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Web.Script.Services;
using System.Web.Services;
using Entity;

namespace SMVM_1.view._00_Metricas
{
    public partial class frmReportesEventos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            CargaTabla();
            CargaChart();
        }
        private void CargaChart()
        {
            Bu_Eventos b = new Bu_Eventos();
            Chart1.DataSource = b.CantidadEventos_Maquina();
            Chart1.DataBind();
        }
        private void CargaTabla()
        {
            Bu_Eventos b = new Bu_Eventos();
            DataSet ds = new DataSet();
            ds = b.CantidadEventos_Maquina();

            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th>ID</th><th>CANT_EVENTO</th><th>MAQUINA</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["ID"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["CANT_EVENTOS"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["MAQUINA"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListarEventos.InnerHtml = cadena;
            }
            else
            {
                ListarEventos.InnerHtml = "";
            }


        }
    }
}