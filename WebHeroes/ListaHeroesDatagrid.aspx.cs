using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Modelo;

namespace WebHeroes
{
    public partial class ListaHeroresDatagrid : System.Web.UI.Page
    {
        public bool FiltroAvanzado = false;

        public List<SuperHeroe> listaHeroes{ get; set; }

       
        protected void Page_Load(object sender, EventArgs e)
        {
            DaoSuperHeroes daoSuperHeroes = new DaoSuperHeroes();
            if (!IsPostBack)
            {
               
                Session.Add("listaHeroes_session", daoSuperHeroes.ListarHeroesSP());
                dgvHeroes.DataSource = Session["listaHeroes_session"];
                dgvHeroes.DataBind();
            }
            //para las Cartas de Abajo 
            listaHeroes = daoSuperHeroes.ListarHeroesSP();

        }

        protected void dgvHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvHeroes.SelectedDataKey.Value.ToString();
            Response.Redirect("DetalleHeroe.aspx?id=" + id);
        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            listaHeroes = (List<SuperHeroe>)Session["listaHeroes_session"];
            List<SuperHeroe> listaFiltrada = listaHeroes.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            dgvHeroes.DataSource = listaFiltrada;
            dgvHeroes.DataBind();

        }

        protected void dgvHeroes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvHeroes.PageIndex = e.NewPageIndex;
            dgvHeroes.DataBind();
        }

        protected void checkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFiltro.Checked == true)
            {
                txtFiltro.Text = "";
                txtFiltro.Enabled = false;
                FiltroAvanzado = true;
            }
            else
            {
                if(checkFiltro.Checked == false)
                {
                    txtFiltro.Text = "";
                    txtFiltro.Enabled = true;
                    FiltroAvanzado =false;
                }
            }
        }
    }
}