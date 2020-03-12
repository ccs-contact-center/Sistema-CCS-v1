Imports System.Data.SqlClient
Public Class HOCapa
    Inherits System.Web.UI.Page

    Dim x As New Funciones

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        ListaAgentes()
        If Not IsPostBack Then
            'x.FillCampañas(DropDownList1, False)
            x.FillCursos(DropDownList1, 2)
        End If

    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
        If e.CommandName = "Select" Then
            Session("seleccionsinasignar") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
            Session("seleccionsinasignarnombre") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(1).Text)
            Session("seleccionsinasignarcampania") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(2).Text)
        End If


    End Sub

    Protected Sub GridView2_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView2.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView2, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView2_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView2.RowCommand
        If e.CommandName = "Select" Then
            Session("seleccionsupervisor") = String.Format("{1}", e.CommandArgument, GridView2.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
        End If


    End Sub

    Sub ListaAgentesAsignacion()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT a.id, a.nombres+ ' ' + a.paterno+ ' ' +a.materno as Nombre, b.nombres+' '+b.paterno as Supervisor, c.campania as Campaña FROM SYS_empleados a LEFT JOIN SYS_empleados b ON a.jefe_directo = b.id LEFT JOIN SYS_campanias c ON a.campaña = c.id WHERE (a.status = 8) AND a.puesto = 0 AND a.curso =" & DropDownList1.SelectedItem.Value & " ORDER BY campania"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView1.DataSource = cmd.ExecuteReader()
        GridView1.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Sub ListaAgentes()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT a.id, a.nombres+ ' ' + a.paterno+ ' ' +a.materno as Nombre, b.nombres+' '+b.paterno as Supervisor, c.campania as Campaña FROM SYS_empleados a LEFT JOIN SYS_empleados b ON a.jefe_directo = b.id LEFT JOIN SYS_campanias c ON a.campaña = c.id WHERE (a.status = 9) AND a.puesto = 0 AND a.jefe_directo = '" & x.GetUserID(Request.Cookies("Usersettings")("Username")) & "' ORDER BY campania"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView2.DataSource = cmd.ExecuteReader()
        GridView2.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        ListaAgentesAsignacion()
    End Sub


    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click

        Dim jefe_directo As String = x.GetUserID(Request.Cookies("Usersettings")("Username"))

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET status= 9, jefe_directo='" & jefe_directo & "' WHERE id = " & Session("seleccionsinasignar")
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

        ListaAgentesAsignacion()
        ListaAgentes()

    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET status = 8, jefe_directo = NULL WHERE id = " & Session("seleccionsupervisor")
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

        ListaAgentesAsignacion()
        ListaAgentes()

    End Sub
End Class