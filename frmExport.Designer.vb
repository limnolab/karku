<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExport
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
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnSelDeselTodo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkItemsNombres = New System.Windows.Forms.CheckedListBox()
        Me.chkItemsCodigos = New System.Windows.Forms.CheckedListBox()
        Me.tabGrids = New System.Windows.Forms.TabControl()
        Me.btnExportarSHP = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnExportarCSV = New System.Windows.Forms.Button()
        Me.btnExporttoExcel = New System.Windows.Forms.Button()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Scilla10DataSet
        '
        Me.Scilla10DataSet.DataSetName = "Scilla10DataSet"
        Me.Scilla10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MuestrasBindingSource
        '
        Me.MuestrasBindingSource.DataMember = "Muestras"
        Me.MuestrasBindingSource.DataSource = Me.Scilla10DataSet
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSelDeselTodo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkItemsNombres)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExportarSHP)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGenerar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkItemsCodigos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExportarCSV)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExporttoExcel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tabGrids)
        Me.SplitContainer1.Size = New System.Drawing.Size(885, 562)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 10
        '
        'btnSelDeselTodo
        '
        Me.btnSelDeselTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSelDeselTodo.FlatAppearance.BorderSize = 2
        Me.btnSelDeselTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelDeselTodo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelDeselTodo.Location = New System.Drawing.Point(319, 265)
        Me.btnSelDeselTodo.Name = "btnSelDeselTodo"
        Me.btnSelDeselTodo.Size = New System.Drawing.Size(131, 26)
        Me.btnSelDeselTodo.TabIndex = 19
        Me.btnSelDeselTodo.Text = "Seleccionar todo"
        Me.btnSelDeselTodo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Datos a exportar:"
        '
        'chkItemsNombres
        '
        Me.chkItemsNombres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkItemsNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItemsNombres.FormattingEnabled = True
        Me.chkItemsNombres.Location = New System.Drawing.Point(12, 47)
        Me.chkItemsNombres.Name = "chkItemsNombres"
        Me.chkItemsNombres.Size = New System.Drawing.Size(301, 244)
        Me.chkItemsNombres.TabIndex = 17
        '
        'chkItemsCodigos
        '
        Me.chkItemsCodigos.FormattingEnabled = True
        Me.chkItemsCodigos.Location = New System.Drawing.Point(12, 47)
        Me.chkItemsCodigos.Name = "chkItemsCodigos"
        Me.chkItemsCodigos.Size = New System.Drawing.Size(219, 139)
        Me.chkItemsCodigos.TabIndex = 15
        '
        'tabGrids
        '
        Me.tabGrids.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabGrids.Location = New System.Drawing.Point(0, 0)
        Me.tabGrids.Name = "tabGrids"
        Me.tabGrids.SelectedIndex = 0
        Me.tabGrids.Size = New System.Drawing.Size(885, 258)
        Me.tabGrids.TabIndex = 2
        '
        'btnExportarSHP
        '
        Me.btnExportarSHP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarSHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnExportarSHP.FlatAppearance.BorderSize = 0
        Me.btnExportarSHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarSHP.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportarSHP.ForeColor = System.Drawing.Color.White
        Me.btnExportarSHP.Image = Global.Scila7.My.Resources.Resources.earth212
        Me.btnExportarSHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarSHP.Location = New System.Drawing.Point(714, 187)
        Me.btnExportarSHP.Name = "btnExportarSHP"
        Me.btnExportarSHP.Size = New System.Drawing.Size(159, 62)
        Me.btnExportarSHP.TabIndex = 13
        Me.btnExportarSHP.Text = "Exportar a GIS Shapefile"
        Me.btnExportarSHP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportarSHP.UseVisualStyleBackColor = False
        Me.btnExportarSHP.Visible = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGenerar.FlatAppearance.BorderSize = 0
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.ForeColor = System.Drawing.Color.White
        Me.btnGenerar.Image = Global.Scila7.My.Resources.Resources.volume56
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerar.Location = New System.Drawing.Point(319, 47)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(226, 63)
        Me.btnGenerar.TabIndex = 16
        Me.btnGenerar.Text = "Generar datos para exportar"
        Me.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnExportarCSV
        '
        Me.btnExportarCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarCSV.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnExportarCSV.FlatAppearance.BorderSize = 0
        Me.btnExportarCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarCSV.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportarCSV.ForeColor = System.Drawing.Color.White
        Me.btnExportarCSV.Image = Global.Scila7.My.Resources.Resources.csv
        Me.btnExportarCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarCSV.Location = New System.Drawing.Point(714, 116)
        Me.btnExportarCSV.Name = "btnExportarCSV"
        Me.btnExportarCSV.Size = New System.Drawing.Size(159, 63)
        Me.btnExportarCSV.TabIndex = 12
        Me.btnExportarCSV.Text = "Exportar a texto delimitado"
        Me.btnExportarCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportarCSV.UseVisualStyleBackColor = False
        Me.btnExportarCSV.Visible = False
        '
        'btnExporttoExcel
        '
        Me.btnExporttoExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExporttoExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnExporttoExcel.FlatAppearance.BorderSize = 0
        Me.btnExporttoExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExporttoExcel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExporttoExcel.ForeColor = System.Drawing.Color.White
        Me.btnExporttoExcel.Image = Global.Scila7.My.Resources.Resources.xls2
        Me.btnExporttoExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExporttoExcel.Location = New System.Drawing.Point(714, 47)
        Me.btnExporttoExcel.Name = "btnExporttoExcel"
        Me.btnExporttoExcel.Size = New System.Drawing.Size(159, 63)
        Me.btnExporttoExcel.TabIndex = 9
        Me.btnExporttoExcel.Text = "Exportar a Excel"
        Me.btnExporttoExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExporttoExcel.UseVisualStyleBackColor = False
        Me.btnExporttoExcel.Visible = False
        '
        'frmExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 562)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmExport"
        Me.Text = "Exportar datos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents btnExporttoExcel As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnExportarCSV As System.Windows.Forms.Button
    Friend WithEvents btnExportarSHP As System.Windows.Forms.Button
    Friend WithEvents chkItemsCodigos As System.Windows.Forms.CheckedListBox
    Friend WithEvents tabGrids As System.Windows.Forms.TabControl
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents chkItemsNombres As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelDeselTodo As System.Windows.Forms.Button
End Class
