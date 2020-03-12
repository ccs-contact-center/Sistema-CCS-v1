<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Asignacion_Analista.aspx.vb" Inherits="CCS.Asignacion_Analista" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
    .auto-style3 {
        width: 27px;
    }
        .auto-style5 {
            width: 15px;
        }
        .auto-style6 {
 
            width: 888px;
        }
        .auto-style7 {
            width: 102%;
        }
        .auto-style8 {
            width: 30px;
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
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <div id="site_content">
        <div class="content">

            <h1>Administración</h1>
            <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                <h2>
                            <asp:Label ID="Label1" runat="server" Text="Asignación de Analista"></asp:Label></h2>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>

                        <div style="margin-left: 4px; margin-right: 4px;" class="auto-style6">
                            <br />

                            <table class="auto-style7">
                                <tr>
                                    <td colspan="5" class="auto-style20"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style3"></td>
                                    <td class="auto-style2">Agentes Sin Asignar</td>
                                    <td class="auto-style8"></td>
                                    <td class="auto-style2">Analista:&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="300px">
                            </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida2"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3"></td>
                                    <td rowspan="3">

                                        <div style="overflow: auto; width: 400px; height: 150px;">

                                            <asp:GridView ID="GridView1" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="400px" CssClass="grids">
                                                <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                                <RowStyle Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="false" />
                                            </asp:GridView>
                                        </div>
                                    </td>
                                    <td class="auto-style8">
                                        <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/Images/Arrows-Right-Circular-icon.png" Width="20px" ValidationGroup="Valida2" />
                                    </td>
                                    <td rowspan="3">
                                        <div style="overflow: auto; width: 400px; height: 150px;">
                                            <asp:GridView ID="GridView2" runat="server" Font-Names="Arial" Font-Size="13px" HorizontalAlign="Center" Width="400px" CssClass="grids">
                                                <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                                <RowStyle Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="false" />
                                            </asp:GridView>
                                        </div>
                                    </td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class="auto-style3"></td>
                                    <td class="auto-style8">
                                        <asp:ImageButton ID="ImageButton2" runat="server" Height="20px" ImageUrl="~/Images/Arrows-Left-Circular-icon.png" ValidationGroup="Valida2" Width="20px" />
                                    </td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class="auto-style3"></td>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class="auto-style3"></td>
                                    <td></td>
                                    <td class="auto-style8"></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td colspan="5"></td>
                                </tr>
                            </table>

                            <br />



                        </div>

                    
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
        </div>
    </div>

</asp:Content>
