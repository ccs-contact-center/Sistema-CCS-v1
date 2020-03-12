Imports System.Data.SqlClient
Public Class Editar_Calificacion_2
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

        LoadGuia()
        LoadAdicionales()

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

        Else
            GetAdicionales()
            GetGenerales()
        End If




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

        If (CInt(HiddenField1.Value)) = 1 Then

            ConcatenaValores()
            GuardaRetro()

            msgtipo(0) = 1
            msgmensaje(0) = "¡Calificacion Modificada!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        Else
            msgtipo(0) = 3
            msgmensaje(0) = "¡El cambio debe ser firmado por el supervisor de calidad!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End If

    End Sub


    Sub ConcatenaValores()

        Session("StringValores") = Nothing

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("Select c.Subrubro, a.Rubro,a.ponderacion from (Select * FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("Guia") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE a.Rubro <>0", conexion)

        Dim ValorID As String

        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        da.Fill(ds)
        conexion.Close()

        For i = 1 To ds.Tables(0).Rows.Count
            ValorID = ds.Tables(0).Rows(i - 1).Item(1)



            Session("StringValores") = Session("StringValores") & "O" & ValorID & " = " & "'" & CType(Guia.Parent.FindControl("SEL" & ValorID), DropDownList).SelectedItem.Text & "',"

        Next

        Session("StringValores") = Session("StringValores").ToString.TrimEnd(",")

    End Sub



    Sub GuardaRetro()

        SumaTextBoxOK()

        Dim strConnString1 As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery1 As String = "UPDATE [QA].[dbo].[SYS_Monitoreos] SET calificacion = '" & Session("Calificacion") & "', " & Session("StringValores") & " WHERE id = " & Session("idSeleccion")

        Dim con1 As New SqlConnection(strConnString1)
        Dim cmd1 As New SqlCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = strQuery1
        cmd1.Connection = con1

        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()

        Response.Redirect("Editar_Calificacion.aspx")

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

        cmd.CommandText = "SELECT rubro FROM QA.dbo.SYS_guias WHERE guia = '" & GuiaS & "' and rubro <>0"
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(1))
        conexion.Close()
        Dim Selecinado As Integer








        For i = 0 To GetNumRubros(GuiaS) - 1

            Valor = ds.Tables(1).Rows(i).Item(0).ToString

            If ds.Tables(0).Rows(0).Item(26 + i).ToString = "SI" Then
                Selecinado = 1
            ElseIf ds.Tables(0).Rows(0).Item(26 + i).ToString = "NO"
                Selecinado = 2
            ElseIf ds.Tables(0).Rows(0).Item(26 + i).ToString = "NA"
                Selecinado = 3
            End If

            CType(Guia.Parent.FindControl("SEL" & Valor), DropDownList).SelectedValue = Selecinado


            If x.GetTipoPonderacion(Session("Guia")) = 1 Then

                If CType(Guia.Parent.FindControl("SEL" & Valor), DropDownList).SelectedItem.Value = 1 Then
                    CType(Guia.Parent.FindControl("Obtenido" & Valor), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & Valor), TextBox).Text
                    CType(Guia.Parent.FindControl("Posible" & Valor), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & Valor), TextBox).Text
                ElseIf CType(Guia.Parent.FindControl("SEL" & Valor), DropDownList).SelectedItem.Value = 2 Then
                    CType(Guia.Parent.FindControl("Obtenido" & Valor), TextBox).Text = 0
                    CType(Guia.Parent.FindControl("Posible" & Valor), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & Valor), TextBox).Text
                ElseIf CType(Guia.Parent.FindControl("SEL" & Valor), DropDownList).SelectedItem.Value = 3 Then
                    CType(Guia.Parent.FindControl("Obtenido" & Valor), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & Valor), TextBox).Text
                    CType(Guia.Parent.FindControl("Posible" & Valor), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & Valor), TextBox).Text
                End If

            ElseIf x.GetTipoPonderacion(Session("Guia")) = 2 Then

                If CType(Guia.Parent.FindControl("SEL" & Valor), DropDownList).SelectedItem.Value = 1 Then
                    CType(Guia.Parent.FindControl("Obtenido" & Valor), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & Valor), TextBox).Text
                    CType(Guia.Parent.FindControl("Posible" & Valor), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & Valor), TextBox).Text
                ElseIf CType(Guia.Parent.FindControl("SEL" & Valor), DropDownList).SelectedItem.Value = 2 Then
                    CType(Guia.Parent.FindControl("Obtenido" & Valor), TextBox).Text = 0
                    CType(Guia.Parent.FindControl("Posible" & Valor), TextBox).Text = CType(Guia.Parent.FindControl("Valor" & Valor), TextBox).Text
                ElseIf CType(Guia.Parent.FindControl("SEL" & Valor), DropDownList).SelectedItem.Value = 3 Then
                    CType(Guia.Parent.FindControl("Obtenido" & Valor), TextBox).Text = 0
                    CType(Guia.Parent.FindControl("Posible" & Valor), TextBox).Text = 0
                End If

            End If


        Next



    End Sub

    Sub Cambiale(ByVal sender As Object, ByVal e As EventArgs)
        Dim SEL As DropDownList = DirectCast(sender, DropDownList)

        CambiaHidden()

        SumaTextBoxOK()
    End Sub

    Sub SumaTextBoxOK()

        Try

            Session("CuentaValor") = 0
            Session("CuentaPosible") = 0
            Session("CuentaObtenido") = 0
            Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            Dim ds As New System.Data.DataSet
            Dim cmd As SqlCommand = New SqlCommand("SELECT c.Subrubro,a.Rubro,a.ponderacion from (SELECT * FROM [QA].[dbo].[SYS_Guias] WHERE guia = '" & Session("Guia") & "') a LEFT JOIN QA.DBO.SYS_Rubros b ON A.CATEGORIA = b.ID LEFT JOIN QA.DBO.SYS_Subrubros c ON A.RUBRO = c.ID WHERE a.Rubro <>0", conexion)

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





            Dato7.Text = Decimal.Round((Session("CuentaObtenido") / Session("CuentaPosible") * 100), 2) & "%"
            Session("Calificacion") = Decimal.Round((Session("CuentaObtenido") / Session("CuentaPosible") * 100), 2)



        Catch ex As Exception
            Dato7.Text = "-"
        End Try


    End Sub

End Class