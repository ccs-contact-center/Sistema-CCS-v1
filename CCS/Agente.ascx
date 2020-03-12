<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Agente.ascx.vb" Inherits="CCS.Agente" %>

        <asp:Table ID="Table1" runat="server" Font-Names="Arial">
            <asp:TableRow Visible="false">
                <asp:TableCell runat="server" Width="50px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">ID</asp:TableCell>
                <asp:TableCell runat="server" Width="300px" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Nombre</asp:TableCell>
                <asp:TableCell runat="server" Width="70px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Conexión</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">A</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">F</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">FJ</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">D</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">I</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">PC</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">PS</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">V</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">PJ</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">HE</asp:TableCell>
                <asp:TableCell runat="server" Width="35px" HorizontalAlign="Center" BackColor="#C00327" ForeColor="White" Font-Names="Arial" Font-Size="Small" Font-Bold="true">Comentarios</asp:TableCell>
            </asp:TableRow>




            <asp:TableRow>
                <asp:TableCell runat="server" Width="50px" HorizontalAlign="Center" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" ><asp:Label ID="Label1" runat="server" Text="ID" Font-Names="Arial" Font-Size="Small"></asp:Label></asp:TableCell>
                <asp:TableCell runat="server" Width="300px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"><asp:Label ID="Label2" runat="server" Text="Nombre" Font-Names="Arial" Font-Size="Small"></asp:Label></asp:TableCell>
                <asp:TableCell runat="server" Width="70px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:Label ID="Label3" runat="server" Text="CNX" Font-Names="Arial" Font-Size="Small"></asp:Label></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:RadioButton ID="RadioButton1" runat="server" GroupName="Agente" AutoPostBack="True" /></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:RadioButton ID="RadioButton2" runat="server" Groupname="Agente" AutoPostBack="True"/></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:RadioButton ID="RadioButton3" runat="server" Groupname="Agente" AutoPostBack="True"/></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:RadioButton ID="RadioButton4" runat="server" Groupname="Agente" AutoPostBack="True"/></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:RadioButton ID="RadioButton5" runat="server" Groupname="Agente" AutoPostBack="True"/></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:RadioButton ID="RadioButton6" runat="server" Groupname="Agente" AutoPostBack="True"/></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:RadioButton ID="RadioButton7" runat="server" Groupname="Agente" AutoPostBack="True"/></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:RadioButton ID="RadioButton8" runat="server" Groupname="Agente" AutoPostBack="True"/></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:RadioButton ID="RadioButton9" runat="server" Groupname="Agente" Enabled="False" AutoPostBack="True"/></asp:TableCell>
                <asp:TableCell runat="server" Width="35px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px" HorizontalAlign="Center"><asp:TextBox ID="TextBox1" runat="server" width="35px" Font-Names="Arial" Font-Size="Small"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server" Width="250px" BorderStyle="Solid" BorderColor="#EEEEEE" BorderWidth="1px"  HorizontalAlign="Center"><asp:TextBox ID="TextBox2" runat="server" Width="230px" Font-Names="Arial" Font-Size="Small"></asp:TextBox> <asp:Label ID="Label4" runat="server" Text="A" Font-Names="Arial" Font-Size="Small" Width="10px" ForeColor="#009900" Font-Bold="True" Visible="false"></asp:Label></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
<asp:HiddenField ID="HiddenField1" runat="server" />

<asp:HiddenField ID="HiddenField2" runat="server" />