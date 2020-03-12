Imports System.Data.SqlClient
Imports System.Web.Script.Serialization
Partial Public Class Nueva_Evaluacion


    Inherits Page
    Dim x As New Funciones
    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String

    Dim Evaluacion As New Evaluacion
    Dim Funciones As New Funciones
    Dim y As New Evaluacion



    Sub FillClass()



        y.Nombre = TextBox1.Text
        y.Tipo = DropDownList1.SelectedItem.Value
        y.Campania = DropDownList2.SelectedItem.Value
        y.Status = 1
        y.Fecha = Format(Today(), "dd/MM/yyyy")
        y.Vencimiento = Format(DateAdd(DateInterval.Day, 30, Today()), "dd/MM/yyyy")
        y.Seconds = TextBox2.Text
        'MsgBox(y.Fecha)
        Dim A, B, C, D, E, F, G, H, J, K As Integer

        A = 3
        B = 4
        C = 5
        D = 6
        E = 7

        F = 1
        G = 2
        H = 3
        J = 4
        K = 5



        For i = 0 To CType(DropDownList3.SelectedItem.Value, Integer) - 1

            y.Reactivos.Add(New Reactivo)
            y.Reactivos(i).ID_Reactivo = i + 1
            y.Reactivos(i).Imagen = 0
            y.Reactivos(i).URL_Imagen = "-"


            y.Reactivos(i).Nombre = CType(RadioButton100.Parent.FindControl("Pregunta" & i + 1), TextBox).Text

            y.Reactivos(i).A = CType(RadioButton100.Parent.FindControl("TextBox" & A), TextBox).Text
            y.Reactivos(i).B = CType(RadioButton100.Parent.FindControl("TextBox" & B), TextBox).Text
            y.Reactivos(i).C = CType(RadioButton100.Parent.FindControl("TextBox" & C), TextBox).Text
            y.Reactivos(i).D = CType(RadioButton100.Parent.FindControl("TextBox" & D), TextBox).Text
            y.Reactivos(i).E = CType(RadioButton100.Parent.FindControl("TextBox" & E), TextBox).Text

            y.Reactivos(i).Correcta = CType(RadioButton100.Parent.FindControl("RadioButtonList" & i + 1), RadioButtonList).Text

            'If CType(RadioButton100.Parent.FindControl("RadioButton" & F), RadioButton).Checked = True Then
            '    y.Reactivos(i).Correcta = CType(RadioButton100.Parent.FindControl("RadioButton" & F), RadioButton).Text
            'ElseIf CType(RadioButton100.Parent.FindControl("RadioButton" & G), RadioButton).Checked = True Then
            '    y.Reactivos(i).Correcta = CType(RadioButton100.Parent.FindControl("RadioButton" & G), RadioButton).Text
            'ElseIf CType(RadioButton100.Parent.FindControl("RadioButton" & H), RadioButton).Checked = True Then
            '    y.Reactivos(i).Correcta = CType(RadioButton100.Parent.FindControl("RadioButton" & H), RadioButton).Text
            'ElseIf CType(RadioButton100.Parent.FindControl("RadioButton" & J), RadioButton).Checked = True Then
            '    y.Reactivos(i).Correcta = CType(RadioButton100.Parent.FindControl("RadioButton" & J), RadioButton).Text
            'ElseIf CType(RadioButton100.Parent.FindControl("RadioButton" & K), RadioButton).Checked = True Then
            '    y.Reactivos(i).Correcta = CType(RadioButton100.Parent.FindControl("RadioButton" & K), RadioButton).Text
            'End If



            A = A + 5
            B = B + 5
            C = C + 5
            D = D + 5
            E = E + 5

            F = F + 5
            G = G + 5
            H = H + 5
            J = J + 5
            K = K + 5

        Next

        Dim jsonSerialiser = New JavaScriptSerializer()
        Dim json = jsonSerialiser.Serialize(y)
        'MsgBox(json)


    End Sub


    Sub Guardar()


        For z = 0 To CType(DropDownList3.SelectedItem.Value, Integer) - 1

            Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
            Dim strQuery As String = "INSERT INTO [Capacitacion].[dbo].[SYS_Evaluaciones] (nombre_evaluacion, tipo_evaluacion, campania, status, id_reactivo, nombre_reactivo,imagen, url_imagen, a,b,c,d,e,correcta, fecha_alta, vence ,time_limit) VALUES ('" &
                                      y.Nombre & "', '" & y.Tipo & "', '" & y.Campania & "', '" & y.Status & "', '" & y.Reactivos(z).ID_Reactivo & "', '" & y.Reactivos(z).Nombre & "', '" & y.Reactivos(z).Imagen & "', '" & y.Reactivos(z).URL_Imagen & "', '" & y.Reactivos(z).A & "', '" & y.Reactivos(z).B & "', '" & y.Reactivos(z).C & "', '" & y.Reactivos(z).D & "', '" & y.Reactivos(z).E & "', '" & y.Reactivos(z).Correcta & "', '" & y.Fecha & "', '" & y.Vencimiento & "', '" & CType(y.Seconds, Integer) * 60 & "')"
            Dim con As New SqlConnection(strConnString)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            con.Dispose()

        Next


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If HiddenField1.Value = 1 Then

            HiddenField1.Value = HiddenField1.Value + 1
            Evaluacion.Tipo = DropDownList1.SelectedItem.Value
            Evaluacion.Nombre = TextBox1.Text

            Alta1.Visible = False
            Alta2.Visible = True
            Button1.Visible = True

        ElseIf HiddenField1.Value = 2 Then

            HiddenField1.Value = HiddenField1.Value + 1

            Alta2.Visible = False
            evalu.Visible = True


            For i = 1 To CType(DropDownList3.SelectedItem.Value, Integer)
                RadioButton100.Parent.FindControl("R" & i).Visible = True

            Next



        ElseIf HiddenField1.Value = 3 Then

            HiddenField1.Value = HiddenField1.Value + 1
            evalu.Visible = False
            preview.Visible = True
            Alta1.Visible = True
            Alta2.Visible = True
            DropDownList1.Enabled = False
            DropDownList2.Enabled = False
            DropDownList3.Enabled = False
            DropDownList4.Enabled = False
            TextBox1.Enabled = False
            TextBox2.Enabled = False


            FillClass()


            Dim RA, RB, RC, RD, RE As Integer

            RA = 101
            RB = 102
            RC = 103
            RD = 104
            RE = 105


            For i = 1 To CType(DropDownList3.SelectedItem.Value, Integer)


                RadioButton100.Parent.FindControl("PV" & i).Visible = True
                CType(RadioButton100.Parent.FindControl("Label" & 107 + i), Label).Text = y.Reactivos(i - 1).Nombre


                For z = 1 To 5

                    If z = 1 Then
                        CType(RadioButton100.Parent.FindControl("RadioButton" & RA), RadioButton).Text = y.Reactivos(i - 1).A
                        If y.Reactivos(i - 1).Correcta = "A" Then
                            CType(RadioButton100.Parent.FindControl("RadioButton" & RA), RadioButton).Checked = True
                        End If
                    ElseIf z = 2 Then
                        CType(RadioButton100.Parent.FindControl("RadioButton" & RB), RadioButton).Text = y.Reactivos(i - 1).B
                        If y.Reactivos(i - 1).Correcta = "B" Then
                            CType(RadioButton100.Parent.FindControl("RadioButton" & RB), RadioButton).Checked = True
                        End If
                    ElseIf z = 3 Then
                        CType(RadioButton100.Parent.FindControl("RadioButton" & RC), RadioButton).Text = y.Reactivos(i - 1).C
                        If y.Reactivos(i - 1).Correcta = "C" Then
                            CType(RadioButton100.Parent.FindControl("RadioButton" & RC), RadioButton).Checked = True
                        End If
                    ElseIf z = 4 Then
                        CType(RadioButton100.Parent.FindControl("RadioButton" & RD), RadioButton).Text = y.Reactivos(i - 1).D
                        If y.Reactivos(i - 1).Correcta = "D" Then
                            CType(RadioButton100.Parent.FindControl("RadioButton" & RD), RadioButton).Checked = True
                        End If
                    ElseIf z = 5 Then
                        CType(RadioButton100.Parent.FindControl("RadioButton" & RE), RadioButton).Text = y.Reactivos(i - 1).E
                        If y.Reactivos(i - 1).Correcta = "E" Then
                            CType(RadioButton100.Parent.FindControl("RadioButton" & RE), RadioButton).Checked = True
                        End If
                    End If
                Next


                RA = RA + 5
                RB = RB + 5
                RC = RC + 5
                RD = RD + 5
                RE = RE + 5

            Next


            Button2.Text = "Guardar"


        ElseIf HiddenField1.Value = 4 Then

            FillClass()
            Guardar()
            Response.Redirect("./Nueva_Evaluacion.aspx")

        End If







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If HiddenField1.Value = 1 Then

        ElseIf HiddenField1.Value = 2 Then
            HiddenField1.Value = HiddenField1.Value - 1
            Evaluacion.Tipo = DropDownList1.SelectedItem.Value
            Evaluacion.Nombre = TextBox1.Text
            Alta1.Visible = True
            Alta2.Visible = False
            Button1.Visible = False

        ElseIf HiddenField1.Value = 3 Then
            HiddenField1.Value = HiddenField1.Value - 1

            evalu.Visible = False
            Alta2.Visible = True


        ElseIf HiddenField1.Value = 4 Then

            HiddenField1.Value = HiddenField1.Value - 1

            Alta1.Visible = False
            Alta2.Visible = False
            DropDownList1.Enabled = True
            DropDownList2.Enabled = True
            DropDownList3.Enabled = True
            DropDownList4.Enabled = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            preview.Visible = False
            evalu.Visible = True

            Button2.Text = "Siguiente"


        End If

    End Sub

    Private Sub Nueva_Evaluacion_Load(sender As Object, e As EventArgs) Handles Me.Load




        If Not IsPostBack Then
            Funciones.FillCampañas(DropDownList2, True)
        End If


        If HiddenField1.Value = 1 Then

        ElseIf HiddenField1.Value = 2 Then

        ElseIf HiddenField1.Value = 3 Then

        ElseIf HiddenField1.Value = 4 Then


        End If


    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList4.SelectedIndexChanged
        If DropDownList4.SelectedValue = 1 Then
            TextBox2.Enabled = True
            TextBox2.Text = Nothing
            RangeValidator1.Enabled = True
            RequiredFieldValidator6.Enabled = True
        Else
            TextBox2.Enabled = False
            TextBox2.Text = 0
            RangeValidator1.Enabled = False
            RequiredFieldValidator6.Enabled = False
        End If



    End Sub
End Class



Public Class Evaluacion

    Private _nombre, _tipo, _campania As String
    Private _status As Integer
    Private _fecha, _vencimiento As Date
    Private _seconds As Integer

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    Public Property Campania() As String
        Get
            Return _campania
        End Get
        Set(ByVal value As String)
            _campania = value
        End Set
    End Property

    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal value As Integer)
            _status = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Vencimiento() As Date
        Get
            Return _vencimiento
        End Get
        Set(ByVal value As Date)
            _vencimiento = value
        End Set
    End Property

    Public Property Seconds() As Integer
        Get
            Return _seconds
        End Get
        Set(ByVal value As Integer)
            _seconds = value
        End Set
    End Property


    Public Property Reactivos As List(Of Reactivo) = New List(Of Reactivo)

End Class

Public Class Reactivo

    Private _id As Integer
    Private _imagen As Integer
    Private _nombre, _url_imagen, _a, _b, _c, _d, _e, _correcto As String


    Public Property ID_Reactivo() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Imagen() As Integer
        Get
            Return _imagen
        End Get
        Set(ByVal value As Integer)
            _imagen = value
        End Set
    End Property
    Public Property URL_Imagen() As String
        Get
            Return _url_imagen
        End Get
        Set(ByVal value As String)
            _url_imagen = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Public Property A() As String
        Get
            Return _a
        End Get
        Set(ByVal value As String)
            _a = value
        End Set
    End Property

    Public Property B() As String
        Get
            Return _b
        End Get
        Set(ByVal value As String)
            _b = value
        End Set
    End Property

    Public Property C() As String
        Get
            Return _c
        End Get
        Set(ByVal value As String)
            _c = value
        End Set
    End Property

    Public Property D() As String
        Get
            Return _d
        End Get
        Set(ByVal value As String)
            _d = value
        End Set
    End Property

    Public Property E() As String
        Get
            Return _e
        End Get
        Set(ByVal value As String)
            _e = value
        End Set
    End Property

    Public Property Correcta() As String
        Get
            Return _correcto
        End Get
        Set(ByVal value As String)
            _correcto = value
        End Set
    End Property

End Class