<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigModulos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabilitadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.ModulosTableAdapter = New Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter()
        Me.CalculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalculosTableAdapter = New Scila7.ConfigDataSetTableAdapters.CalculosTableAdapter()
        Me.CalculosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBPathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScriptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmbientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEditarModulos = New System.Windows.Forms.Button()
        Me.btnEditarCalculos = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.ModulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalculosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Módulos disponibles"
        '
        'ModulosDataGridView
        '
        Me.ModulosDataGridView.AllowUserToAddRows = False
        Me.ModulosDataGridView.AllowUserToDeleteRows = False
        Me.ModulosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModulosDataGridView.AutoGenerateColumns = False
        Me.ModulosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ModulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.HabilitadoDataGridViewCheckBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CreadorDataGridViewTextBoxColumn, Me.VersionDataGridViewTextBoxColumn})
        Me.ModulosDataGridView.DataSource = Me.ModulosBindingSource
        Me.ModulosDataGridView.Location = New System.Drawing.Point(17, 101)
        Me.ModulosDataGridView.Name = "ModulosDataGridView"
        Me.ModulosDataGridView.RowHeadersVisible = False
        Me.ModulosDataGridView.Size = New System.Drawing.Size(813, 248)
        Me.ModulosDataGridView.TabIndex = 2
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'HabilitadoDataGridViewCheckBoxColumn
        '
        Me.HabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "habilitado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = False
        Me.HabilitadoDataGridViewCheckBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.HabilitadoDataGridViewCheckBoxColumn.HeaderText = "Activado"
        Me.HabilitadoDataGridViewCheckBoxColumn.Name = "HabilitadoDataGridViewCheckBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreadorDataGridViewTextBoxColumn
        '
        Me.CreadorDataGridViewTextBoxColumn.DataPropertyName = "creador"
        Me.CreadorDataGridViewTextBoxColumn.HeaderText = "Creador"
        Me.CreadorDataGridViewTextBoxColumn.Name = "CreadorDataGridViewTextBoxColumn"
        Me.CreadorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VersionDataGridViewTextBoxColumn
        '
        Me.VersionDataGridViewTextBoxColumn.DataPropertyName = "version"
        Me.VersionDataGridViewTextBoxColumn.HeaderText = "Version"
        Me.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn"
        Me.VersionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModulosBindingSource
        '
        Me.ModulosBindingSource.DataMember = "Modulos"
        Me.ModulosBindingSource.DataSource = Me.ConfigDataSet
        '
        'ConfigDataSet
        '
        Me.ConfigDataSet.DataSetName = "ConfigDataSet"
        Me.ConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModulosTableAdapter
        '
        Me.ModulosTableAdapter.ClearBeforeFill = True
        '
        'CalculosBindingSource
        '
        Me.CalculosBindingSource.DataMember = "Calculos"
        Me.CalculosBindingSource.DataSource = Me.ConfigDataSet
        '
        'CalculosTableAdapter
        '
        Me.CalculosTableAdapter.ClearBeforeFill = True
        '
        'CalculosDataGridView
        '
        Me.CalculosDataGridView.AllowUserToAddRows = False
        Me.CalculosDataGridView.AllowUserToDeleteRows = False
        Me.CalculosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalculosDataGridView.AutoGenerateColumns = False
        Me.CalculosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CalculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CalculosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.ActivadoDataGridViewCheckBoxColumn, Me.NombreDataGridViewTextBoxColumn1, Me.CodigoDataGridViewTextBoxColumn1, Me.CategoriaDataGridViewTextBoxColumn, Me.DBPathDataGridViewTextBoxColumn, Me.ScriptDataGridViewTextBoxColumn, Me.AmbientesDataGridViewTextBoxColumn})
        Me.CalculosDataGridView.DataSource = Me.CalculosBindingSource
        Me.CalculosDataGridView.Location = New System.Drawing.Point(17, 385)
        Me.CalculosDataGridView.Name = "CalculosDataGridView"
        Me.CalculosDataGridView.RowHeadersVisible = False
        Me.CalculosDataGridView.Size = New System.Drawing.Size(813, 250)
        Me.CalculosDataGridView.TabIndex = 4
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'ActivadoDataGridViewCheckBoxColumn
        '
        Me.ActivadoDataGridViewCheckBoxColumn.DataPropertyName = "Activado"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.NullValue = False
        Me.ActivadoDataGridViewCheckBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ActivadoDataGridViewCheckBoxColumn.HeaderText = "Activado"
        Me.ActivadoDataGridViewCheckBoxColumn.Name = "ActivadoDataGridViewCheckBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn1
        '
        Me.CodigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
        Me.CodigoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DBPathDataGridViewTextBoxColumn
        '
        Me.DBPathDataGridViewTextBoxColumn.DataPropertyName = "DBPath"
        Me.DBPathDataGridViewTextBoxColumn.HeaderText = "Base de Datos"
        Me.DBPathDataGridViewTextBoxColumn.Name = "DBPathDataGridViewTextBoxColumn"
        Me.DBPathDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ScriptDataGridViewTextBoxColumn
        '
        Me.ScriptDataGridViewTextBoxColumn.DataPropertyName = "Script"
        Me.ScriptDataGridViewTextBoxColumn.HeaderText = "Script"
        Me.ScriptDataGridViewTextBoxColumn.Name = "ScriptDataGridViewTextBoxColumn"
        Me.ScriptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmbientesDataGridViewTextBoxColumn
        '
        Me.AmbientesDataGridViewTextBoxColumn.DataPropertyName = "Ambientes"
        Me.AmbientesDataGridViewTextBoxColumn.HeaderText = "Ambientes"
        Me.AmbientesDataGridViewTextBoxColumn.Name = "AmbientesDataGridViewTextBoxColumn"
        Me.AmbientesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cálculos disponibles"
        '
        'btnEditarModulos
        '
        Me.btnEditarModulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnEditarModulos.FlatAppearance.BorderSize = 0
        Me.btnEditarModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarModulos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarModulos.ForeColor = System.Drawing.Color.White
        Me.btnEditarModulos.Image = Global.Scila7.My.Resources.Resources.edit_equalizer
        Me.btnEditarModulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarModulos.Location = New System.Drawing.Point(836, 101)
        Me.btnEditarModulos.Name = "btnEditarModulos"
        Me.btnEditarModulos.Size = New System.Drawing.Size(37, 38)
        Me.btnEditarModulos.TabIndex = 8
        Me.btnEditarModulos.UseVisualStyleBackColor = False
        '
        'btnEditarCalculos
        '
        Me.btnEditarCalculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnEditarCalculos.FlatAppearance.BorderSize = 0
        Me.btnEditarCalculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCalculos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCalculos.ForeColor = System.Drawing.Color.White
        Me.btnEditarCalculos.Image = Global.Scila7.My.Resources.Resources.edit_equalizer
        Me.btnEditarCalculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarCalculos.Location = New System.Drawing.Point(836, 385)
        Me.btnEditarCalculos.Name = "btnEditarCalculos"
        Me.btnEditarCalculos.Size = New System.Drawing.Size(37, 38)
        Me.btnEditarCalculos.TabIndex = 7
        Me.btnEditarCalculos.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = Global.Scila7.My.Resources.Resources.add2002
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(17, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 48)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        Me.btnAgregar.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.Scila7.My.Resources.Resources.save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(680, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 48)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmConfigModulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 691)
        Me.Controls.Add(Me.btnEditarModulos)
        Me.Controls.Add(Me.btnEditarCalculos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CalculosDataGridView)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.ModulosDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConfigModulos"
        Me.Text = "Módulos"
        CType(Me.ModulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalculosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ModulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModulosTableAdapter As Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter
    Friend WithEvents ModulosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents CalculosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents CalculosTableAdapter As Scila7.ConfigDataSetTableAdapters.CalculosTableAdapter
    Friend WithEvents CalculosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HabilitadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreadorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DBPathDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScriptDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmbientesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEditarCalculos As System.Windows.Forms.Button
    Friend WithEvents btnEditarModulos As System.Windows.Forms.Button
End Class
