<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista))
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.lbl_carrera = New System.Windows.Forms.Label
        Me.lbl_materia = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbl_title = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 129)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.ScrollAlwaysVisible = True
        Me.CheckedListBox1.Size = New System.Drawing.Size(314, 175)
        Me.CheckedListBox1.TabIndex = 1
        '
        'lbl_carrera
        '
        Me.lbl_carrera.AutoSize = True
        Me.lbl_carrera.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_carrera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_carrera.Location = New System.Drawing.Point(8, 63)
        Me.lbl_carrera.Name = "lbl_carrera"
        Me.lbl_carrera.Size = New System.Drawing.Size(52, 19)
        Me.lbl_carrera.TabIndex = 2
        Me.lbl_carrera.Text = "Label1"
        '
        'lbl_materia
        '
        Me.lbl_materia.AutoSize = True
        Me.lbl_materia.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_materia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_materia.Location = New System.Drawing.Point(8, 85)
        Me.lbl_materia.Name = "lbl_materia"
        Me.lbl_materia.Size = New System.Drawing.Size(52, 19)
        Me.lbl_materia.TabIndex = 3
        Me.lbl_materia.Text = "Label2"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_fecha.Location = New System.Drawing.Point(8, 107)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(52, 19)
        Me.lbl_fecha.TabIndex = 4
        Me.lbl_fecha.Text = "Label3"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(168, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Tomar Lista"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_title.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(338, 53)
        Me.lbl_title.TabIndex = 36
        Me.lbl_title.Text = "LISTADO DE ALUMNOS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 319)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(150, 39)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_materia)
        Me.Controls.Add(Me.lbl_carrera)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Lista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_carrera As System.Windows.Forms.Label
    Friend WithEvents lbl_materia As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
