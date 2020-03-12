﻿Public Class Login1
    Inherits System.Web.UI.Page

    Dim x As New Funciones

    Private Sub Login2_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login2.Authenticate
        Dim usuariotxt As String
        usuariotxt = Login2.UserName


        Dim Pass As String

        Pass = x.Passcrypt(Login2.Password)
        Session("user") = Login2.UserName

        If Autentificacion.Autenticar(Login2.UserName, Pass) = True Then

            FormsAuthentication.RedirectFromLoginPage(Login2.UserName, Login2.RememberMeSet)

            Response.Cookies("UserSettings")("Username") = Login2.UserName
            Response.Cookies("UserSettings")("SU") = x.GetUserSU(Login2.UserName)
            Response.Cookies("UserSettings")("Area") = x.GetUserArea(Login2.UserName)
            Response.Cookies("UserSettings")("Puesto") = x.GetUserPuesto(Login2.UserName)
            Response.Cookies("UserSettings")("Supervisor") = x.GetUserSupervisor(Login2.UserName)
            Response.Cookies("UserSettings")("MTY") = x.GetUserMTY(Login2.UserName)
            Response.Cookies("UserSettings")("ARA") = x.GetUserARA(Login2.UserName)
            Response.Cookies("UserSettings")("Campania") = x.GetUserCampania(Login2.UserName)

            Response.Redirect("Calidad/Default.aspx")

        End If
    End Sub
End Class