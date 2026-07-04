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
    public partial class FormularioAltaModifacion_Heroes : Form
    {
        public SuperHeroe heroe { get; set; }

        public FormularioAltaModifacion_Heroes()
        {
            InitializeComponent();
        }
        public FormularioAltaModifacion_Heroes( SuperHeroe v_heroe)
        {
            InitializeComponent();
            heroe = v_heroe;
        }

        private void FormularioAltaModifacion_Heroes_Load(object sender, EventArgs e)
        {
            if(heroe != null)
            {
                btnAccion.Text = "MODIFICAR";

                this.Text = heroe.Nombre;
                txtNombre.Text = heroe.Nombre;
                txtUrl_Imagen.Text = heroe.UrlImagen;
                CargarImagen(txtUrl_Imagen.Text);
                txtAltura.Text = heroe.Altura.ToString();  
            }
            else
            {
                btnAccion.Text = "GRABAR";
            }

        }
        //funcion de carga de imagen
        private void CargarImagen(string img)
        {
            try
            {
                //validar
                if (!string.IsNullOrWhiteSpace(img))
                    pbxImagen.Load(img);
                else
                    fotoRota();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                fotoRota();
                
            }
            
        }
        private void fotoRota()
        {
            try
            {
                string ruta = Application.StartupPath + @"\fotos\fotoRota.png";
                pbxImagen.Load(ruta);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (heroe == null)
            {
                MessageBox.Show("voy a grabar un Heroe");
            }
            else
            {
                MessageBox.Show("voy a Modificar un Heroe");
            }
        }
    }
}
