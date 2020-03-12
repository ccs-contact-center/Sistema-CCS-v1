Imports System.Data.SqlClient
Public Class Maestra
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Session("MTY") = Request.Cookies("Usersettings")("MTY")
        Session("ARA") = Request.Cookies("Usersettings")("ARA")

        LoginStatus2.LogoutText = "Cerrar Sesion (" & Request.Cookies("Usersettings")("Username") & ")"

        Reclutamiento.Visible = False
        Capacitacion.Visible = False
        Operaciones.Visible = False
        Nomina.Visible = False
        Alta.Visible = False
        ReasignacionCAP.Visible = False
        Imple.Visible = False

        MisEvaluaciones.Visible = False
        NuevaEvaluacion.Visible = False

        MonitoreoQA.Visible = False
        RetroQA.Visible = False
        ResumenQA.Visible = False
        Asistencia.Visible = False
        RetroSUP.Visible = False
        RetroAG.Visible = False
        ResumenOP.Visible = False
        Incidencias.Visible = False
        Diseño.Visible = False
        Edicion.Visible = False
        Asignacion.Visible = False

        Catalogo.Visible = False
        Edicion_Calif.Visible = False

        HO.Visible = False
        SecundariasOP.Visible = False
        SecundariasCAP.Visible = False
        SecundariasEntrega.Visible = False
        HOCAP.Visible = False
        HOEntrega.Visible = False

        If Request.Cookies("Usersettings")("SU") = True Then

            MonitoreoQA.Visible = True
            RetroQA.Visible = True
            ResumenQA.Visible = True
            Asistencia.Visible = True
            RetroSUP.Visible = True
            RetroAG.Visible = True
            ResumenOP.Visible = True
            Incidencias.Visible = True
            Diseño.Visible = True
            Edicion.Visible = True
            Asignacion.Visible = True

            Catalogo.Visible = True
            Edicion_Calif.Visible = True

            Reclutamiento.Visible = True
            Capacitacion.Visible = True
            Operaciones.Visible = True
            Nomina.Visible = True
            Alta.Visible = True
            ReasignacionCAP.Visible = True

            Imple.Visible = True
            HO.Visible = True
            SecundariasOP.Visible = True
            SecundariasCAP.Visible = True
            SecundariasEntrega.Visible = True
            HOCAP.Visible = True
            HOEntrega.Visible = True

            MisEvaluaciones.Visible = True
            NuevaEvaluacion.Visible = True

        ElseIf Request.Cookies("Usersettings")("Area") = 0 And Request.Cookies("Usersettings")("Puesto") = 0 Then
            RetroAG.Visible = True
            MisEvaluaciones.Visible = True
            If Request.Cookies("Usersettings")("MTY") = "True" Or Request.Cookies("Usersettings")("ARA") = "True" Then
                QAGeneral.Visible = False
                CCGeneral.Visible = False
                REPGeneral.Visible = False
                AdminGeneral.Visible = False
                MisEvaluaciones.Visible = False
                NuevaEvaluacion.Visible = False
            End If

        ElseIf Request.Cookies("Usersettings")("Area") = 0 And Request.Cookies("Usersettings")("Puesto") = 1 Then
            Asistencia.Visible = True
            ResumenOP.Visible = True
            RetroSUP.Visible = True
            Operaciones.Visible = True
            Incidencias.Visible = True
            HO.Visible = True
            SecundariasOP.Visible = True
            MonitoreoQA.Visible = True
            If Request.Cookies("Usersettings")("MTY") = "True" Or Request.Cookies("Usersettings")("ARA") = "True" Then
                QAGeneral.Visible = False
                CCGeneral.Visible = False
                REPGeneral.Visible = True
                AdminGeneral.Visible = False
                REP_Campanias.Visible = False
                REP_General.Visible = False
                Asistencia.Visible = False
                Incidencias.Visible = False
            End If


        ElseIf Request.Cookies("Usersettings")("Area") = 0 And Request.Cookies("Usersettings")("Puesto") >= 3 Then
            Asistencia.Visible = True
            Operaciones.Visible = True
            Incidencias.Visible = True
            Alta.Visible = True
            Imple.Visible = True
            IMP_Nuevo_Proyecto.Visible = False
            HO.Visible = True
            SecundariasOP.Visible = True
        ElseIf Request.Cookies("Usersettings")("Area") = 1 And Request.Cookies("Usersettings")("Puesto") = 2 Then
            MonitoreoQA.Visible = True
            RetroQA.Visible = True
            ResumenQA.Visible = True
            Alta.Visible = True

        ElseIf Request.Cookies("Usersettings")("Campania") = 80 Then
            RetroQA.Visible = True
            ResumenQA.Visible = True
            MonitoreoQA.Visible = True
            REPGeneral.Visible = False
            CCGeneral.Visible = False


        ElseIf Request.Cookies("Usersettings")("Area") = 1 And Request.Cookies("Usersettings")("Puesto") >= 3 Then
            MonitoreoQA.Visible = True
            RetroQA.Visible = True
            ResumenQA.Visible = True
            Diseño.Visible = True
            Edicion.Visible = True
            Asignacion.Visible = True
            Catalogo.Visible = True
            Edicion_Calif.Visible = True
            Alta.Visible = True
            Operaciones.Visible = True
            Imple.Visible = True
            IMP_Nuevo_Proyecto.Visible = False
        ElseIf Request.Cookies("Usersettings")("Area") = 2 And Request.Cookies("Usersettings")("Puesto") = 2 Then

        ElseIf Request.Cookies("Usersettings")("Area") = 2 And Request.Cookies("Usersettings")("Puesto") >= 3 Then
            Operaciones.Visible = True
            Alta.Visible = True
            Imple.Visible = True
            IMP_Nuevo_Proyecto.Visible = False
        ElseIf Request.Cookies("Usersettings")("Area") = 3 And Request.Cookies("Usersettings")("Puesto") = 2 Then
            Asistencia.Visible = True
            Capacitacion.Visible = True
            Imple.Visible = True
            SecundariasCAP.Visible = True
            SecundariasEntrega.Visible = True
            HOCAP.Visible = True
            HOEntrega.Visible = True
            MisEvaluaciones.Visible = True
            NuevaEvaluacion.Visible = True
        ElseIf Request.Cookies("Usersettings")("Area") = 3 And Request.Cookies("Usersettings")("Puesto") >= 3 Then
            Asistencia.Visible = True
            Capacitacion.Visible = True
            ReasignacionCAP.Visible = True
            Operaciones.Visible = True
            Imple.Visible = True
            SecundariasCAP.Visible = True
            SecundariasEntrega.Visible = True
            HOCAP.Visible = True
            HOEntrega.Visible = True
            MisEvaluaciones.Visible = True
            NuevaEvaluacion.Visible = True
        ElseIf Request.Cookies("Usersettings")("Area") = 4 And Request.Cookies("Usersettings")("Puesto") >= 3 Then
            Nomina.Visible = True
            Alta.Visible = True
            Imple.Visible = True
            IMP_Nuevo_Proyecto.Visible = False
        ElseIf Request.Cookies("Usersettings")("Area") = 5 And Request.Cookies("Usersettings")("Puesto") >= 2 Then
            Reclutamiento.Visible = True
            Imple.Visible = True
            IMP_Nuevo_Proyecto.Visible = False
        End If


        LoadCampanias()

    End Sub

    Sub LoadCampanias()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT id,campania FROM [CCS].[dbo].[SYS_campanias_V2] where status = 1 and id <9998 ORDER BY campania", conexion)


        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        For x = 0 To ds.Tables(0).Rows.Count - 1

            Pruebitita.Visible = False
            Dim ul1 As HtmlGenericControl = DirectCast(Pruebitita.Parent.FindControl("ListaReportes"), HtmlGenericControl)
            Dim liToAdd As New HtmlGenericControl("li")
            liToAdd.Attributes.Add("class", "current")
            liToAdd.InnerHtml = "<a href='.././Calidad/Reportes.aspx?reportindex=3&campania=" & ds.Tables(0).Rows(x).Item(0) & "'>" & ds.Tables(0).Rows(x).Item(1) & " </a>"
            ul1.Controls.Add(liToAdd)

        Next






    End Sub

End Class