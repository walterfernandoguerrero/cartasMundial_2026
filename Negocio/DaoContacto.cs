using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DaoContacto
    {
        //metodos
        public List<Contacto> listContactos()
        {
            List<Contacto> lista = new List<Contacto>();


            Conexion cnn = new Conexion();

            string query = "select * from contactos";
            
            try
            {
                //ir a la base de datos
                SqlCommand cmd = new SqlCommand(query, cnn.abrirBD());

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Contacto contacto = new Contacto();
                    contacto.id = Convert.ToInt32(dr["id"]);
                    contacto.nombre = dr["nombre"].ToString();
                    contacto.correo = dr["correo"].ToString();
                    contacto.grupos = dr["grupos"].ToString();

                    lista.Add(contacto);
                }
                dr.Close();
                cnn.cerrarBD(cnn.abrirBD());
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
