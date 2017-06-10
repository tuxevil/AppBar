Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class Conexion
    Private _DataSource As String
    Private _InitialCatalog As String
    Private _User As String
    Private _Password As String
    Private _conexion1 As New SqlConnection

    Public Sub New()
        _DataSource = "192.168.1.4\SQLEXPRESS"
        _InitialCatalog = "BarDisco"
        _User = "sa"
        _Password = "gotechdev"
    End Sub

#Region "Propiedades"
    Public Property DataSource() As String
        Get
            Return _DataSource
        End Get
        Set(ByVal value As String)
            _DataSource = value
        End Set
    End Property

    Public Property InitialCatalog() As String
        Get
            Return _InitialCatalog
        End Get
        Set(ByVal value As String)
            _InitialCatalog = value
        End Set
    End Property

    Public Property UsuarioDB() As String
        Get
            Return _User
        End Get
        Set(ByVal value As String)
            _User = value
        End Set
    End Property

    Public Property PasswordDB() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Public Property conexion1() As SqlConnection
        Get
            Return _conexion1
        End Get
        Set(ByVal value As SqlConnection)
            _conexion1 = value
        End Set
    End Property

#End Region


    Public Sub conectar(ByVal estado As Boolean)
        Try
            If estado = True Then
                conexion1.ConnectionString = "Data Source='" & Me.DataSource & "';Initial Catalog='" & Me.InitialCatalog & "';User ID='" & Me.UsuarioDB & "';Password='" & Me.PasswordDB & "'"
                conexion1.Open()
            Else
                conexion1.Close()
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class
