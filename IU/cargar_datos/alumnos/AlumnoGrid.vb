Imports System.Data
Imports System.Data.OleDb
Public Class AlumnoGrid
    Dim alum As New alumnos

    Private Sub AlumnoGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        alum.Listar(DataGridView2)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cargar_alumno As New Cargar_Alumno()
        cargar_alumno.ShowDialog()
        alum.Listar(DataGridView2)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(2).Value Is Nothing Then
                    MsgBox("No existen datos para borrar")
                    Exit For
                Else
                    alum.aldni = DataGridView2.CurrentRow.Cells("Documento").Value
                    alum.Borrar(alum.aldni)
                    alum.Listar(DataGridView2)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Modificar()
        Try
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(2).Value Is Nothing Then
                    MsgBox("No existen datos para modificar")
                    Exit For
                Else
                    alum.aldni = DataGridView2.CurrentRow.Cells("Documento").Value
                    alum.alnombre = DataGridView2.CurrentRow.Cells("Nombre").Value
                    alum.aldomicilio = DataGridView2.CurrentRow.Cells("Domicilio").Value
                    alum.albeg = DataGridView2.CurrentRow.Cells("BEG").Value
                    alum.alcerttrab = DataGridView2.CurrentRow.Cells("CertificadoTrabajo").Value

                    Dim cargar_alumno As New Cargar_Alumno(alum)
                    cargar_alumno.ShowDialog()
                    alum.Listar(DataGridView2)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Modificar()
    End Sub
    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        If DataGridView2.SelectedCells.Item(0).Value Is DBNull.Value Then
            Cargar_Alumno.ShowDialog()
        Else
            Modificar()
        End If
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If


        Dim cmd1 As New OleDbCommand("select * from alumno where nombre like '%" + TextBox1.Text + "%' or domicilio like '%" + TextBox1.Text + "%' or documento like '%" + TextBox1.Text + "%'", conn)

        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView2.DataSource = dt



        conn.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If


        Dim cmd1 As New OleDbCommand("select * from alumno where nombre like '%" + TextBox1.Text + "%' or domicilio like '%" + TextBox1.Text + "%' or documento like '%" + TextBox1.Text + "%'", conn)

        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView2.DataSource = dt



        conn.Close()
    End Sub

End Class