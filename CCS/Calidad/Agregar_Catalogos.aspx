<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Agregar_Catalogos.aspx.vb" Inherits="CCS.Agregar_Catalogos" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 86%;
            margin-left: 320px;
            border-style: none;
            vertical-align: top;
        }

        td {
            vertical-align: top;
        }

        .auto-style3 {
            text-align: left;
            width: 74px;
        }

        .auto-style4 {
            text-align: left;
            width: 196px;
        }

        .auto-style5 {
            width: 74px;
        }

        .auto-style6 {
            width: 196px;
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
                            <asp:Label ID="Label1" runat="server" Text="Agregar a Catálogos"></asp:Label></h2>


                        <div runat="server" id="Alta1">
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style5">
                                        <asp:Label ID="Label2" runat="server" Text="Rubro:"></asp:Label></td>
                                    <td class="auto-style6">
                                        <asp:TextBox ID="TextBox1" runat="server" Width="180px" CssClass="textos"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:Button ID="Button1" runat="server" CssClass="Button" Height="25px" Text="Agregar" Width="80px" ValidationGroup="Valida1" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>

                        <div runat="server" id="Div1">
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label4" runat="server" Text="Subrubro:"></asp:Label></td>
                                    <td class="auto-style4">
                                        <asp:TextBox ID="TextBox2" runat="server" Width="180px" CssClass="textos"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida2" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:Button ID="Button2" runat="server" CssClass="Button" Height="25px" Text="Agregar" Width="80px" ValidationGroup="Valida2" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>

                        <table class="auto-style2">
                            <tr>
                                <td class="auto-style5">
                                    <asp:Label ID="Label5" runat="server" Text="Adicional:"></asp:Label></td>
                                <td class="auto-style6">
                                    <asp:TextBox ID="TextBox3" runat="server" Width="180px" CssClass="textos"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida3" Display="Dynamic"></asp:RequiredFieldValidator>
                                </td>
                                <td>
                                    <asp:Button ID="Button3" runat="server" CssClass="Button" Height="25px" Text="Agregar" Width="80px" ValidationGroup="Valida3" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </div>

                        <br />

                        <div class="textos">
                        </div>

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

</asp:Content>
