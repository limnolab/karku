<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIMRP1m
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
        Dim Label1 As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim PrecisionLabel As System.Windows.Forms.Label
        Dim RangoLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIMRP1m))
        Me.ImrpTableAdapter = New Scila7.Scilla10DataSetTableAdapters.IMRPTableAdapter
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet
        Me.CaracMacroinvIMRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaracMacroinvIMRPTableAdapter = New Scila7.Scilla10DataSetTableAdapters.CaracMacroinvIMRPTableAdapter
        Me.TableAdapterManager = New Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
        Me.MacroinvSpIMRPTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MacroinvSpIMRPTableAdapter
        Me.MacroinvSpIMRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValorTextBox = New System.Windows.Forms.TextBox
        Me.btnCancelar = New C1.Win.C1Input.C1Button
        Me.grpIMRP = New System.Windows.Forms.GroupBox
        Me.btnGuardar = New C1.Win.C1Input.C1Button
        Me.txtNombreMuestra = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAgregar = New C1.Win.C1Input.C1Button
        Me.grpEspecie = New System.Windows.Forms.GroupBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.AutorTextBox = New System.Windows.Forms.TextBox
        Me.ValorTextBox1 = New System.Windows.Forms.TextBox
        Me.PrecisionTextBox = New System.Windows.Forms.TextBox
        Me.RangoTextBox = New System.Windows.Forms.TextBox
        Me.NotasTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MostrarDatosGrid = New System.Windows.Forms.DataGridView
        Me.Taxón = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vx = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MacroinvSpDataGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnBorrarMuestra = New System.Windows.Forms.Button
        Me.MuestrasDataGrid = New System.Windows.Forms.DataGridView
        Me.Muestra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MuestraIMRP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnBorrarSp = New System.Windows.Forms.Button
        Label1 = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        AutorLabel = New System.Windows.Forms.Label
        ValorLabel = New System.Windows.Forms.Label
        PrecisionLabel = New System.Windows.Forms.Label
        RangoLabel = New System.Windows.Forms.Label
        NotasLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaracMacroinvIMRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MacroinvSpIMRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIMRP.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpEspecie.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarDatosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MacroinvSpDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(17, 64)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(42, 13)
        Label1.TabIndex = 0
        Label1.Text = "Valor:"
        Label1.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(11, 42)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(57, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AutorLabel.Location = New System.Drawing.Point(11, 69)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(43, 13)
        AutorLabel.TabIndex = 4
        AutorLabel.Text = "Autor:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorLabel.Location = New System.Drawing.Point(11, 96)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(71, 13)
        ValorLabel.TabIndex = 6
        ValorLabel.Text = "Valor (Vx):"
        '
        'PrecisionLabel
        '
        PrecisionLabel.AutoSize = True
        PrecisionLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecisionLabel.Location = New System.Drawing.Point(11, 123)
        PrecisionLabel.Name = "PrecisionLabel"
        PrecisionLabel.Size = New System.Drawing.Size(63, 13)
        PrecisionLabel.TabIndex = 8
        PrecisionLabel.Text = "Precision:"
        '
        'RangoLabel
        '
        RangoLabel.AutoSize = True
        RangoLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RangoLabel.Location = New System.Drawing.Point(11, 150)
        RangoLabel.Name = "RangoLabel"
        RangoLabel.Size = New System.Drawing.Size(48, 13)
        RangoLabel.TabIndex = 10
        RangoLabel.Text = "Rango:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotasLabel.Location = New System.Drawing.Point(11, 177)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(44, 13)
        NotasLabel.TabIndex = 12
        NotasLabel.Text = "Notas:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(17, 35)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 13)
        Label2.TabIndex = 50
        Label2.Text = "Nombre:"
        '
        'ImrpTableAdapter
        '
        Me.ImrpTableAdapter.ClearBeforeFill = True
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'Scilla10DataSet
        '
        Me.Scilla10DataSet.DataSetName = "Scilla10DataSet"
        Me.Scilla10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaracMacroinvIMRPBindingSource
        '
        Me.CaracMacroinvIMRPBindingSource.DataMember = "CaracMacroinvIMRP"
        Me.CaracMacroinvIMRPBindingSource.DataSource = Me.Scilla10DataSet
        '
        'CaracMacroinvIMRPTableAdapter
        '
        Me.CaracMacroinvIMRPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CaracDiatomeasTableAdapter = Nothing
        Me.TableAdapterManager.CaracMacroinvIMRPTableAdapter = Me.CaracMacroinvIMRPTableAdapter
        Me.TableAdapterManager.CianoSpTableAdapter = Nothing
        Me.TableAdapterManager.DiatomeasSpParte2TableAdapter = Nothing
        Me.TableAdapterManager.DiatomeasSpTableAdapter = Nothing
        Me.TableAdapterManager.EutrofizacionTableAdapter = Nothing
        Me.TableAdapterManager.IBPAMPTableAdapter = Nothing
        Me.TableAdapterManager.IDPTableAdapter = Nothing
        Me.TableAdapterManager.IMRPlataTableAdapter = Nothing
        Me.TableAdapterManager.IMRPTableAdapter = Me.ImrpTableAdapter
        Me.TableAdapterManager.MacroinvSpIBPAMPTableAdapter = Nothing
        Me.TableAdapterManager.MacroinvSpIMRPTableAdapter = Me.MacroinvSpIMRPTableAdapter
        Me.TableAdapterManager.MuestrasTableAdapter = Me.MuestrasTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Scila7.Scilla10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MacroinvSpIMRPTableAdapter
        '
        Me.MacroinvSpIMRPTableAdapter.ClearBeforeFill = True
        '
        'MacroinvSpIMRPBindingSource
        '
        Me.MacroinvSpIMRPBindingSource.DataMember = "MacroinvSpIMRP"
        Me.MacroinvSpIMRPBindingSource.DataSource = Me.Scilla10DataSet
        '
        'IMRPBindingSource
        '
        Me.IMRPBindingSource.DataMember = "IMRP"
        Me.IMRPBindingSource.DataSource = Me.Scilla10DataSet
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMRPBindingSource, "Valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(80, 57)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.ReadOnly = True
        Me.ValorTextBox.Size = New System.Drawing.Size(56, 24)
        Me.ValorTextBox.TabIndex = 6
        Me.ValorTextBox.TabStop = False
        Me.ValorTextBox.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.Location = New System.Drawing.Point(546, 496)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(191, 24)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grpIMRP
        '
        Me.grpIMRP.Controls.Add(Me.btnGuardar)
        Me.grpIMRP.Controls.Add(Label2)
        Me.grpIMRP.Controls.Add(Me.txtNombreMuestra)
        Me.grpIMRP.Controls.Add(Label1)
        Me.grpIMRP.Controls.Add(Me.ValorTextBox)
        Me.grpIMRP.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpIMRP.Location = New System.Drawing.Point(536, 349)
        Me.grpIMRP.Name = "grpIMRP"
        Me.grpIMRP.Size = New System.Drawing.Size(210, 143)
        Me.grpIMRP.TabIndex = 41
        Me.grpIMRP.TabStop = False
        Me.grpIMRP.Text = "3 - Calcular IMRP"
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 2
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Location = New System.Drawing.Point(10, 86)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(191, 42)
        Me.btnGuardar.TabIndex = 51
        Me.btnGuardar.Text = "Calcular IMRP"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNombreMuestra
        '
        Me.txtNombreMuestra.Location = New System.Drawing.Point(80, 32)
        Me.txtNombreMuestra.Name = "txtNombreMuestra"
        Me.txtNombreMuestra.Size = New System.Drawing.Size(100, 24)
        Me.txtNombreMuestra.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 510)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1 - Seleccionar taxón"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"HYDROIDA", "TURBELLARIA", "ROTIFERA", "NEMATODA", "Naididae", "Tubificidae", "Lumbriculidae", "Enchytraeidae", "HIRUDINEA", "GASTROPODA", "PELECIPODA", "CLADOCERA", "COPEPODA", "CYCLOPOIDA", "HARPACTICOIDA", "OSTRACODA", "AMPHIPODA", "DECAPODA", "ISOPODA", "COLLEMBOLA", "EPHEMEROPTERA", "ODONATA", "PSOCOPTERA", "HETEROPTERA", "TRICHOPTERA", "Chironomidae", "Culicidae", "Tipulidae ", "Tabanidae ", "Ceratopogonidae", "Psychodidae", "Stratiomyidae", "Ephydridae", "Simuliidae", "COLEOPTERA", "TARDIGRADA", "ACARINA"})
        Me.ListBox1.Location = New System.Drawing.Point(16, 23)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(196, 484)
        Me.ListBox1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 20
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.Location = New System.Drawing.Point(6, 201)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(262, 46)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'grpEspecie
        '
        Me.grpEspecie.Controls.Add(NombreLabel)
        Me.grpEspecie.Controls.Add(Me.btnAgregar)
        Me.grpEspecie.Controls.Add(Me.NombreTextBox)
        Me.grpEspecie.Controls.Add(AutorLabel)
        Me.grpEspecie.Controls.Add(Me.AutorTextBox)
        Me.grpEspecie.Controls.Add(ValorLabel)
        Me.grpEspecie.Controls.Add(Me.ValorTextBox1)
        Me.grpEspecie.Controls.Add(PrecisionLabel)
        Me.grpEspecie.Controls.Add(Me.PrecisionTextBox)
        Me.grpEspecie.Controls.Add(RangoLabel)
        Me.grpEspecie.Controls.Add(Me.RangoTextBox)
        Me.grpEspecie.Controls.Add(NotasLabel)
        Me.grpEspecie.Controls.Add(Me.NotasTextBox)
        Me.grpEspecie.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEspecie.Location = New System.Drawing.Point(245, 12)
        Me.grpEspecie.Name = "grpEspecie"
        Me.grpEspecie.Size = New System.Drawing.Size(283, 510)
        Me.grpEspecie.TabIndex = 39
        Me.grpEspecie.TabStop = False
        Me.grpEspecie.Text = "2 - Detalles del taxón"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(88, 39)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(180, 21)
        Me.NombreTextBox.TabIndex = 3
        Me.NombreTextBox.TabStop = False
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Autor", True))
        Me.AutorTextBox.Enabled = False
        Me.AutorTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorTextBox.Location = New System.Drawing.Point(88, 66)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(180, 21)
        Me.AutorTextBox.TabIndex = 5
        Me.AutorTextBox.TabStop = False
        '
        'ValorTextBox1
        '
        Me.ValorTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Valor", True))
        Me.ValorTextBox1.Enabled = False
        Me.ValorTextBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorTextBox1.Location = New System.Drawing.Point(88, 93)
        Me.ValorTextBox1.Name = "ValorTextBox1"
        Me.ValorTextBox1.Size = New System.Drawing.Size(36, 21)
        Me.ValorTextBox1.TabIndex = 7
        Me.ValorTextBox1.TabStop = False
        '
        'PrecisionTextBox
        '
        Me.PrecisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Precision", True))
        Me.PrecisionTextBox.Enabled = False
        Me.PrecisionTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecisionTextBox.Location = New System.Drawing.Point(88, 120)
        Me.PrecisionTextBox.Name = "PrecisionTextBox"
        Me.PrecisionTextBox.Size = New System.Drawing.Size(36, 21)
        Me.PrecisionTextBox.TabIndex = 9
        Me.PrecisionTextBox.TabStop = False
        '
        'RangoTextBox
        '
        Me.RangoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Rango", True))
        Me.RangoTextBox.Enabled = False
        Me.RangoTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RangoTextBox.Location = New System.Drawing.Point(88, 147)
        Me.RangoTextBox.Name = "RangoTextBox"
        Me.RangoTextBox.Size = New System.Drawing.Size(64, 21)
        Me.RangoTextBox.TabIndex = 11
        Me.RangoTextBox.TabStop = False
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaracMacroinvIMRPBindingSource, "Notas", True))
        Me.NotasTextBox.Enabled = False
        Me.NotasTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasTextBox.Location = New System.Drawing.Point(88, 174)
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(180, 21)
        Me.NotasTextBox.TabIndex = 13
        Me.NotasTextBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.Scila7.My.Resources.Resources.logoKerku
        Me.PictureBox1.Location = New System.Drawing.Point(251, 264)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'MostrarDatosGrid
        '
        Me.MostrarDatosGrid.AllowUserToAddRows = False
        Me.MostrarDatosGrid.AllowUserToDeleteRows = False
        Me.MostrarDatosGrid.AllowUserToOrderColumns = True
        Me.MostrarDatosGrid.AllowUserToResizeColumns = False
        Me.MostrarDatosGrid.AllowUserToResizeRows = False
        Me.MostrarDatosGrid.BackgroundColor = System.Drawing.Color.White
        Me.MostrarDatosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MostrarDatosGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Taxón, Me.Vx})
        Me.MostrarDatosGrid.Enabled = False
        Me.MostrarDatosGrid.GridColor = System.Drawing.Color.White
        Me.MostrarDatosGrid.Location = New System.Drawing.Point(536, 21)
        Me.MostrarDatosGrid.Name = "MostrarDatosGrid"
        Me.MostrarDatosGrid.RowHeadersVisible = False
        Me.MostrarDatosGrid.Size = New System.Drawing.Size(203, 287)
        Me.MostrarDatosGrid.TabIndex = 38
        Me.MostrarDatosGrid.TabStop = False
        '
        'Taxón
        '
        Me.Taxón.HeaderText = "Taxón"
        Me.Taxón.Name = "Taxón"
        '
        'Vx
        '
        Me.Vx.HeaderText = "Vx"
        Me.Vx.Name = "Vx"
        '
        'MacroinvSpDataGrid
        '
        Me.MacroinvSpDataGrid.AllowUpdate = False
        Me.MacroinvSpDataGrid.DataSource = Me.MacroinvSpIMRPBindingSource
        Me.MacroinvSpDataGrid.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Inverted
        Me.MacroinvSpDataGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.MacroinvSpDataGrid.Images.Add(CType(resources.GetObject("MacroinvSpDataGrid.Images"), System.Drawing.Image))
        Me.MacroinvSpDataGrid.Location = New System.Drawing.Point(858, 429)
        Me.MacroinvSpDataGrid.Name = "MacroinvSpDataGrid"
        Me.MacroinvSpDataGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.MacroinvSpDataGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.MacroinvSpDataGrid.PreviewInfo.ZoomFactor = 75
        Me.MacroinvSpDataGrid.PrintInfo.PageSettings = CType(resources.GetObject("MacroinvSpDataGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.MacroinvSpDataGrid.Size = New System.Drawing.Size(173, 107)
        Me.MacroinvSpDataGrid.TabIndex = 43
        Me.MacroinvSpDataGrid.Text = "C1TrueDBGrid1"
        Me.MacroinvSpDataGrid.Visible = False
        Me.MacroinvSpDataGrid.PropBag = resources.GetString("MacroinvSpDataGrid.PropBag")
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(867, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Exportar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBorrarMuestra
        '
        Me.btnBorrarMuestra.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBorrarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarMuestra.Location = New System.Drawing.Point(752, 497)
        Me.btnBorrarMuestra.Name = "btnBorrarMuestra"
        Me.btnBorrarMuestra.Size = New System.Drawing.Size(98, 23)
        Me.btnBorrarMuestra.TabIndex = 45
        Me.btnBorrarMuestra.TabStop = False
        Me.btnBorrarMuestra.Text = "Borrar muestra"
        Me.btnBorrarMuestra.UseVisualStyleBackColor = True
        '
        'MuestrasDataGrid
        '
        Me.MuestrasDataGrid.AllowUserToAddRows = False
        Me.MuestrasDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.MuestrasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Muestra, Me.MuestraIMRP})
        Me.MuestrasDataGrid.Location = New System.Drawing.Point(752, 21)
        Me.MuestrasDataGrid.Name = "MuestrasDataGrid"
        Me.MuestrasDataGrid.ReadOnly = True
        Me.MuestrasDataGrid.RowHeadersVisible = False
        Me.MuestrasDataGrid.Size = New System.Drawing.Size(205, 469)
        Me.MuestrasDataGrid.TabIndex = 44
        Me.MuestrasDataGrid.TabStop = False
        '
        'Muestra
        '
        Me.Muestra.HeaderText = "Muestra"
        Me.Muestra.Name = "Muestra"
        Me.Muestra.ReadOnly = True
        '
        'MuestraIMRP
        '
        Me.MuestraIMRP.HeaderText = "IMRP"
        Me.MuestraIMRP.Name = "MuestraIMRP"
        Me.MuestraIMRP.ReadOnly = True
        '
        'btnBorrarSp
        '
        Me.btnBorrarSp.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBorrarSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSp.Location = New System.Drawing.Point(641, 314)
        Me.btnBorrarSp.Name = "btnBorrarSp"
        Me.btnBorrarSp.Size = New System.Drawing.Size(98, 23)
        Me.btnBorrarSp.TabIndex = 47
        Me.btnBorrarSp.TabStop = False
        Me.btnBorrarSp.Text = "Borrar especie"
        Me.btnBorrarSp.UseVisualStyleBackColor = True
        '
        'frmIMRP1m
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 534)
        Me.Controls.Add(Me.btnBorrarSp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBorrarMuestra)
        Me.Controls.Add(Me.MuestrasDataGrid)
        Me.Controls.Add(Me.MacroinvSpDataGrid)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grpIMRP)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpEspecie)
        Me.Controls.Add(Me.MostrarDatosGrid)
        Me.Name = "frmIMRP1m"
        Me.Text = "Karku - Calcular IMRP"
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaracMacroinvIMRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MacroinvSpIMRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIMRP.ResumeLayout(False)
        Me.grpIMRP.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpEspecie.ResumeLayout(False)
        Me.grpEspecie.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarDatosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MacroinvSpDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImrpTableAdapter As Scila7.Scilla10DataSetTableAdapters.IMRPTableAdapter
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents CaracMacroinvIMRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaracMacroinvIMRPTableAdapter As Scila7.Scilla10DataSetTableAdapters.CaracMacroinvIMRPTableAdapter
    Friend WithEvents TableAdapterManager As Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MacroinvSpIMRPTableAdapter As Scila7.Scilla10DataSetTableAdapters.MacroinvSpIMRPTableAdapter
    Friend WithEvents MacroinvSpIMRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As C1.Win.C1Input.C1Button
    Friend WithEvents grpIMRP As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As C1.Win.C1Input.C1Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpEspecie As System.Windows.Forms.GroupBox
    Friend WithEvents MostrarDatosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Taxón As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MacroinvSpDataGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PrecisionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RangoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBorrarMuestra As System.Windows.Forms.Button
    Friend WithEvents MuestrasDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Muestra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MuestraIMRP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombreMuestra As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As C1.Win.C1Input.C1Button
    Friend WithEvents btnBorrarSp As System.Windows.Forms.Button
End Class
