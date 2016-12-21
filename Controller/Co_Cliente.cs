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
    public class Co_Cliente
    {
        Co_Conexion cn = new Co_Conexion();
        public int IngresaClientes(Clientes c)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Cliente", SqlCn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@cliente_rut", SqlDbType.Int).Value = c.cliente_rut;
                cmd.Parameters.Add("@cliente_dv", SqlDbType.Char).Value = c.cliente_dv;
                cmd.Parameters.Add("@cliente_nombre", SqlDbType.VarChar).Value = c.cliente_nombre;
                cmd.Parameters.Add("@cliente_paterno", SqlDbType.VarChar).Value = c.cliente_paterno;
                cmd.Parameters.Add("@cliente_materno", SqlDbType.VarChar).Value = c.cliente_materno;
                cmd.Parameters.Add("@cliente_nacimiento", SqlDbType.Date).Value = c.cliente_nacimiento;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = c.id_user;
                cmd.Parameters.Add("@datos_cliente_celular", SqlDbType.VarChar).Value = c.datos_cliente_celular;
                cmd.Parameters.Add("@datos_cliente_fono", SqlDbType.VarChar).Value = c.datos_cliente_fono;
                cmd.Parameters.Add("@datos_cliente_email", SqlDbType.VarChar).Value = c.datos_cliente_email;

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

        public DataSet BuscaCliente(Clientes c)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Busca_Cliente", SqlCn);
                cmd.Parameters.Add("@rut", SqlDbType.Int).Value = c.cliente_rut;
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
  
        public int IngresaDatoCliente(Clientes c)
        {
            try
            {
                SqlConnection SqlCn = new SqlConnection(cn.LeerConexion());
                SqlCommand cmd = new SqlCommand("Sp_Registro_Agrega_Dato_Cliete", SqlCn);
                cmd.Parameters.Add("@rut_cliente", SqlDbType.Int).Value = c.cliente_rut;
                cmd.Parameters.Add("@datos_cliente_celular", SqlDbType.VarChar).Value = (c.datos_cliente_celular == null ? "" : c.datos_cliente_celular);
                cmd.Parameters.Add("@datos_cliente_fono", SqlDbType.VarChar).Value = (c.datos_cliente_fono == null ? "" : c.datos_cliente_fono);
                cmd.Parameters.Add("@datos_cliente_email", SqlDbType.VarChar).Value = (c.datos_cliente_email == null ? "" : c.datos_cliente_email);
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = c.id_user;
                cmd.CommandType = CommandType.StoredProcedure;

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
