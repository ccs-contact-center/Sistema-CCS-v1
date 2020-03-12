<%@ Page Title="CCS" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Semaforo_IN.aspx.vb" Inherits="CCS.Semaforo" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            text-align: left;
        }

        .auto-style6 {
            width: 183px;
            text-align: right;
        }

        .auto-style8 {
            width: 231px;
            text-align: right;
        }

        .auto-style14 {
            width: 150px;
            text-align: right;
        }

        .auto-style16 {
            width: 141px;
            text-align: right;
        }

        .auto-style17 {
            width: 82px;
            text-align: right;
        }

        .auto-style18 {
            text-align: left;
            width: 200px;
        }

        .auto-style19 {
            text-align: left;
            width: 215px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div id="site_content">
        <div class="content">
            <h1>Semaforo Inbound</h1>
            <div class="center">


                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <h2>Semaforo Operativo</h2>

                        <table width="100%" class="textos">
                            <tr>
                                <td class="auto-style16">Campaña:</td>
                                <td class="auto-style18">
                                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="180px">
                                    </asp:DropDownList>
                                </td>

                                <td class="auto-style17">Skill:</td>
                                <td class="auto-style19">
                                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Width="180px">
                                    </asp:DropDownList>
                                </td>

                                <td class="auto-style14">Intervalo Actualización:</td>
                                <td class="auto-style2">
                                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" Width="100px">
                                        <asp:ListItem Value="10000">10 Segundos</asp:ListItem>
                                        <asp:ListItem Value="30000">30 Segundos</asp:ListItem>
                                        <asp:ListItem Value="60000">1 Minuto</asp:ListItem>
                                        <asp:ListItem Value="300000">5 Minutos</asp:ListItem>
                                        <asp:ListItem Value="1800000">30 Minutos</asp:ListItem>
                                        <asp:ListItem Value="3600000">1 Hora</asp:ListItem>
                                    </asp:DropDownList>
                                </td>

                            </tr>
                        </table>



                    </ContentTemplate>
                </asp:UpdatePanel>


                <br />


                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>


                        <asp:Timer ID="Timer1" runat="server" Interval="10000"></asp:Timer>


                        <h3>
                            <asp:Label ID="Label9" runat="server" Text="Actualización a las:"></asp:Label></h3>



                        <table width="90%" class="textos">
                            <tr>
                                <td class="auto-style8">
                                    <asp:Label ID="LNCO" runat="server" Text="Llamadas Recibidas:"></asp:Label>
                                </td>
                                <td class="TablaCentro">
                                    <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:Label ID="LPABA" runat="server" Text="% Abandono:"></asp:Label>
                                </td>
                                <td class="TablaCentro">
                                    <asp:Label ID="Label5" runat="server" Text="0"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">
                                    <asp:Label ID="LNCH" runat="server" Text="Llamadas Atendidas"></asp:Label>
                                </td>
                                <td class="TablaCentro">
                                    <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:Label ID="LPSLV" runat="server" Text="% Nivel de Servicio:"></asp:Label>
                                </td>
                                <td class="TablaCentro">
                                    <asp:Label ID="Label6" runat="server" Text="0"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">
                                    <asp:Label ID="LABA" runat="server" Text="Llamadas Abandonadas:"></asp:Label>
                                </td>
                                <td class="TablaCentro">
                                    <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:Label ID="LAHT" runat="server" Text="AHT:"></asp:Label>
                                </td>
                                <td class="TablaCentro">
                                    <asp:Label ID="Label7" runat="server" Text="0"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">
                                    <asp:Label ID="LNCHT" runat="server" Text="Llamadas Atendidas &lt;20'':"></asp:Label>
                                </td>
                                <td class="TablaCentro">
                                    <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:Label ID="LASA" runat="server" Text="ASA:"></asp:Label>
                                </td>
                                <td class="TablaCentro">
                                    <asp:Label ID="Label8" runat="server" Text="0"></asp:Label>
                                </td>
                            </tr>
                        </table>


                        <br>


                        <div class="chart1">
                            <div class="chart1">
                            <asp:Chart ID="Chart1" runat="server" Palette="Grayscale">
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1">
                                    </asp:ChartArea>
                                </ChartAreas>
                            </asp:Chart>
                            <asp:Chart ID="Chart2" runat="server">
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1">
                                    </asp:ChartArea>
                                </ChartAreas>
                            </asp:Chart>
                            <asp:Chart ID="Chart3" runat="server">
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1">
                                    </asp:ChartArea>
                                </ChartAreas>
                            </asp:Chart>
                        </div>
                        </div>


                        <br />
                        <h2>Detalle Intervalos</h2>

                        <div style="margin-left:5%;">
                        <asp:GridView ID="GridView1" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="880px" CssClass="grids">
                            <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                            <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:GridView>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>


            </div>
        </div>
    </div>
    </asp:Content>
