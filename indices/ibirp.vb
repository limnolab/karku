Public Module ibirp
    Dim idmuestra As String
    Dim idproyecto As String
    Dim formorigen As String
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Public Function CalcularIBIRP(idmuestracalcular As String, idproyectocalcular As String)
        idmuestra = idmuestracalcular
        idproyecto = idproyectocalcular
        ' LOS PASOS DE CALCULO SON:

        ' 1) BUSCA EN LA DB DE OTROSDATOS LOS DATOS PARA LA IDMUESTRA. SI LA MUESTRA NO EXISTE, SALE. Genera una tabla virtual para los parametros a calcular
        ' 2) LEE DE LA BASE DE DATOS DEL INDICE LOS CODIGOS Y NUMEROS DE PARAMETROS DE OTROSDATOS QUE INCLUYE EL INDICE
        ' 3) RETIENE, DE LA DB DE OTROSDATOS PARA LA MUESTRA, SOLO LOS PARAMETROS CUYO NUMERO COINCIDE CON LOS QUE ESTAN INCLUIDOS EN EL INDICE
        ' 4) CALCULAR EL INDICE FINAL
        ' 5) GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL

        '----------------------------------------------------------------------------------
        'PASO 1:  BUSCA EN LA DB DE OTROSDATOS LOS DATOS PARA LA IDMUESTRA

        Dim Otroscon As New OleDb.OleDbConnection
        Dim Otrosds As New DataSet
        Dim OtrosSQL As String
        Otroscon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\otros.mdb"
        Otroscon.Open()
        OtrosSQL = "SELECT * FROM ParametrosOtros WHERE IdMuestra = '" & idmuestracalcular & "'"
        Dim Otrosda = New OleDb.OleDbDataAdapter(OtrosSQL, Otroscon)
        Otrosda.Fill(Otrosds, "TablaOtros")

        If Otrosds.Tables("TablaOtros").Rows.Count = 0 Then
            Otroscon.Close()
            Return Nothing
            Exit Function
        End If

        'GENERA UNA TABLA VIRTUAL
        Dim ParametrosIBIRP As New DataGridView
        Dim idcol As New DataGridViewTextBoxColumn
        Dim idproyectocol As New DataGridViewTextBoxColumn
        idcol.Name = "IdMuestra"
        idproyectocol.Name = "IdProyecto"
        ParametrosIBIRP.Columns.Add(idcol)
        ParametrosIBIRP.Columns.Add(idproyectocol)


        'agrego una row para esta muestra
        ParametrosIBIRP.Rows.Add()
        ParametrosIBIRP.Rows(0).Cells("IdMuestra").Value = idmuestracalcular
        ParametrosIBIRP.Rows(0).Cells("IdProyecto").Value = idproyectocalcular

        '----------------------------------------------------------------------------------
        'PASO 2:  LEE DE LA BASE DE DATOS DEL INDICE LOS CODIGOS Y NUMEROS DE PARAMETROS DE HABITAT QUE INCLUYE EL INDICE. Crea una tabla virtual

        Dim IBIRPcon As New OleDb.OleDbConnection
        Dim IBIRPds As New DataSet
        Dim IBIRPSQL As String
        IBIRPcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\ibirp.mdb"
        IBIRPcon.Open()
        IBIRPSQL = "SELECT * FROM CaracIBIRP"
        Dim IBIRPda = New OleDb.OleDbDataAdapter(IBIRPSQL, IBIRPcon)
        IBIRPda.Fill(IBIRPds, "TablaIBIRP")


        'ESTO PUEDE SER REEMPLAZADO SACANDO EL LOOP, TOTAL LOS VALORES PARA EL IHRPLATA SON DEFINIDOS. PERO ASI RECUPERA EL IDPARAMETRO POR SI CAMBIA
        For i As Integer = 0 To IBIRPds.Tables("TablaIBIRP").Rows.Count - 1
            Dim newcol As New DataGridViewTextBoxColumn
            newcol.Name = "p" & IBIRPds.Tables("TablaIBIRP").Rows(i).Item("IdParametro").ToString
            newcol.HeaderText = IBIRPds.Tables("TablaIBIRP").Rows(i).Item("codigo").ToString
            ParametrosIBIRP.Columns.Add(newcol)
        Next

        '----------------------------------------------------------------------------------
        'PASO 3:  RETIENE EN LA DGV VIRTUAL SOLO LOS PARAMETROS CUYO NUMERO COINCIDE CON LOS QUE ESTAN INCLUIDOS EN EL INDICE

        For i = 2 To ParametrosIBIRP.Columns.Count - 1
            'retiene el numero del idparametro
            Dim idparametrobuscar As String = ParametrosIBIRP.Columns(i).Name.ToString
            'busca ese idparametro en la tabla precargada con los datos de otrosdatos de la meustra
            For j As Integer = 0 To Otrosds.Tables("TablaOtros").Columns.Count - 1
                If Otrosds.Tables("TablaOtros").Columns(j).ColumnName = idparametrobuscar Then
                    'matcheo el parametro que esta en el indice con la columna en la tabla de otrosodatos, asi que retiene el valor de esa celda y lo manda a la nueva tabla virtual
                    ParametrosIBIRP.Item(i, 0).Value = Otrosds.Tables("TablaOtros").Rows(0).Item(j).ToString
                    Exit For
                End If
            Next
        Next

        '----------------------------------------------------------------------------------
        'PASO 4:  YA TIENE LA DGV VIRTUAL COMPLETA, CALCULA EL INDICE


        Dim indicPCD As Double
        Dim indicPTD As Double
        Dim indicMTD As Double
        Dim indicTANAID As Double
        Dim precision As Integer

        'cada variable se calcula: [(value for test site - floor)/(ceiling-floor) x 10]

        For i = 2 To ParametrosIBIRP.Columns.Count - 1
            ' traduce el PCD (planktonic cyanobacterial density) y corrije los margenes (a 0 y a 10)
            If ParametrosIBIRP.Columns(i).HeaderText = "densidadcyano" Then
                ' ceiling : 0; floor: 25000
                indicPCD = ((ParametrosIBIRP.Item(i, 0).Value - 25000) / (0 - 25000)) * 10
                If indicPCD < 0 Then
                    indicPCD = 0
                ElseIf indicPCD > 10 Then
                    indicPCD = 10
                End If
                precision = precision + 1

                'traduce el PTD (Phytoplanktonic total density) y corrije los margenes (a 0 y a 10)
            ElseIf ParametrosIBIRP.Columns(i).HeaderText = "fitototal" Then
                ' ceiling : 30; floor: 80000
                indicPTD = ((ParametrosIBIRP.Item(i, 0).Value - 80000) / (30 - 80000)) * 10
                If indicPTD < 0 Then
                    indicPTD = 0
                ElseIf indicPTD > 10 Then
                    indicPTD = 10
                End If
                precision = precision + 1
                'traduce el MTD (% Most tolerant diatoms) y corrije los margenes (a 0 y a 10)
            ElseIf ParametrosIBIRP.Columns(i).HeaderText = "densidaddiatoMT" Then
                ' ceiling : 1; floor: 40
                indicMTD = ((ParametrosIBIRP.Item(i, 0).Value - 40) / (1 - 40)) * 10
                If indicMTD < 0 Then
                    indicMTD = 0
                ElseIf indicMTD > 10 Then
                    indicMTD = 10
                End If
                precision = precision + 1

                'traduce el TANAID (% Tanaidacea) y corrije los margenes (a 0 y a 10)
            ElseIf ParametrosIBIRP.Columns(i).HeaderText = "tanaidaceos" Then
                ' ceiling : 25; floor: 0
                indicTANAID = ((ParametrosIBIRP.Item(i, 0).Value - 0) / (25 - 0)) * 10
                If indicTANAID < 0 Then
                    indicTANAID = 0
                ElseIf indicTANAID > 10 Then
                    indicTANAID = 10
                End If
                precision = precision + 1
            End If
        Next

        'calcula el promedio de los cuatro indicadores
        Dim IBIRPfinal As Double = Math.Round(((indicPCD + indicPTD + indicMTD + indicTANAID) / 4), 2)

        '----------------------------------------------------------------------------------
        'PASO 5: GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL Y DEVUELVE EL VALOR RESULTANTE
        'CIERRA EL DATASET
        IBIRPcon.Close()
        Otroscon.Close()

        'GRABA SI LA PRECISION ES MAYOR A UNO
        If precision >= 1 Then

            'GRABA 
            GuardarIBIRP(IBIRPfinal, precision, idmuestra, idproyecto)
            Return IBIRPfinal
        Else
            Return Nothing
        End If
    End Function


    Private Sub GuardarIBIRP(ByVal valorconpunto As String, precision As Integer, ByVal idmuestra As String, ByVal idproyecto As String)
        ' CONEXION A LA TABLA DE IBIRP
        Dim IBIRPcon As New OleDb.OleDbConnection
        Dim IBIRPds As New DataSet
        Dim IBIRPSql As String
        IBIRPcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\ibirp.mdb"
        IBIRPcon.Open()
        IBIRPSql = "SELECT * FROM IBIRP Where IdMuestra = '" & idmuestra & "'"
        Dim IBIRPda = New OleDb.OleDbDataAdapter(IBIRPSql, IBIRPcon)
        IBIRPda.Fill(IBIRPds, "TablaIBIRP")
        Dim IBIRPcb As New OleDb.OleDbCommandBuilder(IBIRPda)

        ' ME FIJO SI HABIA YA UN VALOR DE IBIRP, SINO HAGO UNA ROW NUEVA

        If IBIRPds.Tables("TablaIBIRP").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = IBIRPds.Tables("TablaIBIRP").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("Valor") = valorconpunto
            dsNewRow.Item("Prec") = precision
            IBIRPds.Tables("TablaIBIRP").Rows.Add(dsNewRow)
            IBIRPda.Update(IBIRPds, "TablaIBIRP")
            IBIRPcon.Close()
        Else
            'SI YA HABIA VALORES DE IBIRP
            IBIRPds.Tables("TablaIBIRP").Rows(0).Item("IdMuestra") = idmuestra
            IBIRPds.Tables("TablaIBIRP").Rows(0).Item("IdProyecto") = idproyecto
            IBIRPds.Tables("TablaIBIRP").Rows(0).Item("Valor") = valorconpunto
            IBIRPds.Tables("TablaIBIRP").Rows(0).Item("Prec") = precision
            IBIRPda.Update(IBIRPds, "TablaIBIRP")
            IBIRPcon.Close()
        End If
    End Sub
    Public Function DefineTaxonesIBIRP(dummy As String)
        Dim taxonestipo As String = "múltiples variables"
        Return (taxonestipo)
    End Function

    'TRADUCCION DEL INDICE A PALABRAS, A PARTIR DE UN VALOR
    'DEVUELVE TRES VALORES:
    'claseagua= clase de agua (si hay)
    'colorvalor= color del indice
    'sign= en palabras, lo q significa el valor

    Public Function TraduceIBIRP(valorindice As String)
        Dim claseagua As String = ""
        Dim colorvalor As String = ""
        Dim sign As String = ""
        Dim valorindice1 As Double = CDbl(valorindice)

        If valorindice1 >= 8 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Muy buen estado biológico"
        ElseIf valorindice1 >= 6 And valorindice < 8 Then
            claseagua = "2"
            colorvalor = "Verde"
            sign = "Buen estado biológicoa"
        ElseIf valorindice1 >= 4 And valorindice < 6 Then
            claseagua = "3"
            colorvalor = "Amarillo"
            sign = "Aceptable estado biológico"
        ElseIf valorindice1 >= 2 And valorindice < 6 Then
            claseagua = "4"
            colorvalor = "Naranja"
            sign = "Pobre estado biológico"
        ElseIf valorindice1 <= 2 Then
            claseagua = "5"
            colorvalor = "Rojo"
            sign = "Mal estado biológico"
        End If

        Dim retorno As String = claseagua & ";" & colorvalor & ";" & sign
        Return (retorno)

    End Function

End Module
