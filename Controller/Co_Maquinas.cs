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
    public class Co_Maquinas
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
        public int IngresaMaquinas(Maquinas m)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Eventos", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maquina_serie", SqlDbType.VarChar).Value = m.serie;
                cmd.Parameters.Add("@modelo_id", SqlDbType.Int).Value = m.modelo_id;
                cmd.Parameters.Add("@maquina_FechaFabri", SqlDbType.DateTime).Value = m.dateFabricacion;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = m.id_user;

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

        public int IngresaMarca(Maquinas m)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Marcas_Equipos", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = m.descripcion;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = m.id_user;

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
        public int IngresaModelo(Maquinas m)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Modelos_Equipos", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = m.descripcion;
                cmd.Parameters.Add("@marca_id", SqlDbType.Int).Value = m.marca_id;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = m.id_user;

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
        public int RegistraInstalacionMaquina(Maquinas m)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Instalacion_Maquina", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ubicacion_id", SqlDbType.Int).Value = m.marca_id;
                cmd.Parameters.Add("@maquina_id", SqlDbType.Int).Value = m.marca_id;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = m.descripcion;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = m.id_user;

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
