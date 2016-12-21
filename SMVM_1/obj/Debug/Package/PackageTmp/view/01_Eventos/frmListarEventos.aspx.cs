using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;


namespace SMVM_1.view._01_Eventos
{
    public partial class frmListarEventos : System.Web.UI.Page
    {
        private void CargaBox(DropDownList control, int flag, int ddlFlag)
        {
            Bu_Eventos box = new Bu_Eventos();
            DataSet ds = box.CargaCombos(flag, ddlFlag);
            control.DataSource = ds;
            control.DataTextField = "Nombre";
            control.DataValueField = "Codigo";
            control.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargaBox(ddlEstatoEvento, 18, 0);
                }
            }
            catch (Exception)
            {
                throw;

            }
        }


        private void CargaTabla(int id_evento)
        {
            Bu_Eventos b = new Bu_Eventos();
            DataSet ds = new DataSet();
            ds = b.CargarListadoEventos(id_evento);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th>ID</th><th>NOMBRE CLIENTE</th><th>MAQUINA</th><th>TIPO FALLA</th><th>FECHA EVENTO</th><th>ESTADO</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["ID"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["NOMBRE CLIENTE"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["MAQUINA"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["TIPO FALLA"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["FECHA EVENTO"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["ESTADO"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListarEventos.InnerHtml = cadena;
            }
            else
            {
                ListarEventos.InnerHtml = "";
            }


        }


        protected void ddlEstatoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaTabla(Convert.ToInt32(ddlEstatoEvento.SelectedValue));
        }


    }
}