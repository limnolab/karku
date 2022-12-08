Public Class frmHabitatOld
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
        idmuestraactual = muestrainicial
    End Sub

    Private Sub frmHabitat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HabitatDataSet.ParametrosHabitat' table. You can move, or remove it, as needed.
        Me.ParametrosHabitatTableAdapter.Fill(Me.HabitatDataSet.ParametrosHabitat)
        Me.ModulosTableAdapter.Fill(Me.ConfigDataSet.Modulos)
        Me.ConfigTableAdapter.Fill(Me.ConfigDataSet.Config)

        'CARGA MUESTRAS POR PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)

        For i = 0 To Habitatdatagridview.Columns.Count - 1
            Habitatdatagridview.Splits(0).DisplayColumns(i).Height = 30
        Next

        For i = 0 To Habitatdatagridview1.Columns.Count - 1
            Habitatdatagridview1.Splits(0).DisplayColumns(i).Height = 30
        Next
        For i = 0 To Habitatdatagridview2.Columns.Count - 1
            Habitatdatagridview2.Splits(0).DisplayColumns(i).Height = 30
        Next


        IrAMuestra(idmuestraactual)
    End Sub

    Private Sub IrAMuestra(ByVal idmuestraactual As Integer)
        Dim nombremuestra As String = ""

        If MuestrasDataGridView.RowCount > 1 Then
            For i As Integer = 0 To MuestrasDataGridView.Rows.Count - 1
                If MuestrasDataGridView.Item(0, i).Value = idmuestraactual Then
                    MuestrasDataGridView.CurrentCell = MuestrasDataGridView.Item(0, i)
                    nombremuestra = MuestrasDataGridView.Item(2, i).Value.ToString
                    cargarHabitat(idmuestraactual)
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
        If MuestrasDataGridView.Rows.Count > 1 And IdMuestraTextBox.Text <> "" Then
            idmuestra = CInt(IdMuestraTextBox.Text)
            nombremuestra = lblNombreMuestra.Text
            cargarHabitat(idmuestra)

            If Habitatdatagridview.RowCount = 0 Then
                Dim labelNoData As New Label
                Dim grpNodata As New GroupBox
                With grpNodata
                    .Location = New System.Drawing.Point(142, 195)
                    .Size = New System.Drawing.Size(500, 150)
                    .BackColor = Color.White
                    .Text = ""
                    .Name = "grpNoData"
                End With
                With labelNoData
                    .AutoSize = True
                    .Parent = Me
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Location = New System.Drawing.Point(50, 10)
                    .Font = New Font(labelNoData.Font.Name, 22)
                    .ForeColor = Color.Teal
                    .Size = New System.Drawing.Size(279, 195)
                    .Name = "labelNoData"
                    .Text = "NO HAY DATOS" & vbCrLf & "EN ESTA MUESTRA" & vbCrLf & "Haga click aquí para agregarlos"
                    .TextAlign = ContentAlignment.TopCenter
                    .Visible = True
                End With
                AddHandler labelNoData.Click, AddressOf labelNoData_Click
                C1SplitterPanel2.Controls.Add(grpNodata)
                C1SplitterPanel2.BackColor = Color.LightGray
                grpNodata.Controls.Add(labelNoData)
                grpContenido.Visible = False
            Else
                C1SplitterPanel2.BackColor = Color.White
                grpContenido.Visible = True
            End If
        End If
    End Sub

    Friend Sub labelNoData_Click(ByVal sender As Object, ByVal e As EventArgs)
        Habitatdatagridview.MoveLast()
        ' Move to the "addnew row", and set focus to the grid.
        Habitatdatagridview.Row = Habitatdatagridview.Row + 1
        Habitatdatagridview.Select()
        grpContenido.Visible = True
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


    Public Sub cargarHabitat(ByVal idmuestra As Integer)
        ' CARGA DATOS DE FQ
        Me.ParametrosHabitatTableAdapter.qryParametrosHabitatbyIdMuestra(Me.HabitatDataSet.ParametrosHabitat, idmuestra)
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

        Habitatdatagridview.Item(0, 1) = idmuestra
        Habitatdatagridview.Item(0, 2) = idproyecto

        ParametrosHabitatBindingSource.EndEdit()
        ParametrosHabitatTableAdapter.Update(HabitatDataSet.ParametrosHabitat)

        'Recarga el adaptador de FQ
        ParametrosHabitatTableAdapter.qryParametrosHabitatbyIdMuestra(HabitatDataSet.ParametrosHabitat, idmuestra)
    End Sub

    Private Sub btnEliminarFQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarFQ.Click
        If MessageBox.Show("Esta seguro de eliminar los datos físico-químicos de esta muestra?", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Habitatdatagridview.Delete()

            ParametrosHabitatBindingSource.EndEdit()
            ParametrosHabitatTableAdapter.Update(HabitatDataSet.ParametrosHabitat)
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