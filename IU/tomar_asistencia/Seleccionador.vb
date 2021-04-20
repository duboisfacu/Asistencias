Imports System.Data.OleDb
Imports System.Data
Public Class Seleccionador
    Dim asis As New Asistencias
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
    Public preceptor As String

    Private Sub Seleccionador_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Seleccionador_Preceptor.Show()
    End Sub
    Private Sub Seleccionador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tabla1 As New DataTable

        If preceptor = Nothing Then
            Dim sql1 As String = "SELECT DISTINCT año FROM Carreras"
            Dim adp1 As New OleDbDataAdapter(sql1, con)
            adp1.Fill(tabla1)
        Else
            Dim sql1 As String = "SELECT DISTINCT año FROM Carreras where IdPreceptor =" + preceptor + ""

            Dim adp1 As New OleDbDataAdapter(sql1, con)
            adp1.Fill(tabla1)
        End If

        cmb_año.DataSource = tabla1
        cmb_año.DisplayMember = "año"
        cmb_año.ValueMember = "año"
        If cmb_año.SelectedIndex = -1 Then
            cmb_año.DataSource = Nothing
            cmb_año.Items.Add("No hay años cargadas")
            cmb_año.SelectedIndex = 0
            cmb_año.Enabled = False
        End If


        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        Button1.Enabled = False
    End Sub
    Private Sub cmb_año_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_año.SelectionChangeCommitted
        Dim tabla1 As New DataTable

        Dim año = cmb_año.SelectedValue.ToString
        If preceptor = Nothing Then
            Dim sql1 As String = "SELECT DISTINCT Id, Nombre FROM Carreras where año =" + año + ""
            Dim adp1 As New OleDbDataAdapter(sql1, con)
            adp1.Fill(tabla1)
        Else
            Dim sql1 As String = "SELECT DISTINCT Id, Nombre FROM Carreras where IdPreceptor =" + preceptor + " and año =" + año + ""

            Dim adp1 As New OleDbDataAdapter(sql1, con)
            adp1.Fill(tabla1)
        End If

        ComboBox1.DataSource = tabla1
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "Id"
        If ComboBox1.SelectedIndex = -1 Then
            ComboBox1.DataSource = Nothing
            ComboBox1.Items.Add("No hay carreras cargadas")
            ComboBox1.SelectedIndex = 0
            ComboBox1.Enabled = False
        End If

        ComboBox1.Enabled = True
        ComboBox2.Enabled = False
        Button1.Enabled = False
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        ComboBox2.DataSource = Nothing
        ComboBox2.Enabled = False

        If ComboBox1.SelectedIndex > -1 Then
            Dim valuecarrera = (ComboBox1.SelectedValue).ToString
            Dim tabla As New DataTable
            Dim sql As String = "select * from Materias where idCarrera like '" + valuecarrera + "'"
            Dim adp As New OleDbDataAdapter(sql, con)
            adp.Fill(tabla)
            ComboBox2.DataSource = tabla
            ComboBox2.ValueMember = "Id"
            ComboBox2.DisplayMember = "Nombre"
            ComboBox2.Enabled = True
        End If
        If ComboBox2.SelectedIndex = -1 Then
            ComboBox2.DataSource = Nothing
            ComboBox2.Items.Add("No hay ninguna materia en esta carrera")
            ComboBox2.SelectedIndex = 0
            ComboBox2.Enabled = False
        End If
        If ComboBox2.Enabled = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim fecha = Format(DateTimePicker1.Value, "M/dd/yyyy")
        Dim cadenacomprobante As String = "select * from Asistencia where IdMateria = " + CStr(ComboBox2.SelectedValue) + " and IdCarrera = " + CStr(ComboBox1.SelectedValue) + " and Fecha =  #" + CStr(fecha) + "#"
        Dim adaptador As New OleDbDataAdapter(cadenacomprobante, con)
        Dim comando As New OleDbCommand(cadenacomprobante, con)
        Dim basededatos As New DataTable
        adaptador.Fill(basededatos)



        If chkb_beg.Checked Then
            asis.BEG = True
            Lista.beg = True
        Else
            asis.BEG = False
            Lista.beg = False
        End If



        If basededatos.Rows.Count > 0 Then
            Lista.identificador = 1
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            asis.idCarrera = CStr(ComboBox1.SelectedValue)
            asis.idMateria = CStr(ComboBox2.SelectedValue)
            asis.Fecha = Format(DateTimePicker1.Value, "dd/M/yyyy")

            Lista.valorcarrera = CStr(ComboBox1.SelectedValue)
            Lista.valormateria = CStr(ComboBox2.SelectedValue)
            Lista.valorfecha = Format(DateTimePicker1.Value, "dd/M/yyyy")

            Lista.lbl_carrera.Text = (ComboBox1.Text)
            Lista.lbl_materia.Text = (ComboBox2.Text)
            Lista.lbl_fecha.Text = Format(DateTimePicker1.Value, "dd/M/yyyy")

            Lista.idmateria = (ComboBox2.SelectedValue).ToString

            Dim myreader = comando.ExecuteReader
            myreader.Read()

            Lista.idasistencia = (myreader("id"))

            Dim strComando As String = "UPDATE Asistencia SET BEG=" + asis.BEG.ToString + " WHERE id=" + Lista.idasistencia.ToString + ";"
            Dim adap3 As New OleDbCommand(strComando, con)
            adap3.ExecuteNonQuery()


            con.Close()


        Else

            Lista.identificador = 0

            asis.idCarrera = CStr(ComboBox1.SelectedValue)
            asis.idMateria = CStr(ComboBox2.SelectedValue)
            asis.Fecha = Format(DateTimePicker1.Value, "dd/M/yyyy")

            Lista.valorcarrera = CStr(ComboBox1.SelectedValue)
            Lista.valormateria = CStr(ComboBox2.SelectedValue)
            Lista.valorfecha = Format(DateTimePicker1.Value, "dd/M/yyyy")

            Lista.lbl_carrera.Text = (ComboBox1.Text)
            Lista.lbl_materia.Text = (ComboBox2.Text)
            Lista.lbl_fecha.Text = Format(DateTimePicker1.Value, "dd/M/yyyy")

            Lista.idmateria = (ComboBox2.SelectedValue).ToString
            Lista.idcarrera = (ComboBox1.SelectedValue).ToString

            asis.Agregar(asis)

        End If

        Lista.ShowDialog()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Info.ShowDialog()
    End Sub



End Class