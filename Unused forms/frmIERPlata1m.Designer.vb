<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIERPlata1m
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
        Dim DiatoDensidadLabel As System.Windows.Forms.Label
        Dim CianoDensidadLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.grpBiologicos = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TanaidsTextBox = New System.Windows.Forms.TextBox
        Me.FitoDensidadTextBox = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.DiatoDensidadTextBox = New System.Windows.Forms.TextBox
        Me.CianoDensidadTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnBorrarMuestra = New System.Windows.Forms.Button
        Me.MuestrasDataGrid = New System.Windows.Forms.DataGridView
        Me.Muestra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MuestraIERPlata = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombreMuestra = New System.Windows.Forms.TextBox
        Me.IndiceTextBox = New System.Windows.Forms.TextBox
        DiatoDensidadLabel = New System.Windows.Forms.Label
        CianoDensidadLabel = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Me.grpBiologicos.SuspendLayout()
        CType(Me.MuestrasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DiatoDensidadLabel
        '
        DiatoDensidadLabel.AutoSize = True
        DiatoDensidadLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        DiatoDensidadLabel.Location = New System.Drawing.Point(14, 58)
        DiatoDensidadLabel.Name = "DiatoDensidadLabel"
        DiatoDensidadLabel.Size = New System.Drawing.Size(164, 13)
        DiatoDensidadLabel.TabIndex = 38
        DiatoDensidadLabel.Text = "Diatomeas Muy Tolerantes:"
        '
        'CianoDensidadLabel
        '
        CianoDensidadLabel.AutoSize = True
        CianoDensidadLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        CianoDensidadLabel.Location = New System.Drawing.Point(14, 32)
        CianoDensidadLabel.Name = "CianoDensidadLabel"
        CianoDensidadLabel.Size = New System.Drawing.Size(170, 13)
        CianoDensidadLabel.TabIndex = 36
        CianoDensidadLabel.Text = "Densidad de Cyanobacteria:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Verdana", 8.25!)
        Label5.Location = New System.Drawing.Point(14, 109)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(99, 13)
        Label5.TabIndex = 88
        Label5.Text = "% Tanaidáceos:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Verdana", 8.25!)
        Label6.Location = New System.Drawing.Point(14, 83)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(188, 13)
        Label6.TabIndex = 86
        Label6.Text = "Densidad Total del fitoplancton:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(22, 26)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(140, 13)
        Label2.TabIndex = 70
        Label2.Text = "Nombre de la muestra:"
        '
        'grpBiologicos
        '
        Me.grpBiologicos.BackColor = System.Drawing.Color.White
        Me.grpBiologicos.Controls.Add(Me.Label3)
        Me.grpBiologicos.Controls.Add(Me.Label4)
        Me.grpBiologicos.Controls.Add(Me.TanaidsTextBox)
        Me.grpBiologicos.Controls.Add(Label5)
        Me.grpBiologicos.Controls.Add(Me.FitoDensidadTextBox)
        Me.grpBiologicos.Controls.Add(Label6)
        Me.grpBiologicos.Controls.Add(Me.Label14)
        Me.grpBiologicos.Controls.Add(Me.Label13)
        Me.grpBiologicos.Controls.Add(Me.DiatoDensidadTextBox)
        Me.grpBiologicos.Controls.Add(DiatoDensidadLabel)
        Me.grpBiologicos.Controls.Add(Me.CianoDensidadTextBox)
        Me.grpBiologicos.Controls.Add(CianoDensidadLabel)
        Me.grpBiologicos.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpBiologicos.Location = New System.Drawing.Point(22, 12)
        Me.grpBiologicos.Name = "grpBiologicos"
        Me.grpBiologicos.Size = New System.Drawing.Size(318, 137)
        Me.grpBiologicos.TabIndex = 62
        Me.grpBiologicos.TabStop = False
        Me.grpBiologicos.Text = "Datos biológicos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "cél/mL"
        '
        'TanaidsTextBox
        '
        Me.TanaidsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanaidsTextBox.Location = New System.Drawing.Point(204, 105)
        Me.TanaidsTextBox.Name = "TanaidsTextBox"
        Me.TanaidsTextBox.Size = New System.Drawing.Size(45, 20)
        Me.TanaidsTextBox.TabIndex = 4
        '
        'FitoDensidadTextBox
        '
        Me.FitoDensidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FitoDensidadTextBox.Location = New System.Drawing.Point(204, 79)
        Me.FitoDensidadTextBox.Name = "FitoDensidadTextBox"
        Me.FitoDensidadTextBox.Size = New System.Drawing.Size(45, 20)
        Me.FitoDensidadTextBox.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(255, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(255, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "cél/mL"
        '
        'DiatoDensidadTextBox
        '
        Me.DiatoDensidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiatoDensidadTextBox.Location = New System.Drawing.Point(204, 54)
        Me.DiatoDensidadTextBox.Name = "DiatoDensidadTextBox"
        Me.DiatoDensidadTextBox.Size = New System.Drawing.Size(45, 20)
        Me.DiatoDensidadTextBox.TabIndex = 2
        '
        'CianoDensidadTextBox
        '
        Me.CianoDensidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CianoDensidadTextBox.Location = New System.Drawing.Point(204, 28)
        Me.CianoDensidadTextBox.Name = "CianoDensidadTextBox"
        Me.CianoDensidadTextBox.Size = New System.Drawing.Size(45, 20)
        Me.CianoDensidadTextBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(461, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 67
        Me.Button1.TabStop = False
        Me.Button1.Text = "Exportar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBorrarMuestra
        '
        Me.btnBorrarMuestra.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBorrarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarMuestra.Location = New System.Drawing.Point(346, 381)
        Me.btnBorrarMuestra.Name = "btnBorrarMuestra"
        Me.btnBorrarMuestra.Size = New System.Drawing.Size(98, 23)
        Me.btnBorrarMuestra.TabIndex = 66
        Me.btnBorrarMuestra.TabStop = False
        Me.btnBorrarMuestra.Text = "Borrar muestra"
        Me.btnBorrarMuestra.UseVisualStyleBackColor = True
        '
        'MuestrasDataGrid
        '
        Me.MuestrasDataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.MuestrasDataGrid.AllowUserToAddRows = False
        Me.MuestrasDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.MuestrasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Muestra, Me.MuestraIERPlata})
        Me.MuestrasDataGrid.Location = New System.Drawing.Point(346, 20)
        Me.MuestrasDataGrid.Name = "MuestrasDataGrid"
        Me.MuestrasDataGrid.ReadOnly = True
        Me.MuestrasDataGrid.RowHeadersVisible = False
        Me.MuestrasDataGrid.Size = New System.Drawing.Size(205, 355)
        Me.MuestrasDataGrid.TabIndex = 65
        Me.MuestrasDataGrid.TabStop = False
        '
        'Muestra
        '
        Me.Muestra.HeaderText = "Muestra"
        Me.Muestra.Name = "Muestra"
        Me.Muestra.ReadOnly = True
        '
        'MuestraIERPlata
        '
        Me.MuestraIERPlata.HeaderText = "IBIDPlata"
        Me.MuestraIERPlata.Name = "MuestraIERPlata"
        Me.MuestraIERPlata.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombreMuestra)
        Me.GroupBox1.Controls.Add(Me.IndiceTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 116)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "IBIDPlata:"
        Me.Label1.Visible = False
        '
        'txtNombreMuestra
        '
        Me.txtNombreMuestra.Location = New System.Drawing.Point(173, 19)
        Me.txtNombreMuestra.Name = "txtNombreMuestra"
        Me.txtNombreMuestra.Size = New System.Drawing.Size(100, 24)
        Me.txtNombreMuestra.TabIndex = 5
        '
        'IndiceTextBox
        '
        Me.IndiceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndiceTextBox.Location = New System.Drawing.Point(102, 53)
        Me.IndiceTextBox.Name = "IndiceTextBox"
        Me.IndiceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IndiceTextBox.TabIndex = 72
        Me.IndiceTextBox.TabStop = False
        Me.IndiceTextBox.Visible = False
        '
        'frmIERPlata1m
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 420)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBorrarMuestra)
        Me.Controls.Add(Me.MuestrasDataGrid)
        Me.Controls.Add(Me.grpBiologicos)
        Me.Name = "frmIERPlata1m"
        Me.Text = "Karku - Cálculo del IBIDPlata"
        Me.grpBiologicos.ResumeLayout(False)
        Me.grpBiologicos.PerformLayout()
        CType(Me.MuestrasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBiologicos As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DiatoDensidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CianoDensidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBorrarMuestra As System.Windows.Forms.Button
    Friend WithEvents MuestrasDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IndiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TanaidsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FitoDensidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Muestra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MuestraIERPlata As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNombreMuestra As System.Windows.Forms.TextBox
End Class
