Public Class frmMuestrasRLP
    Dim idproyecto As Integer = Convert.ToInt32(frmRLP.IdProyectoTextBox.Text)

    Private Sub frmMuestrasRLP_Load_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Desea grabar al salir?", "Grabar?", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
            IdProyectoTextBox.Text = idproyecto
            MuestrasBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Scilla10DataSet)
        ElseIf Windows.Forms.DialogResult.No Then
        ElseIf Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMuestrasRLP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConfigDataSet.Config' table. You can move, or remove it, as needed.
        Me.ConfigTableAdapter.Fill(Me.ConfigDataSet.Config)
        ' Me.IMRPlataTableAdapter.Fill(Me.Scilla10DataSet.IMRPlata)

        'CARGA MUESTRAS POR PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If Not BindingNavigatorMoveLastItem.Enabled = False Then
            IdProyectoTextBox.Text = idproyecto
            MuestrasBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Scilla10DataSet)
        Else
            IdProyectoTextBox.Text = frmRLP.IdProyectoTextBox.Text
            MuestrasBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Scilla10DataSet)

            'Recarga los adaptadores en frmRLP
            frmRLP.ProyectosTableAdapter.qryProyectosByID(frmRLP.Scilla10DataSet.Proyectos, idproyecto)
            frmRLP.MuestrasTableAdapter.qryMuestrasByProyecto(frmRLP.Scilla10DataSet.Muestras, idproyecto)
            ' Recarga los adaptadores en este form
            Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
            'Habilita los indices
            grpIndices.Enabled = True
            'me lleva al registro recien creado
            MuestrasDataGridView.CurrentCell = MuestrasDataGridView(0, MuestrasDataGridView.Rows.Count - 2)
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If Not MuestrasDataGridView.RowCount = 1 Then
            If MessageBox.Show("Esta seguro de eliminar esta muestra?", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Me.MuestrasBindingSource.RemoveCurrent()
                Me.TableAdapterManager.UpdateAll(Me.Scilla10DataSet)
                Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
                'Recarga los adaptadores en frmRLP
                frmRLP.ProyectosTableAdapter.qryProyectosByID(frmRLP.Scilla10DataSet.Proyectos, idproyecto)
                frmRLP.MuestrasTableAdapter.qryMuestrasByProyecto(frmRLP.Scilla10DataSet.Muestras, idproyecto)
            End If
        Else
            MsgBox("No hay muestras en este proyecto")
        End If

    End Sub

    Private Sub btnCalcularIBIDPlata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularIBIDPlata.Click
        If IEcoPlataSignifica.Text <> "" Then
            CalcularIBIDPlata()
        End If
    End Sub

 
    Private Sub CalcularIBIDPlata()
        Dim dencyano As Integer = Val(CianoDensidadTextBox.Text)
        Dim totalphyto As Integer = Val(FitoTotalTextBox.Text)
        Dim mtdiatoms As Integer = Val(DiatoDensidadTextBox.Text)
        Dim tanaids As Integer = Val(TanaidsTextBox.Text)
        Dim dencyanoumbral As Integer
        Dim totalphytoumbral As Integer
        Dim mtdiatomsumbral As Integer
        Dim tanaidsumbral As Integer
        Dim IBIDPlatavalue As Integer

        'Umbrales para Cyano
        dencyanoumbral = ((dencyano - 25000) / (0 - 25000)) * 10
        If dencyanoumbral > 10 Then
            dencyanoumbral = 10
        ElseIf dencyanoumbral < 0 Then
            dencyanoumbral = 0
        End If

        'Umbrales para FitoTotal
        totalphytoumbral = ((totalphyto - 80000) / (30 - 80000)) * 10
        If totalphytoumbral > 10 Then
            totalphytoumbral = 10
        ElseIf totalphytoumbral < 0 Then
            totalphytoumbral = 0
        End If

        'Umbrales para DiatomMT
        mtdiatomsumbral = ((mtdiatoms - 40) / (1 - 40)) * 10
        If mtdiatomsumbral > 10 Then
            mtdiatomsumbral = 10
        ElseIf mtdiatomsumbral < 0 Then
            mtdiatomsumbral = 0
        End If

        'Umbrales para Tanaids
        tanaidsumbral = ((tanaids - 0) / (25 - 0)) * 10
        If tanaidsumbral > 10 Then
            tanaidsumbral = 10
        ElseIf tanaidsumbral < 0 Then
            tanaidsumbral = 0
        End If

        'CALCULO EL IBIRPLATA
        IBIDPlatavalue = (dencyanoumbral + totalphytoumbral + mtdiatomsumbral + tanaidsumbral) / 4

        'CARGO EL IBIDPLATA A LAS BASES DE DATOS
        IBIDPlataTextBox.Text = IBIDPlatavalue
        MuestrasBindingSource.EndEdit()
        MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

    End Sub
    Private Sub tmrCheckIndices_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckIndices.Tick
        'REVISA PARA EL IBIDPlata
        If CianoDensidadTextBox.Text = "" Or FitoTotalTextBox.Text = "" Or TanaidsTextBox.Text = "" Or DiatoDensidadTextBox.Text = "" Then
            IEcoPlataSignifica.Text = ""
            IEcoPlataSignifica.BackColor = Color.LightGray
        Else
            IEcoPlataSignifica.Enabled = True
            If IBIDPlataTextBox.Text = "" Then
                IEcoPlataSignifica.Text = "Se calculará"
            Else
                IEcoPlataSignificado()
            End If
        End If
    End Sub
    Private Sub IEcoPlataSignificado()
        Dim indicecolor As Integer
        If IBIDPlataTextBox.Text <> "" Then
            indicecolor = Val(IBIDPlataTextBox.Text)
        Else
            IEcoPlataSignifica.Text = ""
            IEcoPlataSignifica.BackColor = Color.Gray
        End If
        If indicecolor >= 0 And indicecolor < 2 Then
            IEcoPlataSignifica.Text = "Mala"
            IEcoPlataSignifica.BackColor = Color.Red
        End If
        If indicecolor >= 1 And indicecolor < 4 Then
            IEcoPlataSignifica.Text = "Pobre"
            IEcoPlataSignifica.BackColor = Color.Orange
        End If
        If indicecolor >= 4 And indicecolor < 6 Then
            IEcoPlataSignifica.Text = "Aceptable"
            IEcoPlataSignifica.BackColor = Color.Yellow
        End If
        If indicecolor >= 6 And indicecolor < 8 Then
            IEcoPlataSignifica.Text = "Buena"
            IEcoPlataSignifica.BackColor = Color.Green
        End If
        If indicecolor >= 8 And indicecolor <= 10 Then
            IEcoPlataSignifica.Text = "Muy Buena"
            IEcoPlataSignifica.BackColor = Color.Blue
        End If
    End Sub

    Private Sub CheckFQ()
        Dim FQgeneral As Integer
        Dim phvalue As Integer = Val(FQpHTextBox.Text)
        Dim tempvalue As Integer = Val(FQTempTextBox.Text)
        Dim condvalue As Integer = Val(FQCondTextBox.Text)
        Dim turbvalue As Integer = Val(FQTurbTextBox.Text)
        Dim caudalvalue As Integer = Val(FQCaudalTextBox.Text)
        Dim odvalue As Integer = Val(FQODTextBox.Text)
        Dim dbovalue As Integer = Val(FQBODTextBox.Text)

        Dim no3value As Integer = Val(FQNitratosTextBox.Text)
        Dim no2value As Integer = Val(FQNitritosTextBox.Text)
        Dim nh4value As Integer = Val(FQAmonioTextBox.Text)
        Dim po4value As Integer = Val(FQFosfatoTextBox.Text)

        progHabitatGeneral.Value = FQgeneral
        If FQgeneral > 80 Then
            txtEstadoHabitat.Text = "Muy bueno"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es muy bueno. Hay buena conectividad entre el río y la costa, buena vegetación ripariana, etc."
            txtEstadoHabitat.BackColor = Color.Blue
        ElseIf FQgeneral < 80 And FQgeneral > 60 Then
            txtEstadoHabitat.Text = "Bueno"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es regular."
            txtEstadoHabitat.BackColor = Color.Green
        ElseIf FQgeneral < 60 And FQgeneral > 40 Then
            txtEstadoHabitat.Text = "Regular"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es regular."
            txtEstadoHabitat.BackColor = Color.Yellow
        ElseIf FQgeneral < 40 And FQgeneral > 20 Then
            txtEstadoHabitat.Text = "Malo"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es malo."
            txtEstadoHabitat.BackColor = Color.Orange
        ElseIf FQgeneral < 20 Then
            txtEstadoHabitat.Text = "Muy malo"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es muy malo. Cuidado!"
            txtEstadoHabitat.BackColor = Color.Red
        End If

    End Sub

    Private Sub Nuevamuestra_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles Nuevamuestra.Click
        MuestrasBindingSource.AddNew()
        IdProyectoTextBox.Text = frmRLP.IdProyectoTextBox.Text
    End Sub

    Private Sub EliminarMuestra_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles EliminarMuestra.Click
        If MessageBox.Show("Esta seguro de eliminar esta muestra?", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.MuestrasBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.Scilla10DataSet)
        End If
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles Guardar.Click
        IdProyectoTextBox.Text = frmRLP.IdProyectoTextBox.Text
        MuestrasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Scilla10DataSet)
    End Sub

    Private Sub IEcoPlataSignifica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles IEcoPlataSignifica.MouseEnter
        ' MUESTRA QUE CAMPOS SE REQUIEREN PARA CALCULAR EL INDICE
        CianoDensidadTextBox.BackColor = Color.Coral
        DiatoDensidadTextBox.BackColor = Color.Coral
        FitoTotalTextBox.BackColor = Color.Coral
        TanaidsTextBox.BackColor = Color.Coral
    End Sub

    Private Sub IEcoPlataSignifica_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IEcoPlataSignifica.MouseLeave
        ' MUESTRA QUE CAMPOS SE REQUIEREN PARA CALCULAR EL INDICE, vuelve a blanco
        CianoDensidadTextBox.BackColor = Color.White
        DiatoDensidadTextBox.BackColor = Color.White
        FitoTotalTextBox.BackColor = Color.White
        TanaidsTextBox.BackColor = Color.White
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        IEcoPlataSignifica.Text = ""
        IEcoPlataSignifica.BackColor = Color.LightGray
        grpIndices.Enabled = False
    End Sub

    Private Sub C1Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button3.Click
        ' GRABO LOS CAMBIOS A LA MUESTRA
        IdProyectoTextBox.Text = frmRLP.IdProyectoTextBox.Text
        MuestrasBindingSource.EndEdit()
        MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)
        'CALCULO
        CheckHabitat()
    End Sub
    Private Sub CheckHabitat()
        Dim habitatgeneral As Integer
        Dim olorvalue As Integer = Val(OlorComboBox.Text)
        Dim conectividadvalue As Integer = Val(ConectividadComboBox.Text)
        Dim divbasuravalue As Integer = Val(DivBasuraComboBox.Text)
        Dim naturalidadvalue As Integer = Val(NaturalidadComboBox.Text)
        habitatgeneral = (olorvalue + conectividadvalue + divbasuravalue + naturalidadvalue) * 2
        progHabitatGeneral.Value = habitatgeneral
        If habitatgeneral > 80 Then
            txtEstadoHabitat.Text = "Muy bueno"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es muy bueno. Hay buena conectividad entre el río y la costa, buena vegetación ripariana, etc."
            txtEstadoHabitat.BackColor = Color.Blue
        ElseIf habitatgeneral < 80 And habitatgeneral > 60 Then
            txtEstadoHabitat.Text = "Bueno"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es regular."
            txtEstadoHabitat.BackColor = Color.Green
        ElseIf habitatgeneral < 60 And habitatgeneral > 40 Then
            txtEstadoHabitat.Text = "Regular"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es regular."
            txtEstadoHabitat.BackColor = Color.Yellow
        ElseIf habitatgeneral < 40 And habitatgeneral > 20 Then
            txtEstadoHabitat.Text = "Malo"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es malo."
            txtEstadoHabitat.BackColor = Color.Orange
        ElseIf habitatgeneral < 20 Then
            txtEstadoHabitat.Text = "Muy malo"
            txtEstadoHabitatExplain.Text = "El estado general de hábitat es muy malo. Cuidado!"
            txtEstadoHabitat.BackColor = Color.Red
        End If
    End Sub

    Private Sub SalirAWindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirAWindowsToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EnciclopediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnciclopediaToolStripMenuItem.Click
        frmEnciclopedia.Show()
    End Sub

End Class