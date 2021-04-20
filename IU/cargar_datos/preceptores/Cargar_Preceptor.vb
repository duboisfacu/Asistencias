Imports System.Data.OleDb
Public Class Cargar_Preceptor
    Private prece_ As New Preceptores
    Private precenuevo_ As Boolean

    Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
    Public Dst As New DataSet
    Public Cmd As OleDbCommand
    Public Dad As OleDbDataAdapter
    Public precep_icon As String
    Public CurrentRow

    Public Property prece() As Preceptores
        Get
            Return prece_
        End Get
        Set(ByVal value As Preceptores)
            prece_ = value
        End Set
    End Property

    Private Property precenuevo() As Boolean
        Get
            Return precenuevo_
        End Get
        Set(ByVal value As Boolean)
            precenuevo_ = value
        End Set
    End Property
    Private Function IsIdExist()
        Dim Str, Str1 As String
        Dim i As Integer

        Str = txt_doc.Text
        i = 0
        While i <> Dst.Tables("Preceptor").Rows.Count

            Str1 = Dst.Tables("Preceptor").Rows(i)("Documento")

            If Str = Str1 Then
                Return True

            End If
            i += 1


        End While


        Return False
    End Function
    Public Sub New(ByVal prece As Preceptores) 'Constructor para Modificar
        InitializeComponent()
        txt_doc.Text = prece.doc
        txt_name_prece.Text = prece.nombre
        txt_doc.Enabled = False


        Dim ts As New ToolStripButton

        ts.AutoSize = False
        ts.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts.TextImageRelation = TextImageRelation.Overlay
        ts.TextAlign = ContentAlignment.BottomCenter
        ts.Width = "70"
        ts.Height = "70"
        ts.CheckOnClick = True
        ts.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 14.75)
        ts.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_1.png")
        ts.Name = "..\\..\Resources\preceptor_icons\prec_1.png"
        ToolStrip1.Items.Add(ts)

        Dim ts2 As New ToolStripButton
        ts2.AutoSize = False
        ts2.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts2.TextImageRelation = TextImageRelation.Overlay
        ts2.TextAlign = ContentAlignment.BottomCenter
        ts2.Width = "70"
        ts2.Height = "70"
        ts2.CheckOnClick = True
        ts2.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts2.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_2.png")
        ts2.Name = "..\\..\Resources\preceptor_icons\prec_2.png"
        ToolStrip1.Items.Add(ts2)

        Dim ts3 As New ToolStripButton
        ts3.AutoSize = False
        ts3.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts3.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts3.TextImageRelation = TextImageRelation.Overlay
        ts3.TextAlign = ContentAlignment.BottomCenter
        ts3.Width = "70"
        ts3.Height = "70"
        ts3.CheckOnClick = True
        ts3.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts3.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_3.png")
        ts3.Name = "..\\..\Resources\preceptor_icons\prec_3.png"
        ToolStrip1.Items.Add(ts3)

        Dim ts4 As New ToolStripButton
        ts4.AutoSize = False
        ts4.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts4.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts4.TextImageRelation = TextImageRelation.Overlay
        ts4.TextAlign = ContentAlignment.BottomCenter
        ts4.Width = "70"
        ts4.Height = "70"
        ts4.CheckOnClick = True
        ts4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        ts4.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_4.png")
        ts4.Name = "..\\..\Resources\preceptor_icons\prec_4.png"
        ToolStrip1.Items.Add(ts4)

        Dim ts5 As New ToolStripButton
        ts5.AutoSize = False
        ts5.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts5.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts5.TextImageRelation = TextImageRelation.Overlay
        ts5.TextAlign = ContentAlignment.BottomCenter
        ts5.Width = "70"
        ts5.Height = "70"
        ts5.CheckOnClick = True
        ts5.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts5.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_5.png")
        ts5.Name = "..\\..\Resources\preceptor_icons\prec_5.png"
        ToolStrip1.Items.Add(ts5)

        Dim ts6 As New ToolStripButton
        ts6.AutoSize = False
        ts6.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts6.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts6.TextImageRelation = TextImageRelation.Overlay
        ts6.TextAlign = ContentAlignment.BottomCenter
        ts6.Width = "70"
        ts6.Height = "70"
        ts6.CheckOnClick = True
        ts6.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts6.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_6.png")
        ts6.Name = "..\\..\Resources\preceptor_icons\prec_6.png"
        ToolStrip1.Items.Add(ts6)

        Dim ts7 As New ToolStripButton
        ts7.AutoSize = False
        ts7.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts7.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts7.TextImageRelation = TextImageRelation.Overlay
        ts7.TextAlign = ContentAlignment.BottomCenter
        ts7.Width = "70"
        ts7.Height = "70"
        ts7.CheckOnClick = True
        ts7.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts7.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_7.png")
        ts7.Name = "..\\..\Resources\preceptor_icons\prec_7.png"
        ToolStrip1.Items.Add(ts7)

        Dim ts8 As New ToolStripButton
        ts8.AutoSize = False
        ts8.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts8.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts8.TextImageRelation = TextImageRelation.Overlay
        ts8.TextAlign = ContentAlignment.BottomCenter
        ts8.Width = "70"
        ts8.Height = "70"
        ts8.CheckOnClick = True
        ts8.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        ts8.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_8.png")
        ts8.Name = "..\\..\Resources\preceptor_icons\prec_8.png"
        ToolStrip1.Items.Add(ts8)
        AddHandler ts.Click, AddressOf ts_Click
        AddHandler ts2.Click, AddressOf ts_Click
        AddHandler ts3.Click, AddressOf ts_Click
        AddHandler ts4.Click, AddressOf ts_Click
        AddHandler ts5.Click, AddressOf ts_Click
        AddHandler ts6.Click, AddressOf ts_Click
        AddHandler ts7.Click, AddressOf ts_Click
        AddHandler ts8.Click, AddressOf ts_Click

        Dim ic As String = prece.prec_icon
        For Each button As ToolStripItem In Me.ToolStrip1.Items
            If button.Name = ic Then
                DirectCast(button, ToolStripButton).Checked = True
            End If
        Next



        Me.lbl_title.Text = "MODIFICAR DATOS DEL PRECEPTOR"
        Me.Button1.Text = "Modificar"
        Me.Text = "Modificar Preceptor"
        precenuevo = False
    End Sub

    Public Sub New() 'Constructor para Agregar
        InitializeComponent()
        txt_doc.Text = ""
        txt_name_prece.Text = ""

        Dim ts As New ToolStripButton

        ts.AutoSize = False
        ts.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts.TextImageRelation = TextImageRelation.Overlay
        ts.TextAlign = ContentAlignment.BottomCenter
        ts.Width = "70"
        ts.Height = "70"
        ts.CheckOnClick = True
        ts.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 14.75)
        ts.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_1.png")
        ts.Name = "..\\..\Resources\preceptor_icons\prec_1.png"
        ToolStrip1.Items.Add(ts)

        Dim ts2 As New ToolStripButton
        ts2.AutoSize = False
        ts2.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts2.TextImageRelation = TextImageRelation.Overlay
        ts2.TextAlign = ContentAlignment.BottomCenter
        ts2.Width = "70"
        ts2.Height = "70"
        ts2.CheckOnClick = True
        ts2.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts2.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_2.png")
        ts2.Name = "..\\..\Resources\preceptor_icons\prec_2.png"
        ToolStrip1.Items.Add(ts2)

        Dim ts3 As New ToolStripButton
        ts3.AutoSize = False
        ts3.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts3.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts3.TextImageRelation = TextImageRelation.Overlay
        ts3.TextAlign = ContentAlignment.BottomCenter
        ts3.Width = "70"
        ts3.Height = "70"
        ts3.CheckOnClick = True
        ts3.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts3.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_3.png")
        ts3.Name = "..\\..\Resources\preceptor_icons\prec_3.png"
        ToolStrip1.Items.Add(ts3)

        Dim ts4 As New ToolStripButton
        ts4.AutoSize = False
        ts4.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts4.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts4.TextImageRelation = TextImageRelation.Overlay
        ts4.TextAlign = ContentAlignment.BottomCenter
        ts4.Width = "70"
        ts4.Height = "70"
        ts4.CheckOnClick = True
        ts4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        ts4.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_4.png")
        ts4.Name = "..\\..\Resources\preceptor_icons\prec_4.png"
        ToolStrip1.Items.Add(ts4)

        Dim ts5 As New ToolStripButton
        ts5.AutoSize = False
        ts5.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts5.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts5.TextImageRelation = TextImageRelation.Overlay
        ts5.TextAlign = ContentAlignment.BottomCenter
        ts5.Width = "70"
        ts5.Height = "70"
        ts5.CheckOnClick = True
        ts5.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts5.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_5.png")
        ts5.Name = "..\\..\Resources\preceptor_icons\prec_5.png"
        ToolStrip1.Items.Add(ts5)

        Dim ts6 As New ToolStripButton
        ts6.AutoSize = False
        ts6.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts6.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts6.TextImageRelation = TextImageRelation.Overlay
        ts6.TextAlign = ContentAlignment.BottomCenter
        ts6.Width = "70"
        ts6.Height = "70"
        ts6.CheckOnClick = True
        ts6.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts6.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_6.png")
        ts6.Name = "..\\..\Resources\preceptor_icons\prec_6.png"
        ToolStrip1.Items.Add(ts6)

        Dim ts7 As New ToolStripButton
        ts7.AutoSize = False
        ts7.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts7.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts7.TextImageRelation = TextImageRelation.Overlay
        ts7.TextAlign = ContentAlignment.BottomCenter
        ts7.Width = "70"
        ts7.Height = "70"
        ts7.CheckOnClick = True
        ts7.Margin = New System.Windows.Forms.Padding(0, 0, 14.75, 0)
        ts7.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_7.png")
        ts7.Name = "..\\..\Resources\preceptor_icons\prec_7.png"
        ToolStrip1.Items.Add(ts7)

        Dim ts8 As New ToolStripButton
        ts8.AutoSize = False
        ts8.ImageScaling = ToolStripItemImageScaling.SizeToFit
        ts8.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ts8.TextImageRelation = TextImageRelation.Overlay
        ts8.TextAlign = ContentAlignment.BottomCenter
        ts8.Width = "70"
        ts8.Height = "70"
        ts8.CheckOnClick = True
        ts8.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        ts8.Image = Image.FromFile("..\\..\Resources\preceptor_icons\prec_8.png")
        ts8.Name = "..\\..\Resources\preceptor_icons\prec_8.png"
        ToolStrip1.Items.Add(ts8)
        AddHandler ts.Click, AddressOf ts_Click
        AddHandler ts2.Click, AddressOf ts_Click
        AddHandler ts3.Click, AddressOf ts_Click
        AddHandler ts4.Click, AddressOf ts_Click
        AddHandler ts5.Click, AddressOf ts_Click
        AddHandler ts6.Click, AddressOf ts_Click
        AddHandler ts7.Click, AddressOf ts_Click
        AddHandler ts8.Click, AddressOf ts_Click

        Me.lbl_title.Text = "AGREGAR DATOS DEL PRECEPTOR"
        Me.Text = "Agregar Preceptor"
        precenuevo = True
    End Sub

    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_name_prece.Text = "" Or txt_doc.Text = "" Then
            MsgBox("Debes rellenar todos los campos para continuar")
            Return
        End If

        If Not IsNumeric(txt_doc.Text) And _
            txt_doc.Text <> "" Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            txt_doc.Text = ""
            Return
        End If

        If txt_doc.Text.Length > 9 Then
            Beep()
            MsgBox("El número de documento es muy largo")
            Return
        End If

        Dim seleccion As String = 0
        For Each item As ToolStripItem In Me.ToolStrip1.Items
            If DirectCast(item, ToolStripButton).Checked = True Then
                seleccion = 1
                precep_icon = item.Name
            End If
        Next

        If seleccion = 0 Then
            Beep()
            MsgBox("Se debe seleccionar un avatar")
            Return
        End If

        Me.txt_name_prece.Text = cambia(Me.txt_name_prece.Text)

        prece.nombre = txt_name_prece.Text
        prece.doc = txt_doc.Text
        prece.prec_icon = precep_icon

        If precenuevo = False Then
            prece.doc = txt_doc.Text
            prece.Modificar(prece)
            Close()
        Else
            If IsIdExist() = True Then
                MsgBox("El número de documento ya existe")
                txt_doc.Text = ""
                txt_doc.Focus()
                Return
            End If
            prece.Agregar(prece)
            Close()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Sub Cargar_Preceptor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CurrentRow = 0
        Con.Open()
        Dad = New OleDbDataAdapter("SELECT * FROM Preceptor", Con)
        Dad.Fill(Dst, "Preceptor")
        Con.Close()


    End Sub
    Private Sub ts_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim ts As ToolStripButton = DirectCast(sender, ToolStripButton)
        precep_icon = ts.Name

        For Each item As ToolStripItem In Me.ToolStrip1.Items
            If TypeOf item Is ToolStripButton AndAlso item IsNot sender Then
                DirectCast(item, ToolStripButton).Checked = False
            End If
        Next

    End Sub
    Private Sub txt_doc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_doc.KeyPress
        txt_doc.MaxLength = 8
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_name_prece_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_name_prece.KeyPress
        txt_name_prece.MaxLength = 100

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
End Class