Public Class frmIBPAMP
    Dim idmuestra As Integer
    Dim idproyecto As Integer
    Dim pathimagen As String = My.Application.Info.DirectoryPath & "\fotosespecies\ibpamp\"

    Public Sub SetReceive(ByVal Value As Integer, ByVal Value2 As Integer)
        idmuestra = Value
        idproyecto = Value2
    End Sub
    Private Sub frmIBPAMP_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Graba todo
        Grabar()
        'Recarga los adaptadores en frmMuestrasRLP
        frmMuestrasArroyoPamp.MuestrasBindingSource.EndEdit()
        frmMuestrasArroyoPamp.MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)
        frmMuestrasArroyoPamp.IBPAMPTableAdapter.Fill(frmMuestrasArroyoPamp.IbpampDataSet.IBPAMP)
        frmMuestrasArroyoPamp.GrabarMuestra()
    End Sub

    Private Sub frmIBPAMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carga las muestras por id
        Me.MuestrasTableAdapter.qryMuestrasByMuestra(Me.Scilla10DataSet.Muestras, idmuestra)
        Me.MacroinvSpIBPAMPTableAdapter.qryMacroinvByMuestras(Me.Scilla10DataSet.MacroinvSpIBPAMP, idmuestra)
        Me.IBPAMPTableAdapter.qryIBPAMPByMuestra(Me.Scilla10DataSet.IBPAMP, idmuestra)

        ' SE FIJA QUE HAYA YA HECHO UN RECORD EN IBPAMP, SINO LO CREA
        If IBPAMPDataGridView.RowCount = 1 Then
            IBPAMPBindingSource.AddNew()
            IdMuestraTextBox.Text = idmuestra
            IdProyectoTextBox.Text = idproyecto
            IndiceTextBox.Text = "No calculado"
        End If
        'UPDATE THE DATABASE
        IBPAMPBindingSource.EndEdit()
        MacroinvSpIBPAMPBindingSource.EndEdit()
        IBPAMPTableAdapter.Update(Scilla10DataSet.IBPAMP)
        TableAdapterManager.UpdateAll(Scilla10DataSet)

        'Refresh everything, including adapters
        IBPAMPDataGridView.Refresh()
        MacroinvSpIBPAMPDataGridView.Refresh()
        Me.MuestrasTableAdapter.qryMuestrasByMuestra(Me.Scilla10DataSet.Muestras, idmuestra)
        Me.MacroinvSpIBPAMPTableAdapter.qryMacroinvByMuestras(Me.Scilla10DataSet.MacroinvSpIBPAMP, idmuestra)
        Me.IBPAMPTableAdapter.qryIBPAMPByMuestra(Me.Scilla10DataSet.IBPAMP, idmuestra)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        IBPAMPDataGridView.Refresh()
        'necesito primero sacar los valores ya ingresados al form a variables para q no se pierdan
        Dim catotales As String = NombreTextBox.Text
        Dim cat1 As String = Cat1TextBox.Text
        Dim cat2 As String = Cat2TextBox.Text
        Dim cat3 As String = Cat3TextBox.Text
        Dim cat4 As String = Cat4TextBox.Text
        Dim cat5 As String = Cat5TextBox.Text
        Dim cat6 As String = Cat6TextBox.Text
        Dim cat7 As String = Cat7TextBox.Text
        NombreTextBox.Text = catotales
        Cat1TextBox.Text = cat1
        Cat2TextBox.Text = cat2
        Cat3TextBox.Text = cat3
        Cat4TextBox.Text = cat4
        Cat5TextBox.Text = cat5
        Cat6TextBox.Text = cat6
        Cat7TextBox.Text = cat7

        'Si mi muestra ya tiene un valor de densidad prosigue, sino genera una row propia
        If MacroinvSpIBPAMPDataGridView.RowCount = 1 Then
            'genero nuevo record y devuelvo los valores de variables al form
            MacroinvSpIBPAMPBindingSource.AddNew()
            NombreTextBox.Text = catotales
            Cat1TextBox.Text = cat1
            Cat2TextBox.Text = cat2
            Cat3TextBox.Text = cat3
            Cat4TextBox.Text = cat4
            Cat5TextBox.Text = cat5
            Cat6TextBox.Text = cat6
            Cat7TextBox.Text = cat7
            IdMuestraTextBox.Text = idmuestra
            IdProyectoTextBox.Text = idproyecto
            CalcularIBPAMP()
            Me.Close()
        ElseIf MacroinvSpIBPAMPDataGridView.RowCount = 2 Then
            'MsgBox("hay valores previos para la muestra")
            CalcularIBPAMP()
            Me.Close()
        End If

    End Sub

    Private Sub CalcularIBPAMP()
        'validacion de los datos ingresados en la form, conversion de blanks a ceros
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
        Dim ibpampfinal As String

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
        ' Guarda las DB
        IdMuestrasTextBox.Text = idmuestra
        IdMuestraTextBox.Text = idmuestra
        IdProyectoTextBox.Text = idproyecto
        IBPAMPTextBox.Text = IndiceTextBox.Text

        IBPAMPBindingSource.EndEdit()
        MacroinvSpIBPAMPBindingSource.EndEdit()
        MuestrasBindingSource.EndEdit()
        IBPAMPTableAdapter.Update(Scilla10DataSet.IBPAMP)
        MacroinvSpIBPAMPTableAdapter.Update(Scilla10DataSet.MacroinvSpIBPAMP)
        MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

        ' Tengo que recargar los adaptadores para que no salte!
        Me.MuestrasTableAdapter.qryMuestrasByMuestra(Me.Scilla10DataSet.Muestras, idmuestra)
        Me.MacroinvSpIBPAMPTableAdapter.qryMacroinvByMuestras(Me.Scilla10DataSet.MacroinvSpIBPAMP, idmuestra)
        Me.IBPAMPTableAdapter.qryIBPAMPByMuestra(Me.Scilla10DataSet.IBPAMP, idmuestra)

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