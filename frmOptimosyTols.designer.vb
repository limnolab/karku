<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptimosyTols
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptimosyTols))
        Me.PlanillaSpXMuestras = New System.Windows.Forms.DataGridView()
        Me.PlanillaFqXMuestras = New System.Windows.Forms.DataGridView()
        Me.btnCargaSpXMuestras = New System.Windows.Forms.Button()
        Me.btnPegarAbu = New System.Windows.Forms.Button()
        Me.btnPegarFQ = New System.Windows.Forms.Button()
        Me.PlanillaResultados = New System.Windows.Forms.DataGridView()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.PlanillaResumen = New System.Windows.Forms.DataGridView()
        Me.PlanillaTolerancia = New System.Windows.Forms.DataGridView()
        Me.radRawData = New System.Windows.Forms.RadioButton()
        Me.radLog10Data = New System.Windows.Forms.RadioButton()
        Me.radAbundancias = New System.Windows.Forms.RadioButton()
        Me.radDensidades = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.ProyectosTableAdapter = New Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        CType(Me.PlanillaSpXMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaFqXMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaTolerancia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlanillaSpXMuestras
        '
        Me.PlanillaSpXMuestras.BackgroundColor = System.Drawing.Color.White
        Me.PlanillaSpXMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaSpXMuestras.Location = New System.Drawing.Point(12, 100)
        Me.PlanillaSpXMuestras.Name = "PlanillaSpXMuestras"
        Me.PlanillaSpXMuestras.Size = New System.Drawing.Size(350, 231)
        Me.PlanillaSpXMuestras.TabIndex = 0
        '
        'PlanillaFqXMuestras
        '
        Me.PlanillaFqXMuestras.BackgroundColor = System.Drawing.Color.White
        Me.PlanillaFqXMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaFqXMuestras.Location = New System.Drawing.Point(12, 352)
        Me.PlanillaFqXMuestras.Name = "PlanillaFqXMuestras"
        Me.PlanillaFqXMuestras.Size = New System.Drawing.Size(350, 210)
        Me.PlanillaFqXMuestras.TabIndex = 1
        '
        'btnCargaSpXMuestras
        '
        Me.btnCargaSpXMuestras.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnCargaSpXMuestras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnCargaSpXMuestras.FlatAppearance.BorderSize = 0
        Me.btnCargaSpXMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargaSpXMuestras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaSpXMuestras.ForeColor = System.Drawing.Color.White
        Me.btnCargaSpXMuestras.Location = New System.Drawing.Point(368, 101)
        Me.btnCargaSpXMuestras.Name = "btnCargaSpXMuestras"
        Me.btnCargaSpXMuestras.Size = New System.Drawing.Size(105, 54)
        Me.btnCargaSpXMuestras.TabIndex = 2
        Me.btnCargaSpXMuestras.Text = "COMENZAR"
        Me.btnCargaSpXMuestras.UseVisualStyleBackColor = False
        '
        'btnPegarAbu
        '
        Me.btnPegarAbu.Enabled = False
        Me.btnPegarAbu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnPegarAbu.FlatAppearance.BorderSize = 2
        Me.btnPegarAbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPegarAbu.Location = New System.Drawing.Point(368, 161)
        Me.btnPegarAbu.Name = "btnPegarAbu"
        Me.btnPegarAbu.Size = New System.Drawing.Size(105, 77)
        Me.btnPegarAbu.TabIndex = 4
        Me.btnPegarAbu.Text = "Pegar matriz de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Especies x Muestras"
        Me.btnPegarAbu.UseVisualStyleBackColor = True
        '
        'btnPegarFQ
        '
        Me.btnPegarFQ.Enabled = False
        Me.btnPegarFQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnPegarFQ.FlatAppearance.BorderSize = 2
        Me.btnPegarFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPegarFQ.Location = New System.Drawing.Point(368, 394)
        Me.btnPegarFQ.Name = "btnPegarFQ"
        Me.btnPegarFQ.Size = New System.Drawing.Size(105, 77)
        Me.btnPegarFQ.TabIndex = 5
        Me.btnPegarFQ.Text = "Pegar matriz de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Físico-químicos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "x Muestras"
        Me.btnPegarFQ.UseVisualStyleBackColor = True
        '
        'PlanillaResultados
        '
        Me.PlanillaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaResultados.Location = New System.Drawing.Point(488, 101)
        Me.PlanillaResultados.Name = "PlanillaResultados"
        Me.PlanillaResultados.ReadOnly = True
        Me.PlanillaResultados.Size = New System.Drawing.Size(188, 215)
        Me.PlanillaResultados.TabIndex = 6
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.White
        Me.btnCalcular.Location = New System.Drawing.Point(479, 494)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(163, 70)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "CALCULAR "
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'PlanillaResumen
        '
        Me.PlanillaResumen.BackgroundColor = System.Drawing.Color.White
        Me.PlanillaResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaResumen.Location = New System.Drawing.Point(479, 101)
        Me.PlanillaResumen.Name = "PlanillaResumen"
        Me.PlanillaResumen.ReadOnly = True
        Me.PlanillaResumen.Size = New System.Drawing.Size(408, 387)
        Me.PlanillaResumen.TabIndex = 9
        '
        'PlanillaTolerancia
        '
        Me.PlanillaTolerancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaTolerancia.Location = New System.Drawing.Point(683, 101)
        Me.PlanillaTolerancia.Name = "PlanillaTolerancia"
        Me.PlanillaTolerancia.Size = New System.Drawing.Size(204, 215)
        Me.PlanillaTolerancia.TabIndex = 11
        '
        'radRawData
        '
        Me.radRawData.AutoSize = True
        Me.radRawData.Checked = True
        Me.radRawData.Location = New System.Drawing.Point(7, 19)
        Me.radRawData.Name = "radRawData"
        Me.radRawData.Size = New System.Drawing.Size(88, 17)
        Me.radRawData.TabIndex = 12
        Me.radRawData.TabStop = True
        Me.radRawData.Text = "Datos crudos"
        Me.radRawData.UseVisualStyleBackColor = True
        '
        'radLog10Data
        '
        Me.radLog10Data.AutoSize = True
        Me.radLog10Data.Location = New System.Drawing.Point(7, 42)
        Me.radLog10Data.Name = "radLog10Data"
        Me.radLog10Data.Size = New System.Drawing.Size(71, 30)
        Me.radLog10Data.TabIndex = 13
        Me.radLog10Data.Text = "Datos en " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LOG10"
        Me.radLog10Data.UseVisualStyleBackColor = True
        '
        'radAbundancias
        '
        Me.radAbundancias.AutoSize = True
        Me.radAbundancias.Checked = True
        Me.radAbundancias.Location = New System.Drawing.Point(7, 19)
        Me.radAbundancias.Name = "radAbundancias"
        Me.radAbundancias.Size = New System.Drawing.Size(90, 30)
        Me.radAbundancias.TabIndex = 15
        Me.radAbundancias.TabStop = True
        Me.radAbundancias.Text = "Abundancias " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "relativas"
        Me.radAbundancias.UseVisualStyleBackColor = True
        '
        'radDensidades
        '
        Me.radDensidades.AutoSize = True
        Me.radDensidades.Location = New System.Drawing.Point(7, 55)
        Me.radDensidades.Name = "radDensidades"
        Me.radDensidades.Size = New System.Drawing.Size(81, 17)
        Me.radDensidades.TabIndex = 14
        Me.radDensidades.Text = "Densidades"
        Me.radDensidades.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDensidades)
        Me.GroupBox1.Controls.Add(Me.radAbundancias)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 87)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radLog10Data)
        Me.GroupBox2.Controls.Add(Me.radRawData)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 477)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(105, 87)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(648, 494)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(239, 20)
        Me.ProgressBar1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Matriz de ESPECIES (filas) x MUESTRA (columnas)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Matriz de FÍSICOQUÍMICOS  (filas) x MUESTRA (columnas)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(92, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 26)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Óptimos y tolerancias de las especies"
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ForeColor = System.Drawing.Color.White
        Me.btnExportar.Image = Global.Scila7.My.Resources.Resources.xls2
        Me.btnExportar.Location = New System.Drawing.Point(749, 519)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(138, 45)
        Me.btnExportar.TabIndex = 24
        Me.btnExportar.Text = "Exportar XLS"
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(680, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Óptimos y tolerancias calculados siguiendo a:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(550, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(342, 39)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Potapova y Charles (2003). Distribution of benthic diatoms in U.S. rivers " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in re" & _
    "lation to conductivity and ionic composition.  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Freshwate Biology 48:1311–1328"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.Scilla10DataSet
        '
        'Scilla10DataSet
        '
        Me.Scilla10DataSet.DataSetName = "Scilla10DataSet"
        Me.Scilla10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
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
        'frmOptimosyTols
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(901, 572)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PlanillaResumen)
        Me.Controls.Add(Me.PlanillaTolerancia)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.PlanillaResultados)
        Me.Controls.Add(Me.btnPegarFQ)
        Me.Controls.Add(Me.btnPegarAbu)
        Me.Controls.Add(Me.btnCargaSpXMuestras)
        Me.Controls.Add(Me.PlanillaFqXMuestras)
        Me.Controls.Add(Me.PlanillaSpXMuestras)
        Me.Name = "frmOptimosyTols"
        Me.Text = "Cálculo de óptimos y tolerancias"
        CType(Me.PlanillaSpXMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaFqXMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaTolerancia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlanillaSpXMuestras As System.Windows.Forms.DataGridView
    Friend WithEvents PlanillaFqXMuestras As System.Windows.Forms.DataGridView
    Friend WithEvents btnCargaSpXMuestras As System.Windows.Forms.Button
    Friend WithEvents btnPegarAbu As System.Windows.Forms.Button
    Friend WithEvents btnPegarFQ As System.Windows.Forms.Button
    Friend WithEvents PlanillaResultados As System.Windows.Forms.DataGridView
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents PlanillaResumen As System.Windows.Forms.DataGridView
    Friend WithEvents PlanillaTolerancia As System.Windows.Forms.DataGridView
    Friend WithEvents radRawData As System.Windows.Forms.RadioButton
    Friend WithEvents radLog10Data As System.Windows.Forms.RadioButton
    Friend WithEvents radAbundancias As System.Windows.Forms.RadioButton
    Friend WithEvents radDensidades As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents ProyectosTableAdapter As Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter

End Class
