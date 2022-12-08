Public Class frmIMRP
    Dim idmuestra As Integer
    Dim idproyecto As Integer
    Dim pathimagen As String = My.Application.Info.DirectoryPath & "\fotosespecies\imrp\"


    Public Sub SetReceive(ByVal Value As Integer, ByVal Value2 As Integer)
        idmuestra = Value
        idproyecto = Value2
    End Sub

    Private Sub frmIMRP_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cierroventana()
    End Sub
    Private Sub frmIMRP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Scilla10DataSet.Muestras' table. You can move, or remove it, as needed.
        Me.CaracMacroinvIMRPTableAdapter.Fill(Me.Scilla10DataSet.CaracMacroinvIMRP)

        'Carga las muestras por id
        Me.MuestrasTableAdapter.qryMuestrasByMuestra(Me.Scilla10DataSet.Muestras, idmuestra)
        Me.MacroinvSpIMRPTableAdapter.qryMacroinvByMuestra(Me.Scilla10DataSet.MacroinvSpIMRP, idmuestra)
        Me.ImrpTableAdapter.qryIMRPByMuestra(Me.Scilla10DataSet.IMRP, idmuestra)

        ' SE FIJA QUE HAYA YA HECHO UN RECORD, SINO LO CREA
        IMRPDataGridView.Refresh()
        If IMRPDataGridView.RowCount = 1 Then
            IMRPBindingSource.AddNew()
            IdMuestraTextBox1.Text = idmuestra
            IdProyectoTextBox1.Text = idproyecto
            ValorTextBox.Text = ""

            'UPDATE THE DATABASE
            IMRPBindingSource.EndEdit()
            MacroinvSpIMRPBindingSource.EndEdit()
            ImrpTableAdapter.Update(Scilla10DataSet.IMRP)
            TableAdapterManager.UpdateAll(Scilla10DataSet)

            'Refresh everything, including adapters
            IMRPDataGridView.Refresh()
            MacroinvSpDataGrid.Refresh()
            Me.MuestrasTableAdapter.qryMuestrasByMuestra(Me.Scilla10DataSet.Muestras, idmuestra)
            Me.MacroinvSpIMRPTableAdapter.qryMacroinvByMuestra(Me.Scilla10DataSet.MacroinvSpIMRP, idmuestra)
            Me.ImrpTableAdapter.qryIMRPByMuestra(Me.Scilla10DataSet.IMRP, idmuestra)
        End If
        MostrarDatos()
    End Sub
    Private Sub MostrarDatos()
        ' Este procedimiento pasa los valores no nulos de la base de datos a la MostrarDatosGrid para que el usuario
        ' vea lo que esta cargado en esa muestra, solo lo distinto de NULL y lo distinto de ZERO

        Dim i As Integer
        Dim nombreespecie As String
        Dim valorimrp As String
        MostrarDatosGrid.Rows.Clear()
        For i = 2 To MacroinvSpDataGrid.Columns.Count - 1
            If Not MacroinvSpDataGrid.Item(0, i).ToString = String.Empty Then
                If Not MacroinvSpDataGrid.Item(0, i).ToString = "0" Then
                    nombreespecie = MacroinvSpDataGrid.Columns(i).ToString
                    valorimrp = MacroinvSpDataGrid.Item(0, i).ToString

                    'muestra todo en  la tabla de resultados 
                    MostrarDatosGrid.Rows.Add(nombreespecie, valorimrp)
                End If
            End If
        Next
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'Si mi muestra ya tiene un valor de densidad de diatomeas prosigue, sino genera una row propia
        If MacroinvSpDataGrid.RowCount = 0 Then
            'MsgBox("no hay valores previos para la muestra")
            MacroinvSpIMRPBindingSource.AddNew()
            Modificardensidad()
        ElseIf MacroinvSpDataGrid.RowCount = 1 Then
            'MsgBox("hay valores previos para la muestra")
            'Busca en ambas tablas de diatomeas la muestra que estoy actualizando
            Modificardensidad()
        End If
        btnGuardar.Enabled = True
    End Sub
    Private Sub Modificardensidad()
        Dim valorvx As String

        valorvx = ValorTextBox1.Text

        'Chequea en que tabla esta la especie y agrega la densidad nueva
        For Each dc As C1.Win.C1TrueDBGrid.C1DisplayColumn In Me.MacroinvSpDataGrid.Splits(0).DisplayColumns
            If dc.DataColumn.DataField = NombreTextBox.Text Then
                MacroinvSpDataGrid.Item(0, "IdMuestras") = idmuestra
                MacroinvSpDataGrid.Item(0, NombreTextBox.Text) = valorvx
            End If
        Next
        'Update las grids sin grabar
        MacroinvSpDataGrid.Update()
        MacroinvSpDataGrid.Refresh()
        MostrarDatos()
    End Sub

    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        'Se fija en que  muestra estoy trabajando
        Dim nombretaxon As String

        nombretaxon = ListBox1.SelectedItems.Item(0).ToString()
        CaracMacroinvIMRPTableAdapter.qryMacroinvByNombre(Scilla10DataSet.CaracMacroinvIMRP, nombretaxon)

        'Si mi muestra ya tiene un valor de densidad de diatomeas prosigue, sino genera una row propia
        If MacroinvSpDataGrid.RowCount = 0 Then
            'MsgBox("no hay valores previos para la muestra")
            MacroinvSpIMRPBindingSource.AddNew()
            Modificardensidad()
        ElseIf MacroinvSpDataGrid.RowCount = 1 Then
            'MsgBox("hay valores previos para la muestra")
            'Busca en ambas tablas de diatomeas la muestra que estoy actualizando
            Modificardensidad()
        End If
        btnGuardar.Enabled = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim nombretaxon As String
        nombretaxon = ListBox1.SelectedItems.Item(0).ToString()
        CaracMacroinvIMRPTableAdapter.qryMacroinvByNombre(Scilla10DataSet.CaracMacroinvIMRP, nombretaxon)
        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & nombretaxon & ".jpg"
        If Not RangoTextBox.Text = "" Then
            ValorTextBox1.Enabled = True
        ElseIf RangoTextBox.Text = "" Then
            ValorTextBox1.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not MostrarDatosGrid.Rows.Count = 0 Then
            CalcularIMRP()
            IMRPBindingSource.EndEdit()
            MuestrasBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Scilla10DataSet)
            Me.Close()
        ElseIf MostrarDatosGrid.Rows.Count = 0 Then
            MsgBox("No hay taxones ingresados en esta muestra")
        End If
    End Sub

    Private Sub CalcularIMRP()
        Dim imrpvaluetotal As Double = 0
        Dim imrpvalue As Double
        Dim imrpvalueredondeado As String
        Dim i As Integer

        'Calculo abundancia total
        For i = 0 To MostrarDatosGrid.RowCount - 1
            imrpvalue = Val(MostrarDatosGrid.Rows(i).Cells("Vx").Value)
            imrpvaluetotal += imrpvalue
        Next

        'redondeo imrptotal y lo paso al textbox de la db
        imrpvalueredondeado = Math.Round(imrpvaluetotal, 2)
        Dim value2 As String = imrpvalueredondeado.Replace(",", ".")
        ValorTextBox.Text = value2
        IMRPTextBox.Text = value2

        'grabo
        IMRPBindingSource.EndEdit()
        MuestrasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Scilla10DataSet)
        Cierroventana()
    End Sub

    Private Sub Cierroventana()

        IMRPTextBox.Text = ValorTextBox.Text

        ' GRABO MACROINV
        Me.MacroinvSpIMRPBindingSource.EndEdit()
        Me.MacroinvSpIMRPTableAdapter.Update(Scilla10DataSet.MacroinvSpIMRP)

        ' GRABO IMRP
        Me.IMRPBindingSource.EndEdit()
        Me.ImrpTableAdapter.Update(Scilla10DataSet.IMRP)

        ' GRABO MUESTRAS
        Me.MuestrasBindingSource.EndEdit()
        Me.MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

        'Recarga los adaptadores en frmMuestrasRLP
        frmMuestrasArroyoPamp.MuestrasBindingSource.EndEdit()
        frmMuestrasArroyoPamp.MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)
        frmMuestrasArroyoPamp.IMRPTableAdapter.Fill(frmMuestrasArroyoPamp.ImrpDataSet.IMRP)
        frmMuestrasArroyoPamp.GrabarMuestra()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnBorrarSp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarSp.Click
        Dim especieaborrar As String

        If MostrarDatosGrid.RowCount <> 0 Then
            'MostrarDatosGrid.Rows.Remove(MostrarDatosGrid.CurrentRow)
            especieaborrar = MostrarDatosGrid.CurrentRow.Cells(0).Value
            'Chequea en que tabla esta la especie y agrega la densidad nueva
            For Each dc As C1.Win.C1TrueDBGrid.C1DisplayColumn In Me.MacroinvSpDataGrid.Splits(0).DisplayColumns
                If dc.DataColumn.DataField = especieaborrar Then
                    MacroinvSpDataGrid.Item(0, "IdMuestras") = idmuestra
                    MacroinvSpDataGrid.Item(0, especieaborrar) = ""
                End If
            Next
            'Update las grids sin grabar
            MacroinvSpDataGrid.Update()
            MacroinvSpDataGrid.Refresh()
            MostrarDatos()
        Else
            MsgBox("No ha agregado especies a la muestra todavia!")

        End If
    End Sub

    Private Sub tmrCheckIndices_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckIndices.Tick
        Dim indicecolor As Integer
        If ValorTextBox.Text <> "" Then
            indicecolor = Val(ValorTextBox.Text)
        ElseIf ValorTextBox.Text = "" Then
            Significa.Text = ""
            Significa.BackColor = Color.Gray
        End If

        If indicecolor > 0 And indicecolor <= 1 Then
            Significa.Text = "Muy fuerte"
            Significa.BackColor = Color.Red
        End If
        If indicecolor > 1 And indicecolor <= 2.5 Then
            Significa.Text = "Fuerte"
            Significa.BackColor = Color.OrangeRed
        End If
        If indicecolor > 2.5 And indicecolor < 4 Then
            Significa.Text = "Moderada"
            Significa.BackColor = Color.Orange
        End If
        If indicecolor >= 4 And indicecolor < 8 Then
            Significa.Text = "Débil"
            Significa.BackColor = Color.Yellow
        End If
        If indicecolor >= 8 And indicecolor <= 12 Then
            Significa.Text = "Escasa"
            Significa.BackColor = Color.Green
        End If
        If indicecolor > 12 Then
            Significa.Text = "Nula"
            Significa.BackColor = Color.Blue
        End If
    End Sub
End Class