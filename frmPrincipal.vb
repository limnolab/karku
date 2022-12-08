Imports System.Reflection

Public Class frmPrincipal
    Dim pathfisico As String = My.Application.Info.DirectoryPath & "\htmls\"
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim destino As Form
    Dim destinostring As String
    Dim idproyectoselected As String

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SitiosDataSet.Sitios' table. You can move, or remove it, as needed.
        Me.SitiosTableAdapter.Fill(Me.SitiosDataSet.Sitios)
        Me.ProyectosTableAdapter.Fill(Me.Scilla10DataSet.Proyectos)
        ConfigTableAdapter.qryConfigById(Me.ConfigDataSet.Config, 1)

        'CARGA DEL LOGOTIPO
        'los logos van en la carpeta images\logo
        Dim logoname As String = ConfigDataSet.Tables("Config").Rows(0).Item("logotipo").ToString
        Dim pathlogo As String = pathapp & "\images\logo\" & logoname
        If logoname <> "" Then
            LogoPictureBox.BackgroundImage = Image.FromFile(pathlogo)
            LogoPictureBox.BackgroundImageLayout = ImageLayout.Zoom
        End If

        '///////////////////////////////
        '///////////////////////////////
        '///////////////////////////////
        'PRECARGA DE ARBOLES DE TAXONES
        '///////////////////////////////
        '///////////////////////////////
        '///////////////////////////////

        'CARGA LAS DB DE MODULOS 
        Dim moduloscon As New OleDb.OleDbConnection
        Dim modulosSQL As String
        moduloscon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\config.mdb"
        moduloscon.Open()

        Dim modulosds As New DataSet
        modulosSQL = "SELECT * FROM Modulos"
        Dim modulosda = New OleDb.OleDbDataAdapter(modulosSQL, moduloscon)
        modulosda.Fill(modulosds, "Tablamodulos")

        ' RECORRO LOS MODULOS DE LA CONFIGURACION. para todos los que son de taxones genero un arbol
        For i = 0 To modulosds.Tables("Tablamodulos").Rows.Count - 1
            If modulosds.Tables("Tablamodulos").Rows(i).Item("Tipo").ToString.Contains("DatosTaxones") Then
                Dim tipoarray As String() = modulosds.Tables("Tablamodulos").Rows(i).Item("Tipo").ToString.Split(";")
                Dim dbname As String = tipoarray(1)

                Dim newtreeview As New TreeView
                With newtreeview
                    .Name = "treeview" & dbname
                    .Visible = False
                    PrecargaArbol(dbname, newtreeview)
                End With
                Me.Controls.Add(newtreeview)

                'y ya que esta agregua opciones al boton de buscar organismos
                Dim organismosval As New C1.Win.C1Input.DropDownItem
                organismosval.Text = modulosds.Tables("Tablamodulos").Rows(i).Item("Nombre").ToString
                'organismosval.BackColor = Color.FromArgb(23, 108, 156)

                AddHandler organismosval.Click, AddressOf organismosval_Click
                btnBuscarOrganismos2.Items.Add(organismosval)

            End If
        Next
        moduloscon.Close()

        'ESCONDE LAS TABS - Poner en TRUE al final
        TabDock.ShowTabs = False
    End Sub

    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////
    '////////////////////////////////////// CONTROLA EL CLICK DEL BOTON "BUSCAR ORGANISMOS"
    '//////////////////////////////////////

    Private Sub organismosval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim organismo = DirectCast(sender, C1.Win.C1Input.DropDownItem)
        Dim organismonombre As String = organismo.Text
        frmBuscarEspecie.RecibirVariables(organismonombre)
        frmBuscarEspecie.Show()
    End Sub


    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////
    '////////////////////////////////////// PRECARGA DE ARBOL
    '//////////////////////////////////////

    Private Sub PrecargaArbol(dbnombre As String, treeviewdestino As TreeView)
        Dim dt As DataTable

        ' CONEXION A LA TABLA DE TAXONES
        Dim Taxonescon As New OleDb.OleDbConnection
        Dim Taxonesds As New DataSet
        Dim TaxonesSQL As String
        Taxonescon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & dbnombre & ".mdb"
        Taxonescon.Open()
        TaxonesSQL = "SELECT * FROM Taxones"
        Dim Taxonesda = New OleDb.OleDbDataAdapter(TaxonesSQL, Taxonescon)
        Taxonesda.Fill(Taxonesds, "TablaTaxones")
        dt = Taxonesds.Tables("TablaTaxones")
        ArmarArbol(treeviewdestino, dt)
        Taxonescon.Close()
    End Sub

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

    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////
    '//////////////////////// TAB: NUEVO PROYECTO
    '////////////////////////
    '////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////

    Private Sub btnRLP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRLP.Click
        webDescripcion.Navigate(pathfisico & "descripcion-estuarioRLP.html")
        webDescripcion.Visible = True
        txtNuevoAmbiente.Text = "RLP"
        btnSiguienteTipoAmbiente.Visible = True
    End Sub

    Private Sub btnarroyopamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarroyopamp.Click
        webDescripcion.Navigate(pathfisico & "descripcion-arroyopamp.html")
        webDescripcion.Visible = True
        txtNuevoAmbiente.Text = "ArroyoPamp"
        btnSiguienteTipoAmbiente.Visible = True
    End Sub

    Private Sub btnAmbienteLibre_Click(sender As Object, e As EventArgs) Handles btnAmbienteLibre.Click
        webDescripcion.Navigate(pathfisico & "descripcion-ambientelibre.html")
        webDescripcion.Visible = True
        txtNuevoAmbiente.Text = "Libre"
        btnSiguienteTipoAmbiente.Visible = True
    End Sub

    Private Sub btnarroyomont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarroyomont.Click
        webDescripcion.Navigate(pathfisico & "descripcion-arroyomont.html")
        webDescripcion.Visible = True
        txtNuevoAmbiente.Text = "Amontana"
        btnSiguienteTipoAmbiente.Visible = True
    End Sub

    Private Sub btnLenitico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLenitico.Click
        webDescripcion.Navigate(pathfisico & "descripcion-lenitico.html")
        webDescripcion.Visible = True
        txtNuevoAmbiente.Text = "Lentico"
        btnSiguienteTipoAmbiente.Visible = True
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// COMIENZA EL "WIZARD" DE NUEVOS PROYECTOS
    '////////////////////////////////////////////////////////////////////////

    Private Sub btnSiguienteSeleccioneAmbiente_Click(sender As Object, e As EventArgs) Handles btnSiguienteTipoAmbiente.Click
        'Grilla para que seleccione los datos a usar en el proyecto, carga de los módulos habilitados
        Dim moduloscon As New OleDb.OleDbConnection
        Dim modulosSQL As String
        moduloscon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\config.mdb"
        moduloscon.Open()

        Dim modulosds As New DataSet
        modulosSQL = "SELECT * FROM Modulos"
        Dim modulosda = New OleDb.OleDbDataAdapter(modulosSQL, moduloscon)
        modulosda.Fill(modulosds, "Tablamodulos")

        Dim modulocodigo As String
        For i = 0 To modulosds.Tables("Tablamodulos").Rows.Count - 1
            modulocodigo = modulosds.Tables("Tablamodulos").Rows(i).Item("codigo").ToString
            If modulosds.Tables("Tablamodulos").Rows(i).Item("habilitado") = True Then
                'Hace una row para ese modulo
                Dim modulorow As New DataGridViewRow
                dgvDatosAUsar.Rows.Add(modulosds.Tables("Tablamodulos").Rows(i).Item("nombre").ToString)
            End If
        Next
        moduloscon.Close()
        'TabPageTipoDatos.TabVisible = True
        'tabNuevoProyecto.SelectedTab = TabPageTipoDatos
        TabPageMuestrasIniciales.TabVisible = True
        tabNuevoProyecto.SelectedTab = TabPageMuestrasIniciales
    End Sub

    Private Sub btnSiguienteTipoDatos_Click(sender As Object, e As EventArgs) Handles btnSiguienteTipoDatos.Click
        'ACA SE FIJA SI ES UN PROYECTO DE VERDAD O SON MUESTRAS LIBRES
        If tipoproyecto = "Libre" Then
            MsgBox("Muestras libres y sueltas")
        Else
            TabPageMuestrasIniciales.TabVisible = True
            tabNuevoProyecto.SelectedTab = TabPageMuestrasIniciales
        End If
    End Sub

    Private Sub numMuestrasIniciales_ValueChanged(sender As Object, e As EventArgs) Handles numMuestrasIniciales.ValueChanged
        Dim varmuestrasiniciales As Integer = numMuestrasIniciales.Value
        Dim numrows As Integer = dgvMuestrasIniciales.RowCount
        Dim diferenciarows As Integer = varmuestrasiniciales - numrows
        'AGREGA ROWS SI FALTAN
        If numrows < varmuestrasiniciales Then
            For i As Integer = 0 To varmuestrasiniciales
                dgvMuestrasIniciales.Rows.Add()
                dgvMuestrasIniciales.Item(0, dgvMuestrasIniciales.RowCount - 1).Value = "Muestra " & dgvMuestrasIniciales.RowCount
                If numMuestrasIniciales.Value = dgvMuestrasIniciales.Rows.Count Then
                    Exit Sub
                End If
            Next
        End If

        'SACA ROWS SI SOBRAN
        If numrows > varmuestrasiniciales Then
            For i As Integer = 0 To dgvMuestrasIniciales.Rows.Count
                dgvMuestrasIniciales.Rows.RemoveAt(dgvMuestrasIniciales.RowCount - 1)
                If numMuestrasIniciales.Value = dgvMuestrasIniciales.Rows.Count Then
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub btnSiguienteMuestrasIniciales_Click(sender As Object, e As EventArgs) Handles btnSiguienteMuestrasIniciales.Click

        'GUARDA EL PROYECTO NUEVO
        If txtNuevoAmbiente.Text = "" Then
            MsgBox("Debe seleccionar un tipo de ambiente")
            Exit Sub
        Else
            Dim tipoproyecto As String = txtNuevoAmbiente.Text
            ProyectosBindingSource.EndEdit()
            ProyectosTableAdapter.Update(Scilla10DataSet.Proyectos)
        End If

        'CREA MUESTRAS PARA ESE PROYECTO
        'Primero chequea que todas tengan nombre, sino cancela
        Dim nombresok As Boolean = True
        For i As Integer = 0 To dgvMuestrasIniciales.RowCount - 1
            If dgvMuestrasIniciales.Item(0, i).ToString = "" Then
                MsgBox("Hay muestras que no tienen nombre. Todas las muestras a agregar deben tener nombre")
                Exit Sub
            End If
        Next

        ProyectosTableAdapter.Fill(Scilla10DataSet.Proyectos)
        ProyectosBindingSource.MoveLast()

        Dim idproyectonuevo As String = IdProyectoTextBox.Text
        Dim autorproyectonuevo As String = txtAutorNuevo.Text

        'Conecta a la base de datos de muestras

        Dim muestrascon As New OleDb.OleDbConnection
        Dim muestrasSQL As String
        muestrascon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\Scilla10.mdb"
        muestrascon.Open()

        Dim muestrasds As New DataSet
        muestrasSQL = "SELECT * FROM Muestras"
        Dim muestrasda = New OleDb.OleDbDataAdapter(muestrasSQL, muestrascon)
        muestrasda.Fill(muestrasds, "TablaMuestras")

        'Agrega una muestra por cada row
        For i = 0 To dgvMuestrasIniciales.RowCount - 1
            Dim nombremuestra As String = dgvMuestrasIniciales.Item(0, i).Value.ToString
            Dim nuevarow As DataRow = muestrasds.Tables("Tablamuestras").NewRow
            nuevarow.Item("IdProyecto") = CInt(idproyectonuevo)
            nuevarow.Item("Nombre") = nombremuestra
            nuevarow.Item("Autor") = autorproyectonuevo
            muestrasds.Tables("Tablamuestras").Rows.Add(nuevarow)

        Next

        'Graba la tabla y cierra
        Dim changes As DataSet
        Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(muestrasda)
        muestrasda.InsertCommand = oledbCmdBuilder.GetInsertCommand()
        muestrasda.DeleteCommand = oledbCmdBuilder.GetDeleteCommand()

        changes = muestrasds.GetChanges()
        If changes IsNot Nothing Then
            muestrasda.Update(muestrasds.Tables("Tablamuestras"))
        End If
        muestrasds.AcceptChanges()
        muestrascon.Close()

        MsgBox("Proyecto creado exitosamente. Ya puede cargar datos en las muestras!")

        'RECARGO LOS PROYECTOS
        ProyectosTableAdapter.Fill(Scilla10DataSet.Proyectos)
        ProyectosBindingSource.MoveLast()

        'PASO A LOS SIGUIENTES TABS y ESCONDO LAS TABS QUE NO VAN
        PageNuevoProyecto.TabVisible = False
        PageMuestras.TabVisible = True
        PageProyectos.TabVisible = False
        TabDock.SelectedTab = PageMuestras
        CargarMuestrasProyecto()
    End Sub


    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////
    '//////////////////////// TAB INICIO
    '////////////////////////
    '////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////


    Private Sub btnNuevoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProyecto.Click
        Dim nombreproyecto As String
        Dim autorproyecto As String
        nombreproyecto = InputBox("Ingrese el nombre del proyecto", , "Proyecto ")

        If nombreproyecto <> "" Then
            autorproyecto = InputBox("Ingrese el autor del proyecto", , "Autor")
            If autorproyecto <> "" Then
                ' AGREGA PROYECTO
                ProyectosBindingSource.AddNew()

                'MUESTRA LA TAB NUEVOPROYECTO Y ESCONDE EL RESTO
                PageProyectos.TabVisible = False
                PageMuestras.TabVisible = False
                PageNuevoProyecto.TabVisible = True
                TabDock.SelectedTab = PageNuevoProyecto

                'AGREGA EL NOMBRE Y AUTOR DE LOS INPUTS
                txtNombreNuevo.Text = nombreproyecto
                txtAutorNuevo.Text = autorproyecto
            Else
                'CANCELA EL INPUT AUTOR DEL PROYECTO
                Exit Sub
            End If
        Else
            ' CANCELA EL INPUT NOMBRE DEL PROYECTO
            Exit Sub
        End If
    End Sub


    Private Sub btnGuardarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarProyecto.Click
        ProyectosBindingSource.EndEdit()
        ProyectosTableAdapter.Update(Scilla10DataSet.Proyectos)

        ' ESCONDE BOTONES INNECESARIOS Y MUESTRA NECESARIOS
        btnNuevoProyecto.Visible = True
        btnGuardarProyecto.Visible = False
        btnSiguienteProyectos.Visible = True
        NombreTextBox.Enabled = False
        AutorTextBox.Enabled = False
        DescripcionTextBox.Enabled = False
        grpDatosdelProyecto.Visible = False
        ProyectosDataGridView.Visible = True

    End Sub


    Private Sub borrarProyecto(borrarmuestras As Boolean)
        Dim idmuestraborrar As Integer
        Dim i As Integer

        'RETIENE EL NUMERO DE PROYECTO Y CARGA LOS MODULOS
        j = ProyectosDataGridView.CurrentRow.Index
        idproyectoselected = CInt(ProyectosDataGridView.Item(0, j).Value.ToString)

        Dim moduloscon As New OleDb.OleDbConnection
        Dim modulosSQL As String
        moduloscon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\config.mdb"
        moduloscon.Open()

        Dim modulosds As New DataSet
        modulosSQL = "SELECT * FROM Modulos"
        Dim modulosda = New OleDb.OleDbDataAdapter(modulosSQL, moduloscon)
        modulosda.Fill(modulosds, "Tablamodulos")
        moduloscon.Close()

        'TOMA EL PRIMER MODULO Y CARGA LA DB ASOCIADA

        Dim modulocodigo As String
        For i = 0 To modulosds.Tables("Tablamodulos").Rows.Count - 1
            'busca el nombre del modulo
            modulocodigo = modulosds.Tables("Tablamodulos").Rows(i).Item("codigo").ToString
            Dim modulotipo As String = modulosds.Tables("Tablamodulos").Rows(i).Item("Tipo").ToString
            'SI ES DE DATOS SIMPLES, CARGA LA DB POR VARIABLES Y BORRA
            If modulotipo = "DatosSimples" Then
                Dim con As New OleDb.OleDbConnection
                Dim sql As String
                con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & modulocodigo & ".mdb"
                con.Open()

                Dim ds As New DataSet
                Dim modulocodigocaps As String = StrConv(modulocodigo, VbStrConv.ProperCase)
                sql = "SELECT * FROM Parametros" & modulocodigocaps & " WHERE IdProyecto = '" & idproyectoselected & "'"
                Dim da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(ds, "Tabla")

                Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(da)
                da.DeleteCommand = oledbCmdBuilder.GetDeleteCommand()

                Dim rowsfound As Integer = ds.Tables("Tabla").Rows.Count - 1
                For rowdeleted As Integer = 0 To rowsfound
                    ds.Tables("Tabla").Rows(0).Delete()
                    da.Update(ds.Tables("Tabla"))
                    ds.AcceptChanges()
                Next
                'MsgBox("Datos de " & modulocodigocaps & " borrados")
                con.Close()
            Else
                Dim con1 As New OleDb.OleDbConnection
                Dim sql1 As String
                con1.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
                con1.Open()
                Dim ds1 As New DataSet

                sql1 = "SELECT * FROM " & modulocodigo & " WHERE IdProyecto = '" & idproyectoselected & "'"
                Dim da1 = New OleDb.OleDbDataAdapter(sql1, con1)
                da1.Fill(ds1, "Tabla")


                Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(da1)
                da1.DeleteCommand = oledbCmdBuilder.GetDeleteCommand()

                Dim rowsfound1 As Integer = ds1.Tables("Tabla").Rows.Count - 1
                For rowdeleted1 As Integer = 0 To rowsfound1
                    ds1.Tables("Tabla").Rows(0).Delete()
                    da1.Update(ds1.Tables("Tabla"))
                    ds1.AcceptChanges()
                Next
                'MsgBox("Datos de " & modulocodigo & " borrados")
                con1.Close()
            End If
        Next
        MsgBox("Datos asociados a las muestras borrados exitosamente")
        If borrarmuestras = True Then
            'BORRAR MUESTRAS DEL PROYECTO
            If Not MuestrasDataGridView.RowCount = 1 Then

                Dim con As New OleDb.OleDbConnection
                Dim sql As String
                con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\Scilla10.mdb"
                con.Open()
                Dim ds2 As New DataSet

                sql = "SELECT * FROM Muestras WHERE IdProyecto = " & idproyectoselected
                Dim da2 = New OleDb.OleDbDataAdapter(sql, con)
                da2.Fill(ds2, "Tabla")

                Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(da2)
                da2.DeleteCommand = oledbCmdBuilder.GetDeleteCommand()

                Dim rowsfound As Integer = ds2.Tables("Tabla").Rows.Count - 1
                For rowdeleted As Integer = 0 To rowsfound
                    ds2.Tables("Tabla").Rows(0).Delete()
                    da2.Update(ds2.Tables("Tabla"))
                    ds2.AcceptChanges()
                Next
                MsgBox("Muestras asociadas al proyecto borradas exitosamente")
                'BORRA EL PROYECTO DE LA TABLA PROYECTOS
                ProyectosBindingSource.RemoveCurrent()
                ProyectosTableAdapter.Update(Scilla10DataSet.Proyectos)
                MsgBox("Proyecto borrado exitosamente")
                con.Close()
            End If
        Else
            MsgBox("Se vació el contenido de las muestras, pero no se borraron los datos de las muestras en sí. Se mantuvo el proyecto.")
        End If
    End Sub

    Private Sub ProyectosDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProyectosDataGridView.CellContentDoubleClick
        TabDock.SelectedTab = PageMuestras
    End Sub

    Private Sub btnSeleccionarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguienteProyectos.Click
        PageMuestras.TabVisible = True
        PageProyectos.TabVisible = False
        TabDock.SelectedTab = PageMuestras
        CargarMuestrasProyecto()
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////
    '//////////////////////// TAB DE MUESTRAS
    '////////////////////////
    '////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////

    Dim j As Integer
    Dim tipoproyecto As String
    Dim nombreproyecto As String

    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// Carga de muestras en el proyecto
    '////////////////////////////////////////////////////////////////////////

    Private Sub CargarMuestrasProyecto()

        j = ProyectosDataGridView.CurrentRow.Index
        idproyectoselected = CInt(ProyectosDataGridView.Item(0, j).Value.ToString)
        tipoproyecto = ProyectosDataGridView.Item(4, j).Value.ToString
        nombreproyecto = ProyectosDataGridView.Item(1, j).Value.ToString

        MuestrasTableAdapter.qryMuestrasByProyecto(Scilla10DataSet.Muestras, idproyectoselected)

        MuestrasDataGridView.Refresh()
        MuestrasDataGridView.Sort(MuestrasDataGridView.Columns("IdMuestra"), System.ComponentModel.ListSortDirection.Ascending)
        NombreLabel2.Visible = True

        ' CARGA LOS TILES DEPENDIENDO DE LOS MODULOS ACTIVADOS
        Dim moduloscon As New OleDb.OleDbConnection
        Dim modulosSQL As String
        moduloscon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\config.mdb"
        moduloscon.Open()

        Dim modulosds As New DataSet
        modulosSQL = "SELECT * FROM Modulos"
        Dim modulosda = New OleDb.OleDbDataAdapter(modulosSQL, moduloscon)
        modulosda.Fill(modulosds, "Tablamodulos")

        ' RECORRO LOS MODULOS DE LA CONFIGURACION
        ' PARA LOS QUE ESTAN HABILITADOS, HAGO VISIBLE EL TILE
        Dim modulocodigo As String
        For i = 0 To modulosds.Tables("Tablamodulos").Rows.Count - 1
            modulocodigo = modulosds.Tables("Tablamodulos").Rows(i).Item("codigo").ToString
            If modulosds.Tables("Tablamodulos").Rows(i).Item("habilitado") = True Then
                'Hace una tile para ese modulo
                Dim modulotile As New C1.Win.C1Tile.Tile
                'Tile.NAME = codigo
                'Tile.TEXT = Nombre (bonito)
                'Tile.Text1 = Tipo de modulo (DatosSimples, otro)
                modulotile.Name = modulocodigo
                modulotile.Text = modulosds.Tables("Tablamodulos").Rows(i).Item("nombre").ToString
                modulotile.Text1 = modulosds.Tables("Tablamodulos").Rows(i).Item("Tipo").ToString
                'los logos van en la carpeta images\icons
                Dim logoname As String = modulosds.Tables("Tablamodulos").Rows(i).Item("logo").ToString
                Dim pathlogo As String = pathapp & "\images\icons\" & logoname

                If logoname <> "" Then
                    Dim bm_source As New Bitmap(pathlogo)
                    Dim bm_dest As New Bitmap(30, 30)
                    Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
                    gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1)
                    modulotile.Image = bm_dest
                End If
                modulotile.HorizontalSize = 3
                modulotile.VerticalSize = 2
                AddHandler modulotile.Click, AddressOf modulotile_Click
                TileMuestras.Groups(0).Tiles.Add(modulotile)
            End If
        Next
        moduloscon.Close()

        If MuestrasDataGridView.Rows.Count > 0 Then
            CargaPresencias(MuestrasDataGridView.Item("IdMuestra", 0).Value.ToString)
        End If
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// Controla el click de las tiles
    '////////////////////////////////////////////////////////////////////////

    Private Sub modulotile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim modulo = DirectCast(sender, C1.Win.C1Tile.Tile)
        Dim moduloname = modulo.Name
        Dim modulonombrelindo = modulo.Text
        Dim modulotipo = modulo.Text1
        Dim k As Integer

        'Si no hay muestras, cancela el sub y manda un error
        If MuestrasDataGridView.Rows.Count = 0 Then
            MsgBox("No hay muestras en el proyecto aún. Debe agregar primero la muestras y después podrá agregar los datos de cada muestra")
            Exit Sub
        End If


        k = MuestrasDataGridView.CurrentRow.Index
        Dim idmuestraactual As String = Convert.ToInt32(MuestrasDataGridView.Item(0, k).Value.ToString)

        If modulotipo.Contains("DatosSimples") Then
            frmDatosSimple.RecibirVariables(moduloname, modulonombrelindo, idproyectoselected, tipoproyecto, nombreproyecto, idmuestraactual)
            frmDatosSimple.Show()
        ElseIf modulotipo.Contains("DatosTaxones") Then
            Dim dbname As String
            Dim dbtabla As String
            Dim modulotipoarray As String() = modulotipo.Split(";")
            dbname = modulotipoarray(1)
            dbtabla = modulotipoarray(2)

            Dim newtreeview As TreeView = CType(Me.Controls("treeview" & dbname), TreeView)

            frmDatosTaxones.RecibirVariables(tipoproyecto, idproyectoselected, nombreproyecto, idmuestraactual, newtreeview, dbname, dbtabla)
            frmDatosTaxones.Show()
        End If

    End Sub

    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// Botón de volver a Proyectos
    '////////////////////////////////////////////////////////////////////////

    Private Sub btnVolverAProyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverAProyectos.Click
        VolverAProyectos()
    End Sub

    Private Sub VolverAProyectos()
        Dim colcount As Integer = MuestrasDataGridView.ColumnCount - 7
        For numit As Integer = 0 To colcount
            Dim colname As String = MuestrasDataGridView.Columns(6).Name
            MuestrasDataGridView.Columns.Remove(colname)
        Next

        Dim tilecount As Integer = TileMuestras.Groups(0).Tiles.Count - 1
        For colit As Integer = 0 To tilecount
            Dim tilename As String = TileMuestras.Groups(0).Tiles(0).Name
            TileMuestras.Groups(0).Tiles.Remove(tilename)
        Next

        PageProyectos.TabVisible = True
        PageMuestras.TabVisible = False
        TabDock.SelectedTab = PageProyectos
        Me.ProyectosTableAdapter.Fill(Me.Scilla10DataSet.Proyectos)
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// Carga de Nuevas muestras en el proyecto
    '////////////////////////////////////////////////////////////////////////

    Private Sub btnNuevaMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaMuestra.Click
        grpAgregarMuestra.Visible = True
        txtNombreMuestra.Text = ""
        AutorTextBox.Text = ""
        txtFechaMuestra.Text = DateAndTime.Today
        btnCancelarNuevaMuestra.Visible = True
        btnAgregarMultiples.Visible = True

        btnGuardarMuestra.Visible = True
        btnNuevaMuestra.Visible = False
        btnExportarDatos.Visible = False
        btnImportarDatos.Visible = False
        btnCalcularIndices.Visible = False

        TileMuestras.Visible = False

        MuestrasDataGridView.ClearSelection()
        MuestrasDataGridView.Visible = False
    End Sub
    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// CANCELAR Carga de Nuevas muestras en el proyecto
    '////////////////////////////////////////////////////////////////////////

    Private Sub btnCancelarNuevaMuestra_Click(sender As Object, e As EventArgs) Handles btnCancelarNuevaMuestra.Click
        'Cancela
        dgvMultiplesMuestras.Visible = False
        lblNombreMuestra.Visible = True
        lblCodigoSitio.Visible = True
        lblFecha.Visible = True
        txtFechaMuestra.Visible = True
        txtNombreMuestra.Visible = True
        txtFechaMuestra.Visible = True
        CodigoSitioComboBox.Visible = True
        btnEditarSitios.Visible = True

        grpAgregarMuestra.Visible = False
        MuestrasDataGridView.Visible = True
        btnGuardarMuestra.Visible = False
        btnNuevaMuestra.Visible = True
        btnExportarDatos.Visible = True
        btnImportarDatos.Visible = True
        btnCancelarNuevaMuestra.Visible = False
        btnCalcularIndices.Visible = True
        TileMuestras.Visible = True


    End Sub

    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// Guardar Nuevas muestras en el proyecto
    '////////////////////////////////////////////////////////////////////////

    Private Sub btnGuardarMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarMuestra.Click
        'SI ES UNA SOLA MUESTRA.
        If dgvMultiplesMuestras.Visible = False Then
            ' SI EL CAMPO NOMBRE ESTA VACIO, CANCELA Y SALE
            If txtNombreMuestra.Text = "" Or txtNombreMuestra.Text = " " Then
                MsgBox("Debe ponerle nombre a la muestra")
                Exit Sub
            Else
                Dim nombremuestra As String = txtNombreMuestra.Text
                Dim nombreautor As String = AutorTextBox.Text
                Dim fecha As String = txtFechaMuestra.Text
                Dim codigositio As String = txtCodigoSitio.Text

                Dim nrow As DataRowView = DirectCast(MuestrasBindingSource.AddNew(), DataRowView)

                nrow("Nombre") = nombremuestra
                nrow("Autor") = nombreautor
                nrow("IdProyecto") = idproyectoselected
                nrow("Fecha") = fecha
                nrow("CodigoSitio") = codigositio

                ' GUARDA
                MuestrasBindingSource.EndEdit()
                MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

                'RECARGA ADAPTADOR MUESTRAS
                MuestrasTableAdapter.qryMuestrasByProyecto(Scilla10DataSet.Muestras, idproyectoselected)
                MuestrasDataGridView.Refresh()
                MuestrasBindingSource.MoveLast()

            End If

            ' SI SON MULTIPLES MUESTRAS
        ElseIf dgvMultiplesMuestras.Visible = True Then
            Dim nombresok As Boolean = True
            'Primero chequea que todas tengan nombre, sino cancela
            For i As Integer = 0 To dgvMultiplesMuestras.RowCount - 1
                If dgvMultiplesMuestras.Item(i, 0).ToString = "" Then
                    MsgBox("Hay muestras que no tienen nombre. Todas las muestras a agregar deben tener nombre")
                    Exit Sub
                End If
            Next
            'Despues genera tantas nuevas rows como rows en dgvMultiplesMuestras
            For j As Integer = 0 To dgvMultiplesMuestras.RowCount - 1
                Dim nombremuestra As String = dgvMultiplesMuestras.Item(j, 0).ToString
                Dim fecha As String = dgvMultiplesMuestras.Item(j, 1).ToString
                If fecha = "" Then
                    fecha = Date.Today
                End If

                Dim codigositio As String = dgvMultiplesMuestras.Item(j, 2).ToString
                Dim nombreautor As String = AutorTextBox.Text

                MuestrasBindingSource.AddNew()
                MuestrasDataGridView.CurrentRow.Cells.Item("Nombre").Value = nombremuestra
                MuestrasDataGridView.CurrentRow.Cells.Item("Autor").Value = nombreautor
                MuestrasDataGridView.CurrentRow.Cells.Item("IdProyecto").Value = idproyectoselected
                MuestrasDataGridView.CurrentRow.Cells.Item("Fecha").Value = fecha
                MuestrasDataGridView.CurrentRow.Cells.Item("CodigoSitio").Value = codigositio

                ' GUARDA
                MuestrasBindingSource.EndEdit()
                MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

                'RECARGA ADAPTADOR MUESTRAS
                MuestrasTableAdapter.qryMuestrasByProyecto(Scilla10DataSet.Muestras, idproyectoselected)
                MuestrasDataGridView.Refresh()
                MuestrasBindingSource.MoveLast()
            Next
        End If

        'VUELVE A LA NORMALIDAD LA VISUAL
        grpAgregarMuestra.Visible = False
        btnCancelarNuevaMuestra.Visible = False
        btnGuardarMuestra.Visible = False
        btnNuevaMuestra.Visible = True
        btnExportarDatos.Visible = True
        btnImportarDatos.Visible = True
        MuestrasDataGridView.Visible = True
        btnCalcularIndices.Visible = True
        TileMuestras.Visible = True
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// Carga de MULTIPLES Nuevas muestras en el proyecto
    '////////////////////////////////////////////////////////////////////////

    Private Sub btnAgregarMultiples_Click(sender As Object, e As EventArgs) Handles btnAgregarMultiples.Click
        'Esconde lo que hay para una sola muestra y muestra la DGV
        dgvMultiplesMuestras.Visible = True
        dgvMultiplesMuestras.SetDataBinding()
        dgvMultiplesMuestras.Rows.Clear()
        lblNombreMuestra.Visible = False
        lblCodigoSitio.Visible = False
        lblFecha.Visible = False
        txtFechaMuestra.Visible = False
        txtNombreMuestra.Visible = False
        txtFechaMuestra.Visible = False
        CodigoSitioComboBox.Visible = False
        btnEditarSitios.Visible = False
        btnAgregarMultiples.Visible = False

        lblAddMuestras.Visible = True
        numAddMuestras.Visible = True
    End Sub


    Private Sub numAddMuestras_ValueChanged(sender As Object, e As EventArgs) Handles numAddMuestras.ValueChanged
        Dim varmuestrasiniciales As Integer = numAddMuestras.Value
        Dim numrows As Integer = dgvMultiplesMuestras.RowCount
        Dim diferenciarows As Integer = varmuestrasiniciales - numrows
        'AGREGA ROWS SI FALTAN
        If numrows < varmuestrasiniciales Then
            For i As Integer = 0 To varmuestrasiniciales
                dgvMultiplesMuestras.Rows.Add()
                dgvMultiplesMuestras.Item(dgvMultiplesMuestras.RowCount - 1, 0) = "Muestra " & dgvMultiplesMuestras.RowCount
                If numAddMuestras.Value = dgvMultiplesMuestras.Rows.Count Then
                    Exit Sub
                End If
            Next
        End If

        'SACA ROWS SI SOBRAN
        If numrows > varmuestrasiniciales Then
            For i As Integer = 0 To dgvMuestrasIniciales.Rows.Count
                dgvMultiplesMuestras.Rows.RemoveAt(dgvMultiplesMuestras.RowCount - 1)
                If numAddMuestras.Value = dgvMultiplesMuestras.Rows.Count Then
                    Exit Sub
                End If
            Next
        End If
    End Sub



    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// PEGAR Multiples muestras en el proyecto
    '////////////////////////////////////////////////////////////////////////

    Private Sub dgvMultiplesMuestras_KeyPaste(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvMultiplesMuestras.KeyDown
        If e.KeyCode = Keys.V And Keys.ControlKey Then
            PasteData(dgvMultiplesMuestras)
        End If

    End Sub

    Private Sub btnEditarSitios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarSitios.Click

        Dim abrirformsitios As New frmSitios

        ' Show testDialog as a modal dialog and determine if DialogResult = OK. 
        If abrirformsitios.ShowDialog(Me) = System.Windows.Forms.DialogResult.Cancel Then
            Me.SitiosTableAdapter.Fill(Me.SitiosDataSet.Sitios)
        Else
            MsgBox("Error recargando la lista de sitios")
        End If
        abrirformsitios.Dispose()
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// NUEVO CHEQUEADOR DE DATOS EXISTENTES, para cada muestra individual (CargaPresencias)
    '////////////////////////////////////////////////////////////////////////

    Private Sub MuestrasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MuestrasDataGridView.CellClick
        Dim idmuestracargar As String = MuestrasDataGridView.CurrentRow.Cells("IdMuestra").Value.ToString
        CargaPresencias(idmuestracargar)
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '//////////////////////// Carga de presencia de datos para la muestra en el proyecto, A PARTIR DE UN IDMUESTRA
    '////////////////////////////////////////////////////////////////////////

    Private Sub CargaPresencias(idmuestracargar As String)
        For Each tile In TileMuestras.Groups(0).Tiles
            'Tile.NAME = codigo
            'Tile.TEXT = Nombre (bonito)
            'Tile.Text1 = Tipo de modulo (DatosSimples, otro)

            Dim moduloname As String = tile.Name
            ' SE FIJA SI SON DATOS SIMPLES 
            If tile.Text1 = "DatosSimples" Then
                Dim con As New OleDb.OleDbConnection
                Dim sql As String
                Dim ds As New DataSet

                con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & moduloname & ".mdb"
                con.Open()
                sql = "SELECT * FROM Parametros" & moduloname & " WHERE IdMuestra = '" & idmuestracargar & "'"
                Dim da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(ds, "Tabla")

                If ds.Tables("Tabla").Rows.Count = 1 Then
                    tile.Checked = True
                ElseIf ds.Tables("Tabla").Rows.Count = 0 Then
                    tile.Checked = False
                End If
                con.Close()

                'SI NO SON DATOS SIMPLES
            Else
                'busca el codigo del tile
                Dim modulocodigo As String = tile.Name
                'conecta a la DB TaxonesMuestras
                Dim con1 As New OleDb.OleDbConnection
                Dim sql1 As String
                Dim ds1 As New DataSet
                con1.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
                con1.Open()
                sql1 = "SELECT * FROM " & modulocodigo & " WHERE IdMuestra = '" & idmuestracargar & "'"
                Dim da1 = New OleDb.OleDbDataAdapter(sql1, con1)
                da1.Fill(ds1, "Tabla1")

                If ds1.Tables("Tabla1").Rows.Count = 1 Then
                    tile.Checked = True
                ElseIf ds1.Tables("Tabla1").Rows.Count = 0 Then
                    tile.Checked = False
                End If
                con1.Close()
            End If
        Next
    End Sub


    Private Sub btnExportarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarDatos.Click
        If tipoproyecto = "ArroyoPamp" Then
            frmExport.RecibirVariables(idproyectoselected, tipoproyecto, nombreproyecto)
            frmExport.Show()
        End If
    End Sub


    Private Sub btnImportarDatos_Click(sender As Object, e As EventArgs) Handles btnImportarDatos.Click
        frmImportar.Show()
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////
    '//////////////////////// BARRA DE NAVEGACION
    '////////////////////////
    '////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////

    Private Sub SalirAWindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirAWindowsToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EnciclopediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnciclopediaToolStripMenuItem.Click
        frmEnciclopedia.Show()
    End Sub

    Private Sub PerfilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerfilToolStripMenuItem.Click
        frmConfigPerfil.ShowDialog()
    End Sub


    Private Sub EditorDeParámetrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeParámetrosToolStripMenuItem.Click
        frmDBParametros.Show()
    End Sub

    Private Sub MódulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MódulosToolStripMenuItem.Click
        frmConfigModulos.Show()
    End Sub


    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////
    '//////////////////////// TAB DE CALCULOS
    '////////////////////////
    '////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////

    Private Sub btnCalcularIndices_Click(sender As Object, e As EventArgs) Handles btnCalcularIndices.Click
        'Si no hay muestras, cancela el sub y manda un error
        If MuestrasDataGridView.Rows.Count = 0 Then
            MsgBox("No hay muestras en el proyecto aún. Debe agregar primero la muestras, después podrá agregar los datos de cada muestra, que permitirán los cálculos de los índices")
            Exit Sub
        End If

        PageCalculos.TabVisible = True
        PageMuestras.TabVisible = False
        TabDock.SelectedTab = PageCalculos
        CargarCalculos()
    End Sub


    Dim dgvMuestrasCalculosTemp As New DataGridView

    Private Sub CargarCalculos()
        'Genera un listado de muestras en la dgvMuestrasCalculosTemp
        Dim colIdmuestra As New DataGridViewTextBoxColumn
        colIdmuestra.Name = "IdMuestra"
        colIdmuestra.HeaderText = "IdMuestra"
        Dim colNombremuestra As New DataGridViewTextBoxColumn
        colNombremuestra.Name = "Nombre"
        colNombremuestra.HeaderText = "Nombre"

        dgvMuestrasCalculosTemp.Columns.Add(colIdmuestra)
        dgvMuestrasCalculosTemp.Columns.Add(colNombremuestra)

        For i As Integer = 0 To MuestrasDataGridView.RowCount - 1
            Dim idmuestragregar As String = MuestrasDataGridView.Item("IdMuestra", i).Value
            Dim nombremuestragregar As String = MuestrasDataGridView.Item("Nombre", i).Value
            dgvMuestrasCalculosTemp.Rows.Add()
            dgvMuestrasCalculosTemp.Item("IdMuestra", i).Value = idmuestragregar
            dgvMuestrasCalculosTemp.Item("Nombre", i).Value = nombremuestragregar
        Next

        'CARGA LAS TILES DEPENDIENDO DE LOS INDICES HABILITADOS PARA ESTE TIPO DE PROYECTO
        Dim calculocon As New OleDb.OleDbConnection
        Dim calculoSQL As String
        calculocon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\config.mdb"
        calculocon.Open()

        Dim calculods As New DataSet
        calculoSQL = "SELECT * FROM Calculos"
        Dim modulosda = New OleDb.OleDbDataAdapter(calculoSQL, calculocon)
        modulosda.Fill(calculods, "Tablacalculos")


        'HAGO LOS DOS GRANDES GRUPOS
        Dim newgroup As New C1.Win.C1Tile.Group
        newgroup.Name = "grpIndices"
        newgroup.Text = "Índices bióticos"


        Dim newgroup1 As New C1.Win.C1Tile.Group
        newgroup1.Name = "grpEcologicos"
        newgroup1.Text = "Índices ecológicos"
        TileCalculos.Groups.Add(newgroup)
        TileCalculos.Groups.Add(newgroup1)

        ' RECORRO LOS MODULOS DE LA CONFIGURACION
        ' PARA LOS QUE ESTAN HABILITADOS, HAGO VISIBLE EL TILE
        Dim calculocodigo As String
        For i = 0 To calculods.Tables("Tablacalculos").Rows.Count - 1
            calculocodigo = calculods.Tables("Tablacalculos").Rows(i).Item("codigo").ToString

            'SE FIJA SI EL TILE ES APTO PARA ESTE AMBIENTE
            'para eso primero parte la array "Ambiente" y recorre cada valor
            Dim tipoproyectocalcular As String = tipoproyecto
            Dim ambientearray() As String = (calculods.Tables("Tablacalculos").Rows(i).Item("Ambientes").ToString).Split(";")

            If ambientearray.Contains(tipoproyectocalcular) Then
                If calculods.Tables("Tablacalculos").Rows(i).Item("Activado") = True Then
                    'Hace una tile para ese modulo
                    Dim calculotile As New C1.Win.C1Tile.Tile
                    'Tile.NAME = codigo
                    'Tile.TEXT = Nombre (bonito)
                    'Tile.Text2 = script
                    'Tile.Text3 = Ambientes
                    calculotile.Template = TemplateTiles
                    Dim tilename As String
                    If calculods.Tables("Tablacalculos").Rows(i).Item("Codigo").ToString.Contains("_") Then
                        Dim tilenamearray As String()
                        tilenamearray = calculods.Tables("Tablacalculos").Rows(i).Item("Codigo").ToString.Split("_")
                        tilename = StrConv(tilenamearray(0), VbStrConv.ProperCase) & " (" & StrConv(tilenamearray(1), VbStrConv.ProperCase) & ")"
                        calculotile.Template = TemplateTileSmall
                        calculotile.Text = tilename
                    Else
                        tilename = calculods.Tables("Tablacalculos").Rows(i).Item("Codigo").ToString.ToUpper
                        calculotile.Text = tilename
                    End If
                    calculotile.Name = calculocodigo
                    calculotile.Text1 = calculods.Tables("Tablacalculos").Rows(i).Item("Nombre").ToString
                    calculotile.ToolTipText = calculods.Tables("Tablacalculos").Rows(i).Item("Nombre").ToString
                    calculotile.Text2 = calculods.Tables("Tablacalculos").Rows(i).Item("script").ToString
                    calculotile.Text3 = calculods.Tables("Tablacalculos").Rows(i).Item("Ambientes").ToString
                    calculotile.HorizontalSize = 3
                    calculotile.VerticalSize = 1
                    calculotile.Checked = True

                    If calculods.Tables("Tablacalculos").Rows(i).Item("Categoria").ToString = "Indice" Then
                        calculotile.BackColor = Color.FromArgb(23, 108, 156)
                        TileCalculos.Groups("grpIndices").Tiles.Add(calculotile)

                    ElseIf calculods.Tables("Tablacalculos").Rows(i).Item("Categoria").ToString = "Ecologico" Then
                        calculotile.BackColor = Color.FromArgb(4, 52, 79)
                        TileCalculos.Groups("grpEcologicos").Tiles.Add(calculotile)
                    End If
                End If
            End If
        Next
        calculocon.Close()

    End Sub
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////
    '//////////////////////// PROCEDIMIENTO DE CALCULOS: todo a una dgv temporal que despues se pasa a frmResultados
    '////////////////////////
    '////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    Private Sub btnCalcularSeleccionados_Click(sender As Object, e As EventArgs) Handles btnCalcularSeleccionados.Click
        ' Limpia la datagrid y resetea la progressbar
        For i = dgvMuestrasCalculosTemp.Columns.Count - 1 To 0 Step -1
            If dgvMuestrasCalculosTemp.Columns(i).Name <> "IdMuestra" And dgvMuestrasCalculosTemp.Columns(i).Name <> "Nombre" Then
                dgvMuestrasCalculosTemp.Columns.RemoveAt(i)
            End If
        Next
        pgbCalculoIndices.Visible = True
        pgbCalculoIndices.Value = 0
        pgbCalculoIndices.Maximum = dgvMuestrasCalculosTemp.Rows.Count * dgvMuestrasCalculosTemp.Columns.Count


        'GENERA COLUMNAS DE TODAS LAS TILES QUE ESTAN CHEQUEADAS
        For Each tile In TileCalculos.Groups("grpIndices").Tiles
            If tile.Checked = True Then
                'col.Name = codigo del indice
                'col.HeaderText = Nombre bonito
                'col.tooltiptext = script a utilizar
                Dim newcol As New DataGridViewTextBoxColumn
                newcol.Name = tile.Name
                newcol.HeaderText = tile.Text
                newcol.ToolTipText = tile.Text2
                dgvMuestrasCalculosTemp.Columns.Add(newcol)
            End If
        Next

        For Each tile In TileCalculos.Groups("grpEcologicos").Tiles
            If tile.Checked = True Then
                'col.Name = codigo del indice
                'col.HeaderText = Nombre bonito
                'col.tooltiptext = script a utilizar
                Dim newcol As New DataGridViewTextBoxColumn

                newcol.Name = tile.Name
                newcol.HeaderText = tile.Text
                newcol.ToolTipText = tile.Text2

                Dim ecologiconame As String = newcol.Name
                Dim ecologicoletra As String = ecologiconame.Substring(0, 1)

                Dim Ecologicocon As New OleDb.OleDbConnection
                Dim Ecologicods As New DataSet
                Dim EcologicoSQL As String
                Ecologicocon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\" & ecologiconame & ".mdb"
                Ecologicocon.Open()
                EcologicoSQL = "SELECT * FROM Carac" & ecologiconame
                Dim Ecologicoda = New OleDb.OleDbDataAdapter(EcologicoSQL, Ecologicocon)
                Ecologicoda.Fill(Ecologicods, "TablaEcologico")

                'Para cada variable a la cual debe calcular el Ecologico, recorre el metodo
                For i = 0 To Ecologicods.Tables("TablaEcologico").Rows.Count - 1
                    Dim colretur As New DataGridViewTextBoxColumn
                    colretur.Name = ecologiconame & " - " & Ecologicods.Tables("TablaEcologico").Rows(i).Item("variable").ToString
                    colretur.HeaderText = ecologiconame & " - " & Ecologicods.Tables("TablaEcologico").Rows(i).Item("nombre").ToString
                    colretur.ToolTipText = tile.Text2
                    dgvMuestrasCalculosTemp.Columns.Add(colretur)
                Next
                Ecologicocon.Close()
            End If
        Next

        'INVOCA LA FUNCION DE CADA INDICE DE MANERA DINAMICA 
        Dim idproyectocalcular As String = idproyectoselected
        For i As Integer = 0 To dgvMuestrasCalculosTemp.Rows.Count - 1
            Dim idmuestracalcular As String = dgvMuestrasCalculosTemp.Rows(i).Cells("IdMuestra").Value
            For j As Integer = 2 To dgvMuestrasCalculosTemp.Columns.Count - 1
                'SI TIENE LOS CARACTERES " - " ES UN ECOLOGICO
                If dgvMuestrasCalculosTemp.Columns(j).Name.Contains(" - ") Then
                    'Calculo del indice
                    Dim nombrecol As String = dgvMuestrasCalculosTemp.Columns(j).Name.ToString
                    Dim corte As String = " - "
                    Dim x As Integer = InStr(nombrecol, corte)
                    Dim nombreecologico As String = nombrecol.Substring(0, x - 1)
                    Dim nombrevariable As String = nombrecol.Substring(x + corte.Length - 1)
                    Dim mType As Type = Type.GetType("Scila7." & nombreecologico)
                    Dim scriptname As String = dgvMuestrasCalculosTemp.Columns(j).ToolTipText.ToString
                    If mType IsNot Nothing Then
                        Dim mMethod As MethodInfo = mType.GetMethod(scriptname)
                        Dim mValue As Object = mMethod.Invoke(mType, New Object() {idmuestracalcular, idproyectocalcular, nombrevariable})
                        dgvMuestrasCalculosTemp.Item(j, i).Value = mValue

                        'Traducción del indice ECOLOGICO
                        'llama al script para traducir el nombre del taxon
                        Dim scripttranslatename As String = "Traduce" & nombrecol.ToUpper
                        Dim traducciontaxon As String = ""
                        Dim mTypeTranslate As Type = Type.GetType("Scila7." & nombrecol)
                        If mTypeTranslate IsNot Nothing And mValue IsNot Nothing Then
                            Dim mMethodTranslate As MethodInfo = mTypeTranslate.GetMethod(scripttranslatename)
                            Dim mValueTranslate As Object = mMethodTranslate.Invoke(mTypeTranslate, New Object() {mValue.ToString})
                            traducciontaxon = mValueTranslate
                        Else
                            traducciontaxon = ""
                        End If

                        If traducciontaxon <> "" Then
                            Dim traduccion As String() = traducciontaxon.Split(";")
                            If traduccion(1) = "Rojo" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Red
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Naranja" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Orange
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Amarillo" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Yellow
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Verde" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Green
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Azul" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Blue
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.White
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Negro" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.White
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Gris" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.LightGray
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            End If
                        Else
                            dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.LightGray
                            dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                            dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = "Sin datos"
                        End If
                    Else
                        Continue For
                    End If
                Else
                    'SI NO TIENE LOS CARACTERES " - " ES UN INDICE
                    'Calculo del indice
                    Dim nombrecol As String = dgvMuestrasCalculosTemp.Columns(j).Name.ToString
                    Dim mType As Type = Type.GetType("Scila7." & nombrecol)
                    Dim scriptname As String = dgvMuestrasCalculosTemp.Columns(j).ToolTipText.ToString
                    If mType IsNot Nothing Then
                        Dim mMethod As MethodInfo = mType.GetMethod(scriptname)
                        Dim mValue As Object = mMethod.Invoke(mType, New Object() {idmuestracalcular, idproyectocalcular})
                        dgvMuestrasCalculosTemp.Item(j, i).Value = mValue

                        'Traducción del indice BIOLOGICO
                        'llama al script para traducir el nombre del taxon
                        Dim scripttranslatename As String = "Traduce" & scriptname.ToUpper.Remove(0, 8)
                        Dim traducciontaxon As String = ""
                        Dim mTypeTranslate As Type = Type.GetType("Scila7." & nombrecol)
                        If mTypeTranslate IsNot Nothing And mValue IsNot Nothing Then
                            Dim mMethodTranslate As MethodInfo = mTypeTranslate.GetMethod(scripttranslatename)
                            Dim mValueTranslate As Object = mMethodTranslate.Invoke(mTypeTranslate, New Object() {mValue.ToString})
                            traducciontaxon = mValueTranslate
                        Else
                            traducciontaxon = ""
                        End If

                        'PONE COLORES
                        If traducciontaxon <> "" Then
                            Dim traduccion As String() = traducciontaxon.Split(";")
                            If traduccion(1) = "Rojo" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Red
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Naranja" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Orange
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Amarillo" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Yellow
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Verde" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Green
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Azul" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Blue
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.White
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Negro" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.White
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            ElseIf traduccion(1) = "Gris" Then
                                dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.LightGray
                                dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                                dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = traduccion(2)
                            End If
                        Else
                            dgvMuestrasCalculosTemp.Item(j, i).Style.BackColor = Color.LightGray
                            dgvMuestrasCalculosTemp.Item(j, i).Style.ForeColor = Color.Black
                            dgvMuestrasCalculosTemp.Item(j, i).ToolTipText = "Sin datos"
                        End If
                    Else
                        Continue For
                    End If
                End If
            Next
            pgbCalculoIndices.Value = pgbCalculoIndices.Value + 2
        Next

        '////////////////////////////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////
        'Una vez que ya calculo todo, divide las columnas que tengan datos con el caracter ";" en columnas separadas
        Dim coladividir As Integer
        Dim nombrecoladividir As String
        Dim cantidadadividir As Integer
        Dim coldivisible As Boolean = False

        For jj As Integer = dgvMuestrasCalculosTemp.Columns.Count - 1 To 0 Step -1
            For i As Integer = 0 To dgvMuestrasCalculosTemp.Rows.Count - 1
                If Not dgvMuestrasCalculosTemp.Item(jj, i).Value Is Nothing Then
                    If dgvMuestrasCalculosTemp.Item(jj, i).Value.ToString.Contains(";") Then
                        coladividir = jj
                        nombrecoladividir = dgvMuestrasCalculosTemp.Columns(jj).HeaderText
                        cantidadadividir = dgvMuestrasCalculosTemp.Item(jj, i).Value.ToString.Split(";").Length - 1
                        For m As Integer = 0 To cantidadadividir
                            If Not dgvMuestrasCalculosTemp.Columns.Contains(nombrecoladividir & " -" & m) Then
                                Dim col As New DataGridViewColumn
                                Dim nombrecoladividir1 = nombrecoladividir.Trim(")")
                                nombrecoladividir1 = nombrecoladividir1.Replace(" (", "_")
                                Dim nombreparte1 As String() = nombrecoladividir1.Split("_")
                                col = dgvMuestrasCalculosTemp.Columns(nombrecoladividir1).Clone
                                col.Name = nombrecoladividir1 & " -" & m
                                col.HeaderText = nombrecoladividir & " -" & m
                                dgvMuestrasCalculosTemp.Columns.Insert(jj + m + 1, DirectCast(col.Clone, DataGridViewColumn))
                            End If
                        Next
                        coldivisible = True
                    End If
                End If
            Next
        Next

        '////////////////////////////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////

        ' Y divide las celdas qe tengan ; en las columnas recien generadas
        Dim colsaborrar As String() = {}
        For jjj As Integer = 0 To dgvMuestrasCalculosTemp.Columns.Count - 1
            'For jjj = dgvMuestrasCalculosTemp.Columns.Count - 1 To 0 Step -1
            For i As Integer = 0 To dgvMuestrasCalculosTemp.Rows.Count - 1
                If Not dgvMuestrasCalculosTemp.Item(jjj, i).Value Is Nothing Then
                    If dgvMuestrasCalculosTemp.Item(jjj, i).Value.ToString.Contains(";") Then
                        'si tiene ";"
                        Dim valorarray As String() = dgvMuestrasCalculosTemp.Item(jjj, i).Value.ToString.Split(";")
                        Dim nombrecol As String = dgvMuestrasCalculosTemp.Columns(jjj).Name
                        dgvMuestrasCalculosTemp.Item(nombrecol & " -0", i).Value = valorarray(0)
                        For m As Integer = 1 To valorarray.Length - 1
                            dgvMuestrasCalculosTemp.Item(nombrecol & " -" & m, i).Value = valorarray(m)
                        Next

                        ' y agrega a una array la lista de nombres de las columnas a borrar. No es lo mas elegante pero funciona
                        Array.Resize(colsaborrar, colsaborrar.Length + 1)
                        colsaborrar(colsaborrar.Length - 1) = nombrecol
                    Else
                        'si no tiene ";"
                        dgvMuestrasCalculosTemp.Item(jjj, i).Value = dgvMuestrasCalculosTemp.Item(jjj, i).Value
                    End If
                End If
            Next
        Next

        'borra las cols que tenian los valores originales con ;, del listado cargado en la array
        For i = 0 To colsaborrar.Length - 1
            If dgvMuestrasCalculosTemp.Columns.Contains(colsaborrar(i)) Then
                dgvMuestrasCalculosTemp.Columns.Remove(colsaborrar(i))
            End If
        Next

        ' Busca las cols vacias y las borra
        Dim colvacia As Boolean = True
        Dim colsaborrar1 As String() = {}
        For jjj = dgvMuestrasCalculosTemp.Columns.Count - 1 To 0 Step -1
            colvacia = True
            For i As Integer = 0 To dgvMuestrasCalculosTemp.Rows.Count - 1
                If Not dgvMuestrasCalculosTemp.Item(jjj, i).Value Is Nothing Then
                    ' si la col no esta vacia
                    colvacia = False
                    Continue For
                End If
            Next
            If colvacia = True Then
                dgvMuestrasCalculosTemp.Columns.RemoveAt(jjj)
            End If
        Next

        '////////////////////////////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////
        'Muestra los resultados en un form aparte
        frmResultadosCalcular.RecibirVariables(idproyectoselected, tipoproyecto, nombreproyecto, dgvMuestrasCalculosTemp)
        frmResultadosCalcular.Show()
        pgbCalculoIndices.Visible = False
    End Sub

    Private Sub btnVolverAProyectos1_Click(sender As Object, e As EventArgs) Handles btnVolverAProyectos1.Click
        TileCalculos.Groups.Remove("grpIndices")
        TileCalculos.Groups.Remove("grpEcologicos")

        dgvMuestrasCalculosTemp.Rows.Clear()
        dgvMuestrasCalculosTemp.Columns.Clear()
        pgbCalculoIndices.Maximum = 0
        PageMuestras.TabVisible = True
        PageCalculos.TabVisible = False

        VolverAProyectos()
    End Sub

    Private Sub btnVolverAMuestras_Click(sender As Object, e As EventArgs) Handles btnVolverAMuestras.Click
        TileCalculos.Groups.Remove("grpIndices")
        TileCalculos.Groups.Remove("grpEcologicos")

        dgvMuestrasCalculosTemp.Rows.Clear()
        dgvMuestrasCalculosTemp.Columns.Clear()
        pgbCalculoIndices.Maximum = 0
        PageMuestras.TabVisible = True
        PageCalculos.TabVisible = False
        TabDock.SelectedTab = PageMuestras
    End Sub

    Private Sub ConversorDeUnidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversorDeUnidadesToolStripMenuItem.Click
        frmConversor.Show()
    End Sub

    Private Sub ProyectosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ProyectosDataGridView.CurrentRow.Selected = True

    End Sub

    Private Sub VaciarProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VaciarProyectoToolStripMenuItem.Click
        If Not ProyectosDataGridView.RowCount = 1 Then
            If MessageBox.Show("Esta seguro de vaciar este proyecto? Se borraran todas los datos asociados a las muestras, de todos los módulos (habilitados o no), aunque se mantendrán las muestras y la estructura del proyecto", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                borrarProyecto(False)
            End If
        Else
            MsgBox("No hay proyectos que vaciar!")
        End If
    End Sub

    Private Sub EliminarProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProyectoToolStripMenuItem.Click
        If Not ProyectosDataGridView.RowCount = 1 Then
            If MessageBox.Show("Esta seguro de borrar este proyecto? Se borraran todas las muestras y sus datos asociados, de todos los módulos (habilitados o no)", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                borrarProyecto(True)
            End If
        Else
            MsgBox("No hay proyectos que borrar!")
        End If
    End Sub

    Private Sub ÓptimosYToleranciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÓptimosYToleranciasToolStripMenuItem.Click
        frmOptimosyTols.Show()
    End Sub
    Private Sub EditorDeÍndicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeÍndicesToolStripMenuItem.Click
        frmDBIndices.Show()
    End Sub


    Private Sub EditarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarDatosToolStripMenuItem.Click
        TabDock.SelectedTab = PageProyectos
        ' ESCONDE BOTONES INNECESARIOS Y MUESTRA NECESARIOS
        grpDatosdelProyecto.Visible = True
        ProyectosDataGridView.Visible = False
        btnNuevoProyecto.Visible = False
        btnGuardarProyecto.Visible = True
        btnSiguienteProyectos.Visible = False
        NombreTextBox.Enabled = True
        AutorTextBox.Enabled = True
        DescripcionTextBox.Enabled = True

    End Sub

    Private Sub btnSeleccionarTodosIndices_Click(sender As Object, e As EventArgs) Handles btnSeleccionarTodosIndices.Click
        If btnSeleccionarTodosIndices.Text = "Seleccionar todos" Then
            For i As Integer = 0 To TileCalculos.Groups(0).Tiles.Count - 1
                TileCalculos.Groups(0).Tiles(i).Checked = True
            Next
            For i As Integer = 0 To TileCalculos.Groups(1).Tiles.Count - 1
                TileCalculos.Groups(1).Tiles(i).Checked = True
            Next
            btnSeleccionarTodosIndices.Text = "Deseleccionar todos"
        Else
            TileCalculos.UncheckAllTiles()
            btnSeleccionarTodosIndices.Text = "Seleccionar todos"
        End If
    End Sub

End Class