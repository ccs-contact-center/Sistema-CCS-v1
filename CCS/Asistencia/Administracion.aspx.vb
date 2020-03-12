Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class Administracion
    Inherits System.Web.UI.Page

    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    '########################################################### FUNCIONES PUBLICAS #######################################################

    Sub EnviarMail(Destinatario As String, Asunto As String, Mensaje As String)

        Dim correo As New MailMessage
        Dim smtp As New SmtpClient()

        correo.From = New MailAddress("ccs.notificaciones@ccscontactcenter.com", "Notificaciones CCS", System.Text.Encoding.UTF8)
        correo.To.Add(Destinatario)
        correo.Bcc.Add("isaac.contreras@ccscontactcenter.com")
        correo.SubjectEncoding = System.Text.Encoding.UTF8
        correo.Subject = Asunto
        correo.Body = Mensaje
        correo.BodyEncoding = System.Text.Encoding.UTF8
        correo.IsBodyHtml = True '(formato tipo web o normal:   true = web)
        correo.Priority = MailPriority.High '>> prioridad

        smtp.Credentials = New System.Net.NetworkCredential("ccs.notificaciones@ccscontactcenter.com", "Pow25925")
        smtp.Port = 587
        smtp.Host = "smtp.office365.com"
        smtp.EnableSsl = True

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

        If GetPassStatus(Request.Cookies("UserSettings")("Username")) = False Then
            Response.Redirect("Password.aspx")
        Else

        End If


        LoadAspirantes(1)
        LoadTronco()

        UpdatePanel1.Visible = False
        UpdatePanel2.Visible = False
        UpdatePanel3.Visible = False
        UpdatePanel4.Visible = False
        UpdatePanel5.Visible = False
        UpdatePanel6.Visible = False
        UpdatePanel7.Visible = False
        UpdatePanel8.Visible = False
        UpdatePanel9.Visible = False
        UpdatePanel10.Visible = False
        UpdatePanel11.Visible = False
        UpdatePanel13.Visible = False
        UpdatePanel14.Visible = False


        If Session("HI") = 1 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then
                UpdatePanel10.Visible = True

            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 5 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 1 Then
                UpdatePanel10.Visible = True
            End If

        ElseIf Session("HI") = 2 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then
                UpdatePanel11.Visible = True


            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 3 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 1 Then
                UpdatePanel11.Visible = True
            End If

        ElseIf Session("HI") = 3 Then


            If GetUserArea(Request.Cookies("Usersettings")("Username")) = 3 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 3 Then
                UpdatePanel14.Visible = True
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
                UpdatePanel3.Visible = True
            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) <> 4 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 3 Then
                UpdatePanel3.Visible = True
            End If


        ElseIf Session("HI") = 6 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then
                UpdatePanel6.Visible = True
            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) <> 4 And GetUserPuesto(Request.Cookies("Usersettings")("Username")) >= 3 Then
                UpdatePanel6.Visible = True
            ElseIf GetUserPuesto(Request.Cookies("Usersettings")("Username")) = 1 Then
                UpdatePanel6.Visible = True
            End If

        ElseIf Session("HI") = 7 Then

        ElseIf Session("HI") = 8 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then
                UpdatePanel4.Visible = True
                UpdatePanel5.Visible = True
            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 4 Then
                UpdatePanel4.Visible = True
                UpdatePanel5.Visible = True
            End If

        ElseIf Session("HI") = 9 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then
                UpdatePanel7.Visible = True
                UpdatePanel8.Visible = True
            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 4 Then
                UpdatePanel7.Visible = True
                UpdatePanel8.Visible = True
            End If

        ElseIf Session("HI") = 10 Then

            If GetUserSU(Request.Cookies("Usersettings")("Username")) = True Then
                UpdatePanel13.Visible = True
            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) = 4 Then
                UpdatePanel13.Visible = True
            End If

        ElseIf Session("HI") = 11 Then
            UpdatePanel9.Visible = True

            If GetUserSU(Request.Cookies("UserSettings")("Username")) = True Then
                UpdatePanel9.Visible = True
                altaCalidad.Visible = False
            ElseIf GetUserArea(Request.Cookies("Usersettings")("Username")) <> 1 Then

                altaCalidad.Visible = False
            End If

        End If


            If Not IsPostBack Then
            Combo1()
            Combo3()
            Combo4()
            Combo5()
            Combo6()
            Combo7()
            Combo8()
            ComboEstados()
            ComboEstados2()
            ComboCAMP()
            ComboSUP()
            ComboArea()
            ComboPuesto()
            ListaAgentesCapa()
            ListaAgentesAsignacion()
            ListaAgentesRH()
            ListaAgentesActivos()
            ListaAgentesPendientes()
            ListaAgentesRHBaja()
            ComboStatus()
            ComboInstructores()
            ComboInstructoresActivo()

            DropDownList7.Items.Add(New ListItem("-Selecciona-", 0))


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

    '########################################################### MODULO RECLUTAMIENTO ###########################################################

    Sub LoadAspirantes(NumeroAgentes As Integer)

        Aspirante1.Tablita.Rows(0).Visible = True

        Dim ctrl As Aspirante1
        For x = 0 To NumeroAgentes - 1
            Session("CuentaCosaesta") = x + 1

            ctrl = CType(Aspirante1.Parent.FindControl("Aspirante" & Session("CuentaCosaesta")), Aspirante1)
            ctrl.Visible = True
        Next
    End Sub

    Private Sub DropDownList24_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList24.SelectedIndexChanged

        Aspirante1.Visible = False
        Aspirante2.Visible = False
        Aspirante3.Visible = False
        Aspirante4.Visible = False
        Aspirante5.Visible = False
        Aspirante6.Visible = False
        Aspirante7.Visible = False
        Aspirante8.Visible = False
        Aspirante9.Visible = False
        Aspirante10.Visible = False
        Aspirante11.Visible = False
        Aspirante12.Visible = False
        Aspirante13.Visible = False
        Aspirante14.Visible = False
        Aspirante15.Visible = False
        Aspirante16.Visible = False
        Aspirante17.Visible = False
        Aspirante18.Visible = False
        Aspirante19.Visible = False
        Aspirante20.Visible = False


        LoadAspirantes(DropDownList24.SelectedValue)

    End Sub

    Public Sub CleanControls()

        TextBox44.Text = Nothing

        Dim ctrl As Aspirante1
        For x = 0 To DropDownList24.SelectedValue - 1
            Session("CuentaCosaesta") = x + 1

            ctrl = CType(Aspirante1.Parent.FindControl("Aspirante" & Session("CuentaCosaesta")), Aspirante1)

            ctrl.Nombre.Text = Nothing
            ctrl.Paterno.Text = Nothing
            ctrl.Materno.Text = Nothing
            ctrl.Entrada.SelectedValue = 0
            ctrl.Salida.SelectedValue = 0
            ctrl.EntradaCAP.SelectedValue = 0
            ctrl.SalidaCAP.SelectedValue = 0
            ctrl.Telefono.Text = Nothing
            ctrl.Campania.SelectedValue = 0

        Next
    End Sub

    Sub GuardarReclu()

        Dim user As String

        'Se genera el cuerpo del correo a enviar cuando se apriete guardar
        Dim MensajeHTML As String
        MensajeHTML = "<html><head><style>p.MsoNormal, li.MsoNormal, div.MsoNormal{mso-style-unhide:no;mso-style-qformat:yes;mso-style-parent:'';margin:0cm;margin-bottom:.0001pt;mso-pagination:widow-orphan;font-size:11.0pt;font-family:'Calibri',sans-serif;mso-ascii-font-family:Calibri;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-font-family:Calibri;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:'Times New Roman';mso-bidi-theme-font:minor-bidi;mso-fareast-language:EN-US;}a:link, span.MsoHyperlink{mso-style-noshow:yes;mso-style-priority:99;color:#0563C1;mso-themecolor:hyperlink;text-decoration:underline;text-underline:single;}a:visited, span.MsoHyperlinkFollowed{mso-style-noshow:yes;mso-style-priority:99;color:#954F72;mso-themecolor:followedhyperlink;text-decoration:underline;text-underline:single;}</style></head><body><p class=MsoNormal>Reclutamiento ha ingresado nuevos agentes:</p><br>" &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Reclutador: </b>" &
                      Request.Cookies("Usersettings")("Username") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><br><p class=MsoNormal><span style='mso-bookmark:_MailAutoSig'><span style='mso-fareast-font-family:'Times New Roman';mso-fareast-theme-font:minor-fareast;mso-fareast-language:ES-MX;mso-no-proof:yes'>Los agentes ya se encuentran disponibles para asignacion de instructor <a href='http://10.0.0.40/Asistencia/'>aqui</a> para continuar con el proceso.<o:p></o:p></span></span></p></body></html>"


        'Se instancian las clases que vamos a utilizar  (Funciones generales, base de datos y clase "Agente"
        Dim Funcion As New Funciones
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim ctrl As Aspirante1

        'Se recorre el numero de veces indicado en dropdownlist24  
        For x = 0 To DropDownList24.SelectedValue - 1



            Session("CuentaReclu") = x + 1

            ctrl = CType(Aspirante1.Parent.FindControl("Aspirante" & Session("CuentaReclu")), Aspirante1)


            '##### Se genera el usuario con la primera letra del nombre, 4 del apellido paterno y 4 del materno 
            user = StrConv(Mid(Replace(ctrl.Nombre.Text, " ", ""), 1, 1) & Mid(Replace(ctrl.Paterno.Text, " ", ""), 1, 4) & Mid(Replace(ctrl.Materno.Text, " ", ""), 1, 3), vbLowerCase)


            Dim strQuery As String = "INSERT INTO SYS_empleados ([status],id_ccs,pass_ccs,reclutador,fecha_tronco,entrada_capa,salida_capa,salida,entrada,area,puesto,nombres,paterno,materno,celular,campaña) VALUES (0,'" & user & "','" & Funcion.Passcrypt(user) & "' ,'" & Request.Cookies("Usersettings")("Username") & "', '" & CDate(TextBox44.Text) & "', '" & ctrl.EntradaCAP.SelectedItem.Text & "', '" & ctrl.SalidaCAP.SelectedItem.Text & "', '" & ctrl.Entrada.SelectedItem.Text & "', '" & ctrl.Salida.SelectedItem.Text & "', '0', '0', '" & StrConv(ctrl.Nombre.Text, vbUpperCase) & "', '" & StrConv(ctrl.Paterno.Text, vbUpperCase) & "', '" & StrConv(ctrl.Materno.Text, vbUpperCase) & "', '" & ctrl.Telefono.Text & "', '" & ctrl.Campania.SelectedItem.Value & "')"

            Dim con As New SqlConnection(strConnString)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            'Se ejecuta la insercion en la base de datos
            cmd.ExecuteNonQuery()
            con.Close()
            con.Dispose()
            'Se cierra la conexion

            'Se repite el numero de veces que indique el DropDownList24
        Next


        'Se lanza notificacio
        msgtipo(0) = 1
        msgmensaje(0) = "¡Aspirantes Ingresados Correctamente!"
        msgtipo(1) = 2
        msgmensaje(1) = "!Notificación Enviada a Capacitación!"
        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        'Se resetean los campos
        CleanControls()


        'Se envía mail de notificacion de acuerdo a la campaña seleccionada y al instructor asignado
        EnviarMail(GetListaNotificacion(3, 2), "***Nuevos Agentes para Tronco Común***", MensajeHTML)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        CleanControls()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        GuardarReclu()
    End Sub

    '########################################################### MODULO DE CAPACITACION ###########################################################

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        GuardaTronco()
    End Sub

    Function GetTronco()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM Plantilla a WHERE status = 'Reclutado'", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)

        conexion.Close()

        Return CInt(ds.Tables(0).Rows(0).Item(0).ToString)


    End Function

    Sub LoadTronco()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT nombres, paterno ,materno,id, campaña,SUBSTRING(CONVERT(char(38),Entrada_capa,121),12,5)+' - '+ SUBSTRING(CONVERT(char(38),Salida_capa,121),12,5) AS Horario FROM SYS_empleados  WHERE status = 0", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()
        TroncoComun1.Tablita.Rows(0).Visible = True


        Dim ctrl As TroncoComun
        For x = 0 To GetTronco() - 1
            Session("TroncoCount") = x + 1

            ctrl = CType(TroncoComun1.Parent.FindControl("TroncoComun" & Session("TroncoCount")), TroncoComun)
            ctrl.Visible = True
            ctrl.Nombre.Text = ds.Tables(0).Rows(x).Item(0).ToString
            ctrl.Paterno.Text = ds.Tables(0).Rows(x).Item(1).ToString
            ctrl.Materno.Text = ds.Tables(0).Rows(x).Item(2).ToString
            ctrl.IDBD.Value = ds.Tables(0).Rows(x).Item(3).ToString
            ctrl.Campania.SelectedValue = ds.Tables(0).Rows(x).Item(4).ToString
            ctrl.Horario.Text = ds.Tables(0).Rows(x).Item(5).ToString


        Next


    End Sub

    Sub GuardaTronco()


        Dim MensajeHTML As String



        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim ctrl As TroncoComun

        Dim idinstructor As String

        If GetTronco() = 0 Then


            msgtipo(0) = 4
            msgmensaje(0) = "¡No hay agentes para asignar!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)


        Else

            For x = 0 To GetTronco() - 1



                Session("TroncoUpdate") = x + 1

                ctrl = CType(TroncoComun1.Parent.FindControl("TroncoComun" & Session("TroncoUpdate")), TroncoComun)

                If ctrl.Instructor.SelectedItem.Value = "9999" Then



                    Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
                    Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 8 WHERE id = '" & ctrl.IDBD.Value & "'"
                    Dim con As New SqlConnection(strConnString)
                    Dim cmd As New SqlCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = strQuery
                    cmd.Connection = con

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    con.Dispose()

                    ctrl.Nombre.Text = Nothing
                    ctrl.Paterno.Text = Nothing
                    ctrl.Materno.Text = Nothing
                    ctrl.Instructor.SelectedValue = 0
                    ctrl.Campania.SelectedValue = 0
                    ctrl.Grupo.Text = Nothing
                    ctrl.Horario.Text = Nothing


                Else

                    idinstructor = GetUserID(ctrl.Instructor.SelectedItem.Value)

                    Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
                    Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 1, instructor = '" & ctrl.Instructor.SelectedItem.Value & "', fecha_capacitacion = CONVERT(DATE,GETDATE()), jefe_directo = '" & idinstructor & "', generacion = '" & ctrl.Grupo.Text & "', campaña='" & ctrl.Campania.SelectedValue & "'  WHERE id = '" & ctrl.IDBD.Value & "'"
                    Dim con As New SqlConnection(strConnString)
                    Dim cmd As New SqlCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = strQuery
                    cmd.Connection = con

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    con.Dispose()

                    MensajeHTML = "<html><head><style>p.MsoNormal, li.MsoNormal, div.MsoNormal{mso-style-unhide:no;mso-style-qformat:yes;mso-style-parent:'';margin:0cm;margin-bottom:.0001pt;mso-pagination:widow-orphan;font-size:11.0pt;font-family:'Calibri',sans-serif;mso-ascii-font-family:Calibri;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-font-family:Calibri;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:'Times New Roman';mso-bidi-theme-font:minor-bidi;mso-fareast-language:EN-US;}a:link, span.MsoHyperlink{mso-style-noshow:yes;mso-style-priority:99;color:#0563C1;mso-themecolor:hyperlink;text-decoration:underline;text-underline:single;}a:visited, span.MsoHyperlinkFollowed{mso-style-noshow:yes;mso-style-priority:99;color:#954F72;mso-themecolor:followedhyperlink;text-decoration:underline;text-underline:single;}</style></head><body><p class=MsoNormal>Reclutamiento ha ingresado nuevos agentes:</p> <br>" &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Reclutador: </b>" &
                      Request.Cookies("Usersettings")("Username") &
                      "<b style='mso-bidi-font-weight:normal'></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Nombre: </b>" &
                      ctrl.Nombre.Text & " " & ctrl.Paterno.Text & " " & ctrl.Materno.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><br><p class=MsoNormal><span style='mso-bookmark:_MailAutoSig'><span style='mso-fareast-font-family:'Times New Roman';mso-fareast-theme-font:minor-fareast;mso-fareast-language:ES-MX;mso-no-proof:yes'>Los agentes ya se encuentran disponibles para asignacion de instructor <a href='http://10.0.0.40/Asistencia/'>aqui</a> para continuar con el proceso.<o:p></o:p></span></span></p></body></html>"


                    EnviarMail(GetCorreoSupervisor(ctrl.Instructor.SelectedItem.Text), "***Nuevos Agentes Entregados***", MensajeHTML)

                    ctrl.Nombre.Text = Nothing
                    ctrl.Paterno.Text = Nothing
                    ctrl.Materno.Text = Nothing
                    ctrl.Instructor.SelectedValue = 0
                    ctrl.Campania.SelectedValue = 0
                    ctrl.Grupo.Text = Nothing
                    ctrl.Horario.Text = Nothing

                End If



            Next

            msgtipo(0) = 1
            msgmensaje(0) = "¡Aspirantes Asignados Correctamente!"
            msgtipo(1) = 2
            msgmensaje(1) = "!Notificación Enviada!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        End If
    End Sub

    Sub Combo1()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id, campania FROM SYS_campanias"
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
            DropDownList1.DataTextField = "campania"
            DropDownList1.DataValueField = "id"
            DropDownList1.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub Combo1SP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id, campania FROM SYS_campanias"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList1.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList1.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList1.DataSource = cmd.ExecuteReader()
        DropDownList1.DataTextField = "campania"
        DropDownList1.DataValueField = "id"
        DropDownList1.DataBind()

        con.Close()
        con.Dispose()


    End Sub

    Private Sub DropDownList1_TextChanged(sender As Object, e As EventArgs) Handles DropDownList1.TextChanged




        RequiredFieldValidator13.Enabled = True

    End Sub

    Protected Sub DropDownList7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList7.SelectedIndexChanged

        If DropDownList7.SelectedValue = 1 Then
            RequiredFieldValidator14.Enabled = False
            RequiredFieldValidator15.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
        ElseIf DropDownList7.SelectedValue = 2 Then
            RequiredFieldValidator14.Enabled = False
            RequiredFieldValidator15.Enabled = False
        ElseIf DropDownList7.SelectedValue = 3 Then
            RequiredFieldValidator15.Enabled = True
            RequiredFieldValidator14.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DropDownList7.SelectedValue = 1 Then

        ElseIf DropDownList7.SelectedValue = 2 Then
            BajaAgenteCapacitacion()
        ElseIf DropDownList7.SelectedValue = 3 Then
            EntregaAgenteCapacitacion()
        End If

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

        DropDownList7.Items.Clear()
        DropDownList7.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList7.Items.Add(New ListItem("Baja", 2))
        DropDownList7.Items.Add(New ListItem("Entrega", 3))

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

        If DropDownList7.SelectedValue = 1 Then

            Return False

        Else
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

        End If
    End Function

    Sub BajaAgenteCapacitacion()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 5, fecha_baja = CONVERT(DATE,GETDATE()) WHERE id = " & Session("idSeleccion")
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
        msgmensaje(0) = "¡Baja Aplicada!"
        msgtipo(1) = 2
        msgmensaje(1) = "!Notificación Enviada!"
        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        Limpiar()
        ListaAgentesCapa()
        ListaAgentesAsignacion()
        ListaAgentesActivos()
        ListaAgentesRH()
        ListaAgentesPendientes()
        ListaAgentesRHBaja()

    End Sub

    Sub EntregaAgenteCapacitacion()

        Dim MensajeHTML As String

        MensajeHTML = "<html><head><style>p.MsoNormal, li.MsoNormal, div.MsoNormal{mso-style-unhide:no;mso-style-qformat:yes;mso-style-parent:'';margin:0cm;margin-bottom:.0001pt;mso-pagination:widow-orphan;font-size:11.0pt;font-family:'Calibri',sans-serif;mso-ascii-font-family:Calibri;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-font-family:Calibri;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:'Times New Roman';mso-bidi-theme-font:minor-bidi;mso-fareast-language:EN-US;}a:link, span.MsoHyperlink{mso-style-noshow:yes;mso-style-priority:99;color:#0563C1;mso-themecolor:hyperlink;text-decoration:underline;text-underline:single;}a:visited, span.MsoHyperlinkFollowed{mso-style-noshow:yes;mso-style-priority:99;color:#954F72;mso-themecolor:followedhyperlink;text-decoration:underline;text-underline:single;}</style></head><body><p class=MsoNormal>Capacitación ha entregado un nuevo agente:<o:p></o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Nombre: </b>" &
                      TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Campaña: </b>" &
                      DropDownList1.SelectedItem.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Instructor: </b>" &
                      Request.Cookies("Usersettings")("Username") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><br><p class=MsoNormal><span style='mso-bookmark:_MailAutoSig'><span style='mso-fareast-font-family:'Times New Roman';mso-fareast-theme-font:minor-fareast;mso-fareast-language:ES-MX;mso-no-proof:yes'>Favor de asignar un supervisor <a href='http://10.0.0.40/Asistencia/Content/Administracion.aspx'>aqui</a> para continuar con el proceso.<o:p></o:p></span></span></p></body></html>"

        If CheckACD(TextBox9.Text) = False Then

            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 6, evaluacion_final = '" & TextBox10.Text & "', fecha_alta = CONVERT(DATE,GETDATE()), jefe_directo = NULL, id_acd1 = '" & TextBox9.Text & "', fecha_capacitacion = '" & TextBox5.Text & "' WHERE id = " & Session("idSeleccion")
            Dim con As New SqlConnection(strConnString)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            con.Dispose()

            ActualizaAsistenciaID(TextBox9.Text, TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text)

            msgtipo(0) = 1
            msgmensaje(0) = "¡Entrega Correcta!"
            msgtipo(1) = 2
            msgmensaje(1) = "!Notificación Enviada!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

            EnviarMail(GetListaNotificacion(0, 3), "***Nuevo Agente Entregado***", MensajeHTML)
            Limpiar()
            ListaAgentesCapa()
            ListaAgentesAsignacion()
            ListaAgentesActivos()
            ListaAgentesRH()
            ListaAgentesPendientes()
            ListaAgentesRHBaja()



        Else
            msgtipo(0) = 4
            msgmensaje(0) = "¡El ID del ACD ya existe en la base de datos!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End If

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
        Dim strQuery As String = "Select ID,campania As 'Campaña',nombres+ ' ' + paterno+ ' ' +materno as Nombre,id_acd1 as 'Login',celular as 'Celular',telefono as 'Fijo' FROM Plantilla WHERE status = 'En Capacitacion' AND id_super = '" & Request.Cookies("Usersettings")("Username") & "'"
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
        DropDownList1.SelectedValue = ds.Tables(0).Rows(0).Item(3).ToString()
        If ds.Tables(0).Rows(0).Item(4).ToString = "" Then
            TextBox4.Text = ""
        Else
            TextBox4.Text = DateTime.ParseExact(Mid(ds.Tables(0).Rows(0).Item(4).ToString, 1, 10), "dd/MM/yyyy", Nothing)
        End If
        If ds.Tables(0).Rows(0).Item(5).ToString = "" Then
            TextBox5.Text = ""
        Else
            TextBox5.Text = DateTime.ParseExact(Mid(ds.Tables(0).Rows(0).Item(5).ToString, 1, 10), "dd/MM/yyyy", Nothing)
        End If



        If ds.Tables(0).Rows(0).Item(7).ToString = "" Then
            TextBox9.Text = ""
        Else
            TextBox9.Text = DateTime.ParseExact(Mid(ds.Tables(0).Rows(0).Item(7).ToString, 1, 10), "dd/MM/yyyy", Nothing)
        End If

        If ds.Tables(0).Rows(0).Item(8).ToString = "" Then
            TextBox6.Text = ""
        Else
            TextBox6.Text = ds.Tables(0).Rows(0).Item(8).ToString
        End If

        If ds.Tables(0).Rows(0).Item(9).ToString = "" Then
            TextBox7.Text = ""
        Else
            TextBox7.Text = ds.Tables(0).Rows(0).Item(9).ToString
        End If

        DropDownList2.SelectedValue = ds.Tables(0).Rows(0).Item(10).ToString()
        DropDownList4.SelectedValue = ds.Tables(0).Rows(0).Item(11).ToString()
        DropDownList3.SelectedValue = ds.Tables(0).Rows(0).Item(12).ToString()
        DropDownList5.SelectedValue = ds.Tables(0).Rows(0).Item(13).ToString()
        TextBox45.Text = ds.Tables(0).Rows(0).Item(6).ToString()


    End Sub

    Sub Limpiar()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        DropDownList1.Items.Clear()
        Combo1SP()
        DropDownList2.SelectedValue = 0
        DropDownList3.SelectedValue = 0
        DropDownList4.SelectedValue = 0
        DropDownList5.SelectedValue = 0
        DropDownList7.Items.Clear()
        DropDownList7.Items.Add(New ListItem("-Selecciona-", 0))


        Session("idSeleccion") = 0


    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Limpiar()
    End Sub

    Sub ComboInstructores()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,[nombres]+ ' ' +[paterno]+ ' '+[materno] as Nombre, id_ccs FROM SYS_empleados WHERE puesto = '2' AND area = '3' AND status=2"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        If Not IsPostBack Then

            DropDownList40.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList40.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList40.DataSource = cmd.ExecuteReader()
            DropDownList40.DataTextField = "Nombre"
            DropDownList40.DataValueField = "id"
            DropDownList40.DataBind()

            con.Close()
            con.Dispose()

        End If
    End Sub

    Sub ComboInstructoresActivo()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,[nombres]+ ' ' +[paterno]+ ' '+[materno] as Nombre, id_ccs FROM SYS_empleados WHERE puesto = '2' AND area = '3' AND status='2'"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        If Not IsPostBack Then

            DropDownList41.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList41.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList41.DataSource = cmd.ExecuteReader()
            DropDownList41.DataTextField = "Nombre"
            DropDownList41.DataValueField = "id"
            DropDownList41.DataBind()

            con.Close()
            con.Dispose()

        End If
    End Sub

    Private Sub DropDownList40_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList40.SelectedIndexChanged
        Llena2()
    End Sub

    Sub Llena2()
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select a.ID,nombres+ ' ' + paterno+ ' ' +materno as Nombre,campania as 'Campaña' FROM SYS_empleados a LEFT JOIN [dbo].[SYS_campanias] b ON a.campaña = b.id WHERE a.status = 1 AND jefe_directo = '" & DropDownList40.SelectedItem.Value & "'"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView9.DataSource = cmd.ExecuteReader()
        GridView9.DataBind()

        con.Close()
        con.Dispose()
    End Sub

    Private Sub DropDownList41_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList41.SelectedIndexChanged
        Llena1()
    End Sub

    Sub Llena1()
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select a.ID,nombres+ ' ' + paterno+ ' ' +materno as Nombre,campania as 'Campaña' FROM SYS_empleados a LEFT JOIN [dbo].[SYS_campanias] b ON a.campaña = b.id WHERE a.status = 1 AND jefe_directo = '" & DropDownList41.SelectedItem.Value & "'"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView10.DataSource = cmd.ExecuteReader()
        GridView10.DataBind()

        con.Close()
        con.Dispose()
    End Sub

    Protected Sub GridView9_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView9.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView9, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView9_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView9.RowCommand
        If e.CommandName = "Select" Then
            Session("idSeleccionCAP") = String.Format("{1}", e.CommandArgument, GridView9.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)

        End If



    End Sub

    Private Sub ImageButton11_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton11.Click



        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET jefe_directo = '" & DropDownList41.SelectedValue & "' WHERE id = " & Session("idSeleccionCAP")
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

        Llena1()
        Llena2()


    End Sub

    '########################################################### MODULO DE COORDINACION OPERACIONES ###########################################################

    Protected Sub GridView2_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView2.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView2, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView2_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView2.RowCommand
        If e.CommandName = "Select" Then
            Session("seleccionsinasignar") = String.Format("{1}", e.CommandArgument, GridView2.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
            Session("seleccionsinasignarnombre") = String.Format("{1}", e.CommandArgument, GridView2.Rows(Convert.ToInt32(e.CommandArgument)).Cells(1).Text)
            Session("seleccionsinasignarcampania") = String.Format("{1}", e.CommandArgument, GridView2.Rows(Convert.ToInt32(e.CommandArgument)).Cells(2).Text)
        End If


    End Sub

    Protected Sub GridView3_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView3.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView3, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView3_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView3.RowCommand
        If e.CommandName = "Select" Then
            Session("seleccionsupervisor") = String.Format("{1}", e.CommandArgument, GridView3.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
        End If


    End Sub

    Sub ListaAgentesAsignacion()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id, nombres+ ' ' + paterno+ ' ' +materno as Nombre, campania as Campaña FROM Plantilla WHERE status = 'Pendiente de Alta' ORDER BY campania"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView2.DataSource = cmd.ExecuteReader()
        GridView2.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Sub ListaAgentesSupervisor()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id, nombres+ ' ' + paterno+ ' ' +materno as Nombre, campania as Campaña FROM Plantilla WHERE (status = 'Preingreso' OR status = 'Activo') AND jefe_directo = '" & DropDownList8.SelectedItem.Text & "'"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView3.DataSource = cmd.ExecuteReader()
        GridView3.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Sub Combo3()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,[nombres]+ ' ' +[paterno]+ ' '+[materno] as Nombre FROM SYS_Empleados WHERE puesto = '1' AND area = '0' AND status = 2 ORDER BY [nombres]+ ' ' +[paterno]+ ' '+[materno]"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList8.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList8.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList8.DataSource = cmd.ExecuteReader()
            DropDownList8.DataTextField = "Nombre"
            DropDownList8.DataValueField = "id"
            DropDownList8.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Protected Sub DropDownList8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList8.SelectedIndexChanged
        ListaAgentesSupervisor()
    End Sub

    Protected Sub ImageButton3_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton3.Click


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 7, jefe_directo = '" & DropDownList8.SelectedValue.ToString & "' WHERE id = " & Session("seleccionsinasignar")
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

        Dim MensajeHTML As String

        MensajeHTML = "<html><head><style>p.MsoNormal, li.MsoNormal, div.MsoNormal{mso-style-unhide:no;mso-style-qformat:yes;mso-style-parent:'';margin:0cm;margin-bottom:.0001pt;mso-pagination:widow-orphan;font-size:11.0pt;font-family:'Calibri',sans-serif;mso-ascii-font-family:Calibri;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-font-family:Calibri;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:'Times New Roman';mso-bidi-theme-font:minor-bidi;mso-fareast-language:EN-US;}a:link, span.MsoHyperlink{mso-style-noshow:yes;mso-style-priority:99;color:#0563C1;mso-themecolor:hyperlink;text-decoration:underline;text-underline:single;}a:visited, span.MsoHyperlinkFollowed{mso-style-noshow:yes;mso-style-priority:99;color:#954F72;mso-themecolor:followedhyperlink;text-decoration:underline;text-underline:single;}</style></head><body><p class=MsoNormal>Coordinación ha asignado un nuevo agente:<o:p></o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Nombre: </b>" &
                      Session("seleccionsinasignarnombre") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Campaña: </b>" &
                      Session("seleccionsinasignarcampania") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Supervisor: </b>" &
                      DropDownList8.SelectedItem.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Coordinador: </b>" &
                      Request.Cookies("Usersettings")("Username") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><br><p class=MsoNormal><span style='mso-bookmark:_MailAutoSig'><span style='mso-fareast-font-family:'Times New Roman';mso-fareast-theme-font:minor-fareast;mso-fareast-language:ES-MX;mso-no-proof:yes'>Debes validar el alta <a href='http://10.0.0.40/Asistencia/Content/Administracion.aspx'>aqui</a> para continuar con el proceso.<o:p></o:p></span></span></p></body></html>"

        EnviarMail(GetListaNotificacion(4, 3), "***Nueva Alta***", MensajeHTML)

        ListaAgentesAsignacion()
        ListaAgentesSupervisor()
        ListaAgentesRH()
        ListaAgentesActivos()
        ListaAgentesPendientes()
        ListaAgentesRHBaja()


    End Sub


    '########################################################### MODULO DE SUPERVISOR OPERACIONES ###########################################################

    Protected Sub GridView5_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView5.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView5, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView5_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView5.RowCommand
        If e.CommandName = "Select" Then
            Session("bajaactivos") = String.Format("{1}", e.CommandArgument, GridView5.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
            Session("bajaactivosnombre") = String.Format("{1}", e.CommandArgument, GridView5.Rows(Convert.ToInt32(e.CommandArgument)).Cells(1).Text)
            Session("bajaactivoscampania") = String.Format("{1}", e.CommandArgument, GridView5.Rows(Convert.ToInt32(e.CommandArgument)).Cells(2).Text)
        End If


    End Sub

    Protected Sub GridView6_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView6.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView6, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView6_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView6.RowCommand
        If e.CommandName = "Select" Then
            Session("bajapendientes") = String.Format("{1}", e.CommandArgument, GridView6.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
        End If


    End Sub

    Sub ListaAgentesActivos()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id, nombres+ ' ' + paterno+ ' ' +materno as Nombre, campania as Campaña FROM Plantilla WHERE (status = 'Activo' OR status = 'Preingreso') AND id_super = '" & Request.Cookies("Usersettings")("Username") & "' ORDER BY campania"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView5.DataSource = cmd.ExecuteReader()
        GridView5.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Sub ListaAgentesPendientes()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id, nombres+ ' ' + paterno+ ' ' +materno as Nombre, campania as Campaña FROM Plantilla WHERE status = 'Pendiente de Baja' AND id_super = '" & Request.Cookies("Usersettings")("Username") & "' ORDER BY campania"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView6.DataSource = cmd.ExecuteReader()
        GridView6.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Private Sub ImageButton6_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton6.Click



        Dim MensajeHTML As String

        MensajeHTML = "<html><head><style>p.MsoNormal, li.MsoNormal, div.MsoNormal{mso-style-unhide:no;mso-style-qformat:yes;mso-style-parent:'';margin:0cm;margin-bottom:.0001pt;mso-pagination:widow-orphan;font-size:11.0pt;font-family:'Calibri',sans-serif;mso-ascii-font-family:Calibri;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-font-family:Calibri;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:'Times New Roman';mso-bidi-theme-font:minor-bidi;mso-fareast-language:EN-US;}a:link, span.MsoHyperlink{mso-style-noshow:yes;mso-style-priority:99;color:#0563C1;mso-themecolor:hyperlink;text-decoration:underline;text-underline:single;}a:visited, span.MsoHyperlinkFollowed{mso-style-noshow:yes;mso-style-priority:99;color:#954F72;mso-themecolor:followedhyperlink;text-decoration:underline;text-underline:single;}</style></head><body><p class=MsoNormal>Se ha dado de baja a un agente:<o:p></o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Nombre: </b>" &
                      Session("bajaactivosnombre") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Campaña: </b>" &
                      Session("bajaactivoscampania") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Supervisor: </b>" &
                      Request.Cookies("Usersettings")("Username") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><br><p class=MsoNormal><span style='mso-bookmark:_MailAutoSig'><span style='mso-fareast-font-family:'Times New Roman';mso-fareast-theme-font:minor-fareast;mso-fareast-language:ES-MX;mso-no-proof:yes'>Debes confirmar la baja <a href='http://10.0.0.40/Asistencia/Content/Administracion.aspx'>aqui</a> para continuar con el proceso.<o:p></o:p></span></span></p></body></html>"


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 4 WHERE id = " & Session("bajaactivos")
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

        EnviarMail(GetListaNotificacion(4, 3), "***Nueva Baja Pendiente***", MensajeHTML)

        ListaAgentesAsignacion()
        ListaAgentesSupervisor()
        ListaAgentesRH()
        ListaAgentesActivos()
        ListaAgentesPendientes()
        ListaAgentesRHBaja()



    End Sub

    Private Sub ImageButton7_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton7.Click
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 2 WHERE id = " & Session("bajapendientes")
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

        ListaAgentesAsignacion()
        ListaAgentesSupervisor()
        ListaAgentesRH()
        ListaAgentesActivos()
        ListaAgentesPendientes()
        ListaAgentesRHBaja()

    End Sub

    '########################################################### MODULO DE RECURSOS HUMANOS ###########################################################

    Protected Sub GridView4_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView4.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView4, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView4_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView4.RowCommand
        If e.CommandName = "Select" Then
            Session("idSeleccionRH") = String.Format("{1}", e.CommandArgument, GridView4.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
        End If
        Llena_CamposRH()

    End Sub

    Sub ListaAgentesRH()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT a.ID,a.Nombres,a.Paterno,a.Materno,a.no_empleado as 'No. Empleado',c.nombres+' '+c.paterno+' '+c.materno as 'Supervisor',b.campania as 'Campaña',a.fecha_nacimiento as 'Fecha de Nacimiento',a.Sexo,a.estado_civil as 'Estado Civil',a.CURP,a.RFC,a.NSS,a.Calle as 'Calle y Numero',a.delegacion_municipio as 'Delegación/Municipio',a.Estado,a.CP,a.telefono as 'Fijo',a.Celular FROM SYS_empleados a LEFT JOIN SYS_campanias b ON a.campaña = b.id LEFT JOIN SYS_empleados c ON a.jefe_directo = c.id WHERE a.STATUS =7 AND (DATEDIFF(day,a.fecha_capacitacion,CONVERT(DATE,GETDATE())) > = 30 OR a.fecha_capacitacion IS NULL)"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView4.DataSource = cmd.ExecuteReader()
        GridView4.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Sub Llena_CamposRH()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT a.Nombres,a.Paterno,a.materno,b.nombres+' '+b.paterno+' '+b.materno as Supervisor,a.campaña,CASE WHEN DATEPART(HOUR,a.entrada) >=12 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,a.entrada))+':00' ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,a.entrada))+':00' END as 'Entrada',CASE WHEN DATEPART(HOUR,a.salida) >=12 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,a.salida))+':00' ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,a.salida))+':00' END as 'Salida',DATEDIFF(HOUR,a.entrada,a.salida) as Jornada,a.telefono,a.celular,a.fecha_alta FROM SYS_empleados a LEFT JOIN SYS_empleados b ON a.jefe_directo = b.id WHERE a.status = 7 AND a.ID = " & Session("idSeleccionRH"), conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        TextBox8.Text = ds.Tables(0).Rows(0).Item(0).ToString()
        TextBox11.Text = ds.Tables(0).Rows(0).Item(1).ToString()
        TextBox12.Text = ds.Tables(0).Rows(0).Item(2).ToString()
        TextBox13.Text = ds.Tables(0).Rows(0).Item(3).ToString()
        Try
            TextBox51.Text = DateTime.ParseExact(Mid(ds.Tables(0).Rows(0).Item(10).ToString(), 1, 10), "dd/MM/yyyy", Nothing)
        Catch ex As Exception
        End Try

        DropDownList17.SelectedValue = ds.Tables(0).Rows(0).Item(4).ToString()
        DropDownList9.SelectedValue = ds.Tables(0).Rows(0).Item(5).ToString()
        DropDownList10.SelectedValue = ds.Tables(0).Rows(0).Item(6).ToString()
        TextBox22.Text = ds.Tables(0).Rows(0).Item(7).ToString()
        TextBox17.Text = ds.Tables(0).Rows(0).Item(8).ToString()
        TextBox18.Text = ds.Tables(0).Rows(0).Item(9).ToString()

    End Sub

    Sub Combo4()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,campania FROM SYS_campanias"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList17.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList17.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList17.DataSource = cmd.ExecuteReader()
            DropDownList17.DataTextField = "campania"
            DropDownList17.DataValueField = "id"
            DropDownList17.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub Combo4SP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,campania FROM SYS_campanias"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()



        DropDownList17.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList17.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList17.DataSource = cmd.ExecuteReader()
        DropDownList17.DataTextField = "campania"
        DropDownList17.DataValueField = "id"
        DropDownList17.DataBind()

        con.Close()
        con.Dispose()


    End Sub

    Sub ComboEstados()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cats").ConnectionString
        Dim strQuery As String = "SELECT ID,Estado FROM edos_mx ORDER BY Estado"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList16.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList16.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList16.DataSource = cmd.ExecuteReader()
            DropDownList16.DataTextField = "estado"
            DropDownList16.DataValueField = "id"
            DropDownList16.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub ComboEstadosSP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cats").ConnectionString
        Dim strQuery As String = "SELECT ID,Estado FROM edos_mx ORDER BY Estado"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList16.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList16.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList16.DataSource = cmd.ExecuteReader()
        DropDownList16.DataTextField = "estado"
        DropDownList16.DataValueField = "id"
        DropDownList16.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Sub ComboDelMun()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cats").ConnectionString
        Dim strQuery As String = "SELECT UPPER([delmun]) as delmun FROM delmun_mx WHERE edo = '" & DropDownList16.SelectedItem.Text & "' ORDER BY delmun"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList13.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList13.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList13.DataSource = cmd.ExecuteReader()
        DropDownList13.DataTextField = "delmun"
        DropDownList13.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Protected Sub DropDownList16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList16.SelectedIndexChanged
        DropDownList13.Items.Clear()
        ComboDelMun()
    End Sub

    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AltaRH()
    End Sub

    Sub AltaRH()

        Dim MensajeHTML As String

        MensajeHTML = "<html><head><style>p.MsoNormal, li.MsoNormal, div.MsoNormal{mso-style-unhide:no;mso-style-qformat:yes;mso-style-parent:'';margin:0cm;margin-bottom:.0001pt;mso-pagination:widow-orphan;font-size:11.0pt;font-family:'Calibri',sans-serif;mso-ascii-font-family:Calibri;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-font-family:Calibri;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:'Times New Roman';mso-bidi-theme-font:minor-bidi;mso-fareast-language:EN-US;}a:link, span.MsoHyperlink{mso-style-noshow:yes;mso-style-priority:99;color:#0563C1;mso-themecolor:hyperlink;text-decoration:underline;text-underline:single;}a:visited, span.MsoHyperlinkFollowed{mso-style-noshow:yes;mso-style-priority:99;color:#954F72;mso-themecolor:followedhyperlink;text-decoration:underline;text-underline:single;}</style></head><body><p class=MsoNormal>Se ha dado de alta un nuevo agente:<o:p></o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Nombre: </b>" &
                      TextBox8.Text & " " & TextBox11.Text & " " & TextBox12.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Campaña: </b>" &
                      DropDownList17.SelectedItem.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Ejecutivo Nómina: </b>" &
                      Request.Cookies("Usersettings")("Username") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><br><p class=MsoNormal><span style='mso-bookmark:_MailAutoSig'><span style='mso-fareast-font-family:'Times New Roman';mso-fareast-theme-font:minor-fareast;mso-fareast-language:ES-MX;mso-no-proof:yes'>El agente ya aparece en el control de asistencia <a href='http://10.0.0.40/Asistencia/Content/Asistencia.aspx'>aqui</a>.<o:p></o:p></span></span></p></body></html>"

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 2, pago_capa = 0, campaña = '" & DropDownList17.SelectedValue.ToString & "', no_empleado = '" & TextBox19.Text & "', entrada = '" & DropDownList9.SelectedItem.Text & "', salida = '" & DropDownList10.SelectedItem.Text & "', nombres = '" & TextBox8.Text & "', paterno = '" & TextBox11.Text & "', materno = '" & TextBox12.Text & "', fecha_nacimiento = '" & CDate(TextBox21.Text) & "', sexo = '" & DropDownList14.SelectedItem.Text & "', estado_civil = '" & DropDownList15.SelectedItem.Text & "', curp = '" & TextBox20.Text & "', rfc = '" & TextBox15.Text & "', nss = '" & TextBox16.Text & "', calle = '" & TextBox23.Text & "', delegacion_municipio = '" & DropDownList13.SelectedItem.Text & "', estado = '" & DropDownList16.SelectedItem.Text & "', cp = '" & TextBox24.Text & "', celular = '" & TextBox18.Text & "', telefono = '" & TextBox17.Text & "', dependientes_economicos = '" & DropDownList21.SelectedItem.Text & "', escolaridad = '" & DropDownList22.SelectedItem.Text & "' WHERE id = '" & Session("idSeleccionRH") & "'"
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
        msgmensaje(0) = "¡Alta Aplicada!"
        msgtipo(1) = 2
        msgmensaje(1) = "!Notificación Enviada!"
        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        EnviarMail(GetCorreoSupervisor(TextBox13.Text), "***Nueva Alta Aplicada***", MensajeHTML)

        LimpiarRH()
        ListaAgentesCapa()
        ListaAgentesAsignacion()
        ListaAgentesRH()
        ListaAgentesActivos()
        ListaAgentesPendientes()
        ListaAgentesRHBaja()


    End Sub

    Sub LimpiarRH()

        TextBox8.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox19.Text = ""
        TextBox13.Text = ""
        TextBox20.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox51.Text = ""
        TextBox52.Text = ""
        DropDownList17.Items.Clear()
        Combo4SP()
        DropDownList14.SelectedValue = 0
        DropDownList15.SelectedValue = 0
        DropDownList9.SelectedValue = 0
        DropDownList10.SelectedValue = 0
        DropDownList21.SelectedValue = 0
        DropDownList22.SelectedValue = 0
        DropDownList16.Items.Clear()
        ComboEstadosSP()
        DropDownList13.Items.Clear()
        DropDownList13.Items.Add(New ListItem("-Selecciona-", 0))


    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        LimpiarRH()
    End Sub

    Protected Sub GridView7_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView7.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView7, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView7_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView7.RowCommand
        If e.CommandName = "Select" Then
            Session("idSeleccionRHBaja") = String.Format("{1}", e.CommandArgument, GridView7.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
        End If
        Llena_CamposRHBaja()

    End Sub

    Sub ListaAgentesRHBaja()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT a.ID,a.Nombres,a.Paterno,a.Materno,a.no_empleado as 'No. Empleado',c.nombres+' '+c.paterno+' '+c.materno as 'Supervisor',b.campania as 'Campaña',a.fecha_nacimiento as 'Fecha de Nacimiento',a.Sexo,a.estado_civil as 'Estado Civil',a.CURP,a.RFC,a.NSS,a.Calle as 'Calle y Numero',a.delegacion_municipio as 'Delegación/Municipio',a.Estado,a.CP,a.telefono as 'Fijo',a.Celular FROM SYS_empleados a LEFT JOIN SYS_campanias b ON a.campaña = b.id LEFT JOIN SYS_empleados c ON a.jefe_directo = c.id WHERE a.STATUS =4"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView7.DataSource = cmd.ExecuteReader()
        GridView7.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Sub Llena_CamposRHBaja()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT a.Nombres,a.Paterno,a.Materno,a.no_empleado,b.nombres+' '+b.paterno+' '+b.Materno as Supervisor,c.campania,a.curp,a.rfc,a.nss,a.sexo,a.fecha_nacimiento,a.estado_civil,CASE WHEN DATEPART(HOUR,a.entrada) >=11 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,a.entrada))+':00' ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,a.entrada))+':00' END as 'Entrada',CASE WHEN DATEPART(HOUR,a.salida) >=11 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,a.salida))+':00' ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,a.salida))+':00' END as 'Salida',DATEDIFF(HOUR,a.entrada,a.salida) as Jornada,a.telefono,a.celular,a.calle,a.estado,a.delegacion_municipio,a.cp FROM SYS_empleados a LEFT JOIN SYS_empleados b ON a.jefe_directo = b.id LEFT JOIN SYS_campanias c On a.campaña = c.id  WHERE a.status = 4 AND a.ID = " & Session("idSeleccionRHBaja"), conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        TextBox14.Text = ds.Tables(0).Rows(0).Item(0).ToString()
        TextBox25.Text = ds.Tables(0).Rows(0).Item(1).ToString()
        TextBox26.Text = ds.Tables(0).Rows(0).Item(2).ToString()

        TextBox27.Text = ds.Tables(0).Rows(0).Item(3).ToString()
        TextBox28.Text = ds.Tables(0).Rows(0).Item(4).ToString()

        TextBox40.Text = ds.Tables(0).Rows(0).Item(5).ToString()

        TextBox29.Text = ds.Tables(0).Rows(0).Item(6).ToString()
        TextBox30.Text = ds.Tables(0).Rows(0).Item(7).ToString()
        TextBox31.Text = ds.Tables(0).Rows(0).Item(8).ToString()

        DropDownList12.SelectedItem.Text = ds.Tables(0).Rows(0).Item(9).ToString()

        TextBox32.Text = ds.Tables(0).Rows(0).Item(10).ToString()

        DropDownList18.SelectedItem.Text = ds.Tables(0).Rows(0).Item(11).ToString()

        DropDownList19.SelectedValue = ds.Tables(0).Rows(0).Item(12).ToString()
        DropDownList20.SelectedValue = ds.Tables(0).Rows(0).Item(13).ToString()

        TextBox33.Text = ds.Tables(0).Rows(0).Item(14).ToString()

        TextBox34.Text = ds.Tables(0).Rows(0).Item(15).ToString()
        TextBox35.Text = ds.Tables(0).Rows(0).Item(16).ToString()
        TextBox36.Text = ds.Tables(0).Rows(0).Item(17).ToString()

        TextBox38.Text = ds.Tables(0).Rows(0).Item(18).ToString()
        TextBox39.Text = ds.Tables(0).Rows(0).Item(19).ToString()

        TextBox37.Text = ds.Tables(0).Rows(0).Item(20).ToString()

    End Sub

    Sub BajaRH()

        Dim MensajeHTML As String

        MensajeHTML = "<html><head><style>p.MsoNormal, li.MsoNormal, div.MsoNormal{mso-style-unhide:no;mso-style-qformat:yes;mso-style-parent:'';margin:0cm;margin-bottom:.0001pt;mso-pagination:widow-orphan;font-size:11.0pt;font-family:'Calibri',sans-serif;mso-ascii-font-family:Calibri;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-font-family:Calibri;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:'Times New Roman';mso-bidi-theme-font:minor-bidi;mso-fareast-language:EN-US;}a:link, span.MsoHyperlink{mso-style-noshow:yes;mso-style-priority:99;color:#0563C1;mso-themecolor:hyperlink;text-decoration:underline;text-underline:single;}a:visited, span.MsoHyperlinkFollowed{mso-style-noshow:yes;mso-style-priority:99;color:#954F72;mso-themecolor:followedhyperlink;text-decoration:underline;text-underline:single;}</style></head><body><p class=MsoNormal>Se ha aplicado la siguiente baja:<o:p></o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Nombre: </b>" &
                      TextBox14.Text & " " & TextBox25.Text & " " & TextBox26.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Campaña: </b>" &
                      TextBox40.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Ejecutivo Nómina: </b>" &
                      Request.Cookies("Usersettings")("Username") &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Motivo de Baja: </b>" &
                      DropDownList23.SelectedItem.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><p class=MsoNormal><b style='mso-bidi-font-weight:normal'>Comentarios: </b>" &
                      TextBox52.Text &
                      "<b style='mso-bidi-font-weight:normal'><o:p></o:p></b></p><br><p class=MsoNormal><span style='mso-bookmark:_MailAutoSig'><span style='mso-fareast-font-family:'Times New Roman';mso-fareast-theme-font:minor-fareast;mso-fareast-language:ES-MX;mso-no-proof:yes'>El agente ya no aparece en el control de asistencia.<o:p></o:p></span></span></p></body></html>"



        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET [status] = 3, fecha_baja = '" & TextBox53.Text & "', motivo_baja = '" & DropDownList23.SelectedItem.Text & "', comentario_baja = '" & TextBox52.Text & "' WHERE id = '" & Session("idSeleccionRHBaja") & "'"
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
        msgmensaje(0) = "¡Baja Aplicada!"
        msgtipo(1) = 2
        msgmensaje(1) = "!Notificación Enviada!"
        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        EnviarMail(GetCorreoSupervisor(TextBox28.Text), "***Confirmación de Baja***", MensajeHTML)

        LimpiaRHBaja()
        ListaAgentesCapa()
        ListaAgentesAsignacion()
        ListaAgentesRH()
        ListaAgentesActivos()
        ListaAgentesPendientes()
        ListaAgentesRHBaja()


    End Sub

    Sub LimpiaRHBaja()

        TextBox14.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""

        TextBox27.Text = ""
        TextBox28.Text = ""

        TextBox40.Text = ""

        TextBox29.Text = ""
        TextBox30.Text = ""
        TextBox31.Text = ""

        DropDownList12.SelectedItem.Text = "-"

        TextBox32.Text = ""

        DropDownList18.SelectedItem.Text = "-"

        DropDownList19.SelectedValue = 0
        DropDownList20.SelectedValue = 0

        TextBox33.Text = ""

        TextBox34.Text = ""
        TextBox35.Text = ""
        TextBox36.Text = ""

        TextBox38.Text = ""
        TextBox39.Text = ""

        TextBox37.Text = ""

        TextBox52.Text = ""
        TextBox53.Text = ""

        DropDownList23.SelectedValue = 0

    End Sub


    Protected Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        LimpiaRHBaja()
    End Sub

    Protected Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        BajaRH()
    End Sub

    Sub Buscador_Edicion()

        Dim nombresearch As String

        If TextBox68.Text = "" Then
            nombresearch = ""
        Else
            nombresearch = "%" & TextBox68.Text & "%"
        End If

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT a.ID,a.no_empleado as 'No. Empleado',a.id_acd1 as 'ID ACD',a.paterno+' '+a.materno+' '+a.nombres as Nombre,b.Status,c.Area,d.Puesto,f.campania as Campaña,e.nombres+' '+e.paterno+' '+e.materno as Supervisor,a.fecha_alta 'Fecha Alta',a.Entrada,a.Salida,a.fecha_nacimiento as 'Fecha de Naciemiento',a.CURP,a.RFC,a.NSS,a.dependientes_economicos as Dependientes,a.Escolaridad,a.Calle,a.delegacion_municipio as Delegacion,a.Estado,a.CP,a.Celular,a.Telefono FROM SYS_empleados a LEFT JOIN SYS_status b ON a.status = b.id LEFT JOIN SYS_areas c ON a.area = c.id LEFT JOIN SYS_puestos d ON a.puesto = d.id LEFT JOIN SYS_empleados e ON a.jefe_directo = e.id LEFT JOIN SYS_campanias f ON a.campaña = f.id WHERE (a.status = 2 or a.STATUS = 3 OR a.STATUS = 4 OR a.status = 7) AND (a.id_acd1 = '" & TextBox67.Text & "' OR a.no_empleado = '" & TextBox67.Text & "' OR a.nombres + ' ' + a.paterno + ' ' + a.materno LIKE '" & nombresearch & "')"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView8.DataSource = cmd.ExecuteReader()
        GridView8.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Sub ComboEstados2()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cats").ConnectionString
        Dim strQuery As String = "SELECT ID,Estado FROM edos_mx ORDER BY Estado"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList36.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList36.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList36.DataSource = cmd.ExecuteReader()
            DropDownList36.DataTextField = "estado"
            DropDownList36.DataValueField = "estado"
            DropDownList36.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub ComboEstados2SP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cats").ConnectionString
        Dim strQuery As String = "SELECT ID,Estado FROM edos_mx ORDER BY Estado"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList36.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList36.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList36.DataSource = cmd.ExecuteReader()
        DropDownList36.DataTextField = "estado"
        DropDownList36.DataValueField = "id"
        DropDownList36.DataBind()

        con.Close()


    End Sub

    Private Sub DropDownList36_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList36.SelectedIndexChanged
        DropDownList37.Items.Clear()
        ComboDelMun2()
    End Sub

    Sub ComboDelMun2()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cats").ConnectionString
        Dim strQuery As String = "SELECT UPPER([delmun]) as delmun FROM delmun_mx WHERE edo = '" & DropDownList36.SelectedItem.Text & "' ORDER BY delmun"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList37.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList37.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList37.DataSource = cmd.ExecuteReader()
        DropDownList37.DataTextField = "delmun"
        DropDownList37.DataValueField = "delmun"
        DropDownList37.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Sub ComboDelMunLoad(ESTADO As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cats").ConnectionString
        Dim strQuery As String = "SELECT UPPER([delmun]) as delmun FROM delmun_mx WHERE edo = '" & ESTADO & "' ORDER BY delmun"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList37.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList37.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList37.DataSource = cmd.ExecuteReader()
        DropDownList37.DataTextField = "delmun"
        DropDownList37.DataValueField = "delmun"
        DropDownList37.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Sub ComboCAMP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,campania FROM SYS_campanias"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList6.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList6.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList6.DataSource = cmd.ExecuteReader()
            DropDownList6.DataTextField = "campania"
            DropDownList6.DataValueField = "id"
            DropDownList6.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub ComboCAMPSP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,campania FROM SYS_campanias"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()



        DropDownList6.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList6.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList6.DataSource = cmd.ExecuteReader()
        DropDownList6.DataTextField = "campania"
        DropDownList6.DataValueField = "id"
        DropDownList6.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Sub ComboSUP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,[nombres]+ ' ' +[paterno]+ ' '+[materno] as Nombre FROM SYS_Empleados WHERE puesto >= '1' AND status=2 ORDER BY [nombres]+ ' ' +[paterno]+ ' '+[materno]"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList38.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList38.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList38.DataSource = cmd.ExecuteReader()
            DropDownList38.DataTextField = "Nombre"
            DropDownList38.DataValueField = "id"
            DropDownList38.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub ComboArea()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT * FROM SYS_areas"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        If Not IsPostBack Then

            DropDownList30.Items.Add(New ListItem("-Selecciona-", "X"))
            DropDownList30.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList30.DataSource = cmd.ExecuteReader()
            DropDownList30.DataTextField = "area"
            DropDownList30.DataValueField = "id"
            DropDownList30.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub ComboPuesto()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT * FROM SYS_puestos"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        If Not IsPostBack Then

            DropDownList31.Items.Add(New ListItem("-Selecciona-", "X"))
            DropDownList31.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList31.DataSource = cmd.ExecuteReader()
            DropDownList31.DataTextField = "puesto"
            DropDownList31.DataValueField = "id"
            DropDownList31.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub ComboStatus()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT * FROM SYS_status"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        If Not IsPostBack Then

            DropDownList39.Items.Add(New ListItem("-Selecciona-", "X"))
            DropDownList39.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList39.DataSource = cmd.ExecuteReader()
            DropDownList39.DataTextField = "status"
            DropDownList39.DataValueField = "id"
            DropDownList39.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Protected Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        LimpiarEdicion()
    End Sub

    Sub Llena_CamposEdicion()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet



        Dim cmd As SqlCommand = New SqlCommand("SELECT id,status,su,id_ccs,pass_ccs,reclutador,instructor,fecha_tronco,fecha_capacitacion,generacion,entrada_capa,salida_capa,evaluacion_final,pago_capa,fecha_alta ,fecha_baja,motivo_baja,comentario_baja,no_empleado,CASE WHEN DATEPART(HOUR,entrada) >=12 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,entrada))+CASE WHEN DATEPART(MINUTE,entrada) >=30 THEN ':30' ELSE ':00' END  ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,entrada))+CASE WHEN DATEPART(MINUTE,entrada) >=30 THEN ':30' ELSE ':00' END  END as 'Entrada',CASE WHEN DATEPART(HOUR,salida) >=12 THEN CONVERT(NVARCHAR(MAX),DATEPART(HOUR,salida))+CASE WHEN DATEPART(MINUTE,salida) >=30 THEN ':30' ELSE ':00' END  ELSE '0'+CONVERT(NVARCHAR(MAX),DATEPART(HOUR,salida))+CASE WHEN DATEPART(MINUTE,salida) >=30 THEN ':30' ELSE ':00' END  END as 'Salida',area,puesto,jefe_directo,campaña,id_acd1,id_acd2,id_app1,id_app2,id_app3,nombres,paterno,materno,fecha_nacimiento,sexo,estado_civil,curp,rfc,nss,dependientes_economicos,escolaridad,mail_ccs,calle,delegacion_municipio,estado,cp,celular,telefono FROM SYS_empleados WHERE id= '" & Session("idSeleccion") & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        TextBox46.Text = ds.Tables(0).Rows(0).Item("nombres").ToString()
        TextBox47.Text = ds.Tables(0).Rows(0).Item("paterno").ToString()
        TextBox54.Text = ds.Tables(0).Rows(0).Item("materno").ToString()
        TextBox55.Text = ds.Tables(0).Rows(0).Item("no_empleado").ToString()
        TextBox57.Text = ds.Tables(0).Rows(0).Item("curp").ToString()
        TextBox58.Text = ds.Tables(0).Rows(0).Item("rfc").ToString()
        TextBox59.Text = ds.Tables(0).Rows(0).Item("nss").ToString()
        If ds.Tables(0).Rows(0).Item("fecha_nacimiento").ToString = Nothing Then
        Else
            TextBox60.Text = DateTime.ParseExact(Mid(ds.Tables(0).Rows(0).Item("fecha_nacimiento").ToString, 1, 10), "dd/MM/yyyy", Nothing)
        End If
        TextBox61.Text = ds.Tables(0).Rows(0).Item("id_acd1").ToString()
        If ds.Tables(0).Rows(0).Item("fecha_alta").ToString = Nothing Then
        Else
            TextBox62.Text = DateTime.ParseExact(Mid(ds.Tables(0).Rows(0).Item("fecha_alta").ToString, 1, 10), "dd/MM/yyyy", Nothing)
        End If
        TextBox63.Text = ds.Tables(0).Rows(0).Item("telefono").ToString()
        TextBox64.Text = ds.Tables(0).Rows(0).Item("celular").ToString()
        TextBox65.Text = ds.Tables(0).Rows(0).Item("calle").ToString()
        TextBox66.Text = ds.Tables(0).Rows(0).Item("cp").ToString()

        DropDownList6.SelectedValue = ds.Tables(0).Rows(0).Item("campaña").ToString()
        DropDownList30.SelectedValue = ds.Tables(0).Rows(0).Item("area").ToString()
        DropDownList31.SelectedValue = ds.Tables(0).Rows(0).Item("puesto").ToString()
        DropDownList32.SelectedValue = ds.Tables(0).Rows(0).Item("entrada").ToString()
        DropDownList33.SelectedValue = ds.Tables(0).Rows(0).Item("salida").ToString()
        DropDownList34.SelectedValue = ds.Tables(0).Rows(0).Item("dependientes_economicos").ToString()

        If ds.Tables(0).Rows(0).Item("escolaridad").ToString() = Nothing Then
        Else
            DropDownList35.SelectedValue = ds.Tables(0).Rows(0).Item("escolaridad").ToString()
        End If

        If ds.Tables(0).Rows(0).Item("estado").ToString() = Nothing Then
        Else
            DropDownList36.SelectedValue = ds.Tables(0).Rows(0).Item("estado").ToString()
        End If

        ComboDelMunLoad(ds.Tables(0).Rows(0).Item("estado").ToString())


        If ds.Tables(0).Rows(0).Item("delegacion_municipio").ToString() = Nothing Then

        Else
            DropDownList37.SelectedValue = ds.Tables(0).Rows(0).Item("delegacion_municipio").ToString()
        End If

        Try
            If ds.Tables(0).Rows(0).Item("jefe_directo").ToString() = Nothing Then
            Else
                DropDownList38.SelectedValue = ds.Tables(0).Rows(0).Item("jefe_directo").ToString()
            End If
        Catch ex As Exception

        End Try

        DropDownList39.SelectedValue = ds.Tables(0).Rows(0).Item("status").ToString()

        TextBox69.Text = ds.Tables(0).Rows(0).Item("mail_ccs").ToString()

        Session("UpdateAgente") = ds.Tables(0).Rows(0).Item("id").ToString()
        'Session("UpCampania") = ds.Tables(0).Rows(0).Item("campaña").ToString()


    End Sub

    Sub LimpiarEdicion()

        TextBox46.Text = Nothing
        TextBox47.Text = Nothing
        TextBox54.Text = Nothing
        TextBox55.Text = Nothing
        TextBox57.Text = Nothing
        TextBox58.Text = Nothing
        TextBox59.Text = Nothing
        TextBox60.Text = Nothing
        TextBox61.Text = Nothing
        TextBox62.Text = Nothing
        TextBox63.Text = Nothing
        TextBox64.Text = Nothing
        TextBox65.Text = Nothing
        TextBox66.Text = Nothing
        TextBox69.Text = Nothing

        DropDownList6.SelectedValue = 0
        DropDownList30.SelectedValue = "X"
        DropDownList31.SelectedValue = "X"
        DropDownList32.SelectedValue = 0
        DropDownList33.SelectedValue = 0
        DropDownList34.SelectedValue = 0
        DropDownList35.SelectedValue = 0
        DropDownList36.SelectedValue = 0
        DropDownList37.Items.Clear()
        DropDownList37.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList38.SelectedValue = 0
        DropDownList39.SelectedValue = "X"


    End Sub

    Protected Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Buscador_Edicion()
    End Sub

    Protected Sub GridView8_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView8.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            e.Row.Attributes.Add("OnMouseOver", "On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Off(this);")
            e.Row.Attributes("OnClick") =
            Page.ClientScript.GetPostBackClientHyperlink(GridView8, "Select$" + e.Row.RowIndex.ToString)

        End If

    End Sub

    Private Sub GridView8_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView8.RowCommand
        If e.CommandName = "Select" Then
            Session("idSeleccion") = String.Format("{1}", e.CommandArgument, GridView8.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
            Session("Preingreso") = String.Format("{1}", e.CommandArgument, GridView8.Rows(Convert.ToInt32(e.CommandArgument)).Cells(4).Text)
            If String.Format("{1}", e.CommandArgument, GridView8.Rows(Convert.ToInt32(e.CommandArgument)).Cells(4).Text) = "Preingreso" Then

                RequiredFieldValidator60.Enabled = False
                RequiredFieldValidator63.Enabled = False
                RequiredFieldValidator64.Enabled = False
                RequiredFieldValidator65.Enabled = False
                RequiredFieldValidator67.Enabled = False
                RequiredFieldValidator72.Enabled = False
                RequiredFieldValidator73.Enabled = False
                RequiredFieldValidator74.Enabled = False
                RequiredFieldValidator76.Enabled = False
                RequiredFieldValidator77.Enabled = False
                RequiredFieldValidator78.Enabled = False
                RequiredFieldValidator79.Enabled = False
            Else
                RequiredFieldValidator60.Enabled = True
                RequiredFieldValidator63.Enabled = True
                RequiredFieldValidator64.Enabled = True
                RequiredFieldValidator65.Enabled = True
                RequiredFieldValidator67.Enabled = True
                RequiredFieldValidator72.Enabled = True
                RequiredFieldValidator73.Enabled = True
                RequiredFieldValidator74.Enabled = True
                RequiredFieldValidator76.Enabled = True
                RequiredFieldValidator77.Enabled = True
                RequiredFieldValidator78.Enabled = True
                RequiredFieldValidator79.Enabled = True
            End If
        End If
        Llena_CamposEdicion()

    End Sub

    Protected Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        ActualizaRegistro()
        ActualizaQA()
        ' ActualizaFecha()
    End Sub

    Sub ActualizaQA()
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE QA.dbo.SYS_Monitoreos SET  id_acd = '" & TextBox61.Text & "' WHERE agente = " & Session("UpdateAgente")

        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

        LimpiarEdicion()
    End Sub

    Sub ActualizaFecha()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "UPDATE SYS_empleados SET ultimo_cambio=GETDATE() WHERE id= " & Session("UpdateAgente")

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

    Sub ActualizaRegistro()

        If Session("Preingreso") <> "Preingreso" Then
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim strQuery As String = "UPDATE SYS_empleados Set nombres = '" & TextBox46.Text & "', paterno = '" & TextBox47.Text & "', materno = '" & TextBox54.Text & "', no_empleado = '" & TextBox55.Text & "', jefe_directo = '" & DropDownList38.SelectedItem.Value & "', campaña = '" & DropDownList6.SelectedItem.Value & "', curp = '" & TextBox57.Text & "' , rfc = '" & TextBox58.Text & "', nss = '" & TextBox59.Text & "', area = '" & DropDownList30.SelectedItem.Value & "', fecha_nacimiento = '" & TextBox60.Text & "', puesto = '" & DropDownList31.SelectedItem.Value & "', entrada = '" & DropDownList32.SelectedItem.Text & "', salida = '" & DropDownList33.SelectedItem.Value & "', id_acd1 = '" & TextBox61.Text & "', fecha_alta = '" & TextBox62.Text & "', dependientes_economicos = '" & DropDownList34.SelectedItem.Text & "', escolaridad = '" & DropDownList35.SelectedItem.Text & "', status = '" & DropDownList39.SelectedItem.Value & "', mail_ccs = '" & TextBox69.Text & "', telefono = '" & TextBox63.Text & "', celular = '" & TextBox64.Text & "', calle = '" & TextBox65.Text & "', estado = '" & DropDownList36.SelectedItem.Text & "', delegacion_municipio = '" & DropDownList37.SelectedItem.Value & "', cp = '" & TextBox66.Text & "' WHERE id = " & Session("UpdateAgente")

            Dim con As New SqlConnection(strConnString)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            con.Dispose()

            'LimpiarEdicion()
        Else
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim strQuery As String = "UPDATE SYS_empleados Set nombres = '" & TextBox46.Text & "', paterno = '" & TextBox47.Text & "', materno = '" & TextBox54.Text & "', jefe_directo = '" & DropDownList38.SelectedItem.Value & "', campaña = '" & DropDownList6.SelectedItem.Value & "', area = '" & DropDownList30.SelectedItem.Value & "', puesto = '" & DropDownList31.SelectedItem.Value & "', entrada = '" & DropDownList32.SelectedItem.Text & "', salida = '" & DropDownList33.SelectedItem.Value & "', id_acd1 = '" & TextBox61.Text & "', fecha_alta = '" & TextBox62.Text & "', status = '" & DropDownList39.SelectedItem.Value & "', telefono = '" & TextBox63.Text & "', celular = '" & TextBox64.Text & "' WHERE id = " & Session("UpdateAgente")
            Dim con As New SqlConnection(strConnString)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            con.Dispose()

            LimpiarEdicion()
        End If

    End Sub

    Protected Sub DropDownList6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList6.SelectedIndexChanged
        ActualizaFecha()
    End Sub

    ' ########################################################### ALTA ADMINISTRATIVOS ###########################################################

    Sub Combo5()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,campania FROM SYS_campanias WHERE status=1 ORDER BY campania ASC"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList11.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList11.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList11.DataSource = cmd.ExecuteReader()
            DropDownList11.DataTextField = "campania"
            DropDownList11.DataValueField = "id"
            DropDownList11.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub Combo5SP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id,campania FROM SYS_campanias"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList11.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList11.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList11.DataSource = cmd.ExecuteReader()
        DropDownList11.DataTextField = "campania"
        DropDownList11.DataValueField = "id"
        DropDownList11.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Sub Combo6()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id,area FROM SYS_areas"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList28.Items.Add(New ListItem("-Selecciona-", "x"))
            DropDownList28.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList28.DataSource = cmd.ExecuteReader()
            DropDownList28.DataTextField = "area"
            DropDownList28.DataValueField = "id"
            DropDownList28.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub Combo6SP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id,area FROM SYS_areas"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList28.Items.Add(New ListItem("-Selecciona-", "x"))
        DropDownList28.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList28.DataSource = cmd.ExecuteReader()
        DropDownList28.DataTextField = "area"
        DropDownList28.DataValueField = "id"
        DropDownList28.DataBind()

        con.Close()
        con.Dispose()


    End Sub

    Sub Combo7()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id,puesto FROM SYS_puestos"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList27.Items.Add(New ListItem("-Selecciona-", "x"))
            DropDownList27.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList27.DataSource = cmd.ExecuteReader()
            DropDownList27.DataTextField = "puesto"
            DropDownList27.DataValueField = "id"
            DropDownList27.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub Combo7SP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id,puesto FROM SYS_puestos WHERE id >0"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList27.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList27.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList27.DataSource = cmd.ExecuteReader()
        DropDownList27.DataTextField = "puesto"
        DropDownList27.DataValueField = "id"
        DropDownList27.DataBind()

        con.Close()
        con.Dispose()


    End Sub

    Sub Combo8()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id,nombres+' '+paterno+' '+materno as 'nombre'FROM SYS_empleados WHERE puesto >0 AND puesto <> 2  AND area <> 4 and status in (2,7)"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList29.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList29.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList29.DataSource = cmd.ExecuteReader()
            DropDownList29.DataTextField = "nombre"
            DropDownList29.DataValueField = "id"
            DropDownList29.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub

    Sub Combo8SP()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,nombres+' '+paterno+' '+materno as 'nombre'FROM SYS_empleados WHERE puesto >0 AND puesto <> 2  AND area <> 4 "
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        DropDownList29.Items.Add(New ListItem("-Selecciona-", 0))
        DropDownList29.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList29.DataSource = cmd.ExecuteReader()
        DropDownList29.DataTextField = "nombre"
        DropDownList29.DataValueField = "id"
        DropDownList29.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Sub AltaAmin()

        Dim user As String
        user = StrConv(Mid(Replace(TextBox41.Text, " ", ""), 1, 1) & Mid(Replace(TextBox42.Text, " ", ""), 1, 4) & Mid(Replace(TextBox43.Text, " ", ""), 1, 3), vbLowerCase)


        Dim x As New Funciones

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString

        Dim strQuery As String
        If DropDownList27.SelectedItem.Text = "Agente" Then
            strQuery = "INSERT INTO SYS_empleados (reclutador,[status],id_ccs,pass_ccs,entrada,salida,area,puesto,jefe_directo,campaña,nombres,paterno,materno,celular,telefono, mail_ccs,fecha_nacimiento,id_acd1,no_empleado) VALUES ('MTY',2,'" & user & "','" & x.Passcrypt(user) & "' ,'" & DropDownList25.SelectedValue.ToString & "', '" & DropDownList26.SelectedValue.ToString & "', '" & DropDownList28.SelectedValue.ToString & "', '" & DropDownList27.SelectedValue.ToString & "', '" & DropDownList29.SelectedValue.ToString & "', '" & DropDownList11.SelectedValue.ToString & "', '" & TextBox41.Text & "', '" & TextBox42.Text & "', '" & TextBox43.Text & "', '" & TextBox49.Text & "', '" & TextBox48.Text & "', '" & TextBox50.Text & "', '" & TextBox71.Text & "', '" & TextBox72.Text & "', '" & TextBox73.Text & "')"
        Else
            strQuery = "INSERT INTO SYS_empleados ([status],id_ccs,pass_ccs,entrada,salida,area,puesto,jefe_directo,campaña,nombres,paterno,materno,celular,telefono, mail_ccs) VALUES (2,'" & user & "','" & x.Passcrypt(user) & "' ,'" & DropDownList25.SelectedValue.ToString & "', '" & DropDownList26.SelectedValue.ToString & "', '" & DropDownList28.SelectedValue.ToString & "', '" & DropDownList27.SelectedValue.ToString & "', '" & DropDownList29.SelectedValue.ToString & "', '" & DropDownList11.SelectedValue.ToString & "', '" & TextBox41.Text & "', '" & TextBox42.Text & "', '" & TextBox43.Text & "', '" & TextBox49.Text & "', '" & TextBox48.Text & "', '" & TextBox50.Text & "')"
        End If


        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()

        Alerta.EnviarMail("ricardo.gomez@ccscontactcenter.com", "ricardo.gomez@ccscontactcenter.com", "Alta de nuevo usuario", "Se ha dado de alta el siguiente usuario:  </br> Nombre: " + TextBox41.Text + " " + TextBox42.Text + " " + TextBox43.Text + "  </br> Usuario: " + user + " </br>  Password: " + user)

        msgtipo(0) = 1
        msgmensaje(0) = "¡Alta Correcta!"
        msgtipo(1) = 2
        msgmensaje(1) = "!Notificación Enviada!"
        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        Limpiar()
        ListaAgentesCapa()
        ListaAgentesAsignacion()
        ListaAgentesActivos()
        ListaAgentesRH()
        ListaAgentesPendientes()
        ListaAgentesRHBaja()

    End Sub

    Sub LimpiaAltaAdmin()

        DropDownList11.Items.Clear()
        DropDownList28.Items.Clear()
        DropDownList27.Items.Clear()
        DropDownList29.Items.Clear()

        Combo5SP()
        Combo6SP()
        Combo7SP()
        Combo8SP()


        TextBox41.Text = ""
        TextBox42.Text = ""
        TextBox43.Text = ""

        DropDownList11.SelectedValue = 0
        DropDownList28.SelectedValue = "x"
        DropDownList27.SelectedValue = 0
        DropDownList29.SelectedValue = 0

        TextBox50.Text = ""
        TextBox48.Text = ""
        TextBox49.Text = ""
        TextBox71.Text = ""
        TextBox72.Text = ""
        TextBox73.Text = ""

        DropDownList25.SelectedValue = 0
        DropDownList26.SelectedValue = 0

    End Sub

    Protected Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        AltaAmin()
        LimpiaAltaAdmin()
    End Sub

    Protected Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        LimpiaAltaAdmin()
    End Sub

    Protected Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub


End Class