<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuestrasRLP
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
        Dim IdMuestraLabel As System.Windows.Forms.Label
        Dim IdProyectoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CodigoSitioLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim FQpHLabel As System.Windows.Forms.Label
        Dim FQTempLabel As System.Windows.Forms.Label
        Dim FQCondLabel As System.Windows.Forms.Label
        Dim FQTurbLabel As System.Windows.Forms.Label
        Dim FQCaudalLabel As System.Windows.Forms.Label
        Dim FQODLabel As System.Windows.Forms.Label
        Dim FQNitratosLabel As System.Windows.Forms.Label
        Dim FQNitritosLabel As System.Windows.Forms.Label
        Dim FQAmonioLabel As System.Windows.Forms.Label
        Dim FQFosfatoLabel As System.Windows.Forms.Label
        Dim ClorofilaALabel As System.Windows.Forms.Label
        Dim MateriaOrganicaLabel As System.Windows.Forms.Label
        Dim CianoDensidadLabel As System.Windows.Forms.Label
        Dim DiatoDensidadLabel As System.Windows.Forms.Label
        Dim EcoliLabel As System.Windows.Forms.Label
        Dim OlorLabel As System.Windows.Forms.Label
        Dim ConectividadLabel As System.Windows.Forms.Label
        Dim NaturalidadLabel As System.Windows.Forms.Label
        Dim DivBasuraLabel As System.Windows.Forms.Label
        Dim IndiceLabel As System.Windows.Forms.Label
        Dim FQBODLabel As System.Windows.Forms.Label
        Dim FitoTotalLabel As System.Windows.Forms.Label
        Dim TanaidsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMuestrasRLP))
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet
        Me.IdMuestraTextBox = New System.Windows.Forms.TextBox
        Me.IdProyectoTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.CodigoSitioTextBox = New System.Windows.Forms.TextBox
        Me.AutorTextBox = New System.Windows.Forms.TextBox
        Me.FQpHTextBox = New System.Windows.Forms.TextBox
        Me.FQTempTextBox = New System.Windows.Forms.TextBox
        Me.FQCondTextBox = New System.Windows.Forms.TextBox
        Me.FQTurbTextBox = New System.Windows.Forms.TextBox
        Me.FQCaudalTextBox = New System.Windows.Forms.TextBox
        Me.FQODTextBox = New System.Windows.Forms.TextBox
        Me.FQNitratosTextBox = New System.Windows.Forms.TextBox
        Me.FQNitritosTextBox = New System.Windows.Forms.TextBox
        Me.FQAmonioTextBox = New System.Windows.Forms.TextBox
        Me.FQFosfatoTextBox = New System.Windows.Forms.TextBox
        Me.MateriaOrganicaTextBox = New System.Windows.Forms.TextBox
        Me.CianoDensidadTextBox = New System.Windows.Forms.TextBox
        Me.DiatoDensidadTextBox = New System.Windows.Forms.TextBox
        Me.EcoliTextBox = New System.Windows.Forms.TextBox
        Me.MuestrasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.grpMuestra = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FQBODTextBox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ClorofilaATextBox = New System.Windows.Forms.TextBox
        Me.DivBasuraComboBox = New System.Windows.Forms.ComboBox
        Me.NaturalidadComboBox = New System.Windows.Forms.ComboBox
        Me.ConectividadComboBox = New System.Windows.Forms.ComboBox
        Me.OlorComboBox = New System.Windows.Forms.ComboBox
        Me.IMRPlataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpIndices = New System.Windows.Forms.GroupBox
        Me.IBIDPlataTextBox = New System.Windows.Forms.TextBox
        Me.btnCalcularIBIDPlata = New C1.Win.C1Input.C1Button
        Me.IEcoPlataSignifica = New System.Windows.Forms.Button
        Me.btnReporte = New C1.Win.C1Input.C1Button
        Me.tmrCheckIndices = New System.Windows.Forms.Timer(Me.components)
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
        Me.TableAdapterManager = New Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
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
        Me.ComboBox15 = New System.Windows.Forms.ComboBox
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.C1OutPage2 = New C1.Win.C1Command.C1OutPage
        Me.C1OutPage3 = New C1.Win.C1Command.C1OutPage
        Me.C1OutPage4 = New C1.Win.C1Command.C1OutPage
        Me.Label16 = New System.Windows.Forms.Label
        Me.IBPAMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EutrofizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1DockingTab2 = New C1.Win.C1Command.C1DockingTab
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage
        Me.C1Button3 = New C1.Win.C1Input.C1Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtEstadoHabitatExplain = New System.Windows.Forms.RichTextBox
        Me.txtEstadoHabitat = New System.Windows.Forms.TextBox
        Me.progHabitatGeneral = New System.Windows.Forms.ProgressBar
        Me.C1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtEstadoFQExplain = New System.Windows.Forms.RichTextBox
        Me.txtEstadoFQ = New System.Windows.Forms.TextBox
        Me.progEstadoFQ = New System.Windows.Forms.ProgressBar
        Me.C1DockingTabPage6 = New C1.Win.C1Command.C1DockingTabPage
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TanaidsTextBox = New System.Windows.Forms.TextBox
        Me.FitoTotalTextBox = New System.Windows.Forms.TextBox
        Me.ConfigDataSet = New Scila7.ConfigDataSet
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigTableAdapter = New Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
        Me.TableAdapterManager1 = New Scila7.ConfigDataSetTableAdapters.TableAdapterManager
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirAWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnciclopediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        IdMuestraLabel = New System.Windows.Forms.Label
        IdProyectoLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        CodigoSitioLabel = New System.Windows.Forms.Label
        AutorLabel = New System.Windows.Forms.Label
        FQpHLabel = New System.Windows.Forms.Label
        FQTempLabel = New System.Windows.Forms.Label
        FQCondLabel = New System.Windows.Forms.Label
        FQTurbLabel = New System.Windows.Forms.Label
        FQCaudalLabel = New System.Windows.Forms.Label
        FQODLabel = New System.Windows.Forms.Label
        FQNitratosLabel = New System.Windows.Forms.Label
        FQNitritosLabel = New System.Windows.Forms.Label
        FQAmonioLabel = New System.Windows.Forms.Label
        FQFosfatoLabel = New System.Windows.Forms.Label
        ClorofilaALabel = New System.Windows.Forms.Label
        MateriaOrganicaLabel = New System.Windows.Forms.Label
        CianoDensidadLabel = New System.Windows.Forms.Label
        DiatoDensidadLabel = New System.Windows.Forms.Label
        EcoliLabel = New System.Windows.Forms.Label
        OlorLabel = New System.Windows.Forms.Label
        ConectividadLabel = New System.Windows.Forms.Label
        NaturalidadLabel = New System.Windows.Forms.Label
        DivBasuraLabel = New System.Windows.Forms.Label
        IndiceLabel = New System.Windows.Forms.Label
        FQBODLabel = New System.Windows.Forms.Label
        FitoTotalLabel = New System.Windows.Forms.Label
        TanaidsLabel = New System.Windows.Forms.Label
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        Me.grpMuestra.SuspendLayout()
        CType(Me.IMRPlataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIndices.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EutrofizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab2.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.C1DockingTabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.C1DockingTabPage6.SuspendLayout()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdMuestraLabel
        '
        IdMuestraLabel.AutoSize = True
        IdMuestraLabel.Font = New System.Drawing.Font("Calibri", 9.0!)
        IdMuestraLabel.Location = New System.Drawing.Point(25, 28)
        IdMuestraLabel.Name = "IdMuestraLabel"
        IdMuestraLabel.Size = New System.Drawing.Size(69, 14)
        IdMuestraLabel.TabIndex = 0
        IdMuestraLabel.Text = "Id Muestra:"
        '
        'IdProyectoLabel
        '
        IdProyectoLabel.AutoSize = True
        IdProyectoLabel.Font = New System.Drawing.Font("Calibri", 9.0!)
        IdProyectoLabel.Location = New System.Drawing.Point(350, 26)
        IdProyectoLabel.Name = "IdProyectoLabel"
        IdProyectoLabel.Size = New System.Drawing.Size(69, 14)
        IdProyectoLabel.TabIndex = 2
        IdProyectoLabel.Text = "Id Proyecto:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Calibri", 9.0!)
        NombreLabel.Location = New System.Drawing.Point(25, 54)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(53, 14)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Calibri", 9.0!)
        FechaLabel.Location = New System.Drawing.Point(25, 81)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(42, 14)
        FechaLabel.TabIndex = 6
        FechaLabel.Text = "Fecha:"
        '
        'CodigoSitioLabel
        '
        CodigoSitioLabel.AutoSize = True
        CodigoSitioLabel.Font = New System.Drawing.Font("Calibri", 9.0!)
        CodigoSitioLabel.Location = New System.Drawing.Point(25, 106)
        CodigoSitioLabel.Name = "CodigoSitioLabel"
        CodigoSitioLabel.Size = New System.Drawing.Size(74, 14)
        CodigoSitioLabel.TabIndex = 8
        CodigoSitioLabel.Text = "Codigo Sitio:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Font = New System.Drawing.Font("Calibri", 9.0!)
        AutorLabel.Location = New System.Drawing.Point(25, 132)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(39, 14)
        AutorLabel.TabIndex = 10
        AutorLabel.Text = "Autor:"
        '
        'FQpHLabel
        '
        FQpHLabel.AutoSize = True
        FQpHLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQpHLabel.Location = New System.Drawing.Point(19, 22)
        FQpHLabel.Name = "FQpHLabel"
        FQpHLabel.Size = New System.Drawing.Size(28, 17)
        FQpHLabel.TabIndex = 12
        FQpHLabel.Text = "pH:"
        '
        'FQTempLabel
        '
        FQTempLabel.AutoSize = True
        FQTempLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQTempLabel.Location = New System.Drawing.Point(19, 48)
        FQTempLabel.Name = "FQTempLabel"
        FQTempLabel.Size = New System.Drawing.Size(86, 17)
        FQTempLabel.TabIndex = 14
        FQTempLabel.Text = "Temperatura:"
        '
        'FQCondLabel
        '
        FQCondLabel.AutoSize = True
        FQCondLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQCondLabel.Location = New System.Drawing.Point(19, 74)
        FQCondLabel.Name = "FQCondLabel"
        FQCondLabel.Size = New System.Drawing.Size(91, 17)
        FQCondLabel.TabIndex = 16
        FQCondLabel.Text = "Conductividad:"
        '
        'FQTurbLabel
        '
        FQTurbLabel.AutoSize = True
        FQTurbLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQTurbLabel.Location = New System.Drawing.Point(19, 100)
        FQTurbLabel.Name = "FQTurbLabel"
        FQTurbLabel.Size = New System.Drawing.Size(60, 17)
        FQTurbLabel.TabIndex = 18
        FQTurbLabel.Text = "Turbidez:"
        '
        'FQCaudalLabel
        '
        FQCaudalLabel.AutoSize = True
        FQCaudalLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQCaudalLabel.Location = New System.Drawing.Point(19, 126)
        FQCaudalLabel.Name = "FQCaudalLabel"
        FQCaudalLabel.Size = New System.Drawing.Size(50, 17)
        FQCaudalLabel.TabIndex = 20
        FQCaudalLabel.Text = "Caudal:"
        '
        'FQODLabel
        '
        FQODLabel.AutoSize = True
        FQODLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQODLabel.Location = New System.Drawing.Point(19, 154)
        FQODLabel.Name = "FQODLabel"
        FQODLabel.Size = New System.Drawing.Size(107, 17)
        FQODLabel.TabIndex = 22
        FQODLabel.Text = "Oxígeno Disuelto:"
        '
        'FQNitratosLabel
        '
        FQNitratosLabel.AutoSize = True
        FQNitratosLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQNitratosLabel.Location = New System.Drawing.Point(266, 22)
        FQNitratosLabel.Name = "FQNitratosLabel"
        FQNitratosLabel.Size = New System.Drawing.Size(58, 17)
        FQNitratosLabel.TabIndex = 24
        FQNitratosLabel.Text = "Nitratos:"
        '
        'FQNitritosLabel
        '
        FQNitritosLabel.AutoSize = True
        FQNitritosLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQNitritosLabel.Location = New System.Drawing.Point(266, 48)
        FQNitritosLabel.Name = "FQNitritosLabel"
        FQNitritosLabel.Size = New System.Drawing.Size(54, 17)
        FQNitritosLabel.TabIndex = 26
        FQNitritosLabel.Text = "Nitritos:"
        '
        'FQAmonioLabel
        '
        FQAmonioLabel.AutoSize = True
        FQAmonioLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQAmonioLabel.Location = New System.Drawing.Point(266, 73)
        FQAmonioLabel.Name = "FQAmonioLabel"
        FQAmonioLabel.Size = New System.Drawing.Size(55, 17)
        FQAmonioLabel.TabIndex = 28
        FQAmonioLabel.Text = "Amonio:"
        '
        'FQFosfatoLabel
        '
        FQFosfatoLabel.AutoSize = True
        FQFosfatoLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQFosfatoLabel.Location = New System.Drawing.Point(266, 99)
        FQFosfatoLabel.Name = "FQFosfatoLabel"
        FQFosfatoLabel.Size = New System.Drawing.Size(53, 17)
        FQFosfatoLabel.TabIndex = 30
        FQFosfatoLabel.Text = "Fosfato:"
        '
        'ClorofilaALabel
        '
        ClorofilaALabel.AutoSize = True
        ClorofilaALabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        ClorofilaALabel.Location = New System.Drawing.Point(23, 32)
        ClorofilaALabel.Name = "ClorofilaALabel"
        ClorofilaALabel.Size = New System.Drawing.Size(80, 17)
        ClorofilaALabel.TabIndex = 32
        ClorofilaALabel.Text = "Clorofila ""a"":"
        '
        'MateriaOrganicaLabel
        '
        MateriaOrganicaLabel.AutoSize = True
        MateriaOrganicaLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        MateriaOrganicaLabel.Location = New System.Drawing.Point(23, 60)
        MateriaOrganicaLabel.Name = "MateriaOrganicaLabel"
        MateriaOrganicaLabel.Size = New System.Drawing.Size(112, 17)
        MateriaOrganicaLabel.TabIndex = 34
        MateriaOrganicaLabel.Text = "Materia Orgánica:"
        '
        'CianoDensidadLabel
        '
        CianoDensidadLabel.AutoSize = True
        CianoDensidadLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        CianoDensidadLabel.Location = New System.Drawing.Point(23, 86)
        CianoDensidadLabel.Name = "CianoDensidadLabel"
        CianoDensidadLabel.Size = New System.Drawing.Size(167, 17)
        CianoDensidadLabel.TabIndex = 36
        CianoDensidadLabel.Text = "Densidad de Cianobacterias:"
        '
        'DiatoDensidadLabel
        '
        DiatoDensidadLabel.AutoSize = True
        DiatoDensidadLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        DiatoDensidadLabel.Location = New System.Drawing.Point(23, 112)
        DiatoDensidadLabel.Name = "DiatoDensidadLabel"
        DiatoDensidadLabel.Size = New System.Drawing.Size(163, 17)
        DiatoDensidadLabel.TabIndex = 38
        DiatoDensidadLabel.Text = "Diatomeas Muy Tolerantes:"
        '
        'EcoliLabel
        '
        EcoliLabel.AutoSize = True
        EcoliLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        EcoliLabel.Location = New System.Drawing.Point(23, 137)
        EcoliLabel.Name = "EcoliLabel"
        EcoliLabel.Size = New System.Drawing.Size(43, 17)
        EcoliLabel.TabIndex = 40
        EcoliLabel.Text = "E.Coli:"
        '
        'OlorLabel
        '
        OlorLabel.AutoSize = True
        OlorLabel.BackColor = System.Drawing.Color.Transparent
        OlorLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        OlorLabel.Location = New System.Drawing.Point(27, 26)
        OlorLabel.Name = "OlorLabel"
        OlorLabel.Size = New System.Drawing.Size(36, 17)
        OlorLabel.TabIndex = 42
        OlorLabel.Text = "Olor:"
        '
        'ConectividadLabel
        '
        ConectividadLabel.AutoSize = True
        ConectividadLabel.BackColor = System.Drawing.Color.Transparent
        ConectividadLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        ConectividadLabel.Location = New System.Drawing.Point(27, 66)
        ConectividadLabel.Name = "ConectividadLabel"
        ConectividadLabel.Size = New System.Drawing.Size(88, 17)
        ConectividadLabel.TabIndex = 44
        ConectividadLabel.Text = "Hábitat Físico:"
        '
        'NaturalidadLabel
        '
        NaturalidadLabel.AutoSize = True
        NaturalidadLabel.BackColor = System.Drawing.Color.Transparent
        NaturalidadLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        NaturalidadLabel.Location = New System.Drawing.Point(27, 106)
        NaturalidadLabel.Name = "NaturalidadLabel"
        NaturalidadLabel.Size = New System.Drawing.Size(129, 17)
        NaturalidadLabel.TabIndex = 46
        NaturalidadLabel.Text = "Vegetación de ribera:"
        '
        'DivBasuraLabel
        '
        DivBasuraLabel.AutoSize = True
        DivBasuraLabel.BackColor = System.Drawing.Color.Transparent
        DivBasuraLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        DivBasuraLabel.Location = New System.Drawing.Point(27, 144)
        DivBasuraLabel.Name = "DivBasuraLabel"
        DivBasuraLabel.Size = New System.Drawing.Size(129, 17)
        DivBasuraLabel.TabIndex = 50
        DivBasuraLabel.Text = "Diversidad de basura:"
        '
        'IndiceLabel
        '
        IndiceLabel.AutoSize = True
        IndiceLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndiceLabel.Location = New System.Drawing.Point(12, 36)
        IndiceLabel.Name = "IndiceLabel"
        IndiceLabel.Size = New System.Drawing.Size(66, 13)
        IndiceLabel.TabIndex = 62
        IndiceLabel.Text = "IBIRPlata:"
        '
        'FQBODLabel
        '
        FQBODLabel.AutoSize = True
        FQBODLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        FQBODLabel.Location = New System.Drawing.Point(19, 182)
        FQBODLabel.Name = "FQBODLabel"
        FQBODLabel.Size = New System.Drawing.Size(38, 17)
        FQBODLabel.TabIndex = 66
        FQBODLabel.Text = "DBO:"
        '
        'FitoTotalLabel
        '
        FitoTotalLabel.AutoSize = True
        FitoTotalLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FitoTotalLabel.Location = New System.Drawing.Point(23, 165)
        FitoTotalLabel.Name = "FitoTotalLabel"
        FitoTotalLabel.Size = New System.Drawing.Size(112, 17)
        FitoTotalLabel.TabIndex = 86
        FitoTotalLabel.Text = "Fitoplancton total:"
        '
        'TanaidsLabel
        '
        TanaidsLabel.AutoSize = True
        TanaidsLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TanaidsLabel.Location = New System.Drawing.Point(24, 191)
        TanaidsLabel.Name = "TanaidsLabel"
        TanaidsLabel.Size = New System.Drawing.Size(94, 17)
        TanaidsLabel.TabIndex = 87
        TanaidsLabel.Text = "% Tanaidáceos:"
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
        'IdMuestraTextBox
        '
        Me.IdMuestraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IdMuestra", True))
        Me.IdMuestraTextBox.Enabled = False
        Me.IdMuestraTextBox.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.IdMuestraTextBox.Location = New System.Drawing.Point(125, 23)
        Me.IdMuestraTextBox.Name = "IdMuestraTextBox"
        Me.IdMuestraTextBox.Size = New System.Drawing.Size(27, 22)
        Me.IdMuestraTextBox.TabIndex = 1
        Me.IdMuestraTextBox.TabStop = False
        '
        'IdProyectoTextBox
        '
        Me.IdProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IdProyecto", True))
        Me.IdProyectoTextBox.Enabled = False
        Me.IdProyectoTextBox.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.IdProyectoTextBox.Location = New System.Drawing.Point(447, 23)
        Me.IdProyectoTextBox.Name = "IdProyectoTextBox"
        Me.IdProyectoTextBox.Size = New System.Drawing.Size(27, 22)
        Me.IdProyectoTextBox.TabIndex = 3
        Me.IdProyectoTextBox.TabStop = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(125, 49)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NombreTextBox.TabIndex = 5
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MuestrasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(125, 75)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.FechaDateTimePicker.TabIndex = 7
        '
        'CodigoSitioTextBox
        '
        Me.CodigoSitioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "CodigoSitio", True))
        Me.CodigoSitioTextBox.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.CodigoSitioTextBox.Location = New System.Drawing.Point(125, 101)
        Me.CodigoSitioTextBox.Name = "CodigoSitioTextBox"
        Me.CodigoSitioTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CodigoSitioTextBox.TabIndex = 9
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Autor", True))
        Me.AutorTextBox.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.AutorTextBox.Location = New System.Drawing.Point(125, 127)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AutorTextBox.TabIndex = 11
        '
        'FQpHTextBox
        '
        Me.FQpHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQpH", True))
        Me.FQpHTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQpHTextBox.Location = New System.Drawing.Point(142, 14)
        Me.FQpHTextBox.Name = "FQpHTextBox"
        Me.FQpHTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQpHTextBox.TabIndex = 13
        '
        'FQTempTextBox
        '
        Me.FQTempTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQTemp", True))
        Me.FQTempTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQTempTextBox.Location = New System.Drawing.Point(142, 40)
        Me.FQTempTextBox.Name = "FQTempTextBox"
        Me.FQTempTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQTempTextBox.TabIndex = 15
        '
        'FQCondTextBox
        '
        Me.FQCondTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQCond", True))
        Me.FQCondTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQCondTextBox.Location = New System.Drawing.Point(142, 66)
        Me.FQCondTextBox.Name = "FQCondTextBox"
        Me.FQCondTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQCondTextBox.TabIndex = 17
        '
        'FQTurbTextBox
        '
        Me.FQTurbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQTurb", True))
        Me.FQTurbTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQTurbTextBox.Location = New System.Drawing.Point(142, 92)
        Me.FQTurbTextBox.Name = "FQTurbTextBox"
        Me.FQTurbTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQTurbTextBox.TabIndex = 19
        '
        'FQCaudalTextBox
        '
        Me.FQCaudalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQCaudal", True))
        Me.FQCaudalTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQCaudalTextBox.Location = New System.Drawing.Point(142, 118)
        Me.FQCaudalTextBox.Name = "FQCaudalTextBox"
        Me.FQCaudalTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQCaudalTextBox.TabIndex = 21
        '
        'FQODTextBox
        '
        Me.FQODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQOD", True))
        Me.FQODTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQODTextBox.Location = New System.Drawing.Point(142, 146)
        Me.FQODTextBox.Name = "FQODTextBox"
        Me.FQODTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQODTextBox.TabIndex = 23
        '
        'FQNitratosTextBox
        '
        Me.FQNitratosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQNitratos", True))
        Me.FQNitratosTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQNitratosTextBox.Location = New System.Drawing.Point(342, 18)
        Me.FQNitratosTextBox.Name = "FQNitratosTextBox"
        Me.FQNitratosTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQNitratosTextBox.TabIndex = 25
        '
        'FQNitritosTextBox
        '
        Me.FQNitritosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQNitritos", True))
        Me.FQNitritosTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQNitritosTextBox.Location = New System.Drawing.Point(342, 44)
        Me.FQNitritosTextBox.Name = "FQNitritosTextBox"
        Me.FQNitritosTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQNitritosTextBox.TabIndex = 27
        '
        'FQAmonioTextBox
        '
        Me.FQAmonioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQAmonio", True))
        Me.FQAmonioTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQAmonioTextBox.Location = New System.Drawing.Point(342, 69)
        Me.FQAmonioTextBox.Name = "FQAmonioTextBox"
        Me.FQAmonioTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQAmonioTextBox.TabIndex = 29
        '
        'FQFosfatoTextBox
        '
        Me.FQFosfatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQFosfato", True))
        Me.FQFosfatoTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQFosfatoTextBox.Location = New System.Drawing.Point(342, 95)
        Me.FQFosfatoTextBox.Name = "FQFosfatoTextBox"
        Me.FQFosfatoTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQFosfatoTextBox.TabIndex = 31
        '
        'MateriaOrganicaTextBox
        '
        Me.MateriaOrganicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "MateriaOrganica", True))
        Me.MateriaOrganicaTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.MateriaOrganicaTextBox.Location = New System.Drawing.Point(199, 56)
        Me.MateriaOrganicaTextBox.Name = "MateriaOrganicaTextBox"
        Me.MateriaOrganicaTextBox.Size = New System.Drawing.Size(45, 24)
        Me.MateriaOrganicaTextBox.TabIndex = 35
        '
        'CianoDensidadTextBox
        '
        Me.CianoDensidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "CianoDensidad", True))
        Me.CianoDensidadTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CianoDensidadTextBox.Location = New System.Drawing.Point(199, 82)
        Me.CianoDensidadTextBox.Name = "CianoDensidadTextBox"
        Me.CianoDensidadTextBox.Size = New System.Drawing.Size(45, 24)
        Me.CianoDensidadTextBox.TabIndex = 37
        '
        'DiatoDensidadTextBox
        '
        Me.DiatoDensidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "DiatoDensidad", True))
        Me.DiatoDensidadTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.DiatoDensidadTextBox.Location = New System.Drawing.Point(199, 108)
        Me.DiatoDensidadTextBox.Name = "DiatoDensidadTextBox"
        Me.DiatoDensidadTextBox.Size = New System.Drawing.Size(45, 24)
        Me.DiatoDensidadTextBox.TabIndex = 39
        '
        'EcoliTextBox
        '
        Me.EcoliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Ecoli", True))
        Me.EcoliTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.EcoliTextBox.Location = New System.Drawing.Point(199, 134)
        Me.EcoliTextBox.Name = "EcoliTextBox"
        Me.EcoliTextBox.Size = New System.Drawing.Size(45, 24)
        Me.EcoliTextBox.TabIndex = 41
        '
        'MuestrasBindingNavigator
        '
        Me.MuestrasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MuestrasBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.MuestrasBindingNavigator.BindingSource = Me.MuestrasBindingSource
        Me.MuestrasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MuestrasBindingNavigator.CountItemFormat = "de {0}"
        Me.MuestrasBindingNavigator.DeleteItem = Nothing
        Me.MuestrasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MuestrasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton, Me.toolStripSeparator, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator1})
        Me.MuestrasBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MuestrasBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.MuestrasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MuestrasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MuestrasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MuestrasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MuestrasBindingNavigator.Name = "MuestrasBindingNavigator"
        Me.MuestrasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MuestrasBindingNavigator.Size = New System.Drawing.Size(1049, 37)
        Me.MuestrasBindingNavigator.TabIndex = 52
        Me.MuestrasBindingNavigator.Text = "Navegador de muestras"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(93, 34)
        Me.BindingNavigatorAddNewItem.Text = "Nueva muestra"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 34)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(105, 34)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar muestra"
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveToolStripButton.ForeColor = System.Drawing.Color.White
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(103, 34)
        Me.SaveToolStripButton.Text = "Guardar muestra"
        Me.SaveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 37)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorMoveFirstItem.Text = "Primera"
        Me.BindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorMovePreviousItem.Text = "Anterior"
        Me.BindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorMoveNextItem.Text = "Siguiente"
        Me.BindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorMoveLastItem.Text = "Última"
        Me.BindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'grpMuestra
        '
        Me.grpMuestra.BackColor = System.Drawing.Color.White
        Me.grpMuestra.Controls.Add(IdProyectoLabel)
        Me.grpMuestra.Controls.Add(Me.IdProyectoTextBox)
        Me.grpMuestra.Controls.Add(Me.IdMuestraTextBox)
        Me.grpMuestra.Controls.Add(IdMuestraLabel)
        Me.grpMuestra.Controls.Add(NombreLabel)
        Me.grpMuestra.Controls.Add(Me.AutorTextBox)
        Me.grpMuestra.Controls.Add(AutorLabel)
        Me.grpMuestra.Controls.Add(Me.NombreTextBox)
        Me.grpMuestra.Controls.Add(Me.CodigoSitioTextBox)
        Me.grpMuestra.Controls.Add(FechaLabel)
        Me.grpMuestra.Controls.Add(CodigoSitioLabel)
        Me.grpMuestra.Controls.Add(Me.FechaDateTimePicker)
        Me.grpMuestra.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpMuestra.Location = New System.Drawing.Point(12, 63)
        Me.grpMuestra.Name = "grpMuestra"
        Me.grpMuestra.Size = New System.Drawing.Size(345, 163)
        Me.grpMuestra.TabIndex = 57
        Me.grpMuestra.TabStop = False
        Me.grpMuestra.Text = "Datos de la muestra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(185, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 17)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "mg/L"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(385, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "mg/L"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(385, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 17)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "mg/L"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(385, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "mg/L"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(385, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "mg/L"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(185, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "mg/L"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(185, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "m2/seg"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(185, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "UNT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(185, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "°C"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(185, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "uS/cm"
        '
        'FQBODTextBox
        '
        Me.FQBODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQBOD", True))
        Me.FQBODTextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FQBODTextBox.Location = New System.Drawing.Point(142, 177)
        Me.FQBODTextBox.Name = "FQBODTextBox"
        Me.FQBODTextBox.Size = New System.Drawing.Size(37, 24)
        Me.FQBODTextBox.TabIndex = 67
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(250, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 17)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "UFC/mL"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(250, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 17)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(250, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 17)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "cél/mL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(250, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 17)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "mg/cm2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(250, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 17)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "mg/L"
        '
        'ClorofilaATextBox
        '
        Me.ClorofilaATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "ClorofilaA", True))
        Me.ClorofilaATextBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ClorofilaATextBox.Location = New System.Drawing.Point(199, 30)
        Me.ClorofilaATextBox.Name = "ClorofilaATextBox"
        Me.ClorofilaATextBox.Size = New System.Drawing.Size(45, 24)
        Me.ClorofilaATextBox.TabIndex = 33
        '
        'DivBasuraComboBox
        '
        Me.DivBasuraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "DivBasura", True))
        Me.DivBasuraComboBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.DivBasuraComboBox.FormattingEnabled = True
        Me.DivBasuraComboBox.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.DivBasuraComboBox.Location = New System.Drawing.Point(171, 142)
        Me.DivBasuraComboBox.Name = "DivBasuraComboBox"
        Me.DivBasuraComboBox.Size = New System.Drawing.Size(126, 23)
        Me.DivBasuraComboBox.TabIndex = 46
        '
        'NaturalidadComboBox
        '
        Me.NaturalidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Naturalidad", True))
        Me.NaturalidadComboBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.NaturalidadComboBox.FormattingEnabled = True
        Me.NaturalidadComboBox.Items.AddRange(New Object() {"", "0", "2.5", "5", "7.5", "10"})
        Me.NaturalidadComboBox.Location = New System.Drawing.Point(171, 104)
        Me.NaturalidadComboBox.Name = "NaturalidadComboBox"
        Me.NaturalidadComboBox.Size = New System.Drawing.Size(126, 23)
        Me.NaturalidadComboBox.TabIndex = 44
        '
        'ConectividadComboBox
        '
        Me.ConectividadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Conectividad", True))
        Me.ConectividadComboBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ConectividadComboBox.FormattingEnabled = True
        Me.ConectividadComboBox.Items.AddRange(New Object() {"", "0", "2.5", "5", "7.5", "10"})
        Me.ConectividadComboBox.Location = New System.Drawing.Point(171, 64)
        Me.ConectividadComboBox.Name = "ConectividadComboBox"
        Me.ConectividadComboBox.Size = New System.Drawing.Size(126, 23)
        Me.ConectividadComboBox.TabIndex = 43
        '
        'OlorComboBox
        '
        Me.OlorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Olor", True))
        Me.OlorComboBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.OlorComboBox.FormattingEnabled = True
        Me.OlorComboBox.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.OlorComboBox.Location = New System.Drawing.Point(171, 24)
        Me.OlorComboBox.Name = "OlorComboBox"
        Me.OlorComboBox.Size = New System.Drawing.Size(126, 23)
        Me.OlorComboBox.TabIndex = 42
        '
        'IMRPlataBindingSource
        '
        Me.IMRPlataBindingSource.DataMember = "MuestrasIMRPlata"
        Me.IMRPlataBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'grpIndices
        '
        Me.grpIndices.Controls.Add(Me.IBIDPlataTextBox)
        Me.grpIndices.Controls.Add(Me.btnCalcularIBIDPlata)
        Me.grpIndices.Controls.Add(Me.IEcoPlataSignifica)
        Me.grpIndices.Controls.Add(IndiceLabel)
        Me.grpIndices.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpIndices.Location = New System.Drawing.Point(372, 64)
        Me.grpIndices.Name = "grpIndices"
        Me.grpIndices.Size = New System.Drawing.Size(407, 159)
        Me.grpIndices.TabIndex = 64
        Me.grpIndices.TabStop = False
        Me.grpIndices.Text = "Índices"
        '
        'IBIDPlataTextBox
        '
        Me.IBIDPlataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IMRPlata", True))
        Me.IBIDPlataTextBox.Location = New System.Drawing.Point(96, 29)
        Me.IBIDPlataTextBox.Name = "IBIDPlataTextBox"
        Me.IBIDPlataTextBox.Size = New System.Drawing.Size(54, 24)
        Me.IBIDPlataTextBox.TabIndex = 68
        '
        'btnCalcularIBIDPlata
        '
        Me.btnCalcularIBIDPlata.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCalcularIBIDPlata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularIBIDPlata.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.btnCalcularIBIDPlata.Location = New System.Drawing.Point(280, 30)
        Me.btnCalcularIBIDPlata.Name = "btnCalcularIBIDPlata"
        Me.btnCalcularIBIDPlata.Size = New System.Drawing.Size(107, 22)
        Me.btnCalcularIBIDPlata.TabIndex = 65
        Me.btnCalcularIBIDPlata.Text = "Calcular"
        Me.btnCalcularIBIDPlata.UseVisualStyleBackColor = True
        '
        'IEcoPlataSignifica
        '
        Me.IEcoPlataSignifica.BackColor = System.Drawing.Color.LightGray
        Me.IEcoPlataSignifica.Enabled = False
        Me.IEcoPlataSignifica.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.IEcoPlataSignifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IEcoPlataSignifica.Location = New System.Drawing.Point(156, 29)
        Me.IEcoPlataSignifica.Name = "IEcoPlataSignifica"
        Me.IEcoPlataSignifica.Size = New System.Drawing.Size(118, 23)
        Me.IEcoPlataSignifica.TabIndex = 67
        Me.IEcoPlataSignifica.TabStop = False
        Me.IEcoPlataSignifica.Text = "No se calculará"
        Me.IEcoPlataSignifica.UseVisualStyleBackColor = False
        '
        'btnReporte
        '
        Me.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnReporte.FlatAppearance.BorderSize = 2
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Location = New System.Drawing.Point(492, 523)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(281, 33)
        Me.btnReporte.TabIndex = 66
        Me.btnReporte.Text = "Generar Reporte del Proyecto"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'tmrCheckIndices
        '
        Me.tmrCheckIndices.Enabled = True
        Me.tmrCheckIndices.Interval = 10
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MuestrasTableAdapter = Me.MuestrasTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Scila7.Scilla10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.Salir)
        Me.C1CommandHolder1.Commands.Add(Me.c1Command1)
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandMenu1)
        Me.C1CommandHolder1.Commands.Add(Me.Archivo)
        Me.C1CommandHolder1.Commands.Add(Me.Nuevamuestra)
        Me.C1CommandHolder1.Commands.Add(Me.Guardar)
        Me.C1CommandHolder1.Commands.Add(Me.MenuMuestras)
        Me.C1CommandHolder1.Commands.Add(Me.EliminarMuestra)
        Me.C1CommandHolder1.Commands.Add(Me.MenuProtocolos)
        Me.C1CommandHolder1.Commands.Add(Me.MenuIndices)
        Me.C1CommandHolder1.Owner = Me
        '
        'Salir
        '
        Me.Salir.Name = "Salir"
        Me.Salir.Text = "Salir"
        '
        'c1Command1
        '
        Me.c1Command1.Name = "c1Command1"
        Me.c1Command1.Text = "E&xit"
        '
        'C1CommandMenu1
        '
        Me.C1CommandMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink3})
        Me.C1CommandMenu1.HideNonRecentLinks = False
        Me.C1CommandMenu1.Name = "C1CommandMenu1"
        Me.C1CommandMenu1.Text = "New Command"
        Me.C1CommandMenu1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
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
        Me.Archivo.Text = "&Archivo"
        Me.Archivo.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.Command = Me.Guardar
        '
        'Guardar
        '
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.Name = "Guardar"
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
        Me.Nuevamuestra.Text = "Nueva &Muestra"
        '
        'MenuMuestras
        '
        Me.MenuMuestras.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.C1CommandLink7})
        Me.MenuMuestras.HideNonRecentLinks = False
        Me.MenuMuestras.Name = "MenuMuestras"
        Me.MenuMuestras.Text = "&Muestras"
        Me.MenuMuestras.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
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
        Me.EliminarMuestra.Text = "&Eliminar Muestra"
        '
        'MenuProtocolos
        '
        Me.MenuProtocolos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink9})
        Me.MenuProtocolos.HideNonRecentLinks = False
        Me.MenuProtocolos.Name = "MenuProtocolos"
        Me.MenuProtocolos.Text = "&Protocolos"
        Me.MenuProtocolos.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
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
        Me.MenuIndices.Text = "&Indices"
        Me.MenuIndices.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink11
        '
        Me.C1CommandLink11.Text = "New Command"
        '
        'ComboBox15
        '
        Me.ComboBox15.DataSource = Me.MuestrasBindingSource
        Me.ComboBox15.DisplayMember = "Nombre"
        Me.ComboBox15.FormattingEnabled = True
        Me.ComboBox15.Location = New System.Drawing.Point(605, 30)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox15.TabIndex = 68
        Me.ComboBox15.TabStop = False
        '
        'MuestrasDataGridView
        '
        Me.MuestrasDataGridView.AutoGenerateColumns = False
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(981, 53)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(68, 63)
        Me.MuestrasDataGridView.TabIndex = 69
        Me.MuestrasDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdMuestra"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdMuestra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdProyecto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdProyecto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CodigoSitio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CodigoSitio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FQpH"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FQpH"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FQTemp"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FQTemp"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FQCond"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FQCond"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FQTurb"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FQTurb"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FQCaudal"
        Me.DataGridViewTextBoxColumn11.HeaderText = "FQCaudal"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FQOD"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FQOD"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FQNitratos"
        Me.DataGridViewTextBoxColumn13.HeaderText = "FQNitratos"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FQNitritos"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FQNitritos"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "FQAmonio"
        Me.DataGridViewTextBoxColumn15.HeaderText = "FQAmonio"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FQFosfato"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FQFosfato"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ClorofilaA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ClorofilaA"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn18.HeaderText = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CianoDensidad"
        Me.DataGridViewTextBoxColumn19.HeaderText = "CianoDensidad"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn20.HeaderText = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Ecoli"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Ecoli"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Olor"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Olor"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Conectividad"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Conectividad"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Naturalidad"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Naturalidad"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "AbuBasura"
        Me.DataGridViewTextBoxColumn25.HeaderText = "AbuBasura"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "DivBasura"
        Me.DataGridViewTextBoxColumn26.HeaderText = "DivBasura"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "IDP"
        Me.DataGridViewTextBoxColumn27.HeaderText = "IDP"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "IMRP"
        Me.DataGridViewTextBoxColumn28.HeaderText = "IMRP"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "IMRPlata"
        Me.DataGridViewTextBoxColumn29.HeaderText = "IMRPlata"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "FQBOD"
        Me.DataGridViewTextBoxColumn31.HeaderText = "FQBOD"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(534, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 14)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Muestra:"
        '
        'IBPAMPBindingSource
        '
        Me.IBPAMPBindingSource.DataMember = "MuestrasIBPAMP"
        Me.IBPAMPBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'EutrofizacionBindingSource
        '
        Me.EutrofizacionBindingSource.DataMember = "MuestrasEutrofizacion"
        Me.EutrofizacionBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'IMRPBindingSource
        '
        Me.IMRPBindingSource.DataMember = "MuestrasIMRP"
        Me.IMRPBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'IDPBindingSource
        '
        Me.IDPBindingSource.DataMember = "MuestrasIDP"
        Me.IDPBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'C1DockingTab2
        '
        Me.C1DockingTab2.BackColor = System.Drawing.Color.White
        Me.C1DockingTab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage5)
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage6)
        Me.C1DockingTab2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1DockingTab2.Location = New System.Drawing.Point(12, 233)
        Me.C1DockingTab2.Name = "C1DockingTab2"
        Me.C1DockingTab2.Size = New System.Drawing.Size(760, 284)
        Me.C1DockingTab2.TabIndex = 74
        Me.C1DockingTab2.TabsSpacing = 0
        Me.C1DockingTab2.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP
        Me.C1DockingTab2.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.C1DockingTab2.VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.C1Button3)
        Me.C1DockingTabPage1.Controls.Add(Me.GroupBox1)
        Me.C1DockingTabPage1.Controls.Add(OlorLabel)
        Me.C1DockingTabPage1.Controls.Add(Me.DivBasuraComboBox)
        Me.C1DockingTabPage1.Controls.Add(Me.ConectividadComboBox)
        Me.C1DockingTabPage1.Controls.Add(Me.OlorComboBox)
        Me.C1DockingTabPage1.Controls.Add(DivBasuraLabel)
        Me.C1DockingTabPage1.Controls.Add(Me.NaturalidadComboBox)
        Me.C1DockingTabPage1.Controls.Add(NaturalidadLabel)
        Me.C1DockingTabPage1.Controls.Add(ConectividadLabel)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 32)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(758, 251)
        Me.C1DockingTabPage1.TabBackColorSelected = System.Drawing.Color.White
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "Hábitat"
        '
        'C1Button3
        '
        Me.C1Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.C1Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1Button3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.C1Button3.Location = New System.Drawing.Point(104, 218)
        Me.C1Button3.Name = "C1Button3"
        Me.C1Button3.Size = New System.Drawing.Size(141, 30)
        Me.C1Button3.TabIndex = 53
        Me.C1Button3.Text = "Estado del hábitat"
        Me.C1Button3.UseVisualStyleBackColor = True
        Me.C1Button3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstadoHabitatExplain)
        Me.GroupBox1.Controls.Add(Me.txtEstadoHabitat)
        Me.GroupBox1.Controls.Add(Me.progHabitatGeneral)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(359, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 229)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado general del hábitat"
        Me.GroupBox1.Visible = False
        '
        'txtEstadoHabitatExplain
        '
        Me.txtEstadoHabitatExplain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstadoHabitatExplain.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoHabitatExplain.Location = New System.Drawing.Point(6, 59)
        Me.txtEstadoHabitatExplain.Name = "txtEstadoHabitatExplain"
        Me.txtEstadoHabitatExplain.Size = New System.Drawing.Size(381, 164)
        Me.txtEstadoHabitatExplain.TabIndex = 2
        Me.txtEstadoHabitatExplain.Text = ""
        '
        'txtEstadoHabitat
        '
        Me.txtEstadoHabitat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEstadoHabitat.Location = New System.Drawing.Point(311, 29)
        Me.txtEstadoHabitat.Name = "txtEstadoHabitat"
        Me.txtEstadoHabitat.Size = New System.Drawing.Size(76, 24)
        Me.txtEstadoHabitat.TabIndex = 1
        '
        'progHabitatGeneral
        '
        Me.progHabitatGeneral.Location = New System.Drawing.Point(15, 30)
        Me.progHabitatGeneral.Name = "progHabitatGeneral"
        Me.progHabitatGeneral.Size = New System.Drawing.Size(290, 23)
        Me.progHabitatGeneral.TabIndex = 0
        '
        'C1DockingTabPage5
        '
        Me.C1DockingTabPage5.Controls.Add(Me.GroupBox2)
        Me.C1DockingTabPage5.Controls.Add(FQpHLabel)
        Me.C1DockingTabPage5.Controls.Add(Me.Label10)
        Me.C1DockingTabPage5.Controls.Add(FQAmonioLabel)
        Me.C1DockingTabPage5.Controls.Add(Me.Label9)
        Me.C1DockingTabPage5.Controls.Add(Me.FQAmonioTextBox)
        Me.C1DockingTabPage5.Controls.Add(Me.FQNitritosTextBox)
        Me.C1DockingTabPage5.Controls.Add(Me.Label8)
        Me.C1DockingTabPage5.Controls.Add(FQFosfatoLabel)
        Me.C1DockingTabPage5.Controls.Add(FQCaudalLabel)
        Me.C1DockingTabPage5.Controls.Add(FQNitritosLabel)
        Me.C1DockingTabPage5.Controls.Add(Me.Label7)
        Me.C1DockingTabPage5.Controls.Add(Me.FQFosfatoTextBox)
        Me.C1DockingTabPage5.Controls.Add(Me.FQTurbTextBox)
        Me.C1DockingTabPage5.Controls.Add(FQTempLabel)
        Me.C1DockingTabPage5.Controls.Add(Me.Label6)
        Me.C1DockingTabPage5.Controls.Add(Me.FQBODTextBox)
        Me.C1DockingTabPage5.Controls.Add(Me.FQCaudalTextBox)
        Me.C1DockingTabPage5.Controls.Add(Me.FQNitratosTextBox)
        Me.C1DockingTabPage5.Controls.Add(Me.Label5)
        Me.C1DockingTabPage5.Controls.Add(Me.FQpHTextBox)
        Me.C1DockingTabPage5.Controls.Add(FQTurbLabel)
        Me.C1DockingTabPage5.Controls.Add(Me.FQTempTextBox)
        Me.C1DockingTabPage5.Controls.Add(Me.Label4)
        Me.C1DockingTabPage5.Controls.Add(FQBODLabel)
        Me.C1DockingTabPage5.Controls.Add(FQODLabel)
        Me.C1DockingTabPage5.Controls.Add(FQNitratosLabel)
        Me.C1DockingTabPage5.Controls.Add(Me.Label3)
        Me.C1DockingTabPage5.Controls.Add(FQCondLabel)
        Me.C1DockingTabPage5.Controls.Add(Me.FQCondTextBox)
        Me.C1DockingTabPage5.Controls.Add(Me.Label1)
        Me.C1DockingTabPage5.Controls.Add(Me.Label2)
        Me.C1DockingTabPage5.Controls.Add(Me.FQODTextBox)
        Me.C1DockingTabPage5.Location = New System.Drawing.Point(1, 32)
        Me.C1DockingTabPage5.Name = "C1DockingTabPage5"
        Me.C1DockingTabPage5.Size = New System.Drawing.Size(758, 251)
        Me.C1DockingTabPage5.TabIndex = 1
        Me.C1DockingTabPage5.Text = "Físico-químicos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtEstadoFQExplain)
        Me.GroupBox2.Controls.Add(Me.txtEstadoFQ)
        Me.GroupBox2.Controls.Add(Me.progEstadoFQ)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(456, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 229)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado general"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.Button1.Location = New System.Drawing.Point(72, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Que significa esto?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtEstadoFQExplain
        '
        Me.txtEstadoFQExplain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstadoFQExplain.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoFQExplain.Location = New System.Drawing.Point(18, 59)
        Me.txtEstadoFQExplain.Name = "txtEstadoFQExplain"
        Me.txtEstadoFQExplain.Size = New System.Drawing.Size(268, 121)
        Me.txtEstadoFQExplain.TabIndex = 2
        Me.txtEstadoFQExplain.Text = ""
        '
        'txtEstadoFQ
        '
        Me.txtEstadoFQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEstadoFQ.Location = New System.Drawing.Point(214, 29)
        Me.txtEstadoFQ.Name = "txtEstadoFQ"
        Me.txtEstadoFQ.Size = New System.Drawing.Size(76, 24)
        Me.txtEstadoFQ.TabIndex = 1
        '
        'progEstadoFQ
        '
        Me.progEstadoFQ.Location = New System.Drawing.Point(15, 30)
        Me.progEstadoFQ.Name = "progEstadoFQ"
        Me.progEstadoFQ.Size = New System.Drawing.Size(193, 23)
        Me.progEstadoFQ.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progEstadoFQ.TabIndex = 0
        Me.progEstadoFQ.Value = 50
        '
        'C1DockingTabPage6
        '
        Me.C1DockingTabPage6.Controls.Add(Me.Label18)
        Me.C1DockingTabPage6.Controls.Add(Me.Label17)
        Me.C1DockingTabPage6.Controls.Add(TanaidsLabel)
        Me.C1DockingTabPage6.Controls.Add(Me.TanaidsTextBox)
        Me.C1DockingTabPage6.Controls.Add(FitoTotalLabel)
        Me.C1DockingTabPage6.Controls.Add(Me.FitoTotalTextBox)
        Me.C1DockingTabPage6.Controls.Add(Me.Label15)
        Me.C1DockingTabPage6.Controls.Add(ClorofilaALabel)
        Me.C1DockingTabPage6.Controls.Add(Me.Label14)
        Me.C1DockingTabPage6.Controls.Add(EcoliLabel)
        Me.C1DockingTabPage6.Controls.Add(Me.DiatoDensidadTextBox)
        Me.C1DockingTabPage6.Controls.Add(Me.Label13)
        Me.C1DockingTabPage6.Controls.Add(Me.EcoliTextBox)
        Me.C1DockingTabPage6.Controls.Add(MateriaOrganicaLabel)
        Me.C1DockingTabPage6.Controls.Add(DiatoDensidadLabel)
        Me.C1DockingTabPage6.Controls.Add(Me.Label12)
        Me.C1DockingTabPage6.Controls.Add(Me.ClorofilaATextBox)
        Me.C1DockingTabPage6.Controls.Add(Me.MateriaOrganicaTextBox)
        Me.C1DockingTabPage6.Controls.Add(Me.CianoDensidadTextBox)
        Me.C1DockingTabPage6.Controls.Add(Me.Label11)
        Me.C1DockingTabPage6.Controls.Add(CianoDensidadLabel)
        Me.C1DockingTabPage6.Location = New System.Drawing.Point(1, 32)
        Me.C1DockingTabPage6.Name = "C1DockingTabPage6"
        Me.C1DockingTabPage6.Size = New System.Drawing.Size(758, 251)
        Me.C1DockingTabPage6.TabIndex = 2
        Me.C1DockingTabPage6.Text = "Biológicos"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(250, 166)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 17)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "cél/mL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(251, 188)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 17)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "%"
        '
        'TanaidsTextBox
        '
        Me.TanaidsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Tanaids", True))
        Me.TanaidsTextBox.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanaidsTextBox.Location = New System.Drawing.Point(199, 188)
        Me.TanaidsTextBox.Name = "TanaidsTextBox"
        Me.TanaidsTextBox.Size = New System.Drawing.Size(45, 24)
        Me.TanaidsTextBox.TabIndex = 88
        '
        'FitoTotalTextBox
        '
        Me.FitoTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FitoTotal", True))
        Me.FitoTotalTextBox.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FitoTotalTextBox.Location = New System.Drawing.Point(199, 161)
        Me.FitoTotalTextBox.Name = "FitoTotalTextBox"
        Me.FitoTotalTextBox.Size = New System.Drawing.Size(45, 24)
        Me.FitoTotalTextBox.TabIndex = 87
        '
        'ConfigDataSet
        '
        Me.ConfigDataSet.DataSetName = "ConfigDataSet"
        Me.ConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.ConfigDataSet
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AdminTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ConfigTableAdapter = Me.ConfigTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Scila7.ConfigDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EnciclopediaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1049, 24)
        Me.MenuStrip1.TabIndex = 75
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'frmMuestrasRLP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1049, 562)
        Me.Controls.Add(Me.C1DockingTab2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grpMuestra)
        Me.Controls.Add(Me.MuestrasDataGridView)
        Me.Controls.Add(Me.ComboBox15)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.grpIndices)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMuestrasRLP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karku - Muestras de Estuario RLP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MuestrasBindingNavigator.ResumeLayout(False)
        Me.MuestrasBindingNavigator.PerformLayout()
        Me.grpMuestra.ResumeLayout(False)
        Me.grpMuestra.PerformLayout()
        CType(Me.IMRPlataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIndices.ResumeLayout(False)
        Me.grpIndices.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EutrofizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab2.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.C1DockingTabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.C1DockingTabPage5.ResumeLayout(False)
        Me.C1DockingTabPage5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.C1DockingTabPage6.ResumeLayout(False)
        Me.C1DockingTabPage6.PerformLayout()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents TableAdapterManager As Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdMuestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CodigoSitioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQpHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQTempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQCondTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQTurbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQCaudalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQNitratosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQNitritosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQAmonioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FQFosfatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MateriaOrganicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CianoDensidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiatoDensidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EcoliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MuestrasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IMRPlataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grpMuestra As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpIndices As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalcularIBIDPlata As C1.Win.C1Input.C1Button
    Friend WithEvents btnReporte As C1.Win.C1Input.C1Button
    Friend WithEvents IDPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EutrofizacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IEcoPlataSignifica As System.Windows.Forms.Button
    Friend WithEvents tmrCheckIndices As System.Windows.Forms.Timer
    Friend WithEvents ConectividadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OlorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NaturalidadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DivBasuraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FQBODTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents ComboBox15 As System.Windows.Forms.ComboBox
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ClorofilaATextBox As System.Windows.Forms.TextBox
    Friend WithEvents C1OutPage2 As C1.Win.C1Command.C1OutPage
    Friend WithEvents C1OutPage3 As C1.Win.C1Command.C1OutPage
    Friend WithEvents C1OutPage4 As C1.Win.C1Command.C1OutPage
    Friend WithEvents IBPAMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents C1DockingTab2 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage6 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents TableAdapterManager1 As Scila7.ConfigDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEstadoHabitat As System.Windows.Forms.TextBox
    Friend WithEvents progHabitatGeneral As System.Windows.Forms.ProgressBar
    Friend WithEvents txtEstadoHabitatExplain As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtEstadoFQExplain As System.Windows.Forms.RichTextBox
    Friend WithEvents txtEstadoFQ As System.Windows.Forms.TextBox
    Friend WithEvents progEstadoFQ As System.Windows.Forms.ProgressBar
    Friend WithEvents C1Button3 As C1.Win.C1Input.C1Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TanaidsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FitoTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IBIDPlataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnciclopediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
