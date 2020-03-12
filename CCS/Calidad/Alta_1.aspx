<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Alta_1.aspx.vb" Inherits="CCS.Alta_Guias" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 86%;
            margin-left: 120px;
            border-style: none;
            vertical-align: top;
        }

        .auto-style3 {
            width: 149px;
            vertical-align: top;
        }

        td {
            vertical-align: top;
        }

        .auto-style9 {
            width: 120px;
            text-align: right;
        }
        .auto-style10 {
            width: 131px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>


    <div id="site_content">
        <div class="content">

            <h1>Diseño de Guias</h1>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Selecciona Campaña"></asp:Label></h2>

                        <div runat="server" id="Alta1">
                            <table class="auto-style2">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="Campaña:"></asp:Label></td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList1" runat="server" Width="180px" CssClass="textos"></asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text="Nombre de la Guia:"></asp:Label></td>
                                    <td>

    <script>
    function solonumeros(e) {
    var key, numeros, teclado, especiales, teclado_especial, i;
    key = event.keyCode || event.which;
                teclado = String.fromCharCode(key);
                numeros = ' 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz_-';
   				especiales = [8, 9, 37, 38, 39, 40, 46];
                shiif = [16, 17, 18];
    			teclado_especial = false;

                for ( i in especiales ) {
                    if ( key == especiales[i] && !shiif ) {
                        teclado_especial = true;
                        break;
                    }
                }
                if ( numeros.indexOf(teclado) == -1 && !teclado_especial ) {
                    return false;
                }
    }
</script>


                                        <asp:TextBox ID="TextBox1" runat="server" Width="180px" CssClass="textos" onpaste="return false" onkeypress="return solonumeros(event);"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </div>

                        <div runat="server" id="Alta2" visible="false">
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label4" runat="server" Text="Tipo de Ponderación:"></asp:Label></td>
                                    <td class="auto-style10">
                                        <asp:DropDownList ID="DropDownList2" runat="server" Width="120px" CssClass="textos">
                                            <asp:ListItem Value="0">-Selecciona-</asp:ListItem>
                                            <asp:ListItem Value="1">Estatica</asp:ListItem>
                                            <asp:ListItem Value="2">Dinámica</asp:ListItem>
                                        </asp:DropDownList> <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList2" ErrorMessage="*" ForeColor="Red" InitialValue="0" ValidationGroup="Valida1" Display="Dynamic"></asp:RequiredFieldValidator></td>
                                    <td class="auto-style9">
                                        <asp:Label ID="Label5" runat="server" Text="Rubros:"></asp:Label></td>
                                    <td>
                                        <asp:Panel ID="Panel2" runat="server" Width="400px">
                                        </asp:Panel>
                                    </td>
                                </tr>

                            </table>
                        </div>

                        <div runat="server" id="Alta3" visible="false">
                            </div>
                

                        <br />

                        <div class="textos">
                            <asp:HiddenField ID="HiddenField1" runat="server" Value="1" />
                            <asp:Button ID="Button1" runat="server" Text="Atras" CssClass="Button" Style="margin-right: 180px;" Height="25px" Width="85px" Visible="False" />
                            <asp:Button ID="Button2" runat="server" Text="Siguiente" CssClass="Button" Height="25px" Width="85px" ValidationGroup="Valida1" />
                        </div>

                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

</asp:Content>
