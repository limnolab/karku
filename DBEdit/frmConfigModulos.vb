Public Class frmConfigModulos

    Private Sub ModulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ModulosBindingSource.EndEdit()
    End Sub

    Private Sub frmConfigModulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Modificaciones en la configuración de módulos pueden resultar en un mal funcionamiento del software!", MsgBoxStyle.Exclamation, "Cuidado!")

        Me.CalculosTableAdapter.Fill(Me.ConfigDataSet.Calculos)
        Me.ModulosTableAdapter.Fill(Me.ConfigDataSet.Modulos)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        For i As Integer = 2 To ModulosDataGridView.Columns.Count - 1
            ModulosDataGridView.Columns(i).ReadOnly = True
            ModulosDataGridView.Columns(i).DefaultCellStyle.BackColor = Color.White
        Next

        For i = 2 To CalculosDataGridView.Columns.Count - 1
            CalculosDataGridView.Columns(i).ReadOnly = True
            CalculosDataGridView.Columns(i).DefaultCellStyle.BackColor = Color.White
        Next
        ModulosBindingSource.EndEdit()
        CalculosBindingSource.EndEdit()
        ModulosTableAdapter.Update(ConfigDataSet.Modulos)
        CalculosTableAdapter.Update(ConfigDataSet.Calculos)

    End Sub

    Private Sub btnEditarModulos_Click(sender As Object, e As EventArgs) Handles btnEditarModulos.Click
        For i As Integer = 0 To ModulosDataGridView.Columns.Count - 1
            ModulosDataGridView.Columns(i).ReadOnly = False
            ModulosDataGridView.Columns(i).DefaultCellStyle.BackColor = Color.FromArgb(23, 108, 156)
        Next
    End Sub

    Private Sub btnEditarCalculos_Click(sender As Object, e As EventArgs) Handles btnEditarCalculos.Click
        For i As Integer = 0 To CalculosDataGridView.Columns.Count - 1
            CalculosDataGridView.Columns(i).ReadOnly = False
            CalculosDataGridView.Columns(i).DefaultCellStyle.BackColor = Color.FromArgb(23, 108, 156)
        Next
    End Sub
End Class