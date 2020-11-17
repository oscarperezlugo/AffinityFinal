using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class Certificados : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {            

           
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Busqueda.aspx");
            

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdicionConsulta.aspx");
        }
        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReemplazoCons.aspx");
        }
    }
}