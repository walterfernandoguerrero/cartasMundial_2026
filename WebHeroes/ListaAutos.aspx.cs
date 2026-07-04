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
    public partial class ListaAutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["listaAutos"]==null) 
            {
                DaoAuto daoAuto = new DaoAuto();
                Session.Add("listaAutos", daoAuto.listar());
            }   
            dgvAutos.DataSource = Session["listaAutos"];
            dgvAutos.DataBind();
        }

        protected void dgvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nombre = dgvAutos.SelectedRow.Cells[0].Text; // tomo un valor de la grilla

            var id = dgvAutos.SelectedDataKey.Value.ToString(); // tomo el valor key de la grilla
            
            //voy a mandar a un formulario el id en este caso AutoForm y le paso un valor por url
            Response.Redirect("AutoForm.aspx?id=" + id);

        }
    }
}