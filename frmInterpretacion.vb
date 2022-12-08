Imports System.Reflection
Public Class frmInterpretacion
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
        lblNombreMuestra.Text = dgvEntrada.Item("Nombre", idmuestraactual).Value.ToString

        'Pasa todos los valores a las dgv de Indices
        For i As Integer = 2 To dgvEntrada.ColumnCount - 1
            If dgvEntrada.Columns(i).HeaderText.Contains(" -") Then
                Dim namearray As String() = dgvEntrada.Columns(i).HeaderText.Split(" -")
                dgvMuestrasIndicesEcologicos.Rows.Add(New String() {namearray(2), namearray(0), dgvEntrada.Item(i, idmuestraactual).Value, dgvEntrada.Item(i, idmuestraactual).ToolTipText})
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
                        If Not dgvMuestrasDensidades.Item(3, k).Value = "Sin datos" Then
                            densidadtotalcomunidad = densidadtotalcomunidad + CDbl(dgvMuestrasDensidades.Item(3, k).Value)
                        End If

                    End If
                Next k
                dgvMuestrasDensidades.Rows.Add(nombresarray(i), indicesarray(j), "Total", densidadtotalcomunidad, "100%")
            Next j
        Next i

        'Calcula los %
        For i As Integer = 0 To dgvMuestrasDensidades.RowCount - 1
            If dgvMuestrasDensidades.Item(3, i).Value = Nothing Then
                Continue For
            End If

            If Not dgvMuestrasDensidades.Item(3, i).Value.ToString = "Sin datos" Then
                Dim densidadactual As Double = dgvMuestrasDensidades.Item(3, i).Value
            Else
                Continue For
            End If

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
    '/////////////////////////////////////// MENUES
    '///////////////////////////////////////
    '///////////////////////////////////////
    '///////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class