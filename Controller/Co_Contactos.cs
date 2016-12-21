using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace Controller
{
    public class Co_Contactos
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

        public int IngresaContactos(Contactos c)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Contactos", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ubicacion_id", SqlDbType.Int).Value = c.ubicacion_id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = c.nombre;
                cmd.Parameters.Add("@paterno", SqlDbType.VarChar).Value = c.paterno;
                cmd.Parameters.Add("@materno", SqlDbType.VarChar).Value = c.materno;
                cmd.Parameters.Add("@celular", SqlDbType.VarChar).Value = c.celular;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = c.fono;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = c.email;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = c.id_user;
                try
                {
                    SqlCn.Open();
                    return cmd.ExecuteNonQuery(); ;
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
