Imports System.Data
Imports System.Data.OleDb

Public Class Listado
    Inherits conexiones

    Private id_ As Integer
    Private idasis_ As Integer
    Private idal_ As Integer
    Private nomalumno_ As String
    Private pres_ As Boolean
    Private beg_ As Boolean
    Private idmat_ As Integer
    Private idcarr_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Public Property idasis() As Integer
        Get
            Return idasis_
        End Get
        Set(ByVal value As Integer)
            idasis_ = value
        End Set
    End Property
    Public Property idal() As Integer
        Get
            Return idal_
        End Get
        Set(ByVal value As Integer)
            idal_ = value
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
    Public Property pres() As Boolean
        Get
            Return pres_
        End Get
        Set(ByVal value As Boolean)
            pres_ = value
        End Set
    End Property
    Public Property beg() As Boolean
        Get
            Return beg_
        End Get
        Set(ByVal value As Boolean)
            beg_ = value
        End Set
    End Property
    Public Property idmat() As Integer
        Get
            Return idmat_
        End Get
        Set(ByVal value As Integer)
            idmat_ = value
        End Set
    End Property
    Public Property idcarr() As Integer
        Get
            Return idcarr_
        End Get
        Set(ByVal value As Integer)
            idcarr_ = value
        End Set
    End Property

    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Listado"
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

    Public Sub Modificar(ByVal list As Listado)
        Abrir()
        Dim strComando As String = "UPDATE Listado SET IdAsistencia=@idasistencia, id=@id, IdAlumno=@idalumno, NomAlumno=@nomalumno, Presente=@presente, beg=@beg, IdMateria=@idmateria, IdCarrera=@idcarrera" + "WHERE id like @id;"

        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@idasistencia", list.idasis)
        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@idalumno", list.idal)
        comando.Parameters.AddWithValue("@nomalumno", list.nomalumno)
        comando.Parameters.AddWithValue("@presente", list.pres)
        comando.Parameters.AddWithValue("@beg", list.beg)
        comando.Parameters.AddWithValue("@idmateria", list.idmat)
        comando.Parameters.AddWithValue("@idcarrera", list.idcarr)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal list As Listado)
        Abrir()
        ',BEG,CertificadoTrabajo
        ',@BEG,@certificadotrabajo
        Dim strComando As String = "INSERT INTO Listado (idasistencia,idalumno,nomalumno,presente,beg,idmateria,idcarrera) VALUES " & _
        "(@idasistencia,@idalumno,@nomalumno,@presente,@beg,@idmateria,@idcarrera);"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@idasistencia", list.idasis)
        comando.Parameters.AddWithValue("@idalumno", list.idal)
        comando.Parameters.AddWithValue("@nomalumno", list.nomalumno)
        comando.Parameters.AddWithValue("@presente", list.pres)
        comando.Parameters.AddWithValue("@beg", list.beg)
        comando.Parameters.AddWithValue("@idmateria", list.idmat)
        comando.Parameters.AddWithValue("@idcarrera", list.idcarr)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal list As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Listado WHERE id=@id;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@id", id)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
