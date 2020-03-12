Imports System.Data.SqlClient
Public Class Resumen
    Inherits System.Web.UI.Page

    Dim x As New Funciones

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If x.GetUserArea(Request.Cookies("UserSettings")("Username")) = 0 Then
            LoadResumenOP()
        Else
            LoadResumenQA()
        End If
    End Sub

    Sub LoadResumenOP()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("
            SELECT a.id_acd1 as ID,b.nombres + ' ' + b.paterno + ' ' + b.materno as Nombre	,c.nombres + ' ' + c.paterno as Analista,CONVERT(VARCHAR(MAX),CONVERT(DECIMAL(4,2),calificacion_semana_anterior)) +'%' as 'Calificación Anterior',nivel_semana_anterior as 'Nivel Anterior',CONVERT(VARCHAR(MAX),CONVERT(DECIMAL(4,2),calificacion_semana_actual))+'%' as 'Calificación Actual' ,nivel_semana_actual as 'Nivel Actual',monitoreos_semana_actual as 'Monitoreos Actual',retros_semana_actual as 'Retros Actual' FROM QA.dbo.SYS_Resumen_Agentes a LEFT JOIN CCS.dbo.SYS_empleados b ON a.id = b.id LEFT JOIN CCS.dbo.SYS_empleados c ON a.analista = c.id WHERE a.jefe_directo =" & x.GetUserID(Request.Cookies("UserSettings")("Username")), conexion)


        conexion.Open()
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))

        Dim tabla As New Table
        Dim fila As New TableRow
        For i = 1 To 9


            Dim celda As New TableCell
            celda.BorderWidth = 1
            celda.CssClass = "TablaRubros2"

            If i = 1 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "ID"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 2 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Agente"
                celda.Width = 200
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 3 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Analista"
                celda.Width = 200
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 4 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Nivel Anterior"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 5 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Calificacion Anterior"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 6 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Nivel Actual"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 7 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Calificación Actual"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 8 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Monitoreos"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 9 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Retros"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            Else
            End If

            tabla.Rows.Add(fila)
        Next
        ''''''''''''''''''''''''''''''''''''''''''
        For Agente = 1 To ds.Tables(0).Rows.Count

            Dim D1, D2, D3, D4, D5, D6, D7, D8, D9 As String
            Dim FilaSR As New TableRow

            D1 = ds.Tables(0).Rows(Agente - 1).Item(0).ToString
            D2 = ds.Tables(0).Rows(Agente - 1).Item(1).ToString
            D3 = ds.Tables(0).Rows(Agente - 1).Item(2).ToString
            D4 = ds.Tables(0).Rows(Agente - 1).Item(3).ToString
            D5 = ds.Tables(0).Rows(Agente - 1).Item(5).ToString
            D6 = ds.Tables(0).Rows(Agente - 1).Item(4).ToString
            D7 = ds.Tables(0).Rows(Agente - 1).Item(6).ToString
            D8 = ds.Tables(0).Rows(Agente - 1).Item(7).ToString
            D9 = ds.Tables(0).Rows(Agente - 1).Item(8).ToString



            For j = 1 To 9
                Dim Ncelda As New TableCell
                Ncelda.BorderWidth = 1


                If j = 1 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D1
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 2 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D2
                    label.Width = 200
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 3 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D3
                    label.Width = 200
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 4 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D4
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 5 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D5
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 6 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D6
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 7 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D7
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 8 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D8
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 9 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D9
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                Else
                End If
            Next
            tabla.Rows.Add(FilaSR)

        Next
        ''''''''''''''''''''''''''''''''''''''''''


        Panel2.Controls.Add(tabla)



    End Sub

    Sub LoadResumenQA()

        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ToString)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New System.Data.DataSet
        Dim cmd As SqlCommand = New SqlCommand("SET DATEFIRST 1

                SELECT 
                a.agente as ID,
                b.nombres + ' ' + b.paterno + ' ' + b.materno as Nombre,
                c.campania as Campaña,
				a.ABC,
                SUM(CASE WHEN Semana_Objetivo = DATEPART(WEEK,GETDATE()) THEN Objetivo ELSE 0 END) as Objetivo,
                ISNULL(Monitoreos.Monitoreos1,0) as Monitoreos 

                FROM (SELECT a.agente,a.analista,semana_monitoreo + 1 as Semana_Objetivo,[QA].[dbo].GET_Objetivo_Mon([QA].[dbo].[GET_ABC](AVG(calificacion),b.Campania),b.Campania,90) as Objetivo,[QA].[dbo].[GET_ABC](AVG(calificacion),b.Campania) as ABC  FROM QA.dbo.SYS_Monitoreos a LEFT JOIN (SELECT id,CASE WHEN campaña = 16 THEN 2 ELSE 1 END as Campania FROM CCS.dbo.SYS_empleados) b ON a.agente = b.id WHERE DATEPART(year,fecha_monitoreo) >= 2018 AND semana_monitoreo = DATEPART(WEEK,GETDATE()) - 1 /*and b.status IN(2,7)*/  GROUP BY a.analista,agente,semana_monitoreo,b.Campania) as a
                    LEFT JOIN CCS.dbo.SYS_empleados b ON a.agente = b.id
                LEFT JOIN (

                    SELECT a.analista,a.agente,
                    SUM(CASE WHEN semana_monitoreo = 29 THEN 1 ELSE 0 END) as Monitoreos1 
 
                    FROM QA.dbo.SYS_Monitoreos a 
                    LEFT JOIN CCS.dbo.SYS_empleados b ON a.agente = b.id
                    WHERE DATEPART(year,fecha_monitoreo) >= 2018 AND semana_monitoreo >= 29 /*AND b.status in (2,7)*/ GROUP BY a.analista,a.agente

                    ) Monitoreos ON a.analista = Monitoreos.analista AND a.agente=Monitoreos.agente


                    LEFT JOIN CCS.dbo.SYS_campanias c ON b.campaña = c.id
                    WHERE  a.analista = '" & x.GetUserID(Request.Cookies("UserSettings")("Username")) & "' AND b.status in (2,7)
                    GROUP BY a.agente,a.analista,Monitoreos.Monitoreos1,b.nombres + ' ' + b.paterno + ' ' + b.materno,c.campania,a.ABC
                    ORDER BY c.campania
                    ", conexion)


        cmd.CommandTimeout = 1800

        conexion.Open()

        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        ds.Tables.Add()
        da.Fill(ds.Tables(0))

        Dim tabla As New Table
        Dim fila As New TableRow
        For i = 1 To 9


            Dim celda As New TableCell
            celda.BorderWidth = 1
            celda.CssClass = "TablaRubros2"

            If i = 1 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "ID"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 2 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Agente"
                celda.Width = 200
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 3 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Campaña"
                celda.Width = 200
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 4 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "ABC"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 5 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Objetivo"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            ElseIf i = 6 Then
                Dim label As New Label
                label.ID = "Titulo" & i
                label.Text = "Monitoreos"
                celda.Controls.Add(label)
                fila.Cells.Add(celda)
            Else
            End If

            tabla.Rows.Add(fila)
        Next
        ''''''''''''''''''''''''''''''''''''''''''
        For Agente = 1 To ds.Tables(0).Rows.Count

            Dim D1, D2, D3, D4, D5, D6, D7, D8, D9 As String
            Dim FilaSR As New TableRow

            D1 = ds.Tables(0).Rows(Agente - 1).Item(0).ToString
            D2 = ds.Tables(0).Rows(Agente - 1).Item(1).ToString
            D3 = ds.Tables(0).Rows(Agente - 1).Item(2).ToString
            D4 = ds.Tables(0).Rows(Agente - 1).Item(3).ToString
            D5 = ds.Tables(0).Rows(Agente - 1).Item(4).ToString
            D6 = ds.Tables(0).Rows(Agente - 1).Item(5).ToString



            For j = 1 To 9
                Dim Ncelda As New TableCell
                Ncelda.BorderWidth = 1


                If j = 1 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D1
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 2 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D2
                    label.Width = 200
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 3 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D3
                    label.Width = 200
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 4 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D4
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 5 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D5
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)
                ElseIf j = 6 Then
                    Dim label As New Label
                    label.ID = "Agente" & j
                    label.Text = D6
                    Ncelda.CssClass = "TablaCentro"
                    Ncelda.Controls.Add(label)
                    FilaSR.Cells.Add(Ncelda)

                Else
                End If
            Next
            tabla.Rows.Add(FilaSR)

        Next
        ''''''''''''''''''''''''''''''''''''''''''


        Panel2.Controls.Add(tabla)



    End Sub

End Class