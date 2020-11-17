using Newtonsoft.Json;
using ReachSystem.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class ListaTotal : Page
    {
        Double m;
        protected void Page_Load(object sender, EventArgs e)
        {
            Text4.Value = Request.Cookies["nombretomC"].Value;
            prefifin.Text = Request.Cookies["totalC"].Value;
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "11")
                {
                    Label2.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");


                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");


                }
            }
        }
        

       

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            
            if (Request.Cookies["indexC"].Value == "2")
            {
                //Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);
                //Response.Redirect("AdicionSeleccion.aspx");
                Response.Redirect("InclusionCertificados.aspx");
            }
            else
            {                
                Response.Redirect("InclusionCertificados.aspx");
            }
        }

       
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;

            string CedulaTom = Request.Cookies["paramCedula"].Value;
            string Ejec = Request.Cookies["nombreC"].Value;
            string fecha = Request.Cookies["fechaC"].Value;
            string nombre = GridView1.Rows[i].Cells[0].Text;
            string prod = GridView1.Rows[i].Cells[1].Text;
            string plan = GridView1.Rows[i].Cells[2].Text;

            double n = Double.Parse(GridView1.Rows[i].Cells[3].Text);
            double x = Double.Parse(prefifin.Text);
            m = x - n;
            HttpCookie totalS = new HttpCookie("totalC");
            totalS.Value = m.ToString();
            totalS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(totalS);
            prefifin.Text = m.ToString();
            using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
            {
                

                string saveStaff = "DELETE FROM VentaTemp WHERE Nombre=@Nombre AND PlanSelect=@PlanSelect AND CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta AND Ejecutivo=@Ejecutivo AND Producto=@Producto"; 

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = prod;
                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = plan;
                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(CedulaTom);
                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.NVarChar).Value = Ejec;

                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        GridView1.DataBind();
                        
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }
            using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
            {                

                string saveStaff = "DELETE FROM Dependientes WHERE Nombre=@Nombre AND [Plan]=@Plan AND CedulaTomador=@CedulaTomador AND Producto=@Producto";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = prod;
                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = plan;
                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(CedulaTom);                    

                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        GridView1.DataBind();
                        Response.Write("<script>alert('REGISTRO EXCLUIDO')</script>");
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }

        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            Response.Redirect("InclusionAegurados.aspx");
        }
    }
}