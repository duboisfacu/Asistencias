Imports System.Data.OleDb
Imports System.Data
Public Class Seleccionador_Preceptor
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
    Private Sub Seleccionador_Preceptor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel2.Parent = PictureBox1
        lbl_title.Parent = PictureBox1
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim cadenacomprobante2 As String = "select * from Preceptor"
        Dim adaptador2 As New OleDbDataAdapter(cadenacomprobante2, con)
        Dim comando2 As New OleDbCommand(cadenacomprobante2, con)
        Dim basededatos2 As New DataTable
        adaptador2.Fill(basededatos2)



        Dim nombrepreceptor As String
        Dim idpreceptor As String
        Dim iconpreceptor As String

        Using profmatcomp As OleDbDataReader = comando2.ExecuteReader()
            If profmatcomp.HasRows() Then

                While profmatcomp.Read()
                    idpreceptor = (profmatcomp("Documento").ToString)
                    nombrepreceptor = (profmatcomp("Nombre").ToString)
                    iconpreceptor = (profmatcomp("prec_icon").ToString)
                    If basededatos2.Rows.Count > 0 Then

                        Dim ts As New ToolStripButton
                        ts.AutoSize = True
                        ts.ImageScaling = ToolStripItemImageScaling.None
                        ts.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        ts.TextImageRelation = TextImageRelation.ImageAboveText
                        ts.Text = nombrepreceptor
                        ts.TextAlign = ContentAlignment.BottomCenter
                        ts.Width = "100"
                        ts.Height = "100"

                        ts.Name = idpreceptor

                        ts.Image = Image.FromFile(iconpreceptor)
                        AddHandler ts.Click, AddressOf ts_Click

          

                        ToolStrip1.Items.Add(ts)
                    End If
                End While
            End If
        End Using

        If ToolStrip1.Items.Count > 2 Then
            ToolStrip1.Height = 351
            Me.Width = Me.Width + 17
            Me.Height = Me.Height + 175
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 85)
        End If
        If ToolStrip1.Items.Count > 4 Then
            ToolStrip1.Height = ToolStrip1.Height + 175
        End If

        If ToolStrip1.Items.Count > 6 Then
            ToolStrip1.Height = ToolStrip1.Height + 175
        End If

        If ToolStrip1.Items.Count > 8 Then
            ToolStrip1.Height = ToolStrip1.Height + 175
        End If

        If ToolStrip1.Items.Count > 10 Then
            ToolStrip1.Height = ToolStrip1.Height + 175
        End If

        If ToolStrip1.Items.Count > 12 Then
            ToolStrip1.Height = ToolStrip1.Height + 175
        End If

        If ToolStrip1.Items.Count > 14 Then
            ToolStrip1.Height = ToolStrip1.Height + 175
        End If

        If ToolStrip1.Items.Count > 16 Then
            ToolStrip1.Height = ToolStrip1.Height + 175
        End If

        If ToolStrip1.Items.Count > 18 Then
            ToolStrip1.Height = ToolStrip1.Height + 175
        End If
        con.Close()
    End Sub

    Private Sub ts_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ts As ToolStripButton = DirectCast(sender, ToolStripButton)

        Seleccionador.preceptor = ts.Name
        Seleccionador.Show()
        Me.Close()

    End Sub


    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Seleccionador.Show()
        Me.Close()

    End Sub
End Class