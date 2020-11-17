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
    public partial class AdjuntarCert : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "11")
                {
                    DropDownList1.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    DropDownList1.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    DropDownList1.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    DropDownList1.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                }
                else
                {
                    Label2.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                }
            }
            else
            {
                Label2.Attributes.Add("style", "display:none");
                Label3.Attributes.Add("style", "display:none");
                Label8.Attributes.Add("style", "display:none");
            }
            
        }

        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string transferente1;
            string transferente2;
            string transferente3;
            using (BinaryReader reader = new BinaryReader(FileUpload1.PostedFile.InputStream))
            {
                if (FileUpload1.HasFile == true)
                {
                    var Archivod1 = reader.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    transferente1 = Convert.ToBase64String(Archivod1);
                    
                }
                else
                {
                    transferente1 = "";
                }
            }
            using (BinaryReader reader2 = new BinaryReader(FileUpload2.PostedFile.InputStream))
            {
                if (FileUpload2.HasFile == true)
                {
                    var Archivod2 = reader2.ReadBytes(FileUpload2.PostedFile.ContentLength);
                    transferente2 = Convert.ToBase64String(Archivod2);

                }
                else
                {
                    transferente2 = "";
                }
            }
            using (BinaryReader reader3 = new BinaryReader(FileUpload3.PostedFile.InputStream))
            {
                if (FileUpload3.HasFile == true)
                {
                    var Archivod3 = reader3.ReadBytes(FileUpload3.PostedFile.ContentLength);
                    transferente3 = Convert.ToBase64String(Archivod3);

                }
                else
                {
                    transferente3 = "";
                }
            }
            using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
            {

                string saveStaff = "UPDATE Asegurados SET Archivo1=@Archivo1, Archivo2=@Archivo2, Archivo3=@Archivo3, Proceso=@Proceso WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Archivo1", SqlDbType.VarChar).Value = transferente1;
                    querySaveStaff.Parameters.Add("@Archivo2", SqlDbType.VarChar).Value = transferente2;
                    querySaveStaff.Parameters.Add("@Archivo3", SqlDbType.VarChar).Value = transferente3;                    
                    querySaveStaff.Parameters.Add("@Proceso", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
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
                        Response.Redirect("Default.aspx");

                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InclusionTomador.aspx");

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string url = "https://www.registrocivil.gob.ec/";
            Response.Write("<script> window.open('" + url + "','_blank'); </script>");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            string url = "https://srienlinea.sri.gob.ec/sri-en-linea/SriDeclaracionesWeb/ConsultaImpuestoRenta/Consultas/consultaImpuestoRenta";
            Response.Write("<script> window.open('" + url + "','_blank'); </script>");
        }
    }
}