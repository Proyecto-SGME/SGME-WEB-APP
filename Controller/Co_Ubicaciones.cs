using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace Controller
{
    public class Co_Ubicaciones
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
        public int IngresaHorarios(Ubicaciones u)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Horarios_Ubicaciones", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@hora_apertura", SqlDbType.DateTime).Value = u.hApertura;
                cmd.Parameters.Add("@hora_cierre", SqlDbType.DateTime).Value = u.hCierre;
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
        public DataSet CargaGridHorarios()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Carga_Grilla_Horarios", SqlCn);
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
        public int IngresaUbicacion(Ubicaciones u)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Ubicacion", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@direccion_id", SqlDbType.Int).Value = u.direccion_id;
                cmd.Parameters.Add("@ubicacion_descripcion", SqlDbType.VarChar).Value = u.descripcion;
                cmd.Parameters.Add("@id_horario", SqlDbType.Int).Value = u.horario_id;
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
        public DataSet CargaGridUbicaciones()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Carga_Grilla_Ubicaciones", SqlCn);
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
