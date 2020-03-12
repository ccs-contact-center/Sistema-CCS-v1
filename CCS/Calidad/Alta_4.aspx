<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Alta_4.aspx.vb" Inherits="CCS.Alta_4" %>

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
                            <asp:Label ID="Label1" runat="server" Text="Selecciona Rubros Adicionales"></asp:Label></h2>

                        <div runat="server" id="Alta5" visible="true" style="padding-left: 120px;">
                            <asp:Panel ID="Panel5" runat="server" Width="700px"></asp:Panel>
                        </div>
                        <div runat="server" id="Alta6" visible="false" style="padding-left: 120px;">
                            <asp:Panel ID="Panel6" runat="server" Width="700px"></asp:Panel>
                        </div>
                        <div runat="server" id="Alta7" visible="false" style="padding-left: 120px;">
                            <asp:Panel ID="Panel7" runat="server" Width="700px"></asp:Panel>
                        </div>



                        <br />

                        <div class="textos">
                            <asp:HiddenField ID="HiddenField1" runat="server" Value="5" />
                            <asp:Button ID="Button1" runat="server" Text="Atras" CssClass="Button" Style="margin-right: 180px;" Height="25px" Width="85px" />
                            <asp:Button ID="Button2" runat="server" Text="Siguiente" CssClass="Button" Height="25px" Width="85px" ValidationGroup="Llenos" />
                        </div>

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
