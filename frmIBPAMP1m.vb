Public Class frmIBPAMP1m
    Dim pathimagen As String = My.Application.Info.DirectoryPath & "\fotosespecies\ibpamp\"

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        CalcularIBPAMP()
    End Sub
    Private Sub frmIBPAMP1m_Load_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Show()
    End Sub

    Private Sub CalcularIBPAMP()
        'validacion de los datos ingresados en el formulario, conversion de blanks a ceros
        If Cat1TextBox.Text = "" Then
            Cat1TextBox.Text = "0"
        End If
        If Cat2TextBox.Text = "" Then
            Cat2TextBox.Text = "0"
        End If
        If Cat3TextBox.Text = "" Then
            Cat3TextBox.Text = "0"
        End If
        If Cat4TextBox.Text = "" Then
            Cat4TextBox.Text = "0"
        End If
        If Cat5TextBox.Text = "" Then
            Cat5TextBox.Text = "0"
        End If
        If Cat6TextBox.Text = "" Then
            Cat6TextBox.Text = "0"
        End If
        If Cat7TextBox.Text = "" Then
            Cat7TextBox.Text = "0"
        End If
        If NombreTextBox.Text = "" Then
            MsgBox("Tiene que ingresar las unidades sistemáticas totales en su muestra")
            Exit Sub
        End If
        If Not IsNumeric(NombreTextBox.Text) Then
            MsgBox("Las unidades sistemáticas totales deben ser numéricas")
            Exit Sub
        End If

        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(NombreTextBox.Text)
        Dim cat1 As Double = Val(Cat1TextBox.Text)
        Dim cat2 As Double = Val(Cat2TextBox.Text)
        Dim cat3 As Double = Val(Cat3TextBox.Text)
        Dim cat4 As Double = Val(Cat4TextBox.Text)
        Dim cat5 As Double = Val(Cat5TextBox.Text)
        Dim cat6 As Double = Val(Cat6TextBox.Text)
        Dim cat7 As Double = Val(Cat7TextBox.Text)

        If cat1 > 0 Then
            CalculoCat1()
        Else
            If cat2 > 0 Then
                CalculoCat2()
            Else
                If cat3 > 0 Then
                    CalculoCat3()
                Else
                    If cat4 > 0 Then
                        CalculoCat4()
                    Else
                        If cat5 > 0 Then
                            CalculoCat5()
                        Else
                            If cat6 > 0 Then
                                CalculoCat6()
                            Else
                                If cat7 > 0 Then
                                    CalculoCat7()
                                Else
                                    MsgBox("No hay Unidades Sistemáticas presentes de ninguna categoría. No se puede calcular el IBPAMP")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub CalculoCat1()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(NombreTextBox.Text)
        Dim cat1 As Double = Val(Cat1TextBox.Text)
        Dim ibpampfinal As String

        ' Si US > 1
        If cat1 > 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "9"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "10"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "11"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "12"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "13"
            End If
            ' Si US = 1
        ElseIf cat1 = 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "8"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "9"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "10"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "11"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "12"
            End If
        End If
        'MsgBox(ibpampfinal)
        IndiceTextBox.Text = ibpampfinal
        Grabar()
    End Sub
    Private Sub CalculoCat2()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(NombreTextBox.Text)
        Dim cat2 As Double = Val(Cat2TextBox.Text)
        Dim ibpampfinal As String

        ' Si US > 1
        If cat2 > 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "6"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "7"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "8"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "9"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "10"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "11"
            End If
            ' Si US = 1
        ElseIf cat2 = 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "5"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "6"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "7"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "8"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "9"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "10"
            End If
        End If
        'MsgBox(ibpampfinal)
        IndiceTextBox.Text = ibpampfinal
        Grabar()

    End Sub
    Private Sub CalculoCat3()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(NombreTextBox.Text)
        Dim cat3 As Double = Val(Cat3TextBox.Text)
        Dim ibpampfinal As String

        ' Si US > 1
        If cat3 > 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "4"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "5"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "6"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "7"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "8"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "9"
            End If
            ' Si US = 1
        ElseIf cat3 = 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "3"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "4"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "5"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "6"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "7"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "8"
            End If
        End If
        'MsgBox(ibpampfinal)
        IndiceTextBox.Text = ibpampfinal
        Grabar()
    End Sub
    Private Sub CalculoCat4()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(NombreTextBox.Text)
        Dim cat4 As Double = Val(Cat4TextBox.Text)
        Dim ibpampfinal As String

        If ibpampvaluetotal <= 1 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
            ibpampfinal = "3"
        ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
            ibpampfinal = "4"
        ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
            ibpampfinal = "5"
        ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
            ibpampfinal = "6"
        ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
            ibpampfinal = "7"
        ElseIf ibpampvaluetotal >= 26 Then
            ibpampfinal = "---"
        End If
        'MsgBox(ibpampfinal)
        IndiceTextBox.Text = ibpampfinal
        Grabar()
    End Sub
    Private Sub CalculoCat5()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(NombreTextBox.Text)
        Dim cat5 As Double = Val(Cat5TextBox.Text)
        Dim ibpampfinal As String

        If ibpampvaluetotal <= 1 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
            ibpampfinal = "2"
        ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
            ibpampfinal = "3"
        ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
            ibpampfinal = "4"
        ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
            ibpampfinal = "5"
        ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal >= 26 Then
            ibpampfinal = "---"
        End If
        'MsgBox(ibpampfinal)
        IndiceTextBox.Text = ibpampfinal
        Grabar()
    End Sub
    Private Sub CalculoCat6()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(NombreTextBox.Text)
        Dim cat6 As Double = Val(Cat6TextBox.Text)
        Dim ibpampfinal As String

        If ibpampvaluetotal <= 1 Then
            ibpampfinal = "1"
        ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
            ibpampfinal = "1"
        ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
            ibpampfinal = "2"
        ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
            ibpampfinal = "3"
        ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal >= 26 Then
            ibpampfinal = "---"
        End If
        'MsgBox(ibpampfinal)
        IndiceTextBox.Text = ibpampfinal
        Grabar()
    End Sub
    Private Sub CalculoCat7()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(NombreTextBox.Text)
        Dim cat7 As Double = Val(Cat7TextBox.Text)
        Dim ibpampfinal As String

        If ibpampvaluetotal <= 1 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
            ibpampfinal = "0"
        ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
            ibpampfinal = "1"
        ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
            ibpampfinal = "2"
        ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal >= 26 Then
            ibpampfinal = "---"
        End If
        'MsgBox(ibpampfinal)
        IndiceTextBox.Text = ibpampfinal
        Grabar()
    End Sub
    Private Sub Grabar()
        Dim nombremuestra As String = txtNombreMuestra.Text
        Dim idmuestra As Integer = 0
        Dim ibpampfinal As String = IndiceTextBox.Text
        Dim i As Integer

        i = MuestrasDataGrid.RowCount
        idmuestra = i + 1

        If txtNombreMuestra.Text = "" Then
            MuestrasDataGrid.Rows.Add(idmuestra, ibpampfinal)
        Else
            MuestrasDataGrid.Rows.Add(nombremuestra, ibpampfinal)
        End If

        Cat1TextBox.Text = ""
        Cat2TextBox.Text = ""
        Cat3TextBox.Text = ""
        Cat4TextBox.Text = ""
        Cat5TextBox.Text = ""
        Cat6TextBox.Text = ""
        Cat7TextBox.Text = ""
    End Sub

    Private Sub Significa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Significa.Click
        If Significa.Text = "Clase V" Then
            MsgBox("Muy fuertemente poluído")
        End If
        If Significa.Text = "Clase IIII" Then
            MsgBox("Fuertemente poluído")
        End If
        If Significa.Text = "Clase III" Then
            MsgBox("Moderadamente poluído")
        End If
        If Significa.Text = "Clase II" Then
            MsgBox("Suavemente poluído")
        End If
        If Significa.Text = "Clase I" Then
            MsgBox("No poluído")
        End If
    End Sub

    Private Sub tmrCheckIndices_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckIndices.Tick
        Dim indicecolor As Integer
        If IndiceTextBox.Text <> "---" Then
            indicecolor = Val(IndiceTextBox.Text)
        Else
            Significa.Text = "---"
            Significa.BackColor = Color.Gray
        End If

        If indicecolor >= 1 And indicecolor <= 3 Then
            Significa.Text = "Clase V"
            Significa.BackColor = Color.Red
        End If
        If indicecolor >= 4 And indicecolor <= 5 Then
            Significa.Text = "Clase IIII"
            Significa.BackColor = Color.Orange
        End If
        If indicecolor >= 6 And indicecolor <= 7 Then
            Significa.Text = "Clase III"
            Significa.BackColor = Color.Yellow
        End If
        If indicecolor >= 8 And indicecolor <= 9 Then
            Significa.Text = "Clase II"
            Significa.BackColor = Color.Green
        End If
        If indicecolor >= 10 Then
            Significa.Text = "Clase I"
            Significa.BackColor = Color.Blue
        End If
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

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Me.Close()
    End Sub

    Private Sub Cat1TextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cat1TextBox.GotFocus
        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & "IBPAMPCat1.jpg"
    End Sub

    Private Sub Cat2TextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cat2TextBox.GotFocus
        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & "IBPAMPCat2.jpg"
    End Sub
    Private Sub Cat3TextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cat3TextBox.GotFocus
        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & "IBPAMPCat3.jpg"
    End Sub
    Private Sub Cat4TextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cat4TextBox.GotFocus
        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & "IBPAMPCat4.jpg"
    End Sub
    Private Sub Cat5TextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cat5TextBox.GotFocus
        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & "IBPAMPCat5.jpg"
    End Sub
    Private Sub Cat6TextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cat6TextBox.GotFocus
        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & "IBPAMPCat6.jpg"
    End Sub
    Private Sub Cat7TextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cat7TextBox.GotFocus
        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & "IBPAMPCat7.jpg"
    End Sub
End Class