using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMVM_1.view._02_Usuarios
{
    public partial class frmListarUsuarios : System.Web.UI.Page
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
        private void CargaTabla()
        {
            Bu_Usuario b = new Bu_Usuario();
            DataSet ds = new DataSet();
            ds = b.CargaGridListarUsuarios();

            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th style='width: 100px'>USUARIO</th><th>NOMBRE</th><th>FECHA DE NACIMIENTO</th><th>TIPO USUARIO</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["USUARIO"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["NOMBRE"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["FECHA DE NACIMIENTO"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["TIPO USUARIO"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListarUsuarios.InnerHtml = cadena;
            }


        }

        //protected void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    CargaTabla();
        //}

    }
}