Public Class Seleccionar_Guia
    Inherits System.Web.UI.Page

    Dim x As New Funciones

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            x.FillCampañas(DropDownList1, False)
        End If

        If (Request.Cookies("UserSettings")("Area") = 1 And Request.Cookies("UserSettings")("Puesto") >= 1) Or (Request.Cookies("UserSettings")("Area") = 0 And Request.Cookies("UserSettings")("Puesto") >= 1) Or Request.Cookies("UserSettings")("SU") = True Then
            UpdatePanel1.Visible = True
        Else
            UpdatePanel1.Visible = False
        End If

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        X.FillDependiente(DropDownList1, DropDownList2)
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session("CampaniaSeleccionada") = DropDownList1.SelectedItem.Text
        Session("IDCampaniaSeleccionada") = DropDownList1.SelectedItem.Value
        Session("GuiaSeleccionada") = DropDownList2.SelectedItem.Text
        Session("TipoMonitoreo") = DropDownList3.SelectedItem.Value
        Response.Redirect("Monitoreo.aspx")
    End Sub


End Class