Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text
Imports System.IO

Module Export


    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////
    '////////       EXPORTAR A EXCEL
    '////////
    '////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    Public Sub ExportarDGVaXLS(datagridentrada As DataGridView, nombresheet As String)

        Dim filepath As String
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Archivos de Excel 2007-2010(*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            filepath = saveFileDialog1.FileName

            ' AGREGA SHEETS DE FINAL A PRINCIPIO
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim xlApp As New Microsoft.Office.Interop.Excel.Application
            Dim excelBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add

            ExportarExcel(xlApp, excelBook, datagridentrada, nombresheet)
            xlApp.DisplayAlerts = False
            excelBook.SaveAs(filepath)
            xlApp.Visible = True
        End If

    End Sub


    Private Sub ExportarExcel(ByVal xlApp As Microsoft.Office.Interop.Excel.Application, ByVal excelBook As Microsoft.Office.Interop.Excel.Workbook, ByVal datagridview As DataGridView, ByVal sheetname As String)
        Dim iC As Short
        Dim k, z, x As Short
        Dim excelWorksheet As Excel.Worksheet
        excelWorksheet = DirectCast(excelBook.Sheets.Add(, Count:=1, Type:=Excel.XlSheetType.xlWorksheet), Excel.Worksheet)
        If sheetname.Length >= 30 Then
            sheetname = sheetname.Substring(0, 30)
        End If
        excelWorksheet.Name = sheetname

        ' PONE LOS HEADERS
        Dim colstotal As Integer = datagridview.Columns.Count - 1
        For iC = 0 To colstotal
            k = datagridview.Columns(iC).DisplayIndex
            excelWorksheet.Cells(1, k + 1).Value = datagridview.Columns(iC).HeaderText
        Next

        'PONE LOS VALORES COMO UN RANGE
        Dim array(datagridview.Rows.Count, datagridview.Columns.Count) As String
        For z = 0 To datagridview.Rows.Count - 1
            For x = 0 To datagridview.Columns.Count - 1
                If datagridview(x, z).Value IsNot Nothing Then
                    array(z, x) = datagridview(x, z).Value.ToString
                End If
            Next
        Next

        'PASA LOS VALORES
        excelWorksheet.Range("A2:" & ConvertToLetter(datagridview.Columns.Count) & datagridview.Rows.Count + 1).Value = array

        'PINTA LAS CELDA
        For z = 0 To datagridview.Rows.Count - 1
            For x = 0 To datagridview.Columns.Count - 1
                If datagridview.Item(x, z).Value IsNot Nothing Then
                    If Not datagridview.Item(x, z).Style.BackColor.Name = "0" Then
                        excelWorksheet.Cells(z + 2, x + 1).Interior.Color = datagridview.Item(x, z).Style.BackColor
                    End If
                End If
            Next
        Next

        'RELEASE ALLOCATED RESOURCES  
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        xlApp = Nothing
        MsgBox("Archivos exportados exitosamente")
    End Sub

    'ESTA FUNCION CONVIERTE UNA CANTIDAD A SU EQUIVALENTE EN LETRAS... SIRVE PARA LA EXPORT DE EXCEL, PARA SETEAR EL RANGO
    Function ConvertToLetter(iCol As Integer) As String
        Dim iAlpha As Integer
        Dim iRemainder As Integer
        iAlpha = Int(iCol / 27)
        iRemainder = iCol - (iAlpha * 26)
        If iAlpha > 0 Then
            ConvertToLetter = Chr(iAlpha + 64)
        End If
        If iRemainder > 0 Then
            ConvertToLetter = ConvertToLetter & Chr(iRemainder + 64)
        End If
    End Function


    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////
    '////////       EXPORTAR A CSV
    '////////
    '////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////

    Public Sub ExportarDGVaCSV(datagridentrada As DataGridView, sheetname As String)


        Dim delimitador As String
        Dim filepath As String
        Dim saveFileDialog1 As New SaveFileDialog()

        'PREGUNTA EL DELIMITADOR
        delimitador = InputBox("Ingrese caracter delimitador (por defecto: coma)", "Ingrese caracter", ",")
        If delimitador.Length = 0 Then
            Exit Sub
        End If


        saveFileDialog1.Title = "Guarda la planilla de datos " & sheetname
        saveFileDialog1.Filter = "Archivos delimitados por coma (*.csv)|*.csv|Todos los archivos (*.*)|*.*"
        saveFileDialog1.FileName = sheetname
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            filepath = saveFileDialog1.FileName
            ExportarCSV(datagridentrada, filepath, delimitador)
        End If

        MsgBox("Archivos exportados exitosamente")
    End Sub

    Private Sub ExportarCSV(ByVal datagridview As DataGridView, ByVal filepath As String, ByVal delimitador As String)

        Dim sr As StreamWriter = File.CreateText(filepath)
        Dim strDelimiter As String = delimitador
        Dim intColumnCount As Integer = datagridview.Columns.Count - 1
        Dim strRowData As String = ""

        For intX As Integer = 0 To intColumnCount

            strRowData += Replace(datagridview.Columns(intX).HeaderText, strDelimiter, "") & _
                IIf(intX < intColumnCount, strDelimiter, "")
        Next intX

        sr.WriteLine(strRowData)

        For intX As Integer = 0 To datagridview.Rows.Count - 1
            strRowData = ""
            For intRowData As Integer = 0 To intColumnCount
                strRowData += Replace(datagridview.Rows(intX).Cells(intRowData).Value, strDelimiter, "") & _
                    IIf(intRowData < intColumnCount, strDelimiter, "")
            Next intRowData

            sr.WriteLine(strRowData)
        Next intX

        sr.Close()
    End Sub

End Module
