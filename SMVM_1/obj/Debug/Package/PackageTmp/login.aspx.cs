﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;

namespace SMVM_1
{
    public partial class login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            Bu_Login l = new Bu_Login();
            DataTable dt = new DataTable();
            dt = l.Obtiene_Usuarios();
            string us1 = txtUsu.Text.Trim().ToUpper();
            string pw1 = txtPw.Text.Trim().ToUpper();

            foreach (DataRow d in dt.Rows)
            {
                string us = d["us"].ToString();
                string pw = d["pw"].ToString();
                string id_tipo = d["id_tipo"].ToString();


                if (us == us1  && pw == pw1)
                {
                    if (id_tipo == "2" || id_tipo == "3")
                    {
                        Response.Redirect("/view/frmPrincipal.aspx");
                    }
                }
                else if (id_tipo == "1")
                {
                    ERROR.Text = "TIPO DE USUARIO NO PERMITIDO";
                }
                else if(us != us1 || pw != pw1)
                {
                    ERROR.Text = "USUARIO O CLAVE INCORRECTA";

                }
            }


            
        }
    }
}