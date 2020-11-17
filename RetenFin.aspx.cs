using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class RetenFin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
        }

        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
            {

                string saveStaff = "UPDATE Asegurados SET Retencion=@Retencion, FechaRet=@FechaRet WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;

                    querySaveStaff.Parameters.Add("@FechaRet", SqlDbType.DateTime).Value = DateTime.Now;
                    querySaveStaff.Parameters.Add("@Retencion", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
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
                        Response.Redirect("ProReten.aspx");

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
            Response.Redirect("ProReten.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}