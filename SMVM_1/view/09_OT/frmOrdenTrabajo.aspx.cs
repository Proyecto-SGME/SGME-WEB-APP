using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;
using Entity;

namespace SMVM_1.view._09_OT
{
    public partial class frmOrdenCompra : System.Web.UI.Page
    {
        private void CargaBox(DropDownList control, int flag, int ddlFlag)
        {
            Bu_OrdenTrabajo box = new Bu_OrdenTrabajo();
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
                    CargaBox(ddlCliente, 19, 0); //19 - Carga las empresas
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            OT ot = new OT();
            Bu_OrdenTrabajo bu = new Bu_OrdenTrabajo();
            if (ddlCliente.SelectedValue == "0")
            {
                Response.Write("<script language=javascript>alert('DEBES SELECCIONAR UNA EMPRESA');</script>");
            }
            else
            {
                ot.fecha_inicio = Convert.ToDateTime(txtFechaTrabajo.Text.Trim());
            }
            //else if (txtRequerimiento.t)
            //{
            //    //u.usuario_rut = v.Aux;
            //    //u.usuario_dv = v.dv;
            //    //u.usuario_us = txtUs.Text.Trim();
            //    //u.usuario_pw = txtPw.Text.Trim();
            //    //u.usuario_nombre = txtNombre.Text.Trim();
            //    //u.usuario_paterno = txtPaterno.Text.Trim();
            //    //u.usuario_materno = txtMaterno.Text.Trim();
            //    //u.usuario_nacimiento = Convert.ToDateTime(txtNacimiento.Text.Trim());
            //    //u.id_user = 16712750;
            //    //u.tipo_usuario_id = Convert.ToInt32(ddlTipoUsuario.SelectedValue);
            //    //bu.IngresaUsuario(u);
            //}
            //else
            //{
            //    Response.Write("<script language=javascript>alert('RUT INVALIDO VERIFIQUE');</script>");
            //}
        }
    }
}