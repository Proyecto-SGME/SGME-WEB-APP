using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;
using System.Data;

namespace SMVM_1.view
{
    public partial class frmClientes : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                  
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidaRut v = new ValidaRut();
            Bu_Clientes r = new Bu_Clientes();
            Clientes c = new Clientes();
            bool rut_valido = v.validarRut(txtRut.Text.Trim().ToUpper());
            if (rut_valido == true)
            {
                
                //c.flag = 1;
                c.cliente_rut = v.Aux;
                c.cliente_dv = v.dv; ;
                c.cliente_nombre = txtNombre.Text.Trim().ToUpper();
                c.cliente_paterno = txtPaterno.Text.Trim().ToUpper();
                c.cliente_materno = txtMaterno.Text.Trim().ToUpper();
                c.cliente_nacimiento = Convert.ToDateTime(txtNacimiento.Text.Trim().ToUpper());
                c.id_user = 16712750;
                c.datos_cliente_celular = txtCelular.Text.Trim().ToUpper();
                c.datos_cliente_fono = txtFijo.Text.Trim().ToUpper();
                c.datos_cliente_email = txtEmail.Text.Trim().ToUpper();

                r.IngresaClientes(c);
                recarga();
            }
            else
            {
                Response.Write("<script language=javascript>alert('Rut Incorrecto Verifique');</script>");
                txtRut.Focus();
            }

        }

        private void recarga()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtNacimiento.Text = "";
            txtCelular.Text = "";
            txtFijo.Text = "";
            txtEmail.Text = "";
        }

    }
}