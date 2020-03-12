<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Administracion.aspx.vb" Inherits="CCS.Administracion" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Src="~/Aspirante.ascx" TagPrefix="uc1" TagName="Aspirante" %>
<%@ Register Src="~/TroncoComun.ascx" TagPrefix="uc1" TagName="TroncoComun" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style9 {
            width: 223px;
        }

        .auto-style10 {
            width: 171px;
        }

        .auto-style11 {
            width: 193px;
        }

        .auto-style16 {
            width: 193px;
        }



        .auto-style17 {
            width: 170px;
        }



        .auto-style18 {
            width: 170px;
            text-align: left;
        }



        .auto-style19 {
            width: 171px;
            text-align: left;
        }



        .auto-style20 {
            height: 20px;
        }



        .auto-style22 {
            width: 171px;
            text-align: center;
        }



        .auto-style27 {
            text-align: center;
            width: 100%;
            height: 87px;
        }

        .auto-style31 {
            width: 214px;
            height: 22px;
        }

        .auto-style32 {
            height: 22px;
        }

        .auto-style33 {
            width: 215px;
            height: 28px;
        }

        .auto-style34 {
            width: 214px;
            height: 28px;
        }

        .auto-style35 {
            height: 28px;
        }

        .auto-style36 {
            left: 0;
            top: 5px;
            width: 274px;
            height: 28px;
        }

        .auto-style37 {
            width: 215px;
            height: 30px;
        }

        .auto-style38 {
            width: 222px;
            height: 30px;
        }

        .auto-style39 {
            height: 30px;
        }

        .auto-style40 {
            left: 0;
            top: 5px;
            width: 302px;
            height: 30px;
        }



        .auto-style41 {
            width: 214px;
            height: 30px;
        }

        .auto-style42 {
            vertical-align: middle;
            text-align: center;
            width: 100%;
        }

        .auto-style43 {
            left: 0;
            top: 5px;
            width: 287px;
            height: 30px;
        }



        .auto-style44 {
            text-align: center;
            width: 100%;
            height: 180px;
        }



        .auto-style45 {
            text-align: center;
        }






        .auto-style46 {
            text-align: right;
        }

        .auto-style47 {
            width: 274px;
        }






        .auto-style48 {
            text-align: left;
        }






        .auto-style49 {
            width: 170px;
            text-align: right;
        }






        .auto-style51 {
            width: 215px;
            height: 13px;
            text-align: left;
        }

        .auto-style52 {
            width: 214px;
            height: 13px;
            text-align: right;
        }

        .auto-style53 {
            height: 13px;
            text-align: left;
        }

        .auto-style58 {
            vertical-align: middle;
            text-align: center;
            width: 100%;
            height: 92px;
            margin-bottom: 0;
        }

        .auto-style59 {
            left: 0;
            top: 5px;
            width: 197px;
            height: 11px;
            text-align: right;
        }

        .auto-style60 {
            width: 215px;
            height: 11px;
            text-align: left;
        }

        .auto-style61 {
            width: 214px;
            height: 11px;
            text-align: right;
        }

        .auto-style62 {
            height: 11px;
            text-align: left;
        }

        .auto-style63 {
            left: 0;
            top: 5px;
            width: 197px;
            height: 12px;
            text-align: right;
        }

        .auto-style64 {
            width: 215px;
            height: 12px;
            text-align: left;
        }

        .auto-style65 {
            width: 214px;
            height: 12px;
            text-align: right;
        }

        .auto-style66 {
            height: 12px;
            text-align: left;
        }






        .auto-style67 {
            left: 0;
            top: 5px;
            width: 197px;
            height: 13px;
            text-align: right;
        }

        .auto-style70 {
            width: 34px;
        }

        .auto-style72 {
            width: 168px;
        }

        .auto-style73 {
            width: 152px;
            text-align: right;
        }

        .auto-style74 {
            text-align: right;
            width: 129px;
        }

        .auto-style79 {
            width: 288px;
        }

        .auto-style80 {
            height: 30px;
            width: 206px;
        }

        .auto-style81 {
            width: 194px;
        }

        .auto-style82 {
            text-align: right;
            width: 115px;
        }

        .auto-style83 {
            width: 223px;
            text-align: right;
        }

        .auto-style84 {
            text-align: right;
            width: 99px;
        }
    </style>

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

    <script type="text/javascript">
        $(window).bind("load", function () {
            var footer = $("#footer");
            var pos = footer.position();
            var height = $(window).height();
            height = height - pos.top;
            height = height - footer.height();
            if (height > 0) {
                footer.css({
                    'margin-top': height + 'px'
                });
            }
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="site_content">
        <div class="content">

            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

            <h1>Administración</h1>

            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>


                    <asp:Panel ID="Panel2" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Aspirantes"></asp:Label></h2>

                        <br />


                        <div style="overflow: auto; width: 888px; margin-left: 25px;">
                            <asp:GridView ID="GridView1" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="880px" CssClass="grids">
                                <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:GridView>
                            <br />
                        </div>

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label2" runat="server" Text="Baja y Entrega de Aspirantes"></asp:Label></h2>

                        <br />

                        <table style="width: 100%;" class="Buscador">

                            <tr>
                                <td class="auto-style74">Nombres:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox1" runat="server" Wrap="True" CssClass="textos" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                <td class="auto-style73">Apellido Paterno:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="textos" Wrap="True" Width="150px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                <td class="auto-style72">Apellido Materno:</td>
                                <td class="auto-style79">
                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="textos" Wrap="True" Width="150px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox3" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                            </tr>

                            <tr>
                                <td class="auto-style74">Campaña:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="150px" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="DropDownList1" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style73">Tronco Comun:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="textos" Width="117px" Wrap="True"></asp:TextBox>
                                    <asp:CalendarExtender ID="TextBox4_CalendarExtender" runat="server" Enabled="True" PopupButtonID="ImageButton1" TargetControlID="TextBox4" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageAlign="Middle" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="TextBox4" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style72">Fecha Inicio:</td>
                                <td class="auto-style79">
                                    <asp:TextBox ID="TextBox5" runat="server" CssClass="textos" Width="117px" Wrap="True"></asp:TextBox>
                                    <asp:CalendarExtender ID="TextBox5_CalendarExtender" runat="server" Enabled="True" PopupButtonID="Imagebutton2" TargetControlID="TextBox5" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton2" runat="server" Height="23px" ImageAlign="Middle" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="TextBox5" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style74">Grupo:</td>
                                <td class="auto-style18">


                                    <asp:TextBox ID="TextBox45" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="TextBox45" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style73">ID ACD:</td>
                                <td class="auto-style19">
                                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" Enabled="True" PopupButtonID="ImageButton1" TargetControlID="TextBox4" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>
                                    <asp:TextBox ID="TextBox9" runat="server" CssClass="textos" Width="140px" Enabled="False" onpaste="return false" onkeypress="return solonumeros(event)"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="TextBox9" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style72">Evaluación Final:</td>
                                <td class="auto-style79">
                                    <asp:TextBox ID="TextBox10" runat="server" CssClass="textos" Width="150px" Wrap="True" Enabled="False"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="TextBox10" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                    <asp:CalendarExtender ID="CalendarExtender2" runat="server" Enabled="True" PopupButtonID="Imagebutton2" TargetControlID="TextBox5" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>
                                </td>
                            </tr>
<script>
    function solonumeros(e) {
    var key, numeros, teclado, especiales, teclado_especial, i;
    key = event.keyCode || event.which;
                teclado = String.fromCharCode(key);
                numeros = '0123456789';
        especiales = [8, 9, 37, 38, 39, 40, 46];
        shiif=[16, 17, 18]
     teclado_especial = false;

                for ( i in especiales ) {
                    if ( key == especiales[i] && !shiif ) {
                        teclado_especial = true;
                    }
                }
                if ( numeros.indexOf(teclado) == -1 && !teclado_especial ) {
                    return false;
                }
    }
</script>
                        </table>


                        <table class="auto-style44">

                            <tr>
                                <td class="auto-style40">Supervisor:</td>
                                <td class="auto-style37">
                                    <asp:TextBox ID="TextBox56" CssClass="Textos " runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator83" runat="server" ErrorMessage="*" ControlToValidate="TextBox6" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style38">Tutor:</td>
                                <td class="auto-style80">
                                    <asp:TextBox ID="TextBox70" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator84" runat="server" ErrorMessage="*" ControlToValidate="TextBox7" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style40">Telefono Casa:</td>
                                <td class="auto-style37">
                                    <asp:TextBox ID="TextBox6" CssClass="Textos " runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="TextBox6" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style38">Telefono Móvil:</td>
                                <td class="auto-style80">
                                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*" ControlToValidate="TextBox7" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style40">Entrada Capacitación:</td>
                                <td class="auto-style37">
                                    <asp:DropDownList ID="DropDownList2" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" ControlToValidate="DropDownList2" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style38">Salida Capacitación:</td>
                                <td class="auto-style80">
                                    <asp:DropDownList ID="DropDownList4" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*" ControlToValidate="DropDownList4" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style40">Entrada Operaciones:</td>
                                <td class="auto-style37">
                                    <asp:DropDownList ID="DropDownList3" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="*" ControlToValidate="DropDownList3" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style38">Salida Operaciones:</td>
                                <td class="auto-style80">
                                    <asp:DropDownList ID="DropDownList5" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="*" ControlToValidate="DropDownList5" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                            </tr>


                            <tr>
                                <td colspan="4"></td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="DropDownList7" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                            </tr>


                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center; margin-right: 25px;" Text="Limpiar" CssClass="Button" Height="22px" Width="85px" />
                                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center" Text="Guardar" ValidationGroup="Valida1" CssClass="Button" Height="22px" Width="85px" />
                                </td>
                            </tr>


                        </table>



                    </asp:Panel>



                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>




                    <asp:Panel ID="Panel3" runat="server" CssClass="Panel">

                        <h2>
                            <asp:Label ID="Label3" runat="server" Text="Asignación de Supervisor"></asp:Label></h2>

                        <br />

                        <table style="width: 100%; margin-left: 20px;" class="Buscador">
                            <tr>
                                <td colspan="5" class="auto-style20"></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td class="auto-style45">Agentes Sin Asignar</td>
                                <td></td>
                                <td class="auto-style45">Supervisor:&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList8" runat="server" AutoPostBack="True" Width="300px">
                            </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="DropDownList8" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida2"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td rowspan="3">

                                    <div style="overflow: auto; width: 400px; height: 150px;">

                                        <asp:GridView ID="GridView2" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="400px" CssClass="grids">
                                            <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                            <RowStyle Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="false" />
                                        </asp:GridView>
                                    </div>
                                </td>
                                <td>
                                    <asp:ImageButton ID="ImageButton3" runat="server" Height="20px" ImageUrl="~/Images/Arrows-Right-Circular-icon.png" Width="20px" ValidationGroup="Valida2" />
                                </td>
                                <td rowspan="3">
                                    <div style="overflow: auto; width: 400px; height: 150px;">
                                        <asp:GridView ID="GridView3" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="400px" CssClass="grids">
                                            <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                            <RowStyle Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="false" />
                                        </asp:GridView>
                                    </div>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>&nbsp;</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>&nbsp;</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td colspan="5"></td>
                            </tr>
                        </table>

                        <br />

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>


            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>

                    <asp:Panel ID="Panel4" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label5" runat="server" Text="Altas Pendientes RH"></asp:Label></h2>

                        <br />
                        <div style="overflow: auto; width: 888px; margin-left: 30px;">
                            <asp:GridView ID="GridView4" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="880px" CssClass="grids">
                                <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:GridView>
                            <br />
                        </div>
                    </asp:Panel>
                    <br />

                </ContentTemplate>
            </asp:UpdatePanel>




            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                <ContentTemplate>





                    <asp:Panel ID="Panel5" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label4" runat="server" Text="Alta RH"></asp:Label></h2>

                        <br />

                        <table style="width: 100%;" class="Buscador">

                            <tr>
                                <td class="auto-style82">Nombres:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox8" runat="server" Wrap="True" CssClass="textos" Width="140px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ErrorMessage="*" ControlToValidate="TextBox8" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator></td>
                                <td class="auto-style81">Apellido Paterno:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox11" runat="server" CssClass="textos" Wrap="True" Width="150px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ErrorMessage="*" ControlToValidate="TextBox11" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator></td>
                                <td class="auto-style16">Apellido Materno:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox12" runat="server" CssClass="textos" Wrap="True" Width="140px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="*" ControlToValidate="TextBox12" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator></td>
                            </tr>

                            <tr>
                                <td class="auto-style82">Empleado:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox19" runat="server" CssClass="textos" Width="140px" Wrap="True"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="*" ControlToValidate="TextBox19" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style81">Supervisor:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox13" runat="server" CssClass="textos" Width="150px" Wrap="True" Enabled="False"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ErrorMessage="*" ControlToValidate="TextBox13" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">Campaña:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList17" runat="server" AutoPostBack="True" Width="140px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator42" runat="server" ControlToValidate="DropDownList17" InitialValue="0" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style82">CURP:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox20" runat="server" CssClass="textos" Width="140px" Wrap="True"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" ControlToValidate="TextBox20" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style81">RFC:</td>
                                <td class="auto-style19">
                                    <asp:TextBox ID="TextBox15" runat="server" CssClass="textos" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ControlToValidate="TextBox15" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">NSS:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox16" runat="server" CssClass="textos" Width="140px" Wrap="True"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="TextBox16" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style82">Sexo:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList14" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem Value="1">M</asp:ListItem>
                                        <asp:ListItem Value="2">F</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator36" runat="server" ControlToValidate="DropDownList14" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style81">Fecha de Nacimiento:</td>
                                <td class="auto-style19">
                                    <asp:TextBox ID="TextBox21" runat="server" CssClass="textos" Width="117px" Wrap="True"></asp:TextBox>
                                    <asp:CalendarExtender ID="TextBox21_CalendarExtender" runat="server" Enabled="True" PopupButtonID="ImageButton5" TargetControlID="TextBox21" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton5" runat="server" Height="23px" ImageAlign="Middle" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" ControlToValidate="TextBox21" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">Estado Civil:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList15" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem Value="1">Soltero</asp:ListItem>
                                        <asp:ListItem Value="2">Casado</asp:ListItem>
                                        <asp:ListItem Value="3">Viudo</asp:ListItem>
                                        <asp:ListItem Value="4">Divorciado</asp:ListItem>
                                        <asp:ListItem Value="5">Union Libre</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator37" runat="server" ControlToValidate="DropDownList15" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style82">Entrada:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList9" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="DropDownList9" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style81">Salida:</td>
                                <td class="auto-style22">

                                    <asp:DropDownList ID="DropDownList10" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="DropDownList10" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">Jornada:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox22" runat="server" Width="50px" CssClass="textos"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator38" runat="server" ControlToValidate="TextBox22" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style82">Alta:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox51" runat="server" CssClass="textos" Width="140px" Wrap="True" Enabled="False"></asp:TextBox>
                                </td>
                                <td class="auto-style81">Dep. Economicos:</td>
                                <td class="auto-style22">

                                    <asp:DropDownList ID="DropDownList21" runat="server" Width="120px">
                                        <asp:ListItem Value="0">-Selecciona-</asp:ListItem>
                                        <asp:ListItem Value="x">0</asp:ListItem>
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                        <asp:ListItem>8</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator48" runat="server" ControlToValidate="DropDownList21" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">Escolaridad:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList22" runat="server" Width="120px">
                                        <asp:ListItem Value="0">-Selecciona-</asp:ListItem>
                                        <asp:ListItem Value="Secundaria">Secundaria</asp:ListItem>
                                        <asp:ListItem Value="Bachillerato Trunco">Bachillerato Trunco</asp:ListItem>
                                        <asp:ListItem Value="Bachillerato">Bachillerato</asp:ListItem>
                                        <asp:ListItem Value="Licenciatura Trunca">Licenciatura Trunca</asp:ListItem>
                                        <asp:ListItem>Licenciatura</asp:ListItem>
                                        <asp:ListItem>Carrera Tecnica</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator51" runat="server" ControlToValidate="DropDownList22" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                        </table>


                        <table class="auto-style42">

                            <tr>
                                <td class="auto-style43">Telefono Casa:</td>
                                <td class="auto-style37">
                                    <asp:TextBox ID="TextBox17" CssClass="Textos " runat="server" Width="120px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ErrorMessage="*" ControlToValidate="TextBox17" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style41">Telefono Móvil:</td>
                                <td class="auto-style39">
                                    <asp:TextBox ID="TextBox18" runat="server" Width="120px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ErrorMessage="*" ControlToValidate="TextBox18" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style43">Calle y Número:</td>
                                <td class="auto-style37">
                                    <asp:TextBox ID="TextBox23" runat="server" CssClass="Textos "></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator39" runat="server" ControlToValidate="TextBox23" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style41">Estado:</td>
                                <td class="auto-style39">
                                    <asp:DropDownList ID="DropDownList16" runat="server" Width="150px" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator40" runat="server" ControlToValidate="DropDownList16" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style43">Delegacion/Municipio:</td>
                                <td class="auto-style37">
                                    <asp:DropDownList ID="DropDownList13" runat="server" Width="150px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ErrorMessage="*" ControlToValidate="DropDownList13" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style41">CP:</td>
                                <td class="auto-style39">
                                    <asp:TextBox ID="TextBox24" runat="server" Width="50px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator41" runat="server" ControlToValidate="TextBox24" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaRH"></asp:RequiredFieldValidator>
                                </td>
                            </tr>




                            <tr>
                                <td colspan="4"></td>
                            </tr>


                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="Button8" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center; margin-right: 25px;" Text="Limpiar" CssClass="Button" Height="22px" Width="85px" />
                                    <asp:Button ID="Button9" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center" Text="Guardar" ValidationGroup="ValidaRH" CssClass="Button" Height="22px" Width="85px" />
                                </td>
                            </tr>


                        </table>



                    </asp:Panel>




                </ContentTemplate>
            </asp:UpdatePanel>


            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                <ContentTemplate>

                    <asp:Panel ID="Panel6" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label6" runat="server" Text="Baja Operaciones"></asp:Label></h2>

                        <br />

                        <table style="width: 100%; margin-left: 15px;" class="Buscador">
                            <tr>
                                <td colspan="5" class="auto-style20"></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td class="auto-style45">Agentes Activos:</td>
                                <td></td>
                                <td class="auto-style45">Pendientes de Baja:&nbsp;&nbsp;
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td rowspan="3">

                                    <div style="overflow: auto; width: 400px; height: 150px;">

                                        <asp:GridView ID="GridView5" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="400px" CssClass="grids">
                                            <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                            <RowStyle Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="false" />
                                        </asp:GridView>
                                    </div>
                                </td>
                                <td>
                                    <asp:ImageButton ID="ImageButton6" runat="server" Height="20px" ImageUrl="~/Images/Arrows-Right-Circular-icon.png" Width="20px" />
                                </td>
                                <td rowspan="3">
                                    <div style="overflow: auto; width: 400px; height: 150px; margin-left: 20px;">
                                        <asp:GridView ID="GridView6" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="400px" CssClass="grids">
                                            <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                            <RowStyle Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="false" />
                                        </asp:GridView>
                                    </div>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>
                                    <asp:ImageButton ID="ImageButton7" runat="server" Height="20px" ImageUrl="~/Images/Arrows-Left-Circular-icon.png" Width="20px" />
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>&nbsp;</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td colspan="5"></td>
                            </tr>
                        </table>

                        <br />

                    </asp:Panel>


                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                <ContentTemplate>

                    <asp:Panel ID="Panel7" runat="server" CssClass="Panel">

                        <h2>
                            <asp:Label ID="Label7" runat="server" Text="Bajas Pendientes RH"></asp:Label></h2>
                        <br />

                        <div style="overflow: auto; width: 888px; margin-left: 30px;">
                            <asp:GridView ID="GridView7" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="880px" CssClass="grids">
                                <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:GridView>
                        </div>

                    </asp:Panel>

                    <br />
                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                <ContentTemplate>

                    <asp:Panel ID="Panel8" runat="server" CssClass="Panel">

                        <h2>
                            <asp:Label ID="Label8" runat="server" Text="Baja RH"></asp:Label></h2>
                        <br />

                        <table style="width: 100%;" class="Buscador">

                            <tr>
                                <td class="auto-style84">Nombres:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox14" runat="server" Wrap="True" CssClass="textos" Width="140px" Enabled="False"></asp:TextBox>
                                </td>
                                <td class="auto-style83">Apellido Paterno:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox25" runat="server" CssClass="textos" Wrap="True" Width="150px" Enabled="False"></asp:TextBox></td>
                                <td class="auto-style16">Apellido Materno:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox26" runat="server" CssClass="textos" Wrap="True" Width="140px" Enabled="False"></asp:TextBox></td>
                            </tr>

                            <tr>
                                <td class="auto-style84">Empleado:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox27" runat="server" CssClass="textos" Width="140px" Wrap="True" Enabled="False"></asp:TextBox>
                                </td>
                                <td class="auto-style83">Supervisor:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox28" runat="server" CssClass="textos" Width="150px" Wrap="True" Enabled="False"></asp:TextBox>
                                </td>
                                <td class="auto-style11">Campaña:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox40" runat="server" CssClass="textos" Enabled="False" Width="140px" Wrap="True"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style84">CURP:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox29" runat="server" CssClass="textos" Width="140px" Wrap="True" Enabled="False"></asp:TextBox>
                                </td>
                                <td class="auto-style83">RFC:</td>
                                <td class="auto-style19">
                                    <asp:TextBox ID="TextBox30" runat="server" CssClass="textos" Width="150px" Enabled="False"></asp:TextBox>
                                </td>
                                <td class="auto-style11">NSS:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox31" runat="server" CssClass="textos" Width="140px" Wrap="True" Enabled="False"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style84">Sexo:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList12" runat="server" Width="80px" Enabled="False">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem Value="1">M</asp:ListItem>
                                        <asp:ListItem Value="2">F</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="auto-style83">Fecha de Nacimiento:</td>
                                <td class="auto-style19">
                                    <asp:TextBox ID="TextBox32" runat="server" CssClass="textos" Width="150px" Wrap="True" Enabled="False"></asp:TextBox>

                                </td>
                                <td class="auto-style11">Estado Civil:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList18" runat="server" Width="80px" Enabled="False">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem Value="1">Soltero</asp:ListItem>
                                        <asp:ListItem Value="2">Casado</asp:ListItem>
                                        <asp:ListItem Value="3">Viudo</asp:ListItem>
                                        <asp:ListItem Value="4">Divorciado</asp:ListItem>
                                        <asp:ListItem Value="5">Union Libre</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style84">Entrada:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList19" runat="server" Width="80px" Enabled="False">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="auto-style83">Salida:</td>
                                <td class="auto-style22">

                                    <asp:DropDownList ID="DropDownList20" runat="server" Width="80px" Enabled="False">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="auto-style11">Jornada:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox33" runat="server" Width="50px" CssClass="textos" Enabled="False"></asp:TextBox>
                                </td>
                            </tr>

                        </table>


                        <table style="width: 100%;" class="Buscador">

                            <tr>
                                <td class="auto-style40">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telefono Casa:</td>
                                <td class="auto-style37">
                                    <asp:TextBox ID="TextBox34" CssClass="Textos " runat="server" Enabled="False"></asp:TextBox>
                                </td>
                                <td class="auto-style38">Telefono Móvil:</td>
                                <td class="auto-style39">
                                    <asp:TextBox ID="TextBox35" runat="server" Enabled="False"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style40">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Calle y Número:</td>
                                <td class="auto-style37">
                                    <asp:TextBox ID="TextBox36" runat="server" CssClass="Textos " Enabled="False"></asp:TextBox>
                                </td>
                                <td class="auto-style38">Estado:</td>
                                <td class="auto-style39">
                                    <asp:TextBox ID="TextBox38" runat="server" Enabled="False"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style40">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Delegacion/Municipio:</td>
                                <td class="auto-style37">
                                    <asp:TextBox ID="TextBox39" runat="server" Enabled="False"></asp:TextBox>
                                </td>
                                <td class="auto-style38">CP:</td>
                                <td class="auto-style39">
                                    <asp:TextBox ID="TextBox37" runat="server" Width="50px" Enabled="False"></asp:TextBox>
                                </td>
                            </tr>


                            <tr>
                                <td colspan="4" class="auto-style45">Comentarios:</td>
                            </tr>
                            <tr>
                                <td colspan="4" class="auto-style45">
                                    <asp:TextBox ID="TextBox52" runat="server" Height="50px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator55" runat="server" ControlToValidate="TextBox52" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaBaja"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="2" class="TablaCentro">Motivo Baja:&nbsp;
                            <asp:DropDownList ID="DropDownList23" runat="server">
                                <asp:ListItem Value="0">-Selecciona-</asp:ListItem>
                                <asp:ListItem Value="1">Abandono de Trabajo </asp:ListItem>
                                <asp:ListItem Value="2">Ambiente Laboral </asp:ListItem>
                                <asp:ListItem Value="3">Baja Productividad </asp:ListItem>
                                <asp:ListItem Value="4">Cierre de Campaña </asp:ListItem>
                                <asp:ListItem Value="5">Cliente solicita  baja </asp:ListItem>
                                <asp:ListItem Value="6">Colgar llamada </asp:ListItem>
                                <asp:ListItem Value="7">Esquema de Pago </asp:ListItem>
                                <asp:ListItem Value="8">Falsificación de Documentos </asp:ListItem>
                                <asp:ListItem Value="9">Falta de Capacitación </asp:ListItem>
                                <asp:ListItem Value="10">Falta de Oportunidades de Desarrollo</asp:ListItem>
                                <asp:ListItem Value="11">Faltas Injustificadas </asp:ListItem>
                                <asp:ListItem Value="12">Horario de Trabajo </asp:ListItem>
                                <asp:ListItem Value="13">Mal uso de la información de la empresa </asp:ListItem>
                                <asp:ListItem Value="14">Mala actitud del Jefe Inmediato </asp:ListItem>
                                <asp:ListItem Value="15">Mala actitud del operador </asp:ListItem>
                                <asp:ListItem Value="16">Mejor Oferta Laboral </asp:ListItem>
                                <asp:ListItem Value="17">Motivos escolares </asp:ListItem>
                                <asp:ListItem Value="18">Movimiento Interno </asp:ListItem>
                                <asp:ListItem Value="19">No apego a políticas de la empresa </asp:ListItem>
                                <asp:ListItem Value="20">Problemas de Salud</asp:ListItem>
                                <asp:ListItem Value="21">Problemas Personales/ Familiares </asp:ListItem>
                                <asp:ListItem Value="22">Termino de Contrato </asp:ListItem>
                                <asp:ListItem Value="23">No Contratado</asp:ListItem>

                            </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator43" runat="server" ControlToValidate="DropDownList23" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaBaja"></asp:RequiredFieldValidator>
                                </td>
                                <td colspan="2">Fecha de Baja:&nbsp;
                            <asp:TextBox ID="TextBox53" runat="server" CssClass="textos" Width="117px" Wrap="True"></asp:TextBox>
                                    <asp:CalendarExtender ID="TextBox53_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageButton8" TargetControlID="TextBox53">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton8" runat="server" Height="23px" ImageAlign="Middle" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator56" runat="server" ControlToValidate="TextBox53" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaBaja"></asp:RequiredFieldValidator>
                                </td>
                            </tr>


                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="Button13" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center; margin-right: 25px; margin-left: 370px;" Text="Cancelar" Width="85px" CssClass="Button" Height="22px" />
                                    <asp:Button ID="Button14" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center" Text="Aplicar" ValidationGroup="ValidaBaja" Width="85px" CssClass="Button" Height="22px" />
                                </td>
                            </tr>


                        </table>

                    </asp:Panel>



                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                <ContentTemplate>

                    <asp:Panel ID="Panel9" runat="server" CssClass="Panel">

                        <h2>
                            <asp:Label ID="Label9" runat="server" Text="Alta Administrativos"></asp:Label></h2>

                        <br />

                        <table style="width: 100%;" class="Buscador">

                            <tr>
                                <td>Nombres:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox41" runat="server" Wrap="True" CssClass="textos" Width="120px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ErrorMessage="*" ControlToValidate="TextBox41" ForeColor="Red" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator></td>
                                <td class="auto-style9">Apellido Paterno:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox42" runat="server" CssClass="textos" Wrap="True" Width="120px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ErrorMessage="*" ControlToValidate="TextBox42" ForeColor="Red" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator></td>
                                <td class="auto-style16">Apellido Materno:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox43" runat="server" CssClass="textos" Wrap="True" Width="120px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" ErrorMessage="*" ControlToValidate="TextBox43" ForeColor="Red" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator></td>
                            </tr>

                            <tr>
                                <td>Campaña:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList11" runat="server" Width="120px" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" ErrorMessage="*" ControlToValidate="DropDownList11" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style9">Area:</td>
                                <td class="auto-style10">

                                    <asp:DropDownList ID="DropDownList28" runat="server" Width="120px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator44" runat="server" ErrorMessage="*" ControlToValidate="DropDownList28" ForeColor="Red" ValidationGroup="ValidaAdmin" InitialValue="x"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">Puesto:</td>
                                <td class="auto-style17">

                                    <asp:DropDownList ID="DropDownList27" runat="server" Width="120px">
                                    </asp:DropDownList>

                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator45" runat="server" ErrorMessage="*" ControlToValidate="DropDownList27" ForeColor="Red" ValidationGroup="ValidaAdmin" InitialValue="x"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style18">Jefe Directo:</td>
                                <td class="auto-style9">
                                    <asp:DropDownList ID="DropDownList29" runat="server" Width="150px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator47" runat="server" ControlToValidate="DropDownList29" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style22">Correo CCS:</td>
                                <td class="auto-style11">
                                    <asp:TextBox ID="TextBox50" runat="server" Width="100px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator46" runat="server" ErrorMessage="*" ControlToValidate="TextBox50" ForeColor="Red" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>

                                <td class="auto-style17">&nbsp;</td>
                                <tr id="altaCalidad" runat="server">
                               
                                    <td class="auto-style81">Fecha de Nacimiento:</td>
                                <td class="auto-style19">
                                    <asp:TextBox ID="TextBox71" runat="server" CssClass="textos" Width="100px" Wrap="True" Enabled="False"></asp:TextBox>
                                    <asp:CalendarExtender ID="TextBox71_CalendarExtender" runat="server" Enabled="True" PopupButtonID="ImageButton12" TargetControlID="TextBox71" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton12" runat="server" Height="23px" ImageAlign="Middle" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator85" runat="server" ControlToValidate="TextBox71" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>

                                    <td class="auto-style22">ID ACD</td>
                                <td class="auto-style11">
                                    <asp:TextBox ID="TextBox72" runat="server" Width="100px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator86" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="TextBox72" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>
                                    <td class="auto-style22">Núm. Empleado</td>
                                <td class="auto-style11">
                                    <asp:TextBox ID="TextBox73" runat="server" Width="100px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator87" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="TextBox73" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>

                                    </tr>
                            </tr>

                        </table>


                        <table class="auto-style27">

                            <tr>
                                <td class="auto-style36">Telefono Casa:</td>
                                <td class="auto-style33">
                                    <asp:TextBox ID="TextBox48" CssClass="Textos " runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator49" runat="server" ErrorMessage="*" ControlToValidate="TextBox48" ForeColor="Red" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style34">Telefono Móvil:</td>
                                <td class="auto-style35">
                                    <asp:TextBox ID="TextBox49" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator50" runat="server" ErrorMessage="*" ControlToValidate="TextBox49" ForeColor="Red" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>
                            </tr>



                            <tr>
                                <td class="auto-style47">Entrada:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList25" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator53" runat="server" ErrorMessage="*" ControlToValidate="DropDownList25" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style31">Salida:</td>
                                <td class="auto-style32">
                                    <asp:DropDownList ID="DropDownList26" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator54" runat="server" ErrorMessage="*" ControlToValidate="DropDownList26" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaAdmin"></asp:RequiredFieldValidator>
                                </td>
                            </tr>


                            <tr>
                                <td colspan="4"></td>
                            </tr>



                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="Button16" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center; margin-right: 25px;" Text="Limpiar" CssClass="Button" Height="22px" Width="85px" />
                                    <asp:Button ID="Button17" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center" Text="Guardar" ValidationGroup="ValidaAdmin" CssClass="Button" Height="22px" Width="85px" />
                                </td>
                            </tr>


                        </table>

                    </asp:Panel>



                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="UpdatePanel13" runat="server">

                <ContentTemplate>


                    <asp:Panel ID="Panel13" runat="server" CssClass="Panel">

                        <h2>
                            <asp:Label ID="Label10" runat="server" Text="Buscador"></asp:Label></h2>
                        <br />

                        <table style="width: 100%;" class="Buscador">

                            <tr>
                                <td class="auto-style49">ID o # Nómina:</td>
                                <td class="auto-style7">
                                    <asp:TextBox ID="TextBox67" runat="server" AutoPostBack="True" CssClass="textos"> </asp:TextBox>
                                </td>
                                <td class="auto-style49">Nombre o Apellido:</td>
                                <td class="auto-style7">
                                    <asp:TextBox ID="TextBox68" runat="server" AutoPostBack="True" CssClass="textos"></asp:TextBox>
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
                                        <asp:Button ID="Button27" runat="server" Font-Bold="True" Font-Size="13px" Text="Buscar" ValidationGroup="Requeridos" Height="22px" Width="85px" CssClass="Button" Style="margin-left: 390px;" />
                                    </strong>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="6"></td>
                            </tr>

                        </table>
                        <div style="overflow: auto; width: 888px; height: 100px; margin-left:25px;">
                            <asp:GridView ID="GridView8" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="880px" CssClass="grids">
                                <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:GridView>
                        </div>
               

                    </asp:Panel>



                    <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                        <ContentTemplate>

              

                    <asp:Panel ID="Panel12" runat="server" CssClass="Panel">

                        <h2><asp:Label ID="Label11" runat="server" Text="Editar"></asp:Label></h2>

                        <br />

                        <table style="width: 100%;" class="Buscador">

                            <tr>
                                <td>Nombres:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox46" runat="server" Wrap="True" CssClass="textos" Width="140px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator52" runat="server" ErrorMessage="*" ControlToValidate="TextBox46" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator></td>
                                <td class="auto-style9">Apellido Paterno:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox47" runat="server" CssClass="textos" Wrap="True" Width="150px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator58" runat="server" ErrorMessage="*" ControlToValidate="TextBox47" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator></td>
                                <td class="auto-style16">Apellido Materno:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox54" runat="server" CssClass="textos" Wrap="True" Width="140px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator59" runat="server" ErrorMessage="*" ControlToValidate="TextBox54" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator></td>
                            </tr>

                            <tr>
                                <td>Empleado:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox55" runat="server" CssClass="textos" Width="140px" Wrap="True"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator60" runat="server" ErrorMessage="*" ControlToValidate="TextBox55" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style9">Supervisor:</td>
                                <td class="auto-style10">
                                    <asp:DropDownList ID="DropDownList38" runat="server" AutoPostBack="True" Width="140px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator61" runat="server" ErrorMessage="*" ControlToValidate="DropDownList38" ForeColor="Red" ValidationGroup="ValidaCambios" InitialValue="0"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">Campaña:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True" Width="140px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator62" runat="server" ControlToValidate="DropDownList6" InitialValue="0" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td>CURP:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox57" runat="server" CssClass="textos" Width="140px" Wrap="True"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator63" runat="server" ControlToValidate="TextBox57" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style9">RFC:</td>
                                <td class="auto-style19">
                                    <asp:TextBox ID="TextBox58" runat="server" CssClass="textos" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator64" runat="server" ControlToValidate="TextBox58" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">NSS:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox59" runat="server" CssClass="textos" Width="140px" Wrap="True"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator65" runat="server" ControlToValidate="TextBox59" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td>Area:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList30" runat="server" Width="80px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator66" runat="server" ControlToValidate="DropDownList30" ErrorMessage="*" ForeColor="Red" InitialValue="X" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style9">Fecha de Nacimiento:</td>
                                <td class="auto-style19">
                                    <asp:TextBox ID="TextBox60" runat="server" CssClass="textos" Width="117px" Wrap="True"></asp:TextBox>

                                    <asp:CalendarExtender ID="TextBox60_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox60" PopupButtonID="ImageButton4" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>

                                    <asp:ImageButton ID="ImageButton4" runat="server" Height="23px" ImageAlign="Middle" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator67" runat="server" ControlToValidate="TextBox60" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">Puesto:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList31" runat="server" Width="140px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator68" runat="server" ControlToValidate="DropDownList31" ErrorMessage="*" ForeColor="Red" InitialValue="X" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td>Entrada:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList32" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator69" runat="server" ControlToValidate="DropDownList32" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style9">Salida:</td>
                                <td class="auto-style22">

                                    <asp:DropDownList ID="DropDownList33" runat="server" Width="80px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                        <asp:ListItem>00:00</asp:ListItem>
                                        <asp:ListItem>00:30</asp:ListItem>
                                        <asp:ListItem>01:00</asp:ListItem>
                                        <asp:ListItem>01:30</asp:ListItem>
                                        <asp:ListItem>02:00</asp:ListItem>
                                        <asp:ListItem>02:30</asp:ListItem>
                                        <asp:ListItem>03:00</asp:ListItem>
                                        <asp:ListItem>03:30</asp:ListItem>
                                        <asp:ListItem>04:00</asp:ListItem>
                                        <asp:ListItem>04:30</asp:ListItem>
                                        <asp:ListItem>05:00</asp:ListItem>
                                        <asp:ListItem>05:30</asp:ListItem>
                                        <asp:ListItem>06:00</asp:ListItem>
                                        <asp:ListItem>06:30</asp:ListItem>
                                        <asp:ListItem>07:00</asp:ListItem>
                                        <asp:ListItem>07:30</asp:ListItem>
                                        <asp:ListItem>08:00</asp:ListItem>
                                        <asp:ListItem>08:30</asp:ListItem>
                                        <asp:ListItem>09:00</asp:ListItem>
                                        <asp:ListItem>09:30</asp:ListItem>
                                        <asp:ListItem>10:00</asp:ListItem>
                                        <asp:ListItem>10:30</asp:ListItem>
                                        <asp:ListItem>11:00</asp:ListItem>
                                        <asp:ListItem>11:30</asp:ListItem>
                                        <asp:ListItem>12:00</asp:ListItem>
                                        <asp:ListItem>12:30</asp:ListItem>
                                        <asp:ListItem>13:00</asp:ListItem>
                                        <asp:ListItem>13:30</asp:ListItem>
                                        <asp:ListItem>14:00</asp:ListItem>
                                        <asp:ListItem>14:30</asp:ListItem>
                                        <asp:ListItem>15:00</asp:ListItem>
                                        <asp:ListItem>15:30</asp:ListItem>
                                        <asp:ListItem>16:00</asp:ListItem>
                                        <asp:ListItem>16:30</asp:ListItem>
                                        <asp:ListItem>17:00</asp:ListItem>
                                        <asp:ListItem>17:30</asp:ListItem>
                                        <asp:ListItem>18:00</asp:ListItem>
                                        <asp:ListItem>18:30</asp:ListItem>
                                        <asp:ListItem>19:00</asp:ListItem>
                                        <asp:ListItem>19:30</asp:ListItem>
                                        <asp:ListItem>20:00</asp:ListItem>
                                        <asp:ListItem>20:30</asp:ListItem>
                                        <asp:ListItem>21:00</asp:ListItem>
                                        <asp:ListItem>21:30</asp:ListItem>
                                        <asp:ListItem>22:00</asp:ListItem>
                                        <asp:ListItem>22:30</asp:ListItem>
                                        <asp:ListItem>23:00</asp:ListItem>
                                        <asp:ListItem>23:30</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator70" runat="server" ControlToValidate="DropDownList33" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">ID ACD:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox61" runat="server" Width="80px" CssClass="textos"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator71" runat="server" ControlToValidate="TextBox61" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td>Alta:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox62" runat="server" CssClass="textos" Width="117px" Wrap="True"></asp:TextBox>

                                    <asp:CalendarExtender ID="TextBox62_CalendarExtender" runat="server" Enabled="True" PopupButtonID="ImageButton10" TargetControlID="TextBox62" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>

                                    <asp:ImageButton ID="ImageButton10" runat="server" Height="23px" ImageAlign="Middle" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator80" runat="server" ControlToValidate="TextBox62" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style9">Dep. Economicos:</td>
                                <td class="auto-style22">

                                    <asp:DropDownList ID="DropDownList34" runat="server" Width="120px">
                                        <asp:ListItem Value="X">-Selecciona-</asp:ListItem>
                                        <asp:ListItem Value="0">0</asp:ListItem>
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                        <asp:ListItem>8</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator72" runat="server" ControlToValidate="DropDownList34" ErrorMessage="*" ForeColor="Red" InitialValue="X" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style11">Escolaridad:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList35" runat="server" Width="120px">
                                        <asp:ListItem Value="0">-Selecciona-</asp:ListItem>
                                        <asp:ListItem Value="Secundaria">Secundaria</asp:ListItem>
                                        <asp:ListItem>Bachillerato Trunco</asp:ListItem>
                                        <asp:ListItem Value="Bachillerato">Bachillerato</asp:ListItem>
                                        <asp:ListItem Value="Licenciatura Trunca">Licenciatura Trunca</asp:ListItem>
                                        <asp:ListItem Value="Licenciatura">Licenciatura</asp:ListItem>
                                        <asp:ListItem>Carrera Tecnica</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator73" runat="server" ControlToValidate="DropDownList35" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                        </table>


                        <table class="auto-style58">

                            <tr>
                                <td class="auto-style67">Status:</td>
                                <td class="auto-style51">
                                    <asp:DropDownList ID="DropDownList39" runat="server" Width="140px"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator81" runat="server" ErrorMessage="*" ControlToValidate="DropDownList39" ForeColor="Red" ValidationGroup="ValidaCambios" InitialValue="X"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style52">Mail CCS:</td>
                                <td class="auto-style53">
                                    <asp:TextBox ID="TextBox69" runat="server" Width="140px" Height="20px"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style67">Telefono Casa:</td>
                                <td class="auto-style51">
                                    <asp:TextBox ID="TextBox63" CssClass="Textos " runat="server" Width="140px" Height="20px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator74" runat="server" ErrorMessage="*" ControlToValidate="TextBox63" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style52">Telefono Móvil:</td>
                                <td class="auto-style53">
                                    <asp:TextBox ID="TextBox64" runat="server" Width="140px" Height="20px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator75" runat="server" ErrorMessage="*" ControlToValidate="TextBox64" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style63">Calle y Número:</td>
                                <td class="auto-style64">
                                    <asp:TextBox ID="TextBox65" runat="server" CssClass="Textos " Height="20px" Width="140px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator76" runat="server" ControlToValidate="TextBox65" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style65">Estado:</td>
                                <td class="auto-style66">
                                    <asp:DropDownList ID="DropDownList36" runat="server" Width="140px" AutoPostBack="True" Height="20px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator77" runat="server" ControlToValidate="DropDownList36" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style59">Delegacion/Municipio:</td>
                                <td class="auto-style60">
                                    <asp:DropDownList ID="DropDownList37" runat="server" Width="140px" Height="20px">
                                        <asp:ListItem Value="0">-</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator78" runat="server" ErrorMessage="*" ControlToValidate="DropDownList37" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style61">CP:</td>
                                <td class="auto-style62">
                                    <asp:TextBox ID="TextBox66" runat="server" Width="50px" Height="20px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator79" runat="server" ControlToValidate="TextBox66" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaCambios"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="4"></td>
                            </tr>


                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="Button24" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center; margin-right: 25px;" Text="Limpiar" CssClass="Button" Height="22px" Width="85px" />
                                    <asp:Button ID="Button25" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center" Text="Guardar" ValidationGroup="ValidaCambios" CssClass="Button" Height="22px" Width="85px" />
                                </td>
                            </tr>


                        </table>
                    </asp:Panel>


                                      </ContentTemplate>
                    </asp:UpdatePanel>

                </ContentTemplate>
            </asp:UpdatePanel>





            <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                <ContentTemplate>

                    <asp:Panel ID="Panel14" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label12" runat="server" Text="Cambio de Instructor"></asp:Label></h2>

                        <br />

                        <table style="width: 100%; margin-left: 20px;" class="Buscador">
                            <tr>
                                <td colspan="5" class="auto-style20"></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td class="auto-style45">Instructor:
                            <asp:DropDownList ID="DropDownList40" runat="server" Width="200px" AutoPostBack="True"></asp:DropDownList>
                                </td>
                                <td class="auto-style70"></td>
                                <td class="auto-style45">Instructor:
                            <asp:DropDownList ID="DropDownList41" runat="server" Width="200px" AutoPostBack="True"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator82" runat="server" ControlToValidate="DropDownList41" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="ValidaUpdateCAP"></asp:RequiredFieldValidator>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td rowspan="3">

                                    <div style="overflow: auto; width: 400px; height: 150px;">

                                        <asp:GridView ID="GridView9" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="400px" CssClass="grids">
                                            <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                            <RowStyle Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="false" />
                                        </asp:GridView>
                                    </div>
                                </td>
                                <td class="auto-style70">
                                    <asp:ImageButton ID="ImageButton11" runat="server" Height="20px" ImageUrl="~/Images/Arrows-Right-Circular-icon.png" Width="20px" ValidationGroup="ValidaUpdateCAP" />
                                </td>
                                <td rowspan="3">
                                    <div style="overflow: auto; width: 400px; height: 150px;">
                                        <asp:GridView ID="GridView10" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="400px" CssClass="grids">
                                            <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                            <RowStyle Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="false" />
                                        </asp:GridView>
                                    </div>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td class="auto-style70">&nbsp;</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td class="auto-style70">&nbsp;</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td class="auto-style70"></td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td colspan="5"></td>
                            </tr>
                        </table>

                        <br />


                    </asp:Panel>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                <ContentTemplate>




                    <asp:Panel ID="Panel10" runat="server" CssClass="Panel">

                        <h2>
                            <asp:Label ID="Label13" runat="server" Text="Captura de Aspirantes"></asp:Label></h2>

                        <br />

                        <table style="width: 100%; margin-left: 45px;" class="Buscador">
                            <tr>
                                <td class="auto-style46">Fecha Tronco Común:</td>
                                <td>
                                    <asp:TextBox ID="TextBox44" runat="server" CssClass="textos"></asp:TextBox>

                                    <asp:CalendarExtender ID="TextBox44_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageButton9" TargetControlID="TextBox44">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton9" runat="server" Height="23px" ImageAlign="Middle" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator57" runat="server" ControlToValidate="TextBox44" ErrorMessage="*" ForeColor="Red" ValidationGroup="ValidaReclu"></asp:RequiredFieldValidator>

                                </td>

                            </tr>

                            <tr>
                                <td class="auto-style46">Número de Aspirantes:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList24" runat="server" AutoPostBack="True">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                        <asp:ListItem>8</asp:ListItem>
                                        <asp:ListItem>9</asp:ListItem>
                                        <asp:ListItem>10</asp:ListItem>
                                        <asp:ListItem>11</asp:ListItem>
                                        <asp:ListItem>12</asp:ListItem>
                                        <asp:ListItem>13</asp:ListItem>
                                        <asp:ListItem>14</asp:ListItem>
                                        <asp:ListItem>15</asp:ListItem>
                                        <asp:ListItem>16</asp:ListItem>
                                        <asp:ListItem>17</asp:ListItem>
                                        <asp:ListItem>18</asp:ListItem>
                                        <asp:ListItem>19</asp:ListItem>
                                        <asp:ListItem>20</asp:ListItem>
                                    </asp:DropDownList></td>

                            </tr>

                        </table>

                        <table style="width: 100%; margin-left: 45px;" class="Buscador">

                            <tr>
                                <td class="auto-style45">
                                    <uc1:Aspirante ID="Aspirante1" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante2" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante3" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante4" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante5" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante6" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante7" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante8" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante9" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante10" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante11" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante12" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante13" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante14" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante15" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante16" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante17" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante18" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante19" runat="server" Visible="false" />
                                    <uc1:Aspirante ID="Aspirante20" runat="server" Visible="false" />


                                </td>
                            </tr>

                        </table>

                        <table style="width: 100%;" class="Buscador">
                            <tr>
                                <td class="auto-style48">
                                    <asp:Button ID="Button19" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center; margin-right: 25px; margin-left: 370px;" Text="Limpiar" CssClass="Button" Height="22px" Width="85px" />
                                    <asp:Button ID="Button20" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center" Text="Guardar" ValidationGroup="ValidaReclu" CssClass="Button" Height="22px" Width="85px" />
                                </td>
                            </tr>


                        </table>

                    </asp:Panel>


                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel11" runat="server" CssClass="Panel">

                        <h2>
                            <asp:Label ID="Label14" runat="server" Text="Tronco Común"></asp:Label></h2>
                        <br />
                        <table style="width: 100%; margin-left: 40px;" class="Buscador">

                            <tr>
                                <td class="auto-style45">

                                    <uc1:TroncoComun runat="server" ID="TroncoComun1" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun2" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun3" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun4" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun5" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun6" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun7" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun8" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun9" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun10" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun11" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun12" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun13" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun14" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun15" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun16" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun17" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun18" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun19" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun20" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun21" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun22" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun23" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun24" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun25" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun26" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun27" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun28" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun29" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun30" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun31" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun32" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun33" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun34" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun35" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun36" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun37" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun38" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun39" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun40" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun41" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun42" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun43" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun44" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun45" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun46" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun47" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun48" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun49" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun50" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun51" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun52" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun53" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun54" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun55" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun56" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun57" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun58" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun59" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun60" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun61" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun62" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun63" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun64" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun65" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun66" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun67" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun68" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun69" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun70" Visible="false" />
                                      <uc1:TroncoComun runat="server" ID="TroncoComun71" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun72" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun73" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun74" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun75" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun76" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun77" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun78" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun79" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun80" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun81" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun82" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun83" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun84" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun85" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun86" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun87" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun88" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun89" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun90" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun91" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun92" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun93" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun94" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun95" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun96" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun97" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun98" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun99" Visible="false" />
                                    <uc1:TroncoComun runat="server" ID="TroncoComun100" Visible="false" />

                                  


                                </td>
                            </tr>

                        </table>

                        <table style="width: 100%;" class="Buscador">
                            <tr>
                                <td class="auto-style48">
                                    <asp:Button ID="Button23" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center; margin-left: 380px;" Text="Guardar" ValidationGroup="ValidaTronco" CssClass="Button" Height="22px" Width="85px" />
                                </td>
                            </tr>


                        </table>

                    </asp:Panel>



                </ContentTemplate>
            </asp:UpdatePanel>



            <br />

        </div>
    </div>

</asp:Content>
