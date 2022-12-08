Public Module cbr
    Dim idmuestra As String
    Dim idproyecto As String
    Dim formorigen As String
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Public Function CalcularCBR(idmuestracalcular As String, idproyectocalcular As String)
        idmuestra = idmuestracalcular
        idproyecto = idproyectocalcular
        ' LOS PASOS DE CALCULO SON:

        ' 1) BUSCA EN LA DB DE HABITAT LOS DATOS PARA LA IDMUESTRA. SI LA MUESTRA NO EXISTE, SALE. Genera una tabla virtual para los parametros a calcular
        ' 2) LEE DE LA BASE DE DATOS DEL INDICE LOS CODIGOS Y NUMEROS DE PARAMETROS DE HABITAT QUE INCLUYE EL INDICE
        ' 3) RETIENE, DE LA DB DE HABITAT PARA LA MUESTRA, SOLO LOS PARAMETROS CUYO NUMERO COINCIDE CON LOS QUE ESTAN INCLUIDOS EN EL INDICE
        ' 4) CALCULAR EL INDICE FINAL
        ' 5) GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL

        '----------------------------------------------------------------------------------
        'PASO 1:  BUSCA EN LA DB DE HABITAT LOS DATOS PARA LA IDMUESTRA

        Dim Habitatcon As New OleDb.OleDbConnection
        Dim Habitatds As New DataSet
        Dim HabitatSQL As String
        Habitatcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\habitat.mdb"
        Habitatcon.Open()
        HabitatSQL = "SELECT * FROM ParametrosHabitat WHERE IdMuestra = '" & idmuestracalcular & "'"
        Dim Habitatda = New OleDb.OleDbDataAdapter(HabitatSQL, Habitatcon)
        Habitatda.Fill(Habitatds, "TablaHabitat")

        If Habitatds.Tables("TablaHabitat").Rows.Count = 0 Then
            Habitatcon.Close()
            Return Nothing
            Exit Function
        End If

        'GENERA UNA TABLA VIRTUAL
        Dim ParametrosCBR As New DataGridView
        Dim idcol As New DataGridViewTextBoxColumn
        Dim idproyectocol As New DataGridViewTextBoxColumn
        idcol.Name = "IdMuestra"
        idproyectocol.Name = "IdProyecto"
        ParametrosCBR.Columns.Add(idcol)
        ParametrosCBR.Columns.Add(idproyectocol)


        'agrego una row para esta muestra
        ParametrosCBR.Rows.Add()
        ParametrosCBR.Rows(0).Cells("IdMuestra").Value = idmuestracalcular
        ParametrosCBR.Rows(0).Cells("IdProyecto").Value = idproyectocalcular

        '----------------------------------------------------------------------------------
        'PASO 2:  LEE DE LA BASE DE DATOS DEL INDICE LOS CODIGOS Y NUMEROS DE PARAMETROS DE HABITAT QUE INCLUYE EL INDICE. Crea una tabla virtual

        Dim CBRcon As New OleDb.OleDbConnection
        Dim CBRds As New DataSet
        Dim CBRSQL As String
        CBRcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\cbr.mdb"
        CBRcon.Open()
        CBRSQL = "SELECT * FROM CaracCBR"
        Dim CBRda = New OleDb.OleDbDataAdapter(CBRSQL, CBRcon)
        CBRda.Fill(CBRds, "TablaCBR")


        'ESTO PUEDE SER REEMPLAZADO SACANDO EL LOOP, TOTAL LOS VALORES PARA EL CBR SON DEFINIDOS. PERO ASI RECUPERA EL IDPARAMETRO POR SI CAMBIA
        For i As Integer = 0 To CBRds.Tables("TablaCBR").Rows.Count - 1
            Dim newcol As New DataGridViewTextBoxColumn
            newcol.Name = "p" & CBRds.Tables("TablaCBR").Rows(i).Item("IdParametro").ToString
            newcol.HeaderText = CBRds.Tables("TablaCBR").Rows(i).Item("codigo").ToString
            ParametrosCBR.Columns.Add(newcol)
        Next

        '----------------------------------------------------------------------------------
        'PASO 3:  RETIENE EN LA DGV VIRTUAL SOLO LOS PARAMETROS CUYO NUMERO COINCIDE CON LOS QUE ESTAN INCLUIDOS EN EL INDICE

        For i = 2 To ParametrosCBR.Columns.Count - 1
            'retiene el numero del idparametro
            Dim idparametrobuscar As String = ParametrosCBR.Columns(i).Name.ToString
            'busca ese idparametro en la tabla precargada con los datos de habitat de la meustra
            For j As Integer = 0 To Habitatds.Tables("TablaHabitat").Columns.Count - 1
                If Habitatds.Tables("TablaHabitat").Columns(j).ColumnName = idparametrobuscar Then
                    'matcheo el parametro que esta en el indice con la columna en la tabla de habitat, asi que retiene el valor de esa celda y lo manda a la nueva tabla virtual
                    ParametrosCBR.Item(i, 0).Value = Habitatds.Tables("TablaHabitat").Rows(0).Item(j).ToString
                    Exit For
                End If
            Next
        Next


        'copia a la dgvPRUEBA - REVISION INTERNA NOMAS

        For Each Col As DataGridViewColumn In ParametrosCBR.Columns
            frmPrincipal.DataGridView1.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next
        For i As Integer = 0 To ParametrosCBR.Rows.Count - 1
            frmPrincipal.DataGridView1.Rows.Add(ParametrosCBR.Rows(i).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        Next

        '----------------------------------------------------------------------------------
        'PASO 4:  YA TIENE LA DGV VIRTUAL COMPLETA, CALCULA EL INDICE

        Dim indiccobertura As Double
        Dim indiccomplejidad As Double
        Dim morforibera As Double
        Dim naturalidad As Double
        Dim precision As Integer

        'Por cada parametro por p+ID recupera su valor y lo traduce a un valor de puntuacion, y se lo suma a su categoria
        For i = 2 To ParametrosCBR.Columns.Count - 1
            'COBERTURA
            If ParametrosCBR.Columns(i).Name = "p9" Then
                If ParametrosCBR.Item(i, 0).Value.ToString.Contains(">80%") Then
                    indiccobertura = indiccobertura + 25
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("50-80%") Then
                    indiccobertura = indiccobertura + 10
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("10-50%") Then
                    indiccobertura = indiccobertura + 5
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("<10%") Then
                    indiccobertura = indiccobertura + 0
                    precision = precision + 1
                End If

                 'COMPLEJIDAD
            ElseIf ParametrosCBR.Columns(i).Name = "p11" Then
                If ParametrosCBR.Item(i, 0).Value.ToString.Contains(">75%") Then
                    indiccomplejidad = indiccobertura + 25
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("50-75%") Then
                    indiccomplejidad = indiccobertura + 10
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("<50%") Then
                    If ParametrosCBR.Item("p12", 0).Value.ToString.Contains("10-25%") Or ParametrosCBR.Item("p12", 0).Value.ToString.Contains(">50%") Or ParametrosCBR.Item("p12", 0).Value.ToString.Contains("25-50%") Then
                        indiccomplejidad = indiccobertura + 5
                        precision = precision + 1
                    ElseIf ParametrosCBR.Item("p12", 0).Value.ToString.Contains("<10%") Then
                        indiccomplejidad = indiccobertura + 0
                        precision = precision + 1
                    End If
                End If

                'MORFOLOGIA VEGETAL

            ElseIf ParametrosCBR.Columns(i).Name = "p16" Then
                If ParametrosCBR.Item(i, 0).Value.ToString.Contains(">50%") Then
                    morforibera = morforibera + 25
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("30-50%") Then
                    morforibera = morforibera + 10
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("<30%") Then
                    morforibera = morforibera + 5
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("Sin especies autóctona") Then
                    morforibera = morforibera + 0
                    precision = precision + 1
                End If

                'NATURALIDAD
            ElseIf ParametrosCBR.Columns(i).Name = "p20" Then
                If ParametrosCBR.Item(i, 0).Value.ToString.Contains("Canal sin modificar") Then
                    naturalidad = naturalidad + 25
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("Modificaciones de terrazas sin reducción del canal") Then
                    naturalidad = naturalidad + 10
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("Modificaciones de terrazas con reducción del canal") Then
                    naturalidad = naturalidad + 10
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("Signos de alteración y estructuras que modifican el canal") Then
                    naturalidad = naturalidad + 5
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("Estructuras transversales") Then
                    naturalidad = naturalidad + 5
                    precision = precision + 1
                ElseIf ParametrosCBR.Item(i, 0).Value.ToString.Contains("Canalización total") Then
                    naturalidad = naturalidad + 0
                    precision = precision + 1
                End If
            End If
        Next

        'calcula el promedio de los cuatro indicadores
        Dim cbrlatafinal As Double = (indiccobertura + indiccomplejidad + morforibera + naturalidad)

        '----------------------------------------------------------------------------------
        'PASO 5: GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL Y DEVUELVE EL VALOR RESULTANTE
        'CIERRA EL DATASET
        CBRcon.Close()
        Habitatcon.Close()
        'GRABA SI LA PRECISION ES MAYOR A UNO
        If precision >= 1 Then
            'GRABA 
            GuardarCBR(cbrlatafinal, precision, idmuestra, idproyecto)
            Return cbrlatafinal
        Else
            Return Nothing
        End If

    End Function


    Private Sub GuardarCBR(ByVal valorconpunto As String, precision As Integer, ByVal idmuestra As String, ByVal idproyecto As String)
        ' CONEXION A LA TABLA DE IDP
        Dim CBRcon As New OleDb.OleDbConnection
        Dim CBRds As New DataSet
        Dim CBRSql As String
        CBRcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\cbr.mdb"
        CBRcon.Open()
        CBRSql = "SELECT * FROM CBR Where IdMuestra = '" & idmuestra & "'"
        Dim CBRda = New OleDb.OleDbDataAdapter(CBRSql, CBRcon)
        CBRda.Fill(CBRds, "TablaCBR")
        Dim CBRcb As New OleDb.OleDbCommandBuilder(CBRda)

        ' ME FIJO SI HABIA YA UN VALOR DE IDP, SINO HAGO UNA ROW NUEVA

        If CBRds.Tables("TablaCBR").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = CBRds.Tables("TablaCBR").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("Valor") = valorconpunto
            dsNewRow.Item("Prec") = precision
            CBRds.Tables("TablaCBR").Rows.Add(dsNewRow)
            CBRda.Update(CBRds, "TablaCBR")
            CBRcon.Close()
        Else
            'SI YA HABIA VALORES DE CBR
            CBRds.Tables("TablaCBR").Rows(0).Item("IdMuestra") = idmuestra
            CBRds.Tables("TablaCBR").Rows(0).Item("IdProyecto") = idproyecto
            CBRds.Tables("TablaCBR").Rows(0).Item("Valor") = valorconpunto
            CBRds.Tables("TablaCBR").Rows(0).Item("Prec") = precision
            CBRda.Update(CBRds, "TablaCBR")
            CBRcon.Close()
        End If
    End Sub

    'NECESITO HACER UNA FUNCION PARA QUE SEPA DIFERENCIAR SI LOS TAXONES RELACIONADOS CON ESTE INDICE SON DIATOMEAS, MACROINV U OTROS
    'POR SI SE REQUIERE... SE USA DESDE FRMDBINDICES

    Public Function DefineTaxonesCBR(dummy As String)
        Dim taxonestipo As String = "hábitat"
        Return (taxonestipo)
    End Function



    'TRADUCCION DEL INDICE A PALABRAS, A PARTIR DE UN VALOR
    'DEVUELVE TRES VALORES:
    'claseagua= clase de agua (si hay)
    'colorvalor= color del indice
    'sign= en palabras, lo q significa el valor

    Public Function TraduceCBR(valorindice As String)
        Dim claseagua As String = ""
        Dim colorvalor As String = ""
        Dim sign As String = ""
        Dim valorindice1 As Double = CDbl(valorindice)

        If valorindice1 >= 95 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Máxima calidad de ribera"
        ElseIf valorindice1 >= 75 And valorindice < 95 Then
            claseagua = "2"
            colorvalor = "Verde"
            sign = "Buena calidad de ribera"
        ElseIf valorindice1 >= 51 And valorindice < 75 Then
            claseagua = "3"
            colorvalor = "Amarillo"
            sign = "Moderada calidad de ribera"
        ElseIf valorindice1 >= 25 And valorindice < 51 Then
            claseagua = "4"
            colorvalor = "Naranja"
            sign = "Mala calidad de ribera"
        ElseIf valorindice1 <= 25 Then
            claseagua = "5"
            colorvalor = "Rojo"
            sign = "Pésima calidad de ribera"
        End If

        Dim retorno As String = claseagua & ";" & colorvalor & ";" & sign
        Return (retorno)

    End Function


End Module
