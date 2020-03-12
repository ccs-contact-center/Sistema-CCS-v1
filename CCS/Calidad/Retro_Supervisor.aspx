<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Retro_Supervisor.aspx.vb" Inherits="CCS.Retro_Supervisor" EnableEventValidation="false"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        text-align: center;
        margin-left:23px;
        overflow:auto;
        width:95%;
    }
</style>
        <script id="grid" type="text/javascript" >
       
       
function On(GridView)
{
    if(GridView != null)
    {
       GridView.originalBgColor = GridView.style.backgroundColor;
       GridView.style.backgroundColor = "#C00327";
       GridView.style.Color = "#FFFFFF";

    }
}

function Off(GridView)
{
    if(GridView != null)
    {
        GridView.style.backgroundColor = GridView.originalBgColor;
    }
}

 </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" AsyncPostBackTimeout="36000"></asp:ToolkitScriptManager>

    <div id="site_content">
        <div class="content">

            <h1>Retroalimentación</h1>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2><asp:Label ID="Label1" runat="server" Text="Retroalimentaciones Pendientes"></asp:Label></h2>
                        <div runat="server" id="Alta1" class="auto-style2">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="150px" AutoPostBack="True">
                                <asp:ListItem Value="0">-Selecciona-</asp:ListItem>
                                <asp:ListItem Value="1">Coaching</asp:ListItem>
                                <asp:ListItem Value="2">FODA</asp:ListItem>
                            </asp:DropDownList>

                            <br />
                            <br />

                            <asp:GridView ID="GridView1" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="880px" CssClass="grids">
                                <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:GridView>

                            <br />


                        </div>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>




        </div>
    </div>


</asp:Content>
