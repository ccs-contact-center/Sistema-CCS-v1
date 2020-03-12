Imports System.Data.SqlClient
Public Class TroncoComun
    Inherits System.Web.UI.UserControl


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Combo1()
        Combo2()

    End Sub

    Sub Combo1()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,campania FROM SYS_campanias"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        If Not IsPostBack Then

            DropDownList1.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList1.Items.Add(New ListItem("-BAJA-", 9999))
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

    Sub Combo2()

        Dim strConnString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
        Dim strQuery As String = "SELECT id,[nombres]+ ' ' +[paterno]+ ' '+[materno] as Nombre, id_ccs FROM SYS_empleados WHERE puesto = '2' AND area = '3' AND Status = '2'"
        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        If Not IsPostBack Then

            DropDownList2.Items.Add(New ListItem("-Selecciona-", 0))
            DropDownList2.Items.Add(New ListItem("-BAJA-", 9999))
            DropDownList2.AppendDataBoundItems = True

            cmd.CommandType = CommandType.Text
            cmd.CommandText = strQuery
            cmd.Connection = con

            con.Open()

            DropDownList2.DataSource = cmd.ExecuteReader()
            DropDownList2.DataTextField = "Nombre"
            DropDownList2.DataValueField = "id_ccs"
            DropDownList2.DataBind()

            con.Close()
            con.Dispose()

        End If
    End Sub


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

    Public Property Grupo As TextBox
        Get
            Return TextBox4
        End Get
        Set
            TextBox4 = Grupo
        End Set
    End Property


    Public Property Instructor As DropDownList
        Get
            Return DropDownList2
        End Get
        Set
            DropDownList2 = Instructor
        End Set
    End Property

    Public Property Campania As DropDownList
        Get
            Return DropDownList1
        End Get
        Set
            DropDownList1 = Campania
        End Set
    End Property

    Public Property Horario As TextBox
        Get
            Return TextBox5
        End Get
        Set
            TextBox5 = Horario
        End Set
    End Property

    Public Property IDBD As HiddenField
        Get
            Return HiddenField1
        End Get
        Set
            HiddenField1 = IDBD
        End Set
    End Property

End Class