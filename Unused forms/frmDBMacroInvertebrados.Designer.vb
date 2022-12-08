<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBMacroInvertebrados
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
        Dim FotoLabel As System.Windows.Forms.Label
        Dim NivelPadreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBMacroInvertebrados))
        Me.TaxonesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TaxonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MacroinvertebradosDataSet = New Scila7.macroinvertebradosDataSet()
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnGuardarIndices = New System.Windows.Forms.Button()
        Me.btnCambiarFoto = New System.Windows.Forms.Button()
        Me.btnEditarIndices = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.FotoC1PictureBox = New C1.Win.C1Input.C1PictureBox()
        Me.grpIndices = New System.Windows.Forms.GroupBox()
        Me.grpAmbientes = New System.Windows.Forms.GroupBox()
        Me.grpTaxon = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarPadre = New System.Windows.Forms.Button()
        Me.CategoriaPadreComboBox = New System.Windows.Forms.ComboBox()
        Me.TaxonesBindingSourceIndep = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGuardarPadre = New System.Windows.Forms.Button()
        Me.btnCambiarPadre = New System.Windows.Forms.Button()
        Me.CategoriaPadreTextBox = New System.Windows.Forms.TextBox()
        Me.NivelTaxonomicoComboBox = New System.Windows.Forms.ComboBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.IdTaxonTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.TaxonesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTaxonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelTaxonomicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelPadre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaracMacroinvIMRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImrpDataSet = New Scila7.imrpDataSet()
        Me.CaracMacroinvIBPAMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbpampDataSet = New Scila7.ibpampDataSet()
        Me.TaxonesTableAdapter = New Scila7.macroinvertebradosDataSetTableAdapters.TaxonesTableAdapter()
        Me.TableAdapterManager = New Scila7.bmpsDataSetTableAdapters.TableAdapterManager()
        Me.IMRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMRPTableAdapter = New Scila7.imrpDataSetTableAdapters.IMRPTableAdapter()
        Me.TableAdapterManager1 = New Scila7.imrpDataSetTableAdapters.TableAdapterManager()
        Me.CaracMacroinvIMRPTableAdapter = New Scila7.imrpDataSetTableAdapters.CaracIMRPTableAdapter()
        Me.IBPAMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IBPAMPTableAdapter = New Scila7.ibpampDataSetTableAdapters.IBPAMPTableAdapter()
        Me.TableAdapterManager2 = New Scila7.ibpampDataSetTableAdapters.TableAdapterManager()
        Me.CaracMacroinvIBPAMPTableAdapter = New Scila7.ibpampDataSetTableAdapters.CaracIBPAMPTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        IdTaxonLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        NivelTaxonomicoLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        NivelPadreLabel = New System.Windows.Forms.Label()
        CType(Me.TaxonesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaxonesBindingNavigator.SuspendLayout()
        CType(Me.TaxonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MacroinvertebradosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.FotoC1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTaxon.SuspendLayout()
        CType(Me.TaxonesBindingSourceIndep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaracMacroinvIMRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImrpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaracMacroinvIBPAMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbpampDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(25, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'IdTaxonLabel
        '
        IdTaxonLabel.AutoSize = True
        IdTaxonLabel.Location = New System.Drawing.Point(25, 48)
        IdTaxonLabel.Name = "IdTaxonLabel"
        IdTaxonLabel.Size = New System.Drawing.Size(52, 13)
        IdTaxonLabel.TabIndex = 2
        IdTaxonLabel.Text = "Id Taxon:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(25, 74)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(25, 100)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 6
        AutorLabel.Text = "Autor:"
        '
        'NivelTaxonomicoLabel
        '
        NivelTaxonomicoLabel.AutoSize = True
        NivelTaxonomicoLabel.Location = New System.Drawing.Point(25, 126)
        NivelTaxonomicoLabel.Name = "NivelTaxonomicoLabel"
        NivelTaxonomicoLabel.Size = New System.Drawing.Size(57, 13)
        NivelTaxonomicoLabel.TabIndex = 8
        NivelTaxonomicoLabel.Text = "Categoría:"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Location = New System.Drawing.Point(371, 158)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(31, 13)
        FotoLabel.TabIndex = 10
        FotoLabel.Text = "Foto:"
        '
        'NivelPadreLabel
        '
        NivelPadreLabel.AutoSize = True
        NivelPadreLabel.Location = New System.Drawing.Point(25, 191)
        NivelPadreLabel.Name = "NivelPadreLabel"
        NivelPadreLabel.Size = New System.Drawing.Size(87, 13)
        NivelPadreLabel.TabIndex = 12
        NivelPadreLabel.Text = "Categoría padre:"
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
        Me.TaxonesBindingNavigator.TabIndex = 0
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGuardarIndices)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCambiarFoto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnEditarIndices)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FotoC1PictureBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpIndices)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpAmbientes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpTaxon)
        Me.SplitContainer1.Panel1.Controls.Add(FotoLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TaxonesDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(978, 537)
        Me.SplitContainer1.SplitterDistance = 356
        Me.SplitContainer1.TabIndex = 2
        '
        'btnGuardarIndices
        '
        Me.btnGuardarIndices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarIndices.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnGuardarIndices.Location = New System.Drawing.Point(559, 158)
        Me.btnGuardarIndices.Name = "btnGuardarIndices"
        Me.btnGuardarIndices.Size = New System.Drawing.Size(121, 23)
        Me.btnGuardarIndices.TabIndex = 40
        Me.btnGuardarIndices.Text = "Guardar Índices"
        Me.btnGuardarIndices.UseVisualStyleBackColor = True
        Me.btnGuardarIndices.Visible = False
        '
        'btnCambiarFoto
        '
        Me.btnCambiarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarFoto.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnCambiarFoto.Location = New System.Drawing.Point(408, 263)
        Me.btnCambiarFoto.Name = "btnCambiarFoto"
        Me.btnCambiarFoto.Size = New System.Drawing.Size(125, 23)
        Me.btnCambiarFoto.TabIndex = 40
        Me.btnCambiarFoto.Text = "Cambiar foto"
        Me.btnCambiarFoto.UseVisualStyleBackColor = True
        '
        'btnEditarIndices
        '
        Me.btnEditarIndices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarIndices.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnEditarIndices.Location = New System.Drawing.Point(559, 132)
        Me.btnEditarIndices.Name = "btnEditarIndices"
        Me.btnEditarIndices.Size = New System.Drawing.Size(121, 23)
        Me.btnEditarIndices.TabIndex = 39
        Me.btnEditarIndices.Text = "Editar Índices"
        Me.btnEditarIndices.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Button2.Location = New System.Drawing.Point(860, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Recargar árbol"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(701, 45)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(265, 298)
        Me.TreeView1.TabIndex = 37
        '
        'FotoC1PictureBox
        '
        Me.FotoC1PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoC1PictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TaxonesBindingSource, "Foto", True))
        Me.FotoC1PictureBox.Location = New System.Drawing.Point(408, 158)
        Me.FotoC1PictureBox.Name = "FotoC1PictureBox"
        Me.FotoC1PictureBox.Size = New System.Drawing.Size(125, 99)
        Me.FotoC1PictureBox.TabIndex = 11
        Me.FotoC1PictureBox.TabStop = False
        '
        'grpIndices
        '
        Me.grpIndices.Enabled = False
        Me.grpIndices.Location = New System.Drawing.Point(548, 16)
        Me.grpIndices.Name = "grpIndices"
        Me.grpIndices.Size = New System.Drawing.Size(147, 113)
        Me.grpIndices.TabIndex = 36
        Me.grpIndices.TabStop = False
        Me.grpIndices.Text = "Índices"
        '
        'grpAmbientes
        '
        Me.grpAmbientes.Location = New System.Drawing.Point(361, 16)
        Me.grpAmbientes.Name = "grpAmbientes"
        Me.grpAmbientes.Size = New System.Drawing.Size(172, 136)
        Me.grpAmbientes.TabIndex = 35
        Me.grpAmbientes.TabStop = False
        Me.grpAmbientes.Text = "Ambientes"
        '
        'grpTaxon
        '
        Me.grpTaxon.Controls.Add(Me.btnLimpiarPadre)
        Me.grpTaxon.Controls.Add(Me.CategoriaPadreComboBox)
        Me.grpTaxon.Controls.Add(Me.btnGuardarPadre)
        Me.grpTaxon.Controls.Add(Me.btnCambiarPadre)
        Me.grpTaxon.Controls.Add(Me.CategoriaPadreTextBox)
        Me.grpTaxon.Controls.Add(NivelPadreLabel)
        Me.grpTaxon.Controls.Add(Me.NivelTaxonomicoComboBox)
        Me.grpTaxon.Controls.Add(IdLabel)
        Me.grpTaxon.Controls.Add(Me.IdTextBox)
        Me.grpTaxon.Controls.Add(IdTaxonLabel)
        Me.grpTaxon.Controls.Add(Me.IdTaxonTextBox)
        Me.grpTaxon.Controls.Add(NombreLabel)
        Me.grpTaxon.Controls.Add(Me.NombreTextBox)
        Me.grpTaxon.Controls.Add(AutorLabel)
        Me.grpTaxon.Controls.Add(Me.AutorTextBox)
        Me.grpTaxon.Controls.Add(NivelTaxonomicoLabel)
        Me.grpTaxon.Location = New System.Drawing.Point(11, 16)
        Me.grpTaxon.Name = "grpTaxon"
        Me.grpTaxon.Size = New System.Drawing.Size(332, 277)
        Me.grpTaxon.TabIndex = 34
        Me.grpTaxon.TabStop = False
        Me.grpTaxon.Text = "Datos del Taxon"
        '
        'btnLimpiarPadre
        '
        Me.btnLimpiarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarPadre.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnLimpiarPadre.Location = New System.Drawing.Point(182, 239)
        Me.btnLimpiarPadre.Name = "btnLimpiarPadre"
        Me.btnLimpiarPadre.Size = New System.Drawing.Size(62, 23)
        Me.btnLimpiarPadre.TabIndex = 19
        Me.btnLimpiarPadre.Text = "Limpiar"
        Me.btnLimpiarPadre.UseVisualStyleBackColor = True
        Me.btnLimpiarPadre.Visible = False
        '
        'CategoriaPadreComboBox
        '
        Me.CategoriaPadreComboBox.DataSource = Me.TaxonesBindingSourceIndep
        Me.CategoriaPadreComboBox.DisplayMember = "Nombre"
        Me.CategoriaPadreComboBox.FormattingEnabled = True
        Me.CategoriaPadreComboBox.Location = New System.Drawing.Point(126, 217)
        Me.CategoriaPadreComboBox.Name = "CategoriaPadreComboBox"
        Me.CategoriaPadreComboBox.Size = New System.Drawing.Size(186, 21)
        Me.CategoriaPadreComboBox.TabIndex = 18
        Me.CategoriaPadreComboBox.Visible = False
        '
        'TaxonesBindingSourceIndep
        '
        Me.TaxonesBindingSourceIndep.DataMember = "Taxones"
        Me.TaxonesBindingSourceIndep.DataSource = Me.MacroinvertebradosDataSet
        '
        'btnGuardarPadre
        '
        Me.btnGuardarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPadre.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnGuardarPadre.Location = New System.Drawing.Point(250, 238)
        Me.btnGuardarPadre.Name = "btnGuardarPadre"
        Me.btnGuardarPadre.Size = New System.Drawing.Size(62, 23)
        Me.btnGuardarPadre.TabIndex = 17
        Me.btnGuardarPadre.Text = "Guardar"
        Me.btnGuardarPadre.UseVisualStyleBackColor = True
        Me.btnGuardarPadre.Visible = False
        '
        'btnCambiarPadre
        '
        Me.btnCambiarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarPadre.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnCambiarPadre.Location = New System.Drawing.Point(250, 185)
        Me.btnCambiarPadre.Name = "btnCambiarPadre"
        Me.btnCambiarPadre.Size = New System.Drawing.Size(62, 23)
        Me.btnCambiarPadre.TabIndex = 16
        Me.btnCambiarPadre.Text = "Cambiar"
        Me.btnCambiarPadre.UseVisualStyleBackColor = True
        '
        'CategoriaPadreTextBox
        '
        Me.CategoriaPadreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "NivelPadre", True))
        Me.CategoriaPadreTextBox.Enabled = False
        Me.CategoriaPadreTextBox.Location = New System.Drawing.Point(126, 186)
        Me.CategoriaPadreTextBox.Name = "CategoriaPadreTextBox"
        Me.CategoriaPadreTextBox.Size = New System.Drawing.Size(118, 20)
        Me.CategoriaPadreTextBox.TabIndex = 15
        '
        'NivelTaxonomicoComboBox
        '
        Me.NivelTaxonomicoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "NivelTaxonomico", True))
        Me.NivelTaxonomicoComboBox.FormattingEnabled = True
        Me.NivelTaxonomicoComboBox.Location = New System.Drawing.Point(126, 122)
        Me.NivelTaxonomicoComboBox.Name = "NivelTaxonomicoComboBox"
        Me.NivelTaxonomicoComboBox.Size = New System.Drawing.Size(186, 21)
        Me.NivelTaxonomicoComboBox.TabIndex = 12
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(173, 19)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(53, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'IdTaxonTextBox
        '
        Me.IdTaxonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "IdTaxon", True))
        Me.IdTaxonTextBox.Location = New System.Drawing.Point(173, 45)
        Me.IdTaxonTextBox.Name = "IdTaxonTextBox"
        Me.IdTaxonTextBox.Size = New System.Drawing.Size(53, 20)
        Me.IdTaxonTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(126, 71)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(186, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaxonesBindingSource, "Autor", True))
        Me.AutorTextBox.Location = New System.Drawing.Point(126, 97)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(186, 20)
        Me.AutorTextBox.TabIndex = 7
        '
        'TaxonesDataGridView
        '
        Me.TaxonesDataGridView.AllowUserToAddRows = False
        Me.TaxonesDataGridView.AllowUserToResizeColumns = False
        Me.TaxonesDataGridView.AllowUserToResizeRows = False
        Me.TaxonesDataGridView.AutoGenerateColumns = False
        Me.TaxonesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TaxonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaxonesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdTaxonDataGridViewTextBoxColumn, Me.Nombre, Me.AutorDataGridViewTextBoxColumn, Me.NivelTaxonomicoDataGridViewTextBoxColumn, Me.NivelPadre, Me.FotoDataGridViewTextBoxColumn})
        Me.TaxonesDataGridView.DataSource = Me.TaxonesBindingSource
        Me.TaxonesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaxonesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TaxonesDataGridView.Name = "TaxonesDataGridView"
        Me.TaxonesDataGridView.Size = New System.Drawing.Size(978, 177)
        Me.TaxonesDataGridView.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'IdTaxonDataGridViewTextBoxColumn
        '
        Me.IdTaxonDataGridViewTextBoxColumn.DataPropertyName = "IdTaxon"
        Me.IdTaxonDataGridViewTextBoxColumn.HeaderText = "IdTaxon"
        Me.IdTaxonDataGridViewTextBoxColumn.Name = "IdTaxonDataGridViewTextBoxColumn"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'AutorDataGridViewTextBoxColumn
        '
        Me.AutorDataGridViewTextBoxColumn.DataPropertyName = "Autor"
        Me.AutorDataGridViewTextBoxColumn.HeaderText = "Autor"
        Me.AutorDataGridViewTextBoxColumn.Name = "AutorDataGridViewTextBoxColumn"
        '
        'NivelTaxonomicoDataGridViewTextBoxColumn
        '
        Me.NivelTaxonomicoDataGridViewTextBoxColumn.DataPropertyName = "NivelTaxonomico"
        Me.NivelTaxonomicoDataGridViewTextBoxColumn.HeaderText = "NivelTaxonomico"
        Me.NivelTaxonomicoDataGridViewTextBoxColumn.Name = "NivelTaxonomicoDataGridViewTextBoxColumn"
        '
        'NivelPadre
        '
        Me.NivelPadre.DataPropertyName = "NivelPadre"
        Me.NivelPadre.HeaderText = "NivelPadre"
        Me.NivelPadre.Name = "NivelPadre"
        '
        'FotoDataGridViewTextBoxColumn
        '
        Me.FotoDataGridViewTextBoxColumn.DataPropertyName = "Foto"
        Me.FotoDataGridViewTextBoxColumn.HeaderText = "Foto"
        Me.FotoDataGridViewTextBoxColumn.Name = "FotoDataGridViewTextBoxColumn"
        '
        'CaracMacroinvIMRPBindingSource
        '
        Me.CaracMacroinvIMRPBindingSource.DataMember = "CaracIMRP"
        Me.CaracMacroinvIMRPBindingSource.DataSource = Me.ImrpDataSet
        '
        'ImrpDataSet
        '
        Me.ImrpDataSet.DataSetName = "imrpDataSet"
        Me.ImrpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaracMacroinvIBPAMPBindingSource
        '
        Me.CaracMacroinvIBPAMPBindingSource.DataMember = "CaracIBPAMP"
        Me.CaracMacroinvIBPAMPBindingSource.DataSource = Me.IbpampDataSet
        '
        'IbpampDataSet
        '
        Me.IbpampDataSet.DataSetName = "ibpampDataSet"
        Me.IbpampDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaxonesTableAdapter
        '
        Me.TaxonesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BMPSTableAdapter = Nothing
        Me.TableAdapterManager.CaracBMPSTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Scila7.bmpsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IMRPBindingSource
        '
        Me.IMRPBindingSource.DataMember = "IMRP"
        Me.IMRPBindingSource.DataSource = Me.ImrpDataSet
        '
        'IMRPTableAdapter
        '
        Me.IMRPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CaracIMRPTableAdapter = Me.CaracMacroinvIMRPTableAdapter
        Me.TableAdapterManager1.IMRPTableAdapter = Me.IMRPTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Scila7.imrpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CaracMacroinvIMRPTableAdapter
        '
        Me.CaracMacroinvIMRPTableAdapter.ClearBeforeFill = True
        '
        'IBPAMPBindingSource
        '
        Me.IBPAMPBindingSource.DataMember = "IBPAMP"
        Me.IBPAMPBindingSource.DataSource = Me.IbpampDataSet
        '
        'IBPAMPTableAdapter
        '
        Me.IBPAMPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.CaracIBPAMPTableAdapter = Me.CaracMacroinvIBPAMPTableAdapter
        Me.TableAdapterManager2.IBPAMPTableAdapter = Me.IBPAMPTableAdapter
        Me.TableAdapterManager2.UpdateOrder = Scila7.ibpampDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CaracMacroinvIBPAMPTableAdapter
        '
        Me.CaracMacroinvIBPAMPTableAdapter.ClearBeforeFill = True
        '
        'frmDBMacroInvertebrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(978, 562)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TaxonesBindingNavigator)
        Me.Name = "frmDBMacroInvertebrados"
        Me.Text = "Base de datos de Macroinvertebrados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TaxonesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaxonesBindingNavigator.ResumeLayout(False)
        Me.TaxonesBindingNavigator.PerformLayout()
        CType(Me.TaxonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MacroinvertebradosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.FotoC1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTaxon.ResumeLayout(False)
        Me.grpTaxon.PerformLayout()
        CType(Me.TaxonesBindingSourceIndep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaracMacroinvIMRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImrpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaracMacroinvIBPAMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbpampDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MacroinvertebradosDataSet As Scila7.macroinvertebradosDataSet
    Friend WithEvents TaxonesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TaxonesTableAdapter As Scila7.macroinvertebradosDataSetTableAdapters.TaxonesTableAdapter
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTaxonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FotoC1PictureBox As C1.Win.C1Input.C1PictureBox
    Friend WithEvents TaxonesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents grpTaxon As System.Windows.Forms.GroupBox
    Friend WithEvents grpIndices As System.Windows.Forms.GroupBox
    Friend WithEvents grpAmbientes As System.Windows.Forms.GroupBox
    Friend WithEvents NivelTaxonomicoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TaxonesBindingSourceIndep As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaPadreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiarPadre As System.Windows.Forms.Button
    Friend WithEvents btnGuardarPadre As System.Windows.Forms.Button
    Friend WithEvents CategoriaPadreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTaxonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NivelTaxonomicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NivelPadre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAPampeanoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MRLPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMRPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IBPAMPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IBIRPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAPatagonicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAMontaniaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BMWPprimaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BMPSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IBCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IBSSLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiarPadre As System.Windows.Forms.Button
    Friend WithEvents btnCambiarFoto As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As Scila7.bmpsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImrpDataSet As Scila7.imrpDataSet
    Friend WithEvents IMRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMRPTableAdapter As Scila7.imrpDataSetTableAdapters.IMRPTableAdapter
    Friend WithEvents TableAdapterManager1 As Scila7.imrpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IbpampDataSet As Scila7.ibpampDataSet
    Friend WithEvents IBPAMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IBPAMPTableAdapter As Scila7.ibpampDataSetTableAdapters.IBPAMPTableAdapter
    Friend WithEvents TableAdapterManager2 As Scila7.ibpampDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CaracMacroinvIBPAMPTableAdapter As Scila7.ibpampDataSetTableAdapters.CaracIBPAMPTableAdapter
    Friend WithEvents CaracMacroinvIBPAMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaracMacroinvIMRPTableAdapter As Scila7.imrpDataSetTableAdapters.CaracIMRPTableAdapter
    Friend WithEvents CaracMacroinvIMRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnEditarIndices As System.Windows.Forms.Button
    Friend WithEvents btnGuardarIndices As System.Windows.Forms.Button
End Class
