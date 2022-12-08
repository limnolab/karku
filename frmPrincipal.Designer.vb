<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim Label8 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim AmbienteLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AmbienteLabel1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim PanelElement3 As C1.Win.C1Tile.PanelElement = New C1.Win.C1Tile.PanelElement()
        Dim ImageElement3 As C1.Win.C1Tile.ImageElement = New C1.Win.C1Tile.ImageElement()
        Dim TextElement7 As C1.Win.C1Tile.TextElement = New C1.Win.C1Tile.TextElement()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim PanelElement4 As C1.Win.C1Tile.PanelElement = New C1.Win.C1Tile.PanelElement()
        Dim ImageElement4 As C1.Win.C1Tile.ImageElement = New C1.Win.C1Tile.ImageElement()
        Dim TextElement8 As C1.Win.C1Tile.TextElement = New C1.Win.C1Tile.TextElement()
        Dim TextElement9 As C1.Win.C1Tile.TextElement = New C1.Win.C1Tile.TextElement()
        Dim TextElement10 As C1.Win.C1Tile.TextElement = New C1.Win.C1Tile.TextElement()
        Dim TextElement11 As C1.Win.C1Tile.TextElement = New C1.Win.C1Tile.TextElement()
        Dim TextElement12 As C1.Win.C1Tile.TextElement = New C1.Win.C1Tile.TextElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.EmpresaLabel1 = New System.Windows.Forms.Label()
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.ConfigTableAdapter = New Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirAWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaciarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnciclopediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversorDeUnidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÓptimosYToleranciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MódulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBOrganismosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeParámetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeÍndicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter()
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.SitiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SitiosDataSet = New Scila7.sitiosDataSet()
        Me.TableAdapterManager = New Scila7.Scilla10DataSetTableAdapters.TableAdapterManager()
        Me.SitiosTableAdapter = New Scila7.sitiosDataSetTableAdapters.SitiosTableAdapter()
        Me.PageMuestras = New C1.Win.C1Command.C1DockingTabPage()
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdMuestra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoSitio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpAgregarMuestra = New System.Windows.Forms.GroupBox()
        Me.dgvMultiplesMuestras = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.lblAddMuestras = New System.Windows.Forms.Label()
        Me.numAddMuestras = New System.Windows.Forms.NumericUpDown()
        Me.txtCodigoSitio = New System.Windows.Forms.TextBox()
        Me.txtCoordLONG = New System.Windows.Forms.TextBox()
        Me.txtCoordLAT = New System.Windows.Forms.TextBox()
        Me.CodigoSitioComboBox = New System.Windows.Forms.ComboBox()
        Me.DDSitios = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.txtFechaMuestra = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreMuestra = New System.Windows.Forms.TextBox()
        Me.lblCodigoSitio = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNombreMuestra = New System.Windows.Forms.Label()
        Me.btnEditarSitios = New System.Windows.Forms.Button()
        Me.btnCalcularIndices = New System.Windows.Forms.Button()
        Me.btnImportarDatos = New System.Windows.Forms.Button()
        Me.btnExportarDatos = New System.Windows.Forms.Button()
        Me.btnNuevaMuestra = New System.Windows.Forms.Button()
        Me.btnGuardarMuestra = New System.Windows.Forms.Button()
        Me.btnVolverAProyectos = New System.Windows.Forms.Button()
        Me.btnAgregarMultiples = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NombreLabel2 = New System.Windows.Forms.Label()
        Me.btnCancelarNuevaMuestra = New System.Windows.Forms.Button()
        Me.TileMuestras = New C1.Win.C1Tile.C1TileControl()
        Me.Group1 = New C1.Win.C1Tile.Group()
        Me.PageNuevoProyecto = New C1.Win.C1Command.C1DockingTabPage()
        Me.tabNuevoProyecto = New C1.Win.C1Command.C1DockingTab()
        Me.TabPageTipoAmbiente = New C1.Win.C1Command.C1DockingTabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSiguienteTipoAmbiente = New C1.Win.C1Input.C1Button()
        Me.btnAmbienteLibre = New C1.Win.C1Input.C1Button()
        Me.btnRLP = New C1.Win.C1Input.C1Button()
        Me.btnarroyopamp = New C1.Win.C1Input.C1Button()
        Me.btnarroyomont = New C1.Win.C1Input.C1Button()
        Me.btnLenitico = New C1.Win.C1Input.C1Button()
        Me.TabPageTipoDatos = New C1.Win.C1Command.C1DockingTabPage()
        Me.btnSiguienteTipoDatos = New C1.Win.C1Input.C1Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvDatosAUsar = New System.Windows.Forms.DataGridView()
        Me.colModulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHabilitado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPageMuestrasIniciales = New C1.Win.C1Command.C1DockingTabPage()
        Me.dgvMuestrasIniciales = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSiguienteMuestrasIniciales = New C1.Win.C1Input.C1Button()
        Me.numMuestrasIniciales = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.webDescripcion = New System.Windows.Forms.WebBrowser()
        Me.grpDatosNuevo = New System.Windows.Forms.GroupBox()
        Me.txtNuevoAmbiente = New System.Windows.Forms.TextBox()
        Me.txtDescripcionNuevo = New System.Windows.Forms.TextBox()
        Me.txtAutorNuevo = New System.Windows.Forms.TextBox()
        Me.txtNombreNuevo = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtIdProyectoNuevo = New System.Windows.Forms.TextBox()
        Me.IdProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.TabDock = New C1.Win.C1Command.C1DockingTab()
        Me.PageProyectos = New C1.Win.C1Command.C1DockingTabPage()
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ambiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscarOrganismos2 = New C1.Win.C1Input.C1SplitButton()
        Me.btnSiguienteProyectos = New System.Windows.Forms.Button()
        Me.btnNuevoProyecto = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpDatosdelProyecto = New System.Windows.Forms.GroupBox()
        Me.btnGuardarProyecto = New System.Windows.Forms.Button()
        Me.AmbienteLabel2 = New System.Windows.Forms.Label()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.AmbienteTextBox = New System.Windows.Forms.TextBox()
        Me.PageCalculos = New C1.Win.C1Command.C1DockingTabPage()
        Me.btnSeleccionarTodosIndices = New System.Windows.Forms.Button()
        Me.btnVolverAProyectos1 = New System.Windows.Forms.Button()
        Me.btnVolverAMuestras = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pgbCalculoIndices = New System.Windows.Forms.ProgressBar()
        Me.btnCalcularSeleccionados = New System.Windows.Forms.Button()
        Me.TileCalculos = New C1.Win.C1Tile.C1TileControl()
        Me.TemplateTiles = New C1.Win.C1Tile.Template()
        Me.TemplateTileSmall = New C1.Win.C1Tile.Template()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.DropDownItem1 = New C1.Win.C1Input.DropDownItem()
        Label8 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        AmbienteLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        AmbienteLabel1 = New System.Windows.Forms.Label()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitiosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageMuestras.SuspendLayout()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAgregarMuestra.SuspendLayout()
        CType(Me.dgvMultiplesMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAddMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDSitios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageNuevoProyecto.SuspendLayout()
        CType(Me.tabNuevoProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNuevoProyecto.SuspendLayout()
        Me.TabPageTipoAmbiente.SuspendLayout()
        Me.TabPageTipoDatos.SuspendLayout()
        CType(Me.dgvDatosAUsar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMuestrasIniciales.SuspendLayout()
        CType(Me.dgvMuestrasIniciales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMuestrasIniciales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosNuevo.SuspendLayout()
        CType(Me.TabDock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDock.SuspendLayout()
        Me.PageProyectos.SuspendLayout()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosdelProyecto.SuspendLayout()
        Me.PageCalculos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(13, 113)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(76, 15)
        Label8.TabIndex = 39
        Label8.Text = "Descripción:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(14, 55)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(40, 15)
        Label7.TabIndex = 37
        Label7.Text = "Autor:"
        '
        'Label6
        '
        Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(14, 22)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(53, 15)
        Label6.TabIndex = 35
        Label6.Text = "Nombre:"
        '
        'AmbienteLabel
        '
        AmbienteLabel.AutoSize = True
        AmbienteLabel.Location = New System.Drawing.Point(13, 86)
        AmbienteLabel.Name = "AmbienteLabel"
        AmbienteLabel.Size = New System.Drawing.Size(61, 15)
        AmbienteLabel.TabIndex = 40
        AmbienteLabel.Text = "Ambiente:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(17, 105)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(76, 15)
        DescripcionLabel.TabIndex = 39
        DescripcionLabel.Text = "Descripción:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AutorLabel.Location = New System.Drawing.Point(17, 55)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(40, 15)
        AutorLabel.TabIndex = 37
        AutorLabel.Text = "Autor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(17, 25)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(124, 15)
        NombreLabel.TabIndex = 35
        NombreLabel.Text = "Nombre del Proyecto:"
        '
        'AmbienteLabel1
        '
        AmbienteLabel1.AutoSize = True
        AmbienteLabel1.Location = New System.Drawing.Point(17, 77)
        AmbienteLabel1.Name = "AmbienteLabel1"
        AmbienteLabel1.Size = New System.Drawing.Size(61, 15)
        AmbienteLabel1.TabIndex = 40
        AmbienteLabel1.Text = "Ambiente:"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Owner = Me
        '
        'EmpresaLabel1
        '
        Me.EmpresaLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpresaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigBindingSource, "Empresa", True))
        Me.EmpresaLabel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaLabel1.ForeColor = System.Drawing.Color.Black
        Me.EmpresaLabel1.Location = New System.Drawing.Point(558, 30)
        Me.EmpresaLabel1.Name = "EmpresaLabel1"
        Me.EmpresaLabel1.Size = New System.Drawing.Size(162, 72)
        Me.EmpresaLabel1.TabIndex = 18
        Me.EmpresaLabel1.Text = "Empresa"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.ProyectosToolStripMenuItem, Me.EnciclopediaToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(808, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirAWindowsToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SalirToolStripMenuItem.Text = "Archivo"
        '
        'SalirAWindowsToolStripMenuItem
        '
        Me.SalirAWindowsToolStripMenuItem.Name = "SalirAWindowsToolStripMenuItem"
        Me.SalirAWindowsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SalirAWindowsToolStripMenuItem.Text = "Salir a Windows"
        '
        'ProyectosToolStripMenuItem
        '
        Me.ProyectosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VaciarProyectoToolStripMenuItem, Me.EliminarProyectoToolStripMenuItem, Me.EditarDatosToolStripMenuItem})
        Me.ProyectosToolStripMenuItem.Name = "ProyectosToolStripMenuItem"
        Me.ProyectosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ProyectosToolStripMenuItem.Text = "Proyectos"
        '
        'VaciarProyectoToolStripMenuItem
        '
        Me.VaciarProyectoToolStripMenuItem.Name = "VaciarProyectoToolStripMenuItem"
        Me.VaciarProyectoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.VaciarProyectoToolStripMenuItem.Text = "Vaciar proyecto..."
        '
        'EliminarProyectoToolStripMenuItem
        '
        Me.EliminarProyectoToolStripMenuItem.Name = "EliminarProyectoToolStripMenuItem"
        Me.EliminarProyectoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.EliminarProyectoToolStripMenuItem.Text = "Eliminar proyecto..."
        '
        'EditarDatosToolStripMenuItem
        '
        Me.EditarDatosToolStripMenuItem.Name = "EditarDatosToolStripMenuItem"
        Me.EditarDatosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.EditarDatosToolStripMenuItem.Text = "Editar datos..."
        '
        'EnciclopediaToolStripMenuItem
        '
        Me.EnciclopediaToolStripMenuItem.Name = "EnciclopediaToolStripMenuItem"
        Me.EnciclopediaToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.EnciclopediaToolStripMenuItem.Text = "Enciclopedia"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConversorDeUnidadesToolStripMenuItem, Me.ÓptimosYToleranciasToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'ConversorDeUnidadesToolStripMenuItem
        '
        Me.ConversorDeUnidadesToolStripMenuItem.Name = "ConversorDeUnidadesToolStripMenuItem"
        Me.ConversorDeUnidadesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ConversorDeUnidadesToolStripMenuItem.Text = "Conversor de unidades"
        '
        'ÓptimosYToleranciasToolStripMenuItem
        '
        Me.ÓptimosYToleranciasToolStripMenuItem.Name = "ÓptimosYToleranciasToolStripMenuItem"
        Me.ÓptimosYToleranciasToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ÓptimosYToleranciasToolStripMenuItem.Text = "Óptimos y tolerancias"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MódulosToolStripMenuItem, Me.PerfilToolStripMenuItem, Me.DBOrganismosToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'MódulosToolStripMenuItem
        '
        Me.MódulosToolStripMenuItem.Name = "MódulosToolStripMenuItem"
        Me.MódulosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MódulosToolStripMenuItem.Text = "Módulos..."
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PerfilToolStripMenuItem.Text = "Perfil..."
        '
        'DBOrganismosToolStripMenuItem
        '
        Me.DBOrganismosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorDeParámetrosToolStripMenuItem, Me.EditorDeÍndicesToolStripMenuItem})
        Me.DBOrganismosToolStripMenuItem.Name = "DBOrganismosToolStripMenuItem"
        Me.DBOrganismosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DBOrganismosToolStripMenuItem.Text = "Bases de datos"
        '
        'EditorDeParámetrosToolStripMenuItem
        '
        Me.EditorDeParámetrosToolStripMenuItem.Name = "EditorDeParámetrosToolStripMenuItem"
        Me.EditorDeParámetrosToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.EditorDeParámetrosToolStripMenuItem.Text = "Editor de Parámetros y Taxones"
        '
        'EditorDeÍndicesToolStripMenuItem
        '
        Me.EditorDeÍndicesToolStripMenuItem.Name = "EditorDeÍndicesToolStripMenuItem"
        Me.EditorDeÍndicesToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.EditorDeÍndicesToolStripMenuItem.Text = "Editor de Índices"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Instituto de Limnología ""Dr. Raúl A. Ringuelet"""
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
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'SitiosBindingSource
        '
        Me.SitiosBindingSource.DataMember = "Sitios"
        Me.SitiosBindingSource.DataSource = Me.SitiosDataSet
        '
        'SitiosDataSet
        '
        Me.SitiosDataSet.DataSetName = "sitiosDataSet"
        Me.SitiosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MuestrasTableAdapter = Me.MuestrasTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Scila7.Scilla10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SitiosTableAdapter
        '
        Me.SitiosTableAdapter.ClearBeforeFill = True
        '
        'PageMuestras
        '
        Me.PageMuestras.BackColor = System.Drawing.Color.White
        Me.PageMuestras.Controls.Add(Me.MuestrasDataGridView)
        Me.PageMuestras.Controls.Add(Me.grpAgregarMuestra)
        Me.PageMuestras.Controls.Add(Me.btnCalcularIndices)
        Me.PageMuestras.Controls.Add(Me.btnImportarDatos)
        Me.PageMuestras.Controls.Add(Me.btnExportarDatos)
        Me.PageMuestras.Controls.Add(Me.btnNuevaMuestra)
        Me.PageMuestras.Controls.Add(Me.btnGuardarMuestra)
        Me.PageMuestras.Controls.Add(Me.btnVolverAProyectos)
        Me.PageMuestras.Controls.Add(Me.Label10)
        Me.PageMuestras.Controls.Add(Me.NombreLabel2)
        Me.PageMuestras.Controls.Add(Me.btnCancelarNuevaMuestra)
        Me.PageMuestras.Controls.Add(Me.TileMuestras)
        Me.PageMuestras.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageMuestras.Location = New System.Drawing.Point(0, 38)
        Me.PageMuestras.Name = "PageMuestras"
        Me.PageMuestras.Size = New System.Drawing.Size(808, 607)
        Me.PageMuestras.TabIndex = 2
        Me.PageMuestras.TabVisible = False
        Me.PageMuestras.Text = "Muestras"
        '
        'MuestrasDataGridView
        '
        Me.MuestrasDataGridView.AllowUserToAddRows = False
        Me.MuestrasDataGridView.AllowUserToDeleteRows = False
        Me.MuestrasDataGridView.AllowUserToResizeColumns = False
        Me.MuestrasDataGridView.AllowUserToResizeRows = False
        Me.MuestrasDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MuestrasDataGridView.AutoGenerateColumns = False
        Me.MuestrasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MuestrasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MuestrasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MuestrasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMuestra, Me.IdProyecto, Me.Nombre, Me.Fecha, Me.CodigoSitio, Me.Autor})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MuestrasDataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.MuestrasDataGridView.EnableHeadersVisualStyles = False
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(29, 154)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.ReadOnly = True
        Me.MuestrasDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MuestrasDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.MuestrasDataGridView.RowHeadersVisible = False
        Me.MuestrasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(312, 438)
        Me.MuestrasDataGridView.TabIndex = 175
        '
        'IdMuestra
        '
        Me.IdMuestra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdMuestra.DataPropertyName = "IdMuestra"
        Me.IdMuestra.HeaderText = "ID"
        Me.IdMuestra.Name = "IdMuestra"
        Me.IdMuestra.ReadOnly = True
        Me.IdMuestra.Visible = False
        '
        'IdProyecto
        '
        Me.IdProyecto.DataPropertyName = "IdProyecto"
        Me.IdProyecto.HeaderText = "IdProyecto"
        Me.IdProyecto.Name = "IdProyecto"
        Me.IdProyecto.ReadOnly = True
        Me.IdProyecto.Visible = False
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle7
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
        'CodigoSitio
        '
        Me.CodigoSitio.DataPropertyName = "CodigoSitio"
        Me.CodigoSitio.HeaderText = "Código"
        Me.CodigoSitio.Name = "CodigoSitio"
        Me.CodigoSitio.ReadOnly = True
        '
        'Autor
        '
        Me.Autor.DataPropertyName = "Autor"
        Me.Autor.HeaderText = "Autor"
        Me.Autor.Name = "Autor"
        Me.Autor.ReadOnly = True
        Me.Autor.Visible = False
        '
        'MuestrasBindingSource
        '
        Me.MuestrasBindingSource.DataMember = "Proyectos_Muestras"
        Me.MuestrasBindingSource.DataSource = Me.ProyectosBindingSource
        '
        'grpAgregarMuestra
        '
        Me.grpAgregarMuestra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpAgregarMuestra.Controls.Add(Me.txtCodigoSitio)
        Me.grpAgregarMuestra.Controls.Add(Me.txtCoordLONG)
        Me.grpAgregarMuestra.Controls.Add(Me.txtCoordLAT)
        Me.grpAgregarMuestra.Controls.Add(Me.CodigoSitioComboBox)
        Me.grpAgregarMuestra.Controls.Add(Me.DDSitios)
        Me.grpAgregarMuestra.Controls.Add(Me.txtFechaMuestra)
        Me.grpAgregarMuestra.Controls.Add(Me.btnAgregarMultiples)
        Me.grpAgregarMuestra.Controls.Add(Me.txtNombreMuestra)
        Me.grpAgregarMuestra.Controls.Add(Me.lblCodigoSitio)
        Me.grpAgregarMuestra.Controls.Add(Me.lblFecha)
        Me.grpAgregarMuestra.Controls.Add(Me.lblNombreMuestra)
        Me.grpAgregarMuestra.Controls.Add(Me.btnEditarSitios)
        Me.grpAgregarMuestra.Controls.Add(Me.dgvMultiplesMuestras)
        Me.grpAgregarMuestra.Controls.Add(Me.lblAddMuestras)
        Me.grpAgregarMuestra.Controls.Add(Me.numAddMuestras)
        Me.grpAgregarMuestra.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAgregarMuestra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.grpAgregarMuestra.Location = New System.Drawing.Point(29, 154)
        Me.grpAgregarMuestra.Name = "grpAgregarMuestra"
        Me.grpAgregarMuestra.Size = New System.Drawing.Size(312, 438)
        Me.grpAgregarMuestra.TabIndex = 118
        Me.grpAgregarMuestra.TabStop = False
        Me.grpAgregarMuestra.Visible = False
        '
        'dgvMultiplesMuestras
        '
        Me.dgvMultiplesMuestras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvMultiplesMuestras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMultiplesMuestras.CaptionHeight = 17
        Me.dgvMultiplesMuestras.Images.Add(CType(resources.GetObject("dgvMultiplesMuestras.Images"), System.Drawing.Image))
        Me.dgvMultiplesMuestras.Location = New System.Drawing.Point(16, 52)
        Me.dgvMultiplesMuestras.Name = "dgvMultiplesMuestras"
        Me.dgvMultiplesMuestras.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.dgvMultiplesMuestras.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.dgvMultiplesMuestras.PreviewInfo.ZoomFactor = 75.0R
        Me.dgvMultiplesMuestras.PrintInfo.PageSettings = CType(resources.GetObject("dgvMultiplesMuestras.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.dgvMultiplesMuestras.RecordSelectors = False
        Me.dgvMultiplesMuestras.RowHeight = 25
        Me.dgvMultiplesMuestras.Size = New System.Drawing.Size(281, 344)
        Me.dgvMultiplesMuestras.TabIndex = 181
        Me.dgvMultiplesMuestras.Visible = False
        Me.dgvMultiplesMuestras.PropBag = resources.GetString("dgvMultiplesMuestras.PropBag")
        '
        'lblAddMuestras
        '
        Me.lblAddMuestras.AutoSize = True
        Me.lblAddMuestras.Location = New System.Drawing.Point(16, 26)
        Me.lblAddMuestras.Name = "lblAddMuestras"
        Me.lblAddMuestras.Size = New System.Drawing.Size(201, 15)
        Me.lblAddMuestras.TabIndex = 184
        Me.lblAddMuestras.Text = "¿Cuántas muestras desea agregar ?"
        Me.lblAddMuestras.Visible = False
        '
        'numAddMuestras
        '
        Me.numAddMuestras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numAddMuestras.Location = New System.Drawing.Point(223, 23)
        Me.numAddMuestras.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numAddMuestras.Name = "numAddMuestras"
        Me.numAddMuestras.Size = New System.Drawing.Size(74, 23)
        Me.numAddMuestras.TabIndex = 187
        Me.numAddMuestras.Visible = False
        '
        'txtCodigoSitio
        '
        Me.txtCodigoSitio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoSitio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitiosBindingSource, "CodigoSitio", True))
        Me.txtCodigoSitio.Enabled = False
        Me.txtCodigoSitio.Location = New System.Drawing.Point(16, 128)
        Me.txtCodigoSitio.Name = "txtCodigoSitio"
        Me.txtCodigoSitio.ReadOnly = True
        Me.txtCodigoSitio.Size = New System.Drawing.Size(101, 16)
        Me.txtCodigoSitio.TabIndex = 186
        '
        'txtCoordLONG
        '
        Me.txtCoordLONG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCoordLONG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitiosBindingSource, "CoordLONG", True))
        Me.txtCoordLONG.Enabled = False
        Me.txtCoordLONG.Location = New System.Drawing.Point(205, 128)
        Me.txtCoordLONG.Name = "txtCoordLONG"
        Me.txtCoordLONG.ReadOnly = True
        Me.txtCoordLONG.Size = New System.Drawing.Size(68, 16)
        Me.txtCoordLONG.TabIndex = 185
        '
        'txtCoordLAT
        '
        Me.txtCoordLAT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCoordLAT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitiosBindingSource, "CoordLAT", True))
        Me.txtCoordLAT.Enabled = False
        Me.txtCoordLAT.Location = New System.Drawing.Point(123, 128)
        Me.txtCoordLAT.Name = "txtCoordLAT"
        Me.txtCoordLAT.ReadOnly = True
        Me.txtCoordLAT.Size = New System.Drawing.Size(76, 16)
        Me.txtCoordLAT.TabIndex = 184
        '
        'CodigoSitioComboBox
        '
        Me.CodigoSitioComboBox.DataSource = Me.SitiosBindingSource
        Me.CodigoSitioComboBox.DisplayMember = "Nombre"
        Me.CodigoSitioComboBox.FormattingEnabled = True
        Me.CodigoSitioComboBox.Location = New System.Drawing.Point(82, 85)
        Me.CodigoSitioComboBox.Name = "CodigoSitioComboBox"
        Me.CodigoSitioComboBox.Size = New System.Drawing.Size(174, 23)
        Me.CodigoSitioComboBox.TabIndex = 183
        Me.CodigoSitioComboBox.ValueMember = "Nombre"
        '
        'DDSitios
        '
        Me.DDSitios.AllowColMove = True
        Me.DDSitios.AllowColSelect = True
        Me.DDSitios.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.DDSitios.AlternatingRows = False
        Me.DDSitios.CaptionHeight = 17
        Me.DDSitios.CaptionStyle = Style9
        Me.DDSitios.ColumnCaptionHeight = 17
        Me.DDSitios.ColumnFooterHeight = 17
        Me.DDSitios.DataSource = Me.SitiosBindingSource
        Me.DDSitios.DisplayMember = "CodigoSitio"
        Me.DDSitios.DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Column
        Me.DDSitios.EvenRowStyle = Style10
        Me.DDSitios.FetchRowStyles = False
        Me.DDSitios.FooterStyle = Style11
        Me.DDSitios.HeadingStyle = Style12
        Me.DDSitios.HighLightRowStyle = Style13
        Me.DDSitios.Images.Add(CType(resources.GetObject("DDSitios.Images"), System.Drawing.Image))
        Me.DDSitios.Location = New System.Drawing.Point(243, 303)
        Me.DDSitios.Name = "DDSitios"
        Me.DDSitios.OddRowStyle = Style14
        Me.DDSitios.RecordSelectorStyle = Style15
        Me.DDSitios.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.DDSitios.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.DDSitios.RowHeight = 15
        Me.DDSitios.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.DDSitios.ScrollTips = False
        Me.DDSitios.Size = New System.Drawing.Size(183, 93)
        Me.DDSitios.Style = Style16
        Me.DDSitios.TabIndex = 182
        Me.DDSitios.TabStop = False
        Me.DDSitios.ValueMember = "CodigoSitio"
        Me.DDSitios.Visible = False
        Me.DDSitios.PropBag = resources.GetString("DDSitios.PropBag")
        '
        'txtFechaMuestra
        '
        Me.txtFechaMuestra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaMuestra.Location = New System.Drawing.Point(82, 56)
        Me.txtFechaMuestra.Name = "txtFechaMuestra"
        Me.txtFechaMuestra.Size = New System.Drawing.Size(215, 23)
        Me.txtFechaMuestra.TabIndex = 180
        '
        'txtNombreMuestra
        '
        Me.txtNombreMuestra.Location = New System.Drawing.Point(82, 22)
        Me.txtNombreMuestra.Name = "txtNombreMuestra"
        Me.txtNombreMuestra.Size = New System.Drawing.Size(215, 23)
        Me.txtNombreMuestra.TabIndex = 179
        '
        'lblCodigoSitio
        '
        Me.lblCodigoSitio.AutoSize = True
        Me.lblCodigoSitio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoSitio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblCodigoSitio.Location = New System.Drawing.Point(12, 88)
        Me.lblCodigoSitio.Name = "lblCodigoSitio"
        Me.lblCodigoSitio.Size = New System.Drawing.Size(41, 19)
        Me.lblCodigoSitio.TabIndex = 178
        Me.lblCodigoSitio.Text = "Sitio:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(12, 59)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(51, 19)
        Me.lblFecha.TabIndex = 177
        Me.lblFecha.Text = "Fecha:"
        '
        'lblNombreMuestra
        '
        Me.lblNombreMuestra.AutoSize = True
        Me.lblNombreMuestra.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMuestra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblNombreMuestra.Location = New System.Drawing.Point(12, 26)
        Me.lblNombreMuestra.Name = "lblNombreMuestra"
        Me.lblNombreMuestra.Size = New System.Drawing.Size(64, 19)
        Me.lblNombreMuestra.TabIndex = 176
        Me.lblNombreMuestra.Text = "Nombre:"
        '
        'btnEditarSitios
        '
        Me.btnEditarSitios.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEditarSitios.FlatAppearance.BorderSize = 0
        Me.btnEditarSitios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarSitios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarSitios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEditarSitios.Image = Global.Scila7.My.Resources.Resources.edit_equalizer
        Me.btnEditarSitios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarSitios.Location = New System.Drawing.Point(262, 85)
        Me.btnEditarSitios.Name = "btnEditarSitios"
        Me.btnEditarSitios.Size = New System.Drawing.Size(35, 37)
        Me.btnEditarSitios.TabIndex = 127
        Me.btnEditarSitios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarSitios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditarSitios.UseVisualStyleBackColor = False
        '
        'btnCalcularIndices
        '
        Me.btnCalcularIndices.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcularIndices.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCalcularIndices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCalcularIndices.FlatAppearance.BorderSize = 0
        Me.btnCalcularIndices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularIndices.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularIndices.ForeColor = System.Drawing.Color.White
        Me.btnCalcularIndices.Image = Global.Scila7.My.Resources.Resources.calculator7
        Me.btnCalcularIndices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcularIndices.Location = New System.Drawing.Point(619, 98)
        Me.btnCalcularIndices.Name = "btnCalcularIndices"
        Me.btnCalcularIndices.Size = New System.Drawing.Size(186, 50)
        Me.btnCalcularIndices.TabIndex = 174
        Me.btnCalcularIndices.Text = "  Calcular Índices"
        Me.btnCalcularIndices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcularIndices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalcularIndices.UseVisualStyleBackColor = False
        '
        'btnImportarDatos
        '
        Me.btnImportarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnImportarDatos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnImportarDatos.FlatAppearance.BorderSize = 0
        Me.btnImportarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportarDatos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportarDatos.ForeColor = System.Drawing.Color.White
        Me.btnImportarDatos.Image = Global.Scila7.My.Resources.Resources.importarrow
        Me.btnImportarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportarDatos.Location = New System.Drawing.Point(619, 542)
        Me.btnImportarDatos.Name = "btnImportarDatos"
        Me.btnImportarDatos.Size = New System.Drawing.Size(187, 50)
        Me.btnImportarDatos.TabIndex = 171
        Me.btnImportarDatos.Text = "  Importar "
        Me.btnImportarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportarDatos.UseVisualStyleBackColor = False
        '
        'btnExportarDatos
        '
        Me.btnExportarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnExportarDatos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExportarDatos.FlatAppearance.BorderSize = 0
        Me.btnExportarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarDatos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportarDatos.ForeColor = System.Drawing.Color.White
        Me.btnExportarDatos.Image = Global.Scila7.My.Resources.Resources.exportarrow
        Me.btnExportarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarDatos.Location = New System.Drawing.Point(619, 488)
        Me.btnExportarDatos.Name = "btnExportarDatos"
        Me.btnExportarDatos.Size = New System.Drawing.Size(186, 50)
        Me.btnExportarDatos.TabIndex = 170
        Me.btnExportarDatos.Text = "Exportar"
        Me.btnExportarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportarDatos.UseVisualStyleBackColor = False
        '
        'btnNuevaMuestra
        '
        Me.btnNuevaMuestra.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnNuevaMuestra.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNuevaMuestra.FlatAppearance.BorderSize = 0
        Me.btnNuevaMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaMuestra.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaMuestra.ForeColor = System.Drawing.Color.White
        Me.btnNuevaMuestra.Image = Global.Scila7.My.Resources.Resources.add2002
        Me.btnNuevaMuestra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevaMuestra.Location = New System.Drawing.Point(29, 98)
        Me.btnNuevaMuestra.Name = "btnNuevaMuestra"
        Me.btnNuevaMuestra.Size = New System.Drawing.Size(312, 50)
        Me.btnNuevaMuestra.TabIndex = 116
        Me.btnNuevaMuestra.Text = "  Agregar muestras"
        Me.btnNuevaMuestra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevaMuestra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevaMuestra.UseVisualStyleBackColor = False
        '
        'btnGuardarMuestra
        '
        Me.btnGuardarMuestra.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnGuardarMuestra.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnGuardarMuestra.FlatAppearance.BorderSize = 0
        Me.btnGuardarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarMuestra.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarMuestra.ForeColor = System.Drawing.Color.White
        Me.btnGuardarMuestra.Image = Global.Scila7.My.Resources.Resources.save
        Me.btnGuardarMuestra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarMuestra.Location = New System.Drawing.Point(29, 98)
        Me.btnGuardarMuestra.Name = "btnGuardarMuestra"
        Me.btnGuardarMuestra.Size = New System.Drawing.Size(199, 50)
        Me.btnGuardarMuestra.TabIndex = 117
        Me.btnGuardarMuestra.Text = "  Guardar muestra"
        Me.btnGuardarMuestra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarMuestra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarMuestra.UseVisualStyleBackColor = False
        Me.btnGuardarMuestra.Visible = False
        '
        'btnVolverAProyectos
        '
        Me.btnVolverAProyectos.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnVolverAProyectos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVolverAProyectos.FlatAppearance.BorderSize = 0
        Me.btnVolverAProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolverAProyectos.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btnVolverAProyectos.ForeColor = System.Drawing.Color.White
        Me.btnVolverAProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolverAProyectos.Location = New System.Drawing.Point(3, 0)
        Me.btnVolverAProyectos.Name = "btnVolverAProyectos"
        Me.btnVolverAProyectos.Size = New System.Drawing.Size(88, 31)
        Me.btnVolverAProyectos.TabIndex = 168
        Me.btnVolverAProyectos.Text = "Proyectos >"
        Me.btnVolverAProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolverAProyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVolverAProyectos.UseVisualStyleBackColor = False
        '
        'btnAgregarMultiples
        '
        Me.btnAgregarMultiples.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnAgregarMultiples.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarMultiples.FlatAppearance.BorderSize = 0
        Me.btnAgregarMultiples.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarMultiples.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMultiples.ForeColor = System.Drawing.Color.White
        Me.btnAgregarMultiples.Image = Global.Scila7.My.Resources.Resources.dots7
        Me.btnAgregarMultiples.Location = New System.Drawing.Point(16, 403)
        Me.btnAgregarMultiples.Name = "btnAgregarMultiples"
        Me.btnAgregarMultiples.Size = New System.Drawing.Size(270, 29)
        Me.btnAgregarMultiples.TabIndex = 174
        Me.btnAgregarMultiples.Text = "Agregar múltiples muestras"
        Me.btnAgregarMultiples.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarMultiples.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(29, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 33)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Muestras"
        '
        'NombreLabel2
        '
        Me.NombreLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.NombreLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre", True))
        Me.NombreLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.NombreLabel2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLabel2.ForeColor = System.Drawing.Color.White
        Me.NombreLabel2.Location = New System.Drawing.Point(0, 0)
        Me.NombreLabel2.Name = "NombreLabel2"
        Me.NombreLabel2.Size = New System.Drawing.Size(808, 31)
        Me.NombreLabel2.TabIndex = 121
        Me.NombreLabel2.Text = "Label1"
        Me.NombreLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelarNuevaMuestra
        '
        Me.btnCancelarNuevaMuestra.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCancelarNuevaMuestra.FlatAppearance.BorderSize = 0
        Me.btnCancelarNuevaMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarNuevaMuestra.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarNuevaMuestra.ForeColor = System.Drawing.Color.White
        Me.btnCancelarNuevaMuestra.Image = Global.Scila7.My.Resources.Resources.cross106
        Me.btnCancelarNuevaMuestra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarNuevaMuestra.Location = New System.Drawing.Point(234, 98)
        Me.btnCancelarNuevaMuestra.Name = "btnCancelarNuevaMuestra"
        Me.btnCancelarNuevaMuestra.Size = New System.Drawing.Size(107, 50)
        Me.btnCancelarNuevaMuestra.TabIndex = 173
        Me.btnCancelarNuevaMuestra.Text = "  Cancelar"
        Me.btnCancelarNuevaMuestra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarNuevaMuestra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelarNuevaMuestra.UseVisualStyleBackColor = False
        Me.btnCancelarNuevaMuestra.Visible = False
        '
        'TileMuestras
        '
        Me.TileMuestras.AllowChecking = True
        Me.TileMuestras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TileMuestras.BackColor = System.Drawing.Color.LightGray
        Me.TileMuestras.CellHeight = 40
        Me.TileMuestras.CellSpacing = 5
        Me.TileMuestras.CellWidth = 80
        Me.TileMuestras.CheckBorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        '
        '
        '
        PanelElement3.Alignment = System.Drawing.ContentAlignment.BottomLeft
        PanelElement3.Children.Add(ImageElement3)
        PanelElement3.Children.Add(TextElement7)
        PanelElement3.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.TileMuestras.DefaultTemplate.Elements.Add(PanelElement3)
        Me.TileMuestras.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileMuestras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TileMuestras.GroupFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileMuestras.GroupForeColor = System.Drawing.Color.White
        Me.TileMuestras.GroupPadding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.TileMuestras.Groups.Add(Me.Group1)
        Me.TileMuestras.GroupSpacing = 40
        Me.TileMuestras.GroupTextBold = C1.Win.C1Tile.ThreeStateBoolean.[True]
        Me.TileMuestras.GroupTextY = 0
        Me.TileMuestras.HotBorderColor = System.Drawing.Color.White
        Me.TileMuestras.Location = New System.Drawing.Point(347, 98)
        Me.TileMuestras.Name = "TileMuestras"
        Me.TileMuestras.Orientation = C1.Win.C1Tile.LayoutOrientation.Vertical
        Me.TileMuestras.Padding = New System.Windows.Forms.Padding(0)
        Me.TileMuestras.Size = New System.Drawing.Size(266, 494)
        Me.TileMuestras.SurfacePadding = New System.Windows.Forms.Padding(5, 5, 15, 5)
        Me.TileMuestras.TabIndex = 169
        Me.TileMuestras.TextBold = C1.Win.C1Tile.ThreeStateBoolean.[False]
        Me.TileMuestras.TextSize = 0.0!
        Me.TileMuestras.TextX = 0
        Me.TileMuestras.TextY = 0
        Me.TileMuestras.TileBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TileMuestras.TileBorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        '
        'Group1
        '
        Me.Group1.Name = "Group1"
        Me.Group1.Text = "Group 1"
        '
        'PageNuevoProyecto
        '
        Me.PageNuevoProyecto.BackColor = System.Drawing.Color.White
        Me.PageNuevoProyecto.Controls.Add(Me.tabNuevoProyecto)
        Me.PageNuevoProyecto.Controls.Add(Me.webDescripcion)
        Me.PageNuevoProyecto.Controls.Add(Me.grpDatosNuevo)
        Me.PageNuevoProyecto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageNuevoProyecto.Location = New System.Drawing.Point(0, 38)
        Me.PageNuevoProyecto.Name = "PageNuevoProyecto"
        Me.PageNuevoProyecto.Size = New System.Drawing.Size(808, 607)
        Me.PageNuevoProyecto.TabIndex = 0
        Me.PageNuevoProyecto.TabVisible = False
        Me.PageNuevoProyecto.Text = "Nuevo Proyecto"
        '
        'tabNuevoProyecto
        '
        Me.tabNuevoProyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabNuevoProyecto.Controls.Add(Me.TabPageTipoAmbiente)
        Me.tabNuevoProyecto.Controls.Add(Me.TabPageTipoDatos)
        Me.tabNuevoProyecto.Controls.Add(Me.TabPageMuestrasIniciales)
        Me.tabNuevoProyecto.Location = New System.Drawing.Point(21, 10)
        Me.tabNuevoProyecto.Name = "tabNuevoProyecto"
        Me.tabNuevoProyecto.SelectedIndex = 2
        Me.tabNuevoProyecto.Size = New System.Drawing.Size(494, 583)
        Me.tabNuevoProyecto.TabIndex = 69
        Me.tabNuevoProyecto.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.tabNuevoProyecto.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
        Me.tabNuevoProyecto.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'TabPageTipoAmbiente
        '
        Me.TabPageTipoAmbiente.BackColor = System.Drawing.Color.White
        Me.TabPageTipoAmbiente.Controls.Add(Me.Label3)
        Me.TabPageTipoAmbiente.Controls.Add(Me.btnSiguienteTipoAmbiente)
        Me.TabPageTipoAmbiente.Controls.Add(Me.btnAmbienteLibre)
        Me.TabPageTipoAmbiente.Controls.Add(Me.btnRLP)
        Me.TabPageTipoAmbiente.Controls.Add(Me.btnarroyopamp)
        Me.TabPageTipoAmbiente.Controls.Add(Me.btnarroyomont)
        Me.TabPageTipoAmbiente.Controls.Add(Me.btnLenitico)
        Me.TabPageTipoAmbiente.Location = New System.Drawing.Point(1, 30)
        Me.TabPageTipoAmbiente.Name = "TabPageTipoAmbiente"
        Me.TabPageTipoAmbiente.Size = New System.Drawing.Size(492, 552)
        Me.TabPageTipoAmbiente.TabIndex = 0
        Me.TabPageTipoAmbiente.Text = "Ambiente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 18)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "¿A qué ambiente pertenecen las muestras?"
        '
        'btnSiguienteTipoAmbiente
        '
        Me.btnSiguienteTipoAmbiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnSiguienteTipoAmbiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSiguienteTipoAmbiente.FlatAppearance.BorderSize = 0
        Me.btnSiguienteTipoAmbiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteTipoAmbiente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteTipoAmbiente.Image = Global.Scila7.My.Resources.Resources.check59W
        Me.btnSiguienteTipoAmbiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiguienteTipoAmbiente.Location = New System.Drawing.Point(307, 496)
        Me.btnSiguienteTipoAmbiente.Name = "btnSiguienteTipoAmbiente"
        Me.btnSiguienteTipoAmbiente.Size = New System.Drawing.Size(177, 50)
        Me.btnSiguienteTipoAmbiente.TabIndex = 67
        Me.btnSiguienteTipoAmbiente.Text = "    Siguiente"
        Me.btnSiguienteTipoAmbiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSiguienteTipoAmbiente.UseVisualStyleBackColor = True
        Me.btnSiguienteTipoAmbiente.Visible = False
        '
        'btnAmbienteLibre
        '
        Me.btnAmbienteLibre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnAmbienteLibre.FlatAppearance.BorderSize = 2
        Me.btnAmbienteLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmbienteLibre.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmbienteLibre.Location = New System.Drawing.Point(18, 496)
        Me.btnAmbienteLibre.Name = "btnAmbienteLibre"
        Me.btnAmbienteLibre.Size = New System.Drawing.Size(112, 50)
        Me.btnAmbienteLibre.TabIndex = 68
        Me.btnAmbienteLibre.Text = "Muestras libres"
        Me.btnAmbienteLibre.UseVisualStyleBackColor = True
        Me.btnAmbienteLibre.Visible = False
        '
        'btnRLP
        '
        Me.btnRLP.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnRLP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnRLP.FlatAppearance.BorderSize = 0
        Me.btnRLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRLP.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRLP.Location = New System.Drawing.Point(18, 185)
        Me.btnRLP.Name = "btnRLP"
        Me.btnRLP.Size = New System.Drawing.Size(466, 58)
        Me.btnRLP.TabIndex = 0
        Me.btnRLP.Text = "Estuarios"
        Me.btnRLP.UseVisualStyleBackColor = True
        '
        'btnarroyopamp
        '
        Me.btnarroyopamp.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnarroyopamp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnarroyopamp.FlatAppearance.BorderSize = 0
        Me.btnarroyopamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnarroyopamp.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnarroyopamp.Location = New System.Drawing.Point(18, 57)
        Me.btnarroyopamp.Name = "btnarroyopamp"
        Me.btnarroyopamp.Size = New System.Drawing.Size(466, 58)
        Me.btnarroyopamp.TabIndex = 2
        Me.btnarroyopamp.Text = "Arroyos de llanura"
        Me.btnarroyopamp.UseVisualStyleBackColor = True
        '
        'btnarroyomont
        '
        Me.btnarroyomont.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnarroyomont.Enabled = False
        Me.btnarroyomont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnarroyomont.FlatAppearance.BorderSize = 0
        Me.btnarroyomont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnarroyomont.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnarroyomont.Location = New System.Drawing.Point(18, 121)
        Me.btnarroyomont.Name = "btnarroyomont"
        Me.btnarroyomont.Size = New System.Drawing.Size(466, 58)
        Me.btnarroyomont.TabIndex = 3
        Me.btnarroyomont.Text = "Arroyos de montaña"
        Me.btnarroyomont.UseVisualStyleBackColor = True
        '
        'btnLenitico
        '
        Me.btnLenitico.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnLenitico.Enabled = False
        Me.btnLenitico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnLenitico.FlatAppearance.BorderSize = 0
        Me.btnLenitico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLenitico.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLenitico.Location = New System.Drawing.Point(18, 249)
        Me.btnLenitico.Name = "btnLenitico"
        Me.btnLenitico.Size = New System.Drawing.Size(466, 58)
        Me.btnLenitico.TabIndex = 4
        Me.btnLenitico.Text = "Lagos y lagunas"
        Me.btnLenitico.UseVisualStyleBackColor = True
        '
        'TabPageTipoDatos
        '
        Me.TabPageTipoDatos.BackColor = System.Drawing.Color.White
        Me.TabPageTipoDatos.Controls.Add(Me.btnSiguienteTipoDatos)
        Me.TabPageTipoDatos.Controls.Add(Me.Label5)
        Me.TabPageTipoDatos.Controls.Add(Me.dgvDatosAUsar)
        Me.TabPageTipoDatos.Location = New System.Drawing.Point(1, 30)
        Me.TabPageTipoDatos.Name = "TabPageTipoDatos"
        Me.TabPageTipoDatos.Size = New System.Drawing.Size(492, 552)
        Me.TabPageTipoDatos.TabIndex = 1
        Me.TabPageTipoDatos.TabVisible = False
        Me.TabPageTipoDatos.Text = "Tipo de datos"
        '
        'btnSiguienteTipoDatos
        '
        Me.btnSiguienteTipoDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnSiguienteTipoDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSiguienteTipoDatos.FlatAppearance.BorderSize = 0
        Me.btnSiguienteTipoDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteTipoDatos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteTipoDatos.Image = Global.Scila7.My.Resources.Resources.check59W
        Me.btnSiguienteTipoDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiguienteTipoDatos.Location = New System.Drawing.Point(307, 496)
        Me.btnSiguienteTipoDatos.Name = "btnSiguienteTipoDatos"
        Me.btnSiguienteTipoDatos.Size = New System.Drawing.Size(177, 50)
        Me.btnSiguienteTipoDatos.TabIndex = 71
        Me.btnSiguienteTipoDatos.Text = "    Siguiente"
        Me.btnSiguienteTipoDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSiguienteTipoDatos.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 18)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "¿Qué tipo de datos planea cargar en las muestras?"
        '
        'dgvDatosAUsar
        '
        Me.dgvDatosAUsar.AllowUserToAddRows = False
        Me.dgvDatosAUsar.AllowUserToDeleteRows = False
        Me.dgvDatosAUsar.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatosAUsar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosAUsar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colModulo, Me.colHabilitado})
        Me.dgvDatosAUsar.Location = New System.Drawing.Point(18, 49)
        Me.dgvDatosAUsar.Name = "dgvDatosAUsar"
        Me.dgvDatosAUsar.RowHeadersVisible = False
        Me.dgvDatosAUsar.Size = New System.Drawing.Size(466, 441)
        Me.dgvDatosAUsar.TabIndex = 0
        '
        'colModulo
        '
        Me.colModulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colModulo.HeaderText = "Datos de tipo..."
        Me.colModulo.Name = "colModulo"
        Me.colModulo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colModulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colHabilitado
        '
        Me.colHabilitado.HeaderText = "Si"
        Me.colHabilitado.Name = "colHabilitado"
        '
        'TabPageMuestrasIniciales
        '
        Me.TabPageMuestrasIniciales.BackColor = System.Drawing.Color.White
        Me.TabPageMuestrasIniciales.Controls.Add(Me.dgvMuestrasIniciales)
        Me.TabPageMuestrasIniciales.Controls.Add(Me.btnSiguienteMuestrasIniciales)
        Me.TabPageMuestrasIniciales.Controls.Add(Me.numMuestrasIniciales)
        Me.TabPageMuestrasIniciales.Controls.Add(Me.Label9)
        Me.TabPageMuestrasIniciales.Location = New System.Drawing.Point(1, 30)
        Me.TabPageMuestrasIniciales.Name = "TabPageMuestrasIniciales"
        Me.TabPageMuestrasIniciales.Size = New System.Drawing.Size(492, 552)
        Me.TabPageMuestrasIniciales.TabIndex = 2
        Me.TabPageMuestrasIniciales.TabVisible = False
        Me.TabPageMuestrasIniciales.Text = "Muestras"
        '
        'dgvMuestrasIniciales
        '
        Me.dgvMuestrasIniciales.AllowUserToAddRows = False
        Me.dgvMuestrasIniciales.AllowUserToDeleteRows = False
        Me.dgvMuestrasIniciales.BackgroundColor = System.Drawing.Color.White
        Me.dgvMuestrasIniciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMuestrasIniciales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
        Me.dgvMuestrasIniciales.Location = New System.Drawing.Point(13, 55)
        Me.dgvMuestrasIniciales.Name = "dgvMuestrasIniciales"
        Me.dgvMuestrasIniciales.RowHeadersVisible = False
        Me.dgvMuestrasIniciales.Size = New System.Drawing.Size(471, 435)
        Me.dgvMuestrasIniciales.TabIndex = 186
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre de la muestra"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnSiguienteMuestrasIniciales
        '
        Me.btnSiguienteMuestrasIniciales.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSiguienteMuestrasIniciales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSiguienteMuestrasIniciales.FlatAppearance.BorderSize = 0
        Me.btnSiguienteMuestrasIniciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteMuestrasIniciales.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteMuestrasIniciales.Image = Global.Scila7.My.Resources.Resources.save
        Me.btnSiguienteMuestrasIniciales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiguienteMuestrasIniciales.Location = New System.Drawing.Point(284, 496)
        Me.btnSiguienteMuestrasIniciales.Name = "btnSiguienteMuestrasIniciales"
        Me.btnSiguienteMuestrasIniciales.Size = New System.Drawing.Size(200, 50)
        Me.btnSiguienteMuestrasIniciales.TabIndex = 185
        Me.btnSiguienteMuestrasIniciales.Text = "    Guardar y comenzar "
        Me.btnSiguienteMuestrasIniciales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSiguienteMuestrasIniciales.UseVisualStyleBackColor = True
        '
        'numMuestrasIniciales
        '
        Me.numMuestrasIniciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numMuestrasIniciales.Location = New System.Drawing.Point(322, 13)
        Me.numMuestrasIniciales.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numMuestrasIniciales.Name = "numMuestrasIniciales"
        Me.numMuestrasIniciales.Size = New System.Drawing.Size(120, 26)
        Me.numMuestrasIniciales.TabIndex = 184
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(301, 18)
        Me.Label9.TabIndex = 183
        Me.Label9.Text = "¿Cuántas muestras desea agregar inicialmente?"
        '
        'webDescripcion
        '
        Me.webDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webDescripcion.Location = New System.Drawing.Point(521, -9)
        Me.webDescripcion.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webDescripcion.Name = "webDescripcion"
        Me.webDescripcion.ScrollBarsEnabled = False
        Me.webDescripcion.Size = New System.Drawing.Size(272, 388)
        Me.webDescripcion.TabIndex = 6
        Me.webDescripcion.Visible = False
        '
        'grpDatosNuevo
        '
        Me.grpDatosNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDatosNuevo.BackColor = System.Drawing.Color.Transparent
        Me.grpDatosNuevo.Controls.Add(AmbienteLabel)
        Me.grpDatosNuevo.Controls.Add(Me.txtNuevoAmbiente)
        Me.grpDatosNuevo.Controls.Add(Me.txtDescripcionNuevo)
        Me.grpDatosNuevo.Controls.Add(Label6)
        Me.grpDatosNuevo.Controls.Add(Me.txtAutorNuevo)
        Me.grpDatosNuevo.Controls.Add(Me.txtNombreNuevo)
        Me.grpDatosNuevo.Controls.Add(Me.TextBox4)
        Me.grpDatosNuevo.Controls.Add(Label7)
        Me.grpDatosNuevo.Controls.Add(Me.txtIdProyectoNuevo)
        Me.grpDatosNuevo.Controls.Add(Label8)
        Me.grpDatosNuevo.Controls.Add(Me.IdProyectoTextBox)
        Me.grpDatosNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDatosNuevo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosNuevo.Location = New System.Drawing.Point(521, 385)
        Me.grpDatosNuevo.Name = "grpDatosNuevo"
        Me.grpDatosNuevo.Size = New System.Drawing.Size(272, 208)
        Me.grpDatosNuevo.TabIndex = 63
        Me.grpDatosNuevo.TabStop = False
        Me.grpDatosNuevo.Text = "Datos"
        '
        'txtNuevoAmbiente
        '
        Me.txtNuevoAmbiente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ambiente", True))
        Me.txtNuevoAmbiente.Enabled = False
        Me.txtNuevoAmbiente.Location = New System.Drawing.Point(80, 82)
        Me.txtNuevoAmbiente.Name = "txtNuevoAmbiente"
        Me.txtNuevoAmbiente.Size = New System.Drawing.Size(172, 23)
        Me.txtNuevoAmbiente.TabIndex = 41
        '
        'txtDescripcionNuevo
        '
        Me.txtDescripcionNuevo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Descripcion", True))
        Me.txtDescripcionNuevo.Enabled = False
        Me.txtDescripcionNuevo.Location = New System.Drawing.Point(95, 111)
        Me.txtDescripcionNuevo.Multiline = True
        Me.txtDescripcionNuevo.Name = "txtDescripcionNuevo"
        Me.txtDescripcionNuevo.Size = New System.Drawing.Size(157, 79)
        Me.txtDescripcionNuevo.TabIndex = 40
        '
        'txtAutorNuevo
        '
        Me.txtAutorNuevo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Autor", True))
        Me.txtAutorNuevo.Enabled = False
        Me.txtAutorNuevo.Location = New System.Drawing.Point(80, 52)
        Me.txtAutorNuevo.Name = "txtAutorNuevo"
        Me.txtAutorNuevo.Size = New System.Drawing.Size(172, 23)
        Me.txtAutorNuevo.TabIndex = 38
        '
        'txtNombreNuevo
        '
        Me.txtNombreNuevo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre", True))
        Me.txtNombreNuevo.Enabled = False
        Me.txtNombreNuevo.Location = New System.Drawing.Point(80, 19)
        Me.txtNombreNuevo.Name = "txtNombreNuevo"
        Me.txtNombreNuevo.Size = New System.Drawing.Size(172, 23)
        Me.txtNombreNuevo.TabIndex = 36
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ambiente", True))
        Me.TextBox4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(517, 76)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(56, 21)
        Me.TextBox4.TabIndex = 34
        '
        'txtIdProyectoNuevo
        '
        Me.txtIdProyectoNuevo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "IdProyecto", True))
        Me.txtIdProyectoNuevo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProyectoNuevo.Location = New System.Drawing.Point(196, 169)
        Me.txtIdProyectoNuevo.Name = "txtIdProyectoNuevo"
        Me.txtIdProyectoNuevo.Size = New System.Drawing.Size(56, 21)
        Me.txtIdProyectoNuevo.TabIndex = 25
        '
        'IdProyectoTextBox
        '
        Me.IdProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "IdProyecto", True))
        Me.IdProyectoTextBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProyectoTextBox.Location = New System.Drawing.Point(95, 112)
        Me.IdProyectoTextBox.Name = "IdProyectoTextBox"
        Me.IdProyectoTextBox.Size = New System.Drawing.Size(55, 21)
        Me.IdProyectoTextBox.TabIndex = 42
        '
        'TabDock
        '
        Me.TabDock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabDock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TabDock.Controls.Add(Me.PageNuevoProyecto)
        Me.TabDock.Controls.Add(Me.PageProyectos)
        Me.TabDock.Controls.Add(Me.PageMuestras)
        Me.TabDock.Controls.Add(Me.PageCalculos)
        Me.TabDock.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabDock.ItemSize = New System.Drawing.Size(0, 35)
        Me.TabDock.Location = New System.Drawing.Point(0, 108)
        Me.TabDock.MultiLine = True
        Me.TabDock.Name = "TabDock"
        Me.TabDock.SelectedIndex = 1
        Me.TabDock.Size = New System.Drawing.Size(808, 645)
        Me.TabDock.TabIndex = 65
        Me.TabDock.TabsSpacing = 5
        Me.TabDock.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.TabDock.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
        Me.TabDock.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'PageProyectos
        '
        Me.PageProyectos.BackColor = System.Drawing.Color.White
        Me.PageProyectos.Controls.Add(Me.ProyectosDataGridView)
        Me.PageProyectos.Controls.Add(Me.btnBuscarOrganismos2)
        Me.PageProyectos.Controls.Add(Me.btnSiguienteProyectos)
        Me.PageProyectos.Controls.Add(Me.btnNuevoProyecto)
        Me.PageProyectos.Controls.Add(Me.Label4)
        Me.PageProyectos.Controls.Add(Me.Label2)
        Me.PageProyectos.Controls.Add(Me.grpDatosdelProyecto)
        Me.PageProyectos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageProyectos.Location = New System.Drawing.Point(0, 38)
        Me.PageProyectos.Name = "PageProyectos"
        Me.PageProyectos.Size = New System.Drawing.Size(808, 607)
        Me.PageProyectos.TabIndex = 1
        Me.PageProyectos.Text = "Inicio"
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AllowUserToAddRows = False
        Me.ProyectosDataGridView.AllowUserToDeleteRows = False
        Me.ProyectosDataGridView.AllowUserToResizeColumns = False
        Me.ProyectosDataGridView.AllowUserToResizeRows = False
        Me.ProyectosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        Me.ProyectosDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProyectosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Ambiente, Me.DataGridViewTextBoxColumn6})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        Me.ProyectosDataGridView.GridColor = System.Drawing.Color.Silver
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(25, 146)
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.ReadOnly = True
        Me.ProyectosDataGridView.RowHeadersVisible = False
        Me.ProyectosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(675, 446)
        Me.ProyectosDataGridView.TabIndex = 66
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProyecto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 44
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 62
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Ambiente
        '
        Me.Ambiente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Ambiente.DataPropertyName = "Ambiente"
        Me.Ambiente.HeaderText = "Ambiente"
        Me.Ambiente.Name = "Ambiente"
        Me.Ambiente.ReadOnly = True
        Me.Ambiente.Width = 83
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Provincia"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Provincia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'btnBuscarOrganismos2
        '
        Me.btnBuscarOrganismos2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnBuscarOrganismos2.FlatAppearance.BorderSize = 0
        Me.btnBuscarOrganismos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarOrganismos2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnBuscarOrganismos2.Image = Global.Scila7.My.Resources.Resources.zoom77
        Me.btnBuscarOrganismos2.Location = New System.Drawing.Point(479, 96)
        Me.btnBuscarOrganismos2.Name = "btnBuscarOrganismos2"
        Me.btnBuscarOrganismos2.Size = New System.Drawing.Size(221, 44)
        Me.btnBuscarOrganismos2.TabIndex = 67
        Me.btnBuscarOrganismos2.Text = "Buscar Organismos"
        Me.btnBuscarOrganismos2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarOrganismos2.UseVisualStyleBackColor = True
        '
        'btnSiguienteProyectos
        '
        Me.btnSiguienteProyectos.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSiguienteProyectos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSiguienteProyectos.FlatAppearance.BorderSize = 0
        Me.btnSiguienteProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteProyectos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProyectos.ForeColor = System.Drawing.Color.White
        Me.btnSiguienteProyectos.Image = Global.Scila7.My.Resources.Resources.check59W
        Me.btnSiguienteProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiguienteProyectos.Location = New System.Drawing.Point(252, 96)
        Me.btnSiguienteProyectos.Name = "btnSiguienteProyectos"
        Me.btnSiguienteProyectos.Size = New System.Drawing.Size(221, 44)
        Me.btnSiguienteProyectos.TabIndex = 63
        Me.btnSiguienteProyectos.Text = "  Abrir Proyecto"
        Me.btnSiguienteProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiguienteProyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSiguienteProyectos.UseVisualStyleBackColor = False
        '
        'btnNuevoProyecto
        '
        Me.btnNuevoProyecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnNuevoProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnNuevoProyecto.FlatAppearance.BorderSize = 0
        Me.btnNuevoProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoProyecto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProyecto.ForeColor = System.Drawing.Color.White
        Me.btnNuevoProyecto.Image = Global.Scila7.My.Resources.Resources.add2002
        Me.btnNuevoProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoProyecto.Location = New System.Drawing.Point(25, 96)
        Me.btnNuevoProyecto.Name = "btnNuevoProyecto"
        Me.btnNuevoProyecto.Size = New System.Drawing.Size(221, 44)
        Me.btnNuevoProyecto.TabIndex = 46
        Me.btnNuevoProyecto.Text = "   Nuevo Proyecto"
        Me.btnNuevoProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevoProyecto.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(451, 19)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Para comenzar, agregue un nuevo proyecto, o abra uno ya existente."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 29)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Bienvenido al KARKU"
        '
        'grpDatosdelProyecto
        '
        Me.grpDatosdelProyecto.BackColor = System.Drawing.Color.Transparent
        Me.grpDatosdelProyecto.Controls.Add(AmbienteLabel1)
        Me.grpDatosdelProyecto.Controls.Add(Me.btnGuardarProyecto)
        Me.grpDatosdelProyecto.Controls.Add(Me.AmbienteLabel2)
        Me.grpDatosdelProyecto.Controls.Add(Me.DescripcionTextBox)
        Me.grpDatosdelProyecto.Controls.Add(NombreLabel)
        Me.grpDatosdelProyecto.Controls.Add(Me.AutorTextBox)
        Me.grpDatosdelProyecto.Controls.Add(Me.NombreTextBox)
        Me.grpDatosdelProyecto.Controls.Add(Me.AmbienteTextBox)
        Me.grpDatosdelProyecto.Controls.Add(AutorLabel)
        Me.grpDatosdelProyecto.Controls.Add(DescripcionLabel)
        Me.grpDatosdelProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDatosdelProyecto.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosdelProyecto.Location = New System.Drawing.Point(251, 146)
        Me.grpDatosdelProyecto.Name = "grpDatosdelProyecto"
        Me.grpDatosdelProyecto.Size = New System.Drawing.Size(371, 352)
        Me.grpDatosdelProyecto.TabIndex = 62
        Me.grpDatosdelProyecto.TabStop = False
        Me.grpDatosdelProyecto.Text = "Datos"
        Me.grpDatosdelProyecto.Visible = False
        '
        'btnGuardarProyecto
        '
        Me.btnGuardarProyecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnGuardarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnGuardarProyecto.FlatAppearance.BorderSize = 0
        Me.btnGuardarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarProyecto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarProyecto.ForeColor = System.Drawing.Color.White
        Me.btnGuardarProyecto.Image = Global.Scila7.My.Resources.Resources.save
        Me.btnGuardarProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarProyecto.Location = New System.Drawing.Point(225, 301)
        Me.btnGuardarProyecto.Name = "btnGuardarProyecto"
        Me.btnGuardarProyecto.Size = New System.Drawing.Size(140, 32)
        Me.btnGuardarProyecto.TabIndex = 48
        Me.btnGuardarProyecto.Text = "Guardar Datos"
        Me.btnGuardarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarProyecto.UseVisualStyleBackColor = False
        Me.btnGuardarProyecto.Visible = False
        '
        'AmbienteLabel2
        '
        Me.AmbienteLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ambiente", True))
        Me.AmbienteLabel2.Location = New System.Drawing.Point(242, 77)
        Me.AmbienteLabel2.Name = "AmbienteLabel2"
        Me.AmbienteLabel2.Size = New System.Drawing.Size(118, 23)
        Me.AmbienteLabel2.TabIndex = 41
        Me.AmbienteLabel2.Text = "Label4"
        Me.AmbienteLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Enabled = False
        Me.DescripcionTextBox.Location = New System.Drawing.Point(146, 103)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(219, 192)
        Me.DescripcionTextBox.TabIndex = 40
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Autor", True))
        Me.AutorTextBox.Enabled = False
        Me.AutorTextBox.Location = New System.Drawing.Point(146, 49)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(214, 23)
        Me.AutorTextBox.TabIndex = 38
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(146, 20)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(214, 23)
        Me.NombreTextBox.TabIndex = 36
        '
        'AmbienteTextBox
        '
        Me.AmbienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ambiente", True))
        Me.AmbienteTextBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbienteTextBox.Location = New System.Drawing.Point(146, 105)
        Me.AmbienteTextBox.Name = "AmbienteTextBox"
        Me.AmbienteTextBox.Size = New System.Drawing.Size(56, 21)
        Me.AmbienteTextBox.TabIndex = 34
        '
        'PageCalculos
        '
        Me.PageCalculos.BackColor = System.Drawing.Color.White
        Me.PageCalculos.Controls.Add(Me.btnSeleccionarTodosIndices)
        Me.PageCalculos.Controls.Add(Me.btnVolverAProyectos1)
        Me.PageCalculos.Controls.Add(Me.btnVolverAMuestras)
        Me.PageCalculos.Controls.Add(Me.DataGridView1)
        Me.PageCalculos.Controls.Add(Me.pgbCalculoIndices)
        Me.PageCalculos.Controls.Add(Me.btnCalcularSeleccionados)
        Me.PageCalculos.Controls.Add(Me.TileCalculos)
        Me.PageCalculos.Controls.Add(Me.lblNombre2)
        Me.PageCalculos.Location = New System.Drawing.Point(0, 38)
        Me.PageCalculos.Name = "PageCalculos"
        Me.PageCalculos.Size = New System.Drawing.Size(808, 607)
        Me.PageCalculos.TabIndex = 3
        Me.PageCalculos.TabVisible = False
        Me.PageCalculos.Text = "Calculos"
        '
        'btnSeleccionarTodosIndices
        '
        Me.btnSeleccionarTodosIndices.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarTodosIndices.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSeleccionarTodosIndices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSeleccionarTodosIndices.FlatAppearance.BorderSize = 0
        Me.btnSeleccionarTodosIndices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarTodosIndices.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarTodosIndices.ForeColor = System.Drawing.Color.White
        Me.btnSeleccionarTodosIndices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionarTodosIndices.Location = New System.Drawing.Point(662, 39)
        Me.btnSeleccionarTodosIndices.Name = "btnSeleccionarTodosIndices"
        Me.btnSeleccionarTodosIndices.Size = New System.Drawing.Size(133, 32)
        Me.btnSeleccionarTodosIndices.TabIndex = 176
        Me.btnSeleccionarTodosIndices.Text = "Seleccionar todos"
        Me.btnSeleccionarTodosIndices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionarTodosIndices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSeleccionarTodosIndices.UseVisualStyleBackColor = False
        '
        'btnVolverAProyectos1
        '
        Me.btnVolverAProyectos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnVolverAProyectos1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVolverAProyectos1.FlatAppearance.BorderSize = 0
        Me.btnVolverAProyectos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolverAProyectos1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btnVolverAProyectos1.ForeColor = System.Drawing.Color.White
        Me.btnVolverAProyectos1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolverAProyectos1.Location = New System.Drawing.Point(3, 0)
        Me.btnVolverAProyectos1.Name = "btnVolverAProyectos1"
        Me.btnVolverAProyectos1.Size = New System.Drawing.Size(85, 31)
        Me.btnVolverAProyectos1.TabIndex = 181
        Me.btnVolverAProyectos1.Text = "Proyectos >"
        Me.btnVolverAProyectos1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolverAProyectos1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVolverAProyectos1.UseVisualStyleBackColor = False
        '
        'btnVolverAMuestras
        '
        Me.btnVolverAMuestras.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnVolverAMuestras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnVolverAMuestras.FlatAppearance.BorderSize = 0
        Me.btnVolverAMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolverAMuestras.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btnVolverAMuestras.ForeColor = System.Drawing.Color.White
        Me.btnVolverAMuestras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolverAMuestras.Location = New System.Drawing.Point(94, 0)
        Me.btnVolverAMuestras.Name = "btnVolverAMuestras"
        Me.btnVolverAMuestras.Size = New System.Drawing.Size(79, 31)
        Me.btnVolverAMuestras.TabIndex = 179
        Me.btnVolverAMuestras.Text = "Muestras >"
        Me.btnVolverAMuestras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolverAMuestras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVolverAMuestras.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(748, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(47, 45)
        Me.DataGridView1.TabIndex = 177
        Me.DataGridView1.Visible = False
        '
        'pgbCalculoIndices
        '
        Me.pgbCalculoIndices.Location = New System.Drawing.Point(17, 90)
        Me.pgbCalculoIndices.Name = "pgbCalculoIndices"
        Me.pgbCalculoIndices.Size = New System.Drawing.Size(220, 13)
        Me.pgbCalculoIndices.TabIndex = 176
        Me.pgbCalculoIndices.Visible = False
        '
        'btnCalcularSeleccionados
        '
        Me.btnCalcularSeleccionados.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCalcularSeleccionados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCalcularSeleccionados.FlatAppearance.BorderSize = 0
        Me.btnCalcularSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularSeleccionados.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularSeleccionados.ForeColor = System.Drawing.Color.White
        Me.btnCalcularSeleccionados.Image = Global.Scila7.My.Resources.Resources.calculator7
        Me.btnCalcularSeleccionados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcularSeleccionados.Location = New System.Drawing.Point(17, 40)
        Me.btnCalcularSeleccionados.Name = "btnCalcularSeleccionados"
        Me.btnCalcularSeleccionados.Size = New System.Drawing.Size(218, 44)
        Me.btnCalcularSeleccionados.TabIndex = 175
        Me.btnCalcularSeleccionados.Text = "Calcular seleccionados..."
        Me.btnCalcularSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcularSeleccionados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalcularSeleccionados.UseVisualStyleBackColor = False
        '
        'TileCalculos
        '
        Me.TileCalculos.AllowChecking = True
        Me.TileCalculos.AllowRearranging = True
        Me.TileCalculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TileCalculos.BackColor = System.Drawing.Color.White
        Me.TileCalculos.CellHeight = 60
        Me.TileCalculos.CheckBorderColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TileCalculos.CheckForeColor = System.Drawing.Color.White
        '
        '
        '
        PanelElement4.Alignment = System.Drawing.ContentAlignment.BottomLeft
        PanelElement4.Children.Add(ImageElement4)
        PanelElement4.Children.Add(TextElement8)
        PanelElement4.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.TileCalculos.DefaultTemplate.Elements.Add(PanelElement4)
        Me.TileCalculos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TileCalculos.GroupFont = New System.Drawing.Font("Calibri", 9.75!)
        Me.TileCalculos.GroupForeColor = System.Drawing.Color.Black
        Me.TileCalculos.GroupPadding = New System.Windows.Forms.Padding(0, 40, 20, 20)
        Me.TileCalculos.GroupTextBold = C1.Win.C1Tile.ThreeStateBoolean.[False]
        Me.TileCalculos.GroupTextSize = 16.0!
        Me.TileCalculos.GroupTextX = 0
        Me.TileCalculos.HotBorderColor = System.Drawing.Color.Gray
        Me.TileCalculos.Location = New System.Drawing.Point(14, 40)
        Me.TileCalculos.Name = "TileCalculos"
        Me.TileCalculos.Orientation = C1.Win.C1Tile.LayoutOrientation.Vertical
        Me.TileCalculos.Size = New System.Drawing.Size(781, 552)
        Me.TileCalculos.TabIndex = 0
        Me.TileCalculos.Templates.Add(Me.TemplateTiles)
        Me.TileCalculos.Templates.Add(Me.TemplateTileSmall)
        Me.TileCalculos.TextSize = 18.0!
        Me.TileCalculos.TextX = 13
        Me.TileCalculos.TextY = 10
        Me.TileCalculos.TileBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TileCalculos.TileBorderColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TileCalculos.UncheckTilesOnClick = False
        '
        'TemplateTiles
        '
        Me.TemplateTiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TemplateTiles.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
        Me.TemplateTiles.Description = "Template for the Tiles"
        TextElement9.Alignment = System.Drawing.ContentAlignment.TopLeft
        TextElement9.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
        TextElement9.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextElement9.ForeColor = System.Drawing.Color.White
        TextElement9.ForeColorSelector = C1.Win.C1Tile.ForeColorSelector.Unbound
        TextElement9.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        TextElement9.SingleLine = True
        TextElement10.Alignment = System.Drawing.ContentAlignment.BottomLeft
        TextElement10.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
        TextElement10.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
        TextElement10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextElement10.ForeColor = System.Drawing.Color.Black
        TextElement10.ForeColorSelector = C1.Win.C1Tile.ForeColorSelector.Unbound
        TextElement10.Margin = New System.Windows.Forms.Padding(12, 0, 0, 5)
        TextElement10.TextSelector = C1.Win.C1Tile.TextSelector.Text1
        Me.TemplateTiles.Elements.Add(TextElement9)
        Me.TemplateTiles.Elements.Add(TextElement10)
        Me.TemplateTiles.Name = "TemplateTiles"
        '
        'TemplateTileSmall
        '
        Me.TemplateTileSmall.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TemplateTileSmall.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
        Me.TemplateTileSmall.Description = "Template for when the title is too big"
        TextElement11.Alignment = System.Drawing.ContentAlignment.TopLeft
        TextElement11.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
        TextElement11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextElement11.ForeColor = System.Drawing.Color.White
        TextElement11.ForeColorSelector = C1.Win.C1Tile.ForeColorSelector.Unbound
        TextElement11.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        TextElement11.SingleLine = True
        TextElement12.Alignment = System.Drawing.ContentAlignment.BottomLeft
        TextElement12.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
        TextElement12.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
        TextElement12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextElement12.ForeColor = System.Drawing.Color.Black
        TextElement12.ForeColorSelector = C1.Win.C1Tile.ForeColorSelector.Unbound
        TextElement12.Margin = New System.Windows.Forms.Padding(12, 0, 0, 5)
        TextElement12.TextSelector = C1.Win.C1Tile.TextSelector.Text1
        Me.TemplateTileSmall.Elements.Add(TextElement11)
        Me.TemplateTileSmall.Elements.Add(TextElement12)
        Me.TemplateTileSmall.Name = "TemplateTileSmall"
        '
        'lblNombre2
        '
        Me.lblNombre2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblNombre2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre", True))
        Me.lblNombre2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNombre2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.ForeColor = System.Drawing.Color.White
        Me.lblNombre2.Location = New System.Drawing.Point(0, 0)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(808, 31)
        Me.lblNombre2.TabIndex = 180
        Me.lblNombre2.Text = "Label1"
        Me.lblNombre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Scila7.My.Resources.Resources.logoKerku
        Me.PictureBox2.Location = New System.Drawing.Point(12, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(303, 51)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(483, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Registrado a:"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoPictureBox.Location = New System.Drawing.Point(726, 27)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(71, 75)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 67
        Me.LogoPictureBox.TabStop = False
        '
        'DropDownItem1
        '
        Me.DropDownItem1.Text = "DropDownItem1"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 750)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TabDock)
        Me.Controls.Add(Me.EmpresaLabel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARKU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitiosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageMuestras.ResumeLayout(False)
        Me.PageMuestras.PerformLayout()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAgregarMuestra.ResumeLayout(False)
        Me.grpAgregarMuestra.PerformLayout()
        CType(Me.dgvMultiplesMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAddMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDSitios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageNuevoProyecto.ResumeLayout(False)
        CType(Me.tabNuevoProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNuevoProyecto.ResumeLayout(False)
        Me.TabPageTipoAmbiente.ResumeLayout(False)
        Me.TabPageTipoAmbiente.PerformLayout()
        Me.TabPageTipoDatos.ResumeLayout(False)
        Me.TabPageTipoDatos.PerformLayout()
        CType(Me.dgvDatosAUsar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMuestrasIniciales.ResumeLayout(False)
        Me.TabPageMuestrasIniciales.PerformLayout()
        CType(Me.dgvMuestrasIniciales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMuestrasIniciales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosNuevo.ResumeLayout(False)
        Me.grpDatosNuevo.PerformLayout()
        CType(Me.TabDock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDock.ResumeLayout(False)
        Me.PageProyectos.ResumeLayout(False)
        Me.PageProyectos.PerformLayout()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosdelProyecto.ResumeLayout(False)
        Me.grpDatosdelProyecto.PerformLayout()
        Me.PageCalculos.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ConfigTableAdapter As Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents EmpresaLabel1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnciclopediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerfilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DBOrganismosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SitiosDataSet As Scila7.sitiosDataSet
    Friend WithEvents SitiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SitiosTableAdapter As Scila7.sitiosDataSetTableAdapters.SitiosTableAdapter
    Friend WithEvents TabDock As C1.Win.C1Command.C1DockingTab
    Friend WithEvents PageNuevoProyecto As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents grpDatosNuevo As System.Windows.Forms.GroupBox
    Friend WithEvents txtNuevoAmbiente As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtAutorNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreNuevo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents txtIdProyectoNuevo As System.Windows.Forms.TextBox
    Protected Friend WithEvents webDescripcion As System.Windows.Forms.WebBrowser
    Friend WithEvents btnLenitico As C1.Win.C1Input.C1Button
    Friend WithEvents btnarroyopamp As C1.Win.C1Input.C1Button
    Friend WithEvents btnarroyomont As C1.Win.C1Input.C1Button
    Friend WithEvents btnRLP As C1.Win.C1Input.C1Button
    Friend WithEvents PageMuestras As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NombreLabel2 As System.Windows.Forms.Label
    Friend WithEvents btnNuevaMuestra As System.Windows.Forms.Button
    Friend WithEvents btnGuardarMuestra As System.Windows.Forms.Button
    Friend WithEvents grpAgregarMuestra As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditarSitios As System.Windows.Forms.Button
    Friend WithEvents PageProyectos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpDatosdelProyecto As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardarProyecto As System.Windows.Forms.Button
    Friend WithEvents AmbienteLabel2 As System.Windows.Forms.Label
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmbienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSiguienteProyectos As System.Windows.Forms.Button
    Friend WithEvents btnNuevoProyecto As System.Windows.Forms.Button
    Friend WithEvents MódulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnVolverAProyectos As System.Windows.Forms.Button
    Friend WithEvents TileMuestras As C1.Win.C1Tile.C1TileControl
    Friend WithEvents btnExportarDatos As System.Windows.Forms.Button
    Friend WithEvents btnImportarDatos As System.Windows.Forms.Button
    Friend WithEvents EditorDeParámetrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCancelarNuevaMuestra As System.Windows.Forms.Button
    Friend WithEvents btnAgregarMultiples As System.Windows.Forms.Button
    Friend WithEvents lblNombreMuestra As System.Windows.Forms.Label
    Friend WithEvents lblCodigoSitio As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtFechaMuestra As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombreMuestra As System.Windows.Forms.TextBox
    Friend WithEvents dgvMultiplesMuestras As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DDSitios As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents dgvDatosAUsar As System.Windows.Forms.DataGridView
    Friend WithEvents colModulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHabilitado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnSiguienteTipoAmbiente As C1.Win.C1Input.C1Button
    Friend WithEvents btnAmbienteLibre As C1.Win.C1Input.C1Button
    Friend WithEvents tabNuevoProyecto As C1.Win.C1Command.C1DockingTab
    Friend WithEvents TabPageTipoAmbiente As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPageTipoDatos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents TabPageMuestrasIniciales As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSiguienteTipoDatos As C1.Win.C1Input.C1Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents numMuestrasIniciales As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSiguienteMuestrasIniciales As C1.Win.C1Input.C1Button
    Friend WithEvents dgvMuestrasIniciales As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PageCalculos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents TileCalculos As C1.Win.C1Tile.C1TileControl
    Friend WithEvents btnCalcularIndices As System.Windows.Forms.Button
    Friend WithEvents btnCalcularSeleccionados As System.Windows.Forms.Button
    Friend WithEvents pgbCalculoIndices As System.Windows.Forms.ProgressBar
    Friend WithEvents CodigoSitioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents txtCoordLONG As System.Windows.Forms.TextBox
    Friend WithEvents txtCoordLAT As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoSitio As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolverAMuestras As System.Windows.Forms.Button
    Friend WithEvents lblNombre2 As System.Windows.Forms.Label
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversorDeUnidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÓptimosYToleranciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VaciarProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents EditorDeÍndicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemplateTiles As C1.Win.C1Tile.Template
    Friend WithEvents TemplateTileSmall As C1.Win.C1Tile.Template
    Friend WithEvents btnVolverAProyectos1 As System.Windows.Forms.Button
    Friend WithEvents IdProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ambiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdMuestra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoSitio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Autor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscarOrganismos2 As C1.Win.C1Input.C1SplitButton
    Friend WithEvents DropDownItem1 As C1.Win.C1Input.DropDownItem
    Friend WithEvents Group1 As C1.Win.C1Tile.Group
    Friend WithEvents btnSeleccionarTodosIndices As System.Windows.Forms.Button
    Friend WithEvents lblAddMuestras As System.Windows.Forms.Label
    Friend WithEvents numAddMuestras As System.Windows.Forms.NumericUpDown
End Class
