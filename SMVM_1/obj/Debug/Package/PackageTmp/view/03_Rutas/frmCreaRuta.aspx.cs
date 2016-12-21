using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;
using System.Data;

namespace SMVM_1.view._03_Rutas
{
    public partial class frmCreaRuta : System.Web.UI.Page
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
                    CargaBox(ddlTecnico, 2, 0); //carga listado de tecnicos
                    CargaBox(ddlEvento, 11, 0);//carga eventos disponibles
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('ERROR DE CONEXIÓN: \n  " + ex.ToString() + "');</script>");
            }
        }

        protected void ddlTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargaTabla(Convert.ToInt32(ddlTecnico.SelectedValue));
        }
        private void CargaTabla(int valor)
        {

            Bu_Rutas b = new Bu_Rutas();
            DataSet ds = new DataSet();
            ListadoRutasTecnicos.InnerHtml = "";
            ds = b.CargaGrid(valor);//cambiar

            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th style='width: 30px'>EVENTO</th><th  style='width: 300px'>TIPO EVENTO</th><th style='width: 300px'>CLIENTE</th><th style='width: 150px'>ESTADO</th><th style='width: 150px'>FECHA</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["EVENTO"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["TIPO EVENTO"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["CLIENTE"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["ESTADO"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["FECHA"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListadoRutasTecnicos.InnerHtml = cadena;
            }


        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Rutas r = new Rutas();
            Bu_Rutas br = new Bu_Rutas();
            try
            {
                r.evento_id = Convert.ToInt32(ddlEvento.SelectedValue);
                r.tecnico_id = Convert.ToInt32(ddlTecnico.SelectedValue);
                r.id_user = 16712750;
                br.RegistroRutaTecnico(r);
            }
            catch (Exception rr)
            {

                Response.Write("<script language=javascript>alert('ERROR:\n  " + rr.ToString() + "');</script>");
            }
            




        }
    }
}