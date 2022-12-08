<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosSimple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosSimple))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirAWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnciclopediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigTableAdapter = New Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter()
        Me.SitiosMuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblNombreMuestra = New System.Windows.Forms.Label()
        Me.MuestrasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.MuestrasProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblMuestraenDatos = New System.Windows.Forms.Label()
        Me.IdMuestraTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardarDatos = New System.Windows.Forms.Button()
        Me.FQId = New System.Windows.Forms.TextBox()
        Me.FQIdMuestra = New System.Windows.Forms.TextBox()
        Me.FQIdProyecto = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MuestrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEliminarDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnciclopediaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirAWindowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarVentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sitio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New System.Data.DataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DatosTableAdapter = New Scila7.habitatDataSetTableAdapters.ParametrosHabitatTableAdapter()
        Me.btnCargaAvanzada = New System.Windows.Forms.Button()
        Me.btnGuardarAvanzado = New System.Windows.Forms.Button()
        Me.dgvMuestras = New System.Windows.Forms.DataGridView()
        Me.btnAgregarAvanzado = New System.Windows.Forms.Button()
        Me.btnAbrirenExcel = New System.Windows.Forms.Button()
        Me.grpMuestras = New System.Windows.Forms.GroupBox()
        Me.btnCargaBasica = New System.Windows.Forms.Button()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitiosMuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMuestras.SuspendLayout()
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
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
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
        Me.MuestrasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.MuestrasProgressBar, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1})
        Me.MuestrasBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.MuestrasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MuestrasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MuestrasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MuestrasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MuestrasBindingNavigator.Name = "MuestrasBindingNavigator"
        Me.MuestrasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MuestrasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MuestrasBindingNavigator.Size = New System.Drawing.Size(972, 50)
        Me.MuestrasBindingNavigator.TabIndex = 181
        Me.MuestrasBindingNavigator.Text = "MuestrasBindingNavigator"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 47)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveFirstItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMoveFirstItem.Text = "|<"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMovePreviousItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 47)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMoveNextItem.Text = ">"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveLastItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 47)
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(58, 47)
        Me.ToolStripLabel1.Text = "Muestras:"
        '
        'lblMuestraenDatos
        '
        Me.lblMuestraenDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblMuestraenDatos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Nombre", True))
        Me.lblMuestraenDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMuestraenDatos.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuestraenDatos.ForeColor = System.Drawing.Color.White
        Me.lblMuestraenDatos.Location = New System.Drawing.Point(0, 74)
        Me.lblMuestraenDatos.Name = "lblMuestraenDatos"
        Me.lblMuestraenDatos.Size = New System.Drawing.Size(972, 28)
        Me.lblMuestraenDatos.TabIndex = 157
        Me.lblMuestraenDatos.Text = "lblMuestraenDatos"
        Me.lblMuestraenDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdMuestraTextBox
        '
        Me.IdMuestraTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdMuestraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IdMuestra", True))
        Me.IdMuestraTextBox.Location = New System.Drawing.Point(531, 38)
        Me.IdMuestraTextBox.Name = "IdMuestraTextBox"
        Me.IdMuestraTextBox.Size = New System.Drawing.Size(24, 20)
        Me.IdMuestraTextBox.TabIndex = 120
        '
        'btnGuardarDatos
        '
        Me.btnGuardarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGuardarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnGuardarDatos.FlatAppearance.BorderSize = 2
        Me.btnGuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarDatos.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.btnGuardarDatos.ForeColor = System.Drawing.Color.White
        Me.btnGuardarDatos.Image = Global.Scila7.My.Resources.Resources.save
        Me.btnGuardarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarDatos.Location = New System.Drawing.Point(660, 28)
        Me.btnGuardarDatos.Name = "btnGuardarDatos"
        Me.btnGuardarDatos.Size = New System.Drawing.Size(139, 40)
        Me.btnGuardarDatos.TabIndex = 5
        Me.btnGuardarDatos.Text = "  Guardar"
        Me.btnGuardarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarDatos.UseVisualStyleBackColor = False
        '
        'FQId
        '
        Me.FQId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FQId.Location = New System.Drawing.Point(628, 38)
        Me.FQId.Name = "FQId"
        Me.FQId.Size = New System.Drawing.Size(26, 20)
        Me.FQId.TabIndex = 113
        '
        'FQIdMuestra
        '
        Me.FQIdMuestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FQIdMuestra.Location = New System.Drawing.Point(605, 38)
        Me.FQIdMuestra.Name = "FQIdMuestra"
        Me.FQIdMuestra.Size = New System.Drawing.Size(26, 20)
        Me.FQIdMuestra.TabIndex = 115
        '
        'FQIdProyecto
        '
        Me.FQIdProyecto.Location = New System.Drawing.Point(674, 38)
        Me.FQIdProyecto.Name = "FQIdProyecto"
        Me.FQIdProyecto.Size = New System.Drawing.Size(26, 20)
        Me.FQIdProyecto.TabIndex = 117
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MuestrasToolStripMenuItem, Me.DatosToolStripMenuItem, Me.ImportarDatosToolStripMenuItem, Me.EnciclopediaToolStripMenuItem1, Me.SalirAWindowsToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(972, 24)
        Me.MenuStrip1.TabIndex = 117
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MuestrasToolStripMenuItem
        '
        Me.MuestrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EliminarActualToolStripMenuItem})
        Me.MuestrasToolStripMenuItem.Name = "MuestrasToolStripMenuItem"
        Me.MuestrasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.MuestrasToolStripMenuItem.Text = "Muestras"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar..."
        '
        'EliminarActualToolStripMenuItem
        '
        Me.EliminarActualToolStripMenuItem.Name = "EliminarActualToolStripMenuItem"
        Me.EliminarActualToolStripMenuItem.ShowShortcutKeys = False
        Me.EliminarActualToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EliminarActualToolStripMenuItem.Text = "Eliminar actual"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEliminarDatos})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'btnEliminarDatos
        '
        Me.btnEliminarDatos.Name = "btnEliminarDatos"
        Me.btnEliminarDatos.Size = New System.Drawing.Size(258, 22)
        Me.btnEliminarDatos.Text = "Borrar datos sólo de esta muestra..."
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
        Me.NombreComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.ComboBox1.Location = New System.Drawing.Point(334, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 183
        Me.ComboBox1.TabStop = False
        Me.ComboBox1.ValueMember = "IdMuestra"
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
        Me.MuestrasDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.colIdProyecto, Me.Nombre, Me.Fecha, Me.Sitio, Me.Autor})
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
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(548, 31)
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
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(106, 34)
        Me.MuestrasDataGridView.TabIndex = 3
        Me.MuestrasDataGridView.TabStop = False
        Me.MuestrasDataGridView.Visible = False
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
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.CaptionHeight = 17
        Me.DataGridView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.Images.Add(CType(resources.GetObject("DataGridView1.Images"), System.Drawing.Image))
        Me.DataGridView1.Location = New System.Drawing.Point(556, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DataGridView1.PreviewInfo.ZoomFactor = 75.0R
        Me.DataGridView1.PrintInfo.PageSettings = CType(resources.GetObject("DataGridView1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DataGridView1.RowHeight = 30
        Me.DataGridView1.Size = New System.Drawing.Size(75, 40)
        Me.DataGridView1.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation
        Me.DataGridView1.TabIndex = 184
        Me.DataGridView1.Visible = False
        Me.DataGridView1.PropBag = resources.GetString("DataGridView1.PropBag")
        '
        'DatosTableAdapter
        '
        Me.DatosTableAdapter.ClearBeforeFill = True
        '
        'btnCargaAvanzada
        '
        Me.btnCargaAvanzada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargaAvanzada.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnCargaAvanzada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCargaAvanzada.FlatAppearance.BorderSize = 2
        Me.btnCargaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargaAvanzada.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaAvanzada.ForeColor = System.Drawing.Color.White
        Me.btnCargaAvanzada.Image = Global.Scila7.My.Resources.Resources.show7
        Me.btnCargaAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargaAvanzada.Location = New System.Drawing.Point(801, 28)
        Me.btnCargaAvanzada.Name = "btnCargaAvanzada"
        Me.btnCargaAvanzada.Size = New System.Drawing.Size(162, 40)
        Me.btnCargaAvanzada.TabIndex = 185
        Me.btnCargaAvanzada.Text = "Carga avanzada..."
        Me.btnCargaAvanzada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargaAvanzada.UseVisualStyleBackColor = False
        '
        'btnGuardarAvanzado
        '
        Me.btnGuardarAvanzado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarAvanzado.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGuardarAvanzado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnGuardarAvanzado.FlatAppearance.BorderSize = 2
        Me.btnGuardarAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarAvanzado.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarAvanzado.ForeColor = System.Drawing.Color.White
        Me.btnGuardarAvanzado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarAvanzado.Location = New System.Drawing.Point(660, 28)
        Me.btnGuardarAvanzado.Name = "btnGuardarAvanzado"
        Me.btnGuardarAvanzado.Size = New System.Drawing.Size(139, 40)
        Me.btnGuardarAvanzado.TabIndex = 186
        Me.btnGuardarAvanzado.Text = "  Guardar"
        Me.btnGuardarAvanzado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarAvanzado.UseVisualStyleBackColor = False
        Me.btnGuardarAvanzado.Visible = False
        '
        'dgvMuestras
        '
        Me.dgvMuestras.AllowUserToAddRows = False
        Me.dgvMuestras.AllowUserToDeleteRows = False
        Me.dgvMuestras.AllowUserToResizeColumns = False
        Me.dgvMuestras.AllowUserToResizeRows = False
        Me.dgvMuestras.BackgroundColor = System.Drawing.Color.White
        Me.dgvMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMuestras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMuestras.Location = New System.Drawing.Point(3, 18)
        Me.dgvMuestras.Name = "dgvMuestras"
        Me.dgvMuestras.ReadOnly = True
        Me.dgvMuestras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvMuestras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMuestras.Size = New System.Drawing.Size(194, 79)
        Me.dgvMuestras.TabIndex = 187
        Me.dgvMuestras.Visible = False
        '
        'btnAgregarAvanzado
        '
        Me.btnAgregarAvanzado.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnAgregarAvanzado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnAgregarAvanzado.FlatAppearance.BorderSize = 2
        Me.btnAgregarAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarAvanzado.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAvanzado.ForeColor = System.Drawing.Color.White
        Me.btnAgregarAvanzado.Image = Global.Scila7.My.Resources.Resources.add2002
        Me.btnAgregarAvanzado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarAvanzado.Location = New System.Drawing.Point(4, 57)
        Me.btnAgregarAvanzado.Name = "btnAgregarAvanzado"
        Me.btnAgregarAvanzado.Size = New System.Drawing.Size(142, 40)
        Me.btnAgregarAvanzado.TabIndex = 188
        Me.btnAgregarAvanzado.Text = "  Agregar datos a muestra"
        Me.btnAgregarAvanzado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarAvanzado.UseVisualStyleBackColor = False
        Me.btnAgregarAvanzado.Visible = False
        '
        'btnAbrirenExcel
        '
        Me.btnAbrirenExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirenExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnAbrirenExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnAbrirenExcel.FlatAppearance.BorderSize = 2
        Me.btnAbrirenExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirenExcel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirenExcel.ForeColor = System.Drawing.Color.White
        Me.btnAbrirenExcel.Image = Global.Scila7.My.Resources.Resources.exportarrow
        Me.btnAbrirenExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrirenExcel.Location = New System.Drawing.Point(279, 28)
        Me.btnAbrirenExcel.Name = "btnAbrirenExcel"
        Me.btnAbrirenExcel.Size = New System.Drawing.Size(139, 40)
        Me.btnAbrirenExcel.TabIndex = 189
        Me.btnAbrirenExcel.Text = "  Exportar a Excel"
        Me.btnAbrirenExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbrirenExcel.UseVisualStyleBackColor = False
        Me.btnAbrirenExcel.Visible = False
        '
        'grpMuestras
        '
        Me.grpMuestras.BackColor = System.Drawing.Color.White
        Me.grpMuestras.Controls.Add(Me.dgvMuestras)
        Me.grpMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpMuestras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMuestras.Location = New System.Drawing.Point(760, 503)
        Me.grpMuestras.Name = "grpMuestras"
        Me.grpMuestras.Size = New System.Drawing.Size(200, 100)
        Me.grpMuestras.TabIndex = 190
        Me.grpMuestras.TabStop = False
        Me.grpMuestras.Text = "Muestras en el proyecto"
        Me.grpMuestras.Visible = False
        '
        'btnCargaBasica
        '
        Me.btnCargaBasica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargaBasica.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnCargaBasica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCargaBasica.FlatAppearance.BorderSize = 2
        Me.btnCargaBasica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargaBasica.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaBasica.ForeColor = System.Drawing.Color.White
        Me.btnCargaBasica.Image = Global.Scila7.My.Resources.Resources.show4
        Me.btnCargaBasica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargaBasica.Location = New System.Drawing.Point(801, 28)
        Me.btnCargaBasica.Name = "btnCargaBasica"
        Me.btnCargaBasica.Size = New System.Drawing.Size(162, 40)
        Me.btnCargaBasica.TabIndex = 191
        Me.btnCargaBasica.Text = "Carga básica.."
        Me.btnCargaBasica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargaBasica.UseVisualStyleBackColor = False
        Me.btnCargaBasica.Visible = False
        '
        'frmDatosSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(972, 750)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCargaBasica)
        Me.Controls.Add(Me.grpMuestras)
        Me.Controls.Add(Me.btnAbrirenExcel)
        Me.Controls.Add(Me.btnAgregarAvanzado)
        Me.Controls.Add(Me.lblMuestraenDatos)
        Me.Controls.Add(Me.btnCargaAvanzada)
        Me.Controls.Add(Me.btnGuardarDatos)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(Me.MuestrasDataGridView)
        Me.Controls.Add(Me.lblNombreMuestra)
        Me.Controls.Add(Me.IdMuestraTextBox)
        Me.Controls.Add(Me.FQId)
        Me.Controls.Add(Me.FQIdMuestra)
        Me.Controls.Add(Me.FQIdProyecto)
        Me.Controls.Add(Me.btnGuardarAvanzado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDatosSimple"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HÁBITAT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitiosMuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MuestrasBindingNavigator.ResumeLayout(False)
        Me.MuestrasBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMuestras.ResumeLayout(False)
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
    Friend WithEvents EnciclopediaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGuardarDatos As System.Windows.Forms.Button
    Friend WithEvents FQId As System.Windows.Forms.TextBox
    Friend WithEvents FQIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents FQIdMuestra As System.Windows.Forms.TextBox
    Friend WithEvents lblMuestraenDatos As System.Windows.Forms.Label
    Friend WithEvents IdMuestraTextBox As System.Windows.Forms.TextBox
    Private WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Private WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Private WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents SitiosMuestrasBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DatosTableAdapter As Scila7.habitatDataSetTableAdapters.ParametrosHabitatTableAdapter
    Friend WithEvents ImportarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuestrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarActualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCargaAvanzada As System.Windows.Forms.Button
    Friend WithEvents btnGuardarAvanzado As System.Windows.Forms.Button
    Friend WithEvents dgvMuestras As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregarAvanzado As System.Windows.Forms.Button
    Friend WithEvents btnAbrirenExcel As System.Windows.Forms.Button
    Friend WithEvents grpMuestras As System.Windows.Forms.GroupBox
    Friend WithEvents btnCargaBasica As System.Windows.Forms.Button
    Friend WithEvents DatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEliminarDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarVentanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
