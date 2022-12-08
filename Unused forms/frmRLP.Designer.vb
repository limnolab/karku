<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRLP
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
        Dim IdProyectoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim AmbienteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRLP))
        Me.ProyectosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Scilla10DataSet = New Scila7.Scilla10DataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ProyectosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorEdit = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.IdProyectoTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.AutorTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.ProyectosTableAdapter = New Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter
        Me.TableAdapterManager = New Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
        Me.MuestrasTableAdapter = New Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
        Me.MuestrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuestrasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.C1Button1 = New C1.Win.C1Input.C1Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.AmbienteTextBox = New System.Windows.Forms.TextBox
        Me.ConfigDataSet = New Scila7.ConfigDataSet
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigTableAdapter = New Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
        Me.TableAdapterManager1 = New Scila7.ConfigDataSetTableAdapters.TableAdapterManager
        Me.EmpresaLabel1 = New System.Windows.Forms.Label
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder
        Me.C1CommandMenu1 = New C1.Win.C1Command.C1CommandMenu
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink
        Me.C1CommandMenu2 = New C1.Win.C1Command.C1CommandMenu
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink
        Me.C1Command1 = New C1.Win.C1Command.C1Command
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirAWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnciclopediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        IdProyectoLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        AutorLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        AmbienteLabel = New System.Windows.Forms.Label
        CType(Me.ProyectosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProyectosBindingNavigator.SuspendLayout()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdProyectoLabel
        '
        IdProyectoLabel.AutoSize = True
        IdProyectoLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdProyectoLabel.ForeColor = System.Drawing.Color.Black
        IdProyectoLabel.Location = New System.Drawing.Point(384, 30)
        IdProyectoLabel.Name = "IdProyectoLabel"
        IdProyectoLabel.Size = New System.Drawing.Size(78, 13)
        IdProyectoLabel.TabIndex = 1
        IdProyectoLabel.Text = "Id Proyecto:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.Color.Black
        NombreLabel.Location = New System.Drawing.Point(14, 28)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(57, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AutorLabel.ForeColor = System.Drawing.Color.Black
        AutorLabel.Location = New System.Drawing.Point(14, 56)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(43, 13)
        AutorLabel.TabIndex = 5
        AutorLabel.Text = "Autor:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.ForeColor = System.Drawing.Color.Black
        DescripcionLabel.Location = New System.Drawing.Point(14, 84)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(78, 13)
        DescripcionLabel.TabIndex = 7
        DescripcionLabel.Text = "Descripción:"
        '
        'AmbienteLabel
        '
        AmbienteLabel.AutoSize = True
        AmbienteLabel.Enabled = False
        AmbienteLabel.Location = New System.Drawing.Point(37, 399)
        AmbienteLabel.Name = "AmbienteLabel"
        AmbienteLabel.Size = New System.Drawing.Size(63, 14)
        AmbienteLabel.TabIndex = 8
        AmbienteLabel.Text = "Ambiente:"
        '
        'ProyectosBindingNavigator
        '
        Me.ProyectosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProyectosBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ProyectosBindingNavigator.BindingSource = Me.ProyectosBindingSource
        Me.ProyectosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProyectosBindingNavigator.CountItemFormat = "de {0}"
        Me.ProyectosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProyectosBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProyectosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ProyectosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ProyectosBindingNavigatorSaveItem, Me.BindingNavigatorEdit, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.ProyectosBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ProyectosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProyectosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProyectosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProyectosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProyectosBindingNavigator.Name = "ProyectosBindingNavigator"
        Me.ProyectosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProyectosBindingNavigator.Size = New System.Drawing.Size(801, 40)
        Me.ProyectosBindingNavigator.TabIndex = 0
        Me.ProyectosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(106, 37)
        Me.BindingNavigatorAddNewItem.Text = "Nuevo proyecto"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(42, 37)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(114, 37)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar proyecto"
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ProyectosBindingNavigatorSaveItem
        '
        Me.ProyectosBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.White
        Me.ProyectosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProyectosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProyectosBindingNavigatorSaveItem.Name = "ProyectosBindingNavigatorSaveItem"
        Me.ProyectosBindingNavigatorSaveItem.Size = New System.Drawing.Size(116, 37)
        Me.ProyectosBindingNavigatorSaveItem.Text = "Guardar proyecto"
        Me.ProyectosBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorEdit
        '
        Me.BindingNavigatorEdit.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorEdit.Image = CType(resources.GetObject("BindingNavigatorEdit.Image"), System.Drawing.Image)
        Me.BindingNavigatorEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEdit.Name = "BindingNavigatorEdit"
        Me.BindingNavigatorEdit.Size = New System.Drawing.Size(102, 37)
        Me.BindingNavigatorEdit.Text = "Editar proyecto"
        Me.BindingNavigatorEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 40)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'IdProyectoTextBox
        '
        Me.IdProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "IdProyecto", True))
        Me.IdProyectoTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProyectoTextBox.Location = New System.Drawing.Point(462, 27)
        Me.IdProyectoTextBox.Name = "IdProyectoTextBox"
        Me.IdProyectoTextBox.Size = New System.Drawing.Size(37, 21)
        Me.IdProyectoTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(98, 25)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(191, 21)
        Me.NombreTextBox.TabIndex = 4
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Autor", True))
        Me.AutorTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorTextBox.Location = New System.Drawing.Point(98, 53)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(191, 21)
        Me.AutorTextBox.TabIndex = 6
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(98, 81)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(191, 144)
        Me.DescripcionTextBox.TabIndex = 8
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MuestrasTableAdapter = Me.MuestrasTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Scila7.Scilla10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MuestrasTableAdapter
        '
        Me.MuestrasTableAdapter.ClearBeforeFill = True
        '
        'MuestrasBindingSource
        '
        Me.MuestrasBindingSource.DataMember = "Proyectos_Muestras"
        Me.MuestrasBindingSource.DataSource = Me.ProyectosBindingSource
        '
        'MuestrasDataGridView
        '
        Me.MuestrasDataGridView.AllowUserToAddRows = False
        Me.MuestrasDataGridView.AllowUserToDeleteRows = False
        Me.MuestrasDataGridView.AllowUserToOrderColumns = True
        Me.MuestrasDataGridView.AllowUserToResizeColumns = False
        Me.MuestrasDataGridView.AllowUserToResizeRows = False
        Me.MuestrasDataGridView.AutoGenerateColumns = False
        Me.MuestrasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MuestrasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MuestrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MuestrasDataGridView.DataSource = Me.MuestrasBindingSource
        Me.MuestrasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MuestrasDataGridView.Location = New System.Drawing.Point(10, 46)
        Me.MuestrasDataGridView.Name = "MuestrasDataGridView"
        Me.MuestrasDataGridView.ReadOnly = True
        Me.MuestrasDataGridView.RowHeadersVisible = False
        Me.MuestrasDataGridView.Size = New System.Drawing.Size(304, 402)
        Me.MuestrasDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdMuestra"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdMuestra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdProyectoLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.AutorTextBox)
        Me.GroupBox1.Controls.Add(Me.IdProyectoTextBox)
        Me.GroupBox1.Controls.Add(AutorLabel)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 262)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del proyecto"
        '
        'C1Button1
        '
        Me.C1Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.C1Button1.FlatAppearance.BorderSize = 2
        Me.C1Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Button1.Location = New System.Drawing.Point(23, 360)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(380, 64)
        Me.C1Button1.TabIndex = 14
        Me.C1Button1.Text = "Trabajar con este proyecto"
        Me.C1Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ProyectosBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(650, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.TabIndex = 15
        '
        'AmbienteTextBox
        '
        Me.AmbienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ambiente", True))
        Me.AmbienteTextBox.Enabled = False
        Me.AmbienteTextBox.Location = New System.Drawing.Point(116, 396)
        Me.AmbienteTextBox.Name = "AmbienteTextBox"
        Me.AmbienteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AmbienteTextBox.TabIndex = 9
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AdminTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ConfigTableAdapter = Me.ConfigTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Scila7.ConfigDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresaLabel1
        '
        Me.EmpresaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpresaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigBindingSource, "Empresa", True))
        Me.EmpresaLabel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmpresaLabel1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.EmpresaLabel1.Location = New System.Drawing.Point(0, 515)
        Me.EmpresaLabel1.Name = "EmpresaLabel1"
        Me.EmpresaLabel1.Size = New System.Drawing.Size(801, 25)
        Me.EmpresaLabel1.TabIndex = 16
        Me.EmpresaLabel1.Text = "Label2"
        Me.EmpresaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandMenu1)
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandMenu2)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command1)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CommandMenu1
        '
        Me.C1CommandMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink3})
        Me.C1CommandMenu1.HideNonRecentLinks = False
        Me.C1CommandMenu1.Name = "C1CommandMenu1"
        Me.C1CommandMenu1.Text = "Salir de Karku"
        Me.C1CommandMenu1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.Text = "New Command"
        '
        'C1CommandMenu2
        '
        Me.C1CommandMenu2.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink4})
        Me.C1CommandMenu2.HideNonRecentLinks = False
        Me.C1CommandMenu2.Name = "C1CommandMenu2"
        Me.C1CommandMenu2.Text = "Volver al comienzo"
        Me.C1CommandMenu2.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.C1Command1
        '
        'C1Command1
        '
        Me.C1Command1.Name = "C1Command1"
        Me.C1Command1.Text = "Volver al comienzo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProyectosDataGridView)
        Me.GroupBox2.Controls.Add(Me.MuestrasDataGridView)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(484, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(317, 451)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Este proyecto contiene las muestras"
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(338, 406)
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(23, 44)
        Me.ProyectosDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdProyecto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdProyecto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ambiente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ambiente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EnciclopediaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirAWindowsToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirAWindowsToolStripMenuItem
        '
        Me.SalirAWindowsToolStripMenuItem.Name = "SalirAWindowsToolStripMenuItem"
        Me.SalirAWindowsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SalirAWindowsToolStripMenuItem.Text = "Salir a Windows"
        '
        'EnciclopediaToolStripMenuItem
        '
        Me.EnciclopediaToolStripMenuItem.Name = "EnciclopediaToolStripMenuItem"
        Me.EnciclopediaToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.EnciclopediaToolStripMenuItem.Text = "Enciclopedia"
        '
        'frmRLP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 540)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.EmpresaLabel1)
        Me.Controls.Add(AmbienteLabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.AmbienteTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProyectosBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRLP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karku - Módulo: Estuarios (RLP)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProyectosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProyectosBindingNavigator.ResumeLayout(False)
        Me.ProyectosBindingNavigator.PerformLayout()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scilla10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuestrasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scilla10DataSet As Scila7.Scilla10DataSet
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As Scila7.Scilla10DataSetTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager As Scila7.Scilla10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProyectosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProyectosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MuestrasTableAdapter As Scila7.Scilla10DataSetTableAdapters.MuestrasTableAdapter
    Friend WithEvents MuestrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MuestrasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BindingNavigatorEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AmbienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents TableAdapterManager1 As Scila7.ConfigDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresaLabel1 As System.Windows.Forms.Label
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandMenu1 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandMenu2 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1Command1 As C1.Win.C1Command.C1Command
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProyectosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnciclopediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
