Imports System.Threading
Public Class frmMacroinvertebrados
    Dim idproyecto As Integer
    Dim idmuestra As Integer
    Dim tipoproyecto As String
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim pathimagen As String = My.Application.Info.DirectoryPath & "\fotosespecies\macroinv\"
    'DECLARO VARIABLES PARA CONSTRUIR ARBOL DE TAXONES
    Dim nombrepadre
    Dim nombrehijo
    Dim taxonyaesta As Boolean
    Dim frmWorkingDialog As New frmWorkingDialog

    Public Sub RecibirVariables(ByVal tipo As String, ByVal id As Integer, ByVal muestra As Integer, ByVal treeviewtemp As TreeView)
        'RECIBO TIPO Y NUMERO DE PROYECTO DE FRMMAIN
        idproyecto = id
        tipoproyecto = tipo
        idmuestra = muestra

        For Each newNode As TreeNode In treeviewtemp.Nodes
            Dim cloneNode As New TreeNode
            cloneNode = newNode.Clone()
            TreeView1.Nodes.Add(cloneNode)
        Next
    End Sub

    Public Sub RecargarArbolMacroinv(ByVal treeview As TreeView)
        Me.TreeView1.Enabled = False
        Me.TreeView1.Nodes.Clear()
        For Each newNode As TreeNode In treeview.Nodes
            Dim cloneNode As New TreeNode
            cloneNode = newNode.Clone()
            Me.TreeView1.Nodes.Add(cloneNode)
        Next
        Me.TreeView1.Enabled = True
    End Sub

    Private Sub frmMacroinvertebrados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        GuardarMuestra()
        'If tipoproyecto = "ArroyoPamp" Then
        '    frmAPampeano.cargarComunidades(idmuestra)
        'End If
    End Sub

    Private Sub frmMacroinvertebrados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MuestrasTableAdapter.qryMuestrasByProyecto(Scilla10DataSet.Muestras, idproyecto)
        MuestrasBindingSource.Position = MuestrasBindingSource.Find("IdMuestra", idmuestra)
        CargaMuestra()

        Me.TaxonesTableAdapter.Fill(MacroinvertebradosDataSet.Taxones)
        'EXTIENDE EL ARBOL
        TreeView1.Nodes(0).Expand()

        Autocompletar()
        txtSearch.Focus()

    End Sub

    Private Sub CargaMuestra()

        '///////////////////////////////////////
        '///////////////////////////////////////
        '///////////////////////////////////////
        '///////////////////////////////////////
        'NUEVA CARGA DE TAXONES ---- DB NUEVA

        ' CONEXION A LA TABLA DE TAXONES
        Dim Macroinvcon As New OleDb.OleDbConnection
        Dim Macroinvds As New DataSet
        Dim MacroinvSQL As String
        Macroinvcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Macroinvcon.Open()
        MacroinvSQL = "SELECT * FROM macroinvs WHERE IdMuestra = '" & idmuestra & "'"
        Dim Macroinvda = New OleDb.OleDbDataAdapter(MacroinvSQL, Macroinvcon)
        Macroinvda.Fill(Macroinvds, "TablaMacroInv")

        If Macroinvds.Tables("TablaMacroInv").Rows.Count = 0 Then
            TaxonesPresentes.Rows.Clear()
            Macroinvds.Tables("TablaMacroInv").Rows.Add()

            'Dim result As Integer = MessageBox.Show("No hay datos para esta muestra, desea agregarlos?", "Agregar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            'If result = DialogResult.Cancel Then
            '    Exit Sub
            'ElseIf result = DialogResult.No Then
            '    Exit Sub
            'ElseIf result = DialogResult.Yes Then
            '    TaxonesPresentes.Rows.Clear()
            '    Macroinvds.Tables("TablaMacroInv").Rows.Add()
            'End If
        ElseIf Macroinvds.Tables("TablaMacroInv").Rows.Count = 1 Then
            TraduceTaxonesPresentes(Macroinvds.Tables("TablaMacroInv"))
        End If
    End Sub

    Private Sub MuestrasBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MuestrasBindingSource.PositionChanged
        If IdMuestraTextBox.Text <> "" Then
            idmuestra = IdMuestraTextBox.Text
            CargaMuestra()
        End If
    End Sub
    Private Sub IrAMuestra(ByVal idmuestraactual As Integer)
        MuestrasBindingSource.Position = MuestrasBindingSource.Find("IdMuestra", idmuestra)
    End Sub


    Private Sub Autocompletar()
        Dim col As New AutoCompleteStringCollection
        Dim m As Integer
        For m = 0 To MacroinvertebradosDataSet.Taxones.Rows.Count - 1
            col.Add(MacroinvertebradosDataSet.Taxones.Rows(m).Item("Nombre").ToString)
        Next
        txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSearch.AutoCompleteCustomSource = col
        txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub TraduceTaxonesPresentes(ByVal tablamuestras As DataTable)
        Dim k As Integer
        Dim j As Integer
        Dim idtaxon As Integer
        Dim nombretaxon As String
        TaxonesPresentes.Rows.Clear()

        ' PRIMERO RECUPERA TODO LO PRESENTE EN LOS CAMPOS TAXA1, TAXA2 Y TAXA3, Y LO SEPARA
        ' POR SU CARACTER SEPARADOR (#)
        Dim taxa1 As String
        Dim taxa2 As String
        Dim taxa3 As String
        Dim taxa1Array() As String
        Dim taxa2Array() As String
        Dim taxa3Array() As String
        taxa1 = tablamuestras.Rows(0).Item(3).ToString()
        taxa2 = tablamuestras.Rows(0).Item(4).ToString()
        taxa3 = tablamuestras.Rows(0).Item(5).ToString()
        taxa1Array = taxa1.Split("#")
        taxa2Array = taxa2.Split("#")
        taxa3Array = taxa3.Split("#")

        'SACA LOS ID DE TAXA1 y LOS VUELCA EN LA GRID. Si tiene el simbolo !, lo oculta
        For k = 0 To taxa1Array.Length - 1
            If taxa1Array(k).ToString <> "" Then
                If (taxa1Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa1Array(k) = taxa1Array(k).Trim("!")
                    TaxonesPresentes.Rows.Add(taxa1Array(k).ToString)
                    Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                    TaxonesPresentes.Rows(c).Visible = False
                Else
                    TaxonesPresentes.Rows.Add(taxa1Array(k).ToString)
                End If
            End If
        Next
        'SACA LOS ID DE TAXA2 y LOS VUELCA EN LA GRID
        For k = 0 To taxa2Array.Length - 1
            If taxa2Array(k).ToString <> "" Then
                If (taxa2Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa2Array(k) = taxa2Array(k).Trim("!")
                    TaxonesPresentes.Rows.Add(taxa2Array(k).ToString)
                    Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                    TaxonesPresentes.Rows(c).Visible = False
                Else
                    TaxonesPresentes.Rows.Add(taxa2Array(k).ToString)
                End If
            End If
        Next
        'SACA LOS ID DE TAXA3 y LOS VUELCA EN LA GRID
        For k = 0 To taxa3Array.Length - 1
            If taxa3Array(k).ToString <> "" Then
                If (taxa3Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa3Array(k) = taxa3Array(k).Trim("!")
                    TaxonesPresentes.Rows.Add(taxa3Array(k).ToString)
                    Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                    TaxonesPresentes.Rows(c).Visible = False
                Else
                    TaxonesPresentes.Rows.Add(taxa3Array(k).ToString)
                End If
            End If
        Next

        ' BUSCA CADA IDTAXON EN LA GRID (recien volcados) EN LA TABLA DE MACROINVERTEBRADOS
        ' Y TRADUCE EL NOMBRE, y LO CARGA A LA GRID TAMBIEN
        Dim taxontable As DataTable

        For j = 0 To TaxonesPresentes.Rows.Count - 1
            idtaxon = CInt(TaxonesPresentes.Item(0, j).Value.ToString)
            taxontable = TaxonesTableAdapter.getTaxonesByIdTaxon(idtaxon)
            nombretaxon = taxontable.Rows(0).Item("Nombre").ToString
            TaxonesPresentes.Item(1, j).Value = nombretaxon
        Next


        ' SEGUNDO RECUPERA TODO LO PRESENTE EN LOS CAMPOS DENSIDAD1, DENSIDAD2 Y DENSIDAD3, Y LO SEPARA
        ' POR SU CARACTER SEPARADOR (#)
        Dim l, m As Integer
        Dim densidad1 As String
        Dim densidad2 As String
        Dim densidad3 As String
        Dim densidad1Array() As String
        Dim densidad2Array() As String
        Dim densidad3Array() As String
        densidad1 = tablamuestras.Rows(0).Item(6).ToString()
        densidad2 = tablamuestras.Rows(0).Item(7).ToString()
        densidad3 = tablamuestras.Rows(0).Item(8).ToString()
        densidad1Array = densidad1.Split("#")
        densidad2Array = densidad2.Split("#")
        densidad3Array = densidad3.Split("#")

        'SACA LAS DENSIDADES DE DENSIDAD1ARRAY y LOS VUELCA EN LA GRID
        m = 0
        If densidad1Array.Length > 1 Then
            For l = 0 To densidad1Array.Length - 2
                TaxonesPresentes.Item(2, m).Value = densidad1Array(l).ToString
                m = m + 1
            Next
        End If
        If densidad2Array.Length > 1 Then
            For l = 0 To densidad2Array.Length - 2
                TaxonesPresentes.Item(2, m).Value = densidad2Array(l).ToString
                m = m + 1
            Next
        End If
        If densidad3Array.Length > 1 Then
            For l = 0 To densidad3Array.Length - 2
                TaxonesPresentes.Item(2, m).Value = densidad3Array(l).ToString
                m = m + 1
            Next
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        GuardarMuestra()
    End Sub
    Private Sub GuardarMuestra()

        ' CONEXION A LA TABLA DE TAXONES
        Dim Macroinvcon As New OleDb.OleDbConnection
        Dim Macroinvds As New DataSet
        Dim MacroinvSQL As String
        Macroinvcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Macroinvcon.Open()
        MacroinvSQL = "SELECT * FROM macroinvs WHERE IdMuestra = '" & idmuestra & "'"
        Dim Macroinvda = New OleDb.OleDbDataAdapter(MacroinvSQL, Macroinvcon)
        Macroinvda.Fill(Macroinvds, "TablaMacroInv")

        Dim i As Integer
        Dim idtaxon As String
        Dim densidad As String
        Dim taxa1 As String
        Dim taxa2 As String
        Dim taxa3 As String
        Dim densidad1 As String
        Dim densidad2 As String
        Dim densidad3 As String

        If Macroinvds.Tables("TablaMacroInv").Rows.Count = 0 Then
            ' SE FIJA QUE HAYA TAXONES PARA AGREGAR, SINO SALE DEL SUB
            If TaxonesPresentes.Rows.Count >= 1 Then
                Macroinvds.Tables("TablaMacroInv").Rows.Add()
                For i = 0 To TaxonesPresentes.RowCount - 1
                    If TaxonesPresentes.Rows(i).Visible = False Then
                        idtaxon = "!" & TaxonesPresentes.Item(0, i).Value.ToString
                        densidad = TaxonesPresentes.Item(2, i).Value.ToString
                        If i < 6400 Then
                            taxa1 = taxa1 + idtaxon + "#"
                            densidad1 = densidad1 + densidad + "#"
                        ElseIf i > 6400 And i < 12800 Then
                            taxa2 = taxa2 + idtaxon + "#"
                            densidad2 = densidad2 + densidad + "#"
                        ElseIf i > 12800 Then
                            taxa3 = taxa3 + idtaxon + "#"
                            densidad3 = densidad3 + densidad + "#"
                        End If
                    ElseIf TaxonesPresentes.Rows(i).Visible = True Then
                        idtaxon = TaxonesPresentes.Item(0, i).Value.ToString
                        densidad = TaxonesPresentes.Item(2, i).Value.ToString
                        If i < 6400 Then
                            taxa1 = taxa1 + idtaxon + "#"
                            densidad1 = densidad1 + densidad + "#"
                        ElseIf i > 6400 And i < 12800 Then
                            taxa2 = taxa2 + idtaxon + "#"
                            densidad2 = densidad2 + densidad + "#"
                        ElseIf i > 12800 Then
                            taxa3 = taxa3 + idtaxon + "#"
                            densidad3 = densidad3 + densidad + "#"
                        End If
                    End If
                Next
            ElseIf TaxonesPresentes.Rows.Count < 1 Then
                Exit Sub
            End If
        ElseIf Macroinvds.Tables("TablaMacroInv").Rows.Count = 1 Then
            ' SE FIJA QUE HAYA TAXONES PARA AGREGAR, SINO SALE DEL SUB Y BORRA LA FILA EXISTENTE
            If TaxonesPresentes.Rows.Count >= 1 Then
                For i = 0 To TaxonesPresentes.RowCount - 1
                    If TaxonesPresentes.Rows(i).Visible = False Then
                        idtaxon = "!" & TaxonesPresentes.Item(0, i).Value.ToString
                        densidad = TaxonesPresentes.Item(2, i).Value.ToString
                        If i < 6400 Then
                            taxa1 = taxa1 + idtaxon + "#"
                            densidad1 = densidad1 + densidad + "#"
                        ElseIf i > 6400 And i < 12800 Then
                            taxa2 = taxa2 + idtaxon + "#"
                            densidad2 = densidad2 + densidad + "#"
                        ElseIf i > 12800 Then
                            taxa3 = taxa3 + idtaxon + "#"
                            densidad3 = densidad3 + densidad + "#"
                        End If
                    ElseIf TaxonesPresentes.Rows(i).Visible = True Then
                        idtaxon = TaxonesPresentes.Item(0, i).Value.ToString
                        densidad = TaxonesPresentes.Item(2, i).Value.ToString
                        If i < 6400 Then
                            taxa1 = taxa1 + idtaxon + "#"
                            densidad1 = densidad1 + densidad + "#"
                        ElseIf i > 6400 And i < 12800 Then
                            taxa2 = taxa2 + idtaxon + "#"
                            densidad2 = densidad2 + densidad + "#"
                        ElseIf i > 12800 Then
                            taxa3 = taxa3 + idtaxon + "#"
                            densidad3 = densidad3 + densidad + "#"
                        End If
                    End If
                Next
            ElseIf TaxonesPresentes.Rows.Count < 1 Then
                Dim cb1 As New OleDb.OleDbCommandBuilder(Macroinvda)
                Dim drCurrent1 As DataRow = Macroinvds.Tables("TablaMacroInv").Rows(0)
                drCurrent1.Delete()
                Macroinvda.Update(Macroinvds, "TablaMacroInv")
                Exit Sub
            End If

        End If


        ' UPDATEA LA BASE DE DATOS, CARGANDO LO NUEVO
        Dim cb As New OleDb.OleDbCommandBuilder(Macroinvda)
        Dim drCurrent As DataRow = Macroinvds.Tables("TablaMacroInv").Rows(0)
        drCurrent.Item(1) = idproyecto
        drCurrent.Item(2) = idmuestra
        drCurrent.Item(3) = taxa1
        drCurrent.Item(4) = taxa2
        drCurrent.Item(5) = taxa3
        drCurrent.Item(6) = densidad1
        drCurrent.Item(7) = densidad2
        drCurrent.Item(8) = densidad3
        Macroinvda.Update(Macroinvds, "TablaMacroInv")
    End Sub


    '    ////////////////////////////////////////////////////////////////
    '    ////
    '    //// AGREGAR TAXON (2 subs)
    '    ////
    '    ////
    '    ////////////////////////////////////////////////////////////////

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim i As Integer
        Dim idtaxon As String
        Dim nombretaxon As String
        Dim cantidadtaxon As String
        Dim padretaxon As String
        Dim idpadretaxon As String
        Dim taxonfinal As Boolean = False

        If txtCantidadAgregar.Text = String.Empty Then
            MsgBox("Tiene que ingresar la cantidad de individuos presentes en su muestra.")
            txtCantidadAgregar.Focus()
            Exit Sub
        End If

        i = TaxonesDataGridView.CurrentRow.Index
        idtaxon = TaxonesDataGridView.Item(1, i).Value.ToString
        nombretaxon = TaxonesDataGridView.Item(2, i).Value.ToString
        padretaxon = TaxonesDataGridView.Item(3, i).Value.ToString
        cantidadtaxon = txtCantidadAgregar.Text

        ' BUSCA EL TAXON POR ID Y LE AGREGA LA NUEVA CANTIDAD

        If padretaxon = "" Then
            'SI NO TIENE PADRE
            AgregarTaxon(idtaxon, cantidadtaxon, False)
        Else
            'SI TIENE PADRE
            'LOOPEA HASTA Q EL TAXON FINAL SEA CIERTO
            Do While taxonfinal = False
                ' SI TIENE PADRE
                ' SACA EL NUMERO DE ID DEL TAXON PADRE A PARTIR DEL NOMBRE
                Dim p As Integer
                For p = 0 To TaxonesDataGridView.RowCount - 1
                    If TaxonesDataGridView.Item(2, p).Value.ToString = padretaxon Then
                        idpadretaxon = TaxonesDataGridView.Item(1, p).Value.ToString
                        AgregarTaxon(idpadretaxon, cantidadtaxon, True)
                        padretaxon = TaxonesDataGridView.Item(3, p).Value.ToString
                        'SI EL TAXON PADRE NO TIENE ABUELO, ES EL TAXON FINAL
                        If padretaxon = "" Then
                            taxonfinal = True
                        Else
                            taxonfinal = False
                        End If
                        Exit For
                    End If
                Next
            Loop
            AgregarTaxon(idtaxon, cantidadtaxon, False)
        End If
    End Sub

    Private Sub AgregarTaxon(ByVal idtaxon As String, ByVal cantidadtaxon As String, ByVal automatic As Boolean)

        ' TRADUCE EL IDTAXON A NOMBRE, SOLO PARA MOSTRARLO
        Dim taxontable As DataTable
        Dim nombretaxon As String
        taxontable = TaxonesTableAdapter.getTaxonesByIdTaxon(CInt(idtaxon))
        nombretaxon = taxontable.Rows(0).Item("Nombre").ToString


        ' TIENE QUE LOOPEAR PARA VER SI EL TAXON YA ESTA AGREGADO O NO
        Dim i As Integer
        Dim taxonexistente As Boolean = False
        For i = 0 To TaxonesPresentes.Rows.Count - 1
            If TaxonesPresentes.Item(0, i).Value.ToString = idtaxon Then
                If TaxonesPresentes.Rows(i).Visible = True Then
                    TaxonesPresentes.Item(2, i).Value = CInt(TaxonesPresentes.Item(2, i).Value) + CInt(cantidadtaxon)
                    taxonexistente = True
                    Exit For
                    'ElseIf TaxonesPresentes.Rows(i).Visible = False Then
                    '    If automatic = True Then
                    '        TaxonesPresentes.Item(2, i).Value = CInt(TaxonesPresentes.Item(2, i).Value) + CInt(cantidadtaxon)
                    '        taxonexistente = True
                    '    Else
                    '        TaxonesPresentes.Item(2, i).Value = CInt(TaxonesPresentes.Item(2, i).Value) + CInt(cantidadtaxon)
                    '        TaxonesPresentes.Rows.Add(idtaxon, nombretaxon, cantidadtaxon)
                    '        taxonexistente = True
                    '    End If
                    '    Exit For
                End If
            End If
        Next i
        If taxonexistente = False Then
            ' AGREGA EL TAXON A LA GRILLA TaxonesPresentes
            ' SI ES UN TAXON AGREGADO AUTOMATICAMENTE, LO PINTA DE OTRO COLOR
            If automatic = True Then
                TaxonesPresentes.Rows.Add(idtaxon, nombretaxon, cantidadtaxon)
                Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                TaxonesPresentes.Rows(c).DefaultCellStyle.ForeColor = Color.Gray
                'TaxonesPresentes.Rows(c).Visible = False
            Else
                TaxonesPresentes.Rows.Add(idtaxon, nombretaxon, cantidadtaxon)
                'TaxonesPresentes.Rows.Add(idtaxon, nombretaxon, cantidadtaxon)
                'Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                'TaxonesPresentes.Rows(c).Visible = False
            End If
        End If
    End Sub


    '    ////////////////////////////////////////////////////////////////
    '    ////
    '    //// BORRAR TAXON (1 sub)
    '    ////
    '    ////
    '    ////////////////////////////////////////////////////////////////


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        ' OBTENGO LOS DATOS DEL TAXON A ELIMINAR
        Dim i As Integer = TaxonesPresentes.CurrentRow.Index
        Dim idtaxon As String = TaxonesPresentes.Item(0, i).Value.ToString
        Dim nombretaxon As String = TaxonesPresentes.Item(1, i).Value.ToString
        Dim cantidadtaxon As String = TaxonesPresentes.Item(2, i).Value.ToString

        ' PREGUNTO CUANTO DEL TAXON DEBO ELIMINAR
        Dim cantidadaeliminar As String
        cantidadaeliminar = InputBox("Cuánto desea eliminar del taxon " & nombretaxon & ", de un máximo de " & cantidadtaxon & "?", , cantidadtaxon)
        If cantidadaeliminar = "" Then
            Exit Sub
        End If

        If CInt(cantidadaeliminar) > CInt(cantidadtaxon) Then
            MsgBox("La cantidad a eliminar del taxón " & nombretaxon & "(" & cantidadaeliminar & ") es mayor a la cantidad existente (" & cantidadtaxon & "). Corríjalo e intente de nuevo")
            Exit Sub
        End If

        ' BUSCO EL TAXON EN EL ARBOL Y VEO EN QUE NIVEL SE ENCUENTRA
        Dim tn() As TreeNode = TreeView1.Nodes(0).Nodes.Find(nombretaxon, True)

        ' VEO EL NIVEL DEL TAXON SELECCIONADO Y BUSCO EL NOMBRE DE SU PADRE
        Dim niveltaxon As String
        Dim padretaxon As String
        TreeView1.SelectedNode = tn(0)
        niveltaxon = TreeView1.SelectedNode.Level.ToString()
        padretaxon = TreeView1.SelectedNode.Parent.Text.ToString()

        ' ME FIJO CUANTOS NODOS HIJOS TIENE ESE NODO (numerohijos)
        ' Y SUMO LA DENSIDAD DE CADA UNO DE LOS NODOS HIJOS

        Dim numerohijos As Integer
        Dim j, k, l As Integer
        Dim nombrehijosiguiente As String
        Dim cantidadhijostotal As Integer

        Dim tnselected As TreeNodeCollection = TreeView1.SelectedNode.Nodes
        numerohijos = tnselected.Count

        For j = 0 To numerohijos - 1
            ' SACO EL NOMBRE DEL NODO HIJO
            nombrehijosiguiente = tnselected.Item(j).Text.ToString
            ' BUSCO EL NODO HIJO EN TAXONESPRESENTES
            For k = 0 To TaxonesPresentes.RowCount - 1
                If TaxonesPresentes.Item(1, k).Value.ToString = nombrehijosiguiente Then
                    ' SUMO LA CANTIDAD DEL TAXON HIJO AL TOTAL
                    cantidadhijostotal = cantidadhijostotal + CInt(TaxonesPresentes.Item(2, k).Value)
                    Exit For
                End If
            Next
        Next

        ' SI LA SUMATORIA DE LAS DENSIDADES DE LOS TAXONES HIJOS ES 
        ' MENOR QUE LA CANTIDAD A ELIMINAR, MANDO MENSAJE Y CANCELO

        'ESTAS VARIABLES SIRVEN PARA BUSCAR A LOS PADRES Y ABUELOS PARA BORRAR
        Dim taxonfinaldel As Boolean = False

        If cantidadhijostotal + cantidadaeliminar > cantidadtaxon Then
            MsgBox("La cantidad que seleccionó para eliminar del taxón " & nombretaxon & " (" & cantidadaeliminar & ") supera a la cantidad que se puede eliminar sin afectar a los taxones que se encuentran en categorías taxonómicas inferiores. No se eliminará.")
            Exit Sub
        Else
            ' SI ES VALIDO, ELIMINO EN LA TABLA TAXONESPRESENTES
            For l = 0 To TaxonesPresentes.Rows.Count - 1
                If TaxonesPresentes.Item(0, l).Value.ToString = idtaxon Then
                    TaxonesPresentes.Item(2, l).Value = CInt(TaxonesPresentes.Item(2, l).Value) - cantidadaeliminar
                End If
            Next

            ' ARRANCA EL LOOP PARA BORRAR A TODOS LOS PADRES Y ABUELOS DEL TAXON
            'SI TIENE PADRE
            'LOOPEA HASTA Q EL TAXONFINAL SEA CIERTO


            Do While taxonfinaldel = False And padretaxon <> "Macroinvertebrados"

                ' BUSCA AL PADRE EN LA TAXONESDATAGRIDVIEW (para saber si tiene otro padre)
                ' Y EN LA TAXONESPRESENTES (para eliminarlo de la lista final)

                Dim p, q As Integer
                For p = 0 To TaxonesDataGridView.RowCount - 1
                    ' Cuando lo encuentra en taxonesdatagridview
                    If TaxonesDataGridView.Item(2, p).Value.ToString = padretaxon Then
                        ' lo busca en taxonespresentes y lo borra
                        For q = 0 To TaxonesPresentes.Rows.Count - 1
                            If TaxonesPresentes.Item(1, q).Value.ToString = padretaxon Then
                                TaxonesPresentes.Item(2, q).Value = CInt(TaxonesPresentes.Item(2, q).Value) - cantidadaeliminar
                            End If
                        Next
                        ' Y cambia el padretaxon al nuevo padretaxon
                        padretaxon = TaxonesDataGridView.Item(3, p).Value.ToString
                        'SI EL TAXON PADRE NO TIENE ABUELO, ES EL TAXON FINAL
                        If padretaxon = "" Then
                            taxonfinaldel = True
                            Exit Do
                        Else
                            taxonfinaldel = False
                        End If
                    End If
                Next
            Loop
            ' LIMPIO TODOS LAS ROWS DE TAXONESPRESENTES
            ' QUE TENGAN VALORES = 0
            ' EN ESTE "REVERSE LOOP"

            For s As Integer = TaxonesPresentes.Rows.Count - 1 To 0 Step -1
                If TaxonesPresentes.Item(2, s).Value.ToString = "0" Then
                    TaxonesPresentes.Rows.Remove(TaxonesPresentes.Rows(s))
                End If
            Next
            MsgBox("Se han eliminado exitosamente " & cantidadaeliminar & " del taxon " & nombretaxon)

        End If
    End Sub


    '    ////////////////////////////////////////////////////////////////
    '    ////
    '    //// MANEJO DE ARBOL Y BUSQUEDA DE TAXON CON AUTOCOMPLETE
    '    ////
    '    ////
    '    ////////////////////////////////////////////////////////////////



    ' SUB PARA CUANDO EL USER HACE CLICK SOBRE UN TAXON
    ' EN EL ARBOL DE TAXONES

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim taxonseleccionado As String
        Dim i As Integer
        If TreeView1.Enabled = True Then
            taxonseleccionado = TreeView1.SelectedNode.Text
            TaxonesDataGridView.ClearSelection()

            For i = 0 To TaxonesDataGridView.RowCount - 1
                If TaxonesDataGridView.Item(2, i).Value.ToString = taxonseleccionado Then
                    TaxonesDataGridView.CurrentCell = TaxonesDataGridView.Rows(i).Cells(1)
                    TaxonesDataGridView.Rows(i).Selected = True
                    Exit For
                End If
            Next i
        End If
        
    End Sub

    ' MANEJA LA TEXT BOX DE BUSQUEDA
    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        If TreeView1.Enabled = True Then
            Dim nodes As TreeNodeCollection
            nodes = TreeView1.Nodes
            Dim n As TreeNode
            txtSearch.Text = ""
            For Each n In nodes
                ClearRecursive(n)
            Next
        End If
    End Sub
    Private Sub ClearRecursive(ByVal treeNode As TreeNode)
        Dim tn As TreeNode
        For Each tn In treeNode.Nodes
            tn.BackColor = Color.White
            ClearRecursive(tn)
        Next
    End Sub
    Private Sub txtSearch_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        If TreeView1.Enabled = True Then
            Dim taxonabuscar As String = txtSearch.Text
            Dim i As Integer

            TaxonesDataGridView.ClearSelection()

            For i = 0 To TaxonesDataGridView.RowCount - 1
                If TaxonesDataGridView.Item(2, i).Value.ToString = taxonabuscar Then
                    TaxonesDataGridView.CurrentCell = TaxonesDataGridView.Rows(i).Cells(1)
                    TaxonesDataGridView.Rows(i).Selected = True
                End If
            Next i

            Dim tnlength As String
            tnlength = TreeView1.GetNodeCount(True)
            If tnlength <> 0 Then
                Dim tn() As TreeNode = TreeView1.Nodes(0).Nodes.Find(taxonabuscar, True)
                TreeView1.SelectedNode = tn(0)
                tn(0).BackColor = Color.Yellow
                TreeView1.Focus()
                txtCantidadAgregar.Focus()
            End If

            '// CARGA LA FOTO DEL TAXON SELECCIONADO
            fototaxon.ImageLocation = pathimagen & taxonabuscar & ".jpg"
        End If

    End Sub

    Private Sub btnEditarListaTaxones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarListaTaxones.Click
        frmDBMacroInvertebrados.RecibirVariables(TreeView1)
        frmDBMacroInvertebrados.Show()
    End Sub

End Class