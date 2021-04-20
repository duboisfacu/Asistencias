Imports System.Data
Imports System.Data.OleDb

Public Class Asistencias
    Inherits conexiones
    Private asid_ As Integer
    Private idCarrera_ As Integer
    Private idMateria_ As Integer
    Private Fecha_ As Date
    Private BEG_ As Boolean

    Public Property asid() As Integer
        Get
            Return asid_
        End Get
        Set(ByVal value As Integer)
            asid_ = value
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
    Public Property idMateria() As Integer
        Get
            Return idMateria_
        End Get
        Set(ByVal value As Integer)
            idMateria_ = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property
    Public Property BEG() As Boolean
        Get
            Return BEG_
        End Get
        Set(ByVal value As Boolean)
            BEG_ = value
        End Set
    End Property

    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Alumno"
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

    Public Sub Modificar(ByVal asis As Asistencias)
        Abrir()
        Dim strComando As String = "UPDATE Asistencia SET idcarrera=@idcarrera, idmateria=@idmateria, fecha=@fecha, BEG@beg " + "WHERE id=@id;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@id", asis.asid)
        comando.Parameters.AddWithValue("@idcarrera", asis.idCarrera)
        comando.Parameters.AddWithValue("@idmateria", asis.idMateria)
        comando.Parameters.AddWithValue("@fecha", asis.Fecha)
        comando.Parameters.AddWithValue("@beg", asis.BEG)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal asis As Asistencias)
        Abrir()
        ',BEG,CertificadoTrabajo
        ',@BEG,@certificadotrabajo
        Dim strComando As String = "INSERT INTO Asistencia (idcarrera,idmateria,fecha,BEG) VALUES " & _
        "(@idcarrera,@idmateria,@fecha,@beg);"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@idcarrera", asis.idCarrera)
        comando.Parameters.AddWithValue("@idmateria", asis.idMateria)
        comando.Parameters.AddWithValue("@fecha", asis.Fecha)
        comando.Parameters.AddWithValue("@beg", asis.BEG)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal asid As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Asistencia WHERE id=@id;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@id", asid)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
