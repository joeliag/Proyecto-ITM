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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim IdcarreraLabel As System.Windows.Forms.Label
        Dim FecnacLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim NumcelLabel As System.Windows.Forms.Label
        Dim NumtelLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim FecestadoLabel As System.Windows.Forms.Label
        Dim FecingresoLabel As System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SexoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.IdcarreraTextBox = New System.Windows.Forms.TextBox()
        Me.FecnacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SexoTextBox = New System.Windows.Forms.TextBox()
        Me.NumcelTextBox = New System.Windows.Forms.TextBox()
        Me.NumtelTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.FecestadoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FecingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ALUMNOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        CodigoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        IdcarreraLabel = New System.Windows.Forms.Label()
        FecnacLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        NumcelLabel = New System.Windows.Forms.Label()
        NumtelLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        FecestadoLabel = New System.Windows.Forms.Label()
        FecingresoLabel = New System.Windows.Forms.Label()
        CType(Me.ALUMNOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoLabel.Location = New System.Drawing.Point(-136, -63)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(65, 20)
        CodigoLabel.TabIndex = 102
        CodigoLabel.Text = "Codigo"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(-137, -13)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(71, 20)
        NombreLabel.TabIndex = 104
        NombreLabel.Text = "Nombre"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.Location = New System.Drawing.Point(-137, 37)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(73, 20)
        ApellidoLabel.TabIndex = 106
        ApellidoLabel.Text = "Apellido"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DNILabel.Location = New System.Drawing.Point(-137, 140)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(40, 20)
        DNILabel.TabIndex = 108
        DNILabel.Text = "DNI"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexoLabel.Location = New System.Drawing.Point(-138, 87)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(49, 20)
        SexoLabel.TabIndex = 114
        SexoLabel.Text = "Sexo"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Location = New System.Drawing.Point(-157, -122)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(317, 45)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "Registro de Alumnos"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(259, 367)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 152
        '
        'SexoComboBox1
        '
        Me.SexoComboBox1.Enabled = False
        Me.SexoComboBox1.FormattingEnabled = True
        Me.SexoComboBox1.Items.AddRange(New Object() {"F", "M"})
        Me.SexoComboBox1.Location = New System.Drawing.Point(113, 217)
        Me.SexoComboBox1.Name = "SexoComboBox1"
        Me.SexoComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.SexoComboBox1.TabIndex = 151
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(21, 70)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(65, 20)
        Label1.TabIndex = 121
        Label1.Text = "Codigo"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Enabled = False
        Me.CodigoTextBox.Location = New System.Drawing.Point(113, 70)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CodigoTextBox.TabIndex = 122
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(20, 120)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(71, 20)
        Label2.TabIndex = 123
        Label2.Text = "Nombre"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(113, 117)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NombreTextBox.TabIndex = 124
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(20, 170)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(73, 20)
        Label3.TabIndex = 125
        Label3.Text = "Apellido"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.Enabled = False
        Me.ApellidoTextBox.Location = New System.Drawing.Point(113, 167)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ApellidoTextBox.TabIndex = 126
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(20, 273)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(40, 20)
        Label4.TabIndex = 127
        Label4.Text = "DNI"
        '
        'DNITextBox
        '
        Me.DNITextBox.Enabled = False
        Me.DNITextBox.Location = New System.Drawing.Point(112, 267)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(200, 26)
        Me.DNITextBox.TabIndex = 128
        '
        'IdcarreraLabel
        '
        IdcarreraLabel.AutoSize = True
        IdcarreraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdcarreraLabel.Location = New System.Drawing.Point(728, 125)
        IdcarreraLabel.Name = "IdcarreraLabel"
        IdcarreraLabel.Size = New System.Drawing.Size(85, 20)
        IdcarreraLabel.TabIndex = 129
        IdcarreraLabel.Text = "idcarrera:"
        '
        'IdcarreraTextBox
        '
        Me.IdcarreraTextBox.Location = New System.Drawing.Point(732, 146)
        Me.IdcarreraTextBox.Multiline = True
        Me.IdcarreraTextBox.Name = "IdcarreraTextBox"
        Me.IdcarreraTextBox.Size = New System.Drawing.Size(200, 26)
        Me.IdcarreraTextBox.TabIndex = 130
        '
        'FecnacLabel
        '
        FecnacLabel.AutoSize = True
        FecnacLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FecnacLabel.Location = New System.Drawing.Point(21, 318)
        FecnacLabel.Name = "FecnacLabel"
        FecnacLabel.Size = New System.Drawing.Size(178, 20)
        FecnacLabel.TabIndex = 131
        FecnacLabel.Text = "Fecha de Nacimiento"
        '
        'FecnacDateTimePicker
        '
        Me.FecnacDateTimePicker.Enabled = False
        Me.FecnacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecnacDateTimePicker.Location = New System.Drawing.Point(23, 348)
        Me.FecnacDateTimePicker.Name = "FecnacDateTimePicker"
        Me.FecnacDateTimePicker.Size = New System.Drawing.Size(125, 26)
        Me.FecnacDateTimePicker.TabIndex = 132
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(19, 220)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(49, 20)
        Label5.TabIndex = 133
        Label5.Text = "Sexo"
        '
        'SexoTextBox
        '
        Me.SexoTextBox.Enabled = False
        Me.SexoTextBox.Location = New System.Drawing.Point(496, 392)
        Me.SexoTextBox.Name = "SexoTextBox"
        Me.SexoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SexoTextBox.TabIndex = 134
        '
        'NumcelLabel
        '
        NumcelLabel.AutoSize = True
        NumcelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumcelLabel.Location = New System.Drawing.Point(376, 73)
        NumcelLabel.Name = "NumcelLabel"
        NumcelLabel.Size = New System.Drawing.Size(65, 20)
        NumcelLabel.TabIndex = 135
        NumcelLabel.Text = "Celular"
        '
        'NumcelTextBox
        '
        Me.NumcelTextBox.Enabled = False
        Me.NumcelTextBox.Location = New System.Drawing.Point(469, 67)
        Me.NumcelTextBox.Name = "NumcelTextBox"
        Me.NumcelTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NumcelTextBox.TabIndex = 136
        '
        'NumtelLabel
        '
        NumtelLabel.AutoSize = True
        NumtelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumtelLabel.Location = New System.Drawing.Point(376, 121)
        NumtelLabel.Name = "NumtelLabel"
        NumtelLabel.Size = New System.Drawing.Size(79, 20)
        NumtelLabel.TabIndex = 137
        NumtelLabel.Text = "Telefono"
        '
        'NumtelTextBox
        '
        Me.NumtelTextBox.Enabled = False
        Me.NumtelTextBox.Location = New System.Drawing.Point(469, 118)
        Me.NumtelTextBox.Name = "NumtelTextBox"
        Me.NumtelTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NumtelTextBox.TabIndex = 138
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(376, 226)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(84, 20)
        DireccionLabel.TabIndex = 139
        DireccionLabel.Text = "Direccion"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Enabled = False
        Me.DireccionTextBox.Location = New System.Drawing.Point(469, 223)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DireccionTextBox.TabIndex = 140
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalidadLabel.Location = New System.Drawing.Point(376, 274)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(86, 20)
        LocalidadLabel.TabIndex = 141
        LocalidadLabel.Text = "Localidad"
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.Enabled = False
        Me.LocalidadTextBox.Location = New System.Drawing.Point(469, 271)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(200, 26)
        Me.LocalidadTextBox.TabIndex = 142
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(376, 166)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(53, 20)
        EmailLabel.TabIndex = 143
        EmailLabel.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(469, 166)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 26)
        Me.EmailTextBox.TabIndex = 144
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(728, 269)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(66, 20)
        EstadoLabel.TabIndex = 145
        EstadoLabel.Text = "Estado"
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.Enabled = False
        Me.EstadoTextBox.Location = New System.Drawing.Point(729, 292)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.EstadoTextBox.TabIndex = 146
        '
        'FecestadoLabel
        '
        FecestadoLabel.AutoSize = True
        FecestadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FecestadoLabel.Location = New System.Drawing.Point(728, 188)
        FecestadoLabel.Name = "FecestadoLabel"
        FecestadoLabel.Size = New System.Drawing.Size(144, 20)
        FecestadoLabel.TabIndex = 147
        FecestadoLabel.Text = "Fecha de estado"
        '
        'FecestadoDateTimePicker
        '
        Me.FecestadoDateTimePicker.Enabled = False
        Me.FecestadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecestadoDateTimePicker.Location = New System.Drawing.Point(732, 213)
        Me.FecestadoDateTimePicker.Name = "FecestadoDateTimePicker"
        Me.FecestadoDateTimePicker.Size = New System.Drawing.Size(123, 26)
        Me.FecestadoDateTimePicker.TabIndex = 148
        '
        'FecingresoLabel
        '
        FecingresoLabel.AutoSize = True
        FecingresoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FecingresoLabel.Location = New System.Drawing.Point(725, 67)
        FecingresoLabel.Name = "FecingresoLabel"
        FecingresoLabel.Size = New System.Drawing.Size(148, 20)
        FecingresoLabel.TabIndex = 149
        FecingresoLabel.Text = "Fecha de ingreso"
        '
        'FecingresoDateTimePicker
        '
        Me.FecingresoDateTimePicker.Enabled = False
        Me.FecingresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecingresoDateTimePicker.Location = New System.Drawing.Point(729, 90)
        Me.FecingresoDateTimePicker.Name = "FecingresoDateTimePicker"
        Me.FecingresoDateTimePicker.Size = New System.Drawing.Size(125, 26)
        Me.FecingresoDateTimePicker.TabIndex = 150
        '
        'ALUMNOSDataGridView
        '
        Me.ALUMNOSDataGridView.AllowUserToAddRows = False
        Me.ALUMNOSDataGridView.AllowUserToDeleteRows = False
        Me.ALUMNOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ALUMNOSDataGridView.Location = New System.Drawing.Point(0, 440)
        Me.ALUMNOSDataGridView.Name = "ALUMNOSDataGridView"
        Me.ALUMNOSDataGridView.RowTemplate.Height = 28
        Me.ALUMNOSDataGridView.Size = New System.Drawing.Size(932, 266)
        Me.ALUMNOSDataGridView.TabIndex = 120
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(970, 90)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(116, 76)
        Me.BtnNuevo.TabIndex = 119
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(0, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(317, 45)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Registro de Alumnos"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(970, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 76)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(970, 255)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(116, 76)
        Me.btnModificar.TabIndex = 116
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(970, 173)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(116, 76)
        Me.BtnInsertar.TabIndex = 115
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1115, 717)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SexoComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.DNITextBox)
        Me.Controls.Add(IdcarreraLabel)
        Me.Controls.Add(Me.IdcarreraTextBox)
        Me.Controls.Add(FecnacLabel)
        Me.Controls.Add(Me.FecnacDateTimePicker)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.SexoTextBox)
        Me.Controls.Add(NumcelLabel)
        Me.Controls.Add(Me.NumcelTextBox)
        Me.Controls.Add(NumtelLabel)
        Me.Controls.Add(Me.NumtelTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(Me.LocalidadTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(FecestadoLabel)
        Me.Controls.Add(Me.FecestadoDateTimePicker)
        Me.Controls.Add(FecingresoLabel)
        Me.Controls.Add(Me.FecingresoDateTimePicker)
        Me.Controls.Add(Me.ALUMNOSDataGridView)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(DNILabel)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.Label17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ALUMNOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SexoComboBox1 As ComboBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents IdcarreraTextBox As TextBox
    Friend WithEvents FecnacDateTimePicker As DateTimePicker
    Friend WithEvents SexoTextBox As TextBox
    Friend WithEvents NumcelTextBox As TextBox
    Friend WithEvents NumtelTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents FecestadoDateTimePicker As DateTimePicker
    Friend WithEvents FecingresoDateTimePicker As DateTimePicker
    Friend WithEvents ALUMNOSDataGridView As DataGridView
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents BtnInsertar As Button
End Class
