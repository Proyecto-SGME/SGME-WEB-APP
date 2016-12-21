using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;
using System.Data;

namespace SMVM_1.view.Formularios_Direcciones
{
    public partial class frmCreaUbicacion : System.Web.UI.Page
    {
        private void CargaBox(DropDownList control, int flag, int ddlFlag)
        {
            Bu_Ubicaciones box = new Bu_Ubicaciones();
            DataSet ds = box.CargarComboBox(flag, ddlFlag);
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
                    CargaBox(ddlDireccion, 17, 0); //lista direcciones +  comuna
                    CargaBox(ddlHorario, 16, 0);  //lista horarios de ubicaciones
                    CargaTabla();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Bu_Ubicaciones b = new Bu_Ubicaciones();
            Ubicaciones u = new Ubicaciones();
            u.direccion_id = Convert.ToInt32(ddlDireccion.SelectedValue);
            u.descripcion = txtDetalle.Value.ToString().Trim().ToUpper();
            u.horario_id = Convert.ToInt32(ddlHorario.SelectedValue);
            u.id_user = 16712750;
            try
            {
                b.IngresaUbicacion(u);
                limpiar();
                CargaTabla();
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void CargaTabla()
        {
            Bu_Ubicaciones bu = new Bu_Ubicaciones();
            DataSet ds = new DataSet();
            ds = bu.CargaGridUbicaciones();

            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th style='width: 10px'>ID</th><th>DESCRIPCIÓN</th><th>HORARIO APERTURA</th><th>HORARIO CIERRE</th><th>DIRECCIÓN</th><th>COMUNA</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["ID"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["DESCRIPCIÓN"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["HORARIO APERTURA"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["HORARIO CIERRE"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["DIRECCIÓN"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["COMUNA"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListadoUbicaciones.InnerHtml = cadena;
            }


        }
        private void limpiar()
        {
            ddlDireccion.SelectedIndex = 0;
            ddlHorario.SelectedIndex = 0;
            txtDetalle.Value = "";
        }
    }
}