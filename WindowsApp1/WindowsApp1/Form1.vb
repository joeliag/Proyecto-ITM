Public Class Form1
    Private Sub ALUMNOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ALUMNOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALUMNOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ITMDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ITMDataSet1.CARRERAS' Puede moverla o quitarla según sea necesario.
        ' Me.CARRERASTableAdapter.Fill(Me.ITMDataSet1.CARRERAS)
        'TODO: esta línea de código carga datos en la tabla 'ITMDataSet.ALUMNOS' Puede moverla o quitarla según sea necesario.
        '  Me.ALUMNOSTableAdapter.FillBy(Me.ITMDataSet.ALUMNOS)


    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Me.ALUMNOSTableAdapter.Insertar(CodigoTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, SexoComboBox1.Text, DNITextBox.Text, FecnacDateTimePicker.Text, NumcelTextBox.Text, NumtelTextBox.Text, EmailTextBox.Text, DireccionTextBox.Text, LocalidadTextBox.Text, FecingresoDateTimePicker.Text, IdcarreraTextBox.Text, FecestadoDateTimePicker.Text, EstadoTextBox.Text)
    End Sub

    Private Sub HabilitarCampos()
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        DNITextBox.Enabled = True
        LocalidadTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        FecestadoDateTimePicker.Enabled = True
        FecingresoDateTimePicker.Enabled = True
        FecnacDateTimePicker.Enabled = True
        NumcelTextBox.Enabled = True
        NumtelTextBox.Enabled = True
        EstadoTextBox.Enabled = True
        EmailTextBox.Enabled = True
        SexoComboBox1.Enabled = True
        ''
        NombreTextBox.Text = ""
        ApellidoTextBox.Text = ""
        DNITextBox.Text = ""
        LocalidadTextBox.Text = ""
        DireccionTextBox.Text = ""
        FecestadoDateTimePicker.Text = ""
        FecingresoDateTimePicker.Text = ""
        FecnacDateTimePicker.Text = ""
        NumcelTextBox.Text = ""
        NumtelTextBox.Text = ""
        EstadoTextBox.Text = ""
        EmailTextBox.Text = ""
        SexoComboBox1.Text = ""
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarCampos()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim valor As String
        valor = BuscarTextBox.Text

        If valor = "" Then
            Me.ALUMNOSTableAdapter.FillBy(Me.ITMDataSet.ALUMNOS)
        Else
            If IsNumeric(valor) Then
                Me.ALUMNOSTableAdapter.BuscarAlumnosNumero(ITMDataSet.ALUMNOS, valor)
            Else
                Me.ALUMNOSTableAdapter.BuscarAlumnosTexto(ITMDataSet.ALUMNOS, valor, valor)
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        DNITextBox.Enabled = True
        LocalidadTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        FecestadoDateTimePicker.Enabled = True
        FecingresoDateTimePicker.Enabled = True
        FecnacDateTimePicker.Enabled = True
        NumcelTextBox.Enabled = True
        NumtelTextBox.Enabled = True
        EstadoTextBox.Enabled = True
        EmailTextBox.Enabled = True
        SexoComboBox1.Enabled = True

    End Sub
End Class
