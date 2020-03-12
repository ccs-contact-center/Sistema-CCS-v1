Imports System.Data.SqlClient
Public Class Coaching_Agente
    Inherits System.Web.UI.Page


    Dim x As New Funciones
    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Function GetMTY(User As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT [reclutador] FROM [CCS].[dbo].[SYS_empleados] WHERE id_ccs = '" & User & "'", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()
        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

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

    Function GetAnalista(ID As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT b.nombres + ' ' + b.paterno + ' ' + b.materno as Analista FROM [QA].[dbo].[SYS_Monitoreos] a LEFT JOIN CCS.dbo.SYS_empleados b ON a.analista = b.id WHERE b.id = '" & ID & "'", conexion)

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

    Function GetNombreRubros(Rubro As String)

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [QA].[dbo].[SYS_subrubros] WHERE id ='" & Rubro & "'", conexion)

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()
        Return ds.Tables(0).Rows(0).Item(1).ToString

    End Function

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

    Public Function GetAnalistaID(Seleccionado As String)

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim conexion As New SqlConnection(strConnString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet

        Dim cmd As SqlCommand = New SqlCommand("SELECT analista FROM QA.dbo.SYS_monitoreos WHERE id = '" & Seleccionado & "'", conexion)
        cmd.CommandType = CommandType.Text
        conexion.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        Return ds.Tables(0).Rows(0).Item(0).ToString

    End Function

    Sub ListaCoachingPendientes()

        If GetMTY(Request.Cookies("UserSettings")("Username")) = "MTY" Then
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim strQuery As String = "SELECT a.ID,a.id_acd as 'ID Mitrol',b.nombres + ' ' + b.paterno + ' '+b.materno as Nombre,c.nombres + ' ' + c.paterno + ' '+c.materno as Supervisor,e.nombres + ' ' + e.paterno + ' '+e.materno as Analista ,d.campania as Campaña,id_guia as Guia,CONVERT(NVARCHAR(MAX),calificacion) + '%' as Calificación,CONVERT(DATE,fecha_monitoreo) as Fecha,(CASE WHEN a.id_campania <> 16 THEN 3-DATEDIFF(DD,CONVERT(DATE,fecha_monitoreo),CONVERT(DATE,GETDATE())) + QA.dbo.GET_Dias_Retro(CONVERT(DATE,fecha_monitoreo),a.id_acd) ELSE 8 END) as 'Dias para Retro' FROM QA.dbo.SYS_Monitoreos a LEFT JOIN CCS.dbo.SYS_empleados b ON a.agente=b.id LEFT JOIN CCS.dbo.SYS_empleados c ON a.supervisor=c.id LEFT JOIN CCS.dbo.SYS_campanias d ON a.id_campania=d.id LEFT JOIN CCS.dbo.SYS_empleados e ON a.analista=e.id WHERE (CASE WHEN a.id_campania <> 16 THEN 3-DATEDIFF(DD,CONVERT(DATE,fecha_monitoreo),CONVERT(DATE,GETDATE())) + QA.dbo.GET_Dias_Retro(CONVERT(DATE,fecha_monitoreo),a.id_acd) ELSE 8 END) > 0  AND retro IS NULL AND a.agente =" & x.GetUserID(Request.Cookies("Usersettings")("Username"))
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
        Else
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim strQuery As String = "SELECT a.ID,a.id_acd as 'ID Mitrol',b.nombres + ' ' + b.paterno + ' '+b.materno as Nombre,c.nombres + ' ' + c.paterno + ' '+c.materno as Supervisor,e.nombres + ' ' + e.paterno + ' '+e.materno as Analista ,d.campania as Campaña,id_guia as Guia,CONVERT(NVARCHAR(MAX),calificacion) + '%' as Calificación,CONVERT(DATE,fecha_monitoreo) as Fecha,(CASE WHEN a.id_campania <> 16 THEN 3-DATEDIFF(DD,CONVERT(DATE,fecha_monitoreo),CONVERT(DATE,GETDATE())) + QA.dbo.GET_Dias_Retro(CONVERT(DATE,fecha_monitoreo),a.id_acd) ELSE 8 END) as 'Dias para Retro' FROM QA.dbo.SYS_Monitoreos a LEFT JOIN CCS.dbo.SYS_empleados b ON a.agente=b.id LEFT JOIN CCS.dbo.SYS_empleados c ON a.supervisor=c.id LEFT JOIN CCS.dbo.SYS_campanias d ON a.id_campania=d.id LEFT JOIN CCS.dbo.SYS_empleados e ON a.analista=e.id WHERE (CASE WHEN a.id_campania <> 16 THEN 3-DATEDIFF(DD,CONVERT(DATE,fecha_monitoreo),CONVERT(DATE,GETDATE())) + QA.dbo.GET_Dias_Retro(CONVERT(DATE,fecha_monitoreo),a.id_acd) ELSE 8 END) > 0 AND calificacion >= 80 AND retro IS NULL AND a.agente =" & x.GetUserID(Request.Cookies("Usersettings")("Username"))
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
            Session("idACD") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(1).Text)
            Session("Guia") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(6).Text)
            Session("Calificacion") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(7).Text)
            Session("CampaniaSelect") = GetCampaniaID(String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(5).Text))
            Dim IDAnalista As String
            IDAnalista = GetAnalistaID(Session("idSeleccion"))
            Session("NombreAnalista") = GetAnalista(IDAnalista)

        End If

        If Mid(Session("Calificacion"), 1, Len(Session("Calificacion")) - 1) < 80 Then
            Session("Centro") = "MTY"
            Response.Redirect("FODA.aspx")
        End If


        GetGenerales()
        LoadAdicionales()
        GetAdicionales()

        Try
            Dim script As String = "<script type='text/javascript'> cambiarTrack('" & x.BuildString(Valor4.Text, x.GetServidorCampania(Session("CampaniaSelect")), Session("Segmento")) & "'); </script>"
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "cambiarTrack('" & x.BuildString(Valor4.Text, x.GetServidorCampania(Session("CampaniaSelect")), Session("Segmento")) & "');", script, False)

        Catch ex As Exception
            msgtipo(0) = 3
            msgmensaje(0) = "¡El ID no existe o no pertenece a la campaña seleccionada!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End Try

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.Cookies("UserSettings")("Campania") = "16" Then
            Panel22.Visible = True
            Panel23.Visible = True

        End If

        ListaCoachingPendientes()

        If Request.Browser.Browser = "InternetExplorer" Then
            Panel11.Visible = False
        End If



        If GetMTY(Request.Cookies("UserSettings")("Username")) = "MTY" Then
            FirmaAnalista.Visible = False
            Panel3.Visible = False
            Panel2.CssClass = "margencitofull"
        Else


        End If



    End Sub

    Sub GetGenerales()

        Dim Guia, ID, AreasOportunidad As String

        Guia = Session("Guia")
        ID = Session("idSeleccion")

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("EXEC [QA].[dbo].[GET_Retro] @GUIA = '" & Guia & "' , @IDMON ='" & ID & "'", conexion)

        AreasOportunidad = Nothing

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))

        Valor1.Text = ds.Tables(0).Rows(0).Item(4).ToString
        Valor2.Text = ds.Tables(0).Rows(0).Item(5).ToString
        Valor4.Text = ds.Tables(0).Rows(0).Item(13).ToString
        Valor5.Text = Mid(ds.Tables(0).Rows(0).Item(10).ToString, 1, 10)
        Valor6.Text = ds.Tables(0).Rows(0).Item(6).ToString
        Valor7.Text = ds.Tables(0).Rows(0).Item(20).ToString & "%"
        Valor9.Text = x.Pasar_Segundos_a_Horas(ds.Tables(0).Rows(0).Item(14).ToString)
        Valor10.Text = Mid(ds.Tables(0).Rows(0).Item(9).ToString, 1, 10)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(17).ToString
        Session("Segmento") = ds.Tables(0).Rows(0).Item("seg").ToString

        cmd.CommandText = "SELECT rubro,ponderacion FROM QA.dbo.SYS_guias WHERE guia = '" & Guia & "' and rubro <>0"
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(1))
        conexion.Close()

        For i = 0 To GetNumRubros(Guia)

            If ds.Tables(0).Rows(0).Item(26 + i).ToString = "NO" Then

                AreasOportunidad = AreasOportunidad & "•" & GetNombreRubros(ds.Tables(1).Rows(i).Item(0).ToString) & "(" & ds.Tables(1).Rows(i).Item(1).ToString & "%)" & vbCrLf

            End If
        Next

        TextBox1.Text = AreasOportunidad

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


            CType(Panel5.Parent.FindControl("DDL" & Valor), DropDownList).SelectedItem.Text = ds.Tables(0).Rows(0).Item(26 + GetNumRubros(Session("Guia")) + i).ToString


        Next



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

        Panel5.Controls.Add(tabla)



    End Sub

    Protected Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If Autentificacion.AutenticarID(GetAnalistaID(Session("idSeleccion")), x.Passcrypt(TextBox5.Text)) = True Then
            Image2.Visible = True
            HiddenField1.Value = 1
        Else
            Image2.Visible = False
            HiddenField1.Value = 0
        End If
    End Sub

    Protected Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If Autentificacion.Autenticar(x.GetCCSID2(Session("idACD"), Request.Cookies("Usersettings")("Supervisor")), x.Passcrypt(TextBox6.Text)) = True Then
            Image3.Visible = True
            HiddenField2.Value = 1
        Else
            Image3.Visible = False
            HiddenField2.Value = 0
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If GetMTY(Request.Cookies("UserSettings")("Username")) = "MTY" Then


            If CInt(HiddenField2.Value) = 1 Then

                GuardaRetro()
                If Session("X") = "X" Then
                Else

                    msgtipo(0) = 1
                    msgmensaje(0) = "¡Firma Guardada!"
                    Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
                End If
            Else
                    msgtipo(0) = 3
                msgmensaje(0) = "¡Debes firmar la retroalimentación!"
                Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
            End If

            ListaCoachingPendientes()

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

            ListaCoachingPendientes()

        End If


    End Sub

    Sub GuardaRetro()

        If Valor6.Text = Nothing Then
            Session("X") = "X"
        Else
            Dim MensajeCoaching As String

            MensajeCoaching = "<html>  <head> <meta http-equiv=Content-Type content='text/html; charset=windows-1252'> <meta name=Generator content='Microsoft Word 15 (filtered)'> <style> <!-- /* Font Definitions */ @font-face {font-family:'Cambria Math'; panose-1:2 4 5 3 5 4 6 3 2 4;} @font-face {font-family:'Calibri Light'; panose-1:2 15 3 2 2 2 4 3 2 4;} @font-face {font-family:Calibri; panose-1:2 15 5 2 2 2 4 3 2 4;} /* Style Definitions */ p.MsoNormal, li.MsoNormal, div.MsoNormal {margin-top:0cm; margin-right:0cm; margin-bottom:8.0pt; margin-left:0cm; line-height:107%; font-size:11.0pt; font-family:'Calibri',sans-serif;} .MsoChpDefault {font-family:'Calibri',sans-serif;} .MsoPapDefault {margin-bottom:8.0pt; line-height:107%;} @page WordSection1 {size:612.0pt 792.0pt; margin:0cm 3.0cm 70.85pt 3.0cm;} div.WordSection1 {page:WordSection1;} --> </style>  </head>  <body lang=ES-MX>  <div class=WordSection1>  <p class=MsoNormal><b><span style='font-size:5.0pt;line-height:107%;font-family: 'Calibri Light',sans-serif;color:white'><img width=810 height=166 id='Imagen 6' src='http://10.0.0.40/Calidad/Images/Header_Coaching.png'></span></b></p>  <table class=MsoTable15Grid2Accent3 border=1 cellspacing=0 cellpadding=0 style='margin-left:-49.65pt;border-collapse:collapse;border:none'> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Agente:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:solid windowtext 1.0pt; border-left:none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Valor1.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Evaluación:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Valor7.Text &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Proyecto:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        GetCampania(Session("Guia")) &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid #C9C9C9 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Skill:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid #C9C9C9 1.0pt;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Session("Guia") &
                        "</span></b></p> </td> </tr> <tr> <td width=38 valign=top style='width:1.0cm;border:none;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>&nbsp;</span></b></p> </td> <td width=95 valign=top style='width:70.95pt;border:none;border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>&nbsp;</span></p> </td> <td width=283 valign=top style='width:212.6pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid #C9C9C9 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><span style='font-size:12.0pt'>Analista:</span></p> </td> <td width=274 valign=top style='width:205.5pt;border-top:none;border-left: none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt; background:#EDEDED;padding:0cm 5.4pt 0cm 5.4pt'> <p class=MsoNormal align=center style='margin-bottom:0cm;margin-bottom:.0001pt; text-align:center;line-height:normal'><b><span style='font-size:12.0pt'>" &
                        Session("NombreAnalista") &
                        "</span></b></p> </td> </tr> </table>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  <p class=MsoNormal align=center style='text-align:center'><b><span style='font-size:14.0pt;line-height:107%;font-family:'Calibri Light',sans-serif; color:white'>&nbsp;</span></b></p>  </div>  </body>  </html> "


            If GetMTY(Request.Cookies("UserSettings")("Username")) = "MTY" Then



                Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
                Dim strQuery As String = "UPDATE QA.dbo.SYS_monitoreos SET compromisos_agente = '" & TextBox3.Text & "', Q1= '" & TextBox20.Text & "',  Q2= '" & TextBox21.Text & "', retro = 2 WHERE id = " & Session("idSeleccion")
                Dim con As New SqlConnection(strConnString)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = strQuery
                cmd.Connection = con

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                con.Dispose()

                'Alerta.EnviarMail(Alerta.GetCorreoSupervisor(Valor6.Text), Alerta.GetListaNotificacion(1, x.GetUserIDACD(Valor6.Text)), "***Retroalimentación: Coaching***", MensajeCoaching)



            Else


                Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
                Dim strQuery As String = "UPDATE QA.dbo.SYS_monitoreos SET fecha_retro_qa = GETDATE(), compromisos_analista = '" & TextBox4.Text & "', compromisos_agente = '" & TextBox3.Text & "', Q1= '" & TextBox20.Text & "',  Q2= '" & TextBox21.Text & "', retro = 1 WHERE id = " & Session("idSeleccion")
                Dim con As New SqlConnection(strConnString)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = strQuery
                cmd.Connection = con

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                con.Dispose()

                Alerta.EnviarMail(Alerta.GetCorreoSupervisor(Valor6.Text), Alerta.GetListaNotificacion(1, x.GetUserIDACD(Valor6.Text)), "***Retroalimentación: Coaching***", MensajeCoaching)


            End If





        End If



    End Sub


End Class