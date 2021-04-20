Imports System.Data.OleDb
Imports System.Data
Public Class Lista

    Dim asis_ As New Asistencias
    Dim list_ As New Listado
    Dim list As New Listado
    Dim asis As New Asistencias
    Public valorcarrera As String
    Public valormateria As String
    Public valorfecha As String
    Public idmateria As String
    Public idcarrera As String
    Public idasistencia As String
    Public identificador As String
    Public idlistado As String
    Public ultimoid As String
    Public guardar As String
    Public beg As Boolean
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim cadenacomprobante As String = "select * from Asistencia where IdMateria = " + valormateria + " and IdCarrera = " + valorcarrera + " and Fecha =  #" + valorfecha + "#"
        Dim adaptador As New OleDbDataAdapter(cadenacomprobante, con)
        Dim comando As New OleDbCommand(cadenacomprobante, con)
        Dim basededatos As New DataTable
        adaptador.Fill(basededatos)

        If identificador = 1 Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim chkstate As CheckState

            Dim query2 As String = "select id from Asistencia where IdMateria = " + valormateria + " and IdCarrera = " + valorcarrera + " and Fecha =  #" + valorfecha + "#"
            Dim adapter2 As New OleDbDataAdapter(query2, con)
            Dim adapter3 As New OleDbCommand(query2, con)
            Dim dt2 As New DataTable
            adapter2.Fill(dt2)

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim myreader = adapter3.ExecuteReader
            myreader.Read()

            Dim valoralumno As String
            For i = 0 To CheckedListBox1.Items.Count - 1

                CheckedListBox1.SelectedIndex = i
                valoralumno = CheckedListBox1.SelectedValue

                Dim a As New DataTable
                Dim caden As String = "select * from listado where idalumno =" + valoralumno + " and idasistencia= " + idasistencia + ""
                Dim adap As New OleDbDataAdapter(caden, con)
                Dim adap2 As New OleDbCommand(caden, con)
                adap.Fill(a)

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim myreader2 = adap2.ExecuteReader
                myreader2.Read()
                chkstate = CheckedListBox1.GetItemCheckState(i)
                CheckedListBox1.SelectedIndex = i

                idlistado = (myreader2("id")).ToString

                If (chkstate = CheckState.Checked) Then
                    list.pres = True
                    list.idal = CheckedListBox1.SelectedValue
                    list.nomalumno = CheckedListBox1.Text
                    list.idasis = (myreader("id")).ToString
                    list.idmat = idmateria
                    list.idcarr = idcarrera
                ElseIf (chkstate = CheckState.Unchecked) Then
                    list.pres = False
                    list.idal = CheckedListBox1.SelectedValue
                    list.nomalumno = CheckedListBox1.Text
                    list.idasis = (myreader("id")).ToString
                    list.idmat = idmateria
                    list.idcarr = idcarrera
                End If
                If beg = True Then
                    list.beg = True
                Else
                    list.beg = False
                End If
                Dim strComando As String = "UPDATE Listado SET Presente=" + list.pres.ToString + "" + " WHERE id=" + idlistado.ToString + ";"
                Dim adap3 As New OleDbCommand(strComando, con)
                adap3.ExecuteNonQuery()

            Next
        End If

        If identificador = 0 Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim chkstate As CheckState

            Dim query As String = "select id from asistencia where id=(select max(id) from asistencia)"
            Dim adapter As New OleDbDataAdapter(query, con)
            Dim adapter2 As New OleDbCommand(query, con)
            Dim dt As New DataTable
            adapter.Fill(dt)

            Dim myreader = adapter2.ExecuteReader
            myreader.Read()

            For i = 0 To CheckedListBox1.Items.Count - 1
                chkstate = CheckedListBox1.GetItemCheckState(i)
                CheckedListBox1.SelectedIndex = i

                If (chkstate = CheckState.Checked) Then
                    list.pres = True
                Else
                    list.pres = False
                End If
                list.idal = CheckedListBox1.SelectedValue
                list.nomalumno = CheckedListBox1.Text
                list.idasis = (myreader("id"))
                list.idmat = idmateria
                list.idcarr = idcarrera
                If beg = True Then
                    list.beg = True
                Else
                    list.beg = False
                End If
                list.Agregar(list)
            Next
        End If
        con.Close()
        guardar = 1
        Me.Close()
    End Sub

    Private Sub Lista_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If guardar = 0 Then
            If identificador = 0 Then
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim query As String = "select id from asistencia where id=(select max(id) from asistencia)"
                Dim adapter As New OleDbDataAdapter(query, con)
                Dim adapter2 As New OleDbCommand(query, con)
                Dim dt As New DataTable
                adapter.Fill(dt)

                Dim myreader = adapter2.ExecuteReader
                myreader.Read()
                ultimoid = (myreader("id"))
                asis.asid = ultimoid
                asis.Borrar(asis.asid)

                con.Close()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Lista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        guardar = 0
        If identificador = 0 Then
            Dim tabla4 As New DataTable
            Dim sql4 As String = "select * from AlumnoMaterias where idmaterias like '" + idmateria + "'"
            Dim adp4 As New OleDbDataAdapter(sql4, con)
            adp4.Fill(tabla4)
            CheckedListBox1.DataSource = tabla4
            CheckedListBox1.DisplayMember = "Nomalumno"
            CheckedListBox1.ValueMember = "Idalumno"
            For i = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SelectedIndex = i
                CheckedListBox1.SetItemChecked(i, False)
            Next

        End If
        If identificador = 1 Then
            Dim tabla4 As New DataTable
            Dim sql4 As String = "select * from Listado where idasistencia like '" + idasistencia + "'"
            Dim adp4 As New OleDbDataAdapter(sql4, con)
            adp4.Fill(tabla4)
            CheckedListBox1.DataSource = tabla4
            CheckedListBox1.DisplayMember = "Nomalumno"
            CheckedListBox1.ValueMember = "Idalumno"

            Dim valoralumno As String
            Dim presente As String

            For i = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SelectedIndex = i
                valoralumno = CheckedListBox1.SelectedValue

                Dim tb As New DataTable
                Dim caden As String = "select presente from listado where idalumno =" + valoralumno + " and idasistencia= " + idasistencia + ""
                Dim adap As New OleDbDataAdapter(caden, con)
                Dim adap2 As New OleDbCommand(caden, con)
                adap.Fill(tb)

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim myreader = adap2.ExecuteReader
                myreader.Read()

                presente = (myreader("presente")).ToString
                If CheckedListBox1.SelectedValue = valoralumno Then
                    If presente = True Then
                        CheckedListBox1.SetItemChecked(i, True)
                    Else
                        CheckedListBox1.SetItemChecked(i, False)
                    End If
                    con.Close()
                End If
            Next
        End If
        If CheckedListBox1.Items.Count < 1 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

End Class