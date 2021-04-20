Imports System.Data
Imports System.Data.OleDb
Public Class Cargar_AlumnoMateria
    Private almat_ As New AlumnoMaterias
    Public documentoalumno As String
    Public materias As String
    Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
    Public Property almat() As AlumnoMaterias
        Get
            Return almat_
        End Get
        Set(ByVal value As AlumnoMaterias)
            almat_ = value
        End Set
    End Property
    Private Sub Cargar_AlumnoMateria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.DataSource = Nothing
        cmb_carr.DataSource = Nothing
        Dim tabla5 As New DataTable
        Dim sql5 As String = "select * from Alumno where documento like '" + documentoalumno + "'"
        Dim adp5 As New OleDbDataAdapter(sql5, Con)
        adp5.Fill(tabla5)

        ComboBox1.DataSource = tabla5
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "Documento"


        Con.Open()


        Dim tabla1 As New DataTable
        Dim sql1 As String = "SELECT DISTINCT Año FROM Carreras"
        Dim adp1 As New OleDbDataAdapter(sql1, Con)
        adp1.Fill(tabla1)
        cmb_año.DataSource = tabla1
        cmb_año.DisplayMember = "Año"
        cmb_año.ValueMember = "Año"

        If cmb_año.SelectedIndex = -1 Then
            cmb_año.DataSource = Nothing
            cmb_año.Items.Add("No hay carreras cargadas")
            cmb_año.SelectedIndex = 0
            cmb_año.Enabled = False
        End If
        Con.Close()

        cmb_año.SelectedItem = Nothing

        cmb_carr.Enabled = False









        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If


        Dim cmd1 As New OleDbCommand("select * from alumnomaterias where idalumno like '" + ComboBox1.SelectedValue.ToString + "'", conn)

        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        'dt.Clear()
        da.Fill(dt)
        ListBox2.DataSource = dt
        ListBox2.DisplayMember = "nommaterias"
        ListBox2.ValueMember = "Id"


        conn.Close()

    End Sub

    Private Sub cmb_carr_SelectedValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_carr.SelectionChangeCommitted

        Dim valuecarrera = (cmb_carr.SelectedValue).ToString
        Dim tabla2 As New DataTable
        Dim sql2 As String = "select * from Materias where idCarrera like '%" + valuecarrera + "%'"
        Dim adp2 As New OleDbDataAdapter(sql2, Con)
        adp2.Fill(tabla2)

        ListBox1.DataSource = tabla2
        ListBox1.DisplayMember = "Nombre"
        ListBox1.ValueMember = "Id"
        ListBox1.SelectedItem = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        almat.idalumno = ComboBox1.SelectedValue
        almat.nomalumno = ComboBox1.Text
        almat.idmaterias = CStr(ListBox1.SelectedValue)
        almat.nommaterias = CStr(ListBox1.Text)
        almat.Agregar(almat)
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If

        Dim cmd1 As New OleDbCommand("select * from alumnomaterias where idalumno like '" + ComboBox1.SelectedValue.ToString + "'", conn)

        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        da.Fill(dt)
        ListBox2.DataSource = dt
        ListBox2.DisplayMember = "nommaterias"
        ListBox2.ValueMember = "Id"

        conn.Close()
    End Sub

    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        almat.id = ListBox2.SelectedValue
        almat.Borrar(almat.id)
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If


        Dim cmd1 As New OleDbCommand("select * from alumnomaterias where idalumno like '" + ComboBox1.SelectedValue.ToString + "'", conn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        da.Fill(dt)
        ListBox2.DataSource = dt
        ListBox2.DisplayMember = "nommaterias"
        ListBox2.ValueMember = "Id"

        conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub cmb_año_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_año.SelectionChangeCommitted
        'cmb_carr.DataSource = Nothing
        'cmb_carr.Enabled = False
        'cmb_carr.DataSource = Nothing
        'cmb_carr.Enabled = False

        If cmb_carr.SelectedIndex = -1 Then
            cmb_carr.DataSource = Nothing
            cmb_carr.Items.Add("No hay ninguna carrera en este año")
            cmb_carr.SelectedIndex = 0
            cmb_carr.Enabled = False
        End If


        ListBox1.DataSource = Nothing
        If cmb_carr.SelectedIndex > -1 Then
            Dim año = (cmb_año.SelectedValue).ToString

            Dim tabla As New DataTable
            Dim sql As String = "SELECT DISTINCT * FROM Carreras where año= " + año.ToString + " ORDER BY Nombre ASC"
            Dim adp As New OleDbDataAdapter(sql, Con)
            adp.Fill(tabla)
            cmb_carr.DataSource = tabla
            cmb_carr.ValueMember = "Id"
            cmb_carr.DisplayMember = "Nombre"
            cmb_carr.Enabled = True
        End If

    End Sub



End Class