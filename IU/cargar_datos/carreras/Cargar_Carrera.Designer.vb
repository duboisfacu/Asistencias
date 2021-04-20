<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargar_Carrera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cargar_Carrera))
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_name_carr = New System.Windows.Forms.TextBox
        Me.lbl_name = New System.Windows.Forms.Label
        Me.txt_anio_carr = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.combobox1 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lbl_title = New System.Windows.Forms.Label
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 39)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(178, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_name_carr
        '
        Me.txt_name_carr.BackColor = System.Drawing.Color.Silver
        Me.txt_name_carr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_name_carr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_name_carr.Location = New System.Drawing.Point(12, 85)
        Me.txt_name_carr.Name = "txt_name_carr"
        Me.txt_name_carr.Size = New System.Drawing.Size(326, 19)
        Me.txt_name_carr.TabIndex = 1
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_name.Location = New System.Drawing.Point(8, 63)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(64, 19)
        Me.lbl_name.TabIndex = 25
        Me.lbl_name.Text = "Nombre:"
        '
        'txt_anio_carr
        '
        Me.txt_anio_carr.BackColor = System.Drawing.Color.Silver
        Me.txt_anio_carr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_anio_carr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_anio_carr.Location = New System.Drawing.Point(12, 129)
        Me.txt_anio_carr.Name = "txt_anio_carr"
        Me.txt_anio_carr.Size = New System.Drawing.Size(326, 19)
        Me.txt_anio_carr.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Preceptor:"
        '
        'combobox1
        '
        Me.combobox1.BackColor = System.Drawing.Color.Silver
        Me.combobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox1.FormattingEnabled = True
        Me.combobox1.Location = New System.Drawing.Point(12, 173)
        Me.combobox1.Name = "combobox1"
        Me.combobox1.Size = New System.Drawing.Size(326, 21)
        Me.combobox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Id:"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.Silver
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_id.Location = New System.Drawing.Point(12, 219)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(326, 19)
        Me.txt_id.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(352, 53)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_title.Font = New System.Drawing.Font("Calibri", 17.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(-2, -4)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(352, 53)
        Me.lbl_title.TabIndex = 34
        Me.lbl_title.Text = "DATOS DE LA CARRERA"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cargar_Carrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(348, 304)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.combobox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_anio_carr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_name_carr)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Cargar_Carrera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Carreras"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_name_carr As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_anio_carr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents combobox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_title As System.Windows.Forms.Label
End Class
