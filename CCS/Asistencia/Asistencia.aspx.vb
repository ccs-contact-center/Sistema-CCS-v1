Imports System.Data.SqlClient
Public Class Asistencia
    Inherits System.Web.UI.Page

    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Public Asistencias, Descansos, Faltas, Faltas_Justificadas, Incapacidades, PCG, PSG, Vacaciones, Pago_Jornada, Otros, Vacios, Horas_Extra, Count As Integer

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


    Private Sub Modulo_Validacion_Load(sender As Object, e As EventArgs) Handles Me.Load


        If GetPassStatus(Request.Cookies("UserSettings")("Username")) = False Then
            Response.Redirect("Password.aspx")
        Else

        End If


        If Not IsPostBack Then
            Fecha.Text = Today()
            Label16.Text = GetAgentes().ToString
        End If

        LoadAgentes()


    End Sub


    Protected Sub ImageButton1_Click(sender As Object, e As EventArgs) Handles ImageButton1.Click

        If CDate(Fecha.Text) = Today Then
            ImageButton2.Enabled = True
            Fecha.Text = DateAdd(DateInterval.Day, -1, CDate(Fecha.Text))
            LoadConexion()
            CleanControls(Controls)
        ElseIf CDate(Fecha.Text) = DateAdd(DateInterval.Day, -2, Today) Then
            ImageButton1.Enabled = False
            Fecha.Text = DateAdd(DateInterval.Day, -1, CDate(Fecha.Text))
            LoadConexion()
            CleanControls(Controls)
        Else
            Fecha.Text = DateAdd(DateInterval.Day, -1, CDate(Fecha.Text))
            LoadConexion()
            CleanControls(Controls)
        End If

        Label16.Text = GetAgentes().ToString
    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As EventArgs) Handles ImageButton2.Click

        If CDate(Fecha.Text) = Today Then
            ImageButton2.Enabled = False
        ElseIf CDate(Fecha.Text) < DateAdd(DateInterval.Day, -2, Today)
            ImageButton1.Enabled = True
            Fecha.Text = DateAdd(DateInterval.Day, 1, CDate(Fecha.Text))
            LoadConexion()
            CleanControls(Controls)
        Else
            Fecha.Text = DateAdd(DateInterval.Day, 1, CDate(Fecha.Text))
            LoadConexion()
            CleanControls(Controls)
        End If

        Label16.Text = GetAgentes().ToString

    End Sub


    Function GetAgentes()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM Plantilla a WHERE (status = 'En Capacitacion' OR status = 'Activo' OR status = 'Pendiente de Baja' OR status = 'Preingreso' OR Status = 'Secundarias') AND id_super = '" & Request.Cookies("UserSettings")("Username") & "'", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)

        conexion.Close()

        Return CInt(ds.Tables(0).Rows(0).Item(0).ToString)


    End Function

    Sub LoadAgentes()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT Nombre=[nombres] + ' ' +paterno + ' ' +materno, Conexión=ISNULL(CONVERT(DECIMAL(4,1),b.Conexión),0), id_acd1 as 'ID',Segundos=ISNULL(b.Segundos,0) FROM Plantilla a LEFT JOIN (SELECT * FROM Conexion WHERE Fecha = '" & Fecha.Text & "') b ON CONVERT(NVARCHAR(MAX),a.server) +'-'+a.id_acd1 = b.server WHERE (status = 'Activo' OR status= 'En Capacitacion' OR status ='Pendiente de Baja' OR status = 'Preingreso' OR status ='Secundarias') AND id_super = '" & Request.Cookies("Usersettings")("Username") & "'", conexion)


        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()
        Agente1.Tablita.Rows(0).Visible = True


        Dim ctrl As Agente
        For x = 0 To GetAgentes() - 1
            Session("GrupoCount") = x + 1

            ctrl = CType(Agente1.Parent.FindControl("Agente" & Session("GrupoCount")), Agente)
            ctrl.Visible = True
            ctrl.IDACD.Text = ds.Tables(0).Rows(x).Item(2).ToString
            ctrl.Nombre.Text = StrConv(ds.Tables(0).Rows(x).Item(0).ToString, vbProperCase)
            ctrl.Conexion.Text = ds.Tables(0).Rows(x).Item(1).ToString
            ctrl.CNXSegundos.Value = ds.Tables(0).Rows(x).Item(3).ToString

        Next


    End Sub

    Sub LoadConexion()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT Nombre=[nombres] + ' ' +paterno + ' ' +materno,Conexión=ISNULL(CONVERT(DECIMAL(4,1),b.Conexión),0), id_acd1 as 'ID',Segundos=ISNULL(b.Segundos,0) FROM Plantilla a LEFT JOIN (SELECT * FROM Conexion WHERE Fecha = '" & Fecha.Text & "') b ON a.id_acd1 = b.ID WHERE id_super = '" & Request.Cookies("Usersettings")("Username") & "'", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()
        Dim ctrl As Agente
        For x = 0 To GetAgentes() - 1

            Session("GrupoCount") = x + 1
            ctrl = CType(Agente1.Parent.FindControl("Agente" & Session("GrupoCount")), Agente)
            ctrl.Conexion.Text = ds.Tables(0).Rows(x).Item(1).ToString
            ctrl.CNXSegundos.Value = ds.Tables(0).Rows(x).Item(2).ToString
        Next


    End Sub

    Public Sub CleanControls(ByVal controles As ControlCollection)
        For Each control As Control In controles

            If TypeOf control Is DropDownList Then
                DirectCast(control, DropDownList).ClearSelection()
            ElseIf TypeOf control Is RadioButtonList Then
                DirectCast(control, RadioButtonList).ClearSelection()
            ElseIf TypeOf control Is CheckBoxList Then
                DirectCast(control, CheckBoxList).ClearSelection()
            ElseIf TypeOf control Is RadioButton Then
                DirectCast(control, RadioButton).Checked = False
            ElseIf TypeOf control Is CheckBox Then
                DirectCast(control, CheckBox).Checked = False
            ElseIf control.HasControls() Then
                CleanControls(control.Controls)
            End If
        Next

        Dim ctrl As Agente
        For x = 0 To GetAgentes() - 1
            Session("GrupoCount") = x + 1

            ctrl = CType(Agente1.Parent.FindControl("Agente" & Session("GrupoCount")), Agente)

            ctrl.Seleccion.Value = Nothing
            ctrl.Horas.Text = Nothing
            ctrl.Comentario.Text = Nothing

        Next


        Label9.Text = 0
        Label11.Text = 0
        Label13.Text = 0
        Label15.Text = 0
        Label10.Text = 0
        Label12.Text = 0
        Label16.Text = 0
        Label20.Text = 0
        Label22.Text = 0
        Label24.Text = 0
        Label26.Text = 0

    End Sub

    Sub ValidaAsistencia()

        Dim ctrl As Agente

        Asistencias = 0
        Descansos = 0
        Faltas = 0
        Incapacidades = 0
        PCG = 0
        PSG = 0
        Vacaciones = 0
        Pago_Jornada = 0
        Otros = 0
        Faltas_Justificadas = 0
        Vacios = 0

        For x = 0 To GetAgentes() - 1
            Session("GrupoCount") = x + 1
            ctrl = CType(Agente1.Parent.FindControl("Agente" & Session("GrupoCount")), Agente)

            If ctrl.Seleccion.Value = "A" Then
                Asistencias = Asistencias + 1
            ElseIf ctrl.Seleccion.Value = "F" Then
                Faltas = Faltas + 1
            ElseIf ctrl.Seleccion.Value = "FJ" Then
                Faltas_Justificadas = Faltas_Justificadas + 1
            ElseIf ctrl.Seleccion.Value = "D" Then
                Descansos = Descansos + 1
            ElseIf ctrl.Seleccion.Value = "I" Then
                Incapacidades = Incapacidades + 1
            ElseIf ctrl.Seleccion.Value = "PC" Then
                PCG = PCG + 1
            ElseIf ctrl.Seleccion.Value = "PS" Then
                PSG = PSG + 1
            ElseIf ctrl.Seleccion.Value = "V" Then
                Vacaciones = Vacaciones + 1
            ElseIf ctrl.Seleccion.Value = "PJ" Then
                Pago_Jornada = Pago_Jornada + 1
            ElseIf ctrl.Seleccion.Value = "O" Then
                Otros = Otros + 1
            Else
                Vacios = Vacios + 1
            End If

        Next



        Label9.Text = Asistencias
        Label11.Text = Faltas
        Label13.Text = Descansos
        Label15.Text = Incapacidades
        Label10.Text = PCG
        Label12.Text = PSG
        Label16.Text = Vacios
        Label20.Text = Faltas_Justificadas
        Label24.Text = Vacaciones
        Label26.Text = Pago_Jornada


        For x = 0 To GetAgentes() - 1
            Session("GrupoCount") = x + 1
            ctrl = CType(Agente1.Parent.FindControl("Agente" & Session("GrupoCount")), Agente)

            If ctrl.Horas.Text = "" Then
                Count = 0
            Else
                Count = CInt(ctrl.Horas.Text)
            End If

            Horas_Extra = Horas_Extra + Count
        Next

        Label22.Text = Horas_Extra



    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ValidaAsistencia()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guardar()
    End Sub

    Sub Guardar()

        Dim asistencia As String

        If Label16.Text = "0" Then



            Dim Funcion As New Funciones

            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim ctrl As Agente
            For x = 0 To GetAgentes() - 1
                Session("GrupoCount") = x + 1



                ctrl = CType(Agente1.Parent.FindControl("Agente" & Session("GrupoCount")), Agente)

                If Funcion.CompruebaAsitencia(Fecha.Text, ctrl.Nombre.Text) = False Then

                    If Request.Cookies("Usersettings")("Area") = 3 Then
                        asistencia = "C" & ctrl.Seleccion.Value
                    Else
                        asistencia = ctrl.Seleccion.Value
                    End If


                    Dim strQuery As String = "INSERT INTO OP_Asistencia " &
                    "(Fecha_Asistencia, Fecha_Captura, idMitrol, Nombre, Asistencia, Conexion, Hora_Extra, Supervisor, Comentario) " &
                     "VALUES " &
                    "('" & Fecha.Text & "', GETDATE(), '" & ctrl.IDACD.Text & "', '" & ctrl.Nombre.Text & "', '" & asistencia & "','" & ctrl.CNXSegundos.Value & "', '" & ctrl.Horas.Text & "', '" & Request.Cookies("UserSettings")("Username") & "', '" & ctrl.Comentario.Text & "')"

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
                    msgmensaje(0) = "¡Asistencia Correcta!"
                    Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

                Else
                    msgtipo(0) = 4
                    msgmensaje(0) = "¡Ya se registro la asistencia de algunos agentes!"
                    Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

                End If

            Next

            CleanControls(Controls)


        Else

            msgtipo(0) = 4
            msgmensaje(0) = "¡Debes llenar la asistencia de todos los agentes!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        End If



    End Sub


End Class