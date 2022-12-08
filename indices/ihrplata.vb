Public Module ihrplata
    Dim idmuestra As String
    Dim idproyecto As String
    Dim formorigen As String
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Public Function CalcularIHRPLATA(idmuestracalcular As String, idproyectocalcular As String)
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
        Dim ParametrosIHRPlata As New DataGridView
        Dim idcol As New DataGridViewTextBoxColumn
        Dim idproyectocol As New DataGridViewTextBoxColumn
        idcol.Name = "IdMuestra"
        idproyectocol.Name = "IdProyecto"
        ParametrosIHRPlata.Columns.Add(idcol)
        ParametrosIHRPlata.Columns.Add(idproyectocol)


        'agrego una row para esta muestra
        ParametrosIHRPlata.Rows.Add()
        ParametrosIHRPlata.Rows(0).Cells("IdMuestra").Value = idmuestracalcular
        ParametrosIHRPlata.Rows(0).Cells("IdProyecto").Value = idproyectocalcular

        '----------------------------------------------------------------------------------
        'PASO 2:  LEE DE LA BASE DE DATOS DEL INDICE LOS CODIGOS Y NUMEROS DE PARAMETROS DE HABITAT QUE INCLUYE EL INDICE. Crea una tabla virtual

        Dim IHRPlatacon As New OleDb.OleDbConnection
        Dim IHRPlatads As New DataSet
        Dim IHRPlataSQL As String
        IHRPlatacon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\ihrplata.mdb"
        IHRPlatacon.Open()
        IHRPlataSQL = "SELECT * FROM CaracIHRPlata"
        Dim IHRPlatada = New OleDb.OleDbDataAdapter(IHRPlataSQL, IHRPlatacon)
        IHRPlatada.Fill(IHRPlatads, "TablaIHRPlata")


        'ESTO PUEDE SER REEMPLAZADO SACANDO EL LOOP, TOTAL LOS VALORES PARA EL IHRPLATA SON DEFINIDOS. PERO ASI RECUPERA EL IDPARAMETRO POR SI CAMBIA
        For i As Integer = 0 To IHRPlatads.Tables("TablaIHRPlata").Rows.Count - 1
            Dim newcol As New DataGridViewTextBoxColumn
            newcol.Name = "p" & IHRPlatads.Tables("TablaIHRPlata").Rows(i).Item("IdParametro").ToString
            newcol.HeaderText = IHRPlatads.Tables("TablaIHRPlata").Rows(i).Item("codigo").ToString
            ParametrosIHRPlata.Columns.Add(newcol)
        Next

        '----------------------------------------------------------------------------------
        'PASO 3:  RETIENE EN LA DGV VIRTUAL SOLO LOS PARAMETROS CUYO NUMERO COINCIDE CON LOS QUE ESTAN INCLUIDOS EN EL INDICE

        For i = 2 To ParametrosIHRPlata.Columns.Count - 1
            'retiene el numero del idparametro
            Dim idparametrobuscar As String = ParametrosIHRPlata.Columns(i).Name.ToString
            'busca ese idparametro en la tabla precargada con los datos de habitat de la meustra
            For j As Integer = 0 To Habitatds.Tables("TablaHabitat").Columns.Count - 1
                If Habitatds.Tables("TablaHabitat").Columns(j).ColumnName = idparametrobuscar Then
                    'matcheo el parametro que esta en el indice con la columna en la tabla de habitat, asi que retiene el valor de esa celda y lo manda a la nueva tabla virtual
                    ParametrosIHRPlata.Item(i, 0).Value = Habitatds.Tables("TablaHabitat").Rows(0).Item(j).ToString
                    Exit For
                End If
            Next
        Next

        '----------------------------------------------------------------------------------
        'PASO 4:  YA TIENE LA DGV VIRTUAL COMPLETA, CALCULA EL INDICE


        Dim indicbarreras As Double
        Dim indicbacterias As Integer
        Dim indicbasura As Integer
        Dim indicvegetacion As Integer
        Dim precision As Integer

        For i = 2 To ParametrosIHRPlata.Columns.Count - 1
            ' traduce el indicador barreras fisicas a un valor
            If ParametrosIHRPlata.Columns(i).HeaderText = "barrerasfisicas" Then
                If ParametrosIHRPlata.Item(i, 0).Value.ToString.Contains("1-") Then
                    indicbarreras = 10
                    precision = precision + 1
                ElseIf ParametrosIHRPlata.Item(i, 0).Value.ToString.Contains("2-") Then
                    indicbarreras = 7.5
                    precision = precision + 1
                ElseIf ParametrosIHRPlata.Item(i, 0).Value.ToString.Contains("3-") Then
                    indicbarreras = 5
                    precision = precision + 1
                ElseIf ParametrosIHRPlata.Item(i, 0).Value.ToString.Contains("4-") Then
                    indicbarreras = 2.5
                    precision = precision + 1
                ElseIf ParametrosIHRPlata.Item(i, 0).Value.ToString.Contains("5-") Then
                    indicbarreras = 0
                    precision = precision + 1
                End If
                'traduce la presencia ausencia de  bacetrias
            ElseIf ParametrosIHRPlata.Columns(i).HeaderText = "bacteriasfilamentosas" Then
                If ParametrosIHRPlata.Item(i, 0).Value.ToString.Contains("Si") Then
                    indicbacterias = 0
                    precision = precision + 1
                ElseIf ParametrosIHRPlata.Item(i, 0).Value.ToString.Contains("No") Then
                    indicbacterias = 10
                    precision = precision + 1
                End If
                'traduce el indicador de vegetacion
            ElseIf ParametrosIHRPlata.Columns(i).HeaderText = "sucespacialveg" Then
                If ParametrosIHRPlata.Item(i, 0).Value.ToString <> "" Then
                    indicvegetacion = ParametrosIHRPlata.Item(i, 0).Value
                    'MsgBox(indicvegetacion)
                    precision = precision + 1
                End If
                'traduce el indicador de basura
            ElseIf ParametrosIHRPlata.Columns(i).HeaderText = "ocresiduos" Then
                If ParametrosIHRPlata.Item(i, 0).Value.ToString <> "" Then
                    indicbasura = 10 - (ParametrosIHRPlata.Item(i, 0).Value)
                    'MsgBox(indicbasura)
                    precision = precision + 1
                End If

            End If
        Next

        'calcula el promedio de los cuatro indicadores
        Dim ihrplatafinal As Double = (indicbarreras + indicbacterias + indicbasura + indicvegetacion) / 4

        '----------------------------------------------------------------------------------
        'PASO 5: GUARDAR LOS VALORES DEL INDICE EN LA DB FINAL Y DEVUELVE EL VALOR RESULTANTE
        'CIERRA EL DATASET
        IHRPlatacon.Close()
        Habitatcon.Close()

        'GRABA SI LA PRECISION ES MAYOR A UNO
        If precision >= 1 Then

            'GRABA 
            GuardarIHRPlata(ihrplatafinal, precision, idmuestra, idproyecto)
            Return ihrplatafinal
        Else
            Return Nothing
        End If
    End Function


    Private Sub GuardarIHRPlata(ByVal valorconpunto As String, precision As Integer, ByVal idmuestra As String, ByVal idproyecto As String)
        ' CONEXION A LA TABLA DE IDP
        Dim IHRPlatacon As New OleDb.OleDbConnection
        Dim IHRPlatads As New DataSet
        Dim IHRPlataSql As String
        IHRPlatacon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\ihrplata.mdb"
        IHRPlatacon.Open()
        IHRPlataSql = "SELECT * FROM IHRPlata Where IdMuestra = '" & idmuestra & "'"
        Dim IHRPlatada = New OleDb.OleDbDataAdapter(IHRPlataSql, IHRPlatacon)
        IHRPlatada.Fill(IHRPlatads, "TablaIHRPlata")
        Dim IHRPlatacb As New OleDb.OleDbCommandBuilder(IHRPlatada)

        ' ME FIJO SI HABIA YA UN VALOR DE IDP, SINO HAGO UNA ROW NUEVA

        If IHRPlatads.Tables("TablaIHRPlata").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = IHRPlatads.Tables("TablaIHRPlata").NewRow()
            dsNewRow.Item("IdMuestra") = idmuestra
            dsNewRow.Item("IdProyecto") = idproyecto
            dsNewRow.Item("Valor") = valorconpunto
            dsNewRow.Item("Prec") = precision
            IHRPlatads.Tables("TablaIHRPlata").Rows.Add(dsNewRow)
            IHRPlatada.Update(IHRPlatads, "TablaIHRPlata")
            IHRPlatacon.Close()
        Else
            'SI YA HABIA VALORES DE IHRPlata
            IHRPlatads.Tables("TablaIHRPlata").Rows(0).Item("IdMuestra") = idmuestra
            IHRPlatads.Tables("TablaIHRPlata").Rows(0).Item("IdProyecto") = idproyecto
            IHRPlatads.Tables("TablaIHRPlata").Rows(0).Item("Valor") = valorconpunto
            IHRPlatads.Tables("TablaIHRPlata").Rows(0).Item("Prec") = precision
            IHRPlatada.Update(IHRPlatads, "TablaIHRPlata")
            IHRPlatacon.Close()
        End If
    End Sub

    'NECESITO HACER UNA FUNCION PARA QUE SEPA DIFERENCIAR SI LOS TAXONES RELACIONADOS CON ESTE INDICE SON DIATOMEAS, MACROINV U OTROS
    'POR SI SE REQUIERE... SE USA DESDE FRMDBINDICES

    Public Function DefineTaxonesIHRPLATA(dummy As String)
        Dim taxonestipo As String = ""
        Return (taxonestipo)
    End Function

    'TRADUCCION DEL INDICE A PALABRAS, A PARTIR DE UN VALOR
    'DEVUELVE TRES VALORES:
    'claseagua= clase de agua (si hay)
    'colorvalor= color del indice
    'sign= en palabras, lo q significa el valor

    Public Function TraduceIHRPLATA(valorindice As String)
        Dim claseagua As String = ""
        Dim colorvalor As String = ""
        Dim sign As String = ""
        Dim valorindice1 As Double = CDbl(valorindice)

        If valorindice1 > 8 Then
            claseagua = "1"
            colorvalor = "Azul"
            sign = "Muy buena calidad del hábitat"
        ElseIf valorindice1 > 6 And valorindice <= 8 Then
            claseagua = "1"
            colorvalor = "Verde"
            sign = "Buena calidad del hábitat"
        ElseIf valorindice1 > 4 And valorindice <= 6 Then
            claseagua = "2"
            colorvalor = "Amarillo"
            sign = "Calidad del hábitat intermedia"
        ElseIf valorindice1 > 2 And valorindice <= 4 Then
            claseagua = "3"
            colorvalor = "Naranja"
            sign = "Mala calidad del hábitat"
        ElseIf valorindice1 < 2 Then
            claseagua = "4"
            colorvalor = "Roja"
            sign = "Muy mala calidad del hábitat"
        End If

        Dim retorno As String = claseagua & ";" & colorvalor & ";" & sign
        Return (retorno)

    End Function


End Module
