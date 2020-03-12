<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Coaching_Sup.aspx.vb" Inherits="CCS.Coaching_Sup" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
        .auto-style2 {
            width: 16px;
        }

        .auto-style3 {
            width: 17px;
        }

        .auto-style4 {
            width: 236px;
        }
        .auto-style5 {
            text-align: center;
        }
    </style>

    <script src="../JS/funcionesReproductor.js.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="site_content">
        <div class="content">

            <h1>Retroalimentación<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            </h1>


            <asp:Panel ID="Panel11" runat="server" CssClass="Panel">
                <h2>Grabación</h2>
                <div id="reproductorBox" class="TablaCentro">
                </div>

            </asp:Panel>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Coaching"></asp:Label></h2>
                        <div runat="server" id="Alta1" style="margin-left: 30px;">

                            

                            <asp:Panel ID="Panel2" runat="server" Width="700px" CssClass="margencitotop">

                                

                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="6" class="TituloGuia">Datos Generales</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:Label ID="Valor1" runat="server" Width="180px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label8" runat="server" Text="ID ACD:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Valor6" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label10" runat="server" Text="Supervisor:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:Label ID="Valor2" runat="server" Width="180px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label12" runat="server" Text="Calificación:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Valor7" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label18" runat="server" Text="Folio Llamada:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:Label ID="Valor4" runat="server" Width="180px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label20" runat="server" Text="Duracion:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Valor9" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                    <tr>
                                        <td class="auto-style12"></td>
                                        <td>
                                            <asp:Label ID="Label13" runat="server" Text="Fecha de Audio:"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:Label ID="Valor5" runat="server" Width="180px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label19" runat="server" Text="Fecha de Monitoreo:"></asp:Label>
                                        </td>
                                        <td class="auto-style3">
                                            <asp:Label ID="Valor10" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style5"></td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="TituloGuia">Areas de Oportunidad</td>
                                    </tr>
                                    <tr>

                                        <td colspan="6">
                                            <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" Height="40px" ReadOnly="True" TextMode="MultiLine" Width="100%" CssClass="textos"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="TituloGuia">Comentario Monitoreo</td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="auto-style5">
                                            <asp:TextBox ID="TextBox2" runat="server" BorderStyle="None" Height="40px" ReadOnly="True" TextMode="MultiLine" Width="100%" CssClass="textos"></asp:TextBox>
                                           
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="TituloGuia">Compromisos Agente</td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="auto-style5">
                                            <asp:TextBox ID="TextBox3" runat="server" BorderStyle="None" Height="40px" TextMode="MultiLine" Width="100%" CssClass="textos" ReadOnly="True"></asp:TextBox>
                                        </td>
                                    </tr>

                                </table>

                                <asp:Panel ID="Panel5" runat="server"></asp:Panel>
                            </asp:Panel>




                            <asp:Panel ID="Panel24" runat="server" Width="700px" CssClass="margencitobottom">
                                <table style="width: 100%">

                                    <tr>
                                        <td colspan="6" class="TituloGuia">Comentario Retroalimentación</td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="auto-style5">
                                            <asp:TextBox ID="TextBox4" runat="server" BorderStyle="None" Height="40px" TextMode="MultiLine" Width="100%" CssClass="textos" ReadOnly="True"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="TituloGuia">Comentario Supervisor</td>
                                    </tr>
                                    <tr>
                                        <td colspan="6" class="auto-style5">
                                            <asp:TextBox ID="TextBox6" runat="server" BorderStyle="None" Height="40px" TextMode="MultiLine" Width="100%" CssClass="textos"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>

                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>

                         <%--  <asp:Panel ID="Panel25" runat="server" style="display:none" Width="700px" CssClass="margencitobottom" Visible="false" >
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="6" style="display:none" class="TituloGuia">¿ Qué ocasionó que no realizarás el proceso correcto de HOLD? </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox51" style="display:none" runat="server" BorderStyle="None" Height="40px" TextMode="MultiLine" Width="100%" CssClass="textos"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox51" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>

                                </table>
                                 </asp:Panel>--%>


                                <%--  <asp:Panel ID="Panel26" runat="server" style="display:none" Width="700px" CssClass="margencitobottom" Visible="false">
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="6" class="TituloGuia">¿Solicitaste apoyo para atender esta llamada y a quién? </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox52" style="display:none" runat="server" BorderStyle="None" Height="40px" TextMode="MultiLine" Width="100%" CssClass="textos"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox52" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>

                                        </td>
                                    </tr>

                                </table>
                            </asp:Panel>--%>
                          

                        </div>

                        <br />

                        <div runat="server" id="Div1" style="margin-left: 30px;">
                            <asp:Panel ID="Panel4" runat="server" Width="700px" CssClass="margencitofull">
                                <table style="width: 100%">

                                    <tr>
                                        <td class="auto-style4"></td>
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text="Firma Supervisor:"></asp:Label>
                                            <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" AutoPostBack="True"></asp:TextBox>
                                            <asp:Image ID="Image2" runat="server" ImageAlign="Middle" ImageUrl="~/Images/Check-3-icon.png" Visible="False" Width="20px" />
                                            <asp:HiddenField ID="HiddenField1" runat="server" Value="0" />
                                        </td>
                                        <td class="auto-style2">&nbsp;</td>
                                        <td class="auto-style5"></td>
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
