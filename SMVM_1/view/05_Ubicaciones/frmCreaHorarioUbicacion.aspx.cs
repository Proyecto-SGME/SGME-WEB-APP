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
    public partial class frmCreaHorarioUbicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargaTabla();
                }
            }
            catch (Exception)
            {
                throw;

            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Bu_Ubicaciones b = new Bu_Ubicaciones();
            Ubicaciones u = new Ubicaciones();
            u.hApertura = Convert.ToDateTime(txtApertura.Text.Trim());
            u.hCierre = Convert.ToDateTime(txtCierre.Text.Trim());
            u.id_user = 16712750;
            try
            {
                b.IngresaHorarios(u);
                limpiar();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void limpiar()
        {
            txtApertura.Text = "";
            txtCierre.Text = "";
            CargaTabla();
        }

        private void CargaTabla()
        {
            Bu_Ubicaciones b = new Bu_Ubicaciones();
            DataSet ds = new DataSet();
            ds = b.CargaGridHorarios();

            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th style='width: 50px'>ID</th><th>HORA APERTURA</th><th>HORA CIERRE</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["ID"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["HORA APERTURA"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["HORA CIERRE"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListarHorarios.InnerHtml = cadena;
            }


        }

        
    }
}