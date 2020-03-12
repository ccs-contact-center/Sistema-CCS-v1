<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Administracion.aspx.vb" Inherits="CCS.EntregaSecundarias" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Src="~/Aspirante.ascx" TagPrefix="uc1" TagName="Aspirante" %>
<%@ Register Src="~/TroncoComun.ascx" TagPrefix="uc1" TagName="TroncoComun" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        
        .auto-style10 {
            width: 171px;
        }

        




        .auto-style17 {
            width: 170px;
        }



        .auto-style44 {
            text-align: center;
            width: 100%;
            height: 66px;
        }



        .auto-style72 {
            width: 168px;
        }

        .auto-style73 {
            width: 152px;
            text-align: right;
        }

        .auto-style74 {
            text-align: right;
            width: 129px;
        }

        .auto-style79 {
            width: 288px;
        }

        </style>

    <script id="grid" type="text/javascript">


        function On(GridView) {
            if (GridView != null) {
                GridView.originalBgColor = GridView.style.backgroundColor;
                GridView.style.backgroundColor = "#C00327";
                GridView.style.Color = "#FFFFFF";

            }
        }

        function Off(GridView) {
            if (GridView != null) {
                GridView.style.backgroundColor = GridView.originalBgColor;
            }
        }

    </script>

    <script type="text/javascript">
        $(window).bind("load", function () {
            var footer = $("#footer");
            var pos = footer.position();
            var height = $(window).height();
            height = height - pos.top;
            height = height - footer.height();
            if (height > 0) {
                footer.css({
                    'margin-top': height + 'px'
                });
            }
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="site_content">
        <div class="content">

            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

            <h1>Administración</h1>

            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>


                    <asp:Panel ID="Panel2" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Aspirantes"></asp:Label></h2>

                        <br />


                        <div style="overflow: auto; width: 888px; margin-left: 25px;">
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

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label2" runat="server" Text="Entrega"></asp:Label></h2>

                        <br />

                        <table style="width: 100%;" class="Buscador">

                            <tr>
                                <td class="auto-style74">Nombres:</td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="TextBox1" runat="server" Wrap="True" CssClass="textos" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                <td class="auto-style73">Apellido Paterno:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="textos" Wrap="True" Width="150px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                                <td class="auto-style72">Apellido Materno:</td>
                                <td class="auto-style79">
                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="textos" Wrap="True" Width="150px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox3" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator></td>
                            </tr>

                            <tr>
                                <td class="auto-style74">Curso:</td>
                                <td class="auto-style17">
                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="150px" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="DropDownList1" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style73">ID ACD:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox9" runat="server" CssClass="textos"  Width="140px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="TextBox9" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style72">Supervisor:</td>
                                <td class="auto-style79">
                                 <asp:DropDownList ID="DropDownList2" runat="server" Width="150px" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="DropDownList1" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1"></asp:RequiredFieldValidator>

                                </td>
                            </tr>

                                                      <tr>
                                <td class="auto-style74">&nbsp;</td>
                                <td class="auto-style17">
                                    &nbsp;</td>
                                <td class="auto-style73">Calificacion:</td>
                                <td class="auto-style10">
                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="textos"  Width="140px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox4" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1"></asp:RequiredFieldValidator>
                                </td>
                                <td class="auto-style72">&nbsp;</td>
                                <td class="auto-style79">
                                    &nbsp;</td>
                            </tr>


                        </table>


                        <table class="auto-style44">

     
                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center; margin-right: 25px;" Text="Limpiar" CssClass="Button" Height="22px" Width="85px" />
                                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Smaller" Style="text-align: center" Text="Guardar" ValidationGroup="Valida1" CssClass="Button" Height="22px" Width="85px" />
                                </td>
                            </tr>


                        </table>



                    </asp:Panel>



                </ContentTemplate>
            </asp:UpdatePanel>




            <br />

        </div>
    </div>

</asp:Content>
