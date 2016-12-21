using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Controller
{
    public class Co_Login
    {
        Co_Conexion cn = new Co_Conexion();

        public int Obtiene_Usuarios(string us, string pw)
        {
            int estado = 0;
            string id_tipo;
            string s, p;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Obtiene_Usuarios", SqlCn);
                //cmd.Parameters.Add("@flag", SqlDbType.Int).Value = flag;
                //cmd.Parameters.Add("@ddlFlag", SqlDbType.Int).Value = ddlFlag;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow d in dt.Rows)
                {
                    
                    s = d["us"].ToString();
                    p = d["pw"].ToString();
                    id_tipo = d["id_tipo"].ToString();
                    if (s==us && p==pw)
                    {
                        switch (id_tipo)
                        {
                            case "1":
                                estado = Convert.ToInt32(id_tipo);
                                break;
                            case "2":
                                estado = Convert.ToInt32(id_tipo);
                                break;
                            case "3":
                                estado = Convert.ToInt32(id_tipo);
                                break;
                            default:
                                estado = 9;
                                break;
                        }
                    }
                    
                }


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return estado;
        }
       
    }
}
