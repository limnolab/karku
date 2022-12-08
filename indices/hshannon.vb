Public Module hshannon
    Dim idmuestra As String
    Dim idproyecto As String
    Dim formorigen As String
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Public Function CalcularHSHANNON(idmuestracalcular As String, idproyectocalcular As String, variablename As String)
        idmuestra = idmuestracalcular
        idproyecto = idproyectocalcular


        '----------------------------------------------------------------------------------
        'PASO 1:  BUSCA EN LA DB DE TAXONESMUESTRAS los datos para esa muestra en la variable seleccionada
        Dim Taxonescon As New OleDb.OleDbConnection
        Dim Taxonesds As New DataSet
        Dim TaxonesSQL As String
        Taxonescon.Close()
        Taxonescon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Taxonescon.Open()
        TaxonesSQL = "SELECT * FROM " & variablename & " WHERE IdMuestra = '" & idmuestra & "'"
        Dim Taxonesda = New OleDb.OleDbDataAdapter(TaxonesSQL, Taxonescon)
        Taxonesda.Fill(Taxonesds, "TablaTaxones")

        If Taxonesds.Tables("TablaTaxones").Rows.Count = 0 Then
            Taxonescon.Close()
            Return Nothing
            Exit Function
        End If

        '----------------------------------------------------------------------------------
        'PASO 2:SEPARA LAS ESPECIES Y DENSIDADES POR SU SEPARADOR Y CARGAR ESE LISTADO UNA TABLA VIRTUAL

        ' RECUPERA TODO LO PRESENTE EN LOS CAMPOS TAXA1, TAXA2 Y TAXA3, Y LO SEPARA
        ' POR SU CARACTER SEPARADOR (#)
        Dim taxa1 As String
        Dim taxa2 As String
        Dim taxa3 As String
        Dim taxa1Array() As String
        Dim taxa2Array() As String
        Dim taxa3Array() As String
        taxa1 = Taxonesds.Tables("TablaTaxones").Rows(0).Item("taxa1").ToString()
        taxa2 = Taxonesds.Tables("TablaTaxones").Rows(0).Item("taxa2").ToString()
        taxa3 = Taxonesds.Tables("TablaTaxones").Rows(0).Item("taxa3").ToString()
        taxa1Array = taxa1.Split("#")
        taxa2Array = taxa2.Split("#")
        taxa3Array = taxa3.Split("#")

        If taxa1Array.Length = 2 Then
            Return ("D/I")
            Exit Function
        End If

        'GENERA UNA TABLA VIRTUAL
        Dim TaxonesPresentes As New DataGridView
        Dim colId As New DataGridViewTextBoxColumn
        Dim colCantidad As New DataGridViewTextBoxColumn
        colId.Name = "IdTaxon"
        colCantidad.Name = "Cantidad"
        TaxonesPresentes.Columns.Add(colId)
        TaxonesPresentes.Columns.Add(colCantidad)



        'SACA LOS ID DE TAXA1 y LOS VUELCA EN LA GRID. Si tiene el simbolo !, lo oculta
        For k = 0 To taxa1Array.Length - 1
            If taxa1Array(k).ToString <> "" Then
                TaxonesPresentes.Rows.Add(taxa1Array(k).ToString)
            End If
        Next
        'SACA LOS ID DE TAXA2 y LOS VUELCA EN LA GRID. Si tiene el simbolo !, lo oculta
        For k = 0 To taxa2Array.Length - 1
            If taxa2Array(k).ToString <> "" Then
                TaxonesPresentes.Rows.Add(taxa2Array(k).ToString)

            End If
        Next
        'SACA LOS ID DE TAXA3 y LOS VUELCA EN LA GRID. Si tiene el simbolo !, lo oculta
        For k = 0 To taxa3Array.Length - 1
            If taxa3Array(k).ToString <> "" Then
                TaxonesPresentes.Rows.Add(taxa3Array(k).ToString)
            End If
        Next

        '  RECUPERA TODO LO PRESENTE EN LOS CAMPOS DENSIDAD1, DENSIDAD2 Y DENSIDAD3, Y LO SEPARA
        ' POR SU CARACTER SEPARADOR (#)
        Dim l, m As Integer
        Dim densidad1 As String
        Dim densidad2 As String
        Dim densidad3 As String
        Dim densidad1Array() As String
        Dim densidad2Array() As String
        Dim densidad3Array() As String
        densidad1 = Taxonesds.Tables("TablaTaxones").Rows(0).Item("densidad1").ToString()
        densidad2 = Taxonesds.Tables("TablaTaxones").Rows(0).Item("densidad2").ToString()
        densidad3 = Taxonesds.Tables("TablaTaxones").Rows(0).Item("densidad3").ToString()
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

        '----------------------------------------------------------------------------------
        'PASO 3 y 4: A partir de la tabla virtual que contiene IDTAXON y la Cantidad, calculo el indice para la muestra
        'calculo densidad total
        Dim densidadtotal As Double
        Dim precision As Short
        For i As Integer = 0 To TaxonesPresentes.Rows.Count - 2
            If TaxonesPresentes.Item("IdTaxon", i).Value.ToString <> "" Then
                If Not TaxonesPresentes.Item("IdTaxon", i).Value.ToString.Contains("!") Then
                    If Not TaxonesPresentes.Item("Cantidad", i).Value Is Nothing Then
                        Dim densidadparcial As Double = CDbl(TaxonesPresentes.Item("Cantidad", i).Value)
                        densidadtotal = densidadtotal + densidadparcial
                        precision = precision + 1
                    End If

                End If
            End If
        Next
        'calculo ni/N para cada row

        Dim colNiN As New DataGridViewTextBoxColumn
        colNiN.Name = "NiN"
        TaxonesPresentes.Columns.Add(colNiN)
        For i As Integer = 0 To TaxonesPresentes.Rows.Count - 2
            If TaxonesPresentes.Item("IdTaxon", i).Value.ToString <> "" Then
                If Not TaxonesPresentes.Item("IdTaxon", i).Value.ToString.Contains("!") Then
                    If TaxonesPresentes.Item("Cantidad", i).Value.ToString <> 0.0 Then
                        Dim densidadparcial As Double = CDbl(TaxonesPresentes.Item("Cantidad", i).Value)
                        Dim NiNparcial As Double = densidadparcial / densidadtotal
                        TaxonesPresentes.Item("NiN", i).Value = NiNparcial
                    End If
                End If
            End If
        Next

        'calculo LOG(ni/N)2 para cada row
        Dim colLOGNiN As New DataGridViewTextBoxColumn
        colLOGNiN.Name = "LOGNiN"
        TaxonesPresentes.Columns.Add(colLOGNiN)


        For i As Integer = 0 To TaxonesPresentes.Rows.Count - 2
            If TaxonesPresentes.Item("IdTaxon", i).Value.ToString <> "" Then
                If Not TaxonesPresentes.Item("IdTaxon", i).Value.ToString.Contains("!") Then
                    If Not TaxonesPresentes.Item("NiN", i).Value Is Nothing Then
                        Dim LOGNiNparcial As Double = Math.Log(TaxonesPresentes.Item("NiN", i).Value, 2)
                        TaxonesPresentes.Item("LOGNiN", i).Value = LOGNiNparcial
                    End If

                End If
            End If
        Next

        'calculo LOG(ni/N)2*(Ni/N) para cada row
        Dim colLOGNiNxNiN As New DataGridViewTextBoxColumn
        colLOGNiNxNiN.Name = "LOGNiNxNiN"
        TaxonesPresentes.Columns.Add(colLOGNiNxNiN)

        For i As Integer = 0 To TaxonesPresentes.Rows.Count - 2
            If TaxonesPresentes.Item("IdTaxon", i).Value.ToString <> "" Then
                If Not TaxonesPresentes.Item("IdTaxon", i).Value.ToString.Contains("!") Then
                    If Not TaxonesPresentes.Item("LOGNiN", i).Value Is Nothing Then
                        Dim LOGNiNxNiNparcial As Double = TaxonesPresentes.Item("LOGNiN", i).Value * TaxonesPresentes.Item("NiN", i).Value
                        TaxonesPresentes.Item("LOGNiNxNiN", i).Value = LOGNiNxNiNparcial
                    End If
                End If
            End If
        Next

        'calculo -H para toda la muestra
        Dim colmH As New DataGridViewTextBoxColumn
        colmH.Name = "mH"
        TaxonesPresentes.Columns.Add(colmH)
        Dim mHvalue As Double

        For i As Integer = 0 To TaxonesPresentes.Rows.Count - 2
            If TaxonesPresentes.Item("IdTaxon", i).Value.ToString <> "" Then
                If Not TaxonesPresentes.Item("IdTaxon", i).Value.ToString.Contains("!") Then
                    If Not TaxonesPresentes.Item("LOGNiNxNiN", i).Value Is Nothing Then
                        Dim mHparcial As Double = TaxonesPresentes.Item("LOGNiNxNiN", i).Value
                        mHvalue = mHvalue + mHparcial
                    End If
                End If
            End If
        Next

        Dim HValue As Double
        If mHvalue <> 0 Then
            HValue = Math.Round(-1 * mHvalue, 3)
        End If




        '----------------------------------------------------------------------------------
        'PASO 5: GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL Y DEVUELVE EL VALOR RESULTANTE
        'CIERRA EL DATASET
        Taxonescon.Close()

        'GRABA SI LA PRECISION ES MAYOR A UNO
        If precision >= 1 Then
            'GRABA 
            GuardarHShannon(HValue, precision, idmuestra, idproyecto, variablename)
            Return (HValue)
        Else
            Return Nothing
        End If

        'For Each Col As DataGridViewColumn In TaxonesPresentes.Columns
        '    frmPrincipal.DataGridView1.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        'Next
        'For i As Integer = 0 To TaxonesPresentes.Rows.Count - 1
        '    frmPrincipal.DataGridView1.Rows.Add(TaxonesPresentes.Rows(i).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        'Next

    End Function


    Private Sub GuardarHShannon(ByVal valorconpunto As String, precision As Integer, ByVal idmuestra As String, ByVal idproyecto As String, variablename As String)
        ' CONEXION A LA TABLA DE HShannon
        Dim HShannoncon As New OleDb.OleDbConnection
        Dim HShannonds As New DataSet
        Dim HShannonSql As String
        HShannoncon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\hshannon.mdb"
        HShannoncon.Open()
        HShannonSql = "SELECT * FROM HShannon Where IdMuestra = '" & idmuestra & "'"
        Dim HShannonda = New OleDb.OleDbDataAdapter(HShannonSql, HShannoncon)
        HShannonda.Fill(HShannonds, "TablaHShannon")
        Dim HShannoncb As New OleDb.OleDbCommandBuilder(HShannonda)

        ' ME FIJO SI HABIA YA UN VALOR DE IDP, SINO HAGO UNA ROW NUEVA

        If HShannonds.Tables("TablaHShannon").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = HShannonds.Tables("TablaHShannon").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("Valor") = valorconpunto
            dsNewRow.Item("Variable") = variablename
            dsNewRow.Item("Prec") = precision
            HShannonds.Tables("TablaHShannon").Rows.Add(dsNewRow)
            HShannonda.Update(HShannonds, "TablaHShannon")
            HShannoncon.Close()
        Else
            'SI YA HABIA VALORES DE HShannon de una sola variable
            Dim encontrado As Boolean = False
            For i As Integer = 0 To HShannonds.Tables("TablaHShannon").Rows.Count - 1
                If HShannonds.Tables("TablaHShannon").Rows(i).Item("Variable") = variablename Then
                    HShannonds.Tables("TablaHShannon").Rows(i).Item("IdMuestra") = idmuestra
                    HShannonds.Tables("TablaHShannon").Rows(i).Item("IdProyecto") = idproyecto
                    HShannonds.Tables("TablaHShannon").Rows(i).Item("Valor") = valorconpunto
                    HShannonds.Tables("TablaHShannon").Rows(i).Item("Prec") = precision
                    HShannonds.Tables("TablaHShannon").Rows(i).Item("Variable") = variablename
                    HShannonda.Update(HShannonds, "TablaHShannon")
                    HShannoncon.Close()
                    encontrado = True
                    Exit For
                End If
            Next
            If encontrado = False Then
                Dim dsNewRow As DataRow
                dsNewRow = HShannonds.Tables("TablaHShannon").NewRow()
                dsNewRow.Item("IdMuestra") = idmuestra
                dsNewRow.Item("IdProyecto") = idproyecto
                dsNewRow.Item("Valor") = valorconpunto
                dsNewRow.Item("Variable") = variablename
                dsNewRow.Item("Prec") = precision
                HShannonds.Tables("TablaHShannon").Rows.Add(dsNewRow)
                HShannonda.Update(HShannonds, "TablaHShannon")
                HShannoncon.Close()
            End If
        End If
    End Sub

    'NECESITO HACER UNA FUNCION PARA QUE SEPA DIFERENCIAR SI LOS TAXONES RELACIONADOS CON ESTE INDICE SON DIATOMEAS, MACROINV U OTROS
    'POR SI SE REQUIERE... SE USA DESDE FRMDBINDICES

    Public Function DefineTaxonesHSHANNON(dummy As String)
        Dim taxonestipo As String = ""
        Return (taxonestipo)
    End Function

    Public Function TraduceHSHANNON(valorindice As String)
        Return ("NA")
    End Function


End Module
