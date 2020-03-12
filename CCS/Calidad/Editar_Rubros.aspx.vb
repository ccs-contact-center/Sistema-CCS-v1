Imports System.Data.SqlClient
Public Class Editar_Rubros
    Inherits System.Web.UI.Page

    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadPonderaciones()
        LoadAdicionales()
    End Sub

    Sub LoadPonderaciones()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT a.Categoria,b.Rubro  from  (SELECT * FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID where a.rubro <>0 ", conexion)
        Dim ValorID As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))
        conexion.Close()

        For CuentaDS = 1 To ds.Tables(0).Rows.Count

            ValorID = ds.Tables(0).Rows(CuentaDS - 1).Item(0)

            cmd.CommandText = "SELECT c.Subrubro,a.Rubro,a.ponderacion from (SELECT * FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE Categoria = " & ValorID
            cmd.CommandType = CommandType.Text
            conexion.Open()
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

                        Dim CB As New CheckBox
                        CB.ID = "CB" & T
                        CB.Text = ""
                        celda.Controls.Add(CB)
                        FilaSR.Cells.Add(celda)

                    End If
                Next
                tabla.Rows.Add(FilaSR)

            Next
            ''''''''''''''''''''''''''''''''''''''''''

        Next
        Panel2.Controls.Add(tabla)

    End Sub

    Sub LoadAdicionales()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT a.rubro_adic,b.tipifcacion  from (SELECT * FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Tipificaciones b ON A.rubro_Adic = b.ID  where a.rubro =0", conexion)


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
        label.Text = "Rubros Adicionales"
        celda.ColumnSpan = 3
        celda.Controls.Add(label)
        fila.Cells.Add(celda)

        tabla.Rows.Add(fila)


        ''''''''''''''''''''''''''''''''''''''''''
        For Rubros = 1 To ds.Tables(0).Rows.Count

            Dim S As String
            Dim T As String


            Dim FilaSR As New TableRow
            S = ds.Tables(0).Rows(Rubros - 1).Item(1).ToString
            T = ds.Tables(0).Rows(Rubros - 1).Item(0).ToString

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
                    Dim CB As New CheckBox
                    CB.ID = "CBA" & T
                    CB.Text = ""
                    celdaA.Width = 72

                    celdaA.Controls.Add(CB)
                    FilaSR.Cells.Add(celdaA)
                End If
            Next
            tabla.Rows.Add(FilaSR)

        Next
        '''''''''''''''''''''''''''''''''''''''''''

        Panel3.Controls.Add(tabla)



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ConstruyeStringAdic()
        ConstruyeString()
        DeleteRegistros()
        DeleteRegistrosAdic()
        Response.Redirect("Modificar_Ponderacion.aspx")
    End Sub

    Sub ConstruyeString()


        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT *  FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("GuiaSeleccionada") & "' AND rubro <>0", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Dim selectedR As String = Nothing
        Dim idrubro As String

        For i = 1 To ds.Tables(0).Rows.Count
            idrubro = ds.Tables(0).Rows(i - 1).Item(4)

            If CType(Edicion1.Parent.FindControl("CB" & idrubro), CheckBox).Checked = True Then
                selectedR = selectedR & ", " & CType(Edicion1.Parent.FindControl("CB" & idrubro), CheckBox).ID.ToString.TrimStart("C", "B")

            End If
        Next

        If Not selectedR = Nothing Then

            Session("StringCB") = selectedR.TrimStart(",")

        Else

        End If




    End Sub

    Sub ConstruyeStringAdic()


        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT *  FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("GuiaSeleccionada") & "' AND rubro =0", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Dim selectedR As String = Nothing
        Dim idrubro As String

        For i = 1 To ds.Tables(0).Rows.Count
            idrubro = ds.Tables(0).Rows(i - 1).Item(5)

            If CType(Edicion1.Parent.FindControl("CBA" & idrubro), CheckBox).Checked = True Then
                selectedR = selectedR & ", " & CType(Edicion1.Parent.FindControl("CBA" & idrubro), CheckBox).ID.ToString.TrimStart("C", "B", "A")

            End If
        Next

        If Not selectedR = Nothing Then

            Session("StringCBA") = selectedR.TrimStart(",")

        Else

        End If




    End Sub

    Sub DeleteRegistros()

        Try

            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("DELETE FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("GuiaSeleccionada") & "' AND rubro IN (" & Session("StringCB") & ")", conexion)

            conexion.Open()

            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

        Catch ex As Exception

        End Try

    End Sub

    Sub DeleteRegistrosAdic()

        Try

            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("DELETE FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("GuiaSeleccionada") & "' AND rubro_adic IN (" & Session("StringCBA") & ")", conexion)

            conexion.Open()

            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.Fill(ds)

            conexion.Close()

        Catch ex As Exception

        End Try

    End Sub

End Class