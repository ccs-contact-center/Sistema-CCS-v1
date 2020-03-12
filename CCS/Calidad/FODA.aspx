<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="FODA.aspx.vb" Inherits="CCS.FODA" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }

        .auto-style3 {
            width: 14px;
        }

        .auto-style4 {
            width: 77px;
        }
    </style>

    <script src="../JS/funcionesReproductor.js.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <div id="site_content">
        <div class="content">

            <h1>Retroalimentación</h1>

            <asp:Panel ID="Panel11" runat="server" CssClass="Panel">
                <h2>Grabación</h2>
                <div id="reproductorBox" class="TablaCentro">
                </div>

            </asp:Panel>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="FODA"></asp:Label></h2>

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

                                    <div runat="server" id="Agente">
                                    <tr>
                                        <td colspan="6" class="TituloGuia">Compromisos Agente</td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="auto-style2">
                                            <asp:TextBox ID="TextBox3" runat="server" BorderStyle="None" Height="40px" TextMode="MultiLine" Width="100%" CssClass="textos"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    </div>
                                    <div runat="server" id="Analista">
                                    <tr>
                                        <td colspan="6" class="TituloGuia">Comentario Analista</td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="auto-style2">
                                            <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" Height="40px" TextMode="MultiLine" Width="100%" CssClass="textos"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    </div>

                                </table>
                            </asp:Panel>
                        </div>

                        <asp:Panel ID="Panel30" runat="server" Width="700px" CssClass="margencitobottom" Visible="false" >
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="6" class="TituloGuia">¿ Qué ocasionó que no realizarás el proceso correcto de HOLD? </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox54" runat="server" BorderStyle="None" Height="40px" TextMode="MultiLine" Width="100%" CssClass="textos"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox54" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>

                                </table>
                                 </asp:Panel>


                                  <asp:Panel ID="Panel31" runat="server" Width="700px" CssClass="margencitobottom" Visible="false">
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="6" class="TituloGuia">¿Solicitaste apoyo para atender esta llamada y a quién? </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox55" runat="server" BorderStyle="None" Height="40px" TextMode="MultiLine" Width="100%" CssClass="textos"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox55" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>

                                        </td>
                                    </tr>

                                </table>
                            </asp:Panel>
                          





                        <br />


                        <div runat="server" id="Div1" style="margin-left: 25px;">
                            <asp:Panel ID="Panel4" runat="server" Width="700px" CssClass="margencitofull">
                                <table style="width: 100%">

                                    <tr>
                                        <td class="auto-style4"></td>
                                        <div runat="server" id="FirmaAnalista">
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text="Firma Analista:"></asp:Label>
                                            <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" AutoPostBack="True"></asp:TextBox>
                                            <asp:Image ID="Image2" runat="server" ImageAlign="Middle" ImageUrl="~/Images/Check-3-icon.png" Visible="False" Width="20px" />
                                            <asp:HiddenField ID="HiddenField1" runat="server" Value="0" />
                                        </td>
                                        </div>
                                        <td class="auto-style2">&nbsp;</td>
                                        <div runat="server" id ="FirmaAgente">
                                        <td>
                                            <asp:Label ID="Label4" runat="server" Text="Firma Agente:"></asp:Label>
                                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" AutoPostBack="True"></asp:TextBox>
                                            <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/Check-3-icon.png" Visible="False" Width="20px" ImageAlign="Middle" />
                                            <asp:HiddenField ID="HiddenField2" runat="server" Value="0" />
                                        </td>
                                        </div>
                                        <td>&nbsp;</td>
                                        <td class="auto-style5">
                                            <asp:Image ID="Image4" runat="server" ImageAlign="Middle" ImageUrl="~/Images/Check-3-icon.png" Visible="False" Width="20px" />
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
