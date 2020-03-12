<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Seleccionar_Guia.aspx.vb" Inherits="CCS.Seleccionar_Guia" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
        .auto-style2 {
            width: 930px;
        }
    .auto-style3 {
        width: 13px;
    }
    .auto-style4 {
        width: 200px;
    }
            </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <div id="site_content">
        <div class="content">

            <h1>Monitoreo</h1>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Selecciona Guia"></asp:Label></h2>

                        <div runat="server" id="Alta1">
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style3"></td>
                                    <td class="TablaDerecha">
                                        <asp:Label ID="Label2" runat="server" Text="Campaña:"></asp:Label></td>
                                    <td class="auto-style4">
                                        <asp:DropDownList ID="DropDownList1" runat="server" Width="180px" CssClass="textos" AutoPostBack="True"></asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                    <td class="TablaDerecha">
                                        <asp:Label ID="Label3" runat="server" Text="Nombre de la Guia:"></asp:Label></td>
                                    <td>
                                    <asp:DropDownList ID="DropDownList2" runat="server" Width="180px" CssClass="textos">
                                        <asp:ListItem Value="0">-Selecciona Campaña-</asp:ListItem>
                                        </asp:DropDownList>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList2" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1" Display="Dynamic" InitialValue="0"></asp:RequiredFieldValidator>
                                    </td>
                                    <td><asp:Label ID="Label4" runat="server" Text="Tipo de Monitoreo:"></asp:Label></td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList3" runat="server" Width="180px" CssClass="textos">
                                            <asp:ListItem Value="0">-Selecciona-</asp:ListItem>
                                            <asp:ListItem Value="1">Lado a Lado</asp:ListItem>
                                            <asp:ListItem Value="2">Historico</asp:ListItem>
                                            <asp:ListItem Value="3">En Linea</asp:ListItem>
                                            <asp:ListItem Value="4">Calibración</asp:ListItem>
                                            <asp:ListItem Value="5">Solicitud</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList3" Display="Dynamic" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </div>

       
                        <br />

                        <div class="textos">
                            <asp:Button ID="Button1" runat="server" Text="Ir" CssClass="Button" Height="25px" Width="80px" ValidationGroup="Valida1"  />
                        </div>

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

</asp:Content>
