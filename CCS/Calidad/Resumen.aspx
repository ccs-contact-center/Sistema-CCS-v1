<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Resumen.aspx.vb" Inherits="CCS.Resumen" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            border: 1.5px solid black;
            margin-left: -7px;
            border-radius: 5px 5px 5px 5px;
            -moz-border-radius: 5px 5px 5px 5px;
            -webkit-border: 5px 5px 5px 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="site_content">
        <div class="content">
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

            <h1>Resumen</h1>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Resumen Semanal"></asp:Label></h2>

                        <div runat="server" id="Generales" visible="True" style="padding-left: 25px;">
                            <asp:Panel ID="Panel2" runat="server" Width="900px" CssClass="auto-style2">
                                
                            </asp:Panel>
                        </div>


<br />

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

</asp:Content>
