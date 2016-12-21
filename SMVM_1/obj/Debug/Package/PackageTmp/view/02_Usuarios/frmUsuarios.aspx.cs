using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;

namespace SMVM_1.view
{
    public partial class frmUsuarios : System.Web.UI.Page
    {
        private void CargaBox(DropDownList control, int flag, int ddlFlag)
        {
            Bu_Usuario box = new Bu_Usuario();
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
                    CargaBox(ddlTipoUsuario, 1, 0); //6 - Carga los Clientes
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            Bu_Usuario bu = new Bu_Usuario();
            ValidaRut v = new ValidaRut();
            if (ddlTipoUsuario.SelectedValue=="0")
            {
                Response.Write("<script language=javascript>alert('DEBES SELeCCIONAR TIPO USUARIO');</script>");
            }
            else if (v.validarRut(txtRut.Text.Trim()))
            {
                u.usuario_rut = v.Aux;
                u.usuario_dv = v.dv;
                u.usuario_us = txtUs.Text.Trim();
                u.usuario_pw = txtPw.Text.Trim();
                u.usuario_nombre = txtNombre.Text.Trim();
                u.usuario_paterno = txtPaterno.Text.Trim();
                u.usuario_materno = txtMaterno.Text.Trim();
                u.usuario_nacimiento = Convert.ToDateTime(txtNacimiento.Text.Trim());
                u.id_user = 16712750;
                u.tipo_usuario_id = Convert.ToInt32(ddlTipoUsuario.SelectedValue);
                bu.IngresaUsuario(u);
            }
            else
            {
                Response.Write("<script language=javascript>alert('RUT INVALIDO VERIFIQUE');</script>");
            }
            
        }
    }
}