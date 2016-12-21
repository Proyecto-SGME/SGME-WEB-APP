using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;

namespace SMVM_1.view.Formularios_Maquinas
{
    public partial class frmCrearMarcaModelo : System.Web.UI.Page
    {
        private void CargaBox(DropDownList control, int flag, int ddlFlag)
        {
            Bu_Maquinas box = new Bu_Maquinas();
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
                    CargaBox(ddlMarca, 13, 0);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnRegistraMarca_Click(object sender, EventArgs e)
        {
            Bu_Maquinas b = new Bu_Maquinas();
            Maquinas m = new Maquinas();
            //m.marca_id = txtNumeroSerie.Text.Trim().ToUpper();
            m.descripcion = txtMarca.Text.Trim().ToUpper();
            m.id_user = 16712750;
            try
            {
                b.IngresaMarca(m);
            }
            catch (Exception)
            {
                throw;
            }

            CargaBox(ddlMarca, 13, 0);
        }

        protected void btnRegistraModelo_Click(object sender, EventArgs e)
        {
            if (ddlMarca.SelectedValue=="0")
            {
                lblError.Text = "NO HA REGISTRADO MARCA PARA MODELO";
            }
            else
            {
                Bu_Maquinas b = new Bu_Maquinas();
                Maquinas m = new Maquinas();
                //m.marca_id = txtNumeroSerie.Text.Trim().ToUpper();
                m.descripcion = txtModelo.Text.Trim().ToUpper();
                m.marca_id = Convert.ToInt32(ddlMarca.SelectedValue);
                m.id_user = 16712750;
                try
                {
                    b.IngresaModelo(m);
                    limpiar();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void limpiar()
        {
            txtMarca.Text = "";
            lblError.Text = "";
            txtModelo.Text = "";
            ddlMarca.SelectedIndex = 0;
        }
    }
}