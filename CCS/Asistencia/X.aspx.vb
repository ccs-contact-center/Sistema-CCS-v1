Public Class X
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Session("HI") = Request.QueryString("hideindex")
        Response.Redirect("Administracion.aspx")
        Label1.Text = Session("HI")

    End Sub

End Class