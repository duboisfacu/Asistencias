Imports System.Data.OleDb
Imports System.Data
Public Class Cargar_Profesor
    Private prof_ As New Profesores
    Private profnuevo_ As Boolean

    Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
    Public Dst As New DataSet
    Public Cmd As OleDbCommand
    Public Dad As OleDbDataAdapter
    Public CurrentRow

    Public Property prof() As Profesores
        Get
            Return prof_
        End Get
        Set(ByVal value As Profesores)
            prof_ = value
        End Set
    End Property

    Private Property profnuevo() As Boolean
        Get
            Return profnuevo_
        End Get
        Set(ByVal value As Boolean)
            profnuevo_ = value
        End Set
    End Property

    Private Function IsIdExist()
        Dim Str, Str1 As String
        Dim i As Integer

        Str = txt_legajo.Text
        i = 0
        While i <> Dst.Tables("Profesor").Rows.Count

            Str1 = Dst.Tables("Profesor").Rows(i)("Legajo")

            If Str = Str1 Then
                Return True

            End If
            i += 1


        End While


        Return False
    End Function
    Public Sub New(ByVal prof As Profesores) 'Constructor para Modificar
        InitializeComponent()
        txt_legajo.Text = prof.legajo
        txt_name_prof.Text = prof.nombre
        txt_legajo.Enabled = False

        Me.lbl_title.Text = "MODIFICAR DATOS DEL PROFESOR"
        Me.Button1.Text = "Modificar"
        Me.Text = "Modificar Profesor"
        profnuevo = False
    End Sub

    Public Sub New() 'Constructor para Agregar
        InitializeComponent()
        txt_legajo.Text = ""
        txt_name_prof.Text = ""

        Me.lbl_title.Text = "AGREGAR DATOS DEL PROFESOR"
        Me.Text = "Agregar Profesor"
        profnuevo = True
    End Sub

    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_name_prof.Text = "" Or txt_legajo.Text = "" Then
            MsgBox("Debes rellenar todos los campos para continuar")
            Return
        End If

        If Not IsNumeric(txt_legajo.Text) And _
            txt_legajo.Text <> "" Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            txt_legajo.Text = ""
            Return
        End If

        If txt_legajo.Text.Length > 9 Then
            Beep()
            MsgBox("El número de legajo es muy largo")
            Return
        End If


        Me.txt_name_prof.Text = cambia(Me.txt_name_prof.Text)

        prof.nombre = txt_name_prof.Text
        prof.legajo = txt_legajo.Text





        If profnuevo = False Then
            prof.legajo = txt_legajo.Text
            prof.Modificar(prof)
            Close()
        Else
            If IsIdExist() = True Then
                MsgBox("El número de legajo ya existe")
                txt_legajo.Text = ""
                txt_legajo.Focus()
                Return
            End If
            prof.Agregar(prof)
            Close()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Cargar_Profesor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CurrentRow = 0
        Con.Open()
        Dad = New OleDbDataAdapter("SELECT * FROM Profesor", Con)
        Dad.Fill(Dst, "Profesor")
        Con.Close()
    End Sub

    Private Sub txt_name_prof_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_name_prof.KeyPress
        txt_name_prof.MaxLength = 100

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_legajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_legajo.KeyPress
        txt_legajo.MaxLength = 10
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class