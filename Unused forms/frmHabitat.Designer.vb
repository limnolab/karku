<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHabitat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHabitat))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.ParametrosHabitatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitatDataSet = New Scila7.habitatDataSet()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirAWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnciclopediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.ConfigTableAdapter = New Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter()
        Me.ParametrosFQTableAdapter = New Scila7.fqDataSetTableAdapters.ParametrosFQTableAdapter()
        Me.SitiosMuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblNombreMuestra = New System.Windows.Forms.Label()
        Me.MuestrasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.MuestrasProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblMuestraenFQ = New System.Windows.Forms.Label()
        Me.btnEliminarDatos = New System.Windows.Forms.Button()
        Me.IdMuestraTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardarDatos = New System.Windows.Forms.Button()
        Me.FQId = New System.Windows.Forms.TextBox()
        Me.FQIdMuestra = New System.Windows.Forms.TextBox()
        Me.FQIdProyecto = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnciclopediaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirAWindowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulosTableAdapter = New Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.Salir = New C1.Win.C1Command.C1Command()
        Me.c1Command1 = New C1.Win.C1Command.C1Command()
        Me.C1CommandMenu1 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.Archivo = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.Guardar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.Nuevamuestra = New C1.Win.C1Command.C1Command()
        Me.MenuMuestras = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink7 = New C1.Win.C1Command.C1CommandLink()
        Me.EliminarMuestra = New C1.Win.C1Command.C1Command()
        Me.MenuProtocolos = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink9 = New C1.Win.C1Command.C1CommandLink()
        Me.MenuIndices = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink11 = New C1.Win.C1Command.C1CommandLink()
        Me.C1OutPage2 = New C1.Win.C1Command.C1OutPage()
        Me.C1OutPage3 = New C1.Win.C1Command.C1OutPage()
        Me.C1OutPage4 = New C1.Win.C1Command.C1OutPage()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sitio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView()
        Me.ParametrosHabitatTableAdapter = New Scila7.habitatDataSetTableAdapters.ParametrosHabitatTableAdapter()
        Me.Parametrosdatagridview = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DataSet1 = New System.Data.DataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosHabitatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitiosMuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Parametrosdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ParametrosFQTableAdapter
        '
        Me.ParametrosFQTableAdapter.ClearBeforeFill = True
        '
        'lblNombreMuestra
        '
        Me.lblNombreMuestra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Nombre", True))
        Me.lblNombreMuestra.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMuestra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.lblNombreMuestra.Location = New System.Drawing.Point(781, 29)
        Me.lblNombreMuestra.Name = "lblNombreMuestra"
        Me.lblNombreMuestra.Size = New System.Drawing.Size(121, 23)
        Me.lblNombreMuestra.TabIndex = 179
        Me.lblNombreMuestra.Text = "Label1"
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
        Me.MuestrasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.MuestrasProgressBar, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1})
        Me.MuestrasBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.MuestrasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MuestrasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MuestrasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MuestrasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MuestrasBindingNavigator.Name = "MuestrasBindingNavigator"
        Me.MuestrasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MuestrasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MuestrasBindingNavigator.Size = New System.Drawing.Size(1147, 30)
        Me.MuestrasBindingNavigator.TabIndex = 181
        Me.MuestrasBindingNavigator.Text = "MuestrasBindingNavigator"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorAddNewItem.Image = Global.Scila7.My.Resources.Resources.Plus1
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(107, 27)
        Me.BindingNavigatorAddNewItem.Text = "Nueva muestra"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorDeleteItem.Image = Global.Scila7.My.Resources.Resources.Cancel1
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(116, 27)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar Muestra"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 30)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(30, 16)
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
        'MuestrasProgressBar
        '
        Me.MuestrasProgressBar.AutoSize = False
        Me.MuestrasProgressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MuestrasProgressBar.Name = "MuestrasProgressBar"
        Me.MuestrasProgressBar.Size = New System.Drawing.Size(100, 15)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(58, 27)
        Me.ToolStripLabel1.Text = "Muestras:"
        '
        'lblMuestraenFQ
        '
        Me.lblMuestraenFQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblMuestraenFQ.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMuestraenFQ.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuestraenFQ.ForeColor = System.Drawing.Color.White
        Me.lblMuestraenFQ.Location = New System.Drawing.Point(0, 54)
        Me.lblMuestraenFQ.Name = "lblMuestraenFQ"
        Me.lblMuestraenFQ.Size = New System.Drawing.Size(1147, 28)
        Me.lblMuestraenFQ.TabIndex = 157
        Me.lblMuestraenFQ.Text = "lblMuestraenFQ"
        Me.lblMuestraenFQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEliminarDatos
        '
        Me.btnEliminarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarDatos.FlatAppearance.BorderSize = 0
        Me.btnEliminarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarDatos.Image = Global.Scila7.My.Resources.Resources.Cancel1
        Me.btnEliminarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarDatos.Location = New System.Drawing.Point(12, 707)
        Me.btnEliminarDatos.Name = "btnEliminarDatos"
        Me.btnEliminarDatos.Size = New System.Drawing.Size(306, 31)
        Me.btnEliminarDatos.TabIndex = 164
        Me.btnEliminarDatos.TabStop = False
        Me.btnEliminarDatos.Text = "Borrar datos del hábitat de esta muestra"
        Me.btnEliminarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminarDatos.UseVisualStyleBackColor = True
        '
        'IdMuestraTextBox
        '
        Me.IdMuestraTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IdMuestraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IdMuestra", True))
        Me.IdMuestraTextBox.Location = New System.Drawing.Point(19, 718)
        Me.IdMuestraTextBox.Name = "IdMuestraTextBox"
        Me.IdMuestraTextBox.Size = New System.Drawing.Size(24, 20)
        Me.IdMuestraTextBox.TabIndex = 120
        '
        'btnGuardarDatos
        '
        Me.btnGuardarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGuardarDatos.FlatAppearance.BorderSize = 0
        Me.btnGuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarDatos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarDatos.Image = Global.Scila7.My.Resources.Resources.Save
        Me.btnGuardarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarDatos.Location = New System.Drawing.Point(872, 676)
        Me.btnGuardarDatos.Name = "btnGuardarDatos"
        Me.btnGuardarDatos.Size = New System.Drawing.Size(258, 56)
        Me.btnGuardarDatos.TabIndex = 5
        Me.btnGuardarDatos.Text = "Guardar datos del hábitat"
        Me.btnGuardarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarDatos.UseVisualStyleBackColor = False
        '
        'FQId
        '
        Me.FQId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FQId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosHabitatBindingSource, "Id", True))
        Me.FQId.Location = New System.Drawing.Point(116, 718)
        Me.FQId.Name = "FQId"
        Me.FQId.Size = New System.Drawing.Size(26, 20)
        Me.FQId.TabIndex = 113
        '
        'FQIdMuestra
        '
        Me.FQIdMuestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FQIdMuestra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosHabitatBindingSource, "IdMuestra", True))
        Me.FQIdMuestra.Location = New System.Drawing.Point(93, 718)
        Me.FQIdMuestra.Name = "FQIdMuestra"
        Me.FQIdMuestra.Size = New System.Drawing.Size(26, 20)
        Me.FQIdMuestra.TabIndex = 115
        '
        'FQIdProyecto
        '
        Me.FQIdProyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FQIdProyecto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosHabitatBindingSource, "IdProyecto", True))
        Me.FQIdProyecto.Location = New System.Drawing.Point(162, 718)
        Me.FQIdProyecto.Name = "FQIdProyecto"
        Me.FQIdProyecto.Size = New System.Drawing.Size(26, 20)
        Me.FQIdProyecto.TabIndex = 117
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProyectoToolStripMenuItem, Me.EnciclopediaToolStripMenuItem1, Me.SalirAWindowsToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1147, 24)
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
        'NombreComboBox
        '
        Me.NombreComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Nombre", True))
        Me.NombreComboBox.DataSource = Me.MuestrasBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NombreComboBox.ForeColor = System.Drawing.Color.White
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(574, 55)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NombreComboBox.TabIndex = 182
        Me.NombreComboBox.ValueMember = "Nombre"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MuestrasBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(561, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 183
        Me.ComboBox1.TabStop = False
        Me.ComboBox1.ValueMember = "IdMuestra"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "FQBOD"
        Me.DataGridViewTextBoxColumn31.HeaderText = "FQBOD"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "IMRPlata"
        Me.DataGridViewTextBoxColumn29.HeaderText = "IMRPlata"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "IMRP"
        Me.DataGridViewTextBoxColumn28.HeaderText = "IMRP"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "IDP"
        Me.DataGridViewTextBoxColumn27.HeaderText = "IDP"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "DivBasura"
        Me.DataGridViewTextBoxColumn26.HeaderText = "DivBasura"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "AbuBasura"
        Me.DataGridViewTextBoxColumn25.HeaderText = "AbuBasura"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Naturalidad"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Naturalidad"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Conectividad"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Conectividad"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Olor"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Olor"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Ecoli"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Ecoli"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn20.HeaderText = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CianoDensidad"
        Me.DataGridViewTextBoxColumn19.HeaderText = "CianoDensidad"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn18.HeaderText = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ClorofilaA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ClorofilaA"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FQFosfato"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FQFosfato"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "FQAmonio"
        Me.DataGridViewTextBoxColumn15.HeaderText = "FQAmonio"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FQNitritos"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FQNitritos"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FQNitratos"
        Me.DataGridViewTextBoxColumn13.HeaderText = "FQNitratos"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FQOD"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FQOD"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FQCaudal"
        Me.DataGridViewTextBoxColumn11.HeaderText = "FQCaudal"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FQTurb"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FQTurb"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FQCond"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FQCond"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FQTemp"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FQTemp"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FQpH"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FQpH"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'Autor
        '
        Me.Autor.DataPropertyName = "Autor"
        Me.Autor.HeaderText = "Autor"
        Me.Autor.Name = "Autor"
        Me.Autor.ReadOnly = True
        Me.Autor.Visible = False
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
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 62
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'colIdProyecto
        '
        Me.colIdProyecto.DataPropertyName = "IdProyecto"
        Me.colIdProyecto.HeaderText = "IdProyecto"
        Me.colIdProyecto.Name = "colIdProyecto"
        Me.colIdProyecto.ReadOnly = True
        Me.colIdProyecto.Visible = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MuestrasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.colIdProyecto, Me.Nombre, Me.Fecha, Me.Sitio, Me.Autor, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MuestrasDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.MuestrasDataGridView.GridColor = System.Drawing.Color.LightGray
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(638, 687)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MuestrasDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MuestrasDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight
        Me.MuestrasDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MuestrasDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(350, 35)
        Me.MuestrasDataGridView.TabIndex = 3
        Me.MuestrasDataGridView.TabStop = False
        Me.MuestrasDataGridView.Visible = False
        '
        'ParametrosHabitatTableAdapter
        '
        Me.ParametrosHabitatTableAdapter.ClearBeforeFill = True
        '
        'Parametrosdatagridview
        '
        Me.Parametrosdatagridview.AllowAddNew = True
        Me.Parametrosdatagridview.AllowArrows = False
        Me.Parametrosdatagridview.AllowColMove = False
        Me.Parametrosdatagridview.AllowColSelect = False
        Me.Parametrosdatagridview.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.Parametrosdatagridview.BackColor = System.Drawing.SystemColors.Window
        Me.Parametrosdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Parametrosdatagridview.CaptionHeight = 17
        Me.Parametrosdatagridview.DataSource = Me.ParametrosHabitatBindingSource
        Me.Parametrosdatagridview.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Inverted
        Me.Parametrosdatagridview.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.Parametrosdatagridview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parametrosdatagridview.Images.Add(CType(resources.GetObject("Parametrosdatagridview.Images"), System.Drawing.Image))
        Me.Parametrosdatagridview.LinesPerRow = 4
        Me.Parametrosdatagridview.Location = New System.Drawing.Point(638, 567)
        Me.Parametrosdatagridview.Name = "Parametrosdatagridview"
        Me.Parametrosdatagridview.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.Parametrosdatagridview.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.Parametrosdatagridview.PreviewInfo.ZoomFactor = 75.0R
        Me.Parametrosdatagridview.PrintInfo.PageSettings = CType(resources.GetObject("Parametrosdatagridview.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.Parametrosdatagridview.RecordSelectors = False
        Me.Parametrosdatagridview.RowDivider.Color = System.Drawing.Color.White
        Me.Parametrosdatagridview.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.None
        Me.Parametrosdatagridview.RowHeight = 1
        Me.Parametrosdatagridview.RowSubDividerColor = System.Drawing.Color.White
        Me.Parametrosdatagridview.Size = New System.Drawing.Size(200, 100)
        Me.Parametrosdatagridview.TabIndex = 177
        Me.Parametrosdatagridview.Text = "C1TrueDBGrid1"
        Me.Parametrosdatagridview.ViewCaptionWidth = 200
        Me.Parametrosdatagridview.Visible = False
        Me.Parametrosdatagridview.PropBag = resources.GetString("Parametrosdatagridview.PropBag")
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.Images.Add(CType(resources.GetObject("DataGridView1.Images"), System.Drawing.Image))
        Me.DataGridView1.Location = New System.Drawing.Point(785, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DataGridView1.PreviewInfo.ZoomFactor = 75.0R
        Me.DataGridView1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 184
        Me.DataGridView1.PropBag = resources.GetString("DataGridView1.PropBag")
        '
        'frmHabitat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1147, 750)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnGuardarDatos)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblMuestraenFQ)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(Me.MuestrasDataGridView)
        Me.Controls.Add(Me.lblNombreMuestra)
        Me.Controls.Add(Me.btnEliminarDatos)
        Me.Controls.Add(Me.IdMuestraTextBox)
        Me.Controls.Add(Me.Parametrosdatagridview)
        Me.Controls.Add(Me.FQId)
        Me.Controls.Add(Me.FQIdMuestra)
        Me.Controls.Add(Me.FQIdProyecto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHabitat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HÁBITAT"
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosHabitatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitiosMuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MuestrasBindingNavigator.ResumeLayout(False)
        Me.MuestrasBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Parametrosdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnciclopediaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGuardarDatos As System.Windows.Forms.Button
    Friend WithEvents FQId As System.Windows.Forms.TextBox
    Friend WithEvents FQIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents FQIdMuestra As System.Windows.Forms.TextBox
    Friend WithEvents lblMuestraenFQ As System.Windows.Forms.Label
    Friend WithEvents IdMuestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarDatos As System.Windows.Forms.Button
    Private WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Private WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Private WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ParametrosHabitatBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ParametrosFQTableAdapter As Scila7.fqDataSetTableAdapters.ParametrosFQTableAdapter
    Private WithEvents SitiosMuestrasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ModulosBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ModulosTableAdapter As Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter
    Private WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Private WithEvents ConfigTableAdapter As Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents lblNombreMuestra As System.Windows.Forms.Label
    Friend WithEvents MuestrasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MuestrasProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdProyecto As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents ParametrosHabitatTableAdapter As Scila7.habitatDataSetTableAdapters.ParametrosHabitatTableAdapter
    Private WithEvents HabitatDataSet As Scila7.habitatDataSet
    Friend WithEvents Parametrosdatagridview As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
