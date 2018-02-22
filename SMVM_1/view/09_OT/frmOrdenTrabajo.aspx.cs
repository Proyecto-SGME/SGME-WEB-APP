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
                    CargaBox(ddlEmpresa, 19, 0); //19 - Carga las empresas
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
            if (ddlEmpresa.SelectedValue == "0")
            {
                Response.Write("<script language=javascript>alert('DEBES SELECCIONAR UNA EMPRESA');</script>");
            }
            else
            {
                try
                {
                    ot.fecha_trabajo = Convert.ToDateTime(txtFechaTrabajo.Text.Trim());
                    ot.hora_inicio = txtHoraInicio.Text;
                    ot.hora_fin = txtHoraTermino.Text;
                    ot.cantidad_hora = Convert.ToInt32(txtHH.Text.Trim());
                    ot.requerimiento = txtRequerimiento.Value.Trim().ToUpper();
                    ot.solucion = txtSolucion.Value.Trim().ToUpper();
                    ot.contacto_empresa_id = Convert.ToInt32(ddlContacto.SelectedValue);
                    ot.id_user = 16712750;
                    bu.RegistrarOT(ot);
                    recarga();
                }
                catch (Exception)
                {
                    Response.Write("<script language=javascript>alert('ERROR : " + e.ToString() + "');</script>");
                }
                

            }
        }

       
        private void recarga()
        {
            ddlEmpresa.SelectedIndex = 0;
            ddlContacto.SelectedIndex = 0;
            txtFechaTrabajo.Text = "";
            txtHH.Text = "";
            txtHoraInicio.Text = "";
            txtHoraTermino.Text = "";
            txtRequerimiento.Value = "";
            txtSolucion.Value = "";

        }

        protected void ddlEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ddl = Convert.ToInt32(ddlEmpresa.SelectedValue);
            CargaBox(ddlContacto, 20, ddl);
        }
    }
}