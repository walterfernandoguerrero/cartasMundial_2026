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
    public partial class AutoForm : System.Web.UI.Page
    {
        List<Auto> aux = new List<Auto>();
        protected void Page_Load(object sender, EventArgs e)
        {

            txtId.ReadOnly = true; //voy a cargar autosc con funcion autoincremento
            txtId.Visible = false;



            if (!IsPostBack)
            {
                

                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    List<Auto> temporal = (List<Auto>)Session["listaAutos"];

                    //creo objeto  y busco en la lista la coinsidencia del parametro que vino de URL
                    //con Find busco coincidencia 
                    Auto seleccionado = temporal.Find(x => x.Id == id);
                    lblId.Text = seleccionado.Id.ToString();
                    txtModelo.Text = seleccionado.Modelo;
                    txtDescripcion.Text = seleccionado.Descripcion.ToString();
                    ddlColores.Text = seleccionado.Color.ToString();
                    txtFecha.Text = seleccionado.fecha.ToString("yyyy-MM-dd");
                    ckbUsado.Checked = seleccionado.Usado;
                    if (seleccionado.Importado)
                    {
                        rdbImportado.Checked = true;
                    }
                    else
                    {
                        rdbNacional.Checked = true;
                    }

                }
                ddlColores.Items.Add("GRIS");
                ddlColores.Items.Add("AZUL");
                ddlColores.Items.Add("ROJO");

            }

            
 

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            
            Auto auto = new Auto();

            try
            {
                auto.Id = AutoIncremento();
                auto.Modelo = txtModelo.Text;
                auto.Descripcion = txtDescripcion.Text;
                auto.Color = ddlColores.SelectedValue;
                auto.fecha = DateTime.Parse(txtFecha.Text);
                auto.Usado = ckbUsado.Checked;

                if (rdbImportado.Checked)
                {
                    auto.Importado = true;
                }
                else
                {
                    auto.Importado = false;
                }

                if (Session["listaAutos"]==null)
                {
                    Session.Add("listaAutos", aux);

                }

                List<Auto> temporal = (List<Auto>)Session["listaAutos"];
                temporal.Add(auto);
                Response.Redirect("ListaAutos.aspx",false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.Message);
                Response.Redirect("Errores.aspx");
            }
            
        }
        private int AutoIncremento()
        {
            // 1. Recuperamos la lista de forma segura
            List<Auto> temporal = Session["listaAutos"] as List<Auto> ?? new List<Auto>();

            int valor;

            // 3. Lógica de incremento
            if (temporal.Count > 0)
            {
                // Tomamos el último objeto y le sumamos 1 a su Id
                valor = temporal.Last().Id + 1;
            }
            else
            {
                // Si la lista está vacía, empezamos en 1
                valor = 1;
            }
            return valor;
        }
    }
}