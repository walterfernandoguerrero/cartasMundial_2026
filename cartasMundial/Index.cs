using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Negocio;

namespace cartasMundial
{
    public partial class Index : Form
    {
        //artibutos del formulario
        private SuperHeroe unHeroe;


        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            
            //tabajo con Heroes

            unHeroe = new SuperHeroe();

            DaoSuperHeroes sph = new DaoSuperHeroes();
            try
            {
                dgvSuperHeroe.DataSource = sph.listaSH();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            unHeroe = (SuperHeroe)dgvSuperHeroe.CurrentRow.DataBoundItem;
            CargarImagen(unHeroe.UrlImagen);
            lbl_Nombre_Heroe.Text = unHeroe.Nombre;


            dgvSuperHeroe.Columns["Id"].Visible = false;
            dgvSuperHeroe.Columns["UrlImagen"].Visible = false;
        }
        private void CargarImagen(string img)
        {
            // 1. Forzamos el protocolo TLS 1.2 para evitar el error de conexión (SocketException)
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            try
            {
                // 2. Verificamos que la URL no sea nula, vacía o solo espacios
                if (!string.IsNullOrWhiteSpace(img))
                {
                    pbxImagenHeroe.Load(img);
                }
                else
                {
                    // 3. Si la URL es inválida, cargamos una imagen local de "sin imagen"
                    CargarImagenPorDefecto();
                }
            }
            catch (Exception ex)
            {
                // Si la descarga falla (por ejemplo, el link está roto), cargamos la de defecto
                CargarImagenPorDefecto();

                // Opcional: Solo mostrar el error en consola para no interrumpir al usuario
                //Console.WriteLine("Error al cargar imagen: " + ex.Message);
                lblErrorImagen.Text="error al cargar la Imagen: " + ex.Message;
            }
        }

        private void CargarImagenPorDefecto()
        {
            // Aquí puedes cargar una imagen que tengas en los recursos de tu proyecto
            // pbxImagenHeroe.Image = Properties.Resources.placeholder; 

            // O simplemente dejarlo vacío si prefieres:
            try
            {
                pbxImagenHeroe.Load("https://img.icons8.com/external-smashingstocks-hand-drawn-color-smashing-stocks/1200/external-Corrupted-File-files-and-folders-smashingstocks-hand-drawn-color-smashing-stocks-2.jpg");
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("no hay imagen desde internet");
            }
            
        }

        private void dgvSuperHeroe_MouseClick(object sender, MouseEventArgs e)
        {
            lblErrorImagen.Text = "";
            unHeroe = (SuperHeroe)dgvSuperHeroe.CurrentRow.DataBoundItem;
            CargarImagen(unHeroe.UrlImagen);
            lbl_Nombre_Heroe.Text = unHeroe.Nombre;
        }

        private void btnAgregar_Heroe_Click(object sender, EventArgs e)
        {
            FormularioAltaModifacion_Heroes formulario = new FormularioAltaModifacion_Heroes();
            formulario.Show();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SuperHeroe aux = new SuperHeroe();
            aux= (SuperHeroe)dgvSuperHeroe.CurrentRow.DataBoundItem;
            FormularioAltaModifacion_Heroes formulario = new FormularioAltaModifacion_Heroes(aux);
            formulario.Show();
        }
    }
}
