<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiatomeas
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
        Dim AcronimoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiatomeas))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TaxonesPresentes = New System.Windows.Forms.DataGridView()
        Me.IdTaxon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acronimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Taxón = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCantidadAgregar = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New C1.Win.C1Input.C1Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.AcronimoTextBox = New System.Windows.Forms.TextBox()
        Me.TaxonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiatomeasDataSet = New Scila7.diatomeasDataSet()
        Me.NivelTaxonomicoTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.IdTaxonTextBox = New System.Windows.Forms.TextBox()
        Me.fototaxon = New C1.Win.C1Input.C1PictureBox()
        Me.TaxonesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxonesmuestrasDataSet = New Scila7.taxonesmuestrasDataSet()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.TaxonesTableAdapter = New Scila7.diatomeasDataSetTableAdapters.TaxonesTableAdapter()
        Me.TableAdapterManager = New Scila7.diatomeasDataSetTableAdapters.TableAdapterManager()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearchAcronimo = New System.Windows.Forms.TextBox()
        Me.lblBuscarAcronimo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSearchbyName = New System.Windows.Forms.TextBox()
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
        IdTaxonLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        NivelTaxonomicoLabel = New System.Windows.Forms.Label()
        AcronimoLabel = New System.Windows.Forms.Label()
        CType(Me.TaxonesPresentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfo.SuspendLayout()
        CType(Me.TaxonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiatomeasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fototaxon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesmuestrasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdTaxonLabel
        '
        IdTaxonLabel.AutoSize = True
        IdTaxonLabel.Location = New System.Drawing.Point(16, 31)
        IdTaxonLabel.Name = "IdTaxonLabel"
        IdTaxonLabel.Size = New System.Drawing.Size(52, 13)
        IdTaxonLabel.TabIndex = 9
        IdTaxonLabel.Text = "Id Taxon:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(21, 57)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 10
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(33, 108)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 11
        AutorLabel.Text = "Autor:"
        '
        'NivelTaxonomicoLabel
        '
        NivelTaxonomicoLabel.AutoSize = True
        NivelTaxonomicoLabel.Location = New System.Drawing.Point(12, 134)
        NivelTaxonomicoLabel.Name = "NivelTaxonomicoLabel"
        NivelTaxonomicoLabel.Size = New System.Drawing.Size(57, 13)
        NivelTaxonomicoLabel.TabIndex = 12
        NivelTaxonomicoLabel.Text = "Categoría:"
        '
        'AcronimoLabel
        '
        AcronimoLabel.AutoSize = True
        AcronimoLabel.Location = New System.Drawing.Point(15, 82)
        AcronimoLabel.Name = "AcronimoLabel"
        AcronimoLabel.Size = New System.Drawing.Size(54, 13)
        AcronimoLabel.TabIndex = 13
        AcronimoLabel.Text = "Acronimo:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(595, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Taxones en la muestra"
        '
        'TaxonesPresentes
        '
        Me.TaxonesPresentes.AllowUserToAddRows = False
        Me.TaxonesPresentes.AllowUserToDeleteRows = False
        Me.TaxonesPresentes.AllowUserToOrderColumns = True
        Me.TaxonesPresentes.AllowUserToResizeColumns = False
        Me.TaxonesPresentes.AllowUserToResizeRows = False
        Me.TaxonesPresentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaxonesPresentes.BackgroundColor = System.Drawing.Color.White
        Me.TaxonesPresentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaxonesPresentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTaxon, Me.Acronimo, Me.Taxón, Me.Cantidad})
        Me.TaxonesPresentes.GridColor = System.Drawing.Color.White
        Me.TaxonesPresentes.Location = New System.Drawing.Point(595, 72)
        Me.TaxonesPresentes.Name = "TaxonesPresentes"
        Me.TaxonesPresentes.RowHeadersVisible = False
        Me.TaxonesPresentes.Size = New System.Drawing.Size(256, 426)
        Me.TaxonesPresentes.TabIndex = 40
        Me.TaxonesPresentes.TabStop = False
        '
        'IdTaxon
        '
        Me.IdTaxon.HeaderText = "Id"
        Me.IdTaxon.Name = "IdTaxon"
        Me.IdTaxon.Width = 30
        '
        'Acronimo
        '
        Me.Acronimo.HeaderText = "Acrónimo"
        Me.Acronimo.Name = "Acronimo"
        Me.Acronimo.Width = 50
        '
        'Taxón
        '
        Me.Taxón.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Taxón.DefaultCellStyle = DataGridViewCellStyle1
        Me.Taxón.HeaderText = "Taxón"
        Me.Taxón.Name = "Taxón"
        '
        'Cantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 80
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(337, 72)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(252, 58)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = ">> Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtCantidadAgregar
        '
        Me.txtCantidadAgregar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAgregar.Location = New System.Drawing.Point(187, 99)
        Me.txtCantidadAgregar.Name = "txtCantidadAgregar"
        Me.txtCantidadAgregar.Size = New System.Drawing.Size(129, 26)
        Me.txtCantidadAgregar.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 2
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnGuardar.Location = New System.Drawing.Point(598, 504)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(256, 59)
        Me.btnGuardar.TabIndex = 153
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "Guardar datos de diatomeas"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 18)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Cantidad de individuos"
        '
        'grpInfo
        '
        Me.grpInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInfo.Controls.Add(AcronimoLabel)
        Me.grpInfo.Controls.Add(Me.AcronimoTextBox)
        Me.grpInfo.Controls.Add(NivelTaxonomicoLabel)
        Me.grpInfo.Controls.Add(Me.NivelTaxonomicoTextBox)
        Me.grpInfo.Controls.Add(AutorLabel)
        Me.grpInfo.Controls.Add(Me.AutorTextBox)
        Me.grpInfo.Controls.Add(NombreLabel)
        Me.grpInfo.Controls.Add(Me.NombreTextBox)
        Me.grpInfo.Controls.Add(IdTaxonLabel)
        Me.grpInfo.Controls.Add(Me.IdTaxonTextBox)
        Me.grpInfo.Controls.Add(Me.fototaxon)
        Me.grpInfo.Location = New System.Drawing.Point(337, 136)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(252, 427)
        Me.grpInfo.TabIndex = 159
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Información del Taxón"
        '
        'AcronimoTextBox
        '
        Me.AcronimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Acronimo", True))
        Me.AcronimoTextBox.Location = New System.Drawing.Point(75, 79)
        Me.AcronimoTextBox.Name = "AcronimoTextBox"
        Me.AcronimoTextBox.ReadOnly = True
        Me.AcronimoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AcronimoTextBox.TabIndex = 14
        Me.AcronimoTextBox.TabStop = False
        '
        'TaxonesBindingSource
        '
        Me.TaxonesBindingSource.DataMember = "Taxones"
        Me.TaxonesBindingSource.DataSource = Me.DiatomeasDataSet
        '
        'DiatomeasDataSet
        '
        Me.DiatomeasDataSet.DataSetName = "diatomeasDataSet"
        Me.DiatomeasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NivelTaxonomicoTextBox
        '
        Me.NivelTaxonomicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "NivelTaxonomico", True))
        Me.NivelTaxonomicoTextBox.Location = New System.Drawing.Point(75, 131)
        Me.NivelTaxonomicoTextBox.Name = "NivelTaxonomicoTextBox"
        Me.NivelTaxonomicoTextBox.ReadOnly = True
        Me.NivelTaxonomicoTextBox.Size = New System.Drawing.Size(171, 20)
        Me.NivelTaxonomicoTextBox.TabIndex = 13
        Me.NivelTaxonomicoTextBox.TabStop = False
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Autor", True))
        Me.AutorTextBox.Location = New System.Drawing.Point(74, 105)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.ReadOnly = True
        Me.AutorTextBox.Size = New System.Drawing.Size(172, 20)
        Me.AutorTextBox.TabIndex = 12
        Me.AutorTextBox.TabStop = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(74, 54)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(172, 20)
        Me.NombreTextBox.TabIndex = 11
        Me.NombreTextBox.TabStop = False
        '
        'IdTaxonTextBox
        '
        Me.IdTaxonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "IdTaxon", True))
        Me.IdTaxonTextBox.Location = New System.Drawing.Point(74, 28)
        Me.IdTaxonTextBox.Name = "IdTaxonTextBox"
        Me.IdTaxonTextBox.ReadOnly = True
        Me.IdTaxonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTaxonTextBox.TabIndex = 10
        Me.IdTaxonTextBox.TabStop = False
        '
        'fototaxon
        '
        Me.fototaxon.ErrorImage = Global.Scila7.My.Resources.Resources.logoKerku
        Me.fototaxon.Location = New System.Drawing.Point(19, 157)
        Me.fototaxon.Name = "fototaxon"
        Me.fototaxon.Size = New System.Drawing.Size(231, 254)
        Me.fototaxon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fototaxon.TabIndex = 9
        Me.fototaxon.TabStop = False
        '
        'TaxonesDataGridView
        '
        Me.TaxonesDataGridView.AllowUserToAddRows = False
        Me.TaxonesDataGridView.AllowUserToDeleteRows = False
        Me.TaxonesDataGridView.AllowUserToResizeRows = False
        Me.TaxonesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaxonesDataGridView.AutoGenerateColumns = False
        Me.TaxonesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TaxonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaxonesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TaxonesDataGridView.DataSource = Me.TaxonesBindingSource
        Me.TaxonesDataGridView.Location = New System.Drawing.Point(12, 131)
        Me.TaxonesDataGridView.Name = "TaxonesDataGridView"
        Me.TaxonesDataGridView.ReadOnly = True
        Me.TaxonesDataGridView.RowHeadersVisible = False
        Me.TaxonesDataGridView.Size = New System.Drawing.Size(319, 432)
        Me.TaxonesDataGridView.TabIndex = 159
        Me.TaxonesDataGridView.TabStop = False
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
        Me.DataGridViewTextBoxColumn2.Width = 30
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Acronimo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Acrónimo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
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
        'TaxonesmuestrasDataSet
        '
        Me.TaxonesmuestrasDataSet.DataSetName = "taxonesmuestrasDataSet"
        Me.TaxonesmuestrasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TaxonesTableAdapter
        '
        Me.TaxonesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TaxonesTableAdapter = Me.TaxonesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Scila7.diatomeasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Buscar por acrónimo:"
        '
        'txtSearchAcronimo
        '
        Me.txtSearchAcronimo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAcronimo.Location = New System.Drawing.Point(187, 70)
        Me.txtSearchAcronimo.MaxLength = 4
        Me.txtSearchAcronimo.Name = "txtSearchAcronimo"
        Me.txtSearchAcronimo.Size = New System.Drawing.Size(57, 26)
        Me.txtSearchAcronimo.TabIndex = 2
        '
        'lblBuscarAcronimo
        '
        Me.lblBuscarAcronimo.AutoSize = True
        Me.lblBuscarAcronimo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarAcronimo.ForeColor = System.Drawing.Color.Maroon
        Me.lblBuscarAcronimo.Location = New System.Drawing.Point(494, 47)
        Me.lblBuscarAcronimo.Name = "lblBuscarAcronimo"
        Me.lblBuscarAcronimo.Size = New System.Drawing.Size(0, 19)
        Me.lblBuscarAcronimo.TabIndex = 166
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(322, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 19)
        Me.Label5.TabIndex = 169
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 18)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "Buscar por nombre:"
        '
        'txtSearchbyName
        '
        Me.txtSearchbyName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchbyName.Location = New System.Drawing.Point(187, 39)
        Me.txtSearchbyName.MaxLength = 4
        Me.txtSearchbyName.Name = "txtSearchbyName"
        Me.txtSearchbyName.Size = New System.Drawing.Size(402, 26)
        Me.txtSearchbyName.TabIndex = 1
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
        Me.MuestrasBindingNavigator.TabIndex = 175
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
        'frmDiatomeas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(866, 571)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSearchbyName)
        Me.Controls.Add(Me.lblBuscarAcronimo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearchAcronimo)
        Me.Controls.Add(Me.TaxonesPresentes)
        Me.Controls.Add(Me.TaxonesDataGridView)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCantidadAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmDiatomeas"
        Me.Text = "DIATOMEAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TaxonesPresentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.TaxonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiatomeasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fototaxon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesmuestrasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TaxonesmuestrasDataSet As Scila7.taxonesmuestrasDataSet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TaxonesPresentes As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCantidadAgregar As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As C1.Win.C1Input.C1Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents fototaxon As C1.Win.C1Input.C1PictureBox
    Friend WithEvents DiatomeasDataSet As Scila7.diatomeasDataSet
    Friend WithEvents TaxonesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TaxonesTableAdapter As Scila7.diatomeasDataSetTableAdapters.TaxonesTableAdapter
    Friend WithEvents TaxonesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NivelTaxonomicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTaxonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As Scila7.diatomeasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSearchAcronimo As System.Windows.Forms.TextBox
    Friend WithEvents AcronimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscarAcronimo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSearchbyName As System.Windows.Forms.TextBox
    Friend WithEvents IdTaxon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Acronimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Taxón As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MuestrasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
