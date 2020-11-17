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
    public partial class AdminCert : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                SqlCommand cmd = new SqlCommand("select distinct Nombre from Usuario", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DropDownList2.DataSource = dt;
                DropDownList2.DataBind();
            }
            string connectionString = "workstation id = affisDB.mssql.somee.com; packet size = 4096; user id = localarts_SQLLogin_2; pwd = kgiivi9to9; data source = affisDB.mssql.somee.com; persist security info = False; initial catalog = affisDB";
            string query = "SELECT TOP 1 Numero from Certificados ORDER BY Numero DESC";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        int tasa = dr.GetFieldValue<int>(0);
                        int prox = tasa + 1;
                        Text4.Value = prox.ToString();

                    }
                    else
                    {
                        Response.Write("<script>alert('revise la tasa')</script>");

                    }

                    dr.Close();
                }

                con.Close();
            }
        }
               

        protected void Unnamed_Click(object sender, EventArgs e)
        {            
            if(DropDownList1.SelectedValue == "ENTREGADO")
            {
                int ini = Int32.Parse(Text4.Value);
                int cierre = Int32.Parse(Text1.Value);
                for (int i = ini; i <= cierre; i++)
                {
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "INSERT into Certificados (Ejecutivo, Numero, Estado, Observaciones) VALUES (@Ejecutivo, @Numero, @Estado, @Observaciones)";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = i;
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                            querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Correo.Value;
                            
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                
                            }
                            catch (SqlException ex)
                            {
                                Response.Write("Error" + ex);
                            }
                        }
                    }

                }
                Response.Write("<script>alert('CERTIFICADOS ENTREGADOS')</script>");

            }
            else
            {
                if (DropDownList1.SelectedValue == "DEVUELTO")
                {
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Certificados SET Ejecutivo=@Ejecutivo, Estado=@Estado, Observaciones=@Observaciones WHERE Numero=@Numero";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(Text1.Value);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "DEVUELTO";
                            querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Correo.Value;

                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Write("<script>alert('CERTIFICADO DEVUELTO')</script>");

                            }
                            catch (SqlException ex)
                            {
                                Response.Write("Error" + ex);
                            }
                        }
                    }
                }
                else
                {
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Certificados SET Ejecutivo=@Ejecutivo, Estado=@Estado, Observaciones=@Observaciones WHERE Numero=@Numero";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(Text1.Value);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "ANULADO";
                            querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Correo.Value;

                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Write("<script>alert('CERTIFICADO ANULADO')</script>");

                            }
                            catch (SqlException ex)
                            {
                                Response.Write("Error" + ex);
                            }
                        }
                    }
                }
            }
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}