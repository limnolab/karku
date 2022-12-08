Public Class frmRLP

    Private Sub ProyectosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProyectosBindingNavigatorSaveItem.Click
        GroupBox1.Enabled = False
        AmbienteTextBox.Text = "RLP"


        If Not BindingNavigatorMoveLastItem.Enabled = False Then
            Me.ProyectosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Scilla10DataSet)
        Else
            Me.ProyectosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Scilla10DataSet)

            'Recarga los adaptadores en frmRLP
            Me.ConfigTableAdapter.Fill(Me.ConfigDataSet.Config)
            Me.MuestrasTableAdapter.Fill(Me.Scilla10DataSet.Muestras)
            Me.ProyectosTableAdapter.qryProyectosByAmbiente(Me.Scilla10DataSet.Proyectos, "RLP")
            'me lleva al registro recien creado
            ProyectosDataGridView.CurrentCell = ProyectosDataGridView(0, ProyectosDataGridView.Rows.Count - 2)
        End If
    End Sub
    Private Sub frmArroyoPamp_Load_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Show()
    End Sub
    Private Sub frmRLP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConfigDataSet.Config' table. You can move, or remove it, as needed.
        Me.ConfigTableAdapter.Fill(Me.ConfigDataSet.Config)
        Me.MuestrasTableAdapter.Fill(Me.Scilla10DataSet.Muestras)
        Me.ProyectosTableAdapter.qryProyectosByAmbiente(Me.Scilla10DataSet.Proyectos, "RLP")
    End Sub


    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MessageBox.Show("Esta seguro de borrar este proyecto?", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.ProyectosBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.Scilla10DataSet)
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        GroupBox1.Enabled = True
    End Sub

    Private Sub BindingNavigatorEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEdit.Click
        GroupBox1.Enabled = True
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        'Necesita haber algun proyecto cargado
        If BindingNavigatorPositionItem.Enabled = False Then
            MsgBox("No hay ningún proyecto")
            Exit Sub
        Else
            If MuestrasDataGridView.RowCount = 0 Then
                If MsgBox("Este proyecto no tiene muestras, desea agregar una?", MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    frmMuestrasRLP.Show()
                    frmMuestrasRLP.MuestrasBindingSource.AddNew()
                    frmMuestrasRLP.IdProyectoTextBox.Text = IdProyectoTextBox.Text
                End If
            Else
                frmMuestrasRLP.Show()
                GroupBox1.Enabled = False
                ' Me.Hide()
            End If
        End If
    End Sub

    Private Sub SalirAWindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirAWindowsToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub EnciclopediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnciclopediaToolStripMenuItem.Click
        frmEnciclopedia.Show()
    End Sub
End Class
