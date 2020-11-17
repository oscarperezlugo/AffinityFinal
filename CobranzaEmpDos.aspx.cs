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
    public partial class CobranzaEmpDos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tasa;
            string tasa2;
            string connectionString = "workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB";
            string query = "select sum(TotalCobrar) as Monto from Asegurados where NombreComercial='" + Request.Cookies["emprecobnom"].Value + "'";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    
                    if (dr.Read())
                    {
                        if (dr.IsDBNull(0))
                        {
                            
                            tasa = "0";
                            
                        }
                        else
                        {
                            tasa = dr.GetFieldValue<decimal>(0).ToString();
                            
                        }
                                               
                         
                    }
                    else
                    {
                        tasa = "0";
                        
                    }
                    
                    

                    dr.Close();
                }

                con.Close();
            }
            string connectionString2 = "workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB";
            string query2 = "select Deuda as Monto from Pagos where RazonSocial='" + Request.Cookies["emprecobnom"].Value + "'";


            using (SqlConnection con2 = new SqlConnection(connectionString2))
            using (SqlCommand cmd2 = new SqlCommand(query2, con2))
            {

                con2.Open();


                using (SqlDataReader dr2 = cmd2.ExecuteReader())
                {

                    if (dr2.Read())
                    {
                        if (dr2.IsDBNull(0))
                        {

                            tasa2 = "0";

                        }
                        else
                        {
                            tasa2 = dr2.GetFieldValue<decimal>(0).ToString();

                        }


                    }
                    else
                    {
                        tasa2 = "0";

                    }



                    dr2.Close();
                }

                con2.Close();
            }
            decimal tasa3 = Decimal.Parse(tasa2);
            if (tasa3 > 0)
            {
                Correo.Value = tasa2.ToString();
                Double neto = Double.Parse(tasa2) + (0.12 * Double.Parse(tasa2));
                Text1.Value = neto.ToString();
            }
            else
            {
                Correo.Value = tasa.ToString();
                Double neto = Double.Parse(tasa) + (0.12 * Double.Parse(tasa));
                Text1.Value = neto.ToString();
            }
            
            
            
            Label33.Text = Request.Cookies["emprecobmes"].Value;
            
        }

        protected void PAGAR(object sender, EventArgs e)
        {
            int mes = Int32.Parse(Label33.Text) + 1;
            string empresa = Request.Cookies["emprecobnom"].Value;
            double deuda = Double.Parse(Label29.Text);
            if (deuda > 0)
            {
                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {

                    string saveStaff = "UPDATE Pagos SET FormaPago=@FormaPago, NumeroFactura=@NumeroFactura, ValorFactura=@ValorFactura, ValorNotaCred=@ValorNotaCred, NumeroFactComi=@NumeroFactComi, ValorFactComi=@ValorFactComi, ValorReten=@ValorReten, NumeroReten=@NumeroReten, ValorRetenEmp=@ValorRetenEmp, Banco=@Banco, Cuenta=@Cuenta, FechaTransf=@FechaTransf, Comprobante=@Comprobante, ValorTransf=@ValorTransf, ValorDebito=@ValorDebito, NumeroNotaCred=@NumeroNotaCred, Deuda=@Deuda WHERE RazonSocial=@RazonSocial";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = Correo.Value;
                        querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label29.Text);
                        querySaveStaff.Parameters.Add("@NumeroFactura", SqlDbType.VarChar).Value = Text2.Value;
                        querySaveStaff.Parameters.Add("@ValorFactura", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@ValorNotaCred", SqlDbType.Money).Value = Decimal.Parse(Text3.Value);
                        querySaveStaff.Parameters.Add("@NumeroFactComi", SqlDbType.VarChar).Value = Text7.Value;
                        querySaveStaff.Parameters.Add("@ValorReten", SqlDbType.Money).Value = Decimal.Parse(Text9.Value);
                        querySaveStaff.Parameters.Add("@NumeroReten", SqlDbType.VarChar).Value = Text9.Value;
                        querySaveStaff.Parameters.Add("@ValorRetenEmp", SqlDbType.VarChar).Value = Text10.Value;
                        querySaveStaff.Parameters.Add("@Banco", SqlDbType.VarChar).Value = "" + Text11.Value + " " + Text16.Value + "";
                        querySaveStaff.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = ""+Text12.Value+" "+Text17.Value+"";
                        querySaveStaff.Parameters.Add("@FechaTransf", SqlDbType.VarChar).Value = DateTime.Now;
                        querySaveStaff.Parameters.Add("@Comprobante", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorTransf", SqlDbType.Money).Value = Decimal.Parse(Label31.Text);
                        querySaveStaff.Parameters.Add("@ValorDebito", SqlDbType.Money).Value = Decimal.Parse(Label31.Text);
                        querySaveStaff.Parameters.Add("@ValorFactComi", SqlDbType.Money).Value = Decimal.Parse(Text7.Value);
                        querySaveStaff.Parameters.Add("@NumeroNotaCred", SqlDbType.VarChar).Value = Text4.Value;                         
                        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;                        
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
            else
            {
                using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                {

                    string saveStaff = "UPDATE Pagos SET FormaPago=@FormaPago, NumeroFactura=@NumeroFactura, ValorFactura=@ValorFactura, ValorNotaCred=@ValorNotaCred, NumeroFactComi=@NumeroFactComi, ValorFactComi=@ValorFactComi, ValorReten=@ValorReten, NumeroReten=@NumeroReten, ValorRetenEmp=@ValorRetenEmp, Banco=@Banco, Cuenta=@Cuenta, FechaTransf=@FechaTransf, Comprobante=@Comprobante, ValorTransf=@ValorTransf, ValorDebito=@ValorDebito, NumeroNotaCred=@NumeroNotaCred, Deuda=@Deuda, Status='PAGADO' WHERE RazonSocial=@RazonSocial";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = Correo.Value;
                        querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label29.Text);
                        querySaveStaff.Parameters.Add("@NumeroFactura", SqlDbType.VarChar).Value = Text2.Value;
                        querySaveStaff.Parameters.Add("@ValorFactura", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@ValorNotaCred", SqlDbType.Money).Value = Decimal.Parse(Text3.Value);
                        querySaveStaff.Parameters.Add("@NumeroFactComi", SqlDbType.VarChar).Value = Text7.Value;
                        querySaveStaff.Parameters.Add("@ValorReten", SqlDbType.Money).Value = Decimal.Parse(Text9.Value);
                        querySaveStaff.Parameters.Add("@NumeroReten", SqlDbType.VarChar).Value = Text9.Value;
                        querySaveStaff.Parameters.Add("@ValorRetenEmp", SqlDbType.VarChar).Value = Text10.Value;
                        querySaveStaff.Parameters.Add("@Banco", SqlDbType.VarChar).Value = "" + Text11.Value + " " + Text16.Value + "";
                        querySaveStaff.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = "" + Text12.Value + " " + Text17.Value + "";
                        querySaveStaff.Parameters.Add("@FechaTransf", SqlDbType.VarChar).Value = DateTime.Now;
                        querySaveStaff.Parameters.Add("@Comprobante", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorTransf", SqlDbType.Money).Value = Decimal.Parse(Label31.Text);
                        querySaveStaff.Parameters.Add("@ValorDebito", SqlDbType.Money).Value = Decimal.Parse(Label31.Text);
                        querySaveStaff.Parameters.Add("@ValorFactComi", SqlDbType.Money).Value = Decimal.Parse(Text7.Value);
                        querySaveStaff.Parameters.Add("@NumeroNotaCred", SqlDbType.VarChar).Value = Text4.Value;
                        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;
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

                    string saveStaff = "INSERT INTO Pagos (RazonSocial, Mes, Deuda) VALUES (@RazonSocial, @Mes, 0)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;                        
                        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;
                        querySaveStaff.Parameters.Add("@Mes", SqlDbType.DateTime).Value = ""+DateTime.Now.Year+"-"+mes+"-01";
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('PAGO REGISTRADA')</script>");
                            Response.Redirect("EmpDetalleUno.aspx");
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }


                }
            }

        }     
        
        protected void siguiclick(object sender, EventArgs e)
        {            

            Response.Redirect("Default.aspx");
        }
        protected void siguiclickDOS(object sender, EventArgs e)
        {

            Response.Redirect("CobranzaEmpUno.aspx");
        }
        protected void calc(object sender, EventArgs e)
        {
            double cheque;
            if (Text3.Value == "")
            {
                cheque = 0;
            }
            else
            {
                cheque = Double.Parse(Text3.Value);
            }
            double cobrar = Double.Parse(Text1.Value) - cheque;
            string cadena = cobrar.ToString();
            Text5.Value = cadena;
        }
        protected void calcdos(object sender, EventArgs e)
        {
            double cheque;
            if (Text14.Value == "")
            {
                cheque = 0;
            }
            else
            {
                cheque = Double.Parse(Text14.Value);
            }
            double transf;
            if (Text20.Value == "")
            {
                transf = 0;
            }
            else
            {
                transf = Double.Parse(Text20.Value);
            }
            double debito;
            if (Text21.Value == "")
            {
                debito = 0;
            }
            else
            {
                debito = Double.Parse(Text21.Value);
            }
            double cobrar = Double.Parse(Text5.Value);            
            double totalcobro = cobrar - (cheque + transf + debito);
            double pago = cheque + transf + debito;
            Label29.Text = totalcobro.ToString();
            Label31.Text = pago.ToString();
            double deuda = cobrar - totalcobro;
        }
    }
}