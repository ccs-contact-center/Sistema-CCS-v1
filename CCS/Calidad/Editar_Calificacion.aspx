<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Editar_Calificacion.aspx.vb" Inherits="CCS.Editar_Calificacion" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script id="grid" type="text/javascript">


        function On(GridView) {
            if (GridView != null) {
                GridView.originalBgColor = GridView.style.backgroundColor;
                GridView.style.backgroundColor = "#C00327";
                GridView.style.Color = "#FFFFFF";

            }
        }

        function Off(GridView) {
            if (GridView != null) {
                GridView.style.backgroundColor = GridView.originalBgColor;
            }
        }

    </script>

    <script src="../JS/funcionesReproductor.js.js"></script>

    <style type="text/css">
        .Grid {
            text-align: center;
            margin-left: 23px;
            overflow: auto;
            width: 95%;
        }

        .auto-style2 {
            text-align: center;
        }

        .auto-style3 {
            width: 14px;
        }

        .auto-style4 {
            width: 222px;
        }

        .auto-style5 {
            text-align: left;
        }

        .auto-style6 {
            width: 99px;
        }

        .auto-style8 {
            width: 142px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <div id="site_content">
        <div class="content">

            <h1>Editar Calificación</h1>

            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel6" runat="server" CssClass="Panel">
                        <h2>Buscador</h2>
                        <div class="TablaCentro">
                            <table style="width: 100%;">
                                <tr>
                                    <td></td>
                                    <td class="auto-style6"></td>
                                    <td class="TablaDerecha">ID Grabación:</td>
                                    <td class="auto-style5">
                                        <asp:TextBox ID="TextBox4" runat="server" Width="150px" CssClass="textos"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Buscar"></asp:RequiredFieldValidator>
                                    </td>
                                    <td class="TablaDerecha">ID ACD:</td>
                                    <td class="auto-style5">
                                        <asp:TextBox ID="TextBox7" runat="server" Width="80px" CssClass="textos"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox7" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Buscar"></asp:RequiredFieldValidator>
                                    </td>
                                    <td class="auto-style8"></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td colspan="8">
                                        <asp:Button ID="Button1" runat="server" Text="Buscar" CssClass="Button" Height="25px" Width="85px" ValidationGroup="Buscar" /></td>
                                </tr>
                            </table>

                            <div runat="server" id="Div2" class="Grid" style="width: 900px;">
                                <asp:GridView ID="GridView1" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="880px" CssClass="grids">
                                    <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                    <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:GridView>
                            </div>


                        </div>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            </asp:UpdatePanel>
        </div>
    </div>

    <script>cargarReproductor();</script>
</asp:Content>
