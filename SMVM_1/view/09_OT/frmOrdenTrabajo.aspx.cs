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
                    //CargaBox(ddlCliente, 19, 0); //6 - Carga los Clientes
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}