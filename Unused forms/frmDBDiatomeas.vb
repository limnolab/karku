Public Class frmDBDiatomeas
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Private Sub frmDBDiatomeas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim grabarmsj As Integer = MessageBox.Show("Desea grabar los cambios?", "Guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If grabarmsj = DialogResult.Cancel Then
            Exit Sub
        ElseIf grabarmsj = DialogResult.No Then
            Exit Sub
        ElseIf grabarmsj = DialogResult.Yes Then
            Me.TaxonesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DiatomeasDataSet)
        End If
    End Sub

    Public Sub RecibirVariables(ByVal treeviewtemp As TreeView)

        TreeView1.Nodes.Clear()
        For Each newNode As TreeNode In treeviewtemp.Nodes
            Dim cloneNode As New TreeNode
            cloneNode = newNode.Clone()
            TreeView1.Nodes.Add(cloneNode)
        Next

    End Sub


    Private Sub frmDBDiatomeas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConfigDataSet.Calculos' table. You can move, or remove it, as needed.
        Me.CalculosTableAdapter.Fill(Me.ConfigDataSet.Calculos)
        Me.TaxonesTableAdapter.Fill(Me.DiatomeasDataSet.Taxones)
    End Sub

    Private Sub TaxonesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxonesBindingNavigatorSaveItem.Click
        Me.TaxonesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiatomeasDataSet)
    End Sub

    Private Sub btnCambiarFoto_Click(sender As Object, e As EventArgs) Handles btnCambiarFoto.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            If (OpenFileDialog.FileName IsNot Nothing) Or (OpenFileDialog.FileName <> String.Empty) Then
                PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog.FileName)
                PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmbIndice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIndice.SelectedIndexChanged
        'CARGA LAS DB DE MODULOS 
        Dim moduloscon As New OleDb.OleDbConnection
        Dim modulosSQL As String

        Dim dbnombre As String = cmbIndice.SelectedValue
        Dim idcurrenttaxon As String = IdTaxonTextBox.Text

        moduloscon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\" & dbnombre & ".mdb"
        moduloscon.Open()

        Dim modulosds As New DataSet
        modulosSQL = "SELECT * FROM Carac" & dbnombre.ToUpper & " WHERE IdTaxon='" & idcurrenttaxon & "'"
        Dim modulosda = New OleDb.OleDbDataAdapter(modulosSQL, moduloscon)
        modulosda.Fill(modulosds, "TablaCarac")


        txtValorIndice.Text = modulosds.Tables("TablaCarac").Rows(0).Item("Valor").ToString


      moduloscon.Close()
    End Sub
End Class