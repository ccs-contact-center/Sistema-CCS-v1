Imports System.Data.SqlClient
Public Class Semaforo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load



        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT DISTINCT campania, id FROM SYS_campanias_V2 WHERE modo = 0 AND id <9999  AND skill IS NOT NULL ORDER BY campania"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        If Not IsPostBack Then

            DropDownList3.SelectedIndex = 5

            DropDownList1.Items.Add(New ListItem("--Selecciona Campaña--", ""))
            DropDownList2.Items.Add(New ListItem("--Selecciona Skill--", ""))
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

    Private Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

        Label1.Text = "-"
        Label2.Text = "-"
        Label3.Text = "-"
        Label4.Text = "-"

        Label5.Text = "-"
        Label6.Text = "-"
        Label7.Text = "-"
        Label8.Text = "-"

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "select id_Campania, Skill, Server from SYS_Campanias_V2 where id=@id and modo =0 AND status = 1"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        DropDownList2.Items.Clear()
        DropDownList2.Items.Add(New ListItem("--Selecciona Skill--", ""))
        DropDownList2.AppendDataBoundItems = True

        cmd.Parameters.AddWithValue("@id", DropDownList1.SelectedItem.Value)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strQuery
        cmd.Connection = con

        con.Open()

        DropDownList2.DataSource = cmd.ExecuteReader()
        DropDownList2.DataTextField = "Skill"
        DropDownList2.DataValueField = "Skill"
        DropDownList2.DataBind()

        con.Close()
        con.Dispose()

        Session("Skill") = DropDownList2.SelectedValue

    End Sub

    Private Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged

        Label1.Text = "-"
        Label2.Text = "-"
        Label3.Text = "-"
        Label4.Text = "-"

        Label5.Text = "-"
        Label6.Text = "-"
        Label7.Text = "-"
        Label8.Text = "-"

        Session("Skill") = DropDownList2.SelectedValue
        Session("Server") = Funciones.GetServer()

        Refresh()

    End Sub

    Private Sub DropDownList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList3.SelectedIndexChanged

        Label1.Text = "-"
        Label2.Text = "-"
        Label3.Text = "-"
        Label4.Text = "-"

        Label5.Text = "-"
        Label6.Text = "-"
        Label7.Text = "-"
        Label8.Text = "-"

        Session("Skill") = DropDownList2.SelectedValue
        Session("Server") = Funciones.GetServer()

        Refresh()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Refresh()

    End Sub

    Sub Refresh()

        Timer1.Interval = DropDownList3.SelectedValue

        Dim cn As New Funciones
        Dim dsbases As New System.Data.DataSet

        On Error Resume Next

        If Session("Server") = 1 Then
            dsbases = cn.mitacd1()
        ElseIf Session("Server") = 2 Then
            dsbases = cn.mitacd2()
        ElseIf Session("Server") = 3 Then
            dsbases = cn.mitacd3
        End If


        Dim aba As String

        If dsbases.Tables(0).Rows(0).Item(3).ToString = 0 Then
            aba = "0.0%"
        Else
            aba = Format((dsbases.Tables(0).Rows(0).Item(5).ToString / dsbases.Tables(0).Rows(0).Item(3).ToString), "0.0%")
        End If


        If (dsbases.Tables(0).Rows(0).Item(5).ToString / dsbases.Tables(0).Rows(0).Item(3).ToString) > 0.05 Then
            Label5.BackColor = Drawing.ColorTranslator.FromHtml("#C00327")
            Label5.ForeColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
        Else
            Label5.BackColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
            Label5.ForeColor = Drawing.ColorTranslator.FromHtml("#000000")
        End If

        Dim slv As String
        If dsbases.Tables(0).Rows(0).Item(3).ToString > 0 And dsbases.Tables(0).Rows(0).Item(6).ToString = 0 Then
            slv = "0.0%"
        Else
            slv = Format((dsbases.Tables(0).Rows(0).Item(6).ToString / dsbases.Tables(0).Rows(0).Item(4).ToString), "0.0%")
        End If




        If (dsbases.Tables(0).Rows(0).Item(6).ToString / dsbases.Tables(0).Rows(0).Item(4).ToString) < 0.8 Then
            Label6.BackColor = Drawing.ColorTranslator.FromHtml("#C00327")
            Label6.ForeColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
        Else
            Label6.BackColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
            Label6.ForeColor = Drawing.ColorTranslator.FromHtml("#000000")
        End If


        Label1.Text = dsbases.Tables(0).Rows(0).Item(3).ToString
        Label2.Text = dsbases.Tables(0).Rows(0).Item(4).ToString
        Label3.Text = dsbases.Tables(0).Rows(0).Item(5).ToString
        Label4.Text = dsbases.Tables(0).Rows(0).Item(6).ToString

        Label5.Text = aba
        Label6.Text = slv

        Label7.Text = CInt(dsbases.Tables(0).Rows(0).Item(8).ToString)
        Label8.Text = CInt(dsbases.Tables(0).Rows(0).Item(7).ToString)

        Label9.Text = "Actualizacion a las : " & Format(Now, "hh:mm:ss tt")

        Chart1.Legends.Add("Leyenda")
        Chart1.Legends("Leyenda").DockedToChartArea = "ChartArea1"
        Chart1.Series.Add("Series1")
        Chart1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Chart1.Series("Series1").Points.AddY(dsbases.Tables(0).Rows(0).Item(4).ToString)
        Chart1.Series("Series1").Points.AddY(dsbases.Tables(0).Rows(0).Item(5).ToString)
        Chart1.Series("Series1").Points(0).Label = dsbases.Tables(0).Rows(0).Item(4).ToString
        Chart1.Series("Series1").Points(1).Label = dsbases.Tables(0).Rows(0).Item(5).ToString
        Chart1.Series("Series1").Points(0).LegendText = "Atendidas"
        Chart1.Series("Series1").Points(1).LegendText = "Abandonadas"
        Chart1.Series("Series1").Points(0).Color = Drawing.ColorTranslator.FromHtml("#999")
        Chart1.Series("Series1").Points(1).Color = Drawing.ColorTranslator.FromHtml("#C00327")
        Chart1.Series("Series1").ChartArea = "ChartArea1"

        Chart2.Series.Add("Series1")
        Chart2.ChartAreas("ChartArea1").AxisY.Enabled = DataVisualization.Charting.AxisEnabled.False
        Chart2.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
        Chart2.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Column
        Chart2.Series("Series1").Points.AddY(dsbases.Tables(0).Rows(0).Item(5).ToString / dsbases.Tables(0).Rows(0).Item(3).ToString)
        Chart2.Series("Series1").Points.AddY(dsbases.Tables(0).Rows(0).Item(6).ToString / dsbases.Tables(0).Rows(0).Item(4).ToString)
        Chart2.Series("Series1").Points(0).Label = Label5.Text
        Chart2.Series("Series1").Points(1).Label = Label6.Text
        Chart2.Series("Series1").Points(0).AxisLabel = "% ABA"
        Chart2.Series("Series1").Points(1).AxisLabel = "% SLV"
        Chart2.Series("Series1").Points(0).Color = Drawing.ColorTranslator.FromHtml("#999")
        Chart2.Series("Series1").Points(1).Color = Drawing.ColorTranslator.FromHtml("#C00327")
        Chart2.Series("Series1").ChartArea = "ChartArea1"


        Chart3.Series.Add("Series1")
        Chart3.ChartAreas("ChartArea1").AxisY.Enabled = DataVisualization.Charting.AxisEnabled.False
        Chart3.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
        Chart3.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Chart3.Series("Series1").Points.AddY(CInt(dsbases.Tables(0).Rows(0).Item(7).ToString))
        Chart3.Series("Series1").Points.AddY(CInt(dsbases.Tables(0).Rows(0).Item(8).ToString))
        Chart3.Series("Series1").Points(0).Label = Label8.Text
        Chart3.Series("Series1").Points(1).Label = Label7.Text
        Chart3.Series("Series1").Points(0).AxisLabel = "ASA"
        Chart3.Series("Series1").Points(1).AxisLabel = "AHT"
        Chart3.Series("Series1").Points(0).Color = Drawing.ColorTranslator.FromHtml("#999")
        Chart3.Series("Series1").Points(1).Color = Drawing.ColorTranslator.FromHtml("#C00327")
        Chart3.Series("Series1").ChartArea = "ChartArea1"


        If Session("Server") = 1 Then
            GridView1.DataSource = cn.mitacd1ID
            GridView1.DataBind()
        ElseIf Session("Server") = 2 Then
            GridView1.DataSource = cn.mitacd2ID
            GridView1.DataBind()
        ElseIf Session("Server") = 3 Then
            GridView1.DataSource = cn.mitacd3ID
            GridView1.DataBind()
        End If



    End Sub

End Class