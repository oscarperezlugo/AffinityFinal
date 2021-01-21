<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RetenFin.aspx.cs" Inherits="ReachSystem.RetenFin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="RETENCIONES" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">  
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" >
                        <Columns>                            
                            <asp:BoundField DataField="Cedula" HeaderText="Cedula" SortExpression="Cedula"></asp:BoundField>    
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="Numero de Certificado" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="Tomador" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="NombreComercial" HeaderText="Empresa" SortExpression="NombreComercial"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT  [Nombre], [NumeroCertificado], [Cedula], [NombreComercial] FROM [Asegurados] WHERE ([NumeroCertificado] = @NumeroCertificado)">
                        <SelectParameters>                                                        
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <hr />
                    <table style="width: 100%;">                        
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="SELECCIONE LA ACCION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc2">
                                    <asp:ListItem>ACCION</asp:ListItem>
                                    <asp:ListItem>SOLICITADO</asp:ListItem>
                                    <asp:ListItem>RETENIDO</asp:ListItem>
                                    <asp:ListItem>REEMPLAZADO</asp:ListItem>
                                    <asp:ListItem>EXCLUIDO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td><asp:Label ID="Label1" runat="server"  Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                            </td>                                                     
                        </tr>
                                                           
                    </table>
                    <hr />
                                            
                    <CENTER><asp:Button runat="server" CssClass="botonsubmitTRES" text="CANCELAR" OnClick="Unnamed_Click1"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click"/>                                                  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="FINALIZAR" OnClick="Unnamed1_Click"/>                                                  
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
