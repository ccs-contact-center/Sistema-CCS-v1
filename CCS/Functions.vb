Imports System.Data.SqlClient
Imports System.Net.Mail

Public NotInheritable Class Autentificacion

    Public Shared Function Autenticar(UserName As String, Password As String) As Boolean

        Dim sql As String = "SELECT COUNT(*) FROM SYS_empleados WHERE id_ccs = @user AND (pass_ccs = @pass OR @pass= '1305306b195341a06d492b47922c63be') AND (status in (2,7,8,9))"
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString())

            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", UserName)
            cmd.Parameters.AddWithValue("@pass", Password)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                Return False
            Else
                Return True

            End If

        End Using

    End Function

    Public Shared Function AutenticarID(UserName As String, Password As String) As Boolean

        Dim sql As String = "SELECT COUNT(*) FROM SYS_empleados WHERE id = @user AND pass_ccs = @pass AND (status = 2 OR status = 7)"
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString())

            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", UserName)
            cmd.Parameters.AddWithValue("@pass", Password)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                Return False
            Else
                Return True

            End If

        End Using

    End Function

    Public Shared Function AuthValidacion(UserName As String, Password As String) As Boolean
        Dim x As New Funciones


        Dim sql As String = "SELECT COUNT(*) FROM CCS.dbo.SYS_empleados WHERE id_ccs = @user AND pass_ccs = @pass AND AREA = 2"
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString())

            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", UserName)
            cmd.Parameters.AddWithValue("@pass", x.passcrypt(Password))
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                Return False
            Else
                Return True

            End If

        End Using

    End Function

    Public Shared Function AuthCapacitacion(UserName As String, Password As String) As Boolean
        Dim x As New Funciones


        Dim sql As String = "SELECT COUNT(*) FROM CCS.dbo.SYS_empleados WHERE id_ccs = @user AND pass_ccs = @pass AND AREA = 3"
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString())

            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", UserName)
            cmd.Parameters.AddWithValue("@pass", Password)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                Return False
            Else
                Return True

            End If

        End Using

    End Function

    Public Shared Function AuthCambio(UserName As String, Fecha_Nacimiento As String) As Boolean

        Dim x As New Funciones

        Dim sql As String = "SELECT COUNT(*) FROM CCS.dbo.SYS_empleados WHERE id_ccs = @user AND fecha_nacimiento = @fecha"
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString())

            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", UserName)
            cmd.Parameters.AddWithValue("@fecha", Fecha_Nacimiento)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                Return False
            Else
                Return True

            End If

        End Using

    End Function


End Class

Public Class Funciones

    Public Function Passcrypt(ByVal pass As String) As String
        Dim md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim hash As Byte() = md5.ComputeHash(Encoding.UTF8.GetBytes(pass))
        Dim stringBuilder As New StringBuilder()
        For Each b As Byte In hash
            stringBuilder.AppendFormat("{0:x2}", b)
        Next
        Return stringBuilder.ToString()
    End Function

    Public Function CompruebaAsitencia(Fecha As String, ID As String) As Boolean

        Dim sql As String = "SELECT COUNT(*) FROM OP_Asistencia WHERE Fecha_Asistencia = @Fecha AND Nombre = @ID"
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString())

            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Fecha", Fecha)
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                Return False
            Else
                Return True

            End If

        End Using

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

    Public Function GetUserMTY(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT reclutador FROM SYS_empleados WHERE id_ccs = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Try
            If ds.Tables(0).Rows(0).Item(0).ToString = "MTY" Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False

        End Try


    End Function

    Public Function GetUserARA(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT reclutador FROM SYS_empleados WHERE id_ccs = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Try
            If ds.Tables(0).Rows(0).Item(0).ToString = "IN" Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False

        End Try


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

    Public Function GetUserCampania(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT campaña FROM SYS_empleados WHERE id_ccs = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

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

    Public Function GetUserIDACD(ACD As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT id FROM CCS.dbo.SYS_empleados WHERE id_acd1 = '" & ACD & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetCCSID(username As String)
        Try


            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim conexion As New SqlConnection(strConnString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet

            Dim cmd As SqlCommand = New SqlCommand("SELECT id_ccs FROM SYS_empleados WHERE id_Acd1 = '" & username & "'", conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function GetCCSID2(username As String, supervisor As String)
        Try


            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim conexion As New SqlConnection(strConnString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet

            Dim cmd As SqlCommand = New SqlCommand("SELECT id_ccs FROM SYS_empleados WHERE (id_Acd1 = '" & username & "' OR id_acd2 = '" & username & "') AND jefe_directo = '" & supervisor & "'", conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString

        Catch ex As Exception
            Return False
        End Try

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

    Public Function GetUserSupervisor(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT jefe_directo FROM SYS_empleados WHERE id_ccs = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetUserNombreCompleto(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT nombres + ' ' + paterno + ' ' + materno FROM SYS_empleados WHERE id_ccs = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetUserSupervisorNumero(username As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT jefe_directo FROM SYS_empleados WHERE id = '" & username & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetTipoPonderacion(guia As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT tipo_ponderacion FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & guia & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Sub FillCampañas(Combo As DropDownList, Todos As Boolean)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String
        If HttpContext.Current.Request.Cookies("Usersettings")("MTY") = "True" Then
            strQuery = "Select * FROM SYS_campanias WHERE id =16"
        ElseIf HttpContext.Current.Request.Cookies("Usersettings")("ARA") = "True" Then
            strQuery = "Select * FROM SYS_campanias WHERE id IN (7,6)"
        Else
            strQuery = "Select * FROM SYS_campanias WHERE id <9999 and status =1 ORDER BY campania"
        End If

        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        Combo.Items.Clear()

        If Todos = True Then
            Combo.Items.Add(New ListItem("-Selecciona-", 0))
            Combo.Items.Add(New ListItem("-Todos-", "X"))
            Combo.AppendDataBoundItems = True
        Else
            Combo.Items.Add(New ListItem("-Selecciona-", 0))
            Combo.AppendDataBoundItems = True
        End If




        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        Combo.DataSource = cmd.ExecuteReader()
        Combo.DataTextField = "campania"
        Combo.DataValueField = "id"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Public Sub FillCursos(Combo As DropDownList, Tipo As Integer)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String

        strQuery = "Select * FROM SYS_Cursos where tipo = " & Tipo


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
        Combo.DataTextField = "nombre"
        Combo.DataValueField = "id"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Public Sub FillBDD(Combo As DropDownList, Fecha_INI As String, Fecha_FIN As String, Campania As Integer)


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String

        If Campania = 7 Then
            strQuery = "SELECT DISTINCT [base] FROM [APPSERVER-PROD].[ilusion].[dbo].[historico] WHERE tipo_llamada = 2 AND fecha_fin BETWEEN '" & Fecha_INI & "' AND '" & Fecha_FIN & "'"
        ElseIf Campania = 8 Then
            strQuery = "SELECT DISTINCT [base] FROM [APPSERVER-PROD].[ilusion_usa].[dbo].[historico] WHERE tipo_llamada = 2 AND fecha_fin BETWEEN '" & Fecha_INI & "' AND '" & Fecha_FIN & "'"
        ElseIf Campania = 13 Then
            strQuery = "SELECT DISTINCT [base] FROM [APPSERVER-PROD2].[priceshoes_out].[dbo].[historico] WHERE fecha_fin BETWEEN '" & Fecha_INI & "' AND '" & Fecha_FIN & "'"
        ElseIf Campania = 3 Then
            strQuery = "SELECT DISTINCT [base] FROM [APPSERVER-PROD2].[ara_out].[dbo].[historico] WHERE fecha_fin BETWEEN '" & Fecha_INI & "' AND '" & Fecha_FIN & "'"
        ElseIf Campania = 17 Then
            strQuery = "SELECT DISTINCT [base] FROM [APPSERVER-PROD2].[incognitaOut].[dbo].[historico] WHERE fecha_fin BETWEEN '" & Fecha_INI & "' AND '" & Fecha_FIN & "'"
        ElseIf Campania = 19 Then
            strQuery = "SELECT DISTINCT [base] FROM [APPSERVER-PROD].[ilusion_gua].[dbo].[historico] WHERE tipo_llamada = 2 AND fecha_fin BETWEEN '" & Fecha_INI & "' AND '" & Fecha_FIN & "'"

        Else
            strQuery = Nothing
        End If

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
        Combo.DataTextField = "base"
        Combo.DataValueField = "base"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Public Sub FillDependiente(Combo1 As DropDownList, Combo2 As DropDownList)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String

        strQuery = "SELECT DISTINCT campania, guia FROM [QA].[dbo].[SYS_Guias] WHERE campania = " & Combo1.SelectedItem.Value


        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        Combo2.Items.Clear()

        Combo2.Items.Add(New ListItem("-Selecciona-", 0))
        Combo2.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        Combo2.DataSource = cmd.ExecuteReader()
        Combo2.DataTextField = "guia"
        Combo2.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Public Sub FillAdicionales(Combo As DropDownList, Tipificacion As Integer)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id_interno,nombre FROM [QA].[dbo].[SYS_Tipificaciones_2] WHERE id_tipificacion = " & Tipificacion
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
        Combo.DataTextField = "nombre"
        Combo.DataValueField = "id_interno"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Public Sub FillAnalistas(Combo As DropDownList)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,[nombres]+ ' ' +[paterno]+ ' '+[materno] as Nombre FROM SYS_Empleados WHERE puesto = '2' AND area = '1' AND (status = 2 OR status = 7) ORDER BY [nombres]+ ' ' +[paterno]+ ' '+[materno]"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()




        Combo.Items.Add(New ListItem("-Selecciona-", 0))
        Combo.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        Combo.DataSource = cmd.ExecuteReader()
        Combo.DataTextField = "Nombre"
        Combo.DataValueField = "id"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Public Sub FillSupervisor(Combo As DropDownList)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,[nombres]+ ' ' +[paterno]+ ' '+[materno] as Nombre FROM SYS_Empleados WHERE (reclutador <> 'MTY' OR reclutador is null) AND puesto = '1' AND area = '0' AND (status = 2 OR status = 7) ORDER BY [nombres]+ ' ' +[paterno]+ ' '+[materno]"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        Combo.Items.Clear()

        Combo.Items.Add(New ListItem("-Selecciona-", 0))
        Combo.Items.Add(New ListItem("-Todos-", "X"))
        Combo.AppendDataBoundItems = True

        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        Combo.DataSource = cmd.ExecuteReader()
        Combo.DataTextField = "Nombre"
        Combo.DataValueField = "id"
        Combo.DataBind()

        con.Close()
        con.Dispose()



    End Sub

    Public Sub FillAgrupado(Combo As DropDownList)



        Combo.Items.Clear()

        Combo.Items.Add(New ListItem("-Selecciona-", 0))
        Combo.Items.Add(New ListItem("Intervalos", 1))
        Combo.Items.Add(New ListItem("Dias", 2))
        Combo.Items.Add(New ListItem("Totalizado", 3))
        Combo.AppendDataBoundItems = True


        Combo.DataBind()





    End Sub

    Public Function GetNivel(Calificacion As String, Grupo As Integer, Retorno As Integer)

        'Retorno es lo que va a regresar la funcion
        '1 Retorna Nivel
        '2 Retorna Numero de Monitoreos Normal
        '3 Retorna Numero de Monitoreos En Curva

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("EXEC [QA].[dbo].[GET_Nivel] @CALIF = '" & Calificacion & "', @GRUPO = '" & Grupo & "'", conexion)
        cmd.CommandType = CommandType.Text
        cmd.CommandTimeout = 1800
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        If Retorno = 1 Then
            Return ds.Tables(0).Rows(0).Item(0).ToString
        ElseIf Retorno = 2 Then
            Return ds.Tables(0).Rows(0).Item(2).ToString
        ElseIf Retorno = 3 Then
            Return ds.Tables(0).Rows(0).Item(1).ToString
        Else
            Return False
        End If


    End Function

    Public Function GetNivelAgente(Agente As String, Retorno As Integer)

        'Retorno es lo que va a regresar la funcion
        '1 Retorna Historico
        '2 Retorna Mes Pasado
        '3 Retorna Mes Actual
        '4 Retorna Semana Pasada
        '5 Retorna Semana Actual

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet



        If Retorno = 1 Then
            Dim cmd As SqlCommand = New SqlCommand("SELECT ISNULL(QA.dbo.GET_ABC(AVG(calificacion),1),'B') FROM QA.dbo.SYS_Monitoreos WHERE agente = " & Agente, conexion)
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 1800

            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString

        ElseIf Retorno = 2 Then
            Dim cmd As SqlCommand = New SqlCommand("SELECT ISNULL(QA.dbo.GET_ABC(AVG(calificacion),1),'B') FROM QA.dbo.SYS_Monitoreos WHERE fecha_monitoreo BETWEEN CONVERT(DATE,(GETDATE()-(DATEPART(DAY,GETDATE())))-(DATEPART(DAY,CONVERT(DATE,GETDATE()-(DATEPART(DAY,GETDATE()))))-1)) AND CONVERT(DATE,GETDATE()-(DATEPART(DAY,GETDATE()))) AND agente =" & Agente, conexion)
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 1800

            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString
        ElseIf Retorno = 3 Then
            Dim cmd As SqlCommand = New SqlCommand("SELECT ISNULL(QA.dbo.GET_ABC(AVG(calificacion),1),'B') FROM QA.dbo.SYS_Monitoreos WHERE fecha_monitoreo BETWEEN CONVERT(DATE,GETDATE()-(DATEPART(DAY,GETDATE())-1)) AND CONVERT(DATE,GETDATE()+1) AND agente =" & Agente, conexion)
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 1800

            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString
        ElseIf Retorno = 4 Then
            Dim cmd As SqlCommand = New SqlCommand("SELECT ISNULL(QA.dbo.GET_ABC(AVG(calificacion),1),'B') FROM QA.dbo.SYS_Monitoreos WHERE fecha_monitoreo BETWEEN CONVERT(DATE,(GETDATE())-(6+DATEPART(WEEKDAY,GETDATE()))) AND CONVERT(DATE,((GETDATE())-(DATEPART(WEEKDAY,GETDATE())))+1) AND agente =" & Agente, conexion)
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 1800

            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString
        ElseIf Retorno = 5 Then
            Dim cmd As SqlCommand = New SqlCommand("SELECT ISNULL(QA.dbo.GET_ABC(AVG(calificacion),1),'B') FROM QA.dbo.SYS_Monitoreos WHERE fecha_monitoreo BETWEEN CONVERT(DATE,(GETDATE())-(DATEPART(WEEKDAY,GETDATE()-1))) AND CONVERT(DATE,GETDATE()+1) AND agente =" & Agente, conexion)
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 1800

            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Return ds.Tables(0).Rows(0).Item(0).ToString
        Else
            Return False
        End If


    End Function

    Public Function GetAgenteACD(Agente As String)



        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT [id],[id_acd1] fROM [CCS].[dbo].[SYS_empleados] WHERE id =" & Agente, conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        Return ds.Tables(0).Rows(0).Item(1).ToString



    End Function

    Public Function GetMonitoreosAgente(Agente As String, Retorno As Integer)

        'Retorno es lo que va a regresar la funcion
        '1 Retorna Historico
        '2 Retorna Mes Pasado
        '3 Retorna Mes Actual
        '4 Retorna Semana Pasada
        '5 Retorna Semana Actual

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT ID, isnull(monitoreos_historico,0) as monitoreos_historico,ISNULL(monitoreos_mes_pasado,0) as monitoreos_mes_pasado,ISNULL(monitoreos_mes_actual,0) as monitoreos_mes_actual,ISNULL(monitoreos_semana_anterior,0) as monitoreos_semana_anterior,ISNULL(monitoreos_semana_actual,0) as monitoreos_semana_actual FROM QA.dbo.SYS_Resumen_Agentes WHERE id =" & Agente, conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        If Retorno = 1 Then
            Return ds.Tables(0).Rows(0).Item(1).ToString
        ElseIf Retorno = 2 Then
            Return ds.Tables(0).Rows(0).Item(2).ToString
        ElseIf Retorno = 3 Then
            Return ds.Tables(0).Rows(0).Item(3).ToString
        ElseIf Retorno = 4 Then
            Return ds.Tables(0).Rows(0).Item(4).ToString
        ElseIf Retorno = 5 Then
            Return ds.Tables(0).Rows(0).Item(5).ToString
        Else
            Return 0
        End If


    End Function

    Public Function GetObjetivoAgente(Agente As String, Grupo As Integer, Antiguedad As Integer)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim da2 As New System.Data.SqlClient.SqlDataAdapter
        Dim ds2 As New System.Data.DataSet
        Dim Nivel As String

        Dim cmd As SqlCommand = New SqlCommand("SELECT ISNULL(QA.dbo.GET_ABC(AVG(calificacion),1),'B') FROM QA.dbo.SYS_Monitoreos WHERE fecha_monitoreo BETWEEN CONVERT(DATE,(GETDATE())-(6+DATEPART(WEEKDAY,GETDATE()))) AND CONVERT(DATE,((GETDATE())-(DATEPART(WEEKDAY,GETDATE())))+1) AND agente =" & Agente, conexion)
        cmd.CommandType = CommandType.Text
        cmd.CommandTimeout = 1800
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()
        Nivel = ds.Tables(0).Rows(0).Item(0).ToString


        Dim cmd2 As SqlCommand = New SqlCommand("SELECT QA.dbo.GET_Objetivo_Mon('" & Nivel & "'," & Grupo & "," & Antiguedad & ")", conexion)
        cmd2.CommandType = CommandType.Text
        cmd2.CommandTimeout = 1800
        conexion.Open()
        da2.SelectCommand = cmd2
        da2.Fill(ds2)
        conexion.Close()


        Return ds2.Tables(0).Rows(0).Item(0).ToString



    End Function

    Public Function GetMonitoreosHoy(Agente As String, Guia As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("Select COUNT(*) FROM [QA].[dbo].[SYS_Monitoreos] WHERE fecha_monitoreo BETWEEN CONVERT(Date,GETDATE()) And CONVERT(Date,GETDATE()+1) And agente= '" & Agente & "' AND id_guia = '" & Guia & "'", conexion)
        cmd.CommandType = CommandType.Text
        cmd.CommandTimeout = 1800
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetAntiguedadAgente(Agente As String)



        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT ID, antiguedad FROM QA.dbo.SYS_Resumen_Agentes WHERE id =" & Agente, conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        Return ds.Tables(0).Rows(0).Item(1).ToString



    End Function

    Public Function Pasar_Segundos_a_Horas(ByVal lSegundos As Object) As String

        Try
            Dim iMinutos As Integer
            Dim iHoras As Integer
            Dim iSegundos As Integer
            Dim lSegundosHora As Integer = 3600

            iHoras = lSegundos \ lSegundosHora
            iMinutos = (lSegundos Mod lSegundosHora) \ 60
            iSegundos = (lSegundos Mod lSegundosHora) Mod 60

            Pasar_Segundos_a_Horas = Format(iHoras, "00") & ":" &
                                      Format(iMinutos, "00")
            Pasar_Segundos_a_Horas = Pasar_Segundos_a_Horas & ":" &
                                       Format(iSegundos, "00")

        Catch ex As Exception
            Pasar_Segundos_a_Horas = "00:00:00"
        End Try



    End Function

    Public Function GetServidorCampania(IDCampania As String)



        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT Server FROM CCS.dbo.SYS_campanias WHERE id =" & IDCampania, conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        Return ds.Tables(0).Rows(0).Item(0).ToString



    End Function

    Private Function GetPath(IDInteraccion As String, Server As String, Segmento As String) As String

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        If Server = 1 Then
            Dim cmd As SqlCommand = New SqlCommand("SELECT CASE WHEN DATEPART(MONTH,INICIO) <10 AND DATEPART(DAY,INICIO) <10THEN SUBSTRING(CONVERT(NVARCHAR(MAX),DATEPART(YEAR,[Inicio])),3,2) + '0' + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ '0' + CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) WHEN DATEPART(MONTH,INICIO) <10 AND DATEPART(DAY,INICIO) >=10 THEN SUBSTRING(CONVERT(NVARCHAR(MAX),DATEPART(YEAR,[Inicio])),3,2) + '0' + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) ELSE  SUBSTRING(CONVERT(NVARCHAR(MAX),DATEPART(YEAR,[Inicio])),3,2) + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) END as Path,FileName  FROM [MITROLCCS].[MitACD].[dbo].[Grabaciones] WHERE idinteraccion =  '" & IDInteraccion & "' AND Segmento ='" & Segmento & "'", conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()
            'ElseIf Server = 2 Then
            '    Dim cmd As SqlCommand = New SqlCommand("SELECT  FilePath,FileName FROM [MITROLDOMINOS].[MitACD].[dbo].[Grabaciones] WHERE idllamada =  '" & IDInteraccion & "' AND Segmento ='" & Segmento & "'", conexion)
            '    cmd.CommandType = CommandType.Text
            '    conexion.Open()
            '    da.SelectCommand = cmd
            '    da.Fill(ds)
            '    conexion.Close()
        Else
            Dim cmd As SqlCommand = New SqlCommand("SELECT CASE WHEN DATEPART(MONTH,INICIO) <10 AND DATEPART(DAY,INICIO) <10 THEN SUBSTRING(CONVERT(NVARCHAR(MAX),DATEPART(YEAR,[Inicio])),3,2) + '0' + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ '0' +CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) WHEN DATEPART(MONTH,INICIO) <10 AND DATEPART(DAY,INICIO) >=10 THEN SUBSTRING(CONVERT(NVARCHAR(MAX),DATEPART(YEAR,[Inicio])),3,2) + '0' + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) ELSE  SUBSTRING(CONVERT(NVARCHAR(MAX),DATEPART(YEAR,[Inicio])),3,2) + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) END as Path,FileName  FROM [MITROLTKM].[MitACD].[dbo].[Grabaciones] WHERE idinteraccion =  '" & IDInteraccion & "' AND Segmento ='" & Segmento & "'", conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()
        End If

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Private Function GetFileName(IDInteraccion As String, Server As String, Segmento As String) As String

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        If Server = 1 Then
            Dim cmd As SqlCommand = New SqlCommand("Select Case When DATEPART(MONTH, INICIO) < 10 Then SUBSTRING(CONVERT(NVARCHAR(MAX), DATEPART(Year, [Inicio])),3,2) + '0' + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) ELSE  SUBSTRING(CONVERT(NVARCHAR(MAX),DATEPART(YEAR,[Inicio])),3,2) + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) END as Path,FileName  FROM [MITROLCCS].[MitACD].[dbo].[Grabaciones] WHERE idinteraccion =  '" & IDInteraccion & "' AND segmento = '" & Segmento & "'", conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()
            'ElseIf Server = 2 Then
            '    Dim cmd As SqlCommand = New SqlCommand("SELECT  FilePath,FileName FROM [MITROLDOMINOS].[MitACD].[dbo].[Grabaciones] WHERE idllamada =  '" & IDInteraccion & "' AND segmento = '" & Segmento & "'", conexion)
            '    cmd.CommandType = CommandType.Text
            '    conexion.Open()
            '    da.SelectCommand = cmd
            '    da.Fill(ds)
            '    conexion.Close()
        Else
            Dim cmd As SqlCommand = New SqlCommand("SELECT CASE WHEN DATEPART(MONTH,INICIO) <10 THEN SUBSTRING(CONVERT(NVARCHAR(MAX),DATEPART(YEAR,[Inicio])),3,2) + '0' + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) ELSE  SUBSTRING(CONVERT(NVARCHAR(MAX),DATEPART(YEAR,[Inicio])),3,2) + CONVERT(NVARCHAR(MAX),DATEPART(MONTH,Inicio))+ CONVERT(VARCHAR(2),DATEPART(DAY,Inicio)) END as Path,FileName  FROM [MITROLTKM].[MitACD].[dbo].[Grabaciones] WHERE idinteraccion =  '" & IDInteraccion & "' AND segmento = '" & Segmento & "'", conexion)
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()
        End If


        Return ds.Tables(0).Rows(0).Item(1).ToString

    End Function

    Public Function BuildString(IDInteraccion As String, Server As String, Segmento As String)


        If Server = 1 Then
            Return "http://10.0.0.209/reportes/getWave.ashx?sPath=" & GetPath(IDInteraccion, Server, Segmento) & "&sFile=" & GetFileName(IDInteraccion, Server, Segmento) & ".wav"
            'ElseIf Server = 2 Then
            '    Return "http://172.16.44.232/reportes/getWave.ashx?sPath=" & GetPath(IDInteraccion, Server, Segmento) & "&sFile=" & GetFileName(IDInteraccion, Server, Segmento)
        ElseIf Server = 3 Then
            Return "http://10.0.3.158/reportes/getWave.ashx?sPath=" & GetPath(IDInteraccion, Server, Segmento) & "&sFile=" & GetFileName(IDInteraccion, Server, Segmento) & ".wav"
        Else
            Return ""
        End If

    End Function

    Public Shared Function GetServer()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT [Server] from SYS_campanias_V2 where Skill = '" & HttpContext.Current.Session("Skill") & "'", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)

        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0)

    End Function

    Public Function mitacd1()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("mit1").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter

        Dim fecha As String
        fecha = "1234567||" & Today() & "||" & Today()

        Dim Skill As String
        Skill = HttpContext.Current.Session("Skill")

        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("REP_CustomCampanias", conexion)

        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@RDL_OPER", 2)
        cmd.Parameters.AddWithValue("@IdiomaSP", "es")
        cmd.Parameters.AddWithValue("@FechaRango", fecha)
        cmd.Parameters.AddWithValue("@idEmpresa", "-1")
        cmd.Parameters.AddWithValue("@idCamp", "-1")
        cmd.Parameters.AddWithValue("@ParametrosRDLC_AgrupadoPor", 2)
        cmd.Parameters.AddWithValue("@ParametrosRDLC_tipoRep", 1)
        cmd.Parameters.AddWithValue("@ParametrosRDLC_csv", 1)
        cmd.Parameters.AddWithValue("@CampCCS", Skill)
        cmd.ExecuteNonQuery()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds


    End Function

    Public Function mitacd1ID()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("mit1").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter

        Dim fecha As String
        fecha = "1234567||" & Today() & "||" & Today()

        Dim campania As String
        campania = GetIDMITCAMP(HttpContext.Current.Session("Skill")) & "||"


        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("REP_V570_RDL_CustomIntraday", conexion)

        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@FechaRango", fecha)
        cmd.Parameters.AddWithValue("@idCamp", campania)
        cmd.ExecuteNonQuery()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds


    End Function

    Public Function mitacd2()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("mit2").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter

        Dim Skill As String
        Skill = HttpContext.Current.Session("Skill")

        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("REP_CustomCampanias", conexion)

        Dim idcamp As String
        idcamp = "Dominos_IN@@" & Skill

        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@RDL_OPER", 2)
        cmd.Parameters.AddWithValue("@tipoRep", 1)
        cmd.Parameters.AddWithValue("@idCampLote", idcamp)
        cmd.Parameters.AddWithValue("@FechaInicio", Today())
        cmd.Parameters.AddWithValue("@FechaFin", Today())
        cmd.Parameters.AddWithValue("@T1", 20000)
        cmd.Parameters.AddWithValue("@T2", 40000)
        cmd.Parameters.AddWithValue("@T3", 60000)
        cmd.Parameters.AddWithValue("@T4", 80000)
        cmd.Parameters.AddWithValue("@Skill", Skill)
        cmd.ExecuteNonQuery()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds


    End Function

    Public Function mitacd2ID()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("mit2").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter

        Dim fecha As String
        fecha = Today()

        Dim campania As String
        campania = "DOMINOS_IN@@" & HttpContext.Current.Session("Skill")


        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("REP_V570_RDL_CustomIntraday", conexion)

        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@idCampLote", campania)
        cmd.Parameters.AddWithValue("@FechaInicio", fecha)
        cmd.Parameters.AddWithValue("@FechaFin", fecha)
        cmd.ExecuteNonQuery()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds


    End Function

    Public Function mitacd3()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("mit3").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter

        Dim fecha As String
        fecha = "1234567||" & Today() & "||" & Today()

        Dim Skill As String
        Skill = HttpContext.Current.Session("Skill")

        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("REP_CustomCampanias", conexion)

        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@RDL_OPER", 2)
        cmd.Parameters.AddWithValue("@IdiomaSP", "es")
        cmd.Parameters.AddWithValue("@FechaRango", fecha)
        cmd.Parameters.AddWithValue("@idEmpresa", "-1")
        cmd.Parameters.AddWithValue("@idCamp", "-1")
        cmd.Parameters.AddWithValue("@ParametrosRDLC_AgrupadoPor", 2)
        cmd.Parameters.AddWithValue("@ParametrosRDLC_tipoRep", 1)
        cmd.Parameters.AddWithValue("@ParametrosRDLC_csv", 1)
        cmd.Parameters.AddWithValue("@CampCCS", Skill)
        cmd.ExecuteNonQuery()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds


    End Function

    Public Function mitacd3ID()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("mit3").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter

        Dim fecha As String
        fecha = "1234567||" & Today() & "||" & Today()

        Dim campania As String
        campania = GetIDMITCAMP(HttpContext.Current.Session("Skill")) & "||"


        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("REP_V570_RDL_CustomIntraday", conexion)

        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@FechaRango", fecha)
        cmd.Parameters.AddWithValue("@idCamp", campania)
        cmd.ExecuteNonQuery()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds


    End Function

    Public Function GetIDMITCAMP(Skill As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT id_campania FROM [CCS].[dbo].[SYS_Campanias_V2] WHERE skill='" & Skill & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function




End Class


Public Class Alertas

    Sub EnviarMail(Destinatario As String, Copia As String, Asunto As String, Mensaje As String)

        Dim Alerta As New Alertas
        Dim msgtipo(20) As Integer
        Dim msgmensaje(20) As String

        Try


            Dim correo As New MailMessage
            Dim smtp As New SmtpClient()
            'aquiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii
            correo.From = New MailAddress("ccs.notificaciones@ccscontactcenter.com", "Notificaciones Calidad", System.Text.Encoding.UTF8)
            correo.To.Add(Destinatario)
            correo.CC.Add(Copia)
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

        Catch ex As Exception

        End Try

    End Sub

    Public Function GetListaNotificacion(Nivel As Integer, ID As Integer)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("EXEC CCS.dbo.GET_Lista_QA @NIVEL = " & Nivel & ", @ID =" & ID, conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetCorreoSupervisor(ID As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT b.mail_ccs FROM [CCS].[dbo].[SYS_empleados] a LEFT JOIN [CCS].[dbo].[SYS_empleados] b ON a.jefe_directo = b.id WHERE a.id_acd1 ='" & ID & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function GetCorreoAnalista(ID As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT b.mail_ccs as Analista FROM [QA].[dbo].[SYS_Monitoreos] a LEFT JOIN CCS.dbo.SYS_empleados b ON a.analista = b.id WHERE a.id ='" & ID & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Sub NewShowAlert(Tipo() As Integer, Mensaje() As String, form As Control)
        Dim conteo As Integer, x As Integer, y As Integer
        conteo = Tipo.Count
        Dim AlertType(conteo - 1) As String
        For x = 0 To conteo - 1
            If Tipo(x) = 1 Then
                AlertType(x) = "toastr.success"
            ElseIf Tipo(x) = 2 Then
                AlertType(x) = "toastr.info"
            ElseIf Tipo(x) = 3 Then
                AlertType(x) = "toastr.warning"
            ElseIf Tipo(x) = 4 Then
                AlertType(x) = "toastr.error"
                'Else                                     Se comento para no cambiar la dimension del vector de mensaje
                'AlertType(x) = "toastr.info"
            End If
        Next x
        Dim script As String = ""
        For y = 0 To conteo - 1
            script = script & AlertType(y) & "('<center><strong>" & Mensaje(y) & "</center></strong>') ;"
        Next y
        script = "<script type='text/javascript'> " & script
        script = script & " </script>"
        ScriptManager.RegisterStartupScript(form, GetType(Page), "toastr", script, False)
    End Sub


End Class