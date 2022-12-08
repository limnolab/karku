﻿Public Class frmIERPlata1m

    Private Sub frmIERPlata1m_Load_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Show()
    End Sub
    Private Sub CalcularIBIDPlata()
        Dim dencyano As Integer = Val(CianoDensidadTextBox.Text)
        Dim totalphyto As Integer = Val(FitoDensidadTextBox.Text)
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


        'CALCULO EL IBIDPLATA
        IBIDPlatavalue = (dencyanoumbral + totalphytoumbral + mtdiatomsumbral + tanaidsumbral) / 4
        IndiceTextBox.Text = IBIDPlatavalue
    End Sub

    Private Sub MostrarMuestra()
        Dim nombremuestra As String = txtNombreMuestra.Text
        Dim idmuestra As Integer = 0
        Dim valorierplata As String = IndiceTextBox.Text
        Dim i As Integer

        i = MuestrasDataGrid.RowCount
        idmuestra = i + 1

        If txtNombreMuestra.Text = "" Then
            MuestrasDataGrid.Rows.Add(idmuestra, valorierplata)
        Else
            MuestrasDataGrid.Rows.Add(nombremuestra, valorierplata)
        End If

        CianoDensidadTextBox.Text = ""
        DiatoDensidadTextBox.Text = ""
        FitoDensidadTextBox.Text = ""
        TanaidsTextBox.Text = ""
        IndiceTextBox.Text = ""

    End Sub

    Private Sub btnBorrarMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarMuestra.Click
        If MuestrasDataGrid.RowCount <> 0 Then
            MuestrasDataGrid.Rows.Remove(MuestrasDataGrid.CurrentRow)
        Else
            MsgBox("No ha agregado muestras todavia!")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim pathdestino As String
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            pathdestino = saveFileDialog1.FileName.ToString
            pathdestino = pathdestino & ".xml"
            exportExcel(MuestrasDataGrid, pathdestino)
        End If
    End Sub

    Public Sub exportExcel(ByVal grdView As DataGridView, ByVal filePath As String)

        ' Open the file and write the headers
        Dim fs As New IO.StreamWriter(filePath, False)
        fs.WriteLine("<?xml version=""1.0""?>")
        fs.WriteLine("<?mso-application progid=""Excel.Sheet""?>")
        fs.WriteLine("<ss:Workbook xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet"">")
        ' Create the styles for the worksheet
        fs.WriteLine("  <ss:Styles>")
        ' Style for the column headers
        fs.WriteLine("    <ss:Style ss:ID=""1"">")
        fs.WriteLine("      <ss:Font ss:Bold=""1""/>")
        fs.WriteLine("      <ss:Alignment ss:Horizontal=""Center"" ss:Vertical=""Center"" " & _
            "ss:WrapText=""1""/>")
        fs.WriteLine("      <ss:Interior ss:Color=""#C0C0C0"" ss:Pattern=""Solid""/>")
        fs.WriteLine("    </ss:Style>")
        ' Style for the column information
        fs.WriteLine("    <ss:Style ss:ID=""2"">")
        fs.WriteLine("      <ss:Alignment ss:Vertical=""Center"" ss:WrapText=""1""/>")
        fs.WriteLine("    </ss:Style>")
        fs.WriteLine("  </ss:Styles>")
        ' Write the worksheet contents
        fs.WriteLine("<ss:Worksheet ss:Name=""Measurement Results"">")
        fs.WriteLine("  <ss:Table>")
        For i As Integer = 0 To grdView.Columns.Count - 1
            fs.WriteLine(String.Format("    <ss:Column ss:Width=""{0}""/>", _
            grdView.Columns.Item(i).Width))
        Next
        fs.WriteLine("    <ss:Row>")
        For i As Integer = 0 To grdView.Columns.Count - 1
            fs.WriteLine(String.Format("      <ss:Cell ss:StyleID=""1"">" & _
                "<ss:Data ss:Type=""String"">{0}</ss:Data></ss:Cell>", _
                grdView.Columns.Item(i).HeaderText))
        Next
        fs.WriteLine("    </ss:Row>")

        ' Check for an empty row at the end due to Adding allowed on the DataGridView
        Dim subtractBy As Integer, cellText As String
        If grdView.AllowUserToAddRows = True Then subtractBy = 2 Else subtractBy = 1
        ' Write contents for each cell
        For i As Integer = 0 To grdView.RowCount - subtractBy
            fs.WriteLine(String.Format("    <ss:Row ss:Height=""{0}"">", _
                grdView.Rows(i).Height))
            For intCol As Integer = 0 To grdView.Columns.Count - 1
                cellText = grdView.Item(intCol, i).Value
                ' Check for null cell and change it to empty to avoid error
                If cellText = vbNullString Then cellText = ""
                fs.WriteLine(String.Format("      <ss:Cell ss:StyleID=""2"">" & _
                    "<ss:Data ss:Type=""String"">{0}</ss:Data></ss:Cell>", _
                    cellText.ToString))
            Next
            fs.WriteLine("    </ss:Row>")
        Next
        ' Close  the document
        fs.WriteLine("  </ss:Table>")
        fs.WriteLine("</ss:Worksheet>")
        fs.WriteLine("</ss:Workbook>")
        fs.Close()
        MsgBox("Se ha exportado la grilla al archivo " & filePath)
    End Sub

End Class