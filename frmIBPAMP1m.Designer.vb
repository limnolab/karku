<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIBPAMP1m
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
        Dim Cat1Label As System.Windows.Forms.Label
        Dim Cat2Label As System.Windows.Forms.Label
        Dim Cat3Label As System.Windows.Forms.Label
        Dim Cat4Label As System.Windows.Forms.Label
        Dim Cat5Label As System.Windows.Forms.Label
        Dim Cat6Label As System.Windows.Forms.Label
        Dim Cat7Label As System.Windows.Forms.Label
        Dim IndiceLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIBPAMP1m))
        Me.IBPAMPTableAdapter = New Scila7.Scilla10DataSetTableAdapters.IBPAMPTableAdapter
        Me.Cat1TextBox = New System.Windows.Forms.TextBox
        Me.Cat2TextBox = New System.Windows.Forms.TextBox
        Me.Cat3TextBox = New System.Windows.Forms.TextBox
        Me.Cat4TextBox = New System.Windows.Forms.TextBox
        Me.Cat5TextBox = New System.Windows.Forms.TextBox
        Me.Cat6TextBox = New System.Windows.Forms.TextBox
        Me.Cat7TextBox = New System.Windows.Forms.TextBox
        Me.IBPAMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAgregar = New C1.Win.C1Input.C1Button
        Me.IndiceTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.C1Button1 = New C1.Win.C1Input.C1Button
        Me.txtNombreMuestra = New System.Windows.Forms.TextBox
        Me.Significa = New System.Windows.Forms.Button
        Me.tmrCheckIndices = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnBorrarMuestra = New System.Windows.Forms.Button
        Me.MuestrasDataGrid = New System.Windows.Forms.DataGridView
        Me.Muestra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MuestraIBPAMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Cat1Label = New System.Windows.Forms.Label
        Cat2Label = New System.Windows.Forms.Label
        Cat3Label = New System.Windows.Forms.Label
        Cat4Label = New System.Windows.Forms.Label
        Cat5Label = New System.Windows.Forms.Label
        Cat6Label = New System.Windows.Forms.Label
        Cat7Label = New System.Windows.Forms.Label
        IndiceLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MuestrasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cat1Label
        '
        Cat1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cat1Label.Location = New System.Drawing.Point(24, 22)
        Cat1Label.Name = "Cat1Label"
        Cat1Label.Size = New System.Drawing.Size(126, 32)
        Cat1Label.TabIndex = 9
        Cat1Label.Text = "Trichoptera con estuche (Leptoceridae)"
        '
        'Cat2Label
        '
        Cat2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cat2Label.Location = New System.Drawing.Point(24, 56)
        Cat2Label.Name = "Cat2Label"
        Cat2Label.Size = New System.Drawing.Size(126, 39)
        Cat2Label.TabIndex = 11
        Cat2Label.Text = "Otros Trichoptera Lestidae, Elmidae, Gomphidae, Unionidae"
        '
        'Cat3Label
        '
        Cat3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cat3Label.Location = New System.Drawing.Point(24, 106)
        Cat3Label.Name = "Cat3Label"
        Cat3Label.Size = New System.Drawing.Size(122, 30)
        Cat3Label.TabIndex = 13
        Cat3Label.Text = "Ancylidae, Decapoda, Aeshnidae, Simuliidae"
        '
        'Cat4Label
        '
        Cat4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cat4Label.Location = New System.Drawing.Point(24, 142)
        Cat4Label.Name = "Cat4Label"
        Cat4Label.Size = New System.Drawing.Size(151, 46)
        Cat4Label.TabIndex = 15
        Cat4Label.Text = "Otros Coleoptera Ephemeroptera (exceptuados los Caenidae), Libellulidae"
        '
        'Cat5Label
        '
        Cat5Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cat5Label.Location = New System.Drawing.Point(24, 194)
        Cat5Label.Name = "Cat5Label"
        Cat5Label.Size = New System.Drawing.Size(139, 26)
        Cat5Label.TabIndex = 17
        Cat5Label.Text = "Coenagrionidae, Caenidae, Heteroptera, Amphipoda"
        '
        'Cat6Label
        '
        Cat6Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cat6Label.Location = New System.Drawing.Point(24, 230)
        Cat6Label.Name = "Cat6Label"
        Cat6Label.Size = New System.Drawing.Size(151, 39)
        Cat6Label.TabIndex = 19
        Cat6Label.Text = "Tubificinae, Hirudinea Chironomidae rojos, Physidae, Culicidae"
        '
        'Cat7Label
        '
        Cat7Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cat7Label.Location = New System.Drawing.Point(24, 280)
        Cat7Label.Name = "Cat7Label"
        Cat7Label.Size = New System.Drawing.Size(151, 32)
        Cat7Label.TabIndex = 21
        Cat7Label.Text = "Syrphidae, Enchitreidae, Psychodidae"
        '
        'IndiceLabel
        '
        IndiceLabel.AutoSize = True
        IndiceLabel.Location = New System.Drawing.Point(4, 35)
        IndiceLabel.Name = "IndiceLabel"
        IndiceLabel.Size = New System.Drawing.Size(48, 17)
        IndiceLabel.TabIndex = 29
        IndiceLabel.Text = "Indice:"
        IndiceLabel.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(26, 31)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(151, 13)
        NombreLabel.TabIndex = 30
        NombreLabel.Text = "Unidades Sistemáticas totales:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(6, 68)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(143, 17)
        Label3.TabIndex = 53
        Label3.Text = "Nombre de la muestra:"
        '
        'IBPAMPTableAdapter
        '
        Me.IBPAMPTableAdapter.ClearBeforeFill = True
        '
        'Cat1TextBox
        '
        Me.Cat1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat1TextBox.Location = New System.Drawing.Point(230, 22)
        Me.Cat1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat1TextBox.Name = "Cat1TextBox"
        Me.Cat1TextBox.Size = New System.Drawing.Size(28, 20)
        Me.Cat1TextBox.TabIndex = 2
        '
        'Cat2TextBox
        '
        Me.Cat2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat2TextBox.Location = New System.Drawing.Point(230, 61)
        Me.Cat2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat2TextBox.Name = "Cat2TextBox"
        Me.Cat2TextBox.Size = New System.Drawing.Size(28, 20)
        Me.Cat2TextBox.TabIndex = 3
        '
        'Cat3TextBox
        '
        Me.Cat3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat3TextBox.Location = New System.Drawing.Point(230, 104)
        Me.Cat3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat3TextBox.Name = "Cat3TextBox"
        Me.Cat3TextBox.Size = New System.Drawing.Size(28, 20)
        Me.Cat3TextBox.TabIndex = 4
        '
        'Cat4TextBox
        '
        Me.Cat4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat4TextBox.Location = New System.Drawing.Point(230, 145)
        Me.Cat4TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat4TextBox.Name = "Cat4TextBox"
        Me.Cat4TextBox.Size = New System.Drawing.Size(28, 20)
        Me.Cat4TextBox.TabIndex = 5
        '
        'Cat5TextBox
        '
        Me.Cat5TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat5TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat5TextBox.Location = New System.Drawing.Point(230, 191)
        Me.Cat5TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat5TextBox.Name = "Cat5TextBox"
        Me.Cat5TextBox.Size = New System.Drawing.Size(28, 20)
        Me.Cat5TextBox.TabIndex = 6
        '
        'Cat6TextBox
        '
        Me.Cat6TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat6TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat6TextBox.Location = New System.Drawing.Point(230, 233)
        Me.Cat6TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat6TextBox.Name = "Cat6TextBox"
        Me.Cat6TextBox.Size = New System.Drawing.Size(28, 20)
        Me.Cat6TextBox.TabIndex = 7
        '
        'Cat7TextBox
        '
        Me.Cat7TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cat7TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat7TextBox.Location = New System.Drawing.Point(230, 278)
        Me.Cat7TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cat7TextBox.Name = "Cat7TextBox"
        Me.Cat7TextBox.Size = New System.Drawing.Size(28, 20)
        Me.Cat7TextBox.TabIndex = 8
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.Location = New System.Drawing.Point(7, 100)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(144, 46)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Calcular IBPAMP"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'IndiceTextBox
        '
        Me.IndiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IBPAMPBindingSource, "Indice", True))
        Me.IndiceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndiceTextBox.Location = New System.Drawing.Point(48, 28)
        Me.IndiceTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IndiceTextBox.Name = "IndiceTextBox"
        Me.IndiceTextBox.Size = New System.Drawing.Size(103, 23)
        Me.IndiceTextBox.TabIndex = 30
        Me.IndiceTextBox.TabStop = False
        Me.IndiceTextBox.Visible = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(230, 28)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(27, 20)
        Me.NombreTextBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Cat1Label)
        Me.GroupBox1.Controls.Add(Me.Cat7TextBox)
        Me.GroupBox1.Controls.Add(Cat7Label)
        Me.GroupBox1.Controls.Add(Me.Cat6TextBox)
        Me.GroupBox1.Controls.Add(Cat6Label)
        Me.GroupBox1.Controls.Add(Me.Cat5TextBox)
        Me.GroupBox1.Controls.Add(Cat5Label)
        Me.GroupBox1.Controls.Add(Me.Cat4TextBox)
        Me.GroupBox1.Controls.Add(Cat4Label)
        Me.GroupBox1.Controls.Add(Me.Cat3TextBox)
        Me.GroupBox1.Controls.Add(Cat3Label)
        Me.GroupBox1.Controls.Add(Me.Cat2TextBox)
        Me.GroupBox1.Controls.Add(Cat2Label)
        Me.GroupBox1.Controls.Add(Me.Cat1TextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 77)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(309, 338)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "2 - Detalle Unidades Sistemáticas"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.Scila7.My.Resources.Resources.logoKerku
        Me.PictureBox1.Location = New System.Drawing.Point(368, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 271)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(NombreLabel)
        Me.GroupBox2.Controls.Add(Me.NombreTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(309, 59)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "1 - Ingresar Unidades Sistemáticas totales"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(702, 43)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(218, 292)
        Me.RichTextBox1.TabIndex = 35
        Me.RichTextBox1.TabStop = False
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(710, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Taxa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(816, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Unidad Sistemática"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.C1Button1)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Me.txtNombreMuestra)
        Me.GroupBox3.Controls.Add(Me.Significa)
        Me.GroupBox3.Controls.Add(Me.IndiceTextBox)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Controls.Add(IndiceLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(368, 294)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(281, 152)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "3 - Calcular IBPAMP"
        '
        'C1Button1
        '
        Me.C1Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.C1Button1.FlatAppearance.BorderSize = 2
        Me.C1Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1Button1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Button1.Location = New System.Drawing.Point(157, 100)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(118, 46)
        Me.C1Button1.TabIndex = 69
        Me.C1Button1.TabStop = False
        Me.C1Button1.Text = "Cerrar"
        Me.C1Button1.UseVisualStyleBackColor = True
        '
        'txtNombreMuestra
        '
        Me.txtNombreMuestra.Location = New System.Drawing.Point(155, 63)
        Me.txtNombreMuestra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreMuestra.Name = "txtNombreMuestra"
        Me.txtNombreMuestra.Size = New System.Drawing.Size(118, 24)
        Me.txtNombreMuestra.TabIndex = 9
        '
        'Significa
        '
        Me.Significa.BackColor = System.Drawing.Color.LightGray
        Me.Significa.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Significa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Significa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Significa.Location = New System.Drawing.Point(155, 28)
        Me.Significa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Significa.Name = "Significa"
        Me.Significa.Size = New System.Drawing.Size(118, 22)
        Me.Significa.TabIndex = 68
        Me.Significa.TabStop = False
        Me.Significa.Text = "Clase V"
        Me.Significa.UseVisualStyleBackColor = False
        Me.Significa.Visible = False
        '
        'tmrCheckIndices
        '
        Me.tmrCheckIndices.Enabled = True
        Me.tmrCheckIndices.Interval = 10
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1053, 489)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 22)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Exportar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBorrarMuestra
        '
        Me.btnBorrarMuestra.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBorrarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarMuestra.Location = New System.Drawing.Point(938, 489)
        Me.btnBorrarMuestra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrarMuestra.Name = "btnBorrarMuestra"
        Me.btnBorrarMuestra.Size = New System.Drawing.Size(98, 22)
        Me.btnBorrarMuestra.TabIndex = 50
        Me.btnBorrarMuestra.TabStop = False
        Me.btnBorrarMuestra.Text = "Borrar muestra"
        Me.btnBorrarMuestra.UseVisualStyleBackColor = True
        '
        'MuestrasDataGrid
        '
        Me.MuestrasDataGrid.AllowUserToAddRows = False
        Me.MuestrasDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.MuestrasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuestrasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Muestra, Me.MuestraIBPAMP})
        Me.MuestrasDataGrid.Location = New System.Drawing.Point(938, 12)
        Me.MuestrasDataGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MuestrasDataGrid.Name = "MuestrasDataGrid"
        Me.MuestrasDataGrid.ReadOnly = True
        Me.MuestrasDataGrid.RowHeadersVisible = False
        Me.MuestrasDataGrid.Size = New System.Drawing.Size(205, 469)
        Me.MuestrasDataGrid.TabIndex = 49
        Me.MuestrasDataGrid.TabStop = False
        '
        'Muestra
        '
        Me.Muestra.HeaderText = "Muestra"
        Me.Muestra.Name = "Muestra"
        Me.Muestra.ReadOnly = True
        '
        'MuestraIBPAMP
        '
        Me.MuestraIBPAMP.HeaderText = "IBPAMP"
        Me.MuestraIBPAMP.Name = "MuestraIBPAMP"
        Me.MuestraIBPAMP.ReadOnly = True
        '
        'frmIBPAMP1m
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1155, 516)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBorrarMuestra)
        Me.Controls.Add(Me.MuestrasDataGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmIBPAMP1m"
        Me.Text = "Karku - Calcular IBPAMP"
        CType(Me.IBPAMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.MuestrasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IBPAMPTableAdapter As Scila7.Scilla10DataSetTableAdapters.IBPAMPTableAdapter
    Friend WithEvents Cat1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat6TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat7TextBox As System.Windows.Forms.TextBox
    Friend WithEvents IBPAMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAgregar As C1.Win.C1Input.C1Button
    Friend WithEvents IndiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Significa As System.Windows.Forms.Button
    Friend WithEvents tmrCheckIndices As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBorrarMuestra As System.Windows.Forms.Button
    Friend WithEvents MuestrasDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Muestra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MuestraIBPAMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNombreMuestra As System.Windows.Forms.TextBox
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
End Class
