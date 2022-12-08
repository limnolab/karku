<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProyectos
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProyectos))
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter
        Me.ConfigDataSet = New Scila7.ConfigDataSet
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigTableAdapter = New Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
        Me.grpMuestras = New System.Windows.Forms.GroupBox
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView
        Me.IdMuestra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpDatosdelProyecto = New System.Windows.Forms.GroupBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.AutorTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.AmbienteTextBox = New System.Windows.Forms.TextBox
        Me.IdProyectoTextBox = New System.Windows.Forms.TextBox
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmpresaLabel1 = New System.Windows.Forms.Label
        Me.btnEditarProyecto = New System.Windows.Forms.Button
        Me.btnAbrirProyecto = New System.Windows.Forms.Button
        Me.btnBorrarProyecto = New System.Windows.Forms.Button
        Me.btnGuardarProyecto = New System.Windows.Forms.Button
        Me.btnNuevoProyecto = New System.Windows.Forms.Button
        Me.grpProyectos = New System.Windows.Forms.GroupBox
        Me.ProyectosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.grpBotones = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnciclopediaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirAWindowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage
        Me.NombreLabel2 = New System.Windows.Forms.Label
        Me.TableAdapterManager = New Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
        NombreLabel = New System.Windows.Forms.Label
        AutorLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMuestras.SuspendLayout()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosdelProyecto.SuspendLayout()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProyectos.SuspendLayout()
        CType(Me.ProyectosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProyectosBindingNavigator.SuspendLayout()
        Me.grpBotones.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(14, 31)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(53, 15)
        NombreLabel.TabIndex = 35
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        AutorLabel.AutoSize = True
        AutorLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AutorLabel.Location = New System.Drawing.Point(-102, 59)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(40, 15)
        AutorLabel.TabIndex = 37
        AutorLabel.Text = "Autor:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(14, 102)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(76, 15)
        DescripcionLabel.TabIndex = 39
        DescripcionLabel.Text = "Descripción:"
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
        'ConfigDataSet
        '
        Me.ConfigDataSet.DataSetName = "ConfigDataSet"
        Me.ConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.ConfigDataSet
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'grpMuestras
        '
        Me.grpMuestras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMuestras.BackColor = System.Drawing.Color.White
        Me.grpMuestras.Controls.Add(Me.MuestrasDataGridView)
        Me.grpMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpMuestras.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMuestras.Location = New System.Drawing.Point(316, 311)
        Me.grpMuestras.Name = "grpMuestras"
        Me.grpMuestras.Size = New System.Drawing.Size(507, 253)
        Me.grpMuestras.TabIndex = 50
        Me.grpMuestras.TabStop = False
        Me.grpMuestras.Text = "Muestras"
        '
        'MuestrasDataGridView
        '
        Me.MuestrasDataGridView.AllowUserToAddRows = False
        Me.MuestrasDataGridView.AllowUserToDeleteRows = False
        Me.MuestrasDataGridView.AllowUserToResizeColumns = False
        Me.MuestrasDataGridView.AllowUserToResizeRows = False
        Me.MuestrasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MuestrasDataGridView.AutoGenerateColumns = False
        Me.MuestrasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MuestrasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MuestrasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.MuestrasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MuestrasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMuestra, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MuestrasDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.MuestrasDataGridView.GridColor = System.Drawing.Color.White
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(10, 22)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.ReadOnly = True
        Me.MuestrasDataGridView.RowHeadersVisible = False
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(491, 219)
        Me.MuestrasDataGridView.TabIndex = 35
        '
        'IdMuestra
        '
        Me.IdMuestra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdMuestra.DataPropertyName = "IdMuestra"
        Me.IdMuestra.HeaderText = "IdMuestra"
        Me.IdMuestra.Name = "IdMuestra"
        Me.IdMuestra.ReadOnly = True
        Me.IdMuestra.Width = 89
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 64
        '
        'MuestrasBindingSource
        '
        Me.MuestrasBindingSource.DataMember = "Proyectos_Muestras"
        Me.MuestrasBindingSource.DataSource = Me.ProyectosBindingSource
        '
        'grpDatosdelProyecto
        '
        Me.grpDatosdelProyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpDatosdelProyecto.BackColor = System.Drawing.Color.White
        Me.grpDatosdelProyecto.Controls.Add(Me.DescripcionTextBox)
        Me.grpDatosdelProyecto.Controls.Add(NombreLabel)
        Me.grpDatosdelProyecto.Controls.Add(Me.AutorTextBox)
        Me.grpDatosdelProyecto.Controls.Add(Me.NombreTextBox)
        Me.grpDatosdelProyecto.Controls.Add(Me.AmbienteTextBox)
        Me.grpDatosdelProyecto.Controls.Add(AutorLabel)
        Me.grpDatosdelProyecto.Controls.Add(Me.IdProyectoTextBox)
        Me.grpDatosdelProyecto.Controls.Add(DescripcionLabel)
        Me.grpDatosdelProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDatosdelProyecto.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosdelProyecto.Location = New System.Drawing.Point(27, 311)
        Me.grpDatosdelProyecto.Name = "grpDatosdelProyecto"
        Me.grpDatosdelProyecto.Size = New System.Drawing.Size(265, 253)
        Me.grpDatosdelProyecto.TabIndex = 51
        Me.grpDatosdelProyecto.TabStop = False
        Me.grpDatosdelProyecto.Text = "Datos"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Enabled = False
        Me.DescripcionTextBox.Location = New System.Drawing.Point(73, 135)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(172, 93)
        Me.DescripcionTextBox.TabIndex = 40
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Autor", True))
        Me.AutorTextBox.Enabled = False
        Me.AutorTextBox.Location = New System.Drawing.Point(73, 59)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(173, 23)
        Me.AutorTextBox.TabIndex = 38
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(73, 25)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(172, 23)
        Me.NombreTextBox.TabIndex = 36
        '
        'AmbienteTextBox
        '
        Me.AmbienteTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AmbienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ambiente", True))
        Me.AmbienteTextBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbienteTextBox.Location = New System.Drawing.Point(179, 137)
        Me.AmbienteTextBox.Name = "AmbienteTextBox"
        Me.AmbienteTextBox.Size = New System.Drawing.Size(56, 21)
        Me.AmbienteTextBox.TabIndex = 34
        '
        'IdProyectoTextBox
        '
        Me.IdProyectoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IdProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "IdProyecto", True))
        Me.IdProyectoTextBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProyectoTextBox.Location = New System.Drawing.Point(179, 163)
        Me.IdProyectoTextBox.Name = "IdProyectoTextBox"
        Me.IdProyectoTextBox.Size = New System.Drawing.Size(56, 21)
        Me.IdProyectoTextBox.TabIndex = 25
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AllowUserToAddRows = False
        Me.ProyectosDataGridView.AllowUserToDeleteRows = False
        Me.ProyectosDataGridView.AllowUserToResizeColumns = False
        Me.ProyectosDataGridView.AllowUserToResizeRows = False
        Me.ProyectosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        Me.ProyectosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProyectosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProyectosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ProyectosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProyectosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProyectosDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.ProyectosDataGridView.GridColor = System.Drawing.Color.White
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(10, 23)
        Me.ProyectosDataGridView.MultiSelect = False
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.ReadOnly = True
        Me.ProyectosDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ProyectosDataGridView.RowHeadersVisible = False
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(786, 202)
        Me.ProyectosDataGridView.TabIndex = 45
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProyecto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdProyecto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 69
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ambiente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ambiente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'EmpresaLabel1
        '
        Me.EmpresaLabel1.BackColor = System.Drawing.Color.DarkGray
        Me.EmpresaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigBindingSource, "Empresa", True))
        Me.EmpresaLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmpresaLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaLabel1.ForeColor = System.Drawing.Color.Black
        Me.EmpresaLabel1.Location = New System.Drawing.Point(0, 24)
        Me.EmpresaLabel1.Name = "EmpresaLabel1"
        Me.EmpresaLabel1.Size = New System.Drawing.Size(1058, 37)
        Me.EmpresaLabel1.TabIndex = 49
        Me.EmpresaLabel1.Text = "Label4"
        Me.EmpresaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditarProyecto
        '
        Me.btnEditarProyecto.BackColor = System.Drawing.Color.White
        Me.btnEditarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnEditarProyecto.FlatAppearance.BorderSize = 0
        Me.btnEditarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarProyecto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarProyecto.Image = Global.Scila7.My.Resources.Resources.Write3
        Me.btnEditarProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarProyecto.Location = New System.Drawing.Point(8, 69)
        Me.btnEditarProyecto.Name = "btnEditarProyecto"
        Me.btnEditarProyecto.Size = New System.Drawing.Size(178, 44)
        Me.btnEditarProyecto.TabIndex = 55
        Me.btnEditarProyecto.Text = "Editar datos"
        Me.btnEditarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditarProyecto.UseVisualStyleBackColor = False
        '
        'btnAbrirProyecto
        '
        Me.btnAbrirProyecto.BackColor = System.Drawing.Color.White
        Me.btnAbrirProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAbrirProyecto.FlatAppearance.BorderSize = 0
        Me.btnAbrirProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirProyecto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirProyecto.Image = CType(resources.GetObject("btnAbrirProyecto.Image"), System.Drawing.Image)
        Me.btnAbrirProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrirProyecto.Location = New System.Drawing.Point(8, 117)
        Me.btnAbrirProyecto.Name = "btnAbrirProyecto"
        Me.btnAbrirProyecto.Size = New System.Drawing.Size(178, 44)
        Me.btnAbrirProyecto.TabIndex = 53
        Me.btnAbrirProyecto.Text = "Abrir Proyecto"
        Me.btnAbrirProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrirProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbrirProyecto.UseVisualStyleBackColor = False
        '
        'btnBorrarProyecto
        '
        Me.btnBorrarProyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarProyecto.BackColor = System.Drawing.Color.White
        Me.btnBorrarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnBorrarProyecto.FlatAppearance.BorderSize = 0
        Me.btnBorrarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarProyecto.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarProyecto.Image = Global.Scila7.My.Resources.Resources.Cancel1
        Me.btnBorrarProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarProyecto.Location = New System.Drawing.Point(7, 13)
        Me.btnBorrarProyecto.Name = "btnBorrarProyecto"
        Me.btnBorrarProyecto.Size = New System.Drawing.Size(140, 32)
        Me.btnBorrarProyecto.TabIndex = 54
        Me.btnBorrarProyecto.Text = "Eliminar Proyecto"
        Me.btnBorrarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrarProyecto.UseVisualStyleBackColor = False
        '
        'btnGuardarProyecto
        '
        Me.btnGuardarProyecto.BackColor = System.Drawing.Color.White
        Me.btnGuardarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnGuardarProyecto.FlatAppearance.BorderSize = 0
        Me.btnGuardarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarProyecto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarProyecto.Image = Global.Scila7.My.Resources.Resources.Save
        Me.btnGuardarProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarProyecto.Location = New System.Drawing.Point(8, 69)
        Me.btnGuardarProyecto.Name = "btnGuardarProyecto"
        Me.btnGuardarProyecto.Size = New System.Drawing.Size(178, 44)
        Me.btnGuardarProyecto.TabIndex = 48
        Me.btnGuardarProyecto.Text = "Guardar Proyecto"
        Me.btnGuardarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarProyecto.UseVisualStyleBackColor = False
        Me.btnGuardarProyecto.Visible = False
        '
        'btnNuevoProyecto
        '
        Me.btnNuevoProyecto.BackColor = System.Drawing.Color.White
        Me.btnNuevoProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnNuevoProyecto.FlatAppearance.BorderSize = 0
        Me.btnNuevoProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoProyecto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProyecto.Image = Global.Scila7.My.Resources.Resources.Document
        Me.btnNuevoProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoProyecto.Location = New System.Drawing.Point(8, 15)
        Me.btnNuevoProyecto.Name = "btnNuevoProyecto"
        Me.btnNuevoProyecto.Size = New System.Drawing.Size(178, 50)
        Me.btnNuevoProyecto.TabIndex = 46
        Me.btnNuevoProyecto.Text = "Nuevo Proyecto"
        Me.btnNuevoProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevoProyecto.UseVisualStyleBackColor = False
        '
        'grpProyectos
        '
        Me.grpProyectos.Controls.Add(Me.ProyectosDataGridView)
        Me.grpProyectos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProyectos.Location = New System.Drawing.Point(27, 28)
        Me.grpProyectos.Name = "grpProyectos"
        Me.grpProyectos.Size = New System.Drawing.Size(802, 233)
        Me.grpProyectos.TabIndex = 57
        Me.grpProyectos.TabStop = False
        '
        'ProyectosBindingNavigator
        '
        Me.ProyectosBindingNavigator.AddNewItem = Nothing
        Me.ProyectosBindingNavigator.BackColor = System.Drawing.Color.White
        Me.ProyectosBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProyectosBindingNavigator.BindingSource = Me.ProyectosBindingSource
        Me.ProyectosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProyectosBindingNavigator.CountItemFormat = "de {0} proyectos"
        Me.ProyectosBindingNavigator.DeleteItem = Nothing
        Me.ProyectosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ProyectosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator1})
        Me.ProyectosBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ProyectosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProyectosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProyectosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProyectosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProyectosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProyectosBindingNavigator.Name = "ProyectosBindingNavigator"
        Me.ProyectosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProyectosBindingNavigator.Size = New System.Drawing.Size(841, 25)
        Me.ProyectosBindingNavigator.TabIndex = 44
        Me.ProyectosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(92, 22)
        Me.BindingNavigatorCountItem.Text = "de {0} proyectos"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'grpBotones
        '
        Me.grpBotones.BackColor = System.Drawing.Color.White
        Me.grpBotones.Controls.Add(Me.btnEditarProyecto)
        Me.grpBotones.Controls.Add(Me.btnAbrirProyecto)
        Me.grpBotones.Controls.Add(Me.btnGuardarProyecto)
        Me.grpBotones.Controls.Add(Me.btnNuevoProyecto)
        Me.grpBotones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpBotones.Location = New System.Drawing.Point(20, 79)
        Me.grpBotones.Name = "grpBotones"
        Me.grpBotones.Size = New System.Drawing.Size(196, 170)
        Me.grpBotones.TabIndex = 59
        Me.grpBotones.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProyectoToolStripMenuItem, Me.EnciclopediaToolStripMenuItem1, Me.SalirAWindowsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1058, 24)
        Me.MenuStrip1.TabIndex = 76
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProyectoToolStripMenuItem
        '
        Me.ProyectoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarProyectoToolStripMenuItem})
        Me.ProyectoToolStripMenuItem.Name = "ProyectoToolStripMenuItem"
        Me.ProyectoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProyectoToolStripMenuItem.Text = "Proyecto"
        '
        'CambiarProyectoToolStripMenuItem
        '
        Me.CambiarProyectoToolStripMenuItem.Name = "CambiarProyectoToolStripMenuItem"
        Me.CambiarProyectoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CambiarProyectoToolStripMenuItem.Text = "Cambiar proyecto..."
        '
        'EnciclopediaToolStripMenuItem1
        '
        Me.EnciclopediaToolStripMenuItem1.Name = "EnciclopediaToolStripMenuItem1"
        Me.EnciclopediaToolStripMenuItem1.Size = New System.Drawing.Size(86, 20)
        Me.EnciclopediaToolStripMenuItem1.Text = "Enciclopedia"
        '
        'SalirAWindowsToolStripMenuItem1
        '
        Me.SalirAWindowsToolStripMenuItem1.Name = "SalirAWindowsToolStripMenuItem1"
        Me.SalirAWindowsToolStripMenuItem1.Size = New System.Drawing.Size(102, 20)
        Me.SalirAWindowsToolStripMenuItem1.Text = "Salir a Windows"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnBorrarProyecto)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 580)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 53)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.C1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1DockingTab1.Location = New System.Drawing.Point(216, 61)
        Me.C1DockingTab1.MultiLine = True
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.ShowSingleTab = False
        Me.C1DockingTab1.Size = New System.Drawing.Size(842, 584)
        Me.C1DockingTab1.TabIndex = 78
        Me.C1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.User
        Me.C1DockingTab1.TabsSpacing = 2
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.C1DockingTab1.TextDirection = C1.Win.C1Command.TabTextDirectionEnum.Horizontal
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DockingTabPage1.BackColor = System.Drawing.Color.White
        Me.C1DockingTabPage1.Controls.Add(Me.NombreLabel2)
        Me.C1DockingTabPage1.Controls.Add(Me.ProyectosBindingNavigator)
        Me.C1DockingTabPage1.Controls.Add(Me.grpMuestras)
        Me.C1DockingTabPage1.Controls.Add(Me.grpProyectos)
        Me.C1DockingTabPage1.Controls.Add(Me.grpDatosdelProyecto)
        Me.C1DockingTabPage1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1DockingTabPage1.ForeColor = System.Drawing.Color.Black
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 0)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(841, 584)
        Me.C1DockingTabPage1.TabBackColor = System.Drawing.Color.White
        Me.C1DockingTabPage1.TabBackColorSelected = System.Drawing.Color.White
        Me.C1DockingTabPage1.TabForeColor = System.Drawing.Color.White
        Me.C1DockingTabPage1.TabForeColorSelected = System.Drawing.Color.White
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "PROYECTO"
        '
        'NombreLabel2
        '
        Me.NombreLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreLabel2.BackColor = System.Drawing.Color.Gainsboro
        Me.NombreLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre", True))
        Me.NombreLabel2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.NombreLabel2.Location = New System.Drawing.Point(0, 276)
        Me.NombreLabel2.Name = "NombreLabel2"
        Me.NombreLabel2.Size = New System.Drawing.Size(842, 23)
        Me.NombreLabel2.TabIndex = 58
        Me.NombreLabel2.Text = "Label1"
        Me.NombreLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False

        Me.TableAdapterManager.MuestrasTableAdapter = Me.MuestrasTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Scila7.Scilla10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmProyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 662)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpBotones)
        Me.Controls.Add(Me.EmpresaLabel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmProyectos"
        Me.Text = "PROYECTOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMuestras.ResumeLayout(False)
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosdelProyecto.ResumeLayout(False)
        Me.grpDatosdelProyecto.PerformLayout()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProyectos.ResumeLayout(False)
        CType(Me.ProyectosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProyectosBindingNavigator.ResumeLayout(False)
        Me.ProyectosBindingNavigator.PerformLayout()
        Me.grpBotones.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.C1DockingTabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents grpMuestras As System.Windows.Forms.GroupBox
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardarProyecto As System.Windows.Forms.Button
    Friend WithEvents grpDatosdelProyecto As System.Windows.Forms.GroupBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmbienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProyectosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevoProyecto As System.Windows.Forms.Button
    Friend WithEvents EmpresaLabel1 As System.Windows.Forms.Label
    Friend WithEvents btnEditarProyecto As System.Windows.Forms.Button
    Friend WithEvents btnAbrirProyecto As System.Windows.Forms.Button
    Friend WithEvents btnBorrarProyecto As System.Windows.Forms.Button
    Friend WithEvents grpProyectos As System.Windows.Forms.GroupBox
    Friend WithEvents grpBotones As System.Windows.Forms.GroupBox
    Friend WithEvents ProyectosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnciclopediaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdMuestra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreLabel2 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
End Class
