<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder
        Me.EmpresaLabel1 = New System.Windows.Forms.Label
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage
        Me.btnComenzarProyecto = New C1.Win.C1Input.C1Button
        Me.webDescripcion = New System.Windows.Forms.WebBrowser
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnarroyopamp = New C1.Win.C1Input.C1Button
        Me.btnRLP = New C1.Win.C1Input.C1Button
        Me.btnarroyomont = New C1.Win.C1Input.C1Button
        Me.btnLenitico = New C1.Win.C1Input.C1Button
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab
        Me.ConfigTableAdapter = New Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
        Me.TableAdapterManager = New Scila7.ConfigDataSetTableAdapters.TableAdapterManager
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirAWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnciclopediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DBOrganismosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MacroinvertebradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DiatomeasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogotipoTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Owner = Me
        '
        'EmpresaLabel1
        '
        Me.EmpresaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigBindingSource, "Empresa", True))
        Me.EmpresaLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmpresaLabel1.Location = New System.Drawing.Point(6, 10)
        Me.EmpresaLabel1.Name = "EmpresaLabel1"
        Me.EmpresaLabel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.EmpresaLabel1.Size = New System.Drawing.Size(308, 44)
        Me.EmpresaLabel1.TabIndex = 18
        Me.EmpresaLabel1.Text = "Empresa"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.ConfigDataSet
        '
        'ConfigDataSet
        '
        Me.ConfigDataSet.DataSetName = "ConfigDataSet"
        Me.ConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.BackColor = System.Drawing.Color.White
        Me.C1DockingTabPage1.Controls.Add(Me.btnComenzarProyecto)
        Me.C1DockingTabPage1.Controls.Add(Me.webDescripcion)
        Me.C1DockingTabPage1.Controls.Add(Me.Label3)
        Me.C1DockingTabPage1.Controls.Add(Me.btnarroyopamp)
        Me.C1DockingTabPage1.Controls.Add(Me.btnRLP)
        Me.C1DockingTabPage1.Controls.Add(Me.btnarroyomont)
        Me.C1DockingTabPage1.Controls.Add(Me.btnLenitico)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 32)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(867, 493)
        Me.C1DockingTabPage1.TabBackColor = System.Drawing.Color.White
        Me.C1DockingTabPage1.TabBackColorSelected = System.Drawing.Color.White
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "Ambientes"
        '
        'btnComenzarProyecto
        '
        Me.btnComenzarProyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComenzarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnComenzarProyecto.FlatAppearance.BorderSize = 2
        Me.btnComenzarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComenzarProyecto.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzarProyecto.Location = New System.Drawing.Point(700, 440)
        Me.btnComenzarProyecto.Name = "btnComenzarProyecto"
        Me.btnComenzarProyecto.Size = New System.Drawing.Size(156, 50)
        Me.btnComenzarProyecto.TabIndex = 7
        Me.btnComenzarProyecto.Text = "Comenzar proyecto"
        Me.btnComenzarProyecto.UseVisualStyleBackColor = True
        Me.btnComenzarProyecto.Visible = False
        '
        'webDescripcion
        '
        Me.webDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webDescripcion.Location = New System.Drawing.Point(11, 124)
        Me.webDescripcion.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webDescripcion.Name = "webDescripcion"
        Me.webDescripcion.ScrollBarsEnabled = False
        Me.webDescripcion.Size = New System.Drawing.Size(800, 310)
        Me.webDescripcion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Seleccione su ambiente:"
        '
        'btnarroyopamp
        '
        Me.btnarroyopamp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnarroyopamp.FlatAppearance.BorderSize = 2
        Me.btnarroyopamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnarroyopamp.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnarroyopamp.Location = New System.Drawing.Point(24, 70)
        Me.btnarroyopamp.Name = "btnarroyopamp"
        Me.btnarroyopamp.Size = New System.Drawing.Size(112, 50)
        Me.btnarroyopamp.TabIndex = 2
        Me.btnarroyopamp.Text = "Curso de agua pampeano"
        Me.btnarroyopamp.UseVisualStyleBackColor = True
        '
        'btnRLP
        '
        Me.btnRLP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnRLP.FlatAppearance.BorderSize = 2
        Me.btnRLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRLP.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRLP.Location = New System.Drawing.Point(378, 70)
        Me.btnRLP.Name = "btnRLP"
        Me.btnRLP.Size = New System.Drawing.Size(112, 50)
        Me.btnRLP.TabIndex = 0
        Me.btnRLP.Text = "Estuario - Río de la Plata"
        Me.btnRLP.UseVisualStyleBackColor = True
        '
        'btnarroyomont
        '
        Me.btnarroyomont.Enabled = False
        Me.btnarroyomont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnarroyomont.FlatAppearance.BorderSize = 2
        Me.btnarroyomont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnarroyomont.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnarroyomont.Location = New System.Drawing.Point(142, 70)
        Me.btnarroyomont.Name = "btnarroyomont"
        Me.btnarroyomont.Size = New System.Drawing.Size(112, 50)
        Me.btnarroyomont.TabIndex = 3
        Me.btnarroyomont.Text = "Curso de agua de montaña"
        Me.btnarroyomont.UseVisualStyleBackColor = True
        '
        'btnLenitico
        '
        Me.btnLenitico.Enabled = False
        Me.btnLenitico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnLenitico.FlatAppearance.BorderSize = 2
        Me.btnLenitico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLenitico.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLenitico.Location = New System.Drawing.Point(260, 70)
        Me.btnLenitico.Name = "btnLenitico"
        Me.btnLenitico.Size = New System.Drawing.Size(112, 50)
        Me.btnLenitico.TabIndex = 4
        Me.btnLenitico.Text = "Lenítico"
        Me.btnLenitico.UseVisualStyleBackColor = True
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.BackColor = System.Drawing.Color.White
        Me.C1DockingTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.C1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1DockingTab1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 196)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(869, 526)
        Me.C1DockingTab1.TabIndex = 17
        Me.C1DockingTab1.TabLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1DockingTab1.TabsSpacing = 2
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP
        Me.C1DockingTab1.TextDirection = C1.Win.C1Command.TabTextDirectionEnum.Horizontal
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.System
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConfigTableAdapter = Me.ConfigTableAdapter
        Me.TableAdapterManager.UpdateOrder = Scila7.ConfigDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.EmpresaLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(535, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 172)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(110, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.EnciclopediaToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(869, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirAWindowsToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SalirToolStripMenuItem.Text = "Archivo"
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
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem, Me.DBOrganismosToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'DBOrganismosToolStripMenuItem
        '
        Me.DBOrganismosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MacroinvertebradosToolStripMenuItem, Me.DiatomeasToolStripMenuItem})
        Me.DBOrganismosToolStripMenuItem.Name = "DBOrganismosToolStripMenuItem"
        Me.DBOrganismosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DBOrganismosToolStripMenuItem.Text = "DB Organismos"
        '
        'MacroinvertebradosToolStripMenuItem
        '
        Me.MacroinvertebradosToolStripMenuItem.Name = "MacroinvertebradosToolStripMenuItem"
        Me.MacroinvertebradosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MacroinvertebradosToolStripMenuItem.Text = "Macroinvertebrados"
        '
        'DiatomeasToolStripMenuItem
        '
        Me.DiatomeasToolStripMenuItem.Name = "DiatomeasToolStripMenuItem"
        Me.DiatomeasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DiatomeasToolStripMenuItem.Text = "Diatomeas"
        '
        'LogotipoTextBox
        '
        Me.LogotipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigBindingSource, "Logotipo", True))
        Me.LogotipoTextBox.Location = New System.Drawing.Point(167, 57)
        Me.LogotipoTextBox.Name = "LogotipoTextBox"
        Me.LogotipoTextBox.Size = New System.Drawing.Size(100, 21)
        Me.LogotipoTextBox.TabIndex = 24
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Scila7.My.Resources.Resources.logoKerku
        Me.PictureBox2.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(303, 53)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Instituto de Limnología ""Dr. Raúl A. Ringuelet"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Contacto: Joaquín Cochero"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(869, 722)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LogotipoTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARKU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.C1DockingTabPage1.PerformLayout()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents ConfigTableAdapter As Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents TableAdapterManager As Scila7.ConfigDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresaLabel1 As System.Windows.Forms.Label
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents btnComenzarProyecto As C1.Win.C1Input.C1Button
    Protected Friend WithEvents webDescripcion As System.Windows.Forms.WebBrowser
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnarroyopamp As C1.Win.C1Input.C1Button
    Friend WithEvents btnRLP As C1.Win.C1Input.C1Button
    Friend WithEvents btnarroyomont As C1.Win.C1Input.C1Button
    Friend WithEvents btnLenitico As C1.Win.C1Input.C1Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnciclopediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogotipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerfilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DBOrganismosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MacroinvertebradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiatomeasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
