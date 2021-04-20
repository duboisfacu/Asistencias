Imports System.Data
Imports System.Data.OleDb

Public Class alumnos
    Inherits conexiones
    Private aldni_ As Integer
    Private alnombre_ As String
    Private aldomicilio_ As String
    Private albeg_ As Boolean
    Private alcerttrab_ As Boolean

    Public Property aldni() As Integer
        Get
            Return aldni_
        End Get
        Set(ByVal value As Integer)
            aldni_ = value
        End Set
    End Property

    Public Property alnombre() As String
        Get
            Return alnombre_
        End Get
        Set(ByVal value As String)
            alnombre_ = value
        End Set
    End Property

    Public Property aldomicilio() As String
        Get
            Return aldomicilio_
        End Get
        Set(ByVal value As String)
            aldomicilio_ = value
        End Set
    End Property

    Public Property albeg() As Boolean
        Get
            Return albeg_
        End Get
        Set(ByVal value As Boolean)
            albeg_ = value
        End Set
    End Property

    Public Property alcerttrab() As Boolean
        Get
            Return alcerttrab_
        End Get
        Set(ByVal value As Boolean)
            alcerttrab_ = value
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

    Public Sub Modificar(ByVal alum As alumnos)
        Abrir()
        Dim strComando As String = "UPDATE Alumno SET Nombre=@nombre, Documento=@documento, Domicilio=@domicilio, BEG=@BEG, CertificadoTrabajo=@certificadotrabajo " + "WHERE Documento=@documento;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", alum.alnombre)
        comando.Parameters.AddWithValue("@documento", alum.aldni)
        comando.Parameters.AddWithValue("@domicilio", alum.aldomicilio)
        comando.Parameters.AddWithValue("@BEG", alum.albeg)
        comando.Parameters.AddWithValue("@certificadotrabajo", alum.alcerttrab)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal alum As alumnos)
        Abrir()
        ',BEG,CertificadoTrabajo
        ',@BEG,@certificadotrabajo
        Dim strComando As String = "INSERT INTO Alumno (Nombre,Documento,Domicilio,BEG,CertificadoTrabajo) VALUES " & _
        "(@nombre,@documento,@domicilio,@BEG,@certificadotrabajo);"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", alum.alnombre)
        comando.Parameters.AddWithValue("@documento", alum.aldni)
        comando.Parameters.AddWithValue("@domicilio", alum.aldomicilio)
        comando.Parameters.AddWithValue("@BEG", alum.albeg)
        comando.Parameters.AddWithValue("@certificadotrabajo", alum.alcerttrab)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal Documento As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Alumno WHERE Documento=@documento;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@documento", Documento)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
