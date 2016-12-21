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
    public class Co_Usuario
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

        public int IngresaUsuario(Usuarios u)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Usuarios", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@rut", SqlDbType.Int).Value = u.usuario_rut;
                cmd.Parameters.Add("@dv", SqlDbType.Char).Value = u.usuario_dv;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = u.usuario_us;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = u.usuario_pw;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = u.usuario_nombre;
                cmd.Parameters.Add("@paterno", SqlDbType.VarChar).Value = u.usuario_paterno;
                cmd.Parameters.Add("@materno", SqlDbType.VarChar).Value = u.usuario_materno;
                cmd.Parameters.Add("@nacimiento", SqlDbType.DateTime).Value = u.usuario_nacimiento;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = u.id_user;
                cmd.Parameters.Add("@tipo_usuario_id", SqlDbType.Int).Value = u.tipo_usuario_id;

                //SqlParameter NroEvento = new SqlParameter("@numero_evento", 0);
                //NroEvento.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(NroEvento);

                try
                {
                    SqlCn.Open();
                    //int nro_evento = Int32.Parse(cmd.Parameters["@numero_evento"].Value.ToString());
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

        public int IngresTipoaUsuario(Usuarios u)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Tipos_Usuarios", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = u.descripcion;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = u.id_user;

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
        public int CambiaClave(Usuarios u)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Cambia_Clave_Usuarios", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@rut", SqlDbType.VarChar).Value = u.usuario_rut;
                cmd.Parameters.Add("@pw", SqlDbType.VarChar).Value = u.usuario_pw;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = u.id_user;

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
        public DataSet CargaGrid()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Carga_Grilla_Listado_Tipos_Usuarios", SqlCn);
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

        public DataSet CargaGridListarUsuarios()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("CargaGridListarUsuarios", SqlCn);
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


    }
}
