Imports System.Data.SqlClient
Imports System.Web.Script.Serialization
Partial Public Class Aplicar_Evaluacion


    Inherits Page
    Dim x As New Funciones
    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String



    Sub FillClass()


        Dim RA, RB, RC, RD, RE As Integer

        RA = 101
        RB = 102
        RC = 103
        RD = 104
        RE = 105


        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT id_reactivo,nombre_reactivo,a,b ,c,d,e,correcta,time_limit FROM Capacitacion.dbo.SYS_Evaluaciones WHERE nombre_evaluacion = '" & Session("evaluacion") & "'", conexion)

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))

        If Not IsPostBack Then
            Label128.Text = ds.Tables(0).Rows(0).Item(8).ToString
        End If

        For i = 1 To ds.Tables(0).Rows.Count


            RadioButtonList1.Parent.FindControl("PV" & i).Visible = True
            CType(RadioButtonList1.Parent.FindControl("Label" & 107 + i), Label).Text = ds.Tables(0).Rows(i - 1).Item(1).ToString

            CType(RadioButtonList1.Parent.FindControl("HiddenField" & i), HiddenField).Value = ds.Tables(0).Rows(i - 1).Item(7).ToString

            CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).Items(0).Text = ds.Tables(0).Rows(i - 1).Item(2).ToString
            CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).Items(1).Text = ds.Tables(0).Rows(i - 1).Item(3).ToString
            CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).Items(2).Text = ds.Tables(0).Rows(i - 1).Item(4).ToString
            CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).Items(3).Text = ds.Tables(0).Rows(i - 1).Item(5).ToString
            CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).Items(4).Text = ds.Tables(0).Rows(i - 1).Item(6).ToString


            RA = RA + 5
            RB = RB + 5
            RC = RC + 5
            RD = RD + 5
            RE = RE + 5

        Next

        If ds.Tables(0).Rows(0).Item(8).ToString = 0 Then
            Timer1.Enabled = False
        Else
        End If

    End Sub


    Private Sub Nueva_Evaluacion_Load(sender As Object, e As EventArgs) Handles Me.Load

        FillClass()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label128.Text = 0 Then



            Dim RA, RB, RC, RD, RE As Integer

            RA = 101
            RB = 102
            RC = 103
            RD = 104
            RE = 105


            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("SELECT id_reactivo,nombre_reactivo,a,b ,c,d,e,correcta,time_limit FROM Capacitacion.dbo.SYS_Evaluaciones WHERE nombre_evaluacion = '" & Session("evaluacion") & "'", conexion)

            conexion.Open()
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            ds.Tables.Add()
            da.Fill(ds.Tables(0))


            For i = 1 To ds.Tables(0).Rows.Count



                If CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).SelectedValue = Trim(CType(RadioButtonList1.Parent.FindControl("HiddenField" & i), HiddenField).Value) Then
                    CType(RadioButtonList1.Parent.FindControl("Check" & i), Image).Visible = True
                Else
                    CType(RadioButtonList1.Parent.FindControl("Cross" & i), Image).Visible = True
                End If





                RA = RA + 5
                RB = RB + 5
                RC = RC + 5
                RD = RD + 5
                RE = RE + 5

            Next

            DisableControls(Controls)

            Timer1.Interval = 600000000

        Else
            Label128.Text = CInt(Label128.Text) - 1
        End If

        'Timer1.
    End Sub

    Protected Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If Autentificacion.AuthCapacitacion(TextBox5.Text, x.Passcrypt(TextBox6.Text)) = True Then
            Image3.Visible = True
            HiddenField22.Value = 1
        Else
            Image3.Visible = False
            HiddenField22.Value = 0
        End If
    End Sub

    Public Sub DisableControls(ByVal controles As ControlCollection)
        For Each control As Control In controles


            If TypeOf control Is RadioButtonList Then
                DirectCast(control, RadioButtonList).Enabled = False
            ElseIf control.HasControls() Then
                DisableControls(control.Controls)
            End If
        Next






    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label128.Text = 0
        Dim RA, RB, RC, RD, RE As Integer

        RA = 101
        RB = 102
        RC = 103
        RD = 104
        RE = 105


        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT id_reactivo,nombre_reactivo,a,b ,c,d,e,correcta,time_limit FROM Capacitacion.dbo.SYS_Evaluaciones WHERE nombre_evaluacion = '" & Session("evaluacion") & "'", conexion)

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))


        For i = 1 To ds.Tables(0).Rows.Count



            If CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).SelectedValue = Trim(CType(RadioButtonList1.Parent.FindControl("HiddenField" & i), HiddenField).Value) Then
                CType(RadioButtonList1.Parent.FindControl("Check" & i), Image).Visible = True
            Else
                CType(RadioButtonList1.Parent.FindControl("Cross" & i), Image).Visible = True
            End If





            RA = RA + 5
            RB = RB + 5
            RC = RC + 5
            RD = RD + 5
            RE = RE + 5

        Next

        DisableControls(Controls)

        Timer1.Interval = 600000000
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New Funciones

        If CInt(HiddenField22.Value) = 1 Then

            GuardaEvaluacion(Session("evaluacion"))


            Dim NAgente As String = x.GetUserID(Request.Cookies("UserSettings")("Username"))
            Dim NEvaluacion As String = Session("evaluacion")

            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) as Total ,ISNULL(SUM(ok),0) as OK FROM [Capacitacion].[dbo].[SYS_Resultados] WHERE agente = '" & NAgente & "' AND evaluacion = '" & NEvaluacion & "'", conexion)

            conexion.Open()
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            ds.Tables.Add()
            da.Fill(ds.Tables(0))

            msgtipo(0) = 1
            msgmensaje(0) = "¡Evaluación Guardada! Obtuviste " & ds.Tables(0).Rows(0).Item(1).ToString & " de " & ds.Tables(0).Rows(0).Item(0).ToString & " respuestas."
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

            HiddenField22.Value = 2

        ElseIf CInt(HiddenField22.Value) = 2 Then
            msgtipo(0) = 4
            msgmensaje(0) = "¡Ya se firmó y guardó esta evaluación!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

        Else
            msgtipo(0) = 4
            msgmensaje(0) = "¡La evaluación debe ser firmada por un instructor!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End If

    End Sub


    Sub GuardaEvaluacion(ByVal Evaluacion As String)

        Dim RA, RB, RC, RD, RE As Integer

        RA = 101
        RB = 102
        RC = 103
        RD = 104
        RE = 105


        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT id_reactivo,nombre_reactivo,a,b,c,d,e,correcta,time_limit,nombre_evaluacion, tipo_evaluacion, campania FROM Capacitacion.dbo.SYS_Evaluaciones WHERE nombre_evaluacion = '" & Evaluacion & "'", conexion)

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))

        If Not IsPostBack Then
            Label128.Text = ds.Tables(0).Rows(0).Item(8).ToString
        End If
        Dim cmd2 As New SqlCommand()
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString

        For i = 1 To ds.Tables(0).Rows.Count



            Dim selection As String

            Try

                If CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).SelectedItem.Value = Nothing Then
                    selection = "NULL"
                Else
                    selection = "'" & CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).SelectedItem.Value & "'"
                End If

            Catch ex As Exception
                selection = "NULL"
            End Try


            Dim ok As String

            Try


                If Trim(CType(RadioButtonList1.Parent.FindControl("RadioButtonList" & i), RadioButtonList).SelectedItem.Value) = Trim(CType(RadioButtonList1.Parent.FindControl("HiddenField" & i), HiddenField).Value) Then
                    ok = 1
                Else
                    ok = 0
                End If

            Catch ex As Exception
                ok = 0
            End Try

            Dim strQuery As String = "INSERT INTO [Capacitacion].[dbo].[SYS_Resultados] (agente,instructor,evaluacion,tipo,campania,reactivo,respuesta,correcta,ok, fecha) VALUES ('" &
                                     x.GetUserID(Request.Cookies("Usersettings")("Username")) & "', '" & TextBox5.Text & "', '" & ds.Tables(0).Rows(0).Item(9).ToString & "', '" & ds.Tables(0).Rows(0).Item(10).ToString & "', '" & ds.Tables(0).Rows(0).Item(11).ToString & "', '" & i & "', " & selection & ", '" & CType(RadioButtonList1.Parent.FindControl("HiddenField" & i), HiddenField).Value & "', '" & ok & "', GETDATE())"
            Dim con As New SqlConnection(strConnString)

            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = strQuery
            cmd2.Connection = con

            con.Open()
            cmd2.ExecuteNonQuery()
            con.Close()
            con.Dispose()

        Next


    End Sub

End Class





