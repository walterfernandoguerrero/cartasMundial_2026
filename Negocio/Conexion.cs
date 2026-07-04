using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class Conexion
    {
        private string cadena = $"Server=.\\SQLEXPRESS" +
                                $";Database=gestion_agenda;" +
                                $"Integrated Security=True;";
        private SqlConnection con;

        //metodos
        public SqlConnection abrirBD()
        {
            con = new SqlConnection(cadena);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public SqlConnection cerrarBD(SqlConnection conexion)
        {
           conexion.Close();
            return con;
        }
        //otro metodo
        public void CerrarBase() {

            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
