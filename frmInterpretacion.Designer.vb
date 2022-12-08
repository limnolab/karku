<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterpretacion
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1Command1 = New C1.Win.C1Command.C1Command()
        Me.dgvMuestrasDensidades = New System.Windows.Forms.DataGridView()
        Me.colComunidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSignific = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDensidades = New System.Windows.Forms.Label()
        Me.dgvMuestrasIndicesEcologicos = New System.Windows.Forms.DataGridView()
        Me.dgvMuestrasIndicesBioticos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreMuestra = New System.Windows.Forms.Label()
        Me.menuMuestras = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMuestraAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMuestraATextoDelimitadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.colTipoDatos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIndice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSignificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoDatos2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMuestrasDensidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMuestrasIndicesEcologicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMuestrasIndicesBioticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuMuestras.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1Command1)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1Command1
        '
        Me.C1Command1.Name = "C1Command1"
        Me.C1Command1.ShortcutText = ""
        Me.C1Command1.Text = "Resumen del proyecto"
        '
        'dgvMuestrasDensidades
        '
        Me.dgvMuestrasDensidades.AllowUserToAddRows = False
        Me.dgvMuestrasDensidades.AllowUserToDeleteRows = False
        Me.dgvMuestrasDensidades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMuestrasDensidades.BackgroundColor = System.Drawing.Color.White
        Me.dgvMuestrasDensidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMuestrasDensidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMuestrasDensidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMuestrasDensidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colComunidad, Me.DataGridViewTextBoxColumn5, Me.colSignific, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMuestrasDensidades.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMuestrasDensidades.GridColor = System.Drawing.Color.White
        Me.dgvMuestrasDensidades.Location = New System.Drawing.Point(8, 323)
        Me.dgvMuestrasDensidades.Name = "dgvMuestrasDensidades"
        Me.dgvMuestrasDensidades.ReadOnly = True
        Me.dgvMuestrasDensidades.RowHeadersVisible = False
        Me.dgvMuestrasDensidades.Size = New System.Drawing.Size(893, 289)
        Me.dgvMuestrasDensidades.TabIndex = 9
        '
        'colComunidad
        '
        Me.colComunidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colComunidad.HeaderText = "Comunidad"
        Me.colComunidad.Name = "colComunidad"
        Me.colComunidad.ReadOnly = True
        Me.colComunidad.Width = 95
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn5.HeaderText = "Indice"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 5
        '
        'colSignific
        '
        Me.colSignific.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.colSignific.HeaderText = "Categoría"
        Me.colSignific.Name = "colSignific"
        Me.colSignific.ReadOnly = True
        Me.colSignific.Width = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Densidad total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 113
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "%"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 41
        '
        'lblDensidades
        '
        Me.lblDensidades.AutoSize = True
        Me.lblDensidades.BackColor = System.Drawing.Color.White
        Me.lblDensidades.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDensidades.ForeColor = System.Drawing.Color.Black
        Me.lblDensidades.Location = New System.Drawing.Point(12, 294)
        Me.lblDensidades.Name = "lblDensidades"
        Me.lblDensidades.Size = New System.Drawing.Size(109, 26)
        Me.lblDensidades.TabIndex = 8
        Me.lblDensidades.Text = "Densidades"
        '
        'dgvMuestrasIndicesEcologicos
        '
        Me.dgvMuestrasIndicesEcologicos.AllowUserToAddRows = False
        Me.dgvMuestrasIndicesEcologicos.AllowUserToDeleteRows = False
        Me.dgvMuestrasIndicesEcologicos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMuestrasIndicesEcologicos.BackgroundColor = System.Drawing.Color.White
        Me.dgvMuestrasIndicesEcologicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMuestrasIndicesEcologicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMuestrasIndicesEcologicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMuestrasIndicesEcologicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMuestrasIndicesEcologicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTipoDatos2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMuestrasIndicesEcologicos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMuestrasIndicesEcologicos.GridColor = System.Drawing.Color.White
        Me.dgvMuestrasIndicesEcologicos.Location = New System.Drawing.Point(473, 79)
        Me.dgvMuestrasIndicesEcologicos.Name = "dgvMuestrasIndicesEcologicos"
        Me.dgvMuestrasIndicesEcologicos.ReadOnly = True
        Me.dgvMuestrasIndicesEcologicos.RowHeadersVisible = False
        Me.dgvMuestrasIndicesEcologicos.Size = New System.Drawing.Size(428, 212)
        Me.dgvMuestrasIndicesEcologicos.TabIndex = 7
        '
        'dgvMuestrasIndicesBioticos
        '
        Me.dgvMuestrasIndicesBioticos.AllowUserToAddRows = False
        Me.dgvMuestrasIndicesBioticos.AllowUserToDeleteRows = False
        Me.dgvMuestrasIndicesBioticos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMuestrasIndicesBioticos.BackgroundColor = System.Drawing.Color.White
        Me.dgvMuestrasIndicesBioticos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMuestrasIndicesBioticos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMuestrasIndicesBioticos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMuestrasIndicesBioticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMuestrasIndicesBioticos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTipoDatos, Me.colIndice, Me.colValor, Me.colSignificado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMuestrasIndicesBioticos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMuestrasIndicesBioticos.GridColor = System.Drawing.Color.White
        Me.dgvMuestrasIndicesBioticos.Location = New System.Drawing.Point(8, 79)
        Me.dgvMuestrasIndicesBioticos.Name = "dgvMuestrasIndicesBioticos"
        Me.dgvMuestrasIndicesBioticos.ReadOnly = True
        Me.dgvMuestrasIndicesBioticos.RowHeadersVisible = False
        Me.dgvMuestrasIndicesBioticos.Size = New System.Drawing.Size(436, 212)
        Me.dgvMuestrasIndicesBioticos.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(607, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Indices Ecológicos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(161, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Indices Bióticos"
        '
        'lblNombreMuestra
        '
        Me.lblNombreMuestra.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblNombreMuestra.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNombreMuestra.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMuestra.ForeColor = System.Drawing.Color.White
        Me.lblNombreMuestra.Location = New System.Drawing.Point(0, 24)
        Me.lblNombreMuestra.Name = "lblNombreMuestra"
        Me.lblNombreMuestra.Size = New System.Drawing.Size(915, 26)
        Me.lblNombreMuestra.TabIndex = 1
        Me.lblNombreMuestra.Text = "Label1"
        Me.lblNombreMuestra.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'menuMuestras
        '
        Me.menuMuestras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.menuMuestras.Location = New System.Drawing.Point(0, 0)
        Me.menuMuestras.Name = "menuMuestras"
        Me.menuMuestras.Size = New System.Drawing.Size(915, 24)
        Me.menuMuestras.TabIndex = 189
        Me.menuMuestras.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnMuestraAExcelToolStripMenuItem, Me.mnMuestraATextoDelimitadoToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 20)
        Me.ToolStripMenuItem1.Text = "Exportar resultados"
        '
        'mnMuestraAExcelToolStripMenuItem
        '
        Me.mnMuestraAExcelToolStripMenuItem.Name = "mnMuestraAExcelToolStripMenuItem"
        Me.mnMuestraAExcelToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.mnMuestraAExcelToolStripMenuItem.Text = "A Excel"
        '
        'mnMuestraATextoDelimitadoToolStripMenuItem
        '
        Me.mnMuestraATextoDelimitadoToolStripMenuItem.Name = "mnMuestraATextoDelimitadoToolStripMenuItem"
        Me.mnMuestraATextoDelimitadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.mnMuestraATextoDelimitadoToolStripMenuItem.Text = "A texto delimitado..."
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(388, 618)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(138, 59)
        Me.btnCerrar.TabIndex = 190
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'colTipoDatos
        '
        Me.colTipoDatos.HeaderText = "Datos"
        Me.colTipoDatos.Name = "colTipoDatos"
        Me.colTipoDatos.ReadOnly = True
        '
        'colIndice
        '
        Me.colIndice.HeaderText = "Indice"
        Me.colIndice.Name = "colIndice"
        Me.colIndice.ReadOnly = True
        '
        'colValor
        '
        Me.colValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colValor.HeaderText = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.ReadOnly = True
        Me.colValor.Width = 61
        '
        'colSignificado
        '
        Me.colSignificado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSignificado.HeaderText = "Significado"
        Me.colSignificado.Name = "colSignificado"
        Me.colSignificado.ReadOnly = True
        '
        'colTipoDatos2
        '
        Me.colTipoDatos2.HeaderText = "Datos"
        Me.colTipoDatos2.Name = "colTipoDatos2"
        Me.colTipoDatos2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Indice"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 61
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Significado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'frmInterpretacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 683)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblDensidades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombreMuestra)
        Me.Controls.Add(Me.menuMuestras)
        Me.Controls.Add(Me.dgvMuestrasIndicesBioticos)
        Me.Controls.Add(Me.dgvMuestrasIndicesEcologicos)
        Me.Controls.Add(Me.dgvMuestrasDensidades)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmInterpretacion"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMuestrasDensidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMuestrasIndicesEcologicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMuestrasIndicesBioticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuMuestras.ResumeLayout(False)
        Me.menuMuestras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1Command1 As C1.Win.C1Command.C1Command
    Friend WithEvents lblNombreMuestra As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvMuestrasIndicesBioticos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMuestrasIndicesEcologicos As System.Windows.Forms.DataGridView
    Friend WithEvents lblDensidades As System.Windows.Forms.Label
    Friend WithEvents dgvMuestrasDensidades As System.Windows.Forms.DataGridView
    Friend WithEvents colComunidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSignific As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents menuMuestras As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMuestraATextoDelimitadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMuestraAExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents colTipoDatos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIndice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSignificado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoDatos2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
