using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class Beneficiarios : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
            if (Request.Cookies["paramCedula"] != null)
            {
                
                    
                
            }
            else
            {

            }
        }

        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            string fecha = Request.Cookies["fechaC"].Value;
            using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
            {

                string saveStaff = "UPDATE Asegurados SET Beneficiario1=@Beneficiario1, Beneficiario2=@Beneficiario2, Beneficiario3=@Beneficiario3, Beneficiario4=@Beneficiario4, Beneficiario5=@Beneficiario5 WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Beneficiario1", SqlDbType.VarChar).Value = ""+Correo.Value+" "+Text1.Value+" "+Text2.Value+"";
                    querySaveStaff.Parameters.Add("@Beneficiario5", SqlDbType.VarChar).Value = "" + Text12.Value + " " + Text13.Value + " " + Text14.Value + "";
                    querySaveStaff.Parameters.Add("@Beneficiario2", SqlDbType.VarChar).Value = "" + Text3.Value + " " + Text4.Value + " " + Text5.Value + "";
                    querySaveStaff.Parameters.Add("@Beneficiario3", SqlDbType.VarChar).Value = "" + Text6.Value + " " + Text7.Value + " " + Text8.Value + "";
                    querySaveStaff.Parameters.Add("@Beneficiario4", SqlDbType.VarChar).Value = "" + Text9.Value + " " + Text10.Value + " " + Text11.Value + "";
                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                        HttpCookie indexS = new HttpCookie("indexC");
                        indexS.Value = "8";
                        indexS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(indexS);
                        Response.Redirect("MedioCobro.aspx");

                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }

        }
        

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdicionSeleccion.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}