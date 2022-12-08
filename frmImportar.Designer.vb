<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportar
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AmbienteLabel As System.Windows.Forms.Label
        Dim lblTipoDatos As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportar))
        Me.dgvOutputColumns = New System.Windows.Forms.DataGridView()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager = New Scila7.Scilla10DataSetTableAdapters.TableAdapterManager()
        Me.lblAmbiente = New System.Windows.Forms.Label()
        Me.dgvInputColumns = New System.Windows.Forms.DataGridView()
        Me.dgvEquivalencias = New System.Windows.Forms.DataGridView()
        Me.IdEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.dgvInputSamples = New System.Windows.Forms.DataGridView()
        Me.btnAsignarMuestras = New System.Windows.Forms.Button()
        Me.dgvEquivalenciasSamples = New System.Windows.Forms.DataGridView()
        Me.EntradaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter()
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdMuestra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoSitio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdProyectoLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabComenzar = New System.Windows.Forms.TabPage()
        Me.grpOrigen = New System.Windows.Forms.GroupBox()
        Me.btnAbrirExcel = New System.Windows.Forms.Button()
        Me.cmbSheets = New System.Windows.Forms.ComboBox()
        Me.lblArchivoEntrada = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpDestino = New System.Windows.Forms.GroupBox()
        Me.cmbTipoDatos = New System.Windows.Forms.ComboBox()
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.cmbProyecto = New System.Windows.Forms.ComboBox()
        Me.btnAgregarProyecto = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.dgvComenzar = New System.Windows.Forms.DataGridView()
        Me.grpPreviewInput = New System.Windows.Forms.GroupBox()
        Me.btnTransponer = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.TabParametros = New System.Windows.Forms.TabPage()
        Me.btnEliminarTodasRelacionParametros = New System.Windows.Forms.Button()
        Me.btnEliminarRelacionParametros = New System.Windows.Forms.Button()
        Me.btnAutorelacionarParametros = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnSiguiente1 = New System.Windows.Forms.Button()
        Me.TabMuestras = New System.Windows.Forms.TabPage()
        Me.btnEliminarTodasRelacionMuestras = New System.Windows.Forms.Button()
        Me.btnEliminarRelacionMuestras = New System.Windows.Forms.Button()
        Me.btnAutorelacionarMuestras = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnAgregarMuestra = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSiguiente2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabResultados = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnImportacionIncorrecta = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnImportacionCorrecta = New System.Windows.Forms.Button()
        Me.AmbienteLabel1 = New System.Windows.Forms.Label()
        Me.NombreLabel1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulosTableAdapter = New Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        AmbienteLabel = New System.Windows.Forms.Label()
        lblTipoDatos = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        CType(Me.dgvOutputColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInputColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEquivalencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInputSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEquivalenciasSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabComenzar.SuspendLayout()
        Me.grpOrigen.SuspendLayout()
        Me.grpDestino.SuspendLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvComenzar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPreviewInput.SuspendLayout()
        Me.TabParametros.SuspendLayout()
        Me.TabMuestras.SuspendLayout()
        Me.TabResultados.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(819, 17)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(52, 13)
        NombreLabel.TabIndex = 207
        NombreLabel.Text = "Proyecto:"
        '
        'AmbienteLabel
        '
        AmbienteLabel.AutoSize = True
        AmbienteLabel.Location = New System.Drawing.Point(817, 30)
        AmbienteLabel.Name = "AmbienteLabel"
        AmbienteLabel.Size = New System.Drawing.Size(54, 13)
        AmbienteLabel.TabIndex = 209
        AmbienteLabel.Text = "Ambiente:"
        '
        'lblTipoDatos
        '
        lblTipoDatos.AutoSize = True
        lblTipoDatos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTipoDatos.Location = New System.Drawing.Point(151, 25)
        lblTipoDatos.Name = "lblTipoDatos"
        lblTipoDatos.Size = New System.Drawing.Size(220, 15)
        lblTipoDatos.TabIndex = 213
        lblTipoDatos.Text = "Que tipo de datos se esta importando?"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(151, 54)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(113, 15)
        Label14.TabIndex = 229
        Label14.Text = "Para cuál proyecto?"
        '
        'dgvOutputColumns
        '
        Me.dgvOutputColumns.AllowUserToAddRows = False
        Me.dgvOutputColumns.AllowUserToDeleteRows = False
        Me.dgvOutputColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutputColumns.Location = New System.Drawing.Point(554, 81)
        Me.dgvOutputColumns.Name = "dgvOutputColumns"
        Me.dgvOutputColumns.ReadOnly = True
        Me.dgvOutputColumns.RowHeadersVisible = False
        Me.dgvOutputColumns.Size = New System.Drawing.Size(286, 384)
        Me.dgvOutputColumns.TabIndex = 1
        '
        'lblOrigen
        '
        Me.lblOrigen.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.lblOrigen.Location = New System.Drawing.Point(8, 17)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(121, 33)
        Me.lblOrigen.TabIndex = 180
        Me.lblOrigen.Text = "Origen"
        '
        'lblDestino
        '
        Me.lblDestino.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.lblDestino.Location = New System.Drawing.Point(548, 17)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(121, 33)
        Me.lblDestino.TabIndex = 181
        Me.lblDestino.Text = "Destino"
        '
        'Scilla10DataSet
        '
        Me.Scilla10DataSet.DataSetName = "Scilla10DataSet"
        Me.Scilla10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.Scilla10DataSet
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MuestrasTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Scila7.Scilla10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblAmbiente
        '
        Me.lblAmbiente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ambiente", True))
        Me.lblAmbiente.Location = New System.Drawing.Point(659, 524)
        Me.lblAmbiente.Name = "lblAmbiente"
        Me.lblAmbiente.Size = New System.Drawing.Size(66, 17)
        Me.lblAmbiente.TabIndex = 185
        Me.lblAmbiente.Text = "Label1"
        '
        'dgvInputColumns
        '
        Me.dgvInputColumns.AllowUserToAddRows = False
        Me.dgvInputColumns.AllowUserToDeleteRows = False
        Me.dgvInputColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInputColumns.Location = New System.Drawing.Point(12, 81)
        Me.dgvInputColumns.Name = "dgvInputColumns"
        Me.dgvInputColumns.ReadOnly = True
        Me.dgvInputColumns.RowHeadersVisible = False
        Me.dgvInputColumns.Size = New System.Drawing.Size(369, 384)
        Me.dgvInputColumns.TabIndex = 188
        '
        'dgvEquivalencias
        '
        Me.dgvEquivalencias.AllowUserToAddRows = False
        Me.dgvEquivalencias.AllowUserToDeleteRows = False
        Me.dgvEquivalencias.BackgroundColor = System.Drawing.Color.White
        Me.dgvEquivalencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquivalencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEntrada, Me.Entrada, Me.IdSalida, Me.Salida})
        Me.dgvEquivalencias.GridColor = System.Drawing.Color.White
        Me.dgvEquivalencias.Location = New System.Drawing.Point(858, 81)
        Me.dgvEquivalencias.Name = "dgvEquivalencias"
        Me.dgvEquivalencias.ReadOnly = True
        Me.dgvEquivalencias.RowHeadersVisible = False
        Me.dgvEquivalencias.Size = New System.Drawing.Size(212, 384)
        Me.dgvEquivalencias.TabIndex = 189
        '
        'IdEntrada
        '
        Me.IdEntrada.HeaderText = "IdEntrada"
        Me.IdEntrada.Name = "IdEntrada"
        Me.IdEntrada.ReadOnly = True
        Me.IdEntrada.Visible = False
        '
        'Entrada
        '
        Me.Entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Entrada.HeaderText = "Entrada"
        Me.Entrada.Name = "Entrada"
        Me.Entrada.ReadOnly = True
        '
        'IdSalida
        '
        Me.IdSalida.HeaderText = "IdSalida"
        Me.IdSalida.Name = "IdSalida"
        Me.IdSalida.ReadOnly = True
        Me.IdSalida.Visible = False
        '
        'Salida
        '
        Me.Salida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Salida.HeaderText = "Salida"
        Me.Salida.Name = "Salida"
        Me.Salida.ReadOnly = True
        '
        'btnAsignar
        '
        Me.btnAsignar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAsignar.Location = New System.Drawing.Point(400, 229)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(130, 62)
        Me.btnAsignar.TabIndex = 190
        Me.btnAsignar.Text = "RELACIONAR PARAMETRO >"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'dgvInputSamples
        '
        Me.dgvInputSamples.AllowUserToAddRows = False
        Me.dgvInputSamples.AllowUserToDeleteRows = False
        Me.dgvInputSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInputSamples.Location = New System.Drawing.Point(13, 45)
        Me.dgvInputSamples.Name = "dgvInputSamples"
        Me.dgvInputSamples.ReadOnly = True
        Me.dgvInputSamples.RowHeadersVisible = False
        Me.dgvInputSamples.Size = New System.Drawing.Size(286, 384)
        Me.dgvInputSamples.TabIndex = 194
        '
        'btnAsignarMuestras
        '
        Me.btnAsignarMuestras.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAsignarMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignarMuestras.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarMuestras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAsignarMuestras.Location = New System.Drawing.Point(305, 208)
        Me.btnAsignarMuestras.Name = "btnAsignarMuestras"
        Me.btnAsignarMuestras.Size = New System.Drawing.Size(130, 62)
        Me.btnAsignarMuestras.TabIndex = 196
        Me.btnAsignarMuestras.Text = "RELACIONAR MUESTRA >"
        Me.btnAsignarMuestras.UseVisualStyleBackColor = True
        '
        'dgvEquivalenciasSamples
        '
        Me.dgvEquivalenciasSamples.AllowUserToAddRows = False
        Me.dgvEquivalenciasSamples.AllowUserToDeleteRows = False
        Me.dgvEquivalenciasSamples.BackgroundColor = System.Drawing.Color.White
        Me.dgvEquivalenciasSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquivalenciasSamples.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EntradaId, Me.DataGridViewTextBoxColumn1, Me.SalidaId, Me.DataGridViewTextBoxColumn2})
        Me.dgvEquivalenciasSamples.GridColor = System.Drawing.Color.White
        Me.dgvEquivalenciasSamples.Location = New System.Drawing.Point(859, 68)
        Me.dgvEquivalenciasSamples.Name = "dgvEquivalenciasSamples"
        Me.dgvEquivalenciasSamples.ReadOnly = True
        Me.dgvEquivalenciasSamples.RowHeadersVisible = False
        Me.dgvEquivalenciasSamples.Size = New System.Drawing.Size(211, 328)
        Me.dgvEquivalenciasSamples.TabIndex = 197
        '
        'EntradaId
        '
        Me.EntradaId.HeaderText = "EntradaId"
        Me.EntradaId.Name = "EntradaId"
        Me.EntradaId.ReadOnly = True
        Me.EntradaId.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Entrada"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SalidaId
        '
        Me.SalidaId.HeaderText = "SaliddaId"
        Me.SalidaId.Name = "SalidaId"
        Me.SalidaId.ReadOnly = True
        Me.SalidaId.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Salida"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'MuestrasBindingSource
        '
        Me.MuestrasBindingSource.DataMember = "Proyectos_Muestras"
        Me.MuestrasBindingSource.DataSource = Me.ProyectosBindingSource
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'MuestrasDataGridView
        '
        Me.MuestrasDataGridView.AllowUserToAddRows = False
        Me.MuestrasDataGridView.AllowUserToDeleteRows = False
        Me.MuestrasDataGridView.AutoGenerateColumns = False
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMuestra, Me.IdProyecto, Me.Nombre, Me.Fecha, Me.CodigoSitio})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(441, 68)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.ReadOnly = True
        Me.MuestrasDataGridView.RowHeadersVisible = False
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(404, 430)
        Me.MuestrasDataGridView.TabIndex = 197
        '
        'IdMuestra
        '
        Me.IdMuestra.DataPropertyName = "IdMuestra"
        Me.IdMuestra.HeaderText = "IdMuestra"
        Me.IdMuestra.Name = "IdMuestra"
        Me.IdMuestra.ReadOnly = True
        '
        'IdProyecto
        '
        Me.IdProyecto.DataPropertyName = "IdProyecto"
        Me.IdProyecto.HeaderText = "IdProyecto"
        Me.IdProyecto.Name = "IdProyecto"
        Me.IdProyecto.ReadOnly = True
        Me.IdProyecto.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'CodigoSitio
        '
        Me.CodigoSitio.DataPropertyName = "CodigoSitio"
        Me.CodigoSitio.HeaderText = "CodigoSitio"
        Me.CodigoSitio.Name = "CodigoSitio"
        Me.CodigoSitio.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.IndianRed
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(859, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 28)
        Me.Label1.TabIndex = 201
        Me.Label1.Text = "Muestras con datos existentes - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No se reemplazaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.GreenYellow
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(859, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 28)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Muestras con datos existentes - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Se reemplazaran"
        '
        'IdProyectoLabel
        '
        Me.IdProyectoLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "IdProyecto", True))
        Me.IdProyectoLabel.Location = New System.Drawing.Point(659, 505)
        Me.IdProyectoLabel.Name = "IdProyectoLabel"
        Me.IdProyectoLabel.Size = New System.Drawing.Size(58, 16)
        Me.IdProyectoLabel.TabIndex = 204
        Me.IdProyectoLabel.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 33)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "Resultado de Importación"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabComenzar)
        Me.TabControl1.Controls.Add(Me.TabParametros)
        Me.TabControl1.Controls.Add(Me.TabMuestras)
        Me.TabControl1.Controls.Add(Me.TabResultados)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1086, 575)
        Me.TabControl1.TabIndex = 207
        '
        'TabComenzar
        '
        Me.TabComenzar.Controls.Add(Me.grpOrigen)
        Me.TabComenzar.Controls.Add(Me.grpDestino)
        Me.TabComenzar.Controls.Add(Me.TextBox3)
        Me.TabComenzar.Controls.Add(Me.dgvComenzar)
        Me.TabComenzar.Controls.Add(Me.grpPreviewInput)
        Me.TabComenzar.Controls.Add(Me.btnComenzar)
        Me.TabComenzar.Location = New System.Drawing.Point(4, 22)
        Me.TabComenzar.Name = "TabComenzar"
        Me.TabComenzar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabComenzar.Size = New System.Drawing.Size(1078, 549)
        Me.TabComenzar.TabIndex = 3
        Me.TabComenzar.Text = "Comenzar"
        Me.TabComenzar.UseVisualStyleBackColor = True
        '
        'grpOrigen
        '
        Me.grpOrigen.Controls.Add(Me.btnAbrirExcel)
        Me.grpOrigen.Controls.Add(Me.cmbSheets)
        Me.grpOrigen.Controls.Add(Me.lblArchivoEntrada)
        Me.grpOrigen.Controls.Add(Me.Label10)
        Me.grpOrigen.Controls.Add(Me.Label13)
        Me.grpOrigen.Controls.Add(Me.Label11)
        Me.grpOrigen.Location = New System.Drawing.Point(8, 16)
        Me.grpOrigen.Name = "grpOrigen"
        Me.grpOrigen.Size = New System.Drawing.Size(816, 58)
        Me.grpOrigen.TabIndex = 234
        Me.grpOrigen.TabStop = False
        '
        'btnAbrirExcel
        '
        Me.btnAbrirExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirExcel.Location = New System.Drawing.Point(526, 22)
        Me.btnAbrirExcel.Name = "btnAbrirExcel"
        Me.btnAbrirExcel.Size = New System.Drawing.Size(93, 23)
        Me.btnAbrirExcel.TabIndex = 184
        Me.btnAbrirExcel.Text = "Explorar..."
        Me.btnAbrirExcel.UseVisualStyleBackColor = True
        '
        'cmbSheets
        '
        Me.cmbSheets.FormattingEnabled = True
        Me.cmbSheets.Location = New System.Drawing.Point(679, 23)
        Me.cmbSheets.Name = "cmbSheets"
        Me.cmbSheets.Size = New System.Drawing.Size(110, 21)
        Me.cmbSheets.TabIndex = 210
        '
        'lblArchivoEntrada
        '
        Me.lblArchivoEntrada.AutoSize = True
        Me.lblArchivoEntrada.ForeColor = System.Drawing.Color.Red
        Me.lblArchivoEntrada.Location = New System.Drawing.Point(345, 27)
        Me.lblArchivoEntrada.Name = "lblArchivoEntrada"
        Me.lblArchivoEntrada.Size = New System.Drawing.Size(75, 13)
        Me.lblArchivoEntrada.TabIndex = 230
        Me.lblArchivoEntrada.Text = "Seleccione -->"
        Me.lblArchivoEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(636, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 211
        Me.Label10.Text = "Hoja:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(151, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(188, 15)
        Me.Label13.TabIndex = 216
        Me.Label13.Text = "Seleccione un archivo a importar:"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(795, 33)
        Me.Label11.TabIndex = 183
        Me.Label11.Text = "Origen"
        '
        'grpDestino
        '
        Me.grpDestino.Controls.Add(lblTipoDatos)
        Me.grpDestino.Controls.Add(Me.cmbTipoDatos)
        Me.grpDestino.Controls.Add(Me.cmbProyecto)
        Me.grpDestino.Controls.Add(Me.btnAgregarProyecto)
        Me.grpDestino.Controls.Add(Label14)
        Me.grpDestino.Controls.Add(Me.Label12)
        Me.grpDestino.Location = New System.Drawing.Point(8, 67)
        Me.grpDestino.Name = "grpDestino"
        Me.grpDestino.Size = New System.Drawing.Size(816, 89)
        Me.grpDestino.TabIndex = 233
        Me.grpDestino.TabStop = False
        Me.grpDestino.Visible = False
        '
        'cmbTipoDatos
        '
        Me.cmbTipoDatos.DataSource = Me.ModulosBindingSource
        Me.cmbTipoDatos.DisplayMember = "nombre"
        Me.cmbTipoDatos.FormattingEnabled = True
        Me.cmbTipoDatos.Location = New System.Drawing.Point(587, 23)
        Me.cmbTipoDatos.Name = "cmbTipoDatos"
        Me.cmbTipoDatos.Size = New System.Drawing.Size(202, 21)
        Me.cmbTipoDatos.TabIndex = 212
        Me.cmbTipoDatos.ValueMember = "codigo"
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
        'cmbProyecto
        '
        Me.cmbProyecto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre", True))
        Me.cmbProyecto.DataSource = Me.ProyectosBindingSource
        Me.cmbProyecto.DisplayMember = "Nombre"
        Me.cmbProyecto.FormattingEnabled = True
        Me.cmbProyecto.Location = New System.Drawing.Point(440, 52)
        Me.cmbProyecto.Name = "cmbProyecto"
        Me.cmbProyecto.Size = New System.Drawing.Size(179, 21)
        Me.cmbProyecto.TabIndex = 227
        Me.cmbProyecto.ValueMember = "Nombre"
        '
        'btnAgregarProyecto
        '
        Me.btnAgregarProyecto.BackColor = System.Drawing.Color.White
        Me.btnAgregarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAgregarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProyecto.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProyecto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregarProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarProyecto.Location = New System.Drawing.Point(625, 50)
        Me.btnAgregarProyecto.Name = "btnAgregarProyecto"
        Me.btnAgregarProyecto.Size = New System.Drawing.Size(164, 24)
        Me.btnAgregarProyecto.TabIndex = 228
        Me.btnAgregarProyecto.Text = "Agregar proyecto nuevo"
        Me.btnAgregarProyecto.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(6, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(795, 63)
        Me.Label12.TabIndex = 214
        Me.Label12.Text = "Destino"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(841, 33)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(218, 106)
        Me.TextBox3.TabIndex = 224
        Me.TextBox3.Text = resources.GetString("TextBox3.Text")
        '
        'dgvComenzar
        '
        Me.dgvComenzar.AllowUserToAddRows = False
        Me.dgvComenzar.AllowUserToDeleteRows = False
        Me.dgvComenzar.BackgroundColor = System.Drawing.Color.White
        Me.dgvComenzar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComenzar.Location = New System.Drawing.Point(240, 302)
        Me.dgvComenzar.Name = "dgvComenzar"
        Me.dgvComenzar.ReadOnly = True
        Me.dgvComenzar.RowHeadersVisible = False
        Me.dgvComenzar.Size = New System.Drawing.Size(540, 174)
        Me.dgvComenzar.TabIndex = 215
        Me.dgvComenzar.Visible = False
        '
        'grpPreviewInput
        '
        Me.grpPreviewInput.Controls.Add(Me.btnTransponer)
        Me.grpPreviewInput.Controls.Add(Me.Label15)
        Me.grpPreviewInput.Controls.Add(Me.Label17)
        Me.grpPreviewInput.Controls.Add(Me.Label18)
        Me.grpPreviewInput.Controls.Add(Me.Label16)
        Me.grpPreviewInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPreviewInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.grpPreviewInput.Location = New System.Drawing.Point(26, 241)
        Me.grpPreviewInput.Name = "grpPreviewInput"
        Me.grpPreviewInput.Size = New System.Drawing.Size(795, 289)
        Me.grpPreviewInput.TabIndex = 225
        Me.grpPreviewInput.TabStop = False
        Me.grpPreviewInput.Text = "Vista previa del archivo a importar"
        Me.grpPreviewInput.Visible = False
        '
        'btnTransponer
        '
        Me.btnTransponer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTransponer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransponer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransponer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnTransponer.Location = New System.Drawing.Point(624, 241)
        Me.btnTransponer.Name = "btnTransponer"
        Me.btnTransponer.Size = New System.Drawing.Size(130, 31)
        Me.btnTransponer.TabIndex = 223
        Me.btnTransponer.Text = "Transponer matriz"
        Me.btnTransponer.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightGreen
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(215, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 30)
        Me.Label15.TabIndex = 218
        Me.Label15.Text = "             Columna 1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nombres de las muestras"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label17.Location = New System.Drawing.Point(439, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 30)
        Me.Label17.TabIndex = 220
        Me.Label17.Text = "Columnas 2,3,4....n " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Parámetros"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Location = New System.Drawing.Point(75, 183)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 15)
        Me.Label18.TabIndex = 222
        Me.Label18.Text = "Filas 2,3,4....n: Muestras"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Khaki
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label16.Location = New System.Drawing.Point(18, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(196, 15)
        Me.Label16.TabIndex = 221
        Me.Label16.Text = "Fila 1: Nombres de los parámetros"
        '
        'btnComenzar
        '
        Me.btnComenzar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnComenzar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnComenzar.FlatAppearance.BorderSize = 0
        Me.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComenzar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.ForeColor = System.Drawing.Color.White
        Me.btnComenzar.Image = Global.Scila7.My.Resources.Resources.next21
        Me.btnComenzar.Location = New System.Drawing.Point(858, 471)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(212, 62)
        Me.btnComenzar.TabIndex = 207
        Me.btnComenzar.Text = "COMENZAR"
        Me.btnComenzar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComenzar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnComenzar.UseVisualStyleBackColor = False
        '
        'TabParametros
        '
        Me.TabParametros.Controls.Add(Me.btnEliminarTodasRelacionParametros)
        Me.TabParametros.Controls.Add(Me.btnEliminarRelacionParametros)
        Me.TabParametros.Controls.Add(Me.btnAutorelacionarParametros)
        Me.TabParametros.Controls.Add(Me.txtSearch)
        Me.TabParametros.Controls.Add(Me.TextBox4)
        Me.TabParametros.Controls.Add(Me.btnSiguiente1)
        Me.TabParametros.Controls.Add(Me.lblOrigen)
        Me.TabParametros.Controls.Add(Me.dgvInputColumns)
        Me.TabParametros.Controls.Add(Me.lblDestino)
        Me.TabParametros.Controls.Add(Me.dgvOutputColumns)
        Me.TabParametros.Controls.Add(Me.dgvEquivalencias)
        Me.TabParametros.Controls.Add(Me.btnAsignar)
        Me.TabParametros.Location = New System.Drawing.Point(4, 22)
        Me.TabParametros.Name = "TabParametros"
        Me.TabParametros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabParametros.Size = New System.Drawing.Size(1078, 549)
        Me.TabParametros.TabIndex = 0
        Me.TabParametros.Text = "Parámetros"
        Me.TabParametros.UseVisualStyleBackColor = True
        '
        'btnEliminarTodasRelacionParametros
        '
        Me.btnEliminarTodasRelacionParametros.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEliminarTodasRelacionParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarTodasRelacionParametros.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTodasRelacionParametros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminarTodasRelacionParametros.Location = New System.Drawing.Point(971, 49)
        Me.btnEliminarTodasRelacionParametros.Name = "btnEliminarTodasRelacionParametros"
        Me.btnEliminarTodasRelacionParametros.Size = New System.Drawing.Size(99, 26)
        Me.btnEliminarTodasRelacionParametros.TabIndex = 212
        Me.btnEliminarTodasRelacionParametros.Text = "Eliminar todas"
        Me.btnEliminarTodasRelacionParametros.UseVisualStyleBackColor = True
        '
        'btnEliminarRelacionParametros
        '
        Me.btnEliminarRelacionParametros.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEliminarRelacionParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarRelacionParametros.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRelacionParametros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminarRelacionParametros.Location = New System.Drawing.Point(858, 49)
        Me.btnEliminarRelacionParametros.Name = "btnEliminarRelacionParametros"
        Me.btnEliminarRelacionParametros.Size = New System.Drawing.Size(111, 26)
        Me.btnEliminarRelacionParametros.TabIndex = 211
        Me.btnEliminarRelacionParametros.Text = "Eliminar relación"
        Me.btnEliminarRelacionParametros.UseVisualStyleBackColor = True
        '
        'btnAutorelacionarParametros
        '
        Me.btnAutorelacionarParametros.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAutorelacionarParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutorelacionarParametros.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutorelacionarParametros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAutorelacionarParametros.Location = New System.Drawing.Point(400, 439)
        Me.btnAutorelacionarParametros.Name = "btnAutorelacionarParametros"
        Me.btnAutorelacionarParametros.Size = New System.Drawing.Size(130, 26)
        Me.btnAutorelacionarParametros.TabIndex = 210
        Me.btnAutorelacionarParametros.Text = "Autorelacionar>"
        Me.btnAutorelacionarParametros.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(554, 53)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(286, 20)
        Me.txtSearch.TabIndex = 209
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(554, 482)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(286, 52)
        Me.TextBox4.TabIndex = 208
        Me.TextBox4.Text = "Seleccione que parámetro del archivo de entrada (*.XLS) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se corresponde con que " & _
    "parámetro del KARKU," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y presione ""Relacionar Parámetro"""
        '
        'btnSiguiente1
        '
        Me.btnSiguiente1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSiguiente1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSiguiente1.FlatAppearance.BorderSize = 0
        Me.btnSiguiente1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente1.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente1.Image = Global.Scila7.My.Resources.Resources.next21
        Me.btnSiguiente1.Location = New System.Drawing.Point(858, 472)
        Me.btnSiguiente1.Name = "btnSiguiente1"
        Me.btnSiguiente1.Size = New System.Drawing.Size(212, 62)
        Me.btnSiguiente1.TabIndex = 206
        Me.btnSiguiente1.Text = "SIGUIENTE"
        Me.btnSiguiente1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSiguiente1.UseVisualStyleBackColor = False
        '
        'TabMuestras
        '
        Me.TabMuestras.Controls.Add(Me.btnEliminarTodasRelacionMuestras)
        Me.TabMuestras.Controls.Add(Me.btnEliminarRelacionMuestras)
        Me.TabMuestras.Controls.Add(Me.btnAutorelacionarMuestras)
        Me.TabMuestras.Controls.Add(Me.TextBox5)
        Me.TabMuestras.Controls.Add(Me.btnAgregarMuestra)
        Me.TabMuestras.Controls.Add(Me.Label6)
        Me.TabMuestras.Controls.Add(Me.btnSiguiente2)
        Me.TabMuestras.Controls.Add(Me.Label5)
        Me.TabMuestras.Controls.Add(Me.Label4)
        Me.TabMuestras.Controls.Add(Me.dgvInputSamples)
        Me.TabMuestras.Controls.Add(Me.IdProyectoLabel)
        Me.TabMuestras.Controls.Add(Me.Label2)
        Me.TabMuestras.Controls.Add(Me.lblAmbiente)
        Me.TabMuestras.Controls.Add(Me.dgvEquivalenciasSamples)
        Me.TabMuestras.Controls.Add(Me.MuestrasDataGridView)
        Me.TabMuestras.Controls.Add(Me.Label1)
        Me.TabMuestras.Controls.Add(Me.btnAsignarMuestras)
        Me.TabMuestras.Location = New System.Drawing.Point(4, 22)
        Me.TabMuestras.Name = "TabMuestras"
        Me.TabMuestras.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMuestras.Size = New System.Drawing.Size(1078, 549)
        Me.TabMuestras.TabIndex = 1
        Me.TabMuestras.Text = "Muestras"
        Me.TabMuestras.UseVisualStyleBackColor = True
        '
        'btnEliminarTodasRelacionMuestras
        '
        Me.btnEliminarTodasRelacionMuestras.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEliminarTodasRelacionMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarTodasRelacionMuestras.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTodasRelacionMuestras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminarTodasRelacionMuestras.Location = New System.Drawing.Point(971, 36)
        Me.btnEliminarTodasRelacionMuestras.Name = "btnEliminarTodasRelacionMuestras"
        Me.btnEliminarTodasRelacionMuestras.Size = New System.Drawing.Size(99, 26)
        Me.btnEliminarTodasRelacionMuestras.TabIndex = 214
        Me.btnEliminarTodasRelacionMuestras.Text = "Eliminar todas"
        Me.btnEliminarTodasRelacionMuestras.UseVisualStyleBackColor = True
        '
        'btnEliminarRelacionMuestras
        '
        Me.btnEliminarRelacionMuestras.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEliminarRelacionMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarRelacionMuestras.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRelacionMuestras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminarRelacionMuestras.Location = New System.Drawing.Point(858, 36)
        Me.btnEliminarRelacionMuestras.Name = "btnEliminarRelacionMuestras"
        Me.btnEliminarRelacionMuestras.Size = New System.Drawing.Size(111, 26)
        Me.btnEliminarRelacionMuestras.TabIndex = 213
        Me.btnEliminarRelacionMuestras.Text = "Eliminar relación"
        Me.btnEliminarRelacionMuestras.UseVisualStyleBackColor = True
        '
        'btnAutorelacionarMuestras
        '
        Me.btnAutorelacionarMuestras.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAutorelacionarMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutorelacionarMuestras.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutorelacionarMuestras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAutorelacionarMuestras.Location = New System.Drawing.Point(305, 401)
        Me.btnAutorelacionarMuestras.Name = "btnAutorelacionarMuestras"
        Me.btnAutorelacionarMuestras.Size = New System.Drawing.Size(130, 26)
        Me.btnAutorelacionarMuestras.TabIndex = 211
        Me.btnAutorelacionarMuestras.Text = "Autorelacionar>"
        Me.btnAutorelacionarMuestras.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(13, 435)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(416, 108)
        Me.TextBox5.TabIndex = 210
        Me.TextBox5.Text = resources.GetString("TextBox5.Text")
        '
        'btnAgregarMuestra
        '
        Me.btnAgregarMuestra.BackColor = System.Drawing.Color.White
        Me.btnAgregarMuestra.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAgregarMuestra.FlatAppearance.BorderSize = 2
        Me.btnAgregarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarMuestra.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMuestra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregarMuestra.Image = Global.Scila7.My.Resources.Resources.Plus1
        Me.btnAgregarMuestra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarMuestra.Location = New System.Drawing.Point(441, 504)
        Me.btnAgregarMuestra.Name = "btnAgregarMuestra"
        Me.btnAgregarMuestra.Size = New System.Drawing.Size(404, 37)
        Me.btnAgregarMuestra.TabIndex = 209
        Me.btnAgregarMuestra.Text = "Agregar muestra"
        Me.btnAgregarMuestra.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(859, 453)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 15)
        Me.Label6.TabIndex = 208
        Me.Label6.Text = "Muestras sin datos existentes"
        '
        'btnSiguiente2
        '
        Me.btnSiguiente2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSiguiente2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSiguiente2.FlatAppearance.BorderSize = 0
        Me.btnSiguiente2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente2.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente2.Image = Global.Scila7.My.Resources.Resources.next21
        Me.btnSiguiente2.Location = New System.Drawing.Point(859, 479)
        Me.btnSiguiente2.Name = "btnSiguiente2"
        Me.btnSiguiente2.Size = New System.Drawing.Size(212, 62)
        Me.btnSiguiente2.TabIndex = 207
        Me.btnSiguiente2.Text = "SIGUIENTE"
        Me.btnSiguiente2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSiguiente2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(441, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(285, 33)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Destino > Muestras en BD"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 33)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Origen > Lista de muestras"
        '
        'TabResultados
        '
        Me.TabResultados.Controls.Add(Me.Label9)
        Me.TabResultados.Controls.Add(Me.Label8)
        Me.TabResultados.Controls.Add(Me.dgvDatos)
        Me.TabResultados.Controls.Add(Me.TextBox2)
        Me.TabResultados.Controls.Add(Me.btnImportacionIncorrecta)
        Me.TabResultados.Controls.Add(Me.TextBox1)
        Me.TabResultados.Controls.Add(Me.btnImportacionCorrecta)
        Me.TabResultados.Controls.Add(AmbienteLabel)
        Me.TabResultados.Controls.Add(Me.AmbienteLabel1)
        Me.TabResultados.Controls.Add(NombreLabel)
        Me.TabResultados.Controls.Add(Me.NombreLabel1)
        Me.TabResultados.Controls.Add(Me.Label7)
        Me.TabResultados.Controls.Add(Me.Label3)
        Me.TabResultados.Location = New System.Drawing.Point(4, 22)
        Me.TabResultados.Name = "TabResultados"
        Me.TabResultados.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResultados.Size = New System.Drawing.Size(1078, 549)
        Me.TabResultados.TabIndex = 2
        Me.TabResultados.Text = "Resultados"
        Me.TabResultados.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(410, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 20)
        Me.Label9.TabIndex = 218
        Me.Label9.Text = "Parámetros"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(38, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 217
        Me.Label8.Text = "Muestras"
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(127, 128)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.Size = New System.Drawing.Size(681, 355)
        Me.dgvDatos.TabIndex = 216
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(840, 392)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(212, 91)
        Me.TextBox2.TabIndex = 215
        Me.TextBox2.Text = "Los datos de importación no son correctos. Las muestras de mi archivo externo NO " & _
    "están correctamente asociadas a las muestras que existen en el KARKU." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volver al" & _
    " principio del proceso!"
        '
        'btnImportacionIncorrecta
        '
        Me.btnImportacionIncorrecta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImportacionIncorrecta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnImportacionIncorrecta.FlatAppearance.BorderSize = 2
        Me.btnImportacionIncorrecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportacionIncorrecta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportacionIncorrecta.ForeColor = System.Drawing.Color.White
        Me.btnImportacionIncorrecta.Location = New System.Drawing.Point(840, 309)
        Me.btnImportacionIncorrecta.Name = "btnImportacionIncorrecta"
        Me.btnImportacionIncorrecta.Size = New System.Drawing.Size(212, 68)
        Me.btnImportacionIncorrecta.TabIndex = 214
        Me.btnImportacionIncorrecta.Text = "La importación NO es correcta"
        Me.btnImportacionIncorrecta.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(840, 200)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(212, 91)
        Me.TextBox1.TabIndex = 213
        Me.TextBox1.Text = "Los datos de importación son correctos. Las muestras de mi archivo externo están " & _
    "correctamente asociadas a las muestras que existen en el KARKU." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proceder con la" & _
    " importación y grabar!"
        '
        'btnImportacionCorrecta
        '
        Me.btnImportacionCorrecta.BackColor = System.Drawing.Color.Green
        Me.btnImportacionCorrecta.Enabled = False
        Me.btnImportacionCorrecta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnImportacionCorrecta.FlatAppearance.BorderSize = 2
        Me.btnImportacionCorrecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportacionCorrecta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportacionCorrecta.ForeColor = System.Drawing.Color.White
        Me.btnImportacionCorrecta.Location = New System.Drawing.Point(840, 126)
        Me.btnImportacionCorrecta.Name = "btnImportacionCorrecta"
        Me.btnImportacionCorrecta.Size = New System.Drawing.Size(212, 68)
        Me.btnImportacionCorrecta.TabIndex = 211
        Me.btnImportacionCorrecta.Text = "La importación es correcta"
        Me.btnImportacionCorrecta.UseVisualStyleBackColor = False
        '
        'AmbienteLabel1
        '
        Me.AmbienteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ambiente", True))
        Me.AmbienteLabel1.Location = New System.Drawing.Point(872, 32)
        Me.AmbienteLabel1.Name = "AmbienteLabel1"
        Me.AmbienteLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AmbienteLabel1.TabIndex = 210
        Me.AmbienteLabel1.Text = "Label8"
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre", True))
        Me.NombreLabel1.Location = New System.Drawing.Point(872, 17)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel1.TabIndex = 208
        Me.NombreLabel1.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(28, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(312, 23)
        Me.Label7.TabIndex = 207
        Me.Label7.Text = "Vista previa del Proyecto"
        '
        'ModulosTableAdapter
        '
        Me.ModulosTableAdapter.ClearBeforeFill = True
        '
        'frmImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1086, 575)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmImportar"
        Me.Text = "Importar Planillas"
        CType(Me.dgvOutputColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInputColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEquivalencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInputSamples, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEquivalenciasSamples, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabComenzar.ResumeLayout(False)
        Me.TabComenzar.PerformLayout()
        Me.grpOrigen.ResumeLayout(False)
        Me.grpOrigen.PerformLayout()
        Me.grpDestino.ResumeLayout(False)
        Me.grpDestino.PerformLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvComenzar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPreviewInput.ResumeLayout(False)
        Me.grpPreviewInput.PerformLayout()
        Me.TabParametros.ResumeLayout(False)
        Me.TabParametros.PerformLayout()
        Me.TabMuestras.ResumeLayout(False)
        Me.TabMuestras.PerformLayout()
        Me.TabResultados.ResumeLayout(False)
        Me.TabResultados.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvOutputColumns As System.Windows.Forms.DataGridView
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager As Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblAmbiente As System.Windows.Forms.Label
    Friend WithEvents dgvInputColumns As System.Windows.Forms.DataGridView
    Friend WithEvents dgvEquivalencias As System.Windows.Forms.DataGridView
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents dgvInputSamples As System.Windows.Forms.DataGridView
    Friend WithEvents btnAsignarMuestras As System.Windows.Forms.Button
    Friend WithEvents dgvEquivalenciasSamples As System.Windows.Forms.DataGridView
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdMuestra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoSitio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdProyectoLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabParametros As System.Windows.Forms.TabPage
    Friend WithEvents TabMuestras As System.Windows.Forms.TabPage
    Friend WithEvents TabResultados As System.Windows.Forms.TabPage
    Friend WithEvents btnSiguiente1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSiguiente2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AmbienteLabel1 As System.Windows.Forms.Label
    Friend WithEvents NombreLabel1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnImportacionIncorrecta As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnImportacionCorrecta As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregarMuestra As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabComenzar As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoDatos As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbSheets As System.Windows.Forms.ComboBox
    Friend WithEvents btnComenzar As System.Windows.Forms.Button
    Friend WithEvents btnAbrirExcel As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvComenzar As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnTransponer As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents grpPreviewInput As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarProyecto As System.Windows.Forms.Button
    Friend WithEvents cmbProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents lblArchivoEntrada As System.Windows.Forms.Label
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ModulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModulosTableAdapter As Scila7.ConfigDataSetTableAdapters.ModulosTableAdapter
    Friend WithEvents IdEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnAutorelacionarParametros As System.Windows.Forms.Button
    Friend WithEvents btnAutorelacionarMuestras As System.Windows.Forms.Button
    Friend WithEvents EntradaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalidaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpOrigen As System.Windows.Forms.GroupBox
    Friend WithEvents grpDestino As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarTodasRelacionParametros As System.Windows.Forms.Button
    Friend WithEvents btnEliminarRelacionParametros As System.Windows.Forms.Button
    Friend WithEvents btnEliminarTodasRelacionMuestras As System.Windows.Forms.Button
    Friend WithEvents btnEliminarRelacionMuestras As System.Windows.Forms.Button
End Class
