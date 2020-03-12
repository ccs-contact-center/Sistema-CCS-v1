Imports System.Data.SqlClient
Public Class FODA
    Inherits System.Web.UI.Page

    Dim x As New Funciones
    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Function GetCampania(Guia As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT b.campania FROM [QA].[dbo].[SYS_Guias] a LEFT JOIN CCS.dbo.SYS_campanias b ON a.campania = b.id WHERE guia = '" & Guia & "'", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Function GetCampaniaID(Guia As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT a.campania FROM [QA].[dbo].[SYS_Guias] a LEFT JOIN CCS.dbo.SYS_campanias b ON a.campania = b.id WHERE guia = '" & Guia & "'", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Function GetSupervisor(ID_ACD As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT jefe_directo FROM [CCS].[dbo].[SYS_empleados] WHERE (id_Acd1 = '" & ID_ACD & "' OR id_Acd2 = '" & ID_ACD & "')", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Function GetNumRubros(Guia As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM [QA].[dbo].[SYS_Guias] WHERE Guia ='" & Guia & "' AND rubro <>0", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)

        conexion.Close()

        Return CInt(ds.Tables(0).Rows(0).Item(0).ToString)

    End Function

    Function GetNumAdicionales(Guia As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM [QA].[dbo].[SYS_Guias] WHERE Guia ='" & Guia & "' AND rubro =0", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return CInt(ds.Tables(0).Rows(0).Item(0).ToString)

    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If IsPostBack Then
        '    Session.Remove("Centro")
        'End If

        'Session("Centro") = Nothing

        If GetCampania(Session("Guia")) = "OXXO" Then
            Panel30.Visible = True
            Panel31.Visible = True

        End If


        If Session("CampaniaSelect") = 16 Then
            Panel7.Visible = True
            Session("GrupoABC") = 2
        Else
            Session("GrupoABC") = 1
        End If


        If IsPostBack Then
            Dim CtrlID As String = String.Empty
            If Request.Form("__EVENTTARGET") IsNot Nothing And
               Request.Form("__EVENTTARGET") <> String.Empty Then
                CtrlID = Request.Form("__EVENTTARGET")
            Else
            End If
            Session("ElControl") = Mid(CtrlID, InStrRev(CtrlID, "$") + 1)
        End If



        If Session("Centro") = "MTY" And Request.Cookies("Usersettings")("Puesto") = 0 Then
            Analista.Visible = False
            FirmaAnalista.Visible = False
        ElseIf Session("Centro") = "MTY" And Request.Cookies("Usersettings")("Puesto") <> 0 Then
            FirmaAgente.Visible = False
        End If
        TextBox6.ReadOnly = True

        LoadGuia()
        LoadAdicionales()
        GetAdicionales()
        GetGenerales()

        If Request.Browser.Browser = "InternetExplorer" Then
            Panel11.Visible = False
        Else

            Try
                Dim script As String = "<script type='text/javascript'> cambiarTrack('" & x.BuildString(Dato4.Text, x.GetServidorCampania(Session("CampaniaSelect")), Session("Segmento")) & "'); </script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "cambiarTrack('" & x.BuildString(Dato4.Text, x.GetServidorCampania(Session("CampaniaSelect")), Session("Segmento")) & "');", script, False)

            Catch ex As Exception
                msgtipo(0) = 3
                msgmensaje(0) = "¡El ID no existe o no pertenece a la campaña seleccionada!"
                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            End Try
        End If
    End Sub

    Sub LoadGuia()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT a.Categoria,b.Rubro  from  (SELECT * FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("Guia") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID where a.rubro <>0 ", conexion)
        Dim ValorID As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))
        conexion.Close()

        For CuentaDS = 1 To ds.Tables(0).Rows.Count

            ValorID = ds.Tables(0).Rows(CuentaDS - 1).Item(0)

            cmd.CommandText = "SELECT c.Subrubro,a.Rubro,a.ponderacion from (SELECT * FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("Guia") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE Categoria = " & ValorID
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
                        label.Text = S & "(" & U & "%)"
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
                        TXT.Text = 0
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
                        SEL.AutoPostBack = True
                        SEL.Enabled = False
                        AddHandler SEL.SelectedIndexChanged, AddressOf Cambiale

                        celda.CssClass = "TablaDerecha"
                        celda.Controls.Add(SEL)

                        FilaSR.Cells.Add(celda)


                    End If
                Next
                tabla.Rows.Add(FilaSR)

            Next
            ''''''''''''''''''''''''''''''''''''''''''

        Next
        Panel3.Controls.Add(tabla)



    End Sub

    Sub Cambiale(ByVal sender As Object, ByVal e As EventArgs)
        Dim SEL As DropDownList = DirectCast(sender, DropDownList)

        CambiaHidden()
    End Sub

    Sub CambiaHidden()

        Dim IDMODIF As String
        IDMODIF = Session("ElControl")
        IDMODIF = IDMODIF.TrimStart("S", "E", "L")

        If x.GetTipoPonderacion(Session("Guia")) = 1 Then

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

        ElseIf x.GetTipoPonderacion(Session("Guia")) = 2 Then

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

    Sub LoadAdicionales()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT a.rubro_adic,b.tipifcacion  from (SELECT * FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("Guia") & "') a LEFT JOIN QA.DBO.SYS_Tipificaciones b ON A.rubro_Adic = b.ID  where a.rubro =0", conexion)


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
        label.Text = "Rubros Adicionales"
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
                    DDL.Enabled = False
                    x.FillAdicionales(DDL, T)
                    celdaA.CssClass = "TablaDerecha"
                    celdaA.Controls.Add(DDL)
                    FilaSR.Cells.Add(celdaA)
                End If
            Next
            tabla.Rows.Add(FilaSR)

        Next
        ''''''''''''''''''''''''''''''''''''''''''

        Panel9.Controls.Add(tabla)



    End Sub

    Sub GetAdicionales()

        Dim GuiaS, ID, AreasOportunidad, Valor As String

        GuiaS = Session("Guia")
        ID = Session("idSeleccion")

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("EXEC [QA].[dbo].[GET_Retro] @GUIA = '" & GuiaS & "' , @IDMON ='" & ID & "'", conexion)

        AreasOportunidad = Nothing
        Valor = Nothing

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))


        cmd.CommandText = "SELECT rubro_adic FROM QA.dbo.SYS_guias WHERE guia = '" & GuiaS & "' and rubro =0"
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(1))

        conexion.Close()

        For i = 0 To GetNumAdicionales(GuiaS) - 1
            Valor = ds.Tables(1).Rows(i).Item(0).ToString


            CType(Panel9.Parent.FindControl("DDL" & Valor), DropDownList).SelectedItem.Text = ds.Tables(0).Rows(0).Item(26 + GetNumRubros(Session("Guia")) + i).ToString


        Next



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Session("Centro") = "MTY" Then

            If Request.Cookies("Usersettings")("Puesto") = 0 Then

                If CInt(HiddenField2.Value) = 1 Then
                    GuardaRetro()
                    msgtipo(0) = 1
                    msgmensaje(0) = "¡Retroalimentación Guardada!"
                    Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                Else
                    msgtipo(0) = 3
                    msgmensaje(0) = "¡Debes firmar la retroalimentación!"
                    Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                End If
            Else
                If CInt(HiddenField1.Value) = 1 And Image4.Visible = True Then
                    GuardaRetro()
                    msgtipo(0) = 1
                    msgmensaje(0) = "¡Retroalimentación Guardada!"
                    Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                Else
                    msgtipo(0) = 3
                    msgmensaje(0) = "¡El agente debe firmar la retroalimentación primero!"
                    Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                End If

            End If
        Else
                If (CInt(HiddenField1.Value) + CInt(HiddenField2.Value)) = 2 Then

                GuardaRetro()

                msgtipo(0) = 1
                msgmensaje(0) = "¡Retroalimentación Guardada!"
                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            Else
                msgtipo(0) = 3
                msgmensaje(0) = "¡La retroalimentación debe ser firmada por el analista y por el agente!"
                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            End If
        End If


    End Sub

    Sub GuardaRetro()
        If Session("Centro") = "MTY" Then

            If Request.Cookies("Usersettings")("Puesto") = 0 Then


                Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
                Dim strQuery As String = "UPDATE QA.dbo.SYS_monitoreos SET compromisos_agente = '" & TextBox3.Text & "', Q1='" & TextBox54.Text & "', Q2='" & TextBox55.Text & "',   retro = 2 WHERE id = " & Session("idSeleccion")
                Dim con As New SqlConnection(strConnString)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = strQuery
                cmd.Connection = con

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                con.Dispose()
            Else

                Dim MensajeFODA As String

                MensajeFODA = "<html>  <head> <meta http-equiv=Content-Type content='text/html; charset=windows-1252'> <meta name=Generator content='Microsoft Word 15 (filtered)'> <style> <!-- /* Font Definitions */ @font-face {font-family:'Cambria Math'; panose-1:2 4 5 3 5 4 6 3 2 4;} @font-face {font-family:'Calibri Light'; panose-1:2 15 3 2 2 2 4 3 2 4;} @font-face {font-family:Calibri; panose-1:2 15 5 2 2 2 4 3 2 4;} /* Style Definitions */ p.MsoNormal, li.MsoNormal, div.MsoNormal {margin-top:0cm; margin-right:0cm; margin-bottom:8.0pt; margin-left:0cm; line-height:107%; font-size:11.0pt; font-family:'Calibri',sans-serif;} .MsoChpDefault {font-family:'Calibri',sans-serif;} .MsoPapDefault {margin-bottom:8.0pt; line-height:107%;} @page WordSection1 {size:612.0pt 792.0pt; margin:0cm 3.0cm 70.85pt 3.0cm;} div.WordSection1 {page:WordSection1;} --> </style>  </head>  <body lang=ES-MX>  <div class=WordSection1>  <p class=MsoNormal><b><span style='font-size:5.0pt;line-height:107%;font-family: 'Calibri Light',sans-serif;color:white'><img width=810 height=166 id='Imagen 6' src='http://10.0.0.40/Calidad/Images/Header_FODA.png'></span></b></p>  <table class=MsoTable15Grid2Accent3 border=1 cellspacing=0 cellpadding=0 style='margin-left:-49.65pt;border-collapse:collapse;border:none'> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Agente:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Dato1.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Evaluación:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Dato7.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Proyecto:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        GetCampania(Session("Guia")) &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Skill:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Session("Guia") &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Analista:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        x.GetUserNombreCompleto(Request.Cookies("Usersettings")("Username")) &
                        "</span></b></p> </td> </tr> </table>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  </div>  </body>  </html> "



                Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
                Dim strQuery As String = "UPDATE QA.dbo.SYS_monitoreos SET fecha_retro_qa = GETDATE(), compromisos_analista = '" & TextBox1.Text & "',   Q1= '" & TextBox54.Text & "',  Q2= '" & TextBox55.Text & "', retro = 1 WHERE id = " & Session("idSeleccion")
                Dim con As New SqlConnection(strConnString)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = strQuery
                cmd.Connection = con

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                con.Dispose()

                Alerta.EnviarMail(Alerta.GetCorreoSupervisor(Dato6.Text), Alerta.GetListaNotificacion(1, x.GetUserIDACD(Dato6.Text)), "***Retroalimentación: FODA***", MensajeFODA)
            End If
        Else

            Dim MensajeFODA As String

            MensajeFODA = "<html>  <head> <meta http-equiv=Content-Type content='text/html; charset=windows-1252'> <meta name=Generator content='Microsoft Word 15 (filtered)'> <style> <!-- /* Font Definitions */ @font-face {font-family:'Cambria Math'; panose-1:2 4 5 3 5 4 6 3 2 4;} @font-face {font-family:'Calibri Light'; panose-1:2 15 3 2 2 2 4 3 2 4;} @font-face {font-family:Calibri; panose-1:2 15 5 2 2 2 4 3 2 4;} /* Style Definitions */ p.MsoNormal, li.MsoNormal, div.MsoNormal {margin-top:0cm; margin-right:0cm; margin-bottom:8.0pt; margin-left:0cm; line-height:107%; font-size:11.0pt; font-family:'Calibri',sans-serif;} .MsoChpDefault {font-family:'Calibri',sans-serif;} .MsoPapDefault {margin-bottom:8.0pt; line-height:107%;} @page WordSection1 {size:612.0pt 792.0pt; margin:0cm 3.0cm 70.85pt 3.0cm;} div.WordSection1 {page:WordSection1;} --> </style>  </head>  <body lang=ES-MX>  <div class=WordSection1>  <p class=MsoNormal><b><span style='font-size:5.0pt;line-height:107%;font-family: 'Calibri Light',sans-serif;color:white'><img width=810 height=166 id='Imagen 6' src='http://10.0.0.40/Calidad/Images/Header_FODA.png'></span></b></p>  <table class=MsoTable15Grid2Accent3 border=1 cellspacing=0 cellpadding=0 style='margin-left:-49.65pt;border-collapse:collapse;border:none'> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Agente:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Dato1.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Evaluación:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Dato7.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Proyecto:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        GetCampania(Session("Guia")) &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Skill:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Session("Guia") &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Analista:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        x.GetUserNombreCompleto(Request.Cookies("Usersettings")("Username")) &
                        "</span></b></p> </td> </tr> </table>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  </div>  </body>  </html> "



            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim strQuery As String = "UPDATE QA.dbo.SYS_monitoreos SET fecha_retro_qa = GETDATE(), compromisos_analista = '" & TextBox1.Text & "', compromisos_agente = '" & TextBox3.Text & "', Q1= '" & TextBox54.Text & "',  Q2= '" & TextBox55.Text & "', retro = 1 WHERE id = " & Session("idSeleccion")
            Dim con As New SqlConnection(strConnString)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            con.Dispose()

            Alerta.EnviarMail(Alerta.GetCorreoSupervisor(Dato6.Text), Alerta.GetListaNotificacion(1, x.GetUserIDACD(Dato6.Text)), "***Retroalimentación: FODA***", MensajeFODA)


        End If

    End Sub

    Protected Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If Autentificacion.Autenticar(Request.Cookies("Usersettings")("Username"), x.Passcrypt(TextBox5.Text)) = True Then
            Image2.Visible = True
            HiddenField1.Value = 1
        Else
            Image2.Visible = False
            HiddenField1.Value = 0
        End If
    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Autentificacion.Autenticar(x.GetCCSID2(Session("idACD"), GetSupervisor(Session("idACD"))), x.Passcrypt(TextBox2.Text)) = True Then
            Image3.Visible = True
            HiddenField2.Value = 1
        Else
            Image3.Visible = False
            HiddenField2.Value = 0
        End If
    End Sub


    Sub GetGenerales()

        Dim GuiaS, ID, AreasOportunidad, Valor As String

        GuiaS = Session("Guia")
        ID = Session("idSeleccion")

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("EXEC [QA].[dbo].[GET_Retro] @GUIA = '" & GuiaS & "' , @IDMON ='" & ID & "'", conexion)

        AreasOportunidad = Nothing
        Valor = Nothing

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))

        Dato1.Text = ds.Tables(0).Rows(0).Item(4).ToString
        Dato2.Text = ds.Tables(0).Rows(0).Item(5).ToString
        Dato4.Text = ds.Tables(0).Rows(0).Item(13).ToString
        Dato5.Text = Mid(ds.Tables(0).Rows(0).Item(10).ToString, 1, 10)
        Dato6.Text = ds.Tables(0).Rows(0).Item(6).ToString
        Dato7.Text = ds.Tables(0).Rows(0).Item(20).ToString & "%"
        Dato9.Text = x.Pasar_Segundos_a_Horas(ds.Tables(0).Rows(0).Item(14).ToString)
        Dato10.Text = Mid(ds.Tables(0).Rows(0).Item(9).ToString, 1, 10)
        TextBox6.Text = ds.Tables(0).Rows(0).Item(17).ToString
        Session("Segmento") = ds.Tables(0).Rows(0).Item("seg").ToString
        Session("Status") = ds.Tables(0).Rows(0).Item(24).ToString

        If Session("Centro") = "MTY" And Request.Cookies("Usersettings")("Puesto") <> 0 Then
            TextBox3.Text = ds.Tables(0).Rows(0).Item(19).ToString
            TextBox3.ReadOnly = True

        End If

        cmd.CommandText = "SELECT rubro FROM QA.dbo.SYS_guias WHERE guia = '" & GuiaS & "' and rubro <>0"
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(1))
        conexion.Close()

        For i = 0 To GetNumRubros(GuiaS) - 1
            Valor = ds.Tables(1).Rows(i).Item(0).ToString


            CType(Guia.Parent.FindControl("SEL" & Valor), DropDownList).SelectedItem.Text = ds.Tables(0).Rows(0).Item(26 + i).ToString


        Next


        If Request.Cookies("Usersettings")("Puesto") <> 0 And Session("Status") = "2" Then
            Image4.Visible = True
        End If
    End Sub



End Class