﻿<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdCreacion.aspx.cs" Inherits="ReachSystem.ProdCreacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="PRODUCTOS: CREACION" Style="font-weight: bold; font-size: 18px;"></asp:Label>   
                        <asp:Label ID="Label10" runat="server" Text="PRODUCTOS: EDICION" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                    
                      
                        <center><asp:Label ID="Label17" runat="server" Text="CREACION" Style="font-weight: bold; font-size: 24px;"></asp:Label></center><br />
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="PRODUCTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="PRODUCTO" id="Correo" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="PLAN" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList6" runat="server" CssClass="formularioProc"  AppendDataBoundItems="true" DataTextField="PlanSelect" DataValueField="PlanSelect">
                                    <asp:ListItem>PLAN</asp:ListItem>                                    
                                </asp:DropDownList>   
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="EDAD MINIMA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList7" runat="server" CssClass="formularioProc"  AppendDataBoundItems="true" DataTextField="Edadmin" DataValueField="Edadmin">
                                    <asp:ListItem>EDAD MINIMA</asp:ListItem>                                    
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="EDAD MAXIMA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                     <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc"  AppendDataBoundItems="true" DataTextField="Edadmax" DataValueField="Edadmax">
                                    <asp:ListItem>EDAD MAXIMA</asp:ListItem>                                    
                                </asp:DropDownList>                   
                            </td>                            
                        </tr>
                        
                        <tr>
                                             
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="EDAD MAXIMA RENOVA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formularioProc"   AppendDataBoundItems="true" DataTextField="Edadren" DataValueField="Edadren" >
                                <asp:ListItem>EDAD MAXIMA RENOVA</asp:ListItem>  
                                </asp:DropDownList>                               
                            </td>
                            <td>                                
                                <asp:Label ID="Label8" runat="server" Text="APLICA A" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formularioProc" DataTextField="Aplica" DataValueField="Aplica"  AppendDataBoundItems="true" >
                                <asp:ListItem Value="0">APLICA A</asp:ListItem> 
                                </asp:DropDownList>                                                                 
                            </td>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="VALOR $" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FORMATO (9,99)" id="Text1" type="text" runat="server" ValidationGroup="ValidateMe" required/>                             
                            </td>
                            <td><asp:Label ID="Label5" runat="server" Text="COBERTURA $" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FORMATO (90000,99)" id="Text2" type="text" runat="server" ValidationGroup="ValidateMe" required/>                             
                                  
                            </td> 
                            
                        </tr>  
                        
                    </table> 
                        
                    <hr />     
                    <CENTER><asp:Button  value="REGISTRARME" CausesValidation="false" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click3" UseSubmitBehavior="False" />
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="GUARDAR" OnClick="Unnamed_Click"/>                                                  
                    </CENTER>
                                       
                    
                </div>
            </div>
        </div>
        </div>    
</asp:Content>