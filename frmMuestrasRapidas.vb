Public Class frmMuestrasRapidas
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Private Sub frmMuestrasRapidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMuestrasProyecto()

    End Sub


    Private Sub CargarMuestrasProyecto()

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
                modulotile.VerticalSize = 1
                AddHandler modulotile.Click, AddressOf modulotile_Click
                TileMuestras.Groups(0).Tiles.Add(modulotile)

            End If
        Next
        moduloscon.Close()
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

        ''Si no hay muestras, cancela el sub y manda un error
        'If MuestrasDataGridView.Rows.Count = 0 Then
        '    MsgBox("No hay muestras en el proyecto aún. Debe agregar primero la muestras y después podrá agregar los datos de cada muestra")
        '    Exit Sub
        'End If


        ' k = MuestrasDataGridView.CurrentRow.Index
        ' Dim idmuestraactual As String = Convert.ToInt32(MuestrasDataGridView.Item(0, k).Value.ToString)

        Dim idproyectoselected, tipoproyecto, nombreproyecto, idmuestraactual
        idproyectoselected = "MuestraRapida"
        tipoproyecto = "MuestraRapida"
        nombreproyecto = "MuestraRapida"
        idmuestraactual = "MuestraRapida"

        If modulotipo.Contains("DatosSimples") Then
            frmDatosSimple.RecibirVariables(moduloname, modulonombrelindo, idproyectoselected, tipoproyecto, nombreproyecto, idmuestraactual)
            frmDatosSimple.Show()
        ElseIf modulotipo.Contains("DatosTaxones") Then
            Dim dbname As String
            Dim dbtabla As String
            Dim modulotipoarray As String() = modulotipo.Split(";")
            dbname = modulotipoarray(1)
            dbtabla = modulotipoarray(2)

            Dim newtreeview As TreeView = CType(frmPrincipal.Controls("treeview" & dbname), TreeView)

            frmDatosTaxones.RecibirVariables(tipoproyecto, idproyectoselected, nombreproyecto, idmuestraactual, newtreeview, dbname, dbtabla)
            frmDatosTaxones.Show()
        End If

    End Sub

End Class