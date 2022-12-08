﻿Public Module saprobiedad_diatomeas
    Dim idmuestra As Integer
    Dim idproyecto As Integer
    Dim formorigen As String
    Dim ibpampfinal As String
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim ibpampvaluetotal As Double


    Public Function CalcularSAPROBIEDADDIATS(idmuestracalcular As String, idproyectocalcular As String)

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


        Dim SAPROBIEDADvaluetotal As Double = 0
        Dim SAPROBIEDADvalue As String = ""
        Dim SAPROBIEDADvalueredondeado As String
        Dim idtaxonabuscar As String

        ' CONEXION A LA TABLA DE SAPROBIEDAD
        Dim SAPROBIEDADcon As New OleDb.OleDbConnection
        Dim SAPROBIEDADds As New DataSet
        Dim SAPROBIEDADSQL As String
        SAPROBIEDADcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\saprobiedaddiats.mdb"
        SAPROBIEDADcon.Open()
        SAPROBIEDADSQL = "SELECT * FROM CaracSAPROBIEDAD"
        Dim SAPROBIEDADda = New OleDb.OleDbDataAdapter(SAPROBIEDADSQL, SAPROBIEDADcon)
        SAPROBIEDADda.Fill(SAPROBIEDADds, "TablaCaracTaxones")

        'SE FIJA QUE HAYA TAXONES PRESENTES
        If TaxonesPresentes.RowCount = 0 Then
            Taxonescon.Close()
            Return Nothing
            Exit Function
        End If

        Dim precision As Integer = 0
        Dim SAPROBIEDADdensidad As String

        Dim SAPROBIEDADcategoriaactual As String
        Dim cat0 As Double
        Dim cat1 As Double
        Dim cat2 As Double
        Dim cat3 As Double
        Dim cat4 As Double
        Dim cat5 As Double
        Dim SAPROBIEDADarray As String

        Dim taxonencontrado As Boolean = False

        'RECORRE CADA FILA DE LA LISTA DE TAXONES PRESENTES
        For i = 0 To TaxonesPresentes.RowCount - 2
            'Y LES SACA EL IDTAXON
            idtaxonabuscar = TaxonesPresentes.Item("IdTaxon", i).Value.ToString
            taxonencontrado = False
            'BUSCA ESE IDTAXON EN LA TABLA CARACMACROINVSAPROBIEDAD PARA VER SI SE USA EN ESE INDICE
            For j = 0 To SAPROBIEDADds.Tables("TablaCaracTaxones").Rows.Count - 1
                If SAPROBIEDADds.Tables("TablaCaracTaxones").Rows(j).Item("IdTaxon").ToString = idtaxonabuscar Then
                    'SI LLEGO HASTA ACA ES PORQUE ESE TAXON SE USA EN ESTE INDICE
                    'Y BUSCA EN LA TABLA DE CARACTERISTICAS DEL TAXON PARA ESTE INDICE
                    'EL VALOR DE VX DE ESTE IDTAXON
                    SAPROBIEDADcategoriaactual = SAPROBIEDADds.Tables("TablaCaracTaxones").Rows(j).Item("Valor").ToString
                    SAPROBIEDADdensidad = TaxonesPresentes.Item("Cantidad", i).Value.ToString

                    If SAPROBIEDADcategoriaactual = "1" Then
                        cat1 = cat1 + SAPROBIEDADdensidad
                    ElseIf SAPROBIEDADcategoriaactual = "2" Then
                        cat2 = cat2 + SAPROBIEDADdensidad
                    ElseIf SAPROBIEDADcategoriaactual = "3" Then
                        cat3 = cat3 + SAPROBIEDADdensidad
                    ElseIf SAPROBIEDADcategoriaactual = "4" Then
                        cat4 = cat4 + SAPROBIEDADdensidad
                    ElseIf SAPROBIEDADcategoriaactual = "5" Then
                        cat5 = cat5 + SAPROBIEDADdensidad
                    End If
                    precision = precision + 1
                    taxonencontrado = True
                    Exit For
                End If
            Next
            If taxonencontrado = False Then
                cat0 = cat0 + TaxonesPresentes.Item("Cantidad", i).Value.ToString
            End If
        Next

        SAPROBIEDADarray = cat0 & ";" & cat1 & ";" & cat2 & ";" & cat3 & ";" & cat4 & ";" & cat5

        '----------------------------------------------------------------------------------
        'PASO 5: GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL Y DEVUELVE EL VALOR RESULTANTE
        'CIERRA EL DATASET
        SAPROBIEDADcon.Close()
        Taxonescon.Close()

        'GRABA SI LA PRECISION ES MAYOR A UNO

        If precision >= 1 Then
            GuardarSAPROBIEDADDIATS(SAPROBIEDADarray, precision, idmuestra, idproyecto)
            Return SAPROBIEDADarray
        Else
            Return Nothing
        End If
    End Function


    Private Sub GuardarSAPROBIEDADDIATS(ByVal valorSAPROBIEDAD As String, precision As String, ByVal idmuestra As Integer, ByVal idproyecto As Integer)

        ' CONEXION A LA TABLA DE SAPROBIEDAD
        Dim SAPROBIEDADcon As New OleDb.OleDbConnection
        Dim SAPROBIEDADds As New DataSet
        Dim SAPROBIEDADSql As String
        SAPROBIEDADcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\saprobiedaddiats.mdb"
        SAPROBIEDADcon.Open()
        SAPROBIEDADSql = "SELECT * FROM SAPROBIEDAD Where IdMuestra = '" & idmuestra & "'"
        Dim SAPROBIEDADda = New OleDb.OleDbDataAdapter(SAPROBIEDADSql, SAPROBIEDADcon)
        SAPROBIEDADda.Fill(SAPROBIEDADds, "TablaSAPROBIEDAD")
        Dim SAPROBIEDADcb As New OleDb.OleDbCommandBuilder(SAPROBIEDADda)

        ' ME FIJO SI HABIA YA UN VALOR DE SAPROBIEDAD, SINO HAGO UNA ROW NUEVA
        If SAPROBIEDADds.Tables("TablaSAPROBIEDAD").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = SAPROBIEDADds.Tables("TablaSAPROBIEDAD").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("ValorSAPROBIEDAD") = valorSAPROBIEDAD
            dsNewRow.Item("PrecSAPROBIEDAD") = precision
            SAPROBIEDADds.Tables("TablaSAPROBIEDAD").Rows.Add(dsNewRow)
            SAPROBIEDADda.Update(SAPROBIEDADds, "TablaSAPROBIEDAD")
            SAPROBIEDADcon.Close()
        Else
            'SI YA HABIA VALORES DE IMRP
            SAPROBIEDADds.Tables("TablaSAPROBIEDAD").Rows(0).Item("IdMuestra") = idmuestra
            SAPROBIEDADds.Tables("TablaSAPROBIEDAD").Rows(0).Item("IdProyecto") = idproyecto
            SAPROBIEDADds.Tables("TablaSAPROBIEDAD").Rows(0).Item("ValorSAPROBIEDAD") = valorSAPROBIEDAD
            SAPROBIEDADds.Tables("TablaSAPROBIEDAD").Rows(0).Item("PrecSAPROBIEDAD") = precision
            SAPROBIEDADda.Update(SAPROBIEDADds, "TablaSAPROBIEDAD")
            SAPROBIEDADcon.Close()
        End If
    End Sub



    'NECESITO HACER UNA FUNCION PARA QUE SEPA DIFERENCIAR SI LOS TAXONES RELACIONADOS CON ESTE INDICE SON DIATOMEAS, MACROINV U OTROS
    'POR SI SE REQUIERE... SE USA DESDE FRMDBINDICES

    Public Function DefineTaxonesSAPROBIEDADDIATS(dummy As String)
        Dim taxonestipo As String = "diatomeas"
        Return (taxonestipo)
    End Function



    'TRADUCCION DEL INDICE A PALABRAS, A PARTIR DE UN VALOR
    'DEVUELVE TRES VALORES:
    'claseagua= clase de agua (si hay)
    'colorvalor= color del indice
    'sign= en palabras, lo q significa el valor

    Public Function TraduceSAPROBIEDADDIATS(valorindice As String)
        Dim claseagua As String = ""
        Dim colorvalor As String = ""
        Dim sign As String = ""


        'primero se fija q tenga datos
        If valorindice = "Sin datos" Then
            Return ("-;Gris;Sin datos")
        ElseIf valorindice.Contains(";") Then
            Return (valorindice)
        End If

        Dim valorindice1 As Double = CDbl(valorindice)

        If valorindice1 = 1 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Oligosapróbica"
        ElseIf valorindice1 = 2 Then
            claseagua = "2"
            colorvalor = "Verde"
            sign = "b-Mesosapróbica"
        ElseIf valorindice1 = 3 Then
            claseagua = "3"
            colorvalor = "Amarillo"
            sign = "a-Mesosapróbica"
        ElseIf valorindice1 = 4 Then
            claseagua = "4"
            colorvalor = "Naranja"
            sign = "a-Mesosapróbica/polisapróbica"
        ElseIf valorindice1 = 5 Then
            claseagua = "5"
            colorvalor = "Rojo"
            sign = "Polisapróbica"
        End If

        Dim retorno As String = claseagua & ";" & colorvalor & ";" & sign
        Return (retorno)

    End Function


End Module