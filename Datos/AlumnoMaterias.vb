Imports System.Data
Imports System.Data.OleDb

Public Class AlumnoMaterias
    Inherits conexiones

    Private id_ As Integer
    Private idalumno_ As Integer
    Private idmaterias_ As Integer
    Private nommaterias_ As String
    Private nomalumno_ As String
    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Public Property idalumno() As Integer
        Get
            Return idalumno_
        End Get
        Set(ByVal value As Integer)
            idalumno_ = value
        End Set
    End Property
    Public Property idmaterias() As Integer
        Get
            Return idmaterias_
        End Get
        Set(ByVal value As Integer)
            idmaterias_ = value
        End Set
    End Property
    Public Property nommaterias() As String
        Get
            Return nommaterias_
        End Get
        Set(ByVal value As String)
            nommaterias_ = value
        End Set
    End Property
    Public Property nomalumno() As String
        Get
            Return nomalumno_
        End Get
        Set(ByVal value As String)
            nomalumno_ = value
        End Set
    End Property
    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM AlumnoMaterias"
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

    Public Sub Modificar(ByVal almat As AlumnoMaterias)
        Abrir()
        Dim strComando As String = "UPDATE AlumnoMaterias SET id=@id, idalumno=@idalumno, idmaterias=@idmaterias, nommaterias=@nommaterias, nomalumno=@nomalumno " + "WHERE id=@id;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@id", almat.id)
        comando.Parameters.AddWithValue("@idalumno", almat.idalumno)
        comando.Parameters.AddWithValue("@idmaterias", almat.idmaterias)
        comando.Parameters.AddWithValue("@nommaterias", almat.nommaterias)
        comando.Parameters.AddWithValue("@nomalumno", almat.nomalumno)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal almat As AlumnoMaterias)
        Abrir()
        Dim strComando As String = "INSERT INTO AlumnoMaterias (idalumno, idmaterias, nommaterias, nomalumno) VALUES " & _
        "(@idalumno, @idmaterias, @nommaterias, @nomalumno);"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@idalumno", almat.idalumno)
        comando.Parameters.AddWithValue("@idmaterias", almat.idmaterias)
        comando.Parameters.AddWithValue("@nommaterias", almat.nommaterias)
        comando.Parameters.AddWithValue("@nomalumno", almat.nomalumno)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal Documento As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM AlumnoMaterias WHERE Id=@id;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@id", id)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
