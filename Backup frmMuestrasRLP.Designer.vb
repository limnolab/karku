<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuestrasArroyoPamp
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
        Dim AbuBasuraLabel As System.Windows.Forms.Label
        Dim DivBasuraLabel As System.Windows.Forms.Label
        Dim IndiceLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim ValorLabel1 As System.Windows.Forms.Label
        Dim ValorLabel2 As System.Windows.Forms.Label
        Dim FQBODLabel As System.Windows.Forms.Label
        Dim IndiceLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMuestrasArroyoPamp))
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
        Me.HelpFQ = New System.Windows.Forms.Button
        Me.FQBODTextBox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.HelpBiologicos = New System.Windows.Forms.Button
        Me.ClorofilaATextBox = New System.Windows.Forms.TextBox
        Me.HelpHabitat = New System.Windows.Forms.Button
        Me.DivBasuraComboBox = New System.Windows.Forms.ComboBox
        Me.NaturalidadComboBox = New System.Windows.Forms.ComboBox
        Me.AbuBasuraComboBox = New System.Windows.Forms.ComboBox
        Me.ConectividadComboBox = New System.Windows.Forms.ComboBox
        Me.OlorComboBox = New System.Windows.Forms.ComboBox
        Me.HelpIndices = New System.Windows.Forms.Button
        Me.IEcoPlataValor = New System.Windows.Forms.TextBox
        Me.IMRPlataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpIndices = New System.Windows.Forms.GroupBox
        Me.IBPAMPSignifica = New System.Windows.Forms.Button
        Me.C1Button5 = New C1.Win.C1Input.C1Button
        Me.IndiceTextBox = New System.Windows.Forms.TextBox
        Me.IBPAMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkLimitarEutrofizacion = New System.Windows.Forms.CheckBox
        Me.chkLimitarIMRP = New System.Windows.Forms.CheckBox
        Me.chkLimitarIDP = New System.Windows.Forms.CheckBox
        Me.chkLimitarIERPlata = New System.Windows.Forms.CheckBox
        Me.C1Button4 = New C1.Win.C1Input.C1Button
        Me.C1Button3 = New C1.Win.C1Input.C1Button
        Me.EutrofizacionSignifica = New System.Windows.Forms.Button
        Me.C1Button1 = New C1.Win.C1Input.C1Button
        Me.IMRPSignifica = New System.Windows.Forms.Button
        Me.IDPSignifica = New System.Windows.Forms.Button
        Me.IEcoPlataSignifica = New System.Windows.Forms.Button
        Me.EutrofizacionValor = New System.Windows.Forms.TextBox
        Me.EutrofizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMRPTextBox = New System.Windows.Forms.TextBox
        Me.IMRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDPTextbox = New System.Windows.Forms.TextBox
        Me.IDPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1Button2 = New C1.Win.C1Input.C1Button
        Me.tmrCheckIndices = New System.Windows.Forms.Timer(Me.components)
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
        Me.TableAdapterManager = New Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
        Me.EutrofizacionTableAdapter = New Scila7.Scilla10DataSetTableAdapters.EutrofizacionTableAdapter
        Me.IBPAMPTableAdapter = New Scila7.Scilla10DataSetTableAdapters.IBPAMPTableAdapter
        Me.IDPTableAdapter = New Scila7.Scilla10DataSetTableAdapters.IDPTableAdapter
        Me.IMRPlataTableAdapter = New Scila7.Scilla10DataSetTableAdapters.IMRPlataTableAdapter
        Me.IMRPTableAdapter = New Scila7.Scilla10DataSetTableAdapters.IMRPTableAdapter
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
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage
        Me.Label16 = New System.Windows.Forms.Label
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
        AbuBasuraLabel = New System.Windows.Forms.Label
        DivBasuraLabel = New System.Windows.Forms.Label
        IndiceLabel = New System.Windows.Forms.Label
        ValorLabel = New System.Windows.Forms.Label
        ValorLabel1 = New System.Windows.Forms.Label
        ValorLabel2 = New System.Windows.Forms.Label
        FQBODLabel = New System.Windows.Forms.Label
        IndiceLabel1 = New System.Windows.Forms.Label
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        Me.grpMuestra.SuspendLayout()
        CType(Me.IMRPlataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIndices.SuspendLayout()
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EutrofizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage2.SuspendLayout()
        Me.C1DockingTabPage3.SuspendLayout()
        Me.C1DockingTabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdMuestraLabel
        '
        IdMuestraLabel.AutoSize = True
        IdMuestraLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdMuestraLabel.Location = New System.Drawing.Point(115, 21)
        IdMuestraLabel.Name = "IdMuestraLabel"
        IdMuestraLabel.Size = New System.Drawing.Size(73, 13)
        IdMuestraLabel.TabIndex = 0
        IdMuestraLabel.Text = "Id Muestra:"
        '
        'IdProyectoLabel
        '
        IdProyectoLabel.AutoSize = True
        IdProyectoLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdProyectoLabel.Location = New System.Drawing.Point(291, 19)
        IdProyectoLabel.Name = "IdProyectoLabel"
        IdProyectoLabel.Size = New System.Drawing.Size(78, 13)
        IdProyectoLabel.TabIndex = 2
        IdProyectoLabel.Text = "Id Proyecto:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(115, 47)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(57, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(115, 74)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(45, 13)
        FechaLabel.TabIndex = 6
        FechaLabel.Text = "Fecha:"
        '
        'CodigoSitioLabel
        '
        CodigoSitioLabel.AutoSize = True
        CodigoSitioLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoSitioLabel.Location = New System.Drawing.Point(115, 99)
        CodigoSitioLabel.Name = "CodigoSitioLabel"
        CodigoSitioLabel.Size = New System.Drawing.Size(81, 13)
        CodigoSitioLabel.TabIndex = 8
        CodigoSitioLabel.Text = "Codigo Sitio:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AutorLabel.Location = New System.Drawing.Point(115, 125)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(43, 13)
        AutorLabel.TabIndex = 10
        AutorLabel.Text = "Autor:"
        '
        'FQpHLabel
        '
        FQpHLabel.AutoSize = True
        FQpHLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQpHLabel.Location = New System.Drawing.Point(44, 30)
        FQpHLabel.Name = "FQpHLabel"
        FQpHLabel.Size = New System.Drawing.Size(27, 13)
        FQpHLabel.TabIndex = 12
        FQpHLabel.Text = "pH:"
        '
        'FQTempLabel
        '
        FQTempLabel.AutoSize = True
        FQTempLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQTempLabel.Location = New System.Drawing.Point(44, 56)
        FQTempLabel.Name = "FQTempLabel"
        FQTempLabel.Size = New System.Drawing.Size(86, 13)
        FQTempLabel.TabIndex = 14
        FQTempLabel.Text = "Temperatura:"
        '
        'FQCondLabel
        '
        FQCondLabel.AutoSize = True
        FQCondLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQCondLabel.Location = New System.Drawing.Point(44, 82)
        FQCondLabel.Name = "FQCondLabel"
        FQCondLabel.Size = New System.Drawing.Size(93, 13)
        FQCondLabel.TabIndex = 16
        FQCondLabel.Text = "Conductividad:"
        '
        'FQTurbLabel
        '
        FQTurbLabel.AutoSize = True
        FQTurbLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQTurbLabel.Location = New System.Drawing.Point(44, 108)
        FQTurbLabel.Name = "FQTurbLabel"
        FQTurbLabel.Size = New System.Drawing.Size(61, 13)
        FQTurbLabel.TabIndex = 18
        FQTurbLabel.Text = "Turbidez:"
        '
        'FQCaudalLabel
        '
        FQCaudalLabel.AutoSize = True
        FQCaudalLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQCaudalLabel.Location = New System.Drawing.Point(44, 134)
        FQCaudalLabel.Name = "FQCaudalLabel"
        FQCaudalLabel.Size = New System.Drawing.Size(52, 13)
        FQCaudalLabel.TabIndex = 20
        FQCaudalLabel.Text = "Caudal:"
        '
        'FQODLabel
        '
        FQODLabel.AutoSize = True
        FQODLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQODLabel.Location = New System.Drawing.Point(44, 160)
        FQODLabel.Name = "FQODLabel"
        FQODLabel.Size = New System.Drawing.Size(109, 13)
        FQODLabel.TabIndex = 22
        FQODLabel.Text = "Oxígeno Disuelto:"
        '
        'FQNitratosLabel
        '
        FQNitratosLabel.AutoSize = True
        FQNitratosLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQNitratosLabel.Location = New System.Drawing.Point(44, 186)
        FQNitratosLabel.Name = "FQNitratosLabel"
        FQNitratosLabel.Size = New System.Drawing.Size(56, 13)
        FQNitratosLabel.TabIndex = 24
        FQNitratosLabel.Text = "Nitratos:"
        '
        'FQNitritosLabel
        '
        FQNitritosLabel.AutoSize = True
        FQNitritosLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQNitritosLabel.Location = New System.Drawing.Point(44, 212)
        FQNitritosLabel.Name = "FQNitritosLabel"
        FQNitritosLabel.Size = New System.Drawing.Size(52, 13)
        FQNitritosLabel.TabIndex = 26
        FQNitritosLabel.Text = "Nitritos:"
        '
        'FQAmonioLabel
        '
        FQAmonioLabel.AutoSize = True
        FQAmonioLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQAmonioLabel.Location = New System.Drawing.Point(44, 238)
        FQAmonioLabel.Name = "FQAmonioLabel"
        FQAmonioLabel.Size = New System.Drawing.Size(55, 13)
        FQAmonioLabel.TabIndex = 28
        FQAmonioLabel.Text = "Amonio:"
        '
        'FQFosfatoLabel
        '
        FQFosfatoLabel.AutoSize = True
        FQFosfatoLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        FQFosfatoLabel.Location = New System.Drawing.Point(44, 264)
        FQFosfatoLabel.Name = "FQFosfatoLabel"
        FQFosfatoLabel.Size = New System.Drawing.Size(53, 13)
        FQFosfatoLabel.TabIndex = 30
        FQFosfatoLabel.Text = "Fosfato:"
        '
        'ClorofilaALabel
        '
        ClorofilaALabel.AutoSize = True
        ClorofilaALabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        ClorofilaALabel.Location = New System.Drawing.Point(17, 30)
        ClorofilaALabel.Name = "ClorofilaALabel"
        ClorofilaALabel.Size = New System.Drawing.Size(81, 13)
        ClorofilaALabel.TabIndex = 32
        ClorofilaALabel.Text = "Clorofila ""a"":"
        '
        'MateriaOrganicaLabel
        '
        MateriaOrganicaLabel.AutoSize = True
        MateriaOrganicaLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        MateriaOrganicaLabel.Location = New System.Drawing.Point(17, 58)
        MateriaOrganicaLabel.Name = "MateriaOrganicaLabel"
        MateriaOrganicaLabel.Size = New System.Drawing.Size(109, 13)
        MateriaOrganicaLabel.TabIndex = 34
        MateriaOrganicaLabel.Text = "Materia Orgánica:"
        '
        'CianoDensidadLabel
        '
        CianoDensidadLabel.AutoSize = True
        CianoDensidadLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        CianoDensidadLabel.Location = New System.Drawing.Point(17, 84)
        CianoDensidadLabel.Name = "CianoDensidadLabel"
        CianoDensidadLabel.Size = New System.Drawing.Size(170, 13)
        CianoDensidadLabel.TabIndex = 36
        CianoDensidadLabel.Text = "Densidad de Cyanobacteria:"
        '
        'DiatoDensidadLabel
        '
        DiatoDensidadLabel.AutoSize = True
        DiatoDensidadLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        DiatoDensidadLabel.Location = New System.Drawing.Point(17, 110)
        DiatoDensidadLabel.Name = "DiatoDensidadLabel"
        DiatoDensidadLabel.Size = New System.Drawing.Size(164, 13)
        DiatoDensidadLabel.TabIndex = 38
        DiatoDensidadLabel.Text = "Diatomeas Muy Tolerantes:"
        '
        'EcoliLabel
        '
        EcoliLabel.AutoSize = True
        EcoliLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        EcoliLabel.Location = New System.Drawing.Point(17, 135)
        EcoliLabel.Name = "EcoliLabel"
        EcoliLabel.Size = New System.Drawing.Size(149, 13)
        EcoliLabel.TabIndex = 40
        EcoliLabel.Text = "Concentración de E.Coli:"
        '
        'OlorLabel
        '
        OlorLabel.AutoSize = True
        OlorLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OlorLabel.Location = New System.Drawing.Point(16, 19)
        OlorLabel.Name = "OlorLabel"
        OlorLabel.Size = New System.Drawing.Size(36, 13)
        OlorLabel.TabIndex = 42
        OlorLabel.Text = "Olor:"
        '
        'ConectividadLabel
        '
        ConectividadLabel.AutoSize = True
        ConectividadLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ConectividadLabel.Location = New System.Drawing.Point(16, 46)
        ConectividadLabel.Name = "ConectividadLabel"
        ConectividadLabel.Size = New System.Drawing.Size(87, 13)
        ConectividadLabel.TabIndex = 44
        ConectividadLabel.Text = "Hábitat Físico:"
        '
        'NaturalidadLabel
        '
        NaturalidadLabel.AutoSize = True
        NaturalidadLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NaturalidadLabel.Location = New System.Drawing.Point(16, 73)
        NaturalidadLabel.Name = "NaturalidadLabel"
        NaturalidadLabel.Size = New System.Drawing.Size(133, 13)
        NaturalidadLabel.TabIndex = 46
        NaturalidadLabel.Text = "Vegetación Ripariana:"
        '
        'AbuBasuraLabel
        '
        AbuBasuraLabel.AutoSize = True
        AbuBasuraLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AbuBasuraLabel.Location = New System.Drawing.Point(16, 100)
        AbuBasuraLabel.Name = "AbuBasuraLabel"
        AbuBasuraLabel.Size = New System.Drawing.Size(130, 13)
        AbuBasuraLabel.TabIndex = 48
        AbuBasuraLabel.Text = "Frecuencia de debris:"
        '
        'DivBasuraLabel
        '
        DivBasuraLabel.AutoSize = True
        DivBasuraLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DivBasuraLabel.Location = New System.Drawing.Point(16, 127)
        DivBasuraLabel.Name = "DivBasuraLabel"
        DivBasuraLabel.Size = New System.Drawing.Size(134, 13)
        DivBasuraLabel.TabIndex = 50
        DivBasuraLabel.Text = "Diversidad de basura:"
        '
        'IndiceLabel
        '
        IndiceLabel.AutoSize = True
        IndiceLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndiceLabel.Location = New System.Drawing.Point(25, 36)
        IndiceLabel.Name = "IndiceLabel"
        IndiceLabel.Size = New System.Drawing.Size(67, 13)
        IndiceLabel.TabIndex = 62
        IndiceLabel.Text = "IBIDPlata:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        ValorLabel.Location = New System.Drawing.Point(57, 64)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(33, 13)
        ValorLabel.TabIndex = 63
        ValorLabel.Text = "IDP:"
        '
        'ValorLabel1
        '
        ValorLabel1.AutoSize = True
        ValorLabel1.Font = New System.Drawing.Font("Verdana", 8.25!)
        ValorLabel1.Location = New System.Drawing.Point(50, 91)
        ValorLabel1.Name = "ValorLabel1"
        ValorLabel1.Size = New System.Drawing.Size(41, 13)
        ValorLabel1.TabIndex = 64
        ValorLabel1.Text = "IMRP:"
        '
        'ValorLabel2
        '
        ValorLabel2.AutoSize = True
        ValorLabel2.Font = New System.Drawing.Font("Verdana", 8.25!)
        ValorLabel2.Location = New System.Drawing.Point(7, 117)
        ValorLabel2.Name = "ValorLabel2"
        ValorLabel2.Size = New System.Drawing.Size(85, 13)
        ValorLabel2.TabIndex = 65
        ValorLabel2.Text = "Eutrofización:"
        '
        'FQBODLabel
        '
        FQBODLabel.AutoSize = True
        FQBODLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FQBODLabel.Location = New System.Drawing.Point(44, 289)
        FQBODLabel.Name = "FQBODLabel"
        FQBODLabel.Size = New System.Drawing.Size(38, 13)
        FQBODLabel.TabIndex = 66
        FQBODLabel.Text = "DBO:"
        '
        'IndiceLabel1
        '
        IndiceLabel1.AutoSize = True
        IndiceLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndiceLabel1.Location = New System.Drawing.Point(31, 145)
        IndiceLabel1.Name = "IndiceLabel1"
        IndiceLabel1.Size = New System.Drawing.Size(56, 13)
        IndiceLabel1.TabIndex = 96
        IndiceLabel1.Text = "IBPAMP:"
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
        Me.IdMuestraTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdMuestraTextBox.Location = New System.Drawing.Point(215, 16)
        Me.IdMuestraTextBox.Name = "IdMuestraTextBox"
        Me.IdMuestraTextBox.Size = New System.Drawing.Size(27, 21)
        Me.IdMuestraTextBox.TabIndex = 1
        Me.IdMuestraTextBox.TabStop = False
        '
        'IdProyectoTextBox
        '
        Me.IdProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IdProyecto", True))
        Me.IdProyectoTextBox.Enabled = False
        Me.IdProyectoTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProyectoTextBox.Location = New System.Drawing.Point(388, 16)
        Me.IdProyectoTextBox.Name = "IdProyectoTextBox"
        Me.IdProyectoTextBox.Size = New System.Drawing.Size(27, 21)
        Me.IdProyectoTextBox.TabIndex = 3
        Me.IdProyectoTextBox.TabStop = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(215, 42)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NombreTextBox.TabIndex = 5
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MuestrasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(215, 68)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.FechaDateTimePicker.TabIndex = 7
        '
        'CodigoSitioTextBox
        '
        Me.CodigoSitioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "CodigoSitio", True))
        Me.CodigoSitioTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoSitioTextBox.Location = New System.Drawing.Point(215, 94)
        Me.CodigoSitioTextBox.Name = "CodigoSitioTextBox"
        Me.CodigoSitioTextBox.Size = New System.Drawing.Size(200, 21)
        Me.CodigoSitioTextBox.TabIndex = 9
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Autor", True))
        Me.AutorTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorTextBox.Location = New System.Drawing.Point(215, 120)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(200, 21)
        Me.AutorTextBox.TabIndex = 11
        '
        'FQpHTextBox
        '
        Me.FQpHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQpH", True))
        Me.FQpHTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQpHTextBox.Location = New System.Drawing.Point(167, 22)
        Me.FQpHTextBox.Name = "FQpHTextBox"
        Me.FQpHTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQpHTextBox.TabIndex = 13
        '
        'FQTempTextBox
        '
        Me.FQTempTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQTemp", True))
        Me.FQTempTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQTempTextBox.Location = New System.Drawing.Point(167, 48)
        Me.FQTempTextBox.Name = "FQTempTextBox"
        Me.FQTempTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQTempTextBox.TabIndex = 15
        '
        'FQCondTextBox
        '
        Me.FQCondTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQCond", True))
        Me.FQCondTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQCondTextBox.Location = New System.Drawing.Point(167, 74)
        Me.FQCondTextBox.Name = "FQCondTextBox"
        Me.FQCondTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQCondTextBox.TabIndex = 17
        '
        'FQTurbTextBox
        '
        Me.FQTurbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQTurb", True))
        Me.FQTurbTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQTurbTextBox.Location = New System.Drawing.Point(167, 100)
        Me.FQTurbTextBox.Name = "FQTurbTextBox"
        Me.FQTurbTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQTurbTextBox.TabIndex = 19
        '
        'FQCaudalTextBox
        '
        Me.FQCaudalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQCaudal", True))
        Me.FQCaudalTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQCaudalTextBox.Location = New System.Drawing.Point(167, 126)
        Me.FQCaudalTextBox.Name = "FQCaudalTextBox"
        Me.FQCaudalTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQCaudalTextBox.TabIndex = 21
        '
        'FQODTextBox
        '
        Me.FQODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQOD", True))
        Me.FQODTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQODTextBox.Location = New System.Drawing.Point(167, 152)
        Me.FQODTextBox.Name = "FQODTextBox"
        Me.FQODTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQODTextBox.TabIndex = 23
        '
        'FQNitratosTextBox
        '
        Me.FQNitratosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQNitratos", True))
        Me.FQNitratosTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQNitratosTextBox.Location = New System.Drawing.Point(167, 178)
        Me.FQNitratosTextBox.Name = "FQNitratosTextBox"
        Me.FQNitratosTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQNitratosTextBox.TabIndex = 25
        '
        'FQNitritosTextBox
        '
        Me.FQNitritosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQNitritos", True))
        Me.FQNitritosTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQNitritosTextBox.Location = New System.Drawing.Point(167, 204)
        Me.FQNitritosTextBox.Name = "FQNitritosTextBox"
        Me.FQNitritosTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQNitritosTextBox.TabIndex = 27
        '
        'FQAmonioTextBox
        '
        Me.FQAmonioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQAmonio", True))
        Me.FQAmonioTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQAmonioTextBox.Location = New System.Drawing.Point(167, 230)
        Me.FQAmonioTextBox.Name = "FQAmonioTextBox"
        Me.FQAmonioTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQAmonioTextBox.TabIndex = 29
        '
        'FQFosfatoTextBox
        '
        Me.FQFosfatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQFosfato", True))
        Me.FQFosfatoTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FQFosfatoTextBox.Location = New System.Drawing.Point(167, 256)
        Me.FQFosfatoTextBox.Name = "FQFosfatoTextBox"
        Me.FQFosfatoTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQFosfatoTextBox.TabIndex = 31
        '
        'MateriaOrganicaTextBox
        '
        Me.MateriaOrganicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "MateriaOrganica", True))
        Me.MateriaOrganicaTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.MateriaOrganicaTextBox.Location = New System.Drawing.Point(193, 54)
        Me.MateriaOrganicaTextBox.Name = "MateriaOrganicaTextBox"
        Me.MateriaOrganicaTextBox.Size = New System.Drawing.Size(45, 21)
        Me.MateriaOrganicaTextBox.TabIndex = 35
        '
        'CianoDensidadTextBox
        '
        Me.CianoDensidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "CianoDensidad", True))
        Me.CianoDensidadTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.CianoDensidadTextBox.Location = New System.Drawing.Point(193, 80)
        Me.CianoDensidadTextBox.Name = "CianoDensidadTextBox"
        Me.CianoDensidadTextBox.Size = New System.Drawing.Size(45, 21)
        Me.CianoDensidadTextBox.TabIndex = 37
        '
        'DiatoDensidadTextBox
        '
        Me.DiatoDensidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "DiatoDensidad", True))
        Me.DiatoDensidadTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.DiatoDensidadTextBox.Location = New System.Drawing.Point(193, 106)
        Me.DiatoDensidadTextBox.Name = "DiatoDensidadTextBox"
        Me.DiatoDensidadTextBox.Size = New System.Drawing.Size(45, 21)
        Me.DiatoDensidadTextBox.TabIndex = 39
        '
        'EcoliTextBox
        '
        Me.EcoliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Ecoli", True))
        Me.EcoliTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.EcoliTextBox.Location = New System.Drawing.Point(193, 132)
        Me.EcoliTextBox.Name = "EcoliTextBox"
        Me.EcoliTextBox.Size = New System.Drawing.Size(45, 21)
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
        Me.MuestrasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MuestrasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MuestrasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MuestrasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MuestrasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MuestrasBindingNavigator.Name = "MuestrasBindingNavigator"
        Me.MuestrasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MuestrasBindingNavigator.Size = New System.Drawing.Size(1092, 37)
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
        Me.grpMuestra.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMuestra.Location = New System.Drawing.Point(12, 49)
        Me.grpMuestra.Name = "grpMuestra"
        Me.grpMuestra.Size = New System.Drawing.Size(425, 148)
        Me.grpMuestra.TabIndex = 57
        Me.grpMuestra.TabStop = False
        Me.grpMuestra.Text = "Datos de la muestra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(210, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "mg/L"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(210, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "mg/L"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "mg/L"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(210, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "mg/L"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(210, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "mg/L"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "mg/L"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(210, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "m2/seg"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "NTU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "°C"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "mS/cm"
        '
        'HelpFQ
        '
        Me.HelpFQ.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.HelpFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpFQ.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpFQ.Location = New System.Drawing.Point(285, 339)
        Me.HelpFQ.Name = "HelpFQ"
        Me.HelpFQ.Size = New System.Drawing.Size(28, 23)
        Me.HelpFQ.TabIndex = 76
        Me.HelpFQ.TabStop = False
        Me.HelpFQ.Text = "?"
        Me.HelpFQ.UseVisualStyleBackColor = True
        '
        'FQBODTextBox
        '
        Me.FQBODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "FQBOD", True))
        Me.FQBODTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FQBODTextBox.Location = New System.Drawing.Point(167, 284)
        Me.FQBODTextBox.Name = "FQBODTextBox"
        Me.FQBODTextBox.Size = New System.Drawing.Size(37, 21)
        Me.FQBODTextBox.TabIndex = 67
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(244, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "UFC/mL"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(244, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(244, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "cél/mL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(244, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "mg/cm2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(244, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "mg/L"
        '
        'HelpBiologicos
        '
        Me.HelpBiologicos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.HelpBiologicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBiologicos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.HelpBiologicos.Location = New System.Drawing.Point(289, 348)
        Me.HelpBiologicos.Name = "HelpBiologicos"
        Me.HelpBiologicos.Size = New System.Drawing.Size(28, 23)
        Me.HelpBiologicos.TabIndex = 82
        Me.HelpBiologicos.TabStop = False
        Me.HelpBiologicos.Text = "?"
        Me.HelpBiologicos.UseVisualStyleBackColor = True
        '
        'ClorofilaATextBox
        '
        Me.ClorofilaATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "ClorofilaA", True))
        Me.ClorofilaATextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ClorofilaATextBox.Location = New System.Drawing.Point(193, 28)
        Me.ClorofilaATextBox.Name = "ClorofilaATextBox"
        Me.ClorofilaATextBox.Size = New System.Drawing.Size(45, 21)
        Me.ClorofilaATextBox.TabIndex = 33
        '
        'HelpHabitat
        '
        Me.HelpHabitat.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.HelpHabitat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpHabitat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpHabitat.Location = New System.Drawing.Point(287, 348)
        Me.HelpHabitat.Name = "HelpHabitat"
        Me.HelpHabitat.Size = New System.Drawing.Size(28, 23)
        Me.HelpHabitat.TabIndex = 87
        Me.HelpHabitat.TabStop = False
        Me.HelpHabitat.Text = "?"
        Me.HelpHabitat.UseVisualStyleBackColor = True
        '
        'DivBasuraComboBox
        '
        Me.DivBasuraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "DivBasura", True))
        Me.DivBasuraComboBox.FormattingEnabled = True
        Me.DivBasuraComboBox.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.DivBasuraComboBox.Location = New System.Drawing.Point(162, 123)
        Me.DivBasuraComboBox.Name = "DivBasuraComboBox"
        Me.DivBasuraComboBox.Size = New System.Drawing.Size(126, 21)
        Me.DivBasuraComboBox.TabIndex = 46
        '
        'NaturalidadComboBox
        '
        Me.NaturalidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Naturalidad", True))
        Me.NaturalidadComboBox.FormattingEnabled = True
        Me.NaturalidadComboBox.Items.AddRange(New Object() {"", "0", "2.5", "5", "7.5", "10"})
        Me.NaturalidadComboBox.Location = New System.Drawing.Point(162, 68)
        Me.NaturalidadComboBox.Name = "NaturalidadComboBox"
        Me.NaturalidadComboBox.Size = New System.Drawing.Size(126, 21)
        Me.NaturalidadComboBox.TabIndex = 44
        '
        'AbuBasuraComboBox
        '
        Me.AbuBasuraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "AbuBasura", True))
        Me.AbuBasuraComboBox.FormattingEnabled = True
        Me.AbuBasuraComboBox.Items.AddRange(New Object() {"", "0", "2.5", "5", "7.5", "10"})
        Me.AbuBasuraComboBox.Location = New System.Drawing.Point(161, 96)
        Me.AbuBasuraComboBox.Name = "AbuBasuraComboBox"
        Me.AbuBasuraComboBox.Size = New System.Drawing.Size(127, 21)
        Me.AbuBasuraComboBox.TabIndex = 45
        '
        'ConectividadComboBox
        '
        Me.ConectividadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Conectividad", True))
        Me.ConectividadComboBox.FormattingEnabled = True
        Me.ConectividadComboBox.Items.AddRange(New Object() {"", "0", "2.5", "5", "7.5", "10"})
        Me.ConectividadComboBox.Location = New System.Drawing.Point(162, 41)
        Me.ConectividadComboBox.Name = "ConectividadComboBox"
        Me.ConectividadComboBox.Size = New System.Drawing.Size(126, 21)
        Me.ConectividadComboBox.TabIndex = 43
        '
        'OlorComboBox
        '
        Me.OlorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Olor", True))
        Me.OlorComboBox.FormattingEnabled = True
        Me.OlorComboBox.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.OlorComboBox.Location = New System.Drawing.Point(162, 14)
        Me.OlorComboBox.Name = "OlorComboBox"
        Me.OlorComboBox.Size = New System.Drawing.Size(126, 21)
        Me.OlorComboBox.TabIndex = 42
        '
        'HelpIndices
        '
        Me.HelpIndices.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.HelpIndices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpIndices.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpIndices.Location = New System.Drawing.Point(439, 2)
        Me.HelpIndices.Name = "HelpIndices"
        Me.HelpIndices.Size = New System.Drawing.Size(28, 23)
        Me.HelpIndices.TabIndex = 91
        Me.HelpIndices.TabStop = False
        Me.HelpIndices.Text = "?"
        Me.HelpIndices.UseVisualStyleBackColor = True
        '
        'IEcoPlataValor
        '
        Me.IEcoPlataValor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMRPlataBindingSource, "Indice", True))
        Me.IEcoPlataValor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IEcoPlataValor.Location = New System.Drawing.Point(96, 31)
        Me.IEcoPlataValor.Name = "IEcoPlataValor"
        Me.IEcoPlataValor.Size = New System.Drawing.Size(63, 21)
        Me.IEcoPlataValor.TabIndex = 63
        Me.IEcoPlataValor.TabStop = False
        '
        'IMRPlataBindingSource
        '
        Me.IMRPlataBindingSource.DataMember = "MuestrasIMRPlata"
        Me.IMRPlataBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'grpIndices
        '
        Me.grpIndices.Controls.Add(Me.IBPAMPSignifica)
        Me.grpIndices.Controls.Add(Me.C1Button5)
        Me.grpIndices.Controls.Add(IndiceLabel1)
        Me.grpIndices.Controls.Add(Me.IndiceTextBox)
        Me.grpIndices.Controls.Add(Me.chkLimitarEutrofizacion)
        Me.grpIndices.Controls.Add(Me.chkLimitarIMRP)
        Me.grpIndices.Controls.Add(Me.chkLimitarIDP)
        Me.grpIndices.Controls.Add(Me.chkLimitarIERPlata)
        Me.grpIndices.Controls.Add(Me.C1Button4)
        Me.grpIndices.Controls.Add(Me.HelpIndices)
        Me.grpIndices.Controls.Add(Me.C1Button3)
        Me.grpIndices.Controls.Add(Me.EutrofizacionSignifica)
        Me.grpIndices.Controls.Add(Me.C1Button1)
        Me.grpIndices.Controls.Add(Me.IMRPSignifica)
        Me.grpIndices.Controls.Add(Me.IDPSignifica)
        Me.grpIndices.Controls.Add(Me.IEcoPlataSignifica)
        Me.grpIndices.Controls.Add(ValorLabel2)
        Me.grpIndices.Controls.Add(Me.EutrofizacionValor)
        Me.grpIndices.Controls.Add(ValorLabel1)
        Me.grpIndices.Controls.Add(Me.IMRPTextBox)
        Me.grpIndices.Controls.Add(ValorLabel)
        Me.grpIndices.Controls.Add(Me.IDPTextbox)
        Me.grpIndices.Controls.Add(IndiceLabel)
        Me.grpIndices.Controls.Add(Me.IEcoPlataValor)
        Me.grpIndices.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpIndices.Location = New System.Drawing.Point(466, 53)
        Me.grpIndices.Name = "grpIndices"
        Me.grpIndices.Size = New System.Drawing.Size(487, 222)
        Me.grpIndices.TabIndex = 64
        Me.grpIndices.TabStop = False
        Me.grpIndices.Text = "Índices"
        '
        'IBPAMPSignifica
        '
        Me.IBPAMPSignifica.BackColor = System.Drawing.Color.LightGray
        Me.IBPAMPSignifica.Enabled = False
        Me.IBPAMPSignifica.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.IBPAMPSignifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IBPAMPSignifica.Location = New System.Drawing.Point(169, 140)
        Me.IBPAMPSignifica.Name = "IBPAMPSignifica"
        Me.IBPAMPSignifica.Size = New System.Drawing.Size(118, 23)
        Me.IBPAMPSignifica.TabIndex = 99
        Me.IBPAMPSignifica.TabStop = False
        Me.IBPAMPSignifica.UseVisualStyleBackColor = False
        '
        'C1Button5
        '
        Me.C1Button5.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Button5.Location = New System.Drawing.Point(293, 142)
        Me.C1Button5.Name = "C1Button5"
        Me.C1Button5.Size = New System.Drawing.Size(103, 23)
        Me.C1Button5.TabIndex = 98
        Me.C1Button5.TabStop = False
        Me.C1Button5.Text = "Calcular IBPAMP"
        Me.C1Button5.UseVisualStyleBackColor = True
        Me.C1Button5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        '
        'IndiceTextBox
        '
        Me.IndiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IBPAMPBindingSource, "Indice", True))
        Me.IndiceTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndiceTextBox.Location = New System.Drawing.Point(96, 142)
        Me.IndiceTextBox.Name = "IndiceTextBox"
        Me.IndiceTextBox.Size = New System.Drawing.Size(63, 21)
        Me.IndiceTextBox.TabIndex = 97
        '
        'IBPAMPBindingSource
        '
        Me.IBPAMPBindingSource.DataMember = "MuestrasIBPAMP"
        Me.IBPAMPBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'chkLimitarEutrofizacion
        '
        Me.chkLimitarEutrofizacion.AutoSize = True
        Me.chkLimitarEutrofizacion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLimitarEutrofizacion.Location = New System.Drawing.Point(402, 113)
        Me.chkLimitarEutrofizacion.Name = "chkLimitarEutrofizacion"
        Me.chkLimitarEutrofizacion.Size = New System.Drawing.Size(65, 17)
        Me.chkLimitarEutrofizacion.TabIndex = 96
        Me.chkLimitarEutrofizacion.TabStop = False
        Me.chkLimitarEutrofizacion.Text = "Limitar"
        Me.chkLimitarEutrofizacion.UseVisualStyleBackColor = True
        '
        'chkLimitarIMRP
        '
        Me.chkLimitarIMRP.AutoSize = True
        Me.chkLimitarIMRP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLimitarIMRP.Location = New System.Drawing.Point(402, 87)
        Me.chkLimitarIMRP.Name = "chkLimitarIMRP"
        Me.chkLimitarIMRP.Size = New System.Drawing.Size(65, 17)
        Me.chkLimitarIMRP.TabIndex = 95
        Me.chkLimitarIMRP.TabStop = False
        Me.chkLimitarIMRP.Text = "Limitar"
        Me.chkLimitarIMRP.UseVisualStyleBackColor = True
        '
        'chkLimitarIDP
        '
        Me.chkLimitarIDP.AutoSize = True
        Me.chkLimitarIDP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLimitarIDP.Location = New System.Drawing.Point(402, 60)
        Me.chkLimitarIDP.Name = "chkLimitarIDP"
        Me.chkLimitarIDP.Size = New System.Drawing.Size(65, 17)
        Me.chkLimitarIDP.TabIndex = 94
        Me.chkLimitarIDP.TabStop = False
        Me.chkLimitarIDP.Text = "Limitar"
        Me.chkLimitarIDP.UseVisualStyleBackColor = True
        '
        'chkLimitarIERPlata
        '
        Me.chkLimitarIERPlata.AutoSize = True
        Me.chkLimitarIERPlata.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLimitarIERPlata.Location = New System.Drawing.Point(402, 31)
        Me.chkLimitarIERPlata.Name = "chkLimitarIERPlata"
        Me.chkLimitarIERPlata.Size = New System.Drawing.Size(65, 17)
        Me.chkLimitarIERPlata.TabIndex = 93
        Me.chkLimitarIERPlata.TabStop = False
        Me.chkLimitarIERPlata.Text = "Limitar"
        Me.chkLimitarIERPlata.UseVisualStyleBackColor = True
        '
        'C1Button4
        '
        Me.C1Button4.Location = New System.Drawing.Point(293, 84)
        Me.C1Button4.Name = "C1Button4"
        Me.C1Button4.Size = New System.Drawing.Size(103, 23)
        Me.C1Button4.TabIndex = 92
        Me.C1Button4.TabStop = False
        Me.C1Button4.Text = "Calcular IMRP"
        Me.C1Button4.UseVisualStyleBackColor = True
        Me.C1Button4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        '
        'C1Button3
        '
        Me.C1Button3.Location = New System.Drawing.Point(293, 57)
        Me.C1Button3.Name = "C1Button3"
        Me.C1Button3.Size = New System.Drawing.Size(103, 23)
        Me.C1Button3.TabIndex = 69
        Me.C1Button3.TabStop = False
        Me.C1Button3.Text = "Calcular IDP"
        Me.C1Button3.UseVisualStyleBackColor = True
        Me.C1Button3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        '
        'EutrofizacionSignifica
        '
        Me.EutrofizacionSignifica.BackColor = System.Drawing.Color.LightGray
        Me.EutrofizacionSignifica.Enabled = False
        Me.EutrofizacionSignifica.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.EutrofizacionSignifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EutrofizacionSignifica.Location = New System.Drawing.Point(169, 113)
        Me.EutrofizacionSignifica.Name = "EutrofizacionSignifica"
        Me.EutrofizacionSignifica.Size = New System.Drawing.Size(118, 23)
        Me.EutrofizacionSignifica.TabIndex = 68
        Me.EutrofizacionSignifica.TabStop = False
        Me.EutrofizacionSignifica.Text = "No se calculará"
        Me.EutrofizacionSignifica.UseVisualStyleBackColor = False
        '
        'C1Button1
        '
        Me.C1Button1.Location = New System.Drawing.Point(9, 186)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(281, 30)
        Me.C1Button1.TabIndex = 65
        Me.C1Button1.Text = "Calcular Índices"
        Me.C1Button1.UseVisualStyleBackColor = True
        Me.C1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'IMRPSignifica
        '
        Me.IMRPSignifica.BackColor = System.Drawing.Color.LightGray
        Me.IMRPSignifica.Enabled = False
        Me.IMRPSignifica.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.IMRPSignifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IMRPSignifica.Location = New System.Drawing.Point(169, 85)
        Me.IMRPSignifica.Name = "IMRPSignifica"
        Me.IMRPSignifica.Size = New System.Drawing.Size(118, 23)
        Me.IMRPSignifica.TabIndex = 69
        Me.IMRPSignifica.TabStop = False
        Me.IMRPSignifica.UseVisualStyleBackColor = False
        '
        'IDPSignifica
        '
        Me.IDPSignifica.BackColor = System.Drawing.Color.LightGray
        Me.IDPSignifica.Enabled = False
        Me.IDPSignifica.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.IDPSignifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IDPSignifica.Location = New System.Drawing.Point(169, 57)
        Me.IDPSignifica.Name = "IDPSignifica"
        Me.IDPSignifica.Size = New System.Drawing.Size(118, 23)
        Me.IDPSignifica.TabIndex = 68
        Me.IDPSignifica.TabStop = False
        Me.IDPSignifica.UseVisualStyleBackColor = False
        '
        'IEcoPlataSignifica
        '
        Me.IEcoPlataSignifica.BackColor = System.Drawing.Color.LightGray
        Me.IEcoPlataSignifica.Enabled = False
        Me.IEcoPlataSignifica.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.IEcoPlataSignifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IEcoPlataSignifica.Location = New System.Drawing.Point(169, 29)
        Me.IEcoPlataSignifica.Name = "IEcoPlataSignifica"
        Me.IEcoPlataSignifica.Size = New System.Drawing.Size(118, 23)
        Me.IEcoPlataSignifica.TabIndex = 67
        Me.IEcoPlataSignifica.TabStop = False
        Me.IEcoPlataSignifica.Text = "No se calculará"
        Me.IEcoPlataSignifica.UseVisualStyleBackColor = False
        '
        'EutrofizacionValor
        '
        Me.EutrofizacionValor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EutrofizacionBindingSource, "Valor", True))
        Me.EutrofizacionValor.Location = New System.Drawing.Point(96, 114)
        Me.EutrofizacionValor.Name = "EutrofizacionValor"
        Me.EutrofizacionValor.Size = New System.Drawing.Size(63, 21)
        Me.EutrofizacionValor.TabIndex = 66
        Me.EutrofizacionValor.TabStop = False
        '
        'EutrofizacionBindingSource
        '
        Me.EutrofizacionBindingSource.DataMember = "MuestrasEutrofizacion"
        Me.EutrofizacionBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'IMRPTextBox
        '
        Me.IMRPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMRPBindingSource, "Valor", True))
        Me.IMRPTextBox.Location = New System.Drawing.Point(96, 86)
        Me.IMRPTextBox.Name = "IMRPTextBox"
        Me.IMRPTextBox.Size = New System.Drawing.Size(63, 21)
        Me.IMRPTextBox.TabIndex = 65
        Me.IMRPTextBox.TabStop = False
        '
        'IMRPBindingSource
        '
        Me.IMRPBindingSource.DataMember = "MuestrasIMRP"
        Me.IMRPBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'IDPTextbox
        '
        Me.IDPTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDPBindingSource, "Valor", True))
        Me.IDPTextbox.Location = New System.Drawing.Point(96, 59)
        Me.IDPTextbox.Name = "IDPTextbox"
        Me.IDPTextbox.Size = New System.Drawing.Size(63, 21)
        Me.IDPTextbox.TabIndex = 64
        Me.IDPTextbox.TabStop = False
        '
        'IDPBindingSource
        '
        Me.IDPBindingSource.DataMember = "MuestrasIDP"
        Me.IDPBindingSource.DataSource = Me.MuestrasBindingSource
        '
        'C1Button2
        '
        Me.C1Button2.Location = New System.Drawing.Point(466, 583)
        Me.C1Button2.Name = "C1Button2"
        Me.C1Button2.Size = New System.Drawing.Size(281, 30)
        Me.C1Button2.TabIndex = 66
        Me.C1Button2.Text = "Generar Reporte del Proyecto"
        Me.C1Button2.UseVisualStyleBackColor = True
        Me.C1Button2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
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
        Me.TableAdapterManager.CaracDiatomeasTableAdapter = Nothing
        Me.TableAdapterManager.CaracMacroinvIMRPTableAdapter = Nothing
        Me.TableAdapterManager.CianoSpTableAdapter = Nothing
        Me.TableAdapterManager.DiatomeasSpParte2TableAdapter = Nothing
        Me.TableAdapterManager.DiatomeasSpTableAdapter = Nothing
        Me.TableAdapterManager.EutrofizacionTableAdapter = Me.EutrofizacionTableAdapter
        Me.TableAdapterManager.IBPAMPTableAdapter = Me.IBPAMPTableAdapter
        Me.TableAdapterManager.IDPTableAdapter = Me.IDPTableAdapter
        Me.TableAdapterManager.IMRPlataTableAdapter = Me.IMRPlataTableAdapter
        Me.TableAdapterManager.IMRPTableAdapter = Me.IMRPTableAdapter
        Me.TableAdapterManager.MacroinvSpIBPAMPTableAdapter = Nothing
        Me.TableAdapterManager.MacroinvSpIMRPTableAdapter = Nothing
        Me.TableAdapterManager.MuestrasTableAdapter = Me.MuestrasTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Scila7.Scilla10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EutrofizacionTableAdapter
        '
        Me.EutrofizacionTableAdapter.ClearBeforeFill = True
        '
        'IBPAMPTableAdapter
        '
        Me.IBPAMPTableAdapter.ClearBeforeFill = True
        '
        'IDPTableAdapter
        '
        Me.IDPTableAdapter.ClearBeforeFill = True
        '
        'IMRPlataTableAdapter
        '
        Me.IMRPlataTableAdapter.ClearBeforeFill = True
        '
        'IMRPTableAdapter
        '
        Me.IMRPTableAdapter.ClearBeforeFill = True
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
        Me.ComboBox15.Location = New System.Drawing.Point(626, 12)
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
        'C1DockingTab1
        '
        Me.C1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.C1DockingTab1.BackColor = System.Drawing.Color.White
        Me.C1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab1.Location = New System.Drawing.Point(12, 203)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.Size = New System.Drawing.Size(425, 411)
        Me.C1DockingTab1.TabIndex = 71
        Me.C1DockingTab1.TabLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TextDirection = C1.Win.C1Command.TabTextDirectionEnum.Horizontal
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.HelpHabitat)
        Me.C1DockingTabPage2.Controls.Add(Me.DivBasuraComboBox)
        Me.C1DockingTabPage2.Controls.Add(OlorLabel)
        Me.C1DockingTabPage2.Controls.Add(Me.NaturalidadComboBox)
        Me.C1DockingTabPage2.Controls.Add(ConectividadLabel)
        Me.C1DockingTabPage2.Controls.Add(Me.AbuBasuraComboBox)
        Me.C1DockingTabPage2.Controls.Add(NaturalidadLabel)
        Me.C1DockingTabPage2.Controls.Add(DivBasuraLabel)
        Me.C1DockingTabPage2.Controls.Add(Me.OlorComboBox)
        Me.C1DockingTabPage2.Controls.Add(Me.ConectividadComboBox)
        Me.C1DockingTabPage2.Controls.Add(AbuBasuraLabel)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(98, 1)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(326, 409)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "Hábitat"
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.HelpFQ)
        Me.C1DockingTabPage3.Controls.Add(Me.Label10)
        Me.C1DockingTabPage3.Controls.Add(Me.Label9)
        Me.C1DockingTabPage3.Controls.Add(FQpHLabel)
        Me.C1DockingTabPage3.Controls.Add(Me.Label8)
        Me.C1DockingTabPage3.Controls.Add(FQCaudalLabel)
        Me.C1DockingTabPage3.Controls.Add(Me.Label7)
        Me.C1DockingTabPage3.Controls.Add(Me.FQTurbTextBox)
        Me.C1DockingTabPage3.Controls.Add(Me.Label6)
        Me.C1DockingTabPage3.Controls.Add(Me.FQCaudalTextBox)
        Me.C1DockingTabPage3.Controls.Add(Me.Label5)
        Me.C1DockingTabPage3.Controls.Add(FQTurbLabel)
        Me.C1DockingTabPage3.Controls.Add(Me.Label4)
        Me.C1DockingTabPage3.Controls.Add(FQODLabel)
        Me.C1DockingTabPage3.Controls.Add(Me.Label3)
        Me.C1DockingTabPage3.Controls.Add(Me.FQCondTextBox)
        Me.C1DockingTabPage3.Controls.Add(Me.Label2)
        Me.C1DockingTabPage3.Controls.Add(Me.FQODTextBox)
        Me.C1DockingTabPage3.Controls.Add(Me.Label1)
        Me.C1DockingTabPage3.Controls.Add(FQCondLabel)
        Me.C1DockingTabPage3.Controls.Add(FQNitratosLabel)
        Me.C1DockingTabPage3.Controls.Add(FQBODLabel)
        Me.C1DockingTabPage3.Controls.Add(Me.FQTempTextBox)
        Me.C1DockingTabPage3.Controls.Add(Me.FQpHTextBox)
        Me.C1DockingTabPage3.Controls.Add(Me.FQNitratosTextBox)
        Me.C1DockingTabPage3.Controls.Add(Me.FQBODTextBox)
        Me.C1DockingTabPage3.Controls.Add(FQTempLabel)
        Me.C1DockingTabPage3.Controls.Add(Me.FQFosfatoTextBox)
        Me.C1DockingTabPage3.Controls.Add(FQNitritosLabel)
        Me.C1DockingTabPage3.Controls.Add(FQFosfatoLabel)
        Me.C1DockingTabPage3.Controls.Add(Me.FQNitritosTextBox)
        Me.C1DockingTabPage3.Controls.Add(Me.FQAmonioTextBox)
        Me.C1DockingTabPage3.Controls.Add(FQAmonioLabel)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(98, 1)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(326, 409)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "Físico-químicos"
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Controls.Add(Me.Label15)
        Me.C1DockingTabPage4.Controls.Add(Me.Label14)
        Me.C1DockingTabPage4.Controls.Add(ClorofilaALabel)
        Me.C1DockingTabPage4.Controls.Add(Me.Label13)
        Me.C1DockingTabPage4.Controls.Add(MateriaOrganicaLabel)
        Me.C1DockingTabPage4.Controls.Add(Me.Label12)
        Me.C1DockingTabPage4.Controls.Add(Me.MateriaOrganicaTextBox)
        Me.C1DockingTabPage4.Controls.Add(Me.Label11)
        Me.C1DockingTabPage4.Controls.Add(CianoDensidadLabel)
        Me.C1DockingTabPage4.Controls.Add(Me.HelpBiologicos)
        Me.C1DockingTabPage4.Controls.Add(Me.CianoDensidadTextBox)
        Me.C1DockingTabPage4.Controls.Add(Me.ClorofilaATextBox)
        Me.C1DockingTabPage4.Controls.Add(DiatoDensidadLabel)
        Me.C1DockingTabPage4.Controls.Add(Me.EcoliTextBox)
        Me.C1DockingTabPage4.Controls.Add(Me.DiatoDensidadTextBox)
        Me.C1DockingTabPage4.Controls.Add(EcoliLabel)
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(98, 1)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(326, 409)
        Me.C1DockingTabPage4.TabIndex = 3
        Me.C1DockingTabPage4.Text = "Biológicos"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(555, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 14)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Muestra:"
        '
        'frmMuestrasRLP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1092, 662)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grpMuestra)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.MuestrasDataGridView)
        Me.Controls.Add(Me.ComboBox15)
        Me.Controls.Add(Me.C1Button2)
        Me.Controls.Add(Me.grpIndices)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
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
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EutrofizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage2.ResumeLayout(False)
        Me.C1DockingTabPage2.PerformLayout()
        Me.C1DockingTabPage3.ResumeLayout(False)
        Me.C1DockingTabPage3.PerformLayout()
        Me.C1DockingTabPage4.ResumeLayout(False)
        Me.C1DockingTabPage4.PerformLayout()
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
    Friend WithEvents IMRPlataTableAdapter As Scila7.Scilla10DataSetTableAdapters.IMRPlataTableAdapter
    Friend WithEvents IMRPlataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grpMuestra As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IEcoPlataValor As System.Windows.Forms.TextBox
    Friend WithEvents grpIndices As System.Windows.Forms.GroupBox
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents C1Button2 As C1.Win.C1Input.C1Button
    Friend WithEvents IDPTableAdapter As Scila7.Scilla10DataSetTableAdapters.IDPTableAdapter
    Friend WithEvents IDPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMRPTableAdapter As Scila7.Scilla10DataSetTableAdapters.IMRPTableAdapter
    Friend WithEvents IMRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMRPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EutrofizacionTableAdapter As Scila7.Scilla10DataSetTableAdapters.EutrofizacionTableAdapter
    Friend WithEvents EutrofizacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EutrofizacionValor As System.Windows.Forms.TextBox
    Friend WithEvents EutrofizacionSignifica As System.Windows.Forms.Button
    Friend WithEvents IMRPSignifica As System.Windows.Forms.Button
    Friend WithEvents IEcoPlataSignifica As System.Windows.Forms.Button
    Friend WithEvents tmrCheckIndices As System.Windows.Forms.Timer
    Friend WithEvents ConectividadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OlorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NaturalidadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DivBasuraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AbuBasuraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents C1Button3 As C1.Win.C1Input.C1Button
    Friend WithEvents IDPSignifica As System.Windows.Forms.Button
    Friend WithEvents IDPTextbox As System.Windows.Forms.TextBox
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
    Friend WithEvents HelpFQ As System.Windows.Forms.Button
    Friend WithEvents HelpBiologicos As System.Windows.Forms.Button
    Friend WithEvents HelpIndices As System.Windows.Forms.Button
    Friend WithEvents HelpHabitat As System.Windows.Forms.Button
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
    Friend WithEvents C1Button4 As C1.Win.C1Input.C1Button
    Friend WithEvents chkLimitarEutrofizacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkLimitarIMRP As System.Windows.Forms.CheckBox
    Friend WithEvents chkLimitarIDP As System.Windows.Forms.CheckBox
    Friend WithEvents chkLimitarIERPlata As System.Windows.Forms.CheckBox
    Friend WithEvents ClorofilaATextBox As System.Windows.Forms.TextBox
    Friend WithEvents C1OutPage2 As C1.Win.C1Command.C1OutPage
    Friend WithEvents C1OutPage3 As C1.Win.C1Command.C1OutPage
    Friend WithEvents C1OutPage4 As C1.Win.C1Command.C1OutPage
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents IBPAMPTableAdapter As Scila7.Scilla10DataSetTableAdapters.IBPAMPTableAdapter
    Friend WithEvents IBPAMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IndiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C1Button5 As C1.Win.C1Input.C1Button
    Friend WithEvents IBPAMPSignifica As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
