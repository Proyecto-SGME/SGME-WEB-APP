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
    public class Co_Eventos
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

        public int IngresaEventos(Eventos e)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Eventos", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tipo_evento", SqlDbType.Int).Value = e.tipo_evento;
                //cmd.Parameters.Add("@usuario_rut", SqlDbType.Int).Value = e.usuario_rut;
                cmd.Parameters.Add("@cliente_rut", SqlDbType.Int).Value = e.cliente_rut;
                cmd.Parameters.Add("@maquina_id", SqlDbType.Int).Value = e.maquina_id;
                cmd.Parameters.Add("@detalle_evento", SqlDbType.VarChar).Value = e.detalle_eventos;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = e.id_user;

                SqlParameter NroEvento = new SqlParameter("@numero_evento", 0);
                NroEvento.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(NroEvento);

                try
                {
                    SqlCn.Open();
                    cmd.ExecuteNonQuery();
                    int nro_evento = Int32.Parse(cmd.Parameters["@numero_evento"].Value.ToString());
                    return nro_evento;
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

        public DataSet CargaGrid(int id_evento)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Carga_Grilla_Detalles_Eventos", SqlCn);
                cmd.Parameters.Add("@id_evento", SqlDbType.Int).Value = id_evento;
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
        public int IngresaDetalleEventos(DetallesEventos de)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Detalle_Eventos", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_evento", SqlDbType.Int).Value = de.id_evento;
                cmd.Parameters.Add("@detalle_evento", SqlDbType.VarChar).Value = de.detalle_eventos;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = de.id_user;
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

        public int CierraEventos(DetallesEventos de)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Cierra_Evento", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_evento", SqlDbType.Int).Value = de.id_evento;
                cmd.Parameters.Add("@detalle_evento", SqlDbType.VarChar).Value = de.detalle_eventos;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = de.id_user;
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

        public DataSet CargarListadoEventos(int id_evento)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Lista_Eventos_Estado", SqlCn);
                cmd.Parameters.Add("@id_evento", SqlDbType.Int).Value = id_evento;
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
