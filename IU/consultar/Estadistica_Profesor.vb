Imports System.Data.OleDb
Imports System.Data

Imports Charting = System.Windows.Forms.DataVisualization.Charting
Imports ComponentModel = System.ComponentModel
Public Class Estadistica_Profesor
    Private WithEvents Sectors As New ComponentModel.BindingList(Of SectorItem)
    Public porcentaje As String
    Public idprof As String
    Public nomprof As String
    Public añoprof As String

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
    Private Sub Estadistica_Profesor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If nomprof.Length > 37 Then
            lbl_nomprof.Font = New Font("Calibri", 15)
        Else
            lbl_nomprof.Font = New Font("Calibri", 18)
        End If

        Label1.Parent = Chart1
        Chart1.Location = New Point(Convert.ToInt32(Me.ClientSize.Width / 2 - Me.Chart1.Width / 2), (Convert.ToInt32(Me.ClientSize.Height / 2 - Me.Chart1.Height / 1.56)))
        Label1.Location = New Point(Convert.ToInt32(Me.Chart1.Width / 2 - Me.Label1.Width / 2), (Convert.ToInt32(Me.Chart1.Height / 2 - Me.Label1.Height / 2)))
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim contador As String = 0
        Dim contador2 As String = 0
        Dim contador3 As String = 0



        Dim cadprofmat As String = "select * from Materias where IdProfesor = " + CStr(consultar.cmb_prof.SelectedValue) + ""
        Dim adap As New OleDbDataAdapter(cadprofmat, con)
        Dim com As New OleDbCommand(cadprofmat, con)
        Dim profmat As New DataTable
        adap.Fill(profmat)

 
        Dim idmatwp As String

        Using profmatcomp As OleDbDataReader = com.ExecuteReader()
            If profmatcomp.HasRows() Then

                While profmatcomp.Read()
                    idmatwp = (profmatcomp("id")).ToString

                    Dim cadenacomprobante As String = "select * from Listado where IdMateria = " + idmatwp + ""
                    Dim adaptador As New OleDbDataAdapter(cadenacomprobante, con)
                    Dim comando As New OleDbCommand(cadenacomprobante, con)
                    Dim basededatos As New DataTable
                    adaptador.Fill(basededatos)


                    If basededatos.Rows.Count > 0 Then
                        For Each row As DataRow In basededatos.Rows
                            contador = contador + 1
                        Next
                    End If
                    Dim cadenacomprobante2 As String = "select * from Listado where IdMateria = " + idmatwp + " and Presente = True"
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

                    Dim cadenacomprobante3 As String = "select * from Asistencia where IdMateria = " + idmatwp + ""
                    Dim adaptador3 As New OleDbDataAdapter(cadenacomprobante3, con)
                    Dim comando3 As New OleDbCommand(cadenacomprobante3, con)
                    Dim basededatos3 As New DataTable
                    adaptador3.Fill(basededatos3)

                    Dim myreader3 = comando3.ExecuteReader
                    myreader3.Read()


                    If basededatos3.Rows.Count > 0 Then
                        For Each row As DataRow In basededatos3.Rows
                            contador3 = contador3 + 1
                        Next

                    End If


                End While






            End If


            profmatcomp.Close()

        End Using

 








        Dim total As String
        Dim asistencia As String
        Dim restante As String

        total = contador
        asistencia = contador2
        porcentaje = (CStr(asistencia * 100 / total))
        restante = 100 - porcentaje

        lbl_total.Text = ("Impartió un total de " + CStr(contador3) + " días de clases en " + añoprof)
        lbl_procentaje.Text = ("Sus alumnos asistieron un " + CStr(Math.Truncate(CInt(porcentaje))) + ("%"))
        Label1.Text = (CStr(Math.Truncate(CInt(porcentaje))) + ("%"))
        lbl_nomprof.Text = nomprof
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