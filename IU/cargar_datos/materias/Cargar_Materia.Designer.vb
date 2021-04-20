<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargar_Materia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cargar_Materia))
        Me.cmb_prof = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_nom_mat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_carr = New System.Windows.Forms.ComboBox
        Me.txt_matid = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lbl_title = New System.Windows.Forms.Label
        Me.cmb_año = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_prof
        '
        Me.cmb_prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_prof.FormattingEnabled = True
        Me.cmb_prof.Location = New System.Drawing.Point(12, 136)
        Me.cmb_prof.Name = "cmb_prof"
        Me.cmb_prof.Size = New System.Drawing.Size(324, 21)
        Me.cmb_prof.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Profesor:"
        '
        'txt_nom_mat
        '
        Me.txt_nom_mat.BackColor = System.Drawing.Color.Silver
        Me.txt_nom_mat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nom_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_nom_mat.Location = New System.Drawing.Point(12, 85)
        Me.txt_nom_mat.Name = "txt_nom_mat"
        Me.txt_nom_mat.Size = New System.Drawing.Size(326, 19)
        Me.txt_nom_mat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nombre:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(10, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 39)
        Me.Button2.TabIndex = 6
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
        Me.Button1.Location = New System.Drawing.Point(176, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Carrera:"
        '
        'cmb_carr
        '
        Me.cmb_carr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_carr.FormattingEnabled = True
        Me.cmb_carr.Location = New System.Drawing.Point(12, 233)
        Me.cmb_carr.Name = "cmb_carr"
        Me.cmb_carr.Size = New System.Drawing.Size(326, 21)
        Me.cmb_carr.TabIndex = 5
        '
        'txt_matid
        '
        Me.txt_matid.BackColor = System.Drawing.Color.Silver
        Me.txt_matid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_matid.Enabled = False
        Me.txt_matid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_matid.Location = New System.Drawing.Point(279, 55)
        Me.txt_matid.Name = "txt_matid"
        Me.txt_matid.Size = New System.Drawing.Size(57, 19)
        Me.txt_matid.TabIndex = 3
        Me.txt_matid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(248, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Id:"
        Me.Label5.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(352, 53)
        Me.PictureBox2.TabIndex = 43
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
        Me.lbl_title.TabIndex = 45
        Me.lbl_title.Text = "DATOS DE LA MATERIA"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Location = New System.Drawing.Point(12, 187)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(326, 21)
        Me.cmb_año.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Año:"
        '
        'Cargar_Materia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(348, 318)
        Me.Controls.Add(Me.cmb_año)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmb_carr)
        Me.Controls.Add(Me.cmb_prof)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_matid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nom_mat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Cargar_Materia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Materia"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_prof As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nom_mat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_carr As System.Windows.Forms.ComboBox
    Friend WithEvents txt_matid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents cmb_año As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
