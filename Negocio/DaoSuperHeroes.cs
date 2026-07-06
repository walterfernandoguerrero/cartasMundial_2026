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
    public class DaoSuperHeroes
    {

        Conexion conexion = new Conexion();
        private SqlConnection conn1 = new SqlConnection();


        public List<SuperHeroe> ListarHeroesSP()
        {
            List<SuperHeroe> lista = new List<SuperHeroe>();
            conn1 = conexion.abrirBD();
            string sp = "SP_listar_heroe";
            
            try
            {
                SqlCommand comando = new SqlCommand(sp, conn1);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();
               

                while (lector.Read())
                {
                    SuperHeroe sphAux = new SuperHeroe();
                    sphAux.Id = Convert.ToInt32(lector["id"]);
                    sphAux.Codigo = lector["codigo"].ToString();
                    sphAux.Nombre = lector["nombre"].ToString();
                    sphAux.Altura = Convert.ToDecimal(lector["altura"]);
                    sphAux.Peso = Convert.ToInt32(lector["peso"]);
                    sphAux.Fuerza = Convert.ToInt32(lector["fuerza"]);
                    sphAux.PeleasGanadas = Convert.ToInt32(lector["peleas_ganadas"]);
                    sphAux.Velocidad = Convert.ToInt32(lector["velocidad"]);
                    sphAux.UrlImagen = lector["url_imagen"].ToString();

                    sphAux.Estado = Convert.ToBoolean(lector["estado"].ToString());

                    lista.Add(sphAux);
                }
                lector.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                
                conexion.cerrarBD(conn1);
            }
            return lista;

        }

        public List<SuperHeroe> listaSH()
        {
            List<SuperHeroe> lista = new List<SuperHeroe>();
            Conexion con = new Conexion();
            string query = "select * from super_heroes";
            try
            {
                SqlCommand comando = new SqlCommand(query, con.abrirBD());
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    SuperHeroe sphAux =  new SuperHeroe();
                    sphAux.Id = Convert.ToInt32(lector["id"]);
                    sphAux.Codigo = lector["codigo"].ToString();
                    sphAux.Nombre = lector["nombre"].ToString();
                    sphAux.Altura = Convert.ToDecimal(lector["altura"]);
                    sphAux.Peso = Convert.ToInt32(lector["peso"]);
                    sphAux.Fuerza = Convert.ToInt32(lector["fuerza"]);
                    sphAux.PeleasGanadas = Convert.ToInt32(lector["peleas_ganadas"]);
                    sphAux.Velocidad = Convert.ToInt32(lector["velocidad"]);
                    sphAux.UrlImagen = lector["url_imagen"].ToString();
                    
                    sphAux.Estado = Convert.ToBoolean(lector["estado"].ToString());

                    lista.Add(sphAux);
                }
                lector.Close();
                con.cerrarBD(con.abrirBD());
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.CerrarBase();
            }
            return lista;
        }

        public void SP_agregarHeroe(SuperHeroe heroe)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = con.abrirBD();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_crear_heroe";

                cmd.Parameters.AddWithValue("@codigo", heroe.Codigo);// 8 objetos
                cmd.Parameters.AddWithValue("@nombre", heroe.Nombre);
                cmd.Parameters.AddWithValue("@altura", heroe.Altura);
                cmd.Parameters.AddWithValue("@peso", heroe.Peso);
                cmd.Parameters.AddWithValue("@fuerza", heroe.Fuerza);// 8 objetos
                cmd.Parameters.AddWithValue("@peleas_ganadas", heroe.PeleasGanadas);
                cmd.Parameters.AddWithValue("@velocidad", heroe.Velocidad);
                cmd.Parameters.AddWithValue("@url_imagen", heroe.UrlImagen);

                cmd.Parameters.AddWithValue("@estado", true);



                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
            finally
            {
                con.cerrarBD(con.abrirBD());
            }
        } 

        public SuperHeroe unSuperHeroe(int id)
        {
            SuperHeroe heroe = new SuperHeroe();
            List<SuperHeroe> lista = new List<SuperHeroe>();
            Conexion con = new Conexion();
            string query = $"select * from super_heroes where id = {id}";
            try
            {
                SqlCommand comando = new SqlCommand(query, con.abrirBD());
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    SuperHeroe sphAux = new SuperHeroe();
                    sphAux.Id = Convert.ToInt32(lector["id"]);
                    sphAux.Codigo = lector["codigo"].ToString();
                    sphAux.Nombre = lector["nombre"].ToString();
                    sphAux.Altura = Convert.ToDecimal(lector["altura"]);
                    sphAux.Peso = Convert.ToInt32(lector["peso"]);
                    sphAux.Fuerza = Convert.ToInt32(lector["fuerza"]);
                    sphAux.PeleasGanadas = Convert.ToInt32(lector["peleas_ganadas"]);
                    sphAux.Velocidad = Convert.ToInt32(lector["velocidad"]);
                    sphAux.UrlImagen = lector["url_imagen"].ToString();

                    sphAux.Estado = Convert.ToBoolean(lector["estado"].ToString());

                    lista.Add(sphAux);
                }
                lector.Close();

                heroe = lista.First(); 

                return heroe;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.cerrarBD(con.abrirBD());
            }
        } 
        public void SP_modificarHeroe(SuperHeroe heroe)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = con.abrirBD();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_modificar_heroe";

                cmd.Parameters.AddWithValue("@codigo", heroe.Codigo);// 8 objetos
                cmd.Parameters.AddWithValue("@nombre", heroe.Nombre);
                cmd.Parameters.AddWithValue("@altura", heroe.Altura);
                cmd.Parameters.AddWithValue("@peso", heroe.Peso);
                cmd.Parameters.AddWithValue("@fuerza", heroe.Fuerza);// 8 objetos
                cmd.Parameters.AddWithValue("@peleas_ganadas", heroe.PeleasGanadas);
                cmd.Parameters.AddWithValue("@velocidad", heroe.Velocidad);
                cmd.Parameters.AddWithValue("@url_imagen", heroe.UrlImagen);

                cmd.Parameters.AddWithValue("@estado", heroe.Estado);

                cmd.Parameters.AddWithValue("@id", heroe.Id);


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.cerrarBD(con.abrirBD());
            }
        }
        public void SP_eliminarHeroe(int id)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = con.abrirBD();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_eliminar_heroe";

                cmd.Parameters.AddWithValue("@id", id);
               
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.cerrarBD(con.abrirBD());
            }
        }

        public List<SuperHeroe> ListaFiltrada(string campo, string criterio, string filtro, string estado)
        {
            SuperHeroe heroe = new SuperHeroe();
            List<SuperHeroe> lista = new List<SuperHeroe>();
            Conexion con = new Conexion();

            try
            {
                string query = $"select * from super_heroes where ";
                
                if(campo== "Número")
                {
                    switch (criterio)
                    {
                        case "Menor que":
                            query += $"id < {filtro}";
                            break;
                        case "Igual a":
                            query += $"id = {filtro}";
                            break;
                        case "Mayor que":
                            query += $"id > {filtro}";
                            break;
                       default:
                            break;
                    }
                }
                else
                {
                    if (campo == "Nombre")
                    {
                        switch(criterio)
                        {

                            case "Comienza con":
                                query += $"nombre like '{filtro}%'";
                                break;
                            case "Termina con":
                                query += $"nombre like '%{filtro}'";
                                break;
                            case "Contiene":
                                query += $"nombre like '%{filtro}%'";
                                break;
                            default:
                                break;
                        }
                    }
                }
                    
                if(estado == "Activo")
                {
                    query += $" and estado = 1";
                }
                else
                {
                    if(estado == "Inactivo" )
                        query += $" and estado = 0";
                }

                SqlCommand comando = new SqlCommand(query, con.abrirBD());
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    SuperHeroe sphAux = new SuperHeroe();
                    sphAux.Id = Convert.ToInt32(lector["id"]);
                    sphAux.Codigo = lector["codigo"].ToString();
                    sphAux.Nombre = lector["nombre"].ToString();
                    sphAux.Altura = Convert.ToDecimal(lector["altura"]);
                    sphAux.Peso = Convert.ToInt32(lector["peso"]);
                    sphAux.Fuerza = Convert.ToInt32(lector["fuerza"]);
                    sphAux.PeleasGanadas = Convert.ToInt32(lector["peleas_ganadas"]);
                    sphAux.Velocidad = Convert.ToInt32(lector["velocidad"]);
                    sphAux.UrlImagen = lector["url_imagen"].ToString();

                    sphAux.Estado = Convert.ToBoolean(lector["estado"].ToString());

                    lista.Add(sphAux);
                }
                lector.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.cerrarBD(con.abrirBD());
            }
            

        }
    }
}
