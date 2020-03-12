Imports System.Data.SqlClient

Public Class AltaSR
    Inherits System.Web.UI.Page

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

    Sub Hide_Show_Panel()
        If DropDownList1.SelectedItem.Value = 0 Then

            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Rubros] WHERE ID IN (" & Session("StringRubros") & ")", conexion)

            conexion.Open()

            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            For i = 1 To ds.Tables(0).Rows.Count
                If ds.Tables(0).Rows(i - 1).Item(0).ToString = i Then
                    CType(Contenedor1.Parent.FindControl("Panelito" & ds.Tables(0).Rows(i - 1).Item(0).ToString), Panel).Visible = False
                End If
            Next

        Else
            CType(Contenedor1.Parent.FindControl("Panelito" & DropDownList1.SelectedItem.Value), Panel).Visible = True
        End If
    End Sub

    Sub Hide_Subrubros(Rubro As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Rubros] WHERE ID IN (" & Session("StringRubros") & ")", conexion)
        Dim j As Integer



        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Try

            For i = 1 To ds.Tables(0).Rows.Count
                j = ds.Tables(0).Rows(i - 1).Item(0).ToString


                Dim conexion2 As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
                Dim da2 As New System.Data.SqlClient.SqlDataAdapter
                Dim ds2 As New System.Data.DataSet
                Dim cmd2 As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Subrubros]", conexion2)

                conexion2.Open()

                cmd2.CommandType = CommandType.Text
                da2.SelectCommand = cmd2
                da2.Fill(ds2)
                conexion2.Close()

                For k = 1 To CInt(GetNumSubrubros().ToString)



                    If CType(Contenedor1.Parent.FindControl("CB" & j & "-" & ds2.Tables(0).Rows(k - 1).Item(0).ToString), CheckBox).Checked = True And j <> Rubro Then


                        CType(Contenedor1.Parent.FindControl("CB" & Rubro & "-" & ds2.Tables(0).Rows(k - 1).Item(0).ToString), CheckBox).Visible = False

                    End If

                Next
            Next


        Catch ex As Exception
        End Try

    End Sub

    Sub Show_Subrubros(Rubro As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Rubros] WHERE ID IN (" & Session("StringRubros") & ")", conexion)
        Dim j As Integer


        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Try

            For i = 1 To ds.Tables(0).Rows.Count
                j = ds.Tables(0).Rows(i - 1).Item(0).ToString

                Dim conexion2 As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
                Dim da2 As New System.Data.SqlClient.SqlDataAdapter
                Dim ds2 As New System.Data.DataSet
                Dim cmd2 As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Subrubros]", conexion2)

                conexion2.Open()

                cmd2.CommandType = CommandType.Text
                da2.SelectCommand = cmd2
                da2.Fill(ds2)
                conexion2.Close()

                For k = 1 To CInt(GetNumSubrubros().ToString)

                    CType(Contenedor1.Parent.FindControl("CB" & j & "-" & ds2.Tables(0).Rows(k - 1).Item(0).ToString), CheckBox).Visible = True

                Next
            Next


        Catch ex As Exception
        End Try

    End Sub

    Sub LoadCombo(Combo As DropDownList)
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT * FROM [QA].[dbo].[SYS_Rubros] WHERE ID IN (" & Session("StringRubros") & ")"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        Combo.Items.Add(New ListItem("-Selecciona-", 0))
        Combo.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        Combo.DataSource = cmd.ExecuteReader()
        Combo.DataTextField = "rubro"
        Combo.DataValueField = "id"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Sub CargaPaneles()

        Dim conexion1 As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da1 As New System.Data.SqlClient.SqlDataAdapter
        Dim ds1 As New System.Data.DataSet
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Subrubros]", conexion1)
        conexion1.Open()
        cmd1.CommandType = CommandType.Text
        da1.SelectCommand = cmd1
        da1.Fill(ds1)
        conexion1.Close()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Rubros] WHERE ID IN (" & Session("StringRubros") & ")", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        For i = 1 To ds.Tables(0).Rows.Count

            Dim Panelito As New Panel
            Panelito.ID = "Panelito" & ds.Tables(0).Rows(i - 1).Item(0).ToString
            Contenedor1.Controls.Add(Panelito)
            Panelito.Visible = False

            Dim R As String
            Dim tabla As New Table

            Dim conexion2 As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da2 As New System.Data.SqlClient.SqlDataAdapter
            Dim ds2 As New System.Data.DataSet
            Dim cmd2 As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Subrubros]", conexion2)

            conexion2.Open()

            cmd2.CommandType = CommandType.Text
            da2.SelectCommand = cmd2
            da2.Fill(ds2)
            conexion2.Close()

            For h = 1 To GetNumSubrubros()
                Dim fila As New TableRow
                R = ds1.Tables(0).Rows(h - 1).Item(1).ToString
                For j = 1 To 2
                    Dim celda As New TableCell
                    celda.BorderWidth = 1
                    If j = 1 Then
                        Dim CB As New CheckBox
                        CB.ID = "CB" & ds.Tables(0).Rows(i - 1).Item(0).ToString & "-" & ds2.Tables(0).Rows(h - 1).Item(0).ToString
                        CB.Text = R
                        celda.Controls.Add(CB)
                        fila.Cells.Add(celda)
                    Else

                    End If
                Next
                tabla.Rows.Add(fila)
            Next
            Panelito.Controls.Add(tabla)

        Next

    End Sub

    Sub Llena_Temporal()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("Select * FROM [QA].[dbo].[SYS_Rubros] WHERE ID In (" & Session("StringRubros") & ")", conexion)
        Dim j As Integer

        Dim Categoria As String
        Dim Rubro As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Try

            For i = 1 To ds.Tables(0).Rows.Count
                j = ds.Tables(0).Rows(i - 1).Item(0).ToString

                Dim conexion2 As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
                Dim da2 As New System.Data.SqlClient.SqlDataAdapter
                Dim ds2 As New System.Data.DataSet
                Dim cmd2 As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_Subrubros]", conexion2)

                conexion2.Open()

                cmd2.CommandType = CommandType.Text
                da2.SelectCommand = cmd2
                da2.Fill(ds2)
                conexion2.Close()

                For k = 1 To CInt(GetNumSubrubros().ToString)

                    If CType(Contenedor1.Parent.FindControl("CB" & j & "-" & ds2.Tables(0).Rows(k - 1).Item(0).ToString), CheckBox).Checked = True Then

                        Categoria = CType(Contenedor1.Parent.FindControl("CB" & j & "-" & ds2.Tables(0).Rows(k - 1).Item(0).ToString), CheckBox).ID.TrimStart("C", "B")
                        Rubro = CType(Contenedor1.Parent.FindControl("CB" & j & "-" & ds2.Tables(0).Rows(k - 1).Item(0).ToString), CheckBox).ID.TrimStart("C", "B")

                        Categoria = Left(Categoria, InStr(Categoria, "-") - 1)
                        Rubro = Mid(Rubro, InStr(Rubro, "-") + 1)

                        Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
                        Dim strQuery1 As String = "INSERT INTO " & Replace(Session("Alta_Guia"), " ", "_") & " (guia,campania,tipo_ponderacion,categoria, rubro) VALUES ('" & Session("Alta_Guia") & "', " & Session("Alta_Campania") & ", " & Session("Alta_Tipo") & ", " & Categoria & ", " & Rubro & ")"
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
            Next


        Catch ex As Exception
        End Try

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            LoadCombo(DropDownList1)
        End If
        CargaPaneles()

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

        Hide_Show_Panel()
        Show_Subrubros(DropDownList1.SelectedItem.Value)
        Hide_Subrubros(DropDownList1.SelectedItem.Value)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If HiddenField1.Value = 3 Then
            Response.Redirect("Alta_1.aspx")
        Else
            DropDownList1.SelectedValue = 0
            Button2.Text = "Siguiente"


            Dim ctrl As HtmlGenericControl
            Dim ctrlP As HtmlGenericControl

            ctrl = CType(Alta3.Parent.FindControl("Alta" & HiddenField1.Value - 1), HtmlGenericControl)
            ctrlP = CType(Alta3.Parent.FindControl("Alta" & HiddenField1.Value), HtmlGenericControl)
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
        End If


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Try

            Dim ctrl As HtmlGenericControl
            Dim ctrlP As HtmlGenericControl

            ctrl = CType(Alta3.Parent.FindControl("Alta" & HiddenField1.Value + 1), HtmlGenericControl)
            ctrlP = CType(Alta3.Parent.FindControl("Alta" & HiddenField1.Value), HtmlGenericControl)
            ctrl.Visible = True
            ctrlP.Visible = False
            HiddenField1.Value = HiddenField1.Value + 1


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

        Catch ex As Exception
        End Try


        Try
            If HiddenField1.Value = 4 Then

                Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
                Dim strQuery As String = "CREATE TABLE " & Replace(Session("Alta_Guia"), " ", "_") & " (guia NVARCHAR(MAX),campania INT, tipo_ponderacion INT,categoria INT, rubro INT, rubro_adic INT, ponderacion INT)"
                Dim con As New SqlConnection(strConnString)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = strQuery
                cmd.Connection = con

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Llena_Temporal()
                Response.Redirect("Alta_3.aspx")

            End If

        Catch ex As Exception

            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim strQuery As String = "DROP TABLE " & Replace(Session("Alta_Guia"), " ", "_") & " CREATE TABLE " & Replace(Session("Alta_Guia"), " ", "_") & " (guia NVARCHAR(MAX),campania INT, tipo_ponderacion INT,categoria INT, rubro INT, rubro_adic INT, ponderacion INT)"
            Dim con As New SqlConnection(strConnString)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Llena_Temporal()
            Response.Redirect("Alta_3.aspx")

        End Try

    End Sub






End Class