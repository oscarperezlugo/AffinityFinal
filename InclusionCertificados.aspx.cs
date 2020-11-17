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
    public partial class InclusionCertificados : Page
    {
        int certviejo;
        Double m;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Text4.Value = Request.Cookies["nombretomC"].Value;
            Label7.Text = Request.Cookies["paramCedula"].Value;
            Label8.Text = Request.Cookies["nombretomC"].Value;
            Label9.Text = Request.Cookies["totalC"].Value;
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "11")
                {
                    Label10.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label10.Attributes.Add("style", "display:none");
                    certviejo = Int32.Parse(Request.Cookies["paramCerViejo"].Value);

                }
            }

        }        

        

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpCookie nombreS = new HttpCookie("paramCert");
            nombreS.Value = DropDownList1.SelectedValue;
            nombreS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombreS);
            if (Request.Cookies["indexC"].Value == "2")
            {
                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {
                    string saveStaff = "INSERT into Asegurados (Cedula, Nombre, FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, FechaVigencia, MedioDeCobro, FechaEfectiva, FechaVenta, TotalCobrar, NumeroCertificado, Estado, Ejecutivo) VALUES (@Cedula, @Nombre, @FechaNac, @Genero, @Direccion, @DireccionEmpleador, @Cargo, @Codigo, @telfcelular, @telfempresa, @Email, @NombreComercial, @FechaVigencia, @MedioDeCobro, @FechaEfectiva, @FechaVenta, @TotalCobrar, @NumeroCertificado, @Estado, @Ejecutivo)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Request.Cookies["paramCedula"].Value;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Request.Cookies["nombretomC"].Value;
                        querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechanacadC"].Value);
                        querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = Request.Cookies["generoadcC"].Value;
                        querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Request.Cookies["direccionadC"].Value;
                        querySaveStaff.Parameters.Add("@DireccionEmpleador", SqlDbType.VarChar).Value = Request.Cookies["direccionemadC"].Value;
                        querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Request.Cookies["cargoadC"].Value;
                        querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Request.Cookies["codigoadC"].Value;
                        querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = Request.Cookies["telceladC"].Value;
                        querySaveStaff.Parameters.Add("@telfempresa", SqlDbType.VarChar).Value = Request.Cookies["telempreadC"].Value;
                        querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Request.Cookies["emailadC"].Value;
                        querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
                        querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse("" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01");
                        querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = Request.Cookies["medioadC"].Value;
                        querySaveStaff.Parameters.Add("@FechaEfectiva", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(Label9.Text);
                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "VENTA";
                        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["nombreC"].Value;
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

                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {
                    string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificado WHERE CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedula"].Value);
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
                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {
                    string saveStaff = "UPDATE Certificados SET Estado=@Estado WHERE Numero=@Numero";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";

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
                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {
                    string saveStaff = "UPDATE Pagos SET Deuda=Deuda + @Deuda WHERE RazonSocial=@RazonSocial";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label9.Text);
                        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;

                        try
                        {
                            Response.Cookies["totalC"].Expires = DateTime.Now.AddDays(-1);
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Redirect("AdjuntarCert.aspx");

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
                if (Request.Cookies["indexC"].Value == "3")
                {
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "INSERT into Asegurados (Cedula, Nombre, FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, FechaVigencia, MedioDeCobro, FechaEfectiva, FechaVenta, TotalCobrar, NumeroCertificado, Estado, Ejecutivo) VALUES (@Cedula, @Nombre, @FechaNac, @Genero, @Direccion, @DireccionEmpleador, @Cargo, @Codigo, @telfcelular, @telfempresa, @Email, @NombreComercial, @FechaVigencia, @MedioDeCobro, @FechaEfectiva, @FechaVenta, @TotalCobrar, @NumeroCertificado, @Estado, @Ejecutivo)";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Request.Cookies["paramCedula"].Value;
                            querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Request.Cookies["nombretomC"].Value;
                            querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechanacadC"].Value);
                            querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = Request.Cookies["generoadcC"].Value;
                            querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Request.Cookies["direccionadC"].Value;
                            querySaveStaff.Parameters.Add("@DireccionEmpleador", SqlDbType.VarChar).Value = Request.Cookies["direccionemadC"].Value;
                            querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Request.Cookies["cargoadC"].Value;
                            querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Request.Cookies["codigoadC"].Value;
                            querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = Request.Cookies["telceladC"].Value;
                            querySaveStaff.Parameters.Add("@telfempresa", SqlDbType.VarChar).Value = Request.Cookies["telempreadC"].Value;
                            querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Request.Cookies["emailadC"].Value;
                            querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
                            querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse("" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01");
                            querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = Request.Cookies["medioadC"].Value;
                            querySaveStaff.Parameters.Add("@FechaEfectiva", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(Label9.Text);
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "VENTA";
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["nombreC"].Value;
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Write("<script>alert('TOMADOR REGISTRADO')</script>");

                            }
                            catch (SqlException ex)
                            {
                                Response.Write("Error" + ex);
                            }
                        }
                    }

                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificado WHERE CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedula"].Value);
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
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Certificados SET Estado=@Estado WHERE Numero=@Numero";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";

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
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Pagos SET Deuda=Deuda + @Deuda WHERE RazonSocial=@RazonSocial";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label9.Text);
                            querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;

                            try
                            {
                                Response.Cookies["totalC"].Expires = DateTime.Now.AddDays(-1);
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Redirect("AdjuntarCert.aspx");

                            }
                            catch (SqlException ex)
                            {
                                Response.Write("Error" + ex);
                            }
                        }
                    }
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Asegurados SET TotalCobrar=@TotalCobrar, Estado=@Estado, NumeroCertificado=@NumeroCertificado, Ejecutivo=@Ejecutivo, FechaReemplazo=@FechaReemplazo WHERE NumeroCertificado=@NumeroCertificadoViejo";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(Label9.Text);
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@NumeroCertificadoViejo", SqlDbType.Int).Value = certviejo;
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@FechaReemplazo", SqlDbType.DateTime).Value = DateTime.Now;
                            querySaveStaff.Parameters.Add("@Cedula", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedula"].Value);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "VENTA";
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["nombreC"].Value;
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
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificado WHERE CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedula"].Value);
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
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Certificados SET Estado=@Estado WHERE Numero=@Numero";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";

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
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Pagos SET Deuda=Deuda + @Deuda WHERE RazonSocial=@RazonSocial";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label9.Text);
                            querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;

                            try
                            {
                                Response.Cookies["totalC"].Expires = DateTime.Now.AddDays(-1);
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Redirect("AdjuntarCert.aspx");

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
                        string saveStaff = "UPDATE Asegurados SET TotalCobrar=@TotalCobrar, Estado=@Estado, NumeroCertificado=@NumeroCertificado, Ejecutivo=@Ejecutivo WHERE Cedula=@Cedula AND FechaVenta=@FechaVenta";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(Label9.Text);
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@Cedula", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedula"].Value);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "VENTA";
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["nombreC"].Value;
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
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificado WHERE CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedula"].Value);
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
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Certificados SET Estado=@Estado WHERE Numero=@Numero";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";

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
                    using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                    {
                        string saveStaff = "UPDATE Pagos SET Deuda=Deuda + @Deuda WHERE RazonSocial=@RazonSocial";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label9.Text);
                            querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;

                            try
                            {
                                Response.Cookies["totalC"].Expires = DateTime.Now.AddDays(-1);
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();                                
                                Response.Redirect("AdjuntarCert.aspx");

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
            Response.Redirect("ListaTotal.aspx");
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            Response.Redirect("ListaTotal.aspx");
        }
    }
}