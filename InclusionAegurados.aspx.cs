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
    public partial class InclusionAegurados : Page
    {
        Double m;
        protected void Page_Load(object sender, EventArgs e)
        {                
            
            
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "1")
                {
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    prefifin.Text = "0,00";
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                    DropDownList5.Attributes.Add("style", "display:none");

                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                    Correo.Value = Request.Cookies["paramCedula"].Value;
                    Text1.Value = Request.Cookies["nombretomC"].Value;
                    Text2.Value = Request.Cookies["fechanacC"].Value;
                    DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    prefifin.Text = "0,00";
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                    DropDownList5.Attributes.Add("style", "display:none");

                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                    DateTime FECHA = DateTime.Parse(Request.Cookies["fechanacC"].Value);
                    Correo.Value = Request.Cookies["paramCedulaD"].Value;
                    Text1.Value = Request.Cookies["nombreadC"].Value;
                    Text2.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                    DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                }
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    prefifin.Text = "0,00";
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                    DropDownList5.Attributes.Add("style", "display:none");

                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label11.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "8")
                {
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    prefifin.Text = Request.Cookies["primaproC"].Value.ToString();
                    DropDownList5.Attributes.Add("style", "display:none");

                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                    DateTime FECHA = DateTime.Parse(Request.Cookies["fechanacC"].Value);
                    Correo.Value = Request.Cookies["paramCedulaD"].Value;
                    Text1.Value = Request.Cookies["nombreadC"].Value;
                    Text2.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                    DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                    DropDownList2.SelectedValue = Request.Cookies["relaproaD"].Value;
                    DropDownList3.SelectedValue = Request.Cookies["cobproC"].Value;
                    DropDownList4.SelectedValue = Request.Cookies["planproC"].Value;
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd = new SqlCommand("select distinct Producto from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataBind();
                        DropDownList3.Enabled = true;

                        SqlConnection con2 = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd2 = new SqlCommand("select distinct PlanSelect from Productos", con2);
                        SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        DropDownList4.DataSource = dt2;
                        DropDownList4.DataBind();
                        DropDownList4.Enabled = true;
                    }
                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);

                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "9";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    prefifin.Text = Request.Cookies["primaproC"].Value.ToString();
                    DropDownList5.Attributes.Add("style", "display:none");

                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    DateTime FECHA = DateTime.Parse(Request.Cookies["fechanacC"].Value);
                    Correo.Value = Request.Cookies["paramCedulaD"].Value;
                    Text1.Value = Request.Cookies["nombreadC"].Value;
                    Text2.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                    DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                    DropDownList2.SelectedValue = Request.Cookies["relaproaD"].Value;
                    DropDownList3.SelectedValue = Request.Cookies["cobproC"].Value;
                    DropDownList4.SelectedValue = Request.Cookies["planproC"].Value;
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd = new SqlCommand("select distinct Producto from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataBind();
                        DropDownList3.Enabled = true;

                        SqlConnection con2 = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd2 = new SqlCommand("select distinct PlanSelect from Productos", con2);
                        SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        DropDownList4.DataSource = dt2;
                        DropDownList4.DataBind();
                        DropDownList4.Enabled = true;
                    }
                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);

                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "31";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                }
                if (Request.Cookies["indexC"].Value == "11")
                {
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    prefifin.Text = "0,00";
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                    DropDownList5.Attributes.Add("style", "display:none");

                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                    //Correo.Value = Request.Cookies["paramCedula"].Value;
                    //Text1.Value = Request.Cookies["nombretomC"].Value;
                    //Text2.Value = Request.Cookies["fechanacC"].Value;
                    //DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                }

            }
            else
            {

            }
        }        


        protected void fijarrelacion(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("COBERTURA");

            SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
            SqlCommand cmd = new SqlCommand("select distinct Producto from Productos where Aplica = '"+DropDownList2.SelectedValue+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList3.DataSource = dt;
            DropDownList3.DataBind();
            DropDownList3.Enabled = true;
            

        }
        protected void fijarcobertura(object sender, EventArgs e)
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("PLAN");

            SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
            SqlCommand cmd = new SqlCommand("select distinct PlanSelect from Productos where Aplica = '" + DropDownList2.SelectedValue + "' and Producto = '"+DropDownList3.SelectedValue+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList4.DataSource = dt;
            DropDownList4.DataBind();
            DropDownList4.Enabled = true;
           
        }
        protected void fijarplan(object sender, EventArgs e)
        {
            DropDownList5.Items.Clear();            

            SqlConnection con = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB");
            SqlCommand cmd = new SqlCommand("select distinct Valor from Productos where Aplica = '" + DropDownList2.SelectedValue + "' and Producto = '" + DropDownList3.SelectedValue + "' and PlanSelect ='" + DropDownList4.SelectedValue+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList5.DataSource = dt;
            DropDownList5.DataBind();
            DropDownList5.Enabled = true;
            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
           
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"].Value == "1")
            {                
                prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                string CedulaTom = Request.Cookies["paramCedula"].Value;
                string Ejec = Request.Cookies["nombreC"].Value;
                string fecha = Request.Cookies["fechaC"].Value;
                //if (Request.Cookies["totalC"] == null)
                //{
                //    m = Double.Parse(prefifin.Text);
                //}
                //else
                //{
                //    double n = Double.Parse(Request.Cookies["totalC"].Value);
                //    double x = Double.Parse(prefifin.Text);
                //    m = x;
                //}
                //HttpCookie totalS = new HttpCookie("totalC");
                //totalS.Value = prefifin.Text;
                //totalS.Expires = DateTime.Now.AddDays(30);
                //Response.Cookies.Add(totalS);
                HttpCookie total2S = new HttpCookie("indexC");
                total2S.Value = "11";
                total2S.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(total2S);
                //using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                //{
                //    string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo)";

                //    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                //    {
                //        querySaveStaff.Connection = openCon;
                //        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                //        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                //        querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                //        querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                //        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                //        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(CedulaTom);
                //        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                //        try
                //        {
                //            openCon.Open();
                //            querySaveStaff.ExecuteNonQuery();
                //            openCon.Close();
                //        }
                //        catch (SqlException ex)
                //        {
                //            Response.Write("Error" + ex);
                //        }
                //    }
                //}
            }
            if (Request.Cookies["indexC"].Value == "11")
            {
                prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                string CedulaTom = Request.Cookies["paramCedula"].Value;
                string Ejec = Request.Cookies["nombreC"].Value;
                string fecha = Request.Cookies["fechaC"].Value;
                if (Request.Cookies["totalC"] == null)
                {
                    m = double.Parse(prefifin.Text);
                }
                else
                {
                    double n = Double.Parse(Request.Cookies["totalC"].Value);
                    double x = Double.Parse(prefifin.Text);
                    m = n + x;
                }
                HttpCookie totalS = new HttpCookie("totalC");
                totalS.Value = m.ToString();
                totalS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(totalS);                
                //using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                //{
                //    string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo)";

                //    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                //    {
                //        querySaveStaff.Connection = openCon;
                //        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                //        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                //        querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                //        querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                //        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                //        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(CedulaTom);
                //        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                //        try
                //        {
                //            openCon.Open();
                //            querySaveStaff.ExecuteNonQuery();
                //            openCon.Close();
                //        }
                //        catch (SqlException ex)
                //        {
                //            Response.Write("Error" + ex);
                //        }
                //    }
                //}
            }

            if (Request.Cookies["indexC"].Value == "2")
            {
                prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                string CedulaTom = Request.Cookies["paramCedula"].Value;
                string Ejec = Request.Cookies["nombreC"].Value;
                string fecha = Request.Cookies["fechaC"].Value;
                if (Request.Cookies["totalC"] == null)
                {
                    m = double.Parse(prefifin.Text);
                }
                else
                {
                    double n = Double.Parse(Request.Cookies["totalC"].Value);
                    double x = Double.Parse(prefifin.Text);
                    m = n + x;
                }
                HttpCookie totalS = new HttpCookie("totalC");
                totalS.Value = m.ToString();
                totalS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(totalS);
                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {
                    string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(CedulaTom);
                        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
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

                    string saveStaff = "INSERT into Dependientes (Nombre, Cedula, Relacion, Producto, [Plan], TotalPrima, TotalCobrar, Genero, telfcelular, CedulaTomador, FechaVenta, FechaVigencia, FechaNac, NumeroCertificado) VALUES (@Nombre, @Cedula, @Relacion, @Producto, @Plan, @TotalPrima, @TotalCobrar, @Genero, @telfcelular, @CedulaTomador, @FechaVenta, @FechaVigencia, @FechaNac, @NumeroCertificado)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@Cedula", SqlDbType.Int).Value = Int32.Parse(Correo.Value);
                        querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                        querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                        querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                        querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.VarChar).Value = Int32.Parse(CedulaTom);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                        querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                        querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                            Response.Redirect("AdicionSeleccion.aspx");
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
            if (Request.Cookies["indexC"].Value == "9")
            {
                string CedulaTom = Request.Cookies["paramCedula"].Value;
                string Ejec = Request.Cookies["nombreC"].Value;
                string fecha = Request.Cookies["fechaC"].Value;
                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {

                    string saveStaff = "UPDATE Dependientes SET Nombre=@Nombre, Cedula=@Cedula, Relacion=@Relacion, Producto=@Producto, [Plan]=@Plan, TotalPrima=@TotalPrima, TotalCobrar=@TotalCobrar, Genero=@Genero, telfcelular=@telfcelular, CedulaTomador=@CedulaTomador, FechaVenta=@FechaVenta, FechaVigencia=@FechaVigencia, FechaNac=@FechaNac, NumeroCertificado=@NumeroCertificado WHERE Nombre=@FIJADOR1 AND Cedula=@FIJADOR2 AND Producto=@FIJADOR3";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@Cedula", SqlDbType.Int).Value = Int32.Parse(Correo.Value);
                        querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                        querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                        querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                        querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.VarChar).Value = Int32.Parse(CedulaTom);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                        querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                        querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                        querySaveStaff.Parameters.Add("@FIJADOR1", SqlDbType.VarChar).Value = Request.Cookies["nombreadC"].Value;
                        querySaveStaff.Parameters.Add("@FIJADOR2", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedulaD"].Value);
                        querySaveStaff.Parameters.Add("@FIJADOR3", SqlDbType.VarChar).Value = Request.Cookies["cobproC"].Value;
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
                            Response.Redirect("AdicionSeleccion.aspx");
                            
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
            if (Request.Cookies["indexC"].Value == "31")
            {
                prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                string CedulaTom = Request.Cookies["paramCedula"].Value;
                string Ejec = Request.Cookies["nombreC"].Value;
                string fecha = Request.Cookies["fechaC"].Value;
                if (Request.Cookies["totalC"] == null)
                {
                    double t = double.Parse(DropDownList5.SelectedValue);
                    double z = double.Parse(Request.Cookies["ajusteC"].Value);
                    double y = double.Parse(Request.Cookies["primaproC"].Value);
                    m = (z - y) + t;
                }
                else
                {
                    double n = Double.Parse(Request.Cookies["totalC"].Value);
                    double x = Double.Parse(DropDownList5.SelectedValue);
                    double z = double.Parse(Request.Cookies["ajusteC"].Value);
                    double y = double.Parse(Request.Cookies["primaproC"].Value);
                    m = (n-y+x);
                }
                HttpCookie totalS = new HttpCookie("totalC");
                totalS.Value = m.ToString();
                totalS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(totalS);
                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {
                    string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(CedulaTom);
                        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
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

                    string saveStaff = "UPDATE Dependientes SET Nombre=@Nombre, Cedula=@Cedula, Relacion=@Relacion, Producto=@Producto, [Plan]=@Plan, TotalPrima=@TotalPrima, TotalCobrar=@TotalCobrar, Genero=@Genero, telfcelular=@telfcelular, CedulaTomador=@CedulaTomador, FechaVenta=@FechaVenta, FechaVigencia=@FechaVigencia, FechaNac=@FechaNac, NumeroCertificado=@NumeroCertificado WHERE Nombre=@FIJADOR1 AND Cedula=@FIJADOR2 AND Producto=@FIJADOR3";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@Cedula", SqlDbType.Int).Value = Int32.Parse(Correo.Value);
                        querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                        querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                        querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                        querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.VarChar).Value = Int32.Parse(CedulaTom);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                        querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                        querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                        querySaveStaff.Parameters.Add("@FIJADOR1", SqlDbType.VarChar).Value = Request.Cookies["nombreadC"].Value;
                        querySaveStaff.Parameters.Add("@FIJADOR2", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedulaD"].Value);
                        querySaveStaff.Parameters.Add("@FIJADOR3", SqlDbType.VarChar).Value = Request.Cookies["cobproC"].Value;
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                            HttpCookie indexS = new HttpCookie("indexC");
                            indexS.Value = "30";
                            indexS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(indexS);
                            Response.Redirect("AdicionSeleccion.aspx");

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
                //Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);
                prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                string CedulaTom = Request.Cookies["paramCedula"].Value;
                string Ejec = Request.Cookies["nombreC"].Value;
                string fecha = Request.Cookies["fechaC"].Value;
                if (Request.Cookies["totalC"] == null)
                {
                    m = double.Parse(prefifin.Text);
                }
                else
                {
                    double n = Double.Parse(Request.Cookies["totalC"].Value);
                    double x = Double.Parse(prefifin.Text);
                    m = n + x;
                }
                HttpCookie totalS = new HttpCookie("totalC");
                totalS.Value = m.ToString();
                totalS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(totalS);
                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {

                    string saveStaff = "INSERT into Dependientes (Nombre, Cedula, Relacion, Producto, [Plan], TotalPrima, TotalCobrar, Genero, telfcelular, CedulaTomador, FechaVenta, FechaVigencia, FechaNac) VALUES (@Nombre, @Cedula, @Relacion, @Producto, @Plan, @TotalPrima, @TotalCobrar, @Genero, @telfcelular, @CedulaTomador, @FechaVenta, @FechaVigencia, @FechaNac)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@Cedula", SqlDbType.Int).Value = Int32.Parse(Correo.Value);
                        querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                        querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                        querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                        querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.VarChar).Value = Int32.Parse(CedulaTom);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                        querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                        querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
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
                    string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(CedulaTom);
                        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
                
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "9")
                {
                    Response.Redirect("Beneficiarios.aspx");
                }
                else
                {
                    Response.Redirect("ListaTotal.aspx");
                }
            }
            else
            {
                Response.Redirect("ListaTotal.aspx");
            }
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "9")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "8";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("AdicionSeleccion.aspx");
                }
                else
                {
                    Response.Redirect("InclusionTomador.aspx");
                }
            }
            else
            {
                Response.Redirect("InclusionTomador.aspx");
            }
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}