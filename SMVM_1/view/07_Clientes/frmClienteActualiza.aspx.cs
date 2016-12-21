using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;
using System.Data;

namespace SMVM_1.view.FormulariosClientes
{
    public partial class frmClienteActualiza : System.Web.UI.Page
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
      
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ValidaRut v = new ValidaRut();
            Bu_Clientes b = new Bu_Clientes();
            Clientes c = new Clientes();
            bool rut_valido = v.validarRut(txtRut.Text.Trim().ToUpper());
            
            if (rut_valido==true)
            {
                c.flag = 2;
                c.cliente_rut = v.Aux;
                //c.cliente_dv = v.dv;
                DataSet ds = b.BuscaCliente(c);

                foreach (DataRow d in ds.Tables[0].Rows)
                {
                    txtNombre.Text = d["nombre"].ToString();
                }
                ds.Clear();
            }
            
            
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ValidaRut v = new ValidaRut();
            bool rut_valido = v.validarRut(txtRut.Text.Trim().ToUpper());
            if (rut_valido == true)
            {
                Bu_Clientes b = new Bu_Clientes();
                Clientes c = new Clientes();

                c.flag = 1;
                c.cliente_rut = v.Aux;
                c.datos_cliente_celular = txtCelular.Text.Trim();
                c.datos_cliente_fono = txtFijo.Text.Trim();
                c.datos_cliente_email = txtEmail.Text.Trim();
                c.id_user = 16712750;
                b.IngresaDatoCliente(c);

                limpiar();
            }
            else
            {
                //Response.Write("<script language=javascript>alert('No Has Verificado el Rut\n O es Incorrecto Verifique');</script>");
                txtRut.Focus();
            }
            

        }

        private void limpiar()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtCelular.Text = "";
            txtFijo.Text = "";
            txtEmail.Text = "";
        }

      
    }
}