Imports System.Data.SqlClient
Public Class Alta_Guias

    Inherits Page
    Dim x As New Funciones
    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Function GetNumRubros()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM [QA].[dbo].[SYS_Rubros]", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()
        Return CInt(ds.Tables(0).Rows(0).Item(0).ToString)

    End Function

    Function GetNumSubrubros()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM [QA].[dbo].[SYS_Subrubros]", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()
        Return CInt(ds.Tables(0).Rows(0).Item(0).ToString)

    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            x.FillCampañas(DropDownList1, False)
        Else
            CargaRubros()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button2.Text = "Siguiente"


        Dim ctrl As HtmlGenericControl
        Dim ctrlP As HtmlGenericControl

        ctrl = CType(Alta1.Parent.FindControl("Alta" & HiddenField1.Value - 1), HtmlGenericControl)
        ctrlP = CType(Alta1.Parent.FindControl("Alta" & HiddenField1.Value), HtmlGenericControl)
        ctrl.Visible = True
        ctrlP.Visible = False
        HiddenField1.Value = HiddenField1.Value - 1
        If HiddenField1.Value = 1 Then
            Button1.Visible = False
        Else
        End If

        If HiddenField1.Value = 1 Then
            Label1.Text = "Selecciona Campaña"
        ElseIf HiddenField1.Value = 2 Then
            Label1.Text = "Selecciona Rubros y Tipo de Evaluación"
        ElseIf HiddenField1.Value = 3 Then
            Label1.Text = "Selecciona Subrubros"
        ElseIf HiddenField1.Value = 4 Then
            Label1.Text = "Ingresa Ponderaciones"
        ElseIf HiddenField1.Value = 5 Then
            Label1.Text = "Verifica Resumen"
        End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            If HiddenField1.Value = 2 Then
                HiddenField1.Value = HiddenField1.Value + 1

            Else

                Dim ctrl As HtmlGenericControl
                Dim ctrlP As HtmlGenericControl

                ctrl = CType(Alta1.Parent.FindControl("Alta" & HiddenField1.Value + 1), HtmlGenericControl)
                ctrlP = CType(Alta1.Parent.FindControl("Alta" & HiddenField1.Value), HtmlGenericControl)
                ctrl.Visible = True
                ctrlP.Visible = False
                HiddenField1.Value = HiddenField1.Value + 1
                If HiddenField1.Value > 1 Then
                    Button1.Visible = True
                Else
                End If

                If HiddenField1.Value = 5 Then
                    Button2.Text = "Guardar"
                Else
                    Button2.Text = "Siguiente"
                End If

                If HiddenField1.Value = 1 Then
                    Label1.Text = "Selecciona Campaña"
                ElseIf HiddenField1.Value = 2 Then
                    Label1.Text = "Selecciona Rubros y Tipo de Evaluación"
                ElseIf HiddenField1.Value = 3 Then
                    Label1.Text = "Selecciona Subrubros"
                ElseIf HiddenField1.Value = 4 Then
                    Label1.Text = "Ingresa Ponderaciones"
                ElseIf HiddenField1.Value = 5 Then
                    Label1.Text = "Verifica Resumen"
                End If

            End If

        Catch ex As Exception
        End Try


        Try

            If HiddenField1.Value - 1 = 2 Then

                Dim selectedR As String = Nothing

                Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
                Dim da As New System.Data.SqlClient.SqlDataAdapter
                Dim ds As New System.Data.DataSet
                Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Rubros]", conexion)

                conexion.Open()

                cmd.CommandType = CommandType.Text
                da.SelectCommand = cmd
                da.Fill(ds)
                conexion.Close()

                For i = 1 To GetNumRubros()
                    If CType(Alta2.Parent.FindControl("CheckBoxR" & ds.Tables(0).Rows(i - 1).Item(0).ToString), CheckBox).Checked = True Then
                        selectedR = selectedR & ", " & CType(Alta2.Parent.FindControl("HiddenFieldR" & ds.Tables(0).Rows(i - 1).Item(0).ToString), HiddenField).Value.ToString

                    End If
                Next

                If Not selectedR = Nothing Then

                    Session("StringRubros") = selectedR.TrimStart(",")

                    Session("Alta_Campania") = DropDownList1.SelectedItem.Value
                    Session("Alta_Guia") = TextBox1.Text
                    Session("Alta_Tipo") = DropDownList2.SelectedItem.Value
                    Response.Redirect("Alta_2.aspx")


                Else
                    msgtipo(0) = 4
                    msgmensaje(0) = "¡Debes seleccionar al menos una categoría!"

                    Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                End If
            End If

        Catch ex As Exception


        End Try

    End Sub

    Sub CargaRubros()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Rubros]", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Dim R As String
        Dim tabla As New Table

        For i = 1 To GetNumRubros()
            Dim fila As New TableRow
            R = ds.Tables(0).Rows(i - 1).Item(1).ToString
            For j = 1 To 2
                Dim celda As New TableCell
                celda.BorderWidth = 1
                If j = 1 Then
                    Dim label As New CheckBox
                    label.ID = "CheckBoxR" & ds.Tables(0).Rows(i - 1).Item(0).ToString
                    label.Text = R
                    celda.Controls.Add(label)
                    fila.Cells.Add(celda)
                Else
                    Dim caja As New HiddenField
                    caja.ID = "HiddenFieldR" & ds.Tables(0).Rows(i - 1).Item(0).ToString
                    caja.Value = i
                    celda.Controls.Add(caja)
                    fila.Cells.Add(celda)
                End If
            Next
            tabla.Rows.Add(fila)
        Next
        Panel2.Controls.Add(tabla)

    End Sub

End Class