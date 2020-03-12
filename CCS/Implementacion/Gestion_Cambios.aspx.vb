Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Common
Imports System.IO
Imports System.Drawing





Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Public Sub Insertar()

        Using cnn As New SqlConnection(ConfigurationManager.ConnectionStrings("Imple").ToString())

            Dim cmd As SqlCommand = New SqlCommand("INSERT_Cambios", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cnn.Open()


            cmd.Parameters.AddWithValue("@Numero_de_Solicitud", TextBox607.Text)
            cmd.Parameters.AddWithValue("@Numero_de_Ticket", TextBox609.Text)
            cmd.Parameters.AddWithValue("@Area_Solicitante", TextBox611.Text)
            cmd.Parameters.AddWithValue("@Nombre_Solicitante", TextBox613.Text)
            cmd.Parameters.AddWithValue("@Fecha_Solicitud_Cambios", TextBox615.Text)
            cmd.Parameters.AddWithValue("@Area_Ejecutora", TextBox617.Text)
            cmd.Parameters.AddWithValue("@Nombre_Ejecutor", TextBox619.Text)
            cmd.Parameters.AddWithValue("@Descripcion_de_cambios", TextBox621.Text)
            cmd.Parameters.AddWithValue("@Validacion_Tecnica", TextBox623.Text)
            cmd.Parameters.AddWithValue("@Observaciones_1", TextBox625.Text)
            cmd.Parameters.AddWithValue("@Ajustes_cuantitativos", TextBox631.Text)
            cmd.Parameters.AddWithValue("@Observaciones_2", TextBox633.Text)
            cmd.Parameters.AddWithValue("@Aprobado_nombre", TextBox635.Text)
            cmd.Parameters.AddWithValue("@Aprobado_fecha", TextBox637.Text)
            cmd.Parameters.AddWithValue("@Fecha_Solucion", TextBox639.Text)
            cmd.Parameters.AddWithValue("@Fecha_Ejecucion", TextBox639.Text)
            cmd.Parameters.AddWithValue("@Campaña", DropDownList1.SelectedItem.Text)

            cmd.ExecuteNonQuery()

            cnn.Close()

        End Using
    End Sub

    Sub Limpiar()
        TextBox607.Text = Nothing
        TextBox609.Text = Nothing
        TextBox611.Text = Nothing
        TextBox613.Text = Nothing
        TextBox615.Text = Nothing
        TextBox617.Text = Nothing
        TextBox619.Text = Nothing
        TextBox621.Text = Nothing
        TextBox623.Text = Nothing
        TextBox625.Text = Nothing
        TextBox631.Text = Nothing
        TextBox633.Text = Nothing
        TextBox635.Text = Nothing
        TextBox637.Text = Nothing
        TextBox639.Text = Nothing
        TextBox641.Text = Nothing

    End Sub


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Insertar()
            Limpiar()
            msgtipo(0) = 1
            msgmensaje(0) = "¡Cambios Guardados Correctamente!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        Catch ex As Exception
            msgtipo(0) = 4
            msgmensaje(0) = "¡Revisa que todos los campos estén llenos y con el formato correcto!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End Try

    End Sub

    Public Sub FillCampañas(Combo As DropDownList)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString

        Dim strQuery As String = "Select id, general_nombre_comercial_del_cliente FROM Implementacion.dbo.Ficha_Implementacion"


        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        Combo.Items.Clear()

        Combo.Items.Add(New ListItem("-Selecciona-", 0))
        Combo.AppendDataBoundItems = True





        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        Combo.DataSource = cmd.ExecuteReader()
        Combo.DataTextField = "general_nombre_comercial_del_cliente"
        Combo.DataValueField = "id"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Private Sub WebForm2_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            FillCampañas(DropDownList1)

        End If

    End Sub


    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim comando As New System.Data.SqlClient.SqlCommand
        Dim ds As New System.Data.DataSet
        Dim tablaesta As New DataTable

        Using cnn As New SqlConnection(ConfigurationManager.ConnectionStrings("Imple").ToString())

            Dim da As New SqlDataAdapter("select * from Gestion_Cambios where Campaña ='" & DropDownList1.SelectedItem.Text & "'", cnn)

            cnn.Open()
            da.Fill(tablaesta)
            GridView1.DataSource = tablaesta
            GridView1.DataBind()

        End Using
    End Sub

    Protected Sub DropDownList1_Load(sender As Object, e As EventArgs) Handles DropDownList1.Load

    End Sub
End Class

