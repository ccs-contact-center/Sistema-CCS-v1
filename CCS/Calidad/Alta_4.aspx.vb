Imports System.Data.SqlClient

Public Class Alta_4
    Inherits System.Web.UI.Page

    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Function GetNumTips()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM [QA].[dbo].[SYS_Tipificaciones]", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return CInt(ds.Tables(0).Rows(0).Item(0).ToString)

    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CargaRubros()


    End Sub

    Sub CargaRubros()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Tipificaciones]", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Dim Tipis As Integer
        Tipis = GetNumTips()
        Dim R As String
        Dim S As String

        Dim tabla As New Table

        For i = 1 To Tipis
            Dim fila As New TableRow

            For j = 1 To 3
                Dim celda As New TableCell
                celda.BorderWidth = 1
                celda.Width = "500"

                If j = 1 Then
                    Try
                        R = ds.Tables(0).Rows(i - 1).Item(1).ToString
                        S = ds.Tables(0).Rows(i - 1).Item(0).ToString
                        Dim CB As New CheckBox
                        CB.ID = "CB" & S
                        CB.Text = R
                        celda.Controls.Add(CB)
                        fila.Cells.Add(celda)
                        i = i + 1
                    Catch ex As Exception
                    End Try
                ElseIf j = 2
                    Try
                        R = ds.Tables(0).Rows(i - 1).Item(1).ToString
                        S = ds.Tables(0).Rows(i - 1).Item(0).ToString
                        Dim CB As New CheckBox
                        CB.ID = "CB" & S
                        CB.Text = R
                        celda.Controls.Add(CB)
                        fila.Cells.Add(celda)
                        i = i + 1
                    Catch ex As Exception
                    End Try
                Else
                    Try
                        R = ds.Tables(0).Rows(i - 1).Item(1).ToString
                        S = ds.Tables(0).Rows(i - 1).Item(0).ToString
                        Dim CB As New CheckBox
                        CB.ID = "CB" & S
                        CB.Text = R
                        celda.Controls.Add(CB)
                        fila.Cells.Add(celda)

                    Catch ex As Exception

                    End Try
                End If
            Next
            tabla.Rows.Add(fila)
        Next
        Panel5.Controls.Add(tabla)


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If HiddenField1.Value = 5 Then

            Response.Redirect("Alta_3.aspx")

        Else
            DeleteRA()

            Button2.Text = "Siguiente"


            Dim ctrl As HtmlGenericControl
            Dim ctrlP As HtmlGenericControl

            ctrl = CType(Alta5.Parent.FindControl("Alta" & HiddenField1.Value - 1), HtmlGenericControl)
            ctrlP = CType(Alta5.Parent.FindControl("Alta" & HiddenField1.Value), HtmlGenericControl)
            ctrl.Visible = True
            ctrlP.Visible = False
            HiddenField1.Value = HiddenField1.Value - 1


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
            Label1.Text = "Selecciona Rubros Adicionales"
        Else
            Label1.Text = "Verifica Resumen"
        End If


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'AGREGADO
        For i = 1 To 2
            If CType(Alta5.Parent.FindControl("CB" & i), CheckBox).Checked = False Then
                msgtipo(0) = 4
                msgmensaje(0) = "¡Necesitas agregar al menos un rubro adicional!"

                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            Else
                msgtipo(0) = 2
                msgmensaje(0) = "Verifica Resumen"

                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

            End If
        Next


        Dim ctrl As HtmlGenericControl
        Dim ctrlP As HtmlGenericControl

            ctrl = CType(Alta5.Parent.FindControl("Alta" & HiddenField1.Value + 1), HtmlGenericControl)
            ctrlP = CType(Alta5.Parent.FindControl("Alta" & HiddenField1.Value), HtmlGenericControl)
            ctrl.Visible = True
            ctrlP.Visible = False
            HiddenField1.Value = HiddenField1.Value + 1


        If HiddenField1.Value = 6 Then
            Button2.Text = "Siguiente"
            Button2.Text = "Guardar"
            ConstruyeString()
            Llena_Temporal()
            LoadPonderaciones()
            LoadAdicionales()
        ElseIf HiddenField1.Value = 7 Then
            LlenaTablaGuias()
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
            Label1.Text = "Selecciona Rubros Adicionales"
        Else
            Label1.Text = "Verifica Resumen"
        End If

    End Sub

    Sub ConstruyeString()

        Dim selectedR As String = Nothing

            For i = 1 To GetNumTips()
                If CType(Alta5.Parent.FindControl("CB" & i), CheckBox).Checked = True Then
                    selectedR = selectedR & ", " & CType(Alta5.Parent.FindControl("CB" & i), CheckBox).ID.ToString.TrimStart("C", "B")

                End If
            Next

            If Not selectedR = Nothing Then

                Session("StringCB") = selectedR.TrimStart(",")

            Else

            End If

    End Sub

    Sub Llena_Temporal()

        Try

            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("Select * FROM [QA].[dbo].[SYS_Tipificaciones] WHERE ID In (" & Session("StringCB") & ")", conexion)
            Dim j As Integer

            Dim Categoria As String


            conexion.Open()
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()


            For i = 1 To ds.Tables(0).Rows.Count
                j = ds.Tables(0).Rows(i - 1).Item(0).ToString

                If CType(Alta5.Parent.FindControl("CB" & j), CheckBox).Checked = True Then

                    Categoria = CType(Alta5.Parent.FindControl("CB" & j), CheckBox).ID.TrimStart("C", "B")

                    Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
                    Dim strQuery1 As String = "INSERT INTO " & Replace(Session("Alta_Guia"), " ", "_") & " (guia,campania,tipo_ponderacion,categoria, rubro, rubro_adic) VALUES ('" & Session("Alta_Guia") & "', " & Session("Alta_Campania") & ", " & Session("Alta_Tipo") & ", 0,0 ," & Categoria & ")"
                    Dim con1 As New SqlConnection(strConnString1)
                    Dim cmd1 As New SqlCommand()
                    cmd1.CommandType = CommandType.Text
                    cmd1.CommandText = strQuery1
                    cmd1.Connection = con1

                    con1.Open()
                    cmd1.ExecuteNonQuery()
                    con1.Close()

                End If

            Next


        Catch ex As Exception
        End Try

    End Sub

    Sub DeleteRA()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM " & Replace(Session("Alta_Guia"), " ", "_") & " WHERE ponderacion IS NULL", conexion)

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

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

            cmd.CommandText = "SELECT c.Subrubro,a.Rubro,a.ponderacion  from " & Replace(Session("Alta_Guia"), " ", "_") & " a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE Categoria = " & ValorID

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
                Dim U As String
                Dim FilaSR As New TableRow
                S = ds.Tables(i).Rows(Rubros - 1).Item(0).ToString
                T = ds.Tables(i).Rows(Rubros - 1).Item(1).ToString
                U = ds.Tables(i).Rows(Rubros - 1).Item(2).ToString


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
                        Dim TXT As New Label
                        TXT.ID = "Texto" & T
                        TXT.Text = U & "%"
                        TXT.CssClass = "textos"
                        celda.CssClass = "TablaDerecha"
                        celda.Controls.Add(TXT)
                        FilaSR.Cells.Add(celda)

                    End If
                Next
                tabla.Rows.Add(FilaSR)

            Next
            ''''''''''''''''''''''''''''''''''''''''''

        Next
        Panel6.Controls.Add(tabla)

    End Sub

    Sub LoadAdicionales()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT a.rubro_adic,b.tipifcacion  from " & Replace(Session("Alta_Guia"), " ", "_") & " a LEFT JOIN QA.DBO.SYS_Tipificaciones b ON A.rubro_Adic = b.ID  where a.rubro =0", conexion)


        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        Dim tabla As New Table
        Dim celda As New TableCell
        Dim fila As New TableRow
        celda.BorderWidth = 1
        celda.CssClass = "TablaRubros"

        Dim label As New Label
        label.ID = "CategoriaAD" '& i
        label.Text = "RUBROS ADICIONALES"
        celda.ColumnSpan = 3
        celda.Controls.Add(label)
        fila.Cells.Add(celda)

        tabla.Rows.Add(fila)


        ''''''''''''''''''''''''''''''''''''''''''
        For Rubros = 1 To ds.Tables(0).Rows.Count

            Dim S As String


            Dim FilaSR As New TableRow
            S = ds.Tables(0).Rows(Rubros - 1).Item(1).ToString

            For j = 1 To 3
                Dim celdaA As New TableCell
                celdaA.BorderWidth = 1

                If j = 1 Then
                    Dim labelA As New Label
                    labelA.ID = "RubroAD" & Rubros
                    labelA.Text = S
                    celdaA.Controls.Add(labelA)
                    FilaSR.Cells.Add(celdaA)
                ElseIf j = 2 Then
                Else


                End If
            Next
            tabla.Rows.Add(FilaSR)

        Next
        ''''''''''''''''''''''''''''''''''''''''''

        Panel6.Controls.Add(tabla)

    End Sub

    Sub LlenaTablaGuias()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [QA].[dbo].[SYS_Guias] SELECT * FROM " & Replace(Session("Alta_Guia"), " ", "_"), conexion)

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        BorraTemporal()

        msgtipo(0) = 1
        msgmensaje(0) = "¡Guia Guardada Correctamente!"

        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

    End Sub

    Sub BorraTemporal()
        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("DROP TABLE " & Replace(Session("Alta_Guia"), " ", "_"), conexion)

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()
    End Sub

End Class