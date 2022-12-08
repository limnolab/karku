<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim IdProyectoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.IdProyectoLabel1 = New System.Windows.Forms.Label()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdMuestra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulosTableAdapter = New Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter()
        Me.cmbModulo = New System.Windows.Forms.ComboBox()
        Me.cmbVariable = New System.Windows.Forms.ComboBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.dgvDatosActuales = New System.Windows.Forms.DataGridView()
        Me.dgvDatosConvertidos = New System.Windows.Forms.DataGridView()
        Me.txtFactorConversion = New System.Windows.Forms.TextBox()
        Me.grpProyecto = New System.Windows.Forms.GroupBox()
        Me.btnDeseleccionarTodo = New System.Windows.Forms.Button()
        Me.btnSeleccionarTodo = New System.Windows.Forms.Button()
        Me.grpConvertir = New System.Windows.Forms.GroupBox()
        Me.cboConvertTo = New System.Windows.Forms.ComboBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.grpModulo = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        IdProyectoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatosActuales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatosConvertidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProyecto.SuspendLayout()
        Me.grpConvertir.SuspendLayout()
        Me.grpModulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(15, 28)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 13)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Seleccione proyecto:"
        '
        'IdProyectoLabel
        '
        IdProyectoLabel.AutoSize = True
        IdProyectoLabel.Location = New System.Drawing.Point(377, 28)
        IdProyectoLabel.Name = "IdProyectoLabel"
        IdProyectoLabel.Size = New System.Drawing.Size(19, 13)
        IdProyectoLabel.TabIndex = 2
        IdProyectoLabel.Text = "Id:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(15, 58)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(108, 13)
        Label1.TabIndex = 4
        Label1.Text = "Seleccione muestras:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(57, 23)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 13)
        Label2.TabIndex = 6
        Label2.Text = "Seleccione módulo:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(57, 54)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(156, 13)
        Label3.TabIndex = 9
        Label3.Text = "Seleccione variable a convertir:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(6, 59)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(145, 13)
        Label6.TabIndex = 22
        Label6.Text = "FACTOR DE CONVERSIÓN:"
        '
        'Scilla10DataSet
        '
        Me.Scilla10DataSet.DataSetName = "Scilla10DataSet"
        Me.Scilla10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.Scilla10DataSet
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.ProyectosBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(128, 25)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(243, 21)
        Me.NombreComboBox.TabIndex = 1
        Me.NombreComboBox.ValueMember = "IdProyecto"
        '
        'IdProyectoLabel1
        '
        Me.IdProyectoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "IdProyecto", True))
        Me.IdProyectoLabel1.Location = New System.Drawing.Point(391, 28)
        Me.IdProyectoLabel1.Name = "IdProyectoLabel1"
        Me.IdProyectoLabel1.Size = New System.Drawing.Size(40, 18)
        Me.IdProyectoLabel1.TabIndex = 3
        Me.IdProyectoLabel1.Text = "Label1"
        '
        'MuestrasBindingSource
        '
        Me.MuestrasBindingSource.DataMember = "Muestras"
        Me.MuestrasBindingSource.DataSource = Me.Scilla10DataSet
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'MuestrasDataGridView
        '
        Me.MuestrasDataGridView.AllowUserToAddRows = False
        Me.MuestrasDataGridView.AllowUserToDeleteRows = False
        Me.MuestrasDataGridView.AutoGenerateColumns = False
        Me.MuestrasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMuestra, Me.Nombre, Me.Fecha, Me.IdProyecto})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(129, 58)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.ReadOnly = True
        Me.MuestrasDataGridView.RowHeadersVisible = False
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(284, 223)
        Me.MuestrasDataGridView.TabIndex = 5
        '
        'IdMuestra
        '
        Me.IdMuestra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdMuestra.DataPropertyName = "IdMuestra"
        Me.IdMuestra.HeaderText = "IdMuestra"
        Me.IdMuestra.Name = "IdMuestra"
        Me.IdMuestra.ReadOnly = True
        Me.IdMuestra.Width = 79
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'IdProyecto
        '
        Me.IdProyecto.DataPropertyName = "IdProyecto"
        Me.IdProyecto.HeaderText = "IdProyecto"
        Me.IdProyecto.Name = "IdProyecto"
        Me.IdProyecto.ReadOnly = True
        Me.IdProyecto.Visible = False
        '
        'ConfigDataSet
        '
        Me.ConfigDataSet.DataSetName = "ConfigDataSet"
        Me.ConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModulosBindingSource
        '
        Me.ModulosBindingSource.DataMember = "Modulos"
        Me.ModulosBindingSource.DataSource = Me.ConfigDataSet
        '
        'ModulosTableAdapter
        '
        Me.ModulosTableAdapter.ClearBeforeFill = True
        '
        'cmbModulo
        '
        Me.cmbModulo.DataSource = Me.ModulosBindingSource
        Me.cmbModulo.DisplayMember = "nombre"
        Me.cmbModulo.FormattingEnabled = True
        Me.cmbModulo.Location = New System.Drawing.Point(170, 19)
        Me.cmbModulo.Name = "cmbModulo"
        Me.cmbModulo.Size = New System.Drawing.Size(243, 21)
        Me.cmbModulo.TabIndex = 8
        Me.cmbModulo.ValueMember = "codigo"
        '
        'cmbVariable
        '
        Me.cmbVariable.FormattingEnabled = True
        Me.cmbVariable.Location = New System.Drawing.Point(219, 46)
        Me.cmbVariable.Name = "cmbVariable"
        Me.cmbVariable.Size = New System.Drawing.Size(194, 21)
        Me.cmbVariable.TabIndex = 10
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Image = Global.Scila7.My.Resources.Resources.check59W
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(256, 287)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(157, 47)
        Me.btnSeleccionar.TabIndex = 11
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'btnConvertir
        '
        Me.btnConvertir.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnConvertir.FlatAppearance.BorderSize = 0
        Me.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvertir.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.ForeColor = System.Drawing.Color.White
        Me.btnConvertir.Location = New System.Drawing.Point(473, 258)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(331, 35)
        Me.btnConvertir.TabIndex = 12
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = False
        '
        'dgvDatosActuales
        '
        Me.dgvDatosActuales.AllowUserToAddRows = False
        Me.dgvDatosActuales.AllowUserToDeleteRows = False
        Me.dgvDatosActuales.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosActuales.Location = New System.Drawing.Point(473, 40)
        Me.dgvDatosActuales.Name = "dgvDatosActuales"
        Me.dgvDatosActuales.ReadOnly = True
        Me.dgvDatosActuales.RowHeadersVisible = False
        Me.dgvDatosActuales.Size = New System.Drawing.Size(331, 212)
        Me.dgvDatosActuales.TabIndex = 13
        '
        'dgvDatosConvertidos
        '
        Me.dgvDatosConvertidos.AllowUserToAddRows = False
        Me.dgvDatosConvertidos.AllowUserToDeleteRows = False
        Me.dgvDatosConvertidos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatosConvertidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosConvertidos.Location = New System.Drawing.Point(473, 325)
        Me.dgvDatosConvertidos.Name = "dgvDatosConvertidos"
        Me.dgvDatosConvertidos.ReadOnly = True
        Me.dgvDatosConvertidos.RowHeadersVisible = False
        Me.dgvDatosConvertidos.Size = New System.Drawing.Size(331, 183)
        Me.dgvDatosConvertidos.TabIndex = 14
        '
        'txtFactorConversion
        '
        Me.txtFactorConversion.Location = New System.Drawing.Point(157, 52)
        Me.txtFactorConversion.Name = "txtFactorConversion"
        Me.txtFactorConversion.Size = New System.Drawing.Size(100, 20)
        Me.txtFactorConversion.TabIndex = 21
        '
        'grpProyecto
        '
        Me.grpProyecto.Controls.Add(Me.btnDeseleccionarTodo)
        Me.grpProyecto.Controls.Add(Me.btnSeleccionarTodo)
        Me.grpProyecto.Controls.Add(NombreLabel)
        Me.grpProyecto.Controls.Add(Me.NombreComboBox)
        Me.grpProyecto.Controls.Add(Me.IdProyectoLabel1)
        Me.grpProyecto.Controls.Add(IdProyectoLabel)
        Me.grpProyecto.Controls.Add(Label1)
        Me.grpProyecto.Controls.Add(Me.MuestrasDataGridView)
        Me.grpProyecto.Controls.Add(Me.btnSeleccionar)
        Me.grpProyecto.Location = New System.Drawing.Point(15, 12)
        Me.grpProyecto.Name = "grpProyecto"
        Me.grpProyecto.Size = New System.Drawing.Size(431, 352)
        Me.grpProyecto.TabIndex = 23
        Me.grpProyecto.TabStop = False
        Me.grpProyecto.Text = "Seleccione proyecto y muestras"
        '
        'btnDeseleccionarTodo
        '
        Me.btnDeseleccionarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnDeseleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeseleccionarTodo.Location = New System.Drawing.Point(130, 311)
        Me.btnDeseleccionarTodo.Name = "btnDeseleccionarTodo"
        Me.btnDeseleccionarTodo.Size = New System.Drawing.Size(120, 23)
        Me.btnDeseleccionarTodo.TabIndex = 13
        Me.btnDeseleccionarTodo.Text = "Deseleccionar todas"
        Me.btnDeseleccionarTodo.UseVisualStyleBackColor = True
        '
        'btnSeleccionarTodo
        '
        Me.btnSeleccionarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSeleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarTodo.Location = New System.Drawing.Point(130, 287)
        Me.btnSeleccionarTodo.Name = "btnSeleccionarTodo"
        Me.btnSeleccionarTodo.Size = New System.Drawing.Size(120, 23)
        Me.btnSeleccionarTodo.TabIndex = 12
        Me.btnSeleccionarTodo.Text = "Seleccionar todas"
        Me.btnSeleccionarTodo.UseVisualStyleBackColor = True
        '
        'grpConvertir
        '
        Me.grpConvertir.Controls.Add(Me.cboConvertTo)
        Me.grpConvertir.Controls.Add(Me.cboCategory)
        Me.grpConvertir.Controls.Add(Label6)
        Me.grpConvertir.Controls.Add(Me.txtFactorConversion)
        Me.grpConvertir.Location = New System.Drawing.Point(15, 466)
        Me.grpConvertir.Name = "grpConvertir"
        Me.grpConvertir.Size = New System.Drawing.Size(431, 80)
        Me.grpConvertir.TabIndex = 24
        Me.grpConvertir.TabStop = False
        Me.grpConvertir.Text = "Cómo convertir"
        '
        'cboConvertTo
        '
        Me.cboConvertTo.FormattingEnabled = True
        Me.cboConvertTo.Location = New System.Drawing.Point(246, 19)
        Me.cboConvertTo.Name = "cboConvertTo"
        Me.cboConvertTo.Size = New System.Drawing.Size(167, 21)
        Me.cboConvertTo.TabIndex = 24
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(158, 19)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(82, 21)
        Me.cboCategory.TabIndex = 23
        '
        'grpModulo
        '
        Me.grpModulo.Controls.Add(Label2)
        Me.grpModulo.Controls.Add(Me.cmbModulo)
        Me.grpModulo.Controls.Add(Label3)
        Me.grpModulo.Controls.Add(Me.cmbVariable)
        Me.grpModulo.Location = New System.Drawing.Point(15, 370)
        Me.grpModulo.Name = "grpModulo"
        Me.grpModulo.Size = New System.Drawing.Size(431, 90)
        Me.grpModulo.TabIndex = 25
        Me.grpModulo.TabStop = False
        Me.grpModulo.Text = "Variable a convertir"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(473, 514)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(331, 32)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar conversión"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(469, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Valores actuales"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(469, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Valores convertidos"
        '
        'frmConversor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 562)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grpModulo)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.grpConvertir)
        Me.Controls.Add(Me.grpProyecto)
        Me.Controls.Add(Me.dgvDatosConvertidos)
        Me.Controls.Add(Me.dgvDatosActuales)
        Me.Name = "frmConversor"
        Me.Text = "Conversor de unidades"
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatosActuales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatosConvertidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProyecto.ResumeLayout(False)
        Me.grpProyecto.PerformLayout()
        Me.grpConvertir.ResumeLayout(False)
        Me.grpConvertir.PerformLayout()
        Me.grpModulo.ResumeLayout(False)
        Me.grpModulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdProyectoLabel1 As System.Windows.Forms.Label
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ModulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModulosTableAdapter As Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter
    Friend WithEvents cmbModulo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVariable As System.Windows.Forms.ComboBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents btnConvertir As System.Windows.Forms.Button
    Friend WithEvents dgvDatosActuales As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDatosConvertidos As System.Windows.Forms.DataGridView
    Friend WithEvents txtFactorConversion As System.Windows.Forms.TextBox
    Friend WithEvents grpProyecto As System.Windows.Forms.GroupBox
    Friend WithEvents grpConvertir As System.Windows.Forms.GroupBox
    Friend WithEvents grpModulo As System.Windows.Forms.GroupBox
    Friend WithEvents btnSeleccionarTodo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnDeseleccionarTodo As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IdMuestra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboConvertTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
End Class
