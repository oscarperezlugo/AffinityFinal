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
    public partial class MedioCobro : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            prefifin.Text = Request.Cookies["paramTotalCert"].Value;
            if (Request.Cookies["paramCedula"] != null)
            {
                
                    //INCLU.Attributes.Add("style", "display:inline");
                
            }
            else
            {

            }
        }

        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string cuentatipo;
            int tarjeta;
            if (Radio1.Checked == true)
            {
                cuentatipo = "AHORROS";
            }
            else
            {
                if (Radio2.Checked == true)
                {
                    cuentatipo = "CORRIENTE";
                }
                else
                {
                    cuentatipo = "";
                }

                
            }
            if (Text8.Value == "")
            {
                tarjeta = 0;
            }
            else
            {
                tarjeta = Int32.Parse(Text8.Value);

            }
            using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
            {

                string saveStaff = "UPDATE Asegurados SET Banco=@Banco, Cuenta=@Cuenta, Tarjeta=@Tarjeta, TipoCuenta=@TipoCuenta, Vencimiento=@Vencimiento, CodigoSeguridad=@CodigoSeguridad, Digitador=@Digitador, NumeroTar=@NumeroTar WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Banco", SqlDbType.VarChar).Value = Text1.Value;
                    querySaveStaff.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = Text4.Value;
                    querySaveStaff.Parameters.Add("@Tarjeta", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                    querySaveStaff.Parameters.Add("@TipoCuenta", SqlDbType.VarChar).Value = cuentatipo;
                    querySaveStaff.Parameters.Add("@Vencimiento", SqlDbType.VarChar).Value = Text10.Value;
                    querySaveStaff.Parameters.Add("@NumeroTar", SqlDbType.BigInt).Value = tarjeta;
                    querySaveStaff.Parameters.Add("@CodigoSeguridad", SqlDbType.VarChar).Value = Text11.Value;
                    querySaveStaff.Parameters.Add("@Digitador", SqlDbType.VarChar).Value = Request.Cookies["nombreC"].Value;                    
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
                        Response.Redirect("AdjuntarCert.aspx");

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