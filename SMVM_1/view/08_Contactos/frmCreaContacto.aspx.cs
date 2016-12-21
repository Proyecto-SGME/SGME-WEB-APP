using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;
using System.Data;

namespace SMVM_1.view.Formularios_Contactos
{
    public partial class frmCreaContacto : System.Web.UI.Page
    {
        private void CargaBox(DropDownList control, int flag, int ddlFlag)
        {
            Bu_Contactos box = new Bu_Contactos();
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
                    CargaBox(ddlUbicacion, 4, 0); //6 - Carga los Clientes
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Bu_Contactos bc = new Bu_Contactos();
            Contactos c = new Contactos();
            try
            {
                c.ubicacion_id = Convert.ToInt32(ddlUbicacion.SelectedValue);
                c.nombre = txtNombre.Text.Trim().ToUpper();
                c.paterno = txtPaterno.Text.Trim().ToUpper();
                c.materno = txtMaterno.Text.Trim().ToUpper();
                c.celular = txtCelular.Text.Trim().ToUpper();
                c.fono = txtFijo.Text.Trim().ToUpper();
                c.email = txtEmail.Text.Trim().ToUpper();
                c.id_user = 16712750;
                bc.IngresaContactos(c);
                limpiar();
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }

        private void limpiar()
        {
            ddlUbicacion.SelectedIndex = 0;
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtCelular.Text = "";
            txtFijo.Text = "";
            txtEmail.Text = "";

        }
    }
}