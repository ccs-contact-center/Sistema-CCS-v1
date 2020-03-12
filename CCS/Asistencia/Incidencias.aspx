<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Incidencias.aspx.vb" Inherits="CCS.Incidencias" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script id="grid" type="text/javascript">

        function On(GridView) {
            if (GridView != null) {
                GridView.originalBgColor = GridView.style.backgroundColor;
                GridView.style.backgroundColor = "#C00327";

            }
        }

        function Off(GridView) {
            if (GridView != null) {
                GridView.style.backgroundColor = GridView.originalBgColor;
            }
        }

    </script>

    <style type="text/css">
        .auto-style6 {
            left: 0;
            top: 5px;
            width: 302px;
            height: 20px;
            text-align: center;
        }

        .auto-style7 {
            height: 37px;
        }

        .auto-style8 {
            font-size: x-small;
        }

        .auto-style10 {
            height: 30px;
            text-align: center;
        }

        .auto-style11 {
            height: 36px;
        }

        .auto-style15 {
            border-style: none;
            background-color: #545454;
            color: white;
            border-radius: 7px;
            -moz-border-radius: 7px;
            -webkit-border: 7px;
            margin-left: 440px;
        }

        .auto-style16 {
            text-align: right;
            width: 440px;
            font: normal 17px 'Yanone Kaffeesatz';
        }

        .auto-style17 {
            text-align: center;
        }

        .auto-style18 {
            height: 37px;
            text-align: right;
        }

        .auto-style19 {
            height: 36px;
            text-align: right;
        }


        .auto-style2 {
            text-align: center;
            margin-left: 23px;
            overflow: auto;
            width: 95%;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ToolkitScriptManager runat="server"></asp:ToolkitScriptManager>



    <div id="site_content">
        <div class="content">

            <h1>Registro de Incidencias</h1>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel2" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Buscador"></asp:Label></h2>
                        <div class="auto-style2">
                            <br />

                            <table style="width: 100%;" class="Buscador">

                                <tr>
                                    <td class="auto-style18">ID Mitrol:</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" CssClass="textos"> </asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ValidationGroup="Requeridos" CssClass="auto-style8"></asp:RequiredFieldValidator>
                                    </td>
                                    <td class="auto-style18">Fecha:</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" CssClass="textos"></asp:TextBox>
                                        <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" Enabled="True" PopupButtonID="ImageButton1" TargetControlID="TextBox2" Format="dd/MM/yyyy">
                                        </asp:CalendarExtender>
                                        <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageAlign="Middle" ImageUrl="~/Images/calendario.png" Width="23px" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" Style="font-size: xx-small" ValidationGroup="Requeridos"></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                            </table>

                            <table style="width: 100%;" class="Buscador">
                                <tr>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td colspan="6" class="auto-style10">
                                        <strong>
                                            <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="13px" Text="Buscar" ValidationGroup="Requeridos" Height="22px" Width="85px" CssClass="Button" />
                                        </strong>
                                    </td>
                                </tr>

                                <tr>
                                    <td colspan="6"></td>
                                </tr>

                            </table>

                            <asp:GridView ID="GridView2" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="880px" CssClass="grids">
                                <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:GridView>

                            <br />

                        </div>
                    </asp:Panel>


                    <asp:Panel ID="Panel3" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label2" runat="server" Text="Editar"></asp:Label></h2>
                        <div style="overflow: auto; width: 888px; margin-left: 4px; margin-right: 4px;">

                            <br />

                            <table style="width: 100%;" class="Buscador">

                                <tr>
                                    <td class="auto-style19">Nombre:</td>
                                    <td class="auto-style11">
                                        <asp:TextBox ID="TextBox4" runat="server" Enabled="False" Wrap="True" CssClass="textos" Width="300px"></asp:TextBox></td>
                                    <td class="auto-style19">Asistencia:</td>
                                    <td class="auto-style11">
                                        <asp:DropDownList ID="DropDownList1" runat="server" Width="50px" Enabled="False">
                                            <asp:ListItem Value="0">-</asp:ListItem>
                                            <asp:ListItem>A</asp:ListItem>
                                            <asp:ListItem>F</asp:ListItem>
                                            <asp:ListItem>FJ</asp:ListItem>
                                            <asp:ListItem>D</asp:ListItem>
                                            <asp:ListItem>I</asp:ListItem>
                                            <asp:ListItem>PC</asp:ListItem>
                                            <asp:ListItem>PS</asp:ListItem>
                                            <asp:ListItem>V</asp:ListItem>
                                            <asp:ListItem>PJ</asp:ListItem>
                                            <asp:ListItem>O</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="auto-style19">Horas Extra:</td>
                                    <td class="auto-style11">
                                        <asp:TextBox ID="TextBox3" runat="server" CssClass="textos" Enabled="False" Wrap="True" Width="50px"></asp:TextBox>
                                    </td>
                                    <td class="auto-style11"></td>
                                </tr>


                                <tr>

                                    <td class="auto-style6" colspan="6">Comentario:</td>
                                </tr>

                                <tr>
                                    <td colspan="6" class="auto-style17">
                                        <asp:TextBox ID="TextBox16" runat="server" Height="23px" TextMode="MultiLine" Width="800px" Enabled="False"></asp:TextBox>
                                        <br />
                                    </td>
                                </tr>


                                <tr>
                                    <td></td>
                                </tr>

                                <tr>
                                    <td colspan="3" class="auto-style17">
                                        <asp:Button ID="Button5" runat="server" Font-Bold="True" Font-Size="13px" Text="Guardar" ValidationGroup="Validar" CssClass="Button" Height="22px" Width="85px" />

                                    </td>
                                    <td colspan="3">
                                        <asp:CheckBox ID="CheckBox2" runat="server" Font-Size="Small" Text="Editar  " TextAlign="Left" AutoPostBack="True" Enabled="False" Font-Bold="True" />
                                    </td>
                                </tr>

                            </table>


                            <br />

                        </div>

                    </asp:Panel>


                    <br />


                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" Visible="False">
                        <ContentTemplate>

                            <table style="width: 100%;" class="TablaValidar">

                                <tr>
                                    <td class="auto-style16">Coordinador:</td>
                                    <td>
                                        <asp:TextBox ID="TextBox13" runat="server" Style="text-align: center" Height="15px" Width="130px" CssClass="textos"></asp:TextBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="auto-style16">Contraseña:</td>
                                    <td>
                                        <asp:TextBox ID="TextBox14" runat="server" Style="text-align: center" TextMode="Password" Height="15px" Width="130px" CssClass="textos"></asp:TextBox>
                                    </td>
                                </tr>

                            </table>

                            <br />
                            <asp:Button ID="Button1" runat="server" Height="20px" Text="Validar" Width="80px" ValidationGroup="Validacion" CssClass="auto-style15" />
                            <br />
                            <br />
                            <br />

                        </ContentTemplate>
                    </asp:UpdatePanel>


                </ContentTemplate>

            </asp:UpdatePanel>


        </div>
    </div>


</asp:Content>
