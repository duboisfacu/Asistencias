Imports System.Data.OleDb
Public Class Cargar_Carrera
    Private carr_ As New carreras
    Private prec_ As New Preceptores
    Private carrnueva_ As Boolean
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
    Public Property prec() As Preceptores
        Get
            Return prec_
        End Get
        Set(ByVal value As Preceptores)
            prec_ = value
        End Set
    End Property
    Public Property carr() As carreras
        Get
            Return carr_
        End Get
        Set(ByVal value As carreras)
            carr_ = value
        End Set
    End Property
    Private Property carrnueva() As Boolean
        Get
            Return carrnueva_
        End Get
        Set(ByVal value As Boolean)
            carrnueva_ = value
        End Set
    End Property

    Private Function ObtenerAutonumerico() As Integer

        Try
            Using conexion_auto As New OleDbConnection( _
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
                Dim comando As OleDbCommand = conexion_auto.CreateCommand()
                comando.CommandText = "SELECT MAX(id) AS MAXIMO FROM Carreras"
                conexion_auto.Open()
                Dim maximo As Object = comando.ExecuteScalar()
                If (maximo Is DBNull.Value) Then
                    Return 1
                Else
                    Return CInt(maximo) + 1
                End If
            End Using
        Catch ex As Exception
            Throw
        End Try

    End Function
    Private Sub agregando(ByVal sender As Object, ByVal e As EventArgs)

        Try
            Dim n As Integer = ObtenerAutonumerico()
            txt_id.Text = CStr(n)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub New(ByVal carr As carreras) 'Constructor para Modificar
        InitializeComponent()
        txt_id.Text = carr.carrid
        txt_name_carr.Text = carr.nombre
        txt_anio_carr.Text = carr.anio
        txt_id.Enabled = False

        Dim tabla As New DataTable
        Dim sql As String = "SELECT DISTINCT documento, nombre FROM Preceptor"
        Dim adp As New OleDbDataAdapter(sql, con)
        adp.Fill(tabla)

        combobox1.DataSource = tabla

        combobox1.DisplayMember = "Nombre"
        combobox1.ValueMember = "Documento"

        combobox1.SelectedValue = Convert.ToString(carr.idPreceptor)

        Me.lbl_title.Text = "MODIFICAR DATOS DE LA CARRERA"
        Me.Button1.Text = "Modificar"
        Me.Text = "Modificar Carrera"
        carrnueva = False
    End Sub
    Public Sub New() 'Constructor para Agregar
        InitializeComponent()
        txt_anio_carr.Text = ""
        txt_name_carr.Text = ""
        AddHandler Me.Load, AddressOf agregando

        Dim tabla As New DataTable
        Dim sql As String = "SELECT DISTINCT Documento, nombre FROM Preceptor"
        Dim adp As New OleDbDataAdapter(sql, con)
        adp.Fill(tabla)
        combobox1.DataSource = tabla


        combobox1.ValueMember = "Documento"
        combobox1.DisplayMember = "nombre"
        combobox1.SelectedIndex = -1

        Me.lbl_title.Text = "CARGAR DATOS DE LA CARRERA"
        Me.Text = "Cargar Carrera"
        carrnueva = True
    End Sub
    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_name_carr.Text = "" Or txt_anio_carr.Text = "" Or combobox1.SelectedIndex < 0 Then
            MsgBox("Debes rellenar todos los campos para continuar")
            Return
        End If


        If Not IsNumeric(txt_anio_carr.Text) And _
            txt_anio_carr.Text <> "" Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            txt_anio_carr.Text = ""
            Return
        End If
        If txt_anio_carr.Text.Length < 4 Then
            Beep()
            MsgBox("La fecha está mal escrita")
            Return
        End If

        Me.txt_name_carr.Text = cambia(Me.txt_name_carr.Text)


        carr.nombre = txt_name_carr.Text
        carr.anio = txt_anio_carr.Text
        carr.idPreceptor = combobox1.SelectedValue
        carr.carrid = txt_id.Text



        If carrnueva = False Then
            carr.carrid = txt_id.Text
            carr.Modificar(carr)
            Close()
        Else
            carr.Agregar(carr)
            Close()
        End If
    End Sub

    Private Sub txt_anio_carr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_anio_carr.KeyPress
        txt_anio_carr.MaxLength = 4

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_name_carr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_name_carr.KeyPress
        txt_name_carr.MaxLength = 60

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class