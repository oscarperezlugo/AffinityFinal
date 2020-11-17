<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaTotal.aspx.cs" Inherits="ReachSystem.ListaTotal" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="INCLUSIÓN: TOTALIZAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label2" runat="server" Text="ADICION: TOTALIZAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>               
                        <asp:Label ID="Label3" runat="server" Text="REEMPLAZO: TOTALIZAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <asp:Label ID="Label5" runat="server" Text="NOMBRE TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioblock" placeholder="Nombre Tomador" id="Text4" type="text" runat="server"   disabled/>
                    <hr />
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"  GridLines="None" AllowPaging="True" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

        <Columns>            
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Producto" HeaderText="Cobertura" SortExpression="Producto" />
            <asp:BoundField DataField="PlanSelect" HeaderText="Plan" SortExpression="PlanSelect" />
            <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ELIMINAR"></asp:CommandField>
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

                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Nombre], [Producto], [PlanSelect], [Valor] FROM [VentaTemp] WHERE (([Ejecutivo] = @Ejecutivo) AND ([FechaVenta] = @FechaVenta) AND ([CedulaTomador] = @CedulaTomador))">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="nombreC" Name="Ejecutivo" Type="String"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="fechaC" Name="FechaVenta" Type="DateTime"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCedula" Name="CedulaTomador" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            
                            <td><asp:Label ID="Label1" runat="server" Text="TOTAL A PAGAR $:" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="prefifin" runat="server" CssClass="formularioFin" ></asp:Label></td>
                        </tr>                        
                    </table>
                    
                    <hr /> 
                    <CENTER><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CONFIRMAR" OnClick="Unnamed_Click"/>                                                  
                    </CENTER>
                    <hr />                                            
                    <CENTER><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click2" UseSubmitBehavior="False" />  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="ATRAS" OnClick="Unnamed_Click3" UseSubmitBehavior="False" />                                             
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
