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
    public partial class EmpresaDetalleDos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Text2.Value = Request.Cookies["empdetalleC"].Value;
            Text2.Disabled = true;

        }



        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {

            using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
            {

                string saveStaff = "UPDATE Empresa SET Ruc=@Ruc, RazonSocial=@RazonSocial, Direccion=@Direccion, Provincia=@Provincia, Ciudad=@Ciudad, Clase=@Clase, Poliza=@Poliza, cf1=@cf1, cf2=@cf2, cf3=@cf3, telf1=@telf1, telf2=@telf2, telf3=@telf3, cel1=@cel1, cel2=@cel2, cel3=@cel3, email1=@email1, email2=@email2, email3=@email3, cdl1=@cdl1, cdl2=@cdl2, tdl1=@tdl1, tdl2=@tdl2, ccdl1=@ccdl1, ccdl2=@ccdl2, edl1=@edl1, edl2=@edl2, cdc1=@cdc1, cdc2=@cdc2, tdc1=@tdc1, tdc2=@tdc2, ccdc1=@ccdc1, ccdc2=@ccdc2, edc1=@edc1, edc2=@edc2, EjecutivoApertura=@EjecutivoApertura, FechaEnvioListado=@FechaEnvioListado, FechaEmision=@FechaEmision, TipoListado=@TipoListado, EmitenFactura=@EmitenFactura, PorcenComision=@PorcenComision, FechaLlamada=@FechaLlamada WHERE NombreComercial=@NombreComercial ";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Ruc", SqlDbType.VarChar).Value = Correo.Value;
                    querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Text1.Value;
                    querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Text7.Value;
                    querySaveStaff.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = Text5.Value;                    
                    querySaveStaff.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = Text6.Value;
                    querySaveStaff.Parameters.Add("@Clase", SqlDbType.Int).Value = Int32.Parse(Text35.Value);
                    querySaveStaff.Parameters.Add("@Poliza", SqlDbType.Int).Value = Int32.Parse(Text34.Value);
                    querySaveStaff.Parameters.Add("@cf1", SqlDbType.VarChar).Value = Text3.Value;
                    querySaveStaff.Parameters.Add("@cf2", SqlDbType.VarChar).Value = Text9.Value;
                    querySaveStaff.Parameters.Add("@cf3", SqlDbType.VarChar).Value = Text12.Value;
                    querySaveStaff.Parameters.Add("@telf1", SqlDbType.VarChar).Value = Text4.Value;
                    querySaveStaff.Parameters.Add("@telf2", SqlDbType.VarChar).Value = Text10.Value;
                    querySaveStaff.Parameters.Add("@telf3", SqlDbType.VarChar).Value = Text14.Value;
                    querySaveStaff.Parameters.Add("@cel1", SqlDbType.VarChar).Value = Text8.Value;
                    querySaveStaff.Parameters.Add("@cel2", SqlDbType.VarChar).Value = Text11.Value;
                    querySaveStaff.Parameters.Add("@cel3", SqlDbType.VarChar).Value = Text15.Value;
                    querySaveStaff.Parameters.Add("@email1", SqlDbType.VarChar).Value = Text17.Value;
                    querySaveStaff.Parameters.Add("@email2", SqlDbType.VarChar).Value = Text12.Value;
                    querySaveStaff.Parameters.Add("@email3", SqlDbType.VarChar).Value = Text16.Value;
                    querySaveStaff.Parameters.Add("@cdl1", SqlDbType.VarChar).Value = Text18.Value;
                    querySaveStaff.Parameters.Add("@cdl2", SqlDbType.VarChar).Value = Text19.Value;
                    querySaveStaff.Parameters.Add("@tdl1", SqlDbType.VarChar).Value = Text20.Value;
                    querySaveStaff.Parameters.Add("@tdl2", SqlDbType.VarChar).Value = Text21.Value;
                    querySaveStaff.Parameters.Add("@ccdl1", SqlDbType.VarChar).Value = Text22.Value;
                    querySaveStaff.Parameters.Add("@ccdl2", SqlDbType.VarChar).Value = Text23.Value;
                    querySaveStaff.Parameters.Add("@edl1", SqlDbType.VarChar).Value = Text24.Value;
                    querySaveStaff.Parameters.Add("@edl2", SqlDbType.VarChar).Value = Text25.Value;

                    querySaveStaff.Parameters.Add("@cdc1", SqlDbType.VarChar).Value = Text18.Value;
                    querySaveStaff.Parameters.Add("@cdc2", SqlDbType.VarChar).Value = Text19.Value;
                    querySaveStaff.Parameters.Add("@tdc1", SqlDbType.VarChar).Value = Text20.Value;
                    querySaveStaff.Parameters.Add("@tdc2", SqlDbType.VarChar).Value = Text21.Value;
                    querySaveStaff.Parameters.Add("@ccdc1", SqlDbType.VarChar).Value = Text22.Value;
                    querySaveStaff.Parameters.Add("@ccdc2", SqlDbType.VarChar).Value = Text23.Value;
                    querySaveStaff.Parameters.Add("@edc1", SqlDbType.VarChar).Value = Text24.Value;
                    querySaveStaff.Parameters.Add("@edc2", SqlDbType.VarChar).Value = Text25.Value;

                    querySaveStaff.Parameters.Add("@EjecutivoApertura", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                    querySaveStaff.Parameters.Add("@FechaEmision", SqlDbType.VarChar).Value = Text38.Value;
                    querySaveStaff.Parameters.Add("@FechaEnvioListado", SqlDbType.VarChar).Value = Text39.Value;
                    querySaveStaff.Parameters.Add("@TipoListado", SqlDbType.VarChar).Value = Text40.Value;

                    querySaveStaff.Parameters.Add("@EmitenFactura", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                    querySaveStaff.Parameters.Add("@PorcenComision", SqlDbType.VarChar).Value = Text43.Value;
                    querySaveStaff.Parameters.Add("@FechaLlamada", SqlDbType.VarChar).Value = Text44.Value;

                    querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empdetalleC"].Value;
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

                string saveStaff = "INSERT INTO Pagos (Ruc, RazonSocial, Mes) VALUES (@Ruc, @RazonSocial, @Mes)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Ruc", SqlDbType.VarChar).Value = Correo.Value;
                    querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["empdetalleC"].Value;
                    querySaveStaff.Parameters.Add("@Mes", SqlDbType.DateTime).Value = DateTime.Now;                    
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('EMPRESA REGISTRADA')</script>");
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
}