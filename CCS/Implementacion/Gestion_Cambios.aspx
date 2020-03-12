<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Gestion_Cambios.aspx.vb" Inherits="CCS.WebForm2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../../CSS/ValidationEngine.css" rel="stylesheet" type="text/css" />
    <script src="../../JS/jquery.validationEngine-en.js" charset="utf-8"></script>
    <script src="../../JS/jquery.validationEngine.js" charset="utf-8"></script>
    <script id="grid" type="text/javascript">    

        function pageLoad() {

            jQuery("#form1").validationEngine();

           
        }




    </script>

  <style type="text/css">
        .auto-style20 {
            width: 131px;
        }
        .auto-style21 {
            height: 24px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    
    <div id="site_content">
   

        <div class="content">
            <h1>Gestion de Cambios</h1>
            <div class="center">


                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="Panel616" runat="server" CssClass="Panel">
                            <h2>Control de Cambios</h2>
                            <br />
                           

                             <div runat="server" id="Div146" visible="True" style="padding-left: 25px;">
                                 <asp:Panel ID="panel900" runat="server" Width="700px" CssClass="margencitofull">
                                    
                                   <asp:Label ID="Label900" runat="server" Text="Selecciona Campaña:" BackColor="#CC0000" Font-Bold="True" Font-Size="11pt" ForeColor="White" Width="200px"></asp:Label>
                                                            
                                     <asp:DropDownList ID="DropDownList1" runat="server" Width="271px" Height="37px" CssClass="validate[required]" AutoPostBack="True">
                                     </asp:DropDownList>
                                     <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

                                    </asp:Panel>


                                            <asp:Panel ID="Panel700" runat="server" Width="800px" CssClass="margencitofull">
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td colspan="7" class="TituloGuia">Cambios</td>
                                                    </tr>


                                                    <tr>
                                                         <td colspan="2">
                                                            <asp:Label ID="Label600" runat="server" Text="CLAVE DEL DOCUMENTO:" BackColor="#CC0000" ForeColor="White" Width="100px"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label601" runat="server" BackColor="#666666" ForeColor="White" Text="F-IP01" Width="100px"></asp:Label>
                                                        </td>
                                                        
                                                        <td>
                                                            <asp:Label ID="Label602" runat="server" BackColor="#CC0000" ForeColor="White" Text="REVISION:" Width="100px"></asp:Label>
                                                        </td>
                                                        

                                                        <td>
                                                            <asp:Label ID="Label603" runat="server" BackColor="#666666" ForeColor="White" Text="2" Width="100px"></asp:Label>
                                                        </td>
                                                       
                                                        <td>
                                                            <asp:Label ID="Label604" runat="server" BackColor="#CC0000" ForeColor="White" Text="RESGUARDO:" Width="100px"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label605" runat="server" BackColor="#666666" ForeColor="White" Text=" 1 Año" Width="100px"></asp:Label>
                                                        </td>
                                                        </tr>

                                                        <tr>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:Label ID="Label606" runat="server" Text="Número de Solicitud:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style21" colspan="1">
                                                                <asp:TextBox ID="TextBox607" runat="server"  Width="127px"  CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:Label ID="Label608" runat="server" Text="Numero de Ticket:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style21">
                                                                <asp:TextBox ID="TextBox609" runat="server" Width="127px" CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:Label ID="Label610" runat="server" Text="Área Solicitante:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style21" colspan="1">
                                                                <asp:TextBox ID="TextBox611" runat="server"  Width="127px" CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:Label ID="Label612" runat="server" Text="Nombre del Solicitante:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style21">
                                                                <asp:TextBox ID="TextBox613" runat="server" Width="127px" CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:Label ID="Label614" runat="server" Text="Fecha de Solicitud de Cambios:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style21" colspan="1">
                                                                <asp:TextBox ID="TextBox615" runat="server" CssClass="textos validate[required] " Width="127px" Height="21px"></asp:TextBox>
                                                                <asp:CalendarExtender ID="CalendarExtender122" runat="server" Enabled="True" Format="dd/MM/yyyy" PopupButtonID="TextBox615" TargetControlID="TextBox615">
                                                                </asp:CalendarExtender>
                                                                &nbsp;</td>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:Label ID="Label616" runat="server" Text="Área Ejecutora:"></asp:Label>
                                                            </td>
                                                            <td colspan="1">
                                                                <asp:TextBox ID="TextBox617" runat="server" Width="127px" CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style20">
                                                                <asp:Label ID="Label618" runat="server" Text="Nombre del Ejecutor:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:TextBox ID="TextBox619" runat="server" Width="127px" CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                            <td class="auto-style21" colspan="1">
                                                                <asp:Label ID="Label620" runat="server" Text="Descripcion de Cambios:"></asp:Label>
                                                            </td>
                                                            <td colspan="2">
                                                                <asp:TextBox ID="TextBox621" runat="server"  TextMode="MultiLine" Width="250px" CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                        </tr>

                                                        <tr>
                                                            <td class="auto-style20">
                                                                <asp:Label ID="Label622" runat="server" Text="Validación Tecnica:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:TextBox ID="TextBox623" runat="server" CssClass="textos validate[required] " Width="127px"></asp:TextBox>
                                                            </td>
                                                            <td class="auto-style21" colspan="1">
                                                                <asp:Label ID="Label1624" runat="server" Text="Observaciones:"></asp:Label>
                                                            </td>
                                                            <td colspan="2">
                                                                <asp:TextBox ID="TextBox625" runat="server"  TextMode="MultiLine" Width="250px" CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style20">
                                                                <asp:Label ID="Label630" runat="server" Text="Ajustes Cuantitativos:"></asp:Label>
                                                            </td>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:TextBox ID="TextBox631" runat="server" CssClass="textos validate[required] " Width="127px"></asp:TextBox>
                                                            </td>
                                                            <td class="auto-style21" colspan="1">
                                                                <asp:Label ID="Label1632" runat="server" Text="Observaciones:"></asp:Label>
                                                            </td>
                                                            <td colspan="2">
                                                                <asp:TextBox ID="TextBox633" runat="server"  TextMode="MultiLine" CssClass="validate[required]" Width="250px"></asp:TextBox>
                                                            </td>
                                                        </tr>

                                                        <tr>
                                                            <td class="auto-style20">
                                                                <asp:Label ID="Label634" runat="server" Text="Aprobado por (Nombre):"></asp:Label>
                                                            </td>
                                                            <td class="auto-style21" colspan="2">
                                                                <asp:TextBox ID="TextBox635" runat="server"  Width="127px" Height="21px"  CssClass="validate[required]"></asp:TextBox>
                                                            </td>
                                                            <td class="auto-style21" colspan="1">
                                                                <asp:Label ID="Label1636" runat="server" Text="Aprobado (Fecha):"></asp:Label>
                                                            </td>
                                                            <td colspan="2">
                                                                <asp:TextBox ID="TextBox637" runat="server" CssClass="textos validate[required] " Width="127px"></asp:TextBox>
                                                                <asp:CalendarExtender ID="CalendarExtender123" runat="server" Enabled="True" Format="dd/MM/yyyy" PopupButtonID="TextBox637" TargetControlID="TextBox637">
                                                                </asp:CalendarExtender>
                                                               
                                                            </td>
                                                        </tr>

                                                        <tr>
                                                            <td class="auto-style20">
                                                                <asp:Label ID="Label638" runat="server" Text="Fecha de Solución:"></asp:Label>
                                                            </td>
                                                            <td colspan="2">
                                                                <asp:TextBox ID="TextBox639" runat="server" CssClass="textos validate[required]" Width="127px"></asp:TextBox>
                                                                <asp:CalendarExtender ID="CalendarExtender124" runat="server" Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageButton2" TargetControlID="TextBox639">
                                                                </asp:CalendarExtender>
                                                                
                                                            </td>
                                                            <td class="auto-style21" colspan="1">
                                                                <asp:Label ID="Label1640" runat="server" Text="Fecha de Ejecución:"></asp:Label>
                                                            </td>
                                                            <td colspan="2">
                                                                <asp:TextBox ID="TextBox641" runat="server" CssClass="textos validate[required] " Width="127px"></asp:TextBox>
                                                                <asp:CalendarExtender ID="CalendarExtender125" runat="server" Enabled="True" Format="dd/MM/yyyy" PopupButtonID="TextBox641" TargetControlID="TextBox641">
                                                                </asp:CalendarExtender>
                                                                
                                                            </td>
                                                        </tr>
                                                   
                                                       
                                                     </table>
                                                  </asp:Panel>
                                             <asp:Panel ID="Panel1" runat="server" Width="800px" CssClass="margencitofull">
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td colspan="7" class="TituloGuia">Consulta de Cambios</td>
                                                    </tr>
                                               </table>
                                               </asp:Panel>
                                 <asp:Panel ID="Panel2" runat="server" Width="800px" CssClass="margencitofull">
                                   
                                     
                                              <div style="width:800px; height:115px; overflow: scroll;">    
                                                    <asp:GridView ID="GridView1" runat="server" Font-Names="Arial" Font-Size="12px"  Width="872px" CssClass="grids" CellPadding="0" Height="67px" style="margin-left: 0px" >
                                                        <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <EditRowStyle HorizontalAlign="right" VerticalAlign="Middle" Width="100px" />
                                <EmptyDataRowStyle HorizontalAlign="right" VerticalAlign="Middle" />
                                <HeaderStyle BackColor="#C00327" Font-Bold="True" ForeColor="White" />
                                <RowStyle Height="15px" Wrap="false" HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    </asp:GridView>
                                                        
                                                       
                                                   </div>  
                                         
                                                  </asp:Panel>




                                                </div>    
                            
                                
                         
                                        </asp:Panel>
                        
                         
                                    </ContentTemplate>
                                    </asp:UpdatePanel>
                <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="Button" style="height: 22px"/>
                                </div>
             
                                </div>
       
    </div>
</asp:Content>






