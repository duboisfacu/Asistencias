<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadistica_Profesor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estadistica_Profesor))
        Me.lbl_nomprof = New System.Windows.Forms.Label
        Me.lbl_procentaje = New System.Windows.Forms.Label
        Me.lbl_total = New System.Windows.Forms.Label
        Me.lbl_beg = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nomprof
        '
        Me.lbl_nomprof.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_nomprof.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_nomprof.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.lbl_nomprof.ForeColor = System.Drawing.Color.White
        Me.lbl_nomprof.Location = New System.Drawing.Point(0, 0)
        Me.lbl_nomprof.Name = "lbl_nomprof"
        Me.lbl_nomprof.Size = New System.Drawing.Size(394, 57)
        Me.lbl_nomprof.TabIndex = 41
        Me.lbl_nomprof.Text = "NOMBRE DEL PROFESOR"
        Me.lbl_nomprof.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_procentaje
        '
        Me.lbl_procentaje.BackColor = System.Drawing.Color.DimGray
        Me.lbl_procentaje.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_procentaje.ForeColor = System.Drawing.Color.White
        Me.lbl_procentaje.Location = New System.Drawing.Point(12, 420)
        Me.lbl_procentaje.Name = "lbl_procentaje"
        Me.lbl_procentaje.Size = New System.Drawing.Size(370, 19)
        Me.lbl_procentaje.TabIndex = 38
        Me.lbl_procentaje.Text = "Porcentaje de asistencia"
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.DimGray
        Me.lbl_total.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.White
        Me.lbl_total.Location = New System.Drawing.Point(12, 389)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(370, 19)
        Me.lbl_total.TabIndex = 37
        Me.lbl_total.Text = "Total de dias"
        '
        'lbl_beg
        '
        Me.lbl_beg.BackColor = System.Drawing.Color.DimGray
        Me.lbl_beg.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_beg.ForeColor = System.Drawing.Color.White
        Me.lbl_beg.Location = New System.Drawing.Point(0, 345)
        Me.lbl_beg.Name = "lbl_beg"
        Me.lbl_beg.Size = New System.Drawing.Size(394, 31)
        Me.lbl_beg.TabIndex = 36
        Me.lbl_beg.Text = "Posee BEG"
        Me.lbl_beg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_beg.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox3.Location = New System.Drawing.Point(0, 375)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(394, 96)
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row
        Legend1.Name = "Legend1"
        Legend1.Position.Auto = False
        Legend1.Position.Height = 10.0!
        Legend1.Position.Width = 100.0!
        Legend1.Position.Y = 90.0!
        Legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(71, 50)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(13, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer)), System.Drawing.Color.DimGray}
        Series1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(256, 292)
        Me.Chart1.TabIndex = 40
        Me.Chart1.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(158, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 45)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "100%"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Estadistica_Profesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(394, 471)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_nomprof)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_beg)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lbl_procentaje)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Estadistica_Profesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadisticas del Profesor"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_nomprof As System.Windows.Forms.Label
    Friend WithEvents lbl_procentaje As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_beg As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Public WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
