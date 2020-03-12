<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Reportes.aspx.vb" Inherits="CCS.Reportes" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>



<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 700px;
        }
        .auto-style5 {
            width: 109px;
        }
        .auto-style6 {
            width: 221px;
        }
        .auto-style7 {
            width: 79px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="site_content">
        <div class="content">   

  

            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" AsyncPostBackTimeout="36000"></asp:ToolkitScriptManager>

            <h1>Reportes</h1>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div style="margin-left:14%;" class="auto-style4">
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" CssClass="textos" Text="Reporte:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="137px" AutoPostBack="True" CssClass="textos"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red" InitialValue="0" Style="font-size: xx-small" ValidationGroup="ValidaReporte"></asp:RequiredFieldValidator>
                                </td>
                                <td></td>
                                <td class="auto-style5"></td>
                                <td></td>
                                <td class="auto-style7"></td>
                                <td class="auto-style6"></td>
                            </tr>

                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class="auto-style5"></td>
                                <td></td>
                                <td class="auto-style7"></td>
                                <td class="auto-style6"></td>
                            </tr>

                            <tr runat="server" id="UNO"> 
                                <td>
                                    <asp:Label ID="Label3" runat="server" CssClass="textos" Text="Desde:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" Height="15px" Width="130px" Style="text-align: center" CssClass="textos" Font-Size="14px"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender3" runat="server" Enabled="True" PopupButtonID="ImageButton3" TargetControlID="TextBox1" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton3" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" Style="font-size: xx-small" ValidationGroup="ValidaReporte"></asp:RequiredFieldValidator>
                                </td>
                                <td></td>
                                <td class="auto-style5">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                                                <td class="auto-style7">
                                                                    <asp:Label ID="Label4" runat="server" CssClass="textos" Text="Hasta:"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:TextBox ID="TextBox2" runat="server" Height="15px" Width="130px" Style="text-align: center" CssClass="textos" Font-Size="14px"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender4" runat="server" Enabled="True" PopupButtonID="ImageButton4" TargetControlID="TextBox2" Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton4" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" Style="font-size: xx-small" ValidationGroup="ValidaReporte"></asp:RequiredFieldValidator>
                                </td>
                            </tr>


                            <tr runat="server" id="DOS"> 
                                <td>
                                    <asp:Label ID="Label5" runat="server" CssClass="textos" Text="Campaña:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" CssClass="textos" Width="134px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList2" ErrorMessage="*" ForeColor="Red" Style="font-size: xx-small" ValidationGroup="ValidaReporte" InitialValue="0"></asp:RequiredFieldValidator>
                                    <asp:ImageButton ID="ImageButton6" runat="server" Height="18px" ImageAlign="Middle" ImageUrl="~/Images/database-icon.png" Visible="False" Width="18px" />
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style5">
                                    &nbsp;</td>
                                <td></td>
                                <td class="auto-style7">
                                    <asp:Label ID="Label1" runat="server" CssClass="textos" Text="Guia:"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" CssClass="textos" Width="134px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DropDownList3" ErrorMessage="*" ForeColor="Red" InitialValue="0" Style="font-size: xx-small" ValidationGroup="ValidaReporte"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

          
                            <tr runat="server" id="CUATRO">
                                <td>
                                    <asp:Label ID="Label7" runat="server" CssClass="textos" Text="Motivos AHT:"></asp:Label>
                                </td>
                                <td colspan="6">
                                    <asp:TextBox ID="TextBox3" runat="server" Height="48px" TextMode="MultiLine" Width="563px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red" Style="font-size: xx-small" ValidationGroup="ValidaReporte"></asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="6"></td>

                            </tr>

                        </table>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>

            <div class="TablaCentro"><asp:Button ID="Button1" runat="server" Text="Ejecutar" ValidationGroup="ValidaReporte" CssClass="Button" Height="22px" Width="85px" /></div>

                      
  
            <br />

            <div class="contenedor">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" ProcessingMode="Remote" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="950px" Style="text-align: center" Visible="False" PageCountMode="Actual">
                    <ServerReport ReportPath="/Calidad/ABC" ReportServerUrl="http://10.0.0.40/reportss" />
                </rsweb:ReportViewer>
            </div>
            
            <br />
            <br />





        </div>
    </div>
</asp:Content>
