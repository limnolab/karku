Public Module ibpampold
    Dim idmuestra As Integer
    Dim idproyecto As Integer
    Dim formorigen As String
    Dim ibpampfinal As String
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim ibpampvaluetotal As Double
    Dim UStotales As Integer
    Dim tablataxonespresentes2 As DataGridView

    Public Function CalcularIBPAMP(idmuestracalcular As String, idproyectocalcular As String)
        'RECIBO NUMERO DE MUESTRAS Y DEL PROYECTO DEL FORM ANTERIOR
        idmuestra = idmuestracalcular
        idproyecto = idproyectocalcular

        '----------------------------------------------------------------------------------
        'PASO 1: lee el numero de muestra y extrae el listado de taxones con sus densidades

        Dim Taxonescon As New OleDb.OleDbConnection
        Dim Taxonesds As New DataSet
        Dim TaxonesSQL As String
        Taxonescon.Close()
        Taxonescon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Taxonescon.Open()
        TaxonesSQL = "SELECT * FROM macroinvs WHERE IdMuestra = '" & idmuestra & "'"
        Dim Taxonesda = New OleDb.OleDbDataAdapter(TaxonesSQL, Taxonescon)
        Taxonesda.Fill(Taxonesds, "TablaTaxones")

        If Taxonesds.Tables("TablaTaxones").Rows.Count = 0 Then
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


        Dim categoriataxon As String
        Dim cantidadtaxon As String

        ' CONEXION A LA TABLA DE IBPAMP
        Dim IBPAMPcon As New OleDb.OleDbConnection
        Dim IBPAMPds As New DataSet
        Dim IBPAMPSQL As String
        IBPAMPcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\ibpamp.mdb"
        IBPAMPcon.Open()
        IBPAMPSQL = "SELECT * FROM CaracIBPAMP"
        Dim IBPAMPda = New OleDb.OleDbDataAdapter(IBPAMPSQL, IBPAMPcon)
        IBPAMPda.Fill(IBPAMPds, "TablaCaracMacroInv")


        'SE FIJA QUE HAYA TAXONES PRESENTES
        If TaxonesPresentes.RowCount = 0 Then
            Return Nothing
            Exit Function
        End If

        'CALCULA US TOTALES
        UStotales = 0
        CalcularUSTotales("Trichoptera", TaxonesPresentes)
        CalcularUSTotales("Ephemeroptera", TaxonesPresentes)
        CalcularUSTotales("Odonata", TaxonesPresentes)
        CalcularUSTotales("Coleoptera", TaxonesPresentes)
        CalcularUSTotales("Mollusca", TaxonesPresentes)
        CalcularUSTotales("Crustacea", TaxonesPresentes)
        CalcularUSTotales("Heteroptera", TaxonesPresentes)
        CalcularUSTotales("Diptera", TaxonesPresentes)
        CalcularUSTotales("Tricladida", TaxonesPresentes)
        CalcularUSTotales("Hirudinea", TaxonesPresentes)
        CalcularUSTotales("Oligochaeta", TaxonesPresentes)
        CalcularUSTotales("Hydracarina", TaxonesPresentes)
        CalcularUSTotales("Nematoda", TaxonesPresentes)
        CalcularUSTotales("Tardigrada", TaxonesPresentes)
        CalcularUSTotales("Coelenterata", TaxonesPresentes)
        CalcularUSTotales("Porifera", TaxonesPresentes)
        CalcularUSTotales("Bryozoa", TaxonesPresentes)
        CalcularUSTotales("Temnocephala", TaxonesPresentes)


        'GENERO VARIABLES VACIAS PARA CADA CATEGORIA DEL IBPAMP
        Dim cat1 As Double = 0
        Dim cat2 As Double = 0
        Dim cat3 As Double = 0
        Dim cat4 As Double = 0
        Dim cat5 As Double = 0
        Dim cat6 As Double = 0
        Dim cat7 As Double = 0

        Dim idtaxoncalcular As String

        'RECORRE CADA FILA DE LA LISTA DE TAXONES PRESENTES
        For i = 0 To TaxonesPresentes.RowCount - 2
            'Y LES SACA EL IDTAXON
            idtaxoncalcular = TaxonesPresentes.Item(0, i).Value.ToString
            'ESTABLECE QUE LA CANTIDAD DE US PARA UN TAXON EN LA LISTA DE PRESENTES
            'ES IGUAL A 1
            cantidadtaxon = 1

            For j = 0 To IBPAMPds.Tables("TablaCaracMacroInv").Rows.Count - 1
                If IBPAMPds.Tables("TablaCaracMacroInv").Rows(j).Item(1).ToString = idtaxoncalcular Then
                    'SACA EL NUMERO DE CATEGORIA AL CUAL CORRESPONDE EL TAXON
                    categoriataxon = IBPAMPds.Tables("TablaCaracMacroInv").Rows(j).Item(2).ToString
                    'LE SUMA LAS US DE ESA CATEGORIA A LA CANTIDAD EXISTENTE
                    If categoriataxon = "1" Then
                        cat1 = cat1 + cantidadtaxon
                    End If
                    If categoriataxon = "2" Then
                        cat2 = cat2 + cantidadtaxon
                    End If
                    If categoriataxon = "3" Then
                        cat3 = cat3 + cantidadtaxon
                    End If
                    If categoriataxon = "4" Then
                        cat4 = cat4 + cantidadtaxon
                    End If
                    If categoriataxon = "5" Then
                        cat5 = cat5 + cantidadtaxon
                    End If
                    If categoriataxon = "6" Then
                        cat6 = cat6 + cantidadtaxon
                    End If
                    If categoriataxon = "7" Then
                        cat7 = cat7 + cantidadtaxon
                    End If
                End If
            Next
        Next

        'DESPUES DE QUE PASA TODOS LOS TAXONES PRESENTES A CATEGORIAS, 
        'Y SUMA LAS US DE CADA CATEGORIA
        'SE FIJA DE HACER LAS CUENTAS

        If cat1 > 0 Then
            CalculoCat1(cat1)
        Else
            If cat2 > 0 Then
                CalculoCat2(cat2)
            Else
                If cat3 > 0 Then
                    CalculoCat3(cat3)
                Else
                    If cat4 > 0 Then
                        CalculoCat4(cat4)
                    Else
                        If cat5 > 0 Then
                            CalculoCat5(cat5)
                        Else
                            If cat6 > 0 Then
                                CalculoCat6(cat6)
                            Else
                                If cat7 > 0 Then
                                    CalculoCat7(cat7)
                                Else
                                    'MsgBox("No hay Unidades Sistemáticas presentes de ninguna categoría. No se puede calcular el IBPAMP")
                                    Return Nothing
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        'CIERRA EL DATASET
        IBPAMPcon.Close()
        Taxonescon.Close()

        'GUARDA Y DEVUELVE EL VALOR PARA LA MUESTRA
        GuardarIBPAMP(ibpampfinal, idmuestra, idproyecto)
        Return ibpampfinal

    End Function


    Private Sub CalcularUSTotales(ByVal taxonobjetivo As String, tablataxonespresentes As DataGridView)

        'DEBERIA HACER ESTOS PASOS:
        ' 1) Recorrer la tabla de macroinv presentes en la muestra y ver su taxon padre
        ' 2) ver si su taxon padre es el objetivo
        ' 2) si lo es, debe sumar uno al UStotal

        Dim i, j As Integer
        Dim idtaxon As String


        ' CONEXION A LA TABLA DE TAXONES
        Dim Taxonescon As New OleDb.OleDbConnection
        Dim Taxonesds As New DataSet
        Dim TaxonesSQL As String
        Taxonescon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\macroinvertebrados.mdb"
        Taxonescon.Open()
        TaxonesSQL = "SELECT * FROM Taxones"
        Dim Taxonesda = New OleDb.OleDbDataAdapter(TaxonesSQL, Taxonescon)
        Taxonesda.Fill(Taxonesds, "TablaTaxones")

        For i = 0 To tablataxonespresentes.RowCount - 2
            idtaxon = tablataxonespresentes.Item("IdTaxon", i).Value.ToString
            For j = 0 To Taxonesds.Tables("TablaTaxones").Rows.Count - 1
                If Taxonesds.Tables("TablaTaxones").Rows(j).Item(1).ToString = idtaxon Then
                    If Taxonesds.Tables("TablaTaxones").Rows(j).Item("NivelPadre").ToString = taxonobjetivo Then
                        UStotales = UStotales + 1
                    End If
                End If
            Next
        Next
        Taxonescon.Close()
    End Sub


    Private Sub CalculoCat1(ByVal cat1 As Double)
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = UStotales

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

        'GRABA EN ARROYO PAMPEANO
        'GuardarIBPAMP(ibpampfinal, idmuestra, idproyecto)

    End Sub
    Private Sub CalculoCat2(ByVal cat2 As Double)
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = UStotales

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
        'GRABA EN ARROYO PAMPEANO
        'GuardarIBPAMP(ibpampfinal, idmuestra, idproyecto)

    End Sub
    Private Sub CalculoCat3(ByVal cat3 As Double)
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = UStotales

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
        'GRABA EN ARROYO PAMPEANO
        'GuardarIBPAMP(ibpampfinal, idmuestra, idproyecto)

    End Sub
    Private Sub CalculoCat4(ByVal cat4 As Double)
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = UStotales

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
        'GRABA EN ARROYO PAMPEANO
        'GuardarIBPAMP(ibpampfinal, idmuestra, idproyecto)

    End Sub
    Private Sub CalculoCat5(ByVal cat5 As Double)
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = UStotales

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
        'GRABA EN ARROYO PAMPEANO
        'GuardarIBPAMP(ibpampfinal, idmuestra, idproyecto)

    End Sub
    Private Sub CalculoCat6(ByVal cat6 As Double)
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = UStotales

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
        'GRABA EN ARROYO PAMPEANO
        ' GuardarIBPAMP(ibpampfinal, idmuestra, idproyecto)

    End Sub
    Private Sub CalculoCat7(ByVal cat7 As Double)
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = UStotales

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

        'GRABA EN ARROYO PAMPEANO
        'GuardarIBPAMP(ibpampfinal, idmuestra, idproyecto)

    End Sub

    Private Sub GuardarIBPAMP(ByVal valorconpunto As String, ByVal idmuestra As Integer, ByVal idproyecto As Integer)

        ' CONEXION A LA TABLA DE IBPAMP
        Dim IBPAMPcon As New OleDb.OleDbConnection
        Dim IBPAMPds As New DataSet
        Dim IBPAMPSql As String
        IBPAMPcon.Close()
        IBPAMPcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\ibpamp.mdb"
        IBPAMPcon.Open()
        IBPAMPSql = "SELECT * FROM IBPAMP Where IdMuestra = '" & idmuestra & "'"
        Dim IBPAMPda = New OleDb.OleDbDataAdapter(IBPAMPSql, IBPAMPcon)
        IBPAMPda.Fill(IBPAMPds, "TablaIBPAMP")
        Dim IBPAMPcb As New OleDb.OleDbCommandBuilder(IBPAMPda)


        ' ME FIJO SI HABIA YA UN VALOR DE IBPAMP, SINO HAGO UNA ROW NUEVA

        If IBPAMPds.Tables("TablaIBPAMP").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = IBPAMPds.Tables("TablaIBPAMP").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("Indice") = valorconpunto
            dsNewRow.Item("USTotales") = UStotales
            dsNewRow.Item("Prec") = UStotales
            IBPAMPds.Tables("TablaIBPAMP").Rows.Add(dsNewRow)
            IBPAMPda.Update(IBPAMPds, "TablaIBPAMP")
            IBPAMPcon.Close()
        Else
            'SI YA HABIA VALORES DE IMRP

            IBPAMPds.Tables("TablaIBPAMP").Rows(0).Item("IdMuestra") = idmuestra
            IBPAMPds.Tables("TablaIBPAMP").Rows(0).Item("IdProyecto") = idproyecto
            IBPAMPds.Tables("TablaIBPAMP").Rows(0).Item("Indice") = valorconpunto
            IBPAMPds.Tables("TablaIBPAMP").Rows(0).Item("USTotales") = UStotales
            IBPAMPds.Tables("TablaIBPAMP").Rows(0).Item("Prec") = UStotales
            IBPAMPda.Update(IBPAMPds, "TablaIBPAMP")
            IBPAMPcon.Close()
        End If

    End Sub

    'NECESITO HACER UNA FUNCION PARA QUE SEPA DIFERENCIAR SI LOS TAXONES RELACIONADOS CON ESTE INDICE SON DIATOMEAS, MACROINV U OTROS
    'POR SI SE REQUIERE... SE USA DESDE FRMDBINDICES

    Public Function DefineTaxonesIBPAMP(dummy As String)
        Dim taxonestipo As String = "macroinvertebrados"
        Return (taxonestipo)
    End Function

    'TRADUCCION DEL INDICE A PALABRAS, A PARTIR DE UN VALOR
    'DEVUELVE TRES VALORES:
    'claseagua= clase de agua (si hay)
    'colorvalor= color del indice
    'sign= en palabras, lo q significa el valor

    Public Function TraduceIBPAMP(valorindice As String)
        Dim claseagua As String = ""
        Dim colorvalor As String = ""
        Dim sign As String = ""
        Dim valorindice1 As Double = CDbl(valorindice)

        If valorindice1 >= 10 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Agua no poluída"
        ElseIf valorindice1 >= 8 And valorindice < 10 Then
            claseagua = "2"
            colorvalor = "Verde"
            sign = "Agua suavemente poluída"
        ElseIf valorindice1 >= 6 And valorindice < 8 Then
            claseagua = "3"
            colorvalor = "Amarillo"
            sign = "Moderadamente poluída"
        ElseIf valorindice1 >= 4 And valorindice < 6 Then
            claseagua = "4"
            colorvalor = "Naranja"
            sign = "Fuertemente poluída"
        ElseIf valorindice1 <= 4 Then
            claseagua = "5"
            colorvalor = "Rojo"
            sign = "Muy fuertemente poluída"
        End If

        Dim retorno As String = claseagua & ";" & colorvalor & ";" & sign
        Return (retorno)

    End Function



End Module
