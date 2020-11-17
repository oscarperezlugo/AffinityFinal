using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["nombreC"] != null)
            {
                Label1.Text = ""+Request.Cookies["nombreC"].Value+" "+Request.Cookies["appellC"].Value + "";
                if(Request.Cookies["PerfilC"].Value == "VENTA")
                {
                    BLOQUE3.Attributes.Add("style", "display:none");
                    BLOQUE2.Attributes.Add("style", "display:none");
                }
                else
                {

                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }
        public void CierreClick(object sender, EventArgs e)
        {
            Response.Cookies["nombreC"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["rowC"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["PerfilC"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Login.aspx");
        }
        public void BuscarClick(object sender, EventArgs e)
        {
            string buscar = busqueda.Value;
            HttpCookie buscarS = new HttpCookie("paramCedula");
            buscarS.Value = buscar.ToString();
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            Response.Redirect("Busqueda.aspx");
        }
    }
}