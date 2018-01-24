using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Co_OrdenTrabajo
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


        public int RegistrarOT(OT ot)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Ot_Registro_OT", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha_trabajo", SqlDbType.Date).Value = ot.fecha_trabajo;
                cmd.Parameters.Add("@hh_inicio", SqlDbType.VarChar).Value = ot.hora_inicio;
                cmd.Parameters.Add("@hh_termino", SqlDbType.VarChar).Value = ot.hora_fin;
                cmd.Parameters.Add("@cantidad_hh", SqlDbType.Int).Value = ot.cantidad_hora;
                cmd.Parameters.Add("@requerimiento", SqlDbType.VarChar).Value = ot.requerimiento;
                cmd.Parameters.Add("@solucion", SqlDbType.VarChar).Value = ot.solucion;
                cmd.Parameters.Add("@contacto_id", SqlDbType.Int).Value = ot.contacto_empresa_id;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = ot.id_user;

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
