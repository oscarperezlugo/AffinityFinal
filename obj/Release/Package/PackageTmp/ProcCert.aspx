<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProcCert.aspx.cs" Inherits="ReachSystem.ProcCert" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="CERTIFICADOS: PROCESAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
    <center><input class="formulario" placeholder="Cedula" id="Correo" type="text" runat="server"  AutoPostBack="true"/>
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BASE INTERNA"  OnClick="Unnamed1_Click"/></center>    
                    
                    <hr />
                    <asp:Label ID="Label1" runat="server" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="Numero de Certificado" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="Tomador" SortExpression="Nombres Completos"></asp:BoundField>
                            <asp:BoundField DataField="Ejecutivo" HeaderText="Ejecutivo" SortExpression="Ejecutivo"></asp:BoundField>
                            <asp:BoundField DataField="Proceso" HeaderText="Estado" SortExpression="Proceso"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="PROCESAR"></asp:CommandField>
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="black" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
<PagerStyle CssClass="pgr"></PagerStyle>
                    </asp:GridView>
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Ejecutivo], [Nombre], [NumeroCertificado], [Proceso] FROM [Asegurados] WHERE ([Cedula] = @Cedula) OR ([NumeroCertificado] = @NumeroCertificado)">
                        <SelectParameters>                            
                            <asp:CookieParameter CookieName="paramCedula" Name="Cedula" Type="Int32"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCedula" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <hr />
                                            
                    <CENTER><asp:Button runat="server" CssClass="botonsubmitTRES" text="VOLVER" OnClick="Unnamed_Click1" UseSubmitBehavior="False"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />                                                  
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
