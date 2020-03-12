Imports System.Data.SqlClient
Imports System.Web.UI.HtmlControls
Public Class Monitoreo
    Inherits System.Web.UI.Page

    Dim x As New Funciones
    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String
    Dim botontest, sqltest As Integer



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Label1.Text = "Guia de Monitoreo (" & Session("GuiaSeleccionada") & ")"

        If Session("CampaniaSeleccionada") = "OXXO" Then
            Panel7.Visible = True
            Panel13.Visible = True

            Session("GrupoABC") = 2
        Else
            Session("GrupoABC") = 1
        End If

        If Session("CampaniaSeleccionada") = "CV Directo" Or Session("CampaniaSeleccionada") = "OXXO" Or Session("CampaniaSeleccionada") = "Sin Delantal Key Account" Or Session("CampaniaSeleccionada") = "Sin Delantal IN" Then
            RequiredFieldValidator1.Enabled = False
            Label18.Text = "Teléfono"
            ImageButton2.Visible = False
            CheckBox3.Visible = False
        End If

        If Session("CampaniaSeleccionada") = "Sodexo IN" Then
            RequiredFieldValidator1.Enabled = False
            Label18.Text = "Correo:"
            ImageButton2.Visible = False
            CheckBox3.Visible = False
        End If

        If Session("TipoMonitoreo") = 1 Or Session("TipoMonitoreo") = 3 Then
            RequiredFieldValidator1.Enabled = False
        End If

        Label9.Text = Today()

        If IsPostBack Then
            Dim CtrlID As String = String.Empty
            If Request.Form("__EVENTTARGET") IsNot Nothing And
               Request.Form("__EVENTTARGET") <> String.Empty Then
                CtrlID = Request.Form("__EVENTTARGET")
            Else
            End If
            Session("ElControl") = Mid(CtrlID, InStrRev(CtrlID, "$") + 1)

        Else

        End If

        If Not IsPostBack Then
            ListaPendientes()
        End If

        LoadGuia()
        LoadAdicionales()

        If Request.Browser.Browser = "InternetExplorer" Then
            Panel11.Visible = False
            ImageButton2.Visible = False
        End If

        If (Request.Cookies("UserSettings")("Area") = 1 And Request.Cookies("UserSettings")("Puesto") >= 1) Or (Request.Cookies("UserSettings")("Area") = 0 And Request.Cookies("UserSettings")("Puesto") >= 1) Or Request.Cookies("UserSettings")("SU") = True Then
            UpdatePanel1.Visible = True
            UpdatePanel2.Visible = True
            Panel11.Visible = True
        Else
            UpdatePanel1.Visible = False
            UpdatePanel2.Visible = False
            Panel11.Visible = False
        End If

        Dim x As New Funciones


    End Sub

    Sub LoadGuia()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT a.Categoria,b.Rubro  from  (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "' AND campania = '" & Session("IDCampaniaSeleccionada") & "' ) a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID where a.rubro <>0 ", conexion)
        Dim ValorID As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))
        conexion.Close()

        For CuentaDS = 1 To ds.Tables(0).Rows.Count

            ValorID = ds.Tables(0).Rows(CuentaDS - 1).Item(0)

            'cmd.CommandText = "SELECT c.Subrubro,a.Rubro,a.ponderacion from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "' AND campania = '" & Session("IDCampaniaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE Categoria = " & ValorID
            cmd.CommandText = "EXEC [dbo].[GET_Rubros_Ponderaciones] @GUIA = '" & Session("GuiaSeleccionada") & "', @CAMPANIA = '" & Session("IDCampaniaSeleccionada") & "',@CATEGORIA = " & ValorID
            cmd.CommandType = CommandType.Text
            conexion.Open()
            da.SelectCommand = cmd
            ds.Tables.Add()
            da.Fill(ds.Tables(CuentaDS))
            conexion.Close()

        Next

        Dim R As String
        Dim tabla As New Table
        For i = 1 To ds.Tables(0).Rows.Count
            Dim fila As New TableRow
            R = ds.Tables(0).Rows(i - 1).Item(1).ToString


            For j = 1 To 3
                Dim celda As New TableCell
                celda.BorderWidth = 1
                celda.CssClass = "TablaRubros"

                If j = 1 Then
                    Dim label As New Label
                    label.ID = "Categoria" & i
                    label.Text = R
                    celda.ColumnSpan = 3
                    celda.Controls.Add(label)
                    fila.Cells.Add(celda)
                ElseIf j = 2 Then
                Else
                End If
            Next
            tabla.Rows.Add(fila)

            ''''''''''''''''''''''''''''''''''''''''''
            For Rubros = 1 To ds.Tables(i).Rows.Count

                Dim S As String
                Dim T As String
                Dim U As String
                Dim FilaSR As New TableRow
                S = ds.Tables(i).Rows(Rubros - 1).Item(0).ToString
                T = ds.Tables(i).Rows(Rubros - 1).Item(1).ToString
                U = ds.Tables(i).Rows(Rubros - 1).Item(2).ToString


                For j = 1 To 3
                    Dim celda As New TableCell
                    celda.BorderWidth = 1


                    If j = 1 Then
                        Dim label As New Label
                        label.ID = "Rubro" & T
                        label.Text = S & " (" & U & "%)"
                        celda.Controls.Add(label)
                        FilaSR.Cells.Add(celda)
                    ElseIf j = 2 Then
                        Dim VAL As New TextBox
                        VAL.ID = "Valor" & T
                        VAL.Text = U
                        VAL.CssClass = "textos"
                        VAL.Width = 25
                        VAL.Visible = False
                        celda.Controls.Add(VAL)

                        Dim POS As New TextBox
                        POS.ID = "Posible" & T
                        POS.Text = U
                        POS.CssClass = "textos"
                        POS.Width = 25
                        POS.Visible = False
                        celda.Controls.Add(POS)
                        Dim TXT As New TextBox
                        TXT.ID = "Obtenido" & T
                        TXT.Text = POS.Text
                        TXT.CssClass = "textos"
                        TXT.Width = 25
                        TXT.Visible = False
                        celda.Controls.Add(TXT)

                        FilaSR.Cells.Add(celda)
                    Else
                        Dim SEL As New DropDownList
                        SEL.ID = "SEL" & T
                        SEL.CssClass = "textos"
                        SEL.Width = 45
                        SEL.Items.Add(New ListItem("-", 0))
                        SEL.Items.Add(New ListItem("SI", 1))
                        SEL.Items.Add(New ListItem("NO", 2))
                        SEL.Items.Add(New ListItem("NA", 3))
                        SEL.SelectedValue = 1
                        SEL.AutoPostBack = True
                        AddHandler SEL.SelectedIndexChanged, AddressOf Cambiale
                        Dim RFV As New RequiredFieldValidator
                        RFV.ErrorMessage = "*"
                        RFV.Display = ValidatorDisplay.Dynamic
                        RFV.ControlToValidate = SEL.ID
                        RFV.ValidationGroup = "Guia"
                        RFV.InitialValue = 0
                        RFV.CssClass = "RFV"
                        celda.CssClass = "TablaDerecha"
                        celda.Controls.Add(SEL)
                        celda.Controls.Add(RFV)
                        FilaSR.Cells.Add(celda)


                    End If
                Next
                tabla.Rows.Add(FilaSR)

            Next
            ''''''''''''''''''''''''''''''''''''''''''

        Next
        Panel3.Controls.Add(tabla)

        SumaTextBoxOK()
    End Sub

    Sub Cambiale(ByVal sender As Object, ByVal e As EventArgs)

        Dim SEL As DropDownList = DirectCast(sender, DropDownList)

        CambiaHidden()

        SumaTextBoxOK()

    End Sub

    Sub CambiaHidden()

        Dim IDMODIF As String
        IDMODIF = Session("ElControl")
        IDMODIF = IDMODIF.TrimStart("S", "E", "L")

        If x.GetTipoPonderacion(Session("GuiaSeleccionada")) = 1 Then

            If CType(Guia.Parent.FindControl(Session("ElControl")), DropDownList).SelectedItem.Value = 1 Then
                CType(Guia.Parent.FindControl("Obtenido" & IDMODIF), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & IDMODIF), TextBox).Text
                CType(Guia.Parent.FindControl("Posible" & IDMODIF), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & IDMODIF), TextBox).Text
            ElseIf CType(Guia.Parent.FindControl(Session("ElControl")), DropDownList).SelectedItem.Value = 2 Then
                CType(Guia.Parent.FindControl("Obtenido" & IDMODIF), TextBox).Text = 0
                CType(Guia.Parent.FindControl("Posible" & IDMODIF), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & IDMODIF), TextBox).Text
            ElseIf CType(Guia.Parent.FindControl(Session("ElControl")), DropDownList).SelectedItem.Value = 3 Then
                CType(Guia.Parent.FindControl("Obtenido" & IDMODIF), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & IDMODIF), TextBox).Text
                CType(Guia.Parent.FindControl("Posible" & IDMODIF), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & IDMODIF), TextBox).Text
            End If

        ElseIf x.GetTipoPonderacion(Session("GuiaSeleccionada")) = 2 Then

            If CType(Guia.Parent.FindControl(Session("ElControl")), DropDownList).SelectedItem.Value = 1 Then
                CType(Guia.Parent.FindControl("Obtenido" & IDMODIF), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & IDMODIF), TextBox).Text
                CType(Guia.Parent.FindControl("Posible" & IDMODIF), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & IDMODIF), TextBox).Text
            ElseIf CType(Guia.Parent.FindControl(Session("ElControl")), DropDownList).SelectedItem.Value = 2 Then
                CType(Guia.Parent.FindControl("Obtenido" & IDMODIF), TextBox).Text = 0
                CType(Guia.Parent.FindControl("Posible" & IDMODIF), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & IDMODIF), TextBox).Text
            ElseIf CType(Guia.Parent.FindControl(Session("ElControl")), DropDownList).SelectedItem.Value = 3 Then
                CType(Guia.Parent.FindControl("Obtenido" & IDMODIF), TextBox).Text = 0
                CType(Guia.Parent.FindControl("Posible" & IDMODIF), TextBox).Text = 0
            End If

        End If



    End Sub

    Sub SumaTextBoxOK()

        Try

            Session("CuentaValor") = 0
            Session("CuentaPosible") = 0
            Session("CuentaObtenido") = 0
            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("SELECT c.Subrubro,a.Rubro,a.ponderacion from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE a.Rubro <>0", conexion)

            Dim ValorID As String

            conexion.Open()
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            For i = 1 To ds.Tables(0).Rows.Count
                ValorID = ds.Tables(0).Rows(i - 1).Item(1)

                Session("CuentaValor") = Session("CuentaValor") + CInt(CType(Guia.Parent.FindControl("Valor" & ValorID), TextBox).Text)
                Session("CuentaPosible") = Session("CuentaPosible") + CInt(CType(Guia.Parent.FindControl("Posible" & ValorID), TextBox).Text)
                Session("CuentaObtenido") = Session("CuentaObtenido") + CInt(CType(Guia.Parent.FindControl("Obtenido" & ValorID), TextBox).Text)

            Next

            If CheckBox1.Checked = True Then
                Label5.Text = "0%"
                Session("Calificacion") = 0
            Else
                Label5.Text = Decimal.Round((Session("CuentaObtenido") / Session("CuentaPosible") * 100), 2) & "%"
                Session("Calificacion") = Decimal.Round((Session("CuentaObtenido") / Session("CuentaPosible") * 100), 2)
            End If


        Catch ex As Exception
            Label5.Text = "-"
        End Try


    End Sub

    Sub LoadAdicionales()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT a.rubro_adic,b.tipifcacion  from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Tipificaciones b ON A.rubro_Adic = b.ID  where a.rubro =0", conexion)


        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        Dim tabla As New Table
        Dim celda As New TableCell
        Dim fila As New TableRow
        celda.BorderWidth = 1
        celda.CssClass = "TablaRubros2"

        Dim label As New Label
        label.ID = "CategoriaAD" '& i
        label.Text = "RUBROS ADICIONALES"
        celda.ColumnSpan = 3
        celda.Controls.Add(label)
        fila.Cells.Add(celda)

        tabla.Rows.Add(fila)


        ''''''''''''''''''''''''''''''''''''''''''
        For Rubros = 1 To ds.Tables(0).Rows.Count

            Dim S As String
            Dim T As String


            Dim FilaSR As New TableRow
            S = ds.Tables(0).Rows(Rubros - 1).Item(1).ToString
            T = ds.Tables(0).Rows(Rubros - 1).Item(0).ToString

            For j = 1 To 3
                Dim celdaA As New TableCell
                celdaA.BorderWidth = 1

                If j = 1 Then
                    Dim labelA As New Label
                    labelA.ID = "RubroAD" & Rubros
                    labelA.Text = S
                    celdaA.Controls.Add(labelA)
                    FilaSR.Cells.Add(celdaA)
                ElseIf j = 2 Then
                Else
                    Dim DDL As New DropDownList
                    DDL.ID = "DDL" & T
                    DDL.Width = 150
                    DDL.CssClass = "textos"
                    x.FillAdicionales(DDL, T)
                    Dim RFV2 As New RequiredFieldValidator
                    RFV2.ErrorMessage = "*"
                    RFV2.Display = ValidatorDisplay.Dynamic
                    RFV2.ControlToValidate = DDL.ID
                    RFV2.ValidationGroup = "Guia"
                    RFV2.InitialValue = 0
                    RFV2.CssClass = "RFV"
                    celdaA.CssClass = "TablaDerecha"
                    celdaA.Controls.Add(DDL)
                    celdaA.Controls.Add(RFV2)
                    FilaSR.Cells.Add(celdaA)
                End If
            Next
            tabla.Rows.Add(FilaSR)

        Next
        ''''''''''''''''''''''''''''''''''''''''''

        Panel6.Controls.Add(tabla)



    End Sub

    Sub Limpiar()

        Try

            Session("CuentaValor") = 0
            Session("CuentaPosible") = 0
            Session("CuentaObtenido") = 0
            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("SELECT c.Subrubro,a.Rubro,a.ponderacion from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE a.Rubro <>0", conexion)

            Dim ValorID As String
            Label5.Text = "-"
            conexion.Open()
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            For i = 1 To ds.Tables(0).Rows.Count
                ValorID = ds.Tables(0).Rows(i - 1).Item(1)


                CType(Guia.Parent.FindControl("Posible" & ValorID), TextBox).Text = ds.Tables(0).Rows(i - 1).Item(2)
                CType(Guia.Parent.FindControl("Obtenido" & ValorID), TextBox).Text = ds.Tables(0).Rows(i - 1).Item(2)
                CType(Guia.Parent.FindControl("SEL" & ValorID), DropDownList).SelectedValue = 1

            Next

            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            TextBox3.Text = Nothing
            TextBox4.Text = Nothing
            TextBox6.Text = Nothing
            TextBox7.Text = Nothing
            TextBox8.Text = Nothing
            TextBox12.Text = Nothing
            TextBox10.Text = 2


            Label7.Text = Nothing
            Label11.Text = Nothing
            Label15.Text = Nothing
            Label17.Text = Nothing
            Label21.Text = Nothing
            CheckBox1.Checked = False
            CheckBox2.Checked = False

            Label25.Visible = False
            TextBox9.Visible = False
            TextBox5.Visible = False

            RequiredFieldValidator7.Visible = False
            RequiredFieldValidator8.Visible = False


            TextBox11.Text = Nothing
        Catch ex As Exception

        End Try

        SumaTextBoxOK()

    End Sub

    Sub LimpiarAdicionales()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT a.rubro_adic,b.tipifcacion  from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Tipificaciones b ON A.rubro_Adic = b.ID  where a.rubro =0", conexion)
        Dim ValorID As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        For i = 1 To ds.Tables(0).Rows.Count
            ValorID = ds.Tables(0).Rows(i - 1).Item(0)

            CType(Guia.Parent.FindControl("DDL" & ValorID), DropDownList).SelectedValue = 0

        Next

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
        LimpiarAdicionales()
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LlenaDatosAgente()

        If GetPendientes(x.GetUserID(Request.Cookies("Usersettings")("Username"))) = True And Session("CampaniaSeleccionada") <> "OXXO" Then

            Session("CandadoRetro") = True
            msgtipo(0) = 3
            msgmensaje(0) = "¡No puedes monitorear hasta completar tus retroalimentaciones!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        Else
            Session("CandadoRetro") = False
        End If



    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        ConsultaMitrol()

        If CheckBox3.Checked = True Then
            Session("Segmento") = TextBox10.Text
        Else
            Session("Segmento") = 1
        End If

        'MsgBox(Session("CampaniaSeleccionada"))
        If Session("CampaniaSeleccionada") = "CV Directo" Then
            'MsgBox("HOLA")
        Else
            Try
                Dim script As String = "<script type='text/javascript'> cambiarTrack('" & x.BuildString(TextBox2.Text, x.GetServidorCampania(Session("IDCampaniaSeleccionada")), Session("Segmento")) & "'); </script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "cambiarTrack('" & x.BuildString(TextBox2.Text, x.GetServidorCampania(Session("IDCampaniaSeleccionada")), Session("Segmento")) & "');", script, False)

            Catch ex As Exception
                msgtipo(0) = 3
                msgmensaje(0) = "¡El ID no existe o no pertenece a la campaña seleccionada!"
                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            End Try
        End If

    End Sub

    Sub LlenaDatosAgente()


        Try
            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("SELECT a.id,a.nombres + ' ' + a.paterno + ' ' + a.materno as Nombre, b.Nombres+' '+b.paterno as Supervisor FROM [CCS].[dbo].[SYS_empleados] a LEFT JOIN [CCS].[dbo].[SYS_empleados] b ON a.jefe_directo=b.id LEFT JOIN CCS.dbo.SYS_Score_Card c ON a.id =c.agente WHERE  a.puesto = 0 AND (a.id_acd1 ='" & TextBox1.Text & "' OR c.id_acd = '" & TextBox1.Text & "')", conexion)
            conexion.Open()
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.Fill(ds)
            conexion.Close()

            Session("IDAgente") = ds.Tables(0).Rows(0).Item(0).ToString
            Label7.Text = ds.Tables(0).Rows(0).Item(1).ToString
            Label11.Text = ds.Tables(0).Rows(0).Item(2).ToString
            Label15.Text = x.GetNivelAgente(ds.Tables(0).Rows(0).Item(0).ToString, 4)
            Label17.Text = x.GetNivelAgente(ds.Tables(0).Rows(0).Item(0).ToString, 5)



            If x.GetObjetivoAgente(Session("IDAgente"), Session("GrupoABC"), x.GetAntiguedadAgente(Session("IDAgente"))) - x.GetMonitoreosAgente(Session("IDAgente"), 5) < 0 Then
                Label21.Text = 0
                msgtipo(0) = 2
                msgmensaje(0) = "¡Ya está cubierta la cuota de este agente!"
                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            Else
                Label21.Text = x.GetObjetivoAgente(Session("IDAgente"), Session("GrupoABC"), x.GetAntiguedadAgente(Session("IDAgente"))) - x.GetMonitoreosAgente(Session("IDAgente"), 5)
            End If


        Catch ex As Exception
            msgtipo(0) = 4
            msgmensaje(0) = "¡El agente no está dado de alta en el sistema!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

            Limpiar()
            LimpiarAdicionales()
        End Try

    End Sub

    Sub ConsultaMitrol()

        If CheckBox3.Checked = True Then
            Session("Segmento") = TextBox10.Text
        Else
            Session("Segmento") = 1
        End If


        If Session("CampaniaSeleccionada") = "OXXO" Or Session("CampaniaSeleccionada") = "CV Directo" Then

        Else


            Try

                Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
                Dim da As New System.Data.SqlClient.SqlDataAdapter
                Dim ds As New System.Data.DataSet
                Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[Interacciones_Mitrol] WHERE idInteraccion = '" & TextBox2.Text & "' AND segmento = '" & Session("Segmento") & "' and server ='" & x.GetServidorCampania(Session("IDCampaniaSeleccionada")) & "'", conexion)
                conexion.Open()
                cmd.CommandType = CommandType.Text
                da.SelectCommand = cmd
                da.Fill(ds)
                conexion.Close()

                If TextBox1.Text = "" Then
                    TextBox1.Text = ds.Tables(0).Rows(0).Item(3)
                    LlenaDatosAgente()
                End If
                TextBox4.Text = ds.Tables(0).Rows(0).Item(1)
                TextBox3.Text = x.Pasar_Segundos_a_Horas(ds.Tables(0).Rows(0).Item(2))

            Catch ex As Exception
                msgtipo(0) = 4
                msgmensaje(0) = "¡El ID es incorrecto o no pertenece a un agente valido!"

                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                Limpiar()
                LimpiarAdicionales()
            End Try

        End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label26.Text = CInt(Label26.Text) + 1

        Dim MaximoDiario As Integer
        Dim MaximoAntiguedad As Integer

        If Session("CampaniaSeleccionada") = "OXXO" Or Session("CampaniaSeleccionada") = "HarmonHall" Or Session("CampaniaSeleccionada") = "Sin Delantal Key Account" Then
            MaximoDiario = 4
            MaximoAntiguedad = 7

        Else
            If Session("Puesto") >= 3 Then
                MaximoDiario = 100
                MaximoAntiguedad = 100
            Else
                MaximoDiario = 5
                MaximoAntiguedad = 2
            End If


        End If

        ConcatenaValores()
        ConcatenaRubros()
        ConcatenaValoresAD()
        ConcatenaRubrosAD()

        If Session("CandadoRetro") = True And Session("CampaniaSeleccionada") <> "OXXO" Then
            msgtipo(0) = 3
            msgmensaje(0) = "¡No puedes monitorear hasta completar tus retroalimentaciones!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            Limpiar()
            LimpiarAdicionales()
        Else
            

            If CheckBox1.Checked Then
                InsertaMonitoreo()
            Else
                If DateDiff("d", TextBox4.Text, Label9.Text) > 2 Then
                    If Session("TipoMonitoreo") = 4 Or Session("TipoMonitoreo") = 5 Then
                        InsertaMonitoreo()
                    Else
                        msgtipo(0) = 4
                        msgmensaje(0) = "¡No puedes monitorear llamadas con mas de 2 dias de antiguedad!"
                        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                        Limpiar()
                        LimpiarAdicionales()
                    End If
                Else
                    If Session("TipoMonitoreo") = 4 Or Session("TipoMonitoreo") = 5 Or (Request.Cookies("UserSettings")("Area") = 0 And Request.Cookies("UserSettings")("Puesto") >= 1) Then
                        InsertaMonitoreo()
                    Else
                        If Label21.Text = 0 Then
                            msgtipo(0) = 4
                            msgmensaje(0) = "¡Ya se ha cubierto la cuota de monitoreo de este agente!"
                            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                            Limpiar()
                            LimpiarAdicionales()
                        ElseIf x.GetMonitoreosHoy(Session("IDAgente"), Session("GuiaSeleccionada")) >= MaximoDiario Then
                            msgtipo(0) = 4
                            msgmensaje(0) = "¡Solo puedes hacer un monitoreo diario por agente!"
                            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                            Limpiar()
                            LimpiarAdicionales()
                        Else
                            InsertaMonitoreo()
                        End If

                    End If
                End If

            End If
        End If
        ListaPendientes()

    End Sub

    Sub InsertaMonitoreo()

        Dim MensajeAlerta, MensajeError As String

        MensajeAlerta = "<html>  <head> <meta http-equiv=Content-Type content='text/html; charset=windows-1252'> <meta name=Generator content='Microsoft Word 15 (filtered)'> <style> <!-- /* Font Definitions */ @font-face {font-family:'Cambria Math'; panose-1:2 4 5 3 5 4 6 3 2 4;} @font-face {font-family:'Calibri Light'; panose-1:2 15 3 2 2 2 4 3 2 4;} @font-face {font-family:Calibri; panose-1:2 15 5 2 2 2 4 3 2 4;} /* Style Definitions */ p.MsoNormal, li.MsoNormal, div.MsoNormal {margin-top:0cm; margin-right:0cm; margin-bottom:8.0pt; margin-left:0cm; line-height:107%; font-size:11.0pt; font-family:'Calibri',sans-serif;} .MsoChpDefault {font-family:'Calibri',sans-serif;} .MsoPapDefault {margin-bottom:8.0pt; line-height:107%;} @page WordSection1 {size:612.0pt 792.0pt; margin:0cm 3.0cm 70.85pt 3.0cm;} div.WordSection1 {page:WordSection1;} --> </style>  </head>  <body lang=ES-MX>  <div class=WordSection1>  <p class=MsoNormal><b><span style='font-size:5.0pt;line-height:107%;font-family: 'Calibri Light',sans-serif;color:white'><img width=810 height=166 id='Imagen 6' src='http://10.0.0.40/Calidad/Images/Header_Alerta.png'></span></b></p>  <table class=MsoTable15Grid2Accent3 border=1 cellspacing=0 cellpadding=0 style='margin-left:-49.65pt;border-collapse:collapse;border:none'> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Agente:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Label7.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Antigüedad:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        x.GetAntiguedadAgente(Session("IDAgente")) & " Dias" &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Evaluación:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Label5.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Supervisor:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Label11.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Fecha de Audio:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        TextBox4.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Hora de Audio:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Mid(TextBox2.Text, 7, 2) & ":" & Mid(TextBox2.Text, 9, 2) & " Hrs." &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>ID Mitrol/Liga Llamada:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        TextBox2.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Proyecto:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Session("CampaniaSeleccionada") &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Skill:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Session("GuiaSeleccionada") &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Hallazgos:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        TextBox5.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Analista:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        x.GetUserNombreCompleto(Request.Cookies("Usersettings")("Username")) &
                        "</span></b></p> </td> </tr> </table>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  </div>  </body>  </html> "


        MensajeError = "<html>  <head> <meta http-equiv=Content-Type content='text/html; charset=windows-1252'> <meta name=Generator content='Microsoft Word 15 (filtered)'> <style> <!-- /* Font Definitions */ @font-face {font-family:'Cambria Math'; panose-1:2 4 5 3 5 4 6 3 2 4;} @font-face {font-family:'Calibri Light'; panose-1:2 15 3 2 2 2 4 3 2 4;} @font-face {font-family:Calibri; panose-1:2 15 5 2 2 2 4 3 2 4;} /* Style Definitions */ p.MsoNormal, li.MsoNormal, div.MsoNormal {margin-top:0cm; margin-right:0cm; margin-bottom:8.0pt; margin-left:0cm; line-height:107%; font-size:11.0pt; font-family:'Calibri',sans-serif;} .MsoChpDefault {font-family:'Calibri',sans-serif;} .MsoPapDefault {margin-bottom:8.0pt; line-height:107%;} @page WordSection1 {size:612.0pt 792.0pt; margin:0cm 3.0cm 70.85pt 3.0cm;} div.WordSection1 {page:WordSection1;} --> </style>  </head>  <body lang=ES-MX>  <div class=WordSection1>  <p class=MsoNormal><b><span style='font-size:5.0pt;line-height:107%;font-family: 'Calibri Light',sans-serif;color:white'><img width=810 height=166 id='Imagen 6' src='http://10.0.0.40/Calidad/Images/Header_Error.png'></span></b></p>  <table class=MsoTable15Grid2Accent3 border=1 cellspacing=0 cellpadding=0 style='margin-left:-49.65pt;border-collapse:collapse;border:none'> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Agente:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Label7.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Antigüedad:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        x.GetAntiguedadAgente(Session("IDAgente")) & " Dias" &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Evaluación:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Label5.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Supervisor:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Label11.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Fecha de Audio:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        TextBox4.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Hora de Audio:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Mid(TextBox2.Text, 7, 2) & ":" & Mid(TextBox2.Text, 9, 2) & " Hrs." &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>ID Mitrol/Liga Llamada:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        TextBox2.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Proyecto:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Session("CampaniaSeleccionada") &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Skill:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Session("GuiaSeleccionada") &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Hallazgos:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        TextBox6.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Analista:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        x.GetUserNombreCompleto(Request.Cookies("Usersettings")("Username")) &
                        "</span></b></p> </td> </tr> </table>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  </div>  </body>  </html> "

        Dim EF, Monitoreo, segEF, AlertaInt, CommentAlerta As String
        If CheckBox1.Checked = True Then
            EF = 1
            Monitoreo = 1
            Try
                Alerta.EnviarMail(Alerta.GetCorreoSupervisor(TextBox1.Text), Alerta.GetListaNotificacion(3, x.GetUserIDACD(TextBox1.Text)), " ***Error Fatal***", MensajeError)
            Catch ex As Exception
                msgtipo(0) = 3
                msgmensaje(0) = "¡No se envió ninguna alerta debido a que no hay analista asignado!"
                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            End Try
        Else
            EF = 0
            Monitoreo = 1
        End If

        If CheckBox2.Checked = True Then
            AlertaInt = 1
            CommentAlerta = TextBox5.Text
            Try
                Alerta.EnviarMail(Alerta.GetCorreoSupervisor(TextBox1.Text), Alerta.GetListaNotificacion(3, x.GetUserIDACD(TextBox1.Text)), "***Alerta Operativa***", MensajeAlerta)
            Catch ex As Exception
                msgtipo(0) = 3
                msgmensaje(0) = "¡No se envió ninguna alerta debido a que no hay analista asignado!"
                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            End Try
        Else
            AlertaInt = 0
            CommentAlerta = ""
        End If


        Dim Cliente, Folio, TipServCto As String
        If TextBox7.Text = Nothing Then
            Cliente = "-"
        Else
            Cliente = TextBox7.Text
        End If
        If TextBox8.Text = Nothing Then
            Folio = "-"
        Else
            Folio = TextBox8.Text
        End If

        If TextBox12.Text = Nothing Then
            TipServCto = "-"
        Else
            TipServCto = TextBox12.Text
        End If

        If TextBox9.Text = Nothing Then
            segEF = 0
        Else
            segEF = TimeSpan.Parse(TextBox9.Text).TotalSeconds
        End If


        Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery1 As String
        If Request.Cookies("UserSettings")("Area") = 0 And Request.Cookies("UserSettings")("Puesto") >= 1 Then
            strQuery1 = "INSERT INTO [QA].[dbo].[SYS_Monitoreos_Supervisores] (seg,alerta, comment_alerta,id_abc,min_error_fatal,monitoreo,error_fatal,nivel_monitoreo,calificacion,id_campania,id_guia,analista,agente,supervisor,id_acd,fecha_monitoreo,fecha_audio,id_audio,duracion_audio,cliente,folio, TipoServicioCto, comentario," & Session("StringRubrosAD") & Session("StringRubros") & ", tipo_monitoreo,hold ) VALUES (" &
        "'" & Session("Segmento") & "'," &
        "'" & AlertaInt & "'," &
        "'" & CommentAlerta & "'," &
        "QA.[dbo].[GET_ID_ABC](" & DatePart(DateInterval.WeekOfYear, Today, FirstDayOfWeekValue:=vbMonday) & ", " & Session("IDAgente") & ")," &
        "'" & segEF & "'," &
             "'" & Monitoreo & "'," &
            "'" & EF & "'," &
            "'" & x.GetNivel(Session("Calificacion"), Session("GrupoABC"), 1) & "'," &
            "'" & Session("Calificacion") & "'," &
            "'" & Session("IDCampaniaSeleccionada") & "'," &
            "'" & Session("GuiaSeleccionada") & "'," &
            "'" & x.GetUserID(Request.Cookies("Usersettings")("Username")) & "'," &
            "'" & Session("IDAgente") & "'," &
            "'" & x.GetUserSupervisorNumero(Session("IDAgente")) & "'," &
            "'" & TextBox1.Text & "'," &
            "GETDATE() ," &
            "'" & TextBox4.Text & "'," &
            "'" & TextBox2.Text & "'," &
            "'" & TimeSpan.Parse(TextBox3.Text).TotalSeconds & "'," &
            "'" & Cliente & "'," &
            "'" & Folio & "'," &
             "'" & TipServCto & "'," &
            "'" & TextBox6.Text & "'," &
            Session("StringValoresAD") &
            Session("StringValores") &
            "," & Session("TipoMonitoreo") &
            ",'" & TextBox11.Text &
            "')"
        Else
            strQuery1 = "INSERT INTO [QA].[dbo].[SYS_Monitoreos] (seg,alerta, comment_alerta,id_abc,min_error_fatal,monitoreo,error_fatal,nivel_monitoreo,calificacion,id_campania,id_guia,analista,agente,supervisor,id_acd,fecha_monitoreo,fecha_audio,id_audio,duracion_audio,cliente,folio, TipoServicioCto, comentario," & Session("StringRubrosAD") & Session("StringRubros") & ", tipo_monitoreo,hold ) VALUES (" &
        "'" & Session("Segmento") & "'," &
        "'" & AlertaInt & "'," &
        "'" & CommentAlerta & "'," &
        "QA.[dbo].[GET_ID_ABC](" & DatePart(DateInterval.WeekOfYear, Today, FirstDayOfWeekValue:=vbMonday) & ", " & Session("IDAgente") & ")," &
        "'" & segEF & "'," &
             "'" & Monitoreo & "'," &
            "'" & EF & "'," &
            "'" & x.GetNivel(Session("Calificacion"), Session("GrupoABC"), 1) & "'," &
            "'" & Session("Calificacion") & "'," &
            "'" & Session("IDCampaniaSeleccionada") & "'," &
            "'" & Session("GuiaSeleccionada") & "'," &
            "'" & x.GetUserID(Request.Cookies("Usersettings")("Username")) & "'," &
            "'" & Session("IDAgente") & "'," &
            "'" & x.GetUserSupervisorNumero(Session("IDAgente")) & "'," &
            "'" & TextBox1.Text & "'," &
            "GETDATE() ," &
            "'" & TextBox4.Text & "'," &
            "'" & TextBox2.Text & "'," &
            "'" & TimeSpan.Parse(TextBox3.Text).TotalSeconds & "'," &
            "'" & Cliente & "'," &
            "'" & Folio & "'," &
             "'" & TipServCto & "'," &
            "'" & TextBox6.Text & "'," &
            Session("StringValoresAD") &
            Session("StringValores") &
            "," & Session("TipoMonitoreo") &
            ",'" & TextBox11.Text &
            "')"
        End If


        Dim con1 As New SqlConnection(strConnString1)
        Dim cmd1 As New SqlCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = strQuery1
        cmd1.Connection = con1

        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()
        Label27.Text = CInt(Label27.Text) + 1

        Limpiar()
        LimpiarAdicionales()
        UnSelectErrorFatal()

        msgtipo(0) = 1
        msgmensaje(0) = "¡Monitoreo Guardado!"
        Alerta.NewShowAlert(msgtipo, msgmensaje, Me)

    End Sub

    Sub ConcatenaValores()

        Session("StringValores") = Nothing

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("Select c.Subrubro, a.Rubro,a.ponderacion from (Select * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE a.Rubro <>0", conexion)

        Dim ValorID As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        For i = 1 To ds.Tables(0).Rows.Count
            ValorID = ds.Tables(0).Rows(i - 1).Item(1)

            Session("StringValores") = Session("StringValores") & "'" & CInt(CType(Guia.Parent.FindControl("Valor" & ValorID), TextBox).Text) & "','" & CType(Guia.Parent.FindControl("SEL" & ValorID), DropDownList).SelectedItem.Text & "',"

        Next

        Session("StringValores") = Session("StringValores").ToString.TrimEnd(",")

    End Sub

    Sub ConcatenaRubros()

        Session("StringRubros") = Nothing

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT c.Subrubro,a.Rubro,a.ponderacion from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE a.Rubro <>0", conexion)

        Dim ValorID As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        For i = 1 To ds.Tables(0).Rows.Count
            ValorID = ds.Tables(0).Rows(i - 1).Item(1)

            Session("StringRubros") = Session("StringRubros") & "V" & ValorID & ",O" & ValorID & ","

        Next


        Session("StringRubros") = Session("StringRubros").ToString.TrimEnd(",")

    End Sub

    Sub ConcatenaValoresAD()

        Session("StringValoresAD") = Nothing

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT a.rubro_adic,b.tipifcacion  from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Tipificaciones b ON A.rubro_Adic = b.ID  where a.rubro =0", conexion)

        Dim ValorID As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        For i = 1 To ds.Tables(0).Rows.Count
            ValorID = ds.Tables(0).Rows(i - 1).Item(0)

            Session("StringValoresAD") = Session("StringValoresAD") & "'" & CType(Guia.Parent.FindControl("DDL" & ValorID), DropDownList).SelectedItem.Text & "',"

        Next



    End Sub

    Sub ConcatenaRubrosAD()

        Session("StringRubrosAD") = Nothing

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT a.rubro_adic,b.tipifcacion  from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Tipificaciones b ON A.rubro_Adic = b.ID  where a.rubro =0", conexion)

        Dim ValorID As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        For i = 1 To ds.Tables(0).Rows.Count
            ValorID = ds.Tables(0).Rows(i - 1).Item(0)

            Session("StringRubrosAD") = Session("StringRubrosAD") & "R" & ValorID & ","

        Next



    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label25.Visible = True
            TextBox9.Visible = True
            RequiredFieldValidator7.Visible = True
            SelectErrorFatal()
        Else
            Label25.Visible = False
            TextBox9.Visible = False
            RequiredFieldValidator7.Visible = False
            UnSelectErrorFatal()

        End If
    End Sub

    Sub SelectErrorFatal()



        Session("CuentaValor") = 0
        Session("CuentaPosible") = 0
        Session("CuentaObtenido") = 0
        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT c.Subrubro,a.Rubro,a.ponderacion from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE a.Rubro <>0", conexion)


        Label5.Text = "-"
        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()


        Session("Calificacion") = 0
        Label5.Text = "0%"

    End Sub

    Sub UnSelectErrorFatal()



        Session("CuentaValor") = 0
        Session("CuentaPosible") = 0
        Session("CuentaObtenido") = 0
        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("calidad").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT c.Subrubro,a.Rubro,a.ponderacion from (SELECT * FROM [QA].[dbo].[SYS_guias] WHERE guia = '" & Session("GuiaSeleccionada") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE a.Rubro <>0", conexion)

        Label5.Text = "-"
        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()



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
        TextBox1.Text = x.GetAgenteACD(Session("idSeleccion"))
        LlenaDatosAgente()



    End Sub

    Sub ListaPendientes()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT a.ID,a.Nombres + ' ' + a.Paterno + ' ' + a.Materno as Nombre,b.Nombres + ' ' + b.Paterno + ' ' + b.Materno as Supervisor,c.campania as Campaña,CASE WHEN d.lvl IS NULL THEN 'B' ELSE d.lvl END as 'Nivel Anterior',CASE WHEN e.lvl IS NULL THEN 'B' ELSE e.lvl END as 'Nivel Actual',CASE WHEN QA.dbo.GET_Objetivo_Mon(d.lvl," & Session("GrupoABC") & ",DATEDIFF(DAY,a.fecha_alta,GETDATE())) Is NULL Then 3 Else QA.dbo.GET_Objetivo_Mon(d.lvl," & Session("GrupoABC") & ",DATEDIFF(DAY,a.fecha_alta,GETDATE())) End As 'Objetivo Monitoreo',CASE WHEN f.Monitoreos IS NULL THEN 0 ELSE f.Monitoreos END as 'Monitoreos Realizados',CASE WHEN QA.dbo.GET_Objetivo_Mon(d.lvl," & Session("GrupoABC") & ",DATEDIFF(DAY,a.fecha_alta,GETDATE())) IS NULL THEN 3 ELSE QA.dbo.GET_Objetivo_Mon(d.lvl," & Session("GrupoABC") & ",DATEDIFF(DAY,a.fecha_alta,GETDATE())) END - CASE WHEN f.Monitoreos IS NULL THEN 0 ELSE f.Monitoreos END  as 'Monitoreos Restantes' FROM SYS_empleados a LEFT JOIN SYS_empleados b ON a.jefe_directo = b.id LEFT JOIN SYS_campanias c ON a.campaña = c.id LEFT JOIN (SELECT agente ,ISNULL(QA.dbo.GET_ABC(AVG(calificacion)," & Session("GrupoABC") & "),'B') as lvl FROM QA.dbo.SYS_Monitoreos WHERE fecha_monitoreo BETWEEN CONVERT(DATE,(GETDATE())-(6+DATEPART(WEEKDAY,GETDATE()))) AND CONVERT(DATE,((GETDATE())-(DATEPART(WEEKDAY,GETDATE())))+1) GROUP BY agente) d ON a.id = d.agente LEFT JOIN (SELECT agente,ISNULL(QA.dbo.GET_ABC(AVG(calificacion)," & Session("GrupoABC") & "),'B') as lvl FROM QA.dbo.SYS_Monitoreos WHERE fecha_monitoreo BETWEEN CONVERT(DATE,(GETDATE())-(DATEPART(WEEKDAY,GETDATE()-1))) AND CONVERT(DATE,GETDATE()+1) GROUP BY agente) e ON a.id = e.agente LEFT JOIN (SELECT agente, COUNT(agente) as Monitoreos FROM QA.dbo.SYS_Monitoreos WHERE fecha_monitoreo BETWEEN CONVERT(DATE,(GETDATE())-(DATEPART(WEEKDAY,GETDATE()-1))) AND CONVERT(DATE,GETDATE()+1) GROUP BY agente) f ON a.id = f.agente WHERE a.status IN (2,7) AND a.area = 0 AND a.puesto = 0 AND CASE WHEN QA.dbo.GET_Objetivo_Mon(d.lvl," & Session("GrupoABC") & ",DATEDIFF(DAY,a.fecha_alta,GETDATE())) IS NULL THEN 3 ELSE QA.dbo.GET_Objetivo_Mon(d.lvl," & Session("GrupoABC") & ",DATEDIFF(DAY,a.fecha_alta,GETDATE())) END - CASE WHEN f.Monitoreos IS NULL THEN 0 ELSE f.Monitoreos END > 0   And  c.campania = '" & Session("CampaniaSeleccionada") & "' AND a.analista = " & x.GetUserID(Request.Cookies("Usersettings")("Username"))
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        cmd.CommandType = CommandType.Text
        cmd.CommandTimeout = 1800
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        GridView1.DataSource = cmd.ExecuteReader()
        GridView1.DataBind()

        con.Close()
        con.Dispose()

    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click

        Try
            Dim script As String = "<script type='text/javascript'> cambiarTrack('" & x.BuildString(TextBox2.Text, x.GetServidorCampania(Session("IDCampaniaSeleccionada")), Session("Segmento")) & "'); </script>"
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "cambiarTrack('" & x.BuildString(TextBox2.Text, x.GetServidorCampania(Session("IDCampaniaSeleccionada")), Session("Segmento")) & "');", script, False)

        Catch ex As Exception
            msgtipo(0) = 3
            msgmensaje(0) = "¡El ID no existe o no pertenece a la campaña seleccionada!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End Try

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            RequiredFieldValidator8.Visible = True
            TextBox5.Visible = True
        Else
            TextBox5.Visible = False
            RequiredFieldValidator8.Visible = False
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox10.Visible = True
        Else
            TextBox10.Visible = False
        End If

        Limpiar()
    End Sub


    Function GetPendientes(ByVal IDAnalista As String) As Boolean

        Dim sql As String = "SELECT COUNT(*) as Retros_Pendientes FROM [QA].[dbo].[SYS_Monitoreos] A LEFT JOIN [CCS].[dbo].[SYS_empleados] B ON A.agente = B.id WHERE fecha_monitoreo between DATEADD(wk,DATEDIFF(wk,0,GETDATE()),0) AND GETDATE()+1 AND fecha_retro_qa IS NULL AND B.reclutador <> 'MTY' AND A.analista = @user AND A.agente = @IDAgente"
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString())

            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", IDAnalista)
            cmd.Parameters.AddWithValue("@IDAgente", Session("IDAgente"))
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                Return False
            Else
                Return True

            End If

        End Using
    End Function
End Class