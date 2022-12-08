<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHabitatOld
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHabitatOld))
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirAWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnciclopediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet
        Me.ConfigTableAdapter = New Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
        Me.SitiosMuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sitio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Autor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnEliminarFQ = New System.Windows.Forms.Button
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.lblNombreMuestra = New System.Windows.Forms.Label
        Me.IdMuestraTextBox = New System.Windows.Forms.TextBox
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel
        Me.grpContenido = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Habitatdatagridview2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ParametrosHabitatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitatDataSet = New Scila7.habitatDataSet
        Me.Habitatdatagridview1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Habitatdatagridview = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnGuardarFQ = New System.Windows.Forms.Button
        Me.FQId = New System.Windows.Forms.TextBox
        Me.FQIdMuestra = New System.Windows.Forms.TextBox
        Me.FQIdProyecto = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnciclopediaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirAWindowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulosTableAdapter = New Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder
        Me.Salir = New C1.Win.C1Command.C1Command
        Me.c1Command1 = New C1.Win.C1Command.C1Command
        Me.C1CommandMenu1 = New C1.Win.C1Command.C1CommandMenu
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink
        Me.Archivo = New C1.Win.C1Command.C1CommandMenu
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink
        Me.Guardar = New C1.Win.C1Command.C1Command
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink
        Me.Nuevamuestra = New C1.Win.C1Command.C1Command
        Me.MenuMuestras = New C1.Win.C1Command.C1CommandMenu
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink
        Me.C1CommandLink7 = New C1.Win.C1Command.C1CommandLink
        Me.EliminarMuestra = New C1.Win.C1Command.C1Command
        Me.MenuProtocolos = New C1.Win.C1Command.C1CommandMenu
        Me.C1CommandLink9 = New C1.Win.C1Command.C1CommandLink
        Me.MenuIndices = New C1.Win.C1Command.C1CommandMenu
        Me.C1CommandLink11 = New C1.Win.C1Command.C1CommandLink
        Me.C1OutPage2 = New C1.Win.C1Command.C1OutPage
        Me.C1OutPage3 = New C1.Win.C1Command.C1OutPage
        Me.C1OutPage4 = New C1.Win.C1Command.C1OutPage
        Me.ParametrosHabitatTableAdapter = New Scila7.habitatDataSetTableAdapters.ParametrosHabitatTableAdapter
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitiosMuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.C1SplitterPanel2.SuspendLayout()
        Me.grpContenido.SuspendLayout()
        CType(Me.Habitatdatagridview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosHabitatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Habitatdatagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Habitatdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirAWindowsToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirAWindowsToolStripMenuItem
        '
        Me.SalirAWindowsToolStripMenuItem.Name = "SalirAWindowsToolStripMenuItem"
        Me.SalirAWindowsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SalirAWindowsToolStripMenuItem.Text = "Salir a Windows"
        '
        'EnciclopediaToolStripMenuItem
        '
        Me.EnciclopediaToolStripMenuItem.Name = "EnciclopediaToolStripMenuItem"
        Me.EnciclopediaToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.EnciclopediaToolStripMenuItem.Text = "Enciclopedia"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.ConfigDataSet
        '
        'ConfigDataSet
        '
        Me.ConfigDataSet.DataSetName = "ConfigDataSet"
        Me.ConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.White
        Me.C1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.C1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.C1SplitContainer1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1SplitContainer1.LineBelowHeader = False
        Me.C1SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel2)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(792, 646)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.C1SplitContainer1.SplitterWidth = 2
        Me.C1SplitContainer1.TabIndex = 134
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Vista
        Me.C1SplitContainer1.UseParentVisualStyle = False
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.BackColor = System.Drawing.Color.White
        Me.C1SplitterPanel1.Controls.Add(Me.MuestrasDataGridView)
        Me.C1SplitterPanel1.Controls.Add(Me.btnEliminarFQ)
        Me.C1SplitterPanel1.Controls.Add(Me.BindingNavigator1)
        Me.C1SplitterPanel1.Controls.Add(Me.lblNombreMuestra)
        Me.C1SplitterPanel1.Controls.Add(Me.IdMuestraTextBox)
        Me.C1SplitterPanel1.Height = 97
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Resizable = False
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(792, 97)
        Me.C1SplitterPanel1.SizeRatio = 15
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Width = 100
        '
        'MuestrasDataGridView
        '
        Me.MuestrasDataGridView.AllowUserToAddRows = False
        Me.MuestrasDataGridView.AllowUserToDeleteRows = False
        Me.MuestrasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MuestrasDataGridView.AutoGenerateColumns = False
        Me.MuestrasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MuestrasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.DataGridViewTextBoxColumn2, Me.Nombre, Me.Fecha, Me.Sitio, Me.Autor, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MuestrasDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.MuestrasDataGridView.GridColor = System.Drawing.Color.LightGray
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(192, 33)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.ReadOnly = True
        Me.MuestrasDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight
        Me.MuestrasDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MuestrasDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(284, 59)
        Me.MuestrasDataGridView.TabIndex = 69
        Me.MuestrasDataGridView.Visible = False
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Id.DataPropertyName = "IdMuestra"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 41
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdProyecto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdProyecto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 62
        '
        'Sitio
        '
        Me.Sitio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Sitio.DataPropertyName = "CodigoSitio"
        Me.Sitio.HeaderText = "Sitio"
        Me.Sitio.Name = "Sitio"
        Me.Sitio.ReadOnly = True
        Me.Sitio.Visible = False
        '
        'Autor
        '
        Me.Autor.DataPropertyName = "Autor"
        Me.Autor.HeaderText = "Autor"
        Me.Autor.Name = "Autor"
        Me.Autor.ReadOnly = True
        Me.Autor.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FQpH"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FQpH"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FQTemp"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FQTemp"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FQCond"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FQCond"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FQTurb"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FQTurb"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FQCaudal"
        Me.DataGridViewTextBoxColumn11.HeaderText = "FQCaudal"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FQOD"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FQOD"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FQNitratos"
        Me.DataGridViewTextBoxColumn13.HeaderText = "FQNitratos"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FQNitritos"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FQNitritos"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "FQAmonio"
        Me.DataGridViewTextBoxColumn15.HeaderText = "FQAmonio"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FQFosfato"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FQFosfato"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ClorofilaA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ClorofilaA"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn18.HeaderText = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CianoDensidad"
        Me.DataGridViewTextBoxColumn19.HeaderText = "CianoDensidad"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn20.HeaderText = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Ecoli"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Ecoli"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Olor"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Olor"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Conectividad"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Conectividad"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Naturalidad"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Naturalidad"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "AbuBasura"
        Me.DataGridViewTextBoxColumn25.HeaderText = "AbuBasura"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "DivBasura"
        Me.DataGridViewTextBoxColumn26.HeaderText = "DivBasura"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "IDP"
        Me.DataGridViewTextBoxColumn27.HeaderText = "IDP"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "IMRP"
        Me.DataGridViewTextBoxColumn28.HeaderText = "IMRP"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "IMRPlata"
        Me.DataGridViewTextBoxColumn29.HeaderText = "IMRPlata"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "FQBOD"
        Me.DataGridViewTextBoxColumn31.HeaderText = "FQBOD"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'btnEliminarFQ
        '
        Me.btnEliminarFQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarFQ.FlatAppearance.BorderSize = 0
        Me.btnEliminarFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarFQ.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarFQ.Image = Global.Scila7.My.Resources.Resources.Cancel1
        Me.btnEliminarFQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarFQ.Location = New System.Drawing.Point(544, 49)
        Me.btnEliminarFQ.Name = "btnEliminarFQ"
        Me.btnEliminarFQ.Size = New System.Drawing.Size(237, 31)
        Me.btnEliminarFQ.TabIndex = 164
        Me.btnEliminarFQ.Text = "Borrar datos del hábitat"
        Me.btnEliminarFQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarFQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminarFQ.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.MuestrasBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.CountItemFormat = "de {0} muestras"
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.BindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(792, 25)
        Me.BindingNavigator1.TabIndex = 180
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(88, 22)
        Me.BindingNavigatorCountItem.Text = "de {0} muestras"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero total de muestras"
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
        'lblNombreMuestra
        '
        Me.lblNombreMuestra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Nombre", True))
        Me.lblNombreMuestra.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMuestra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.lblNombreMuestra.Location = New System.Drawing.Point(12, 43)
        Me.lblNombreMuestra.Name = "lblNombreMuestra"
        Me.lblNombreMuestra.Size = New System.Drawing.Size(121, 39)
        Me.lblNombreMuestra.TabIndex = 179
        Me.lblNombreMuestra.Text = "Label1"
        '
        'IdMuestraTextBox
        '
        Me.IdMuestraTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IdMuestraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IdMuestra", True))
        Me.IdMuestraTextBox.Location = New System.Drawing.Point(738, 55)
        Me.IdMuestraTextBox.Name = "IdMuestraTextBox"
        Me.IdMuestraTextBox.Size = New System.Drawing.Size(24, 20)
        Me.IdMuestraTextBox.TabIndex = 120
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.Controls.Add(Me.grpContenido)
        Me.C1SplitterPanel2.Height = 200
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(0, 98)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(792, 548)
        Me.C1SplitterPanel2.TabIndex = 1
        '
        'grpContenido
        '
        Me.grpContenido.Controls.Add(Me.Label2)
        Me.grpContenido.Controls.Add(Me.Label1)
        Me.grpContenido.Controls.Add(Me.Habitatdatagridview2)
        Me.grpContenido.Controls.Add(Me.Habitatdatagridview1)
        Me.grpContenido.Controls.Add(Me.Habitatdatagridview)
        Me.grpContenido.Controls.Add(Me.Label3)
        Me.grpContenido.Controls.Add(Me.btnGuardarFQ)
        Me.grpContenido.Controls.Add(Me.FQId)
        Me.grpContenido.Controls.Add(Me.FQIdMuestra)
        Me.grpContenido.Controls.Add(Me.FQIdProyecto)
        Me.grpContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpContenido.Location = New System.Drawing.Point(0, 0)
        Me.grpContenido.Name = "grpContenido"
        Me.grpContenido.Size = New System.Drawing.Size(792, 548)
        Me.grpContenido.TabIndex = 166
        Me.grpContenido.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(473, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 26)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Otros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(475, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 26)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Canal Fluvial"
        '
        'Habitatdatagridview2
        '
        Me.Habitatdatagridview2.AllowAddNew = True
        Me.Habitatdatagridview2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Habitatdatagridview2.CaptionHeight = 20
        Me.Habitatdatagridview2.DataSource = Me.ParametrosHabitatBindingSource
        Me.Habitatdatagridview2.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Form
        Me.Habitatdatagridview2.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.Habitatdatagridview2.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Habitatdatagridview2.GroupByCaption = "Drag a column header here to group by that column"
        Me.Habitatdatagridview2.Images.Add(CType(resources.GetObject("Habitatdatagridview2.Images"), System.Drawing.Image))
        Me.Habitatdatagridview2.Location = New System.Drawing.Point(473, 51)
        Me.Habitatdatagridview2.Name = "Habitatdatagridview2"
        Me.Habitatdatagridview2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.Habitatdatagridview2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.Habitatdatagridview2.PreviewInfo.ZoomFactor = 75
        Me.Habitatdatagridview2.PrintInfo.PageSettings = CType(resources.GetObject("Habitatdatagridview2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.Habitatdatagridview2.RecordSelectors = False
        Me.Habitatdatagridview2.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.Habitatdatagridview2.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.None
        Me.Habitatdatagridview2.RowHeight = 20
        Me.Habitatdatagridview2.Size = New System.Drawing.Size(289, 229)
        Me.Habitatdatagridview2.TabIndex = 166
        Me.Habitatdatagridview2.Text = "C1TrueDBGrid1"
        Me.Habitatdatagridview2.ViewCaptionWidth = 200
        Me.Habitatdatagridview2.PropBag = resources.GetString("Habitatdatagridview2.PropBag")
        '
        'ParametrosHabitatBindingSource
        '
        Me.ParametrosHabitatBindingSource.DataMember = "ParametrosHabitat"
        Me.ParametrosHabitatBindingSource.DataSource = Me.HabitatDataSet
        '
        'HabitatDataSet
        '
        Me.HabitatDataSet.DataSetName = "habitatDataSet"
        Me.HabitatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Habitatdatagridview1
        '
        Me.Habitatdatagridview1.AllowAddNew = True
        Me.Habitatdatagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Habitatdatagridview1.CaptionHeight = 20
        Me.Habitatdatagridview1.DataSource = Me.ParametrosHabitatBindingSource
        Me.Habitatdatagridview1.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Form
        Me.Habitatdatagridview1.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.Habitatdatagridview1.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Habitatdatagridview1.GroupByCaption = "Drag a column header here to group by that column"
        Me.Habitatdatagridview1.Images.Add(CType(resources.GetObject("Habitatdatagridview1.Images"), System.Drawing.Image))
        Me.Habitatdatagridview1.Location = New System.Drawing.Point(473, 316)
        Me.Habitatdatagridview1.Name = "Habitatdatagridview1"
        Me.Habitatdatagridview1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.Habitatdatagridview1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.Habitatdatagridview1.PreviewInfo.ZoomFactor = 75
        Me.Habitatdatagridview1.PrintInfo.PageSettings = CType(resources.GetObject("Habitatdatagridview1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.Habitatdatagridview1.RecordSelectors = False
        Me.Habitatdatagridview1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.Habitatdatagridview1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.None
        Me.Habitatdatagridview1.RowHeight = 20
        Me.Habitatdatagridview1.Size = New System.Drawing.Size(289, 103)
        Me.Habitatdatagridview1.TabIndex = 165
        Me.Habitatdatagridview1.Text = "C1TrueDBGrid1"
        Me.Habitatdatagridview1.ViewCaptionWidth = 200
        Me.Habitatdatagridview1.PropBag = resources.GetString("Habitatdatagridview1.PropBag")
        '
        'Habitatdatagridview
        '
        Me.Habitatdatagridview.AllowAddNew = True
        Me.Habitatdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Habitatdatagridview.CaptionHeight = 20
        Me.Habitatdatagridview.DataSource = Me.ParametrosHabitatBindingSource
        Me.Habitatdatagridview.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Form
        Me.Habitatdatagridview.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.Habitatdatagridview.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Habitatdatagridview.GroupByCaption = "Drag a column header here to group by that column"
        Me.Habitatdatagridview.Images.Add(CType(resources.GetObject("Habitatdatagridview.Images"), System.Drawing.Image))
        Me.Habitatdatagridview.Location = New System.Drawing.Point(12, 51)
        Me.Habitatdatagridview.Name = "Habitatdatagridview"
        Me.Habitatdatagridview.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.Habitatdatagridview.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.Habitatdatagridview.PreviewInfo.ZoomFactor = 75
        Me.Habitatdatagridview.PrintInfo.PageSettings = CType(resources.GetObject("Habitatdatagridview.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.Habitatdatagridview.RecordSelectors = False
        Me.Habitatdatagridview.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.Habitatdatagridview.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.None
        Me.Habitatdatagridview.RowHeight = 20
        Me.Habitatdatagridview.Size = New System.Drawing.Size(435, 412)
        Me.Habitatdatagridview.TabIndex = 164
        Me.Habitatdatagridview.Text = "C1TrueDBGrid1"
        Me.Habitatdatagridview.ViewCaptionWidth = 300
        Me.Habitatdatagridview.PropBag = resources.GetString("Habitatdatagridview.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 26)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Vegetación de ribera"
        '
        'btnGuardarFQ
        '
        Me.btnGuardarFQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarFQ.FlatAppearance.BorderSize = 0
        Me.btnGuardarFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarFQ.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarFQ.Image = Global.Scila7.My.Resources.Resources.Save
        Me.btnGuardarFQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarFQ.Location = New System.Drawing.Point(522, 480)
        Me.btnGuardarFQ.Name = "btnGuardarFQ"
        Me.btnGuardarFQ.Size = New System.Drawing.Size(258, 56)
        Me.btnGuardarFQ.TabIndex = 156
        Me.btnGuardarFQ.Text = "Guardar datos del hábitat"
        Me.btnGuardarFQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarFQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarFQ.UseVisualStyleBackColor = True
        '
        'FQId
        '
        Me.FQId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FQId.Location = New System.Drawing.Point(578, 500)
        Me.FQId.Name = "FQId"
        Me.FQId.Size = New System.Drawing.Size(26, 20)
        Me.FQId.TabIndex = 113
        '
        'FQIdMuestra
        '
        Me.FQIdMuestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FQIdMuestra.Location = New System.Drawing.Point(555, 500)
        Me.FQIdMuestra.Name = "FQIdMuestra"
        Me.FQIdMuestra.Size = New System.Drawing.Size(26, 20)
        Me.FQIdMuestra.TabIndex = 115
        '
        'FQIdProyecto
        '
        Me.FQIdProyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FQIdProyecto.Location = New System.Drawing.Point(624, 500)
        Me.FQIdProyecto.Name = "FQIdProyecto"
        Me.FQIdProyecto.Size = New System.Drawing.Size(26, 20)
        Me.FQIdProyecto.TabIndex = 117
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProyectoToolStripMenuItem, Me.EnciclopediaToolStripMenuItem1, Me.SalirAWindowsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 117
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProyectoToolStripMenuItem
        '
        Me.ProyectoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarProyectoToolStripMenuItem})
        Me.ProyectoToolStripMenuItem.Name = "ProyectoToolStripMenuItem"
        Me.ProyectoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProyectoToolStripMenuItem.Text = "Proyecto"
        '
        'CambiarProyectoToolStripMenuItem
        '
        Me.CambiarProyectoToolStripMenuItem.Name = "CambiarProyectoToolStripMenuItem"
        Me.CambiarProyectoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CambiarProyectoToolStripMenuItem.Text = "Cambiar proyecto..."
        '
        'EnciclopediaToolStripMenuItem1
        '
        Me.EnciclopediaToolStripMenuItem1.Name = "EnciclopediaToolStripMenuItem1"
        Me.EnciclopediaToolStripMenuItem1.Size = New System.Drawing.Size(86, 20)
        Me.EnciclopediaToolStripMenuItem1.Text = "Enciclopedia"
        '
        'SalirAWindowsToolStripMenuItem1
        '
        Me.SalirAWindowsToolStripMenuItem1.Name = "SalirAWindowsToolStripMenuItem1"
        Me.SalirAWindowsToolStripMenuItem1.Size = New System.Drawing.Size(102, 20)
        Me.SalirAWindowsToolStripMenuItem1.Text = "Salir a Windows"
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
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.Salir)
        Me.C1CommandHolder1.Commands.Add(Me.c1Command1)
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandMenu1)
        Me.C1CommandHolder1.Commands.Add(Me.Archivo)
        Me.C1CommandHolder1.Commands.Add(Me.Guardar)
        Me.C1CommandHolder1.Commands.Add(Me.Nuevamuestra)
        Me.C1CommandHolder1.Commands.Add(Me.MenuMuestras)
        Me.C1CommandHolder1.Commands.Add(Me.EliminarMuestra)
        Me.C1CommandHolder1.Commands.Add(Me.MenuProtocolos)
        Me.C1CommandHolder1.Commands.Add(Me.MenuIndices)
        Me.C1CommandHolder1.Owner = Me
        '
        'Salir
        '
        Me.Salir.Name = "Salir"
        Me.Salir.ShortcutText = ""
        Me.Salir.Text = "Salir"
        '
        'c1Command1
        '
        Me.c1Command1.Name = "c1Command1"
        Me.c1Command1.ShortcutText = ""
        Me.c1Command1.Text = "E&xit"
        '
        'C1CommandMenu1
        '
        Me.C1CommandMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink3})
        Me.C1CommandMenu1.HideNonRecentLinks = False
        Me.C1CommandMenu1.Name = "C1CommandMenu1"
        Me.C1CommandMenu1.ShortcutText = ""
        Me.C1CommandMenu1.Text = "New Command"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.Text = "New Command"
        '
        'Archivo
        '
        Me.Archivo.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink5, Me.C1CommandLink6})
        Me.Archivo.HideNonRecentLinks = False
        Me.Archivo.Name = "Archivo"
        Me.Archivo.ShortcutText = ""
        Me.Archivo.Text = "&Archivo"
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.Command = Me.Guardar
        '
        'Guardar
        '
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.ShortcutText = ""
        Me.Guardar.Text = "&Guardar"
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.Command = Me.Salir
        Me.C1CommandLink6.SortOrder = 1
        '
        'Nuevamuestra
        '
        Me.Nuevamuestra.Image = CType(resources.GetObject("Nuevamuestra.Image"), System.Drawing.Image)
        Me.Nuevamuestra.Name = "Nuevamuestra"
        Me.Nuevamuestra.ShortcutText = ""
        Me.Nuevamuestra.Text = "Nueva &Muestraclll"
        '
        'MenuMuestras
        '
        Me.MenuMuestras.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.C1CommandLink7})
        Me.MenuMuestras.HideNonRecentLinks = False
        Me.MenuMuestras.Name = "MenuMuestras"
        Me.MenuMuestras.ShortcutText = ""
        Me.MenuMuestras.Text = "&Muestras"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.Nuevamuestra
        '
        'C1CommandLink7
        '
        Me.C1CommandLink7.Command = Me.EliminarMuestra
        Me.C1CommandLink7.SortOrder = 1
        '
        'EliminarMuestra
        '
        Me.EliminarMuestra.Image = CType(resources.GetObject("EliminarMuestra.Image"), System.Drawing.Image)
        Me.EliminarMuestra.Name = "EliminarMuestra"
        Me.EliminarMuestra.ShortcutText = ""
        Me.EliminarMuestra.Text = "&Eliminar Muestra"
        '
        'MenuProtocolos
        '
        Me.MenuProtocolos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink9})
        Me.MenuProtocolos.HideNonRecentLinks = False
        Me.MenuProtocolos.Name = "MenuProtocolos"
        Me.MenuProtocolos.ShortcutText = ""
        Me.MenuProtocolos.Text = "&Protocolos"
        '
        'C1CommandLink9
        '
        Me.C1CommandLink9.Text = "New Command"
        '
        'MenuIndices
        '
        Me.MenuIndices.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink11})
        Me.MenuIndices.HideNonRecentLinks = False
        Me.MenuIndices.Name = "MenuIndices"
        Me.MenuIndices.ShortcutText = ""
        Me.MenuIndices.Text = "&Indices"
        '
        'C1CommandLink11
        '
        Me.C1CommandLink11.Text = "New Command"
        '
        'C1OutPage2
        '
        Me.C1OutPage2.Name = "C1OutPage2"
        Me.C1OutPage2.Size = New System.Drawing.Size(200, 100)
        Me.C1OutPage2.Text = "Físico-químicos"
        '
        'C1OutPage3
        '
        Me.C1OutPage3.Name = "C1OutPage3"
        Me.C1OutPage3.Size = New System.Drawing.Size(200, 100)
        Me.C1OutPage3.Text = "Biológicos"
        '
        'C1OutPage4
        '
        Me.C1OutPage4.Name = "C1OutPage4"
        Me.C1OutPage4.Size = New System.Drawing.Size(200, 100)
        Me.C1OutPage4.Text = "Hábitat"
        '
        'ParametrosHabitatTableAdapter
        '
        Me.ParametrosHabitatTableAdapter.ClearBeforeFill = True
        '
        'frmHabitat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(792, 670)
        Me.Controls.Add(Me.C1SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHabitat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HÁBITAT"
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitiosMuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel1.PerformLayout()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.C1SplitterPanel2.ResumeLayout(False)
        Me.grpContenido.ResumeLayout(False)
        Me.grpContenido.PerformLayout()
        CType(Me.Habitatdatagridview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosHabitatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Habitatdatagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Habitatdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents Salir As C1.Win.C1Command.C1Command
    Friend WithEvents c1Command1 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandMenu1 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Archivo As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents Nuevamuestra As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Guardar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents MenuMuestras As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink7 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents EliminarMuestra As C1.Win.C1Command.C1Command
    Friend WithEvents MenuProtocolos As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink9 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents MenuIndices As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink11 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1OutPage2 As C1.Win.C1Command.C1OutPage
    Friend WithEvents C1OutPage3 As C1.Win.C1Command.C1OutPage
    Friend WithEvents C1OutPage4 As C1.Win.C1Command.C1OutPage
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnciclopediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents SitiosMuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnciclopediaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModulosTableAdapter As Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents btnGuardarFQ As System.Windows.Forms.Button
    Friend WithEvents FQId As System.Windows.Forms.TextBox
    Friend WithEvents FQIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents FQIdMuestra As System.Windows.Forms.TextBox
    Friend WithEvents IdMuestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreMuestra As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEliminarFQ As System.Windows.Forms.Button
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sitio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Autor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HabitatDataSet As Scila7.habitatDataSet
    Friend WithEvents ParametrosHabitatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParametrosHabitatTableAdapter As Scila7.habitatDataSetTableAdapters.ParametrosHabitatTableAdapter
    Friend WithEvents Habitatdatagridview As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grpContenido As System.Windows.Forms.GroupBox
    Friend WithEvents Habitatdatagridview2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Habitatdatagridview1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
