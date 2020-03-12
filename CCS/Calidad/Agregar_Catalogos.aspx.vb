Imports System.Data.SqlClient
Public Class Agregar_Catalogos
    Inherits System.Web.UI.Page

    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery1 As String = "INSERT INTO [QA].[dbo].[SYS_Rubros] (rubro) VALUES ('" & TextBox1.Text & "')"
        Dim con1 As New SqlConnection(strConnString1)
        Dim cmd1 As New SqlCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = strQuery1
        cmd1.Connection = con1

        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()
        TextBox1.Text = Nothing
        msgtipo(0) = 1
        msgmensaje(0) = "¡Rubro agregado a Catalogos!"

        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery1 As String = "INSERT INTO [QA].[dbo].[SYS_Subrubros] (subrubro) VALUES ('" & TextBox2.Text & "')"
        Dim con1 As New SqlConnection(strConnString1)
        Dim cmd1 As New SqlCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = strQuery1
        cmd1.Connection = con1

        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()
        TextBox2.Text = Nothing
        msgtipo(0) = 1
        msgmensaje(0) = "¡Subrubro agregado a Catalogos!"

        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery1 As String = "INSERT INTO [QA].[dbo].[SYS_Tipificaciones] (tipifcacion) VALUES ('" & TextBox3.Text & "')"
        Dim con1 As New SqlConnection(strConnString1)
        Dim cmd1 As New SqlCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = strQuery1
        cmd1.Connection = con1

        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()
        TextBox3.Text = Nothing
        msgtipo(0) = 1
        msgmensaje(0) = "¡Rubro adicional agregado a Catalogos!"

        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
    End Sub
End Class