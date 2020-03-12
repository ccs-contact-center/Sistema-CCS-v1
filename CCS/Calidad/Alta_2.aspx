<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Alta_2.aspx.vb" Inherits="CCS.AltaSR" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 86%;
            margin-left: 120px;
            border-style: none;
            vertical-align:top;
        }

        td{
            vertical-align:top;
        }
        .auto-style4 {
            width: 176px;
            vertical-align: top;
            text-align: right;
        }
        .auto-style5 {
            text-align: right;
        }
        .auto-style7 {
            text-align: right;
            width: 215px;
        }
        .auto-style8 {
            width: 110px;
        }
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="site_content">
        <div class="content">

            <h1>
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
                Diseño de Guias</h1>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2><asp:Label ID="Label1" runat="server" Text="Selecciona Subrubros"></asp:Label></h2>

                    <div runat="server" id="Alta3" visible="true">
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style4"><asp:Label ID="Label6" runat="server" Text="Rubro:"></asp:Label></td>
                                    <td class="auto-style8"> <asp:DropDownList ID="DropDownList1" runat="server" Width="120px" CssClass="textos" AutoPostBack="True"></asp:DropDownList></td>
                                    <td class="auto-style7"><asp:Label ID="Label7" runat="server" Text="Subrubros:"></asp:Label></td><td>
                                        <div runat="server" ID="Contenedor1" style="Overflow:auto; width:400px; height: 300px;">

                                           </div>
                                    </td>
                                </tr>

                            </table>
                        </div>     

       <div runat="server" id="Alta4" visible="false">
           </div>

                        <br />

                        <div class="textos">
                            <asp:HiddenField ID="HiddenField1" runat="server" Value="3" />
                            <asp:Button ID="Button1" runat="server" Text="Atras" CssClass="Button" Style="margin-right: 180px;" Height="25px" Width="85px" />
                            <asp:Button ID="Button2" runat="server" Text="Siguiente" CssClass="Button" Height="25px" Width="85px" />
                        </div>

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

</asp:Content>
