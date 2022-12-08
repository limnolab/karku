Public Class frmDBMacroInvertebrados
    'DECLARO VARIABLES PARA CONSTRUIR ARBOL DE TAXONES
    Dim nombrepadre
    Dim nombrehijo
    Dim taxonyaesta As Boolean

    Private Sub TaxonesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxonesBindingNavigatorSaveItem.Click
        Me.TaxonesBindingSource.EndEdit()
        Me.TaxonesTableAdapter.Update(Me.MacroinvertebradosDataSet.Taxones)
        Dim taxonactualindex As Integer
        taxonactualindex = TaxonesDataGridView.CurrentRow.Index
        Me.TaxonesTableAdapter.Fill(Me.MacroinvertebradosDataSet.Taxones)
        TaxonesDataGridView.CurrentCell = TaxonesDataGridView(0, taxonactualindex)
        TreeView1.Enabled = True
    End Sub

    Private Sub frmDBMacroInvertebrados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim grabarmsj As Integer = MessageBox.Show("Desea grabar los cambios?", "Guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If grabarmsj = DialogResult.Cancel Then
            Exit Sub
        ElseIf grabarmsj = DialogResult.No Then
            Exit Sub
        ElseIf grabarmsj = DialogResult.Yes Then
            Me.TaxonesBindingSource.EndEdit()
            Me.TaxonesTableAdapter.Update(Me.MacroinvertebradosDataSet.Taxones)

            ' RECARGA EL ARBOL ANTES DE CERRALO PARA ACTUALIZARLO
            TreeView1.Enabled = False
            TreeView1.Visible = False
            TreeView1.Nodes.Clear()
            Dim dt As DataTable = MacroinvertebradosDataSet.Taxones
            ArmarArbol(TreeView1, dt)
            TreeView1.Enabled = True

            ' CUANDO SE CIERRA, RECARGA LOS ARBOLES DE MACROINV EN PRINCIPAL Y MACROINV
            frmPrincipal.RecargarArbolTaxones("treeviewmacroinvertebrados", Me.TreeView1)
            frmDatosTaxones.RecargarArbolTaxones("TreeView1", Me.TreeView1)

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

    Private Sub frmDBMacroInvertebrados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MacroinvertebradosDataSet.Taxones' table. You can move, or remove it, as needed.
        Me.TaxonesTableAdapter.Fill(Me.MacroinvertebradosDataSet.Taxones)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TreeView1.Enabled = False
        TreeView1.Nodes.Clear()
        Dim dt As DataTable = MacroinvertebradosDataSet.Taxones
        ArmarArbol(TreeView1, dt)
        TreeView1.Enabled = True
    End Sub

    '    ////////////////////////////////////////////////////////////////
    '    ////
    '    //// MODIFICAR TAXON PADRE (4 subs)
    '    ////
    '    ////////////////////////////////////////////////////////////////

    Private Sub CategoriaPadreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaPadreComboBox.SelectedIndexChanged
        If Me.Visible = True Then
            CategoriaPadreTextBox.Text = CategoriaPadreComboBox.Text
        End If
    End Sub
    Private Sub btnCambiarPadre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarPadre.Click
        Me.TaxonesBindingSource.EndEdit()
        Me.TaxonesTableAdapter.Update(Me.MacroinvertebradosDataSet.Taxones)
        Dim taxonactualindex As Integer
        taxonactualindex = TaxonesDataGridView.CurrentRow.Index
        Me.TaxonesTableAdapter.Fill(Me.MacroinvertebradosDataSet.Taxones)
        TaxonesDataGridView.CurrentCell = TaxonesDataGridView(0, taxonactualindex)
        TreeView1.Enabled = True

        CategoriaPadreComboBox.Visible = True
        CategoriaPadreTextBox.Visible = False
        btnGuardarPadre.Visible = True
        btnLimpiarPadre.Visible = True
        btnCambiarPadre.Visible = False
    End Sub

    Private Sub btnGuardarPadre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPadre.Click
        TaxonesBindingSource.EndEdit()
        TaxonesTableAdapter.Update(MacroinvertebradosDataSet.Taxones)
        CategoriaPadreComboBox.Visible = False
        CategoriaPadreTextBox.Visible = True
        btnCambiarPadre.Visible = True
        btnGuardarPadre.Visible = False
        btnLimpiarPadre.Visible = False
    End Sub

    Private Sub btnLimpiarPadre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarPadre.Click
        CategoriaPadreTextBox.Text = ""
        TaxonesBindingSource.EndEdit()
        TaxonesTableAdapter.Update(MacroinvertebradosDataSet.Taxones)
        CategoriaPadreComboBox.Visible = False
        CategoriaPadreTextBox.Visible = True
        btnCambiarPadre.Visible = True
        btnGuardarPadre.Visible = False
        btnLimpiarPadre.Visible = False
    End Sub

    '    ////////////////////////////////////////////////////////////////
    '    ////
    '    //// MOVER BINDINGSOURSE DE TAXONES
    '    ////
    '    ////////////////////////////////////////////////////////////////


    Private Sub TaxonesBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TaxonesBindingSource.PositionChanged
        If TreeView1.Enabled = True Then


            If btnGuardarPadre.Visible = True Then
                CategoriaPadreComboBox.Visible = False
                CategoriaPadreTextBox.Enabled = False
                TaxonesBindingSource.EndEdit()
                TaxonesTableAdapter.Update(MacroinvertebradosDataSet.Taxones)
                btnCambiarPadre.Visible = True
                btnGuardarPadre.Visible = False
                btnLimpiarPadre.Visible = False
            End If
            'BUSCA CADA INDICE PARA ESTE TAXON
            Dim idtaxon As String = IdTaxonTextBox.Text
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim taxonseleccionado As String
        Dim i As Integer
        If TreeView1.Enabled = True Then
            taxonseleccionado = TreeView1.SelectedNode.Text
            TaxonesDataGridView.ClearSelection()

            For i = 0 To TaxonesDataGridView.RowCount - 2
                If TaxonesDataGridView.Item(2, i).Value.ToString = taxonseleccionado Then
                    TaxonesDataGridView.CurrentCell = TaxonesDataGridView.Rows(i).Cells(1)
                    TaxonesDataGridView.Rows(i).Selected = True
                End If
            Next i
        End If
    End Sub

    Private Sub TaxonesDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TaxonesDataGridView.CellClick
        '// CARGA LA FOTO DEL TAXON SELECCIONADO
        Dim i As Integer = TaxonesDataGridView.CurrentRow.Index
        TaxonesDataGridView.Rows(i).Selected = True
        Dim nombretaxon As String = TaxonesDataGridView.Item(2, i).Value.ToString

        '// BUSCO EL TAXON EN EL ARBOL Y LO SELECCIONO
        Dim tnlength As String
        tnlength = TreeView1.GetNodeCount(True)
        If tnlength <> 0 Then
            Dim tn() As TreeNode = TreeView1.Nodes(0).Nodes.Find(nombretaxon, True)
            TreeView1.SelectedNode = tn(0)
            TreeView1.Focus()
        End If
    End Sub

    Private Sub btnCambiarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarFoto.Click

    End Sub

    Private Sub btnEditarIndices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarIndices.Click
        grpIndices.Enabled = True
        btnEditarIndices.Visible = False
        btnGuardarIndices.Visible = True
    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        TreeView1.Enabled = False
    End Sub
End Class