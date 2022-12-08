Public Class frmMuestrasArroyoPamp
    Dim idproyecto As Integer = Convert.ToInt32(frmRLP.IdProyectoTextBox.Text)

    Private Sub frmMuestrasArroyoPamp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Scilla10DataSet.IBPAMP' table. You can move, or remove it, as needed.
        Me.IBPAMPTableAdapter.Fill(Me.Scilla10DataSet.IBPAMP)
        Me.EutrofizacionTableAdapter.Fill(Me.Scilla10DataSet.Eutrofizacion)
        Me.IMRPTableAdapter.Fill(Me.Scilla10DataSet.IMRP)
        Me.IDPTableAdapter.Fill(Me.Scilla10DataSet.IDP)
        Me.IMRPlataTableAdapter.Fill(Me.Scilla10DataSet.IMRPlata)

        'CARGA MUESTRAS POR PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        IdProyectoTextBox.Text = frmRLP.IdProyectoTextBox.Text
        MuestrasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Scilla10DataSet)

        'Recarga los adaptadores en frmRLP
        frmRLP.ProyectosTableAdapter.qryProyectosByID(frmRLP.Scilla10DataSet.Proyectos, idproyecto)
        frmRLP.MuestrasTableAdapter.qryMuestrasByProyecto(frmRLP.Scilla10DataSet.Muestras, idproyecto)

        ' Recarga los adaptadores en este form
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
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

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        ' GRABO LOS CAMBIOS A LA MUESTRA
        IdProyectoTextBox.Text = frmRLP.IdProyectoTextBox.Text
        MuestrasBindingSource.EndEdit()
        'TableAdapterManager.UpdateAll(Scilla10DataSet)
        MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)
        'CALCULO
        frmIndices.Show()
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        ' GRABO LOS CAMBIOS A LA MUESTRA
        IdProyectoTextBox.Text = frmRLP.IdProyectoTextBox.Text
        MuestrasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Scilla10DataSet)
        frmReporte.Show()
    End Sub

    Private Sub tmrCheckIndices_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckIndices.Tick
        'REVISA PARA EL IMRPlata

        If ConectividadComboBox.Text = "" Or NaturalidadComboBox.Text = "" Or AbuBasuraComboBox.Text = "" Or FQODTextBox.Text = "" Or FQNitratosTextBox.Text = "" Or FQFosfatoTextBox.Text = "" Or FQBODTextBox.Text = "" Or ClorofilaATextBox.Text = "" Or CianoDensidadTextBox.Text = "" Or DiatoDensidadTextBox.Text = "" Or IMRPTextBox.Text = "" Then
            IEcoPlataSignifica.Text = "No se calculará"
            IEcoPlataSignifica.BackColor = Color.LightGray
        Else
            IEcoPlataSignifica.Enabled = True
            If IEcoPlataValor.Text = "" Then
                IEcoPlataSignifica.Text = "Se calculará"
            Else
                IEcoPlataSignificado()
            End If
        End If
        'REVISA PARA EUTROFIZACIÓN
        If ClorofilaATextBox.Text = "" Then
            EutrofizacionSignifica.Text = "No se calculará"
            EutrofizacionSignifica.BackColor = Color.LightGray
        Else
            EutrofizacionSignifica.Enabled = True
            If EutrofizacionValor.Text = "" Then
                EutrofizacionSignifica.Text = "Se calculará"
            Else
                EutrofizacionSignificado()
            End If
        End If
        'REVISA PARA IDP
        If IDPTextbox.Text <> "" Then
            IDPSignificado()
        End If

    End Sub
    Private Sub IEcoPlataSignificado()
        IEcoPlataSignifica.Text = "Algo significa"
        IEcoPlataSignifica.BackColor = Color.LightGray
    End Sub
    Private Sub IDPSignificado()
        Dim varidp As Double
        varidp = Val(IDPTextbox.Text)
        IDPSignifica.Text = ""
        IDPSignifica.BackColor = Color.LightGray
        If varidp <= 0.5 And varidp > 0 Then
            IDPSignifica.Text = "Muy bueno"
            IDPSignifica.BackColor = Color.Blue
        End If
        If varidp <= 1.5 And varidp > 0.5 Then
            IDPSignifica.Text = "Bueno"
            IDPSignifica.BackColor = Color.Green
        End If
        If varidp <= 2 And varidp > 1.5 Then
            IDPSignifica.Text = "Aceptable"
            IDPSignifica.BackColor = Color.Yellow
        End If
        If varidp <= 3 And varidp > 2 Then
            IDPSignifica.Text = "Malo"
            IDPSignifica.BackColor = Color.Orange
        End If
        If varidp <= 4 And varidp > 3 Then
            IDPSignifica.Text = "Muy Malo"
            IDPSignifica.BackColor = Color.Red
        End If
    End Sub

    Private Sub EutrofizacionSignificado()
        Dim varidp2 As Double
        varidp2 = Val(EutrofizacionValor.Text)
        EutrofizacionSignifica.Text = ""
        EutrofizacionSignifica.BackColor = Color.LightGray
        ' COLOR DE Eutrofizacion
        If varidp2 = 1 Then
            EutrofizacionSignifica.Text = "Ultraoligotrófico"
            EutrofizacionSignifica.BackColor = Color.Blue
        End If
        If varidp2 = 2 Then
            EutrofizacionSignifica.Text = "Oligotrófico"
            EutrofizacionSignifica.BackColor = Color.Green
        End If
        If varidp2 = 3 Then
            EutrofizacionSignifica.Text = "Mesotrofico"
            EutrofizacionSignifica.BackColor = Color.Yellow
        End If
        If varidp2 = 4 Then
            EutrofizacionSignifica.Text = "Eutrofico"
            EutrofizacionSignifica.BackColor = Color.Orange
        End If
        If varidp2 = 5 Then
            EutrofizacionSignifica.Text = "Hipereutrófico"
            EutrofizacionSignifica.BackColor = Color.Red
        End If
    End Sub

    Private Sub C1Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button3.Click
        frmIDP.Show()
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

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles Salir.Click
        If MessageBox.Show("Desea grabar al salir?", "Grabar?", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
            IdProyectoTextBox.Text = frmRLP.IdProyectoTextBox.Text
            MuestrasBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Scilla10DataSet)
            Me.Close()
        ElseIf Windows.Forms.DialogResult.No Then
            Me.Close()
        ElseIf Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub

    Private Sub C1Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' GRABO LOS CAMBIOS A LA MUESTRA
        IdProyectoTextBox.Text = frmRLP.IdProyectoTextBox.Text
        MuestrasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Scilla10DataSet)
        'CALCULO
        frmIndices.Show()
    End Sub

    Private Sub IEcoPlataSignifica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles IEcoPlataSignifica.MouseEnter
        ' MUESTRA QUE CAMPOS SE REQUIEREN PARA CALCULAR EL INDICE
        ConectividadComboBox.BackColor = Color.Firebrick
        NaturalidadComboBox.BackColor = Color.Firebrick
        AbuBasuraComboBox.BackColor = Color.Firebrick
        FQODTextBox.BackColor = Color.Firebrick
        FQNitratosTextBox.BackColor = Color.Firebrick
        FQFosfatoTextBox.BackColor = Color.Firebrick
        FQBODTextBox.BackColor = Color.Firebrick
        ClorofilaATextBox.BackColor = Color.Firebrick
        CianoDensidadTextBox.BackColor = Color.Firebrick
        DiatoDensidadTextBox.BackColor = Color.Firebrick
        IMRPTextBox.BackColor = Color.Firebrick
    End Sub

    Private Sub IEcoPlataSignifica_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IEcoPlataSignifica.MouseLeave
        ConectividadComboBox.BackColor = Color.White
        NaturalidadComboBox.BackColor = Color.White
        AbuBasuraComboBox.BackColor = Color.White
        FQODTextBox.BackColor = Color.White
        FQNitratosTextBox.BackColor = Color.White
        FQFosfatoTextBox.BackColor = Color.White
        FQBODTextBox.BackColor = Color.White
        ClorofilaATextBox.BackColor = Color.White
        CianoDensidadTextBox.BackColor = Color.White
        DiatoDensidadTextBox.BackColor = Color.White
        IMRPTextBox.BackColor = Color.White
    End Sub

    Private Sub EutrofizacionSignifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EutrofizacionSignifica.Click

    End Sub

    Private Sub EutrofizacionSignifica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles EutrofizacionSignifica.MouseEnter
        ClorofilaATextBox.BackColor = Color.Firebrick
    End Sub

    Private Sub EutrofizacionSignifica_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles EutrofizacionSignifica.MouseLeave
        ClorofilaATextBox.BackColor = Color.White
    End Sub

    Private Sub chkLimitarEutrofizacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLimitarEutrofizacion.CheckedChanged
        'LIMITA LOS CAMPOS ENABLED SOLO A CLOROFILA

        If chkLimitarEutrofizacion.Checked = True Then
            FQAmonioTextBox.Enabled = False
            FQBODTextBox.Enabled = False
            FQCaudalTextBox.Enabled = False
            FQCondTextBox.Enabled = False
            FQFosfatoTextBox.Enabled = False
            FQNitratosTextBox.Enabled = False
            FQNitritosTextBox.Enabled = False
            FQODTextBox.Enabled = False
            FQpHTextBox.Enabled = False
            FQTempTextBox.Enabled = False
            FQTurbTextBox.Enabled = False
            MateriaOrganicaTextBox.Enabled = False
            CianoDensidadTextBox.Enabled = False
            DiatoDensidadTextBox.Enabled = False
            EcoliTextBox.Enabled = False
            OlorComboBox.Enabled = False
            ConectividadComboBox.Enabled = False
            NaturalidadComboBox.Enabled = False
            DivBasuraComboBox.Enabled = False
            AbuBasuraComboBox.Enabled = False
            IdMuestraTextBox.Enabled = False
            CodigoSitioTextBox.Enabled = False
            FechaDateTimePicker.Enabled = False
            AutorTextBox.Enabled = False
            NombreTextBox.Enabled = False
            ClorofilaATextBox.BackColor = Color.Firebrick
            ' APAGO LOS OTROS LIMITADORES

            chkLimitarIDP.Checked = False
            chkLimitarIERPlata.Checked = False
            chkLimitarIMRP.Checked = False
        Else
            FQAmonioTextBox.Enabled = True
            FQBODTextBox.Enabled = True
            FQCaudalTextBox.Enabled = True
            FQCondTextBox.Enabled = True
            FQFosfatoTextBox.Enabled = True
            FQNitratosTextBox.Enabled = True
            FQNitritosTextBox.Enabled = True
            FQODTextBox.Enabled = True
            FQpHTextBox.Enabled = True
            FQTempTextBox.Enabled = True
            FQTurbTextBox.Enabled = True
            MateriaOrganicaTextBox.Enabled = True
            CianoDensidadTextBox.Enabled = True
            DiatoDensidadTextBox.Enabled = True
            EcoliTextBox.Enabled = True
            OlorComboBox.Enabled = True
            ConectividadComboBox.Enabled = True
            NaturalidadComboBox.Enabled = True
            DivBasuraComboBox.Enabled = True
            AbuBasuraComboBox.Enabled = True
            IdMuestraTextBox.Enabled = True
            CodigoSitioTextBox.Enabled = True
            FechaDateTimePicker.Enabled = True
            AutorTextBox.Enabled = True
            NombreTextBox.Enabled = True
            ClorofilaATextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub chkLimitarIERPlata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLimitarIERPlata.CheckedChanged
        'LIMITA LOS CAMPOS ENABLED SOLO A LOS DEL IERPLATA 

        If chkLimitarIERPlata.Checked = True Then
            FQAmonioTextBox.Enabled = False
            FQCaudalTextBox.Enabled = False
            FQCondTextBox.Enabled = False
            FQpHTextBox.Enabled = False
            FQTempTextBox.Enabled = False
            FQTurbTextBox.Enabled = False
            MateriaOrganicaTextBox.Enabled = False
            EcoliTextBox.Enabled = False
            OlorComboBox.Enabled = False
            DivBasuraComboBox.Enabled = False
            IdMuestraTextBox.Enabled = False
            CodigoSitioTextBox.Enabled = False
            FechaDateTimePicker.Enabled = False
            AutorTextBox.Enabled = False
            NombreTextBox.Enabled = False
            'los cambio de color
            ConectividadComboBox.BackColor = Color.Firebrick
            NaturalidadComboBox.BackColor = Color.Firebrick
            AbuBasuraComboBox.BackColor = Color.Firebrick
            FQODTextBox.BackColor = Color.Firebrick
            FQNitratosTextBox.BackColor = Color.Firebrick
            FQFosfatoTextBox.BackColor = Color.Firebrick
            FQBODTextBox.BackColor = Color.Firebrick
            ClorofilaATextBox.BackColor = Color.Firebrick
            CianoDensidadTextBox.BackColor = Color.Firebrick
            DiatoDensidadTextBox.BackColor = Color.Firebrick
            IMRPTextBox.BackColor = Color.Firebrick
            'Apago los otros limitadores
            chkLimitarEutrofizacion.Checked = False
            chkLimitarIDP.Checked = False
            chkLimitarIMRP.Checked = False
        Else
            FQAmonioTextBox.Enabled = True
            FQCaudalTextBox.Enabled = True
            FQCondTextBox.Enabled = True
            FQFosfatoTextBox.Enabled = True
            FQNitratosTextBox.Enabled = True
            FQpHTextBox.Enabled = True
            FQTempTextBox.Enabled = True
            FQTurbTextBox.Enabled = True
            MateriaOrganicaTextBox.Enabled = True
            EcoliTextBox.Enabled = True
            OlorComboBox.Enabled = True
            DivBasuraComboBox.Enabled = True

            IdMuestraTextBox.Enabled = True
            CodigoSitioTextBox.Enabled = True
            FechaDateTimePicker.Enabled = True
            AutorTextBox.Enabled = True
            NombreTextBox.Enabled = True

            ConectividadComboBox.BackColor = Color.White
            NaturalidadComboBox.BackColor = Color.White
            AbuBasuraComboBox.BackColor = Color.White
            FQODTextBox.BackColor = Color.White
            FQNitratosTextBox.BackColor = Color.White
            FQFosfatoTextBox.BackColor = Color.White
            FQBODTextBox.BackColor = Color.White
            ClorofilaATextBox.BackColor = Color.White
            CianoDensidadTextBox.BackColor = Color.White
            DiatoDensidadTextBox.BackColor = Color.White
            IMRPTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub C1Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button4.Click
        frmIMRP.Show()
    End Sub

    Private Sub C1Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button5.Click
        frmIBPAMP.Show()
    End Sub
End Class