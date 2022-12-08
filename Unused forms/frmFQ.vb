Public Class frmFQ
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim idproyecto As Integer
    Dim idmuestra As Integer
    Dim tipoproyecto As String
    Dim nombreproyecto As String
    Dim idmuestraactual As String
    Dim isnuevamuestra As Boolean


    Public Sub RecibirVariables(ByVal id As Integer, ByVal tipo As String, ByVal nombre As String, ByVal muestrainicial As String)
        'RECIBO TIPO Y NUMERO DE PROYECTO DE FRMMAIN
        idproyecto = Id
        tipoproyecto = tipo
        nombreproyecto = Nombre
        idmuestra = muestrainicial
    End Sub

    Private Sub frmFQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ModulosTableAdapter.Fill(Me.ConfigDataSet.Modulos)
        Me.ConfigTableAdapter.Fill(Me.ConfigDataSet.Config)

        'CARGA MUESTRAS POR PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
        IrAMuestra(idmuestra)

        ' CARGA DE PARAMETROS PERSONALIZADOS
        'Realiza la carga de los datos, desde el script
        ' cargarParametros("fq", "CaracParametros", dgvCustomParameters, True)

        'Estiliza la grilla
        If dgvCustomParameters.RowCount > 0 Then
            'StyleC1Datagridview(dgvCustomParameters)
        End If

    End Sub

    Private Sub IrAMuestra(ByVal idmuestraactual As Integer)
        Dim nombremuestra As String = ""

        If MuestrasDataGridView.RowCount > 1 Then
            For i As Integer = 0 To MuestrasDataGridView.Rows.Count - 1
                If MuestrasDataGridView.Item(0, i).Value = idmuestraactual Then
                    MuestrasDataGridView.CurrentCell = MuestrasDataGridView.Item(0, i)
                    nombremuestra = MuestrasDataGridView.Item(2, i).Value.ToString
                    lblMuestraenFQ.Text = nombremuestra
                    cargarDatos(idmuestraactual)
                End If
            Next
        End If

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MOVIMIENTO DEL MUESTRASBINDINGSOURCE
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub MuestrasBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuestrasBindingSource.PositionChanged
        Dim nombremuestra As String = ""
        If isnuevamuestra = False Then
            If MuestrasDataGridView.Rows.Count > 1 And IdMuestraTextBox.Text <> "" Then
                idmuestra = CInt(IdMuestraTextBox.Text)
                nombremuestra = lblNombreMuestra.Text
                lblMuestraenFQ.Text = nombremuestra
                MuestrasProgressBar.Maximum = MuestrasDataGridView.RowCount - 1
                MuestrasProgressBar.Value = CInt(BindingNavigatorPositionItem.Text) - 1


                cargarDatos(idmuestra)

                If FQdatagridview.RowCount = 0 Then
                    ParametrosFQBindingSource.AddNew()
                    'Dim result As Integer = MessageBox.Show("Esta muestra aún no tiene datos físico-químicos, desea agregarlos?", "Agregar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    'If result = DialogResult.Cancel Then
                    '    Exit Sub
                    'ElseIf result = DialogResult.No Then
                    '    Exit Sub
                    'ElseIf result = DialogResult.Yes Then
                    '    ParametrosFQBindingSource.AddNew()
                    'End If
                End If
            End If
        End If
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   CARGA DE ADAPTADORES INDIVIDUALES
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////


    Public Sub cargarDatos(ByVal idmuestra As Integer)
        ' CARGA DATOS

        Me.ParametrosFQTableAdapter.qryFQbyIdMuestra(Me.FqDataSet.ParametrosFQ, idmuestra)
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MENU DE MUESTRAS
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Dim nombremuestra As String
        nombremuestra = InputBox("Ingrese el nombre de la muestra", , "Muestra ")

        If nombremuestra <> "" Then
            ' AGREGA MUESTRA
            'isnuevamuestra previene que pregunte si deseo agregar FQ a esa muestra, hasta que se grabe y le asigne un ID correcto
            isnuevamuestra = True

            MuestrasBindingSource.AddNew()
            MuestrasDataGridView.Item("colIdProyecto", MuestrasDataGridView.CurrentRow.Index).Value = idproyecto
            MuestrasDataGridView.Item("Nombre", MuestrasDataGridView.CurrentRow.Index).Value = nombremuestra

            ' GRABO MUESTRAS
            MuestrasBindingSource.EndEdit()
            MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

            ' RECARGA ADAPTADORES
            Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)

            'isnuevamuestra previene que pregunte si deseo agregar FQ a esa muestra, hasta que se grabe y le asigne un ID correcto
            'Reseteo isnuevamuestra y me voy a la nueva muestra agregada

            isnuevamuestra = False
            MuestrasBindingSource.MoveLast()
        Else
            'CANCELA EL INPUT
            Exit Sub
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim idmuestraborrar As Integer

        If Not MuestrasDataGridView.RowCount = 1 Then
            If MessageBox.Show("Esta seguro de eliminar esta muestra?", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                idmuestraborrar = MuestrasDataGridView.CurrentRow.Cells.Item(0).Value
                MsgBox("Borrando muestra " & idmuestraborrar)

                ' BORRA MUESTRA CON IDMUESTRA = IDMUESTRABORRAR 
                ' EN EL RESTO DE LAS LAS TABLAS

                ' TABLA DE MUESTRA 
                MuestrasBindingSource.RemoveCurrent()
                MuestrasTableAdapter.Update(Me.Scilla10DataSet.Muestras)

                ' TABLA DE FQ
                If FQdatagridview.RowCount = 1 Then
                    FQdatagridview.Delete()
                    ParametrosFQBindingSource.EndEdit()
                    ParametrosFQTableAdapter.Update(FqDataSet.ParametrosFQ)
                End If
                MuestrasBindingSource.MoveFirst()
            End If
        Else
            MsgBox("No hay muestras en este proyecto")
        End If

        MsgBox("Muestra " & idmuestraborrar & " borrada")
    End Sub


    Private Sub GrabarMuestra()
        ' SI ES UNA NUEVA MUESTRA, GRABO LA MUESTRA, MUEVO EL RECORDSET AL FINAL
        ' Y HAGO UN FQ NUEVO

        If isnuevamuestra = True Then
            ' GRABO MUESTRAS
            MuestrasBindingSource.EndEdit()
            MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

            ' RECARGA ADAPTADORES
            Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
            MuestrasBindingSource.MoveLast()
        Else
            MuestrasBindingSource.EndEdit()
            MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

            'RECARGA ADAPTADORES
            Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
        End If
    End Sub

    Private Sub GrabarFQ()
        If isnuevamuestra = True Then
            ' NUEVO FQ
            idmuestra = IdMuestraTextBox.Text
            FQdatagridview.Item(0, 1) = idmuestra
            FQdatagridview.Item(0, 2) = idproyecto

            ParametrosFQBindingSource.EndEdit()
            ParametrosFQTableAdapter.Update(FqDataSet.ParametrosFQ)

            'Recarga el adaptador de FQ
            ParametrosFQTableAdapter.qryFQbyIdMuestra(FqDataSet.ParametrosFQ, idmuestra)
            isnuevamuestra = False
            cargarDatos(idmuestra)
        End If

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MANEJO DE TABS
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub btnGuardarFQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarFQ.Click
        FQdatagridview.Item(0, "IdMuestra") = idmuestra
        FQdatagridview.Item(0, "IdProyecto") = idproyecto

        ParametrosFQBindingSource.EndEdit()
        ParametrosFQTableAdapter.Update(FqDataSet.ParametrosFQ)

        'Recarga el adaptador de FQ
        ParametrosFQTableAdapter.qryFQbyIdMuestra(FqDataSet.ParametrosFQ, idmuestra)
    End Sub

    Private Sub btnEliminarFQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarFQ.Click
        If MessageBox.Show("Esta seguro de eliminar los datos físico-químicos de esta muestra?", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            FQdatagridview.Delete()

            ParametrosFQBindingSource.EndEdit()
            ParametrosFQTableAdapter.Update(FqDataSet.ParametrosFQ)
            MuestrasBindingSource.MoveFirst()
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MENU DE NAVEGACION
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub CambiarProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Manda a decir que tipo de proyecto es 
        frmProyectos.RecibirVariables(tipoproyecto)
        frmProyectos.Show()
        Me.Close()
    End Sub

    Private Sub SalirAWindowsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub EnciclopediaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEnciclopedia.Show()
    End Sub
End Class