<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBDiatomeas
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim IdTaxonLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim NivelTaxonomicoLabel As System.Windows.Forms.Label
        Dim AcronimoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBDiatomeas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtValorIndice = New System.Windows.Forms.TextBox()
        Me.cmbIndice = New System.Windows.Forms.ComboBox()
        Me.CalculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnCambiarFoto = New System.Windows.Forms.Button()
        Me.grpTaxon = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TaxonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiatomeasDataSet = New Scila7.diatomeasDataSet()
        Me.IdTaxonTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.NivelTaxonomicoTextBox = New System.Windows.Forms.TextBox()
        Me.AcronimoTextBox = New System.Windows.Forms.TextBox()
        Me.TaxonesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxonesTableAdapter = New Scila7.diatomeasDataSetTableAdapters.TaxonesTableAdapter()
        Me.TableAdapterManager = New Scila7.diatomeasDataSetTableAdapters.TableAdapterManager()
        Me.TaxonesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TaxonesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CalculosTableAdapter = New Scila7.ConfigDataSetTableAdapters.CalculosTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        IdTaxonLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        NivelTaxonomicoLabel = New System.Windows.Forms.Label()
        AcronimoLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.CalculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTaxon.SuspendLayout()
        CType(Me.TaxonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiatomeasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaxonesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(41, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'IdTaxonLabel
        '
        IdTaxonLabel.AutoSize = True
        IdTaxonLabel.Location = New System.Drawing.Point(41, 48)
        IdTaxonLabel.Name = "IdTaxonLabel"
        IdTaxonLabel.Size = New System.Drawing.Size(52, 13)
        IdTaxonLabel.TabIndex = 2
        IdTaxonLabel.Text = "Id Taxon:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(41, 74)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(41, 126)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 6
        AutorLabel.Text = "Autor:"
        '
        'NivelTaxonomicoLabel
        '
        NivelTaxonomicoLabel.AutoSize = True
        NivelTaxonomicoLabel.Location = New System.Drawing.Point(41, 152)
        NivelTaxonomicoLabel.Name = "NivelTaxonomicoLabel"
        NivelTaxonomicoLabel.Size = New System.Drawing.Size(95, 13)
        NivelTaxonomicoLabel.TabIndex = 8
        NivelTaxonomicoLabel.Text = "Nivel Taxonomico:"
        '
        'AcronimoLabel
        '
        AcronimoLabel.AutoSize = True
        AcronimoLabel.Location = New System.Drawing.Point(41, 100)
        AcronimoLabel.Name = "AcronimoLabel"
        AcronimoLabel.Size = New System.Drawing.Size(54, 13)
        AcronimoLabel.TabIndex = 20
        AcronimoLabel.Text = "Acronimo:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtValorIndice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbIndice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCambiarFoto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpTaxon)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TaxonesDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(978, 562)
        Me.SplitContainer1.SplitterDistance = 309
        Me.SplitContainer1.TabIndex = 2
        '
        'txtValorIndice
        '
        Me.txtValorIndice.Location = New System.Drawing.Point(426, 164)
        Me.txtValorIndice.Name = "txtValorIndice"
        Me.txtValorIndice.Size = New System.Drawing.Size(100, 20)
        Me.txtValorIndice.TabIndex = 44
        '
        'cmbIndice
        '
        Me.cmbIndice.DataSource = Me.CalculosBindingSource
        Me.cmbIndice.DisplayMember = "Nombre"
        Me.cmbIndice.FormattingEnabled = True
        Me.cmbIndice.Location = New System.Drawing.Point(330, 43)
        Me.cmbIndice.Name = "cmbIndice"
        Me.cmbIndice.Size = New System.Drawing.Size(196, 21)
        Me.cmbIndice.TabIndex = 43
        Me.cmbIndice.ValueMember = "Codigo"
        '
        'CalculosBindingSource
        '
        Me.CalculosBindingSource.DataMember = "Calculos"
        Me.CalculosBindingSource.DataSource = Me.ConfigDataSet
        '
        'ConfigDataSet
        '
        Me.ConfigDataSet.DataSetName = "ConfigDataSet"
        Me.ConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(532, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 230)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(731, 37)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(235, 259)
        Me.TreeView1.TabIndex = 41
        '
        'btnCambiarFoto
        '
        Me.btnCambiarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarFoto.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnCambiarFoto.Location = New System.Drawing.Point(663, 273)
        Me.btnCambiarFoto.Name = "btnCambiarFoto"
        Me.btnCambiarFoto.Size = New System.Drawing.Size(62, 23)
        Me.btnCambiarFoto.TabIndex = 40
        Me.btnCambiarFoto.Text = "Cambiar"
        Me.btnCambiarFoto.UseVisualStyleBackColor = True
        '
        'grpTaxon
        '
        Me.grpTaxon.Controls.Add(IdLabel)
        Me.grpTaxon.Controls.Add(Me.IdTextBox)
        Me.grpTaxon.Controls.Add(IdTaxonLabel)
        Me.grpTaxon.Controls.Add(Me.IdTaxonTextBox)
        Me.grpTaxon.Controls.Add(NombreLabel)
        Me.grpTaxon.Controls.Add(Me.NombreTextBox)
        Me.grpTaxon.Controls.Add(AutorLabel)
        Me.grpTaxon.Controls.Add(Me.AutorTextBox)
        Me.grpTaxon.Controls.Add(NivelTaxonomicoLabel)
        Me.grpTaxon.Controls.Add(Me.NivelTaxonomicoTextBox)
        Me.grpTaxon.Controls.Add(AcronimoLabel)
        Me.grpTaxon.Controls.Add(Me.AcronimoTextBox)
        Me.grpTaxon.Location = New System.Drawing.Point(12, 37)
        Me.grpTaxon.Name = "grpTaxon"
        Me.grpTaxon.Size = New System.Drawing.Size(312, 187)
        Me.grpTaxon.TabIndex = 34
        Me.grpTaxon.TabStop = False
        Me.grpTaxon.Text = "Datos del Taxon"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(259, 15)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(47, 20)
        Me.IdTextBox.TabIndex = 1
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
        'IdTaxonTextBox
        '
        Me.IdTaxonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "IdTaxon", True))
        Me.IdTaxonTextBox.Location = New System.Drawing.Point(259, 41)
        Me.IdTaxonTextBox.Name = "IdTaxonTextBox"
        Me.IdTaxonTextBox.Size = New System.Drawing.Size(47, 20)
        Me.IdTaxonTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(111, 67)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(195, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Autor", True))
        Me.AutorTextBox.Location = New System.Drawing.Point(111, 119)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(195, 20)
        Me.AutorTextBox.TabIndex = 7
        '
        'NivelTaxonomicoTextBox
        '
        Me.NivelTaxonomicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "NivelTaxonomico", True))
        Me.NivelTaxonomicoTextBox.Location = New System.Drawing.Point(163, 145)
        Me.NivelTaxonomicoTextBox.Name = "NivelTaxonomicoTextBox"
        Me.NivelTaxonomicoTextBox.Size = New System.Drawing.Size(143, 20)
        Me.NivelTaxonomicoTextBox.TabIndex = 9
        '
        'AcronimoTextBox
        '
        Me.AcronimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Acronimo", True))
        Me.AcronimoTextBox.Location = New System.Drawing.Point(259, 93)
        Me.AcronimoTextBox.Name = "AcronimoTextBox"
        Me.AcronimoTextBox.Size = New System.Drawing.Size(47, 20)
        Me.AcronimoTextBox.TabIndex = 21
        '
        'TaxonesDataGridView
        '
        Me.TaxonesDataGridView.AllowUserToAddRows = False
        Me.TaxonesDataGridView.AllowUserToDeleteRows = False
        Me.TaxonesDataGridView.AllowUserToResizeColumns = False
        Me.TaxonesDataGridView.AllowUserToResizeRows = False
        Me.TaxonesDataGridView.AutoGenerateColumns = False
        Me.TaxonesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TaxonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaxonesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn11})
        Me.TaxonesDataGridView.DataSource = Me.TaxonesBindingSource
        Me.TaxonesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaxonesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TaxonesDataGridView.Name = "TaxonesDataGridView"
        Me.TaxonesDataGridView.Size = New System.Drawing.Size(978, 249)
        Me.TaxonesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdTaxon"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdTaxon"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NivelTaxonomico"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NivelTaxonomico"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Foto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Foto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Acronimo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Acronimo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
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
        'TaxonesBindingNavigator
        '
        Me.TaxonesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TaxonesBindingNavigator.BindingSource = Me.TaxonesBindingSource
        Me.TaxonesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TaxonesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TaxonesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TaxonesBindingNavigatorSaveItem})
        Me.TaxonesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TaxonesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TaxonesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TaxonesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TaxonesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TaxonesBindingNavigator.Name = "TaxonesBindingNavigator"
        Me.TaxonesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TaxonesBindingNavigator.Size = New System.Drawing.Size(978, 25)
        Me.TaxonesBindingNavigator.TabIndex = 3
        Me.TaxonesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TaxonesBindingNavigatorSaveItem
        '
        Me.TaxonesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TaxonesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TaxonesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TaxonesBindingNavigatorSaveItem.Name = "TaxonesBindingNavigatorSaveItem"
        Me.TaxonesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TaxonesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CalculosTableAdapter
        '
        Me.CalculosTableAdapter.ClearBeforeFill = True
        '
        'frmDBDiatomeas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(978, 562)
        Me.Controls.Add(Me.TaxonesBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmDBDiatomeas"
        Me.Text = "Base de datos de Diatomeas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.CalculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTaxon.ResumeLayout(False)
        Me.grpTaxon.PerformLayout()
        CType(Me.TaxonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiatomeasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaxonesBindingNavigator.ResumeLayout(False)
        Me.TaxonesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grpTaxon As System.Windows.Forms.GroupBox
    Friend WithEvents btnCambiarFoto As System.Windows.Forms.Button
    Friend WithEvents DiatomeasDataSet As Scila7.diatomeasDataSet
    Friend WithEvents TaxonesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TaxonesTableAdapter As Scila7.diatomeasDataSetTableAdapters.TaxonesTableAdapter
    Friend WithEvents TableAdapterManager As Scila7.diatomeasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TaxonesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TaxonesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTaxonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NivelTaxonomicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AcronimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaxonesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtValorIndice As System.Windows.Forms.TextBox
    Friend WithEvents cmbIndice As System.Windows.Forms.ComboBox
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents CalculosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalculosTableAdapter As Scila7.ConfigDataSetTableAdapters.CalculosTableAdapter
End Class
