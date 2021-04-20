Imports System.Data
Imports System.Data.OleDb

Public Class carreras
    Inherits conexiones
    Private carrid_ As Integer
    Private nombre_ As String
    Private idPreceptor_ As Integer
    Private anio_ As Integer

    Public Property carrid() As Integer
        Get
            Return carrid_
        End Get
        Set(ByVal value As Integer)
            carrid_ = value
        End Set
    End Property

    Public Property anio() As Integer
        Get
            Return anio_
        End Get
        Set(ByVal value As Integer)
            anio_ = value
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

    Public Property idPreceptor() As Integer
        Get
            Return idPreceptor_
        End Get
        Set(ByVal value As Integer)
            idPreceptor_ = value
        End Set
    End Property

    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Carreras"
        
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

    Public Sub Modificar(ByVal carr As carreras)
        Abrir()
        Dim strComando As String = "UPDATE Carreras SET Nombre=@nombre, id=@id, idPreceptor=@idpreceptor, Año=@año " + "WHERE id=@id;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", carr.nombre)
        comando.Parameters.AddWithValue("@id", carr.carrid)
        comando.Parameters.AddWithValue("@idpreceptor", carr.idPreceptor)
        comando.Parameters.AddWithValue("@año", carr.anio)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal carr As carreras)
        Abrir()
        Dim strComando As String = "INSERT INTO Carreras (Nombre,ID,IdPreceptor,Año) VALUES " & _
        "(@nombre,@id,@idpreceptor,@año);"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", carr.nombre)
        comando.Parameters.AddWithValue("@id", carr.carrid)
        comando.Parameters.AddWithValue("@idpreceptor", carr.idPreceptor)
        comando.Parameters.AddWithValue("@año", carr.anio)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal Documento As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Carreras WHERE Id=@id;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@id", carrid)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
