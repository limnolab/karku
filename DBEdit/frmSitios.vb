Public Class frmSitios

    Private Sub SitiosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SitiosBindingNavigatorSaveItem.Click
        Me.SitiosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SitiosDataSet)

    End Sub

    Private Sub frmSitios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.SitiosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SitiosDataSet)

    End Sub


    Private Sub frmSitios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SitiosTableAdapter.Fill(Me.SitiosDataSet.Sitios)
    End Sub

End Class