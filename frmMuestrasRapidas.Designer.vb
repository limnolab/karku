<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuestrasRapidas
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
        Dim PanelElement1 As C1.Win.C1Tile.PanelElement = New C1.Win.C1Tile.PanelElement()
        Dim ImageElement1 As C1.Win.C1Tile.ImageElement = New C1.Win.C1Tile.ImageElement()
        Dim TextElement1 As C1.Win.C1Tile.TextElement = New C1.Win.C1Tile.TextElement()
        Me.TileMuestras = New C1.Win.C1Tile.C1TileControl()
        Me.Group1 = New C1.Win.C1Tile.Group()
        Me.SuspendLayout()
        '
        'TileMuestras
        '
        Me.TileMuestras.AllowChecking = True
        Me.TileMuestras.AllowRearranging = True
        Me.TileMuestras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TileMuestras.BackColor = System.Drawing.Color.White
        Me.TileMuestras.CellHeight = 60
        Me.TileMuestras.CellSpacing = 5
        Me.TileMuestras.CellWidth = 80
        Me.TileMuestras.CheckBorderColor = System.Drawing.Color.Gray
        '
        '
        '
        PanelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft
        PanelElement1.Children.Add(ImageElement1)
        PanelElement1.Children.Add(TextElement1)
        PanelElement1.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.TileMuestras.DefaultTemplate.Elements.Add(PanelElement1)
        Me.TileMuestras.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TileMuestras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TileMuestras.GroupFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileMuestras.GroupForeColor = System.Drawing.Color.Black
        Me.TileMuestras.GroupPadding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.TileMuestras.Groups.Add(Me.Group1)
        Me.TileMuestras.GroupSpacing = 30
        Me.TileMuestras.GroupTextBold = C1.Win.C1Tile.ThreeStateBoolean.[True]
        Me.TileMuestras.GroupTextY = 0
        Me.TileMuestras.HotBorderColor = System.Drawing.Color.Gray
        Me.TileMuestras.Location = New System.Drawing.Point(12, -1)
        Me.TileMuestras.Name = "TileMuestras"
        Me.TileMuestras.Size = New System.Drawing.Size(772, 564)
        Me.TileMuestras.SurfacePadding = New System.Windows.Forms.Padding(5, 5, 15, 5)
        Me.TileMuestras.TabIndex = 170
        Me.TileMuestras.Text = "Ingresar datos"
        Me.TileMuestras.TextSize = 16.0!
        Me.TileMuestras.TextX = 10
        Me.TileMuestras.TileBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TileMuestras.TileBorderColor = System.Drawing.Color.White
        '
        'Group1
        '
        Me.Group1.Name = "Group1"
        '
        'frmMuestrasRapidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.TileMuestras)
        Me.Name = "frmMuestrasRapidas"
        Me.Text = "Muestras Rápidas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileMuestras As C1.Win.C1Tile.C1TileControl
    Friend WithEvents Group1 As C1.Win.C1Tile.Group
End Class
