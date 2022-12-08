<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMacroinvertebrados
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
        Dim IdTaxonLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim NivelTaxonomicoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMacroinvertebrados))
        Me.TaxonesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelPadre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MacroinvertebradosDataSet = New Scila7.macroinvertebradosDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TaxonesPresentes = New System.Windows.Forms.DataGridView()
        Me.IdTaxon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Taxón = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCantidadAgregar = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New C1.Win.C1Input.C1Button()
        Me.TaxonesmuestrasDataSet = New Scila7.taxonesmuestrasDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.fototaxon = New C1.Win.C1Input.C1PictureBox()
        Me.NivelTaxonomicoTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.IdTaxonTextBox = New System.Windows.Forms.TextBox()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEditarListaTaxones = New System.Windows.Forms.Button()
        Me.txtHelp = New System.Windows.Forms.TextBox()
        Me.TaxonesTableAdapter = New Scila7.macroinvertebradosDataSetTableAdapters.TaxonesTableAdapter()
        Me.MuestrasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IdMuestraTextBox = New System.Windows.Forms.TextBox()
        IdTaxonLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        NivelTaxonomicoLabel = New System.Windows.Forms.Label()
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MacroinvertebradosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesPresentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesmuestrasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfo.SuspendLayout()
        CType(Me.fototaxon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdTaxonLabel
        '
        IdTaxonLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        IdTaxonLabel.AutoSize = True
        IdTaxonLabel.Location = New System.Drawing.Point(11, 32)
        IdTaxonLabel.Name = "IdTaxonLabel"
        IdTaxonLabel.Size = New System.Drawing.Size(52, 13)
        IdTaxonLabel.TabIndex = 0
        IdTaxonLabel.Text = "Id Taxon:"
        '
        'NombreLabel
        '
        NombreLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(16, 58)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(28, 83)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 4
        AutorLabel.Text = "Autor:"
        '
        'NivelTaxonomicoLabel
        '
        NivelTaxonomicoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NivelTaxonomicoLabel.AutoSize = True
        NivelTaxonomicoLabel.Location = New System.Drawing.Point(6, 109)
        NivelTaxonomicoLabel.Name = "NivelTaxonomicoLabel"
        NivelTaxonomicoLabel.Size = New System.Drawing.Size(57, 13)
        NivelTaxonomicoLabel.TabIndex = 6
        NivelTaxonomicoLabel.Text = "Categoría:"
        '
        'TaxonesDataGridView
        '
        Me.TaxonesDataGridView.AllowUserToAddRows = False
        Me.TaxonesDataGridView.AllowUserToDeleteRows = False
        Me.TaxonesDataGridView.AutoGenerateColumns = False
        Me.TaxonesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TaxonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaxonesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.NivelPadre, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TaxonesDataGridView.DataSource = Me.TaxonesBindingSource
        Me.TaxonesDataGridView.Location = New System.Drawing.Point(12, 463)
        Me.TaxonesDataGridView.Name = "TaxonesDataGridView"
        Me.TaxonesDataGridView.ReadOnly = True
        Me.TaxonesDataGridView.RowHeadersVisible = False
        Me.TaxonesDataGridView.Size = New System.Drawing.Size(309, 100)
        Me.TaxonesDataGridView.TabIndex = 3
        Me.TaxonesDataGridView.TabStop = False
        Me.TaxonesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdTaxon"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 20
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'NivelPadre
        '
        Me.NivelPadre.DataPropertyName = "NivelPadre"
        Me.NivelPadre.HeaderText = "NivelPadre"
        Me.NivelPadre.Name = "NivelPadre"
        Me.NivelPadre.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NivelTaxonomico"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NivelTaxonomico"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Foto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Foto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'TaxonesBindingSource
        '
        Me.TaxonesBindingSource.DataMember = "Taxones"
        Me.TaxonesBindingSource.DataSource = Me.MacroinvertebradosDataSet
        '
        'MacroinvertebradosDataSet
        '
        Me.MacroinvertebradosDataSet.DataSetName = "macroinvertebradosDataSet"
        Me.MacroinvertebradosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(600, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Taxones en la muestra"
        '
        'TaxonesPresentes
        '
        Me.TaxonesPresentes.AllowUserToAddRows = False
        Me.TaxonesPresentes.AllowUserToDeleteRows = False
        Me.TaxonesPresentes.AllowUserToResizeColumns = False
        Me.TaxonesPresentes.AllowUserToResizeRows = False
        Me.TaxonesPresentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaxonesPresentes.BackgroundColor = System.Drawing.Color.White
        Me.TaxonesPresentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaxonesPresentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTaxon, Me.Taxón, Me.Cantidad})
        Me.TaxonesPresentes.GridColor = System.Drawing.Color.White
        Me.TaxonesPresentes.Location = New System.Drawing.Point(597, 52)
        Me.TaxonesPresentes.MultiSelect = False
        Me.TaxonesPresentes.Name = "TaxonesPresentes"
        Me.TaxonesPresentes.ReadOnly = True
        Me.TaxonesPresentes.RowHeadersVisible = False
        Me.TaxonesPresentes.Size = New System.Drawing.Size(256, 338)
        Me.TaxonesPresentes.TabIndex = 40
        Me.TaxonesPresentes.TabStop = False
        '
        'IdTaxon
        '
        Me.IdTaxon.HeaderText = "Id"
        Me.IdTaxon.Name = "IdTaxon"
        Me.IdTaxon.ReadOnly = True
        Me.IdTaxon.Width = 50
        '
        'Taxón
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Taxón.DefaultCellStyle = DataGridViewCellStyle1
        Me.Taxón.HeaderText = "Taxón"
        Me.Taxón.Name = "Taxón"
        Me.Taxón.ReadOnly = True
        '
        'Cantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(344, 54)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(242, 68)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = ">>    Agregar a la muestra"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtCantidadAgregar
        '
        Me.txtCantidadAgregar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAgregar.Location = New System.Drawing.Point(235, 90)
        Me.txtCantidadAgregar.Name = "txtCantidadAgregar"
        Me.txtCantidadAgregar.Size = New System.Drawing.Size(86, 27)
        Me.txtCantidadAgregar.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(604, 518)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(255, 59)
        Me.btnGuardar.TabIndex = 153
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "Guardar datos de macroinvertebrados"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TaxonesmuestrasDataSet
        '
        Me.TaxonesmuestrasDataSet.DataSetName = "taxonesmuestrasDataSet"
        Me.TaxonesmuestrasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Cantidad de individuos"
        '
        'grpInfo
        '
        Me.grpInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInfo.Controls.Add(Me.fototaxon)
        Me.grpInfo.Controls.Add(NivelTaxonomicoLabel)
        Me.grpInfo.Controls.Add(Me.NivelTaxonomicoTextBox)
        Me.grpInfo.Controls.Add(AutorLabel)
        Me.grpInfo.Controls.Add(Me.AutorTextBox)
        Me.grpInfo.Controls.Add(NombreLabel)
        Me.grpInfo.Controls.Add(Me.NombreTextBox)
        Me.grpInfo.Controls.Add(IdTaxonLabel)
        Me.grpInfo.Controls.Add(Me.IdTaxonTextBox)
        Me.grpInfo.Location = New System.Drawing.Point(339, 135)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(247, 401)
        Me.grpInfo.TabIndex = 159
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Información del Taxón"
        '
        'fototaxon
        '
        Me.fototaxon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fototaxon.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TaxonesBindingSource, "Foto", True))
        Me.fototaxon.ErrorImage = Global.Scila7.My.Resources.Resources.logoKerku
        Me.fototaxon.Location = New System.Drawing.Point(10, 134)
        Me.fototaxon.Name = "fototaxon"
        Me.fototaxon.Size = New System.Drawing.Size(231, 261)
        Me.fototaxon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fototaxon.TabIndex = 9
        Me.fototaxon.TabStop = False
        '
        'NivelTaxonomicoTextBox
        '
        Me.NivelTaxonomicoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NivelTaxonomicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "NivelTaxonomico", True))
        Me.NivelTaxonomicoTextBox.Enabled = False
        Me.NivelTaxonomicoTextBox.Location = New System.Drawing.Point(69, 106)
        Me.NivelTaxonomicoTextBox.Name = "NivelTaxonomicoTextBox"
        Me.NivelTaxonomicoTextBox.Size = New System.Drawing.Size(172, 20)
        Me.NivelTaxonomicoTextBox.TabIndex = 7
        Me.NivelTaxonomicoTextBox.TabStop = False
        '
        'AutorTextBox
        '
        Me.AutorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Autor", True))
        Me.AutorTextBox.Enabled = False
        Me.AutorTextBox.Location = New System.Drawing.Point(69, 80)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(172, 20)
        Me.AutorTextBox.TabIndex = 5
        Me.AutorTextBox.TabStop = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(69, 55)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(172, 20)
        Me.NombreTextBox.TabIndex = 3
        Me.NombreTextBox.TabStop = False
        '
        'IdTaxonTextBox
        '
        Me.IdTaxonTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdTaxonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "IdTaxon", True))
        Me.IdTaxonTextBox.Enabled = False
        Me.IdTaxonTextBox.Location = New System.Drawing.Point(69, 29)
        Me.IdTaxonTextBox.Name = "IdTaxonTextBox"
        Me.IdTaxonTextBox.Size = New System.Drawing.Size(91, 20)
        Me.IdTaxonTextBox.TabIndex = 1
        Me.IdTaxonTextBox.TabStop = False
        '
        'MuestrasBindingSource
        '
        Me.MuestrasBindingSource.DataMember = "Muestras"
        Me.MuestrasBindingSource.DataSource = Me.Scilla10DataSet
        '
        'Scilla10DataSet
        '
        Me.Scilla10DataSet.DataSetName = "Scilla10DataSet"
        Me.Scilla10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(12, 123)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(309, 447)
        Me.TreeView1.TabIndex = 162
        Me.TreeView1.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 2
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(604, 482)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(255, 31)
        Me.btnEliminar.TabIndex = 167
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "Eliminar taxón seleccionado"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(133, 61)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(188, 27)
        Me.txtSearch.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Buscar por nombre:"
        '
        'btnEditarListaTaxones
        '
        Me.btnEditarListaTaxones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarListaTaxones.BackColor = System.Drawing.Color.White
        Me.btnEditarListaTaxones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnEditarListaTaxones.FlatAppearance.BorderSize = 2
        Me.btnEditarListaTaxones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarListaTaxones.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarListaTaxones.Location = New System.Drawing.Point(339, 542)
        Me.btnEditarListaTaxones.Name = "btnEditarListaTaxones"
        Me.btnEditarListaTaxones.Size = New System.Drawing.Size(243, 35)
        Me.btnEditarListaTaxones.TabIndex = 171
        Me.btnEditarListaTaxones.Text = "Editar lista de taxones"
        Me.btnEditarListaTaxones.UseVisualStyleBackColor = False
        '
        'txtHelp
        '
        Me.txtHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHelp.ForeColor = System.Drawing.Color.Gray
        Me.txtHelp.Location = New System.Drawing.Point(603, 396)
        Me.txtHelp.Multiline = True
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.Size = New System.Drawing.Size(256, 80)
        Me.txtHelp.TabIndex = 173
        Me.txtHelp.Text = "Los taxones en GRIS son agregados automáticamente para que las categorías taxonóm" & _
    "icas superiores al taxón seleccionado no queden vacías y puedan ser utilizadas p" & _
    "ara los diversos cálculos de índices." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TaxonesTableAdapter
        '
        Me.TaxonesTableAdapter.ClearBeforeFill = True
        '
        'MuestrasBindingNavigator
        '
        Me.MuestrasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MuestrasBindingNavigator.AutoSize = False
        Me.MuestrasBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.MuestrasBindingNavigator.BindingSource = Me.MuestrasBindingSource
        Me.MuestrasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MuestrasBindingNavigator.CountItemFormat = "de {0}"
        Me.MuestrasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MuestrasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MuestrasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.MuestrasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MuestrasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MuestrasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MuestrasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MuestrasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MuestrasBindingNavigator.Name = "MuestrasBindingNavigator"
        Me.MuestrasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MuestrasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MuestrasBindingNavigator.Size = New System.Drawing.Size(866, 30)
        Me.MuestrasBindingNavigator.TabIndex = 174
        Me.MuestrasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorAddNewItem.Image = Global.Scila7.My.Resources.Resources.Plus1
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(107, 27)
        Me.BindingNavigatorAddNewItem.Text = "Nueva muestra"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 27)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorDeleteItem.Image = Global.Scila7.My.Resources.Resources.Cancel1
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(116, 27)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar muestra"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveFirstItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveFirstItem.Text = "|<"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMovePreviousItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMovePreviousItem.Text = "<"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.BindingNavigatorPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BindingNavigatorPositionItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 16)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveNextItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveNextItem.Text = ">"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveLastItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveLastItem.Text = ">|"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'IdMuestraTextBox
        '
        Me.IdMuestraTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.IdMuestraTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IdMuestraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IdMuestra", True))
        Me.IdMuestraTextBox.Location = New System.Drawing.Point(432, 12)
        Me.IdMuestraTextBox.Name = "IdMuestraTextBox"
        Me.IdMuestraTextBox.Size = New System.Drawing.Size(31, 13)
        Me.IdMuestraTextBox.TabIndex = 175
        '
        'frmMacroinvertebrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(866, 583)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
        Me.Controls.Add(Me.txtHelp)
        Me.Controls.Add(Me.btnEditarListaTaxones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TaxonesPresentes)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCantidadAgregar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TaxonesDataGridView)
        Me.Controls.Add(Me.IdMuestraTextBox)
        Me.Name = "frmMacroinvertebrados"
        Me.Text = "MACROINVERTEBRADOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MacroinvertebradosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesPresentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesmuestrasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.fototaxon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MuestrasBindingNavigator.ResumeLayout(False)
        Me.MuestrasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents MacroinvertebradosDataSet As Scila7.macroinvertebradosDataSet
    Friend WithEvents TaxonesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TaxonesTableAdapter As Scila7.macroinvertebradosDataSetTableAdapters.TaxonesTableAdapter
    Friend WithEvents TaxonesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TaxonesmuestrasDataSet As Scila7.taxonesmuestrasDataSet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TaxonesPresentes As System.Windows.Forms.DataGridView
    Friend WithEvents IdTaxon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Taxón As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCantidadAgregar As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As C1.Win.C1Input.C1Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents fototaxon As C1.Win.C1Input.C1PictureBox
    Friend WithEvents NivelTaxonomicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTaxonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NivelPadre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnEditarListaTaxones As System.Windows.Forms.Button
    Friend WithEvents txtHelp As System.Windows.Forms.TextBox
    Friend WithEvents MuestrasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IdMuestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
