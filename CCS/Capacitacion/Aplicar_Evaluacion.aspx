<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Masterpages/Content.Master" CodeBehind="Aplicar_Evaluacion.aspx.vb" Inherits="CCS.Aplicar_Evaluacion" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 25%;
            margin-left: 339px;
            border-style: none;
            vertical-align: top;
        }

        td {
            vertical-align: top;
        }

        .auto-style3 {
            text-align: left;
            width:300px;
        }
        .auto-style5 {
            width: 127px;
        }
        .auto-style6 {
            width: 148px;
        }
        .auto-style7 {
            width: 3px;
        }
        .auto-style8 {
            margin-left: 339px;
            border-style: none;
            vertical-align: top;
        }
        .auto-style9 {
            width: 408px;
        }
        .auto-style10 {
            width: 238px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div id="site_content">
        <div class="content">

            <h1>Evaluación</h1>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text="Evaluación"></asp:Label></h2>

                        <div runat="server" id="Alta1">
                            <table class="auto-style8">
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td class="auto-style6">
                                        <strong>
                                        <asp:Label ID="Label3" runat="server" Text="Tiempo Restante:"></asp:Label>
                                        </strong></td>
                                    <td class="auto-style7">
                                      
                                                <strong><strong>
                                                <asp:Label ID="Label128" runat="server" Text="Label"></asp:Label>
                                                </strong></strong><asp:Timer ID="Timer1" runat="server" Interval="1000"></asp:Timer>
                                   

                                    </td>
                                </tr>
                            </table>
                        </div>
                        <br /><br />

                        <div runat="server" id="Alta2" visible="false">
                        </div>




                        <div id="preview" runat="server">

                          

                            <div id="PV1" runat="server" visible="false">
                                  <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">1)
                                            <asp:Label ID="Label108" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check1" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross1" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>


                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField1" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                           
                            <div id="PV2" runat="server" visible="false">
                                 <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">2)
                                            <asp:Label ID="Label109" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check2" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross2" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField2" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV3" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">3)
                                            <asp:Label ID="Label110" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check3" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross3" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField3" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV4" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">4)
                                            <asp:Label ID="Label111" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check4" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross4" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList4" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField4" runat="server" />
                                        </td>
                                    </tr>

                                </table>
                            </div>

                           
                            <div id="PV5" runat="server" visible="false">
                                 <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">5)
                                            <asp:Label ID="Label112" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check5" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross5" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList5" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField5" runat="server" />
                                        </td>
                                    </tr>

                                </table>
                            </div>

                            
                            <div id="PV6" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">6)
                                            <asp:Label ID="Label113" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check6" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross6" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList6" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField6" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV7" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">7)
                                            <asp:Label ID="Label114" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check7" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross7" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList7" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField7" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV8" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">8)
                                            <asp:Label ID="Label115" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check8" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross8" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList8" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField8" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV9" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">9)
                                            <asp:Label ID="Label116" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check9" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross9" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList9" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField9" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV10" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">10)
                                            <asp:Label ID="Label117" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check10" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross10" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList10" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField10" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                           
                            <div id="PV11" runat="server" visible="false">
                                 <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">11)
                                            <asp:Label ID="Label118" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check11" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross11" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList11" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField11" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV12" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">12)
                                            <asp:Label ID="Label119" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check12" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross12" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList12" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField12" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV13" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">13)
                                            <asp:Label ID="Label120" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check13" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross13" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList13" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField13" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV14" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">14)
                                            <asp:Label ID="Label121" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check14" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross14" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList14" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField14" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV15" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">15)
                                            <asp:Label ID="Label122" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check15" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross15" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList15" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField15" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV16" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">16)
                                            <asp:Label ID="Label123" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check16" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross16" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList16" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField16" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV17" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">17)
                                            <asp:Label ID="Label124" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check17" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross17" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList17" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField17" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV18" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">18)
                                            <asp:Label ID="Label125" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check18" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross18" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList18" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField18" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV19" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">19)
                                            <asp:Label ID="Label126" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check19" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross19" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList19" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField19" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            
                            <div id="PV20" runat="server" visible="false">
                                <hr />
                                <table>
                                    <tr>
                                        <td class="auto-style3" colspan="3">20)
                                            <asp:Label ID="Label127" runat="server" Text="Label"></asp:Label>

                                        </td>
                                        <td>
                                            <asp:Image ID="Check20" runat="server" Height="20px" ImageUrl="~/Images/check.jpg" Visible="False" ImageAlign="Middle" />
                                            <asp:Image ID="Cross20" runat="server" Height="20px" ImageUrl="~/Images/cross.jpg" Visible="False" ImageAlign="Middle" /></td>
                                    </tr>

                                    <tr>
                                        <td colspan="5">
                                            <asp:RadioButtonList ID="RadioButtonList20" runat="server" RepeatDirection="Horizontal" Width="928px" Style="text-align: center;">
                                                <asp:ListItem Value="A"></asp:ListItem>
                                                <asp:ListItem Value="B"></asp:ListItem>
                                                <asp:ListItem Value="C"></asp:ListItem>
                                                <asp:ListItem Value="D"></asp:ListItem>
                                                <asp:ListItem Value="E"></asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:HiddenField ID="HiddenField20" runat="server" />
                                        </td>
                                    </tr>


                                </table>
                            </div>

                            <hr />


                        </div>


                        <br />

                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>

                        <asp:Panel ID="Panel4" runat="server" Width="700px" CssClass="margencitofull">
                                <table style="width: 100%">

                                    <tr>
                                        <td class="auto-style9"></td>
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text="ID Instructor:"></asp:Label>
                                            <asp:TextBox ID="TextBox5" runat="server" AutoPostBack="True" Width="110px" AutoCompleteType="Disabled"></asp:TextBox>
                                            <asp:Image ID="Image2" runat="server" ImageAlign="Middle" ImageUrl="~/Images/Check-3-icon.png" Visible="False" Width="20px" />
                                            <asp:HiddenField ID="HiddenField21" runat="server" Value="0" />
                                        </td>
                                        <td class="auto-style2">&nbsp;</td>
                                        <td runat="server" id="FirmaAgente" class="auto-style10">
                                            <asp:Label ID="Label4" runat="server" Text="Pass Instructor:"></asp:Label>
                                            <asp:TextBox ID="TextBox6" runat="server" TextMode="Password" AutoPostBack="True" Width="110px" AutoCompleteType="Disabled"></asp:TextBox>
                                            <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/Check-3-icon.png" Visible="False" Width="20px" ImageAlign="Middle" />
                                            <asp:HiddenField ID="HiddenField22" runat="server" Value="0" />
                                        </td>
                                        <td class="auto-style3">
                                            &nbsp;</td>
                                        <td class="auto-style5"></td>
                                    </tr>

                                </table>
                            </asp:Panel>
                           </ContentTemplate>
                        </asp:UpdatePanel>
                        <br />
                        <div class="textos">
                            <asp:Button ID="Button1" runat="server" Text="Finalizar" CssClass="Button" Height="25px" Width="85px" ValidationGroup="Valida1" />
                            <br /><br />
                            <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="Button" Height="25px" Width="85px" ValidationGroup="Valida1" />
                        </div>

                    </asp:Panel>




                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

</asp:Content>
