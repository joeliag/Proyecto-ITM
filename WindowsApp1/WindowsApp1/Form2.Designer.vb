<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBusca = New System.Windows.Forms.TextBox()
        Me.ALUMNOSDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.ALUMNOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Location = New System.Drawing.Point(369, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(339, 45)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Busqueda de Alumnos"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(597, 79)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(137, 35)
        Me.BtnBuscar.TabIndex = 62
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBusca
        '
        Me.TxtBusca.Location = New System.Drawing.Point(357, 83)
        Me.TxtBusca.Name = "TxtBusca"
        Me.TxtBusca.Size = New System.Drawing.Size(221, 26)
        Me.TxtBusca.TabIndex = 61
        '
        'ALUMNOSDataGridView
        '
        Me.ALUMNOSDataGridView.AllowUserToAddRows = False
        Me.ALUMNOSDataGridView.AllowUserToDeleteRows = False
        Me.ALUMNOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ALUMNOSDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ALUMNOSDataGridView.Location = New System.Drawing.Point(76, 133)
        Me.ALUMNOSDataGridView.Name = "ALUMNOSDataGridView"
        Me.ALUMNOSDataGridView.ReadOnly = True
        Me.ALUMNOSDataGridView.RowTemplate.Height = 28
        Me.ALUMNOSDataGridView.Size = New System.Drawing.Size(922, 494)
        Me.ALUMNOSDataGridView.TabIndex = 60
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1124, 692)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBusca)
        Me.Controls.Add(Me.ALUMNOSDataGridView)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.ALUMNOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label17 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBusca As TextBox
    Friend WithEvents ALUMNOSDataGridView As DataGridView
End Class
