Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices


Public Class frmGraficar

    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim idproyecto As Integer
    Dim tipoproyecto As String
    Dim nombreproyecto As String
    Dim datagridentrada As DataGridView

    Public Sub RecibirVariables(ByVal idproy As Integer, ByVal tipoproy As String, ByVal nombreproy As String, datagridentrada As DataGridView)
        'RECIBO TIPO Y NUMERO DE PROYECTO DE FRMMAIN
        idproyecto = idproy
        tipoproyecto = tipoproy
        nombreproyecto = nombreproy

        'Copia la dgv de entrada a la dgv de este form
        'For Each Col As DataGridViewColumn In datagridentrada.Columns
        Dim coladividir As Integer
        Dim nombrecoladividir As String
        Dim cantidadadividir As Integer
        Dim coldivisible As Boolean = False

        ' Agrega las series que tienen ";", usando un boolean para avisar si existen

        For j As Integer = 0 To datagridentrada.Columns.Count - 1
            For i As Integer = 0 To datagridentrada.Rows.Count - 1
                If Not datagridentrada.Item(j, i).Value Is Nothing Then
                    ' si tiene el simbolo ";" llama a DividirCol, sino es una columna normal y la agrega
                    If datagridentrada.Item(j, i).Value.ToString.Contains(";") Then
                        coladividir = j
                        nombrecoladividir = datagridentrada.Columns(j).HeaderText
                        cantidadadividir = datagridentrada.Item(j, i).Value.ToString.Split(";").Length - 1
                        DividirCol(j, nombrecoladividir, cantidadadividir, datagridentrada)
                        coldivisible = True
                    End If
                End If
            Next
            ' Agrega las series que NO tienen ";"
            If coldivisible = False Then
                Dim col As New DataGridViewColumn
                col = datagridentrada.Columns(j).Clone
                DataGridView1.Columns.Add(DirectCast(col.Clone, DataGridViewColumn))
                chklistVariables.Items.Add(col.Name, True)
                chklistVariablesNames.Items.Add(col.HeaderText, True)
                coldivisible = False
            End If
            coldivisible = False
        Next

        'COPIA DE ROWS. Primero copia la row entera, despues hace otro loop para separar aquellas que tengan el simbolo ";"

        ' Primero copia la cantidad de rows
        For i = 0 To datagridentrada.Rows.Count - 1
            DataGridView1.Rows.Add()
        Next
        'separa las celdas con valor ";"
        For i = 0 To datagridentrada.Rows.Count - 1
            For j = 0 To datagridentrada.Columns.Count - 1
                If Not datagridentrada.Item(j, i).Value Is Nothing Then
                    If datagridentrada.Item(j, i).Value.ToString.Contains(";") Then
                        Dim valorarray As String() = datagridentrada.Item(j, i).Value.ToString.Split(";")
                        Dim nombrecol As String = datagridentrada.Columns(j).Name
                        DataGridView1.Item(nombrecol & " -0", i).Value = valorarray(0)

                        For m As Integer = 1 To valorarray.Length - 1
                            DataGridView1.Item(nombrecol & " -" & m, i).Value = valorarray(m)
                        Next
                        'si no tiene ;
                    Else
                        DataGridView1.Item(j, i).Value = datagridentrada.Item(j, i).Value
                    End If
                End If
            Next
        Next

        chklistVariables.Items.Remove("IdMuestra")
        chklistVariables.Items.Remove("Nombre")
        chklistVariablesNames.Items.Remove("IdMuestra")
        chklistVariablesNames.Items.Remove("Nombre")
    End Sub

    Private Sub DividirCol(columnadividir As Integer, nombrecoladividir As String, cantidadadividir As Integer, datagridentrada As DataGridView)
        If Not DataGridView1.Columns.Contains(nombrecoladividir) Then
            For m As Integer = 0 To cantidadadividir
                If Not DataGridView1.Columns.Contains(nombrecoladividir & " -" & m) Then
                    Dim col As New DataGridViewColumn
                    col = datagridentrada.Columns(columnadividir).Clone
                    col.Name = nombrecoladividir & " -" & m
                    col.HeaderText = nombrecoladividir & " -" & m
                    DataGridView1.Columns.Add(DirectCast(col.Clone, DataGridViewColumn))
                    chklistVariables.Items.Add(col.Name, True)
                    chklistVariablesNames.Items.Add(col.HeaderText, True)
                End If

            Next
        End If
    End Sub



    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        If chklistVariablesNames.CheckedItems.Count = 0 Then
            MsgBox("No hay series de datos seleccionadas para agregar al gráfico")
            Exit Sub
        End If

        'Primero replica la lista en chklistVariablesNames a chklistVariables
        Dim idvariablename As Integer
        For j As Integer = 0 To chklistVariables.Items.Count - 1
            chklistVariables.SetItemChecked(j, False)
        Next
        For j As Integer = 0 To chklistVariablesNames.CheckedItems.Count - 1
            idvariablename = chklistVariablesNames.CheckedIndices(j)
            chklistVariables.SetItemChecked(idvariablename, True)
        Next

        ' agrega la serie
        For i As Integer = 0 To chklistVariables.CheckedItems.Count - 1
            Dim nombreserie As String = chklistVariables.CheckedItems(i).ToString
            Dim nombrebonito As String = chklistVariablesNames.CheckedItems(i).ToString

            'se fija que la seria ya no haya sido agregada al grafico 
            If Chart1.Series.Contains(Chart1.Series.FindByName(nombreserie)) Then
                Continue For
            End If

            ' se fija que tenga datos. si es una serie vacia, no agrega
            Dim tienedatos As Boolean = False
            For checkseries As Integer = 0 To DataGridView1.Rows.Count - 1
                If Not DataGridView1.Item(nombreserie, checkseries).Value Is Nothing Then
                    tienedatos = True
                End If
            Next
            If tienedatos = False Then
                Continue For
            End If


            Chart1.Series.Add(nombreserie)
            Chart1.Series(nombreserie).LegendText = nombrebonito
            
            If chkEtiquetas.Checked = True Then
                Chart1.Series(nombreserie).IsValueShownAsLabel = True
                Chart1.Series(nombreserie).SmartLabelStyle.Enabled = True
            End If
            Chart1.ChartAreas(0).AxisY.ScaleBreakStyle.Enabled = True
            Chart1.ChartAreas(0).AxisX.Interval = 1



            'se fija el tipo de serie a agregar
            If cmbTipoSerie.Text = "Columnas" Then
                Chart1.Series(nombreserie).ChartType = DataVisualization.Charting.SeriesChartType.Column
            ElseIf cmbTipoSerie.Text = "Lineas" Then
                Chart1.Series(nombreserie).ChartType = DataVisualization.Charting.SeriesChartType.Line
            ElseIf cmbTipoSerie.Text = "Puntos" Then
                Chart1.Series(nombreserie).ChartType = DataVisualization.Charting.SeriesChartType.Point
            End If

            For Count As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, Count).Value IsNot Nothing Then
                    If DataGridView1.Item(nombreserie, Count).Value IsNot Nothing Then
                        ' aca divide en un array si encuentra el simbolo #
                        If Not DataGridView1.Item(nombreserie, Count).Value.ToString.Contains(";") Then
                            Chart1.Series(nombreserie).Points.AddXY(DataGridView1.Item(1, Count).Value, DataGridView1.Item(nombreserie, Count).Value.ToString.Replace(",", "."))
                        ElseIf DataGridView1.Item(nombreserie, Count).Value.ToString.Contains(";") Then
                            Dim arraydatos As String() = DataGridView1.Item(nombreserie, Count).Value.ToString.Split(";")
                            For m As Integer = 0 To arraydatos.Length - 1
                                Chart1.Series(nombreserie).Points.AddXY(DataGridView1.Item(1, Count).Value & " -" & m, arraydatos(m).ToString.Replace(",", "."))
                            Next
                        End If
                    Else
                        If chkVacios.CheckState = CheckState.Unchecked Then
                            Chart1.Series(nombreserie).Points.AddXY(DataGridView1.Item(1, Count).Value, "0")
                        End If
                    End If
                End If
            Next


        Next

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'limpia el grafico
        For i As Integer = 0 To Chart1.Series.Count - 1
            Chart1.Series(i).Points.Clear()
        Next
        Chart1.Series.Clear()

    End Sub

    Private Sub btnCopiarChart_Click(sender As Object, e As EventArgs) Handles btnCopiarChart.Click

        Dim ms As New System.IO.MemoryStream()
        Try
            Chart1.SaveImage(ms, ImageFormat.Emf)
            ms.Seek(0, IO.SeekOrigin.Begin)

            Dim mf As New Metafile(ms)
            ClipboardMetafileHelper.PutEnhMetafileOnClipboard(Me.Handle, mf)
        Finally
            ms.Close()
        End Try

    End Sub

    Private Sub btnSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarTodo.Click
        If btnSeleccionarTodo.Text = "Seleccionar todo" Then
            'selecciona todo
            For i As Integer = 0 To chklistVariables.Items.Count - 1
                chklistVariables.SetItemChecked(i, True)
                chklistVariablesNames.SetItemChecked(i, True)
                btnSeleccionarTodo.Text = "Deseleccionar todo"
            Next
        Else
            'deselecciona todo
            For i As Integer = 0 To chklistVariables.Items.Count - 1
                chklistVariables.SetItemChecked(i, False)
                chklistVariablesNames.SetItemChecked(i, False)
                btnSeleccionarTodo.Text = "Seleccionar todo"
            Next
        End If

    End Sub

    Private Sub btn3dEnable_Click(sender As Object, e As EventArgs) Handles btn3dEnable.Click

        If btn3dEnable.Text = "Gráfico 3D" Then
            Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
            Chart1.ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Simplistic
            Chart1.ChartAreas(0).Area3DStyle.WallWidth = 0
            Chart1.ChartAreas(0).Area3DStyle.IsClustered = False
            btn3dEnable.Text = "Gráfico 2D"

        Else
            Chart1.ChartAreas(0).Area3DStyle.Enable3D = False
            btn3dEnable.Text = "Gráfico 3D"
        End If

    End Sub
End Class