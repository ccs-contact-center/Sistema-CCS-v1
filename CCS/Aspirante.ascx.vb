Imports System.Data.SqlClient
Public Class Aspirante1
    Inherits System.Web.UI.UserControl


    Public Property Tablita As Table
        Get
            Return Table1
        End Get
        Set
            Table1 = Tablita
        End Set

    End Property


    Public Property Nombre As TextBox
        Get
            Return TextBox1
        End Get
        Set
            TextBox1 = Nombre
        End Set
    End Property

    Public Property Paterno As TextBox
        Get
            Return TextBox2
        End Get
        Set
            TextBox2 = Paterno
        End Set
    End Property

    Public Property Materno As TextBox
        Get
            Return TextBox3
        End Get
        Set
            TextBox3 = Materno
        End Set
    End Property

    Public Property Telefono As TextBox
        Get
            Return TextBox4
        End Get
        Set
            TextBox4 = Telefono
        End Set
    End Property

    Public Property Campania As DropDownList
        Get
            Return DropDownList5
        End Get
        Set
            DropDownList5 = Campania
        End Set
    End Property


    Public Property Entrada As DropDownList
        Get
            Return DropDownList1
        End Get
        Set
            DropDownList1 = Entrada
        End Set
    End Property

    Public Property Salida As DropDownList
        Get
            Return DropDownList2
        End Get
        Set
            DropDownList2 = Salida
        End Set
    End Property

    Public Property EntradaCAP As DropDownList
        Get
            Return DropDownList3
        End Get
        Set
            DropDownList3 = EntradaCAP
        End Set
    End Property

    Public Property SalidaCAP As DropDownList
        Get
            Return DropDownList4
        End Get
        Set
            DropDownList4 = SalidaCAP
        End Set
    End Property

    Private Sub Aspirante1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Combo1()
    End Sub

    Sub Combo1()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "Select id, campania FROM SYS_campanias"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()


        If Not IsPostBack Then

            DropDownList5.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList5.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList5.DataSource = cmd.ExecuteReader()
            DropDownList5.DataTextField = "campania"
            DropDownList5.DataValueField = "id"
            DropDownList5.DataBind()

            con.Close()
            con.Dispose()

        End If

    End Sub
End Class