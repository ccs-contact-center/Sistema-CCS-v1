Imports System.Data.SqlClient
Public Class Incidencias
    Inherits System.Web.UI.Page

    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Public Function GetPassStatus(UserName As String) As Boolean

        Dim sql As String = "SELECT COUNT(*) FROM SYS_empleados WHERE id_ccs = @user AND status = 2 AND su IS NOT NULL"
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString())

            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", UserName)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                Return False
            Else
                Return True

            End If

        End Using

    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If GetPassStatus(Request.Cookies("UserSettings")("Username")) = False Then
            Response.Redirect("Password.aspx")
        Else

        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Buscador()
    End Sub

    Sub Buscador()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT  Id,Nombre,Asistencia,Hora_Extra as [Horas Extras],Comentario FROM OP_Asistencia WHERE idmitrol = '" & TextBox1.Text & "' AND Fecha_Asistencia = '" & TextBox2.Text & "'" & " AND supervisor = '" & Request.Cookies("Usersettings")("Username") & "'"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView2.DataSource = cmd.ExecuteReader()
        GridView2.DataBind()

        If GridView2.Rows.Count = 0 Then
            msgtipo(0) = 4
            msgmensaje(0) = "¡No se encontraron registros o el agente no pertenece a tu plantilla!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        Else

        End If

        con.Close()
        con.Dispose()

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
            Session("Agente") = String.Format("{1}", e.CommandArgument, GridView2.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
        End If
        Llena_Campos()
        CheckBox2.Enabled = True
    End Sub

    Protected Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then

            TextBox4.Enabled = True
            DropDownList1.Enabled = True
            TextBox3.Enabled = True
            TextBox16.Enabled = True
        Else

            TextBox4.Enabled = False
            DropDownList1.Enabled = False
            TextBox3.Enabled = False
            TextBox16.Enabled = False

        End If
    End Sub

    Sub Llena_Campos()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT nombre,asistencia,hora_extra,comentario FROM OP_Asistencia WHERE id = '" & Session("Agente") & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()



        TextBox4.Text = ds.Tables(0).Rows(0).Item(0).ToString
        DropDownList1.SelectedValue = ds.Tables(0).Rows(0).Item(1).ToString
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2).ToString
        TextBox16.Text = ds.Tables(0).Rows(0).Item(3).ToString

    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Page.Validate()

        If (Page.IsValid) Then
            UpdatePanel2.Visible = True
        Else
        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New Funciones

        If Autentificacion.AuthValidacion(TextBox13.Text, TextBox14.Text) Then
            Valida()
        Else
            msgtipo(0) = 4
            msgmensaje(0) = "¡La clave de validador es incorrecta!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End If
    End Sub

    Sub Valida()

        Guardar()

    End Sub

    Sub Guardar()

        Dim x As New Funciones




        Dim validador As String
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        validador = LCase(TextBox13.Text)



        Dim strQuery As String = "UPDATE OP_Asistencia SET Fecha_Modificacion=GETDATE(), asistencia='" & DropDownList1.SelectedValue.ToString & "',hora_extra='" & TextBox3.Text & "',comentario='" & TextBox16.Text & "' WHERE id = '" & Session("Agente") & "'"

        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

        msgtipo(0) = 1
        msgmensaje(0) = "¡Se actualizó la asistencia!"
        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)


        Limpiar()

    End Sub

    Sub Limpiar()



        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox16.Text = ""
        DropDownList1.SelectedValue = 0
        CheckBox2.Checked = False
        UpdatePanel2.Visible = False

        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox16.Enabled = False
        DropDownList1.Enabled = False

        'Response.Redirect("\Content\Default.aspx")

    End Sub

End Class