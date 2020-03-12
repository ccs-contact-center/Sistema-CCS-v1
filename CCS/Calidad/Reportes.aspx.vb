Imports System.Data.SqlClient
Imports System.Net.NetworkCredential
Imports System.Net
Imports Microsoft.Reporting.WebForms
Imports System.Security.Principal

Public Class Reportes
    Inherits System.Web.UI.Page

    Dim x As New Funciones

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If GetGrupoParam(DropDownList1.SelectedValue) = 0 Then

            ReportViewer1.ServerReport.ReportServerCredentials = New ReportServerCredentials("Isaac", "PPl4t3nt0?", ".\")
            ReportViewer1.ServerReport.ReportPath = GetRSURL(DropDownList1.SelectedValue)
            ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://10.0.0.40/reportss")
            ReportViewer1.Visible = True
            Dim serverReport As ServerReport
            serverReport = ReportViewer1.ServerReport

        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 1 Then

            ReportViewer1.ServerReport.ReportServerCredentials = New ReportServerCredentials("Isaac", "PPl4t3nt0?", ".\")
            ReportViewer1.ServerReport.ReportPath = GetRSURL(DropDownList1.SelectedValue)
            ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://10.0.0.40/reportss")
            ReportViewer1.Visible = True
            Dim serverReport As ServerReport
            serverReport = ReportViewer1.ServerReport

            Dim Fecha_INI As New ReportParameter()
            Fecha_INI.Name = "FECHA_INI"
            Fecha_INI.Values.Add(CDate(TextBox1.Text))
            Dim Fecha_FIN As New ReportParameter()
            Fecha_FIN.Name = "FECHA_FIN"
            Fecha_FIN.Values.Add(CDate(TextBox2.Text))
            Dim parameters() As ReportParameter = {Fecha_INI, Fecha_FIN}
            serverReport.SetParameters(parameters)

        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 2 Then

            ReportViewer1.ServerReport.ReportServerCredentials = New ReportServerCredentials("Isaac", "PPl4t3nt0?", ".\")
            ReportViewer1.ServerReport.ReportPath = GetRSURL(DropDownList1.SelectedValue)
            ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://10.0.0.40/reportss")
            ReportViewer1.Visible = True
            Dim serverReport As ServerReport
            serverReport = ReportViewer1.ServerReport
            Dim Fecha_INI As New ReportParameter()
            Fecha_INI.Name = "FECHA_INI"
            Fecha_INI.Values.Add(CDate(TextBox1.Text))
            Dim Fecha_FIN As New ReportParameter()
            Fecha_FIN.Name = "FECHA_FIN"
            Fecha_FIN.Values.Add(CDate(TextBox2.Text))
            Dim Campaña As New ReportParameter()
            Campaña.Name = "CAMPANIA"
            If DropDownList1.SelectedValue = 33 Then
                Campaña.Values.Add(DropDownList2.SelectedValue)
            Else
                Campaña.Values.Add(DropDownList2.SelectedItem.Text)
            End If

            Campaña.Values.Add(DropDownList2.SelectedItem.Text)
            Dim parameters() As ReportParameter = {Fecha_INI, Fecha_FIN, Campaña}
            serverReport.SetParameters(parameters)

        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 3 Then

            ReportViewer1.ServerReport.ReportServerCredentials = New ReportServerCredentials("Isaac", "PPl4t3nt0?", ".\")
            ReportViewer1.ServerReport.ReportPath = GetRSURL(DropDownList1.SelectedValue)
            ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://10.0.0.40/reportss")
            ReportViewer1.Visible = True
            Dim serverReport As ServerReport
            serverReport = ReportViewer1.ServerReport
            Dim Fecha_INI As New ReportParameter()
            Fecha_INI.Name = "FECHA_INI"
            Fecha_INI.Values.Add(CDate(TextBox1.Text))
            Dim Fecha_FIN As New ReportParameter()
            Fecha_FIN.Name = "FECHA_FIN"
            Fecha_FIN.Values.Add(CDate(TextBox2.Text))
            Dim Guia As New ReportParameter()
            Guia.Name = "GUIA"
            Guia.Values.Add(DropDownList3.SelectedItem.Text)
            Dim parameters() As ReportParameter = {Fecha_INI, Fecha_FIN, Guia}
            serverReport.SetParameters(parameters)

        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 4 Then

            ReportViewer1.ServerReport.ReportServerCredentials = New ReportServerCredentials("Isaac", "PPl4t3nt0?", ".\")
            ReportViewer1.ServerReport.ReportPath = GetRSURL(DropDownList1.SelectedValue)
            ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://10.0.0.40/reportss")
            ReportViewer1.Visible = True
            Dim serverReport As ServerReport
            serverReport = ReportViewer1.ServerReport
            Dim Fecha_INI As New ReportParameter()
            Fecha_INI.Name = "FECHA_INI"
            Fecha_INI.Values.Add(CDate(TextBox1.Text))
            Dim Fecha_FIN As New ReportParameter()
            Fecha_FIN.Name = "FECHA_FIN"
            Fecha_FIN.Values.Add(CDate(TextBox2.Text))
            Dim Guia As New ReportParameter()
            Guia.Name = "GUIA"
            Guia.Values.Add(DropDownList3.SelectedItem.Text)
            Dim Motivos As New ReportParameter()
            Motivos.Name = "MOTIVOS"
            Motivos.Values.Add(TextBox3.Text)
            Dim parameters() As ReportParameter = {Fecha_INI, Fecha_FIN, Guia, Motivos}
            serverReport.SetParameters(parameters)

        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 5 Then

            ReportViewer1.ServerReport.ReportServerCredentials = New ReportServerCredentials("Isaac", "PPl4t3nt0?", ".\")
            ReportViewer1.ServerReport.ReportPath = GetRSURL(DropDownList1.SelectedValue)
            ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://10.0.0.40/reportss")
            ReportViewer1.Visible = True
            Dim serverReport As ServerReport
            serverReport = ReportViewer1.ServerReport
            Dim Fecha_INI As New ReportParameter()
            Fecha_INI.Name = "FECHA_INI"
            Fecha_INI.Values.Add(CDate(TextBox1.Text))
            Dim Fecha_FIN As New ReportParameter()
            Fecha_FIN.Name = "FECHA_FIN"
            Fecha_FIN.Values.Add(CDate(TextBox2.Text))
            Dim Campaña As New ReportParameter()
            Campaña.Name = "CAMPANIA"

            If DropDownList2.SelectedValue = "X" Then
                Campaña.Values.Add(Nothing)
            Else
                Campaña.Values.Add(DropDownList2.SelectedValue)
            End If

            Dim Supervisor As New ReportParameter()
            Supervisor.Name = "SUPERVISOR"
            If DropDownList3.SelectedValue = "X" Then
                Supervisor.Values.Add(Nothing)
            Else
                Supervisor.Values.Add(DropDownList3.SelectedItem.Text)
            End If

            Dim parameters() As ReportParameter = {Fecha_INI, Fecha_FIN, Supervisor, Campaña}
            serverReport.SetParameters(parameters)

        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 6 Then

            ReportViewer1.ServerReport.ReportServerCredentials = New ReportServerCredentials("Isaac", "PPl4t3nt0?", ".\")
            ReportViewer1.ServerReport.ReportPath = GetRSURL(DropDownList1.SelectedValue)
            ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://10.0.0.40/reportss")
            ReportViewer1.Visible = True
            Dim serverReport As ServerReport
            serverReport = ReportViewer1.ServerReport
            Dim Fecha_INI As New ReportParameter()
            Fecha_INI.Name = "FECHA_INI"
            Fecha_INI.Values.Add(CDate(TextBox1.Text))
            Dim Fecha_FIN As New ReportParameter()
            Fecha_FIN.Name = "FECHA_FIN"
            Fecha_FIN.Values.Add(CDate(TextBox2.Text))
            Dim Tipo As New ReportParameter()
            Tipo.Name = "TIPO"
            Tipo.Values.Add(DropDownList3.SelectedValue)
            Dim Campania As New ReportParameter()
            Campania.Name = "CAMPANIA"
            Campania.Values.Add(DropDownList2.SelectedValue)
            Dim parameters() As ReportParameter = {Fecha_INI, Fecha_FIN, Tipo, Campania}
            serverReport.SetParameters(parameters)

        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 7 Then

            ReportViewer1.ServerReport.ReportServerCredentials = New ReportServerCredentials("Isaac", "PPl4t3nt0?", ".\")
            ReportViewer1.ServerReport.ReportPath = GetRSURL(DropDownList1.SelectedValue)
            ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://10.0.0.40/reportss")
            ReportViewer1.Visible = True
            Dim serverReport As ServerReport
            serverReport = ReportViewer1.ServerReport
            Dim Fecha_INI As New ReportParameter()
            Fecha_INI.Name = "FECHA_INI"
            Fecha_INI.Values.Add(CDate(TextBox1.Text))
            Dim Fecha_FIN As New ReportParameter()
            Fecha_FIN.Name = "FECHA_FIN"
            Fecha_FIN.Values.Add(CDate(TextBox2.Text))
            Dim Base As New ReportParameter()
            Base.Name = "BASE"
            Base.Values.Add(DropDownList2.SelectedValue)
            Dim parameters() As ReportParameter = {Fecha_INI, Fecha_FIN, Base}
            serverReport.SetParameters(parameters)

        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 8 Then

            ReportViewer1.ServerReport.ReportServerCredentials = New ReportServerCredentials("Isaac", "PPl4t3nt0?", ".\")
            ReportViewer1.ServerReport.ReportPath = GetRSURL(DropDownList1.SelectedValue)
            ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://10.0.0.40/reportss")
            ReportViewer1.Visible = True
            Dim serverReport As ServerReport
            serverReport = ReportViewer1.ServerReport

            Dim Campaña As New ReportParameter()
            Campaña.Name = "CAMPANIA"

            If DropDownList2.SelectedValue = "X" Then
                Campaña.Values.Add(Nothing)
            Else
                Campaña.Values.Add(DropDownList2.SelectedValue)
            End If

            Dim parameters() As ReportParameter = {Campaña}
            serverReport.SetParameters(parameters)
        Else
            Exit Sub
        End If

        Dim columna As String

        If Request.Cookies("Usersettings")("Area") = 0 Then
            columna = "operaciones"
        ElseIf Request.Cookies("Usersettings")("Area") = 1 Then
            columna = "calidad"
        ElseIf Request.Cookies("Usersettings")("Area") = 2 Then
            columna = "command"
        ElseIf Request.Cookies("Usersettings")("Area") = 3 Then
            columna = "capacitacion"
        ElseIf Request.Cookies("Usersettings")("Area") = 4 Then
            columna = "rh"
        ElseIf Request.Cookies("Usersettings")("Area") = 5 Then
            columna = "reclutamiento"
        ElseIf Request.Cookies("Usersettings")("Area") = 6 Then
            columna = "comercial"
        Else
            columna = "command"
        End If


        Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery1 As String = "UPDATE CCS.dbo.SYS_reportes SET " & columna & " = " & GetLastExec(Session("reportId"), columna) + 1 & " WHERE id = " & Session("reportId")

        Dim con1 As New SqlConnection(strConnString1)
        Dim cmd1 As New SqlCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = strQuery1
        cmd1.Connection = con1

        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()




    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged

        If GetGrupoParam(DropDownList1.SelectedValue) = 3 Or GetGrupoParam(DropDownList1.SelectedValue) = 4 Then
            x.FillDependiente(DropDownList2, DropDownList3)
        End If

    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles Me.Load

        UNO.Visible = False
        DOS.Visible = False
        CUATRO.Visible = False

        Try
            If GetGrupoParam(DropDownList1.SelectedValue) = 0 Then

            ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 1 Then
                UNO.Visible = True
            ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 2 Then
                UNO.Visible = True
                DOS.Visible = True
                Label1.Visible = False
                DropDownList3.Visible = False
                RequiredFieldValidator5.Visible = False
            ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 3 Then
                UNO.Visible = True
                DOS.Visible = True
                Label1.Visible = True
                DropDownList3.Visible = True
                RequiredFieldValidator5.Visible = True
                If Not IsPostBack Then
                    x.FillDependiente(DropDownList2, DropDownList3)
                End If
            ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 4 Then
                UNO.Visible = True
                DOS.Visible = True
                CUATRO.Visible = True
                Label1.Visible = True
                DropDownList3.Visible = True
                RequiredFieldValidator5.Visible = True
                If Not IsPostBack Then
                    x.FillDependiente(DropDownList2, DropDownList3)
                End If
            ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 5 Then
                UNO.Visible = True
                DOS.Visible = True
                Label1.Visible = True
                Label1.Text = "Supervisor:"
                DropDownList3.Visible = True
                RequiredFieldValidator5.Visible = True
                If Not IsPostBack Then
                    x.FillSupervisor(DropDownList3)
                    x.FillCampañas(DropDownList2, True)
                End If
            ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 6 Then
                UNO.Visible = True
                DOS.Visible = True
                Label1.Visible = True
                Label1.Text = "Agrupado:"
                DropDownList3.Visible = True
                RequiredFieldValidator5.Visible = True
                If Not IsPostBack Then
                    x.FillAgrupado(DropDownList3)
                End If
            ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 7 Then
                UNO.Visible = True
                DOS.Visible = True
                Label1.Visible = False
                DropDownList3.Visible = False
                RequiredFieldValidator5.Visible = False
                If Not IsPostBack Then
                    x.FillBDD(DropDownList2, "01/01/1900", "02/01/1900", Request.QueryString("campania"))
                End If
                'DropDownList2.Items.Clear()
                'DropDownList2.Items.Add(New ListItem("-Selecciona-", 0))
            ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 8 Then
                UNO.Visible = False
                DOS.Visible = True
                Label1.Visible = False
                DropDownList3.Visible = False
                RequiredFieldValidator5.Visible = False
                If Not IsPostBack Then
                    x.FillCampañas(DropDownList2, True)
                End If
            End If
        Catch ex As Exception

        End Try



        If Not IsPostBack Then
            LoadReportes()
            x.FillCampañas(DropDownList2, False)
        End If



    End Sub

    Sub LoadReportes()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String
        If Request.Cookies("Usersettings")("MTY") = "True" Then
            strQuery = "SELECT * FROM CCS.dbo.SYS_Reportes WHERE id IN (12,15,16,45,13,14) AND status = 1 AND grupo_reportes =" & Request.QueryString("reportindex") & " AND campania = " & Request.QueryString("campania") & " ORDER BY nombre_rep"
        ElseIf Request.Cookies("Usersettings")("ARA") = "True" Then
            strQuery = "SELECT * FROM CCS.dbo.SYS_Reportes WHERE id IN (12,15,16,13,14) AND status = 1 AND grupo_reportes =" & Request.QueryString("reportindex") & " AND campania = " & Request.QueryString("campania") & " ORDER BY nombre_rep"
        Else
            strQuery = "SELECT * FROM CCS.dbo.SYS_Reportes WHERE status = 1 AND grupo_reportes =" & Request.QueryString("reportindex") & " AND campania = " & Request.QueryString("campania") & " ORDER BY nombre_rep"
        End If

        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        DropDownList1.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList1.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList1.DataSource = cmd.ExecuteReader()
        DropDownList1.DataTextField = "nombre_REP"
        DropDownList1.DataValueField = "id"
        DropDownList1.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Function GetGrupoParam(id As Integer) As Integer

        Try

            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim conexion As New SqlConnection(strConnString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet

            Dim cmd As SqlCommand = New SqlCommand("SELECT grupo_parametros FROM CCS.dbo.SYS_reportes WHERE id = " & id, conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString

        Catch ex As Exception
            Return 0
        End Try

    End Function

    Function GetRSURL(id As Integer) As String

        Try

            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim conexion As New SqlConnection(strConnString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet

            Dim cmd As SqlCommand = New SqlCommand("SELECT url_RS FROM CCS.dbo.SYS_reportes WHERE id = " & id, conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString

        Catch ex As Exception
            Return 0
        End Try

    End Function

    Private Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

        If GetGrupoParam(DropDownList1.SelectedValue) = 0 Then

        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 1 Then
            UNO.Visible = True
        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 2 Then
            UNO.Visible = True
            DOS.Visible = True
            Label1.Visible = False
            DropDownList3.Visible = False
            RequiredFieldValidator5.Visible = False
        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 3 Then
            UNO.Visible = True
            DOS.Visible = True
            Label1.Visible = True
            DropDownList3.Visible = True
            RequiredFieldValidator5.Visible = True
            x.FillDependiente(DropDownList2, DropDownList3)
        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 4 Then
            UNO.Visible = True
            DOS.Visible = True
            CUATRO.Visible = True
            Label1.Visible = True
            DropDownList3.Visible = True
            RequiredFieldValidator5.Visible = True
            x.FillDependiente(DropDownList2, DropDownList3)
        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 5 Then
            UNO.Visible = True
            DOS.Visible = True
            Label1.Visible = True
            Label1.Text = "Supervisor:"
            DropDownList3.Visible = True
            RequiredFieldValidator5.Visible = True
            x.FillSupervisor(DropDownList3)
            x.FillCampañas(DropDownList2, True)
        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 6 Then
            UNO.Visible = True
            DOS.Visible = True
            Label1.Visible = True
            Label1.Text = "Agrupado:"
            DropDownList3.Visible = True
            RequiredFieldValidator5.Visible = True
            x.FillAgrupado(DropDownList3)
        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 7 Then
            UNO.Visible = True
            DOS.Visible = True
            Label1.Visible = False
            DropDownList3.Visible = False
            RequiredFieldValidator5.Visible = False
            x.FillBDD(DropDownList2, "01/01/1900", "02/01/1900", Request.QueryString("campania"))
            ImageButton6.Visible = True
        ElseIf GetGrupoParam(DropDownList1.SelectedValue) = 8 Then
            UNO.Visible = False
            DOS.Visible = True
            Label1.Visible = False
            DropDownList3.Visible = False
            RequiredFieldValidator5.Visible = False
            x.FillCampañas(DropDownList2, True)
        Else
            ImageButton6.Visible = False
        End If

        Session("reportId") = DropDownList1.SelectedValue


    End Sub

    Protected Sub ImageButton6_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton6.Click
        x.FillBDD(DropDownList2, TextBox1.Text, TextBox2.Text, Request.QueryString("campania"))
    End Sub

    Function GetLastExec(reportID As Integer, area As String) As Integer


        Dim columna As String

        If Request.Cookies("Usersettings")("Area") = 0 Then
            columna = "operaciones"
        ElseIf Request.Cookies("Usersettings")("Area") = 1 Then
            columna = "calidad"
        ElseIf Request.Cookies("Usersettings")("Area") = 2 Then
            columna = "command"
        ElseIf Request.Cookies("Usersettings")("Area") = 3 Then
            columna = "capacitacion"
        ElseIf Request.Cookies("Usersettings")("Area") = 4 Then
            columna = "rh"
        ElseIf Request.Cookies("Usersettings")("Area") = 5 Then
            columna = "reclutamiento"
        ElseIf Request.Cookies("Usersettings")("Area") = 6 Then
            columna = "comercial"
        Else
            columna = "command"
        End If

        Try

            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim conexion As New SqlConnection(strConnString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet

            Dim cmd As SqlCommand = New SqlCommand("SELECT " & columna & " FROM CCS.dbo.SYS_reportes WHERE id = " & Session("reportId"), conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString

        Catch ex As Exception
            Return 0
        End Try

    End Function


End Class



Public Class ReportServerCredentials
    Implements IReportServerCredentials

    Private _userName As String
    Private _password As String
    Private _domain As String

    Public Sub New(ByVal userName As String, ByVal password As String, ByVal domain As String)
        _userName = userName
        _password = password
        _domain = domain
    End Sub

    Public ReadOnly Property ImpersonationUser() As System.Security.Principal.WindowsIdentity Implements Microsoft.Reporting.WebForms.IReportServerCredentials.ImpersonationUser
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property NetworkCredentials() As ICredentials Implements Microsoft.Reporting.WebForms.IReportServerCredentials.NetworkCredentials
        Get
            Return New NetworkCredential(_userName, _password, _domain)
        End Get
    End Property

    Public Function GetFormsCredentials(ByRef authCookie As System.Net.Cookie, ByRef userName As String, ByRef password As String, ByRef authority As String) As Boolean Implements Microsoft.Reporting.WebForms.IReportServerCredentials.GetFormsCredentials
        userName = _userName
        password = _password
        authority = _domain
        Return Nothing
    End Function
End Class