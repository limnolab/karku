<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosTaxones
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
        Dim NivelTaxonomicoLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim IdTaxonLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosTaxones))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.TaxonesPresentes = New System.Windows.Forms.DataGridView()
        Me.IdTaxon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Taxón = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New C1.Win.C1Input.C1Button()
        Me.txtCantidadAgregar = New System.Windows.Forms.TextBox()
        Me.TaxonesDataGridView = New System.Windows.Forms.DataGridView()
        Me.NivelPadre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchAcronimo = New System.Windows.Forms.TextBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtCategoria = New C1.Win.C1Input.C1TextBox()
        Me.txtAutor = New C1.Win.C1Input.C1TextBox()
        Me.txtNombre = New C1.Win.C1Input.C1TextBox()
        Me.txtIdTaxon = New C1.Win.C1Input.C1TextBox()
        Me.fototaxon = New C1.Win.C1Input.C1PictureBox()
        Me.MuestrasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IdMuestraTextBox = New System.Windows.Forms.TextBox()
        Me.lblMuestraNombre = New System.Windows.Forms.Label()
        Me.txtHelp = New System.Windows.Forms.TextBox()
        Me.btnEditarListaTaxones = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImportarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnciclopediaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirAWindowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarVentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAgregar = New System.Windows.Forms.Button()
        NivelTaxonomicoLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        IdTaxonLabel = New System.Windows.Forms.Label()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesPresentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfo.SuspendLayout()
        CType(Me.txtCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdTaxon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fototaxon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(12, 168)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(376, 436)
        Me.TreeView1.TabIndex = 163
        Me.TreeView1.TabStop = False
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
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
        Me.TaxonesPresentes.Location = New System.Drawing.Point(647, 70)
        Me.TaxonesPresentes.MultiSelect = False
        Me.TaxonesPresentes.Name = "TaxonesPresentes"
        Me.TaxonesPresentes.ReadOnly = True
        Me.TaxonesPresentes.RowHeadersVisible = False
        Me.TaxonesPresentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TaxonesPresentes.Size = New System.Drawing.Size(255, 368)
        Me.TaxonesPresentes.TabIndex = 164
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
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(144, 70)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(244, 27)
        Me.txtSearch.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.Scila7.My.Resources.Resources.save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(647, 545)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(255, 59)
        Me.btnGuardar.TabIndex = 166
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "Guardar datos"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtCantidadAgregar
        '
        Me.txtCantidadAgregar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAgregar.Location = New System.Drawing.Point(302, 135)
        Me.txtCantidadAgregar.Name = "txtCantidadAgregar"
        Me.txtCantidadAgregar.Size = New System.Drawing.Size(86, 27)
        Me.txtCantidadAgregar.TabIndex = 3
        '
        'TaxonesDataGridView
        '
        Me.TaxonesDataGridView.AllowUserToAddRows = False
        Me.TaxonesDataGridView.AllowUserToDeleteRows = False
        Me.TaxonesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TaxonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaxonesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NivelPadre})
        Me.TaxonesDataGridView.Location = New System.Drawing.Point(12, 206)
        Me.TaxonesDataGridView.Name = "TaxonesDataGridView"
        Me.TaxonesDataGridView.ReadOnly = True
        Me.TaxonesDataGridView.RowHeadersVisible = False
        Me.TaxonesDataGridView.Size = New System.Drawing.Size(154, 197)
        Me.TaxonesDataGridView.TabIndex = 168
        Me.TaxonesDataGridView.TabStop = False
        '
        'NivelPadre
        '
        Me.NivelPadre.DataPropertyName = "NivelPadre"
        Me.NivelPadre.HeaderText = "NivelPadre"
        Me.NivelPadre.Name = "NivelPadre"
        Me.NivelPadre.ReadOnly = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 2
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(731, 508)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(171, 31)
        Me.btnEliminar.TabIndex = 170
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "Eliminar taxón seleccionado"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Buscar por nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "Cantidad de individuos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(30, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Buscar por acrónimo:"
        '
        'txtSearchAcronimo
        '
        Me.txtSearchAcronimo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAcronimo.Location = New System.Drawing.Point(331, 103)
        Me.txtSearchAcronimo.MaxLength = 4
        Me.txtSearchAcronimo.Name = "txtSearchAcronimo"
        Me.txtSearchAcronimo.Size = New System.Drawing.Size(57, 26)
        Me.txtSearchAcronimo.TabIndex = 2
        '
        'grpInfo
        '
        Me.grpInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInfo.Controls.Add(Me.txtCategoria)
        Me.grpInfo.Controls.Add(Me.txtAutor)
        Me.grpInfo.Controls.Add(Me.txtNombre)
        Me.grpInfo.Controls.Add(Me.txtIdTaxon)
        Me.grpInfo.Controls.Add(Me.fototaxon)
        Me.grpInfo.Controls.Add(NivelTaxonomicoLabel)
        Me.grpInfo.Controls.Add(AutorLabel)
        Me.grpInfo.Controls.Add(NombreLabel)
        Me.grpInfo.Controls.Add(IdTaxonLabel)
        Me.grpInfo.Location = New System.Drawing.Point(394, 168)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(247, 395)
        Me.grpInfo.TabIndex = 175
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Información del Taxón"
        '
        'txtCategoria
        '
        Me.txtCategoria.Enabled = False
        Me.txtCategoria.Location = New System.Drawing.Point(69, 107)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(125, 18)
        Me.txtCategoria.TabIndex = 13
        Me.txtCategoria.TabStop = False
        Me.txtCategoria.Tag = Nothing
        '
        'txtAutor
        '
        Me.txtAutor.Enabled = False
        Me.txtAutor.Location = New System.Drawing.Point(69, 83)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(125, 18)
        Me.txtAutor.TabIndex = 12
        Me.txtAutor.TabStop = False
        Me.txtAutor.Tag = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(69, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(125, 18)
        Me.txtNombre.TabIndex = 11
        Me.txtNombre.TabStop = False
        Me.txtNombre.Tag = Nothing
        '
        'txtIdTaxon
        '
        Me.txtIdTaxon.Enabled = False
        Me.txtIdTaxon.Location = New System.Drawing.Point(69, 27)
        Me.txtIdTaxon.Name = "txtIdTaxon"
        Me.txtIdTaxon.Size = New System.Drawing.Size(125, 18)
        Me.txtIdTaxon.TabIndex = 10
        Me.txtIdTaxon.TabStop = False
        Me.txtIdTaxon.Tag = Nothing
        '
        'fototaxon
        '
        Me.fototaxon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fototaxon.ErrorImage = Global.Scila7.My.Resources.Resources.logoKerku
        Me.fototaxon.Location = New System.Drawing.Point(10, 134)
        Me.fototaxon.Name = "fototaxon"
        Me.fototaxon.Size = New System.Drawing.Size(231, 255)
        Me.fototaxon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fototaxon.TabIndex = 9
        Me.fototaxon.TabStop = False
        '
        'MuestrasBindingNavigator
        '
        Me.MuestrasBindingNavigator.AddNewItem = Nothing
        Me.MuestrasBindingNavigator.AutoSize = False
        Me.MuestrasBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.MuestrasBindingNavigator.BindingSource = Me.MuestrasBindingSource
        Me.MuestrasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MuestrasBindingNavigator.CountItemFormat = "de {0}"
        Me.MuestrasBindingNavigator.DeleteItem = Nothing
        Me.MuestrasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MuestrasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.MuestrasBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.MuestrasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MuestrasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MuestrasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MuestrasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MuestrasBindingNavigator.Name = "MuestrasBindingNavigator"
        Me.MuestrasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MuestrasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MuestrasBindingNavigator.Size = New System.Drawing.Size(914, 30)
        Me.MuestrasBindingNavigator.TabIndex = 176
        Me.MuestrasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 27)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
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
        Me.IdMuestraTextBox.Location = New System.Drawing.Point(375, 30)
        Me.IdMuestraTextBox.Name = "IdMuestraTextBox"
        Me.IdMuestraTextBox.Size = New System.Drawing.Size(31, 13)
        Me.IdMuestraTextBox.TabIndex = 177
        '
        'lblMuestraNombre
        '
        Me.lblMuestraNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMuestraNombre.AutoSize = True
        Me.lblMuestraNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.lblMuestraNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Nombre", True))
        Me.lblMuestraNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuestraNombre.ForeColor = System.Drawing.Color.White
        Me.lblMuestraNombre.Location = New System.Drawing.Point(449, 30)
        Me.lblMuestraNombre.Name = "lblMuestraNombre"
        Me.lblMuestraNombre.Size = New System.Drawing.Size(48, 18)
        Me.lblMuestraNombre.TabIndex = 178
        Me.lblMuestraNombre.Text = "Label2"
        '
        'txtHelp
        '
        Me.txtHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHelp.ForeColor = System.Drawing.Color.Gray
        Me.txtHelp.Location = New System.Drawing.Point(647, 444)
        Me.txtHelp.Multiline = True
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.Size = New System.Drawing.Size(256, 58)
        Me.txtHelp.TabIndex = 179
        Me.txtHelp.Text = "Los taxones en GRIS son agregados automáticamente para que las categorías taxonóm" & _
    "icas superiores al taxón seleccionado no queden vacías y puedan ser utilizadas p" & _
    "ara los diversos cálculos de índices." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnEditarListaTaxones
        '
        Me.btnEditarListaTaxones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarListaTaxones.BackColor = System.Drawing.Color.White
        Me.btnEditarListaTaxones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnEditarListaTaxones.FlatAppearance.BorderSize = 2
        Me.btnEditarListaTaxones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarListaTaxones.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarListaTaxones.Location = New System.Drawing.Point(394, 569)
        Me.btnEditarListaTaxones.Name = "btnEditarListaTaxones"
        Me.btnEditarListaTaxones.Size = New System.Drawing.Size(243, 35)
        Me.btnEditarListaTaxones.TabIndex = 180
        Me.btnEditarListaTaxones.Text = "Editar lista de taxones"
        Me.btnEditarListaTaxones.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarDatosToolStripMenuItem, Me.EnciclopediaToolStripMenuItem1, Me.SalirAWindowsToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 24)
        Me.MenuStrip1.TabIndex = 181
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImportarDatosToolStripMenuItem
        '
        Me.ImportarDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarToolStripMenuItem})
        Me.ImportarDatosToolStripMenuItem.Name = "ImportarDatosToolStripMenuItem"
        Me.ImportarDatosToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ImportarDatosToolStripMenuItem.Text = "Importar Datos"
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportarToolStripMenuItem.Text = "Importar datos"
        '
        'EnciclopediaToolStripMenuItem1
        '
        Me.EnciclopediaToolStripMenuItem1.Name = "EnciclopediaToolStripMenuItem1"
        Me.EnciclopediaToolStripMenuItem1.Size = New System.Drawing.Size(86, 20)
        Me.EnciclopediaToolStripMenuItem1.Text = "Enciclopedia"
        '
        'SalirAWindowsToolStripMenuItem1
        '
        Me.SalirAWindowsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarVentanaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SalirAWindowsToolStripMenuItem1.Name = "SalirAWindowsToolStripMenuItem1"
        Me.SalirAWindowsToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.SalirAWindowsToolStripMenuItem1.Text = "Salir"
        '
        'CerrarVentanaToolStripMenuItem
        '
        Me.CerrarVentanaToolStripMenuItem.Name = "CerrarVentanaToolStripMenuItem"
        Me.CerrarVentanaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CerrarVentanaToolStripMenuItem.Text = "Cerrar ventana"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SalirToolStripMenuItem.Text = "Salir a Windows"
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
        Me.btnAgregar.Image = Global.Scila7.My.Resources.Resources.next21
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(394, 70)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(247, 92)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar a la muestra"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'frmDatosTaxones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(914, 616)
        Me.Controls.Add(Me.btnEditarListaTaxones)
        Me.Controls.Add(Me.txtHelp)
        Me.Controls.Add(Me.lblMuestraNombre)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchAcronimo)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.TaxonesDataGridView)
        Me.Controls.Add(Me.txtCantidadAgregar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.TaxonesPresentes)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.IdMuestraTextBox)
        Me.Name = "frmDatosTaxones"
        Me.Text = "Taxones"
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesPresentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxonesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.txtCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdTaxon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fototaxon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MuestrasBindingNavigator.ResumeLayout(False)
        Me.MuestrasBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents TaxonesPresentes As System.Windows.Forms.DataGridView
    Friend WithEvents IdTaxon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Taxón As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As C1.Win.C1Input.C1Button
    Friend WithEvents txtCantidadAgregar As System.Windows.Forms.TextBox
    Friend WithEvents TaxonesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NivelPadre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchAcronimo As System.Windows.Forms.TextBox
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents fototaxon As C1.Win.C1Input.C1PictureBox
    Friend WithEvents txtCategoria As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtAutor As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNombre As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtIdTaxon As C1.Win.C1Input.C1TextBox
    Friend WithEvents MuestrasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IdMuestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblMuestraNombre As System.Windows.Forms.Label
    Friend WithEvents txtHelp As System.Windows.Forms.TextBox
    Friend WithEvents btnEditarListaTaxones As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImportarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnciclopediaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarVentanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
