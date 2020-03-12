Imports System.Data.SqlClient
Public Class Selecciona_Evaluacion
    Inherits System.Web.UI.Page

    Dim x As New Funciones

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            ListaEvaluaciones()
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
            Session("evaluacion") = String.Format("{1}", e.CommandArgument, GridView1.Rows(Convert.ToInt32(e.CommandArgument)).Cells(0).Text)
            Response.Redirect("./Aplicar_Evaluacion.aspx")
        End If


    End Sub





    Sub ListaEvaluaciones()


        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT DISTINCT a.nombre_evaluacion as 'Evaluacion',c.tipo as Tipo,ISNULL(d.campania,'Todos') as Campaña,a.time_limit/60 as Minutos FROM Capacitacion.dbo.SYS_Evaluaciones a  LEFT JOIN  (SELECT DISTINCT agente,evaluacion,tipo,campania FROM Capacitacion.dbo.SYS_Resultados WHERE agente = '" & x.GetUserID(Request.Cookies("Usersettings")("Username")) & "') b ON a.nombre_evaluacion = b.evaluacion AND a.tipo_evaluacion = b.tipo AND CONVERT(NVARCHAR(MAX),a.campania) = CONVERT(NVARCHAR(MAX),b.campania) LEFT JOIN Capacitacion.dbo.SYS_Tipos c on a.tipo_evaluacion = c.id LEFT JOIN CCS.dbo.SYS_campanias d ON CONVERT(NVARCHAR(MAX),a.campania) = CONVERT(NVARCHAR(MAX),d.id) WHERE b.agente IS NULL AND a.status= 1 AND (a.campania ='X' OR a.campania = '" & Request.Cookies("Usersettings")("Campania") & "')"
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






End Class