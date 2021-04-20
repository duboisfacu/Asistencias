<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info))
        Me.lbl_title = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbl_info = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_title.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(404, 50)
        Me.lbl_title.TabIndex = 37
        Me.lbl_title.Text = "¿Este día afecta a alumnos con BEG?"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(16, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(373, 39)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Entendido"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_info.Location = New System.Drawing.Point(12, 62)
        Me.lbl_info.MaximumSize = New System.Drawing.Size(386, 292)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(377, 76)
        Me.lbl_info.TabIndex = 39
        Me.lbl_info.Text = "Se debe seleccionar esta casilla en un día donde no hayan transportes públicos ya" & _
            " que si un alumno posee el boleto educativo gratuito su falta no tendra valor en" & _
            " la estadística final"
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 200)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_title)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_info As System.Windows.Forms.Label
End Class
