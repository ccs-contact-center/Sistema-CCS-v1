<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="TroncoComun.ascx.vb" Inherits="CCS.TroncoComun" %>

<asp:Table ID="Table1" runat="server" Font-Names="Arial">
            <asp:TableRow Visible="false">

                <asp:TableCell runat="server" HorizontalAlign="Center" Width="115px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Nombres</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="115px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Paterno</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="115px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Materno</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="150px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Instructor</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="150px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Campaña</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="85px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Grupo</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" Width="80px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Horario</asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                
                <asp:TableCell runat="server" Width="115px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"> <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="ValidaTronco" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="115px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:TextBox ID="TextBox2" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red" ValidationGroup="ValidaTronco" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="115px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:TextBox ID="TextBox3" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="TextBox3" ForeColor="Red" ValidationGroup="ValidaTronco" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="150px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:DropDownList ID="DropDownList2" runat="server" Width="145px"></asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="DropDownList2" ForeColor="Red" ValidationGroup="ValidaTronco" InitialValue="0" Width="3px"></asp:RequiredFieldValidator> </asp:TableCell>
                <asp:TableCell runat="server" Width="150px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:DropDownList ID="DropDownList1" runat="server" Width="145px"> </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="DropDownList1" ForeColor="Red" ValidationGroup="ValidaTronco" InitialValue="0" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="80px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:TextBox ID="TextBox4" runat="server" Width="69px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="TextBox4" ForeColor="Red" ValidationGroup="ValidaTronco" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
                <asp:TableCell runat="server" Width="80px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:TextBox ID="TextBox5" runat="server" Width="69px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="TextBox5" ForeColor="Red" ValidationGroup="ValidaTronco" Width="3px"></asp:RequiredFieldValidator></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
<asp:HiddenField ID="HiddenField1" runat="server" />
