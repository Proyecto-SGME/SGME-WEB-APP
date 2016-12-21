using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;
using System.Data;

namespace SMVM_1.view.Formularios_Usuarios
{
    public partial class frmCreaTipoUsuario : System.Web.UI.Page
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

        
        protected void btnRegistrar_Click1(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            Bu_Usuario bu = new Bu_Usuario();
            u.descripcion = txtTipoUsuario.Text.Trim().ToUpper();
            u.id_user = 16712750;
            bu.IngresTipoaUsuario(u);
            CargaTabla();
            limpiar();

        }

        private void CargaTabla()
        {
            Bu_Usuario b = new Bu_Usuario();
            DataSet ds = new DataSet();
            ds = b.CargaGrid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th style='width: 10px'>ID</th><th>DESCRIPCIÓN</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["ID"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["DESCRIPCIÓN"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListadoTiposUsuarios.InnerHtml = cadena;
            }


        }
        private void limpiar()
        {
            txtTipoUsuario.Text = "";

        }
    }
}