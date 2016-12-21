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
    public class Co_Rutas
    {
        Co_Conexion cn = new Co_Conexion();

        public DataSet CargaGrid(int id_tecnico)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Carga_Grilla_Listado_Rutas_Tecnicos", SqlCn);
                cmd.Parameters.Add("@id_tecnico", SqlDbType.Int).Value = id_tecnico;
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
        public int RegistroRutaTecnico(Rutas r)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Ruta_Tecnico", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@evento_id", SqlDbType.Int).Value = r.evento_id;
                cmd.Parameters.Add("@tecnico_id", SqlDbType.Int).Value = r.tecnico_id;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = r.id_user;
                

                //SqlParameter NroEvento = new SqlParameter("@numero_evento", 0);
                //NroEvento.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(NroEvento);

                try
                {
                    SqlCn.Open();
                    //cmd.ExecuteNonQuery();
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





    }
}
