<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Nueva_Evaluacion.aspx.vb" Inherits="CCS.Nueva_Evaluacion" %>

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
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>


    <div id="site_content">
        <div class="content">

            <h1>Diseño de Evaluación</h1>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Nueva Evaluación"></asp:Label></h2>

                        <div runat="server" id="Alta1">
                            <table class="auto-style2">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="Tipo de Evaluacion:"></asp:Label></td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList1" runat="server" Width="180px" CssClass="textos">
                                            <asp:ListItem Value="0">-Selecciona-</asp:ListItem>
                                            <asp:ListItem Value="1">Nuevo Ingreso</asp:ListItem>
                                            <asp:ListItem Value="2">Habilidades Operativas</asp:ListItem>
                                            <asp:ListItem Value="3">Producto</asp:ListItem>
                                            <asp:ListItem Value="4">Secundaria</asp:ListItem>
                                            <asp:ListItem Value="5">Diagnostico</asp:ListItem>
                                            <asp:ListItem Value="6">Certificacion</asp:ListItem>
                                            <asp:ListItem Value="7">DNC</asp:ListItem>
                                            <asp:ListItem Value="8">Encuesta</asp:ListItem>
                                            <asp:ListItem Value="9">Especial</asp:ListItem>

                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text="Nombre de la Evaluacion:"></asp:Label></td>
                                    <td>
                                        <asp:TextBox ID="TextBox1" runat="server" Width="180px" CssClass="textos"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </div>


                        <div runat="server" id="Alta2" visible="false">
                            <table class="auto-style2">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text="Campaña:"></asp:Label></td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList2" runat="server" Width="140px" CssClass="textos">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList2" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label5" runat="server" Text="Número de Reactivos:"></asp:Label></td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList3" runat="server" CssClass="textos" Width="80px">
                                            <asp:ListItem Value="0">-</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                            <asp:ListItem Value="13">13</asp:ListItem>
                                            <asp:ListItem Value="14">14</asp:ListItem>
                                            <asp:ListItem Value="15">15</asp:ListItem>
                                            <asp:ListItem Value="16">16</asp:ListItem>
                                            <asp:ListItem Value="17">17</asp:ListItem>
                                            <asp:ListItem Value="18">18</asp:ListItem>
                                            <asp:ListItem Value="19">19</asp:ListItem>
                                            <asp:ListItem Value="20">20</asp:ListItem>

                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DropDownList3" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1" Display="Dynamic" InitialValue="0"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <asp:Label ID="Label6" runat="server" Text="Limite de Tiempo:"></asp:Label></td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList4" runat="server" Width="80px" CssClass="textos" AutoPostBack="True">
                                            <asp:ListItem Value="0">-</asp:ListItem>
                                            <asp:ListItem Value="1">SI</asp:ListItem>
                                            <asp:ListItem Value="2">NO</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList4" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label7" runat="server" Text="Minutos:"></asp:Label></td>
                                    <td>
                                        <asp:TextBox ID="TextBox2" runat="server" CssClass="textos" Width="80px" Enabled="False"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="TextBox2" MaximumValue="120" MinimumValue="1" Type="Integer" Enabled="false" ForeColor="Red" ValidationGroup="Valida1"></asp:RangeValidator>

                                    </td>
                                </tr>
                            </table>
                        </div>


                        <div id="evalu" runat="server" visible="false">


                            <div id="R1" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">1)
                                            <asp:TextBox ID="Pregunta1" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Pregunta1" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="RadioButtonList1" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label13" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox3" runat="server" Width="160px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label14" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox4" runat="server" Width="160px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label15" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox5" runat="server" Width="160px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label16" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox6" runat="server" Width="160px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label17" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox7" runat="server" Width="160px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox7" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>


                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>

                                </table>
                            </div>

                            <div id="R2" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">2)
                                            <asp:TextBox ID="Pregunta2" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="Pregunta2" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="RadioButtonList2" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label8" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox8" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="TextBox8" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label9" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox9" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="TextBox9" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label10" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox10" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="TextBox10" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label11" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox11" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="TextBox11" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label12" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox12" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="TextBox12" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R3" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">3)
                                            <asp:TextBox ID="Pregunta3" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="Pregunta3" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ControlToValidate="RadioButtonList3" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label18" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox13" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="TextBox13" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label19" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox14" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="TextBox14" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label20" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox15" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="TextBox15" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label21" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox16" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="TextBox16" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label22" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox17" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ControlToValidate="TextBox17" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R4" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">4)
                                            <asp:TextBox ID="Pregunta4" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator113" runat="server" ControlToValidate="Pregunta4" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator130" runat="server" ControlToValidate="RadioButtonList4" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label23" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox18" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="TextBox18" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label24" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox19" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="TextBox19" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label25" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox20" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="TextBox20" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label26" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox21" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ControlToValidate="TextBox21" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label27" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox22" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" ControlToValidate="TextBox22" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList4" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R5" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">5)
                                            <asp:TextBox ID="Pregunta5" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator114" runat="server" ControlToValidate="Pregunta5" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator131" runat="server" ControlToValidate="RadioButtonList5" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label28" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox23" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" ControlToValidate="TextBox23" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label29" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox24" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" ControlToValidate="TextBox24" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label30" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox25" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" ControlToValidate="TextBox25" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label31" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox26" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator36" runat="server" ControlToValidate="TextBox26" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label32" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox27" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator37" runat="server" ControlToValidate="TextBox27" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList5" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R6" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">6)
                                            <asp:TextBox ID="Pregunta6" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator115" runat="server" ControlToValidate="Pregunta6" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator132" runat="server" ControlToValidate="RadioButtonList6" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label33" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox28" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator38" runat="server" ControlToValidate="TextBox28" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label34" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox29" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator39" runat="server" ControlToValidate="TextBox29" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label35" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox30" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator40" runat="server" ControlToValidate="TextBox30" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label36" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox31" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator41" runat="server" ControlToValidate="TextBox31" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label37" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox32" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator42" runat="server" ControlToValidate="TextBox32" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList6" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R7" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">7)
                                            <asp:TextBox ID="Pregunta7" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator116" runat="server" ControlToValidate="Pregunta7" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator133" runat="server" ControlToValidate="RadioButtonList7" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label38" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox33" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator43" runat="server" ControlToValidate="TextBox33" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label39" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox34" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator44" runat="server" ControlToValidate="TextBox34" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label40" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox35" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator45" runat="server" ControlToValidate="TextBox35" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label41" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox36" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator46" runat="server" ControlToValidate="TextBox36" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label42" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox37" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator47" runat="server" ControlToValidate="TextBox37" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList7" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R8" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">8)
                                            <asp:TextBox ID="Pregunta8" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator117" runat="server" ControlToValidate="Pregunta8" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator134" runat="server" ControlToValidate="RadioButtonList8" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label43" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox38" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator48" runat="server" ControlToValidate="TextBox38" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label44" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox39" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator49" runat="server" ControlToValidate="TextBox39" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label45" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox40" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator50" runat="server" ControlToValidate="TextBox40" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label46" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox41" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator51" runat="server" ControlToValidate="TextBox41" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label47" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox42" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator52" runat="server" ControlToValidate="TextBox42" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList8" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R9" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">9)
                                            <asp:TextBox ID="Pregunta9" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator118" runat="server" ControlToValidate="Pregunta9" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator135" runat="server" ControlToValidate="RadioButtonList9" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label48" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox43" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator53" runat="server" ControlToValidate="TextBox43" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label49" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox44" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator54" runat="server" ControlToValidate="TextBox44" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label50" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox45" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator55" runat="server" ControlToValidate="TextBox45" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label51" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox46" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator56" runat="server" ControlToValidate="TextBox46" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label52" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox47" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator57" runat="server" ControlToValidate="TextBox47" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList9" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R10" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">10)
                                            <asp:TextBox ID="Pregunta10" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator119" runat="server" ControlToValidate="Pregunta10" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator136" runat="server" ControlToValidate="RadioButtonList10" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label53" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox48" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator58" runat="server" ControlToValidate="TextBox48" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label54" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox49" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator59" runat="server" ControlToValidate="TextBox49" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label55" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox50" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator60" runat="server" ControlToValidate="TextBox50" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label56" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox51" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator61" runat="server" ControlToValidate="TextBox51" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label57" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox52" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator62" runat="server" ControlToValidate="TextBox52" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList10" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R11" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">11)
                                            <asp:TextBox ID="Pregunta11" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator120" runat="server" ControlToValidate="Pregunta11" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator137" runat="server" ControlToValidate="RadioButtonList11" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label58" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox53" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator63" runat="server" ControlToValidate="TextBox53" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label59" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox54" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator64" runat="server" ControlToValidate="TextBox54" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label60" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox55" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator65" runat="server" ControlToValidate="TextBox55" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label61" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox56" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator66" runat="server" ControlToValidate="TextBox56" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label62" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox57" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator67" runat="server" ControlToValidate="TextBox57" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList11" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R12" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">12)
                                            <asp:TextBox ID="Pregunta12" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator121" runat="server" ControlToValidate="Pregunta12" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator138" runat="server" ControlToValidate="RadioButtonList12" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label63" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox58" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator68" runat="server" ControlToValidate="TextBox58" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label64" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox59" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator69" runat="server" ControlToValidate="TextBox59" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label65" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox60" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator70" runat="server" ControlToValidate="TextBox60" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label66" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox61" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator71" runat="server" ControlToValidate="TextBox61" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label67" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox62" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator72" runat="server" ControlToValidate="TextBox62" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList12" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R13" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">13)
                                            <asp:TextBox ID="Pregunta13" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator122" runat="server" ControlToValidate="Pregunta13" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator139" runat="server" ControlToValidate="RadioButtonList13" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label68" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox63" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator73" runat="server" ControlToValidate="TextBox63" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label69" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox64" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator74" runat="server" ControlToValidate="TextBox64" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label70" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox65" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator75" runat="server" ControlToValidate="TextBox65" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label71" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox66" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator76" runat="server" ControlToValidate="TextBox66" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label72" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox67" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator77" runat="server" ControlToValidate="TextBox67" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList13" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R14" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">14)
                                            <asp:TextBox ID="Pregunta14" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator123" runat="server" ControlToValidate="Pregunta14" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator140" runat="server" ControlToValidate="RadioButtonList14" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label73" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox68" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator78" runat="server" ControlToValidate="TextBox68" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label74" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox69" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator79" runat="server" ControlToValidate="TextBox69" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label75" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox70" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator80" runat="server" ControlToValidate="TextBox70" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label76" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox71" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator81" runat="server" ControlToValidate="TextBox71" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label77" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox72" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator82" runat="server" ControlToValidate="TextBox72" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList14" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R15" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">15)
                                            <asp:TextBox ID="Pregunta15" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator124" runat="server" ControlToValidate="Pregunta15" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator141" runat="server" ControlToValidate="RadioButtonList15" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label78" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox73" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator83" runat="server" ControlToValidate="TextBox73" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label79" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox74" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator84" runat="server" ControlToValidate="TextBox74" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label80" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox75" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator85" runat="server" ControlToValidate="TextBox75" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label81" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox76" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator86" runat="server" ControlToValidate="TextBox76" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label82" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox77" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator87" runat="server" ControlToValidate="TextBox77" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList15" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R16" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">16)
                                            <asp:TextBox ID="Pregunta16" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator125" runat="server" ControlToValidate="Pregunta16" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator142" runat="server" ControlToValidate="RadioButtonList16" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label83" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox78" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator88" runat="server" ControlToValidate="TextBox78" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label84" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox79" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator89" runat="server" ControlToValidate="TextBox79" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label85" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox80" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator90" runat="server" ControlToValidate="TextBox80" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label86" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox81" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator91" runat="server" ControlToValidate="TextBox81" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label87" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox82" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator92" runat="server" ControlToValidate="TextBox82" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList16" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R17" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">17)
                                            <asp:TextBox ID="Pregunta17" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator126" runat="server" ControlToValidate="Pregunta17" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator143" runat="server" ControlToValidate="RadioButtonList17" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label88" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox83" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator93" runat="server" ControlToValidate="TextBox83" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label89" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox84" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator94" runat="server" ControlToValidate="TextBox84" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label90" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox85" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator95" runat="server" ControlToValidate="TextBox85" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label91" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox86" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator96" runat="server" ControlToValidate="TextBox86" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label92" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox87" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator97" runat="server" ControlToValidate="TextBox87" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList17" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R18" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">18)
                                            <asp:TextBox ID="Pregunta18" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator127" runat="server" ControlToValidate="Pregunta18" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator144" runat="server" ControlToValidate="RadioButtonList18" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label93" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox88" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator98" runat="server" ControlToValidate="TextBox88" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label94" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox89" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator99" runat="server" ControlToValidate="TextBox89" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label95" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox90" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator100" runat="server" ControlToValidate="TextBox90" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label96" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox91" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator101" runat="server" ControlToValidate="TextBox91" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label97" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox92" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator102" runat="server" ControlToValidate="TextBox92" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList18" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R19" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">19)
                                            <asp:TextBox ID="Pregunta19" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator128" runat="server" ControlToValidate="Pregunta19" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator145" runat="server" ControlToValidate="RadioButtonList19" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label98" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox93" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator103" runat="server" ControlToValidate="TextBox93" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label99" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox94" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator104" runat="server" ControlToValidate="TextBox94" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label100" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox95" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator105" runat="server" ControlToValidate="TextBox95" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label101" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox96" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator106" runat="server" ControlToValidate="TextBox96" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label102" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox97" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator107" runat="server" ControlToValidate="TextBox97" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList19" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <div id="R20" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">20)
                                            <asp:TextBox ID="Pregunta20" runat="server" Width="486px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator129" runat="server" ControlToValidate="Pregunta20" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator146" runat="server" ControlToValidate="RadioButtonList20" Display="Dynamic" ErrorMessage="Selecciona la respuesta correcta!" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label103" runat="server" Text="A) "></asp:Label><asp:TextBox ID="TextBox98" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator108" runat="server" ControlToValidate="TextBox98" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label104" runat="server" Text="B) "></asp:Label><asp:TextBox ID="TextBox99" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator109" runat="server" ControlToValidate="TextBox99" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label105" runat="server" Text="C) "></asp:Label><asp:TextBox ID="TextBox100" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator110" runat="server" ControlToValidate="TextBox100" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label106" runat="server" Text="D) "></asp:Label><asp:TextBox ID="TextBox101" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator111" runat="server" ControlToValidate="TextBox101" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:Label ID="Label107" runat="server" Text="E) "></asp:Label><asp:TextBox ID="TextBox102" runat="server" Width="160px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator112" runat="server" ControlToValidate="TextBox102" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                        </td>

                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList20" runat="server" RepeatDirection="Horizontal" Width="931px" Style="text-align: center; width: 100%">
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                                <asp:ListItem>E</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                        <asp:RadioButton ID="RadioButton100" runat="server" />
                                    </tr>


                                </table>


                            </div>


                        </div>

                        <div id="preview" runat="server" visible="false">


                            <div id="PV1" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">1)
                                            <asp:Label ID="Label108" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton101" runat="server" GroupName="P1" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton102" runat="server" GroupName="P1" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton103" runat="server" GroupName="P1" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton104" runat="server" GroupName="P1" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton105" runat="server" GroupName="P1" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>

                            <div id="PV2" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">2)
                                            <asp:Label ID="Label109" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton106" runat="server" GroupName="P2" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton107" runat="server" GroupName="P2" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton108" runat="server" GroupName="P2" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton109" runat="server" GroupName="P2" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton110" runat="server" GroupName="P2" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>

                            <div id="PV3" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">3)
                                            <asp:Label ID="Label110" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton111" runat="server" GroupName="P3" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton112" runat="server" GroupName="P3" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton113" runat="server" GroupName="P3" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton114" runat="server" GroupName="P3" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton115" runat="server" GroupName="P3" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>

                            <div id="PV4" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">4)
                                            <asp:Label ID="Label111" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton116" runat="server" GroupName="P4" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton117" runat="server" GroupName="P4" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton118" runat="server" GroupName="P4" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton119" runat="server" GroupName="P4" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton120" runat="server" GroupName="P4" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV5" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">5)
                                            <asp:Label ID="Label112" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton121" runat="server" GroupName="P5" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton122" runat="server" GroupName="P5" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton123" runat="server" GroupName="P5" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton124" runat="server" GroupName="P5" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton125" runat="server" GroupName="P5" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV6" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">6)
                                            <asp:Label ID="Label113" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton126" runat="server" GroupName="P6" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton127" runat="server" GroupName="P6" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton128" runat="server" GroupName="P6" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton129" runat="server" GroupName="P6" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton130" runat="server" GroupName="P6" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV7" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">7)
                                            <asp:Label ID="Label114" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton131" runat="server" GroupName="P7" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton132" runat="server" GroupName="P7" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton133" runat="server" GroupName="P7" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton134" runat="server" GroupName="P7" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton135" runat="server" GroupName="P7" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV8" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">8)
                                            <asp:Label ID="Label115" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton136" runat="server" GroupName="P8" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton137" runat="server" GroupName="P8" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton138" runat="server" GroupName="P8" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton139" runat="server" GroupName="P8" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton140" runat="server" GroupName="P8" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV9" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">9)
                                            <asp:Label ID="Label116" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton141" runat="server" GroupName="P9" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton142" runat="server" GroupName="P9" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton143" runat="server" GroupName="P9" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton144" runat="server" GroupName="P9" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton145" runat="server" GroupName="P9" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV10" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">10)
                                            <asp:Label ID="Label117" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton146" runat="server" GroupName="P10" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton147" runat="server" GroupName="P10" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton148" runat="server" GroupName="P10" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton149" runat="server" GroupName="P10" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton150" runat="server" GroupName="P10" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV11" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">11)
                                            <asp:Label ID="Label118" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton151" runat="server" GroupName="P11" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton152" runat="server" GroupName="P11" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton153" runat="server" GroupName="P11" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton154" runat="server" GroupName="P11" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton155" runat="server" GroupName="P11" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV12" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">12)
                                            <asp:Label ID="Label119" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton156" runat="server" GroupName="P12" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton157" runat="server" GroupName="P12" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton158" runat="server" GroupName="P12" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton159" runat="server" GroupName="P12" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton160" runat="server" GroupName="P12" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV13" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">13)
                                            <asp:Label ID="Label120" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton161" runat="server" GroupName="P13" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton162" runat="server" GroupName="P13" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton163" runat="server" GroupName="P13" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton164" runat="server" GroupName="P13" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton165" runat="server" GroupName="P13" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV14" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">14)
                                            <asp:Label ID="Label121" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton166" runat="server" GroupName="P14" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton167" runat="server" GroupName="P14" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton168" runat="server" GroupName="P14" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton169" runat="server" GroupName="P14" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton170" runat="server" GroupName="P14" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV15" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">15)
                                            <asp:Label ID="Label122" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton171" runat="server" GroupName="P15" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton172" runat="server" GroupName="P15" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton173" runat="server" GroupName="P15" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton174" runat="server" GroupName="P15" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton175" runat="server" GroupName="P15" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV16" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">16)
                                            <asp:Label ID="Label123" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton176" runat="server" GroupName="P16" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton177" runat="server" GroupName="P16" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton178" runat="server" GroupName="P16" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton179" runat="server" GroupName="P16" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton180" runat="server" GroupName="P16" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV17" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">17)
                                            <asp:Label ID="Label124" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton181" runat="server" GroupName="P17" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton182" runat="server" GroupName="P17" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton183" runat="server" GroupName="P17" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton184" runat="server" GroupName="P17" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton185" runat="server" GroupName="P17" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV18" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">18)
                                            <asp:Label ID="Label125" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton186" runat="server" GroupName="P18" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton187" runat="server" GroupName="P18" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton188" runat="server" GroupName="P18" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton189" runat="server" GroupName="P18" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton190" runat="server" GroupName="P18" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV19" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">19)
                                            <asp:Label ID="Label126" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton191" runat="server" GroupName="P19" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton192" runat="server" GroupName="P19" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton193" runat="server" GroupName="P19" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton194" runat="server" GroupName="P19" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton195" runat="server" GroupName="P19" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>
                            <div id="PV20" runat="server" visible="false">
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">20)
                                            <asp:Label ID="Label127" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton196" runat="server" GroupName="P20" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton197" runat="server" GroupName="P20" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton198" runat="server" GroupName="P20" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButton199" runat="server" GroupName="P20" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>
                                        <td class="TablaCentro">
                                            <asp:RadioButton ID="RadioButtonList200" runat="server" GroupName="P20" CssClass="radioButtonLabel" Enabled="False" />
                                        </td>

                                    </tr>


                                </table>
                            </div>


                        </div>


                        <div class="textos">
                            <br />
                            <asp:HiddenField ID="HiddenField1" runat="server" Value="1" />
                            <asp:Button ID="Button1" runat="server" Text="Atras" CssClass="Button" Style="margin-right: 180px;" Height="25px" Width="85px" Visible="False" />
                            <asp:Button ID="Button2" runat="server" Text="Siguiente" CssClass="Button" Height="25px" Width="85px" ValidationGroup="Valida1" />
                        </div>

                    </asp:Panel>




                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

</asp:Content>
