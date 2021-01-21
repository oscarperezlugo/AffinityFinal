<%@ Page Title="AFFINITY" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReachSystem._Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="DASHBOARD" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <asp:Label ID="Label8" runat="server" Text="GRAFICAS GENERALES" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="GRAFICA: RELACION/CANTIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="GRAFICA: COBERTURA/CANTIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="GRAFICA: GENERO/CANTIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Relacion" YValueMembers="TotalQuantity"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Relacion, COUNT(Relacion) AS TotalQuantity FROM Dependientes GROUP BY Relacion order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource2">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Producto" YValueMembers="TotalQuantity" ChartType="Bar" Palette="SeaGreen"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Producto, COUNT(Producto) AS TotalQuantity FROM Dependientes GROUP BY Producto order by TotalQuantity ASC"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Chart ID="Chart3" runat="server" DataSourceID="SqlDataSource3">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Genero" YValueMembers="TotalQuantity" ChartType="Doughnut" Palette="Berry"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Genero, COUNT(Genero) AS TotalQuantity FROM Dependientes GROUP BY Genero order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="GRAFICA: EJECUTIVO/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="GRAFICA: COBERTURA/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="GRAFICA: RELACION/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Chart ID="Chart4" runat="server" DataSourceID="SqlDataSource4">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Ejecutivo" YValueMembers="TotalQuantity" ChartType="Bar" Palette="Fire"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, SUM(TotalCobrar) AS TotalQuantity FROM Asegurados GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Chart ID="Chart5" runat="server" DataSourceID="SqlDataSource5">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Producto" YValueMembers="TotalQuantity" ChartType="Bar" Palette="Bright"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource5" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Producto, SUM(TotalPrima) AS TotalQuantity FROM Dependientes GROUP BY Producto order by TotalQuantity ASC"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Chart ID="Chart6" runat="server" DataSourceID="SqlDataSource6">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Relacion" YValueMembers="TotalQuantity" ChartType="Bar" Palette="Berry"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource6" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Relacion, SUM(TotalPrima) AS TotalQuantity FROM Dependientes GROUP BY Relacion order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                        </tr>                        
                    </table>
                    <hr />
                    <asp:Label ID="Label9" runat="server" Text="VENTAS MES EN CURSO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="GRAFICA: EJECUTIVO/CANTIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="GRAFICA: EJECUTIVO/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Chart ID="Chart7" runat="server" DataSourceID="SqlDataSource7">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="EJECUTIVO" YValueMembers="TotalQuantity"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource7" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, COUNT(Nombre) AS TotalQuantity FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Chart ID="Chart8" runat="server" DataSourceID="SqlDataSource8">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Ejecutivo" YValueMembers="TotalQuantity" ChartType="Bar" Palette="SeaGreen"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource8" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, SUM(TotalCobrar) AS TotalQuantity FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>                           
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label13" runat="server" Text="GRAFICA: EJECUTIVO/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="GRAFICA: COBERTURA/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>                            
                        </tr>                                           
                    </table>
                     <hr />
                    <asp:Label ID="Label12" runat="server" text="VENTAS DETALLE" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource9" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" >
                        <Columns>                            
                            <asp:BoundField DataField="Ejecutivo" HeaderText="EJECUTIVO" SortExpression="Ejecutivo"></asp:BoundField>
                            <asp:BoundField DataField="TotalQuantity" HeaderText="INCLUSIONES" SortExpression="TotalQuantity"></asp:BoundField>
                            <asp:BoundField DataField="Total" HeaderText="Total $" SortExpression="TOTAL"></asp:BoundField>                            
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource9" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, COUNT(Nombre) AS TotalQuantity, SUM(TotalCobrar) AS Total FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY Ejecutivo order by TotalQuantity DESC">                       
                    </asp:SqlDataSource>
                     <hr />
                    <asp:Label ID="Label15" runat="server" text="COBRANZAS DETALLE" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <hr />
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource10" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" >
                        <Columns>                            
                            <asp:BoundField DataField="NombreComercial" HeaderText="ENTIDAD TOMADORA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="TotalQuantity" HeaderText="TOMADORES" SortExpression="TotalQuantity"></asp:BoundField>
                            <asp:BoundField DataField="Total" HeaderText="Total $" SortExpression="TOTAL"></asp:BoundField>                            
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource10" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT NombreComercial, COUNT(Nombre) AS TotalQuantity, SUM(TotalCobrar) AS Total FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY NombreComercial order by TotalQuantity DESC">                       
                    </asp:SqlDataSource>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
