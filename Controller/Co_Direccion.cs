using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class Co_Direccion
    {
        Co_Conexion cn = new Co_Conexion();
        public DataSet CargarComboBox(int flag, int ddlFlag)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Carga_Combo_Box", SqlCn);
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = flag;
                cmd.Parameters.Add("@ddlFlag", SqlDbType.Int).Value = ddlFlag;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ds;
        }

        public int RegistraDireccion(Direcciones d)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Direccion", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@comuna_id", SqlDbType.Int).Value = d.comuna_id;
                cmd.Parameters.Add("@direccion_des", SqlDbType.VarChar).Value = d.direccion_des;
                cmd.Parameters.Add("@latitud", SqlDbType.Float).Value = d.latitud;
                cmd.Parameters.Add("@longitud", SqlDbType.Float).Value = d.longitud;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = d.id_user;
                

                try
                {
                    SqlCn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    SqlCn.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception exx)
            {
                throw new Exception(exx.Message);
            }
        }




    }
}
