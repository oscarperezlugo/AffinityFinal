﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class ProcCert : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            string connectionString = "workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB";
            string query = "SELECT FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, MedioDeCobro, Cedula, TotalCobrar FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado AND Nombre=@Nombre;";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@NumeroCertificado", SqlDbType.Int, 50).Value = Int32.Parse(GridView1.Rows[i].Cells[0].Text);
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = GridView1.Rows[i].Cells[1].Text;


                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string fechanac = dr.GetFieldValue<System.DateTime>(0).ToString();
                        string genero = dr.GetFieldValue<string>(1);
                        string direccion = dr.GetFieldValue<string>(2);
                        string direccionemp = dr.GetFieldValue<string>(3);
                        string cargo = dr.GetFieldValue<string>(4);
                        string codigo = dr.GetFieldValue<string>(5);
                        string telfcelular = dr.GetFieldValue<string>(6);
                        string telempre = dr.GetFieldValue<string>(7);
                        string email = dr.GetFieldValue<string>(8);
                        string empresa = dr.GetFieldValue<string>(9);
                        string medio = dr.GetFieldValue<string>(10);
                        int cedula = dr.GetFieldValue<int>(11);
                        decimal total = dr.GetFieldValue<decimal>(12);

                        HttpCookie nombreS = new HttpCookie("fechanacadC");
                        nombreS.Value = fechanac;
                        nombreS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(nombreS);

                        HttpCookie idclienteS = new HttpCookie("generoadcC");
                        idclienteS.Value = genero;
                        idclienteS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(idclienteS);

                        HttpCookie perfilS = new HttpCookie("direccionadC");
                        perfilS.Value = direccion;
                        perfilS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfilS);

                        HttpCookie nombre1S = new HttpCookie("direccionemadC");
                        nombre1S.Value = direccionemp;
                        nombre1S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(nombre1S);

                        HttpCookie idcliente1S = new HttpCookie("cargoadC");
                        idcliente1S.Value = cargo;
                        idcliente1S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(idcliente1S);

                        HttpCookie perfil1S = new HttpCookie("codigoadC");
                        perfil1S.Value = codigo;
                        perfil1S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfil1S);

                        HttpCookie nombre2S = new HttpCookie("telceladC");
                        nombre2S.Value = telfcelular;
                        nombre2S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(nombre2S);

                        HttpCookie idcliente2S = new HttpCookie("telempreadC");
                        idcliente2S.Value = telempre;
                        idcliente2S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(idcliente2S);

                        HttpCookie perfil2S = new HttpCookie("emailadC");
                        perfil2S.Value = email;
                        perfil2S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfil2S);

                        HttpCookie idcliente3S = new HttpCookie("empresaadC");
                        idcliente3S.Value = empresa;
                        idcliente3S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(idcliente3S);

                        HttpCookie perfil3S = new HttpCookie("medioadC");
                        perfil3S.Value = medio;
                        perfil3S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfil3S);

                        HttpCookie claseS = new HttpCookie("paramCedula");
                        claseS.Value = cedula.ToString();
                        claseS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(claseS);

                        HttpCookie clase7S = new HttpCookie("paramTotalCert");
                        clase7S.Value = total.ToString();
                        clase7S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(clase7S);

                    }
                    else
                    {                        

                    }

                    dr.Close();
                }

                con.Close();
            }
            HttpCookie codigoS = new HttpCookie("paramCert");
            codigoS.Value = GridView1.Rows[i].Cells[0].Text;
            codigoS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigoS);                    

            HttpCookie nombretomS = new HttpCookie("nombretomC");
            nombretomS.Value = GridView1.Rows[i].Cells[1].Text;
            nombretomS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombretomS);

            DateTime FECHA = DateTime.Now;
            HttpCookie fechaS = new HttpCookie("fechaC");
            fechaS.Value = FECHA.ToString();
            fechaS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fechaS);

            HttpCookie indexS = new HttpCookie("indexC");
            indexS.Value = "9";
            indexS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS);

            HttpCookie index2S = new HttpCookie("ejecprocC");
            index2S.Value = GridView1.Rows[i].Cells[2].Text; ;
            index2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S);

            Response.Redirect("InclusionTomador.aspx");

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = null;
            SqlDataSource1.DataBind();
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramCedula");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            DateTime FECHA = DateTime.Now;
            HttpCookie fechaS = new HttpCookie("fechaC");
            fechaS.Value = FECHA.ToString();
            fechaS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fechaS);
            Response.Redirect("ProcCert.aspx");

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