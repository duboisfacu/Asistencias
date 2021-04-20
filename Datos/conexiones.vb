Imports System.Data
Imports System.Data.OleDb

Public Class conexiones

    Private strConexion_ As String
    Private conexion_ As OleDbConnection

    Public Property strConexion() As String
        Get
            Return strConexion_
        End Get
        Set(ByVal value As String)
            strConexion_ = value
        End Set
    End Property

    Public Property conexion() As OleDbConnection
        Get
            Return conexion_
        End Get
        Set(ByVal value As OleDbConnection)
            conexion_ = value
        End Set
    End Property

    Public Sub Abrir()
        Try
            strConexion_ = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;"
            conexion_ = New OleDbConnection(strConexion)
            conexion.Open()
        Catch ex As InvalidOperationException
            MsgBox("La base ya está abierta")
        Catch ex As OleDbException
            MsgBox("Hay un problema con la cadena")
        End Try
    End Sub

    Public Sub Cerrar()
        conexion_.Close()
    End Sub

End Class
