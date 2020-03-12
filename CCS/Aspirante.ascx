<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Aspirante.ascx.vb" Inherits="CCS.Aspirante1" %>

<asp:Table ID="Table1" runat="server" Font-Names="Arial">
            <asp:TableRow Visible="false">

                <asp:TableCell runat="server" HorizontalAlign="Center" Width="100px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Nombres</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="100px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Paterno</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="100px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Materno</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="85px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Entrada OP</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="85px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Salida OP</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="85px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Entrada CAP</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="85px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Salida CAP</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="80px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Telefono</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="80px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Campaña</asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                

                <asp:TableCell runat="server" Width="100px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"> <asp:TextBox ID="TextBox1" runat="server" Width="85px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="ValidaReclu" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="100px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:TextBox ID="TextBox2" runat="server" Width="85px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red" ValidationGroup="ValidaReclu" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="100px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:TextBox ID="TextBox3" runat="server" Width="85px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox3" ForeColor="Red" ValidationGroup="ValidaReclu" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="85px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:DropDownList ID="DropDownList2" runat="server" Width="80px">
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
                            </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="DropDownList2" ForeColor="Red" ValidationGroup="ValidaReclu" Width="3px" InitialValue="0"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="85px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:DropDownList ID="DropDownList1" runat="server" Width="80px">
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
                            </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="DropDownList1" ForeColor="Red" ValidationGroup="ValidaReclu" Width="3px" InitialValue="0"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="85px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:DropDownList ID="DropDownList3" runat="server" Width="80px">
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
                            </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="DropDownList3" ForeColor="Red" ValidationGroup="ValidaReclu" Width="3px" InitialValue="0"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="85px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:DropDownList ID="DropDownList4" runat="server" Width="80px">
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
                            </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="DropDownList4" ForeColor="Red" ValidationGroup="ValidaReclu" Width="3px" InitialValue="0"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="80px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:TextBox ID="TextBox4" runat="server" Width="68px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" ControlToValidate="TextBox4" ForeColor="Red" ValidationGroup="ValidaReclu" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="80px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:DropDownList ID="DropDownList5" runat="server" Width="75px"></asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*" ControlToValidate="DropDownList5" ForeColor="Red" ValidationGroup="ValidaReclu" Width="3px" InitialValue="0"></asp:RequiredFieldValidator></asp:TableCell>
            </asp:TableRow>
        </asp:Table>