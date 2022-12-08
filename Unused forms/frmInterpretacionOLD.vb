Imports System.Reflection
Public Class frmInterpretacionOLD
    Dim idproyecto As String
    Dim tipoproyecto As String
    Dim nombreproyecto As String
    Dim dgvEntrada As New DataGridView
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Public Sub RecibirVariables(ByVal idproy As Integer, ByVal tipoproy As String, ByVal nombreproy As String, datagridentrada As DataGridView)
        idproyecto = idproy
        tipoproyecto = tipoproy
        nombreproyecto = nombreproy

        'Copia la datagridentrada a dgvResultadosCalcular, con valores y estilos
        For Each Col As DataGridViewColumn In datagridentrada.Columns
            dgvEntrada.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next

        For i As Integer = 0 To datagridentrada.Rows.Count - 1
            Dim row As DataGridViewRow
            row = CType(datagridentrada.Rows(i).Clone(), DataGridViewRow)
            For index As Int32 = 0 To datagridentrada.Rows(i).Cells.Count - 1
                row.Cells(index).Value = datagridentrada.Rows(i).Cells(index).Value
            Next
            dgvEntrada.Rows.Add(row)
        Next

    End Sub

    Private Sub frmInterpretacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Pone el nombre del proyecto en el TV y abre el nodo 0
        tvInterpretacion.Nodes(0).Text = "Proyecto: " & nombreproyecto
        tvInterpretacion.Nodes(0).Expand()
        tvInterpretacion.HotTracking = True
        tvInterpretacion.ShowLines = True

        'Carga las muestras en el treeview
        For i As Integer = 0 To dgvEntrada.RowCount - 3
            tvInterpretacion.Nodes(0).Nodes("ndMuestras").Nodes.Add("muestra-" & dgvEntrada.Item("Nombre", i).Value.ToString, dgvEntrada.Item("Nombre", i).Value.ToString)
        Next

        lblNombreProyecto.Text = nombreproyecto
        lblTipoProyecto.Text = tipoproyecto

        CargarIndicesBioticos()
        tabInterpretacion.TabPages("tabIndicesBioticos").Show()
        tabInterpretacion.SelectedTab = tabIndicesBioticos

        txtIndicesBioticosInterpret.Text = txtIndicesBioticosInterpret.Text & vbNewLine & "Cantidad de muestras en el proyecto: " & dgvEntrada.Rows.Count - 1 & vbNewLine & vbNewLine & vbNewLine

    End Sub

    'Controla los links del TV
    Private Sub tvInterpretacion_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvInterpretacion.AfterSelect

        If tvInterpretacion.SelectedNode.Name = "ndIndicesBioticos" Then
            tabInterpretacion.TabPages("tabIndicesBioticos").Show()
            tabInterpretacion.SelectedTab = tabIndicesBioticos
        ElseIf tvInterpretacion.SelectedNode.Name.Contains("muestra-") Then
            'TAB MUESTRAS (INDIVIDUALES)
            CargaMuestra(tvInterpretacion.SelectedNode.Index)
            tabInterpretacion.TabPages("tabMuestras").Show()
            tabInterpretacion.SelectedTab = tabMuestras
            lblNombreMuestra.Text = tvInterpretacion.SelectedNode.Text
        End If
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////// CARGA DATOS DE UNA MUESTRA
    '///////////////////////////////////////
    '///////////////////////////////////////
    '///////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '

    Public Sub CargaMuestra(idmuestraactual As Integer)
        dgvMuestrasIndicesEcologicos.Rows.Clear()
        dgvMuestrasIndicesBioticos.Rows.Clear()
        dgvMuestrasDensidades.Rows.Clear()
        'Pasa todos los valores a las dgv de Indices
        For i As Integer = 2 To dgvEntrada.ColumnCount - 1
            If dgvEntrada.Columns(i).HeaderText.Contains(" -") Then
                Dim namearray As String() = dgvEntrada.Columns(i).HeaderText.Split(" -")

                dgvMuestrasIndicesEcologicos.Rows.Add(New String() {namearray(2), namearray(0), dgvEntrada.Item(i, idmuestraactual).Value, dgvEntrada.Item(i, idmuestraactual).ToolTipText})
                'dgvMuestrasIndicesEcologicos.Rows.Add(New String() {dgvEntrada.Columns(i).HeaderText, dgvEntrada.Item(i, idmuestraactual).Value, dgvEntrada.Item(i, idmuestraactual).ToolTipText})
                dgvMuestrasIndicesEcologicos.Item(2, dgvMuestrasIndicesEcologicos.RowCount - 1).Style.BackColor = dgvEntrada.Item(i, idmuestraactual).Style.BackColor
            Else
                ' si es un indice biótico, pero que contiene "_", entonces es un indice por densidad, hay q traducir sus categorias
                If dgvEntrada.Columns(i).Name.Contains("_") Then
                    Dim nombrecomarray As String() = dgvEntrada.Columns(i).HeaderText.Split(" ")
                    Dim nombrecomunidad As String = nombrecomarray(0)
                    Dim indicecomarray As String() = dgvEntrada.Columns(i).Name.Split("_")
                    Dim indicecomunidad As String = indicecomarray(0)
                    Dim categoriacomunidad As String = nombrecomarray(1)
                    dgvMuestrasDensidades.Rows.Add(New String() {nombrecomunidad, indicecomunidad, categoriacomunidad, dgvEntrada.Item(i, idmuestraactual).Value, dgvEntrada.Item(i, idmuestraactual).ToolTipText})
                Else
                    Dim nombreindice As String = dgvEntrada.Columns(i).HeaderText
                    Dim mType As Type = Type.GetType("Scila7." & nombreindice.ToLower)
                    If mType Is Nothing Then
                        Continue For
                    End If
                    Dim mMethod As MethodInfo = mType.GetMethod("DefineTaxones" & nombreindice.ToUpper)
                    Dim mValue As Object = mMethod.Invoke(mType, New Object() {"dummyparameter"})

                    dgvMuestrasIndicesBioticos.Rows.Add(New String() {mValue, dgvEntrada.Columns(i).HeaderText, dgvEntrada.Item(i, idmuestraactual).Value, dgvEntrada.Item(i, idmuestraactual).ToolTipText})
                    dgvMuestrasIndicesBioticos.Item(2, dgvMuestrasIndicesBioticos.RowCount - 1).Style.BackColor = dgvEntrada.Item(i, idmuestraactual).Style.BackColor
                End If
            End If
        Next
        dgvMuestrasIndicesBioticos.Sort(dgvMuestrasIndicesBioticos.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        dgvMuestrasIndicesEcologicos.Sort(dgvMuestrasIndicesEcologicos.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        ' y unifica los nombre e indices en la primera col
        For i = dgvMuestrasIndicesBioticos.RowCount - 1 To 1 Step -1
            If dgvMuestrasIndicesBioticos.Item(0, i).Value.ToString = dgvMuestrasIndicesBioticos.Item(0, i - 1).Value.ToString Then
                dgvMuestrasIndicesBioticos.Item(0, i).Value = ""
            End If
        Next

        ' y unifica los nombre e indices en la primera col
        For i = dgvMuestrasIndicesEcologicos.RowCount - 1 To 1 Step -1
            If dgvMuestrasIndicesEcologicos.Item(0, i).Value.ToString = dgvMuestrasIndicesEcologicos.Item(0, i - 1).Value.ToString Then
                dgvMuestrasIndicesEcologicos.Item(0, i).Value = ""
            End If
        Next

        TraducirDensidades()
    End Sub

    Private Sub TraducirDensidades()
        Dim densidadtotalcomunidad As Double
        Dim nombresarray As String() = {}
        Dim indicesarray As String() = {}

        'Cancela todo si dgvMuestrasDensidades esta vacia
        If dgvMuestrasDensidades.RowCount = 0 Then
            Exit Sub
        End If
        'Genera una array con las comunidades
        For i As Integer = 0 To dgvMuestrasDensidades.RowCount - 1
            If Not nombresarray.Contains(dgvMuestrasDensidades.Item(0, i).Value.ToString) Then
                Array.Resize(nombresarray, nombresarray.Length + 1)
                nombresarray(nombresarray.Length - 1) = dgvMuestrasDensidades.Item(0, i).Value.ToString
            End If
        Next

        'Genera una array con los indices
        For i As Integer = 0 To dgvMuestrasDensidades.RowCount - 1
            If Not indicesarray.Contains(dgvMuestrasDensidades.Item(1, i).Value.ToString) Then
                Array.Resize(indicesarray, indicesarray.Length + 1)
                indicesarray(indicesarray.Length - 1) = dgvMuestrasDensidades.Item(1, i).Value.ToString
            End If
        Next

        'Calcula el total de densidades para cada indice, para cada comunidad, y agrega la columna % 
        For i As Integer = 0 To nombresarray.Length - 1
            For j As Integer = 0 To indicesarray.Length - 1
                densidadtotalcomunidad = 0
                For k As Integer = 0 To dgvMuestrasDensidades.RowCount - 1
                    If dgvMuestrasDensidades.Item(0, k).Value.ToString = nombresarray(i) And dgvMuestrasDensidades.Item(1, k).Value.ToString = indicesarray(j) Then
                        densidadtotalcomunidad = densidadtotalcomunidad + CDbl(dgvMuestrasDensidades.Item(3, k).Value)
                    End If
                Next k
                dgvMuestrasDensidades.Rows.Add(nombresarray(i), indicesarray(j), "Total", densidadtotalcomunidad, "100%")
            Next j
        Next i

        'Calcula los %
        For i As Integer = 0 To dgvMuestrasDensidades.RowCount - 1
            Dim densidadactual As Double = dgvMuestrasDensidades.Item(3, i).Value
            For j As Integer = 0 To dgvMuestrasDensidades.RowCount - 1
                If dgvMuestrasDensidades.Item(0, j).Value.ToString = dgvMuestrasDensidades.Item(0, i).Value.ToString And dgvMuestrasDensidades.Item(1, j).Value.ToString = dgvMuestrasDensidades.Item(1, i).Value.ToString And dgvMuestrasDensidades.Item(2, j).Value.ToString = "Total" Then
                    'chequea q la densidad no sea nada, y calcula el %
                    If dgvMuestrasDensidades.Item(3, i).Value Is Nothing Then
                        dgvMuestrasDensidades.Item(4, i).Value = Nothing
                    Else
                        dgvMuestrasDensidades.Item(4, i).Value = Math.Round((dgvMuestrasDensidades.Item(3, i).Value * 100) / dgvMuestrasDensidades.Item(3, j).Value, 2)
                    End If

                End If
            Next
        Next i
        'borra las filas de total
        For i = dgvMuestrasDensidades.RowCount - 1 To 0 Step -1
            If dgvMuestrasDensidades.Item(2, i).Value.ToString = "Total" Then
                dgvMuestrasDensidades.Rows.RemoveAt(i)
            End If
        Next

        ' y unifica los nombre e indices en las primeras 2 cols
        For i = dgvMuestrasDensidades.RowCount - 1 To 1 Step -1
            If dgvMuestrasDensidades.Item(0, i).Value.ToString = dgvMuestrasDensidades.Item(0, i - 1).Value.ToString And _
                dgvMuestrasDensidades.Item(1, i).Value.ToString = dgvMuestrasDensidades.Item(1, i - 1).Value.ToString Then
                dgvMuestrasDensidades.Item(0, i).Value = ""
                dgvMuestrasDensidades.Item(1, i).Value = ""
            End If
        Next
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////// CARGA INDICES BIOTICOS
    '///////////////////////////////////////
    '///////////////////////////////////////
    '///////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub CargarIndicesBioticos()
        dgvIndicesIndicesBioticos.Columns.Clear()

        'Copia la datagridentrada a dgvResultadosCalcular, con valores y estilos
        For Each Col As DataGridViewColumn In dgvEntrada.Columns
            dgvIndicesIndicesBioticos.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next

        For i As Integer = 0 To dgvEntrada.Rows.Count - 1
            Dim row As DataGridViewRow
            row = CType(dgvEntrada.Rows(i).Clone(), DataGridViewRow)
            For index As Int32 = 0 To dgvEntrada.Rows(i).Cells.Count - 1
                row.Cells(index).Value = dgvEntrada.Rows(i).Cells(index).Value
            Next
            dgvIndicesIndicesBioticos.Rows.Add(row)
        Next

        'Esconde todo aquello que no es indice biotico
        For i As Integer = 0 To dgvIndicesIndicesBioticos.Columns.Count - 1
            If dgvIndicesIndicesBioticos.Columns(i).HeaderText.ToString.Contains(" -") Or dgvIndicesIndicesBioticos.Columns(i).Name.ToString.Contains("_") Then
                dgvIndicesIndicesBioticos.Columns(i).Visible = False
            End If
        Next

        'GENERA COLUMNAS DE RESUMEN PARA CADA TIPO DE INDICE (macroinvertebrados, diatomeas, habitat, etc.)
        Dim cantidadcolsiniciales = dgvIndicesIndicesBioticos.Columns.GetColumnCount(DataGridViewElementStates.Visible)

        For i = 2 To dgvIndicesIndicesBioticos.Columns.Count - 1
            Dim nombreindice As String = dgvIndicesIndicesBioticos.Columns(i).HeaderText

            Dim mType As Type = Type.GetType("Scila7." & nombreindice.ToLower)
            If mType Is Nothing Then
                Continue For
            End If
            Dim mMethod As MethodInfo = mType.GetMethod("DefineTaxones" & nombreindice.ToUpper)
            Dim mValue As Object = mMethod.Invoke(mType, New Object() {"dummyparameter"})

            'cambia el tooltiptext de la col al tipo de indice
            dgvIndicesIndicesBioticos.Columns(i).ToolTipText = mValue

            If Not dgvIndicesIndicesBioticos.Columns.Contains("General" & mValue) Then
                Dim newcol As New DataGridViewTextBoxColumn
                newcol.Name = "General" & mValue
                newcol.HeaderText = "Resumen - " & mValue
                newcol.ToolTipText = 1
                newcol.CellTemplate.Style.Font = New Font("Arial", 10, FontStyle.Bold)
                newcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
                dgvIndicesIndicesBioticos.Columns.Add(newcol)
            Else
                'uso el tooltiptext de la nueva col para saber el total de indices de ese tipo
                dgvIndicesIndicesBioticos.Columns("General" & mValue).tooltiptext = dgvIndicesIndicesBioticos.Columns("General" & mValue).ToolTipText + 1
            End If
        Next

        ' RECUENTO POR ROWS Y ASIGNA A LAS NUEVAS COLUMNAS DE RESUMENES UN ARRAY DE VALORES
        For i = 0 To dgvIndicesIndicesBioticos.Rows.Count - 1
            Dim indicesarray(6) As String
            indicesarray(0) = 0
            indicesarray(1) = 0
            indicesarray(2) = 0
            indicesarray(3) = 0
            indicesarray(4) = 0
            indicesarray(5) = 0

            Dim indicetipocol As String

            For j = 2 To cantidadcolsiniciales - 1
                indicetipocol = dgvIndicesIndicesBioticos.Columns(j).ToolTipText
                If dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Red Then
                    If dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value IsNot Nothing Then
                        indicesarray = dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value.ToString.Split(";")
                        indicesarray(0) = indicesarray(0) + 1
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = indicesarray(0) & ";" & indicesarray(1) & ";" & indicesarray(2) & ";" & indicesarray(3) & ";" & indicesarray(4) & ";" & indicesarray(5)
                    Else
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = "1;0;0;0;0;0"
                    End If
                ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Orange Then
                    If dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value IsNot Nothing Then
                        indicesarray = dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value.ToString.Split(";")
                        indicesarray(1) = indicesarray(1) + 1
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = indicesarray(0) & ";" & indicesarray(1) & ";" & indicesarray(2) & ";" & indicesarray(3) & ";" & indicesarray(4) & ";" & indicesarray(5)
                    Else
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = "0;1;0;0;0;0"
                    End If
                ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Yellow Then
                    If dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value IsNot Nothing Then
                        indicesarray = dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value.ToString.Split(";")
                        indicesarray(2) = indicesarray(2) + 1
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = indicesarray(0) & ";" & indicesarray(1) & ";" & indicesarray(2) & ";" & indicesarray(3) & ";" & indicesarray(4) & ";" & indicesarray(5)
                    Else
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = "0;0;1;0;0;0"
                    End If
                ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Green Then
                    If dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value IsNot Nothing Then
                        indicesarray = dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value.ToString.Split(";")
                        indicesarray(3) = indicesarray(3) + 1
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = indicesarray(0) & ";" & indicesarray(1) & ";" & indicesarray(2) & ";" & indicesarray(3) & ";" & indicesarray(4) & ";" & indicesarray(5)
                    Else
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = "0;0;0;1;0;0"
                    End If
                ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Blue Then
                    If dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value IsNot Nothing Then
                        indicesarray = dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value.ToString.Split(";")
                        indicesarray(4) = indicesarray(4) + 1
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = indicesarray(0) & ";" & indicesarray(1) & ";" & indicesarray(2) & ";" & indicesarray(3) & ";" & indicesarray(4) & ";" & indicesarray(5)
                    Else
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = "0;0;0;0;1;0"
                    End If
                ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.LightGray Then
                    If dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value IsNot Nothing Then
                        indicesarray = dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value.ToString.Split(";")
                        indicesarray(5) = indicesarray(5) + 1
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = indicesarray(0) & ";" & indicesarray(1) & ";" & indicesarray(2) & ";" & indicesarray(3) & ";" & indicesarray(4) & ";" & indicesarray(5)
                    Else
                        dgvIndicesIndicesBioticos.Item("General" & indicetipocol, i).Value = "0;0;0;0;0;1"
                    End If
                End If
            Next
        Next

        'TIENE QUE TRADUCIR LO QUE RECIEN SE PUSO EN LAS COLUMNAS NUEVAS
        ' SI HAY DOS INDICES CON COLORES DISTINTOS, SE QUEDA CON EL MAS ALTO (ej: si un indice da rojo y otro naranja, se queda con rojo)
        For i = dgvIndicesIndicesBioticos.Columns.Count - 1 To 0 Step -1
            If dgvIndicesIndicesBioticos.Columns(i).Name.Contains("General") Then
                For j = 0 To dgvIndicesIndicesBioticos.Rows.Count - 1
                    If dgvIndicesIndicesBioticos.Item(i, j).Value Is Nothing Then
                        Continue For
                    End If
                    Dim indicesarray As String() = dgvIndicesIndicesBioticos.Item(i, j).Value.ToString.Split(";")
                    Dim irojo = indicesarray(0)
                    Dim inaranja = indicesarray(1)
                    Dim iamarillo = indicesarray(2)
                    Dim iverde = indicesarray(3)
                    Dim iazul = indicesarray(4)
                    Dim igris = indicesarray(5)

                    Dim higher As Integer = 0
                    For m As Integer = 0 To indicesarray.Length - 2
                        If indicesarray(m) > 0 And indicesarray(m) > indicesarray(higher) Then
                            higher = m
                        End If
                    Next
                    If higher = 0 Then
                        If irojo > 0 Then
                            dgvIndicesIndicesBioticos.Item(i, j).Style.BackColor = Color.Red
                            dgvIndicesIndicesBioticos.Item(i, j).Value = "Muy malo"
                        Else
                            dgvIndicesIndicesBioticos.Item(i, j).Style.BackColor = Color.LightGray
                            dgvIndicesIndicesBioticos.Item(i, j).Value = ""
                        End If
                    ElseIf higher = 1 Then
                        dgvIndicesIndicesBioticos.Item(i, j).Style.BackColor = Color.Orange
                        dgvIndicesIndicesBioticos.Item(i, j).Value = "Malo"
                    ElseIf higher = 2 Then
                        dgvIndicesIndicesBioticos.Item(i, j).Style.BackColor = Color.Yellow
                        dgvIndicesIndicesBioticos.Item(i, j).Value = "Regular"
                    ElseIf higher = 3 Then
                        dgvIndicesIndicesBioticos.Item(i, j).Style.BackColor = Color.Green
                        dgvIndicesIndicesBioticos.Item(i, j).Value = "Bueno"
                    ElseIf higher = 4 Then
                        dgvIndicesIndicesBioticos.Item(i, j).Style.BackColor = Color.Blue
                        dgvIndicesIndicesBioticos.Item(i, j).Value = "Muy bueno"
                    End If

                Next
            End If
        Next

        Dim numtipoindices As Integer
        Dim numtipoindicesarray(0) As String
        Dim numtipoindicesarrayttt(0) As String

        For i = dgvIndicesIndicesBioticos.Columns.Count - 1 To 0 Step -1
            If dgvIndicesIndicesBioticos.Columns(i).Name.Contains("General") Then
                numtipoindices = numtipoindices + 1
                Array.Resize(numtipoindicesarray, numtipoindicesarray.Length + 1)
                numtipoindicesarray(numtipoindicesarray.Length - 1) = dgvIndicesIndicesBioticos.Columns(i).HeaderText.Remove(0, 10)
                Array.Resize(numtipoindicesarrayttt, numtipoindicesarrayttt.Length + 1)
                numtipoindicesarrayttt(numtipoindicesarrayttt.Length - 1) = dgvIndicesIndicesBioticos.Columns(i).ToolTipText
            End If
        Next

        'RECUENTO TOTAL
        Dim rojos, amarillos, verdes, azules, grises, naranjas As Integer
        'comienza el recuento de muestras buenas y malas

        For i = 0 To dgvIndicesIndicesBioticos.Rows.Count - 1
            Dim valorrow As String
            For j As Integer = dgvIndicesIndicesBioticos.Columns.Count - 1 To 0 Step -1
                If dgvIndicesIndicesBioticos.Columns(j).Name.Contains("General") Then
                    If dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Red Then
                        rojos = rojos + 1
                    ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Orange Then
                        naranjas = naranjas + 1
                    ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Blue Then
                        azules = azules + 1
                    ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Green Then
                        verdes = verdes + 1
                    ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.Yellow Then
                        amarillos = amarillos + 1
                    ElseIf dgvIndicesIndicesBioticos.Item(j, i).Style.BackColor = Color.LightGray Then
                        grises = grises + 1
                    End If
                End If
            Next
        Next
        txtIndicesBioticosInterpret.Text = "Cantidad de índices que indican un muy mal estado biótico: " & rojos & vbNewLine
        txtIndicesBioticosInterpret.Text = txtIndicesBioticosInterpret.Text & "Cantidad de índices que indican un mal estado biótico: " & naranjas & vbNewLine
        txtIndicesBioticosInterpret.Text = txtIndicesBioticosInterpret.Text & "Cantidad de índices que indican un estado biótico regular: " & amarillos & vbNewLine
        txtIndicesBioticosInterpret.Text = txtIndicesBioticosInterpret.Text & "Cantidad de índices que indican un estado biótico bueno: " & verdes & vbNewLine
        txtIndicesBioticosInterpret.Text = txtIndicesBioticosInterpret.Text & "Cantidad de índices que indican un estado biótico muy bueno: " & azules & vbNewLine
        txtIndicesBioticosInterpret.Text = txtIndicesBioticosInterpret.Text & "Cantidad de índices que no pudieron determinar el estado biótico: " & grises & vbNewLine & vbNewLine
        txtIndicesBioticosInterpret.Text = txtIndicesBioticosInterpret.Text & "Tipos de indices bióticos: " & numtipoindices & "-> "
        For i As Integer = 0 To numtipoindicesarray.Length - 1
            If Not i = Nothing Then
                txtIndicesBioticosInterpret.Text = txtIndicesBioticosInterpret.Text & numtipoindicesarray(i) & "(" & numtipoindicesarrayttt(i) & ") - "
            End If

        Next

        ''ESCONDE LAS COLS QUE NO SON RESUMEN
        For i As Integer = dgvIndicesIndicesBioticos.Columns.Count - 1 To 2 Step -1
            If Not dgvIndicesIndicesBioticos.Columns(i).HeaderText.Contains("Resumen") Then
                dgvIndicesIndicesBioticos.Columns.RemoveAt(i)
            End If
        Next

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////// MENUES
    '///////////////////////////////////////
    '///////////////////////////////////////
    '///////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '
    Private Sub mnIndicesBioticosAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnIndicesBioticosAExcelToolStripMenuItem.Click
        ExportarDGVaXLS(dgvIndicesIndicesBioticos, "Indices Bióticos")
    End Sub

    Private Sub mnIndicesBioticosATextoDelimitadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnIndicesBioticosATextoDelimitadoToolStripMenuItem.Click
        ExportarDGVaCSV(dgvIndicesIndicesBioticos, "Indices Bióticos")
    End Sub

    ' EXPORTA LAS DATAGRIDS DE UNA MUESTRA TODAS JUNTAS

    Private Sub mnMuestraATextoDelimitadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnMuestraATextoDelimitadoToolStripMenuItem.Click
        Dim dgvtemp As New DataGridView

        'Copia la dgvMuestrasIndicesBioticos a dgvtemp, con valores y estilos
        For Each Col As DataGridViewColumn In dgvMuestrasIndicesBioticos.Columns
            dgvtemp.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next

        For i As Integer = 0 To dgvMuestrasIndicesBioticos.Rows.Count - 1
            Dim row As DataGridViewRow
            row = CType(dgvMuestrasIndicesBioticos.Rows(i).Clone(), DataGridViewRow)
            For index As Int32 = 0 To dgvMuestrasIndicesBioticos.Rows(i).Cells.Count - 1
                row.Cells(index).Value = dgvMuestrasIndicesBioticos.Rows(i).Cells(index).Value
            Next
            dgvtemp.Rows.Add(row)
        Next

        'A continuación, copia la dgvMuestrasIndicesEcologicos a dgvtemp, con valores y estilos
        dgvtemp.Rows.Add()
        'AGREGA HEADERS
        Dim headerrow1 As DataGridViewRow = CType(dgvMuestrasIndicesEcologicos.Rows(0).Clone(), DataGridViewRow)
        For i As Integer = 0 To dgvMuestrasIndicesEcologicos.Columns.Count - 1
            headerrow1.Cells(i).Value = dgvMuestrasIndicesEcologicos.Columns(i).HeaderText
        Next
        dgvtemp.Rows.Add(headerrow1)

        For i As Integer = 0 To dgvMuestrasIndicesEcologicos.Rows.Count - 1
            Dim row As DataGridViewRow
            row = CType(dgvMuestrasIndicesEcologicos.Rows(i).Clone(), DataGridViewRow)
            For index As Int32 = 0 To dgvMuestrasIndicesEcologicos.Rows(i).Cells.Count - 1
                row.Cells(index).Value = dgvMuestrasIndicesEcologicos.Rows(i).Cells(index).Value
            Next
            dgvtemp.Rows.Add(row)
        Next

        'A continuación, copia la dgvMuestrasDensidades a dgvtemp, con valores y estilos
        dgvtemp.Rows.Add()
        Dim newcol As New DataGridViewTextBoxColumn
        dgvtemp.Columns.Add(newcol)

        'AGREGA HEADERS
        Dim headerrow2 As DataGridViewRow = CType(dgvMuestrasDensidades.Rows(0).Clone(), DataGridViewRow)
        For i As Integer = 0 To dgvMuestrasDensidades.Columns.Count - 1
            headerrow2.Cells(i).Value = dgvMuestrasDensidades.Columns(i).HeaderText
        Next
        dgvtemp.Rows.Add(headerrow2)

        For i As Integer = 0 To dgvMuestrasDensidades.Rows.Count - 1
            Dim row As DataGridViewRow
            row = CType(dgvMuestrasDensidades.Rows(i).Clone(), DataGridViewRow)
            For index As Int32 = 0 To dgvMuestrasDensidades.Rows(i).Cells.Count - 1
                row.Cells(index).Value = dgvMuestrasDensidades.Rows(i).Cells(index).Value
            Next
            dgvtemp.Rows.Add(row)
        Next
        ExportarDGVaCSV(dgvtemp, tvInterpretacion.SelectedNode.Text)
    End Sub

    Private Sub mnMuestraAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnMuestraAExcelToolStripMenuItem.Click
        Dim dgvtemp As New DataGridView

        'Copia la dgvMuestrasIndicesBioticos a dgvtemp, con valores y estilos
        For Each Col As DataGridViewColumn In dgvMuestrasIndicesBioticos.Columns
            dgvtemp.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next

        For i As Integer = 0 To dgvMuestrasIndicesBioticos.Rows.Count - 1
            Dim row As DataGridViewRow
            row = CType(dgvMuestrasIndicesBioticos.Rows(i).Clone(), DataGridViewRow)
            For index As Int32 = 0 To dgvMuestrasIndicesBioticos.Rows(i).Cells.Count - 1
                row.Cells(index).Value = dgvMuestrasIndicesBioticos.Rows(i).Cells(index).Value
            Next
            dgvtemp.Rows.Add(row)
        Next

        'A continuación, copia la dgvMuestrasIndicesEcologicos a dgvtemp, con valores y estilos
        dgvtemp.Rows.Add()
        'AGREGA HEADERS
        Dim headerrow1 As DataGridViewRow = CType(dgvMuestrasIndicesEcologicos.Rows(0).Clone(), DataGridViewRow)
        For i As Integer = 0 To dgvMuestrasIndicesEcologicos.Columns.Count - 1
            headerrow1.Cells(i).Value = dgvMuestrasIndicesEcologicos.Columns(i).HeaderText
        Next
        dgvtemp.Rows.Add(headerrow1)

        For i As Integer = 0 To dgvMuestrasIndicesEcologicos.Rows.Count - 1
            Dim row As DataGridViewRow
            row = CType(dgvMuestrasIndicesEcologicos.Rows(i).Clone(), DataGridViewRow)
            For index As Int32 = 0 To dgvMuestrasIndicesEcologicos.Rows(i).Cells.Count - 1
                row.Cells(index).Value = dgvMuestrasIndicesEcologicos.Rows(i).Cells(index).Value
            Next
            dgvtemp.Rows.Add(row)
        Next

        'A continuación, copia la dgvMuestrasDensidades a dgvtemp, con valores y estilos
        dgvtemp.Rows.Add()
        Dim newcol As New DataGridViewTextBoxColumn
        dgvtemp.Columns.Add(newcol)

        'AGREGA HEADERS
        Dim headerrow2 As DataGridViewRow = CType(dgvMuestrasDensidades.Rows(0).Clone(), DataGridViewRow)
        For i As Integer = 0 To dgvMuestrasDensidades.Columns.Count - 1
            headerrow2.Cells(i).Value = dgvMuestrasDensidades.Columns(i).HeaderText
        Next
        dgvtemp.Rows.Add(headerrow2)

        For i As Integer = 0 To dgvMuestrasDensidades.Rows.Count - 1
            Dim row As DataGridViewRow
            row = CType(dgvMuestrasDensidades.Rows(i).Clone(), DataGridViewRow)
            For index As Int32 = 0 To dgvMuestrasDensidades.Rows(i).Cells.Count - 1
                row.Cells(index).Value = dgvMuestrasDensidades.Rows(i).Cells(index).Value
            Next
            dgvtemp.Rows.Add(row)
        Next
        ExportarDGVaXLS(dgvtemp, tvInterpretacion.SelectedNode.Text)
    End Sub
End Class