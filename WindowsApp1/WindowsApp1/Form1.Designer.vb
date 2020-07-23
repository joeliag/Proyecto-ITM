<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SexoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ALUMNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ITMDataSet = New WindowsApp1.ITMDataSet()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.FecnacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumtelTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.FecestadoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FecingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.ALUMNOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ALUMNOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ALUMNOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumcelTextBox = New System.Windows.Forms.TextBox()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CARRERASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ITMDataSet1 = New WindowsApp1.ITMDataSet()
        Me.ALUMNOSTableAdapter = New WindowsApp1.ITMDataSetTableAdapters.ALUMNOSTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.ITMDataSetTableAdapters.TableAdapterManager()
        Me.CARRERASTableAdapter = New WindowsApp1.ITMDataSetTableAdapters.CARRERASTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        Label7 = New System.Windows.Forms.Label()
        CType(Me.ALUMNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUMNOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALUMNOSBindingNavigator.SuspendLayout()
        CType(Me.ALUMNOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARRERASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITMDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'IdcarreraLabel
        '
        IdcarreraLabel.AutoSize = True
        IdcarreraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdcarreraLabel.Location = New System.Drawing.Point(728, 125)
        IdcarreraLabel.Name = "IdcarreraLabel"
        IdcarreraLabel.Size = New System.Drawing.Size(69, 20)
        IdcarreraLabel.TabIndex = 129
        IdcarreraLabel.Text = "Carrera"
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
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(337, 427)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(176, 20)
        Label7.TabIndex = 156
        Label7.Text = "Cuadro de busqueda"
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
        'SexoComboBox1
        '
        Me.SexoComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "sexo", True))
        Me.SexoComboBox1.Enabled = False
        Me.SexoComboBox1.FormattingEnabled = True
        Me.SexoComboBox1.Items.AddRange(New Object() {"F", "M"})
        Me.SexoComboBox1.Location = New System.Drawing.Point(113, 217)
        Me.SexoComboBox1.Name = "SexoComboBox1"
        Me.SexoComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.SexoComboBox1.TabIndex = 151
        '
        'ALUMNOSBindingSource
        '
        Me.ALUMNOSBindingSource.DataMember = "ALUMNOS"
        Me.ALUMNOSBindingSource.DataSource = Me.ITMDataSet
        '
        'ITMDataSet
        '
        Me.ITMDataSet.DataSetName = "ITMDataSet"
        Me.ITMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "Codigo", True))
        Me.CodigoTextBox.Enabled = False
        Me.CodigoTextBox.Location = New System.Drawing.Point(113, 70)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CodigoTextBox.TabIndex = 122
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(113, 117)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NombreTextBox.TabIndex = 124
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Enabled = False
        Me.ApellidoTextBox.Location = New System.Drawing.Point(113, 167)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ApellidoTextBox.TabIndex = 126
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "DNI", True))
        Me.DNITextBox.Enabled = False
        Me.DNITextBox.Location = New System.Drawing.Point(112, 267)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(200, 26)
        Me.DNITextBox.TabIndex = 128
        '
        'FecnacDateTimePicker
        '
        Me.FecnacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "fecnac", True))
        Me.FecnacDateTimePicker.Enabled = False
        Me.FecnacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecnacDateTimePicker.Location = New System.Drawing.Point(23, 348)
        Me.FecnacDateTimePicker.Name = "FecnacDateTimePicker"
        Me.FecnacDateTimePicker.Size = New System.Drawing.Size(125, 26)
        Me.FecnacDateTimePicker.TabIndex = 132
        '
        'NumtelTextBox
        '
        Me.NumtelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "numtel", True))
        Me.NumtelTextBox.Enabled = False
        Me.NumtelTextBox.Location = New System.Drawing.Point(469, 118)
        Me.NumtelTextBox.Name = "NumtelTextBox"
        Me.NumtelTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NumtelTextBox.TabIndex = 138
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "direccion", True))
        Me.DireccionTextBox.Enabled = False
        Me.DireccionTextBox.Location = New System.Drawing.Point(469, 223)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DireccionTextBox.TabIndex = 140
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "localidad", True))
        Me.LocalidadTextBox.Enabled = False
        Me.LocalidadTextBox.Location = New System.Drawing.Point(469, 271)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(200, 26)
        Me.LocalidadTextBox.TabIndex = 142
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(469, 166)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 26)
        Me.EmailTextBox.TabIndex = 144
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "estado", True))
        Me.EstadoTextBox.Enabled = False
        Me.EstadoTextBox.Location = New System.Drawing.Point(729, 292)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.EstadoTextBox.TabIndex = 146
        '
        'FecestadoDateTimePicker
        '
        Me.FecestadoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "fecestado", True))
        Me.FecestadoDateTimePicker.Enabled = False
        Me.FecestadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecestadoDateTimePicker.Location = New System.Drawing.Point(732, 213)
        Me.FecestadoDateTimePicker.Name = "FecestadoDateTimePicker"
        Me.FecestadoDateTimePicker.Size = New System.Drawing.Size(123, 26)
        Me.FecestadoDateTimePicker.TabIndex = 148
        '
        'FecingresoDateTimePicker
        '
        Me.FecingresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "fecingreso", True))
        Me.FecingresoDateTimePicker.Enabled = False
        Me.FecingresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecingresoDateTimePicker.Location = New System.Drawing.Point(729, 90)
        Me.FecingresoDateTimePicker.Name = "FecingresoDateTimePicker"
        Me.FecingresoDateTimePicker.Size = New System.Drawing.Size(125, 26)
        Me.FecingresoDateTimePicker.TabIndex = 150
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(974, 20)
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
        Me.Button1.Location = New System.Drawing.Point(974, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 76)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(974, 185)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(116, 76)
        Me.btnModificar.TabIndex = 116
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(974, 103)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(116, 76)
        Me.BtnInsertar.TabIndex = 115
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'ALUMNOSBindingNavigator
        '
        Me.ALUMNOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ALUMNOSBindingNavigator.BindingSource = Me.ALUMNOSBindingSource
        Me.ALUMNOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ALUMNOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ALUMNOSBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ALUMNOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ALUMNOSBindingNavigatorSaveItem})
        Me.ALUMNOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ALUMNOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ALUMNOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ALUMNOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ALUMNOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ALUMNOSBindingNavigator.Name = "ALUMNOSBindingNavigator"
        Me.ALUMNOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ALUMNOSBindingNavigator.Size = New System.Drawing.Size(1115, 31)
        Me.ALUMNOSBindingNavigator.TabIndex = 154
        Me.ALUMNOSBindingNavigator.Text = "BindingNavigator1"
        Me.ALUMNOSBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ALUMNOSBindingNavigatorSaveItem
        '
        Me.ALUMNOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ALUMNOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("ALUMNOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ALUMNOSBindingNavigatorSaveItem.Name = "ALUMNOSBindingNavigatorSaveItem"
        Me.ALUMNOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.ALUMNOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ALUMNOSDataGridView
        '
        Me.ALUMNOSDataGridView.AutoGenerateColumns = False
        Me.ALUMNOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ALUMNOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.descripcion, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.ALUMNOSDataGridView.DataSource = Me.ALUMNOSBindingSource
        Me.ALUMNOSDataGridView.Location = New System.Drawing.Point(23, 482)
        Me.ALUMNOSDataGridView.Name = "ALUMNOSDataGridView"
        Me.ALUMNOSDataGridView.RowTemplate.Height = 28
        Me.ALUMNOSDataGridView.Size = New System.Drawing.Size(1047, 310)
        Me.ALUMNOSDataGridView.TabIndex = 154
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idcarrera"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idcarrera"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fecnac"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fecnac"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "sexo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "sexo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "numcel"
        Me.DataGridViewTextBoxColumn9.HeaderText = "numcel"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "numtel"
        Me.DataGridViewTextBoxColumn10.HeaderText = "numtel"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "localidad"
        Me.DataGridViewTextBoxColumn12.HeaderText = "localidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn13.HeaderText = "email"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn14.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "fecestado"
        Me.DataGridViewTextBoxColumn15.HeaderText = "fecestado"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "fecingreso"
        Me.DataGridViewTextBoxColumn16.HeaderText = "fecingreso"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'NumcelTextBox
        '
        Me.NumcelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "numcel", True))
        Me.NumcelTextBox.Enabled = False
        Me.NumcelTextBox.Location = New System.Drawing.Point(469, 67)
        Me.NumcelTextBox.Name = "NumcelTextBox"
        Me.NumcelTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NumcelTextBox.TabIndex = 136
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Location = New System.Drawing.Point(341, 450)
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(184, 26)
        Me.BuscarTextBox.TabIndex = 155
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(557, 439)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(102, 37)
        Me.BtnBuscar.TabIndex = 157
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CARRERASBindingSource
        '
        Me.CARRERASBindingSource.DataMember = "CARRERAS"
        Me.CARRERASBindingSource.DataSource = Me.ITMDataSet1
        '
        'ITMDataSet1
        '
        Me.ITMDataSet1.DataSetName = "ITMDataSet"
        Me.ITMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALUMNOSTableAdapter
        '
        Me.ALUMNOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARRERASTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.ITMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOSTableAdapter = Nothing
        '
        'CARRERASTableAdapter
        '
        Me.CARRERASTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "sexo", True))
        Me.ComboBox1.DataSource = Me.ALUMNOSBindingSource
        Me.ComboBox1.DisplayMember = "descripcion"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(732, 151)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 158
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1115, 1002)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.ALUMNOSDataGridView)
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
        Me.Controls.Add(FecnacLabel)
        Me.Controls.Add(Me.FecnacDateTimePicker)
        Me.Controls.Add(Label5)
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
        Me.Controls.Add(Me.ALUMNOSBindingNavigator)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSBindingSource, "numtel", True))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ALUMNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUMNOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALUMNOSBindingNavigator.ResumeLayout(False)
        Me.ALUMNOSBindingNavigator.PerformLayout()
        CType(Me.ALUMNOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARRERASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITMDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As Label
    Friend WithEvents SexoComboBox1 As ComboBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents FecnacDateTimePicker As DateTimePicker
    Friend WithEvents NumtelTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents FecestadoDateTimePicker As DateTimePicker
    Friend WithEvents FecingresoDateTimePicker As DateTimePicker
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents ITMDataSet As ITMDataSet
    Friend WithEvents ALUMNOSBindingSource As BindingSource
    Friend WithEvents ALUMNOSTableAdapter As ITMDataSetTableAdapters.ALUMNOSTableAdapter
    Friend WithEvents TableAdapterManager As ITMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ALUMNOSBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ALUMNOSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ALUMNOSDataGridView As DataGridView
    Friend WithEvents NumcelTextBox As TextBox
    Friend WithEvents ITMDataSet1 As ITMDataSet
    Friend WithEvents CARRERASBindingSource As BindingSource
    Friend WithEvents CARRERASTableAdapter As ITMDataSetTableAdapters.CARRERASTableAdapter
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
End Class
