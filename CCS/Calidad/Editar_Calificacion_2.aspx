<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Editar_Calificacion_2.aspx.vb" Inherits="CCS.Editar_Calificacion_2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }

        .auto-style3 {
            width: 14px;
        }

        </style>

    <script src="../JS/funcionesReproductor.js.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <div id="site_content">
        <div class="content">

            <h1>Editar Calificaciín</h1>

            <asp:Panel ID="Panel11" runat="server" CssClass="Panel">
                <h2>Grabación</h2>
                <div id="reproductorBox" class="TablaCentro">
                </div>

            </asp:Panel>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Monitoreo"></asp:Label></h2>

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
                                            <asp:Label ID="Dato1" runat="server" Width="180px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label8" runat="server" Text="ID ACD:"></asp:Label>
                                        </td>
                                        <td class="">
                                            <asp:Label ID="Dato6" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label10" runat="server" Text="Supervisor:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:Label ID="Dato2" runat="server" Width="180px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label12" runat="server" Text="Calificación:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Dato7" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label18" runat="server" Text="Folio Llamada:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:Label ID="Dato4" runat="server" Width="180px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label20" runat="server" Text="Duracion:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Dato9" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label13" runat="server" Text="Fecha de Audio:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:Label ID="Dato5" runat="server" Width="180px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label19" runat="server" Text="Fecha de Monitoreo:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Dato10" runat="server"></asp:Label>
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
                                            <asp:Label ID="Label35" runat="server"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label24" runat="server" Text="Folio:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Label34" runat="server"></asp:Label>
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
                            <asp:Panel ID="Panel9" runat="server" Width="700px" CssClass="margencito">
                            </asp:Panel>
                        </div>


                        <div runat="server" id="Comentario" visible="True" style="padding-left: 25px;">
                            <asp:Panel ID="Panel5" runat="server" Width="700px" CssClass="margencitobottom">
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
                        </div>

                        <br />


                        <div runat="server" id="Div1" style="margin-left: 25px;">
                            <asp:Panel ID="Panel4" runat="server" Width="700px" CssClass="margencitofull">
                                <table style="width: 100%">

                                    <tr class="TablaCentro">
                                 
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text="Firma Supervisor QA:"></asp:Label>
                                            <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" AutoPostBack="True"></asp:TextBox>
                                            <asp:Image ID="Image2" runat="server" ImageAlign="Middle" ImageUrl="~/Images/Check-3-icon.png" Visible="False" Width="20px" />
                                            <asp:HiddenField ID="HiddenField1" runat="server" Value="0" />
                                        </td>
                     
                                    </tr>







                                </table>
                            </asp:Panel>

                            <br />
                            <div class="textos">
                                <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="Button" Height="25px" Width="85px" ValidationGroup="Valida1" />
                                <asp:HiddenField ID="HiddenField3" runat="server" />
                            </div>



                        </div>




                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <script>cargarReproductor();</script>

</asp:Content>
