<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMacroInv
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim RangoLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim ValorLabel1 As System.Windows.Forms.Label
        Dim IndiceLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim IdMuestraLabel1 As System.Windows.Forms.Label
        Dim IdProyectoLabel1 As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim IdProyectoLabel2 As System.Windows.Forms.Label
        Dim IdMuestraLabel2 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim IdProyectoLabel As System.Windows.Forms.Label
        Dim IdMuestraLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CodigoSitioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMacroInv))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MacroInvDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMRP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IBPAMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MacroInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndicesDataSet = New Scila7.IndicesDataSet
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet
        Me.MacroInvTableAdapter = New Scila7.IndicesDataSetTableAdapters.MacroInvTableAdapter
        Me.TableAdapterManager = New Scila7.IndicesDataSetTableAdapters.TableAdapterManager
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
        Me.ImrpDataSet = New Scila7.imrpDataSet
        Me.CaracMacroinvIMRPTableAdapter = New Scila7.imrpDataSetTableAdapters.CaracMacroinvIMRPTableAdapter
        Me.imrpTaxaGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.MacroinvSpIMRPBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImrpDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DensidadTextBox = New System.Windows.Forms.TextBox
        Me.CaracMacroinvIMRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutorTextBox = New System.Windows.Forms.TextBox
        Me.RangoTextBox = New System.Windows.Forms.TextBox
        Me.NotasTextBox = New System.Windows.Forms.TextBox
        Me.MostrarDatosIMRP = New System.Windows.Forms.DataGridView
        Me.Taxón = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vx = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpIMRP = New System.Windows.Forms.GroupBox
        Me.IMRPId = New System.Windows.Forms.TextBox
        Me.IMRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMRPSignifica = New System.Windows.Forms.Button
        Me.IMRPIdMuestra = New System.Windows.Forms.TextBox
        Me.IMRPIdProyecto = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ValorTextBox = New System.Windows.Forms.TextBox
        Me.ValorIMRP = New System.Windows.Forms.TextBox
        Me.chkIMRP = New System.Windows.Forms.CheckBox
        Me.btnBorrarSpIMRP = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.grpTaxon = New System.Windows.Forms.GroupBox
        Me.grpDatosTaxon = New System.Windows.Forms.GroupBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.USTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CategoriaIBPAMPTextBox = New System.Windows.Forms.TextBox
        Me.grpIBPAMP = New System.Windows.Forms.GroupBox
        Me.IBPAMPSignifica = New System.Windows.Forms.Button
        Me.ValorIBPAMP = New System.Windows.Forms.TextBox
        Me.IBPAMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbpampDataSet = New Scila7.ibpampDataSet
        Me.IBPAMPId = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.IBPAMPIdProyecto = New System.Windows.Forms.TextBox
        Me.CaracIBPAMPDataGridView = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AutorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaracMacroinvIBPAMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtUStotales = New System.Windows.Forms.TextBox
        Me.MacroinvSpIBPAMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IBPAMPIdMuestra = New System.Windows.Forms.TextBox
        Me.Cat7TextBox = New System.Windows.Forms.TextBox
        Me.Cat6TextBox = New System.Windows.Forms.TextBox
        Me.Cat5TextBox = New System.Windows.Forms.TextBox
        Me.Cat4TextBox = New System.Windows.Forms.TextBox
        Me.btnBorrarSpIBPAMP = New System.Windows.Forms.Button
        Me.Cat3TextBox = New System.Windows.Forms.TextBox
        Me.MostrarDatosIBPAMP = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Categoría = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chkIBPAMP = New System.Windows.Forms.CheckBox
        Me.ibpampTaxaGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Cat2TextBox = New System.Windows.Forms.TextBox
        Me.Cat1TextBox = New System.Windows.Forms.TextBox
        Me.IMRPTableAdapter = New Scila7.imrpDataSetTableAdapters.IMRPTableAdapter
        Me.IBPAMPTableAdapter = New Scila7.ibpampDataSetTableAdapters.IBPAMPTableAdapter
        Me.CaracMacroinvIBPAMPTableAdapter = New Scila7.ibpampDataSetTableAdapters.CaracMacroinvIBPAMPTableAdapter
        Me.MuestrasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.EditTootStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCalcularIndices = New System.Windows.Forms.Button
        Me.grpMuestra = New System.Windows.Forms.GroupBox
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnEditarSitios = New C1.Win.C1Input.C1Button
        Me.CoordLONGTextBox = New System.Windows.Forms.TextBox
        Me.CoordLATTextBox = New System.Windows.Forms.TextBox
        Me.CodigoSitioComboBox = New System.Windows.Forms.ComboBox
        Me.SitiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SitiosDataSet = New Scila7.sitiosDataSet
        Me.IdProyectoTextBox = New System.Windows.Forms.TextBox
        Me.IdMuestraTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.CodigoSitioTextBox = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.SitiosTableAdapter = New Scila7.sitiosDataSetTableAdapters.SitiosTableAdapter
        NombreLabel = New System.Windows.Forms.Label
        AutorLabel = New System.Windows.Forms.Label
        ValorLabel = New System.Windows.Forms.Label
        RangoLabel = New System.Windows.Forms.Label
        NotasLabel = New System.Windows.Forms.Label
        ValorLabel1 = New System.Windows.Forms.Label
        IndiceLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CategoriaLabel = New System.Windows.Forms.Label
        IdLabel = New System.Windows.Forms.Label
        IdMuestraLabel1 = New System.Windows.Forms.Label
        IdProyectoLabel1 = New System.Windows.Forms.Label
        IdLabel1 = New System.Windows.Forms.Label
        IdProyectoLabel2 = New System.Windows.Forms.Label
        IdMuestraLabel2 = New System.Windows.Forms.Label
        Label25 = New System.Windows.Forms.Label
        Label24 = New System.Windows.Forms.Label
        IdProyectoLabel = New System.Windows.Forms.Label
        IdMuestraLabel = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        CodigoSitioLabel = New System.Windows.Forms.Label
        CType(Me.MacroInvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MacroInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImrpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imrpTaxaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MacroinvSpIMRPBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImrpDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaracMacroinvIMRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarDatosIMRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIMRP.SuspendLayout()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTaxon.SuspendLayout()
        Me.grpDatosTaxon.SuspendLayout()
        Me.grpIBPAMP.SuspendLayout()
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbpampDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CaracIBPAMPDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaracMacroinvIBPAMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MacroinvSpIBPAMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarDatosIBPAMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ibpampTaxaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        Me.grpMuestra.SuspendLayout()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitiosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.White
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(4, 21)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 6
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.BackColor = System.Drawing.Color.White
        AutorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AutorLabel.Location = New System.Drawing.Point(4, 47)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 8
        AutorLabel.Text = "Autor:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.BackColor = System.Drawing.Color.White
        ValorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorLabel.Location = New System.Drawing.Point(2, 9)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(85, 13)
        ValorLabel.TabIndex = 10
        ValorLabel.Text = "Valor IMRP (Vx):"
        '
        'RangoLabel
        '
        RangoLabel.AutoSize = True
        RangoLabel.BackColor = System.Drawing.Color.White
        RangoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RangoLabel.Location = New System.Drawing.Point(2, 34)
        RangoLabel.Name = "RangoLabel"
        RangoLabel.Size = New System.Drawing.Size(42, 13)
        RangoLabel.TabIndex = 14
        RangoLabel.Text = "Rango:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.BackColor = System.Drawing.Color.White
        NotasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotasLabel.Location = New System.Drawing.Point(2, 60)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(38, 13)
        NotasLabel.TabIndex = 16
        NotasLabel.Text = "Notas:"
        '
        'ValorLabel1
        '
        ValorLabel1.AutoSize = True
        ValorLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorLabel1.Location = New System.Drawing.Point(113, 259)
        ValorLabel1.Name = "ValorLabel1"
        ValorLabel1.Size = New System.Drawing.Size(42, 13)
        ValorLabel1.TabIndex = 39
        ValorLabel1.Text = "IMRP:"
        '
        'IndiceLabel
        '
        IndiceLabel.AutoSize = True
        IndiceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndiceLabel.Location = New System.Drawing.Point(96, 252)
        IndiceLabel.Name = "IndiceLabel"
        IndiceLabel.Size = New System.Drawing.Size(57, 13)
        IndiceLabel.TabIndex = 49
        IndiceLabel.Text = "IBPAMP:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Brown
        Label3.Location = New System.Drawing.Point(10, 162)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(151, 13)
        Label3.TabIndex = 47
        Label3.Text = "Unidades Sistemáticas totales:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.BackColor = System.Drawing.Color.White
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(3, 23)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(100, 13)
        CategoriaLabel.TabIndex = 46
        CategoriaLabel.Text = "Categoría IBPAMP:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(833, 8)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 62
        IdLabel.Text = "Id:"
        '
        'IdMuestraLabel1
        '
        IdMuestraLabel1.AutoSize = True
        IdMuestraLabel1.Location = New System.Drawing.Point(833, 34)
        IdMuestraLabel1.Name = "IdMuestraLabel1"
        IdMuestraLabel1.Size = New System.Drawing.Size(60, 13)
        IdMuestraLabel1.TabIndex = 64
        IdMuestraLabel1.Text = "Id Muestra:"
        '
        'IdProyectoLabel1
        '
        IdProyectoLabel1.AutoSize = True
        IdProyectoLabel1.Location = New System.Drawing.Point(833, 60)
        IdProyectoLabel1.Name = "IdProyectoLabel1"
        IdProyectoLabel1.Size = New System.Drawing.Size(64, 13)
        IdProyectoLabel1.TabIndex = 66
        IdProyectoLabel1.Text = "Id Proyecto:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(993, 36)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(19, 13)
        IdLabel1.TabIndex = 58
        IdLabel1.Text = "Id:"
        '
        'IdProyectoLabel2
        '
        IdProyectoLabel2.AutoSize = True
        IdProyectoLabel2.Location = New System.Drawing.Point(993, 62)
        IdProyectoLabel2.Name = "IdProyectoLabel2"
        IdProyectoLabel2.Size = New System.Drawing.Size(64, 13)
        IdProyectoLabel2.TabIndex = 60
        IdProyectoLabel2.Text = "Id Proyecto:"
        '
        'IdMuestraLabel2
        '
        IdMuestraLabel2.AutoSize = True
        IdMuestraLabel2.Location = New System.Drawing.Point(993, 88)
        IdMuestraLabel2.Name = "IdMuestraLabel2"
        IdMuestraLabel2.Size = New System.Drawing.Size(60, 13)
        IdMuestraLabel2.TabIndex = 62
        IdMuestraLabel2.Text = "Id Muestra:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label25.Location = New System.Drawing.Point(200, 110)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(35, 15)
        Label25.TabIndex = 119
        Label25.Text = "Long:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label24.Location = New System.Drawing.Point(82, 110)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(26, 15)
        Label24.TabIndex = 118
        Label24.Text = "Lat:"
        '
        'IdProyectoLabel
        '
        IdProyectoLabel.AutoSize = True
        IdProyectoLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdProyectoLabel.Location = New System.Drawing.Point(324, 47)
        IdProyectoLabel.Name = "IdProyectoLabel"
        IdProyectoLabel.Size = New System.Drawing.Size(72, 15)
        IdProyectoLabel.TabIndex = 2
        IdProyectoLabel.Text = "Id Proyecto:"
        '
        'IdMuestraLabel
        '
        IdMuestraLabel.AutoSize = True
        IdMuestraLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdMuestraLabel.Location = New System.Drawing.Point(323, 21)
        IdMuestraLabel.Name = "IdMuestraLabel"
        IdMuestraLabel.Size = New System.Drawing.Size(70, 15)
        IdMuestraLabel.TabIndex = 0
        IdMuestraLabel.Text = "Id Muestra:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(14, 23)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 15)
        Label4.TabIndex = 4
        Label4.Text = "Nombre:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(14, 136)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(40, 15)
        Label5.TabIndex = 10
        Label5.Text = "Autor:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(14, 50)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(42, 15)
        FechaLabel.TabIndex = 6
        FechaLabel.Text = "Fecha:"
        '
        'CodigoSitioLabel
        '
        CodigoSitioLabel.AutoSize = True
        CodigoSitioLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoSitioLabel.Location = New System.Drawing.Point(74, 77)
        CodigoSitioLabel.Name = "CodigoSitioLabel"
        CodigoSitioLabel.Size = New System.Drawing.Size(34, 15)
        CodigoSitioLabel.TabIndex = 8
        CodigoSitioLabel.Text = "Sitio:"
        '
        'MacroInvDataGridView
        '
        Me.MacroInvDataGridView.AllowUserToAddRows = False
        Me.MacroInvDataGridView.AllowUserToDeleteRows = False
        Me.MacroInvDataGridView.AutoGenerateColumns = False
        Me.MacroInvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MacroInvDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.IMRP, Me.IBPAMP})
        Me.MacroInvDataGridView.DataSource = Me.MacroInvBindingSource
        Me.MacroInvDataGridView.Location = New System.Drawing.Point(8, 19)
        Me.MacroInvDataGridView.Name = "MacroInvDataGridView"
        Me.MacroInvDataGridView.ReadOnly = True
        Me.MacroInvDataGridView.RowHeadersVisible = False
        Me.MacroInvDataGridView.Size = New System.Drawing.Size(206, 429)
        Me.MacroInvDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 322
        '
        'IMRP
        '
        Me.IMRP.DataPropertyName = "IMRP"
        Me.IMRP.HeaderText = "IMRP"
        Me.IMRP.Name = "IMRP"
        Me.IMRP.ReadOnly = True
        Me.IMRP.Visible = False
        '
        'IBPAMP
        '
        Me.IBPAMP.DataPropertyName = "IBPAMP"
        Me.IBPAMP.HeaderText = "IBPAMP"
        Me.IBPAMP.Name = "IBPAMP"
        Me.IBPAMP.ReadOnly = True
        Me.IBPAMP.Visible = False
        '
        'MacroInvBindingSource
        '
        Me.MacroInvBindingSource.DataMember = "MacroInv"
        Me.MacroInvBindingSource.DataSource = Me.IndicesDataSet
        '
        'IndicesDataSet
        '
        Me.IndicesDataSet.DataSetName = "IndicesDataSet"
        Me.IndicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MacroInvTableAdapter
        '
        Me.MacroInvTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MacroInvTableAdapter = Me.MacroInvTableAdapter
        Me.TableAdapterManager.UpdateOrder = Scila7.IndicesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'ImrpDataSet
        '
        Me.ImrpDataSet.DataSetName = "imrpDataSet"
        Me.ImrpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MacroinvSpIMRPTableAdapter
        '
        Me.MacroinvSpIMRPTableAdapter.ClearBeforeFill = True
        '
        'CaracMacroinvIMRPTableAdapter
        '
        Me.CaracMacroinvIMRPTableAdapter.ClearBeforeFill = True
        '
        'imrpTaxaGrid
        '
        Me.imrpTaxaGrid.AllowUpdate = False
        Me.imrpTaxaGrid.CaptionHeight = 17
        Me.imrpTaxaGrid.DataSource = Me.MacroinvSpIMRPBindingSource2
        Me.imrpTaxaGrid.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Inverted
        Me.imrpTaxaGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imrpTaxaGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.imrpTaxaGrid.Images.Add(CType(resources.GetObject("imrpTaxaGrid.Images"), System.Drawing.Image))
        Me.imrpTaxaGrid.Location = New System.Drawing.Point(836, 79)
        Me.imrpTaxaGrid.Name = "imrpTaxaGrid"
        Me.imrpTaxaGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.imrpTaxaGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.imrpTaxaGrid.PreviewInfo.ZoomFactor = 75
        Me.imrpTaxaGrid.PrintInfo.PageSettings = CType(resources.GetObject("imrpTaxaGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.imrpTaxaGrid.RowHeight = 15
        Me.imrpTaxaGrid.Size = New System.Drawing.Size(191, 226)
        Me.imrpTaxaGrid.TabIndex = 2
        Me.imrpTaxaGrid.Text = "C1TrueDBGrid1"
        Me.imrpTaxaGrid.Visible = False
        Me.imrpTaxaGrid.PropBag = resources.GetString("imrpTaxaGrid.PropBag")
        '
        'MacroinvSpIMRPBindingSource2
        '
        Me.MacroinvSpIMRPBindingSource2.DataMember = "MacroinvSpIMRP"
        Me.MacroinvSpIMRPBindingSource2.DataSource = Me.ImrpDataSetBindingSource
        '
        'ImrpDataSetBindingSource
        '
        Me.ImrpDataSetBindingSource.DataSource = Me.ImrpDataSet
        Me.ImrpDataSetBindingSource.Position = 0
        '
        'DensidadTextBox
        '
        Me.DensidadTextBox.Location = New System.Drawing.Point(285, 16)
        Me.DensidadTextBox.Name = "DensidadTextBox"
        Me.DensidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DensidadTextBox.TabIndex = 3
        Me.DensidadTextBox.Visible = False
        '
        'CaracMacroinvIMRPBindingSource
        '
        Me.CaracMacroinvIMRPBindingSource.DataMember = "CaracMacroinvIMRP"
        Me.CaracMacroinvIMRPBindingSource.DataSource = Me.ImrpDataSet
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Autor", True))
        Me.AutorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorTextBox.Location = New System.Drawing.Point(63, 44)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(206, 20)
        Me.AutorTextBox.TabIndex = 9
        '
        'RangoTextBox
        '
        Me.RangoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Rango", True))
        Me.RangoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RangoTextBox.Location = New System.Drawing.Point(58, 31)
        Me.RangoTextBox.Name = "RangoTextBox"
        Me.RangoTextBox.Size = New System.Drawing.Size(132, 20)
        Me.RangoTextBox.TabIndex = 15
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Notas", True))
        Me.NotasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasTextBox.Location = New System.Drawing.Point(58, 57)
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(132, 20)
        Me.NotasTextBox.TabIndex = 17
        '
        'MostrarDatosIMRP
        '
        Me.MostrarDatosIMRP.AllowUserToAddRows = False
        Me.MostrarDatosIMRP.AllowUserToDeleteRows = False
        Me.MostrarDatosIMRP.AllowUserToOrderColumns = True
        Me.MostrarDatosIMRP.AllowUserToResizeColumns = False
        Me.MostrarDatosIMRP.AllowUserToResizeRows = False
        Me.MostrarDatosIMRP.BackgroundColor = System.Drawing.Color.White
        Me.MostrarDatosIMRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MostrarDatosIMRP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Taxón, Me.Vx})
        Me.MostrarDatosIMRP.GridColor = System.Drawing.Color.White
        Me.MostrarDatosIMRP.Location = New System.Drawing.Point(205, 48)
        Me.MostrarDatosIMRP.Name = "MostrarDatosIMRP"
        Me.MostrarDatosIMRP.RowHeadersVisible = False
        Me.MostrarDatosIMRP.Size = New System.Drawing.Size(203, 226)
        Me.MostrarDatosIMRP.TabIndex = 39
        Me.MostrarDatosIMRP.TabStop = False
        '
        'Taxón
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Taxón.DefaultCellStyle = DataGridViewCellStyle1
        Me.Taxón.HeaderText = "Taxón"
        Me.Taxón.Name = "Taxón"
        '
        'Vx
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Vx.DefaultCellStyle = DataGridViewCellStyle2
        Me.Vx.HeaderText = "Vx"
        Me.Vx.Name = "Vx"
        '
        'grpIMRP
        '
        Me.grpIMRP.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpIMRP.Controls.Add(IdLabel)
        Me.grpIMRP.Controls.Add(Me.IMRPId)
        Me.grpIMRP.Controls.Add(Me.IMRPSignifica)
        Me.grpIMRP.Controls.Add(IdMuestraLabel1)
        Me.grpIMRP.Controls.Add(Me.IMRPIdMuestra)
        Me.grpIMRP.Controls.Add(IdProyectoLabel1)
        Me.grpIMRP.Controls.Add(Me.IMRPIdProyecto)
        Me.grpIMRP.Controls.Add(Me.Panel2)
        Me.grpIMRP.Controls.Add(Me.ValorIMRP)
        Me.grpIMRP.Controls.Add(Me.chkIMRP)
        Me.grpIMRP.Controls.Add(Me.btnBorrarSpIMRP)
        Me.grpIMRP.Controls.Add(ValorLabel1)
        Me.grpIMRP.Controls.Add(Me.MostrarDatosIMRP)
        Me.grpIMRP.Controls.Add(Me.imrpTaxaGrid)
        Me.grpIMRP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpIMRP.Location = New System.Drawing.Point(530, 40)
        Me.grpIMRP.Name = "grpIMRP"
        Me.grpIMRP.Size = New System.Drawing.Size(554, 311)
        Me.grpIMRP.TabIndex = 40
        Me.grpIMRP.TabStop = False
        Me.grpIMRP.Text = "Índice de Macroinvertebrados de Rios Pampeanos (IMRP)"
        '
        'IMRPId
        '
        Me.IMRPId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMRPBindingSource, "Id", True))
        Me.IMRPId.Location = New System.Drawing.Point(903, 5)
        Me.IMRPId.Name = "IMRPId"
        Me.IMRPId.Size = New System.Drawing.Size(100, 20)
        Me.IMRPId.TabIndex = 63
        '
        'IMRPBindingSource
        '
        Me.IMRPBindingSource.DataMember = "IMRP"
        Me.IMRPBindingSource.DataSource = Me.ImrpDataSet
        '
        'IMRPSignifica
        '
        Me.IMRPSignifica.BackColor = System.Drawing.Color.LightGray
        Me.IMRPSignifica.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.IMRPSignifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IMRPSignifica.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMRPSignifica.Location = New System.Drawing.Point(414, 47)
        Me.IMRPSignifica.Name = "IMRPSignifica"
        Me.IMRPSignifica.Size = New System.Drawing.Size(133, 23)
        Me.IMRPSignifica.TabIndex = 100
        Me.IMRPSignifica.TabStop = False
        Me.IMRPSignifica.UseVisualStyleBackColor = False
        '
        'IMRPIdMuestra
        '
        Me.IMRPIdMuestra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMRPBindingSource, "IdMuestra", True))
        Me.IMRPIdMuestra.Location = New System.Drawing.Point(903, 31)
        Me.IMRPIdMuestra.Name = "IMRPIdMuestra"
        Me.IMRPIdMuestra.Size = New System.Drawing.Size(100, 20)
        Me.IMRPIdMuestra.TabIndex = 65
        '
        'IMRPIdProyecto
        '
        Me.IMRPIdProyecto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMRPBindingSource, "IdProyecto", True))
        Me.IMRPIdProyecto.Location = New System.Drawing.Point(903, 57)
        Me.IMRPIdProyecto.Name = "IMRPIdProyecto"
        Me.IMRPIdProyecto.Size = New System.Drawing.Size(100, 20)
        Me.IMRPIdProyecto.TabIndex = 67
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ValorTextBox)
        Me.Panel2.Controls.Add(RangoLabel)
        Me.Panel2.Controls.Add(Me.NotasTextBox)
        Me.Panel2.Controls.Add(ValorLabel)
        Me.Panel2.Controls.Add(NotasLabel)
        Me.Panel2.Controls.Add(Me.RangoTextBox)
        Me.Panel2.Location = New System.Drawing.Point(6, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 112)
        Me.Panel2.TabIndex = 62
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(123, 6)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(67, 20)
        Me.ValorTextBox.TabIndex = 1
        '
        'ValorIMRP
        '
        Me.ValorIMRP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMRPBindingSource, "Valor", True))
        Me.ValorIMRP.Enabled = False
        Me.ValorIMRP.Location = New System.Drawing.Point(156, 254)
        Me.ValorIMRP.Name = "ValorIMRP"
        Me.ValorIMRP.Size = New System.Drawing.Size(43, 20)
        Me.ValorIMRP.TabIndex = 59
        '
        'chkIMRP
        '
        Me.chkIMRP.AutoSize = True
        Me.chkIMRP.Checked = True
        Me.chkIMRP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIMRP.Location = New System.Drawing.Point(11, 19)
        Me.chkIMRP.Name = "chkIMRP"
        Me.chkIMRP.Size = New System.Drawing.Size(94, 17)
        Me.chkIMRP.TabIndex = 49
        Me.chkIMRP.Text = "Calcular IMRP"
        Me.chkIMRP.UseVisualStyleBackColor = True
        '
        'btnBorrarSpIMRP
        '
        Me.btnBorrarSpIMRP.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBorrarSpIMRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSpIMRP.Location = New System.Drawing.Point(310, 280)
        Me.btnBorrarSpIMRP.Name = "btnBorrarSpIMRP"
        Me.btnBorrarSpIMRP.Size = New System.Drawing.Size(98, 23)
        Me.btnBorrarSpIMRP.TabIndex = 48
        Me.btnBorrarSpIMRP.TabStop = False
        Me.btnBorrarSpIMRP.Text = "Borrar taxón"
        Me.btnBorrarSpIMRP.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(391, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(112, 97)
        Me.btnAgregar.TabIndex = 41
        Me.btnAgregar.Text = ">> Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'grpTaxon
        '
        Me.grpTaxon.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpTaxon.Controls.Add(Me.grpDatosTaxon)
        Me.grpTaxon.Controls.Add(Me.Label2)
        Me.grpTaxon.Controls.Add(Me.MacroInvDataGridView)
        Me.grpTaxon.Controls.Add(Me.btnAgregar)
        Me.grpTaxon.Controls.Add(Me.USTextBox)
        Me.grpTaxon.Controls.Add(Me.DensidadTextBox)
        Me.grpTaxon.Controls.Add(Me.Label1)
        Me.grpTaxon.Location = New System.Drawing.Point(12, 206)
        Me.grpTaxon.Name = "grpTaxon"
        Me.grpTaxon.Size = New System.Drawing.Size(512, 452)
        Me.grpTaxon.TabIndex = 42
        Me.grpTaxon.TabStop = False
        Me.grpTaxon.Text = "Taxon"
        '
        'grpDatosTaxon
        '
        Me.grpDatosTaxon.BackColor = System.Drawing.Color.White
        Me.grpDatosTaxon.Controls.Add(Me.NombreTextBox)
        Me.grpDatosTaxon.Controls.Add(NombreLabel)
        Me.grpDatosTaxon.Controls.Add(Me.PictureBox1)
        Me.grpDatosTaxon.Controls.Add(Me.AutorTextBox)
        Me.grpDatosTaxon.Controls.Add(AutorLabel)
        Me.grpDatosTaxon.Location = New System.Drawing.Point(220, 118)
        Me.grpDatosTaxon.Name = "grpDatosTaxon"
        Me.grpDatosTaxon.Size = New System.Drawing.Size(283, 331)
        Me.grpDatosTaxon.TabIndex = 47
        Me.grpDatosTaxon.TabStop = False
        Me.grpDatosTaxon.Text = "Información del Taxón"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(63, 19)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(205, 20)
        Me.NombreTextBox.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Unidades Sistemáticas:"
        '
        'USTextBox
        '
        Me.USTextBox.Location = New System.Drawing.Point(359, 42)
        Me.USTextBox.Name = "USTextBox"
        Me.USTextBox.Size = New System.Drawing.Size(26, 20)
        Me.USTextBox.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Densidad:"
        Me.Label1.Visible = False
        '
        'CategoriaIBPAMPTextBox
        '
        Me.CategoriaIBPAMPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Valor", True))
        Me.CategoriaIBPAMPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaIBPAMPTextBox.Location = New System.Drawing.Point(105, 19)
        Me.CategoriaIBPAMPTextBox.Name = "CategoriaIBPAMPTextBox"
        Me.CategoriaIBPAMPTextBox.Size = New System.Drawing.Size(85, 20)
        Me.CategoriaIBPAMPTextBox.TabIndex = 46
        '
        'grpIBPAMP
        '
        Me.grpIBPAMP.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpIBPAMP.Controls.Add(Me.IBPAMPSignifica)
        Me.grpIBPAMP.Controls.Add(IdLabel1)
        Me.grpIBPAMP.Controls.Add(Me.ValorIBPAMP)
        Me.grpIBPAMP.Controls.Add(Me.IBPAMPId)
        Me.grpIBPAMP.Controls.Add(IdProyectoLabel2)
        Me.grpIBPAMP.Controls.Add(Me.Panel1)
        Me.grpIBPAMP.Controls.Add(Me.IBPAMPIdProyecto)
        Me.grpIBPAMP.Controls.Add(Me.CaracIBPAMPDataGridView)
        Me.grpIBPAMP.Controls.Add(IdMuestraLabel2)
        Me.grpIBPAMP.Controls.Add(Me.txtUStotales)
        Me.grpIBPAMP.Controls.Add(Me.IBPAMPIdMuestra)
        Me.grpIBPAMP.Controls.Add(Me.Cat7TextBox)
        Me.grpIBPAMP.Controls.Add(Label3)
        Me.grpIBPAMP.Controls.Add(Me.Cat6TextBox)
        Me.grpIBPAMP.Controls.Add(Me.Cat5TextBox)
        Me.grpIBPAMP.Controls.Add(IndiceLabel)
        Me.grpIBPAMP.Controls.Add(Me.Cat4TextBox)
        Me.grpIBPAMP.Controls.Add(Me.btnBorrarSpIBPAMP)
        Me.grpIBPAMP.Controls.Add(Me.Cat3TextBox)
        Me.grpIBPAMP.Controls.Add(Me.MostrarDatosIBPAMP)
        Me.grpIBPAMP.Controls.Add(Me.chkIBPAMP)
        Me.grpIBPAMP.Controls.Add(Me.ibpampTaxaGrid)
        Me.grpIBPAMP.Controls.Add(Me.Cat2TextBox)
        Me.grpIBPAMP.Controls.Add(Me.Cat1TextBox)
        Me.grpIBPAMP.Location = New System.Drawing.Point(530, 357)
        Me.grpIBPAMP.Name = "grpIBPAMP"
        Me.grpIBPAMP.Size = New System.Drawing.Size(554, 297)
        Me.grpIBPAMP.TabIndex = 44
        Me.grpIBPAMP.TabStop = False
        Me.grpIBPAMP.Text = "Índice Biotico para ríos y arroyos Pampeanos (IBPAMP)"
        '
        'IBPAMPSignifica
        '
        Me.IBPAMPSignifica.BackColor = System.Drawing.Color.LightGray
        Me.IBPAMPSignifica.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.IBPAMPSignifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IBPAMPSignifica.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBPAMPSignifica.Location = New System.Drawing.Point(414, 41)
        Me.IBPAMPSignifica.Name = "IBPAMPSignifica"
        Me.IBPAMPSignifica.Size = New System.Drawing.Size(133, 23)
        Me.IBPAMPSignifica.TabIndex = 101
        Me.IBPAMPSignifica.TabStop = False
        Me.IBPAMPSignifica.UseVisualStyleBackColor = False
        '
        'ValorIBPAMP
        '
        Me.ValorIBPAMP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IBPAMPBindingSource, "Indice", True))
        Me.ValorIBPAMP.Enabled = False
        Me.ValorIBPAMP.Location = New System.Drawing.Point(159, 247)
        Me.ValorIBPAMP.Name = "ValorIBPAMP"
        Me.ValorIBPAMP.Size = New System.Drawing.Size(40, 20)
        Me.ValorIBPAMP.TabIndex = 59
        '
        'IBPAMPBindingSource
        '
        Me.IBPAMPBindingSource.DataMember = "IBPAMP"
        Me.IBPAMPBindingSource.DataSource = Me.IbpampDataSet
        '
        'IbpampDataSet
        '
        Me.IbpampDataSet.DataSetName = "ibpampDataSet"
        Me.IbpampDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IBPAMPId
        '
        Me.IBPAMPId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IBPAMPBindingSource, "Id", True))
        Me.IBPAMPId.Location = New System.Drawing.Point(1063, 33)
        Me.IBPAMPId.Name = "IBPAMPId"
        Me.IBPAMPId.Size = New System.Drawing.Size(100, 20)
        Me.IBPAMPId.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.CategoriaIBPAMPTextBox)
        Me.Panel1.Controls.Add(CategoriaLabel)
        Me.Panel1.Location = New System.Drawing.Point(6, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 112)
        Me.Panel1.TabIndex = 61
        '
        'IBPAMPIdProyecto
        '
        Me.IBPAMPIdProyecto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IBPAMPBindingSource, "IdProyecto", True))
        Me.IBPAMPIdProyecto.Location = New System.Drawing.Point(1063, 59)
        Me.IBPAMPIdProyecto.Name = "IBPAMPIdProyecto"
        Me.IBPAMPIdProyecto.Size = New System.Drawing.Size(100, 20)
        Me.IBPAMPIdProyecto.TabIndex = 61
        '
        'CaracIBPAMPDataGridView
        '
        Me.CaracIBPAMPDataGridView.AutoGenerateColumns = False
        Me.CaracIBPAMPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CaracIBPAMPDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.AutorDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.PrecisionDataGridViewTextBoxColumn, Me.FotoDataGridViewTextBoxColumn, Me.NotasDataGridViewTextBoxColumn})
        Me.CaracIBPAMPDataGridView.DataSource = Me.CaracMacroinvIBPAMPBindingSource
        Me.CaracIBPAMPDataGridView.Location = New System.Drawing.Point(836, 196)
        Me.CaracIBPAMPDataGridView.Name = "CaracIBPAMPDataGridView"
        Me.CaracIBPAMPDataGridView.Size = New System.Drawing.Size(221, 93)
        Me.CaracIBPAMPDataGridView.TabIndex = 60
        Me.CaracIBPAMPDataGridView.Visible = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'AutorDataGridViewTextBoxColumn
        '
        Me.AutorDataGridViewTextBoxColumn.DataPropertyName = "Autor"
        Me.AutorDataGridViewTextBoxColumn.HeaderText = "Autor"
        Me.AutorDataGridViewTextBoxColumn.Name = "AutorDataGridViewTextBoxColumn"
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        '
        'PrecisionDataGridViewTextBoxColumn
        '
        Me.PrecisionDataGridViewTextBoxColumn.DataPropertyName = "Precision"
        Me.PrecisionDataGridViewTextBoxColumn.HeaderText = "Precision"
        Me.PrecisionDataGridViewTextBoxColumn.Name = "PrecisionDataGridViewTextBoxColumn"
        '
        'FotoDataGridViewTextBoxColumn
        '
        Me.FotoDataGridViewTextBoxColumn.DataPropertyName = "Foto"
        Me.FotoDataGridViewTextBoxColumn.HeaderText = "Foto"
        Me.FotoDataGridViewTextBoxColumn.Name = "FotoDataGridViewTextBoxColumn"
        '
        'NotasDataGridViewTextBoxColumn
        '
        Me.NotasDataGridViewTextBoxColumn.DataPropertyName = "Notas"
        Me.NotasDataGridViewTextBoxColumn.HeaderText = "Notas"
        Me.NotasDataGridViewTextBoxColumn.Name = "NotasDataGridViewTextBoxColumn"
        '
        'CaracMacroinvIBPAMPBindingSource
        '
        Me.CaracMacroinvIBPAMPBindingSource.DataMember = "CaracMacroinvIBPAMP"
        Me.CaracMacroinvIBPAMPBindingSource.DataSource = Me.IbpampDataSet
        '
        'txtUStotales
        '
        Me.txtUStotales.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MacroinvSpIBPAMPBindingSource, "USTotales", True))
        Me.txtUStotales.Location = New System.Drawing.Point(167, 159)
        Me.txtUStotales.Name = "txtUStotales"
        Me.txtUStotales.Size = New System.Drawing.Size(32, 20)
        Me.txtUStotales.TabIndex = 59
        '
        'MacroinvSpIBPAMPBindingSource
        '
        Me.MacroinvSpIBPAMPBindingSource.DataMember = "MacroinvSpIBPAMP"
        Me.MacroinvSpIBPAMPBindingSource.DataSource = Me.IbpampDataSet
        '
        'IBPAMPIdMuestra
        '
        Me.IBPAMPIdMuestra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IBPAMPBindingSource, "IdMuestra", True))
        Me.IBPAMPIdMuestra.Location = New System.Drawing.Point(1063, 85)
        Me.IBPAMPIdMuestra.Name = "IBPAMPIdMuestra"
        Me.IBPAMPIdMuestra.Size = New System.Drawing.Size(100, 20)
        Me.IBPAMPIdMuestra.TabIndex = 63
        '
        'Cat7TextBox
        '
        Me.Cat7TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat7TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat7TextBox.Location = New System.Drawing.Point(818, 153)
        Me.Cat7TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat7TextBox.Name = "Cat7TextBox"
        Me.Cat7TextBox.Size = New System.Drawing.Size(10, 20)
        Me.Cat7TextBox.TabIndex = 58
        Me.Cat7TextBox.Visible = False
        '
        'Cat6TextBox
        '
        Me.Cat6TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat6TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat6TextBox.Location = New System.Drawing.Point(818, 133)
        Me.Cat6TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat6TextBox.Name = "Cat6TextBox"
        Me.Cat6TextBox.Size = New System.Drawing.Size(10, 20)
        Me.Cat6TextBox.TabIndex = 57
        Me.Cat6TextBox.Visible = False
        '
        'Cat5TextBox
        '
        Me.Cat5TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat5TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat5TextBox.Location = New System.Drawing.Point(818, 113)
        Me.Cat5TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat5TextBox.Name = "Cat5TextBox"
        Me.Cat5TextBox.Size = New System.Drawing.Size(10, 20)
        Me.Cat5TextBox.TabIndex = 56
        Me.Cat5TextBox.Visible = False
        '
        'Cat4TextBox
        '
        Me.Cat4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat4TextBox.Location = New System.Drawing.Point(818, 93)
        Me.Cat4TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat4TextBox.Name = "Cat4TextBox"
        Me.Cat4TextBox.Size = New System.Drawing.Size(10, 20)
        Me.Cat4TextBox.TabIndex = 55
        Me.Cat4TextBox.Visible = False
        '
        'btnBorrarSpIBPAMP
        '
        Me.btnBorrarSpIBPAMP.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBorrarSpIBPAMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSpIBPAMP.Location = New System.Drawing.Point(310, 270)
        Me.btnBorrarSpIBPAMP.Name = "btnBorrarSpIBPAMP"
        Me.btnBorrarSpIBPAMP.Size = New System.Drawing.Size(98, 23)
        Me.btnBorrarSpIBPAMP.TabIndex = 49
        Me.btnBorrarSpIBPAMP.TabStop = False
        Me.btnBorrarSpIBPAMP.Text = "Borrar taxón"
        Me.btnBorrarSpIBPAMP.UseVisualStyleBackColor = True
        '
        'Cat3TextBox
        '
        Me.Cat3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat3TextBox.Location = New System.Drawing.Point(818, 73)
        Me.Cat3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat3TextBox.Name = "Cat3TextBox"
        Me.Cat3TextBox.Size = New System.Drawing.Size(10, 20)
        Me.Cat3TextBox.TabIndex = 54
        Me.Cat3TextBox.Visible = False
        '
        'MostrarDatosIBPAMP
        '
        Me.MostrarDatosIBPAMP.AllowUserToAddRows = False
        Me.MostrarDatosIBPAMP.AllowUserToDeleteRows = False
        Me.MostrarDatosIBPAMP.AllowUserToResizeColumns = False
        Me.MostrarDatosIBPAMP.AllowUserToResizeRows = False
        Me.MostrarDatosIBPAMP.BackgroundColor = System.Drawing.Color.White
        Me.MostrarDatosIBPAMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MostrarDatosIBPAMP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.Categoría})
        Me.MostrarDatosIBPAMP.GridColor = System.Drawing.Color.White
        Me.MostrarDatosIBPAMP.Location = New System.Drawing.Point(205, 41)
        Me.MostrarDatosIBPAMP.Name = "MostrarDatosIBPAMP"
        Me.MostrarDatosIBPAMP.RowHeadersVisible = False
        Me.MostrarDatosIBPAMP.Size = New System.Drawing.Size(203, 226)
        Me.MostrarDatosIBPAMP.TabIndex = 40
        Me.MostrarDatosIBPAMP.TabStop = False
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Taxón"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 82
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.HeaderText = "US"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'Categoría
        '
        Me.Categoría.HeaderText = "Cat"
        Me.Categoría.Name = "Categoría"
        Me.Categoría.Width = 40
        '
        'chkIBPAMP
        '
        Me.chkIBPAMP.AutoSize = True
        Me.chkIBPAMP.Checked = True
        Me.chkIBPAMP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIBPAMP.Location = New System.Drawing.Point(11, 19)
        Me.chkIBPAMP.Name = "chkIBPAMP"
        Me.chkIBPAMP.Size = New System.Drawing.Size(107, 17)
        Me.chkIBPAMP.TabIndex = 1
        Me.chkIBPAMP.Text = "Calcular IBPAMP"
        Me.chkIBPAMP.UseVisualStyleBackColor = True
        '
        'ibpampTaxaGrid
        '
        Me.ibpampTaxaGrid.AllowUpdate = False
        Me.ibpampTaxaGrid.CaptionHeight = 17
        Me.ibpampTaxaGrid.DataSource = Me.MacroinvSpIBPAMPBindingSource
        Me.ibpampTaxaGrid.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Inverted
        Me.ibpampTaxaGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ibpampTaxaGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.ibpampTaxaGrid.Images.Add(CType(resources.GetObject("ibpampTaxaGrid.Images"), System.Drawing.Image))
        Me.ibpampTaxaGrid.Location = New System.Drawing.Point(836, 28)
        Me.ibpampTaxaGrid.Name = "ibpampTaxaGrid"
        Me.ibpampTaxaGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.ibpampTaxaGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.ibpampTaxaGrid.PreviewInfo.ZoomFactor = 75
        Me.ibpampTaxaGrid.PrintInfo.PageSettings = CType(resources.GetObject("ibpampTaxaGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.ibpampTaxaGrid.RowHeight = 15
        Me.ibpampTaxaGrid.Size = New System.Drawing.Size(142, 162)
        Me.ibpampTaxaGrid.TabIndex = 0
        Me.ibpampTaxaGrid.Text = "C1TrueDBGrid1"
        Me.ibpampTaxaGrid.Visible = False
        Me.ibpampTaxaGrid.PropBag = resources.GetString("ibpampTaxaGrid.PropBag")
        '
        'Cat2TextBox
        '
        Me.Cat2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat2TextBox.Location = New System.Drawing.Point(818, 53)
        Me.Cat2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat2TextBox.Name = "Cat2TextBox"
        Me.Cat2TextBox.Size = New System.Drawing.Size(10, 20)
        Me.Cat2TextBox.TabIndex = 53
        Me.Cat2TextBox.Visible = False
        '
        'Cat1TextBox
        '
        Me.Cat1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat1TextBox.Location = New System.Drawing.Point(818, 33)
        Me.Cat1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat1TextBox.Name = "Cat1TextBox"
        Me.Cat1TextBox.Size = New System.Drawing.Size(10, 20)
        Me.Cat1TextBox.TabIndex = 52
        Me.Cat1TextBox.Visible = False
        '
        'MacroinvSpIBPAMPTableAdapter
        '
        Me.MacroinvSpIBPAMPTableAdapter.ClearBeforeFill = True
        '
        'IMRPTableAdapter
        '
        Me.IMRPTableAdapter.ClearBeforeFill = True
        '
        'IBPAMPTableAdapter
        '
        Me.IBPAMPTableAdapter.ClearBeforeFill = True
        '
        'CaracMacroinvIBPAMPTableAdapter
        '
        Me.CaracMacroinvIBPAMPTableAdapter.ClearBeforeFill = True
        '
        'MuestrasBindingNavigator
        '
        Me.MuestrasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MuestrasBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.MuestrasBindingNavigator.BindingSource = Me.MuestrasBindingSource
        Me.MuestrasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MuestrasBindingNavigator.DeleteItem = Nothing
        Me.MuestrasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MuestrasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.EditTootStripButton, Me.SaveToolStripButton, Me.BindingNavigatorDeleteItem, Me.toolStripSeparator, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator1})
        Me.MuestrasBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MuestrasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MuestrasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MuestrasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MuestrasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MuestrasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MuestrasBindingNavigator.Name = "MuestrasBindingNavigator"
        Me.MuestrasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MuestrasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MuestrasBindingNavigator.Size = New System.Drawing.Size(1264, 38)
        Me.MuestrasBindingNavigator.TabIndex = 53
        Me.MuestrasBindingNavigator.Text = "Navegador de muestras"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(93, 35)
        Me.BindingNavigatorAddNewItem.Text = "Nueva muestra"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 35)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'EditTootStripButton
        '
        Me.EditTootStripButton.ForeColor = System.Drawing.Color.White
        Me.EditTootStripButton.Image = CType(resources.GetObject("EditTootStripButton.Image"), System.Drawing.Image)
        Me.EditTootStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditTootStripButton.Name = "EditTootStripButton"
        Me.EditTootStripButton.Size = New System.Drawing.Size(87, 35)
        Me.EditTootStripButton.Text = "Editar Muestra"
        Me.EditTootStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveToolStripButton.ForeColor = System.Drawing.Color.White
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(103, 35)
        Me.SaveToolStripButton.Text = "Guardar muestra"
        Me.SaveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(105, 35)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar muestra"
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveFirstItem.Text = "Primera"
        Me.BindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 35)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveNextItem.Text = "Siguiente"
        Me.BindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveLastItem.Text = "Última"
        Me.BindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'btnCalcularIndices
        '
        Me.btnCalcularIndices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCalcularIndices.FlatAppearance.BorderSize = 2
        Me.btnCalcularIndices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularIndices.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularIndices.Location = New System.Drawing.Point(1090, 563)
        Me.btnCalcularIndices.Name = "btnCalcularIndices"
        Me.btnCalcularIndices.Size = New System.Drawing.Size(162, 91)
        Me.btnCalcularIndices.TabIndex = 59
        Me.btnCalcularIndices.Text = "Calcular Indices "
        Me.btnCalcularIndices.UseVisualStyleBackColor = True
        '
        'grpMuestra
        '
        Me.grpMuestra.BackColor = System.Drawing.Color.Transparent
        Me.grpMuestra.Controls.Add(Me.MuestrasDataGridView)
        Me.grpMuestra.Controls.Add(Label25)
        Me.grpMuestra.Controls.Add(Label24)
        Me.grpMuestra.Controls.Add(Me.btnEditarSitios)
        Me.grpMuestra.Controls.Add(Me.CoordLONGTextBox)
        Me.grpMuestra.Controls.Add(Me.CoordLATTextBox)
        Me.grpMuestra.Controls.Add(Me.CodigoSitioComboBox)
        Me.grpMuestra.Controls.Add(IdProyectoLabel)
        Me.grpMuestra.Controls.Add(Me.IdProyectoTextBox)
        Me.grpMuestra.Controls.Add(Me.IdMuestraTextBox)
        Me.grpMuestra.Controls.Add(IdMuestraLabel)
        Me.grpMuestra.Controls.Add(Label4)
        Me.grpMuestra.Controls.Add(Me.TextBox1)
        Me.grpMuestra.Controls.Add(Label5)
        Me.grpMuestra.Controls.Add(Me.TextBox2)
        Me.grpMuestra.Controls.Add(Me.CodigoSitioTextBox)
        Me.grpMuestra.Controls.Add(FechaLabel)
        Me.grpMuestra.Controls.Add(CodigoSitioLabel)
        Me.grpMuestra.Controls.Add(Me.FechaDateTimePicker)
        Me.grpMuestra.Enabled = False
        Me.grpMuestra.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMuestra.Location = New System.Drawing.Point(12, 45)
        Me.grpMuestra.Name = "grpMuestra"
        Me.grpMuestra.Size = New System.Drawing.Size(430, 155)
        Me.grpMuestra.TabIndex = 60
        Me.grpMuestra.TabStop = False
        Me.grpMuestra.Text = "Datos de la muestra"
        '
        'MuestrasDataGridView
        '
        Me.MuestrasDataGridView.AllowUserToAddRows = False
        Me.MuestrasDataGridView.AllowUserToDeleteRows = False
        Me.MuestrasDataGridView.AutoGenerateColumns = False
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(434, 57)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.ReadOnly = True
        Me.MuestrasDataGridView.RowHeadersVisible = False
        Me.MuestrasDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(168, 43)
        Me.MuestrasDataGridView.TabIndex = 120
        Me.MuestrasDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdMuestra"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdMuestra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdProyecto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdProyecto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CodigoSitio"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CodigoSitio"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FQpH"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FQpH"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FQTemp"
        Me.DataGridViewTextBoxColumn11.HeaderText = "FQTemp"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FQCond"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FQCond"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FQTurb"
        Me.DataGridViewTextBoxColumn13.HeaderText = "FQTurb"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FQCaudal"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FQCaudal"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "FQOD"
        Me.DataGridViewTextBoxColumn15.HeaderText = "FQOD"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FQNitratos"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FQNitratos"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FQNitritos"
        Me.DataGridViewTextBoxColumn17.HeaderText = "FQNitritos"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "FQAmonio"
        Me.DataGridViewTextBoxColumn18.HeaderText = "FQAmonio"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "FQFosfato"
        Me.DataGridViewTextBoxColumn19.HeaderText = "FQFosfato"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "ClorofilaA"
        Me.DataGridViewTextBoxColumn20.HeaderText = "ClorofilaA"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn21.HeaderText = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "CianoDensidad"
        Me.DataGridViewTextBoxColumn22.HeaderText = "CianoDensidad"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn23.HeaderText = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Ecoli"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Ecoli"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Olor"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Olor"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Conectividad"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Conectividad"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Naturalidad"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Naturalidad"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "AbuBasura"
        Me.DataGridViewTextBoxColumn28.HeaderText = "AbuBasura"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "DivBasura"
        Me.DataGridViewTextBoxColumn29.HeaderText = "DivBasura"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "IDP"
        Me.DataGridViewTextBoxColumn30.HeaderText = "IDP"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "IMRP"
        Me.DataGridViewTextBoxColumn31.HeaderText = "IMRP"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "IMRPlata"
        Me.DataGridViewTextBoxColumn32.HeaderText = "IMRPlata"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "FQBOD"
        Me.DataGridViewTextBoxColumn34.HeaderText = "FQBOD"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "IBPAMP"
        Me.DataGridViewTextBoxColumn35.HeaderText = "IBPAMP"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "FitoTotal"
        Me.DataGridViewTextBoxColumn36.HeaderText = "FitoTotal"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Tanaids"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Tanaids"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'btnEditarSitios
        '
        Me.btnEditarSitios.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEditarSitios.FlatAppearance.BorderSize = 2
        Me.btnEditarSitios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarSitios.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarSitios.Location = New System.Drawing.Point(326, 103)
        Me.btnEditarSitios.Name = "btnEditarSitios"
        Me.btnEditarSitios.Size = New System.Drawing.Size(86, 23)
        Me.btnEditarSitios.TabIndex = 117
        Me.btnEditarSitios.Text = "Editar sitios"
        Me.btnEditarSitios.UseVisualStyleBackColor = True
        '
        'CoordLONGTextBox
        '
        Me.CoordLONGTextBox.Enabled = False
        Me.CoordLONGTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoordLONGTextBox.Location = New System.Drawing.Point(240, 106)
        Me.CoordLONGTextBox.Name = "CoordLONGTextBox"
        Me.CoordLONGTextBox.Size = New System.Drawing.Size(74, 23)
        Me.CoordLONGTextBox.TabIndex = 115
        '
        'CoordLATTextBox
        '
        Me.CoordLATTextBox.Enabled = False
        Me.CoordLATTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoordLATTextBox.Location = New System.Drawing.Point(114, 105)
        Me.CoordLATTextBox.Name = "CoordLATTextBox"
        Me.CoordLATTextBox.Size = New System.Drawing.Size(74, 23)
        Me.CoordLATTextBox.TabIndex = 116
        '
        'CodigoSitioComboBox
        '
        Me.CodigoSitioComboBox.DataSource = Me.SitiosBindingSource
        Me.CodigoSitioComboBox.DisplayMember = "CodigoSitio"
        Me.CodigoSitioComboBox.FormattingEnabled = True
        Me.CodigoSitioComboBox.Location = New System.Drawing.Point(166, 77)
        Me.CodigoSitioComboBox.Name = "CodigoSitioComboBox"
        Me.CodigoSitioComboBox.Size = New System.Drawing.Size(148, 23)
        Me.CodigoSitioComboBox.TabIndex = 115
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
        'IdProyectoTextBox
        '
        Me.IdProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IdProyecto", True))
        Me.IdProyectoTextBox.Enabled = False
        Me.IdProyectoTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProyectoTextBox.Location = New System.Drawing.Point(399, 43)
        Me.IdProyectoTextBox.Name = "IdProyectoTextBox"
        Me.IdProyectoTextBox.Size = New System.Drawing.Size(27, 23)
        Me.IdProyectoTextBox.TabIndex = 3
        Me.IdProyectoTextBox.TabStop = False
        '
        'IdMuestraTextBox
        '
        Me.IdMuestraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "IdMuestra", True))
        Me.IdMuestraTextBox.Enabled = False
        Me.IdMuestraTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdMuestraTextBox.Location = New System.Drawing.Point(399, 17)
        Me.IdMuestraTextBox.Name = "IdMuestraTextBox"
        Me.IdMuestraTextBox.Size = New System.Drawing.Size(27, 23)
        Me.IdMuestraTextBox.TabIndex = 1
        Me.IdMuestraTextBox.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Autor", True))
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(114, 131)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 23)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Nombre", True))
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(114, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 23)
        Me.TextBox2.TabIndex = 5
        '
        'CodigoSitioTextBox
        '
        Me.CodigoSitioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "CodigoSitio", True))
        Me.CodigoSitioTextBox.Enabled = False
        Me.CodigoSitioTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoSitioTextBox.Location = New System.Drawing.Point(114, 76)
        Me.CodigoSitioTextBox.Name = "CodigoSitioTextBox"
        Me.CodigoSitioTextBox.Size = New System.Drawing.Size(46, 23)
        Me.CodigoSitioTextBox.TabIndex = 9
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MuestrasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(114, 44)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.FechaDateTimePicker.TabIndex = 7
        '
        'SitiosTableAdapter
        '
        Me.SitiosTableAdapter.ClearBeforeFill = True
        '
        'frmMacroInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.grpMuestra)
        Me.Controls.Add(Me.btnCalcularIndices)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
        Me.Controls.Add(Me.grpIBPAMP)
        Me.Controls.Add(Me.grpTaxon)
        Me.Controls.Add(Me.grpIMRP)
        Me.Name = "frmMacroInv"
        Me.Text = "frmMacroInv"
        CType(Me.MacroInvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MacroInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImrpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imrpTaxaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MacroinvSpIMRPBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImrpDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaracMacroinvIMRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarDatosIMRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIMRP.ResumeLayout(False)
        Me.grpIMRP.PerformLayout()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTaxon.ResumeLayout(False)
        Me.grpTaxon.PerformLayout()
        Me.grpDatosTaxon.ResumeLayout(False)
        Me.grpDatosTaxon.PerformLayout()
        Me.grpIBPAMP.ResumeLayout(False)
        Me.grpIBPAMP.PerformLayout()
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbpampDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CaracIBPAMPDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaracMacroinvIBPAMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MacroinvSpIBPAMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarDatosIBPAMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ibpampTaxaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MuestrasBindingNavigator.ResumeLayout(False)
        Me.MuestrasBindingNavigator.PerformLayout()
        Me.grpMuestra.ResumeLayout(False)
        Me.grpMuestra.PerformLayout()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitiosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IndicesDataSet As Scila7.IndicesDataSet
    Friend WithEvents MacroInvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MacroInvTableAdapter As Scila7.IndicesDataSetTableAdapters.MacroInvTableAdapter
    Friend WithEvents TableAdapterManager As Scila7.IndicesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MacroInvDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents ImrpDataSet As Scila7.imrpDataSet
    Friend WithEvents imrpTaxaGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents MacroinvSpIMRPBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ImrpDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DensidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaracMacroinvIMRPTableAdapter As Scila7.imrpDataSetTableAdapters.CaracMacroinvIMRPTableAdapter
    Friend WithEvents CaracMacroinvIMRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RangoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MostrarDatosIMRP As System.Windows.Forms.DataGridView
    Friend WithEvents grpIMRP As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents grpTaxon As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents USTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpIBPAMP As System.Windows.Forms.GroupBox
    Friend WithEvents ibpampTaxaGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents IbpampDataSet As Scila7.ibpampDataSet
    Friend WithEvents MacroinvSpIBPAMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chkIBPAMP As System.Windows.Forms.CheckBox
    Friend WithEvents MostrarDatosIBPAMP As System.Windows.Forms.DataGridView
    Friend WithEvents IMRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMRPTableAdapter As Scila7.imrpDataSetTableAdapters.IMRPTableAdapter
    Friend WithEvents btnBorrarSpIMRP As System.Windows.Forms.Button
    Friend WithEvents btnBorrarSpIBPAMP As System.Windows.Forms.Button
    Friend WithEvents IBPAMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IBPAMPTableAdapter As Scila7.ibpampDataSetTableAdapters.IBPAMPTableAdapter
    Friend WithEvents Taxón As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat7TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat6TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaracMacroinvIBPAMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaracMacroinvIBPAMPTableAdapter As Scila7.ibpampDataSetTableAdapters.CaracMacroinvIBPAMPTableAdapter
    Friend WithEvents txtUStotales As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaIBPAMPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMRP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IBPAMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaracIBPAMPDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpDatosTaxon As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoría As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkIMRP As System.Windows.Forms.CheckBox
    Friend WithEvents MuestrasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ValorIMRP As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ValorIBPAMP As System.Windows.Forms.TextBox
    Friend WithEvents IMRPId As System.Windows.Forms.TextBox
    Friend WithEvents IMRPIdMuestra As System.Windows.Forms.TextBox
    Friend WithEvents IMRPIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents IBPAMPId As System.Windows.Forms.TextBox
    Friend WithEvents IBPAMPIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents IBPAMPIdMuestra As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcularIndices As System.Windows.Forms.Button
    Friend WithEvents EditTootStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents IMRPSignifica As System.Windows.Forms.Button
    Friend WithEvents IBPAMPSignifica As System.Windows.Forms.Button
    Friend WithEvents grpMuestra As System.Windows.Forms.GroupBox
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEditarSitios As C1.Win.C1Input.C1Button
    Friend WithEvents CoordLONGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CoordLATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdMuestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CodigoSitioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CodigoSitioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SitiosDataSet As Scila7.sitiosDataSet
    Friend WithEvents SitiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SitiosTableAdapter As Scila7.sitiosDataSetTableAdapters.SitiosTableAdapter
End Class
