Imports System.Data.SqlClient
Public Class Retro_Calidad
    Inherits System.Web.UI.Page

    Dim x As New Funciones

    Public Function GetCampaniaID(campania As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM SYS_campanias WHERE campania = '" & campania & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetCentro(id As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT reclutador FROM SYS_empleados WHERE id_acd1 = '" & id & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Try
            Return ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If DropDownList1.SelectedItem.Value = 1 Then
            ListaCoachingPendientes()
        Else
            ListaFODAPendientes()
        End If
    End Sub

    Sub ListaCoachingPendientes()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT a.ID,a.id_acd as 'ID Mitrol',b.nombres + ' ' + b.paterno + ' '+b.materno as Nombre,c.nombres + ' ' + c.paterno + ' '+c.materno as Supervisor ,d.campania as Campaña,id_guia as Guia,CONVERT(NVARCHAR(MAX),calificacion) + '%' as Calificación,CONVERT(DATE,fecha_monitoreo) as Fecha,(CASE WHEN a.id_campania <> 16 THEN 3-DATEDIFF(DD,CONVERT(DATE,fecha_monitoreo),CONVERT(DATE,GETDATE())) + QA.dbo.GET_Dias_Retro(CONVERT(DATE,fecha_monitoreo),a.id_acd)+QA.[dbo].[GET_Dias_Adicionales_Analista](CONVERT(DATE,fecha_monitoreo),QA.dbo.GET_Nombre_Analista_IDMON(a.id)) ELSE 8 END) as 'Dias para Retro' FROM QA.dbo.SYS_Monitoreos a LEFT JOIN CCS.dbo.SYS_empleados b ON a.agente=b.id LEFT JOIN CCS.dbo.SYS_empleados c ON a.supervisor=c.id LEFT JOIN CCS.dbo.SYS_campanias d ON a.id_campania=d.id WHERE (CASE WHEN a.id_campania <> 16 THEN 3-DATEDIFF(DD,CONVERT(DATE,fecha_monitoreo),CONVERT(DATE,GETDATE())) + QA.dbo.GET_Dias_Retro(CONVERT(DATE,fecha_monitoreo),a.id_acd)+QA.[dbo].[GET_Dias_Adicionales_Analista](CONVERT(DATE,fecha_monitoreo),QA.dbo.GET_Nombre_Analista_IDMON(a.id)) ELSE 8 END) > 0 AND calificacion >= 80 AND (retro IS NULL OR retro = 2) AND b.status IN (2,7) AND a.analista =" & x.GetUserID(Request.Cookies("Usersettings")("Username"))
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con
        cmd.CommandTimeout = 86400
        con.Open()

        GridView1.DataSource = cmd.ExecuteReader()
        GridView1.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Sub ListaFODAPendientes()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT a.ID,a.id_acd as 'ID Mitrol',b.nombres + ' ' + b.paterno + ' '+b.materno as Nombre,c.nombres + ' ' + c.paterno + ' '+c.materno as Supervisor ,d.campania as Campaña,id_guia as Guia,CONVERT(NVARCHAR(MAX),calificacion) + '%' as Calificación,CONVERT(DATE,fecha_monitoreo) as Fecha,(CASE WHEN a.id_campania <> 16 THEN 3-DATEDIFF(DD,CONVERT(DATE,fecha_monitoreo),CONVERT(DATE,GETDATE())) + QA.dbo.GET_Dias_Retro(CONVERT(DATE,fecha_monitoreo),a.id_acd)+QA.[dbo].[GET_Dias_Adicionales_Analista](CONVERT(DATE,fecha_monitoreo),QA.dbo.GET_Nombre_Analista_IDMON(a.id)) ELSE 8 END) as 'Dias para Retro' FROM QA.dbo.SYS_Monitoreos a LEFT JOIN CCS.dbo.SYS_empleados b ON a.agente=b.id LEFT JOIN CCS.dbo.SYS_empleados c ON a.supervisor=c.id LEFT JOIN CCS.dbo.SYS_campanias d ON a.id_campania=d.id WHERE (CASE WHEN a.id_campania <> 16 THEN 3-DATEDIFF(DD,CONVERT(DATE,fecha_monitoreo),CONVERT(DATE,GETDATE())) + QA.dbo.GET_Dias_Retro(CONVERT(DATE,fecha_monitoreo),a.id_acd)+QA.[dbo].[GET_Dias_Adicionales_Analista](CONVERT(DATE,fecha_monitoreo),QA.dbo.GET_Nombre_Analista_IDMON(a.id)) ELSE 8 END) > 0 AND calificacion < 80 AND (retro IS NULL OR retro = 2) AND b.status IN (2,7) AND a.analista = " & x.GetUserID(Request.Cookies("Usersettings")("Username"))
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con
        cmd.CommandTimeout = 1800
        con.Open()

        GridView1.DataSource = cmd.ExecuteReader()
        GridView1.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand


        If e.CommandName = "Select" Then
            Session("idSeleccion") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
            Session("idACD") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(1).Text)
            Session("Guia") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(5).Text)
            Session("CampaniaSelect") = GetCampaniaID(String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(4).Text))
        End If


        If Session("CampaniaSelect") = 16 And GetCentro(Session("idACD")) = "MTY" Then
            Session("Centro") = "MTY"
        End If

        If DropDownList1.SelectedItem.Value = 1 Then
            Response.Redirect("Coaching.aspx")
        Else
            Response.Redirect("FODA.aspx")

        End If

    End Sub
    'SE LIMPIA LA VARIABLE DE SESSION CENTRO QUE GUARDA SI ES DE MTY O NO 
    Private Sub Retro_Calidad_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session("Centro") = Nothing
    End Sub
End Class