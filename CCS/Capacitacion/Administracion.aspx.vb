Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class EntregaSecundarias
    Inherits System.Web.UI.Page

    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    '########################################################### FUNCIONES PUBLICAS #######################################################

    Sub EnviarMail(Destinatario As String, Asunto As String, Mensaje As String)

        Dim correo As New MailMessage
        Dim smtp As New SmtpClient()

        correo.From = New MailAddress("notificaciones.command@ccsolutions.com.mx", "Notificaciones CCS", System.Text.Encoding.UTF8)
        correo.To.Add(Destinatario)
        correo.Bcc.Add("isaac.contreras@ccscontactcenter.com")
        correo.SubjectEncoding = System.Text.Encoding.UTF8
        correo.Subject = Asunto
        correo.Body = Mensaje
        correo.BodyEncoding = System.Text.Encoding.UTF8
        correo.IsBodyHtml = True '(formato tipo web o normal:   true = web)
        correo.Priority = MailPriority.High '>> prioridad

        smtp.Credentials = New System.Net.NetworkCredential("notificaciones.command@ccsolutions.com.mx", "JX@e0Qr$mVZl")
        smtp.Port = 26
        smtp.Host = "mail.ccsolutions.com.mx"
        smtp.EnableSsl = False

        smtp.Send(correo)



    End Sub

    Public Function GetUserID(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT id FROM SYS_empleados WHERE id_ccs = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetIdCons(user As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) +1 as Count FROM [CCS].[dbo].[SYS_Score_Card] where agente = '" & user & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetUserArea(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT area FROM SYS_empleados WHERE id_ccs = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetUserPuesto(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT puesto FROM SYS_empleados WHERE id_ccs = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetUserSU(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT su FROM SYS_empleados WHERE id_ccs = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Try
            If ds.Tables(0).Rows(0).Item(0).ToString = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function GetListaNotificacion(Area As Integer, Puesto As Integer)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("EXEC GET_ListaNotificacion @AREA = " & Area & ", @PUESTO =" & Puesto, conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetCorreoSupervisor(Nombre As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT mail_ccs FROM SYS_empleados WHERE nombres+' '+paterno+' '+materno ='" & Nombre & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Session("HO") = "True" Then
            Label1.Text = "Agentes"
        End If

        If GetPassStatus(Request.Cookies("UserSettings")("Username")) = False Then
            Response.Redirect("Password.aspx")
        Else

        End If




        UpdatePanel1.Visible = False
        UpdatePanel2.Visible = False




        If Session("HI") = 1 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then


            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 5 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 1 Then

            End If

        ElseIf Session("HI") = 2 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then


            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 3 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 1 Then

            End If

        ElseIf Session("HI") = 3 Then


            If GetUserArea(Request.Cookies("Usersettings")("Username")) = 3 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 3 Then

            End If

        ElseIf Session("HI") = 4 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then
                UpdatePanel1.Visible = True
                UpdatePanel2.Visible = True
            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 3 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) = 2 Then
                UpdatePanel1.Visible = True
                UpdatePanel2.Visible = True
            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 3 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) = 3 Then
                UpdatePanel1.Visible = True
                UpdatePanel2.Visible = True
            End If

        ElseIf Session("HI") = 5 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then

            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) <> 4 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 3 Then

            End If


        ElseIf Session("HI") = 6 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then

            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) <> 4 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 3 Then

            ElseIf GetUserPuesto(Request.Cookies("Usersettings")("Username")) = 1 Then

            End If

        ElseIf Session("HI") = 7 Then

        ElseIf Session("HI") = 8 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then

            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 4 Then

            End If

        ElseIf Session("HI") = 9 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then

            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 4 Then

            End If

        ElseIf Session("HI") = 10 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then

            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 4 Then

            End If

        ElseIf Session("HI") = 11 Then

        End If


        If Not IsPostBack Then
            Combo1()
            ComboSupers()

            ListaAgentesCapa()







        End If

    End Sub

    Public Function GetPassStatus(UserName As String) As Boolean

        Dim sql As String = "SELECT COUNT(*) FROM SYS_empleados WHERE id_ccs = @user AND status = 2 AND su IS NOT NULL"
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString())

            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", UserName)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                Return False
            Else
                Return True

            End If

        End Using

    End Function




    '########################################################### MODULO DE CAPACITACION ###########################################################


    Sub Combo1()
        Dim Tipo As Integer
        If Session("HO") = "True" Then
            Tipo = 2
        Else
            Tipo = 1
        End If
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id, nombre FROM SYS_cursos Where tipo = " & Tipo
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList1.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList1.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList1.DataSource = cmd.ExecuteReader()
            DropDownList1.DataTextField = "nombre"
            DropDownList1.DataValueField = "id"
            DropDownList1.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub Combo1SP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id, nombre FROM SYS_cursos"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList1.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList1.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList1.DataSource = cmd.ExecuteReader()
        DropDownList1.DataTextField = "nombre"
        DropDownList1.DataValueField = "id"
        DropDownList1.DataBind()

        con.Close()
        con.Dispose()


    End Sub

    Sub ComboSupers()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,nombres + ' ' + paterno + ' ' + materno as Nombre FROM [CCS].[dbo].[SYS_empleados] where status =2 and area = 0 and puesto = 1 and (reclutador not in ('MTY','IN') OR reclutador is null)"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList2.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList2.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList2.DataSource = cmd.ExecuteReader()
            DropDownList2.DataTextField = "nombre"
            DropDownList2.DataValueField = "id"
            DropDownList2.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub ComboSPSupers()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,nombres + ' ' + paterno + ' ' + materno as Nombre FROM [CCS].[dbo].[SYS_empleados] where status =2 and area = 0 and puesto = 1 and (reclutador not in ('MTY','IN') OR reclutador is null)"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList2.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList2.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList2.DataSource = cmd.ExecuteReader()
        DropDownList2.DataTextField = "nombre"
        DropDownList2.DataValueField = "id"
        DropDownList2.DataBind()

        con.Close()
        con.Dispose()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        EntregaAgenteCapacitacion()
        LlenaScoreCard()
        Limpiar()

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
        End If
        Llena_Campos()



    End Sub

    Function GetGeneracion()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT  DISTINCT MAX(generacion)+1 as gen FROM SYS_empleados a LEFT JOIN [dbo].[SYS_campanias] b ON a.campaña = b.id WHERE campaña =  '" & DropDownList1.SelectedValue.ToString & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        If ds.Tables(0).Rows.Count = 0 Then
            Return 1
        Else
            Return ds.Tables(0).Rows(0).Item(0).ToString
        End If





    End Function

    Function GetIdSup()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT [id] FROM SYS_empleados WHERE id_ccs = '" & Request.Cookies("Usersettings")("Username") & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        If ds.Tables(0).Rows.Count = 0 Then
            Return 1
        Else
            Return ds.Tables(0).Rows(0).Item(0).ToString
        End If

    End Function

    Function CheckACD(ACD As String)


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim conexion As New SqlConnection(strConnString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet

            Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM SYS_empleados WHERE id_acd1 = '" & ACD & "'", conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            If ds.Tables(0).Rows(0).Item(0).ToString = 0 Then
                Return False
            Else
                Return True
            End If

    End Function



    Sub EntregaAgenteCapacitacion()

        Dim MensajeHTML As String

        MensajeHTML = "<html><head><style>p.MsoNormal, li.MsoNormal, div.MsoNormal{mso-style-unhide:no;mso-style-qformat:yes;mso-style-parent:'';margin:0cm;margin-bottom:.0001pt;mso-pagination:widow-orphan;font-size:11.0pt;font-family:'Calibri',sans-serif;mso-ascii-font-family:Calibri;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-font-family:Calibri;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:'Times New Roman';mso-bidi-theme-font:minor-bidi;mso-fareast-language:EN-US;}a:link, span.MsoHyperlink{mso-style-noshow:yes;mso-style-priority:99;color:#0563C1;mso-themecolor:hyperlink;text-decoration:underline;text-underline:single;}a:visited, span.MsoHyperlinkFollowed{mso-style-noshow:yes;mso-style-priority:99;color:#954F72;mso-themecolor:followedhyperlink;text-decoration:underline;text-underline:single;}</style></head><body><p class=MsoNormal>Capacitación ha entregado un nuevo agente:<o:p></o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Nombre: </b>" &
                      TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Campaña: </b>" &
                      DropDownList1.SelectedItem.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Instructor: </b>" &
                      Request.Cookies("Usersettings")("Username") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><br><p class=MsoNormal><span style='mso-bookmark:_MailAutoSig'><span style='mso-fareast-font-family:'Times New Roman';mso-fareast-theme-font:minor-fareast;mso-fareast-language:ES-MX;mso-no-proof:yes'>Favor de asignar un supervisor <a href='http://10.0.0.40/Asistencia/Content/Administracion.aspx'>aqui</a> para continuar con el proceso.<o:p></o:p></span></span></p></body></html>"



        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 2, jefe_directo = " & DropDownList2.SelectedItem.Value & ", curso = NULL WHERE id = " & Session("idSeleccion")
        Dim con As New SqlConnection(strConnString)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            con.Dispose()




        msgtipo(0) = 1
            msgmensaje(0) = "¡Entrega Correcta!"
            msgtipo(1) = 2
            msgmensaje(1) = "!Notificación Enviada!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        'EnviarMail(GetListaNotificacion(0, 3), "***Agente Entregado Capacitacion Secundaria***", MensajeHTML)

        ListaAgentesCapa()



    End Sub

    Sub LlenaScoreCard()

        Dim MensajeHTML As String

        MensajeHTML = "<html><head><style>p.MsoNormal, li.MsoNormal, div.MsoNormal{mso-style-unhide:no;mso-style-qformat:yes;mso-style-parent:'';margin:0cm;margin-bottom:.0001pt;mso-pagination:widow-orphan;font-size:11.0pt;font-family:'Calibri',sans-serif;mso-ascii-font-family:Calibri;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-font-family:Calibri;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:'Times New Roman';mso-bidi-theme-font:minor-bidi;mso-fareast-language:EN-US;}a:link, span.MsoHyperlink{mso-style-noshow:yes;mso-style-priority:99;color:#0563C1;mso-themecolor:hyperlink;text-decoration:underline;text-underline:single;}a:visited, span.MsoHyperlinkFollowed{mso-style-noshow:yes;mso-style-priority:99;color:#954F72;mso-themecolor:followedhyperlink;text-decoration:underline;text-underline:single;}</style></head><body><p class=MsoNormal>Capacitación ha entregado un nuevo agente:<o:p></o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Nombre: </b>" &
                      TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Campaña: </b>" &
                      DropDownList1.SelectedItem.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Instructor: </b>" &
                      Request.Cookies("Usersettings")("Username") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><br><p class=MsoNormal><span style='mso-bookmark:_MailAutoSig'><span style='mso-fareast-font-family:'Times New Roman';mso-fareast-theme-font:minor-fareast;mso-fareast-language:ES-MX;mso-no-proof:yes'>Favor de asignar un supervisor <a href='http://10.0.0.40/Asistencia/Content/Administracion.aspx'>aqui</a> para continuar con el proceso.<o:p></o:p></span></span></p></body></html>"


        Dim Tipo As Integer
        If Session("HO") = "True" Then
            Tipo = 2
        Else
            Tipo = 1
        End If
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "INSERT INTO SYS_Score_Card (agente, id_acd, curso, tipo, calificacion, id_cons, fecha) VALUES('" & Session("idSeleccion") & "','" & TextBox9.Text & "','" & DropDownList1.SelectedItem.Value & "','" & Tipo & "','" & TextBox4.Text & "','" & GetIdCons(Session("idSeleccion")) & "', GETDATE())"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()




        msgtipo(0) = 1
        msgmensaje(0) = "¡Entrega Correcta!"
        msgtipo(1) = 2
        msgmensaje(1) = "!Notificación Enviada!"
        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        'EnviarMail(GetListaNotificacion(0, 3), "***Agente Entregado Capacitacion Secundaria***", MensajeHTML)
        Limpiar()
        ListaAgentesCapa()



    End Sub

    Sub ActualizaAsistenciaID(ID As String, Nombre As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE OP_Asistencia SET idMitrol = '" & ID & "' WHERE nombre = '" & Nombre & "'"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

    End Sub

    Sub ListaAgentesCapa()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select ID,campania As 'Campaña',nombres+ ' ' + paterno+ ' ' +materno as Nombre,id_acd1 as 'Login',celular as 'Celular' FROM Plantilla WHERE status = 'Secundarias' AND id_super = '" & Request.Cookies("Usersettings")("Username") & "'"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView1.DataSource = cmd.ExecuteReader()
        GridView1.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Sub Llena_Campos()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT nombres,paterno,materno,campaña,fecha_tronco,fecha_capacitacion,generacion,id_acd1,telefono,celular,CASE WHEN DATEPART(HOUR,entrada_capa) >=12 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,entrada_capa))+':00' ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,entrada_capa))+':00' END as 'Entrada_Capa',CASE WHEN DATEPART(HOUR,salida_capa) >=12 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,salida_capa))+':00' ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,salida_capa))+':00' END as 'Salida_Capa',CASE WHEN DATEPART(HOUR,entrada) >=12 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,entrada))+':00' ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,entrada))+':00' END as 'Entrada',CASE WHEN DATEPART(HOUR,salida) >=12 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,salida))+':00' ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,salida))+':00' END as 'Salida' FROM SYS_empleados WHERE id = " & Session("idSeleccion"), conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        TextBox1.Text = ds.Tables(0).Rows(0).Item(0).ToString()
        TextBox2.Text = ds.Tables(0).Rows(0).Item(1).ToString()
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2).ToString()












    End Sub

    Sub Limpiar()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox9.Text = ""
        TextBox4.Text = ""

        DropDownList1.Items.Clear()
        DropDownList2.Items.Clear()
        Combo1SP()
        ComboSPSupers()


        Session("idSeleccion") = 0


    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Limpiar()
    End Sub



















    '########################################################### MODULO DE COORDINACION OPERACIONES ###########################################################




















    '########################################################### MODULO DE SUPERVISOR OPERACIONES ###########################################################









    '########################################################### MODULO DE RECURSOS HUMANOS ###########################################################





































































End Class