<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigPerfil
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
        Dim EmpresaLabel1 As System.Windows.Forms.Label
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigDataSet = New Scila7.ConfigDataSet()
        Me.AdminTableAdapter = New Scila7.ConfigDataSetTableAdapters.AdminTableAdapter()
        Me.TableAdapterManager = New Scila7.ConfigDataSetTableAdapters.TableAdapterManager()
        Me.ConfigTableAdapter = New Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PassLabel = New System.Windows.Forms.Label()
        Me.EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New C1.Win.C1Input.C1Button()
        Me.btnCambiarLogo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCambiarUser = New System.Windows.Forms.Button()
        EmpresaLabel1 = New System.Windows.Forms.Label()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpresaLabel1
        '
        EmpresaLabel1.AutoSize = True
        EmpresaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpresaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        EmpresaLabel1.Location = New System.Drawing.Point(13, 27)
        EmpresaLabel1.Name = "EmpresaLabel1"
        EmpresaLabel1.Size = New System.Drawing.Size(158, 20)
        EmpresaLabel1.TabIndex = 17
        EmpresaLabel1.Text = "Empresa/Laboratorio"
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(405, 32)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        Me.UsuarioLabel.TabIndex = 13
        Me.UsuarioLabel.Text = "Usuario:"
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
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Me.AdminTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalculosTableAdapter = Nothing
        Me.TableAdapterManager.ConfigTableAdapter = Me.ConfigTableAdapter
        Me.TableAdapterManager.ModulosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Scila7.ConfigDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.ConfigDataSet
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.Location = New System.Drawing.Point(406, 57)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(37, 13)
        Me.PassLabel.TabIndex = 15
        Me.PassLabel.Text = "Clave:"
        '
        'EmpresaTextBox
        '
        Me.EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigBindingSource, "Empresa", True))
        Me.EmpresaTextBox.Enabled = False
        Me.EmpresaTextBox.Location = New System.Drawing.Point(58, 55)
        Me.EmpresaTextBox.Name = "EmpresaTextBox"
        Me.EmpresaTextBox.Size = New System.Drawing.Size(165, 20)
        Me.EmpresaTextBox.TabIndex = 18
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(455, 29)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(112, 20)
        Me.UsuarioTextBox.TabIndex = 19
        '
        'PassTextBox
        '
        Me.PassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "pass", True))
        Me.PassTextBox.Location = New System.Drawing.Point(455, 55)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.Size = New System.Drawing.Size(112, 20)
        Me.PassTextBox.TabIndex = 20
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(455, 239)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 50)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCambiarLogo
        '
        Me.btnCambiarLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnCambiarLogo.FlatAppearance.BorderSize = 0
        Me.btnCambiarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarLogo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarLogo.ForeColor = System.Drawing.Color.White
        Me.btnCambiarLogo.Image = Global.Scila7.My.Resources.Resources.edit_equalizer
        Me.btnCambiarLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCambiarLogo.Location = New System.Drawing.Point(59, 251)
        Me.btnCambiarLogo.Name = "btnCambiarLogo"
        Me.btnCambiarLogo.Size = New System.Drawing.Size(166, 38)
        Me.btnCambiarLogo.TabIndex = 22
        Me.btnCambiarLogo.Text = "Cambiar"
        Me.btnCambiarLogo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(59, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 164)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'btnCambiarUser
        '
        Me.btnCambiarUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnCambiarUser.FlatAppearance.BorderSize = 0
        Me.btnCambiarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarUser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarUser.ForeColor = System.Drawing.Color.White
        Me.btnCambiarUser.Image = Global.Scila7.My.Resources.Resources.edit_equalizer
        Me.btnCambiarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCambiarUser.Location = New System.Drawing.Point(455, 81)
        Me.btnCambiarUser.Name = "btnCambiarUser"
        Me.btnCambiarUser.Size = New System.Drawing.Size(112, 38)
        Me.btnCambiarUser.TabIndex = 24
        Me.btnCambiarUser.Text = "Cambiar"
        Me.btnCambiarUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCambiarUser.UseVisualStyleBackColor = False
        '
        'frmConfigPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(585, 304)
        Me.Controls.Add(Me.btnCambiarUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCambiarLogo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(EmpresaLabel1)
        Me.Controls.Add(Me.EmpresaTextBox)
        Me.Controls.Add(Me.PassLabel)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Name = "frmConfigPerfil"
        Me.Text = "Perfil"
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioLabel As System.Windows.Forms.Label
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigDataSet As Scila7.ConfigDataSet
    Friend WithEvents AdminTableAdapter As Scila7.ConfigDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents TableAdapterManager As Scila7.ConfigDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ConfigTableAdapter As Scila7.ConfigDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents AdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PassLabel As System.Windows.Forms.Label
    Friend WithEvents EmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As C1.Win.C1Input.C1Button
    Friend WithEvents btnCambiarLogo As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCambiarUser As System.Windows.Forms.Button
End Class
