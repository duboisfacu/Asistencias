Imports System.Data.OleDb
Imports System.Data

Public Class consultar
    Public carr As String
    Public mat As String
    Public al As String
    Public porcentaje As String

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

    Private Sub consultar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.Open()


        Dim tabla1 As New DataTable
        Dim sql1 As String = "SELECT DISTINCT Año FROM Carreras ORDER BY Año ASC"
        Dim adp1 As New OleDbDataAdapter(sql1, con)
        adp1.Fill(tabla1)



        'POR ALUMNO
        cmb_año_al.DataSource = tabla1
        cmb_año_al.DisplayMember = "Año"
        cmb_año_al.ValueMember = "Año"
        If cmb_año_al.SelectedIndex = -1 Then
            cmb_año_al.DataSource = Nothing
            cmb_año_al.Items.Add("No hay años cargadas")
            cmb_año_al.SelectedIndex = 0
            cmb_año_al.Enabled = False
        End If

        cmb_al_carr.Enabled = False
        cmb_al_mat.Enabled = False
        cmb_al_al.Enabled = False
        btn_al.Enabled = False
        'POR ALUMNO

        'POR MATERIA
        cmb_año_mat.DataSource = tabla1
        cmb_año_mat.DisplayMember = "año"
        cmb_año_mat.ValueMember = "año"
        If cmb_año_mat.SelectedIndex = -1 Then
            cmb_año_mat.DataSource = Nothing
            cmb_año_mat.Items.Add("No hay años cargadas")
            cmb_año_mat.SelectedIndex = 0
            cmb_año_mat.Enabled = False
        End If

        cmb_mat_carr.Enabled = False
        cmb_mat_mat.Enabled = False
        btn_mat.Enabled = False
        'POR MATERIA

        'POR CARRERA
        cmb_año_carr.DataSource = tabla1
        cmb_año_carr.DisplayMember = "año"
        cmb_año_carr.ValueMember = "año"
        If cmb_año_carr.SelectedIndex = -1 Then
            cmb_año_carr.DataSource = Nothing
            cmb_año_carr.Items.Add("No hay años cargadas")
            cmb_año_carr.SelectedIndex = 0
            cmb_año_carr.Enabled = False
            btn_carr.Enabled = False
        End If
        cmb_carr_carr.Enabled = False
        btn_carr.Enabled = False
        'POR CARRERA






        'POR PROFESOR
        cmb_año_prof.DataSource = tabla1
        cmb_año_prof.DisplayMember = "año"
        cmb_año_prof.ValueMember = "año"
        If cmb_año_prof.SelectedIndex = -1 Then
            cmb_año_prof.DataSource = Nothing
            cmb_año_prof.Items.Add("No hay años cargadas")
            cmb_año_prof.SelectedIndex = 0
            cmb_año_prof.Enabled = False
            btn_prof.Enabled = False
        End If
        cmb_prof.Enabled = False
        btn_prof.Enabled = False
        'POR PROFESOR











    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_al_carr.SelectionChangeCommitted
        cmb_al_mat.DataSource = Nothing
        cmb_al_mat.Enabled = False
        cmb_al_al.DataSource = Nothing
        cmb_al_al.Enabled = False


        If cmb_al_carr.SelectedIndex > -1 Then
            Dim valuecarrera = (cmb_al_carr.SelectedValue).ToString
            carr = valuecarrera
            Dim tabla As New DataTable
            Dim sql As String = "select * from Materias where idCarrera like '" + valuecarrera + "'"
            Dim adp As New OleDbDataAdapter(sql, con)
            adp.Fill(tabla)
            cmb_al_mat.DataSource = tabla
            cmb_al_mat.ValueMember = "Id"
            cmb_al_mat.DisplayMember = "Nombre"
            cmb_al_mat.Enabled = True
        End If
        If cmb_al_mat.SelectedIndex = -1 Then
            cmb_al_mat.DataSource = Nothing
            cmb_al_mat.Items.Add("No hay ninguna materia en esta carrera")
            cmb_al_mat.SelectedIndex = 0
            cmb_al_mat.Enabled = False
        End If
        If cmb_al_al.Enabled = True Then
            btn_al.Enabled = True
        Else
            btn_al.Enabled = False
        End If
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_al_mat.SelectionChangeCommitted
        cmb_al_al.DataSource = Nothing
        cmb_al_al.Enabled = False

        If cmb_al_mat.SelectedIndex > -1 Then
            Dim valuemateria = (cmb_al_mat.SelectedValue).ToString

            Dim tabla As New DataTable
            Dim sql As String = "select * from AlumnoMaterias where idMaterias like '" + valuemateria + "'"
            Dim adp As New OleDbDataAdapter(sql, con)
            adp.Fill(tabla)
            cmb_al_al.DataSource = tabla
            cmb_al_al.ValueMember = "IdAlumno"
            cmb_al_al.DisplayMember = "NomAlumno"
            cmb_al_al.Enabled = True
        End If
        If cmb_al_al.SelectedIndex = -1 Then
            cmb_al_al.DataSource = Nothing
            cmb_al_al.Items.Add("No hay ningun alumno en esta materia")
            cmb_al_al.SelectedIndex = 0
            cmb_al_al.Enabled = False
        End If
        If cmb_al_al.Enabled = True Then
            btn_al.Enabled = True
        Else
            btn_al.Enabled = False
        End If
    End Sub



    Private Sub cmb_mat_carr_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_mat_carr.SelectionChangeCommitted
        cmb_mat_mat.DataSource = Nothing
        cmb_mat_mat.Enabled = False

        If cmb_mat_carr.SelectedIndex > -1 Then
            Dim valuecarrera = (cmb_mat_carr.SelectedValue).ToString
            carr = valuecarrera
            Dim tabla As New DataTable
            Dim sql As String = "select * from Materias where idCarrera like '" + valuecarrera + "'"
            Dim adp As New OleDbDataAdapter(sql, con)
            adp.Fill(tabla)
            cmb_mat_mat.DataSource = tabla
            cmb_mat_mat.ValueMember = "Id"
            cmb_mat_mat.DisplayMember = "Nombre"
            cmb_mat_mat.Enabled = True
        End If
        If cmb_mat_mat.SelectedIndex = -1 Then
            cmb_mat_mat.DataSource = Nothing
            cmb_mat_mat.Items.Add("No hay ninguna materia en esta carrera")
            cmb_mat_mat.SelectedIndex = 0
            cmb_mat_mat.Enabled = False
        End If
        If cmb_mat_mat.Enabled = True Then
            btn_mat.Enabled = True
        Else
            btn_mat.Enabled = False
        End If
    End Sub
    Private Sub btn_al_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_al.Click
        Dim cadenacomprobante As String = "select * from Asistencia where IdMateria = " + cmb_al_mat.SelectedValue.ToString + " and IdCarrera = " + cmb_al_carr.SelectedValue.ToString + " and BEG = False"
        Dim adaptador As New OleDbDataAdapter(cadenacomprobante, con)
        Dim comando As New OleDbCommand(cadenacomprobante, con)
        Dim basededatos As New DataTable
        adaptador.Fill(basededatos)


        If basededatos.Rows.Count > 0 Then
            Estadistica_Alumno.idcarr = cmb_al_carr.SelectedValue.ToString
            Estadistica_Alumno.idmat = cmb_al_mat.SelectedValue.ToString
            Estadistica_Alumno.idal = cmb_al_al.SelectedValue.ToString
            Estadistica_Alumno.nomal = cmb_al_al.Text
            Estadistica_Alumno.añoal = cmb_año_al.SelectedValue.ToString
            Estadistica_Alumno.ShowDialog()

        Else
            MsgBox("No hay datos de " + cmb_al_al.Text + " en esta materia.")
        End If

    End Sub
    Private Sub btn_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mat.Click
        Dim cadenacomprobante As String = "select * from Listado where IdMateria = " + cmb_mat_mat.SelectedValue.ToString + ""
        Dim adaptador As New OleDbDataAdapter(cadenacomprobante, con)
        Dim comando As New OleDbCommand(cadenacomprobante, con)
        Dim basededatos As New DataTable
        adaptador.Fill(basededatos)


        If basededatos.Rows.Count > 0 Then
            Estadistica_Materia.idcarr = cmb_mat_carr.SelectedValue.ToString
            Estadistica_Materia.idmat = cmb_mat_mat.SelectedValue.ToString
            Estadistica_Materia.nomat = cmb_mat_mat.Text
            Estadistica_Materia.añomat = cmb_año_mat.SelectedValue.ToString
            Estadistica_Materia.ShowDialog()
        Else
            MsgBox("No hay datos de " + cmb_mat_mat.Text + " en esta en esta carrera.")
        End If
    End Sub

    Private Sub btn_carr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carr.Click
        Dim cadenacomprobante As String = "select * from Listado where IdCarrera = " + cmb_carr_carr.SelectedValue.ToString + ""
        Dim adaptador As New OleDbDataAdapter(cadenacomprobante, con)
        Dim comando As New OleDbCommand(cadenacomprobante, con)
        Dim basededatos As New DataTable
        adaptador.Fill(basededatos)


        If basededatos.Rows.Count > 0 Then
            Estadistica_Carrera.idcarr = cmb_carr_carr.SelectedValue.ToString
            Estadistica_Carrera.nomcarr = cmb_carr_carr.Text
            Estadistica_Carrera.añocarr = cmb_año_carr.SelectedValue.ToString
            Estadistica_Carrera.ShowDialog()
        Else
            MsgBox("No hay datos de " + cmb_carr_carr.Text)
        End If
    End Sub

    Private Sub btn_prof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prof.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim prof = cmb_prof.SelectedValue.ToString
        Dim año = cmb_año_prof.SelectedValue.ToString

        'Dim cadprofmat As String = "SELECT * FROM profesor INNER JOIN (materias INNER JOIN carreras ON materias.idcarrera=carreras.id)  ON materias.idprofesor = profesor.legajo WHERE (carreras.año like '" + año + "')"

        Dim cadprofmat As String = "SELECT * FROM Materias INNER JOIN carreras ON materias.idcarrera=carreras.id  WHERE (carreras.año like '" + año + "') and (materias.idprofesor like '" + prof + "')"

        'Dim cadprofmat As String = "select * from Materias where IdProfesor = " + cmb_prof.SelectedValue.ToString + ""
        Dim adap As New OleDbDataAdapter(cadprofmat, con)
        Dim com As New OleDbCommand(cadprofmat, con)
        Dim profmat As New DataTable
        adap.Fill(profmat)

        Dim idmatwp As String

        Using profmatcomp As OleDbDataReader = com.ExecuteReader()
            If profmatcomp.HasRows() Then

                While profmatcomp.Read()
                    idmatwp = (profmatcomp("materias.id")).ToString

                    Dim cadenacomprobante As String = "select * from Asistencia where IdMateria = " + idmatwp + ""
                    Dim adaptador As New OleDbDataAdapter(cadenacomprobante, con)
                    Dim comando As New OleDbCommand(cadenacomprobante, con)
                    Dim basededatos As New DataTable
                    adaptador.Fill(basededatos)

                    If basededatos.Rows.Count > 0 Then
                        Estadistica_Profesor.idprof = cmb_prof.SelectedValue.ToString
                        Estadistica_Profesor.nomprof = cmb_prof.Text
                        Estadistica_Profesor.añoprof = cmb_año_prof.SelectedValue.ToString
                        Estadistica_Profesor.Show()
                        Exit While
                    End If
                End While
            End If
        End Using
        con.Close()

        If Estadistica_Profesor.IsHandleCreated Then
        Else
            MsgBox("No hay datos de " + cmb_prof.Text)
        End If

    End Sub

    Private Sub cmb_año_al_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_año_al.SelectionChangeCommitted

        cmb_al_mat.DataSource = Nothing
        cmb_al_mat.Enabled = False
        cmb_al_al.DataSource = Nothing
        cmb_al_al.Enabled = False
        cmb_al_carr.DataSource = Nothing
        cmb_al_carr.Enabled = False

        If cmb_año_al.SelectedIndex > -1 Then
            Dim año = (cmb_año_al.SelectedValue).ToString
            Dim tabla As New DataTable
            Dim sql As String = "select * from Carreras where Año like '" + año + "' ORDER BY Nombre ASC"
            Dim adp As New OleDbDataAdapter(sql, con)
            adp.Fill(tabla)
            cmb_al_carr.DataSource = tabla
            cmb_al_carr.ValueMember = "Id"
            cmb_al_carr.DisplayMember = "Nombre"
            cmb_al_carr.Enabled = True
        End If
        If cmb_al_carr.SelectedIndex = -1 Then
            cmb_al_carr.DataSource = Nothing
            cmb_al_carr.Items.Add("No hay ninguna carrera en este año")
            cmb_al_carr.SelectedIndex = 0
            cmb_al_carr.Enabled = False
        End If

    End Sub




    Private Sub cmb_año_mat_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_año_mat.SelectionChangeCommitted

        cmb_mat_mat.DataSource = Nothing
        cmb_mat_mat.Enabled = False
        cmb_mat_carr.DataSource = Nothing
        cmb_mat_carr.Enabled = False

        If cmb_año_mat.SelectedIndex > -1 Then
            Dim año = (cmb_año_mat.SelectedValue).ToString
            Dim tabla As New DataTable
            Dim sql As String = "select * from Carreras where Año like '" + año + "' ORDER BY Nombre ASC"
            Dim adp As New OleDbDataAdapter(sql, con)
            adp.Fill(tabla)
            cmb_mat_carr.DataSource = tabla
            cmb_mat_carr.ValueMember = "Id"
            cmb_mat_carr.DisplayMember = "Nombre"
            cmb_mat_carr.Enabled = True
        End If
        If cmb_mat_carr.SelectedIndex = -1 Then
            cmb_mat_carr.DataSource = Nothing
            cmb_mat_carr.Items.Add("No hay ninguna carrera en este año")
            cmb_mat_carr.SelectedIndex = 0
            cmb_mat_carr.Enabled = False
        End If

    End Sub

    Private Sub cmb_año_carr_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_año_carr.SelectionChangeCommitted
        cmb_carr_carr.DataSource = Nothing
        cmb_carr_carr.Enabled = False

        If cmb_año_carr.SelectedIndex > -1 Then
            Dim año = (cmb_año_carr.SelectedValue).ToString
            Dim tabla As New DataTable
            Dim sql As String = "select * from Carreras  where Año like '" + año + "' ORDER BY Nombre ASC"
            Dim adp As New OleDbDataAdapter(sql, con)
            adp.Fill(tabla)


            cmb_carr_carr.DisplayMember = "Nombre"
            cmb_carr_carr.ValueMember = "Id"
            cmb_carr_carr.DataSource = tabla

            cmb_carr_carr.Enabled = True
        End If
        If cmb_carr_carr.SelectedIndex = -1 Then
            cmb_carr_carr.DataSource = Nothing
            cmb_carr_carr.Items.Add("No hay ninguna carrera en este año")
            cmb_carr_carr.SelectedIndex = 0
            cmb_carr_carr.Enabled = False
        End If

    End Sub

    Private Sub cmb_carr_carr_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_carr_carr.SelectionChangeCommitted
        btn_carr.Enabled = True
    End Sub

    Private Sub cmb_año_prof_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_año_prof.SelectionChangeCommitted

        Dim año = cmb_año_prof.SelectedValue.ToString

        Dim tabla2 As New DataTable
        Dim sql2 As String = "SELECT DISTINCT profesor.nombre, profesor.legajo FROM profesor INNER JOIN (materias INNER JOIN carreras ON materias.idcarrera=carreras.id)  ON materias.idprofesor = profesor.legajo WHERE (carreras.año like '" + año + "')"
        Dim adp2 As New OleDbDataAdapter(sql2, con)
        adp2.Fill(tabla2)


        cmb_prof.DataSource = tabla2
        cmb_prof.DisplayMember = "Nombre"
        cmb_prof.ValueMember = "Legajo"
        cmb_prof.Enabled = True
        If cmb_prof.SelectedIndex = -1 Then
            cmb_prof.DataSource = Nothing
            cmb_prof.Items.Add("No hay profesores cargados")
            cmb_prof.SelectedIndex = 0
            btn_prof.Enabled = False
        End If

        If cmb_prof.Enabled = True Then
            btn_prof.Enabled = True
        Else
            btn_prof.Enabled = False
        End If
    End Sub

End Class