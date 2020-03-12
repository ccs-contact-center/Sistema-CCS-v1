Public Class Agente
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Enabled = False
    End Sub

    Public Property Horas As TextBox
        Get
            Return TextBox1
        End Get
        Set
            TextBox1 = Horas
        End Set

    End Property

    Public Property Comentario As TextBox
        Get
            Return TextBox2
        End Get
        Set
            TextBox2 = Comentario
        End Set

    End Property



    Public Property Tablita As Table
        Get
            Return Table1
        End Get
        Set
            Table1 = Tablita
        End Set

    End Property


    Public Property IDACD() As Label
        Get
            Return Label1
        End Get
        Set
            Label1 = IDACD
        End Set
    End Property

    Public Property Nombre() As Label
        Get
            Return Label2
        End Get
        Set
            Label2 = Nombre
        End Set
    End Property

    Public Property Conexion() As Label
        Get
            Return Label3
        End Get
        Set
            Label3 = Conexion
        End Set
    End Property

    Public Property Seleccion() As HiddenField
        Get
            Return HiddenField1
        End Get
        Set
            HiddenField1 = Seleccion
        End Set
    End Property

    Public Property CNXSegundos() As HiddenField
        Get
            Return HiddenField2
        End Get
        Set
            HiddenField2 = CNXSegundos
        End Set
    End Property

    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Enabled = True
        HiddenField1.Value = "A"
    End Sub

    Protected Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Text = ""
        HiddenField1.Value = "F"
    End Sub

    Protected Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Text = ""
        HiddenField1.Value = "FJ"
    End Sub

    Protected Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TextBox1.Enabled = True
        HiddenField1.Value = "D"
    End Sub

    Protected Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TextBox1.Text = ""
        HiddenField1.Value = "I"
    End Sub

    Protected Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        TextBox1.Text = ""
        HiddenField1.Value = "PC"
    End Sub

    Protected Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        TextBox1.Text = ""
        HiddenField1.Value = "PS"
    End Sub

    Protected Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        TextBox1.Text = ""
        HiddenField1.Value = "V"
    End Sub

    Protected Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        TextBox1.Enabled = True
        HiddenField1.Value = "PJ"
    End Sub


End Class