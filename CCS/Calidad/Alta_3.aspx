<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Alta_3.aspx.vb" Inherits="CCS.Alta_3" %>

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

        .auto-style4 {
            width: 176px;
            vertical-align: top;
            text-align: right;
        }

        .auto-style5 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="site_content">
        <div class="content">

            <h1>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                Diseño de Guias</h1>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Ingresa Ponderaciones"></asp:Label></h2>




                        <div runat="server" id="Alta4" visible="true">
                            <table class="auto-style2">

                                <tr class="auto-style9">
                                    <td>&nbsp;</td>
                                    <td>
                                        <asp:Panel ID="Panel4" runat="server" Width="785px">
                                        </asp:Panel>
                                        <asp:HiddenField ID="HiddenField2" runat="server" />
                                    </td>
                                </tr>

                            </table>
                        </div>

                        <div runat="server" id="Alta5" visible="false">
                        </div>

                        <br />

                        <div class="textos">
                            <asp:HiddenField ID="HiddenField1" runat="server" Value="4" />
                            <asp:Button ID="Button1" runat="server" Text="Atras" CssClass="Button" Style="margin-right: 180px;" Height="25px" Width="85px" />
                            <asp:Button ID="Button2" runat="server" Text="Siguiente" CssClass="Button" Height="25px" Width="85px" ValidationGroup="Llenos" />
                        </div>

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
