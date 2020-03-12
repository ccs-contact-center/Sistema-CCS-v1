<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Ficha_Implementacion.aspx.vb" Inherits="CCS.Implementacion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../CSS/ValidationEngine.css" rel="stylesheet" type="text/css" />
    
    <script src="../JS/jquery.validationEngine-en.js"></script>
    <script src="../JS/jquery.validationEngine.js"></script>
    <script id="grid" type="text/javascript">    

        function pageLoad() {

            jQuery("#form1").validationEngine();

            $(document).ready(function () {
                $('.myCheckBoxList').each(function () {
                    $('.myCheckBoxList input').addClass("validate[minCheckbox[1]]");
                    $('[id*=chkFruits2]').attr("name", "LoanType");
                    $('[id*=CheckBox1]').attr("name", "Prueba");

                })

            });
        }




    </script>





    <script id="grid2" type="text/javascript">    


        function valida() {

            //alert($("#form1").validationEngine('validate'));

            if ($("#form1").validationEngine('validate') == false) {
                return false;
            }
            else {
                return true;
            }



        }


    </script>

    <script id="grid3" type="text/javascript">

         function myValidationFunction() {
             var TextBox15 = $.trim($("#TextBox15").val());
             var TextBox16 = $.trim($("#TextBox16").val());
             var TextBox17 = $.trim($("#TextBox17").val());
             var TextBox18 = $.trim($("#TextBox18").val());
             var TextBox19 = $.trim($("#TextBox19").val());

             if (TextBox15.length == null && TextBox16.length == null && TextBox17.length == null && TextBox18.length == null && TextBox19.length == null) {
                 return "input1 is required";
             }


         }

    </script>

    <script id="grid4" type="text/javascript"> 

         function myValidationFunction1() {
             var TextBox87 = $.trim($("#TextBox87").val());
             var TextBox88 = $.trim($("#TextBox88").val());
             var TextBox89 = $.trim($("#TextBox89").val());
             var TextBox90 = $.trim($("#TextBox90").val());
             var TextBox91 = $.trim($("#TextBox91").val());
             var TextBox92 = $.trim($("#TextBox92").val());
             var TextBox93 = $.trim($("#TextBox93").val());

             if (TextBox87.length == null && TextBox88.length == null && TextBox89.length == null && TextBox90.length == null && TextBox91.length == null && TextBox92.length == null && TextBox93.length == null) {
                 return "input1 is required";
             }


         }


    </script>
    <script id="grid5" type="text/javascript">

         function myValidationFunction2() {
             var TextBox168 = $.trim($("#TextBox168").val());
             var TextBox138 = $.trim($("#TextBox138").val());
             var TextBox139 = $.trim($("#TextBox139").val());
             var TextBox140 = $.trim($("#TextBox140").val());
             var TextBox141 = $.trim($("#TextBox141").val());
             var TextBox142 = $.trim($("#TextBox142").val());
             var TextBox169 = $.trim($("#TextBox143").val());

             if (TextBox168.length == null && TextBox138.length == null && TextBox139.length == null && TextBox140.length == null && TextBox141.length == null && TextBox142.length == null && TextBox169.length == null) {
                 return "input1 is required";
             }


         }
    </script>



    <style type="text/css">
        .auto-style2 {
            font-size: small;
            font-weight: bold;
        }

        .auto-style3 {
            height: 46px;
        }

        .auto-style7 {
            width: 130px;
        }

        .auto-style9 {
            width: 100%;
        }

        .auto-style10 {
            height: 27px;
        }

        .auto-style12 {
            text-align: center;
            background-color: #C00327;
            color: white;
            height: 15px;
        }

        .auto-style13 {
            height: 21px;
        }

        .auto-style14 {
            height: 29px;
        }

        .auto-style15 {
            height: 26px;
        }

        .auto-style16 {
            height: 25px;
        }

        .auto-style17 {
            width: 9px;
        }

        .auto-style18 {
            height: 26px;
            width: 9px;
        }


        .auto-style20 {
            text-align: center;
            background-color: #C00327;
            color: white;
            height: 18px;
        }
        
         .auto-style21 {
            height: 58px;
        }
        .auto-style22 {
            text-align: center;
            background-color: #C00327;
            color: white;
            height: 21px;
        }
        .auto-style23 {
            height: 24px;
        }
        .auto-style24 {
            width: 629px;
        }
        .auto-style36 {
            width: 96px;
        }
        .auto-style37 {
            margin-bottom: 0;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    &nbsp;&nbsp;&nbsp;
    <div id="site_content">

        <div class="content">
            <h1>Implementación</h1>
            <div class="center">


                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="Panel6" runat="server" CssClass="Panel">
                            <h2>Ficha de  Implementación</h2>
                            <br />
                            <div class="TablaCentro" style="margin-top: -30px;">
                                <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BackColor="#545454" BorderStyle="None" BorderWidth="0px" ForeColor="White" ItemWrap="True" RenderingMode="Table" Width="100%" BorderColor="#545454" OnClick="if (valida() == true) {return true;} else {return false;}" Height="28px">
                                    <Items>
                                        <asp:MenuItem Text="General" Value="0"></asp:MenuItem>
                                        <asp:MenuItem Text="Calidad" Value="1"></asp:MenuItem>
                                        <asp:MenuItem Text="Operación" Value="2"></asp:MenuItem>
                                        <asp:MenuItem Text="RRHH" Value="3"></asp:MenuItem>
                                        <asp:MenuItem Text="TI" Value="4"></asp:MenuItem>
                                        <asp:MenuItem Text="Capacitación" Value="5"></asp:MenuItem>
                                        <asp:MenuItem Text="Command Center" Value="6"></asp:MenuItem>
                                        <asp:MenuItem Text="Facturación" Value="7"></asp:MenuItem>
                                    </Items>
                                </asp:Menu>

                                <!--*************************************************************GENERAL***************************************************-->
                                <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">

                                    <asp:View ID="View1" runat="server">
                                        <br />
                                        <div runat="server" id="Generales" visible="True" style="padding-left: 25px;">
                                            <asp:Panel ID="Panel1" runat="server" Width="700px" CssClass="margencitofull">
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td colspan="6" class="auto-style12">Datos Generales del Servicio</td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label1" runat="server" Text="Nombre Comercial del Cliente:"></asp:Label>
                                                        </td>

                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox1" runat="server" Width="300px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label3" runat="server" Text="Tipo de Servicio:"></asp:Label>
                                                        </td>

                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox2" runat="server" Width="300px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label2" runat="server" Text="Ubicación (Contact Center):"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox4" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox></td>

                                                        <td>
                                                            <asp:Label ID="Label4" runat="server" Text="Interna:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList1" runat="server" Width="50px" CssClass="validate[required]">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem Value="1">SI</asp:ListItem>
                                                                <asp:ListItem Value="2">NO</asp:ListItem>
                                                            </asp:DropDownList></td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label5" runat="server" Text="Fecha de Implementación:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox3" runat="server" Width="127px" CssClass="textos validate[required]"></asp:TextBox>
                                                            <asp:CalendarExtender ID="TextBox3_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox3" PopupButtonID="ImageButton1" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                                        </td>

                                                        <td>
                                                            <asp:Label ID="Label6" runat="server" Text="Duración (Dias):"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox5" runat="server" Width="72px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label7" runat="server" Text="Fecha de Inicio:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox6" runat="server" Width="127px" CssClass="textos validate[required] "></asp:TextBox>
                                                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" Enabled="True" TargetControlID="TextBox6" PopupButtonID="ImageButton2" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton2" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                                        </td>

                                                        <td>
                                                            <asp:Label ID="Label8" runat="server" Text="Duración (Dias):"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox7" runat="server" Width="72px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td class="auto-style3"></td>
                                                        <td colspan="2" class="auto-style3">
                                                            <asp:Label ID="Label9" runat="server" Text="Dias de Servicio"></asp:Label>
                                                        </td>

                                                        <td colspan="2" class="auto-style3 ">
                                                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Lunes" CssClass="auto-style2" AutoPostBack="True" />
                                                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Martes" CssClass="auto-style2" AutoPostBack="True" />
                                                            <asp:CheckBox ID="CheckBox3" runat="server" Text="Miercoles" CssClass="auto-style2" AutoPostBack="True" />
                                                            <asp:CheckBox ID="CheckBox4" runat="server" Text="Jueves" CssClass="auto-style2" AutoPostBack="True" />
                                                            <asp:CheckBox ID="CheckBox6" runat="server" Text="Viernes" CssClass="auto-style2" AutoPostBack="True" />
                                                            <asp:CheckBox ID="CheckBox7" runat="server" Text="Sábado" CssClass="auto-style2" AutoPostBack="True" />
                                                            <asp:CheckBox ID="CheckBox5" runat="server" Text="Domingo" CssClass="auto-style2" AutoPostBack="True" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label10" runat="server" Text="Ventana de Servicio:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">L-V:
                                                            <asp:DropDownList ID="DropDownList2" runat="server" Width="50px" >

                                                                <asp:ListItem Value="">-</asp:ListItem>

                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>00:30</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>01:30</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>02:30</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>03:30</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>04:30</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>05:30</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>06:30</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>07:30</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>08:30</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>09:30</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>10:30</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>11:30</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>12:30</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>13:30</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>14:30</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>15:30</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>16:30</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>17:30</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>18:30</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>19:30</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>20:30</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>21:30</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>22:30</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                                <asp:ListItem>23:30</asp:ListItem>
                                                            </asp:DropDownList>
                                                            <asp:DropDownList ID="DropDownList4" runat="server" Width="50px" >
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>00:30</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>01:30</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>02:30</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>03:30</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>04:30</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>05:30</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>06:30</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>07:30</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>08:30</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>09:30</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>10:30</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>11:30</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>12:30</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>13:30</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>14:30</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>15:30</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>16:30</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>17:30</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>18:30</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>19:30</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>20:30</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>21:30</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>22:30</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                                <asp:ListItem>23:30</asp:ListItem>
                                                            </asp:DropDownList>
                                                            &nbsp;S-D:
                                                         <asp:DropDownList ID="DropDownList3" runat="server" Width="50px">
                                                             <asp:ListItem Value="">-</asp:ListItem>
                                                             <asp:ListItem>00:00</asp:ListItem>
                                                             <asp:ListItem>00:30</asp:ListItem>
                                                             <asp:ListItem>01:00</asp:ListItem>
                                                             <asp:ListItem>01:30</asp:ListItem>
                                                             <asp:ListItem>02:00</asp:ListItem>
                                                             <asp:ListItem>02:30</asp:ListItem>
                                                             <asp:ListItem>03:00</asp:ListItem>
                                                             <asp:ListItem>03:30</asp:ListItem>
                                                             <asp:ListItem>04:00</asp:ListItem>
                                                             <asp:ListItem>04:30</asp:ListItem>
                                                             <asp:ListItem>05:00</asp:ListItem>
                                                             <asp:ListItem>05:30</asp:ListItem>
                                                             <asp:ListItem>06:00</asp:ListItem>
                                                             <asp:ListItem>06:30</asp:ListItem>
                                                             <asp:ListItem>07:00</asp:ListItem>
                                                             <asp:ListItem>07:30</asp:ListItem>
                                                             <asp:ListItem>08:00</asp:ListItem>
                                                             <asp:ListItem>08:30</asp:ListItem>
                                                             <asp:ListItem>09:00</asp:ListItem>
                                                             <asp:ListItem>09:30</asp:ListItem>
                                                             <asp:ListItem>10:00</asp:ListItem>
                                                             <asp:ListItem>10:30</asp:ListItem>
                                                             <asp:ListItem>11:00</asp:ListItem>
                                                             <asp:ListItem>11:30</asp:ListItem>
                                                             <asp:ListItem>12:00</asp:ListItem>
                                                             <asp:ListItem>12:30</asp:ListItem>
                                                             <asp:ListItem>13:00</asp:ListItem>
                                                             <asp:ListItem>13:30</asp:ListItem>
                                                             <asp:ListItem>14:00</asp:ListItem>
                                                             <asp:ListItem>14:30</asp:ListItem>
                                                             <asp:ListItem>15:00</asp:ListItem>
                                                             <asp:ListItem>15:30</asp:ListItem>
                                                             <asp:ListItem>16:00</asp:ListItem>
                                                             <asp:ListItem>16:30</asp:ListItem>
                                                             <asp:ListItem>17:00</asp:ListItem>
                                                             <asp:ListItem>17:30</asp:ListItem>
                                                             <asp:ListItem>18:00</asp:ListItem>
                                                             <asp:ListItem>18:30</asp:ListItem>
                                                             <asp:ListItem>19:00</asp:ListItem>
                                                             <asp:ListItem>19:30</asp:ListItem>
                                                             <asp:ListItem>20:00</asp:ListItem>
                                                             <asp:ListItem>20:30</asp:ListItem>
                                                             <asp:ListItem>21:00</asp:ListItem>
                                                             <asp:ListItem>21:30</asp:ListItem>
                                                             <asp:ListItem>22:00</asp:ListItem>
                                                             <asp:ListItem>22:30</asp:ListItem>
                                                             <asp:ListItem>23:00</asp:ListItem>
                                                             <asp:ListItem>23:30</asp:ListItem>
                                                         </asp:DropDownList>
                                                            <asp:DropDownList ID="DropDownList5" runat="server" Width="50px" >
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>00:30</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>01:30</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>02:30</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>03:30</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>04:30</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>05:30</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>06:30</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>07:30</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>08:30</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>09:30</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>10:30</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>11:30</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>12:30</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>13:30</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>14:30</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>15:30</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>16:30</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>17:30</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>18:30</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>19:30</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>20:30</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>21:30</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>22:30</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                                <asp:ListItem>23:30</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>



                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Responsable CCS de la Implementación</td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label11" runat="server" Text="Nombre:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox8" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox></td>

                                                        <td>
                                                            <asp:Label ID="Label12" runat="server" Text="Puesto:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox9" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label13" runat="server" Text="Teléfono:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox10" runat="server" Width="150px" CssClass="validate[required,custom[phone]] required="></asp:TextBox>


                                                        </td>

                                                        <td>
                                                            <asp:Label ID="Label18" runat="server" Text="e-mail:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox42" runat="server" Width="150px " CssClass="validate[required,custom[email]] required="></asp:TextBox>



                                                        </td>

                                                        <td></td>

                                                    </tr>

                                                    <tr>
                                                     <td></td>
                                                        <td>
                                                            <asp:Label ID="Label174" runat="server" Text="Extensión:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox1024" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>


                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Responsable CCS del Servicio</td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label14" runat="server" Text="Nombre:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox11" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox></td>

                                                        <td>
                                                            <asp:Label ID="Label15" runat="server" Text="Puesto:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox12" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label16" runat="server" Text="Teléfono:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox13" runat="server" Width="150px" CssClass="validate[required,custom[phone]] required="></asp:TextBox>

                                                        </td>

                                                        <td>
                                                            <asp:Label ID="Label17" runat="server" Text="e-mail:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox14" runat="server" Width="150px" CssClass="validate[required,custom[email]] required="></asp:TextBox>

                                                        </td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                         <td></td>
                                                        <td>
                                                            <asp:Label ID="Label175" runat="server" Text="Extensión:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox124" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>

                                                        </td>

                                                    </tr>

                                                </table>

                                                <table style="width: 100%;">
                                                    <tr>
                                                        <td colspan="7" class="TituloGuia">Contactos Cliente</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="TituloGuia"></td>
                                                        <td class="TituloGuia">Compañía</td>
                                                        <td class="TituloGuia">Nombre</td>
                                                        <td class="TituloGuia">Puesto</td>
                                                        <td class="TituloGuia">Teléfono</td>
                                                        <td class="TituloGuia">e-mail</td>
                                                        <td class="TituloGuia"></td>
                                                    </tr>

                                                    <tr>

                                                        <td class="auto-style14"></td>
                                                        <td class="auto-style14">
                                                            <asp:TextBox ID="TextBox15" runat="server" Width="100px" CssClass="validate[required,funcCall[myValidationFunction]]"></asp:TextBox></td>
                                                        <td class="auto-style14">
                                                            <asp:TextBox ID="TextBox16" runat="server" Width="100px" CssClass="validate[required,funcCall[myValidationFunction]]"></asp:TextBox></td>
                                                        <td class="auto-style14">
                                                            <asp:TextBox ID="TextBox17" runat="server" Width="100px" Height="21px" CssClass="validate[required,funcCall[myValidationFunction]]"></asp:TextBox></td>
                                                        <td class="auto-style14">
                                                            <asp:TextBox ID="TextBox18" runat="server" Width="100px" CssClass="validate[required,funcCall[myValidationFunction]]"></asp:TextBox></td>
                                                        <td class="auto-style14">
                                                            <asp:TextBox ID="TextBox19" runat="server" Width="100px" CssClass="validate[required,funcCall[myValidationFunction]]"></asp:TextBox></td>
                                                        <td class="auto-style14"></td>
                                                    </tr>
                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox20" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox21" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox22" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox23" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox24" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox25" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox26" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox27" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox28" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox29" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox30" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox31" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox32" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox33" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox34" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td></td>
                                                    </tr>
                                                    <tr id="tr4">
                                                        <td></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox35" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox36" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox37" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox38" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox39" runat="server" Width="100px"></asp:TextBox></td>
                                                        <td></td>
                                                    </tr>

                                                </table>

                                                <table class="auto-style9">
                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Descripción del Servicio</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="3" class="TituloGuia">Objetivo:</td>
                                                        <td colspan="3" class="TituloGuia">Resumen:</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="3">
                                                            <asp:TextBox ID="TextBox40" runat="server" Height="150px" Width="300px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox></td>
                                                        <td colspan="3">
                                                            <asp:TextBox ID="TextBox41" runat="server" Height="150px" Width="300px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox></td>
                                                    </tr>
                                                </table>
                                                <table>
                                                <tr>
                                                       <td colspan="7" class="TituloGuia">Minutas y Gantt</td>

                                                    </tr>
                                                   
                                              

                                                  <tr>
                                                             <td>
                                                                 <asp:Label ID="Label113" runat="server" Text="Minuta 1:"></asp:Label>
                                                             </td>
                                                             <td class="auto-style24">
                                                                 <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage30" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir21" runat="server" Text="Subir Archivo" ForeColor="#000066"/>

                                                                    <asp:Label ID="Label120" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir21" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>

                                                       <tr>
                                                             <td>
                                                                 <asp:Label ID="Label121" runat="server" Text="Minuta 2:"></asp:Label>
                                                             </td>
                                                             <td class="auto-style24">
                                                                 <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage31" runat="server" BorderColor="#999966" CssClass="auto-style37" />
                                                                    <asp:Button ID="btSubir22" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click91" Height="26px"/>

                                                                    <asp:Label ID="Label122" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir22" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>
                                                       <tr>
                                                             <td>
                                                                 <asp:Label ID="Label123" runat="server" Text="Minuta 3:"></asp:Label>
                                                             </td>
                                                             <td class="auto-style24">
                                                                 <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage32" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir23" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click92"/>

                                                                    <asp:Label ID="Label130" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir23" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>
                                                       <tr>
                                                             <td>
                                                                 <asp:Label ID="Label131" runat="server" Text="Minuta 4:"></asp:Label>
                                                             </td>
                                                             <td class="auto-style24">
                                                                 <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage33" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir24" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click93"/>

                                                                    <asp:Label ID="Label151" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir24" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>
                                                       <tr>
                                                             <td>
                                                                 <asp:Label ID="Label152" runat="server" Text="Minuta 5:"></asp:Label>
                                                             </td>
                                                             <td class="auto-style24">
                                                                 <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage34" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir25" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click94"/>

                                                                    <asp:Label ID="Label153" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir25" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>
                                                       <tr>
                                                             <td>
                                                                 <asp:Label ID="Label154" runat="server" Text="Minuta 6:"></asp:Label>
                                                             </td>
                                                             <td class="auto-style24">
                                                                 <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage35" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir26" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click95"/>

                                                                    <asp:Label ID="Label155" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir26" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>
                                                       <tr>
                                                             <td>
                                                                 <asp:Label ID="Label156" runat="server" Text="Minuta 7:"></asp:Label>
                                                             </td>
                                                             <td class="auto-style24">
                                                                 <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage36" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir27" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click96"/>

                                                                    <asp:Label ID="Label157" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir27" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>
                                                       <tr>
                                                             <td>
                                                                 <asp:Label ID="Label158" runat="server" Text="Gantt:"></asp:Label>
                                                             </td>
                                                             <td class="auto-style24">
                                                                 <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage37" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir28" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click97"/>

                                                                    <asp:Label ID="Label159" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir28" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>
                                                    
                                                  </table>











                                            </asp:Panel>


                                        </div>
                                    </asp:View>

                                    <!--*************************************************************CALIDA***************************************************-->
                                    <asp:View ID="View2" runat="server">
                                        <br />
                                        <div runat="server" id="Div1" visible="True" style="padding-left: 25px;">
                                            <asp:Panel ID="Panel2" runat="server" Width="750px" CssClass="margencitofull">
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Datos Generales del Proyecto</td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label19" runat="server" Text="Tipo de Servicio:"></asp:Label>
                                                        </td>

                                                        <td colspan="2">
                                                            <asp:CheckBox ID="CheckBox8" runat="server" Text="Monitoreo" CssClass="auto-style2" AutoPostBack="True" />
                                                            <asp:CheckBox ID="CheckBox9" runat="server" Text="Validación" CssClass="auto-style2" AutoPostBack="True" />
                                                            <asp:CheckBox ID="CheckBox10" runat="server" Text="Verificación" CssClass="auto-style2" AutoPostBack="True" />

                                                        </td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label20" runat="server" Text="Alcance del Proyecto:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox43" runat="server" Width="300px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                    </tr>

                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Area de Calidad</td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label21" runat="server" Text="Persona de Calidad Asignada al Proyecto:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox44" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label22" runat="server" Text="Puesto:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox45" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label23" runat="server" Text="Teléfono:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox46" runat="server" Width="150px" CssClass="validate[required,custom[phone]] required="></asp:TextBox>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label24" runat="server" Text="e-mail:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox47" runat="server" Width="150px"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label25" runat="server" Text="Desarrollo de Script:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList50" runat="server" Width="93px" CssClass="validate[required]" Height="16px" Style="margin-bottom: 0">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>



                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label26" runat="server" Text="Fecha Vo.Bo.:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox49" runat="server" Width="120px" CssClass="textos"></asp:TextBox>
                                                            <asp:CalendarExtender ID="CalendarExtender569" runat="server" Enabled="True" TargetControlID="TextBox49" PopupButtonID="ImageButton3" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton3" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label27" runat="server" Text="Desarrollo de Guia de Monitoreo:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList51" runat="server" Width="93px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label28" runat="server" Text="Fecha Vo.Bo.:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox48" runat="server" Width="120px" CssClass="textos "></asp:TextBox>
                                                            <asp:CalendarExtender ID="CalendarExtender2" runat="server" Enabled="True" TargetControlID="TextBox48" PopupButtonID="ImageButton4" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton4" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label29" runat="server" Text="Desarrollo de Material de Apoyo:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList52" runat="server" Width="93px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>


                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label30" runat="server" Text="Fecha Vo.Bo.:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox50" runat="server" Width="120px" CssClass="textos "></asp:TextBox>
                                                            <asp:CalendarExtender ID="CalendarExtender3" runat="server" Enabled="True" TargetControlID="TextBox50" PopupButtonID="ImageButton5" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton5" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label31" runat="server" Text="Especificación del Servicio de Monitoreo:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox51" runat="server" Width="300px" Height="40px"  TextMode="MultiLine"></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label32" runat="server" Text="Especificación del Servicio de Validación:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox52" runat="server" Width="300px" Height="40px"  TextMode="MultiLine"></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label33" runat="server" Text="Especificación del Servicio de Verificación:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox53" runat="server" Width="300px" Height="40px"  TextMode="MultiLine"></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label34" runat="server" Text="Condiciones de Rechazo del Servicio:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox54" runat="server" Width="300px" Height="40px"  TextMode="MultiLine"></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                    </tr>


                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Adicionales Calidad</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="6" class="auto-style20">Plantillas de Whatsapp</td>
                                                    </tr>


                                                    <tr>
                                                        <td class="auto-style15"></td>
                                                        <td class="auto-style15">
                                                            <asp:Label ID="Label35" runat="server" Text="Plantillas:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style15">
                                                            <asp:DropDownList ID="DropDownList53" runat="server" Width="93px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>


                                                        </td>
                                                        <td class="auto-style18">
                                                            <asp:Label ID="Label36" runat="server" Text="Fecha Vo.Bo.:" Width="150px"></asp:Label>
                                                        </td>

                                                        <td class="auto-style15">
                                                            
                                                            <asp:TextBox ID="TextBox55" runat="server" Width="120px" CssClass="textos"></asp:TextBox>
                                                            <asp:CalendarExtender ID="CalendarExtender55" runat="server" Enabled="True" TargetControlID="TextBox55" PopupButtonID="ImageButton15" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton15" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                                        </td>

                                                        </td>
                                                        

                                                        <td class="auto-style15"></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label37" runat="server" Text="Responsable de Entrega Plantillas:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox56" runat="server" Width="150px" ></asp:TextBox>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label38" runat="server" Text="e-mail:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox57" runat="server" Width="150px"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label39" runat="server" Text="Nombre del Contacto Entrega Plantillas:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox58" runat="server" Width="150px"  Height="20px"></asp:TextBox>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label40" runat="server" Text="e-mail:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox59" runat="server" Width="150px"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>


                                                   
                                          
                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Encuesta de Satisfacción</td>
                                                    </tr>


                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label47" runat="server" Text="Encuesta de Satisfacción:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList55" runat="server" Width="93px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label48" runat="server" Text="Fecha de Vo.Bo.:" Width="150px"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox65" runat="server" Width="120px" CssClass="textos"></asp:TextBox>
                                                            <asp:CalendarExtender ID="CalendarExtender49" runat="server" Enabled="True" TargetControlID="TextBox65" PopupButtonID="ImageButton16" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton16" runat="server" Height="23px" ImageAlign="Top" ImageUrl="~/Images/calendario.png" Width="23px" />
                                                        </td>

                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label49" runat="server" Text="Responsable de Entrega  de Encuestas de Satisfacción:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox66" runat="server" Width="150px" ></asp:TextBox>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label50" runat="server" Text="e-mail:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox67" runat="server" Width="150px"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label51" runat="server" Text="Nombre del Contacto Entrega de Encuesta de Satisfacción:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox68" runat="server" Width="150px" ></asp:TextBox>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label52" runat="server" Text="e-mail:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox69" runat="server" Width="150px" ></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                        
                                                    </tr>
                                                      <tr>
                                                        <td colspan="6" class="TituloGuia">Archivos:</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <td><asp:Label ID="Label177" runat="server" Text="Script:"></asp:Label></td>
                                                            <td>
                                                                 <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage38" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir29" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click98"/>

                                                                    <asp:Label ID="Label176" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir29" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td>
                                                            <td><asp:Label ID="Label178" runat="server" Text="Plantillas:"></asp:Label></td>
                                                            <td>
                                                                 <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage39" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir30" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click99"/>

                                                                    <asp:Label ID="Label179" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir30" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td>
                                                            <td><asp:Label ID="Label180" runat="server" Text="Encuesta:"></asp:Label></td>
                                                            <td>
                                                                 <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage40" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir31" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click100"/>

                                                                    <asp:Label ID="Label181" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir31" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>
                                                        </td>
                                                    </tr>












                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Entrega de Grabaciones del Servicio de Monitoreo, Validación y/o Verificación</td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label53" runat="server" Text="Grabaciones:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList56" runat="server" Width="93px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label54" runat="server" Text="Periodo de Entrega:" Width="150px"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox70" runat="server" Width="120px" ></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label55" runat="server" Text="% de Grabaciones para el Cliente:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox72" runat="server" Width="120px"></asp:TextBox>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label56" runat="server" Text="Forma de Entrega:" Width="150px"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox71" runat="server" Width="120px" CssClass="textos "></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label57" runat="server" Text="Audioteca:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList57" runat="server" Width="93px" CssClass="validate[required]"  Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                        <td class="auto-style17">
                                                            <asp:Label ID="Label58" runat="server" Text="Tiempo de Resguardo:" Width="150px"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox74" runat="server" Width="120px" CssClass="textos "></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label59" runat="server" Text="Reportería Adicional:"></asp:Label>
                                                        </td>


                                                        <td colspan="2">
                                                            <asp:DropDownList ID="DropDownList58" runat="server" Width="93px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                            <td></td>
                                                    </tr>
                                                    
                                                         <tr>
                                                             <td class="TituloGuia" colspan="6">Comentarios Adicionales del Proyecto</td>
                                                         </tr>
                                                         <tr>
                                                             <td colspan="6">
                                                                 <asp:TextBox ID="TextBox73" runat="server"  Height="50px" TextMode="MultiLine" Width="690px"></asp:TextBox>
                                                             </td>
                                                         </tr>
                                                         <tr>
                                                             <td class="TituloGuia" colspan="6">Riesgos de la Información</td>
                                                         </tr>
                                                         <tr>
                                                             <td></td>
                                                             <td>
                                                                 <asp:Label ID="Label60" runat="server" Text="Existe Riesgo:"></asp:Label>
                                                             </td>
                                                             <td>
                                                                 <asp:DropDownList ID="DropDownList59" runat="server" CssClass="validate[required]" Height="16px" Width="93px">
                                                                     <asp:ListItem Value="">Selecciona</asp:ListItem>
                                                                     <asp:ListItem>Si</asp:ListItem>
                                                                     <asp:ListItem>No</asp:ListItem>
                                                                 </asp:DropDownList>
                                                             </td>
                                                             <td class="auto-style17">
                                                                 <asp:Label ID="Label61" runat="server" Text="Nivel de Riesgo:" Width="150px"></asp:Label>
                                                             </td>
                                                             <td>
                                                                 <asp:TextBox ID="TextBox75" runat="server" CssClass="textos validate[required]" Width="120px"></asp:TextBox>
                                                             </td>
                                                             <td></td>
                                                         </tr>
                                                         <tr>
                                                             <td></td>
                                                             <td colspan="2">
                                                                 <asp:Label ID="Label62" runat="server" Text="Activos que deben ser protegidos:"></asp:Label>
                                                             </td>
                                                             <td colspan="2">
                                                                 <asp:TextBox ID="TextBox76" runat="server" CssClass="validate[required]" Width="300px"></asp:TextBox>
                                                             </td>
                                                             <td></td>
                                                         </tr>
                                                

                                                </table>
                                            </asp:Panel>


                                        </div>
                                    </asp:View>




                                    <!--*************************************************************OPERACION***************************************************-->
                                      <asp:View ID="View3" runat="server">
                                        <br />

                                        <div runat="server" id="Div2" visible="True" style="padding-left: 25px;">
                                            <asp:Panel ID="Panel3" runat="server" Width="700px" CssClass="margencitofull">
                                                <table class="auto-style9">
                                                    <tr>
                                                        <td colspan="5" class="TituloGuia">Niveles de Servicio</td>
                                                    </tr>
                                                    <tr>


                                                        <td class="TituloGuia">Metrica/Indicador</td>
                                                        <td class="TituloGuia">Objetivo</td>
                                                    </tr>


                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox87" runat="server" Width="150px" Cssclass="validate[required,funcCall[myValidationFunction1]]"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox88" runat="server" Width="50px" Cssclass="validate[required,funcCall[myValidationFunction1]]"></asp:TextBox></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox77" runat="server" Width="150px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox78" runat="server" Width="50px"></asp:TextBox></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox79" runat="server" Width="150px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox80" runat="server" Width="50px" Height="20px"></asp:TextBox></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox81" runat="server" Width="150px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox82" runat="server" Width="50px"></asp:TextBox></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox83" runat="server" Width="150px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox84" runat="server" Width="50px"></asp:TextBox></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox85" runat="server" Width="150px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox86" runat="server" Width="50px"></asp:TextBox></td>
                                                    </tr>

                                                </table>

                                                <table style="width: 100%">
                                                    <tr>
                                                        <td colspan="5" class="TituloGuia">Horas de Servicio</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="5" class="auto-style21">
                                                            <asp:TextBox ID="TextBox500" runat="server" Height="50px" Width="690px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox></td>
                                                    </tr>
                                                     <tr>
                                                        <td colspan="5" class="auto-style22">Agentes Entregados</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="5">
                                                            <asp:TextBox ID="TextBox510" runat="server" Height="50px" Width="690px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox></td>
                                                    </tr>

                                                   
                                                        <tr>
                                                            <td  colspan="5" class="TituloGuia">Riesgos de la Información</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label700" runat="server" Text="Existe Riesgo:"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:DropDownList ID="DropDownList300" runat="server" CssClass="validate[required]" Height="16px" Width="93px">
                                                                    <asp:ListItem Value="">Selecciona</asp:ListItem>
                                                                    <asp:ListItem>Si</asp:ListItem>
                                                                    <asp:ListItem>No</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label800" runat="server" Text="Nivel de Riesgo:"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox323" runat="server" CssClass="textos validate[required]" Width="50px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label900" runat="server" Text="Activos a Proteger:"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox950" runat="server" CssClass="textos validate[required]" Width="50px"></asp:TextBox>
                                                            </td>
                                                            <td>&nbsp;</td>
                                                        </tr>


                                                         <tr>
                                                            <td  colspan="5" class="TituloGuia">Archivos:</td>
                                                        </tr>


                                                          <tr>
                                                             <td>
                                                                 <asp:Label ID="Label186" runat="server" Text="Dinámicas Operativas:"></asp:Label>
                                                             </td>
                                                             <td>
                                                                 <asp:UpdatePanel ID="UpdatePanel25" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage41" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir32" runat="server" Text="Subir Imagen" ForeColor="#000066" OnClick="btSubir_Click101"/>

                                                                    <asp:Label ID="Label187" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir32" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>

                                                          <tr>
                                                             <td>
                                                                 <asp:Label ID="Label188" runat="server" Text="Mapa Ubicación de Campaña:"></asp:Label>
                                                             </td>
                                                             <td>
                                                                 <asp:UpdatePanel ID="UpdatePanel26" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage42" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir33" runat="server" Text="Subir Imagen" ForeColor="#000066" OnClick="btSubir_Click102"/>

                                                                    <asp:Label ID="Label189" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir33" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                             </td>

                                                             </tr>








                                                </table>
                                            </asp:Panel>


                                        </div>

                                    </asp:View>
                                    <!--*************************************************************RRHH***************************************************-->
                                    <asp:View ID="View4" runat="server">
                                        <br />

                                        <div runat="server" id="Div3" visible="True" style="padding-left: 25px;">
                                            <asp:Panel ID="Panel4" runat="server" Width="700px" CssClass="margencitofull">
                                                <table  style="width: 100%">
                                                    <tr>
                                                        <td colspan="5" class="TituloGuia">Staff</td>
                                                    </tr>
                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label63" runat="server" Text="No. de Supervisores:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:DropDownList ID="DropDownList6" runat="server" CssClass="validate[required]">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>0</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td></td>

                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label64" runat="server" Text="No. de Analistas QA:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:DropDownList ID="DropDownList7" runat="server" CssClass="validate[required]" Height="16px">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>0</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td></td>

                                                    </tr>
                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label65" runat="server" Text="No. de Validadores:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:DropDownList ID="DropDownList8" runat="server" CssClass="validate[required]">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>0</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td>

                                                        </td>

                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label66" runat="server" Text="No. de Agentes:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox125" runat="server" Width="50px"></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                    </tr>


                                                    <tr>
                                                        <td colspan="5" class="TituloGuia">Detalle Agentes</td>
                                                    </tr>
                                                    <tr>

                                                        
                                                        <td class="TituloGuia">Agentes</td>
                                                        <td  class="TituloGuia">Entrada Lunes-Viernes</td>
                                                        <td   class="TituloGuia">Salida Lunes-Viernes</td>
                                                        <td  class="TituloGuia">Entrada Sabado-Domingo</td>
                                                        <td   class="TituloGuia">Salida Sabado-Domingo</td>
                                                      
                                                    </tr>

                                                    <tr>

                                                       
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList9" runat="server" CssClass="validate[required]">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList10" runat="server" CssClass="validate[required]">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList11" runat="server" CssClass="validate[required]">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>


                                                        <td>
                                                            <asp:DropDownList ID="DropDownList12" runat="server" CssClass="validate[required]">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList>
                                                            </td>
                                                     
                                                            <td>
                                                            <asp:DropDownList ID="DropDownList91" runat="server" CssClass="validate[required]">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>

                                                        
                                                    </tr>

                                                    <tr runat="server" id="AG2">

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList102" runat="server" >
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList13" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList14" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                       
                                                            <td >
                                                            <asp:DropDownList ID="DropDownList67" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList100" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        
                                                    </tr>

                                                    <tr runat="server" id="AG3">

                                                     
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList15" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList16" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList17" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                       
                                                            <td>
                                                            <asp:DropDownList ID="DropDownList68" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList>

                                                            </td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList101" runat="server" >
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        
                                                    </tr>

                                                    <tr runat="server" id="AG4">

                                                        
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList18" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList19" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList20" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                       
                                                             <td >
                                                            <asp:DropDownList ID="DropDownList89" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                          <td >
                                                            <asp:DropDownList ID="DropDownList103" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                       
                                                    </tr>

                                                    <tr runat="server" id="AG5">

                                                       
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList21" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList22" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList>

                                                        </td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList23" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                       
                                                             <td >
                                                            <asp:DropDownList ID="DropDownList90" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                           <td >
                                                            <asp:DropDownList ID="DropDownList104" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                       
                                                        
                                                    </tr>

                                                    <tr runat="server" id="AG6">

                                                        
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList24" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList25" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList26" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                           <td >
                                                            <asp:DropDownList ID="DropDownList105" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                          <td >
                                                            <asp:DropDownList ID="DropDownList106" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                       
                                                    </tr>

                                                    <tr runat="server" id="AG7">

                                                        
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList27" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList28" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList29" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                       
                                                           <td>
                                                            <asp:DropDownList ID="DropDownList98" runat="server" >
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList>

                                                           </td> 
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList99" runat="server" >
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        
                                                    </tr>

                                                    <tr runat="server" id="AG8">

                                                       
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList30" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList31" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList32" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        
                                                           <td >
                                                            <asp:DropDownList ID="DropDownList96" runat="server" >
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList97" runat="server" >
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                    </tr>

                                                    <tr runat="server" id="AG9">

                                                        
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList33" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList34" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList35" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                      
                                                            <td >
                                                            <asp:DropDownList ID="DropDownList94" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList95" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        
                                                    </tr>

                                                    <tr runat="server" id="AG10">

                                                    
                                                             <td>
                                                            <asp:DropDownList ID="DropDownList36" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>1</asp:ListItem>
                                                                <asp:ListItem>2</asp:ListItem>
                                                                <asp:ListItem>3</asp:ListItem>
                                                                <asp:ListItem>4</asp:ListItem>
                                                                <asp:ListItem>5</asp:ListItem>
                                                                <asp:ListItem>6</asp:ListItem>
                                                                <asp:ListItem>7</asp:ListItem>
                                                                <asp:ListItem>8</asp:ListItem>
                                                                <asp:ListItem>9</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td >
                                                            <asp:DropDownList ID="DropDownList37" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>
                                                            <asp:DropDownList ID="DropDownList38" runat="server">
                                                                <asp:ListItem Value="0">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                       
                                                            <td >
                                                            <asp:DropDownList ID="DropDownList92" runat="server">
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                      <td >
                                                            <asp:DropDownList ID="DropDownList93" runat="server" >
                                                                <asp:ListItem Value="">-</asp:ListItem>
                                                                <asp:ListItem>00:00</asp:ListItem>
                                                                <asp:ListItem>01:00</asp:ListItem>
                                                                <asp:ListItem>02:00</asp:ListItem>
                                                                <asp:ListItem>03:00</asp:ListItem>
                                                                <asp:ListItem>04:00</asp:ListItem>
                                                                <asp:ListItem>05:00</asp:ListItem>
                                                                <asp:ListItem>06:00</asp:ListItem>
                                                                <asp:ListItem>07:00</asp:ListItem>
                                                                <asp:ListItem>08:00</asp:ListItem>
                                                                <asp:ListItem>09:00</asp:ListItem>
                                                                <asp:ListItem>10:00</asp:ListItem>
                                                                <asp:ListItem>11:00</asp:ListItem>
                                                                <asp:ListItem>12:00</asp:ListItem>
                                                                <asp:ListItem>13:00</asp:ListItem>
                                                                <asp:ListItem>14:00</asp:ListItem>
                                                                <asp:ListItem>15:00</asp:ListItem>
                                                                <asp:ListItem>16:00</asp:ListItem>
                                                                <asp:ListItem>17:00</asp:ListItem>
                                                                <asp:ListItem>18:00</asp:ListItem>
                                                                <asp:ListItem>19:00</asp:ListItem>
                                                                <asp:ListItem>20:00</asp:ListItem>
                                                                <asp:ListItem>21:00</asp:ListItem>
                                                                <asp:ListItem>22:00</asp:ListItem>
                                                                <asp:ListItem>23:00</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                    </tr>

                                                    <tr>
                                                      
                                                        <td colspan="2">
                                                            <asp:Label ID="Label68" runat="server" Text="Perfiles:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox119" runat="server" Width="300px" Height="40px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                       <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label190" runat="server" Text="Dias de Descanso:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox95" runat="server" Width="300px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>


                                                    <tr>
                                                      
                                                        <td colspan="2">
                                                            <asp:Label ID="Label69" runat="server" Text="Sueldo Bruto Asignado:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox120" runat="server" Width="300px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label70" runat="server" Text="Bono de Productividad:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox121" runat="server" Width="300px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                        
                                                        <td colspan="2">
                                                            <asp:Label ID="Label71" runat="server" Text="Bono Plataforma Prosperidad:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox122" runat="server" Width="300px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                       
                                                        <td colspan="2" >
                                                            <asp:Label ID="Label72" runat="server" Text="Otros:"></asp:Label>
                                                        </td>
                                                        <td colspan="2" >
                                                            <asp:TextBox ID="TextBox123" runat="server" Width="300px" ></asp:TextBox>
                                                        </td>
                                                        
                                                    </tr>

                                                      <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label191" runat="server" Text="Perfil del Agente:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel27" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage43" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir34" runat="server" Text="Subir Archivo" ForeColor="#000066" Width="114px" />
                                                                    <asp:Label ID="Label192" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir34" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>


                                                     <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label193" runat="server" Text="Requisición de Agente:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel28" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage44" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir35" runat="server" Text="Subir Archivo" ForeColor="#000066" />
                                                                    <asp:Label ID="Label194" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir35" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>





                                                    <tr>
                                                        
                                                        <td colspan="2">
                                                            <asp:Label ID="Label73" runat="server" Text="Macroproceso:"></asp:Label>
                                                        </td>
                                                        <td colspan="2" >
                                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir" runat="server" OnClick="btSubir_Click" Text="Subir Archivo" ForeColor="#000066" />
                                                                    <asp:Label ID="Label164" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td class="auto-style10"></td>
                                                    </tr>
                                                    <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label74" runat="server" Text="Subprocesos:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">

                                                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage2" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir2" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click1" />
                                                                    <asp:Label ID="Label165" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir2" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>

                                                        </td>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label75" runat="server" Text="Manuales:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage3" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir3" runat="server" Text="Subir  Archivo" ForeColor="#000066" OnClick="btSubir_Click2" />
                                                                    <asp:Label ID="Label166" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir3" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                       
                                                    </tr>

                                                    <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label76" runat="server" Text="Proceso Operativo:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage4" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir4" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click3" />
                                                                    <asp:Label ID="Label167" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir4" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                   

                                                     <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label195" runat="server" Text="Politicas:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel29" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage45" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir36" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click104" />
                                                                    <asp:Label ID="Label196" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir36" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>


                                                    <tr>
                                                        <td colspan="5" class="TituloGuia">Riesgos de la Información</td>
                                                    </tr>

                                                    <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label77" runat="server" Text="Existe Riesgo:"></asp:Label>
                                                            <td class="auto-style7" >
                                                            <asp:DropDownList ID="DropDownList60" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>

                                                        
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label78" runat="server" Text="Nivel de Riesgo:" Width="150px"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox128" runat="server" Width="120px" CssClass="textos validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                    
                                                        <td colspan=2"">
                                                            <asp:Label ID="Label79" runat="server" Text="Activos que deben ser protegidos:"></asp:Label>
                                                        </td>
                                                        <td class="auto-style36">
                                                            <asp:TextBox ID="TextBox129" runat="server" Width="300px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        

                                                    </tr>

                                                </table>


                                            </asp:Panel>


                                        </div>
                                    </asp:View>
                                    <!--*************************************************************TI***************************************************-->
                                    <asp:View ID="View5" runat="server">

                                        <br />
                                        <div runat="server" id="Div4" visible="True" style="padding-left: 25px;">
                                            <asp:Panel ID="Panel5" runat="server" Width="700px" CssClass="margencitofull">
                                                <table class="width: 100%">
                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Telecomunicaciones</td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                        <td></td>
                                                        <td>
                                                            <asp:Label ID="Label80" runat="server" Text="Carrier:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox130" runat="server" Width="150px" ></asp:TextBox>
                                                        </td>
                                                        
                                                        <td></td>
                                                        <td></td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                         <td></td>
                                                        <td>
                                                             <asp:Label ID="Label85" runat="server" Text="Enlaces CCS:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox135" runat="server" Width="150px" ></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td></td>          
                                                        <td></td>  
                                                        <td><asp:Label ID="Label87" runat="server" Text="Enlaces Cliente-CCS:"></asp:Label></td>
                                                        <td><asp:TextBox ID="TextBox137" runat="server" Width="150px" ></asp:TextBox></td>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                        <td></td> 
                                                        <td></td>       
                                                        <td></td>
                                                        <td></td>
                                                    </tr>


                                                    <tr>

                                                        <td class="TituloGuia">Numero 800</td>
                                                        <td class="TituloGuia">Publicado</td>
                                                        <td class="TituloGuia">DID 800</td>
                                                        <td class="TituloGuia">DID de Redundancia</td>
                                                        <td class="TituloGuia">Horario Servicio</td>
                                                    </tr>


                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox168" runat="server" Width="50px" CssClass="validate[required,funcCall[myValidationFunction2]]"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox138" runat="server" Width="50px" CssClass="validate[required,funcCall[myValidationFunction2]]"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox139" runat="server" Width="50px" CssClass="validate[required,funcCall[myValidationFunction2]]"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox140" runat="server" Width="50px" CssClass="validate[required,funcCall[myValidationFunction2]]"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox141" runat="server" Width="50px" CssClass="validate[required,funcCall[myValidationFunction2]]"></asp:TextBox></td>
                                                       
                                                        
                                                    </tr>

                                                    <tr>
                                                        <td class="auto-style23">
                                                            <asp:TextBox ID="TextBox170" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td class="auto-style23">
                                                            <asp:TextBox ID="TextBox171" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td class="auto-style23">
                                                            <asp:TextBox ID="TextBox143" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td class="auto-style23">
                                                            <asp:TextBox ID="TextBox144" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td class="auto-style23">
                                                            <asp:TextBox ID="TextBox145" runat="server" Width="50px"></asp:TextBox></td>
                                                      
                                                        
                                                    </tr>

                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox172" runat="server" Width="50px" Height="20px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox173" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox148" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox149" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox150" runat="server" Width="50px"></asp:TextBox></td>
                                                        
                                                        
                                                    </tr>

                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox174" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox175" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox153" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox154" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox155" runat="server" Width="50px"></asp:TextBox></td>
                                                        
                                                      
                                                    </tr>

                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox176" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox177" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox158" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox159" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox160" runat="server" Width="50px"></asp:TextBox></td>
                                                       
                                                       
                                                    </tr>

                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox178" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox179" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox163" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox164" runat="server" Width="50px"></asp:TextBox></td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox165" runat="server" Width="50px"></asp:TextBox></td>
                                                       
                                                       
                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label88" runat="server" Text="Desborde a número externo:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList61" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label89" runat="server" Text="Skills:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:TextBox ID="TextBox180" runat="server" Width="120px" CssClass="textos validate[required]"></asp:TextBox>
                                                        </td>

                                                    </tr>


                                                    <tr>
                                                        <td colspan="5">
                                                            <asp:Label ID="Label169" runat="server" Text="URL"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="5">
                                                            <asp:TextBox ID="TextBox502" runat="server" Width="650px" CssClass="textos validate[required]" Height="40px" TextMode="MultiLine"></asp:TextBox></td>
                                                    </tr>



                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Infraestructura Requerida</td>
                                                    </tr>

                                                    <tr>

                                                        <td colspan="2" >
                                                            <asp:Label ID="Label90" runat="server" Text="Requiere Estaciones:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList62" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label91" runat="server" Text="No. de Estaciones:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox181" runat="server" Width="50px" CssClass="textos validate[required]"></asp:TextBox>
                                                        </td>

                                                    </tr>

                                                    <tr>

                                                        <td colspan="2" class="auto-style16">
                                                            <asp:Label ID="Label92" runat="server" Text="Analistas por Posicion:"></asp:Label>
                                                        </td>

                                                        <td  class="auto-style16">

                                                            <asp:TextBox ID="TextBox183" runat="server" Width="90px" CssClass="textos validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td class="auto-style16">
                                                            <asp:Label ID="Label93" runat="server" Text="Comentarios:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style16">
                                                            <asp:TextBox ID="TextBox182" runat="server" Width="50px" ></asp:TextBox>
                                                        </td>

                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label94" runat="server" Text="Equipos de Computo:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">

                                                            <asp:DropDownList ID="DropDownList63" runat="server" Width="91px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>


                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label95" runat="server" Text="Unidades:"></asp:Label>
                                                            <asp:TextBox ID="TextBox185" runat="server" Width="50px" CssClass="textos"></asp:TextBox>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList164" runat="server" Width="93px" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>

                                                        
                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label96" runat="server" Text="Telefonos:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">
                                                            <asp:DropDownList ID="DropDownList64" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label97" runat="server" Text="Unidades:"></asp:Label>
                                                             <asp:TextBox ID="TextBox184" runat="server" Width="50px" CssClass="textos"></asp:TextBox>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList65" runat="server" Width="93px" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>

                                                             </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label98" runat="server" Text="Sillas:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">

                                                            <asp:DropDownList ID="DropDownList66" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label99" runat="server" Text="Unidades:"></asp:Label>
                                                             <asp:TextBox ID="TextBox186" runat="server" Width="50px" CssClass="textos "></asp:TextBox>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList69" runat="server" Width="93px" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>



                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label244" runat="server" Text="Diademas:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">

                                                            <asp:DropDownList ID="DropDownList107" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label245" runat="server" Text="Unidades:"></asp:Label>
                                                             <asp:TextBox ID="TextBox105" runat="server" Width="50px" CssClass="textos"></asp:TextBox>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList108" runat="server" Width="93px" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>



                                                    </tr>

                                                        <tr>

                                                        <td colspan="2" >
                                                            <asp:Label ID="Label231" runat="server" Text="Instalación de Pantalla:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">
                                                            <asp:DropDownList ID="DropDownList44" runat="server" Width="93px" CssClass="validate[required]" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>

                                                             <td>
                                                            <asp:Label ID="Label238" runat="server" Text="Unidades:"></asp:Label>
                                                             <asp:TextBox ID="TextBox98" runat="server" Width="50px" CssClass="textos "></asp:TextBox>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList77" runat="server" Width="93px" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>

                                                        </tr>




                                                     <tr>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label232" runat="server" Text="Instalación de Cancelería:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList45" runat="server" Width="93px"  Height="16px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>


                                                           <td>
                                                            <asp:Label ID="Label239" runat="server" Text="Unidades:"></asp:Label>
                                                             <asp:TextBox ID="TextBox99" runat="server" Width="50px" CssClass="textos "></asp:TextBox>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList78" runat="server" Width="93px" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                  

                                                         </tr>

                                                    <tr>

                                                        <td  colspan="2">
                                                            <asp:Label ID="Label233" runat="server" Text="Instalación de Esmerilado:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList46" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>

                                                         <td>
                                                            <asp:Label ID="Label240" runat="server" Text="Unidades:"></asp:Label>
                                                             <asp:TextBox ID="TextBox100" runat="server" Width="50px" CssClass="textos"></asp:TextBox>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList86" runat="server" Width="93px" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                  


                                                        </tr>

                                                    <tr>

                                                        <td  colspan="2">
                                                            <asp:Label ID="Label235" runat="server" Text="Colocación de Mamparas:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList48" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>

                                                         <td>
                                                            <asp:Label ID="Label241" runat="server" Text="Unidades:"></asp:Label>
                                                             <asp:TextBox ID="TextBox101" runat="server" Width="50px" CssClass="textos"></asp:TextBox>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList87" runat="server" Width="93px" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                  
                                                    </tr>

                                                    <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label236" runat="server" Text="Instalación de Nodos:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList49" runat="server" Width="93px"  Height="16px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>


                                                         <td>
                                                            <asp:Label ID="Label242" runat="server" Text="Unidades:"></asp:Label>
                                                             <asp:TextBox ID="TextBox102" runat="server" Width="50px" CssClass="textos"></asp:TextBox>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList88" runat="server" Width="93px" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    
                                                    <tr>
                                                         <td  colspan="2">
                                                            <asp:Label ID="Label237" runat="server" Text="Colocación de Escritorio:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList54" runat="server" Width="93px" CssClass="validate[required]" >

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>

                                                         <td>
                                                            <asp:Label ID="Label101" runat="server" Text="Unidades:"></asp:Label>
                                                             <asp:TextBox ID="TextBox187" runat="server" Width="50px" CssClass="textos"></asp:TextBox>
                                                        </td>

                                                        <td>
                                                         <asp:DropDownList ID="DropDownList76" runat="server" Width="93px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Compra</asp:ListItem>
                                                                <asp:ListItem>Inventario</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>

                                                    </tr>

                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label234" runat="server" Text="Instalación de Biométrico:"></asp:Label>
                                                        </td>

                                                        <td class=" auto-style7" >
                                                            <asp:DropDownList ID="DropDownList47" runat="server" Width="93px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                           <td>
                                                            <asp:Label ID="Label100" runat="server" Text="Especificar:"></asp:Label>
                                                        </td>
                                                         <td >
                                                            <asp:TextBox ID="TextBox103" runat="server" Width="200px" CssClass="textos"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    

                                                  
                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label102" runat="server" Text="Requeimiento Extra:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">

                                                            <asp:DropDownList ID="DropDownList70" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label103" runat="server" Text="Especificar:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:TextBox ID="TextBox188" runat="server" Width="200px" CssClass="textos"></asp:TextBox>
                                                        </td>


                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label104" runat="server" Text="Cliente Propociona Recursos:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">
                                                            <asp:DropDownList ID="DropDownList71" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label105" runat="server" Text="Especificar:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:TextBox ID="TextBox189" runat="server" Width="200px" CssClass="textos"></asp:TextBox>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td colspan="5">
                                                            <asp:Label ID="Label106" runat="server" Text="Otros Requerimientos:"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="5">
                                                            <asp:TextBox ID="TextBox190" runat="server" Width="600px" CssClass="textos " Height="40px" TextMode="MultiLine"></asp:TextBox></td>
                                                    </tr>



                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Desarrollos</td>
                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label107" runat="server" Text="Aplicativo de Tipificación:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">
                                                            <asp:DropDownList ID="DropDownList72" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>


                                                        </td>
                                                        <td >
                                                            <asp:Label ID="Label108" runat="server" Text="CRM:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList73" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                    </tr>

                                                    <tr>

                                                        <td  colspan="2" >
                                                            <asp:Label ID="Label109" runat="server" Text="Email:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">
                                                            <asp:DropDownList ID="DropDownList74" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                        <td >
                                                            <asp:Label ID="Label110" runat="server" Text="IVR:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList75" runat="server" Width="93px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                    </tr>

                                                    <tr>

                                                        
                                                        <td  colspan="2">
                                                            
                                                            <asp:Label ID="Label114" runat="server" Text="CTI:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7" >
                                                            <asp:DropDownList ID="DropDownList79" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Seleccciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                    </tr>


                                                    <tr>

                                                        <td colspan="2" >
                                                            <asp:Label ID="Label115" runat="server" Text="Otro:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">
                                                            <asp:DropDownList ID="DropDownList80" runat="server" Width="93px" CssClass="validate[required]" Height="16px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                         <td>
                                                            <asp:Label ID="Label243" runat="server" Text="Especificar:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:TextBox ID="TextBox104" runat="server" Width="200px" Height="30px" CssClass="textos "></asp:TextBox>
                                                        </td>
                                                       
                                                    </tr>

                                                    
                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Archivos:</td>
                                                    </tr>



                                                      <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label197" runat="server" Text="Tipificación:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel30" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage200" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir250" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click500" />
                                                                    <asp:Label ID="Label198" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir250" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                      <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label199" runat="server" Text="Formato de Caida de Información:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel31" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage201" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir251" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click510" />
                                                                    <asp:Label ID="Label200" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir251" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                      <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label201" runat="server" Text="Pruebas del Aplicativo:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel32" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage202" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir252" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click520" />
                                                                    <asp:Label ID="Label202" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir252" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>



                                                    <tr>
                                                        <td colspan="6" class="TituloGuia">Redes Sociales</td>
                                                    </tr>



                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label116" runat="server" Text="Facebook:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">
                                                            <asp:DropDownList ID="DropDownList81" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                        <td >
                                                            <asp:Label ID="Label117" runat="server" Text="Twitter:"></asp:Label>
                                                        </td>

                                                        <td >
                                                            <asp:DropDownList ID="DropDownList82" runat="server" Width="93px" CssClass="validate[required]" Style="height: 20px">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>
                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label118" runat="server" Text="Otro:"></asp:Label>
                                                        </td>

                                                        <td class="auto-style7">
                                                            <asp:DropDownList ID="DropDownList83" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>

                                                        <td >
                                                            <asp:Label ID="Label41" runat="server" Text="Whatsapp:"></asp:Label>
                                                        </td>

                                                        <td>
                                                            <asp:DropDownList ID="DropDownList39" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>

                                                        </td>

                                                        </tr>


                                                        <tr>
                                                            <td colspan="5">
                                                                <asp:Label ID="Label170" runat="server" Text="Especifica:"></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="5">
                                                                <asp:TextBox ID="TextBox503" runat="server" Width="650px" CssClass="textos" Height="40px" TextMode="MultiLine"></asp:TextBox></td>
                                                        </tr>

                                                        
                                                    <tr>
                                                                
                                                        <td colspan="2">
                                                            <asp:Label ID="Label45" runat="server" Text="Celulares de IN :"></asp:Label>

                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox61" runat="server" Width="100px" ></asp:TextBox>

                                                        </td>
                                                        
                                                        <td>
                                                            <asp:Label ID="Label46" runat="server" Text="Números de out:"></asp:Label>

                                                        </td>

                                                        <td>
                                                            <asp:TextBox ID="TextBox62" runat="server" Width="100px" ></asp:TextBox>
                                                        </td>
                                                        </tr>


                                                        <tr>
                                                            
                                                            <td colspan="2">
                                                                <asp:Label ID="Label67" runat="server" Text="Celulares de IN :"></asp:Label>

                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox63" runat="server" Width="100px" ></asp:TextBox>
                                                            </td>
                                                            

                                                             <td>
                                                                    <asp:Label ID="Label81" runat="server" Text="Números de out:"></asp:Label>
                                                             </td>
                                                             <td>
                                                                    <asp:TextBox ID="TextBox64" runat="server" Width="100px" ></asp:TextBox></td>

                                                            </td>

                                                            
                                                        </tr>
                                                    
                                                        <tr>
                                                            
                                                            <td colspan="2"><asp:Label ID="Label82" runat="server" Text="Celulares de IN :"></asp:Label></td>
                                                            <td><asp:TextBox ID="TextBox89" runat="server" Width="100px" ></asp:TextBox></td>
                                                               
                                                              <td><asp:Label ID="Label83" runat="server" Text="Numeros de Out :"></asp:Label></td>
                                                            <td><asp:TextBox ID="TextBox90" runat="server" Width="100px" ></asp:TextBox></td>
                                                        </tr>
                                                         <tr>
                                                           
                                                            <td colspan="2"><asp:Label ID="Label84" runat="server" Text="Celulares de IN:"></asp:Label></td>
                                                            <td><asp:TextBox ID="TextBox91" runat="server" Width="100px" ></asp:TextBox></td>
                                                                
                                                              <td><asp:Label ID="Label86" runat="server" Text= "Numeros de Out:"></asp:Label></td>
                                                            <td><asp:TextBox ID="TextBox92" runat="server" Width="100px" ></asp:TextBox></td>
                                                        </tr>
                                                     
                                                       
                                                       
                                                        <tr>
                                                            <td class="TituloGuia" colspan="6">Software Standard</td>
                                                        </tr>
                                                        <tr>
                                                           
                                                            <td colspan="2">
                                                                <asp:Label ID="Label124" runat="server" Text="Supervisor:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style7" >
                                                                <asp:TextBox ID="TextBox194" runat="server" CssClass="validate[required]" Width="120px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label125" runat="server" Text="Adicional:"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:TextBox ID="TextBox195" runat="server" Width="120px"></asp:TextBox>
                                                            </td>
                                                            
                                                        </tr>
                                                        <tr>
                                                           
                                                            <td colspan="2">
                                                                <asp:Label ID="Label126" runat="server" Text="Agentes:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style7" >
                                                                <asp:TextBox ID="TextBox196" runat="server" Width="120px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label127" runat="server" Text="Adicional:"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:TextBox ID="TextBox197" runat="server" Width="120px"></asp:TextBox>
                                                            </td>
                                                            
                                                        </tr>
                                                        <tr>
                                                            
                                                            <td colspan="2">
                                                                <asp:Label ID="Label128" runat="server" Text="Cliente:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style7" >
                                                                <asp:TextBox ID="TextBox198" runat="server" CssClass="validate[required]" Width="120px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label129" runat="server" Text="Adicional:"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:TextBox ID="TextBox199" runat="server" Width="120px"></asp:TextBox>
                                                            </td>
                                                           
                                                        </tr>
                                                        <tr>
                                                            <td class="TituloGuia" colspan="6">Hardware Standard</td>
                                                        </tr>
                                                        <tr>
                                                           
                                                            <td colspan="2">
                                                                <asp:Label ID="Label132" runat="server" Text="Supervisor:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style7" >
                                                                <asp:TextBox ID="TextBox202" runat="server" CssClass="validate[required]" Width="120px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label133" runat="server" Text="Adicional:"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:TextBox ID="TextBox203" runat="server" Width="120px"></asp:TextBox>
                                                            </td>
                                                            
                                                        </tr>
                                                        <tr>
                                                            
                                                            <td colspan="2">
                                                                <asp:Label ID="Label134" runat="server" Text="Agentes:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style7" >
                                                                <asp:TextBox ID="TextBox204" runat="server" CssClass="validate[required]" Width="120px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label135" runat="server" Text="Adicional:"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:TextBox ID="TextBox205" runat="server" Width="120px"></asp:TextBox>
                                                            </td>
                                                            
                                                        </tr>
                                                        <tr>
                                                            
                                                            <td colspan="2">
                                                                <asp:Label ID="Label136" runat="server" Text="Cliente:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style7">
                                                                <asp:TextBox ID="TextBox206" runat="server" CssClass="validate[required]" Width="120px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label137" runat="server" Text="Adicional:"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:TextBox ID="TextBox207" runat="server" Width="120px"></asp:TextBox>
                                                            </td>
                                                           
                                                        </tr>
                                                        <tr>
                                                            <td class="TituloGuia" colspan="6">Base de Datos</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="7">Formato</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="7">
                                                                <asp:CheckBox ID="CheckBox85" runat="server" CssClass="auto-style2" Text="XLS" Width="100px" />
                                                                <asp:CheckBox ID="CheckBox86" runat="server" CssClass="auto-style2" Text="SQL" Width="100px" />
                                                                <asp:CheckBox ID="CheckBox87" runat="server" CssClass="auto-style2" Text="Access" Width="100px" />
                                                                <asp:CheckBox ID="CheckBox88" runat="server" CssClass="auto-style2" Text="Otro" Width="100px" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="7">Medio de Intercambio</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="7">
                                                                <asp:CheckBox ID="CheckBox89" runat="server" CssClass="auto-style2" Text="USB" Width="100px" />
                                                                <asp:CheckBox ID="CheckBox90" runat="server" CssClass="auto-style2" Text="FTP" Width="100px" />
                                                                <asp:CheckBox ID="CheckBox91" runat="server" CssClass="auto-style2" Text="Correo Cifrado" Width="100px" />
                                                                <asp:CheckBox ID="CheckBox92" runat="server" CssClass="auto-style2" Text="Otro" Width="100px" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="7">Envío de Llaves</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="7">
                                                                <asp:CheckBox ID="CheckBox93" runat="server" CssClass="auto-style2" Text="Correo Alterno" Width="100px" />
                                                                <asp:CheckBox ID="CheckBox94" runat="server" CssClass="auto-style2" Text="SMS" Width="100px" />
                                                                <asp:CheckBox ID="CheckBox95" runat="server" CssClass="auto-style2" Text="Whatsapp" Width="100px" />
                                                                <asp:CheckBox ID="CheckBox96" runat="server" CssClass="auto-style2" Text="Llamada" Width="100px" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="7">Tratamiento BDD Operativo
                                                                <tr>
                                                                    <td colspan="7">
                                                                        <asp:TextBox ID="TextBox208" runat="server" CssClass="validate[required]" Width="550px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="7">Responsable BDD
                                                                <tr>
                                                                    <td colspan="7">
                                                                        <asp:TextBox ID="TextBox209" runat="server" CssClass="validate[required]" Width="550px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="6">
                                                            <asp:Label ID="Label111" runat="server" Text="Higienización BBDD :"></asp:Label>
                                                             <asp:DropDownList ID="DropDownList40" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>

                                                       
                                                        </tr>


                                                         <tr>
                                                             
                                                            <td colspan="7"> Criterios de higienización
                                                                <tr>
                                                                    <td colspan="7">
                                                                        <asp:TextBox ID="TextBox93" runat="server" CssClass="validate[required]" Width="550px" Height="50px" TextMode="MultiLine"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                            </td>
                                                        </tr>
                                                        

                                                        <tr>
                                                            <td class="TituloGuia" colspan="6">Riesgos de la Información</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Label ID="Label138" runat="server" Text="Existe Riesgo:"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:DropDownList ID="DropDownList84" runat="server" CssClass="validate[required]" Height="16px" Width="93px">
                                                                    <asp:ListItem Value="">Selecciona</asp:ListItem>
                                                                    <asp:ListItem>Si</asp:ListItem>
                                                                    <asp:ListItem>No</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label139" runat="server" Text="Nivel de Riesgo:"></asp:Label>
                                                                <asp:TextBox ID="TextBox210" runat="server" CssClass="textos validate[required]" Width="90px" ></asp:TextBox>
                                                            </td>
                                                            
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" >
                                                                <asp:Label ID="Label140" runat="server" Text="Activos a Proteger:"></asp:Label>
                                                            </td>
                                                            <td colspan="4">
                                                                <asp:TextBox ID="TextBox211" runat="server" CssClass="textos validate[required]" Width="400px"></asp:TextBox>
                                                            </td>
                                                            <td>&nbsp;</td>
                                                        </tr>
                                                    </tr>

                                                </table>


                                            </asp:Panel>


                                        </div>
                                    </asp:View>



                                    <!--*************************************************************CAPACITACION***************************************************-->
                                    <asp:View ID="View6" runat="server">

                                        <br />
                                        <div runat="server" id="Div5" visible="True" style="padding-left: 25px;">
                                            <asp:Panel ID="Panel7" runat="server" Width="750px" CssClass="margencitofull">
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td colspan="7" class="TituloGuia">Capacitación</td>
                                                    </tr>

                                                    <tr>
                                                       

                                                        <td colspan="2">
                                                            <asp:Label ID="Label141" runat="server" Text="Contenido del Curso:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox212" runat="server" Width="250px" Height="60px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label142" runat="server" Text="Impartido por:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox213" runat="server" Width="150px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                    </tr>

                                                    <tr>
                                                        

                                                        <td colspan="2">
                                                            <asp:Label ID="Label143" runat="server" Text="Material Necesario:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox214" runat="server" Width="250px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label144" runat="server" Text="Duracion:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox215" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                    </tr>

                                                    <tr>
                                                        

                                                     <td></td>
                                                        <td>
                                                            <asp:Label ID="Label145" runat="server" Text="Fechas:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox216" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                      <td >
                                                                <asp:Label ID="Label112" runat="server" Text="Intranet::"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:DropDownList ID="DropDownList41" runat="server" CssClass="validate[required]" Height="16px" Width="93px">
                                                                    <asp:ListItem Value="">Selecciona</asp:ListItem>
                                                                    <asp:ListItem>Si</asp:ListItem>
                                                                    <asp:ListItem>No</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                   

                                                       
                                                            <caption>
                                                                &nbsp;</td>
                                                                <tr>
                                                                    <td>&nbsp;</td>
                                                                </tr>
                                                        </caption>
                                                        

                                                    </tr>
                                                    <tr>
                                                      <td></td>
                                                       <td></td>
                                                         <td>
                                                              <asp:Label ID="Label119" runat="server" Text="Agentes Entregados a Operaciones:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox94" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                    </tr>


                                                    <tr>
                                                        <td colspan="7" class="TituloGuia">Archivos:</td>
                                                    </tr>



                                                      <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label203" runat="server" Text="Manual de Producto:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel33" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage67" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir300" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click900" />
                                                                    <asp:Label ID="Label204" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir300" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                      <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label205" runat="server" Text="Manual de Sistema:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel34" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage78" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir301" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click800" />
                                                                    <asp:Label ID="Label206" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir301" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                      <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label207" runat="server" Text="Logística de Capacitación:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel35" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage79" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir302" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click700" />
                                                                    <asp:Label ID="Label208" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir302" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                       <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label209" runat="server" Text="Evaluación de Producto:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel36" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage170" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir560" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click780" />
                                                                    <asp:Label ID="Label210" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir560" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                       <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label211" runat="server" Text="Evaluación de Sistema:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel37" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage177" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir700" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click990" />
                                                                    <asp:Label ID="Label212" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir700" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                       <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label213" runat="server" Text="Presentación Capacitación:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel38" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage999" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir351" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click980" />
                                                                    <asp:Label ID="Label214" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir351" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>

                                                       <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label215" runat="server" Text="Carta Descriptiva:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel39" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage899" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir353" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click970" />
                                                                    <asp:Label ID="Label216" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir353" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>



                                                       <tr>
                                                       
                                                        <td colspan="2">
                                                            <asp:Label ID="Label217" runat="server" Text="Glosario de Tipificación:"></asp:Label>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:UpdatePanel ID="UpdatePanel40" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage877" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir354" runat="server" Text="Subir Archivo" ForeColor="#000066" OnClick="btSubir_Click920" />
                                                                    <asp:Label ID="Label218" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir354" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td></td>
                                                    </tr>


                                                </table>


                                            </asp:Panel>


                                        </div>
                                    </asp:View>



                                     <!--*************************************************************COMAND CENTER***************************************************-->
                                    <asp:View ID="View7" runat="server">
                                        <br />
                                        <div runat="server" id="Div7" visible="True" style="padding-left: 25px;">
                                            <asp:Panel ID="Panel9" runat="server" Width="700px" CssClass="margencitofull">
                                                <table  style="width: 100%">
                                                    
                                                    <tr>
                                                        <td  colspan="4" class="TituloGuia">Reporteria</td>
                                                    </tr>
                                                   
                                                        <tr>
                                                           
                                                                <td>
                                                                    <asp:Label ID="Label521" runat="server" Text="Tipo de Solicitud:"></asp:Label>
                                                                     <asp:TextBox ID="TextBox512" runat="server" Width="200px" CssClass="validate[required]"></asp:TextBox>

                                                                </td>

                                                            <td>
                                                                <asp:Label ID="Label520" runat="server" Text="Reporte:"></asp:Label>
                                                       
                                                                  <asp:TextBox ID="TextBox511" runat="server" Width="250px" CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                           
                                                           
                                                            </tr>


                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label522" runat="server" Text="Campaña:"></asp:Label>
                                                                        <asp:TextBox ID="TextBox513" runat="server" CssClass="validate[required]" Width="235px"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label171" runat="server" Text="Skills:"></asp:Label>
                                                                        <asp:TextBox ID="TextBox524" runat="server" CssClass="validate[required]" Width="260px"></asp:TextBox>
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <asp:Label ID="Label42" runat="server" Text="Solicitado:"></asp:Label>
                                                                    <asp:TextBox ID="TextBox515" runat="server" CssClass="validate[required]" Width="230px"></asp:TextBox>
                                                                </td>
                                                                <td>
                                                                    <asp:Label ID="Label524" runat="server" Text="Responsable de envío de reportería:"></asp:Label>
                                                                    <asp:TextBox ID="TextBox60" runat="server" CssClass="validate[required]" Height="20px" Width="120px"></asp:TextBox>
                                                                </td>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label43" runat="server" Text="Solicitud de Layout Excel:"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:FileUpload ID="FileUpload1" runat="server" BorderColor="#999966" />
                                                                                <asp:Button ID="Button2" runat="server" ForeColor="#000066" OnClick="btSubir_Click71" Text="Subir Imagen" />
                                                                                <asp:Label ID="Label44" runat="server" ForeColor="Red"></asp:Label>
                                                                            </ContentTemplate>
                                                                            <Triggers>
                                                                                <asp:PostBackTrigger ControlID="Button2" />
                                                                            </Triggers>
                                                                        </asp:UpdatePanel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="TituloGuia" colspan="4">Lista de Distribución(Interno)</td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="4">
                                                                        <asp:TextBox ID="TextBox516" runat="server" CssClass="validate[required]" Height="50px" TextMode="MultiLine" Width="690px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="TituloGuia" colspan="4">Detalles de la Solicitud </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label226" runat="server" Text="Reporte1:"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:FileUpload ID="fuimage366" runat="server" BorderColor="#999966" />
                                                                                <asp:Button ID="btSubir1080" runat="server" ForeColor="#000066" OnClick="btSubir_Click1480" Text="Subir Imagen" />
                                                                                <asp:Label ID="Label172" runat="server" ForeColor="Red"></asp:Label>
                                                                            </ContentTemplate>
                                                                            <Triggers>
                                                                                <asp:PostBackTrigger ControlID="btSubir1080" />
                                                                            </Triggers>
                                                                        </asp:UpdatePanel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label225" runat="server" Text="Reporte2:"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:FileUpload ID="fuimage367" runat="server" BorderColor="#999966" />
                                                                                <asp:Button ID="btSubir667" runat="server" ForeColor="#000066" OnClick="btSubir_Click768" Text="Subir Imagen" />
                                                                                <asp:Label ID="Label173" runat="server" ForeColor="Red"></asp:Label>
                                                                            </ContentTemplate>
                                                                            <Triggers>
                                                                                <asp:PostBackTrigger ControlID="btSubir667" />
                                                                            </Triggers>
                                                                        </asp:UpdatePanel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label227" runat="server" Text="Reporte3:"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:FileUpload ID="fuImage368" runat="server" BorderColor="#999966" />
                                                                                <asp:Button ID="btSubir668" runat="server" ForeColor="#000066" Text="Subir Imagen" />
                                                                                <asp:Label ID="Label182" runat="server" ForeColor="Red"></asp:Label>
                                                                            </ContentTemplate>
                                                                            <Triggers>
                                                                                <asp:PostBackTrigger ControlID="btSubir668" />
                                                                            </Triggers>
                                                                        </asp:UpdatePanel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label228" runat="server" Text="Reporte4:"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:FileUpload ID="fuImage544" runat="server" BorderColor="#999966" />
                                                                                <asp:Button ID="btSubir544" runat="server" ForeColor="#000066" OnClick="btSubir_Click404" Text="Subir Imagen" />
                                                                                <asp:Label ID="Label183" runat="server" ForeColor="Red"></asp:Label>
                                                                            </ContentTemplate>
                                                                            <Triggers>
                                                                                <asp:PostBackTrigger ControlID="btSubir544" />
                                                                            </Triggers>
                                                                        </asp:UpdatePanel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label229" runat="server" Text="Reporte5:"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:FileUpload ID="fuImage587" runat="server" BorderColor="#999966" />
                                                                                <asp:Button ID="btSubir587" runat="server" ForeColor="#000066" OnClick="btSubir_Click405" Text="Subir Imagen" />
                                                                                <asp:Label ID="Label184" runat="server" ForeColor="Red"></asp:Label>
                                                                            </ContentTemplate>
                                                                            <Triggers>
                                                                                <asp:PostBackTrigger ControlID="btSubir587" />
                                                                            </Triggers>
                                                                        </asp:UpdatePanel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label230" runat="server" Text="Reporte6:"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:FileUpload ID="fuImage588" runat="server" BorderColor="#999966" />
                                                                                <asp:Button ID="btSubir589" runat="server" ForeColor="#000066" OnClick="btSubir_Click408" Text="Subir Imagen" />
                                                                                <asp:Label ID="Label185" runat="server" ForeColor="Red"></asp:Label>
                                                                            </ContentTemplate>
                                                                            <Triggers>
                                                                                <asp:PostBackTrigger ControlID="btSubir589" />
                                                                            </Triggers>
                                                                        </asp:UpdatePanel>
                                                                    </td>
                                                                </tr>
                                                            </tr>

                                                          </tr>
        

                                                </table>


                                            </asp:Panel>
                                          
                                        </div>

                                    </asp:View>

                                    <!--*************************************************************FACTURACION***************************************************-->
                                    <asp:View ID="View8" runat="server">
                                        <br />
                                        <div runat="server" id="Div6" visible="True" style="padding-left: 25px;">
                                            <asp:Panel ID="Panel8" runat="server" Width="700px" CssClass="margencitofull">
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td colspan="7" class="TituloGuia">Facturacion</td>
                                                    </tr>

                                                    <tr>
                                                        <td></td>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label146" runat="server" Text="Razon Social:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox217" runat="server" Width="250px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label147" runat="server" Text="RFC:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox218" runat="server" Width="150px"></asp:TextBox>

                                                        </td>
                                                        <td></td>

                                                    </tr>

                                                    <tr>
                                                        <td></td>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label148" runat="server" Text="Domicilio Fiscal:"></asp:Label>
                                                        </td>
                                                        <td colspan="3">
                                                            <asp:TextBox ID="TextBox219" runat="server" Width="500px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>


                                                    </tr>

                                                    <tr>
                                                        <td></td>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label149" runat="server" Text="Unidades Facturables:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox220" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label150" runat="server" Text="Descripción de las Unidades:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox221" runat="server" Width="150px" CssClass="validate[required]"></asp:TextBox>
                                                        </td>
                                                        <td></td>

                                                    </tr>

                                                    <tr>
                                                        <td colspan="7">Consideraciones para el cobro del costo de Telecomunicación asociado al servicio:
                                                             <tr>
                                                                 <td colspan="7">
                                                                     <asp:TextBox ID="TextBox222" runat="server" Width="550px" Height="60px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox>
                                                                 </td>
                                                             </tr>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td colspan="2" ></td>
                                                        
                                                         <td  colspan="2">
                                                             
                                                                <asp:Label ID="Label219" runat="server" Text="Entrega de Contrato:"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:DropDownList ID="DropDownList42" runat="server" CssClass="validate[required]" Height="16px" Width="93px">
                                                                    <asp:ListItem Value="">Selecciona</asp:ListItem>
                                                                    <asp:ListItem>Si</asp:ListItem>
                                                                    <asp:ListItem>No</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                     

                                                    </tr>

                                                    <tr>
                                                        <td></td>
                                                       
                                                        <td colspan="7">
                                                            <asp:Label ID="Label220" runat="server" Text="Comentarios:"></asp:Label>
                                                            <tr>
                                                                 <td colspan="7">
                                                                     <asp:TextBox ID="TextBox96" runat="server" Width="550px" Height="60px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox>
                                                                 </td>
                                                             </tr>
                                                        </td>

                                                     
                                                    </tr>





                                                    <tr>
                                                        <td colspan="2"></td>
                                                        
                                                         <td  colspan="2">
                                                             
                                                                <asp:Label ID="Label221" runat="server" Text="Entrega de NDA:"></asp:Label>
                                                            </td>
                                                            <td >
                                                                <asp:DropDownList ID="DropDownList43" runat="server" CssClass="validate[required]" Height="16px" Width="93px">
                                                                    <asp:ListItem Value="">Selecciona</asp:ListItem>
                                                                    <asp:ListItem>Si</asp:ListItem>
                                                                    <asp:ListItem>No</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                     

                                                    </tr>

                                                    <tr>

                                                        <td colspan="7">
                                                           
                                                            <asp:Label ID="Label222" runat="server" Text="Comentarios:"></asp:Label>
                                                            <tr>
                                                                 <td colspan="7">
                                                                     <asp:TextBox ID="TextBox97" runat="server" Width="550px" Height="60px" CssClass="validate[required]" TextMode="MultiLine"></asp:TextBox>
                                                                 </td>
                                                             </tr>
                                                        </td>

                                                     
                                                    </tr>
                                                 

           
                                                    <tr>
                                                        <td></td>
                                                        <td class="auto-style13"></td>

                                                        <td colspan="2" class="auto-style13">
                                                            <asp:Label ID="Label223" runat="server" Text="Carta de Inscripción al RFC:"></asp:Label>
                                                        </td>
                                                        <td colspan="3" class="auto-style13">


                                                            <asp:UpdatePanel ID="UpdatePanel41" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuimage695" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir695" runat="server" Text="Subir Imagen" ForeColor="#000066" OnClick="btSubir_Click695" />

                                                                    <asp:Label ID="Label224" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir695" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td></td>
                                                        <td class="auto-style13"></td>

                                                        <td colspan="2" class="auto-style13">
                                                            <asp:Label ID="Label160" runat="server" Text="Logotipo:"></asp:Label>
                                                        </td>
                                                        <td colspan="3" class="auto-style13">


                                                            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:FileUpload ID="fuImage5" runat="server" BorderColor="#999966" />
                                                                    <asp:Button ID="btSubir5" runat="server" Text="Subir Imagen" ForeColor="#000066" OnClick="btSubir_Click6" />

                                                                    <asp:Label ID="Label168" runat="server" ForeColor="Red"></asp:Label>
                                                                </ContentTemplate>
                                                                <Triggers>
                                                                    <asp:PostBackTrigger ControlID="btSubir5" />
                                                                </Triggers>
                                                            </asp:UpdatePanel>
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td colspan="7" class="TituloGuia">Riesgos de la Información</td>
                                                    </tr>

                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:Label ID="Label161" runat="server" Text="Existe Riesgo:"></asp:Label>
                                                        </td>

                                                        <td colspan="2">

                                                            <asp:DropDownList ID="DropDownList85" runat="server" Width="93px" CssClass="validate[required]">

                                                                <asp:ListItem Value="">Selecciona</asp:ListItem>

                                                                <asp:ListItem>Si</asp:ListItem>
                                                                <asp:ListItem>No</asp:ListItem>


                                                            </asp:DropDownList>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label162" runat="server" Text="Nivel de Riesgo:"></asp:Label>
                                                        </td>

                                                        <td colspan="2">
                                                            <asp:TextBox ID="TextBox233" runat="server" Width="50px" CssClass="textos validate[required]"></asp:TextBox>
                                                        </td>

                                                    </tr>

                                                    <tr>

                                                        <td colspan="2">
                                                            <asp:Label ID="Label163" runat="server" Text="Activos a Proteger:"></asp:Label>
                                                        </td>

                                                        <td colspan="4">
                                                            <asp:TextBox ID="TextBox234" runat="server" CssClass="textos validate[required]" Width="400px"></asp:TextBox>
                                                        </td>
                                                        <td>&nbsp;</td>



                                                    </tr>

                                                </table>


                                            </asp:Panel>
                                            <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="Button" Height="25px" Width="80px" />

                                        </div>

                                    </asp:View>

                                </asp:MultiView>


                            </div>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>
        </div>
    </div>


</asp:Content>
