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
    public partial class AsistFin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
            {

                string saveStaff = "INSERT INTO Asistencia (Ejecutivo, Mes, Dias) VALUES (@Ejecutivo, @Mes, @Dias)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;

                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["asistnombre"].Value;
                    querySaveStaff.Parameters.Add("@Mes", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                    querySaveStaff.Parameters.Add("@Dias", SqlDbType.Int).Value = Int32.Parse(Text1.Value);
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('ASISTENCIA REGISTRADA')</script>");                        
                        Response.Redirect("AsistenciaLista.aspx");

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
            Response.Redirect("AsistenciaLista.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}