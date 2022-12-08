Public Module densidad
    Dim idmuestra As String
    Dim idproyecto As String
    Dim formorigen As String
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Public Function CalcularDENSIDAD(idmuestracalcular As String, idproyectocalcular As String, variablename As String)
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
                    Dim densidadparcial As Double = CDbl(TaxonesPresentes.Item("Cantidad", i).Value)
                    densidadtotal = densidadtotal + densidadparcial
                    precision = precision + 1
                End If
            End If
        Next

        '----------------------------------------------------------------------------------
        'PASO 5: GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL Y DEVUELVE EL VALOR RESULTANTE
        'CIERRA EL DATASET
        Taxonescon.Close()

        '-----------------------------------

        'GRABA. No hay precision
        GuardarDensidad(densidadtotal, precision, idmuestra, idproyecto, variablename)
        Return (densidadtotal)
    End Function


    Private Sub GuardarDensidad(ByVal valorconpunto As String, precision As Integer, ByVal idmuestra As String, ByVal idproyecto As String, variablename As String)
        ' CONEXION A LA TABLA DE Densidad
        Dim Densidadcon As New OleDb.OleDbConnection
        Dim Densidadds As New DataSet
        Dim DensidadSql As String
        Densidadcon.Close()
        Densidadcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\densidad.mdb"
        Densidadcon.Open()
        DensidadSql = "SELECT * FROM Densidad Where IdMuestra = '" & idmuestra & "'"
        Dim Densidadda = New OleDb.OleDbDataAdapter(DensidadSql, Densidadcon)
        Densidadda.Fill(Densidadds, "TablaDensidad")
        Dim Densidadcb As New OleDb.OleDbCommandBuilder(Densidadda)

        ' ME FIJO SI HABIA YA UN VALOR DE Densidad, SINO HAGO UNA ROW NUEVA

        If Densidadds.Tables("TablaDensidad").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = Densidadds.Tables("TablaDensidad").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("Valor") = valorconpunto
            dsNewRow.Item("Variable") = variablename
            dsNewRow.Item("Prec") = precision
            Densidadds.Tables("TablaDensidad").Rows.Add(dsNewRow)
            Densidadda.Update(Densidadds, "TablaDensidad")
            Densidadcon.Close()
        Else
            'SI YA HABIA VALORES DE Densidad de una sola variable
            Dim encontrado As Boolean = False
            For i As Integer = 0 To Densidadds.Tables("TablaDensidad").Rows.Count - 1
                If Densidadds.Tables("TablaDensidad").Rows(i).Item("Variable") = variablename Then
                    Densidadds.Tables("TablaDensidad").Rows(i).Item("IdMuestra") = idmuestra
                    Densidadds.Tables("TablaDensidad").Rows(i).Item("IdProyecto") = idproyecto
                    Densidadds.Tables("TablaDensidad").Rows(i).Item("Valor") = valorconpunto
                    Densidadds.Tables("TablaDensidad").Rows(i).Item("Prec") = precision
                    Densidadds.Tables("TablaDensidad").Rows(i).Item("Variable") = variablename
                    Densidadda.Update(Densidadds, "TablaDensidad")
                    Densidadcon.Close()
                    encontrado = True
                    Exit For
                End If
            Next
            If encontrado = False Then
                Dim dsNewRow As DataRow
                dsNewRow = Densidadds.Tables("TablaDensidad").NewRow()
                dsNewRow.Item("IdMuestra") = idmuestra
                dsNewRow.Item("IdProyecto") = idproyecto
                dsNewRow.Item("Valor") = valorconpunto
                dsNewRow.Item("Variable") = variablename
                dsNewRow.Item("Prec") = precision
                Densidadds.Tables("TablaDensidad").Rows.Add(dsNewRow)
                Densidadda.Update(Densidadds, "TablaDensidad")
                Densidadcon.Close()
            End If
        End If
    End Sub
    'NECESITO HACER UNA FUNCION PARA QUE SEPA DIFERENCIAR SI LOS TAXONES RELACIONADOS CON ESTE INDICE SON DIATOMEAS, MACROINV U OTROS
    'POR SI SE REQUIERE... SE USA DESDE FRMDBINDICES

    Public Function DefineTaxonesDENSIDAD(dummy As String)
        Dim taxonestipo As String = ""
        Return (taxonestipo)
    End Function

    Public Function TraduceDENSIDAD(valorindice As String)
        Return ("NA")
    End Function

End Module
