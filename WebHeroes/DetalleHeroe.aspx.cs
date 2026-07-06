using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Negocio;

namespace WebHeroes
{
    public partial class DetalleHeroe : System.Web.UI.Page
    {
        public string Imagen { get; set; }
        public bool botonBorrar  { get; set; }
        public bool activarBorrado { get; set; }
        public bool estadoHeroe { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            activarBorrado = false;
            if (Request.QueryString["id"] != null) 
            {
                txtId.Text = Request.QueryString["id"].ToString();
                btnAccion.Text = "MODIFICAR HEROE";
                botonBorrar = true;

                DaoSuperHeroes daoSuperHeroes = new DaoSuperHeroes();
                SuperHeroe unHeroe = new SuperHeroe();
                unHeroe = daoSuperHeroes.unSuperHeroe(int.Parse(txtId.Text));

                estadoHeroe = unHeroe.Estado;

                if (!IsPostBack)
                {


                    txtCodigo.Text = unHeroe.Codigo;
                    txtNombre.Text = unHeroe.Nombre;
                    txtUrl.Text = unHeroe.UrlImagen;
                    cargarImagen();
                    txtAltura.Text = unHeroe.Altura.ToString();
                    txtPeso.Text = unHeroe.Peso.ToString();
                    txtFuerza.Text = unHeroe.Fuerza.ToString();
                    txtVelocidad.Text = unHeroe.Velocidad.ToString();
                    txtPeleasGanadas.Text = unHeroe.PeleasGanadas.ToString();

                    
                    estadoHeroe = unHeroe.Estado;

                }

            }
            else
            {
                btnAccion.Text = "GRABAR HEROE";
                botonBorrar=false;
            }

        }

        protected void txtUrl_TextChanged(object sender, EventArgs e)
        {
            cargarImagen();
        }
        protected void cargarImagen()
        {
            Imagen = txtUrl.Text;
        }

        protected void btnUrl_Click(object sender, EventArgs e)
        {
            cargarImagen();
        }

        protected void btnAccion_Click(object sender, EventArgs e)
        {
            DaoSuperHeroes dao = new DaoSuperHeroes();
            if (Request.QueryString["id"] != null)
            {
                SuperHeroe aux = new SuperHeroe();
                //validar cajas
                aux.Id = int.Parse(txtId.Text);
                aux.Codigo = txtCodigo.Text;
                aux.Nombre = txtNombre.Text;
                aux.Altura = decimal.Parse(txtAltura.Text);
                aux.Peso = int.Parse(txtPeso.Text);
                aux.Fuerza = int.Parse(txtFuerza.Text);
                aux.PeleasGanadas = int.Parse(txtPeleasGanadas.Text);
                aux.Velocidad = int.Parse(txtVelocidad.Text);
                aux.UrlImagen = txtUrl.Text;

                aux.Estado = estadoHeroe;

                dao.SP_modificarHeroe(aux);

                Response.Redirect("ListaHeroesDatagrid.aspx");
            }
            else
            {
                SuperHeroe nuevo = new SuperHeroe();
                //validar cajas
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Altura = decimal.Parse(txtAltura.Text);
                nuevo.Peso = int.Parse(txtPeso.Text);
                nuevo.Fuerza = int.Parse(txtFuerza.Text);
                nuevo.PeleasGanadas = int.Parse(txtPeleasGanadas.Text);
                nuevo.Velocidad =int.Parse(txtVelocidad.Text);
                nuevo.UrlImagen = txtUrl.Text;

                dao.SP_agregarHeroe(nuevo);

                Response.Redirect("ListaHeroesDatagrid.aspx");
            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            cargarImagen();
            lblBorrarHeroeOK.Text = $"Desea Borrar el Heroe: {txtNombre.Text}";
            activarBorrado = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            cargarImagen();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            DaoSuperHeroes daoSuperHeroes = new DaoSuperHeroes();
            daoSuperHeroes.SP_eliminarHeroe(int.Parse(txtId.Text));
            Response.Redirect("ListaHeroesDatagrid.aspx");
        }
    }
}