Imports System.Data.OleDb
Public Class Cargar_Materia
    Private mat_ As New Materias
    Private matnueva_ As Boolean
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

    Public Property mat() As Materias
        Get
            Return mat_
        End Get
        Set(ByVal value As Materias)
            mat_ = value
        End Set
    End Property
    Private Property matnueva() As Boolean
        Get
            Return matnueva_
        End Get
        Set(ByVal value As Boolean)
            matnueva_ = value
        End Set

    End Property
    Private Function ObtenerAutonumerico() As Integer

        Try
            Using conexion_auto As New OleDbConnection( _
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
                Dim comando As OleDbCommand = conexion_auto.CreateCommand()
                comando.CommandText = "SELECT MAX(id) AS MAXIMO FROM Materias"
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
            txt_matid.Text = CStr(n)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub New(ByVal mat As Materias) 'Constructor para Modificar
        InitializeComponent()




        Dim tabla1 As New DataTable
        Dim sql1 As String = "SELECT DISTINCT Año FROM Carreras"
        Dim adp1 As New OleDbDataAdapter(sql1, con)
        adp1.Fill(tabla1)
        cmb_año.DataSource = tabla1

        cmb_año.DisplayMember = "Año"
        cmb_año.ValueMember = "Año"

        Dim tb As New DataTable
        Dim caden As String = "select año from carreras where id =" + mat.idCarrera.ToString + ""
        Dim adap As New OleDbDataAdapter(caden, con)
        Dim adap2 As New OleDbCommand(caden, con)
        adap.Fill(tb)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim myreader = adap2.ExecuteReader
        myreader.Read()

        Dim a = (myreader("año")).ToString
        cmb_año.SelectedValue = a

        con.Close()





        Dim año = cmb_año.SelectedValue.ToString

        txt_nom_mat.Text = mat.nombre
        txt_matid.Text = mat.id
        txt_matid.Enabled = False

        Dim tabla As New DataTable
        Dim sql As String = "SELECT DISTINCT Legajo, Nombre FROM Profesor"
        Dim adp As New OleDbDataAdapter(sql, con)
        adp.Fill(tabla)
        cmb_prof.DataSource = tabla

        Dim tabla2 As New DataTable
        Dim sql2 As String = "SELECT DISTINCT Id, Nombre FROM Carreras where año=" + año + "  ORDER BY Nombre ASC"
        Dim adp2 As New OleDbDataAdapter(sql2, con)
        adp2.Fill(tabla2)
        cmb_carr.DataSource = tabla2

        cmb_prof.DisplayMember = "Nombre"
        cmb_prof.ValueMember = "Legajo"

        cmb_carr.DisplayMember = "Nombre"
        cmb_carr.ValueMember = "Id"


        cmb_prof.SelectedValue = Convert.ToString(mat.idProfe)
        cmb_carr.SelectedValue = Convert.ToString(mat.idCarrera)













        Me.lbl_title.Text = "MODIFICAR DATOS DE LA MATERIA"
        Me.Button1.Text = "Modificar"
        Me.Text = "Modificar Materia"
        matnueva = False
    End Sub
    Public Sub New() 'Constructor para Agregar


        InitializeComponent()
        txt_nom_mat.Text = ""
        AddHandler Me.Load, AddressOf agregando

        Dim tabla As New DataTable
        Dim sql As String = "SELECT DISTINCT Legajo, Nombre FROM Profesor"
        Dim adp As New OleDbDataAdapter(sql, con)
        adp.Fill(tabla)

        cmb_prof.DataSource = tabla
        cmb_prof.DisplayMember = "Nombre"
        cmb_prof.ValueMember = "Legajo"
        cmb_prof.SelectedIndex = -1

        Dim tabla1 As New DataTable
        Dim sql1 As String = "SELECT DISTINCT Año FROM Carreras"
        Dim adp1 As New OleDbDataAdapter(sql1, con)
        adp1.Fill(tabla1)


        'POR ALUMNO
        cmb_año.DataSource = tabla1
        cmb_año.DisplayMember = "Año"
        cmb_año.ValueMember = "Año"
        If cmb_año.SelectedIndex = -1 Then
            cmb_año.DataSource = Nothing
            cmb_año.Items.Add("No hay años cargadas")
            cmb_año.SelectedIndex = 0
            cmb_año.Enabled = False

            cmb_carr.DataSource = Nothing
            cmb_carr.Items.Add("No hay carreras cargados")
            cmb_carr.SelectedIndex = 0
            cmb_carr.Enabled = False
        End If
        cmb_carr.Enabled = False
        cmb_año.SelectedItem = Nothing
        Me.lbl_title.Text = "CARGAR DATOS DE LA MATERIA"
        Me.Text = "Cargar Materia"
        matnueva = True
    End Sub
    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_nom_mat.Text = "" Or cmb_carr.SelectedIndex < 0 Or cmb_prof.SelectedIndex < 0 Then
            MsgBox("Debes rellenar todos los campos para continuar")
            Return
        End If


        Me.txt_nom_mat.Text = cambia(Me.txt_nom_mat.Text)


        mat.nombre = txt_nom_mat.Text
        mat.idCarrera = cmb_carr.SelectedValue
        mat.idProfe = cmb_prof.SelectedValue
        mat.id = txt_matid.Text


        If matnueva = False Then
            mat.id = txt_matid.Text
            mat.Modificar(mat)
            Close()
        Else
            mat.Agregar(mat)
            Close()
        End If
    End Sub

    Private Sub txt_nom_mat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nom_mat.KeyPress
        txt_nom_mat.MaxLength = 60

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


    Private Sub cmb_año_SelectedValueChang(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_año.SelectionChangeCommitted
        Dim año = cmb_año.SelectedValue.ToString
        Dim tabla2 As New DataTable
        Dim sql2 As String = "SELECT DISTINCT Id, Nombre FROM Carreras where año like '" + año + "' ORDER BY Nombre ASC"
        Dim adp2 As New OleDbDataAdapter(sql2, con)
        adp2.Fill(tabla2)

        cmb_carr.DataSource = tabla2

        cmb_carr.Enabled = True
        cmb_carr.DisplayMember = "Nombre"
        cmb_carr.ValueMember = "Id"
        cmb_carr.SelectedValue = -1

    End Sub


End Class