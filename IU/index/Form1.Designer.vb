<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.btn_tomar_asistencias = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.btn_consultar = New System.Windows.Forms.Button
        Me.btn_Cargar_Datos = New System.Windows.Forms.Button
        Me.lbl_title = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(679, 369)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "GRID"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(219, 334)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Borrar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(111, 334)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Modificar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(3, 334)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Agregar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(3, 6)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(670, 322)
        Me.DataGridView3.TabIndex = 8
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridView4)
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.Button8)
        Me.TabPage4.Controls.Add(Me.Button9)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(679, 369)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Alumnos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(6, 45)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(667, 271)
        Me.DataGridView4.TabIndex = 4
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(340, 6)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(333, 33)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Cargar Datos"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(6, 322)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(667, 33)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(6, 6)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(333, 33)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btn_tomar_asistencias
        '
        Me.btn_tomar_asistencias.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_tomar_asistencias.BackgroundImage = Global.ABMAsistencia.My.Resources.Resources.v
        Me.btn_tomar_asistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tomar_asistencias.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btn_tomar_asistencias.ForeColor = System.Drawing.Color.White
        Me.btn_tomar_asistencias.Location = New System.Drawing.Point(293, 290)
        Me.btn_tomar_asistencias.Name = "btn_tomar_asistencias"
        Me.btn_tomar_asistencias.Size = New System.Drawing.Size(252, 86)
        Me.btn_tomar_asistencias.TabIndex = 3
        Me.btn_tomar_asistencias.Text = "      TOMAR ASISTENCIA"
        Me.btn_tomar_asistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tomar_asistencias.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABMAsistencia.My.Resources.Resources.carena1
        Me.PictureBox2.Location = New System.Drawing.Point(8, 107)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(279, 269)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ABMAsistencia.My.Resources.Resources.piso
        Me.PictureBox3.Location = New System.Drawing.Point(0, 386)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(514, 75)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'btn_consultar
        '
        Me.btn_consultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_consultar.BackgroundImage = Global.ABMAsistencia.My.Resources.Resources.b
        Me.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btn_consultar.ForeColor = System.Drawing.Color.White
        Me.btn_consultar.Location = New System.Drawing.Point(293, 199)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(252, 85)
        Me.btn_consultar.TabIndex = 2
        Me.btn_consultar.Text = "      CONSULTAR"
        Me.btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_consultar.UseVisualStyleBackColor = False
        '
        'btn_Cargar_Datos
        '
        Me.btn_Cargar_Datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_Cargar_Datos.BackgroundImage = Global.ABMAsistencia.My.Resources.Resources.c
        Me.btn_Cargar_Datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Cargar_Datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cargar_Datos.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btn_Cargar_Datos.ForeColor = System.Drawing.Color.White
        Me.btn_Cargar_Datos.Location = New System.Drawing.Point(293, 107)
        Me.btn_Cargar_Datos.Name = "btn_Cargar_Datos"
        Me.btn_Cargar_Datos.Size = New System.Drawing.Size(252, 86)
        Me.btn_Cargar_Datos.TabIndex = 1
        Me.btn_Cargar_Datos.Text = "     CARGAR DATOS"
        Me.btn_Cargar_Datos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cargar_Datos.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 28.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(554, 89)
        Me.lbl_title.TabIndex = 36
        Me.lbl_title.Text = "Sistema de Asistencias"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(554, 75)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Tesis Software III"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(801, 107)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(320, 86)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(801, 199)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(320, 85)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 38
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(801, 290)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(320, 82)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 38
        Me.PictureBox7.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(554, 461)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.btn_tomar_asistencias)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_Cargar_Datos)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btn_tomar_asistencias As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents btn_Cargar_Datos As System.Windows.Forms.Button
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox

End Class
