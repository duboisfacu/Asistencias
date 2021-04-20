Imports System.Data
Imports System.Data.OleDb

Public Class Profesores
    Inherits conexiones
    Private legajo_ As Integer
    Private nombre_ As String

    Public Property legajo() As Integer
        Get
            Return legajo_

        End Get
        Set(ByVal value As Integer)
            legajo_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Profesor"
        Dim comando As New OleDbCommand(strComando, conexion)
        Dim tabla As New DataTable
        Try
            tabla.Load(comando.ExecuteReader)
            grilla.DataSource = tabla
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Modificar(ByVal prof As Profesores)
        Abrir()
        Dim strComando As String = "UPDATE Profesor SET Nombre=@nombre, Legajo=@legajo " + "WHERE Legajo=@legajo;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", prof.nombre)
        comando.Parameters.AddWithValue("@legajo", legajo)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal prof As Profesores)
        Abrir()
        Dim strComando As String = "INSERT INTO Profesor (Nombre,Legajo) VALUES " & _
        "(@nombre,@legajo);"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", prof.nombre)
        comando.Parameters.AddWithValue("@legajo", prof.legajo)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal Documento As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Profesor WHERE Legajo=@legajo;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@legajo", legajo)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
