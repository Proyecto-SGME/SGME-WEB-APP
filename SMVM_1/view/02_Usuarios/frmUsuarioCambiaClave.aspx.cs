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
    public partial class frmUsuarioActualiza : System.Web.UI.Page
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
                    CargaBox(ddlUsuario, 12, 0);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Bu_Usuario b = new Bu_Usuario();
            Usuarios u = new Usuarios();

            string pw1 = txtPw.Text.Trim().ToUpper();
            string pw2 = txtPwRepite.Text.Trim().ToUpper();
            if (pw1==pw2)
            {
                try
                {
                    u.usuario_rut = Convert.ToInt32(ddlUsuario.SelectedValue);
                    u.usuario_pw = pw1;
                    u.id_user = 16712750;
                    b.CambiaClave(u);
                    limpiar();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                lblError.Text = "LAS PASSWORD NO COINCIDEN POR FAVOR VALIDA";
            }
        }

        private void limpiar()
        {
            txtPw.Text = "";
            txtPwRepite.Text = "";
            lblError.Text = "";
            ddlUsuario.SelectedIndex = 0;
        }
    }
}