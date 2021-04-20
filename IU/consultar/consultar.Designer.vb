<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultar))
        Me.btn_al = New System.Windows.Forms.Button
        Me.cmb_al_carr = New System.Windows.Forms.ComboBox
        Me.lbl_carr = New System.Windows.Forms.Label
        Me.lbl_mat = New System.Windows.Forms.Label
        Me.cmb_al_mat = New System.Windows.Forms.ComboBox
        Me.lbl_al = New System.Windows.Forms.Label
        Me.cmb_al_al = New System.Windows.Forms.ComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.inicio = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_info = New System.Windows.Forms.Label
        Me.por_alumno = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_año_al = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.por_materia = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_año_mat = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_mat = New System.Windows.Forms.Button
        Me.cmb_mat_mat = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_mat_carr = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.por_carrera = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_año_carr = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btn_carr = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_carr_carr = New System.Windows.Forms.ComboBox
        Me.por_profesor = New System.Windows.Forms.TabPage
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmb_año_prof = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btn_prof = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmb_prof = New System.Windows.Forms.ComboBox
        Me.lbl_title = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1.SuspendLayout()
        Me.inicio.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.por_alumno.SuspendLayout()
        Me.por_materia.SuspendLayout()
        Me.por_carrera.SuspendLayout()
        Me.por_profesor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_al
        '
        Me.btn_al.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_al.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btn_al.ForeColor = System.Drawing.Color.White
        Me.btn_al.Location = New System.Drawing.Point(68, 270)
        Me.btn_al.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_al.Name = "btn_al"
        Me.btn_al.Size = New System.Drawing.Size(250, 37)
        Me.btn_al.TabIndex = 4
        Me.btn_al.Text = "Consultar"
        Me.btn_al.UseVisualStyleBackColor = False
        '
        'cmb_al_carr
        '
        Me.cmb_al_carr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_al_carr.FormattingEnabled = True
        Me.cmb_al_carr.Location = New System.Drawing.Point(68, 132)
        Me.cmb_al_carr.Name = "cmb_al_carr"
        Me.cmb_al_carr.Size = New System.Drawing.Size(250, 21)
        Me.cmb_al_carr.TabIndex = 1
        '
        'lbl_carr
        '
        Me.lbl_carr.AutoSize = True
        Me.lbl_carr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_carr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_carr.Location = New System.Drawing.Point(64, 110)
        Me.lbl_carr.Name = "lbl_carr"
        Me.lbl_carr.Size = New System.Drawing.Size(57, 19)
        Me.lbl_carr.TabIndex = 5
        Me.lbl_carr.Text = "Carrera"
        '
        'lbl_mat
        '
        Me.lbl_mat.AutoSize = True
        Me.lbl_mat.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_mat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_mat.Location = New System.Drawing.Point(64, 161)
        Me.lbl_mat.Name = "lbl_mat"
        Me.lbl_mat.Size = New System.Drawing.Size(60, 19)
        Me.lbl_mat.TabIndex = 5
        Me.lbl_mat.Text = "Materia"
        '
        'cmb_al_mat
        '
        Me.cmb_al_mat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_al_mat.FormattingEnabled = True
        Me.cmb_al_mat.Location = New System.Drawing.Point(68, 183)
        Me.cmb_al_mat.Name = "cmb_al_mat"
        Me.cmb_al_mat.Size = New System.Drawing.Size(250, 21)
        Me.cmb_al_mat.TabIndex = 2
        '
        'lbl_al
        '
        Me.lbl_al.AutoSize = True
        Me.lbl_al.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_al.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_al.Location = New System.Drawing.Point(64, 212)
        Me.lbl_al.Name = "lbl_al"
        Me.lbl_al.Size = New System.Drawing.Size(58, 19)
        Me.lbl_al.TabIndex = 5
        Me.lbl_al.Text = "Alumno"
        '
        'cmb_al_al
        '
        Me.cmb_al_al.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_al_al.FormattingEnabled = True
        Me.cmb_al_al.Location = New System.Drawing.Point(68, 234)
        Me.cmb_al_al.Name = "cmb_al_al"
        Me.cmb_al_al.Size = New System.Drawing.Size(250, 21)
        Me.cmb_al_al.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.inicio)
        Me.TabControl1.Controls.Add(Me.por_alumno)
        Me.TabControl1.Controls.Add(Me.por_materia)
        Me.TabControl1.Controls.Add(Me.por_carrera)
        Me.TabControl1.Controls.Add(Me.por_profesor)
        Me.TabControl1.Location = New System.Drawing.Point(0, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(397, 371)
        Me.TabControl1.TabIndex = 0
        '
        'inicio
        '
        Me.inicio.Controls.Add(Me.PictureBox2)
        Me.inicio.Controls.Add(Me.Label9)
        Me.inicio.Controls.Add(Me.lbl_info)
        Me.inicio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inicio.Location = New System.Drawing.Point(4, 22)
        Me.inicio.Name = "inicio"
        Me.inicio.Padding = New System.Windows.Forms.Padding(3)
        Me.inicio.Size = New System.Drawing.Size(389, 345)
        Me.inicio.TabIndex = 1
        Me.inicio.Text = "¿Consultas?"
        Me.inicio.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABMAsistencia.My.Resources.Resources.carena1
        Me.PictureBox2.Location = New System.Drawing.Point(1, 119)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(388, 136)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(0, 24)
        Me.Label9.MaximumSize = New System.Drawing.Size(386, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(386, 33)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "¡Bienvenido a Consultas!"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_info
        '
        Me.lbl_info.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_info.Location = New System.Drawing.Point(0, 57)
        Me.lbl_info.MaximumSize = New System.Drawing.Size(386, 292)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(386, 48)
        Me.lbl_info.TabIndex = 40
        Me.lbl_info.Text = "Navegá por las pestañas superiores para generar diferentes estadísticas de acuerd" & _
            "o a tu búsqueda."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'por_alumno
        '
        Me.por_alumno.BackColor = System.Drawing.SystemColors.Control
        Me.por_alumno.Controls.Add(Me.Label1)
        Me.por_alumno.Controls.Add(Me.cmb_al_al)
        Me.por_alumno.Controls.Add(Me.cmb_año_al)
        Me.por_alumno.Controls.Add(Me.btn_al)
        Me.por_alumno.Controls.Add(Me.cmb_al_mat)
        Me.por_alumno.Controls.Add(Me.lbl_carr)
        Me.por_alumno.Controls.Add(Me.lbl_al)
        Me.por_alumno.Controls.Add(Me.cmb_al_carr)
        Me.por_alumno.Controls.Add(Me.lbl_mat)
        Me.por_alumno.Controls.Add(Me.Label10)
        Me.por_alumno.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.por_alumno.Location = New System.Drawing.Point(4, 22)
        Me.por_alumno.Name = "por_alumno"
        Me.por_alumno.Padding = New System.Windows.Forms.Padding(3)
        Me.por_alumno.Size = New System.Drawing.Size(389, 345)
        Me.por_alumno.TabIndex = 0
        Me.por_alumno.Text = "Por Alumno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Año:"
        '
        'cmb_año_al
        '
        Me.cmb_año_al.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año_al.FormattingEnabled = True
        Me.cmb_año_al.Location = New System.Drawing.Point(68, 86)
        Me.cmb_año_al.Name = "cmb_año_al"
        Me.cmb_año_al.Size = New System.Drawing.Size(250, 21)
        Me.cmb_año_al.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(0, 24)
        Me.Label10.MaximumSize = New System.Drawing.Size(386, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(386, 33)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Consulta por Alumno"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'por_materia
        '
        Me.por_materia.Controls.Add(Me.Label3)
        Me.por_materia.Controls.Add(Me.cmb_año_mat)
        Me.por_materia.Controls.Add(Me.Label7)
        Me.por_materia.Controls.Add(Me.btn_mat)
        Me.por_materia.Controls.Add(Me.cmb_mat_mat)
        Me.por_materia.Controls.Add(Me.Label2)
        Me.por_materia.Controls.Add(Me.cmb_mat_carr)
        Me.por_materia.Controls.Add(Me.Label4)
        Me.por_materia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.por_materia.Location = New System.Drawing.Point(4, 22)
        Me.por_materia.Name = "por_materia"
        Me.por_materia.Size = New System.Drawing.Size(389, 345)
        Me.por_materia.TabIndex = 2
        Me.por_materia.Text = "Por Materia"
        Me.por_materia.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(64, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Año:"
        '
        'cmb_año_mat
        '
        Me.cmb_año_mat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año_mat.FormattingEnabled = True
        Me.cmb_año_mat.Location = New System.Drawing.Point(68, 86)
        Me.cmb_año_mat.Name = "cmb_año_mat"
        Me.cmb_año_mat.Size = New System.Drawing.Size(250, 21)
        Me.cmb_año_mat.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(0, 24)
        Me.Label7.MaximumSize = New System.Drawing.Size(386, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(386, 33)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Consulta por Materia"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_mat
        '
        Me.btn_mat.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_mat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mat.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btn_mat.ForeColor = System.Drawing.Color.White
        Me.btn_mat.Location = New System.Drawing.Point(68, 219)
        Me.btn_mat.Name = "btn_mat"
        Me.btn_mat.Size = New System.Drawing.Size(250, 37)
        Me.btn_mat.TabIndex = 7
        Me.btn_mat.Text = "Consultar"
        Me.btn_mat.UseVisualStyleBackColor = False
        '
        'cmb_mat_mat
        '
        Me.cmb_mat_mat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mat_mat.FormattingEnabled = True
        Me.cmb_mat_mat.Location = New System.Drawing.Point(68, 183)
        Me.cmb_mat_mat.Name = "cmb_mat_mat"
        Me.cmb_mat_mat.Size = New System.Drawing.Size(250, 21)
        Me.cmb_mat_mat.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(64, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Carrera"
        '
        'cmb_mat_carr
        '
        Me.cmb_mat_carr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mat_carr.FormattingEnabled = True
        Me.cmb_mat_carr.Location = New System.Drawing.Point(68, 132)
        Me.cmb_mat_carr.Name = "cmb_mat_carr"
        Me.cmb_mat_carr.Size = New System.Drawing.Size(250, 21)
        Me.cmb_mat_carr.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(64, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Materia"
        '
        'por_carrera
        '
        Me.por_carrera.Controls.Add(Me.Label6)
        Me.por_carrera.Controls.Add(Me.cmb_año_carr)
        Me.por_carrera.Controls.Add(Me.Label11)
        Me.por_carrera.Controls.Add(Me.btn_carr)
        Me.por_carrera.Controls.Add(Me.Label5)
        Me.por_carrera.Controls.Add(Me.cmb_carr_carr)
        Me.por_carrera.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.por_carrera.Location = New System.Drawing.Point(4, 22)
        Me.por_carrera.Name = "por_carrera"
        Me.por_carrera.Size = New System.Drawing.Size(389, 345)
        Me.por_carrera.TabIndex = 3
        Me.por_carrera.Text = "Por Carrera"
        Me.por_carrera.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(64, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 19)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Año:"
        '
        'cmb_año_carr
        '
        Me.cmb_año_carr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año_carr.FormattingEnabled = True
        Me.cmb_año_carr.Location = New System.Drawing.Point(68, 86)
        Me.cmb_año_carr.Name = "cmb_año_carr"
        Me.cmb_año_carr.Size = New System.Drawing.Size(250, 21)
        Me.cmb_año_carr.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(0, 24)
        Me.Label11.MaximumSize = New System.Drawing.Size(386, 292)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(386, 33)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Consulta por Carrera"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_carr
        '
        Me.btn_carr.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_carr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_carr.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btn_carr.ForeColor = System.Drawing.Color.White
        Me.btn_carr.Location = New System.Drawing.Point(68, 168)
        Me.btn_carr.Name = "btn_carr"
        Me.btn_carr.Size = New System.Drawing.Size(250, 37)
        Me.btn_carr.TabIndex = 9
        Me.btn_carr.Text = "Consultar"
        Me.btn_carr.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(64, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Carrera"
        '
        'cmb_carr_carr
        '
        Me.cmb_carr_carr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_carr_carr.FormattingEnabled = True
        Me.cmb_carr_carr.Location = New System.Drawing.Point(68, 132)
        Me.cmb_carr_carr.Name = "cmb_carr_carr"
        Me.cmb_carr_carr.Size = New System.Drawing.Size(250, 21)
        Me.cmb_carr_carr.TabIndex = 8
        '
        'por_profesor
        '
        Me.por_profesor.Controls.Add(Me.Label13)
        Me.por_profesor.Controls.Add(Me.cmb_año_prof)
        Me.por_profesor.Controls.Add(Me.Label12)
        Me.por_profesor.Controls.Add(Me.btn_prof)
        Me.por_profesor.Controls.Add(Me.Label8)
        Me.por_profesor.Controls.Add(Me.cmb_prof)
        Me.por_profesor.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.por_profesor.Location = New System.Drawing.Point(4, 22)
        Me.por_profesor.Name = "por_profesor"
        Me.por_profesor.Size = New System.Drawing.Size(389, 345)
        Me.por_profesor.TabIndex = 4
        Me.por_profesor.Text = "Por Profesor"
        Me.por_profesor.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(64, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 19)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Año:"
        '
        'cmb_año_prof
        '
        Me.cmb_año_prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año_prof.FormattingEnabled = True
        Me.cmb_año_prof.Location = New System.Drawing.Point(68, 86)
        Me.cmb_año_prof.Name = "cmb_año_prof"
        Me.cmb_año_prof.Size = New System.Drawing.Size(250, 21)
        Me.cmb_año_prof.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(0, 24)
        Me.Label12.MaximumSize = New System.Drawing.Size(386, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(386, 33)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Consulta por Profesor"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_prof
        '
        Me.btn_prof.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prof.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btn_prof.ForeColor = System.Drawing.Color.White
        Me.btn_prof.Location = New System.Drawing.Point(68, 168)
        Me.btn_prof.Name = "btn_prof"
        Me.btn_prof.Size = New System.Drawing.Size(250, 37)
        Me.btn_prof.TabIndex = 11
        Me.btn_prof.Text = "Consultar"
        Me.btn_prof.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(64, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Profesor"
        '
        'cmb_prof
        '
        Me.cmb_prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_prof.FormattingEnabled = True
        Me.cmb_prof.Location = New System.Drawing.Point(68, 132)
        Me.cmb_prof.Name = "cmb_prof"
        Me.cmb_prof.Size = New System.Drawing.Size(250, 21)
        Me.cmb_prof.TabIndex = 10
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_title.Font = New System.Drawing.Font("Calibri", 22.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(-2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(399, 57)
        Me.lbl_title.TabIndex = 34
        Me.lbl_title.Text = "CONSULTAS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ABMAsistencia.My.Resources.Resources.piso
        Me.PictureBox1.Location = New System.Drawing.Point(0, 425)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(397, 56)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(394, 477)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "consultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar"
        Me.TabControl1.ResumeLayout(False)
        Me.inicio.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.por_alumno.ResumeLayout(False)
        Me.por_alumno.PerformLayout()
        Me.por_materia.ResumeLayout(False)
        Me.por_materia.PerformLayout()
        Me.por_carrera.ResumeLayout(False)
        Me.por_carrera.PerformLayout()
        Me.por_profesor.ResumeLayout(False)
        Me.por_profesor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_al As System.Windows.Forms.Button
    Friend WithEvents cmb_al_carr As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_carr As System.Windows.Forms.Label
    Friend WithEvents lbl_mat As System.Windows.Forms.Label
    Friend WithEvents cmb_al_mat As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_al As System.Windows.Forms.Label
    Friend WithEvents cmb_al_al As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents por_alumno As System.Windows.Forms.TabPage
    Friend WithEvents inicio As System.Windows.Forms.TabPage
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents por_materia As System.Windows.Forms.TabPage
    Friend WithEvents por_carrera As System.Windows.Forms.TabPage
    Friend WithEvents por_profesor As System.Windows.Forms.TabPage
    Friend WithEvents btn_mat As System.Windows.Forms.Button
    Friend WithEvents cmb_mat_mat As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_mat_carr As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_carr As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_carr_carr As System.Windows.Forms.ComboBox
    Friend WithEvents btn_prof As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_prof As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_info As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_año_al As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_año_mat As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_año_carr As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_año_prof As System.Windows.Forms.ComboBox
End Class
