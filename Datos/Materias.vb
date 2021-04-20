Imports System.Data
Imports System.Data.OleDb

Public Class Materias
    Inherits conexiones

    Private id_ As Integer
    Private nombre_ As String
    Private idProfe_ As Integer
    Private idCarrera_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
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

    Public Property idProfe() As Integer
        Get
            Return idProfe_
        End Get
        Set(ByVal value As Integer)
            idProfe_ = value
        End Set
    End Property

    Public Property idCarrera() As Integer
        Get
            Return idCarrera_
        End Get
        Set(ByVal value As Integer)
            idCarrera_ = value
        End Set
    End Property

    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Materias"
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

    Public Sub Modificar(ByVal mat As Materias)
        Abrir()
        Dim strComando As String = "UPDATE Materias SET Nombre=@nombre, id=@id, idProfesor=@idprofesor, IdCarrera=@idcarrera " + "WHERE id=@id;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", mat.nombre)
        comando.Parameters.AddWithValue("@id", mat.id)
        comando.Parameters.AddWithValue("@idprofesor", mat.idProfe)
        comando.Parameters.AddWithValue("@idcarrera", mat.idCarrera)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal mat As Materias)
        Abrir()
        Dim strComando As String = "INSERT INTO Materias (Nombre,idProfesor,IdCarrera,id) VALUES " & _
        "(@nombre,@idprofesor,@idcarrera,@id);"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", mat.nombre)
        comando.Parameters.AddWithValue("@idprofesor", mat.idProfe)
        comando.Parameters.AddWithValue("@idcarrera", mat.idCarrera)
        comando.Parameters.AddWithValue("@id", mat.id)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal Documento As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Materias WHERE Id=@id;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@id", id)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
