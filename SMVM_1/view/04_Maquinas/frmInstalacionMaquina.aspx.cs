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
    public partial class frmInstalacionMaquina : System.Web.UI.Page
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
                    CargaBox(ddlUbicacion, 4, 0); 
                    CargaBox(ddlMaquina, 15, 0); 

                }
            }
            catch (Exception ex)
            {
                
            }
        }

        protected void btnRegistra_Click(object sender, EventArgs e)
        {
            Maquinas m = new Maquinas();
            Bu_Maquinas b = new Bu_Maquinas();

            m.marca_id = Convert.ToInt32(ddlMaquina.SelectedValue);
            m.ubicacion_id = Convert.ToInt32(ddlUbicacion.SelectedValue);
            m.descripcion = txtDetalle.Value.ToString().ToUpper();
            m.id_user = 16712750;
            try
            {
                b.RegistraInstalacionMaquina(m);
                limpiar();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void limpiar()
        {
            CargaBox(ddlUbicacion, 4, 0);
            CargaBox(ddlMaquina, 15, 0); 
            txtDetalle.Value = "";
        }
    }
}