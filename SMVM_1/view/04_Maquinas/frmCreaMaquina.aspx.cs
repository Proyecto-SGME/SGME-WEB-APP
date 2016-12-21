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
    public partial class frmCreaMaquina : System.Web.UI.Page
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

        protected void ddlMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaBox(ddlModelo, 14, Convert.ToInt32(ddlMarca.SelectedValue));
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Bu_Maquinas b = new Bu_Maquinas();
            Maquinas m = new Maquinas();
            m.serie = txtNumeroSerie.Text.Trim().ToUpper();
            m.modelo_id = Convert.ToInt32(ddlModelo.SelectedValue);
            m.dateFabricacion = Convert.ToDateTime(txtFechaFabri.Text.Trim());
            m.id_user = 16712750;
            try
            {
                b.IngresaMaquinas(m);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}