Public Class frmIMRP1m
    Dim pathimagen As String = My.Application.Info.DirectoryPath & "\fotosespecies\imrp\"
    Private Sub frmIMRP1m_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CaracMacroinvIMRPTableAdapter.Fill(Me.Scilla10DataSet.CaracMacroinvIMRP)
    End Sub
    Private Sub frmIMRP1m_Load_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Show()
    End Sub
    Private Sub MostrarDatos()
        Dim nombreespecie As String
        Dim valorimrp As String
        nombreespecie = NombreTextBox.Text
        valorimrp = ValorTextBox1.Text
        MostrarDatosGrid.Rows.Add(nombreespecie, valorimrp)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        MostrarDatos()
    End Sub

    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Dim nombretaxon As String
        nombretaxon = ListBox1.SelectedItems.Item(0).ToString()
        CaracMacroinvIMRPTableAdapter.qryMacroinvByNombre(Scilla10DataSet.CaracMacroinvIMRP, nombretaxon)
        MostrarDatos()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim nombretaxon As String
        nombretaxon = ListBox1.SelectedItems.Item(0).ToString()
        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & nombretaxon & ".jpg"

        CaracMacroinvIMRPTableAdapter.qryMacroinvByNombre(Scilla10DataSet.CaracMacroinvIMRP, nombretaxon)
        If Not RangoTextBox.Text = "" Then
            ValorTextBox1.Enabled = True
        ElseIf RangoTextBox.Text = "" Then
            ValorTextBox1.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not MostrarDatosGrid.Rows.Count = 0 Then
            CalcularIMRP()
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

        'redondeo idptotal y lo paso al textbox de la db
        imrpvalueredondeado = Math.Round(imrpvaluetotal, 2)
        Dim value2 As String = imrpvalueredondeado.Replace(",", ".")
        ValorTextBox.Text = value2

        MostrarMuestra()

    End Sub

    Private Sub MostrarMuestra()
        'MUESTRA LOS IMRP ACUMULADOS EN ESTA SESION EN LA GRILLA NUEVA

        Dim nombremuestra As String = txtNombreMuestra.Text
        Dim idmuestra As Integer = 0
        Dim valorimrp As String = ValorTextBox.Text
        Dim i As Integer

        i = MuestrasDataGrid.RowCount
        idmuestra = i + 1

        If txtNombreMuestra.Text = "" Then
            MuestrasDataGrid.Rows.Add(idmuestra, valorimrp)
            MostrarDatosGrid.Rows.Clear()
            ValorTextBox.Text = ""
        Else
            MuestrasDataGrid.Rows.Add(txtNombreMuestra.Text, valorimrp)
            txtNombreMuestra.Text = ""
            MostrarDatosGrid.Rows.Clear()
            ValorTextBox.Text = ""
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
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


    Private Sub btnBorrarSp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarSp.Click
        If MostrarDatosGrid.RowCount <> 0 Then
            MostrarDatosGrid.Rows.Remove(MostrarDatosGrid.CurrentRow)
        Else
            MsgBox("No ha agregado especies a la muestra todavia!")
        End If
    End Sub

End Class