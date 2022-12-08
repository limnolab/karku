Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text
Imports System.IO

Public Class frmExport
    Dim tipoproyecto As String
    Dim idproyecto As Integer
    Dim nombreproyecto As String
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim cantidadrepeticiones As Integer

    Public Sub RecibirVariables(ByVal idproyectoexportar As Integer, ByVal tipoproyectoexportar As String, ByVal nombreproyectoexportar As String)
        'RECIBO TIPO Y NUMERO DE PROYECTO DE FRMMAIN
        idproyecto = idproyectoexportar
        tipoproyecto = tipoproyectoexportar
        nombreproyecto = nombreproyectoexportar
    End Sub

    Private Sub frmExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)

        If tabGrids.TabPages.Count > 0 Then
            For Each deltab As TabPage In tabGrids.TabPages
                tabGrids.TabPages.Remove(deltab)
            Next
        End If
        GenerarCheckboxes()
    End Sub

    Private Sub GenerarCheckboxes()
        '-------------------------------------------------

        'CARGA LAS DB DE MODULOS 
        Dim moduloscon As New OleDb.OleDbConnection
        Dim modulosSQL As String
        moduloscon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\config.mdb"
        moduloscon.Open()

        Dim modulosds As New DataSet
        modulosSQL = "SELECT * FROM Modulos"
        Dim modulosda = New OleDb.OleDbDataAdapter(modulosSQL, moduloscon)
        modulosda.Fill(modulosds, "Tablamodulos")

        ' RECORRO LOS MODULOS DE LA CONFIGURACION. PARA LOS QUE ESTAN HABILITADOS, AGREGO UN CHECKBOX
        Dim modulocodigo As String
        For i = 0 To modulosds.Tables("Tablamodulos").Rows.Count - 1
            modulocodigo = modulosds.Tables("Tablamodulos").Rows(i).Item("codigo").ToString
            If modulosds.Tables("Tablamodulos").Rows(i).Item("habilitado") = True Then
                chkItemsCodigos.Items.Add(modulosds.Tables("Tablamodulos").Rows(i).Item("codigo").ToString, False)
                chkItemsNombres.Items.Add(modulosds.Tables("Tablamodulos").Rows(i).Item("nombre").ToString, True)
            End If
        Next
        moduloscon.Close()

        '------------------------------------------------
        'CARGA LAS DB DE CALCULOS 
        Dim calculocon As New OleDb.OleDbConnection
        Dim calculoSQL As String
        calculocon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\config.mdb"
        calculocon.Open()

        Dim calculods As New DataSet
        calculoSQL = "SELECT * FROM Calculos"
        Dim calculosda = New OleDb.OleDbDataAdapter(calculoSQL, calculocon)
        calculosda.Fill(calculods, "Tablacalculos")

        ' RECORRO LOS MODULOS DE LA CONFIGURACION. PARA LOS QUE ESTAN HABILITADOS, AGREGO UN CHECKBOX
        Dim calculocodigo As String
        For i = 0 To calculods.Tables("Tablacalculos").Rows.Count - 1
            calculocodigo = calculods.Tables("Tablacalculos").Rows(i).Item("codigo").ToString
            Dim tipoproyectocalcular As String = tipoproyecto
            If calculods.Tables("Tablacalculos").Rows(i).Item("Activado") = True Then
                chkItemsCodigos.Items.Add(calculods.Tables("Tablacalculos").Rows(i).Item("codigo").ToString, False)
                chkItemsNombres.Items.Add(calculods.Tables("Tablacalculos").Rows(i).Item("nombre").ToString, True)
            End If
        Next
        calculocon.Close()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If chkItemsNombres.CheckedItems.Count = 0 Then
            MsgBox("No ha seleccionado datos para exportar")
            Exit Sub
        End If

        If tabGrids.TabPages.Count > 0 Then
            For Each deltab As TabPage In tabGrids.TabPages
                tabGrids.TabPages.Remove(deltab)
            Next
        End If

        GenerarExportGrids()

        For Each tabgrid As TabPage In tabGrids.TabPages
            Dim nombremodulo As String = tabgrid.Name
            Dim dgvoutput = CType(tabgrid.Controls.Find("dgv" & nombremodulo, True)(0), DataGridView)
            CargarModulo(nombremodulo, dgvoutput)
        Next
        btnExportarCSV.Visible = True
        btnExporttoExcel.Visible = True
        btnExportarSHP.Visible = True

    End Sub

    Private Sub GenerarExportGrids()
        'primero traduce los checks en chkitemsnombres a chkitemscodigos
        For i As Integer = 0 To chkItemsNombres.CheckedItems.Count - 1
            Dim indexitem As Integer = chkItemsNombres.Items.IndexOf(chkItemsNombres.CheckedItems(i))
            chkItemsCodigos.SetItemChecked(indexitem, True)
        Next

        'genera tabs y grids, siempre separadas
        For i = 0 To chkItemsNombres.CheckedItems.Count - 1
            Dim codigomodulo As String
            Dim nombremodulo As String
            codigomodulo = chkItemsCodigos.CheckedItems.Item(i).ToString
            nombremodulo = chkItemsNombres.CheckedItems.Item(i).ToString
            'Genera tabs separadas

            Dim newtab As New TabPage
            Dim newdgv As New DataGridView
            newtab.Name = codigomodulo
            newtab.Text = nombremodulo
            newdgv.Name = "dgv" & codigomodulo
            newdgv.Dock = DockStyle.Fill
            newdgv.AllowUserToAddRows = False
            newdgv.AllowUserToDeleteRows = False
            newtab.Controls.Add(newdgv)
            tabGrids.TabPages.Add(newtab)
            CargarMuestras(newdgv)
        Next
    End Sub

    Private Sub CargarModulo(nombremodulo As String, datagridviewoutput As DataGridView)
        'PASOS
        ' 1) Carga los datos basicos del modulo (codigo, tipo de tabla, etc)
        ' 2) Abre la DB propia desl modulo, usando los datos basicos
        ' 3) De la DB propia del modulo carga los datos para cada muestra del proyecto, en la dgv final
        ' 4) Traduce los titulos de las columnas

        '---------------------------------------------------------------------
        '1) Carga los datos basicos del modulo (codigo, tipo de tabla, etc)
        'PRIMERO LA DB DE MODULOS... SI NO ENCUENTRA NADA, VA A LA DB DE CALCULOS 
        Dim modulocon As New OleDb.OleDbConnection
        Dim moduloSQL As String
        modulocon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\config.mdb"
        modulocon.Open()

        Dim modulods As New DataSet
        moduloSQL = "SELECT * FROM Modulos WHERE codigo='" & nombremodulo & "'"
        Dim modulosda = New OleDb.OleDbDataAdapter(moduloSQL, modulocon)
        modulosda.Fill(modulods, "Tablamodulos")

        Dim codigomodulo As String
        Dim tipomodulo As String
        Dim categoriacalculo As String
        Dim dbpath As String


        'si no encuentra el modulo en "modulos" va a "calculos"
        If modulods.Tables("Tablamodulos").Rows.Count = 0 Then
            moduloSQL = "SELECT * FROM Calculos WHERE codigo='" & nombremodulo & "'"
            modulosda = New OleDb.OleDbDataAdapter(moduloSQL, modulocon)
            modulosda.Fill(modulods, "Tablamodulos")
            'Y vuelve a chequear que este en "calculos". Si esta retiene sus datos, sino sale del sub y manda error
            If modulods.Tables("Tablamodulos").Rows.Count = 0 Then
                MsgBox("Modulo " & nombremodulo & " no encontrado")
                Exit Sub
            Else
                'Encuentra el nombremodulo en la tabla "calculos" de "config.mdb"
                dbpath = modulods.Tables("Tablamodulos").Rows(0).Item("DBpath").ToString
                codigomodulo = modulods.Tables("Tablamodulos").Rows(0).Item("DBpath").ToString
                tipomodulo = "calculo"
                categoriacalculo = modulods.Tables("Tablamodulos").Rows(0).Item("Categoria").ToString
            End If
        Else
            ' 'Encuentra el nombremodulo en la tabla "modulos" de "config.mdb"
            tipomodulo = modulods.Tables("Tablamodulos").Rows(0).Item("tipo").ToString
            codigomodulo = modulods.Tables("Tablamodulos").Rows(0).Item("codigo").ToString
            dbpath = modulods.Tables("Tablamodulos").Rows(0).Item("codigo").ToString
        End If

        '----------------------------------------------------------------------
        ' 2) Abre la DB propia del modulo, usando los datos basicos, y carga los datos para cada muestra en la grid

        Dim tablaname As String

        'Si es un indice (calculo) carga el sub CargarIndice. Si no, carga modulo
        If tipomodulo.Contains("DatosSimples") Then
            tablaname = "Parametros" & codigomodulo
            CargarDatosSimples(datagridviewoutput, nombremodulo, dbpath, tablaname, codigomodulo)
        ElseIf tipomodulo = "calculo" Then
            CargarIndice(datagridviewoutput, codigomodulo, nombremodulo, dbpath, codigomodulo, categoriacalculo)
        ElseIf tipomodulo.Contains("DatosTaxones") Then
            Dim tipomoduloarray As String() = tipomodulo.Split(";")
            Dim dbname As String = tipomoduloarray(1)
            Dim dbtabla As String = tipomoduloarray(2)

            CargarTaxones(datagridviewoutput, dbtabla, dbname)

            'ElseIf tipomodulo = "frmMacroinvertebrados" Then
            '    CargarTaxones(datagridviewoutput, "macroinvs", "macroinvertebrados")
            'ElseIf tipomodulo = "frmDiatomeas" Then
            '    CargarTaxones(datagridviewoutput, "diats", "diatomeas")
        End If


    End Sub

    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////
    '////////       PROCEDIMIENTOS DE CARGA DE LAS DIFERENTES DATAVIEWGRIDS
    '////////
    '////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////


    Private Sub CargarMuestras(ByVal datagridview As DataGridView)
        ' CONEXION A LA TABLA DE MUESTRAS
        Dim Muestrascon As New OleDb.OleDbConnection
        Dim Muestrasds As New DataSet
        Dim MuestrasSQL As String

        Muestrascon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\Scilla10.mdb"
        Muestrascon.Open()
        MuestrasSQL = "SELECT * FROM Muestras WHERE IdProyecto = " & idproyecto
        Dim Muestrasda = New OleDb.OleDbDataAdapter(MuestrasSQL, Muestrascon)
        Muestrasda.Fill(Muestrasds, "TablaMuestras")

        ' AGREGO A TODAS LAS DATAGRIDVIEWS LAS COLUMNAS A UTILIZAR
        datagridview.Columns.Add("ColumnIdMuestra", "IdMuestra")
        datagridview.Columns.Add("ColumnSitioNombre", "Sitio")
        datagridview.Columns.Add("ColumnCodigoSitio", "CodigoSitio")


        ' RECORRE LA TABLA Y AGREGA CADA VALOR A TODAS LAS DATAGRIDVIEWS
        Dim i As Integer
        For i = 0 To Muestrasds.Tables("TablaMuestras").Rows.Count - 1
            datagridview.Rows.Add()
            datagridview.Item("ColumnIdMuestra", i).Value = Muestrasds.Tables("TablaMuestras").Rows(i).Item("IdMuestra").ToString
            datagridview.Item("ColumnSitioNombre", i).Value = Muestrasds.Tables("TablaMuestras").Rows(i).Item("Nombre").ToString
            datagridview.Item("ColumnCodigoSitio", i).Value = Muestrasds.Tables("TablaMuestras").Rows(i).Item("CodigoSitio").ToString
        Next
        Muestrascon.Close()

    End Sub

    Private Sub CargarSitios(ByVal datagridview As DataGridView)
        ' CONEXION A LA TABLA DE SITIOS
        Dim Sitioscon As New OleDb.OleDbConnection
        Dim Sitiosds As New DataSet
        Dim SitiosSQL As String

        Sitioscon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\sitios.mdb"
        Sitioscon.Open()
        SitiosSQL = "SELECT * FROM Sitios"
        Dim Sitiosda = New OleDb.OleDbDataAdapter(SitiosSQL, Sitioscon)
        Sitiosda.Fill(Sitiosds, "TablaSitios")

        datagridview.Columns.Add("ColumnSitioLAT", "LAT")
        datagridview.Columns.Add("ColumnSitioLONG", "LONG")

        ' PARA CADA MUESTRA SACA EL NOMBRE DEL SITIO, BUSCA SU LAT Y LONG Y LAS AGREGA

        Dim codigositio As String
        Dim i, j As Integer
        For i = 0 To datagridview.Rows.Count - 1
            codigositio = datagridview.Item("ColumnCodigoSitio", i).Value.ToString
            For j = 0 To Sitiosds.Tables("TablaSitios").Rows.Count - 1
                If Sitiosds.Tables("TablaSitios").Rows(j).Item("CodigoSitio").ToString = codigositio Then
                    datagridview.Item("ColumnSitioLAT", i).Value = Sitiosds.Tables("TablaSitios").Rows(j).Item("CoordLAT").ToString
                    datagridview.Item("ColumnSitioLONG", i).Value = Sitiosds.Tables("TablaSitios").Rows(j).Item("CoordLONG").ToString
                End If
            Next j
        Next i
        Sitioscon.Close()
    End Sub

    Private Sub CargarIndice(ByVal datagridview As DataGridView, ByVal nombreindice As String, ByVal etiquetaindice As String, ByVal pathDB As String, ByVal nombretablaenDB As String, ByVal categoriacalculo As String)
        ' PARAMETROS: 
        ' datagridview= nombre de la datagridview en la que se cargan los valores
        ' nombreindice= Nombre del índice a agregar como aparece de header en la tabla dentro de la database, ej: valor, indice, etc.
        ' etiquetaindice= Nombre del índice a agregar como va a aparecer en la tabla a exportar
        ' pathDB: el nombre de la base de datos, sin la extension. ej: imrp
        ' nombretablaenDB: el nombre de la tabla en la DB que tiene los valores finales del indice por muestra
        ' categoriacalculo: si el calculo es un indice o un ecologico

        ' CONEXION A LAS TABLAS DE INDICES SI ES ECOLOGICO
        If categoriacalculo = "Ecologico" Then
            Dim ecologicocon As New OleDb.OleDbConnection
            Dim ecologicods As New DataSet
            Dim ecologicoSQL As String
            ecologicocon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\" & pathDB & ".mdb"
            ecologicocon.Open()
            ecologicoSQL = "SELECT * FROM Carac" & pathDB
            Dim ecologicoda = New OleDb.OleDbDataAdapter(ecologicoSQL, ecologicocon)
            ecologicoda.Fill(ecologicods, "Tablaecologico")

            'Para cada variable a la cual debe calcular el ecologico, recorre el metodo y agrega una columna distinta
            For i as integer = 0 To ecologicods.Tables("Tablaecologico").Rows.Count - 1
                Dim colretur As New DataGridViewTextBoxColumn
                colretur.Name = "Column" & nombreindice & "- " & ecologicods.Tables("Tablaecologico").Rows(i).Item("variable").ToString
                colretur.HeaderText = etiquetaindice & "- " & ecologicods.Tables("Tablaecologico").Rows(i).Item("nombre").ToString
                datagridview.Columns.Add(colretur)
            Next
            ecologicocon.Close()

            'carga los valores del ecologico para cada muestra
            Dim Indicecon As New OleDb.OleDbConnection
            Dim Indiceds As New DataSet
            Dim IndiceSQL As String

            Indicecon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\" & pathDB & ".mdb"
            Indicecon.Open()
            IndiceSQL = "SELECT * FROM " & nombretablaenDB & " WHERE IdProyecto = '" & idproyecto & "'"
            Dim Indiceda = New OleDb.OleDbDataAdapter(IndiceSQL, Indicecon)
            Indiceda.Fill(Indiceds, "TablaIndice")

            'recorre cada columna y cada row de la tabla y carga los valores
            Dim idmuestra As String
            For i = 0 To datagridview.Rows.Count - 1
                idmuestra = datagridview.Item("ColumnIdMuestra", i).Value.ToString
                For j = 0 To Indiceds.Tables("TablaIndice").Rows.Count - 1
                    If Indiceds.Tables("TablaIndice").Rows(j).Item("IdMuestra").ToString = idmuestra Then
                        datagridview.Item("Column" & nombreindice & "- " & Indiceds.Tables("TablaIndice").Rows(j).Item("Variable").ToString, i).Value = Indiceds.Tables("TablaIndice").Rows(j).Item(4).ToString
                    End If
                Next j

            Next
            ' CONEXION A LAS TABLAS DE INDICES SI ES INDICE
        ElseIf categoriacalculo = "Indice" Then
            Dim Indicecon As New OleDb.OleDbConnection
            Dim Indiceds As New DataSet
            Dim IndiceSQL As String

            Indicecon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\" & pathDB & ".mdb"
            Indicecon.Open()
            IndiceSQL = "SELECT * FROM " & nombretablaenDB & " WHERE IdProyecto = '" & idproyecto & "'"
            Dim Indiceda = New OleDb.OleDbDataAdapter(IndiceSQL, Indicecon)
            Indiceda.Fill(Indiceds, "TablaIndice")

            datagridview.Columns.Add("Column" & nombreindice, etiquetaindice)

            ' RECORRE LA TABLA Y PARA CADA MUESTRA, BUSCA EN LA TABLA SITIOS Y AGREGA LOS DATOS
            Dim idmuestra As String
            Dim i, j As Integer
            For i = 0 To datagridview.Rows.Count - 1
                idmuestra = datagridview.Item("ColumnIdMuestra", i).Value.ToString
                For j = 0 To Indiceds.Tables("TablaIndice").Rows.Count - 1
                    If Indiceds.Tables("TablaIndice").Rows(j).Item("IdMuestra").ToString = idmuestra Then
                        datagridview.Item("Column" & nombreindice, i).Value = Indiceds.Tables("TablaIndice").Rows(j).Item(3).ToString
                    End If
                Next j
            Next i
            Indicecon.Close()
        End If

    End Sub

    Private Sub CargarDatosSimples(ByVal datagridview As DataGridView, ByVal etiquetaDatos As String, ByVal pathDB As String, ByVal nombretablaenDB As String, codigomodulo As String)
        ' PARAMETROS: 
        ' datagridview= nombre de la datagridview en la que se cargan los valores
        ' etiquetaDatos= Nombre del dato a agregar como va a aparecer en la tabla a exportar
        ' pathDB: el nombre de la base de datos, sin la extension. ej: fq
        ' nombretablaenDB: el nombre de la tabla en la DB que tiene los valores por muestra
        ' codigomodulo: el codigo del modulo. generalmente igual a la pathdb

        ' CONEXION A LAS TABLAS DE DATOS SIMPLES
        Dim DatosSimplescon As New OleDb.OleDbConnection
        Dim DatosSimplesds As New DataSet
        Dim DatosSimplesQL As String

        DatosSimplescon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & pathDB & ".mdb"
        DatosSimplescon.Open()
        DatosSimplesQL = "SELECT * FROM " & nombretablaenDB & " WHERE IdProyecto = '" & idproyecto & "'"
        Dim DatosSimplesda = New OleDb.OleDbDataAdapter(DatosSimplesQL, DatosSimplescon)
        DatosSimplesda.Fill(DatosSimplesds, "TablaDatosSimples")

        Dim i, j As Integer
        For i = 3 To DatosSimplesds.Tables("TablaDatosSimples").Columns.Count - 1
            Dim newcol As New DataGridViewTextBoxColumn
            newcol.Name = DatosSimplesds.Tables("TablaDatosSimples").Columns(i).ColumnName
            newcol.HeaderText = DatosSimplesds.Tables("TablaDatosSimples").Columns(i).ColumnName
            datagridview.Columns.Add(newcol)
        Next

        ' RECORRE LA TABLA Y PARA CADA MUESTRA, BUSCA EN LA TABLA DATOSSIMPLES
        Dim idmuestra As String

        For i = 0 To datagridview.Rows.Count - 1
            idmuestra = datagridview.Item("ColumnIdMuestra", i).Value.ToString
            For j = 0 To DatosSimplesds.Tables("TablaDatosSimples").Rows.Count - 1
                If DatosSimplesds.Tables("TablaDatosSimples").Rows(j).Item("IdMuestra").ToString = idmuestra Then
                    For k As Integer = 3 To DatosSimplesds.Tables("TablaDatosSimples").Columns.Count - 1
                        datagridview.Item(k, i).Value = DatosSimplesds.Tables("TablaDatosSimples").Rows(j).Item(k).ToString
                    Next
                End If
            Next j
        Next i
        DatosSimplescon.Close()
        TraduceDatosSimples(datagridview, pathDB)
    End Sub

    Private Sub TraduceDatosSimples(ByVal datagridview As DataGridView, ByVal tablaenDBNombre As String)
        'TRADUCE LOS NOMBRES DE LAS COLUMNAS POR EL NOMBRE DEL TAXON
        ' CONEXION A LA TABLA DE TAXONES 
        Dim conNombres As New OleDb.OleDbConnection
        Dim dsNombres As New DataSet
        Dim sqlNombres As String
        conNombres.Close()
        conNombres.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & tablaenDBNombre & ".mdb"
        conNombres.Open()
        sqlNombres = "SELECT * FROM CaracParametros"
        Dim daNombres = New OleDb.OleDbDataAdapter(sqlNombres, conNombres)
        daNombres.Fill(dsNombres, "TablaHabitatNombres")

        Dim t, u As Integer
        Dim idtaxon As String
        Dim nombretaxon As String

        For t = 2 To datagridview.Columns.Count - 1
            idtaxon = datagridview.Columns(t).HeaderText
            For u = 0 To dsNombres.Tables("TablaHabitatNombres").Rows.Count - 1
                If "p" & dsNombres.Tables("TablaHabitatNombres").Rows(u).Item("Id").ToString() = idtaxon Then
                    nombretaxon = dsNombres.Tables("TablaHabitatNombres").Rows(u).Item("NombreParametro").ToString
                    datagridview.Columns(t).HeaderText = nombretaxon
                    datagridview.Columns(t).Name = nombretaxon
                End If
            Next
        Next

        'DESPUES RECORRE LA GRID PARA ELIMINAR LAS COLUMNAS QUE NO TIENEN PARAMETROS

        Dim endc As Integer = 2
        Dim totalc As Integer = datagridview.Columns.Count - 1

        Do While endc <= totalc
            idtaxon = datagridview.Columns(endc).HeaderText
            Dim idtaxonrecortado = idtaxon.Remove(0, 1)
            If IsNumeric(idtaxonrecortado) = True Then
                datagridview.Columns.Remove(idtaxon)
                totalc = totalc - 1
                endc = endc - 1
            End If
            endc = endc + 1
        Loop

    End Sub

    Private Sub CargarTaxones(ByVal datagridview As DataGridView, ByVal tablaenDBNombre As String, ByVal dbnombrestaxones As String)
        cantidadrepeticiones = cantidadrepeticiones + 1

        Dim idmuestra As String
        Dim i, j, k, l, m As Integer
        Dim stringfrom As Integer
        Dim stringfromoriginal As Integer = datagridview.Columns.Count
        Dim taxa1 As String
        Dim taxa2 As String
        Dim taxa3 As String
        Dim taxa1Array() As String
        Dim taxa2Array() As String
        Dim taxa3Array() As String
        Dim densidad1 As String
        Dim densidad2 As String
        Dim densidad3 As String
        Dim densidad1Array() As String
        Dim densidad2Array() As String
        Dim densidad3Array() As String

        ' CONECTA A LA TABLA DE TAXONES Y GENERA UNA TABLA VIRTUAL CON LOS DATOS PARA ESE PROYECTO

        ' CONEXION A LA TABLA DE TAXONES
        Dim Taxonescon As New OleDb.OleDbConnection
        Taxonescon.ConnectionString = Nothing
        Taxonescon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Taxonescon.Open()

        For i = 0 To datagridview.Rows.Count - 1
            idmuestra = datagridview.Item(0, i).Value.ToString
            stringfrom = datagridview.Columns.Count
            Dim TaxonesSQL As String = Nothing
            TaxonesSQL = "SELECT * FROM " & tablaenDBNombre & " WHERE IdMuestra = '" & idmuestra & "'"
            Dim Taxonesda = New OleDb.OleDbDataAdapter(TaxonesSQL, Taxonescon)
            Dim Taxonesds As New DataSet
            Taxonesda.Fill(Taxonesds, "TablaTaxones")
            Dim tablamuestras As New DataTable
            tablamuestras.Clear()
            tablamuestras = Taxonesds.Tables("TablaTaxones")

            If tablamuestras.Rows.Count = 0 Then
                Continue For
            End If

            ' PRIMERO RECUPERA TODO LO PRESENTE EN LOS CAMPOS TAXA1, TAXA2 Y TAXA3, Y LO SEPARA
            ' POR SU CARACTER SEPARADOR (#)
            taxa1 = tablamuestras.Rows(0).Item(3).ToString()
            taxa2 = tablamuestras.Rows(0).Item(4).ToString()
            taxa3 = tablamuestras.Rows(0).Item(5).ToString()
            taxa1Array = taxa1.Split("#")
            taxa2Array = taxa2.Split("#")
            taxa3Array = taxa3.Split("#")

            'SACA LOS ID DE TAXA1 y LOS VUELCA EN LA GRID. Si tiene el simbolo !, por ahora no hace nada
            For k = 0 To taxa1Array.Length - 1
                If taxa1Array(k).ToString <> "" Then
                    If (taxa1Array(k).ToString.IndexOf("!") <> -1) Then
                        'taxa1Array(k) = taxa1Array(k).Trim("!")
                        Dim col As New DataGridViewTextBoxColumn
                        col.Name = taxa1Array(k).ToString
                        col.HeaderText = taxa1Array(k).ToString.Trim("!")
                        datagridview.Columns.Add(col)
                    Else
                        Dim col As New DataGridViewTextBoxColumn
                        col.Name = taxa1Array(k).ToString
                        col.HeaderText = taxa1Array(k).ToString.Trim("!")
                        datagridview.Columns.Add(col)
                    End If
                End If
            Next k
            'SACA LOS ID DE TAXA2 y LOS VUELCA EN LA GRID
            For k = 0 To taxa2Array.Length - 1
                If taxa2Array(k).ToString <> "" Then
                    If (taxa2Array(k).ToString.IndexOf("!") <> -1) Then
                        'taxa2Array(k) = taxa2Array(k).Trim("!")
                        Dim col As New DataGridViewTextBoxColumn
                        col.Name = taxa1Array(k).ToString
                        col.HeaderText = taxa2Array(k).ToString.Trim("!")
                        datagridview.Columns.Add(col)
                    Else
                        Dim col As New DataGridViewTextBoxColumn
                        col.Name = taxa2Array(k).ToString
                        col.HeaderText = taxa2Array(k).ToString.Trim("!")
                        datagridview.Columns.Add(col)
                    End If
                End If
            Next k
            'SACA LOS ID DE TAXA3 y LOS VUELCA EN LA GRID
            For k = 0 To taxa3Array.Length - 1
                If taxa3Array(k).ToString <> "" Then
                    If (taxa3Array(k).ToString.IndexOf("!") <> -1) Then
                        Dim col As New DataGridViewTextBoxColumn
                        'taxa3Array(k) = taxa1Array(k).Trim("!")
                        col.Name = taxa3Array(k).ToString
                        col.HeaderText = taxa3Array(k).ToString.Trim("!")
                        datagridview.Columns.Add(col)
                    Else
                        Dim col As New DataGridViewTextBoxColumn
                        col.Name = taxa3Array(k).ToString
                        col.HeaderText = taxa3Array(k).ToString.Trim("!")
                        datagridview.Columns.Add(col)
                    End If
                End If
            Next k

            ' SEGUNDO RECUPERA TODO LO PRESENTE EN LOS CAMPOS DENSIDAD1, DENSIDAD2 Y DENSIDAD3, Y LO SEPARA
            ' POR SU CARACTER SEPARADOR (#)
            densidad1 = tablamuestras.Rows(0).Item(6).ToString()
            densidad2 = tablamuestras.Rows(0).Item(7).ToString()
            densidad3 = tablamuestras.Rows(0).Item(8).ToString()
            densidad1Array = densidad1.Split("#")
            densidad2Array = densidad2.Split("#")
            densidad3Array = densidad3.Split("#")

            'SACA LAS DENSIDADES DE DENSIDAD1ARRAY y LOS VUELCA EN LA GRID
            m = stringfrom
            If densidad1Array.Length > 1 Then
                For l = 0 To densidad1Array.Length - 2
                    If taxa1Array(l).ToString.Contains("!") Then
                        m = m + 1
                    Else
                        datagridview.Item(m, i).Value = densidad1Array(l).ToString
                        m = m + 1
                    End If
                Next l
            End If
            If densidad2Array.Length > 1 Then
                For l = 0 To densidad2Array.Length - 2
                    If taxa2Array(l).ToString.Contains("!") Then
                        m = m + 1
                    Else
                        datagridview.Item(m, i).Value = densidad2Array(l).ToString
                        m = m + 1
                    End If
                Next l
            End If
            If densidad3Array.Length > 1 Then
                For l = 0 To densidad3Array.Length - 2
                    If taxa3Array(l).ToString.Contains("!") Then
                        m = m + 1
                    Else
                        datagridview.Item(m, i).Value = densidad3Array(l).ToString
                        m = m + 1
                    End If
                Next l
            End If
        Next i

        Taxonescon.Close()

        'ACA SACO EL NOMBRE DE LA ULTIMA COLUMNA Y LO GUARDO EN oldname
        'Y LO REEMPLAZO POR CERO, ASI FUNCIONA BIEN EL REORDENADOR DE TAXONES

        Dim oldname As String
        With datagridview
            oldname = .Columns(stringfromoriginal - 1).HeaderText
            .Columns(stringfromoriginal - 1).HeaderText = "0"
        End With

        'REORDENA LOS TAXONES POR ID
        Dim o, p, q, r, s As Integer
        o = 0
        Do Until o = datagridview.Columns.Count - 1
            For p = 3 To datagridview.Columns.Count - 1
                q = datagridview.Columns(p).DisplayIndex - 1
                For r = 0 To datagridview.Columns.Count - 1
                    If datagridview.Columns(r).DisplayIndex = q Then
                        s = datagridview.Columns(r).Index
                    End If
                Next
                If CInt(datagridview.Columns(p).HeaderText) < CInt(datagridview.Columns(s).HeaderText) Then
                    datagridview.Columns(p).DisplayIndex = datagridview.Columns(p).DisplayIndex - 1
                End If
            Next
            o = o + 1
        Loop

        ' Y VUELVO EL HEADERTEXT DE LA ULTIMA COLUMNA ANTES DE REORDENAR
        ' A SU NOMBRE ORIGINAL oldname
        With datagridview
            .Columns(stringfromoriginal - 1).HeaderText = oldname
        End With

        ' AHORA JUNTA LAS COLUMNAS CON IGUAL IDTAXON Y SUMA SUS DENSIDADES
        Dim taxonid As String
        Dim sumadensidades As Integer
        For j = stringfromoriginal To datagridview.Columns.Count - 1
            taxonid = datagridview.Columns(j).HeaderText
            For m = 0 To datagridview.Columns.Count - 1
                If datagridview.Columns(m).HeaderText = taxonid And datagridview.Columns(m).Index <> datagridview.Columns(j).Index And datagridview.Columns(m).Visible = True And datagridview.Columns(j).Visible = True Then
                    For l = 0 To datagridview.Rows.Count - 1
                        sumadensidades = CInt(datagridview.Item(j, l).Value) + CInt(datagridview.Item(m, l).Value)
                        If sumadensidades <> 0 Then
                            datagridview.Item(j, l).Value = sumadensidades
                            datagridview.Columns(m).Visible = False
                        End If
                    Next
                End If
            Next
        Next

        'DESPUES REMUEVE TODAS LAS COLUMNAS QUE FUERON ESCONDIDAS, ASI NO CONFUNDEN MAS
        For i = datagridview.Columns.Count - 1 To 0 Step -1
            If datagridview.Columns(i).Visible = False Then
                datagridview.Columns.RemoveAt(i)
            End If
        Next

        ' MANDA A TRADUCIR LOS HEADERS DE LAS CELDAS A NOMBRES
        Traducetaxones(datagridview, tablaenDBNombre, dbnombrestaxones)

    End Sub

    Private Sub Traducetaxones(ByVal datagridview As DataGridView, ByVal tablaenDBNombre As String, ByVal dbnombrestaxones As String)
        'TRADUCE LOS NOMBRES DE LAS COLUMNAS POR EL NOMBRE DEL TAXON
        ' CONEXION A LA TABLA DE TAXONES 
        Dim conNombres As New OleDb.OleDbConnection
        Dim dsNombres As New DataSet
        Dim sqlNombres As String
        conNombres.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & dbnombrestaxones & ".mdb"
        conNombres.Open()
        sqlNombres = "SELECT * FROM Taxones"
        Dim daNombres = New OleDb.OleDbDataAdapter(sqlNombres, conNombres)
        daNombres.Fill(dsNombres, "TablaTaxonNombres")

        Dim t, u As Integer
        Dim idtaxon As String
        Dim nombretaxon As String

        For t = 2 To datagridview.Columns.Count - 1
            idtaxon = datagridview.Columns(t).HeaderText
            For u = 0 To dsNombres.Tables("TablaTaxonNombres").Rows.Count - 1
                If dsNombres.Tables("TablaTaxonNombres").Rows(u).Item("IdTaxon").ToString() = idtaxon Then
                    nombretaxon = dsNombres.Tables("TablaTaxonNombres").Rows(u).Item("Nombre").ToString
                    datagridview.Columns(t).HeaderText = nombretaxon
                End If
            Next
        Next
        conNombres.Close()
    End Sub

    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////
    '////////       EXPORTAR A EXCEL
    '////////
    '////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////

    Private Sub btnExporttoExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExporttoExcel.Click

        Dim filepath As String
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Archivos de Excel 2007-2010(*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            filepath = saveFileDialog1.FileName

            ' AGREGA SHEETS DE FINAL A PRINCIPIO
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim xlApp As New Microsoft.Office.Interop.Excel.Application
            Dim excelBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add

            For Each tabexport As TabPage In tabGrids.TabPages
                Dim nombremodulo As String = tabexport.Name
                Dim nombrehoja As String = tabexport.Text
                Dim dgvoutput = CType(tabexport.Controls.Find("dgv" & nombremodulo, True)(0), DataGridView)
                ExportarExcel(xlApp, excelBook, dgvoutput, nombrehoja)
            Next

            excelBook.SaveAs(filepath)
            xlApp.Visible = True
        End If
    End Sub

    Private Sub ExportarExcel(ByVal xlApp As Microsoft.Office.Interop.Excel.Application, ByVal excelBook As Microsoft.Office.Interop.Excel.Workbook, ByVal datagridview As DataGridView, ByVal sheetname As String)
        Dim iC As Short
        Dim k, z, x As Short
        Dim excelWorksheet As Excel.Worksheet
        excelWorksheet = DirectCast(excelBook.Sheets.Add(, Count:=1, Type:=Excel.XlSheetType.xlWorksheet), Excel.Worksheet)
        If sheetname.Length >= 30 Then
            sheetname = sheetname.Substring(0, 30)
        End If
        excelWorksheet.Name = sheetname

        ' PONE LOS HEADERS
        Dim colstotal As Integer = datagridview.Columns.Count - 1
        For iC = 0 To colstotal
            k = datagridview.Columns(iC).DisplayIndex
            excelWorksheet.Cells(1, k + 1).Value = datagridview.Columns(iC).HeaderText
        Next

        'PONE LOS VALORES COMO UN RANGE
        Dim array(datagridview.Rows.Count, datagridview.Columns.Count) As String
        For z = 0 To datagridview.Rows.Count - 1
            For x = 0 To datagridview.Columns.Count - 1
                array(z, x) = datagridview(x, z).Value
            Next
        Next
        excelWorksheet.Range("A2:" & ConvertToLetter(datagridview.Columns.Count) & datagridview.Rows.Count + 1).Value = array

        'RELEASE ALLOCATED RESOURCES  
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        xlApp = Nothing
    End Sub

    'ESTA FUNCION CONVIERTE UNA CANTIDAD A SU EQUIVALENTE EN LETRAS... SIRVE PARA LA EXPORT DE EXCEL, PARA SETEAR EL RANGO
    Function ConvertToLetter(iCol As Integer) As String
        Dim iAlpha As Integer
        Dim iRemainder As Integer
        iAlpha = Int(iCol / 27)
        iRemainder = iCol - (iAlpha * 26)
        If iAlpha > 0 Then
            ConvertToLetter = Chr(iAlpha + 64)
        End If
        If iRemainder > 0 Then
            ConvertToLetter = ConvertToLetter & Chr(iRemainder + 64)
        End If
    End Function

    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////
    '////////       EXPORTAR A ARCHIVO DELIMITADO
    '////////
    '////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////


    Private Sub btnExportarCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarCSV.Click
        Dim delimitador As String
        Dim filepath As String
        Dim saveFileDialog1 As New SaveFileDialog()

        'PREGUNTA EL DELIMITADOR
        delimitador = InputBox("Ingrese caracter delimitador (por defecto: coma)", "Ingrese caracter", ",")
        If delimitador.Length = 0 Then
            Exit Sub
        End If


        For Each tabexport As TabPage In tabGrids.TabPages
            Dim nombremodulo As String = tabexport.Name
            Dim nombrehoja As String = tabexport.Text
            saveFileDialog1.Title = "Guarda la planilla de datos " & nombrehoja
            saveFileDialog1.Filter = "Archivos delimitados por coma (*.csv)|*.csv|Todos los archivos (*.*)|*.*"
            saveFileDialog1.FileName = nombremodulo
            saveFileDialog1.FilterIndex = 1
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                filepath = saveFileDialog1.FileName
                Dim dgvoutput = CType(tabexport.Controls.Find("dgv" & nombremodulo, True)(0), DataGridView)
                ExportarCSV(dgvoutput, filepath, delimitador)
            End If
        Next

        MsgBox("Archivos exportados exitosamente")
    End Sub

    Private Sub ExportarCSV(ByVal datagridview As DataGridView, ByVal filepath As String, ByVal delimitador As String)

        Dim sr As StreamWriter = File.CreateText(filepath)
        Dim strDelimiter As String = delimitador
        Dim intColumnCount As Integer = datagridview.Columns.Count - 1
        Dim strRowData As String = ""

        For intX As Integer = 0 To intColumnCount

            strRowData += Replace(datagridview.Columns(intX).HeaderText, strDelimiter, "") & _
                IIf(intX < intColumnCount, strDelimiter, "")
        Next intX

        sr.WriteLine(strRowData)

        For intX As Integer = 0 To datagridview.Rows.Count - 1
            strRowData = ""
            For intRowData As Integer = 0 To intColumnCount
                strRowData += Replace(datagridview.Rows(intX).Cells(intRowData).Value, strDelimiter, "") & _
                    IIf(intRowData < intColumnCount, strDelimiter, "")
            Next intRowData

            sr.WriteLine(strRowData)
        Next intX

        sr.Close()
    End Sub

    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////
    '////////       EXPORTAR A SHAPEFILE
    '////////       
    '////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////

    Private Sub btnExportarSHP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarSHP.Click
        'AGREGA DOS COLUMNAS PARA CADA PAGINA CON LAS COORDENADAS


        For Each tabexport As TabPage In tabGrids.TabPages
            Dim nombremodulo As String = tabexport.Name
            Dim nombrehoja As String = tabexport.Text
            Dim dgvoutput = CType(tabexport.Controls.Find("dgv" & nombremodulo, True)(0), DataGridView)
            CargarSitios(dgvoutput)
            ExportarSHP(dgvoutput, nombrehoja)
        Next
        MsgBox("Archivos exportados a shapefiles correctamente!")
    End Sub


    Private Sub ExportarSHP(ByVal datagridview As DataGridView, nombremodulo As String)

        'Create shapefile from datagridview table
        Dim myShapefile As New MapWinGIS.Shapefile
        Dim success As Boolean
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim filepath As String

        saveFileDialog1.Title = "Guarda Shapefile"
        saveFileDialog1.FileName = nombremodulo & ".shp"
        saveFileDialog1.Filter = "Shapefile (*.shp)|*.shp|Todos los archivos (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            filepath = saveFileDialog1.FileName
        Else
            Exit Sub
        End If


        myShapefile.CreateNew(filepath, MapWinGIS.ShpfileType.SHP_POINT)
        myShapefile.StartEditingShapes(False)


        'Add the fields to .dbf file
        For j As Integer = 0 To datagridview.ColumnCount - 1
            Dim newFld As New MapWinGIS.Field
            Dim fldIdx As Integer
            newFld.Key = datagridview.Columns(j).HeaderText
            newFld.Name = datagridview.Columns(j).HeaderText
            newFld.Width = 25
            newFld.Type = MapWinGIS.FieldType.STRING_FIELD
            fldIdx = datagridview.ColumnCount
            myShapefile.EditInsertField(newFld, fldIdx)
        Next

        'Add points as x, y shapes to shapefile
        For Each r As DataGridViewRow In datagridview.Rows
            Dim shapeindex As Long = 0
            Dim pointindex As Long = 0
            Dim point As New MapWinGIS.Point
            Dim shape As New MapWinGIS.Shape
            success = shape.Create(MapWinGIS.ShpfileType.SHP_POINT)
            point.x = CDbl(r.Cells("ColumnSitioLong").Value)
            point.y = CDbl(r.Cells("ColumnSitioLat").Value)
            shape.InsertPoint(point, pointindex)
            myShapefile.EditInsertShape(shape, shapeindex)
            shapeindex += 1

            'Add all attributes to .dbf file

            For k As Integer = 0 To datagridview.ColumnCount - 1
                Dim cellValueOfDataGrid As String = r.Cells(k).Value
                myShapefile.EditCellValue(k, shapeindex - 1, cellValueOfDataGrid)
            Next k

        Next
        success = myShapefile.StopEditingShapes(True)

        Try
            'Save edits
            myShapefile.SaveAs(myShapefile.Filename)
            Dim myShp As New MapWinGIS.Shapefile

            'Error reporting
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myShapefile.StopEditingShapes(True, True)
        myShapefile.Close()
    End Sub

    Private Sub btnSelDeselTodo_Click(sender As Object, e As EventArgs) Handles btnSelDeselTodo.Click
        If btnSelDeselTodo.Text = "Seleccionar todo" Then
            'selecciona todo
            For i As Integer = 0 To chkItemsCodigos.Items.Count - 1
                chkItemsCodigos.SetItemChecked(i, True)
                chkItemsNombres.SetItemChecked(i, True)
                btnSelDeselTodo.Text = "Deseleccionar todo"
            Next
        Else
            'deselecciona todo
            For i As Integer = 0 To chkItemsNombres.Items.Count - 1
                chkItemsNombres.SetItemChecked(i, False)
                chkItemsCodigos.SetItemChecked(i, False)
                btnSelDeselTodo.Text = "Seleccionar todo"
            Next
        End If
    End Sub

End Class