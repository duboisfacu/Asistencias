Imports System.Data.OleDb
Imports System.Data

Imports Charting = System.Windows.Forms.DataVisualization.Charting
Imports ComponentModel = System.ComponentModel
Public Class Estadistica_Alumno

    Private WithEvents Sectors As New ComponentModel.BindingList(Of SectorItem)
    Public porcentaje As String
    Public idmat As String
    Public idcarr As String
    Public idal As String
    Public nomal As String
    Public añoal As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

    Private Sub Estadistica_Alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If nomal.Length > 37 Then
            lbl_nomal.Font = New Font("Calibri", 15)
        Else
            lbl_nomal.Font = New Font("Calibri", 18)
        End If
        Label1.Parent = Chart1
        Chart1.Location = New Point(Convert.ToInt32(Me.ClientSize.Width / 2 - Me.Chart1.Width / 2), (Convert.ToInt32(Me.ClientSize.Height / 2 - Me.Chart1.Height / 1.56)))
        Label1.Location = New Point(Convert.ToInt32(Me.Chart1.Width / 2 - Me.Label1.Width / 2), (Convert.ToInt32(Me.Chart1.Height / 2 - Me.Label1.Height / 2)))
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim contador As String = 0
        Dim contador2 As String = 0

        Dim compruebabeg As String = "select * from Alumno where Documento = " + CStr(consultar.cmb_al_al.SelectedValue) + ""
        Dim adap As New OleDbDataAdapter(compruebabeg, con)
        Dim com As New OleDbCommand(compruebabeg, con)
        Dim bdbeg As New DataTable
        adap.Fill(bdbeg)

        Dim mrbeg = com.ExecuteReader
        mrbeg.Read()
        lbl_beg.Text = "Posee BEG"
        Dim BEGP As Boolean
        If (mrbeg("BEG")).ToString = True Then
            BEGP = True
            lbl_beg.Visible = True

            If (mrbeg("CertificadoTrabajo")).ToString = True Then
                lbl_beg.Text = lbl_beg.Text + " y Certificado de Trabajo"
            End If

        ElseIf (mrbeg("CertificadoTrabajo")).ToString = True Then
            BEGP = False
            lbl_beg.Visible = True
            lbl_beg.Text = "Posee Certificado de Trabajo"
        Else
            BEGP = False
            lbl_beg.Visible = False
        End If






        If BEGP = True Then
            Dim cadenacomprobante As String = "select * from Asistencia where IdMateria = " + CStr(idmat) + " and IdCarrera = " + CStr(idcarr) + " and BEG = False"
            Dim adaptador As New OleDbDataAdapter(cadenacomprobante, con)
            Dim comando As New OleDbCommand(cadenacomprobante, con)
            Dim basededatos As New DataTable
            adaptador.Fill(basededatos)

            If basededatos.Rows.Count > 0 Then
                For Each row As DataRow In basededatos.Rows
                    contador = contador + 1
                Next
            End If

            Dim cadenacomprobante2 As String = "select * from Listado where IdAlumno = " + CStr(idal) + " and IdMateria = " + CStr(idmat) + " and presente = true and BEG = false"
            Dim adaptador2 As New OleDbDataAdapter(cadenacomprobante2, con)
            Dim comando2 As New OleDbCommand(cadenacomprobante2, con)
            Dim basededatos2 As New DataTable
            adaptador2.Fill(basededatos2)

            Dim myreader2 = comando2.ExecuteReader
            myreader2.Read()

            If basededatos2.Rows.Count > 0 Then
                For Each row As DataRow In basededatos2.Rows
                    contador2 = contador2 + 1
                Next

            End If



        End If
        If BEGP = False Then
            Dim cadenacomprobante As String = "select * from Asistencia where IdMateria = " + CStr(idmat) + " and IdCarrera = " + CStr(idcarr) + ""
            Dim adaptador As New OleDbDataAdapter(cadenacomprobante, con)
            Dim comando As New OleDbCommand(cadenacomprobante, con)
            Dim basededatos As New DataTable
            adaptador.Fill(basededatos)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim myreader = comando.ExecuteReader
            myreader.Read()

            If basededatos.Rows.Count > 0 Then
                For Each row As DataRow In basededatos.Rows
                    contador = contador + 1
                Next
            End If

            Dim cadenacomprobante2 As String = "select * from Listado where IdAlumno = " + CStr(idal) + " and IdMateria = " + CStr(idmat) + " and presente = true"
            Dim adaptador2 As New OleDbDataAdapter(cadenacomprobante2, con)
            Dim comando2 As New OleDbCommand(cadenacomprobante2, con)
            Dim basededatos2 As New DataTable
            adaptador2.Fill(basededatos2)

            Dim myreader2 = comando2.ExecuteReader
            myreader2.Read()

            If basededatos2.Rows.Count > 0 Then
                For Each row As DataRow In basededatos2.Rows
                    contador2 = contador2 + 1
                Next

            End If
        End If




        Dim total As String
        Dim asistencia As String
        Dim restante As String

        total = contador
        asistencia = contador2
        porcentaje = (CStr(asistencia * 100 / total))
        restante = 100 - porcentaje

        lbl_total.Text = ("En un total de " + CStr(contador) + " días de clases en " + añoal)
        lbl_dias_asistidos.Text = ("Asistió a " + CStr(contador2) + " días")
        lbl_procentaje.Text = ("Obteniendo un porcentaje de asistencia de " + CStr(Math.Truncate(CInt(porcentaje))) + ("%"))
        Label1.Text = (CStr(Math.Truncate(CInt(porcentaje))) + ("%"))
        lbl_nomal.Text = nomal
        con.Close()


        Dim PieSeries1 As New Charting.Series("Pie1")
        PieSeries1.ChartType = Charting.SeriesChartType.Doughnut
        PieSeries1.CustomProperties = "PieLabelStyle=Disabled"

        Chart1.Series.Clear()
        Chart1.Series.Insert(0, PieSeries1)

        Sectors.Clear()
        Sectors.Add(New SectorItem(porcentaje, "Asistidos"))
        Sectors.Add(New SectorItem(restante, "Faltados"))
        Sectors.ResetItem(0)
    End Sub
    Private Sub sectors_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Sectors.ListChanged
        If e.ListChangedType = ComponentModel.ListChangedType.ItemChanged Then
            Chart1.Series("Pie1").Points.DataBind(Sectors, "", "Value", "Label=Name")
        End If
    End Sub

    Private Class SectorItem

        Implements System.ComponentModel.INotifyPropertyChanged
        Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Public Sub New(ByVal tb As String, ByVal Name As String)
            Me._Name = Name
            Double.TryParse(tb, _Value)
        End Sub

        Private Sub NotifyPropertyChanged(ByVal info As String)
            RaiseEvent PropertyChanged(Me, New ComponentModel.PropertyChangedEventArgs(info))
        End Sub

        Private _Name As String
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                Dim notify As Boolean = Not String.Equals(_Name, value)
                _Name = value
                If notify Then NotifyPropertyChanged("Name")
            End Set
        End Property

        Private _Value As Double
        Public Property Value() As Double
            Get
                Return _Value
            End Get
            Set(ByVal value As Double)

                Dim notify As Boolean = (_Value <> value)
                _Value = value
                If notify Then NotifyPropertyChanged("Value")
            End Set
        End Property
    End Class


End Class