using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;
using Entity;



namespace SMVM_1.view
{
    public partial class frmRegistroEvento : System.Web.UI.Page
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
                    CargaBox(ddlCliente, 6, 0); //6 - Carga los Clientes
                    CargaBox(ddlTipoEvento, 3, 0); //3 - es tipo de evento
                    CargaBox(ddlUbicacion, 4, 0); //4 - son las ubicaciones de las maquinas
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        protected void btnAgregar_Click(object sender, EventArgs a)
        {
            try
            {
                Bu_Eventos r = new Bu_Eventos();
                Eventos e = new Eventos();
                e.tipo_evento = Convert.ToInt32(ddlTipoEvento.SelectedValue);
                e.cliente_rut = Convert.ToInt32(ddlCliente.SelectedValue);
                e.maquina_id = Convert.ToInt32(ddlMaquina.SelectedValue);
                e.detalle_eventos = txtDetalle.Value.ToString();
                e.id_user = 16712750;
                int nroEvento = r.IngresaEventos(e);
                Response.Write("<script language=javascript>alert('SU NUMERO DE EVENTO ES:  " + nroEvento.ToString() + "');</script>");
                recarga();
            }
            catch (Exception ex)
            {

                Response.Write("<script language=javascript>alert('ERROR:\n  " + ex.ToString() + "');</script>");
            }
            
        }

        private void recarga()
        {
            CargaBox(ddlCliente, 6, 0);     //6 - Carga los Clientes
            CargaBox(ddlTipoEvento, 3, 0);  //3 - es tipo de evento
            CargaBox(ddlUbicacion, 4, 0);   //4 - son las ubicaciones de las maquinas
            ddlMaquina.SelectedIndex=0;
            txtDetalle.Value = "";
        }

        protected void ddlUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
             CargaBox(ddlMaquina, 5, Convert.ToInt32(ddlUbicacion.SelectedValue));
        }

    }
}