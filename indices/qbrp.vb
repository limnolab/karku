Public Module qbrp
    Dim idmuestra As String
    Dim idproyecto As String
    Dim formorigen As String
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Public Function CalcularQBRP(idmuestracalcular As String, idproyectocalcular As String)
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
        Dim ParametrosQBRp As New DataGridView
        Dim idcol As New DataGridViewTextBoxColumn
        Dim idproyectocol As New DataGridViewTextBoxColumn
        idcol.Name = "IdMuestra"
        idproyectocol.Name = "IdProyecto"
        ParametrosQBRp.Columns.Add(idcol)
        ParametrosQBRp.Columns.Add(idproyectocol)


        'agrego una row para esta muestra
        ParametrosQBRp.Rows.Add()
        ParametrosQBRp.Rows(0).Cells("IdMuestra").Value = idmuestracalcular
        ParametrosQBRp.Rows(0).Cells("IdProyecto").Value = idproyectocalcular

        '----------------------------------------------------------------------------------
        'PASO 2:  LEE DE LA BASE DE DATOS DEL INDICE LOS CODIGOS Y NUMEROS DE PARAMETROS DE HABITAT QUE INCLUYE EL INDICE. Crea una tabla virtual

        Dim QBRpcon As New OleDb.OleDbConnection
        Dim QBRpds As New DataSet
        Dim QBRpSQL As String
        QBRpcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\qbrp.mdb"
        QBRpcon.Open()
        QBRpSQL = "SELECT * FROM CaracQBRp"
        Dim QBRpda = New OleDb.OleDbDataAdapter(QBRpSQL, QBRpcon)
        QBRpda.Fill(QBRpds, "TablaQBRp")


        'ESTO PUEDE SER REEMPLAZADO SACANDO EL LOOP, TOTAL LOS VALORES PARA EL QBRp SON DEFINIDOS. PERO ASI RECUPERA EL IDPARAMETRO POR SI CAMBIA
        For i As Integer = 0 To QBRpds.Tables("TablaQBRp").Rows.Count - 1
            Dim newcol As New DataGridViewTextBoxColumn
            newcol.Name = "p" & QBRpds.Tables("TablaQBRp").Rows(i).Item("IdParametro").ToString
            newcol.HeaderText = QBRpds.Tables("TablaQBRp").Rows(i).Item("codigo").ToString
            ParametrosQBRp.Columns.Add(newcol)
        Next

        '----------------------------------------------------------------------------------
        'PASO 3:  RETIENE EN LA DGV VIRTUAL SOLO LOS PARAMETROS CUYO NUMERO COINCIDE CON LOS QUE ESTAN INCLUIDOS EN EL INDICE

        For i = 2 To ParametrosQBRp.Columns.Count - 1
            'retiene el numero del idparametro
            Dim idparametrobuscar As String = ParametrosQBRp.Columns(i).Name.ToString
            'busca ese idparametro en la tabla precargada con los datos de habitat de la meustra
            For j As Integer = 0 To Habitatds.Tables("TablaHabitat").Columns.Count - 1
                If Habitatds.Tables("TablaHabitat").Columns(j).ColumnName = idparametrobuscar Then
                    'matcheo el parametro que esta en el indice con la columna en la tabla de habitat, asi que retiene el valor de esa celda y lo manda a la nueva tabla virtual
                    ParametrosQBRp.Item(i, 0).Value = Habitatds.Tables("TablaHabitat").Rows(0).Item(j).ToString
                    Exit For
                End If
            Next
        Next


        'copia a la dgvPRUEBA - REVISION INTERNA NOMAS

        For Each Col As DataGridViewColumn In ParametrosQBRp.Columns
            frmPrincipal.DataGridView1.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next
        For i As Integer = 0 To ParametrosQBRp.Rows.Count - 1
            frmPrincipal.DataGridView1.Rows.Add(ParametrosQBRp.Rows(i).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        Next

        '----------------------------------------------------------------------------------
        'PASO 4:  YA TIENE LA DGV VIRTUAL COMPLETA, CALCULA EL INDICE

        Dim indiccobertura As Double
        Dim indiccomplejidad As Double
        Dim morforibera As Double
        Dim naturalidad As Double
        Dim precision As Integer

        'Por cada parametro por p+ID recupera su valor y lo traduce a un valor de puntuacion, y se lo suma a su categoria
        For i = 2 To ParametrosQBRp.Columns.Count - 1
            'COBERTURA
            If ParametrosQBRp.Columns(i).Name = "p9" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains(">80%") Then
                    indiccobertura = indiccobertura + 20
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("50-80%") Then
                    indiccobertura = indiccobertura + 15
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("10-50%") Then
                    indiccobertura = indiccobertura + 10
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("<10%") Then
                    indiccobertura = indiccobertura + 5
                    precision = precision + 1
                End If

            ElseIf ParametrosQBRp.Columns(i).Name = "p10" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Total") Then
                    indiccobertura = indiccobertura + 5
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains(">50%") Then
                    indiccobertura = indiccobertura + 2
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("25-50%") Then
                    indiccobertura = indiccobertura - 2
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("<25%") Then
                    indiccobertura = indiccobertura - 5
                    precision = precision + 1
                End If
                'COMPLEJIDAD
            ElseIf ParametrosQBRp.Columns(i).Name = "p11" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains(">75%") Then
                    indiccomplejidad = indiccobertura + 18
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("50-75%") Then
                    indiccomplejidad = indiccobertura + 15
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("<50%") Then
                    If ParametrosQBRp.Item("p12", 0).Value.ToString.Contains("10-25%") Then
                        indiccomplejidad = indiccobertura + 10
                        precision = precision + 1
                    ElseIf ParametrosQBRp.Item("p12", 0).Value.ToString.Contains("<10%") Then
                        indiccomplejidad = indiccobertura + 5
                        precision = precision + 1
                    End If
                End If

            ElseIf ParametrosQBRp.Columns(i).Name = "p12" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains(">50%") Then
                    indiccomplejidad = indiccomplejidad + 5
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("25-50%") Then
                    indiccomplejidad = indiccomplejidad + 2
                    precision = precision + 1
                End If

            ElseIf ParametrosQBRp.Columns(i).Name = "p13" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains(">50%") Then
                    indiccomplejidad = indiccomplejidad + 2
                    precision = precision + 1
                End If

            ElseIf ParametrosQBRp.Columns(i).Name = "p14" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Lineal") Then
                    If ParametrosQBRp.Item("p13", 0).Value.ToString.Contains(">50%") Then
                        indiccomplejidad = indiccomplejidad + 2
                        precision = precision + 1
                    ElseIf ParametrosQBRp.Item("p13", 0).Value.ToString.Contains("<50%") Then
                        indiccomplejidad = indiccomplejidad - 5
                        precision = precision + 1
                    End If
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Manchas discontinuas") Then
                    indiccomplejidad = indiccomplejidad - 2
                    precision = precision + 1
                End If

                'MORFOLOGIA VEGETAL

            ElseIf ParametrosQBRp.Columns(i).Name = "p16" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Óptimo") Then
                    morforibera = morforibera + 15
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Subóptimo") Then
                    morforibera = morforibera + 10
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Sin especies autóctona") Then
                    morforibera = morforibera + 5
                    precision = precision + 1
                End If

            ElseIf ParametrosQBRp.Columns(i).Name = "p17" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains(">75%") Then
                    morforibera = morforibera + 5
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("50-75%") Then
                    morforibera = morforibera + 2.5
                    precision = precision + 1
                End If

            ElseIf ParametrosQBRp.Columns(i).Name = "p18" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Tipo 1") Then
                    morforibera = morforibera + 7
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Tipo 2") Then
                    morforibera = morforibera + 8
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Tipo 3") Then
                    morforibera = morforibera + 9
                    precision = precision + 1
                End If

            ElseIf ParametrosQBRp.Columns(i).Name = "p19" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Algunas") Then
                    morforibera = morforibera - 2.5
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Varias formando comunidades") Then
                    morforibera = morforibera - 5
                    precision = precision + 1
                End If
                'NATURALIDAD
            ElseIf ParametrosQBRp.Columns(i).Name = "p20" Then
                If ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Canal sin modificar") Then
                    naturalidad = naturalidad + 25
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Modificaciones de terrazas sin reducción del canal") Then
                    naturalidad = naturalidad + 20
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Modificaciones de terrazas con reducción del canal") Then
                    naturalidad = naturalidad + 15
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Signos de alteración y estructuras que modifican el canal") Then
                    naturalidad = naturalidad + 10
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Estructuras transversales") Then
                    naturalidad = naturalidad + 5
                    precision = precision + 1
                ElseIf ParametrosQBRp.Item(i, 0).Value.ToString.Contains("Canalización total") Then
                    naturalidad = naturalidad + 0
                    precision = precision + 1
                End If
            End If
        Next

        'calcula el promedio de los cuatro indicadores
        Dim qbrplatafinal As Double = (indiccobertura + indiccomplejidad + morforibera + naturalidad)

        '----------------------------------------------------------------------------------
        'PASO 5: GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL Y DEVUELVE EL VALOR RESULTANTE
        'CIERRA EL DATASET
        QBRpcon.Close()
        Habitatcon.Close()
        'GRABA SI LA PRECISION ES MAYOR A UNO
        If precision >= 1 Then
            'GRABA 
            GuardarQBRp(qbrplatafinal, precision, idmuestra, idproyecto)
            Return qbrplatafinal
        Else
            Return Nothing
        End If

    End Function


    Private Sub GuardarQBRp(ByVal valorconpunto As String, precision As Integer, ByVal idmuestra As String, ByVal idproyecto As String)
        ' CONEXION A LA TABLA DE IDP
        Dim QBRpcon As New OleDb.OleDbConnection
        Dim QBRpds As New DataSet
        Dim QBRpSql As String
        QBRpcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\qbrp.mdb"
        QBRpcon.Open()
        QBRpSql = "SELECT * FROM QBRp Where IdMuestra = '" & idmuestra & "'"
        Dim QBRpda = New OleDb.OleDbDataAdapter(QBRpSql, QBRpcon)
        QBRpda.Fill(QBRpds, "TablaQBRp")
        Dim QBRpcb As New OleDb.OleDbCommandBuilder(QBRpda)

        ' ME FIJO SI HABIA YA UN VALOR DE IDP, SINO HAGO UNA ROW NUEVA

        If QBRpds.Tables("TablaQBRp").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = QBRpds.Tables("TablaQBRp").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("Valor") = valorconpunto
            dsNewRow.Item("Prec") = precision
            QBRpds.Tables("TablaQBRp").Rows.Add(dsNewRow)
            QBRpda.Update(QBRpds, "TablaQBRp")
            QBRpcon.Close()
        Else
            'SI YA HABIA VALORES DE QBRp
            QBRpds.Tables("TablaQBRp").Rows(0).Item("IdMuestra") = idmuestra
            QBRpds.Tables("TablaQBRp").Rows(0).Item("IdProyecto") = idproyecto
            QBRpds.Tables("TablaQBRp").Rows(0).Item("Valor") = valorconpunto
            QBRpds.Tables("TablaQBRp").Rows(0).Item("Prec") = precision
            QBRpda.Update(QBRpds, "TablaQBRp")
            QBRpcon.Close()
        End If
    End Sub
    Public Function DefineTaxonesQBRP(dummy As String)
        Dim taxonestipo As String = "hábitat"
        Return (taxonestipo)
    End Function


    'TRADUCCION DEL INDICE A PALABRAS, A PARTIR DE UN VALOR
    'DEVUELVE TRES VALORES:
    'claseagua= clase de agua (si hay)
    'colorvalor= color del indice
    'sign= en palabras, lo q significa el valor

    Public Function TraduceQBRP(valorindice As String)
        Dim claseagua As String = ""
        Dim colorvalor As String = ""
        Dim sign As String = ""
        Dim valorindice1 As Double = CDbl(valorindice)

        If valorindice1 >= 90 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Bosque de ribera sin alteraciones, calidad muy buena, estado natural"
        ElseIf valorindice1 >= 70 And valorindice < 90 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Bosque ligeramente perturbado, calidad buena"
        ElseIf valorindice1 >= 50 And valorindice < 70 Then
            claseagua = "2"
            colorvalor = "Verde"
            sign = "Inicio de alteración importante, calidad intermedia"
        ElseIf valorindice1 >= 25 And valorindice < 50 Then
            claseagua = "3"
            colorvalor = "Amarillo"
            sign = "Alteración fuerte, mala calidad"
        ElseIf valorindice1 <= 25 Then
            claseagua = "5"
            colorvalor = "Rojo"
            sign = "Degradación extrema, calidad pésima"
        End If
        Dim retorno As String = claseagua & ";" & colorvalor & ";" & sign
        Return (retorno)
    End Function


End Module
