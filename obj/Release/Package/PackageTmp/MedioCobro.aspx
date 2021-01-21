<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MedioCobro.aspx.cs" Inherits="ReachSystem.MedioCobro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="CERTIFICADOS: MEDIO DE COBRO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                                               
                    <table style="width: 100%;">                        
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="SELECCIONE UNA OPCION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc2">
                                    <asp:ListItem>MEDIO DE COBRO</asp:ListItem>
                                    <asp:ListItem>TARJETA DE CREDITOS</asp:ListItem>
                                    <asp:ListItem>ROL DE PAGOS</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td><asp:Label ID="Label5" runat="server" Text="BANCO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="BANCO" id="Text1" type="text" runat="server"/><br />
                            </td>
                            <td><asp:Label ID="Label15" runat="server" Text="TIPO DE CUENTA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProcDOS" name="asegurado" id="Radio1" type="radio" runat="server"  /><label>AHORROS </label>
                                <input class="formularioProcDOS" name="asegurado" id="Radio2" type="radio" runat="server"  /><label>CORRIENTE </label></td>                            
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label7" runat="server" Text="CUENTA NUMERO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="CUENTA NUMERO" id="Text4" type="text" runat="server"/><br />

                            </td>
                            <td>&nbsp;</td>                            
                        </tr>
                         <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label1" runat="server" Text="SELECCIONE UNA OPCION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formularioProc2">
                                    <asp:ListItem>SELECCIONE LA TARJETA</asp:ListItem>
                                    <asp:ListItem>VISA</asp:ListItem>
                                    <asp:ListItem>MASTER CARD</asp:ListItem>
                                    <asp:ListItem>AMERICAN EXPRESS</asp:ListItem>
                                </asp:DropDownList>
                            <td><asp:Label ID="Label2" runat="server" Text="NUMERO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="NUMERO" id="Text8" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label3" runat="server" Text="VENCIMIENTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="VENCIMIENTO" id="Text10" type="text" runat="server"/><br /></td>
                            <td><asp:Label ID="Label8" runat="server" Text="CODIGO DE SEGURIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="CODIGO DE SEGURIDAD" id="Text11" type="text" runat="server"/><br /></td>                            
                        </tr>   
                        <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label9" runat="server" Text="PRIMA TOTAL$" Style="font-weight: bold; font-size: 18px;"></asp:Label><br /></td>
                            <td><asp:Label ID="prefifin" runat="server" CssClass="formularioFin" ></asp:Label></td>
                        </tr> 
                    </table>
                    <hr />
                                            
                    <CENTER><asp:Button runat="server" CssClass="botonsubmitTRES" text="CANCELAR" OnClick="Unnamed_Click1"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click"/>                                                  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="SIGUIENTE" OnClick="Unnamed1_Click"/>                                                  
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
