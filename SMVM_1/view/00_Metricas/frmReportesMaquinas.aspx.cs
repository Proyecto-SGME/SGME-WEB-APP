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
    public partial class frmReportesMaquinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaTabla();
            CargaChart();
        }
        private void CargaChart()
        {
            Bu_Maquinas b = new Bu_Maquinas();
            DataTable dt = new DataTable();

            Chart1.DataSource = b.CantidadMaquinasxMarca();
            Chart1.DataBind();
        }
        private void CargaTabla()
        {
            Bu_Maquinas b = new Bu_Maquinas();
            DataSet ds = new DataSet();
            ds = b.CantidadMaquinasxMarca();

            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th>MARCA_ID</th><th>CANTIDAD POR MARCA</th><th>MARCA_DESCRIPCION</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["MARCA_ID"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["CANTIDAD POR MARCA"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["MARCA_DESCRIPCION"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListarMaquinas.InnerHtml = cadena;
            }
            else
            {
                ListarMaquinas.InnerHtml = "";
            }


        }
    }
}