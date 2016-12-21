using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

namespace SMVM_1.view._01_Eventos
{
    public partial class frmDetalleEventos : System.Web.UI.Page
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
                    CargaBox(ddlEvento, 10, 0); //10 - Carga los eventos creados en estado abiertos y pendientes
                    
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('ERROR DE CONEXIÓN: \n  " + ex.ToString() + "');</script>");
            }
        }

        

        
        protected void ddlEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor.Value = ddlEvento.SelectedValue.ToString();
            CargaTabla(Convert.ToInt32(valor.Value));
        }

        private void CargaTabla(int valor)
        {
            Bu_Eventos e = new Bu_Eventos();
            DataSet ds = new DataSet();
            ds  = e.CargaGrid(valor);
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                string cadena = "";
                cadena += "<table id='tbVista' runat='server' class='table table-striped'><tbody><tr><th style='width: 10px'>ID</th><th style='width: 30px'>NRO EVENTO</th><th>DESCRIPCIÓN</th><th style='width: 150px'>FECHA</th></tr>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cadena += "<tr><th>" + ds.Tables[0].Rows[i]["ID"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["N_EVE"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["DESCRIPCIÓN"] + "</td>";
                    cadena += "<th>" + ds.Tables[0].Rows[i]["FECHA"] + "</td></tr>";
                }
                cadena += "</tbody></table>";
                ListadoDetalle.InnerHtml = cadena;
            }
            

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valor.Value!="0")
                {
                    Bu_Eventos eve = new Bu_Eventos();
                    DetallesEventos d = new DetallesEventos();
                    d.id_evento = Convert.ToInt32(valor.Value);
                    d.detalle_eventos = txtDetalle.Value.ToString().Trim();
                    d.id_user = 16712750;
                    eve.IngresaDetalleEventos(d);
                    CargaTabla(Convert.ToInt32(valor.Value));
                    limpiar();
                }
                else
                {
                    Response.Write("<script language=javascript>alert('NO HAS SELECCIONADO UN EVENTO');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('ERROR DE REGISTRO: \n  " + ex.ToString() + "');</script>");
            }
            

        }

        private void limpiar()
        {
            ddlEvento.SelectedIndex = 0;
            txtDetalle.Value = "";
            valor.Value = "0";
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valor.Value != "0")
                {
                    Bu_Eventos eve = new Bu_Eventos();
                    DetallesEventos d = new DetallesEventos();
                    d.id_evento = Convert.ToInt32(valor.Value);
                    d.detalle_eventos = txtDetalle.Value.ToString().Trim();
                    d.id_user = 16712750;
                    eve.CierraEventos(d);
                    CargaTabla(d.id_evento);
                    limpiar();
                    
                }
                else
                {
                    Response.Write("<script language=javascript>alert('NO HAS SELECCIONADO UN EVENTO\nPARA CERRAR');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('ERROR DE REGISTRO: \n  " + ex.ToString() + "');</script>");
            }
        }
        
    }
}