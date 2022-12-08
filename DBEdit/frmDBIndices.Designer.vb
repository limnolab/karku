<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBIndices
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
        Dim AcronimoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.cmFuente = New System.Windows.Forms.ComboBox()
        Me.CalculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.dgvParametros = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet()
        Me.ModulosTableAdapter = New Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter()
        Me.grpTaxon = New System.Windows.Forms.GroupBox()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtVariableParametro = New System.Windows.Forms.TextBox()
        Me.IdTaxonTextBox = New System.Windows.Forms.TextBox()
        Me.txtCategoriaParametro = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.txtCodigoParametro = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.AcronimoTextBox = New System.Windows.Forms.TextBox()
        Me.CalculosTableAdapter = New Scila7.ConfigDataSetTableAdapters.CalculosTableAdapter()
        Me.BindingSourceTaxones = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceParametros = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGuardarParametro = New System.Windows.Forms.Button()
        Me.btnEditarParametro = New System.Windows.Forms.Button()
        IdTaxonLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        AcronimoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.CalculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTaxon.SuspendLayout()
        CType(Me.BindingSourceTaxones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdTaxonLabel
        '
        IdTaxonLabel.AutoSize = True
        IdTaxonLabel.Location = New System.Drawing.Point(276, 201)
        IdTaxonLabel.Name = "IdTaxonLabel"
        IdTaxonLabel.Size = New System.Drawing.Size(52, 13)
        IdTaxonLabel.TabIndex = 47
        IdTaxonLabel.Text = "Id Taxon:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(13, 41)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 49
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(163, 171)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 51
        AutorLabel.Text = "Autor:"
        '
        'AcronimoLabel
        '
        AcronimoLabel.AutoSize = True
        AcronimoLabel.Location = New System.Drawing.Point(274, 227)
        AcronimoLabel.Name = "AcronimoLabel"
        AcronimoLabel.Size = New System.Drawing.Size(54, 13)
        AcronimoLabel.TabIndex = 55
        AcronimoLabel.Text = "Acronimo:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(13, 68)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 13)
        Label3.TabIndex = 54
        Label3.Text = "Código:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(13, 96)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(55, 13)
        Label4.TabIndex = 56
        Label4.Text = "Categoria:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(13, 123)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(48, 13)
        Label5.TabIndex = 58
        Label5.Text = "Variable:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(13, 149)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(34, 13)
        Label2.TabIndex = 60
        Label2.Text = "Valor:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(13, 260)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(38, 13)
        Label6.TabIndex = 62
        Label6.Text = "Notas:"
        '
        'cmFuente
        '
        Me.cmFuente.DataSource = Me.CalculosBindingSource
        Me.cmFuente.DisplayMember = "nombre"
        Me.cmFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmFuente.FormattingEnabled = True
        Me.cmFuente.Location = New System.Drawing.Point(67, 12)
        Me.cmFuente.Name = "cmFuente"
        Me.cmFuente.Size = New System.Drawing.Size(261, 28)
        Me.cmFuente.TabIndex = 0
        Me.cmFuente.ValueMember = "codigo"
        '
        'CalculosBindingSource
        '
        Me.CalculosBindingSource.DataMember = "Calculos"
        Me.CalculosBindingSource.DataSource = Me.ConfigDataSet
        '
        'ConfigDataSet
        '
        Me.ConfigDataSet.DataSetName = "ConfigDataSet"
        Me.ConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModulosBindingSource
        '
        Me.ModulosBindingSource.DataMember = "Modulos"
        Me.ModulosBindingSource.DataSource = Me.ConfigDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Índice:"
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
        Me.dgvParametros.Location = New System.Drawing.Point(10, 74)
        Me.dgvParametros.Name = "dgvParametros"
        Me.dgvParametros.ReadOnly = True
        Me.dgvParametros.Size = New System.Drawing.Size(511, 510)
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
        'grpTaxon
        '
        Me.grpTaxon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTaxon.Controls.Add(Label6)
        Me.grpTaxon.Controls.Add(Me.txtNotas)
        Me.grpTaxon.Controls.Add(Label2)
        Me.grpTaxon.Controls.Add(Me.txtValor)
        Me.grpTaxon.Controls.Add(Label5)
        Me.grpTaxon.Controls.Add(IdTaxonLabel)
        Me.grpTaxon.Controls.Add(Me.txtVariableParametro)
        Me.grpTaxon.Controls.Add(Me.IdTaxonTextBox)
        Me.grpTaxon.Controls.Add(Label4)
        Me.grpTaxon.Controls.Add(NombreLabel)
        Me.grpTaxon.Controls.Add(Me.txtCategoriaParametro)
        Me.grpTaxon.Controls.Add(Me.NombreTextBox)
        Me.grpTaxon.Controls.Add(Label3)
        Me.grpTaxon.Controls.Add(AutorLabel)
        Me.grpTaxon.Controls.Add(Me.txtCodigoParametro)
        Me.grpTaxon.Controls.Add(Me.AutorTextBox)
        Me.grpTaxon.Controls.Add(AcronimoLabel)
        Me.grpTaxon.Controls.Add(Me.AcronimoTextBox)
        Me.grpTaxon.Enabled = False
        Me.grpTaxon.Location = New System.Drawing.Point(527, 12)
        Me.grpTaxon.Name = "grpTaxon"
        Me.grpTaxon.Size = New System.Drawing.Size(387, 423)
        Me.grpTaxon.TabIndex = 45
        Me.grpTaxon.TabStop = False
        Me.grpTaxon.Text = "Parámetros"
        '
        'txtNotas
        '
        Me.txtNotas.Enabled = False
        Me.txtNotas.Location = New System.Drawing.Point(132, 257)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(181, 131)
        Me.txtNotas.TabIndex = 61
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(133, 142)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 59
        '
        'txtVariableParametro
        '
        Me.txtVariableParametro.Enabled = False
        Me.txtVariableParametro.Location = New System.Drawing.Point(133, 116)
        Me.txtVariableParametro.Name = "txtVariableParametro"
        Me.txtVariableParametro.Size = New System.Drawing.Size(100, 20)
        Me.txtVariableParametro.TabIndex = 57
        '
        'IdTaxonTextBox
        '
        Me.IdTaxonTextBox.Enabled = False
        Me.IdTaxonTextBox.Location = New System.Drawing.Point(334, 194)
        Me.IdTaxonTextBox.Name = "IdTaxonTextBox"
        Me.IdTaxonTextBox.Size = New System.Drawing.Size(47, 20)
        Me.IdTaxonTextBox.TabIndex = 48
        '
        'txtCategoriaParametro
        '
        Me.txtCategoriaParametro.Enabled = False
        Me.txtCategoriaParametro.Location = New System.Drawing.Point(132, 90)
        Me.txtCategoriaParametro.Name = "txtCategoriaParametro"
        Me.txtCategoriaParametro.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoriaParametro.TabIndex = 55
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(69, 38)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(312, 20)
        Me.NombreTextBox.TabIndex = 50
        '
        'txtCodigoParametro
        '
        Me.txtCodigoParametro.Enabled = False
        Me.txtCodigoParametro.Location = New System.Drawing.Point(132, 64)
        Me.txtCodigoParametro.Name = "txtCodigoParametro"
        Me.txtCodigoParametro.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoParametro.TabIndex = 53
        '
        'AutorTextBox
        '
        Me.AutorTextBox.Enabled = False
        Me.AutorTextBox.Location = New System.Drawing.Point(204, 168)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(177, 20)
        Me.AutorTextBox.TabIndex = 52
        '
        'AcronimoTextBox
        '
        Me.AcronimoTextBox.Enabled = False
        Me.AcronimoTextBox.Location = New System.Drawing.Point(334, 220)
        Me.AcronimoTextBox.Name = "AcronimoTextBox"
        Me.AcronimoTextBox.Size = New System.Drawing.Size(47, 20)
        Me.AcronimoTextBox.TabIndex = 56
        '
        'CalculosTableAdapter
        '
        Me.CalculosTableAdapter.ClearBeforeFill = True
        '
        'btnGuardarParametro
        '
        Me.btnGuardarParametro.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnGuardarParametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarParametro.ForeColor = System.Drawing.Color.White
        Me.btnGuardarParametro.Location = New System.Drawing.Point(755, 450)
        Me.btnGuardarParametro.Name = "btnGuardarParametro"
        Me.btnGuardarParametro.Size = New System.Drawing.Size(153, 63)
        Me.btnGuardarParametro.TabIndex = 66
        Me.btnGuardarParametro.Text = "Guardar Parámetro"
        Me.btnGuardarParametro.UseVisualStyleBackColor = False
        '
        'btnEditarParametro
        '
        Me.btnEditarParametro.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEditarParametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarParametro.ForeColor = System.Drawing.Color.White
        Me.btnEditarParametro.Location = New System.Drawing.Point(542, 450)
        Me.btnEditarParametro.Name = "btnEditarParametro"
        Me.btnEditarParametro.Size = New System.Drawing.Size(139, 63)
        Me.btnEditarParametro.TabIndex = 65
        Me.btnEditarParametro.Text = "Editar Parámetro"
        Me.btnEditarParametro.UseVisualStyleBackColor = False
        '
        'frmDBIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 585)
        Me.Controls.Add(Me.btnGuardarParametro)
        Me.Controls.Add(Me.btnEditarParametro)
        Me.Controls.Add(Me.grpTaxon)
        Me.Controls.Add(Me.dgvParametros)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmFuente)
        Me.Name = "frmDBIndices"
        Me.Text = "Editor de Índices y Cálculos"
        CType(Me.CalculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTaxon.ResumeLayout(False)
        Me.grpTaxon.PerformLayout()
        CType(Me.BindingSourceTaxones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceParametros, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grpTaxon As System.Windows.Forms.GroupBox
    Friend WithEvents IdTaxonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AcronimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalculosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalculosTableAdapter As Scila7.ConfigDataSetTableAdapters.CalculosTableAdapter
    Friend WithEvents BindingSourceTaxones As System.Windows.Forms.BindingSource
    Friend WithEvents txtVariableParametro As System.Windows.Forms.TextBox
    Friend WithEvents txtCategoriaParametro As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoParametro As System.Windows.Forms.TextBox
    Friend WithEvents BindingSourceParametros As System.Windows.Forms.BindingSource
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtNotas As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarParametro As System.Windows.Forms.Button
    Friend WithEvents btnEditarParametro As System.Windows.Forms.Button
End Class
