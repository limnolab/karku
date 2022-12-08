Public Module imrp
    Dim idmuestra As Integer
    Dim idproyecto As Integer
    Dim formorigen As String
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Public Function CalcularIMRP(idmuestracalcular As String, idproyectocalcular As String)
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
        Taxonescon.Close()
        Taxonescon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Taxonescon.Open()
        TaxonesSQL = "SELECT * FROM diats WHERE IdMuestra = '" & idmuestra & "'"
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
        Dim colAcronimo As New DataGridViewTextBoxColumn
        Dim colTaxon As New DataGridViewTextBoxColumn
        Dim colCantidad As New DataGridViewTextBoxColumn
        colId.Name = "IdTaxon"
        colAcronimo.Name = "Acronimo"
        colTaxon.Name = "Nombre"
        colCantidad.Name = "Cantidad"
        TaxonesPresentes.Columns.Add(colId)
        TaxonesPresentes.Columns.Add(colAcronimo)
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
        'PASO 3 y 4: A partir de la tabla virtual que contiene IDTAXON, Acronimo y Cantidad, calculo el indice para la muestra

        Dim imrpvaluetotal As Double = 0
        Dim imrpvalue As String
        Dim imrpvaluedouble As Double
        Dim imrpvalueredondeado As String
        Dim i, j As Integer
        Dim idtaxon As String

        ' CONEXION A LA TABLA DE IMRP
        Dim IMRPcon As New OleDb.OleDbConnection
        Dim IMRPds As New DataSet
        Dim IMRPSQL As String
        IMRPcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\imrp.mdb"
        IMRPcon.Open()
        IMRPSQL = "SELECT * FROM CaracIMRP"
        Dim IMRPda = New OleDb.OleDbDataAdapter(IMRPSQL, IMRPcon)
        IMRPda.Fill(IMRPds, "TablaCaracMacroInv")

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
            idtaxon = TaxonesPresentes.Item(0, i).Value.ToString
            'BUSCA ESE IDTAXON EN LA TABLA CARACMACROINVIMRP PARA VER SI SE USA EN ESE INDICE
            For j = 0 To IMRPds.Tables("TablaCaracMacroInv").Rows.Count - 1
                If IMRPds.Tables("TablaCaracMacroInv").Rows(j).Item(1).ToString = idtaxon Then
                    'SI LLEGO HASTA ACA ES PORQUE ESE TAXON SE USA EN ESTE INDICE
                    'Y BUSCA EN LA TABLA DE CARACTERISTICAS DEL TAXON PARA ESTE INDICE
                    'EL VALOR DE VX DE ESTE IDTAXON
                    precision = precision + 1
                    imrpvalue = IMRPds.Tables("TablaCaracMacroInv").Rows(j).Item(2).ToString
                    Dim imrpvalue2 As String = imrpvalue.Replace(".", ",")
                    imrpvaluedouble = Double.Parse(imrpvalue2)
                    Exit For
                End If
            Next
            'Y LAS VA SUMANDO PARA OBTENER LA DENSIDAD TOTAL
            imrpvaluetotal += imrpvaluedouble
        Next

        'CIERRA EL DATASET
        IMRPcon.Close()
        Taxonescon.Close()

        GuardarIMRP(imrpvaluetotal, precision, idmuestra, idproyecto)
        Return imrpvaluetotal

    End Function

    Private Sub GuardarIMRP(ByVal valorconpunto As String, precision As Integer, ByVal idmuestra As Integer, ByVal idproyecto As Integer)

        ' CONEXION A LA TABLA DE IMRP
        Dim IMRPcon As New OleDb.OleDbConnection
        Dim IMRPds As New DataSet
        Dim IMRPSql As String
        IMRPcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\imrp.mdb"
        IMRPcon.Open()
        IMRPSql = "SELECT * FROM IMRP Where IdMuestra = '" & idmuestra & "'"
        Dim IMRPda = New OleDb.OleDbDataAdapter(IMRPSql, IMRPcon)
        IMRPda.Fill(IMRPds, "TablaIMRP")
        Dim IMRPcb As New OleDb.OleDbCommandBuilder(IMRPda)

        ' ME FIJO SI HABIA YA UN VALOR DE IMRP, SINO HAGO UNA ROW NUEVA

        If IMRPds.Tables("TablaIMRP").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = IMRPds.Tables("TablaIMRP").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("Valor") = valorconpunto
            dsNewRow.Item("Prec") = precision
            IMRPds.Tables("TablaIMRP").Rows.Add(dsNewRow)
            IMRPda.Update(IMRPds, "TablaIMRP")
            IMRPcon.Close()
        Else
            'SI YA HABIA VALORES DE IMRP
            IMRPds.Tables("TablaIMRP").Rows(0).Item("IdMuestra") = idmuestra
            IMRPds.Tables("TablaIMRP").Rows(0).Item("idProyecto") = idproyecto
            IMRPds.Tables("TablaIMRP").Rows(0).Item("Valor") = valorconpunto
            IMRPds.Tables("TablaIMRP").Rows(0).Item("Prec") = precision
            IMRPda.Update(IMRPds, "TablaIMRP")
            IMRPcon.Close()
        End If

    End Sub

    'NECESITO HACER UNA FUNCION PARA QUE SEPA DIFERENCIAR SI LOS TAXONES RELACIONADOS CON ESTE INDICE SON DIATOMEAS, MACROINV U OTROS
    'POR SI SE REQUIERE... SE USA DESDE FRMDBINDICES

    Public Function DefineTaxonesIMRP(dummy As String)
        Dim taxonestipo As String = "macroinvertebrados"
        Return (taxonestipo)
    End Function

    'TRADUCCION DEL INDICE A PALABRAS, A PARTIR DE UN VALOR
    'DEVUELVE TRES VALORES:
    'claseagua= clase de agua (si hay)
    'colorvalor= color del indice
    'sign= en palabras, lo q significa el valor

    Public Function TraduceIMRP(valorindice As String)
        Dim claseagua As String = ""
        Dim colorvalor As String = ""
        Dim sign As String = ""
        Dim valorindice1 As Double = CDbl(valorindice)

        If valorindice1 >= 12 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Contaminación desde muy leve a nula"
        ElseIf valorindice1 >= 8 And valorindice < 12 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Contaminación escasa"
        ElseIf valorindice1 >= 4 And valorindice < 8 Then
            claseagua = "2"
            colorvalor = "Verde"
            sign = "Contaminación débil"
        ElseIf valorindice1 >= 2.6 And valorindice < 4 Then
            claseagua = "3"
            colorvalor = "Amarillo"
            sign = "Contaminación moderada"
        ElseIf valorindice1 >= 1.1 And valorindice < 2.6 Then
            claseagua = "4"
            colorvalor = "Naranja"
            sign = "Contaminación fuerte"
        ElseIf valorindice1 <= 1.1 Then
            claseagua = "5"
            colorvalor = "Rojo"
            sign = "Contaminación muy fuerte"
        End If

        Dim retorno As String = claseagua & ";" & colorvalor & ";" & sign
        Return (retorno)

    End Function



End Module
