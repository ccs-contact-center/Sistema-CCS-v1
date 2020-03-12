<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Agregar_Rubros.aspx.vb" Inherits="CCS.Agregar_Rubros" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 86%;
            margin-left: 120px;
            border-style: none;
            vertical-align: top;
        }

        td {
            vertical-align: top;
        }

        .auto-style3 {
         text-align: left;
         width: 69px;
     }
     .auto-style4 {
         text-align: left;
     }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <div id="site_content">
        <div class="content">

            <h1>Edicion de Guias</h1>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Agregar Rubros"></asp:Label></h2>
                        
                        
                        <div runat="server" id="Alta1">
                            <table class="auto-style2">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="Rubro:"></asp:Label></td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList1" runat="server" Width="180px" CssClass="textos"></asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text="Subrubro:"></asp:Label></td>
                                    <td>
                                         <asp:DropDownList ID="DropDownList2" runat="server" Width="180px" CssClass="textos">
                                             <asp:ListItem>-Selecciona-</asp:ListItem>
                                         </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList2" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1" Display="Dynamic" InitialValue="0"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </div>

                        <div runat="server" id="Div1">
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label4" runat="server" Text="Adicional:"></asp:Label></td>
                                    <td class="auto-style4">
                                        <asp:DropDownList ID="DropDownList3" runat="server" Width="180px" CssClass="textos"></asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList3" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida2" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                         &nbsp;</td>
                                </tr>
                            </table>
                        </div>

                        <br />

                        <div class="textos">
                            <asp:Button ID="Button1" runat="server" Text="Agrega Subrubro" CssClass="Button" Style="margin-right: 100px;" Height="30px" Width="150px" ValidationGroup="Valida1" />
                            <asp:Button ID="Button2" runat="server" Text="Agrega Adicional" CssClass="Button" Height="30px" Width="150px" ValidationGroup="Valida2"   Style="margin-right: 100px;" />
                            <asp:Button ID="Button3" runat="server" Text="Guardar" CssClass="Button" Height="30px" Width="150px"  />
                        </div>

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

</asp:Content>
