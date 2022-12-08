Public Class frmDiatomeas
    Dim idproyecto As Integer
    Dim idmuestra As Integer
    Dim tipoproyecto As String
    Dim pathimagen As String = My.Application.Info.DirectoryPath & "\fotosespecies\diatomeas\"
    Dim pathapp As String = My.Application.Info.DirectoryPath


    Public Sub RecibirVariables(ByVal tipo As String, ByVal id As Integer, ByVal muestra As Integer)
        'RECIBO TIPO Y NUMERO DE PROYECTO DE FRMMAIN
        idproyecto = id
        tipoproyecto = tipo
        idmuestra = muestra
    End Sub

    Private Sub frmDiatomeas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        GuardarMuestra()

    End Sub

    Private Sub frmDiatomeas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CARGA LA MUESTRA CON LA QUE TRABAJO
        Me.MuestrasTableAdapter.qryMuestrasByMuestra(Me.Scilla10DataSet.Muestras, idmuestra)
        Me.TaxonesTableAdapter.Fill(DiatomeasDataSet.Taxones)


        'NUEVA CARGA DE TAXONES ---- DB NUEVA

        ' CONEXION A LA TABLA DE TAXONES
        Dim Diatomeascon As New OleDb.OleDbConnection
        Dim Diatomeasds As New DataSet
        Dim DiatomeasSQL As String
        Diatomeascon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Diatomeascon.Open()
        DiatomeasSQL = "SELECT * FROM Diats WHERE IdMuestra = '" & idmuestra & "'"
        Dim Diatomeasda = New OleDb.OleDbDataAdapter(DiatomeasSQL, Diatomeascon)
        Diatomeasda.Fill(Diatomeasds, "TablaDiatomeas")

        If Diatomeasds.Tables("TablaDiatomeas").Rows.Count = 0 Then
            Diatomeasds.Tables("TablaDiatomeas").Rows.Add()
        ElseIf Diatomeasds.Tables("TablaDiatomeas").Rows.Count = 1 Then
            TraduceTaxonesPresentes(Diatomeasds.Tables("TablaDiatomeas"))
        End If

        Autocompletar(TaxonesDataGridView, 2, txtSearchbyName) ' COLUMNA 2 es NOMBRE
        Autocompletar(TaxonesDataGridView, 3, txtSearchAcronimo) 'COLUMNA 10 es ACRONIMO
        txtSearchbyName.Focus()
        Diatomeascon.Close()

    End Sub



    Private Sub Autocompletar(ByVal datagridview As DataGridView, ByVal idcolumnaabuscar As Integer, ByVal textbox As TextBox)
        Dim col As New AutoCompleteStringCollection
        Dim m As Integer

        For m = 0 To datagridview.Rows.Count - 1
            col.Add(datagridview.Item(idcolumnaabuscar, m).Value.ToString)
        Next
        textbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        textbox.AutoCompleteCustomSource = col
        textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub


    Private Sub TraduceTaxonesPresentes(ByVal tablamuestras As DataTable)
        ' ESTE SUB RETIENE LO CARGADO EN LA DB PARA LA MUESTRA, SEPARA POR EL CARACTER #
        ' Y MUESTRA EN UNA LISTA

        Dim k As Integer
        TaxonesPresentes.Rows.Clear()

        ' PRIMERO RECUPERA TODO LO PRESENTE EN LOS CAMPOS TAXA1, TAXA2 Y TAXA3, Y LO SEPARA
        ' POR SU CARACTER SEPARADOR (#)
        Dim taxa1 As String
        Dim taxa2 As String
        Dim taxa3 As String
        Dim taxa1Array() As String
        Dim taxa2Array() As String
        Dim taxa3Array() As String
        taxa1 = tablamuestras.Rows(0).Item(3).ToString()
        taxa2 = tablamuestras.Rows(0).Item(4).ToString()
        taxa3 = tablamuestras.Rows(0).Item(5).ToString()
        taxa1Array = taxa1.Split("#")
        taxa2Array = taxa2.Split("#")
        taxa3Array = taxa3.Split("#")

        'SACA LOS ID DE TAXA1 y LOS VUELCA EN LA GRID. Si tiene el simbolo !, lo oculta
        For k = 0 To taxa1Array.Length - 1
            If taxa1Array(k).ToString <> "" Then
                If (taxa1Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa1Array(k) = taxa1Array(k).Trim("!")
                    TaxonesPresentes.Rows.Add(taxa1Array(k).ToString)
                    Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                    TaxonesPresentes.Rows(c).Visible = False
                Else
                    TaxonesPresentes.Rows.Add(taxa1Array(k).ToString)
                End If
            End If
        Next
        'SACA LOS ID DE TAXA2 y LOS VUELCA EN LA GRID
        For k = 0 To taxa2Array.Length - 1
            If taxa2Array(k).ToString <> "" Then
                If (taxa2Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa2Array(k) = taxa2Array(k).Trim("!")
                    TaxonesPresentes.Rows.Add(taxa2Array(k).ToString)
                    Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                    TaxonesPresentes.Rows(c).Visible = False
                Else
                    TaxonesPresentes.Rows.Add(taxa2Array(k).ToString)
                End If
            End If
        Next
        'SACA LOS ID DE TAXA3 y LOS VUELCA EN LA GRID
        For k = 0 To taxa3Array.Length - 1
            If taxa3Array(k).ToString <> "" Then
                If (taxa3Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa3Array(k) = taxa3Array(k).Trim("!")
                    TaxonesPresentes.Rows.Add(taxa3Array(k).ToString)
                    Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                    TaxonesPresentes.Rows(c).Visible = False
                Else
                    TaxonesPresentes.Rows.Add(taxa3Array(k).ToString)
                End If
            End If
        Next


        ' SEGUNDO RECUPERA TODO LO PRESENTE EN LOS CAMPOS DENSIDAD1, DENSIDAD2 Y DENSIDAD3, Y LO SEPARA
        ' POR SU CARACTER SEPARADOR (#)
        Dim l, m As Integer
        Dim densidad1 As String
        Dim densidad2 As String
        Dim densidad3 As String
        Dim densidad1Array() As String
        Dim densidad2Array() As String
        Dim densidad3Array() As String
        densidad1 = tablamuestras.Rows(0).Item(6).ToString()
        densidad2 = tablamuestras.Rows(0).Item(7).ToString()
        densidad3 = tablamuestras.Rows(0).Item(8).ToString()
        densidad1Array = densidad1.Split("#")
        densidad2Array = densidad2.Split("#")
        densidad3Array = densidad3.Split("#")

        'SACA LAS DENSIDADES DE DENSIDAD1ARRAY y LOS VUELCA EN LA GRID
        m = 0
        If densidad1Array.Length > 1 Then
            For l = 0 To densidad1Array.Length - 2
                TaxonesPresentes.Item("Cantidad", m).Value = densidad1Array(l).ToString
                m = m + 1
            Next
        End If
        If densidad2Array.Length > 1 Then
            For l = 0 To densidad2Array.Length - 2
                TaxonesPresentes.Item("Cantidad", m).Value = densidad2Array(l).ToString
                m = m + 1
            Next
        End If
        If densidad3Array.Length > 1 Then
            For l = 0 To densidad3Array.Length - 2
                TaxonesPresentes.Item("Cantidad", m).Value = densidad3Array(l).ToString
                m = m + 1
            Next
        End If

        TraduceNombres()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim i, k, l As Integer
        Dim idtaxon As String
        Dim acronimo As String
        Dim cantidadtaxon As String
        i = TaxonesDataGridView.CurrentRow.Index

        If txtCantidadAgregar.Text = String.Empty Then
            MsgBox("Tiene que ingresar la cantidad de individuos presentes en su muestra.")
            txtCantidadAgregar.Focus()
            Exit Sub
        End If

        idtaxon = TaxonesDataGridView.Item(1, i).Value.ToString
        acronimo = TaxonesDataGridView.Item(3, i).Value.ToString
        cantidadtaxon = CDbl(txtCantidadAgregar.Text)

        Dim taxonexiste As Boolean = False
        For k = 0 To TaxonesPresentes.Rows.Count - 1
            If TaxonesPresentes.Item(0, k).Value.ToString = idtaxon Then
                TaxonesPresentes.Item(3, k).Value = CDbl(TaxonesPresentes.Item(3, k).Value) + cantidadtaxon
                taxonexiste = True
                Exit For
            End If
        Next

        If taxonexiste = False Then
            TaxonesPresentes.Rows.Add()
            l = TaxonesPresentes.Rows.Count - 1
            TaxonesPresentes.Item(0, l).Value = idtaxon
            TaxonesPresentes.Item(3, l).Value = cantidadtaxon
        End If

        TraduceNombres()
    End Sub

    Private Sub TraduceNombres()
        Dim i, j As Integer
        Dim idtaxon, acronimo, nombretaxon As String

        For i = 0 To TaxonesPresentes.Rows.Count - 1
            idtaxon = TaxonesPresentes.Item(0, i).Value.ToString
            For j = 0 To TaxonesDataGridView.Rows.Count - 1
                If TaxonesDataGridView.Item(1, j).Value.ToString = idtaxon Then
                    nombretaxon = TaxonesDataGridView.Item(2, j).Value.ToString
                    acronimo = TaxonesDataGridView.Item(3, j).Value.ToString
                    TaxonesPresentes.Item(2, i).Value = nombretaxon
                    TaxonesPresentes.Item(1, i).Value = acronimo
                End If
            Next
        Next

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        GuardarMuestra()
    End Sub
    Private Sub GuardarMuestra()

        ' CONEXION A LA TABLA DE TAXONES
        Dim Diatomeascon As New OleDb.OleDbConnection
        Dim Diatomeasds As New DataSet
        Dim DiatomeasSQL As String
        Diatomeascon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Diatomeascon.Open()
        DiatomeasSQL = "SELECT * FROM Diats WHERE IdMuestra = '" & idmuestra & "'"
        Dim Diatomeasda = New OleDb.OleDbDataAdapter(DiatomeasSQL, Diatomeascon)
        Diatomeasda.Fill(Diatomeasds, "TablaDiatomeas")

        Dim i As Integer
        Dim idtaxon As String
        Dim densidad As String
        Dim taxa1 As String
        Dim taxa2 As String
        Dim taxa3 As String
        Dim densidad1 As String
        Dim densidad2 As String
        Dim densidad3 As String

        If Diatomeasds.Tables("TablaDiatomeas").Rows.Count = 0 Then
            ' SE FIJA QUE HAYA TAXONES PARA AGREGAR, SINO SALE DEL SUB
            If TaxonesPresentes.Rows.Count >= 1 Then
                Diatomeasds.Tables("TablaDiatomeas").Rows.Add()
                For i = 0 To TaxonesPresentes.RowCount - 1
                    If TaxonesPresentes.Rows(i).Visible = False Then
                        idtaxon = "!" & TaxonesPresentes.Item(0, i).Value.ToString
                        densidad = TaxonesPresentes.Item(3, i).Value.ToString
                        If i < 6400 Then
                            taxa1 = taxa1 + idtaxon + "#"
                            densidad1 = densidad1 + densidad + "#"
                        ElseIf i > 6400 And i < 12800 Then
                            taxa2 = taxa2 + idtaxon + "#"
                            densidad2 = densidad2 + densidad + "#"
                        ElseIf i > 12800 Then
                            taxa3 = taxa3 + idtaxon + "#"
                            densidad3 = densidad3 + densidad + "#"
                        End If
                    ElseIf TaxonesPresentes.Rows(i).Visible = True Then
                        idtaxon = TaxonesPresentes.Item(0, i).Value.ToString
                        densidad = TaxonesPresentes.Item(3, i).Value.ToString
                        If i < 6400 Then
                            taxa1 = taxa1 + idtaxon + "#"
                            densidad1 = densidad1 + densidad + "#"
                        ElseIf i > 6400 And i < 12800 Then
                            taxa2 = taxa2 + idtaxon + "#"
                            densidad2 = densidad2 + densidad + "#"
                        ElseIf i > 12800 Then
                            taxa3 = taxa3 + idtaxon + "#"
                            densidad3 = densidad3 + densidad + "#"
                        End If
                    End If
                Next
            ElseIf TaxonesPresentes.Rows.Count < 1 Then
                Exit Sub
            End If
        ElseIf Diatomeasds.Tables("TablaDiatomeas").Rows.Count = 1 Then
            ' SE FIJA QUE HAYA TAXONES PARA AGREGAR, SINO SALE DEL SUB Y BORRA LA FILA EXISTENTE
            If TaxonesPresentes.Rows.Count >= 1 Then
                For i = 0 To TaxonesPresentes.RowCount - 1
                    If TaxonesPresentes.Rows(i).Visible = False Then
                        idtaxon = "!" & TaxonesPresentes.Item(0, i).Value.ToString
                        densidad = TaxonesPresentes.Item(3, i).Value.ToString
                        If i < 6400 Then
                            taxa1 = taxa1 + idtaxon + "#"
                            densidad1 = densidad1 + densidad + "#"
                        ElseIf i > 6400 And i < 12800 Then
                            taxa2 = taxa2 + idtaxon + "#"
                            densidad2 = densidad2 + densidad + "#"
                        ElseIf i > 12800 Then
                            taxa3 = taxa3 + idtaxon + "#"
                            densidad3 = densidad3 + densidad + "#"
                        End If
                    ElseIf TaxonesPresentes.Rows(i).Visible = True Then
                        idtaxon = TaxonesPresentes.Item(0, i).Value.ToString
                        densidad = TaxonesPresentes.Item(3, i).Value.ToString
                        If i < 6400 Then
                            taxa1 = taxa1 + idtaxon + "#"
                            densidad1 = densidad1 + densidad + "#"
                        ElseIf i > 6400 And i < 12800 Then
                            taxa2 = taxa2 + idtaxon + "#"
                            densidad2 = densidad2 + densidad + "#"
                        ElseIf i > 12800 Then
                            taxa3 = taxa3 + idtaxon + "#"
                            densidad3 = densidad3 + densidad + "#"
                        End If
                    End If
                Next
            ElseIf TaxonesPresentes.Rows.Count < 1 Then
                Dim cb1 As New OleDb.OleDbCommandBuilder(Diatomeasda)
                Dim drCurrent1 As DataRow = Diatomeasds.Tables("TablaDiatomeas").Rows(0)
                drCurrent1.Delete()
                Diatomeasda.Update(Diatomeasds, "TablaDiatomeas")
                Exit Sub
            End If

        End If


        ' UPDATEA LA BASE DE DATOS, CARGANDO LO NUEVO
        Dim cb As New OleDb.OleDbCommandBuilder(Diatomeasda)
        Dim drCurrent As DataRow = Diatomeasds.Tables("TablaDiatomeas").Rows(0)
        drCurrent.Item(1) = idproyecto
        drCurrent.Item(2) = idmuestra
        drCurrent.Item(3) = taxa1
        drCurrent.Item(4) = taxa2
        drCurrent.Item(5) = taxa3
        drCurrent.Item(6) = densidad1
        drCurrent.Item(7) = densidad2
        drCurrent.Item(8) = densidad3
        Diatomeasda.Update(Diatomeasds, "TablaDiatomeas")
    End Sub

    '// CARGA LA FOTO DEL TAXON SELECCIONADO
    Private Sub TaxonesDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TaxonesDataGridView.CellClick
        Dim j As Integer = TaxonesDataGridView.CurrentRow.Index
        Dim nombretaxon As String = TaxonesDataGridView.Item(3, j).Value.ToString
        fototaxon.ImageLocation = pathimagen & nombretaxon & ".jpg"
    End Sub




    '' ////////////////////////////////////////////////
    '' ////////////////////////////////////////////////
    '' ///// 
    '' ///// CONTROLA EL AUTOCOMPLETE DE LAS SEARCHBOXES
    '' ///// 
    '' ///// 


    Private Sub txtSearchAcronimo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchAcronimo.GotFocus
        TaxonesDataGridView.ClearSelection()
        txtSearchAcronimo.Text = ""
        txtSearchbyName.Text = ""
    End Sub

    Private Sub txtSearchAcronimo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchAcronimo.LostFocus
        'Controla si la especie existe
        Dim nametaxon As String
        Dim acronimovar As String
        Dim j As Integer
        acronimovar = txtSearchAcronimo.Text
        TaxonesDataGridView.ClearSelection()
        If Not txtSearchAcronimo.Text = "" Then
            For j = 0 To TaxonesDataGridView.RowCount - 1
                If TaxonesDataGridView.Item(3, j).Value.ToString = acronimovar Then
                    TaxonesDataGridView.CurrentCell = TaxonesDataGridView.Rows(j).Cells(1)
                    nametaxon = TaxonesDataGridView.Item(2, j).Value.ToString
                    txtSearchbyName.Text = nametaxon
                    TaxonesDataGridView.Rows(j).Selected = True
                End If
            Next j
        End If

    End Sub

    Private Sub txtSearchbyName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchbyName.GotFocus
        TaxonesDataGridView.ClearSelection()
        txtSearchAcronimo.Text = ""
        txtSearchbyName.Text = ""

    End Sub

    Private Sub txtSearchbyName_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchbyName.LostFocus
        'Controla si la especie existe
        Dim nametaxon As String
        Dim acronimotaxon As String
        Dim j As Integer
        nametaxon = txtSearchbyName.Text
        TaxonesDataGridView.ClearSelection()

        If Not txtSearchbyName.Text = "" Then
            For j = 0 To TaxonesDataGridView.RowCount - 1
                If TaxonesDataGridView.Item(2, j).Value.ToString = nametaxon Then
                    TaxonesDataGridView.CurrentCell = TaxonesDataGridView.Rows(j).Cells(1)
                    acronimotaxon = TaxonesDataGridView.Item(3, j).Value.ToString
                    txtSearchAcronimo.Text = acronimotaxon
                    TaxonesDataGridView.Rows(j).Selected = True
                End If
            Next j
            txtCantidadAgregar.Focus()
        End If

    End Sub

    Private Sub txtSearchAcronimo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchAcronimo.TextChanged
        txtSearchAcronimo.Text = UCase(txtSearchAcronimo.Text)
        txtSearchAcronimo.SelectionStart = Len(txtSearchAcronimo.Text)
    End Sub

End Class