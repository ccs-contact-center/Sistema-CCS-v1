<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Monitoreo.aspx.vb" Inherits="CCS.Monitoreo" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 268px;
        }

        .auto-style3 {
            width: 140px;
        }



        .auto-style5 {
            width: 36px;
        }



        .auto-style6 {
            height: 21px;
        }

        .auto-style7 {
            width: 268px;
            height: 21px;
        }

        .auto-style8 {
            width: 140px;
            height: 21px;
        }

        .auto-style9 {
            width: 36px;
            height: 21px;
        }

        .auto-style11 {
            width: 46px;
            height: 21px;
        }



        .auto-style12 {
            width: 46px;
        }

        .auto-style13 {
            width: 100px;
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


    <script src="../JS/funcionesReproductor.js.js"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" AsyncPostBackTimeout="0"></asp:ToolkitScriptManager>

    <div id="site_content">
        <div class="content">

            <h1>Monitoreo</h1>

            <asp:Panel ID="Panel11" runat="server" CssClass="Panel">
                <h2>Grabación</h2>
                <div id="reproductorBox" class="TablaCentro">
                </div>

            </asp:Panel>


            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>

                    <asp:Panel ID="Panel9" runat="server" CssClass="Panel">




                        <asp:Button ID="Button3" runat="server" Text="Pendientes" BackColor="#C00327" Font-Bold="True" ForeColor="White" Height="22px" Width="100%" CssClass="Boton" BorderStyle="None" />
                        <asp:Panel ID="Panel10" runat="server" CssClass="margenlistas">
                            <br />
                            <br />

                            <asp:GridView ID="GridView1" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="880px" CssClass="grids">
                                <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:GridView>

                            <br />


                        </asp:Panel>
                    </asp:Panel>


                    <asp:CollapsiblePanelExtender ID="Panel2_CollapsiblePanelExtender" runat="server" CollapseControlID="Button3" Collapsed="True" Enabled="True" ExpandControlID="Button3" TargetControlID="Panel10">
                    </asp:CollapsiblePanelExtender>


                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Guia de Monitoreo"></asp:Label></h2>

                        <div runat="server" id="Generales" visible="True" style="padding-left: 25px;">
                            <asp:Panel ID="Panel2" runat="server" Width="700px" CssClass="margencitotop">
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="6" class="TituloGuia">DATOS GENERALES</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:Label ID="Label7" runat="server"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label8" runat="server" Text="Fecha:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Label9" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label10" runat="server" Text="Supervisor:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:Label ID="Label11" runat="server"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label12" runat="server" Text="ID ACD:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:TextBox ID="TextBox1" runat="server" Width="70px" CssClass="textos" AutoPostBack="True"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Guia"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style11"></td>
                                        <td class="auto-style6">
                                            <asp:Label ID="Label14" runat="server" Text="Nivel Anterior:"></asp:Label>
                                        </td>
                                        <td class="auto-style7">
                                            <asp:Label ID="Label15" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style6">
                                            <asp:Label ID="Label16" runat="server" Text="Nivel Actual:"></asp:Label>
                                        </td>
                                        <td class="auto-style8">
                                            <asp:Label ID="Label17" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style9"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label18" runat="server" Text="Folio Llamada:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:TextBox ID="TextBox2" runat="server" Width="180px" CssClass="textos" AutoPostBack="True"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Guia"></asp:RequiredFieldValidator>
                                            <asp:ImageButton ID="ImageButton2" runat="server" Height="20px" ImageAlign="Top" ImageUrl="~/Images/Elegantthemes-Beautiful-Flat-Play.ico" Width="20px" />
                                            <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" Text=" " />
                                            <asp:TextBox ID="TextBox10" runat="server" AutoPostBack="True" CssClass="textos" Visible="False" Width="25px">2</asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label20" runat="server" Text="Duracion:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:TextBox ID="TextBox3" runat="server" Width="70px" CssClass="textos"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Guia"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationExpression="^((0?[1-9]|1[012])(:[0-5]\d){0,2}(\ [AP]M))$|^([01]\d|2[0-3])(:[0-5]\d){0,2}$" ValidationGroup="Guia"></asp:RegularExpressionValidator>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label13" runat="server" Text="Fecha de Audio:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:TextBox ID="TextBox4" runat="server" Width="100px" CssClass="textos"></asp:TextBox>
                                            <asp:CalendarExtender ID="TextBox4_CalendarExtender" runat="server" Enabled="True" PopupButtonID="ImageButton1" TargetControlID="TextBox4" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                            <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Guia"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label19" runat="server" Text="Mon. Rest.:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Label21" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label23" runat="server" Text="Error Fatal:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">

                                            <asp:CheckBox ID="CheckBox1" runat="server" Text=" " AutoPostBack="True" />

                                        </td>
                                        <td>
                                            <asp:Label ID="Label25" runat="server" Text="Min. Error:" Visible="False"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:TextBox ID="TextBox9" runat="server" CssClass="textos" Width="70px" Visible="False"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox9" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Guia" Visible="False"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox9" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationExpression="^((0?[1-9]|1[012])(:[0-5]\d){0,2}(\ [AP]M))$|^([01]\d|2[0-3])(:[0-5]\d){0,2}$" ValidationGroup="Guia"></asp:RegularExpressionValidator>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>


                                </table>
                            </asp:Panel>

                            <asp:Panel ID="Panel7" runat="server" Width="700px" CssClass="margencito" Visible="False">
                                <table style="width: 100%">

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td class="auto-style13">
                                            <asp:Label ID="Label22" runat="server" Text="Cliente:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:TextBox ID="TextBox7" runat="server" CssClass="textos" Width="180px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox7" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Guia"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label24" runat="server" Text="Folio:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:TextBox ID="TextBox8" runat="server" CssClass="textos" Width="70px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox8" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Guia"></asp:RequiredFieldValidator>
                                        </td>
                                       <%-- <td class="auto-style5"></td>--%>

                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text="Tipo de Servicio Correcto:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:TextBox ID="TextBox12" runat="server" CssClass="textos" Width="90px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox12" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Guia"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="auto-style5"></td>

                                    </tr>

                                </table>
                            </asp:Panel>

                            <asp:Panel ID="Panel8" runat="server" Width="700px" CssClass="margencito">
                                <table style="width: 100%">

                                    <tr>
                                        <td colspan="6" class="TituloGuia">EVALUACIÓN</td>
                                    </tr>
                                </table>
                            </asp:Panel>

                        </div>

                        <div runat="server" id="Guia" visible="True" style="padding-left: 25px;">
                            <asp:Panel ID="Panel3" runat="server" Width="700px" CssClass="margencito">
                            </asp:Panel>
                        </div>

                        <div runat="server" id="Totales" visible="True" style="padding-left: 25px;">
                            <asp:Panel ID="Panel4" runat="server" Width="700px" CssClass="margencito">
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="3" class="TituloGuia">CALIFICACIÓN TOTAL:</td>
                                        <td colspan="3" class="TituloGuiaCal">
                                            <asp:Label ID="Label5" runat="server" Text="-" Width="45px"></asp:Label>
                                        </td>

                                    </tr>


                                </table>
                            </asp:Panel>
                        </div>

                        <div runat="server" id="Comentario" visible="True" style="padding-left: 25px;">
                            <asp:Panel ID="Panel5" runat="server" Width="700px" CssClass="margencito">
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="6" class="TablaRubros">Comentario:</td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox6" runat="server" Height="40px" TextMode="MultiLine" Width="690px"></asp:TextBox>
                                        </td>
                                    </tr>

                                </table>
                            </asp:Panel>
                            <asp:Panel ID="Panel13" runat="server" Width="700px" CssClass="margencito" Visible="false">
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="6" class="TablaRubros">Hold:</td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox11" runat="server" Height="40px" TextMode="MultiLine" Width="690px"></asp:TextBox>
                                        </td>
                                    </tr>

                                </table>
                            </asp:Panel>

                            


                        </div>

                        <div style="padding-left: 25px;" class="TablaCentro">
                            <asp:Panel ID="Panel12" runat="server" Width="700px" CssClass="margencito">
                                <asp:CheckBox ID="CheckBox2" runat="server" Text="Alarma Operativa" Height="20px" AutoPostBack="True" />
                                <br />
                                <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Width="690px" Visible="False" Height="40px"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Guia"></asp:RequiredFieldValidator>
                            </asp:Panel>
                        </div>

                        <div runat="server" id="Adicionales" visible="True" style="padding-left: 25px;">
                            <asp:Panel ID="Panel6" runat="server" Width="700px" CssClass="margencitobottom">
                            </asp:Panel>
                        </div>

                        <br />
                         
                        
                        <div class="textos">
                            <asp:Button ID="Button1" runat="server" Text="Limpiar" CssClass="Button" Style="margin-right: 180px;" Height="25px" Width="85px" Visible="True" />
                            <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="Button" Height="25px" Width="85px" ValidationGroup="Guia" />
                            <asp:HiddenField ID="HiddenField1" runat="server" />
                            <asp:Label ID="Label26" runat="server" Text="0" Visible="False"></asp:Label>
                            <asp:Label ID="Label27" runat="server" Text="0" Visible="False"></asp:Label>
                        </div>

                    </asp:Panel>
                </ContentTemplate>
           </asp:UpdatePanel>

        </div>
    </div>
    <script>cargarReproductor();</script>
</asp:Content>
