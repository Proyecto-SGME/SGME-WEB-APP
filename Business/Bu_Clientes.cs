using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Controller;
using System.Data;

namespace Business
{
    public class Bu_Clientes
    {
        public int IngresaClientes(Clientes c)
        {
            return new Co_Cliente().IngresaClientes(c);
        }
        //public int ActualizaCliente(Clientes c)
        //{
        //    return new Co_Cliente().ActualizaDatoCliente(c);
        //}
        public int IngresaDatoCliente(Clientes c)
        {
            return new Co_Cliente().IngresaDatoCliente(c);
        }
        public DataSet BuscaCliente(Clientes c)
        {
            return new Co_Cliente().BuscaCliente(c);
        }
        //public void BuscaCliente(Clientes c)
        //{
        //    Co_Cliente cli = new Co_Cliente();
        //    cli.BuscaCliente(c);
        //}
    }
}
