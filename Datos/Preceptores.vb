Imports System.Data
Imports System.Data.OleDb

Public Class Preceptores
    Inherits conexiones
    Private doc_ As Integer
    Private nombre_ As String
    Private precicon_ As String

    Public Property doc() As Integer
        Get
            Return doc_

        End Get
        Set(ByVal value As Integer)
            doc_ = value
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
    Public Property prec_icon() As String
        Get
            Return precicon_
        End Get
        Set(ByVal value As String)
            precicon_ = value
        End Set
    End Property

    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Preceptor"
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

    Public Sub Modificar(ByVal prece As Preceptores)
        Abrir()
        Dim strComando As String = "UPDATE Preceptor SET Nombre=@nombre, Documento=@documento, Prec_Icon=@prec_icon " + "WHERE Documento=@documento;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", prece.nombre)
        comando.Parameters.AddWithValue("@documento", prece.doc)
        comando.Parameters.AddWithValue("@prec_icon", prece.prec_icon)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal prece As Preceptores)
        Abrir()
        Dim strComando As String = "INSERT INTO Preceptor (Nombre,Documento,Prec_Icon) VALUES " & _
        "(@nombre,@documento,@prec_icon);"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@nombre", prece.nombre)
        comando.Parameters.AddWithValue("@legajo", prece.doc)
        comando.Parameters.AddWithValue("@prec_icon", prece.prec_icon)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal Documento As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Preceptor WHERE Documento=@documento;"
        Dim comando As New OleDbCommand(strComando, conexion)
        comando.Parameters.AddWithValue("@documento", doc)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class

