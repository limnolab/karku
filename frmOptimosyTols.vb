Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text
Imports System.IO

Public Class frmOptimosyTols
    Dim cuantasmuestras As Integer
    Dim cuantassp As Integer
    Dim cuantosFQ As Integer



    Private Sub btnCargaSpXMuestras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaSpXMuestras.Click
        Dim input1 As String
        Dim input2 As String
        Dim input3 As String


        'PREPARA LAS PLANILLAS
        PlanillaFqXMuestras.Rows.Clear()
        PlanillaFqXMuestras.Columns.Clear()
        PlanillaResultados.Columns.Clear()
        PlanillaResultados.Rows.Clear()
        PlanillaResumen.Columns.Clear()
        PlanillaResumen.Rows.Clear()
        PlanillaSpXMuestras.Columns.Clear()
        PlanillaSpXMuestras.Rows.Clear()
        PlanillaTolerancia.Rows.Clear()
        PlanillaTolerancia.Columns.Clear()

        input1 = InputBox("Cuántas muestras desea ingresar?", , "3")
        If input1.Length = 0 Then
            Exit Sub
        Else
            cuantasmuestras = CInt(input1)
        End If

        input2 = InputBox("Cuántas especies desea ingresar?", , "3")
        If input2.Length = 0 Then
            Exit Sub
        Else
            cuantassp = CInt(input2)
        End If

        input3 = InputBox("Cuántos parámetros físico-químicos desea ingresar?", , "3")
        If input3.Length = 0 Then
            Exit Sub
        Else
            cuantosFQ = CInt(input3)
        End If

        ProgressBar1.Value = 0
        Dim progresstotal As Integer = cuantasmuestras

        Dim spnames As New DataGridViewTextBoxColumn
        Dim fqnames As New DataGridViewTextBoxColumn
        Dim fqresnames As New DataGridViewTextBoxColumn

        spnames.Name = "spnames"
        fqnames.Name = "fqnames"
        fqresnames.Name = "fqresnames"
        spnames.HeaderText = "Especies"
        fqnames.HeaderText = "Parámetro FQ"
        fqresnames.HeaderText = "Parámetro FQ"

        PlanillaSpXMuestras.Columns.Add(spnames)
        PlanillaFqXMuestras.Columns.Add(fqnames)
        PlanillaResultados.Columns.Add(fqresnames)

        For i As Integer = 0 To cuantasmuestras - 1
            ProgressBar1.Value = (i * 100) / progresstotal
            Dim ncsp As New DataGridViewTextBoxColumn
            Dim ncfq As New DataGridViewTextBoxColumn
            Dim ncres As New DataGridViewTextBoxColumn

            ncsp.Name = "muestra " & i.ToString
            PlanillaSpXMuestras.Columns.Add(ncsp)
            ncfq.Name = "muestra " & i.ToString
            PlanillaFqXMuestras.Columns.Add(ncfq)
            ncres.Name = "muestra " & i.ToString
            PlanillaResultados.Columns.Add(ncres)
        Next

        PlanillaSpXMuestras.Rows.Add(cuantassp - 1)
        PlanillaFqXMuestras.Rows.Add(cuantosFQ - 1)
        PlanillaResultados.Rows.Add(cuantosFQ - 1)

        btnPegarAbu.Enabled = True
        btnPegarFQ.Enabled = True
        btnCargaSpXMuestras.Enabled = False
        btnCalcular.Enabled = True
        ProgressBar1.Value = 0

    End Sub

    Public Sub PasteData(ByRef dgv As DataGridView)
        Dim tArr() As String
        Dim arT() As String
        Dim i, ii As Integer
        Dim c, cc, r As Integer

        tArr = Clipboard.GetText().Split(Environment.NewLine)
        r = 0
        c = 0
        For i = 0 To tArr.Length - 1
            If tArr(i) <> "" Then
                arT = tArr(i).Split(vbTab)
                cc = c
                For ii = 0 To arT.Length - 1
                    If cc > dgv.ColumnCount - 1 Then Exit For
                    If r > dgv.Rows.Count - 1 Then Exit Sub
                    With dgv.Item(cc, r)
                        .Value = arT(ii).TrimStart
                    End With
                    cc = cc + 1
                Next
                r = r + 1
            End If
        Next

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPegarAbu.Click
        PasteData(PlanillaSpXMuestras)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPegarFQ.Click
        PasteData(PlanillaFqXMuestras)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        If PlanillaFqXMuestras.RowCount = 0 Then
            MsgBox("Debe ingresar datos físico-químicos")
            Exit Sub
        End If
        If PlanillaSpXMuestras.RowCount = 0 Then
            MsgBox("Debe ingresar las abundancias relativas de las especies")
            Exit Sub
        End If

        If IsNumeric(PlanillaSpXMuestras.Item(0, 1).Value) = True Then
            MsgBox("La primera columna de la matriz de ESPECIES x MUESTRAS no puede ser numérica. Debe contener los nombres de las especies.")
            Exit Sub
        End If

        If IsNumeric(PlanillaFqXMuestras.Item(0, 1).Value) = True Then
            MsgBox("La primera columna de la matriz de FÍSICOQUÍMICOS x MUESTRAS no puede ser numérica. Debe contener los nombres de los parámetros físico-químicos a considerar.")
            Exit Sub
        End If

        If IsNumeric(PlanillaFqXMuestras.Item(1, 0).Value) = False Then
            MsgBox("La primera fila de la matriz de FÍSICOQUÍMICOS x MUESTRAS no debe incluir los nombres de las muestras.")
            Exit Sub
        End If

        If IsNumeric(PlanillaSpXMuestras.Item(1, 0).Value) = False Then
            MsgBox("La primera fila de la matriz de ESPECIES x MUESTRAS no debe incluir los nombres de las muestras.")
            Exit Sub
        End If

        Dim spactual As Integer = 0


        ' DESPUES PASA POR TOOOOODOS LAS DENISDADES Y LAS PASA A ABUNDANCIAS RELATIVAS
        If radDensidades.Checked = True Then
            Dim cuidado As Integer = MessageBox.Show("Las densidades de las especies serán convertidas a abundancias relativas en cada muestra", "Cuidado!", MessageBoxButtons.OKCancel)
            If cuidado = DialogResult.Cancel Then
                Exit Sub
            End If

            Dim abutotal As Double
            For i = 1 To PlanillaSpXMuestras.Columns.Count - 1
                For j = 0 To PlanillaSpXMuestras.Rows.Count - 1
                    abutotal = abutotal + CDbl(PlanillaSpXMuestras.Item(i, j).Value)
                Next
                For j = 0 To PlanillaSpXMuestras.Rows.Count - 1
                    PlanillaSpXMuestras.Item(i, j).Value = (CDbl(PlanillaSpXMuestras.Item(i, j).Value) * 100) / abutotal
                Next
            Next
        End If


        ProgressBar1.Value = 0
        Dim progress As Integer

        ' PRIMERO PASA POR TOOOODOS LOS FQ Y CONVIERTE LOS ? Y LOS BLANCOS EN MD

        For i = 0 To PlanillaFqXMuestras.RowCount - 1
            For j = 1 To PlanillaFqXMuestras.ColumnCount - 1
                If IsNumeric(PlanillaFqXMuestras.Item(j, i).Value) = False Then
                    PlanillaFqXMuestras.Item(j, i).Value = "MD"
                End If
            Next
        Next

        ' DESPUES PASA POR TOOOOODOS LOS FQ Y CONVIERTE LOS VALORES FQ EN LOGARITMO
        If radRawData.Checked = True Then
            Dim cuidado As Integer = MessageBox.Show("Ha indicado que los valores físico-químicos ingresados son datos crudos. Para calcular los óptimos, los datos deben estar en Logaritmo (base 10). Desea que el software los convierta automáticamente?", "Cuidado!", MessageBoxButtons.YesNo)
            If cuidado = DialogResult.No Then
                MsgBox("Se cancelará el calculo")
                Exit Sub
            End If

            For i = 0 To PlanillaFqXMuestras.RowCount - 1
                For j = 1 To PlanillaFqXMuestras.ColumnCount - 1
                    If PlanillaFqXMuestras.Item(j, i).Value.ToString <> "MD" Then
                        PlanillaFqXMuestras.Item(j, i).Value = Math.Log10(PlanillaFqXMuestras.Item(j, i).Value)
                    End If
                Next
            Next
        End If

        Try
            progress = PlanillaSpXMuestras.Rows.Count - 1
            For spactual = 0 To PlanillaSpXMuestras.Rows.Count - 1

                ProgressBar1.Value = (spactual * 100) / progress
                CalcularAxB(spactual)

                ' LIMPIA Y RESETEA PLANILLARESULTADOS
                For i = 0 To PlanillaResultados.Rows.Count - 1
                    For k As Integer = 0 To PlanillaResultados.Columns.Count - 1
                        PlanillaResultados.Item(k, i).Value = ""
                    Next
                Next
                PlanillaResultados.Columns.Remove("sumyxx")
                PlanillaResultados.Columns.Remove("sumy")
                PlanillaResultados.Columns.Remove("hrhs")
                PlanillaResultados.Columns.Remove("antilog")
                PlanillaTolerancia.Rows.Clear()
                PlanillaTolerancia.Columns.Clear()

            Next

        Catch ex As Exception
            MsgBox("Error calculando optimos. Revise que los datos sean correctos")
            'deshabilita los botones, para comenzar de nuevo
            btnCalcular.Enabled = True
            btnPegarAbu.Enabled = True
            btnPegarFQ.Enabled = True
            btnCargaSpXMuestras.Enabled = True

            'PREPARA LAS PLANILLAS
            PlanillaResumen.Columns.Clear()
            PlanillaResumen.Rows.Clear()
            PlanillaResultados.Columns.Remove("sumyxx")
            PlanillaResultados.Columns.Remove("sumy")
            PlanillaResultados.Columns.Remove("hrhs")
            PlanillaResultados.Columns.Remove("antilog")
            PlanillaTolerancia.Rows.Clear()
            PlanillaTolerancia.Columns.Clear()

            ' LIMPIA Y RESETEA PLANILLARESULTADOS
            For i = 0 To PlanillaResultados.Rows.Count - 1
                For k As Integer = 0 To PlanillaResultados.Columns.Count - 1
                    PlanillaResultados.Item(k, i).Value = ""
                Next
            Next

            Exit Sub
        End Try
        '' Y SI TOOOOODOS LOS DATOS FQ SE CONVIRTIERON A LOG, LOS VUELVE A CRUDOS

        If radRawData.Checked = True Then
            For i = 0 To PlanillaFqXMuestras.RowCount - 1
                For j = 1 To PlanillaFqXMuestras.ColumnCount - 1
                    If PlanillaFqXMuestras.Item(j, i).Value.ToString <> "MD" Then
                        PlanillaFqXMuestras.Item(j, i).Value = Math.Pow(10, PlanillaFqXMuestras.Item(j, i).Value)
                    End If
                Next
            Next
        End If

        'deshabilita los botones, para comenzar de nuevo
        btnCalcular.Enabled = False
        btnPegarAbu.Enabled = False
        btnPegarFQ.Enabled = False
        btnCargaSpXMuestras.Enabled = True

        MsgBox("Óptimos y tolerancias calculados!")
        ProgressBar1.Value = 0


    End Sub

    Private Sub CalcularAxB(ByVal spactual As Integer)
        ' ESTO CALCULA AxB PARA UNA ESPECIE FIJA (spactual)
        Dim i, j As Integer
        Dim abrelativa As String
        Dim logfq As String
        Dim resultadoaxb As Double


        ' pasa los nombres de los parametros fq a resultados
        For i = 0 To PlanillaFqXMuestras.Rows.Count - 1
            PlanillaResultados.Item(0, i).Value = PlanillaFqXMuestras.Item(0, i).Value
        Next

        ' HACE ABRELATIVA DE LA SPACTUAl x LOGFQ Y LO CARGA EN PLANILLA RESULTADOS

        For i = 0 To PlanillaFqXMuestras.RowCount - 1
            For j = 1 To PlanillaFqXMuestras.ColumnCount - 1
                abrelativa = PlanillaSpXMuestras.Item(j, spactual).Value.ToString
                logfq = PlanillaFqXMuestras.Item(j, i).Value.ToString
                If abrelativa = "?" Or logfq = "?" Or logfq = "" Or logfq = "MD" Then
                    PlanillaResultados.Item(j, i).Value = "MD"
                Else
                    resultadoaxb = CDbl(abrelativa) * CDbl(logfq)
                    PlanillaResultados.Item(j, i).Value = resultadoaxb
                End If
            Next j
        Next
        CalcularSums(spactual)
    End Sub

    Private Sub CalcularSums(ByVal spactual As Integer)
        Dim i, k As Integer
        PlanillaResultados.Columns.Add("sumyxx", "SUMy * x desde i hasta n")
        PlanillaResultados.Columns.Add("sumy", "SUMy desde i hasta n")
        ' CALCULA SUMYXX

        Dim sumyxx As Double
        For i = 0 To PlanillaResultados.RowCount - 1
            sumyxx = 0
            For k = 1 To PlanillaResultados.ColumnCount - 2
                If PlanillaResultados.Columns(k).Name = "sumyxx" Then
                    PlanillaResultados.Item(k, i).Value = sumyxx.ToString
                Else
                    If Not PlanillaResultados.Item(k, i).Value.ToString = "MD" Then
                        sumyxx = sumyxx + CDbl(PlanillaResultados.Item(k, i).Value)
                    End If
                End If
            Next k
        Next i


        ' CALCULA sumy EN LA PLANILLA DE SPXMuestras
        ' ESTO DEBE SUMAR SOLO SI ESTA EL FQ PARA ESA MUESTRA
        Dim o, p As Integer
        Dim sumy As Double

        For o = 0 To PlanillaFqXMuestras.RowCount - 1
            sumy = 0
            For p = 1 To PlanillaSpXMuestras.ColumnCount - 1
                If PlanillaFqXMuestras.Item(p, o).Value.ToString <> "MD" Then
                    sumy = sumy + CDbl(PlanillaSpXMuestras.Item(p, spactual).Value)
                End If
            Next p
            ' y carga el resultado en resultados
            For k = 1 To PlanillaResultados.ColumnCount - 1
                If PlanillaResultados.Columns(k).Name = "sumy" Then
                    PlanillaResultados.Item(k, o).Value = sumy
                End If
            Next k
        Next o
        CalcularOptimo(spactual)
    End Sub

    Private Sub CalcularOptimo(ByVal spactual As Integer)
        Dim sumyxx As Double
        Dim sumy As Double

        PlanillaResultados.Columns.Add("hrhs", "HR/HS")
        PlanillaResultados.Columns.Add("antilog", "Optimo")

        ' CALCULA HR/HS EN LA PLANILLA DE RESULTADOS
        Dim hrhs As Double
        sumy = 0
        sumyxx = 0
        For i = 0 To PlanillaResultados.RowCount - 1
            For k = 1 To PlanillaResultados.ColumnCount - 1
                If PlanillaResultados.Columns(k).Name = "sumyxx" Then
                    sumyxx = CDbl(PlanillaResultados.Item(k, i).Value.ToString)
                ElseIf PlanillaResultados.Columns(k).Name = "sumy" Then
                    sumy = CDbl(PlanillaResultados.Item(k, i).Value.ToString)
                End If
                If sumy <> 0 And sumyxx <> 0 And PlanillaResultados.Columns(k).Name = "hrhs" Then
                    hrhs = sumyxx / sumy
                    PlanillaResultados.Item(k, i).Value = hrhs.ToString
                End If
            Next
        Next i

        ' CALCULA OPTIMO (Antilog de hrhs)
        Dim optimo As Double
        For i = 0 To PlanillaResultados.RowCount - 1
            For k = 1 To PlanillaResultados.ColumnCount - 1
                If PlanillaResultados.Columns(k).Name = "hrhs" Then
                    optimo = CDbl(PlanillaResultados.Item(k, i).Value.ToString)
                    optimo = Math.Pow(10, optimo)
                End If
                If PlanillaResultados.Columns(k).Name = "antilog" And optimo <> 0 Then
                    PlanillaResultados.Item(k, i).Value = optimo.ToString
                End If

            Next
        Next
        pasarOptimoaResumen(spactual)
    End Sub


    Private Sub pasarOptimoaResumen(ByVal spactual As Integer)
        Dim i, k As Integer

        ' CONFIGURA EL RESUMEN
        Dim nombresp As String
        nombresp = PlanillaSpXMuestras.Item(0, spactual).Value.ToString

        Dim nombrefq As String
        If spactual = 0 Then
            PlanillaResumen.Columns.Add("sp", "Especie")
            PlanillaResumen.Rows.Add()

            For i = 0 To PlanillaResultados.Rows.Count - 1
                nombrefq = PlanillaResultados.Item(0, i).Value.ToString
                PlanillaResumen.Columns.Add("fq" & i & "opt", nombrefq & " - Optimo")
                PlanillaResumen.Item("fq" & i & "opt", 0).Value = nombrefq & " - Optimo"
                PlanillaResumen.Columns.Add("fq" & i & "max", nombrefq & " - MAX")
                PlanillaResumen.Item("fq" & i & "max", 0).Value = nombrefq & " - MAX"
                PlanillaResumen.Columns.Add("fq" & i & "min", nombrefq & " - MIN")
                PlanillaResumen.Item("fq" & i & "min", 0).Value = nombrefq & " - MIN"
            Next
        End If


        ' agrega rows
        PlanillaResumen.Rows.Add()
        Dim currentrowindex As Integer = PlanillaResumen.Rows.Count - 2

        ' PASA LOS OPTIMOS AL RESUMEN
        PlanillaResumen.Item(0, currentrowindex).Value = nombresp

        Dim valoroptimo As Double
        Dim columnaoptimoindex As Integer
        columnaoptimoindex = PlanillaResultados.Columns("antilog").Index
        Dim columnaoptimoresumen As Integer = 1

        For k = 0 To PlanillaResultados.Rows.Count - 1
            valoroptimo = CDbl(PlanillaResultados.Item(columnaoptimoindex, k).Value)
            PlanillaResumen.Item(columnaoptimoresumen, currentrowindex).Value = valoroptimo
            columnaoptimoresumen = columnaoptimoresumen + 3
        Next
        calcularTolerancia(spactual)
    End Sub

    Private Sub calcularTolerancia(ByVal spactual As Integer)
        Dim i, j, m As Integer
        Dim fqxoptimo As Double = 0
        Dim optimocolindex As Integer = 0
        Dim valoroptimo As Double = 0
        Dim columnamaxresumen As Integer = 2
        Dim columnaminresumen As Integer = 3
        Dim valorsumayindex As Integer
        Dim valorsumay As Double = 0
        'spactual = spactual + 1

        optimocolindex = PlanillaResultados.Columns("hrhs").Index
        valorsumayindex = PlanillaResultados.Columns("sumy").Index

        PlanillaTolerancia.Columns.Add("fqxoptimo", "fqxoptimo")
        PlanillaTolerancia.Rows.Add(cuantosFQ - 1)


        Dim parteA As Double
        Dim abrelativa As Double

        For i = 0 To PlanillaFqXMuestras.Rows.Count - 1
            valoroptimo = CDbl(PlanillaResultados.Item(optimocolindex, i).Value)
            fqxoptimo = 0
            valorsumay = CDbl(PlanillaResultados.Item(valorsumayindex, i).Value)
            For j = 1 To PlanillaFqXMuestras.Columns.Count - 1
                If Not PlanillaFqXMuestras.Item(j, i).Value.ToString = "MD" Then
                    parteA = Math.Pow((CDbl(PlanillaFqXMuestras.Item(j, i).Value) - valoroptimo), 2)
                    abrelativa = CDbl(PlanillaSpXMuestras.Item(j, spactual).Value)
                    fqxoptimo = fqxoptimo + (parteA * abrelativa)
                ElseIf PlanillaFqXMuestras.Item(j, i).Value.ToString = "MD" Then
                    parteA = 0
                End If
            Next j
            fqxoptimo = Math.Sqrt(fqxoptimo / valorsumay)
            PlanillaTolerancia.Item(0, i).Value = fqxoptimo
        Next i
        ' PASA LAS TOLERANCIAS AL RESUMEN
        Dim hrhs As Double
        Dim max As Double
        For m = 0 To PlanillaTolerancia.Rows.Count - 1
            hrhs = CDbl(PlanillaResumen.Item(columnamaxresumen - 1, spactual + 1).Value)
            hrhs = Math.Log10(hrhs)
            max = hrhs + CDbl(PlanillaTolerancia.Item(0, m).Value)
            PlanillaResumen.Item(columnamaxresumen, spactual + 1).Value = Math.Pow(10, (hrhs + CDbl(PlanillaTolerancia.Item(0, m).Value)))
            PlanillaResumen.Item(columnamaxresumen + 1, spactual + 1).Value = Math.Pow(10, (hrhs - CDbl(PlanillaTolerancia.Item(0, m).Value)))
            columnamaxresumen = columnamaxresumen + 3
        Next
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim filepath As String
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Archivos de Excel 2007-2010(*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try

                filepath = saveFileDialog1.FileName

                ' AGREGA SHEETS DE FINAL A PRINCIPIO
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                Dim xlApp As New Microsoft.Office.Interop.Excel.Application
                Dim excelBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add


                Dim rowsTotal, colsTotal As Short
                Dim I, j, iC As Short
                Dim k, m As Short

                Dim excelWorksheet As Excel.Worksheet
                excelWorksheet = DirectCast(excelBook.Sheets.Add(, Count:=1, Type:=Excel.XlSheetType.xlWorksheet), Excel.Worksheet)
                Try
                    rowsTotal = PlanillaResumen.RowCount - 1
                    colsTotal = PlanillaResumen.Columns.Count - 1

                    With excelWorksheet
                        .Name = "Optimos"
                        .Cells.Select()
                        .Cells.Delete()
                        ' PONE LOS HEADERS
                        'For iC = 0 To colsTotal
                        '    k = PlanillaResumen.Columns(iC).DisplayIndex
                        '    .Cells(1, k + 1).Value = PlanillaResumen.Columns(iC).HeaderText
                        'Next

                        'PONE LOS VALORES
                        For I = 0 To rowsTotal
                            For j = 0 To colsTotal
                                m = PlanillaResumen.Columns(j).DisplayIndex
                                .Cells(I + 2, m + 1).value = PlanillaResumen.Rows(I).Cells(j).Value
                            Next j
                        Next I

                        .Rows("1:1").Font.FontStyle = "Bold"
                        .Cells.Columns.AutoFit()
                        .Cells.Select()
                        .Cells.EntireColumn.AutoFit()
                        .Cells(1, 1).Select()
                    End With

                Catch ex As Exception
                    MsgBox("Error al exportar: " & ex.Message)
                Finally

                    'RELEASE ALLOACTED RESOURCES  
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    xlApp = Nothing
                End Try
                excelBook.SaveAs(filepath)
                MsgBox("Archivo XLS finalizado!")

            Catch ex As Exception
                MsgBox("No fue posible grabar el archivo XLS. Compruebe que el archivo no este abierto o en uso.")
            End Try

        End If

    End Sub


End Class
