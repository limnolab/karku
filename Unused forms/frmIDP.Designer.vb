<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIDP
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
        Dim AcronimoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim IDPLabel As System.Windows.Forms.Label
        Dim Tipo_de_AguasLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim PrecLabel As System.Windows.Forms.Label
        Dim IdMuestraLabel1 As System.Windows.Forms.Label
        Dim IdProyectoLabel As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim IdMuestraLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CodigoSitioLabel As System.Windows.Forms.Label
        Dim ValorLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIDP))
        Me.IDPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdpDataSet = New Scila7.idpDataSet
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet
        Me.AcronimoTextBox = New System.Windows.Forms.TextBox
        Me.CaracDiatomeasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.IDPTextBox = New System.Windows.Forms.TextBox
        Me.Tipo_de_AguasTextBox = New System.Windows.Forms.TextBox
        Me.DiatomeasSpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
        Me.DiatomeasSpParte2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiatomeasSpDataGridView1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.DiatomeasSpParte2DataGridView1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnCalcularIDP = New C1.Win.C1Input.C1Button
        Me.grpResultadoEspecie = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grpCalcularIDP = New System.Windows.Forms.GroupBox
        Me.IDPSignifica = New System.Windows.Forms.Button
        Me.PrecTextBox = New System.Windows.Forms.TextBox
        Me.ValorTextBox = New System.Windows.Forms.TextBox
        Me.btnCancelar = New C1.Win.C1Input.C1Button
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdMuestraTextBox1 = New System.Windows.Forms.TextBox
        Me.IdProyectoTextBox1 = New System.Windows.Forms.TextBox
        Me.grpBuscarEspecie = New System.Windows.Forms.GroupBox
        Me.Searchbynamecmb = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAgregar = New C1.Win.C1Input.C1Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.DensidadTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MostrarDatosGrid = New System.Windows.Forms.DataGridView
        Me.Especie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Densidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn83 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn84 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn85 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn86 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn87 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn88 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn89 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn90 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn91 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn92 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn93 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn94 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn95 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn96 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn97 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn98 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn99 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn100 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn101 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn102 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn103 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn104 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn105 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn106 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn107 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn108 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn109 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn110 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDPTableAdapter = New Scila7.idpDataSetTableAdapters.IDPTableAdapter
        Me.CaracDiatomeasTableAdapter = New Scila7.idpDataSetTableAdapters.CaracIDPTableAdapter
        Me.DiatomeasSpTableAdapter = New Scila7.idpDataSetTableAdapters.DiatomeasSpTableAdapter
        Me.DiatomeasSpParte2TableAdapter = New Scila7.idpDataSetTableAdapters.DiatomeasSpParte2TableAdapter
        Me.MuestrasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.EditTootStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.MuestrasBindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.grpMuestra = New System.Windows.Forms.GroupBox
        Me.btnEditarSitios = New C1.Win.C1Input.C1Button
        Me.CoordLONGTextBox = New System.Windows.Forms.TextBox
        Me.CoordLATTextBox = New System.Windows.Forms.TextBox
        Me.CodigoSitioComboBox = New System.Windows.Forms.ComboBox
        Me.SitiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SitiosDataSet = New Scila7.sitiosDataSet
        Me.IdProyectoTextBox = New System.Windows.Forms.TextBox
        Me.IdMuestraTextBox = New System.Windows.Forms.TextBox
        Me.AutorTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CodigoSitioTextBox = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.SitiosTableAdapter = New Scila7.sitiosDataSetTableAdapters.SitiosTableAdapter
        Me.TableAdapterManager = New Scila7.idpDataSetTableAdapters.TableAdapterManager
        Me.IDPDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn111 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorTextBox1 = New System.Windows.Forms.TextBox
        AcronimoLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        IDPLabel = New System.Windows.Forms.Label
        Tipo_de_AguasLabel = New System.Windows.Forms.Label
        ValorLabel = New System.Windows.Forms.Label
        PrecLabel = New System.Windows.Forms.Label
        IdMuestraLabel1 = New System.Windows.Forms.Label
        IdProyectoLabel = New System.Windows.Forms.Label
        Label25 = New System.Windows.Forms.Label
        Label24 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        IdMuestraLabel = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        AutorLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        CodigoSitioLabel = New System.Windows.Forms.Label
        ValorLabel1 = New System.Windows.Forms.Label
        CType(Me.IDPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaracDiatomeasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiatomeasSpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiatomeasSpParte2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiatomeasSpDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiatomeasSpParte2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResultadoEspecie.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCalcularIDP.SuspendLayout()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBuscarEspecie.SuspendLayout()
        CType(Me.MostrarDatosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        Me.grpMuestra.SuspendLayout()
        CType(Me.SitiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitiosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDPDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AcronimoLabel
        '
        AcronimoLabel.AutoSize = True
        AcronimoLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcronimoLabel.Location = New System.Drawing.Point(39, 67)
        AcronimoLabel.Name = "AcronimoLabel"
        AcronimoLabel.Size = New System.Drawing.Size(66, 13)
        AcronimoLabel.TabIndex = 6
        AcronimoLabel.Text = "Acrónimo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(46, 41)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(57, 13)
        NombreLabel.TabIndex = 8
        NombreLabel.Text = "Nombre:"
        '
        'IDPLabel
        '
        IDPLabel.AutoSize = True
        IDPLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDPLabel.Location = New System.Drawing.Point(38, 95)
        IDPLabel.Name = "IDPLabel"
        IDPLabel.Size = New System.Drawing.Size(67, 13)
        IDPLabel.TabIndex = 10
        IDPLabel.Text = "Valor IDP:"
        '
        'Tipo_de_AguasLabel
        '
        Tipo_de_AguasLabel.AutoSize = True
        Tipo_de_AguasLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tipo_de_AguasLabel.Location = New System.Drawing.Point(14, 121)
        Tipo_de_AguasLabel.Name = "Tipo_de_AguasLabel"
        Tipo_de_AguasLabel.Size = New System.Drawing.Size(93, 13)
        Tipo_de_AguasLabel.TabIndex = 12
        Tipo_de_AguasLabel.Text = "Tipo de Aguas:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorLabel.Location = New System.Drawing.Point(23, 36)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(42, 13)
        ValorLabel.TabIndex = 0
        ValorLabel.Text = "Valor:"
        '
        'PrecLabel
        '
        PrecLabel.AutoSize = True
        PrecLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecLabel.Location = New System.Drawing.Point(22, 62)
        PrecLabel.Name = "PrecLabel"
        PrecLabel.Size = New System.Drawing.Size(63, 13)
        PrecLabel.TabIndex = 2
        PrecLabel.Text = "Precisión:"
        PrecLabel.Visible = False
        '
        'IdMuestraLabel1
        '
        IdMuestraLabel1.AutoSize = True
        IdMuestraLabel1.Location = New System.Drawing.Point(1019, 455)
        IdMuestraLabel1.Name = "IdMuestraLabel1"
        IdMuestraLabel1.Size = New System.Drawing.Size(60, 13)
        IdMuestraLabel1.TabIndex = 38
        IdMuestraLabel1.Text = "Id Muestra:"
        '
        'IdProyectoLabel
        '
        IdProyectoLabel.AutoSize = True
        IdProyectoLabel.Location = New System.Drawing.Point(1015, 484)
        IdProyectoLabel.Name = "IdProyectoLabel"
        IdProyectoLabel.Size = New System.Drawing.Size(64, 13)
        IdProyectoLabel.TabIndex = 39
        IdProyectoLabel.Text = "Id Proyecto:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label25.Location = New System.Drawing.Point(206, 130)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(35, 15)
        Label25.TabIndex = 119
        Label25.Text = "Long:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label24.Location = New System.Drawing.Point(88, 130)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(26, 15)
        Label24.TabIndex = 118
        Label24.Text = "Lat:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(196, 20)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(72, 15)
        Label5.TabIndex = 2
        Label5.Text = "Id Proyecto:"
        '
        'IdMuestraLabel
        '
        IdMuestraLabel.AutoSize = True
        IdMuestraLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdMuestraLabel.Location = New System.Drawing.Point(20, 23)
        IdMuestraLabel.Name = "IdMuestraLabel"
        IdMuestraLabel.Size = New System.Drawing.Size(70, 15)
        IdMuestraLabel.TabIndex = 0
        IdMuestraLabel.Text = "Id Muestra:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(20, 49)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(53, 15)
        Label6.TabIndex = 4
        Label6.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AutorLabel.Location = New System.Drawing.Point(20, 189)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(40, 15)
        AutorLabel.TabIndex = 10
        AutorLabel.Text = "Autor:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(20, 76)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(42, 15)
        FechaLabel.TabIndex = 6
        FechaLabel.Text = "Fecha:"
        '
        'CodigoSitioLabel
        '
        CodigoSitioLabel.AutoSize = True
        CodigoSitioLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoSitioLabel.Location = New System.Drawing.Point(20, 101)
        CodigoSitioLabel.Name = "CodigoSitioLabel"
        CodigoSitioLabel.Size = New System.Drawing.Size(34, 15)
        CodigoSitioLabel.TabIndex = 8
        CodigoSitioLabel.Text = "Sitio:"
        '
        'ValorLabel1
        '
        ValorLabel1.AutoSize = True
        ValorLabel1.Location = New System.Drawing.Point(1045, 510)
        ValorLabel1.Name = "ValorLabel1"
        ValorLabel1.Size = New System.Drawing.Size(34, 13)
        ValorLabel1.TabIndex = 58
        ValorLabel1.Text = "Valor:"
        '
        'IDPBindingSource
        '
        Me.IDPBindingSource.DataMember = "IDP"
        Me.IDPBindingSource.DataSource = Me.IdpDataSet
        '
        'IdpDataSet
        '
        Me.IdpDataSet.DataSetName = "idpDataSet"
        Me.IdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Scilla10DataSet
        '
        Me.Scilla10DataSet.DataSetName = "Scilla10DataSet"
        Me.Scilla10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AcronimoTextBox
        '
        Me.AcronimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracDiatomeasBindingSource, "Acronimo", True))
        Me.AcronimoTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcronimoTextBox.Location = New System.Drawing.Point(113, 64)
        Me.AcronimoTextBox.Name = "AcronimoTextBox"
        Me.AcronimoTextBox.ReadOnly = True
        Me.AcronimoTextBox.Size = New System.Drawing.Size(59, 21)
        Me.AcronimoTextBox.TabIndex = 7
        Me.AcronimoTextBox.TabStop = False
        '
        'CaracDiatomeasBindingSource
        '
        Me.CaracDiatomeasBindingSource.DataMember = "CaracDiatomeas"
        Me.CaracDiatomeasBindingSource.DataSource = Me.IdpDataSet
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracDiatomeasBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(113, 38)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(185, 21)
        Me.NombreTextBox.TabIndex = 9
        Me.NombreTextBox.TabStop = False
        '
        'IDPTextBox
        '
        Me.IDPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracDiatomeasBindingSource, "IDP", True))
        Me.IDPTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDPTextBox.Location = New System.Drawing.Point(113, 92)
        Me.IDPTextBox.Name = "IDPTextBox"
        Me.IDPTextBox.ReadOnly = True
        Me.IDPTextBox.Size = New System.Drawing.Size(59, 21)
        Me.IDPTextBox.TabIndex = 11
        Me.IDPTextBox.TabStop = False
        '
        'Tipo_de_AguasTextBox
        '
        Me.Tipo_de_AguasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracDiatomeasBindingSource, "Tipo de Aguas", True))
        Me.Tipo_de_AguasTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo_de_AguasTextBox.Location = New System.Drawing.Point(113, 118)
        Me.Tipo_de_AguasTextBox.Name = "Tipo_de_AguasTextBox"
        Me.Tipo_de_AguasTextBox.ReadOnly = True
        Me.Tipo_de_AguasTextBox.Size = New System.Drawing.Size(59, 21)
        Me.Tipo_de_AguasTextBox.TabIndex = 13
        Me.Tipo_de_AguasTextBox.TabStop = False
        '
        'DiatomeasSpBindingSource
        '
        Me.DiatomeasSpBindingSource.DataMember = "DiatomeasSp"
        Me.DiatomeasSpBindingSource.DataSource = Me.IdpDataSet
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'DiatomeasSpParte2BindingSource1
        '
        Me.DiatomeasSpParte2BindingSource1.DataMember = "DiatomeasSpParte2"
        Me.DiatomeasSpParte2BindingSource1.DataSource = Me.IdpDataSet
        '
        'DiatomeasSpDataGridView1
        '
        Me.DiatomeasSpDataGridView1.DataSource = Me.DiatomeasSpBindingSource
        Me.DiatomeasSpDataGridView1.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Inverted
        Me.DiatomeasSpDataGridView1.GroupByCaption = "Drag a column header here to group by that column"
        Me.DiatomeasSpDataGridView1.Images.Add(CType(resources.GetObject("DiatomeasSpDataGridView1.Images"), System.Drawing.Image))
        Me.DiatomeasSpDataGridView1.LinesPerRow = 42
        Me.DiatomeasSpDataGridView1.Location = New System.Drawing.Point(1224, 63)
        Me.DiatomeasSpDataGridView1.Name = "DiatomeasSpDataGridView1"
        Me.DiatomeasSpDataGridView1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DiatomeasSpDataGridView1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DiatomeasSpDataGridView1.PreviewInfo.ZoomFactor = 75
        Me.DiatomeasSpDataGridView1.PrintInfo.PageSettings = CType(resources.GetObject("DiatomeasSpDataGridView1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DiatomeasSpDataGridView1.Size = New System.Drawing.Size(200, 200)
        Me.DiatomeasSpDataGridView1.TabIndex = 18
        Me.DiatomeasSpDataGridView1.Text = "C1TrueDBGrid1"
        Me.DiatomeasSpDataGridView1.PropBag = resources.GetString("DiatomeasSpDataGridView1.PropBag")
        '
        'DiatomeasSpParte2DataGridView1
        '
        Me.DiatomeasSpParte2DataGridView1.DataSource = Me.DiatomeasSpParte2BindingSource1
        Me.DiatomeasSpParte2DataGridView1.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Inverted
        Me.DiatomeasSpParte2DataGridView1.GroupByCaption = "Drag a column header here to group by that column"
        Me.DiatomeasSpParte2DataGridView1.Images.Add(CType(resources.GetObject("DiatomeasSpParte2DataGridView1.Images"), System.Drawing.Image))
        Me.DiatomeasSpParte2DataGridView1.Location = New System.Drawing.Point(1027, 66)
        Me.DiatomeasSpParte2DataGridView1.Name = "DiatomeasSpParte2DataGridView1"
        Me.DiatomeasSpParte2DataGridView1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DiatomeasSpParte2DataGridView1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DiatomeasSpParte2DataGridView1.PreviewInfo.ZoomFactor = 75
        Me.DiatomeasSpParte2DataGridView1.PrintInfo.PageSettings = CType(resources.GetObject("DiatomeasSpParte2DataGridView1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DiatomeasSpParte2DataGridView1.Size = New System.Drawing.Size(200, 200)
        Me.DiatomeasSpParte2DataGridView1.TabIndex = 19
        Me.DiatomeasSpParte2DataGridView1.Text = "C1TrueDBGrid2"
        Me.DiatomeasSpParte2DataGridView1.PropBag = resources.GetString("DiatomeasSpParte2DataGridView1.PropBag")
        '
        'btnCalcularIDP
        '
        Me.btnCalcularIDP.BackColor = System.Drawing.Color.White
        Me.btnCalcularIDP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCalcularIDP.FlatAppearance.BorderSize = 2
        Me.btnCalcularIDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularIDP.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalcularIDP.ForeColor = System.Drawing.Color.Black
        Me.btnCalcularIDP.Location = New System.Drawing.Point(26, 94)
        Me.btnCalcularIDP.Name = "btnCalcularIDP"
        Me.btnCalcularIDP.Size = New System.Drawing.Size(261, 41)
        Me.btnCalcularIDP.TabIndex = 1
        Me.btnCalcularIDP.Text = "Calcular IDP"
        Me.btnCalcularIDP.UseVisualStyleBackColor = False
        '
        'grpResultadoEspecie
        '
        Me.grpResultadoEspecie.Controls.Add(Me.PictureBox1)
        Me.grpResultadoEspecie.Controls.Add(Me.NombreTextBox)
        Me.grpResultadoEspecie.Controls.Add(Me.AcronimoTextBox)
        Me.grpResultadoEspecie.Controls.Add(AcronimoLabel)
        Me.grpResultadoEspecie.Controls.Add(NombreLabel)
        Me.grpResultadoEspecie.Controls.Add(Me.IDPTextBox)
        Me.grpResultadoEspecie.Controls.Add(IDPLabel)
        Me.grpResultadoEspecie.Controls.Add(Me.Tipo_de_AguasTextBox)
        Me.grpResultadoEspecie.Controls.Add(Tipo_de_AguasLabel)
        Me.grpResultadoEspecie.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResultadoEspecie.Location = New System.Drawing.Point(371, 202)
        Me.grpResultadoEspecie.Name = "grpResultadoEspecie"
        Me.grpResultadoEspecie.Size = New System.Drawing.Size(304, 356)
        Me.grpResultadoEspecie.TabIndex = 31
        Me.grpResultadoEspecie.TabStop = False
        Me.grpResultadoEspecie.Text = "Resultado"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.Scila7.My.Resources.Resources.logoKerku
        Me.PictureBox1.Location = New System.Drawing.Point(17, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 202)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'grpCalcularIDP
        '
        Me.grpCalcularIDP.Controls.Add(Me.IDPSignifica)
        Me.grpCalcularIDP.Controls.Add(PrecLabel)
        Me.grpCalcularIDP.Controls.Add(Me.PrecTextBox)
        Me.grpCalcularIDP.Controls.Add(ValorLabel)
        Me.grpCalcularIDP.Controls.Add(Me.ValorTextBox)
        Me.grpCalcularIDP.Controls.Add(Me.btnCalcularIDP)
        Me.grpCalcularIDP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCalcularIDP.Location = New System.Drawing.Point(683, 362)
        Me.grpCalcularIDP.Name = "grpCalcularIDP"
        Me.grpCalcularIDP.Size = New System.Drawing.Size(304, 146)
        Me.grpCalcularIDP.TabIndex = 35
        Me.grpCalcularIDP.TabStop = False
        Me.grpCalcularIDP.Text = "Calcular IDP"
        '
        'IDPSignifica
        '
        Me.IDPSignifica.BackColor = System.Drawing.Color.LightGray
        Me.IDPSignifica.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.IDPSignifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IDPSignifica.Location = New System.Drawing.Point(149, 34)
        Me.IDPSignifica.Name = "IDPSignifica"
        Me.IDPSignifica.Size = New System.Drawing.Size(118, 23)
        Me.IDPSignifica.TabIndex = 100
        Me.IDPSignifica.TabStop = False
        Me.IDPSignifica.UseVisualStyleBackColor = False
        '
        'PrecTextBox
        '
        Me.PrecTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDPBindingSource, "Prec", True))
        Me.PrecTextBox.Location = New System.Drawing.Point(97, 57)
        Me.PrecTextBox.Name = "PrecTextBox"
        Me.PrecTextBox.ReadOnly = True
        Me.PrecTextBox.Size = New System.Drawing.Size(46, 23)
        Me.PrecTextBox.TabIndex = 99
        Me.PrecTextBox.TabStop = False
        Me.PrecTextBox.Visible = False
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDPBindingSource, "Valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(97, 33)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.ReadOnly = True
        Me.ValorTextBox.Size = New System.Drawing.Size(46, 23)
        Me.ValorTextBox.TabIndex = 98
        Me.ValorTextBox.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(708, 519)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(262, 39)
        Me.btnCancelar.TabIndex = 36
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'MuestrasBindingSource
        '
        Me.MuestrasBindingSource.DataMember = "Muestras"
        Me.MuestrasBindingSource.DataSource = Me.Scilla10DataSet
        '
        'IdMuestraTextBox1
        '
        Me.IdMuestraTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDPBindingSource, "IdMuestra", True))
        Me.IdMuestraTextBox1.Location = New System.Drawing.Point(1085, 452)
        Me.IdMuestraTextBox1.Name = "IdMuestraTextBox1"
        Me.IdMuestraTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IdMuestraTextBox1.TabIndex = 39
        '
        'IdProyectoTextBox1
        '
        Me.IdProyectoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDPBindingSource, "IdProyecto", True))
        Me.IdProyectoTextBox1.Location = New System.Drawing.Point(1085, 481)
        Me.IdProyectoTextBox1.Name = "IdProyectoTextBox1"
        Me.IdProyectoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IdProyectoTextBox1.TabIndex = 40
        '
        'grpBuscarEspecie
        '
        Me.grpBuscarEspecie.Controls.Add(Me.Searchbynamecmb)
        Me.grpBuscarEspecie.Controls.Add(Me.Label4)
        Me.grpBuscarEspecie.Controls.Add(Me.btnAgregar)
        Me.grpBuscarEspecie.Controls.Add(Me.Label1)
        Me.grpBuscarEspecie.Controls.Add(Me.SearchTextBox)
        Me.grpBuscarEspecie.Controls.Add(Me.DensidadTextBox)
        Me.grpBuscarEspecie.Controls.Add(Me.Label2)
        Me.grpBuscarEspecie.Controls.Add(Me.Label3)
        Me.grpBuscarEspecie.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBuscarEspecie.Location = New System.Drawing.Point(371, 47)
        Me.grpBuscarEspecie.Name = "grpBuscarEspecie"
        Me.grpBuscarEspecie.Size = New System.Drawing.Size(304, 149)
        Me.grpBuscarEspecie.TabIndex = 41
        Me.grpBuscarEspecie.TabStop = False
        Me.grpBuscarEspecie.Text = "Buscar Especie"
        '
        'Searchbynamecmb
        '
        Me.Searchbynamecmb.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchbynamecmb.FormattingEnabled = True
        Me.Searchbynamecmb.Items.AddRange(New Object() {"", "Achnanthes delicatula spp hauckiana", "Achnanthes hungarica", "Achnanthes lanceolata", "Achnanthes minutissima  var minutissima", "Achnanthes exigua  ", "Achnanthes inflata", "Actinocyclus normanii fa subsalsus ", "Amphiprora alata ", "Amphora coffeaeformis", "Amphora libyca ", "Amphora ovalis", "Amphora perpusilla", "Amphora veneta", "Anomoeoneis sphaerophora", "Aulacoseira ambigua", "Aulacoseira granulata", "Aulacoseira granulata var angustissima", "Bacillaria paradoxa", "Caloneis amphisbaena", "Caloneis bacillum", "Caloneis ventricosa", "Caloneis oregonica", "Campilodiscus clypeus", "Capartogramma crucicula", "Cocconeis placentula", "Cocconeis placentula var euglypta", "Cocconeis placentula var lineata", "Cyclotella meneghiniana ", "Cyclotella striata", "Cyclotella atomus", "Cymbella affinis", "Cymbella cistula", "Cymbella silesiaca", "Cymbella lanceolata ", "Cymbella minuta", "Denticula elegans", "Denticula kutzingii", "Diploneis elliptica", "Diploneis ovalis ", "Diploneis pseudovalis", "Diploneis puella", "Diatoma vulgaris", "Ellerbekia arenaria", "Epithemia sorex ", "Epithemia adnata", "Eunotia bilunaris", "Eunotia circunborealis ", "Eunotia curvata", "Eunotia monodon", "Eunotia diodon", "Eunotia faba", "Eunotia rabenhorstiana", "Eunotia triodon", "Eunotia sudetica", "Eunotia pectinalis", "Eunotia praerupta ", "Fragilaria ulna", "Fragilaria capuccina", "Fragilaria construens", "Fragilaria crotonensis", "Fragilaria delicatissima", "Fragilaria heidenii", "Fragilaria inflata", "Frustulia rhomboides", "Gomphonema pseudoaugur", "Gomphonema  angustum", "Gomphonema clavatum", "Gomphonema gracile", "Gomphonema parvulum", "Gomphonema subclavatum", "Gomphonema truncatum", "Gyrosigma attenuatum", "Gyrosigma acuminatum", "Hantzschia amphioxys", "Hantzschia virgata", "Hantzschia virgata var capitellata", "Melosira varians", "Melosira arenaria", "Melosira lineata", "Melosira roeseana", "Meridion circulare", "Navicula accomoda", "Navicula atomus", "Navicula capitata", "Navicula capitata var hungarica", "Navicula capitatoradiata", "Navicula confervacea", "Navicula cryptocephala", "Navicula cuspidata", "Navicula erifuga", "Navicula gastrum", "Navicula gregaria", "Navicula goeppertiana", "Navicula halophila", "Navicula notha", "Navicula mutica", "Navicula peregrina", "Navicula pupula", "Navicula pygmaea", "Navicula radiosa", "Navicula rhynchocephala", "Navicula subminuscula", "Navicula tripunctata", "Neidium iridis", "Nitzschia dissipata", "Nitzchia acicularis", "Nitzchia amphibia", "Nitzchia amphiboides", "Nitzchia angustata", "Nitzchia brebissima", "Nitzchia constricta", "Nitzchia debilis", "Nitzchia draveillensis", "Nitzchia filiformis", "Nitzchia fonticola", "Nitzchia frustulum", "Nitzchia flexa", "Nitzchia gracilis", "Nitzchia heufleriana", "Nitzchia hungarica", "Nitzchia levidensis", "Nitzchia linearis", "Nitzchia microcephala", "Nitzchia paleacea", "Nitzchia nana", "Nitzchia palea", "Nitzchia sigma", "Nitzchia sigmoidea", "Nitzchia spectabilis", "Nitzchia supralitorea", "Nitzchia littoralis", "Nitzchia recta", "Nitzchia umbonata", "Nitzchia vermicularis", "Opephora martyi", "Orthoseira roeseana", "Pinnularia acrosphaeria", "Pinnularia borealis var rectangularis", "Pinnularia braunii", "Pinnularia interrupta", "Pinnularia gibba ", "Pinnularia gibba var linearis ", "Pinnularia maior", "Pinnularia microstaurum", "Pinnularia subcapitata", "Pinnularia viridis ", "Pleurosira laevis", "Reimeria sinuata", "Rhoicosphenia abbreviata", "Rhopalodia brebissoni ", "Rhopalodia gibba", "Rhopalodia gibberula", "Rhopalodia musculus", "Stauroneis phoenicenteron", "Stenopterobia curvula", "Stephanodiscus  minutulus", "Stephanodiscus hantzschii", "Surirella angusta", "Surirella tenera", "Surirella biseriata", "Surirella brebissonii", "Surirella linearis", "Surirella ovalis", "Thalassiosira haslae"})
        Me.Searchbynamecmb.Location = New System.Drawing.Point(84, 28)
        Me.Searchbynamecmb.Name = "Searchbynamecmb"
        Me.Searchbynamecmb.Size = New System.Drawing.Size(193, 21)
        Me.Searchbynamecmb.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nombre:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(84, 106)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(193, 31)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Acrónimo:"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(84, 64)
        Me.SearchTextBox.MaxLength = 4
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(56, 21)
        Me.SearchTextBox.TabIndex = 2
        '
        'DensidadTextBox
        '
        Me.DensidadTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DensidadTextBox.Location = New System.Drawing.Point(221, 66)
        Me.DensidadTextBox.Name = "DensidadTextBox"
        Me.DensidadTextBox.Size = New System.Drawing.Size(56, 21)
        Me.DensidadTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Densidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(173, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 20
        '
        'MostrarDatosGrid
        '
        Me.MostrarDatosGrid.AllowUserToAddRows = False
        Me.MostrarDatosGrid.AllowUserToDeleteRows = False
        Me.MostrarDatosGrid.AllowUserToResizeColumns = False
        Me.MostrarDatosGrid.AllowUserToResizeRows = False
        Me.MostrarDatosGrid.BackgroundColor = System.Drawing.Color.White
        Me.MostrarDatosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MostrarDatosGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Especie, Me.Densidad, Me.IDP})
        Me.MostrarDatosGrid.Enabled = False
        Me.MostrarDatosGrid.GridColor = System.Drawing.Color.White
        Me.MostrarDatosGrid.Location = New System.Drawing.Point(683, 47)
        Me.MostrarDatosGrid.Name = "MostrarDatosGrid"
        Me.MostrarDatosGrid.ReadOnly = True
        Me.MostrarDatosGrid.RowHeadersVisible = False
        Me.MostrarDatosGrid.Size = New System.Drawing.Size(304, 309)
        Me.MostrarDatosGrid.TabIndex = 26
        Me.MostrarDatosGrid.TabStop = False
        '
        'Especie
        '
        Me.Especie.HeaderText = "Especie"
        Me.Especie.Name = "Especie"
        Me.Especie.ReadOnly = True
        '
        'Densidad
        '
        Me.Densidad.HeaderText = "Densidad"
        Me.Densidad.Name = "Densidad"
        Me.Densidad.ReadOnly = True
        '
        'IDP
        '
        Me.IDP.HeaderText = "IDP"
        Me.IDP.Name = "IDP"
        Me.IDP.ReadOnly = True
        '
        'MuestrasDataGridView
        '
        Me.MuestrasDataGridView.AutoGenerateColumns = False
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn78, Me.DataGridViewTextBoxColumn79, Me.DataGridViewTextBoxColumn80, Me.DataGridViewTextBoxColumn81, Me.DataGridViewTextBoxColumn82, Me.DataGridViewTextBoxColumn83, Me.DataGridViewTextBoxColumn84, Me.DataGridViewTextBoxColumn85, Me.DataGridViewTextBoxColumn86, Me.DataGridViewTextBoxColumn87, Me.DataGridViewTextBoxColumn88, Me.DataGridViewTextBoxColumn89, Me.DataGridViewTextBoxColumn90, Me.DataGridViewTextBoxColumn91, Me.DataGridViewTextBoxColumn92, Me.DataGridViewTextBoxColumn93, Me.DataGridViewTextBoxColumn94, Me.DataGridViewTextBoxColumn95, Me.DataGridViewTextBoxColumn96, Me.DataGridViewTextBoxColumn97, Me.DataGridViewTextBoxColumn98, Me.DataGridViewTextBoxColumn99, Me.DataGridViewTextBoxColumn100, Me.DataGridViewTextBoxColumn101, Me.DataGridViewTextBoxColumn102, Me.DataGridViewTextBoxColumn103, Me.DataGridViewTextBoxColumn104, Me.DataGridViewTextBoxColumn105, Me.DataGridViewTextBoxColumn106, Me.DataGridViewTextBoxColumn107, Me.DataGridViewTextBoxColumn108, Me.DataGridViewTextBoxColumn109, Me.DataGridViewTextBoxColumn110})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(1018, 281)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(111, 156)
        Me.MuestrasDataGridView.TabIndex = 15
        Me.MuestrasDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdMuestra"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdMuestra"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.DataPropertyName = "IdProyecto"
        Me.DataGridViewTextBoxColumn78.HeaderText = "IdProyecto"
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        '
        'DataGridViewTextBoxColumn79
        '
        Me.DataGridViewTextBoxColumn79.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn79.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
        '
        'DataGridViewTextBoxColumn80
        '
        Me.DataGridViewTextBoxColumn80.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn80.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
        '
        'DataGridViewTextBoxColumn81
        '
        Me.DataGridViewTextBoxColumn81.DataPropertyName = "CodigoSitio"
        Me.DataGridViewTextBoxColumn81.HeaderText = "CodigoSitio"
        Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
        '
        'DataGridViewTextBoxColumn82
        '
        Me.DataGridViewTextBoxColumn82.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn82.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
        '
        'DataGridViewTextBoxColumn83
        '
        Me.DataGridViewTextBoxColumn83.DataPropertyName = "FQpH"
        Me.DataGridViewTextBoxColumn83.HeaderText = "FQpH"
        Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
        '
        'DataGridViewTextBoxColumn84
        '
        Me.DataGridViewTextBoxColumn84.DataPropertyName = "FQTemp"
        Me.DataGridViewTextBoxColumn84.HeaderText = "FQTemp"
        Me.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84"
        '
        'DataGridViewTextBoxColumn85
        '
        Me.DataGridViewTextBoxColumn85.DataPropertyName = "FQCond"
        Me.DataGridViewTextBoxColumn85.HeaderText = "FQCond"
        Me.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85"
        '
        'DataGridViewTextBoxColumn86
        '
        Me.DataGridViewTextBoxColumn86.DataPropertyName = "FQTurb"
        Me.DataGridViewTextBoxColumn86.HeaderText = "FQTurb"
        Me.DataGridViewTextBoxColumn86.Name = "DataGridViewTextBoxColumn86"
        '
        'DataGridViewTextBoxColumn87
        '
        Me.DataGridViewTextBoxColumn87.DataPropertyName = "FQCaudal"
        Me.DataGridViewTextBoxColumn87.HeaderText = "FQCaudal"
        Me.DataGridViewTextBoxColumn87.Name = "DataGridViewTextBoxColumn87"
        '
        'DataGridViewTextBoxColumn88
        '
        Me.DataGridViewTextBoxColumn88.DataPropertyName = "FQOD"
        Me.DataGridViewTextBoxColumn88.HeaderText = "FQOD"
        Me.DataGridViewTextBoxColumn88.Name = "DataGridViewTextBoxColumn88"
        '
        'DataGridViewTextBoxColumn89
        '
        Me.DataGridViewTextBoxColumn89.DataPropertyName = "FQNitratos"
        Me.DataGridViewTextBoxColumn89.HeaderText = "FQNitratos"
        Me.DataGridViewTextBoxColumn89.Name = "DataGridViewTextBoxColumn89"
        '
        'DataGridViewTextBoxColumn90
        '
        Me.DataGridViewTextBoxColumn90.DataPropertyName = "FQNitritos"
        Me.DataGridViewTextBoxColumn90.HeaderText = "FQNitritos"
        Me.DataGridViewTextBoxColumn90.Name = "DataGridViewTextBoxColumn90"
        '
        'DataGridViewTextBoxColumn91
        '
        Me.DataGridViewTextBoxColumn91.DataPropertyName = "FQAmonio"
        Me.DataGridViewTextBoxColumn91.HeaderText = "FQAmonio"
        Me.DataGridViewTextBoxColumn91.Name = "DataGridViewTextBoxColumn91"
        '
        'DataGridViewTextBoxColumn92
        '
        Me.DataGridViewTextBoxColumn92.DataPropertyName = "FQFosfato"
        Me.DataGridViewTextBoxColumn92.HeaderText = "FQFosfato"
        Me.DataGridViewTextBoxColumn92.Name = "DataGridViewTextBoxColumn92"
        '
        'DataGridViewTextBoxColumn93
        '
        Me.DataGridViewTextBoxColumn93.DataPropertyName = "ClorofilaA"
        Me.DataGridViewTextBoxColumn93.HeaderText = "ClorofilaA"
        Me.DataGridViewTextBoxColumn93.Name = "DataGridViewTextBoxColumn93"
        '
        'DataGridViewTextBoxColumn94
        '
        Me.DataGridViewTextBoxColumn94.DataPropertyName = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn94.HeaderText = "MateriaOrganica"
        Me.DataGridViewTextBoxColumn94.Name = "DataGridViewTextBoxColumn94"
        '
        'DataGridViewTextBoxColumn95
        '
        Me.DataGridViewTextBoxColumn95.DataPropertyName = "CianoDensidad"
        Me.DataGridViewTextBoxColumn95.HeaderText = "CianoDensidad"
        Me.DataGridViewTextBoxColumn95.Name = "DataGridViewTextBoxColumn95"
        '
        'DataGridViewTextBoxColumn96
        '
        Me.DataGridViewTextBoxColumn96.DataPropertyName = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn96.HeaderText = "DiatoDensidad"
        Me.DataGridViewTextBoxColumn96.Name = "DataGridViewTextBoxColumn96"
        '
        'DataGridViewTextBoxColumn97
        '
        Me.DataGridViewTextBoxColumn97.DataPropertyName = "Ecoli"
        Me.DataGridViewTextBoxColumn97.HeaderText = "Ecoli"
        Me.DataGridViewTextBoxColumn97.Name = "DataGridViewTextBoxColumn97"
        '
        'DataGridViewTextBoxColumn98
        '
        Me.DataGridViewTextBoxColumn98.DataPropertyName = "Olor"
        Me.DataGridViewTextBoxColumn98.HeaderText = "Olor"
        Me.DataGridViewTextBoxColumn98.Name = "DataGridViewTextBoxColumn98"
        '
        'DataGridViewTextBoxColumn99
        '
        Me.DataGridViewTextBoxColumn99.DataPropertyName = "Conectividad"
        Me.DataGridViewTextBoxColumn99.HeaderText = "Conectividad"
        Me.DataGridViewTextBoxColumn99.Name = "DataGridViewTextBoxColumn99"
        '
        'DataGridViewTextBoxColumn100
        '
        Me.DataGridViewTextBoxColumn100.DataPropertyName = "Naturalidad"
        Me.DataGridViewTextBoxColumn100.HeaderText = "Naturalidad"
        Me.DataGridViewTextBoxColumn100.Name = "DataGridViewTextBoxColumn100"
        '
        'DataGridViewTextBoxColumn101
        '
        Me.DataGridViewTextBoxColumn101.DataPropertyName = "AbuBasura"
        Me.DataGridViewTextBoxColumn101.HeaderText = "AbuBasura"
        Me.DataGridViewTextBoxColumn101.Name = "DataGridViewTextBoxColumn101"
        '
        'DataGridViewTextBoxColumn102
        '
        Me.DataGridViewTextBoxColumn102.DataPropertyName = "DivBasura"
        Me.DataGridViewTextBoxColumn102.HeaderText = "DivBasura"
        Me.DataGridViewTextBoxColumn102.Name = "DataGridViewTextBoxColumn102"
        '
        'DataGridViewTextBoxColumn103
        '
        Me.DataGridViewTextBoxColumn103.DataPropertyName = "IDP"
        Me.DataGridViewTextBoxColumn103.HeaderText = "IDP"
        Me.DataGridViewTextBoxColumn103.Name = "DataGridViewTextBoxColumn103"
        '
        'DataGridViewTextBoxColumn104
        '
        Me.DataGridViewTextBoxColumn104.DataPropertyName = "IMRP"
        Me.DataGridViewTextBoxColumn104.HeaderText = "IMRP"
        Me.DataGridViewTextBoxColumn104.Name = "DataGridViewTextBoxColumn104"
        '
        'DataGridViewTextBoxColumn105
        '
        Me.DataGridViewTextBoxColumn105.DataPropertyName = "IMRPlata"
        Me.DataGridViewTextBoxColumn105.HeaderText = "IMRPlata"
        Me.DataGridViewTextBoxColumn105.Name = "DataGridViewTextBoxColumn105"
        '
        'DataGridViewTextBoxColumn106
        '
        Me.DataGridViewTextBoxColumn106.DataPropertyName = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn106.HeaderText = "Eutrofizacion"
        Me.DataGridViewTextBoxColumn106.Name = "DataGridViewTextBoxColumn106"
        '
        'DataGridViewTextBoxColumn107
        '
        Me.DataGridViewTextBoxColumn107.DataPropertyName = "FQBOD"
        Me.DataGridViewTextBoxColumn107.HeaderText = "FQBOD"
        Me.DataGridViewTextBoxColumn107.Name = "DataGridViewTextBoxColumn107"
        '
        'DataGridViewTextBoxColumn108
        '
        Me.DataGridViewTextBoxColumn108.DataPropertyName = "IBPAMP"
        Me.DataGridViewTextBoxColumn108.HeaderText = "IBPAMP"
        Me.DataGridViewTextBoxColumn108.Name = "DataGridViewTextBoxColumn108"
        '
        'DataGridViewTextBoxColumn109
        '
        Me.DataGridViewTextBoxColumn109.DataPropertyName = "FitoTotal"
        Me.DataGridViewTextBoxColumn109.HeaderText = "FitoTotal"
        Me.DataGridViewTextBoxColumn109.Name = "DataGridViewTextBoxColumn109"
        '
        'DataGridViewTextBoxColumn110
        '
        Me.DataGridViewTextBoxColumn110.DataPropertyName = "Tanaids"
        Me.DataGridViewTextBoxColumn110.HeaderText = "Tanaids"
        Me.DataGridViewTextBoxColumn110.Name = "DataGridViewTextBoxColumn110"
        '
        'IDPTableAdapter
        '
        Me.IDPTableAdapter.ClearBeforeFill = True
        '
        'CaracDiatomeasTableAdapter
        '
        Me.CaracDiatomeasTableAdapter.ClearBeforeFill = True
        '
        'DiatomeasSpTableAdapter
        '
        Me.DiatomeasSpTableAdapter.ClearBeforeFill = True
        '
        'DiatomeasSpParte2TableAdapter
        '
        Me.DiatomeasSpParte2TableAdapter.ClearBeforeFill = True
        '
        'MuestrasBindingNavigator
        '
        Me.MuestrasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MuestrasBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.MuestrasBindingNavigator.BindingSource = Me.MuestrasBindingSource
        Me.MuestrasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MuestrasBindingNavigator.DeleteItem = Nothing
        Me.MuestrasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MuestrasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.EditTootStripButton, Me.SaveToolStripButton, Me.BindingNavigatorDeleteItem, Me.toolStripSeparator, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.MuestrasBindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator1})
        Me.MuestrasBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MuestrasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MuestrasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MuestrasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MuestrasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MuestrasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MuestrasBindingNavigator.Name = "MuestrasBindingNavigator"
        Me.MuestrasBindingNavigator.PositionItem = Me.MuestrasBindingNavigatorPositionItem
        Me.MuestrasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MuestrasBindingNavigator.Size = New System.Drawing.Size(993, 38)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 35)
        Me.BindingNavigatorCountItem.Text = "de {0}"
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
        'MuestrasBindingNavigatorPositionItem
        '
        Me.MuestrasBindingNavigatorPositionItem.AccessibleName = "Position"
        Me.MuestrasBindingNavigatorPositionItem.AutoSize = False
        Me.MuestrasBindingNavigatorPositionItem.Name = "MuestrasBindingNavigatorPositionItem"
        Me.MuestrasBindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.MuestrasBindingNavigatorPositionItem.Text = "0"
        Me.MuestrasBindingNavigatorPositionItem.ToolTipText = "Current position"
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
        'grpMuestra
        '
        Me.grpMuestra.BackColor = System.Drawing.Color.Transparent
        Me.grpMuestra.Controls.Add(Label25)
        Me.grpMuestra.Controls.Add(Label24)
        Me.grpMuestra.Controls.Add(Me.btnEditarSitios)
        Me.grpMuestra.Controls.Add(Me.CoordLONGTextBox)
        Me.grpMuestra.Controls.Add(Me.CoordLATTextBox)
        Me.grpMuestra.Controls.Add(Me.CodigoSitioComboBox)
        Me.grpMuestra.Controls.Add(Label5)
        Me.grpMuestra.Controls.Add(Me.IdProyectoTextBox)
        Me.grpMuestra.Controls.Add(Me.IdMuestraTextBox)
        Me.grpMuestra.Controls.Add(IdMuestraLabel)
        Me.grpMuestra.Controls.Add(Label6)
        Me.grpMuestra.Controls.Add(Me.AutorTextBox)
        Me.grpMuestra.Controls.Add(AutorLabel)
        Me.grpMuestra.Controls.Add(Me.TextBox1)
        Me.grpMuestra.Controls.Add(Me.CodigoSitioTextBox)
        Me.grpMuestra.Controls.Add(FechaLabel)
        Me.grpMuestra.Controls.Add(CodigoSitioLabel)
        Me.grpMuestra.Controls.Add(Me.FechaDateTimePicker)
        Me.grpMuestra.Enabled = False
        Me.grpMuestra.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMuestra.Location = New System.Drawing.Point(12, 47)
        Me.grpMuestra.Name = "grpMuestra"
        Me.grpMuestra.Size = New System.Drawing.Size(340, 221)
        Me.grpMuestra.TabIndex = 58
        Me.grpMuestra.TabStop = False
        Me.grpMuestra.Text = "Datos de la muestra"
        '
        'btnEditarSitios
        '
        Me.btnEditarSitios.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEditarSitios.FlatAppearance.BorderSize = 2
        Me.btnEditarSitios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarSitios.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarSitios.Location = New System.Drawing.Point(234, 155)
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
        Me.CoordLONGTextBox.Location = New System.Drawing.Point(246, 126)
        Me.CoordLONGTextBox.Name = "CoordLONGTextBox"
        Me.CoordLONGTextBox.Size = New System.Drawing.Size(74, 23)
        Me.CoordLONGTextBox.TabIndex = 115
        '
        'CoordLATTextBox
        '
        Me.CoordLATTextBox.Enabled = False
        Me.CoordLATTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoordLATTextBox.Location = New System.Drawing.Point(120, 125)
        Me.CoordLATTextBox.Name = "CoordLATTextBox"
        Me.CoordLATTextBox.Size = New System.Drawing.Size(74, 23)
        Me.CoordLATTextBox.TabIndex = 116
        '
        'CodigoSitioComboBox
        '
        Me.CodigoSitioComboBox.DataSource = Me.SitiosBindingSource
        Me.CodigoSitioComboBox.DisplayMember = "CodigoSitio"
        Me.CodigoSitioComboBox.FormattingEnabled = True
        Me.CodigoSitioComboBox.Location = New System.Drawing.Point(172, 97)
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
        Me.IdProyectoTextBox.Location = New System.Drawing.Point(293, 17)
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
        Me.IdMuestraTextBox.Location = New System.Drawing.Point(120, 18)
        Me.IdMuestraTextBox.Name = "IdMuestraTextBox"
        Me.IdMuestraTextBox.Size = New System.Drawing.Size(27, 23)
        Me.IdMuestraTextBox.TabIndex = 1
        Me.IdMuestraTextBox.TabStop = False
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Autor", True))
        Me.AutorTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorTextBox.Location = New System.Drawing.Point(120, 184)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(200, 23)
        Me.AutorTextBox.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "Nombre", True))
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(120, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 23)
        Me.TextBox1.TabIndex = 5
        '
        'CodigoSitioTextBox
        '
        Me.CodigoSitioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuestrasBindingSource, "CodigoSitio", True))
        Me.CodigoSitioTextBox.Enabled = False
        Me.CodigoSitioTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoSitioTextBox.Location = New System.Drawing.Point(120, 96)
        Me.CodigoSitioTextBox.Name = "CodigoSitioTextBox"
        Me.CodigoSitioTextBox.Size = New System.Drawing.Size(46, 23)
        Me.CodigoSitioTextBox.TabIndex = 9
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MuestrasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(120, 70)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.FechaDateTimePicker.TabIndex = 7
        '
        'SitiosTableAdapter
        '
        Me.SitiosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CaracIDPTableAdapter = Me.CaracDiatomeasTableAdapter
        Me.TableAdapterManager.DiatomeasSpParte2TableAdapter = Me.DiatomeasSpParte2TableAdapter
        Me.TableAdapterManager.DiatomeasSpTableAdapter = Me.DiatomeasSpTableAdapter
        Me.TableAdapterManager.IDPTableAdapter = Me.IDPTableAdapter
        Me.TableAdapterManager.UpdateOrder = Scila7.idpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDPDataGridView
        '
        Me.IDPDataGridView.AutoGenerateColumns = False
        Me.IDPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDPDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn111})
        Me.IDPDataGridView.DataSource = Me.IDPBindingSource
        Me.IDPDataGridView.Location = New System.Drawing.Point(1165, 292)
        Me.IDPDataGridView.Name = "IDPDataGridView"
        Me.IDPDataGridView.Size = New System.Drawing.Size(226, 104)
        Me.IDPDataGridView.TabIndex = 58
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdMuestra"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdMuestra"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdProyecto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdProyecto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Valor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn111
        '
        Me.DataGridViewTextBoxColumn111.DataPropertyName = "Prec"
        Me.DataGridViewTextBoxColumn111.HeaderText = "Prec"
        Me.DataGridViewTextBoxColumn111.Name = "DataGridViewTextBoxColumn111"
        '
        'ValorTextBox1
        '
        Me.ValorTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDPBindingSource, "Valor", True))
        Me.ValorTextBox1.Location = New System.Drawing.Point(1085, 507)
        Me.ValorTextBox1.Name = "ValorTextBox1"
        Me.ValorTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ValorTextBox1.TabIndex = 59
        '
        'frmIDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(993, 578)
        Me.Controls.Add(ValorLabel1)
        Me.Controls.Add(Me.ValorTextBox1)
        Me.Controls.Add(Me.IDPDataGridView)
        Me.Controls.Add(Me.grpMuestra)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
        Me.Controls.Add(Me.MuestrasDataGridView)
        Me.Controls.Add(Me.MostrarDatosGrid)
        Me.Controls.Add(Me.grpBuscarEspecie)
        Me.Controls.Add(IdProyectoLabel)
        Me.Controls.Add(Me.IdProyectoTextBox1)
        Me.Controls.Add(IdMuestraLabel1)
        Me.Controls.Add(Me.IdMuestraTextBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grpCalcularIDP)
        Me.Controls.Add(Me.grpResultadoEspecie)
        Me.Controls.Add(Me.DiatomeasSpParte2DataGridView1)
        Me.Controls.Add(Me.DiatomeasSpDataGridView1)
        Me.Name = "frmIDP"
        Me.Text = "Karku - Cálculo del IDP"
        CType(Me.IDPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaracDiatomeasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiatomeasSpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiatomeasSpParte2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiatomeasSpDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiatomeasSpParte2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResultadoEspecie.ResumeLayout(False)
        Me.grpResultadoEspecie.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCalcularIDP.ResumeLayout(False)
        Me.grpCalcularIDP.PerformLayout()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBuscarEspecie.ResumeLayout(False)
        Me.grpBuscarEspecie.PerformLayout()
        CType(Me.MostrarDatosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MuestrasBindingNavigator.ResumeLayout(False)
        Me.MuestrasBindingNavigator.PerformLayout()
        Me.grpMuestra.ResumeLayout(False)
        Me.grpMuestra.PerformLayout()
        CType(Me.SitiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitiosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDPDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents IDPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaracDiatomeasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcronimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tipo_de_AguasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiatomeasSpBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiatomeasSpParte2BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DiatomeasSpDataGridView1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DiatomeasSpParte2DataGridView1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnCalcularIDP As C1.Win.C1Input.C1Button
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpResultadoEspecie As System.Windows.Forms.GroupBox
    Friend WithEvents grpCalcularIDP As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As C1.Win.C1Input.C1Button
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdMuestraTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents IdProyectoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grpBuscarEspecie As System.Windows.Forms.GroupBox
    Friend WithEvents Searchbynamecmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As C1.Win.C1Input.C1Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DensidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MostrarDatosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Especie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Densidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPSignifica As System.Windows.Forms.Button
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn78 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn79 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn80 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn81 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn82 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn83 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn84 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn85 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn86 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn87 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn88 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn89 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn90 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn91 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn92 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn93 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn94 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn95 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn96 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn97 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn98 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn99 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn100 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn101 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn102 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn103 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn104 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn105 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn106 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn107 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn108 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn109 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn110 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdpDataSet As Scila7.idpDataSet
    Friend WithEvents IDPTableAdapter As Scila7.idpDataSetTableAdapters.IDPTableAdapter
    Friend WithEvents CaracDiatomeasTableAdapter As Scila7.idpDataSetTableAdapters.CaracIDPTableAdapter
    Friend WithEvents DiatomeasSpTableAdapter As Scila7.idpDataSetTableAdapters.DiatomeasSpTableAdapter
    Friend WithEvents DiatomeasSpParte2TableAdapter As Scila7.idpDataSetTableAdapters.DiatomeasSpParte2TableAdapter
    Friend WithEvents MuestrasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EditTootStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MuestrasBindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpMuestra As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditarSitios As C1.Win.C1Input.C1Button
    Friend WithEvents CoordLONGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CoordLATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoSitioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdMuestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CodigoSitioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SitiosDataSet As Scila7.sitiosDataSet
    Friend WithEvents SitiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SitiosTableAdapter As Scila7.sitiosDataSetTableAdapters.SitiosTableAdapter
    Friend WithEvents TableAdapterManager As Scila7.idpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDPDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn111 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorTextBox1 As System.Windows.Forms.TextBox
End Class
