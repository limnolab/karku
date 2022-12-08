<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEspecie
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
        Dim AutorLabel As System.Windows.Forms.Label
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.ModulosTableAdapter = New Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter()
        Me.dgvParametros = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colIndice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValorIndice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTraduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearchAcronimo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fototaxon = New C1.Win.C1Input.C1PictureBox()
        Me.txtAutor = New C1.Win.C1Input.C1TextBox()
        Me.txtNombre = New C1.Win.C1Input.C1TextBox()
        Me.grpBuscar = New System.Windows.Forms.GroupBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnSearchGoogle = New System.Windows.Forms.Button()
        AutorLabel = New System.Windows.Forms.Label()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fototaxon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBuscar.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'AutorLabel
        '
        AutorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(212, 50)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 185
        AutorLabel.Text = "Autor:"
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
        'ModulosTableAdapter
        '
        Me.ModulosTableAdapter.ClearBeforeFill = True
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
        Me.dgvParametros.Location = New System.Drawing.Point(8, 76)
        Me.dgvParametros.Name = "dgvParametros"
        Me.dgvParametros.ReadOnly = True
        Me.dgvParametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParametros.Size = New System.Drawing.Size(277, 472)
        Me.dgvParametros.TabIndex = 5
        Me.dgvParametros.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Enabled = False
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(81, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(203, 20)
        Me.txtSearch.TabIndex = 1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIndice, Me.colNombre, Me.colValorIndice, Me.colTraduccion})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(457, 209)
        Me.DataGridView1.TabIndex = 177
        Me.DataGridView1.TabStop = False
        '
        'colIndice
        '
        Me.colIndice.HeaderText = "Indice"
        Me.colIndice.Name = "colIndice"
        Me.colIndice.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'colValorIndice
        '
        Me.colValorIndice.HeaderText = "Valor"
        Me.colValorIndice.Name = "colValorIndice"
        Me.colValorIndice.ReadOnly = True
        '
        'colTraduccion
        '
        Me.colTraduccion.HeaderText = "Significado"
        Me.colTraduccion.Name = "colTraduccion"
        Me.colTraduccion.ReadOnly = True
        '
        'txtSearchAcronimo
        '
        Me.txtSearchAcronimo.Enabled = False
        Me.txtSearchAcronimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAcronimo.Location = New System.Drawing.Point(226, 50)
        Me.txtSearchAcronimo.Name = "txtSearchAcronimo"
        Me.txtSearchAcronimo.Size = New System.Drawing.Size(59, 20)
        Me.txtSearchAcronimo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Por nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "Por acrónimo:"
        '
        'fototaxon
        '
        Me.fototaxon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fototaxon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fototaxon.ErrorImage = Global.Scila7.My.Resources.Resources.logoKerku
        Me.fototaxon.Location = New System.Drawing.Point(140, 286)
        Me.fototaxon.Name = "fototaxon"
        Me.fototaxon.Size = New System.Drawing.Size(324, 275)
        Me.fototaxon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fototaxon.TabIndex = 9
        Me.fototaxon.TabStop = False
        '
        'txtAutor
        '
        Me.txtAutor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAutor.Enabled = False
        Me.txtAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutor.Location = New System.Drawing.Point(253, 48)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(210, 15)
        Me.txtAutor.TabIndex = 189
        Me.txtAutor.TabStop = False
        Me.txtAutor.Tag = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(6, 13)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(457, 28)
        Me.txtNombre.TabIndex = 188
        Me.txtNombre.TabStop = False
        Me.txtNombre.Tag = Nothing
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNombre.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'grpBuscar
        '
        Me.grpBuscar.Controls.Add(Me.dgvParametros)
        Me.grpBuscar.Controls.Add(Me.txtSearch)
        Me.grpBuscar.Controls.Add(Me.txtSearchAcronimo)
        Me.grpBuscar.Controls.Add(Me.Label3)
        Me.grpBuscar.Controls.Add(Me.Label2)
        Me.grpBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBuscar.Location = New System.Drawing.Point(12, 15)
        Me.grpBuscar.Name = "grpBuscar"
        Me.grpBuscar.Size = New System.Drawing.Size(298, 554)
        Me.grpBuscar.TabIndex = 190
        Me.grpBuscar.TabStop = False
        Me.grpBuscar.Text = "Buscar"
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.btnSiguiente)
        Me.grpInfo.Controls.Add(Me.btnSearchGoogle)
        Me.grpInfo.Controls.Add(Me.txtNombre)
        Me.grpInfo.Controls.Add(Me.txtAutor)
        Me.grpInfo.Controls.Add(Me.DataGridView1)
        Me.grpInfo.Controls.Add(Me.fototaxon)
        Me.grpInfo.Controls.Add(AutorLabel)
        Me.grpInfo.Location = New System.Drawing.Point(315, 2)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(477, 567)
        Me.grpInfo.TabIndex = 191
        Me.grpInfo.TabStop = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSiguiente.FlatAppearance.BorderSize = 0
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente.Location = New System.Drawing.Point(105, 472)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(29, 24)
        Me.btnSiguiente.TabIndex = 193
        Me.btnSiguiente.Text = ">>"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        Me.btnSiguiente.Visible = False
        '
        'btnSearchGoogle
        '
        Me.btnSearchGoogle.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSearchGoogle.FlatAppearance.BorderSize = 0
        Me.btnSearchGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchGoogle.ForeColor = System.Drawing.Color.White
        Me.btnSearchGoogle.Location = New System.Drawing.Point(6, 502)
        Me.btnSearchGoogle.Name = "btnSearchGoogle"
        Me.btnSearchGoogle.Size = New System.Drawing.Size(128, 59)
        Me.btnSearchGoogle.TabIndex = 191
        Me.btnSearchGoogle.Text = "Buscar mas imágenes (Google Images)"
        Me.btnSearchGoogle.UseVisualStyleBackColor = False
        '
        'frmBuscarEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 570)
        Me.Controls.Add(Me.grpBuscar)
        Me.Controls.Add(Me.grpInfo)
        Me.Name = "frmBuscarEspecie"
        Me.Text = "Buscar Taxón"
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fototaxon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBuscar.ResumeLayout(False)
        Me.grpBuscar.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ModulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ModulosTableAdapter As Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter
    Friend WithEvents dgvParametros As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchAcronimo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fototaxon As C1.Win.C1Input.C1PictureBox
    Friend WithEvents txtAutor As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNombre As C1.Win.C1Input.C1TextBox
    Friend WithEvents grpBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchGoogle As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents colIndice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValorIndice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTraduccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
