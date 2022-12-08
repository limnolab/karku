Public Module pbmwp
    Dim idmuestra As Integer
    Dim idproyecto As Integer
    Dim formorigen As String
    Dim pbmwpfinal As String
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim pbmwpvaluetotal As Double


    Public Function CalcularPBMWP(idmuestracalcular As String, idproyectocalcular As String)
        idmuestra = idmuestracalcular
        idproyecto = idproyectocalcular


        ' LOS PASOS DE CALCULO SON:
        ' 1) LEER EL NUMERO DE MUESTRA Y EXTRAER DE ESA MUESTRA EL LISTADO DE TAXONES CON SUS DENSIDADES
        ' 2) SEPARA LAS ESPECIES Y DENSIDADES POR SU SEPARADOR Y CARGAR ESE LISTADO UNA TABLA VIRTUAL
        ' 3) PARA CADA ESPECIE EXTRAER LOS VALORES DEL INDICE, A TRAVES DEL TAXONID, DE LA TABLA DE CARACTERISTICAS DE TAXONES
        ' 4) CALCULAR EL INDICE FINAL
        ' 5) GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL

        '----------------------------------------------------------------------------------
        'PASO 1: lee el numero de muestra y extrae el listado de taxones con sus densidades

        Dim Taxonescon As New OleDb.OleDbConnection
        Dim Taxonesds As New DataSet
        Dim TaxonesSQL As String
        Taxonescon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Taxonescon.Open()
        TaxonesSQL = "SELECT * FROM macroinvs WHERE IdMuestra = '" & idmuestra & "'"
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
        Dim colTaxon As New DataGridViewTextBoxColumn
        Dim colCantidad As New DataGridViewTextBoxColumn
        colId.Name = "IdTaxon"
        colTaxon.Name = "Nombre"
        colCantidad.Name = "Cantidad"
        TaxonesPresentes.Columns.Add(colId)
        TaxonesPresentes.Columns.Add(colTaxon)
        TaxonesPresentes.Columns.Add(colCantidad)

        'SACA LOS ID DE TAXA1 y LOS VUELCA EN LA GRID. Si tiene el simbolo !, lo oculta
        For k = 0 To taxa1Array.Length - 1
            If taxa1Array(k).ToString <> "" Then
                If (taxa1Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa1Array(k) = taxa1Array(k).Trim("!")
                    TaxonesPresentes.Rows.Add(taxa1Array(k).ToString)
                    Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                    'TaxonesPresentes.Rows(c).Visible = False
                Else
                    TaxonesPresentes.Rows.Add(taxa1Array(k).ToString)
                End If
            End If
        Next
        'SACA LOS ID DE TAXA2 y LOS VUELCA EN LA GRID. Si tiene el simbolo !, lo oculta
        For k = 0 To taxa2Array.Length - 1
            If taxa2Array(k).ToString <> "" Then
                If (taxa2Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa2Array(k) = taxa2Array(k).Trim("!")
                    TaxonesPresentes.Rows.Add(taxa2Array(k).ToString)
                    Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                    'TaxonesPresentes.Rows(c).Visible = False
                Else
                    TaxonesPresentes.Rows.Add(taxa2Array(k).ToString)
                End If
            End If
        Next
        'SACA LOS ID DE TAXA3 y LOS VUELCA EN LA GRID. Si tiene el simbolo !, lo oculta
        For k = 0 To taxa3Array.Length - 1
            If taxa3Array(k).ToString <> "" Then
                If (taxa3Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa3Array(k) = taxa3Array(k).Trim("!")
                    TaxonesPresentes.Rows.Add(taxa3Array(k).ToString)
                    Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                    'TaxonesPresentes.Rows(c).Visible = False
                Else
                    TaxonesPresentes.Rows.Add(taxa3Array(k).ToString)
                End If
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
        'PASO 3 y 4: A partir de la tabla virtual que contiene IDTAXON y Cantidad, calculo el indice para la muestra


        Dim pbmwpvaluetotal As Double = 0
        Dim pbmwpvalue As String
        Dim pbmwpvaluedouble As Double
        Dim pbmwpvalueredondeado As String
        Dim idtaxonabuscar As String

        ' CONEXION A LA TABLA DE pbmwp
        Dim pbmwpcon As New OleDb.OleDbConnection
        Dim pbmwpds As New DataSet
        Dim pbmwpSQL As String
        pbmwpcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\pbmwp.mdb"
        pbmwpcon.Open()
        pbmwpSQL = "SELECT * FROM CaracPBMWP"
        Dim pbmwpda = New OleDb.OleDbDataAdapter(pbmwpSQL, pbmwpcon)
        pbmwpda.Fill(pbmwpds, "TablaCaracMacroInv")

        'SE FIJA QUE HAYA TAXONES PRESENTES
        If TaxonesPresentes.RowCount = 0 Then
            Taxonescon.Close()
            Return Nothing
            Exit Function
        End If
        Dim precision As Integer = 0
        'RECORRE CADA FILA DE LA LISTA DE TAXONES PRESENTES
        For i = 0 To TaxonesPresentes.RowCount - 2
            'Y LES SACA EL IDTAXON
            idtaxonabuscar = TaxonesPresentes.Item("IdTaxon", i).Value.ToString
            'BUSCA ESE IDTAXON EN LA TABLA CARACMACROINVpbmwp PARA VER SI SE USA EN ESE INDICE
            For j = 0 To pbmwpds.Tables("TablaCaracMacroInv").Rows.Count - 1
                If pbmwpds.Tables("TablaCaracMacroInv").Rows(j).Item("IdTaxon").ToString = idtaxonabuscar Then
                    pbmwpvalue = "0"
                    'SI LLEGO HASTA ACA ES PORQUE ESE TAXON SE USA EN ESTE INDICE
                    'Y BUSCA EN LA TABLA DE CARACTERISTICAS DEL TAXON PARA ESTE INDICE
                    'EL VALOR DE VX DE ESTE IDTAXON
                    pbmwpvalue = pbmwpds.Tables("TablaCaracMacroInv").Rows(j).Item("Valor").ToString
                    pbmwpvaluedouble = Double.Parse(pbmwpvalue)
                    precision = precision + 1
                    'MsgBox("IDTaxon: " & idtaxonabuscar & "; pbmwp: " & pbmwpvaluedouble)
                    'Y LAS VA SUMANDO PARA OBTENER LA DENSIDAD TOTAL
                    pbmwpvaluetotal += pbmwpvaluedouble
                    Exit For
                End If
            Next
        Next

        'redondeo pbmwptotal y lo paso al textbox de la db
        pbmwpvalueredondeado = Math.Round(pbmwpvaluetotal, 2)
        Dim valorconpunto As String = pbmwpvalueredondeado.Replace(",", ".")

        '----------------------------------------------------------------------------------
        'PASO 5: GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL Y DEVUELVE EL VALOR RESULTANTE
        'CIERRA EL DATASET
        pbmwpcon.Close()
        Taxonescon.Close()

        'GRABA SI LA PRECISION ES MAYOR A UNO

        If precision >= 1 Then
            Guardarpbmwp(valorconpunto, precision, idmuestra, idproyecto)
            Return valorconpunto
        Else
            Return Nothing
        End If

        MsgBox("valorconpunto=" & valorconpunto & "; Precision=" & precision)

        ''copia a la dgvPRUEBA - REVISION INTERNA NOMAS

        'For Each Col As DataGridViewColumn In TaxonesPresentes.Columns
        '    frmPrincipal.datagridPrueba.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        'Next
        'For i As Integer = 0 To TaxonesPresentes.Rows.Count - 1
        '    frmPrincipal.datagridPrueba.Rows.Add(TaxonesPresentes.Rows(i).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        'Next
    End Function


    Private Sub Guardarpbmwp(ByVal valorpbmwp As String, precision As String, ByVal idmuestra As Integer, ByVal idproyecto As Integer)

        ' CONEXION A LA TABLA DE pbmwp
        Dim pbmwpcon As New OleDb.OleDbConnection
        Dim pbmwpds As New DataSet
        Dim pbmwpSql As String
        pbmwpcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\pbmwp.mdb"
        pbmwpcon.Open()
        pbmwpSql = "SELECT * FROM PBMWP Where IdMuestra = '" & idmuestra & "'"
        Dim pbmwpda = New OleDb.OleDbDataAdapter(pbmwpSql, pbmwpcon)
        pbmwpda.Fill(pbmwpds, "TablaPBMWP")
        Dim pbmwpcb As New OleDb.OleDbCommandBuilder(pbmwpda)

        ' ME FIJO SI HABIA YA UN VALOR DE PBMWP, SINO HAGO UNA ROW NUEVA
        If pbmwpds.Tables("TablaPBMWP").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = pbmwpds.Tables("Tablapbmwp").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("Valorpbmwp") = valorpbmwp
            dsNewRow.Item("Precpbmwp") = precision
            pbmwpds.Tables("TablaPBMWP").Rows.Add(dsNewRow)
            pbmwpda.Update(pbmwpds, "TablaPBMWP")
            pbmwpcon.Close()
        Else
            'SI YA HABIA VALORES DE PBMWP
            pbmwpds.Tables("TablaPBMWP").Rows(0).Item("IdMuestra") = idmuestra
            pbmwpds.Tables("TablaPBMWP").Rows(0).Item("IdProyecto") = idproyecto
            pbmwpds.Tables("TablaPBMWP").Rows(0).Item("Valorpbmwp") = valorpbmwp
            pbmwpds.Tables("TablaPBMWP").Rows(0).Item("Precpbmwp") = precision
            pbmwpda.Update(pbmwpds, "TablaPBMWP")
            pbmwpcon.Close()
        End If

        'RECARGO ADAPTADORES DE FRMAPAMPEANO
        'frmAPampeano.pbmwpTableAdapter.qrypbmwpByIdMuestra(frmAPampeano.pbmwpDataSet.pbmwp, idmuestra)
    End Sub

    'NECESITO HACER UNA FUNCION PARA QUE SEPA DIFERENCIAR SI LOS TAXONES RELACIONADOS CON ESTE INDICE SON DIATOMEAS, MACROINV U OTROS
    'POR SI SE REQUIERE... SE USA DESDE FRMDBINDICES

    Public Function DefineTaxonesPBMWP(dummy As String)
        Dim taxonestipo As String = "macroinvertebrados"
        Return (taxonestipo)
    End Function


    'TRADUCCION DEL INDICE A PALABRAS, A PARTIR DE UN VALOR
    'DEVUELVE TRES VALORES:
    'claseagua= clase de agua (si hay)
    'colorvalor= color del indice
    'sign= en palabras, lo q significa el valor

    Public Function TraducePBMWP(valorindice As String)
        Dim claseagua As String = ""
        Dim colorvalor As String = ""
        Dim sign As String = ""
        Dim valorindice1 As Double = CDbl(valorindice)

        If valorindice1 >= 80 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Calidad muy buena"
        ElseIf valorindice1 >= 51 And valorindice < 80 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Calidad buena"
        ElseIf valorindice1 >= 31 And valorindice < 51 Then
            claseagua = "2"
            colorvalor = "Verde"
            sign = "Calidad moderada"
        ElseIf valorindice1 >= 16 And valorindice < 31 Then
            claseagua = "3"
            colorvalor = "Amarillo"
            sign = "Calidad deficiente"
        ElseIf valorindice1 <= 15 Then
            claseagua = "5"
            colorvalor = "Rojo"
            sign = "Calidad mala"
        End If

        Dim retorno As String = claseagua & ";" & colorvalor & ";" & sign
        Return (retorno)

    End Function
End Module
