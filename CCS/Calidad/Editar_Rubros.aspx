<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Editar_Rubros.aspx.vb" Inherits="CCS.Editar_Rubros" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <div id="site_content">
        <div class="content">

            <h1>Edicion de Guias</h1>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Quitar Rubros"></asp:Label></h2>

                        <div runat="server" id="Edicion1" visible="True" style="padding-left: 25px;">
                            <asp:Panel ID="Panel2" runat="server" Width="700px" CssClass="margencitotop"></asp:Panel>
                            <asp:Panel ID="Panel3" runat="server" Width="700px" CssClass="margencitobottom"></asp:Panel>
                        </div>

                        <br />

                        <div class="textos">
                            <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="Button" Height="25px" Width="80px" ValidationGroup="Llenos" />
                            <asp:HiddenField ID="HiddenField1" runat="server" />
                        </div>

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
