using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class AdicionSeleccion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "8")
                {
                    Label3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    GridView3.Attributes.Add("style", "display:none");
                    ADIC.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    Button2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "9")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "8";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                }
                else if (Request.Cookies["indexC"].Value == "15")
                {
                    Label3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    GridView1.Attributes.Add("style", "display:none");
                    siguiente.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    Button2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    GridView1.Attributes.Add("style", "display:none");
                    GridView3.Attributes.Add("style", "display:none");
                    siguiente.Attributes.Add("style", "display:none");
                    
                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    Label3.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    GridView1.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                    siguiente.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                }
            }
            else
            {
                siguiente.Attributes.Add("style", "display:none");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "8")
                {                    
                    int i = GridView1.SelectedIndex;

                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie claseS = new HttpCookie("paramCedulaD");
                    claseS.Value = GridView1.Rows[i].Cells[2].Text;
                    claseS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(claseS);
                    

                    HttpCookie idclienteS = new HttpCookie("generotomC");
                    idclienteS.Value = GridView1.Rows[i].Cells[1].Text;
                    idclienteS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idclienteS);

                    HttpCookie perfilS = new HttpCookie("fechanacC");
                    perfilS.Value = DateTime.Parse(GridView1.Rows[i].Cells[4].Text).ToString();
                    perfilS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfilS);

                    HttpCookie nombreadS = new HttpCookie("nombreadC");
                    nombreadS.Value = GridView1.Rows[i].Cells[0].Text;
                    nombreadS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreadS);

                    HttpCookie clase2S = new HttpCookie("relaproaD");
                    clase2S.Value = GridView1.Rows[i].Cells[3].Text;
                    clase2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(clase2S);


                    HttpCookie idcliente2S = new HttpCookie("cobproC");
                    idcliente2S.Value = GridView1.Rows[i].Cells[5].Text;
                    idcliente2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idcliente2S);

                    HttpCookie perfil2S = new HttpCookie("planproC");
                    perfil2S.Value = GridView1.Rows[i].Cells[6].Text;
                    perfil2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil2S);

                    HttpCookie perfil3S = new HttpCookie("primaproC");
                    perfil3S.Value = GridView1.Rows[i].Cells[7].Text;
                    perfil3S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil3S);

                    HttpCookie nombread2S = new HttpCookie("nombreadC");
                    nombread2S.Value = GridView1.Rows[i].Cells[0].Text;
                    nombread2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombread2S);

                    Response.Redirect("InclusionAegurados.aspx");
                }
                if (Request.Cookies["indexC"].Value == "30")
                {
                    int i = GridView2.SelectedIndex;

                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie claseS = new HttpCookie("paramCedulaD");
                    claseS.Value = GridView2.Rows[i].Cells[2].Text;
                    claseS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(claseS);


                    HttpCookie idclienteS = new HttpCookie("generotomC");
                    idclienteS.Value = GridView2.Rows[i].Cells[1].Text;
                    idclienteS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idclienteS);

                    HttpCookie perfilS = new HttpCookie("fechanacC");
                    perfilS.Value = DateTime.Parse(GridView2.Rows[i].Cells[4].Text).ToString();
                    perfilS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfilS);

                    HttpCookie nombreadS = new HttpCookie("nombreadC");
                    nombreadS.Value = GridView2.Rows[i].Cells[0].Text;
                    nombreadS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreadS);

                    HttpCookie clase2S = new HttpCookie("relaproaD");
                    clase2S.Value = GridView2.Rows[i].Cells[3].Text;
                    clase2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(clase2S);


                    HttpCookie idcliente2S = new HttpCookie("cobproC");
                    idcliente2S.Value = GridView2.Rows[i].Cells[5].Text;
                    idcliente2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idcliente2S);

                    HttpCookie perfil2S = new HttpCookie("planproC");
                    perfil2S.Value = GridView2.Rows[i].Cells[6].Text;
                    perfil2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil2S);

                    HttpCookie perfil3S = new HttpCookie("primaproC");
                    perfil3S.Value = GridView2.Rows[i].Cells[7].Text;
                    perfil3S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil3S);

                    HttpCookie nombread2S = new HttpCookie("nombreadC");
                    nombread2S.Value = GridView2.Rows[i].Cells[0].Text;
                    nombread2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombread2S);

                    Response.Redirect("InclusionAegurados.aspx");
                }
                else
                {
                    int i = GridView3.SelectedIndex;

                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie claseS = new HttpCookie("paramCedulaD");
                    claseS.Value = GridView3.Rows[i].Cells[2].Text;
                    claseS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(claseS);

                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "2";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);

                    HttpCookie idclienteS = new HttpCookie("generotomC");
                    idclienteS.Value = GridView3.Rows[i].Cells[1].Text;
                    idclienteS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idclienteS);

                    HttpCookie perfilS = new HttpCookie("fechanacC");
                    perfilS.Value = DateTime.Parse(GridView3.Rows[i].Cells[4].Text).ToString();
                    perfilS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfilS);

                    HttpCookie nombreadS = new HttpCookie("nombreadC");
                    nombreadS.Value = GridView3.Rows[i].Cells[0].Text;
                    nombreadS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreadS);

                    Response.Redirect("InclusionAegurados.aspx");
                }
            }
            else
            {
                int i = GridView3.SelectedIndex;

                HttpCookie fechavigS = new HttpCookie("fechavigC");
                fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                fechavigS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fechavigS);

                HttpCookie claseS = new HttpCookie("paramCedulaD");
                claseS.Value = GridView3.Rows[i].Cells[2].Text;
                claseS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(claseS);

                HttpCookie indexS = new HttpCookie("indexC");
                indexS.Value = "2";
                indexS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(indexS);

                HttpCookie idclienteS = new HttpCookie("generotomC");
                idclienteS.Value = GridView3.Rows[i].Cells[1].Text;
                idclienteS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(idclienteS);

                HttpCookie perfilS = new HttpCookie("fechanacC");
                perfilS.Value = DateTime.Parse(GridView3.Rows[i].Cells[4].Text).ToString();
                perfilS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(perfilS);

                HttpCookie nombreadS = new HttpCookie("nombreadC");
                nombreadS.Value = GridView3.Rows[i].Cells[0].Text;
                nombreadS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombreadS);

                Response.Redirect("InclusionAegurados.aspx");
            }
            
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {            
            HttpCookie indexS = new HttpCookie("indexC");
            indexS.Value = "3";
            indexS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS);

            HttpCookie fechavigS = new HttpCookie("fechavigC");
            fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
            fechavigS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fechavigS);

            Response.Redirect("InclusionAegurados.aspx");
        }
        
        protected void siguiclick(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "2")
                {
                    Response.Redirect("ListaTotal.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Response.Redirect("ListaTotal.aspx");
                }
                else
                {
                    Response.Redirect("Beneficiarios.aspx");
                }
            }
            else
            {
                Response.Redirect("Beneficiarios.aspx");
            }

                
        }
        protected void elim(object sender, EventArgs e)
        {

            Response.Redirect("ReemplazoElim.aspx");
        }
    }
}