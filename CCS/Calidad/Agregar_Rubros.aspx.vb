Imports System.Data.SqlClient

Public Class Agregar_Rubros
    Inherits System.Web.UI.Page


    Public Function GetRubros(Guia As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("EXEC [QA].[dbo].[GET_Rubros_Select] @GUIA = '" & Guia & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetAdicionales(Guia As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("EXEC [QA].[dbo].[GET_Adicionales_Select] @GUIA = '" & Guia & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Sub FillRubros(Combo As DropDownList)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select * FROM [QA].[dbo].[SYS_Rubros]"
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
        Combo.DataTextField = "rubro"
        Combo.DataValueField = "id"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Public Sub FillSubrubros(Combo As DropDownList)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select * FROM [QA].[dbo].[SYS_Subrubros] WHERE id NOT IN (" & GetRubros(Session("GuiaSeleccionada")) & ")"
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
        Combo.DataTextField = "subrubro"
        Combo.DataValueField = "id"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Public Sub FillAdicionales(Combo As DropDownList)
        Try

            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select * FROM [QA].[dbo].[SYS_Tipificaciones] WHERE id NOT IN (" & GetAdicionales(Session("GuiaSeleccionada")) & ")"
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
        Combo.DataTextField = "tipifcacion"
        Combo.DataValueField = "id"
        Combo.DataBind()

        con.Close()
        con.Dispose()

        Catch ex As Exception

        End Try


    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            FillRubros(DropDownList1)
            FillSubrubros(DropDownList2)
            FillAdicionales(DropDownList3)
        End If

    End Sub

    Sub Insert_Rubros()

        Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery1 As String = "INSERT INTO [QA].[dbo].[SYS_guias] (guia,campania,tipo_ponderacion,categoria, rubro) VALUES ('" & Session("GuiaSeleccionada") & "', " & Session("Alta_Campania") & ", " & Session("Alta_Tipo") & ", " & DropDownList1.SelectedItem.Value & ", " & DropDownList2.SelectedItem.Value & ")"
        Dim con1 As New SqlConnection(strConnString1)
        Dim cmd1 As New SqlCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = strQuery1
        cmd1.Connection = con1

        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()

    End Sub

    Sub Insert_Adicionales()

        Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery1 As String = "INSERT INTO [QA].[dbo].[SYS_guias] (guia,campania,tipo_ponderacion,rubro_adic, categoria, rubro) VALUES ('" & Session("GuiaSeleccionada") & "', " & Session("Alta_Campania") & ", " & Session("Alta_Tipo") & ", '" & DropDownList3.SelectedItem.Value & "',0,0)"
        Dim con1 As New SqlConnection(strConnString1)
        Dim cmd1 As New SqlCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = strQuery1
        cmd1.Connection = con1

        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()

    End Sub

    Sub Get_Otros()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT campania,tipo_ponderacion FROM [QA].[dbo].[SYS_Guias] WHERE guia='" & Session("GuiaSeleccionada") & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        Session("Alta_Campania") = ds.Tables(0).Rows(0).Item(0)
        Session("Alta_Tipo") = ds.Tables(0).Rows(0).Item(1)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Get_Otros()
        Insert_Rubros()
        Response.Redirect("Agregar_Rubros.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Get_Otros()
        Insert_Adicionales()
        Response.Redirect("Agregar_Rubros.aspx")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Response.Redirect("Modificar_Ponderacion.aspx")
    End Sub


End Class