
Public Class MenuEdicion
    Inherits System.Web.UI.Page

    Dim x As New Funciones

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            x.FillCampañas(DropDownList1, False)
        End If



    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        x.FillDependiente(DropDownList1, DropDownList2)
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session("GuiaSeleccionada") = DropDownList2.SelectedItem.Text
        Response.Redirect("Modificar_Ponderacion.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Session("GuiaSeleccionada") = DropDownList2.SelectedItem.Text
        Response.Redirect("Editar_Rubros.aspx")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Session("GuiaSeleccionada") = DropDownList2.SelectedItem.Text
        Response.Redirect("Agregar_Rubros.aspx")
    End Sub
End Class