<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraficar
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.chkVacios = New System.Windows.Forms.CheckBox()
        Me.chklistVariables = New System.Windows.Forms.CheckedListBox()
        Me.cmbTipoSerie = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCopiarChart = New System.Windows.Forms.Button()
        Me.btnSeleccionarTodo = New System.Windows.Forms.Button()
        Me.chklistVariablesNames = New System.Windows.Forms.CheckedListBox()
        Me.btn3dEnable = New System.Windows.Forms.Button()
        Me.chkEtiquetas = New System.Windows.Forms.CheckBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = 90
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(228, 44)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Me.Chart1.Size = New System.Drawing.Size(544, 506)
        Me.Chart1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 522)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(207, 19)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'btnGraficar
        '
        Me.btnGraficar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGraficar.FlatAppearance.BorderSize = 0
        Me.btnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficar.ForeColor = System.Drawing.Color.White
        Me.btnGraficar.Image = Global.Scila7.My.Resources.Resources.next21
        Me.btnGraficar.Location = New System.Drawing.Point(12, 409)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(207, 61)
        Me.btnGraficar.TabIndex = 2
        Me.btnGraficar.Text = "Agregar serie al gráfico"
        Me.btnGraficar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGraficar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGraficar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(228, 7)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(160, 26)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar gráfico"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'chkVacios
        '
        Me.chkVacios.AutoSize = True
        Me.chkVacios.Checked = True
        Me.chkVacios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVacios.Location = New System.Drawing.Point(12, 525)
        Me.chkVacios.Name = "chkVacios"
        Me.chkVacios.Size = New System.Drawing.Size(143, 17)
        Me.chkVacios.TabIndex = 5
        Me.chkVacios.Text = "No graficar datos vacíos"
        Me.chkVacios.UseVisualStyleBackColor = True
        '
        'chklistVariables
        '
        Me.chklistVariables.FormattingEnabled = True
        Me.chklistVariables.Location = New System.Drawing.Point(12, 7)
        Me.chklistVariables.Name = "chklistVariables"
        Me.chklistVariables.Size = New System.Drawing.Size(207, 244)
        Me.chklistVariables.TabIndex = 6
        '
        'cmbTipoSerie
        '
        Me.cmbTipoSerie.FormattingEnabled = True
        Me.cmbTipoSerie.Items.AddRange(New Object() {"Columnas", "Lineas", "Puntos"})
        Me.cmbTipoSerie.Location = New System.Drawing.Point(66, 476)
        Me.cmbTipoSerie.Name = "cmbTipoSerie"
        Me.cmbTipoSerie.Size = New System.Drawing.Size(153, 21)
        Me.cmbTipoSerie.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 479)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Formato:"
        '
        'btnCopiarChart
        '
        Me.btnCopiarChart.BackColor = System.Drawing.Color.White
        Me.btnCopiarChart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnCopiarChart.FlatAppearance.BorderSize = 2
        Me.btnCopiarChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopiarChart.Location = New System.Drawing.Point(612, 7)
        Me.btnCopiarChart.Name = "btnCopiarChart"
        Me.btnCopiarChart.Size = New System.Drawing.Size(160, 26)
        Me.btnCopiarChart.TabIndex = 9
        Me.btnCopiarChart.Text = "Copiar gráfico como imagen"
        Me.btnCopiarChart.UseVisualStyleBackColor = False
        '
        'btnSeleccionarTodo
        '
        Me.btnSeleccionarTodo.BackColor = System.Drawing.Color.White
        Me.btnSeleccionarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSeleccionarTodo.FlatAppearance.BorderSize = 2
        Me.btnSeleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarTodo.Location = New System.Drawing.Point(12, 377)
        Me.btnSeleccionarTodo.Name = "btnSeleccionarTodo"
        Me.btnSeleccionarTodo.Size = New System.Drawing.Size(112, 26)
        Me.btnSeleccionarTodo.TabIndex = 10
        Me.btnSeleccionarTodo.Text = "Deseleccionar todo"
        Me.btnSeleccionarTodo.UseVisualStyleBackColor = False
        '
        'chklistVariablesNames
        '
        Me.chklistVariablesNames.FormattingEnabled = True
        Me.chklistVariablesNames.Location = New System.Drawing.Point(12, 7)
        Me.chklistVariablesNames.Name = "chklistVariablesNames"
        Me.chklistVariablesNames.Size = New System.Drawing.Size(207, 364)
        Me.chklistVariablesNames.TabIndex = 11
        '
        'btn3dEnable
        '
        Me.btn3dEnable.BackColor = System.Drawing.Color.White
        Me.btn3dEnable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn3dEnable.FlatAppearance.BorderSize = 2
        Me.btn3dEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3dEnable.ForeColor = System.Drawing.Color.Black
        Me.btn3dEnable.Location = New System.Drawing.Point(394, 7)
        Me.btn3dEnable.Name = "btn3dEnable"
        Me.btn3dEnable.Size = New System.Drawing.Size(93, 26)
        Me.btn3dEnable.TabIndex = 12
        Me.btn3dEnable.Text = "Gráfico 3D"
        Me.btn3dEnable.UseVisualStyleBackColor = False
        '
        'chkEtiquetas
        '
        Me.chkEtiquetas.AutoSize = True
        Me.chkEtiquetas.Checked = True
        Me.chkEtiquetas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEtiquetas.Location = New System.Drawing.Point(12, 503)
        Me.chkEtiquetas.Name = "chkEtiquetas"
        Me.chkEtiquetas.Size = New System.Drawing.Size(114, 17)
        Me.chkEtiquetas.TabIndex = 13
        Me.chkEtiquetas.Text = "Etiquetas de datos"
        Me.chkEtiquetas.UseVisualStyleBackColor = True
        '
        'frmGraficar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.chkEtiquetas)
        Me.Controls.Add(Me.btn3dEnable)
        Me.Controls.Add(Me.chklistVariablesNames)
        Me.Controls.Add(Me.btnSeleccionarTodo)
        Me.Controls.Add(Me.btnCopiarChart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTipoSerie)
        Me.Controls.Add(Me.chklistVariables)
        Me.Controls.Add(Me.chkVacios)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "frmGraficar"
        Me.Text = "Graficar"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnGraficar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents chkVacios As System.Windows.Forms.CheckBox
    Friend WithEvents chklistVariables As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmbTipoSerie As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCopiarChart As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionarTodo As System.Windows.Forms.Button
    Friend WithEvents chklistVariablesNames As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn3dEnable As System.Windows.Forms.Button
    Friend WithEvents chkEtiquetas As System.Windows.Forms.CheckBox
End Class
