Imports System.Reflection
Module Actions

    Dim pathapp As String = My.Application.Info.DirectoryPath

    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////
    ' //////////////////////    MANEJO DE DATOSSIMPLES
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v


    ' //////////////////////////////////////////////////////////////////////////////v
    ' ESTE SUB GENERA TEXTBOXES SOLO PARA LOS PARAMETROS QUE ESTAN DISPONIBLES EN ESE TIPO DE PROYECTO...
    ' //////////////////////////////////////////////////////////////////////////////v

    Public Sub GenerarTextos(tipoproyecto As String, databasename As String, tablaparametros As String, formentrada As Form, outputdatosC1DataGridView As C1.Win.C1TrueDBGrid.C1TrueDBGrid)

        ' CONECTA A LA TABLA DE PARAMETROS
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim sql As String
        con.Close()
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & databasename & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablaparametros
        Dim da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Tabla")


        ' GENERAR TITULOS POR CATEGORIA

        Dim cantidadcontainers As Integer = 0

        'AGREGA UN TEXTO PARA LA PRIMERA CATEGORIA Y SIGUE
        'AGREGANDO UN TEXTO PARA LAS SIGUIENTES CATEGORIAS
        Dim controlexiste As Boolean = False
        Dim categoriaactual As String = ds.Tables("Tabla").Rows(0).Item("Categoria").ToString
        Dim locy As Integer = 100
        Dim locx As Integer = 5

        For categoriarow As Integer = 0 To ds.Tables("Tabla").Rows.Count - 1
            If locy >= 450 Then
                locx = locx + 410
                locy = 100
            End If
            If ds.Tables("Tabla").Rows(categoriarow).Item("Categoria").ToString <> categoriaactual Then
                controlexiste = False
                For Each elem As Control In formentrada.Controls
                    If elem.Name = "titulo" & ds.Tables("Tabla").Rows(categoriarow).Item("Categoria").ToString Then
                        controlexiste = True
                        Exit For
                    End If
                Next
                'genera un titulo para esa  categoria si no existe
                If controlexiste = False Then
                    Dim containercategoriarow As New Label
                    With containercategoriarow
                        .Size = New Drawing.Size(100, 28)
                        .Location = New Point(locx, locy + 20)
                        Dim myfont As New Font("Sans Serif", 12, FontStyle.Bold)
                        .Font = myfont
                        .ForeColor = System.Drawing.Color.FromArgb(4, 52, 79)
                        .Text = ds.Tables("Tabla").Rows(categoriarow).Item("Categoria").ToString
                        .Name = "titulo" & ds.Tables("Tabla").Rows(categoriarow).Item("Categoria").ToString
                    End With
                    formentrada.Controls.Add(containercategoriarow)
                    locy = locy + 60
                    cantidadcontainers = cantidadcontainers + 1
                    categoriaactual = ds.Tables("Tabla").Rows(categoriarow).Item("Categoria").ToString

                    ' Y EMPIEZA A CARGAR LOS CAMPOS PARA ESA CATEGORIAACTUAL
                    Dim numerocampo As Integer = 1
                    For i As Integer = 0 To ds.Tables("Tabla").Rows.Count - 1
                        'SE FIJA SI CORRESPONDE A ESTE TIPO DE PROYECTO
                        Dim tipoproyectocol As String() = Split(ds.Tables("Tabla").Rows(i).Item("TipoAmbiente").ToString, ";")
                        If tipoproyectocol.Contains(tipoproyecto) Then
                            '    'SE FIJA SI CORRESPONDE A ESTA CATEGORIA DE TITULO
                            If ds.Tables("Tabla").Rows(i).Item("Categoria").ToString = categoriaactual Then
                                'MsgBox(ds.Tables("Tabla").Rows(i).Item("NombreParametro").ToString & " es un parametro de " & categoriaactual)
                                'SE FIJA QUE EL CAMPO ESTE CONFIGURADO COMO VISIBLE Y AGREGA UN TEXTBOX
                                If ds.Tables("Tabla").Rows(i).Item("Visible") = True Then
                                    'SE FIJA QUE TIPO DE CAMPO ES. Si es <> Texto, hace un combobox, usando los valores del array para la coleccion, con su label
                                    If ds.Tables("Tabla").Rows(i).Item("TipoCampo").ToString <> "Texto" Then
                                        Dim MyCombobox As New C1.Win.C1Input.C1ComboBox
                                        Dim MyComboboxLabel As New LinkLabel
                                        Dim MyComboboxUnits As New Label
                                        Dim valoresarray As String() = Split(ds.Tables("Tabla").Rows(i).Item("TipoCampo").ToString, ";")
                                        For Each item In valoresarray
                                            MyCombobox.Items.Add(item)
                                        Next
                                        With MyCombobox
                                            .Name = "p" & ds.Tables("Tabla").Rows(i).Item("Id").ToString
                                            .AutoSize = False
                                            .Size = New Drawing.Size(100, 28)
                                            .BorderStyle = BorderStyle.None
                                            .BackColor = Color.LightGray
                                            .Location = New Point(locx + 252, locy)
                                            Dim myfont As New Font("Sans Serif", 11, FontStyle.Regular)
                                            .Font = myfont
                                            .DataSource = outputdatosC1DataGridView.DataSource
                                            .DataField = "p" & ds.Tables("Tabla").Rows(i).Item("Id").ToString
                                            '.DataField = "p" & i + 1
                                        End With
                                        With MyComboboxLabel
                                            .Name = "lblp" & ds.Tables("Tabla").Rows(i).Item("Id").ToString
                                            .Text = ds.Tables("Tabla").Rows(i).Item("NombreParametro").ToString
                                            .Links(0).LinkData = ds.Tables("Tabla").Rows(i).Item("Link").ToString
                                            AddHandler MyComboboxLabel.LinkClicked, AddressOf MyTextboxLabel_LinkClicked
                                            .LinkColor = Color.Black
                                            .LinkBehavior = LinkBehavior.HoverUnderline
                                            .VisitedLinkColor = Color.Black
                                            .TabStop = False
                                            .AutoSize = False
                                            .Size = New Drawing.Size(250, 40)
                                            .Location = New Point(locx, locy)
                                            Dim myfont As New Font("Sans Serif", 10, FontStyle.Regular)
                                            .Font = myfont
                                        End With
                                        With MyComboboxUnits
                                            .Name = "unitsp" & ds.Tables("Tabla").Rows(i).Item("Id").ToString
                                            .Text = ds.Tables("Tabla").Rows(i).Item("Unidades").ToString
                                            .AutoSize = False
                                            .Size = New Drawing.Size(50, 28)
                                            .Location = New Point(locx + 357, locy)
                                            Dim myfont As New Font("Sans Serif", 10, FontStyle.Regular)
                                            .Font = myfont
                                            .ForeColor = Color.DarkSlateGray
                                        End With
                                        ' Y agrega los controles al container que le corresponde
                                        formentrada.Controls.Add(MyCombobox)
                                        formentrada.Controls.Add(MyComboboxLabel)
                                        formentrada.Controls.Add(MyComboboxUnits)
                                        numerocampo = numerocampo + 1
                                        locy = locy + 40
                                    Else
                                        'SE FIJA QUE TIPO DE CAMPO ES. Si es Texto, hace un textbox,con su label
                                        Dim MyTextbox As New C1.Win.C1Input.C1TextBox
                                        Dim MyTextboxLabel As New LinkLabel
                                        Dim MyTextBoxunits As New Label
                                        With MyTextbox
                                            .Multiline = True
                                            .Name = "p" & ds.Tables("Tabla").Rows(i).Item("Id").ToString
                                            .Location = New Point(locx + 252, locy)
                                            .BorderStyle = BorderStyle.None
                                            .BackColor = Color.LightGray
                                            Dim myfont As New Font("Sans Serif", 11, FontStyle.Regular)
                                            .Font = myfont
                                            .Size = New Drawing.Size(100, 28)
                                            .DataSource = outputdatosC1DataGridView.DataSource
                                            '.DataField = "p" & i + 1
                                            .DataField = "p" & ds.Tables("Tabla").Rows(i).Item("Id").ToString
                                        End With
                                        With MyTextboxLabel
                                            .Name = "lblp" & ds.Tables("Tabla").Rows(i).Item("Id").ToString
                                            .Text = ds.Tables("Tabla").Rows(i).Item("NombreParametro").ToString
                                            .Links(0).LinkData = ds.Tables("Tabla").Rows(i).Item("Link").ToString
                                            .TabStop = False
                                            AddHandler MyTextboxLabel.LinkClicked, AddressOf MyTextboxLabel_LinkClicked
                                            .LinkColor = Color.Black
                                            .LinkBehavior = LinkBehavior.HoverUnderline
                                            .VisitedLinkColor = Color.Black
                                            .AutoSize = False
                                            .Size = New Drawing.Size(250, 40)
                                            .Location = New Point(locx, locy)
                                            Dim myfont As New Font("Sans Serif", 10, FontStyle.Regular)
                                            .Font = myfont
                                        End With
                                        With MyTextBoxunits
                                            .Name = "unitsp" & ds.Tables("Tabla").Rows(i).Item("Id").ToString
                                            .Text = ds.Tables("Tabla").Rows(i).Item("Unidades").ToString
                                            .AutoSize = False
                                            .Size = New Drawing.Size(50, 28)
                                            .Location = New Point(locx + 357, locy)
                                            Dim myfont As New Font("Sans Serif", 10, FontStyle.Regular)
                                            .Font = myfont
                                            .ForeColor = Color.DarkSlateGray
                                        End With

                                        ' Y agrega los controles al container que le corresponde
                                        formentrada.Controls.Add(MyTextbox)
                                        formentrada.Controls.Add(MyTextboxLabel)
                                        formentrada.Controls.Add(MyTextBoxunits)
                                        numerocampo = numerocampo + 1
                                        locy = locy + 40
                                    End If
                                End If
                            End If
                        End If
                    Next i
                End If
            End If
        Next
    End Sub

    'ESTE SUB CONTROLA EL LINK DE LAS LABELS
    Private Sub MyTextboxLabel_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim target As String = CType(e.Link.LinkData, String)

        If target <> "" Then
            System.Diagnostics.Process.Start(target)
        Else
            MsgBox("No hay un vínculo asociado a este parámetro")
        End If
    End Sub

    Public Sub PasteData(ByRef dgv As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Dim tArr() As String
        Dim arT() As String
        Dim i, ii As Integer
        Dim c, cc, r As Integer

        tArr = Clipboard.GetText().Split(Environment.NewLine)
        r = dgv.Row
        c = dgv.Col

        'AGREGA ROWS
        Dim diferencia As Integer = -1 * (dgv.RowCount - r - tArr.Count)
        For i = 0 To diferencia - 1
            dgv.Rows.Add()
        Next

        For i = 0 To tArr.Length - 2
            arT = tArr(i).Split(vbTab)
            cc = c
            For ii = 0 To arT.Length - 1
                dgv.Item(r, cc) = arT(ii).TrimStart
                cc = cc + 1
            Next
            r = r + 1
        Next

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////    DEVUELVE DATOS ECOLOGICOS DE UN TAXON EN PARTICULAR, BUSCANDO EN TODOS LOS INDICES DE SU COMUNIDAD
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'Devuelve una datagridview que deberia tener las columnas:
    ' Indice, Nombre, Valor

    Public Sub DatosTaxon(idtaxon As String, comunidad As String, datagridviewoutput As DataGridView)
        ' CONECTA A LA TABLA DE CALCULOS, PARA PREGUNTAR A CADA UNO DE LOS INDICES CON QUE TIPO DE DATOS ESTAN GENERADOS
        'Conecta
        datagridviewoutput.Rows.Clear()
        Dim conCalculos As New OleDb.OleDbConnection
        Dim dsCalculos As New DataSet
        Dim sqlCalculos As String
        Dim da = New OleDb.OleDbDataAdapter

        conCalculos.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\config.mdb"
        conCalculos.Open()
        sqlCalculos = "SELECT * FROM Calculos"
        Dim daCalculos = New OleDb.OleDbDataAdapter(sqlCalculos, conCalculos)
        daCalculos.Fill(dsCalculos, "TablaCalculos")
        conCalculos.Close()

        'Recorre cada script
        For i As Integer = 0 To dsCalculos.Tables("TablaCalculos").Rows.Count - 1
            Dim codigo As String = dsCalculos.Tables("TablaCalculos").Rows(i).Item("Codigo")
            Dim scriptname As String = dsCalculos.Tables("TablaCalculos").Rows(i).Item("Script").ToString.Remove(0, 8)
            Dim nombreindice As String = dsCalculos.Tables("TablaCalculos").Rows(i).Item("Nombre").ToString

            'llama al script para ver el tipo de comunidad
            Dim scripttranslatename As String = "Traduce" & scriptname
            scriptname = "DefineTaxones" & scriptname
            Dim mType As Type = Type.GetType("Scila7." & codigo)
            Dim mMethod As MethodInfo = mType.GetMethod(scriptname)
            Dim mValue As Object = mMethod.Invoke(mType, New Object() {"dummy"})


            If mValue = comunidad Then
                Dim indice, db, tabla As String
                indice = codigo
                db = dsCalculos.Tables("TablaCalculos").Rows(i).Item("DBPath")
                tabla = "Carac" & db.ToUpper

                ' CONEXION A LA TABLA DEL INDICE, ADONDE BUSCA EL TAXON
                Dim VALORcon As New OleDb.OleDbConnection
                Dim VALORds As New DataSet
                VALORds.Tables.Clear()
                Dim VALORSQL As String
                VALORcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\" & db & ".mdb"
                VALORcon.Open()
                Dim newcodigo As String
                If codigo.Contains("_") Then
                    Dim temparray As String() = codigo.Split("_")
                    newcodigo = temparray(0).ToUpper
                Else
                    newcodigo = codigo
                End If

                VALORSQL = "SELECT * FROM Carac" & newcodigo & " WHERE IdTaxon='" & idtaxon & "'"
                Dim VALORda = New OleDb.OleDbDataAdapter(VALORSQL, VALORcon)
                VALORda.Fill(VALORds, "TablaVALOR")

                Dim valortaxon As String = "Sin datos"
                Dim traducciontaxon As String

                If VALORds.Tables("TablaVALOR").Rows.Count > 0 Then
                    If VALORds.Tables("TablaVALOR").Columns.Contains("Valor") Then
                        valortaxon = VALORds.Tables("TablaVALOR").Rows(0).Item("Valor").ToString

                        'llama al script para traducir el nombre del taxon
                        Dim mTypeTranslate As Type = Type.GetType("Scila7." & codigo)
                        Dim mMethodTranslate As MethodInfo = mTypeTranslate.GetMethod(scripttranslatename)
                        Dim mValueTranslate As Object = mMethodTranslate.Invoke(mTypeTranslate, New Object() {valortaxon})
                        traducciontaxon = mValueTranslate

                    ElseIf VALORds.Tables("TablaVALOR").Columns.Contains("Categoria") Then
                        valortaxon = VALORds.Tables("TablaVALOR").Rows(0).Item("Categoria").ToString

                        'llama al script para traducir el nombre del taxon
                        Dim mTypeTranslate As Type = Type.GetType("Scila7." & codigo)
                        Dim mMethodTranslate As MethodInfo = mTypeTranslate.GetMethod(scripttranslatename)
                        Dim mValueTranslate As Object = mMethodTranslate.Invoke(mTypeTranslate, New Object() {valortaxon})
                        traducciontaxon = mValueTranslate
                    End If

                Else
                    valortaxon = "Sin datos"
                End If

                VALORcon.Close()
                'antes de devolver todo en una row, separa la traducción por ";"
                ' traduccion(0) = clase de agua
                ' traduccion(1) = color
                ' traduccion(2) = significado
                If valortaxon <> "Sin datos" Then
                    Dim traduccion As String() = traducciontaxon.Split(";")
                    datagridviewoutput.Rows.Add({indice, nombreindice, valortaxon, traduccion(2)})
                    If traduccion(1) = "Rojo" Then
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.BackColor = Color.Red
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.ForeColor = Color.Black
                    ElseIf traduccion(1) = "Naranja" Then
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.BackColor = Color.Orange
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.ForeColor = Color.Black
                    ElseIf traduccion(1) = "Amarillo" Then
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.BackColor = Color.Yellow
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.ForeColor = Color.Black
                    ElseIf traduccion(1) = "Verde" Then
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.BackColor = Color.Green
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.ForeColor = Color.Black
                    ElseIf traduccion(1) = "Azul" Then
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.BackColor = Color.Blue
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.ForeColor = Color.White
                    ElseIf traduccion(1) = "Negro" Then
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.BackColor = Color.Black
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.ForeColor = Color.White
                    ElseIf traduccion(1) = "Gris" Then
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.BackColor = Color.LightGray
                        datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.ForeColor = Color.Black
                    End If
                Else
                    datagridviewoutput.Rows.Add({indice, nombreindice, valortaxon, "Sin datos"})
                    datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.BackColor = Color.LightGray
                    datagridviewoutput.Item(3, datagridviewoutput.RowCount - 1).Style.ForeColor = Color.Black
                End If

            End If

        Next
    End Sub



    ' //////////////////////////////////////////////////////////////////////////////v
    ' DE ACA EN ADELANTE NO SE SI SIRVE ALGO, SON CODIGOS DE PRUEBA QUE NO QUIERO BORRAR TODAVIA
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v



    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// COPY AND PASTE desde excel en Datagridviews de ComponentOne
    '////////////////////////////////////////////////////////////////////////

    'Public Sub CopyData(datagridinput As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
    '    Dim rs As New ADODB.Recordset
    '    Dim strTemp As String  'string to be copied onto clipboard
    '    Dim Col As Integer, row As Object

    '    Clipboard.SetText("")
    '    If datagridinput.SelRange Then
    '        'You must format the string so it can be pasted directly into Excel (tab delimited)
    '        rs = TData1.Recordset.Clone
    '        For Each row In datagridinput.SelectedRows
    '            rs.Bookmark = row
    '            For Col = datagridinput.SelectedCols.Count
    '                strTemp = strTemp & rs(Col).Value & vbTab
    '            Next Col
    '            strTemp = strTemp & vbCrLf
    '        Next row

    '        Clipboard.Clear()
    '        Clipboard.SetText(strTemp, vbCFText)

    '        'yes
    '    Else
    '        'no

    '    End If

    'End Sub



    ' //////////////////////////////////////////////////////////////////////////////v
    ' CARGA TODOS LOS PARAMETROS DE UNA DATABASE DE PARAMETROS A OTRA C1TRUEDBGRID DONDE HAY DATOS DE PARAMETROS*MUESTRAS
    ' //////////////////////////////////////////////////////////////////////////////v

    'Public Sub cargarParametros(databasename As String, tablaparametros As String, outputdatosC1DataGridView As C1.Win.C1TrueDBGrid.C1TrueDBGrid, customonly As Boolean)

    '    ' CONECTA A LA TABLA DE PARAMETROS
    '    Dim con As New OleDb.OleDbConnection
    '    Dim ds As New DataSet
    '    Dim sql As String
    '    con.Close()
    '    con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & databasename & ".mdb"
    '    con.Open()
    '    sql = "SELECT * FROM " & tablaparametros
    '    Dim da = New OleDb.OleDbDataAdapter(sql, con)
    '    da.Fill(ds, "Tabla")

    '    ' RECORRE LA DATAGRID CON LOS PARAMETROS Y MARCA EN LA DATAGRID CON LOS DATOS DE LA MUESTRA
    '    ' AQUELLOS CAMPOS QUE SE CORRESPONDEN, DE ROJO
    '    ' TAMBIEN SE FIJA Q TIPO DE CAMPOS SON Y COMBIERTE A COMBOBOX O TEXTO


    '    For i As Integer = 0 To ds.Tables("Tabla").Rows.Count - 1
    '        For j As Integer = 0 To outputdatosC1DataGridView.Columns.Count - 1
    '            'If "p" & outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(j).Name.ToString = ds.Tables("Tabla").Rows(i).Item(0).ToString Then
    '            If outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(j).Name.ToString = "p" & ds.Tables("Tabla").Rows(i).Item(0).ToString Then
    '                'SE FIJA QUE EL CAMPO ESTE CONFIGURADO COMO VISIBLE, SI LO ESTA LO PINTA DE ROJO
    '                ' SI NO ESTA VISIBLE, LO PINTA DE AZUL
    '                If customonly = False Then
    '                    If ds.Tables("Tabla").Rows(i).Item("Visible") = True Then
    '                        outputdatosC1DataGridView.Columns.Item(j).Caption = ds.Tables("Tabla").Rows(i).Item("NombreParametro").ToString & " (" & ds.Tables("Tabla").Rows(i).Item("Unidades").ToString & ")"
    '                        outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(j).HeadingStyle.ForeColor = Color.Red

    '                        'SE FIJA QUE TIPO DE CAMPO ES. Si es <> Texto, hace un combobox, usando los valores del array para la coleccion
    '                        If ds.Tables("Tabla").Rows(i).Item("TipoCampo").ToString <> "Texto" Then
    '                            outputdatosC1DataGridView.Columns.Item(j).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
    '                            Dim valoresarray As String() = Split(ds.Tables("Tabla").Rows(i).Item("TipoCampo").ToString, ";")
    '                            For Each item In valoresarray
    '                                Dim v As C1.Win.C1TrueDBGrid.ValueItem = New C1.Win.C1TrueDBGrid.ValueItem
    '                                v.Value = item
    '                                outputdatosC1DataGridView.Columns.Item(j).ValueItems.Values.Add(v)
    '                            Next
    '                        Else
    '                            outputdatosC1DataGridView.Columns.Item(j).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.Normal
    '                        End If

    '                    ElseIf ds.Tables("Tabla").Rows(i).Item("Visible") = False Then
    '                        outputdatosC1DataGridView.Columns.Item(j).Caption = ds.Tables("Tabla").Rows(i).Item("NombreParametro").ToString & " (" & ds.Tables("Tabla").Rows(i).Item("Unidades").ToString & ")"
    '                        outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(j).HeadingStyle.ForeColor = Color.Blue
    '                    End If
    '                ElseIf customonly = True Then
    '                    If ds.Tables("Tabla").Rows(i).Item("Custom") = True Then
    '                        If ds.Tables("Tabla").Rows(i).Item("Visible") = True Then

    '                            outputdatosC1DataGridView.Columns.Item(j).Caption = ds.Tables("Tabla").Rows(i).Item("NombreParametro").ToString & " (" & ds.Tables("Tabla").Rows(i).Item("Unidades").ToString & ")"
    '                            outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(j).HeadingStyle.ForeColor = Color.Red

    '                            'SE FIJA QUE TIPO DE CAMPO ES. Si es <> Texto, hace un combobox, usando los valores del array para la coleccion
    '                            If ds.Tables("Tabla").Rows(i).Item("TipoCampo").ToString <> "Texto" Then
    '                                outputdatosC1DataGridView.Columns.Item(j).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
    '                                Dim valoresarray As String() = Split(ds.Tables("Tabla").Rows(i).Item("TipoCampo").ToString, ";")
    '                                For Each item In valoresarray
    '                                    Dim v As C1.Win.C1TrueDBGrid.ValueItem = New C1.Win.C1TrueDBGrid.ValueItem
    '                                    v.Value = item
    '                                    outputdatosC1DataGridView.Columns.Item(j).ValueItems.Values.Add(v)
    '                                Next
    '                            Else
    '                                outputdatosC1DataGridView.Columns.Item(j).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.Normal
    '                            End If

    '                        ElseIf ds.Tables("Tabla").Rows(i).Item("Visible") = False Then
    '                            outputdatosC1DataGridView.Columns.Item(j).Caption = ds.Tables("Tabla").Rows(i).Item("NombreParametro").ToString & " (" & ds.Tables("Tabla").Rows(i).Item("Unidades").ToString & ")"
    '                            outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(j).HeadingStyle.ForeColor = Color.Blue
    '                        End If
    '                    End If
    '                End If

    '                Exit For
    '            End If
    '        Next j
    '    Next

    '    ' RECORRE TODO EL GRID Y ESCONDE LO QUE NO SIRVE (COLOR ROJO Y AZUL)
    '    For i As Integer = 0 To outputdatosC1DataGridView.Columns.Count - 1
    '        If outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(i).HeadingStyle.ForeColor = Color.Red Then
    '            outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(i).HeadingStyle.ForeColor = Color.Black
    '        ElseIf outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(i).HeadingStyle.ForeColor = Color.Blue Then
    '            outputdatosC1DataGridView.Splits(0).DisplayColumns.Item(i).HeadingStyle.ForeColor = Color.Blue
    '            outputdatosC1DataGridView.Splits(0).DisplayColumns(i).Visible = False
    '        Else
    '            outputdatosC1DataGridView.Splits(0).DisplayColumns(i).Visible = False
    '        End If
    '    Next
    'End Sub


    ' //////////////////////////////////////////////////////////////////////////////v
    ' LE DA ESTILO A LA C1DATAVIEWGRID DESPUES DE QUE CARGO LOS DATOS
    ' //////////////////////////////////////////////////////////////////////////////v


    'Public Sub StyleC1Datagridview(inputC1dataviewgrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid)

    '    ' DE ACA EN ADELANTE, SE FIJA CUANTAS ROWS ACTIVAS HAY, Y HACE SPLITS DE ACUERDO A ESO
    '    Dim gridtotalheight As Integer = inputC1dataviewgrid.Height
    '    Dim gridnumberofrows As Integer

    '    ' saca el numero de rows visibles (gridnumberofrows)
    '    For i = 0 To inputC1dataviewgrid.Columns.Count - 1
    '        If inputC1dataviewgrid.Splits(0).DisplayColumns.Item(i).Visible = True Then
    '            gridnumberofrows += 1
    '        End If
    '    Next

    '    'MsgBox("number of rows visibles: " & gridnumberofrows)

    '    ' calcula el numero de splits necesarios (numerosplits) y los agrega dependiendo de cuantas rows haya
    '    Dim numerosplits As Integer = (gridnumberofrows * 22) \ gridtotalheight

    '    ' si la datagrid no tiene rows, sale del parametro
    '    If gridnumberofrows = 0 Then
    '        Exit Sub
    '    End If

    '    If gridtotalheight Mod (gridnumberofrows * 22) = 0 Then
    '        numerosplits += 1
    '    End If

    '    'MsgBox("number of splits necesarios: " & numerosplits)

    '    If numerosplits > 0 Then
    '        For i = 0 To numerosplits - 1
    '            'agrega un split
    '            inputC1dataviewgrid.InsertHorizontalSplit(0)
    '        Next
    '    End If

    '    ' esconde las rows en las primeras splits si hay mas de una
    '    If inputC1dataviewgrid.Splits.Count > 1 Then
    '        Dim rowsmaximototal As Integer = inputC1dataviewgrid.Columns.Count - 1

    '        ' PARA SPLIT 0
    '        Dim rowsporsplit As Integer = (gridtotalheight \ 22) - 1
    '        ' MsgBox("number of rows per split: " & rowsporsplit)

    '        For k As Integer = rowsporsplit + 3 To rowsmaximototal - 1
    '            inputC1dataviewgrid.Splits(0).DisplayColumns.Item(k).Visible = False
    '            inputC1dataviewgrid.Splits(0).HScrollBar.Visible = False
    '            inputC1dataviewgrid.Splits(0).VScrollBar.Visible = False
    '        Next

    '        ' PARA LAS DEMAS SPLITS
    '        Dim rowinicial As Integer = 0
    '        Dim rowfinal As Integer = rowsporsplit + 2
    '        For j As Integer = 1 To inputC1dataviewgrid.Splits.Count - 1

    '            For k As Integer = rowinicial To rowfinal
    '                inputC1dataviewgrid.Splits(j).DisplayColumns.Item(k).Visible = False
    '            Next
    '            rowinicial = rowsporsplit * (j + 1) + 3

    '            For k As Integer = rowinicial To rowsmaximototal - 1
    '                inputC1dataviewgrid.Splits(j).DisplayColumns.Item(k).Visible = False
    '            Next
    '            rowinicial = 0
    '            rowfinal = rowsporsplit * (j + 1) + 2
    '            inputC1dataviewgrid.Splits(j).HScrollBar.Visible = False
    '            inputC1dataviewgrid.Splits(j).VScrollBar.Visible = False
    '        Next
    '    End If


    '    'CUANDO YA GENERO TODOS LOS SPLITS Y TODO, LE AGREGA EL ESTILO 

    '    Dim S As New C1.Win.C1TrueDBGrid.Style()
    '    Dim myfont As Font
    '    myfont = New Font("Open Sans", 10)
    '    S.Font = myfont
    '    S.BackColor = Color.LightGray

    '    inputC1dataviewgrid.AddCellStyle(C1.Win.C1TrueDBGrid.CellStyleFlag.AllCells, S)
    '    For j As Integer = 0 To inputC1dataviewgrid.Splits.Count - 1
    '        For i As Integer = 0 To inputC1dataviewgrid.Columns.Count - 1
    '            inputC1dataviewgrid.Splits(j).DisplayColumns(i).Height = 20
    '            inputC1dataviewgrid.CaptionStyle.BackColor = Color.Red
    '            inputC1dataviewgrid.CaptionStyle.Borders.BorderType = C1.Win.C1TrueDBGrid.BorderTypeEnum.Flat
    '            inputC1dataviewgrid.RecordSelectors = False
    '            inputC1dataviewgrid.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
    '            inputC1dataviewgrid.HeadingStyle.BackColor = Color.White
    '            inputC1dataviewgrid.HeadingStyle.Borders.BorderType = C1.Win.C1TrueDBGrid.BorderTypeEnum.None
    '            inputC1dataviewgrid.Style.Borders.BorderType = C1.Win.C1TrueDBGrid.BorderTypeEnum.None
    '            inputC1dataviewgrid.BorderStyle = BorderStyle.None
    '            inputC1dataviewgrid.Splits(j).DisplayColumns(i).AllowSizing = False
    '            inputC1dataviewgrid.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
    '            inputC1dataviewgrid.Splits(j).DisplayColumns(i).Width = 200
    '        Next i
    '    Next j

    'End Sub




    ' //////////////////////////////////////////////////////////////////////////////v
    ' SACA EL HEADER DE LA BASE DE DATOS
    ' //////////////////////////////////////////////////////////////////////////////v

    'Public Sub LoadHeaderFromDB(ByVal DBNombre As String, ByVal TablaenDB As String, CampoCodigoenTabla As String, CampoNombreenTabla As String, outputDataGridView As DataGridView)
    '    'TRADUCE LOS NOMBRES DE LAS COLUMNAS POR EL NOMBRE DEL TAXON
    '    ' CONEXION A LA TABLA DE TAXONES 
    '    Dim con As New OleDb.OleDbConnection
    '    Dim ds As New DataSet
    '    Dim sql As String
    '    con.Close()
    '    con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & DBNombre & ".mdb"
    '    con.Open()
    '    sql = "SELECT * FROM " & TablaenDB
    '    Dim da = New OleDb.OleDbDataAdapter(sql, con)
    '    da.Fill(ds, "Tabla")

    '    For i = 0 To ds.Tables("Tabla").Rows.Count - 1
    '        outputDataGridView.Columns.Add(ds.Tables("Tabla").Rows(i).Item(CampoCodigoenTabla).ToString, ds.Tables("Tabla").Rows(i).Item(CampoNombreenTabla).ToString)
    '    Next

    'End Sub




    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////
    ' //////////////////////    MANEJO DE ARCHIVOS
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    ' //////////////////////////////////////////////////////////////////////////////v
    '

    'Public Sub ClearFile(filename As String)
    '    Dim objWriter As New System.IO.StreamWriter(filename)
    '    objWriter.WriteLine("")
    '    objWriter.Close()
    'End Sub

    'Public Sub CreateHeaderInFile(datagridview As DataGridView, filename As String)
    '    Dim objWriter As New System.IO.StreamWriter(filename, True)
    '    Dim nombrepar As String
    '    Dim header As String

    '    header = "IdMuestra,"

    '    For i As Integer = 0 To datagridview.Columns.Count - 1
    '        If datagridview.Columns(i).Visible = True Then
    '            nombrepar = datagridview.Columns(i).Name.ToString

    '            'DEBERIA BUSCAR EL ID DEL PARAMETRO EN LA BASE DE DATOS DE PARAMETROS
    '            ' PERO POR AHORA LO LEE DIRECTO
    '            header = header & nombrepar & ","
    '        End If

    '    Next
    '    objWriter.WriteLine(header)
    '    objWriter.Close()
    'End Sub
    'Public Sub SaveGridtoFile(ByVal datagridview As DataGridView, ByVal filename As String)
    '    Dim sr As New System.IO.StreamWriter(filename, True)
    '    Dim strDelimiter As String = ","
    '    Dim intColumnCount As Integer = datagridview.Columns.Count - 1
    '    Dim strRowData As String = ""

    '    For intX As Integer = 0 To datagridview.Rows.Count - 2
    '        strRowData = ""
    '        For intRowData As Integer = 0 To intColumnCount
    '            strRowData += Replace(datagridview.Rows(intX).Cells(intRowData).Value, strDelimiter, "") & _
    '                IIf(intRowData < intColumnCount, strDelimiter, "")
    '        Next intRowData

    '        sr.WriteLine(strRowData)
    '    Next intX
    '    sr.Close()
    'End Sub

    'Public Sub LoadGridfromFile(ByVal datagridview As DataGridView, ByVal filename As String)

    '    datagridview.Rows.Clear()
    '    datagridview.Columns.Clear()

    '    Dim fullfile As String = My.Computer.FileSystem.ReadAllText(filename)
    '    Dim lines() As String = IO.File.ReadAllLines(filename)


    '    'READ HEADER FROM FILE AND CREATE COLUMNS ACCODINGLY
    '    Dim HeaderLine As String = lines(1)
    '    Dim colnames() As String = HeaderLine.Split(",")
    '    Dim colname As String

    '    For Each i In colnames
    '        colname = i.ToString
    '        If colname <> "" Then
    '            datagridview.Columns.Add(colname, colname)
    '        End If
    '    Next

    '    'LEE LOS DATOS DE CADA LINEA
    '    Dim line As String
    '    For j As Integer = 2 To lines.Length - 1
    '        line = lines(j).ToString
    '        datagridview.Rows.Add(Split(line, ","))
    '    Next
    'End Sub

End Module
