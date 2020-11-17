<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdLista.aspx.cs" Inherits="ReachSystem.ProdLista" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="PRDUCTOS WSM: LISTA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                    
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="Producto" HeaderText="Producto" SortExpression="Producto"></asp:BoundField>
                            <asp:BoundField DataField="PlanSelect" HeaderText="Plan" SortExpression="PlanSelect"></asp:BoundField>
                            <asp:BoundField DataField="Edadmin" HeaderText="Edad Minima" SortExpression="Edadmin"></asp:BoundField>
                            <asp:BoundField DataField="Edadmax" HeaderText="Edad Maxima" SortExpression="Edadmax"></asp:BoundField>
                            <asp:BoundField DataField="Edadren" HeaderText="Edad Maxima Renova" SortExpression="Edadren"></asp:BoundField>
                            <asp:BoundField DataField="Aplica" HeaderText="Aplica a" SortExpression="Aplica"></asp:BoundField>
                            <asp:BoundField DataField="Valor" HeaderText="Valor $" SortExpression="Valor"></asp:BoundField>
                            <asp:BoundField DataField="Cobertura" HeaderText="Cobertura $" SortExpression="Cobertura"></asp:BoundField>
                            <asp:BoundField DataField="Causa" HeaderText="Causa" SortExpression="Causa"></asp:BoundField>

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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Producto], [PlanSelect], [Edadmin], [Edadmax], [Edadren], [Aplica], [Valor], [Cobertura], [Causa] FROM [Productos]">
                    </asp:SqlDataSource>       
                    <hr />
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" ID="CANCEL" OnClick="CANCEL_Click" UseSubmitBehavior="False" />  
                    
                    </CENTER>                    
                    
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
