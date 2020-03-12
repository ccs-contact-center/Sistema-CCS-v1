Imports System.Data.SqlClient
Public Class Alta_3
    Inherits System.Web.UI.Page

    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Public Function GetTypeControls(Of T As Control)(
        parentContainer As Control, includeInheritedControls As Boolean) As List(Of T)

        If (parentContainer Is Nothing) Then Return Nothing

        Dim controls As New List(Of T)

        ' System.Type para el tipo de dato especificado.
        '
        Dim typeT As Type = GetType(T)

        For Each ctrl As Control In parentContainer.Controls

            If (includeInheritedControls) Then
                If (TypeOf ctrl Is T) Then _
                    controls.Add(DirectCast(ctrl, T))

            Else
                ' System.Type del control.
                '
                Dim typeControl As Type = ctrl.GetType()
                If (typeControl.Equals(typeT)) Then _
                    controls.Add(DirectCast(ctrl, T))

            End If

            controls.AddRange(Me.GetTypeControls(Of T)(ctrl, includeInheritedControls))

        Next

        Return controls

    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadPonderaciones()

    End Sub

    Sub LoadPonderaciones()


        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT a.Categoria,b.Rubro  from " & Replace(Session("Alta_Guia"), " ", "_") & " a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID where a.rubro <>0 ", conexion)
        Dim ValorID As String

            conexion.Open()
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            ds.Tables.Add()
            da.Fill(ds.Tables(0))
        conexion.Close()

        For CuentaDS = 1 To ds.Tables(0).Rows.Count

                ValorID = ds.Tables(0).Rows(CuentaDS - 1).Item(0)

            cmd.CommandText = "SELECT c.Subrubro,a.Rubro  from " & Replace(Session("Alta_Guia"), " ", "_") & " a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE Categoria = " & ValorID

            cmd.CommandType = CommandType.Text
                da.SelectCommand = cmd
                ds.Tables.Add()
                da.Fill(ds.Tables(CuentaDS))
            conexion.Close()

        Next

            Dim R As String
            Dim tabla As New Table
            For i = 1 To ds.Tables(0).Rows.Count
                Dim fila As New TableRow
                R = ds.Tables(0).Rows(i - 1).Item(1).ToString



                For j = 1 To 3
                    Dim celda As New TableCell
                    celda.BorderWidth = 1
                    celda.CssClass = "TablaRubros"

                    If j = 1 Then
                        Dim label As New Label
                        label.ID = "Categoria" & i
                        label.Text = StrConv(R, vbUpperCase)
                        celda.ColumnSpan = 3
                        celda.Controls.Add(label)
                        fila.Cells.Add(celda)
                    ElseIf j = 2 Then
                    Else
                    End If
                Next
                tabla.Rows.Add(fila)

                ''''''''''''''''''''''''''''''''''''''''''
                For Rubros = 1 To ds.Tables(i).Rows.Count

                    Dim S As String
                    Dim T As String
                    Dim FilaSR As New TableRow
                    S = ds.Tables(i).Rows(Rubros - 1).Item(0).ToString
                    T = ds.Tables(i).Rows(Rubros - 1).Item(1).ToString


                    For j = 1 To 3
                        Dim celda As New TableCell
                        celda.BorderWidth = 1


                        If j = 1 Then
                            Dim label As New Label
                            label.ID = "Rubro" & T
                            label.Text = S
                            celda.Controls.Add(label)
                            FilaSR.Cells.Add(celda)
                        ElseIf j = 2 Then
                        Else
                            Dim TXT As New TextBox
                            TXT.ID = "Texto" & T
                            TXT.Width = 20
                            TXT.CssClass = "textos"
                            Dim RFV As New RequiredFieldValidator
                            RFV.ErrorMessage = "*"
                            RFV.Display = ValidatorDisplay.Dynamic
                            RFV.ControlToValidate = TXT.ID
                            RFV.ValidationGroup = "Llenos"
                            RFV.CssClass = "RFV"
                            celda.CssClass = "TablaDerecha"
                            celda.Controls.Add(TXT)
                            celda.Controls.Add(RFV)
                            FilaSR.Cells.Add(celda)

                        End If
                    Next
                    tabla.Rows.Add(FilaSR)

                Next
                ''''''''''''''''''''''''''''''''''''''''''

            Next
            Panel4.Controls.Add(tabla)

    End Sub

    Sub SumaTextBox()

        Try
            Session("Cuenta") = 0
            Dim ctrls As List(Of TextBox) = GetTypeControls(Of TextBox)(Me, False)

            For Each ctrl As Control In ctrls
                If (Not (TypeOf ctrl Is TextBox)) Then
                    Continue For
                End If
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                Session("Cuenta") = Session("Cuenta") + CInt(tb.Text)
            Next


        Catch ex As Exception
            msgtipo(0) = 4
            msgmensaje(0) = "¡Solo puedes ingresar numeros enteros!"

            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End Try

        HiddenField2.Value = Session("Cuenta")

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Alta_2.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


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


        SumaTextBox()

        If Session("Cuenta") = 100 Then
            Update_Ponderacion()
            Response.Redirect("Alta_4.aspx")

        Else
            msgtipo(0) = 3
            msgmensaje(0) = "¡La suma de los rubros no es 100!"

            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End If


    End Sub

    Sub Update_Ponderacion()

        Try
            Dim ctrls As List(Of TextBox) = GetTypeControls(Of TextBox)(Me, False)

            For Each ctrl As Control In ctrls
                If (Not (TypeOf ctrl Is TextBox)) Then
                    Continue For
                End If
                Dim tb As TextBox = DirectCast(ctrl, TextBox)


                Dim RubroSelect As String
                RubroSelect = tb.ID
                RubroSelect = RubroSelect.TrimStart("T", "e", "x", "t", "o")

                Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
                Dim da As New System.Data.SqlClient.SqlDataAdapter
                Dim ds As New System.Data.DataSet
                Dim cmd As SqlCommand = New SqlCommand("UPDATE " & Replace(Session("Alta_Guia"), " ", "_") & " SET ponderacion = '" & tb.Text & "' WHERE rubro = '" & RubroSelect & "'", conexion)


                conexion.Open()
                cmd.CommandType = CommandType.Text
                da.SelectCommand = cmd
                ds.Tables.Add()
                da.Fill(ds.Tables(0))
                'conexion.Close()

            Next


        Catch ex As Exception
            msgtipo(0) = 4
            msgmensaje(0) = "¡Solo puedes ingresar numeros enteros!"

            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End Try

        HiddenField2.Value = Session("Cuenta")


    End Sub

End Class