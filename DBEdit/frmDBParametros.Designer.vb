<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBParametros
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
        Dim IdTaxonLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim NivelTaxonomicoLabel As System.Windows.Forms.Label
        Dim AcronimoLabel As System.Windows.Forms.Label
        Dim NivelPadreLabel As System.Windows.Forms.Label
        Me.cmFuente = New System.Windows.Forms.ComboBox()
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.dgvParametros = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet()
        Me.ModulosTableAdapter = New Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCambiarFoto = New System.Windows.Forms.Button()
        Me.grpTaxon = New System.Windows.Forms.GroupBox()
        Me.btnGuardarPadre = New System.Windows.Forms.Button()
        Me.btnLimpiarPadre = New System.Windows.Forms.Button()
        Me.CategoriaPadreComboBox = New System.Windows.Forms.ComboBox()
        Me.btnCambiarPadre = New System.Windows.Forms.Button()
        Me.CategoriaPadreTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardarTaxon = New System.Windows.Forms.Button()
        Me.IdTaxonTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.NivelTaxonomicoTextBox = New System.Windows.Forms.TextBox()
        Me.AcronimoTextBox = New System.Windows.Forms.TextBox()
        Me.btnEditarTaxon = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.grpSimples = New System.Windows.Forms.GroupBox()
        Me.btnGuardarParametro = New System.Windows.Forms.Button()
        Me.btnEditarParametro = New System.Windows.Forms.Button()
        Me.rdCombo = New System.Windows.Forms.RadioButton()
        Me.rdTexto = New System.Windows.Forms.RadioButton()
        Me.chkAmbientes = New System.Windows.Forms.CheckedListBox()
        Me.rdComboTextbox = New System.Windows.Forms.TextBox()
        IdTaxonLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        NivelTaxonomicoLabel = New System.Windows.Forms.Label()
        AcronimoLabel = New System.Windows.Forms.Label()
        NivelPadreLabel = New System.Windows.Forms.Label()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTaxon.SuspendLayout()
        Me.grpSimples.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdTaxonLabel
        '
        IdTaxonLabel.AutoSize = True
        IdTaxonLabel.Location = New System.Drawing.Point(12, 36)
        IdTaxonLabel.Name = "IdTaxonLabel"
        IdTaxonLabel.Size = New System.Drawing.Size(52, 13)
        IdTaxonLabel.TabIndex = 47
        IdTaxonLabel.Text = "Id Taxon:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(12, 62)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 49
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(12, 114)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 51
        AutorLabel.Text = "Autor:"
        '
        'NivelTaxonomicoLabel
        '
        NivelTaxonomicoLabel.AutoSize = True
        NivelTaxonomicoLabel.Location = New System.Drawing.Point(12, 239)
        NivelTaxonomicoLabel.Name = "NivelTaxonomicoLabel"
        NivelTaxonomicoLabel.Size = New System.Drawing.Size(95, 13)
        NivelTaxonomicoLabel.TabIndex = 53
        NivelTaxonomicoLabel.Text = "Nivel Taxonomico:"
        '
        'AcronimoLabel
        '
        AcronimoLabel.AutoSize = True
        AcronimoLabel.Location = New System.Drawing.Point(12, 88)
        AcronimoLabel.Name = "AcronimoLabel"
        AcronimoLabel.Size = New System.Drawing.Size(54, 13)
        AcronimoLabel.TabIndex = 55
        AcronimoLabel.Text = "Acronimo:"
        '
        'NivelPadreLabel
        '
        NivelPadreLabel.AutoSize = True
        NivelPadreLabel.Location = New System.Drawing.Point(12, 263)
        NivelPadreLabel.Name = "NivelPadreLabel"
        NivelPadreLabel.Size = New System.Drawing.Size(87, 13)
        NivelPadreLabel.TabIndex = 58
        NivelPadreLabel.Text = "Categoría padre:"
        '
        'cmFuente
        '
        Me.cmFuente.DataSource = Me.ModulosBindingSource
        Me.cmFuente.DisplayMember = "nombre"
        Me.cmFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmFuente.FormattingEnabled = True
        Me.cmFuente.Location = New System.Drawing.Point(67, 12)
        Me.cmFuente.Name = "cmFuente"
        Me.cmFuente.Size = New System.Drawing.Size(261, 28)
        Me.cmFuente.TabIndex = 0
        Me.cmFuente.ValueMember = "codigo"
        '
        'ModulosBindingSource
        '
        Me.ModulosBindingSource.DataMember = "Modulos"
        Me.ModulosBindingSource.DataSource = Me.ConfigDataSet
        '
        'ConfigDataSet
        '
        Me.ConfigDataSet.DataSetName = "ConfigDataSet"
        Me.ConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Editar:"
        '
        'btnAbrir
        '
        Me.btnAbrir.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrir.ForeColor = System.Drawing.Color.White
        Me.btnAbrir.Location = New System.Drawing.Point(334, 11)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(75, 28)
        Me.btnAbrir.TabIndex = 2
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.UseVisualStyleBackColor = False
        '
        'dgvParametros
        '
        Me.dgvParametros.AllowUserToAddRows = False
        Me.dgvParametros.AllowUserToDeleteRows = False
        Me.dgvParametros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvParametros.BackgroundColor = System.Drawing.Color.White
        Me.dgvParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParametros.Location = New System.Drawing.Point(0, 119)
        Me.dgvParametros.Name = "dgvParametros"
        Me.dgvParametros.ReadOnly = True
        Me.dgvParametros.Size = New System.Drawing.Size(521, 465)
        Me.dgvParametros.TabIndex = 3
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'ModulosTableAdapter
        '
        Me.ModulosTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(237, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 162)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'btnCambiarFoto
        '
        Me.btnCambiarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarFoto.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnCambiarFoto.Location = New System.Drawing.Point(284, 187)
        Me.btnCambiarFoto.Name = "btnCambiarFoto"
        Me.btnCambiarFoto.Size = New System.Drawing.Size(84, 23)
        Me.btnCambiarFoto.TabIndex = 43
        Me.btnCambiarFoto.Text = "Cambiar foto"
        Me.btnCambiarFoto.UseVisualStyleBackColor = True
        '
        'grpTaxon
        '
        Me.grpTaxon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTaxon.Controls.Add(Me.btnGuardarPadre)
        Me.grpTaxon.Controls.Add(Me.btnLimpiarPadre)
        Me.grpTaxon.Controls.Add(Me.CategoriaPadreComboBox)
        Me.grpTaxon.Controls.Add(Me.btnCambiarPadre)
        Me.grpTaxon.Controls.Add(Me.CategoriaPadreTextBox)
        Me.grpTaxon.Controls.Add(NivelPadreLabel)
        Me.grpTaxon.Controls.Add(Me.btnGuardarTaxon)
        Me.grpTaxon.Controls.Add(IdTaxonLabel)
        Me.grpTaxon.Controls.Add(Me.IdTaxonTextBox)
        Me.grpTaxon.Controls.Add(NombreLabel)
        Me.grpTaxon.Controls.Add(Me.NombreTextBox)
        Me.grpTaxon.Controls.Add(AutorLabel)
        Me.grpTaxon.Controls.Add(Me.AutorTextBox)
        Me.grpTaxon.Controls.Add(NivelTaxonomicoLabel)
        Me.grpTaxon.Controls.Add(Me.NivelTaxonomicoTextBox)
        Me.grpTaxon.Controls.Add(AcronimoLabel)
        Me.grpTaxon.Controls.Add(Me.AcronimoTextBox)
        Me.grpTaxon.Controls.Add(Me.btnEditarTaxon)
        Me.grpTaxon.Controls.Add(Me.PictureBox1)
        Me.grpTaxon.Controls.Add(Me.btnCambiarFoto)
        Me.grpTaxon.Location = New System.Drawing.Point(527, 12)
        Me.grpTaxon.Name = "grpTaxon"
        Me.grpTaxon.Size = New System.Drawing.Size(387, 397)
        Me.grpTaxon.TabIndex = 45
        Me.grpTaxon.TabStop = False
        Me.grpTaxon.Text = "Taxon"
        Me.grpTaxon.Visible = False
        '
        'btnGuardarPadre
        '
        Me.btnGuardarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPadre.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnGuardarPadre.Location = New System.Drawing.Point(313, 259)
        Me.btnGuardarPadre.Name = "btnGuardarPadre"
        Me.btnGuardarPadre.Size = New System.Drawing.Size(62, 23)
        Me.btnGuardarPadre.TabIndex = 64
        Me.btnGuardarPadre.Text = "Guardar"
        Me.btnGuardarPadre.UseVisualStyleBackColor = True
        Me.btnGuardarPadre.Visible = False
        '
        'btnLimpiarPadre
        '
        Me.btnLimpiarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarPadre.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnLimpiarPadre.Location = New System.Drawing.Point(313, 290)
        Me.btnLimpiarPadre.Name = "btnLimpiarPadre"
        Me.btnLimpiarPadre.Size = New System.Drawing.Size(62, 23)
        Me.btnLimpiarPadre.TabIndex = 63
        Me.btnLimpiarPadre.Text = "Limpiar"
        Me.btnLimpiarPadre.UseVisualStyleBackColor = True
        Me.btnLimpiarPadre.Visible = False
        '
        'CategoriaPadreComboBox
        '
        Me.CategoriaPadreComboBox.DisplayMember = "Nombre"
        Me.CategoriaPadreComboBox.FormattingEnabled = True
        Me.CategoriaPadreComboBox.Location = New System.Drawing.Point(121, 291)
        Me.CategoriaPadreComboBox.Name = "CategoriaPadreComboBox"
        Me.CategoriaPadreComboBox.Size = New System.Drawing.Size(186, 21)
        Me.CategoriaPadreComboBox.TabIndex = 62
        Me.CategoriaPadreComboBox.Visible = False
        '
        'btnCambiarPadre
        '
        Me.btnCambiarPadre.Enabled = False
        Me.btnCambiarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarPadre.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.btnCambiarPadre.Location = New System.Drawing.Point(245, 259)
        Me.btnCambiarPadre.Name = "btnCambiarPadre"
        Me.btnCambiarPadre.Size = New System.Drawing.Size(62, 23)
        Me.btnCambiarPadre.TabIndex = 60
        Me.btnCambiarPadre.Text = "Cambiar"
        Me.btnCambiarPadre.UseVisualStyleBackColor = True
        '
        'CategoriaPadreTextBox
        '
        Me.CategoriaPadreTextBox.Enabled = False
        Me.CategoriaPadreTextBox.Location = New System.Drawing.Point(121, 260)
        Me.CategoriaPadreTextBox.Name = "CategoriaPadreTextBox"
        Me.CategoriaPadreTextBox.Size = New System.Drawing.Size(118, 20)
        Me.CategoriaPadreTextBox.TabIndex = 59
        '
        'btnGuardarTaxon
        '
        Me.btnGuardarTaxon.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnGuardarTaxon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarTaxon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarTaxon.ForeColor = System.Drawing.Color.White
        Me.btnGuardarTaxon.Location = New System.Drawing.Point(244, 319)
        Me.btnGuardarTaxon.Name = "btnGuardarTaxon"
        Me.btnGuardarTaxon.Size = New System.Drawing.Size(131, 63)
        Me.btnGuardarTaxon.TabIndex = 57
        Me.btnGuardarTaxon.Text = "Guardar Taxón"
        Me.btnGuardarTaxon.UseVisualStyleBackColor = False
        '
        'IdTaxonTextBox
        '
        Me.IdTaxonTextBox.Enabled = False
        Me.IdTaxonTextBox.Location = New System.Drawing.Point(70, 29)
        Me.IdTaxonTextBox.Name = "IdTaxonTextBox"
        Me.IdTaxonTextBox.Size = New System.Drawing.Size(47, 20)
        Me.IdTaxonTextBox.TabIndex = 48
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(70, 55)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(161, 20)
        Me.NombreTextBox.TabIndex = 50
        '
        'AutorTextBox
        '
        Me.AutorTextBox.Enabled = False
        Me.AutorTextBox.Location = New System.Drawing.Point(70, 107)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(161, 20)
        Me.AutorTextBox.TabIndex = 52
        '
        'NivelTaxonomicoTextBox
        '
        Me.NivelTaxonomicoTextBox.Enabled = False
        Me.NivelTaxonomicoTextBox.Location = New System.Drawing.Point(121, 234)
        Me.NivelTaxonomicoTextBox.Name = "NivelTaxonomicoTextBox"
        Me.NivelTaxonomicoTextBox.Size = New System.Drawing.Size(118, 20)
        Me.NivelTaxonomicoTextBox.TabIndex = 54
        '
        'AcronimoTextBox
        '
        Me.AcronimoTextBox.Enabled = False
        Me.AcronimoTextBox.Location = New System.Drawing.Point(184, 81)
        Me.AcronimoTextBox.Name = "AcronimoTextBox"
        Me.AcronimoTextBox.Size = New System.Drawing.Size(47, 20)
        Me.AcronimoTextBox.TabIndex = 56
        '
        'btnEditarTaxon
        '
        Me.btnEditarTaxon.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEditarTaxon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarTaxon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarTaxon.ForeColor = System.Drawing.Color.White
        Me.btnEditarTaxon.Location = New System.Drawing.Point(15, 318)
        Me.btnEditarTaxon.Name = "btnEditarTaxon"
        Me.btnEditarTaxon.Size = New System.Drawing.Size(139, 63)
        Me.btnEditarTaxon.TabIndex = 46
        Me.btnEditarTaxon.Text = "Editar Taxón"
        Me.btnEditarTaxon.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Buscar:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(57, 90)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(244, 20)
        Me.txtSearch.TabIndex = 175
        '
        'grpSimples
        '
        Me.grpSimples.Controls.Add(Me.btnGuardarParametro)
        Me.grpSimples.Controls.Add(Me.btnEditarParametro)
        Me.grpSimples.Controls.Add(Me.rdComboTextbox)
        Me.grpSimples.Controls.Add(Me.rdCombo)
        Me.grpSimples.Controls.Add(Me.rdTexto)
        Me.grpSimples.Controls.Add(Me.chkAmbientes)
        Me.grpSimples.Location = New System.Drawing.Point(528, 12)
        Me.grpSimples.Name = "grpSimples"
        Me.grpSimples.Size = New System.Drawing.Size(386, 561)
        Me.grpSimples.TabIndex = 178
        Me.grpSimples.TabStop = False
        Me.grpSimples.Text = "Parámetros"
        Me.grpSimples.Visible = False
        '
        'btnGuardarParametro
        '
        Me.btnGuardarParametro.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnGuardarParametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarParametro.ForeColor = System.Drawing.Color.White
        Me.btnGuardarParametro.Location = New System.Drawing.Point(220, 249)
        Me.btnGuardarParametro.Name = "btnGuardarParametro"
        Me.btnGuardarParametro.Size = New System.Drawing.Size(153, 63)
        Me.btnGuardarParametro.TabIndex = 59
        Me.btnGuardarParametro.Text = "Guardar Parámetro"
        Me.btnGuardarParametro.UseVisualStyleBackColor = False
        '
        'btnEditarParametro
        '
        Me.btnEditarParametro.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEditarParametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarParametro.ForeColor = System.Drawing.Color.White
        Me.btnEditarParametro.Location = New System.Drawing.Point(13, 248)
        Me.btnEditarParametro.Name = "btnEditarParametro"
        Me.btnEditarParametro.Size = New System.Drawing.Size(139, 63)
        Me.btnEditarParametro.TabIndex = 58
        Me.btnEditarParametro.Text = "Editar Parámetro"
        Me.btnEditarParametro.UseVisualStyleBackColor = False
        '
        'rdCombo
        '
        Me.rdCombo.AutoSize = True
        Me.rdCombo.Enabled = False
        Me.rdCombo.Location = New System.Drawing.Point(183, 52)
        Me.rdCombo.Name = "rdCombo"
        Me.rdCombo.Size = New System.Drawing.Size(58, 17)
        Me.rdCombo.TabIndex = 2
        Me.rdCombo.TabStop = True
        Me.rdCombo.Text = "Combo"
        Me.rdCombo.UseVisualStyleBackColor = True
        '
        'rdTexto
        '
        Me.rdTexto.AutoSize = True
        Me.rdTexto.Enabled = False
        Me.rdTexto.Location = New System.Drawing.Point(183, 29)
        Me.rdTexto.Name = "rdTexto"
        Me.rdTexto.Size = New System.Drawing.Size(52, 17)
        Me.rdTexto.TabIndex = 1
        Me.rdTexto.TabStop = True
        Me.rdTexto.Text = "Texto"
        Me.rdTexto.UseVisualStyleBackColor = True
        '
        'chkAmbientes
        '
        Me.chkAmbientes.Enabled = False
        Me.chkAmbientes.FormattingEnabled = True
        Me.chkAmbientes.Items.AddRange(New Object() {"Arroyos Pampeanos", "Arroyos Patagónicos", "Arroyos de montaña", "Estuarios", "Lenticos"})
        Me.chkAmbientes.Location = New System.Drawing.Point(14, 29)
        Me.chkAmbientes.Name = "chkAmbientes"
        Me.chkAmbientes.Size = New System.Drawing.Size(139, 109)
        Me.chkAmbientes.TabIndex = 0
        '
        'rdComboTextbox
        '
        Me.rdComboTextbox.Enabled = False
        Me.rdComboTextbox.Location = New System.Drawing.Point(247, 52)
        Me.rdComboTextbox.Multiline = True
        Me.rdComboTextbox.Name = "rdComboTextbox"
        Me.rdComboTextbox.Size = New System.Drawing.Size(100, 99)
        Me.rdComboTextbox.TabIndex = 3
        '
        'frmDBParametros1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 585)
        Me.Controls.Add(Me.grpSimples)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.grpTaxon)
        Me.Controls.Add(Me.dgvParametros)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmFuente)
        Me.Name = "frmDBParametros1"
        Me.Text = "Editor de Parámetros y Taxones"
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTaxon.ResumeLayout(False)
        Me.grpTaxon.PerformLayout()
        Me.grpSimples.ResumeLayout(False)
        Me.grpSimples.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmFuente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAbrir As System.Windows.Forms.Button
    Friend WithEvents dgvParametros As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ModulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModulosTableAdapter As Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCambiarFoto As System.Windows.Forms.Button
    Friend WithEvents grpTaxon As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditarTaxon As System.Windows.Forms.Button
    Friend WithEvents IdTaxonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NivelTaxonomicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AcronimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarTaxon As System.Windows.Forms.Button
    Friend WithEvents btnLimpiarPadre As System.Windows.Forms.Button
    Friend WithEvents CategoriaPadreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnCambiarPadre As System.Windows.Forms.Button
    Friend WithEvents CategoriaPadreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarPadre As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents grpSimples As System.Windows.Forms.GroupBox
    Friend WithEvents chkAmbientes As System.Windows.Forms.CheckedListBox
    Friend WithEvents rdComboTextbox As System.Windows.Forms.TextBox
    Friend WithEvents rdCombo As System.Windows.Forms.RadioButton
    Friend WithEvents rdTexto As System.Windows.Forms.RadioButton
    Friend WithEvents btnGuardarParametro As System.Windows.Forms.Button
    Friend WithEvents btnEditarParametro As System.Windows.Forms.Button
End Class
