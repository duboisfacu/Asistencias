Imports System.Data.OleDb
Imports System.Data
Public Class Cargar_Alumno

    Private alum_ As New alumnos
    Private alumnuevo_ As Boolean
    Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
    Public Dst As New DataSet
    Public Cmd As OleDbCommand
    Public Dad As OleDbDataAdapter
    Public CurrentRow
    Public Property alum() As alumnos
        Get
            Return alum_
        End Get
        Set(ByVal value As alumnos)
            alum_ = value
        End Set
    End Property
    Private Property alumnuevo() As Boolean
        Get
            Return alumnuevo_
        End Get
        Set(ByVal value As Boolean)
            alumnuevo_ = value
        End Set
    End Property

    Private Function IsIdExist()
        Dim Str, Str1 As String
        Dim i As Integer
        Str = txt_doc_al.Text
        i = 0
        While i <> Dst.Tables("Alumno").Rows.Count
            Str1 = Dst.Tables("Alumno").Rows(i)("Documento")
            If Str = Str1 Then
                Return True
            End If
            i += 1
        End While
        Return False
    End Function
    Public Sub New(ByVal alum As alumnos) 'Constructor para Modificar
        InitializeComponent()
        txt_doc_al.Text = alum.aldni
        txt_name_al.Text = alum.alnombre
        txt_domic_al.Text = alum.aldomicilio
        txt_doc_al.Enabled = False

        If alum.albeg = True Then
            rb_beg1.Checked = True
        Else
            rb_beg2.Checked = True
        End If
        If alum.alcerttrab = True Then
            rb_cdt1.Checked = True
        Else
            rb_cdt2.Checked = True
        End If


        Me.lbl_title.Text = "MODIFICAR DATOS DEL ALUMNO"
        Me.Button1.Text = "Modificar"
        Me.Text = "Modificar Alumno"
        Me.Button3.Visible = True
        Cargar_AlumnoMateria.lbl_title.Text = "AGREGAR MATERIAS DE ALUMNO"
        alumnuevo = False
    End Sub

    Public Sub New() 'Constructor para Agregar
        InitializeComponent()
        txt_doc_al.Text = ""
        txt_name_al.Text = ""
        txt_domic_al.Text = ""


        Me.lbl_title.Text = "CARGAR DATOS DEL ALUMNO"
        Me.Text = "Agregar Alumno"
        Me.Button3.Visible = False
        Me.Button1.Top -= 30
        Me.Button2.Top -= 30
        Me.Size = New Size(354, 384)
        alumnuevo = True
    End Sub
    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_name_al.Text = "" Or txt_doc_al.Text = "" Or txt_domic_al.Text = "" Then
            MsgBox("Debes rellenar todos los campos para continuar")
            Return
        End If


        If Not IsNumeric(txt_doc_al.Text) And _
            txt_doc_al.Text <> "" Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            txt_doc_al.Text = ""
            Return
        End If
        If txt_doc_al.Text.Length < 8 Then
            Beep()
            MsgBox("El número de documento está mal escrito")
            Return
        End If

        Me.txt_name_al.Text = cambia(Me.txt_name_al.Text)
        Me.txt_domic_al.Text = cambia(Me.txt_domic_al.Text)

        alum.alnombre = txt_name_al.Text
        alum.aldni = txt_doc_al.Text
        alum.aldomicilio = txt_domic_al.Text
        alum.albeg = rb_beg1.Checked
        alum.alcerttrab = rb_cdt1.Checked



        If alumnuevo = False Then
            alum.aldni = txt_doc_al.Text
            alum.Modificar(alum)

            Close()
        Else
            If IsIdExist() = True Then
                MsgBox("El número de documento ya existe")
                txt_doc_al.Text = ""
                txt_doc_al.Focus()
                Return
            End If
            alum.Agregar(alum)

            Me.Close()

            Cargar_AlumnoMateria.documentoalumno = txt_doc_al.Text

            Dim tabla2 As New DataTable
            Dim sql2 As String = "select * from Materias"
            Dim adp2 As New OleDbDataAdapter(sql2, Con)
            adp2.Fill(tabla2)

            If tabla2.Rows.Count > 0 Then

                Cargar_AlumnoMateria.ShowDialog()
            Else
                MsgBox("No hay materias cargadas")
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Sub txt_doc_al_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_doc_al.KeyPress
        txt_doc_al.MaxLength = 8

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txt_domic_al_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_domic_al.KeyPress
        txt_domic_al.MaxLength = 100

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
    Private Sub txt_name_al_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_name_al.KeyPress
        txt_name_al.MaxLength = 100

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
    Private Sub Cargar_Alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CurrentRow = 0
        Con.Open()
        Dad = New OleDbDataAdapter("SELECT * FROM Alumno", Con)
        Dad.Fill(Dst, "Alumno")
        Con.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txt_doc_al.Text.Length < 8 Then
            Beep()
            MsgBox("El número de documento está mal escrito")
            Return
        End If
        Cargar_AlumnoMateria.documentoalumno = txt_doc_al.Text
        Cargar_AlumnoMateria.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Cargar_AlumnoMateria.documentoalumno = txt_doc_al.Text
        Cargar_AlumnoMateria.ShowDialog()
    End Sub
End Class