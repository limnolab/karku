Public Class frmDatosTaxones
    Dim idproyecto As String
    Dim tipoproyecto As String
    Dim nombreproyecto As String
    Dim idmuestra As String
    Dim dbtaxones As String
    Dim tablataxones As String
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim loadtime As Boolean
    Dim isnuevamuestra As Boolean

    'Datasets para la conexion a tabla taxones
    Dim Taxonescon As New OleDb.OleDbConnection
    Dim TaxonesSQL As String
    Dim Taxonesds As New DataSet
    Dim Taxonesda As New OleDb.OleDbDataAdapter

    'Datasets para la conexion a tabla taxonesMuestras
    Dim TaxonesMuestrascon As New OleDb.OleDbConnection
    Dim TaxonesMuestrasds As New DataSet
    Dim TaxonesMuestrasSQL As String
    Dim TaxonesMuestrasda As New OleDb.OleDbDataAdapter

    ' ///////////////////////////////////////////////////////////////////////////////////
    ' ///////////////////////////////////////////////////////////////////////////////////
    ' ///////////////////////////////////////////////////////////////////////////////////
    ' RECIBE VARIABLES Y CARGA EL ARBOL DE TAXONES
    ' ///////////////////////////////////////////////////////////////////////////////////
    ' ///////////////////////////////////////////////////////////////////////////////////

    Public Sub RecibirVariables(ByVal tipoproy As String, ByVal idproy As String, nombreproy As String, ByVal muestrainic As String, ByVal treeviewtemp As TreeView, dbtax As String, tablatax As String)
        loadtime = True
        If TreeView1.Nodes.Count > 0 Then
            TreeView1.Nodes.Clear()
        End If

        'RECIBO TIPO Y NUMERO DE PROYECTO DE FRMMAIN
        idproyecto = idproy
        tipoproyecto = tipoproy
        idmuestra = muestrainic
        dbtaxones = dbtax
        tablataxones = tablatax
        nombreproyecto = nombreproy

        If tipoproyecto = "MuestraRapida" Then
            btnGuardar.Text = "Guardar en muestra rápida"
            btnAgregar.Text = "Agregar a muestra rápida"
        End If


        For Each newNode As TreeNode In treeviewtemp.Nodes
            Dim cloneNode As New TreeNode
            cloneNode = newNode.Clone()
            TreeView1.Nodes.Add(cloneNode)
        Next

    End Sub

    'RECARGAR ARBOL DE TAXONES
    Public Sub RecargarArbolTaxones(ByVal nombretreeviewexistente As String, treeviewnuevo As TreeView)
        'limpia el tv existente y copia los datos del nuevo
        Dim tv As TreeView = CType(Me.Controls(nombretreeviewexistente), TreeView)
        tv.Nodes.Clear()

        For Each newNode As TreeNode In treeviewnuevo.Nodes
            Dim cloneNode As New TreeNode
            cloneNode = newNode.Clone()
            tv.Nodes.Add(cloneNode)
        Next
    End Sub

    Private Sub frmDatosTaxones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not idproyecto = "MuestraRapida" Then
            MuestrasTableAdapter.qryMuestrasByProyecto(Scilla10DataSet.Muestras, idproyecto)
            MuestrasBindingSource.Position = MuestrasBindingSource.Find("IdMuestra", idmuestra)
        End If

        Taxonescon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & dbtaxones & ".mdb"
        Taxonescon.Open()
        TaxonesSQL = "SELECT * FROM Taxones"
        Taxonesda = New OleDb.OleDbDataAdapter(TaxonesSQL, Taxonescon)
        Taxonesda.Fill(Taxonesds, "TablaTaxones")
        TaxonesDataGridView.DataSource = Taxonesds.Tables("TablaTaxones")

        txtIdTaxon.DataSource = Taxonesds.Tables("TablaTaxones")
        txtIdTaxon.DataField = "IdTaxon"
        txtNombre.DataSource = Taxonesds.Tables("TablaTaxones")
        txtNombre.DataField = "Nombre"
        txtAutor.DataSource = Taxonesds.Tables("TablaTaxones")
        txtAutor.DataField = "Autor"
        txtCategoria.DataSource = Taxonesds.Tables("TablaTaxones")
        txtCategoria.DataField = "Categoria"

        Me.Text = dbtaxones.ToUpper

        CargaMuestra()
        'EXTIENDE EL ARBOL
        TreeView1.Nodes(0).Expand()

        'autocompletar nombre y acronimo
        Autocompletar("Nombre", txtSearch)
        Autocompletar("Acronimo", txtSearchAcronimo)

        Taxonescon.Close()
        txtSearch.Focus()
        loadtime = False
    End Sub

    '///////////////////////////////////////
    '///////////////////////////////////////
    ' CONEXION A LA TABLA DE TAXONESMUESTRAS

    Private Sub CargaMuestra()

        If Not idmuestra = "MuestraRapida" Then
            TaxonesMuestrasds.Clear()
            TaxonesMuestrascon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
            TaxonesMuestrascon.Open()
            TaxonesMuestrasSQL = "SELECT * FROM " & tablataxones & " WHERE IdMuestra = '" & idmuestra & "'"
            TaxonesMuestrasda = New OleDb.OleDbDataAdapter(TaxonesMuestrasSQL, TaxonesMuestrascon)
            TaxonesMuestrasda.Fill(TaxonesMuestrasds, "TablaTaxonesMuestras")
            TaxonesMuestrascon.Close()
            If TaxonesMuestrasds.Tables("TablaTaxonesMuestras").Rows.Count = 0 Then
                TaxonesPresentes.Rows.Clear()
                TaxonesMuestrasds.Tables("TablaTaxonesMuestras").Rows.Add()

                'Dim result As Integer = MessageBox.Show("No hay datos para esta muestra, desea agregarlos?", "Agregar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                'If result = DialogResult.Cancel Then
                '    TaxonesPresentes.Rows.Clear()
                '    Exit Sub
                'ElseIf result = DialogResult.No Then
                '    TaxonesPresentes.Rows.Clear()
                '    Exit Sub
                'ElseIf result = DialogResult.Yes Then
                '    TaxonesPresentes.Rows.Clear()
                '    TaxonesMuestrasds.Tables("TablaTaxonesMuestras").Rows.Add()
                'End If
            ElseIf TaxonesMuestrasds.Tables("TablaTaxonesMuestras").Rows.Count = 1 Then
                TraduceTaxonesPresentes(TaxonesMuestrasds.Tables("TablaTaxonesMuestras"))
            End If
        End If
 

    End Sub

    Private Sub MuestrasBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MuestrasBindingSource.PositionChanged
        If IdMuestraTextBox.Text <> "" And loadtime = False Then
            idmuestra = IdMuestraTextBox.Text
            CargaMuestra()
        End If
    End Sub


    'AUTOCOMPLETAR
    Private Sub Autocompletar(ByVal idcolumnaabuscar As String, ByVal textbox As TextBox)
        Dim col As New AutoCompleteStringCollection
        If Taxonesds.Tables("TablaTaxones").Columns.Contains(idcolumnaabuscar) Then
            For m As Integer = 0 To Taxonesds.Tables("TablaTaxones").Rows.Count - 1
                col.Add(Taxonesds.Tables("TablaTaxones").Rows(m).Item(idcolumnaabuscar).ToString)
            Next
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource
            textbox.AutoCompleteCustomSource = col
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End If
    End Sub


    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' TRADUCCION DE TAXONES PRESENTES
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub TraduceTaxonesPresentes(ByVal tablamuestras As DataTable)
        Dim j As Integer
        Dim idtaxon As String
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


        'AGREGA LOS TAXONES Y SU DENSIDAD
        If taxa1Array.Length > 1 Then
            For i As Integer = 0 To taxa1Array.Length - 1
                TaxonesPresentes.Rows.Add()
                Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                TaxonesPresentes.Item("IdTaxon", c).Value = taxa1Array(i)
                TaxonesPresentes.Item("Cantidad", c).Value = densidad1Array(i)
            Next
        End If
        If taxa2Array.Length > 1 Then
            For i = 0 To taxa2Array.Length - 1
                TaxonesPresentes.Rows.Add()
                Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                TaxonesPresentes.Item("IdTaxon", c).Value = taxa2Array(i)
                TaxonesPresentes.Item("Cantidad", c).Value = densidad2Array(i)
            Next
        End If
        If taxa3Array.Length > 1 Then
            For i = 0 To taxa3Array.Length - 1
                TaxonesPresentes.Rows.Add()
                Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                TaxonesPresentes.Item("IdTaxon", c).Value = taxa3Array(i)
                TaxonesPresentes.Item("Cantidad", c).Value = densidad3Array(i)
            Next
        End If

        'BUSCA CADA IDTAXON EN LA GRID (recien volcados) EN LA TABLA DE TAXONES
        'Y TRADUCE EL NOMBRE, y LO CARGA A LA GRID TAMBIEN
        'PINTA DE GRIS LAS QUE TIENEN !


        For j = 0 To TaxonesPresentes.Rows.Count - 1
            If TaxonesPresentes.Item("IdTaxon", j).Value.ToString = "" Then
                TaxonesPresentes.Rows.RemoveAt(j)
                Continue For
            End If

            idtaxon = TaxonesPresentes.Item("IdTaxon", j).Value.ToString
            If idtaxon.ToString.Contains("!") Then
                TaxonesPresentes.Rows(j).DefaultCellStyle.ForeColor = Color.Gray
                idtaxon = idtaxon.ToString.TrimStart("!")
                TaxonesPresentes.Rows(j).Cells("IdTaxon").Value = idtaxon
            End If

            For i As Integer = 0 To Taxonesds.Tables("TablaTaxones").Rows.Count - 1
                If Taxonesds.Tables("TablaTaxones").Rows(i).Item("IdTaxon") = idtaxon Then
                    nombretaxon = Taxonesds.Tables("TablaTaxones").Rows(i).Item("Nombre").ToString
                    Continue For
                End If
            Next
            TaxonesPresentes.Item(1, j).Value = nombretaxon
        Next

    End Sub

    '    ////////////////////////////////////////////////////////////////
    '    ////
    '    //// AGREGAR TAXON (2 subs)
    '    ////
    '    ////
    '    ////////////////////////////////////////////////////////////////

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

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

        idtaxon = TaxonesDataGridView.Item("IdTaxon", TaxonesDataGridView.CurrentRow.Index).Value.ToString
        nombretaxon = TaxonesDataGridView.Item("Nombre", TaxonesDataGridView.CurrentRow.Index).Value.ToString
        padretaxon = TaxonesDataGridView.Item("NivelPadre", TaxonesDataGridView.CurrentRow.Index).Value.ToString
        cantidadtaxon = txtCantidadAgregar.Text

        ' BUSCA EL TAXON POR ID Y LE AGREGA LA NUEVA CANTIDAD

        If padretaxon = "" Then
            'SI NO TIENE PADRE
            AgregarTaxon(idtaxon, cantidadtaxon, nombretaxon, False)
        Else
            'SI TIENE PADRE
            'LOOPEA HASTA Q EL TAXON FINAL SEA CIERTO
            Do While taxonfinal = False
                ' SI TIENE PADRE
                ' SACA EL NUMERO DE ID DEL TAXON PADRE A PARTIR DEL NOMBRE
                Dim p As Integer
                For p = 0 To TaxonesDataGridView.RowCount - 1
                    If TaxonesDataGridView.Item("Nombre", p).Value.ToString = padretaxon Then
                        idpadretaxon = TaxonesDataGridView.Item("IdTaxon", p).Value.ToString
                        Dim nombrepadretaxon As String = TaxonesDataGridView.Item("Nombre", p).Value.ToString
                        AgregarTaxon(idpadretaxon, cantidadtaxon, nombrepadretaxon, True)
                        padretaxon = TaxonesDataGridView.Item("NivelPadre", p).Value.ToString
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
            AgregarTaxon(idtaxon, cantidadtaxon, nombretaxon, False)
        End If
    End Sub

    Private Sub AgregarTaxon(ByVal idtaxon As String, ByVal cantidadtaxon As String, nombretaxon As String, ByVal automatic As Boolean)

        ' TIENE QUE LOOPEAR PARA VER SI EL TAXON YA ESTA AGREGADO O NO
        Dim taxonexistente As Boolean = False

        For i = 0 To TaxonesPresentes.Rows.Count - 1
            If TaxonesPresentes.Item(0, i).Value.ToString = idtaxon Then
                TaxonesPresentes.Item(2, i).Value = CInt(TaxonesPresentes.Item(2, i).Value) + CInt(cantidadtaxon)
                If automatic = False Then
                    TaxonesPresentes.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                End If
                taxonexistente = True
                Exit For
            End If
        Next i
        If taxonexistente = False Then
            ' AGREGA EL TAXON A LA GRILLA TaxonesPresentes
            ' SI ES UN TAXON AGREGADO AUTOMATICAMENTE, LO PINTA DE OTRO COLOR
            If automatic = True Then
                TaxonesPresentes.Rows.Add(idtaxon, nombretaxon, cantidadtaxon)
                Dim c As Integer = TaxonesPresentes.Rows.Count - 1
                TaxonesPresentes.Rows(c).DefaultCellStyle.ForeColor = Color.Gray
            Else
                TaxonesPresentes.Rows.Add(idtaxon, nombretaxon, cantidadtaxon)
            End If
        End If
    End Sub


    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' GUARDADO DE MUESTRAS
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not tipoproyecto = "MuestraRapida" Then
            GuardarMuestra()
        End If
    End Sub
    Private Sub GuardarMuestra()

        Dim i As Integer
        Dim idtaxon As String
        Dim densidad As String
        Dim taxa1 As String
        Dim taxa2 As String
        Dim taxa3 As String
        Dim densidad1 As String
        Dim densidad2 As String
        Dim densidad3 As String

        If TaxonesMuestrasds.Tables("TablaTaxonesMuestras").Rows.Count = 0 Then
            ' SE FIJA QUE HAYA TAXONES PARA AGREGAR, SINO SALE DEL SUB
            If TaxonesPresentes.Rows.Count >= 1 Then
                TaxonesMuestrasds.Tables("TablaTaxonesMuestras").Rows.Add()
                For i = 0 To TaxonesPresentes.RowCount - 1
                    If TaxonesPresentes.Rows(i).DefaultCellStyle.ForeColor = Color.Gray Then
                        'If TaxonesPresentes.Rows(i).Visible = False Then
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
                    Else
                        'ElseIf TaxonesPresentes.Rows(i).Visible = True Then
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
            Else
                Exit Sub
            End If
        ElseIf TaxonesMuestrasds.Tables("TablaTaxonesMuestras").Rows.Count = 1 Then
            ' SE FIJA QUE HAYA TAXONES PARA AGREGAR, SINO SALE DEL SUB Y BORRA LA FILA EXISTENTE
            If TaxonesPresentes.Rows.Count >= 1 Then
                For i = 0 To TaxonesPresentes.RowCount - 1
                    If TaxonesPresentes.Rows(i).DefaultCellStyle.ForeColor = Color.Gray Then
                        'If TaxonesPresentes.Rows(i).Visible = False Then
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
                    Else
                        'ElseIf TaxonesPresentes.Rows(i).Visible = True Then
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
                Dim cb1 As New OleDb.OleDbCommandBuilder(TaxonesMuestrasda)
                Dim drCurrent1 As DataRow = TaxonesMuestrasds.Tables("TablaTaxonesMuestras").Rows(0)
                drCurrent1.Delete()
                TaxonesMuestrasda.Update(TaxonesMuestrasds, "TablaTaxonesMuestras")
                Exit Sub
            End If
        End If

        ' UPDATEA LA BASE DE DATOS, CARGANDO LO NUEVO
        Dim cb As New OleDb.OleDbCommandBuilder(TaxonesMuestrasda)
        Dim drCurrent As DataRow = TaxonesMuestrasds.Tables("TablaTaxonesMuestras").Rows(0)
        drCurrent.Item(1) = idproyecto
        drCurrent.Item(2) = idmuestra
        drCurrent.Item(3) = taxa1
        drCurrent.Item(4) = taxa2
        drCurrent.Item(5) = taxa3
        drCurrent.Item(6) = densidad1
        drCurrent.Item(7) = densidad2
        drCurrent.Item(8) = densidad3
        TaxonesMuestrasda.Update(TaxonesMuestrasds, "TablaTaxonesMuestras")
    End Sub


    '    ////////////////////////////////////////////////////////////////
    '    ////
    '    //// BORRAR TAXON (1 sub)
    '    ////
    '    ////
    '    ////////////////////////////////////////////////////////////////


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        ' OBTENGO LOS DATOS DEL TAXON A ELIMINAR
        Dim idtaxon As String = TaxonesPresentes.Item(0, TaxonesPresentes.CurrentRow.Index).Value.ToString
        Dim nombretaxon As String = TaxonesPresentes.Item(1, TaxonesPresentes.CurrentRow.Index).Value.ToString
        Dim cantidadtaxon As String = TaxonesPresentes.Item(2, TaxonesPresentes.CurrentRow.Index).Value.ToString

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


            Do While taxonfinaldel = False And padretaxon <> dbtaxones

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


    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' MANEJO DE LA BUSQUEDA Y ARBOL
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        If TreeView1.Enabled = True Then
            Dim taxonabuscar As String = txtSearch.Text
            Dim i As Integer

            TaxonesDataGridView.ClearSelection()

            For i = 0 To TaxonesDataGridView.RowCount - 1
                If TaxonesDataGridView.Item(2, i).Value.ToString = taxonabuscar Then
                    TaxonesDataGridView.CurrentCell = TaxonesDataGridView.Rows(i).Cells(1)
                    TaxonesDataGridView.Rows(i).Selected = True
                    Exit For
                End If
            Next i

            Dim tnlength As String
            tnlength = TreeView1.GetNodeCount(True)
            If tnlength <> 0 Then
                If taxonabuscar <> "" Then
                    Dim tn() As TreeNode = TreeView1.Nodes(0).Nodes.Find(taxonabuscar, True)
                    TreeView1.SelectedNode = tn(0)
                    tn(0).BackColor = Color.Yellow
                    TreeView1.Focus()
                    txtCantidadAgregar.Focus()
                End If

            End If

            '       // CARGA LA FOTO DEL TAXON SELECCIONADO
            '          fototaxon.ImageLocation = pathimagen & taxonabuscar & ".jpg"
        End If
    End Sub

    Private Sub txtSearchAcronimo_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAcronimo.TextChanged
        'Controla si la especie existe
        Dim nametaxon As String
        Dim acronimovar As String
        Dim j As Integer
        acronimovar = txtSearchAcronimo.Text
        TaxonesDataGridView.ClearSelection()
        If Not txtSearchAcronimo.Text = "" Then
            For j = 0 To TaxonesDataGridView.RowCount - 1
                If TaxonesDataGridView.Item(3, j).Value.ToString = acronimovar Then
                    TaxonesDataGridView.CurrentCell = TaxonesDataGridView.Rows(j).Cells(1)
                    nametaxon = TaxonesDataGridView.Item(2, j).Value.ToString
                    txtSearch.Text = nametaxon
                    TaxonesDataGridView.Rows(j).Selected = True
                    Exit For
                End If
            Next j
        End If
    End Sub


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


    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MENU
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub SalirAWindowsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EnciclopediaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnciclopediaToolStripMenuItem1.Click
        frmEnciclopedia.Show()
    End Sub

    Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click
        frmImportar.Show()
        frmImportar.cmbTipoDatos.SelectedValue = tablataxones
        frmImportar.cmbProyecto.SelectedValue = nombreproyecto
    End Sub

    Private Sub btnEditarListaTaxones_Click(sender As Object, e As EventArgs) Handles btnEditarListaTaxones.Click
        '  Dim Fullname As String = "Scila7.frmDB" & dbtaxones
        '  Activator.CreateInstance(Type.GetType(Fullname, True, True))

        Dim obj As Object = Activator.CreateInstance(Type.GetType("Scila7.frmDB" & dbtaxones, True, True))
        obj.recibirvariables(treeview1)
        obj.ShowDialog()
    End Sub
End Class