<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFQ
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
        Dim _1Label As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFQ))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.ParametrosFQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FqDataSet = New Scila7.fqDataSet()
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
        Me.dgvCustomParameters = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminarFQ = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdMuestraTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardarFQ = New System.Windows.Forms.Button()
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
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox2 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox3 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox4 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox5 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox6 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox7 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox8 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox9 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox10 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox11 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox12 = New C1.Win.C1Input.C1TextBox()
        Me.FQdatagridview = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1TextBox13 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox16 = New C1.Win.C1Input.C1TextBox()
        Me.C1ComboBox1 = New C1.Win.C1Input.C1ComboBox()
        Me.C1ComboBox2 = New C1.Win.C1Input.C1ComboBox()
        _1Label = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosFQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FqDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitiosMuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MuestrasBindingNavigator.SuspendLayout()
        CType(Me.dgvCustomParameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FQdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_1Label
        '
        _1Label.AutoSize = True
        _1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _1Label.Location = New System.Drawing.Point(74, 140)
        _1Label.Name = "_1Label"
        _1Label.Size = New System.Drawing.Size(138, 198)
        _1Label.TabIndex = 183
        _1Label.Text = "pH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oxígeno Disuelto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Turbidez" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conductividad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "% Oxígeno D" & _
    "isuelto"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(74, 392)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(105, 198)
        Label5.TabIndex = 191
        Label5.Text = "Nitratos (NO3)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nitritos (NO2)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amonio (NH4)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fosfato (PO4)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DBO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DQO"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(458, 146)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(45, 126)
        Label6.TabIndex = 198
        Label6.Text = "SST" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Olor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Color" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COD"
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
        'ParametrosFQBindingSource
        '
        Me.ParametrosFQBindingSource.DataMember = "ParametrosFQ"
        Me.ParametrosFQBindingSource.DataSource = Me.FqDataSet
        '
        'FqDataSet
        '
        Me.FqDataSet.DataSetName = "fqDataSet"
        Me.FqDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.MuestrasBindingNavigator.Size = New System.Drawing.Size(906, 30)
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
        Me.lblMuestraenFQ.Size = New System.Drawing.Size(906, 28)
        Me.lblMuestraenFQ.TabIndex = 157
        Me.lblMuestraenFQ.Text = "lblMuestraenFQ"
        Me.lblMuestraenFQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvCustomParameters
        '
        Me.dgvCustomParameters.DataSource = Me.ParametrosFQBindingSource
        Me.dgvCustomParameters.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Inverted
        Me.dgvCustomParameters.Images.Add(CType(resources.GetObject("dgvCustomParameters.Images"), System.Drawing.Image))
        Me.dgvCustomParameters.Location = New System.Drawing.Point(461, 322)
        Me.dgvCustomParameters.Name = "dgvCustomParameters"
        Me.dgvCustomParameters.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomParameters.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.dgvCustomParameters.PreviewInfo.ZoomFactor = 75.0R
        Me.dgvCustomParameters.PrintInfo.PageSettings = CType(resources.GetObject("dgvCustomParameters.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.dgvCustomParameters.Size = New System.Drawing.Size(241, 274)
        Me.dgvCustomParameters.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.dgvCustomParameters.TabIndex = 4
        Me.dgvCustomParameters.PropBag = resources.GetString("dgvCustomParameters.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(386, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 24)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Parámetros personalizados"
        '
        'btnEliminarFQ
        '
        Me.btnEliminarFQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarFQ.FlatAppearance.BorderSize = 0
        Me.btnEliminarFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarFQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarFQ.Image = Global.Scila7.My.Resources.Resources.Cancel1
        Me.btnEliminarFQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarFQ.Location = New System.Drawing.Point(12, 707)
        Me.btnEliminarFQ.Name = "btnEliminarFQ"
        Me.btnEliminarFQ.Size = New System.Drawing.Size(306, 31)
        Me.btnEliminarFQ.TabIndex = 164
        Me.btnEliminarFQ.TabStop = False
        Me.btnEliminarFQ.Text = "Borrar datos físico-químicos de esta muestra"
        Me.btnEliminarFQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarFQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminarFQ.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 24)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Físico-químicos"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(386, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Otros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Nutrientes"
        '
        'btnGuardarFQ
        '
        Me.btnGuardarFQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarFQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGuardarFQ.FlatAppearance.BorderSize = 0
        Me.btnGuardarFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarFQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarFQ.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarFQ.Image = Global.Scila7.My.Resources.Resources.Save
        Me.btnGuardarFQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarFQ.Location = New System.Drawing.Point(631, 676)
        Me.btnGuardarFQ.Name = "btnGuardarFQ"
        Me.btnGuardarFQ.Size = New System.Drawing.Size(258, 56)
        Me.btnGuardarFQ.TabIndex = 5
        Me.btnGuardarFQ.Text = "Guardar datos físico-químicos"
        Me.btnGuardarFQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarFQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarFQ.UseVisualStyleBackColor = False
        '
        'FQId
        '
        Me.FQId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FQId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosFQBindingSource, "Id", True))
        Me.FQId.Location = New System.Drawing.Point(116, 718)
        Me.FQId.Name = "FQId"
        Me.FQId.Size = New System.Drawing.Size(26, 20)
        Me.FQId.TabIndex = 113
        '
        'FQIdMuestra
        '
        Me.FQIdMuestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FQIdMuestra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosFQBindingSource, "IdMuestra", True))
        Me.FQIdMuestra.Location = New System.Drawing.Point(93, 718)
        Me.FQIdMuestra.Name = "FQIdMuestra"
        Me.FQIdMuestra.Size = New System.Drawing.Size(26, 20)
        Me.FQIdMuestra.TabIndex = 115
        '
        'FQIdProyecto
        '
        Me.FQIdProyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FQIdProyecto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosFQBindingSource, "IdProyecto", True))
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
        Me.MenuStrip1.Size = New System.Drawing.Size(906, 24)
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
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(329, 614)
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
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(145, 124)
        Me.MuestrasDataGridView.TabIndex = 3
        Me.MuestrasDataGridView.TabStop = False
        Me.MuestrasDataGridView.Visible = False
        '
        'C1TextBox1
        '
        Me.C1TextBox1.AutoSize = False
        Me.C1TextBox1.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p1", True))
        Me.C1TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox1.Location = New System.Drawing.Point(218, 136)
        Me.C1TextBox1.MarkEmpty = True
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox1.TabIndex = 185
        Me.C1TextBox1.Tag = Nothing
        Me.C1TextBox1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox2
        '
        Me.C1TextBox2.AutoSize = False
        Me.C1TextBox2.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p4", True))
        Me.C1TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox2.Location = New System.Drawing.Point(218, 172)
        Me.C1TextBox2.MarkEmpty = True
        Me.C1TextBox2.Name = "C1TextBox2"
        Me.C1TextBox2.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox2.TabIndex = 186
        Me.C1TextBox2.Tag = Nothing
        Me.C1TextBox2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox3
        '
        Me.C1TextBox3.AutoSize = False
        Me.C1TextBox3.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p2", True))
        Me.C1TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox3.Location = New System.Drawing.Point(218, 244)
        Me.C1TextBox3.MarkEmpty = True
        Me.C1TextBox3.Name = "C1TextBox3"
        Me.C1TextBox3.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox3.TabIndex = 188
        Me.C1TextBox3.Tag = Nothing
        Me.C1TextBox3.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox4
        '
        Me.C1TextBox4.AutoSize = False
        Me.C1TextBox4.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p3", True))
        Me.C1TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox4.Location = New System.Drawing.Point(218, 208)
        Me.C1TextBox4.MarkEmpty = True
        Me.C1TextBox4.Name = "C1TextBox4"
        Me.C1TextBox4.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox4.TabIndex = 187
        Me.C1TextBox4.Tag = Nothing
        Me.C1TextBox4.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox5
        '
        Me.C1TextBox5.AutoSize = False
        Me.C1TextBox5.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p5", True))
        Me.C1TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox5.Location = New System.Drawing.Point(218, 316)
        Me.C1TextBox5.MarkEmpty = True
        Me.C1TextBox5.Name = "C1TextBox5"
        Me.C1TextBox5.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox5.TabIndex = 190
        Me.C1TextBox5.Tag = Nothing
        Me.C1TextBox5.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox6
        '
        Me.C1TextBox6.AutoSize = False
        Me.C1TextBox6.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p6", True))
        Me.C1TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox6.Location = New System.Drawing.Point(218, 280)
        Me.C1TextBox6.MarkEmpty = True
        Me.C1TextBox6.Name = "C1TextBox6"
        Me.C1TextBox6.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox6.TabIndex = 189
        Me.C1TextBox6.Tag = Nothing
        Me.C1TextBox6.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox7
        '
        Me.C1TextBox7.AutoSize = False
        Me.C1TextBox7.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p13", True))
        Me.C1TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox7.Location = New System.Drawing.Point(218, 568)
        Me.C1TextBox7.MarkEmpty = True
        Me.C1TextBox7.Name = "C1TextBox7"
        Me.C1TextBox7.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox7.TabIndex = 197
        Me.C1TextBox7.Tag = Nothing
        Me.C1TextBox7.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox8
        '
        Me.C1TextBox8.AutoSize = False
        Me.C1TextBox8.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p12", True))
        Me.C1TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox8.Location = New System.Drawing.Point(218, 532)
        Me.C1TextBox8.MarkEmpty = True
        Me.C1TextBox8.Name = "C1TextBox8"
        Me.C1TextBox8.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox8.TabIndex = 196
        Me.C1TextBox8.Tag = Nothing
        Me.C1TextBox8.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox9
        '
        Me.C1TextBox9.AutoSize = False
        Me.C1TextBox9.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p11", True))
        Me.C1TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox9.Location = New System.Drawing.Point(218, 496)
        Me.C1TextBox9.MarkEmpty = True
        Me.C1TextBox9.Name = "C1TextBox9"
        Me.C1TextBox9.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox9.TabIndex = 195
        Me.C1TextBox9.Tag = Nothing
        Me.C1TextBox9.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox10
        '
        Me.C1TextBox10.AutoSize = False
        Me.C1TextBox10.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p10", True))
        Me.C1TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox10.Location = New System.Drawing.Point(218, 460)
        Me.C1TextBox10.MarkEmpty = True
        Me.C1TextBox10.Name = "C1TextBox10"
        Me.C1TextBox10.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox10.TabIndex = 194
        Me.C1TextBox10.Tag = Nothing
        Me.C1TextBox10.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox11
        '
        Me.C1TextBox11.AutoSize = False
        Me.C1TextBox11.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p9", True))
        Me.C1TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox11.Location = New System.Drawing.Point(218, 424)
        Me.C1TextBox11.MarkEmpty = True
        Me.C1TextBox11.Name = "C1TextBox11"
        Me.C1TextBox11.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox11.TabIndex = 193
        Me.C1TextBox11.Tag = Nothing
        Me.C1TextBox11.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox12
        '
        Me.C1TextBox12.AutoSize = False
        Me.C1TextBox12.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p8", True))
        Me.C1TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox12.Location = New System.Drawing.Point(218, 388)
        Me.C1TextBox12.MarkEmpty = True
        Me.C1TextBox12.Name = "C1TextBox12"
        Me.C1TextBox12.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox12.TabIndex = 192
        Me.C1TextBox12.Tag = Nothing
        Me.C1TextBox12.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'FQdatagridview
        '
        Me.FQdatagridview.AllowAddNew = True
        Me.FQdatagridview.AllowArrows = False
        Me.FQdatagridview.AllowColMove = False
        Me.FQdatagridview.AllowColSelect = False
        Me.FQdatagridview.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.FQdatagridview.BackColor = System.Drawing.SystemColors.Window
        Me.FQdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FQdatagridview.CaptionHeight = 17
        Me.FQdatagridview.DataSource = Me.ParametrosFQBindingSource
        Me.FQdatagridview.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Form
        Me.FQdatagridview.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.FQdatagridview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FQdatagridview.Images.Add(CType(resources.GetObject("FQdatagridview.Images"), System.Drawing.Image))
        Me.FQdatagridview.LinesPerRow = 4
        Me.FQdatagridview.Location = New System.Drawing.Point(506, 651)
        Me.FQdatagridview.Name = "FQdatagridview"
        Me.FQdatagridview.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.FQdatagridview.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.FQdatagridview.PreviewInfo.ZoomFactor = 75.0R
        Me.FQdatagridview.PrintInfo.PageSettings = CType(resources.GetObject("FQdatagridview.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.FQdatagridview.RecordSelectors = False
        Me.FQdatagridview.RowDivider.Color = System.Drawing.Color.White
        Me.FQdatagridview.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.None
        Me.FQdatagridview.RowHeight = 1
        Me.FQdatagridview.RowSubDividerColor = System.Drawing.Color.White
        Me.FQdatagridview.Size = New System.Drawing.Size(117, 81)
        Me.FQdatagridview.TabIndex = 177
        Me.FQdatagridview.Text = "C1TrueDBGrid1"
        Me.FQdatagridview.ViewCaptionWidth = 200
        Me.FQdatagridview.Visible = False
        Me.FQdatagridview.PropBag = resources.GetString("FQdatagridview.PropBag")
        '
        'C1TextBox13
        '
        Me.C1TextBox13.AutoSize = False
        Me.C1TextBox13.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p17", True))
        Me.C1TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox13.Location = New System.Drawing.Point(602, 250)
        Me.C1TextBox13.MarkEmpty = True
        Me.C1TextBox13.Name = "C1TextBox13"
        Me.C1TextBox13.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox13.TabIndex = 202
        Me.C1TextBox13.Tag = Nothing
        Me.C1TextBox13.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox16
        '
        Me.C1TextBox16.AutoSize = False
        Me.C1TextBox16.BackColor = System.Drawing.Color.LightGray
        Me.C1TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosFQBindingSource, "p14", True))
        Me.C1TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox16.Location = New System.Drawing.Point(602, 142)
        Me.C1TextBox16.MarkEmpty = True
        Me.C1TextBox16.Name = "C1TextBox16"
        Me.C1TextBox16.Size = New System.Drawing.Size(100, 28)
        Me.C1TextBox16.TabIndex = 199
        Me.C1TextBox16.Tag = Nothing
        Me.C1TextBox16.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1ComboBox1
        '
        Me.C1ComboBox1.AutoOpen = False
        Me.C1ComboBox1.AutoSize = False
        Me.C1ComboBox1.BackColor = System.Drawing.Color.LightGray
        Me.C1ComboBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1ComboBox1.GapHeight = 0
        Me.C1ComboBox1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox1.ItemsDisplayMember = ""
        Me.C1ComboBox1.ItemsValueMember = ""
        Me.C1ComboBox1.Location = New System.Drawing.Point(602, 176)
        Me.C1ComboBox1.Name = "C1ComboBox1"
        Me.C1ComboBox1.Size = New System.Drawing.Size(100, 28)
        Me.C1ComboBox1.TabIndex = 203
        Me.C1ComboBox1.Tag = Nothing
        Me.C1ComboBox1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1ComboBox2
        '
        Me.C1ComboBox2.AutoOpen = False
        Me.C1ComboBox2.AutoSize = False
        Me.C1ComboBox2.BackColor = System.Drawing.Color.LightGray
        Me.C1ComboBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1ComboBox2.GapHeight = 0
        Me.C1ComboBox2.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox2.ItemsDisplayMember = ""
        Me.C1ComboBox2.ItemsValueMember = ""
        Me.C1ComboBox2.Location = New System.Drawing.Point(602, 210)
        Me.C1ComboBox2.Name = "C1ComboBox2"
        Me.C1ComboBox2.Size = New System.Drawing.Size(100, 28)
        Me.C1ComboBox2.TabIndex = 204
        Me.C1ComboBox2.Tag = Nothing
        Me.C1ComboBox2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'frmFQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(906, 750)
        Me.Controls.Add(Me.C1ComboBox2)
        Me.Controls.Add(Me.C1ComboBox1)
        Me.Controls.Add(Me.C1TextBox13)
        Me.Controls.Add(Me.C1TextBox16)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.C1TextBox7)
        Me.Controls.Add(Me.C1TextBox8)
        Me.Controls.Add(Me.C1TextBox9)
        Me.Controls.Add(Me.C1TextBox10)
        Me.Controls.Add(Me.C1TextBox11)
        Me.Controls.Add(Me.C1TextBox12)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.C1TextBox5)
        Me.Controls.Add(Me.C1TextBox6)
        Me.Controls.Add(Me.C1TextBox3)
        Me.Controls.Add(Me.C1TextBox4)
        Me.Controls.Add(Me.C1TextBox2)
        Me.Controls.Add(Me.C1TextBox1)
        Me.Controls.Add(_1Label)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblMuestraenFQ)
        Me.Controls.Add(Me.MuestrasBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(Me.MuestrasDataGridView)
        Me.Controls.Add(Me.lblNombreMuestra)
        Me.Controls.Add(Me.dgvCustomParameters)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEliminarFQ)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IdMuestraTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FQdatagridview)
        Me.Controls.Add(Me.btnGuardarFQ)
        Me.Controls.Add(Me.FQId)
        Me.Controls.Add(Me.FQIdMuestra)
        Me.Controls.Add(Me.FQIdProyecto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PARÁMETROS FÍSICO-QUÍMICOS"
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosFQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FqDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitiosMuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MuestrasBindingNavigator.ResumeLayout(False)
        Me.MuestrasBindingNavigator.PerformLayout()
        CType(Me.dgvCustomParameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FQdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnGuardarFQ As System.Windows.Forms.Button
    Friend WithEvents FQId As System.Windows.Forms.TextBox
    Friend WithEvents FQIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents FQIdMuestra As System.Windows.Forms.TextBox
    Friend WithEvents lblMuestraenFQ As System.Windows.Forms.Label
    Friend WithEvents IdMuestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEliminarFQ As System.Windows.Forms.Button
    Private WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Private WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Private WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents FqDataSet As Scila7.fqDataSet
    Private WithEvents ParametrosFQBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ParametrosFQTableAdapter As Scila7.fqDataSetTableAdapters.ParametrosFQTableAdapter
    Private WithEvents SitiosMuestrasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ModulosBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ModulosTableAdapter As Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvCustomParameters As C1.Win.C1TrueDBGrid.C1TrueDBGrid
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
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox6 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox9 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox11 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox12 As C1.Win.C1Input.C1TextBox
    Friend WithEvents FQdatagridview As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1ComboBox2 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents C1ComboBox1 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents C1TextBox13 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox16 As C1.Win.C1Input.C1TextBox
End Class
