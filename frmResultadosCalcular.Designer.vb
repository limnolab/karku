<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultadosCalcular
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
        Me.btnGraficarResultados = New System.Windows.Forms.Button()
        Me.dgvResultadosCalcular = New System.Windows.Forms.DataGridView()
        Me.btnInterpretacion = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATextoDelimitadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvResultadosCalcular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGraficarResultados
        '
        Me.btnGraficarResultados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGraficarResultados.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnGraficarResultados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnGraficarResultados.FlatAppearance.BorderSize = 0
        Me.btnGraficarResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficarResultados.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficarResultados.ForeColor = System.Drawing.Color.White
        Me.btnGraficarResultados.Image = Global.Scila7.My.Resources.Resources.chart59
        Me.btnGraficarResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGraficarResultados.Location = New System.Drawing.Point(716, 36)
        Me.btnGraficarResultados.Name = "btnGraficarResultados"
        Me.btnGraficarResultados.Size = New System.Drawing.Size(193, 44)
        Me.btnGraficarResultados.TabIndex = 182
        Me.btnGraficarResultados.Text = "  Graficar resultados"
        Me.btnGraficarResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGraficarResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGraficarResultados.UseVisualStyleBackColor = False
        '
        'dgvResultadosCalcular
        '
        Me.dgvResultadosCalcular.AllowUserToAddRows = False
        Me.dgvResultadosCalcular.AllowUserToDeleteRows = False
        Me.dgvResultadosCalcular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultadosCalcular.BackgroundColor = System.Drawing.Color.White
        Me.dgvResultadosCalcular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultadosCalcular.Location = New System.Drawing.Point(12, 86)
        Me.dgvResultadosCalcular.Name = "dgvResultadosCalcular"
        Me.dgvResultadosCalcular.ReadOnly = True
        Me.dgvResultadosCalcular.RowHeadersVisible = False
        Me.dgvResultadosCalcular.Size = New System.Drawing.Size(897, 438)
        Me.dgvResultadosCalcular.TabIndex = 0
        '
        'btnInterpretacion
        '
        Me.btnInterpretacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnInterpretacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnInterpretacion.FlatAppearance.BorderSize = 0
        Me.btnInterpretacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInterpretacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInterpretacion.ForeColor = System.Drawing.Color.White
        Me.btnInterpretacion.Image = Global.Scila7.My.Resources.Resources.Interpretacion
        Me.btnInterpretacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInterpretacion.Location = New System.Drawing.Point(12, 36)
        Me.btnInterpretacion.Name = "btnInterpretacion"
        Me.btnInterpretacion.Size = New System.Drawing.Size(193, 44)
        Me.btnInterpretacion.TabIndex = 184
        Me.btnInterpretacion.Text = "  Interpretación"
        Me.btnInterpretacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInterpretacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInterpretacion.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(921, 24)
        Me.MenuStrip1.TabIndex = 187
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AExcelToolStripMenuItem, Me.ATextoDelimitadoToolStripMenuItem})
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ExportarToolStripMenuItem.Text = "Exportar resultados"
        '
        'AExcelToolStripMenuItem
        '
        Me.AExcelToolStripMenuItem.Name = "AExcelToolStripMenuItem"
        Me.AExcelToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AExcelToolStripMenuItem.Text = "A Excel..."
        '
        'ATextoDelimitadoToolStripMenuItem
        '
        Me.ATextoDelimitadoToolStripMenuItem.Name = "ATextoDelimitadoToolStripMenuItem"
        Me.ATextoDelimitadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ATextoDelimitadoToolStripMenuItem.Text = "A texto delimitado..."
        '
        'frmResultadosCalcular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(921, 536)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnInterpretacion)
        Me.Controls.Add(Me.btnGraficarResultados)
        Me.Controls.Add(Me.dgvResultadosCalcular)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmResultadosCalcular"
        Me.Text = "RESULTADOS - Cálculos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvResultadosCalcular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGraficarResultados As System.Windows.Forms.Button
    Friend WithEvents dgvResultadosCalcular As System.Windows.Forms.DataGridView
    Friend WithEvents btnInterpretacion As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ATextoDelimitadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
