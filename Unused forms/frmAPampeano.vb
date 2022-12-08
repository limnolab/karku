Public Class frmAPampeano
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim idproyecto As Integer = 0
    Dim idmuestra As Integer = 0
    Dim tipoproyecto As String = ""
    Dim nombreproyecto As String = ""
    Dim idmuestraactual As String = ""

    Dim tabamostrar As String = ""
    Dim macroinvhabilitado As Boolean = 0
    Dim diatomeashabilitado As Boolean = 0


    Public Sub RecibirVariables(ByVal id As Integer, ByVal tipo As String, ByVal nombre As String, ByVal muestrainicial As String)
        'RECIBO TIPO Y NUMERO DE PROYECTO DE FRMMAIN
        idproyecto = id
        tipoproyecto = tipo
        nombreproyecto = nombre
        idmuestraactual = muestrainicial
    End Sub

    Public Sub CargarTabs(ByVal tab As String)
        tabamostrar = tab
        'CARGA LOS TABS PEDIDOS
        If tabamostrar = "todas" Then
            grpCauce.TabVisible = True
            grpHabitat.TabVisible = True
            grpFQ.TabVisible = True
            grpOtrosDatos.TabVisible = True
            grpComunidades.TabVisible = True
            grpInfo.TabVisible = True

            btnDatosMacroInvertebrados.Visible = True
            TaxonesPresentesMacroinvertebrados.Visible = True
            Me.TaxonesTableAdapter.qryTaxonesByAPampeano(MacroinvertebradosDataSet.Taxones)

            btnDatosDiatomeas.Visible = True
            TaxonesPresentesDiatomeas.Visible = True
            Me.TaxonesTableAdapter1.qryTaxonesByAPampeano(DiatomeasDataSet.Taxones)
        Else
            Dim k As Integer
            For k = 0 To grpTabs.TabCount - 1
                If grpTabs.TabPages.Item(k).Name = "grp" & tabamostrar Then
                    grpTabs.TabPages.Item(k).TabVisible = True
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub frmMuestrasArroyoPamp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HabitatDataSet.CaracHabitat' table. You can move, or remove it, as needed.
        Me.ModulosTableAdapter.Fill(Me.ConfigDataSet.Modulos)
        Me.ConfigTableAdapter.Fill(Me.ConfigDataSet.Config)

        lblProyectoNombre.Text = nombreproyecto
        'CARGA MUESTRAS POR PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
        IrAMuestra()
    End Sub

    Private Sub IrAMuestra()
        Dim k As Integer

        'SE FIJA QUE HAYA MUESTRAS CARGADAS ANTES DE HACER NADA
        If Not IdMuestraTextBox.Text = "" Then
            idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        End If
        'VA A LA MUESTRA ACTUAL
        For k = 0 To MuestrasDataGridView.RowCount - 1
            If MuestrasDataGridView.Item(0, k).Value.ToString = idmuestraactual Then
                MuestrasDataGridView.CurrentCell = MuestrasDataGridView.Item(0, k)
                Exit For
            End If
        Next

        lblMuestraenCauce.Text = NombreTextBox.Text
        lblMuestraenHabitat.Text = NombreTextBox.Text
        lblMuestraenFQ.Text = NombreTextBox.Text
        lblMuestraenComunidades.Text = NombreTextBox.Text
        lblMuestraenOtros.Text = NombreTextBox.Text
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   CARGA DE ADAPTADORES CUANDO ENTRO A LOS TABS
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub grpInfo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpInfo.Click
        If Not idmuestra.ToString = String.Empty Then
            If Not IdMuestraTextBox.Text = String.Empty Then
                idmuestra = CInt(IdMuestraTextBox.Text)
                cargarInfo(idmuestra)
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub


    Private Sub grpCauce_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCauce.Click
        If Not idmuestra.ToString = String.Empty Then
            If Not IdMuestraTextBox.Text = String.Empty Then
                idmuestra = CInt(IdMuestraTextBox.Text)
                lblMuestraenCauce.Text = NombreTextBox.Text
                cargarCauce(idmuestra)
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub


    Private Sub grpComunidades_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpComunidades.Click
        If Not idmuestra.ToString = String.Empty Then
            If Not IdMuestraTextBox.Text = String.Empty Then
                idmuestra = CInt(IdMuestraTextBox.Text)
                lblMuestraenComunidades.Text = NombreTextBox.Text
                cargarComunidades(idmuestra)
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub grpHabitatTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpHabitat.Click
        If Not idmuestra.ToString = String.Empty Then
            If Not IdMuestraTextBox.Text = String.Empty Then
                idmuestra = CInt(IdMuestraTextBox.Text)
                lblMuestraenHabitat.Text = NombreTextBox.Text
                cargarHabitat(idmuestra)
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub grpFQ_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpFQ.Click
        If Not idmuestra.ToString = String.Empty Then
            If Not IdMuestraTextBox.Text = String.Empty Then
                idmuestra = CInt(IdMuestraTextBox.Text)
                lblMuestraenFQ.Text = NombreTextBox.Text
                cargarFQ(idmuestra)
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub grpOtrosDatos_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpOtrosDatos.Click
        If Not idmuestra.ToString = String.Empty Then
            If Not IdMuestraTextBox.Text = String.Empty Then
                idmuestra = CInt(IdMuestraTextBox.Text)
                lblMuestraenOtros.Text = NombreTextBox.Text
                cargarOtrosDatos(idmuestra)
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MOVIMIENTO DEL MUESTRASBINDINGSOURCE
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub MuestrasBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuestrasBindingSource.PositionChanged
        If Not idmuestra.ToString = String.Empty Then
            If Not IdMuestraTextBox.Text = String.Empty Then
                idmuestra = CInt(IdMuestraTextBox.Text)
                lblMuestraenCauce.Text = NombreTextBox.Text
                lblMuestraenHabitat.Text = NombreTextBox.Text
                lblMuestraenFQ.Text = NombreTextBox.Text
                lblMuestraenComunidades.Text = NombreTextBox.Text
                lblMuestraenOtros.Text = NombreTextBox.Text
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        Dim tabselected As String
        tabselected = grpTabs.SelectedTab.Name
        If tabselected = "grpCauce" Then
            cargarCauce(idmuestra)
        ElseIf tabselected = "grpOtrosDatos" Then
            cargarOtrosDatos(idmuestra)
        ElseIf tabselected = "grpHabitatTab" Then
            cargarHabitat(idmuestra)
        ElseIf tabselected = "grpComunidades" Then
            cargarComunidades(idmuestra)
        ElseIf tabselected = "grpFQ" Then
            cargarFQ(idmuestra)
        ElseIf tabselected = "grpInfo" Then
            cargarInfo(idmuestra)
        End If
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   CARGA DE ADAPTADORES INDIVIDUALES
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////


    Public Sub cargarInfo(ByVal idmuestra As Integer)
        ' CARGA INFO
        Me.SitiosMuestrasTableAdapter.qrySitioByMuestra(Me.SitiosDataSet.SitiosMuestras, idmuestra)
    End Sub


    Public Sub cargarCauce(ByVal idmuestra As Integer)
        ' CARGA CAUCE
        Me.ParametrosCauceTableAdapter.qryParametrosCaucebyIdMuestra(Me.CauceDataSet.ParametrosCauce, idmuestra)
    End Sub
    Public Sub cargarComunidades(ByVal idmuestra As Integer)

        ' ////////////////////////////////////////////////
        ' //////////////////////// 
        ' ////////////////////////  MACROINVERTEBRADOS
        ' ////////////////////////  NUEVA
        ' ////////////////////////////////////////////////

        ' CONEXION A LA TABLA DE TAXONES
        Dim Macroinvcon As New OleDb.OleDbConnection
        Dim Macroinvds As New DataSet
        Dim MacroinvSQL As String
        Macroinvcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Macroinvcon.Open()
        MacroinvSQL = "SELECT * FROM macroinvs WHERE IdMuestra = '" & idmuestra & "'"
        Dim Macroinvda = New OleDb.OleDbDataAdapter(MacroinvSQL, Macroinvcon)
        Macroinvda.Fill(Macroinvds, "TablaMacroInv")

        If Macroinvds.Tables("TablaMacroInv").Rows.Count = 1 Then
            TaxonesPresentesMacroinvertebrados.Rows.Clear()
            TraduceTaxones(Macroinvds.Tables("TablaMacroInv"), TaxonesPresentesMacroinvertebrados, "macroinv")
        ElseIf Macroinvds.Tables("TablaMacroInv").Rows.Count = 0 Then
            TaxonesPresentesMacroinvertebrados.Rows.Clear()
        End If
        Macroinvcon.Close()

        ' ////////////////////////////////////////////////
        ' //////////////////////// 
        ' ////////////////////////  DIATOMEAS
        ' ////////////////////////  NUEVA
        ' ////////////////////////////////////////////////

        ' CONEXION A LA TABLA DE TAXONES
        Dim Diatomeascon As New OleDb.OleDbConnection
        Dim Diatomeasds As New DataSet
        Dim DiatomeasSQL As String
        Diatomeascon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
        Diatomeascon.Open()
        DiatomeasSQL = "SELECT * FROM Diats WHERE IdMuestra = '" & idmuestra & "'"
        Dim Diatomeasda = New OleDb.OleDbDataAdapter(DiatomeasSQL, Diatomeascon)
        Diatomeasda.Fill(Diatomeasds, "TablaDiatomeas")

        If Diatomeasds.Tables("TablaDiatomeas").Rows.Count = 1 Then
            TaxonesPresentesDiatomeas.Rows.Clear()
            TraduceTaxones(Diatomeasds.Tables("TablaDiatomeas"), TaxonesPresentesDiatomeas, "diatomeas")
        ElseIf Diatomeasds.Tables("TablaDiatomeas").Rows.Count = 0 Then
            TaxonesPresentesDiatomeas.Rows.Clear()
        End If
        Diatomeascon.Close()


    End Sub

    Private Sub TraduceTaxones(ByVal tablamuestras As DataTable, ByVal tablaoutput As DataGridView, ByVal comunidad As String)
        Dim k As Integer
        Dim j As Integer
        Dim idtaxon As Integer
        Dim nombretaxon As String

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
                    tablaoutput.Rows.Add(taxa1Array(k).ToString)
                    Dim c As Integer = tablaoutput.Rows.Count - 1
                    tablaoutput.Rows(c).Visible = False
                Else
                    tablaoutput.Rows.Add(taxa1Array(k).ToString)
                End If
            End If
        Next
        'SACA LOS ID DE TAXA2 y LOS VUELCA EN LA GRID
        For k = 0 To taxa2Array.Length - 1
            If taxa2Array(k).ToString <> "" Then
                If (taxa2Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa2Array(k) = taxa2Array(k).Trim("!")
                    tablaoutput.Rows.Add(taxa2Array(k).ToString)
                    Dim c As Integer = tablaoutput.Rows.Count - 1
                    tablaoutput.Rows(c).Visible = False
                Else
                    tablaoutput.Rows.Add(taxa2Array(k).ToString)
                End If
            End If
        Next
        'SACA LOS ID DE TAXA3 y LOS VUELCA EN LA GRID
        For k = 0 To taxa3Array.Length - 1
            If taxa3Array(k).ToString <> "" Then
                If (taxa3Array(k).ToString.IndexOf("!") <> -1) Then
                    taxa3Array(k) = taxa3Array(k).Trim("!")
                    tablaoutput.Rows.Add(taxa3Array(k).ToString)
                    Dim c As Integer = tablaoutput.Rows.Count - 1
                    tablaoutput.Rows(c).Visible = False
                Else
                    tablaoutput.Rows.Add(taxa3Array(k).ToString)
                End If
            End If
        Next

        ' BUSCA CADA IDTAXON EN LA GRID (recien volcados) EN LA TABLA tablaoutput
        ' Y TRADUCE EL NOMBRE, y LO CARGA A LA GRID TAMBIEN
        Dim taxontable As DataTable


        If comunidad = "macroinv" Then

            'CARGA EL LISTADO DE TAXONES ENTERO
            TaxonesTableAdapter.Fill(MacroinvertebradosDataSet.Taxones)

            For j = 0 To tablaoutput.Rows.Count - 1
                idtaxon = CInt(tablaoutput.Item(0, j).Value.ToString)
                taxontable = TaxonesTableAdapter.getTaxonesByIdTaxon(idtaxon)
                nombretaxon = taxontable.Rows(0).Item("Nombre").ToString
                tablaoutput.Item(1, j).Value = nombretaxon
            Next
        ElseIf comunidad = "diatomeas" Then
            'CARGA EL LISTADO DE TAXONES ENTERO
            TaxonesTableAdapter1.Fill(DiatomeasDataSet.Taxones)

            For j = 0 To tablaoutput.Rows.Count - 1
                idtaxon = CInt(tablaoutput.Item(0, j).Value.ToString)
                taxontable = TaxonesTableAdapter1.getTaxonesByIdTaxon(idtaxon)
                nombretaxon = taxontable.Rows(0).Item("Nombre").ToString
                tablaoutput.Item(1, j).Value = nombretaxon
            Next
        End If

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
                tablaoutput.Item(2, m).Value = densidad1Array(l).ToString
                m = m + 1
            Next
        End If
        If densidad2Array.Length > 1 Then
            For l = 0 To densidad2Array.Length - 2
                tablaoutput.Item(2, m).Value = densidad2Array(l).ToString
                m = m + 1
            Next
        End If
        If densidad3Array.Length > 1 Then
            For l = 0 To densidad3Array.Length - 2
                tablaoutput.Item(2, m).Value = densidad3Array(l).ToString
                m = m + 1
            Next
        End If
    End Sub


    Public Sub cargarOtrosDatos(ByVal idmuestra As Integer)
        ' CARGA OTROS DATOS
        Me.OtrosdatosTableAdapter.qryOtrosDatosbyIdMuestra(Me.OtrosDataSet.Otrosdatos, idmuestra)
    End Sub
    Public Sub cargarFQ(ByVal idmuestra As Integer)
        ' CARGA DATOS DE FQ
        Me.ParametrosFQTableAdapter.qryFQbyIdMuestra(Me.FqDataSet.ParametrosFQ, idmuestra)
    End Sub
    Public Sub cargarHabitat(ByVal idmuestra As Integer)
        ' CARGA DATOS DE HABITAT VIEJA
        Me.ParametrosHabitatTableAdapter.qryParametrosHabitatbyIdMuestra(Me.HabitatDataSet.ParametrosHabitat, idmuestra)

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MENU DE MUESTRAS
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub btnNuevaMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaMuestra.Click

        Dim nombremuestra As String
        nombremuestra = InputBox("Ingrese el nombre de la muestra", , "Muestra ")

        If nombremuestra <> "" Then
            ' AGREGA MUESTRA
            MuestrasBindingSource.AddNew()

            'AGREGA EL NOMBRE Y AUTOR DE LOS INPUTS
            NombreTextBox.Text = nombremuestra

            'GUARDA LA NUEVA MUESTRA
            GrabarMuestra()
        Else
            'CANCELA EL INPUT
            Exit Sub
        End If
    End Sub

    Private Sub btnGuardarMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarMuestra.Click
        GrabarMuestra()
    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   BORRAR MUESTRAS
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub btnBorrarMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarMuestra.Click
        Dim idmuestraborrar As Integer

        If Not MuestrasDataGridView.RowCount = 1 Then
            If MessageBox.Show("Esta seguro de eliminar esta muestra?", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                idmuestraborrar = MuestrasDataGridView.CurrentRow.Cells.Item(0).Value
                MsgBox("Borrando muestra " & idmuestraborrar)

                ' BORRA MUESTRA CON IDMUESTRA = IDMUESTRABORRAR 
                ' EN EL RESTO DE LAS LAS TABLAS
                '
                '
                ' TABLA DE MUESTRA 
                MuestrasBindingSource.RemoveCurrent()
                MuestrasTableAdapter.Update(Me.Scilla10DataSet.Muestras)

                ' TABLA DE SITIOS
                SitiosMuestrasTableAdapter.qrySitioByMuestra(SitiosDataSet.SitiosMuestras, idmuestraborrar)
                If SitiosMuestrasBindingSource.Count <> 0 Then
                    SitiosMuestrasBindingSource.RemoveCurrent()
                    SitiosMuestrasTableAdapter.Update(SitiosDataSet.SitiosMuestras)
                End If

                ' TABLA DE CAUCE
                ParametrosCauceTableAdapter.qryParametrosCaucebyIdMuestra(CauceDataSet.ParametrosCauce, idmuestraborrar)
                If ParametrosCauceBindingSource.Count <> 0 Then
                    ParametrosCauceBindingSource.RemoveCurrent()
                    ParametrosCauceTableAdapter.Update(CauceDataSet.ParametrosCauce)
                End If

                ' TABLA DE FQ
                ParametrosFQTableAdapter.qryFQbyIdMuestra(FqDataSet.ParametrosFQ, idmuestraborrar)
                If ParametrosFQBindingSource.Count <> 0 Then
                    ParametrosFQBindingSource.RemoveCurrent()
                    ParametrosFQTableAdapter.Update(FqDataSet.ParametrosFQ)
                End If

                ' TABLA DE HABITAT
                ParametrosHabitatTableAdapter.qryParametrosHabitatbyIdMuestra(HabitatDataSet.ParametrosHabitat, idmuestraborrar)
                If ParametrosHabitatBindingSource.Count <> 0 Then
                    ParametrosHabitatBindingSource.RemoveCurrent()
                    ParametrosHabitatTableAdapter.Update(HabitatDataSet.ParametrosHabitat)
                End If

                ' TABLA DE OTROS
                OtrosdatosTableAdapter.qryOtrosDatosbyIdMuestra(OtrosDataSet.Otrosdatos, idmuestraborrar)
                If OtrosdatosBindingSource.Count <> 0 Then
                    OtrosdatosBindingSource.RemoveCurrent()
                    OtrosdatosTableAdapter.Update(OtrosDataSet.Otrosdatos)
                End If

                ' TABLA DE IBMAMP
                IBPAMPTableAdapter.qryIBPAMPByIdMuestra(IbpampDataSet.IBPAMP, idmuestraborrar)
                If IBPAMPBindingSource.Count <> 0 Then
                    IBPAMPBindingSource.RemoveCurrent()
                    IBPAMPTableAdapter.Update(IbpampDataSet.IBPAMP)
                End If

                ' TABLA DE IDP
                IDPTableAdapter.qryIDPbyIdMuestra(IdpDataSet.IDP, idmuestraborrar)
                If IDPBindingSource.Count <> 0 Then
                    IDPBindingSource.RemoveCurrent()
                    IDPTableAdapter.Update(IdpDataSet.IDP)
                End If

                ' TABLA DE IMRP
                IMRPTableAdapter.qryIMRPbyIdMuestra(ImrpDataSet.IMRP, idmuestraborrar)
                If IMRPBindingSource.Count <> 0 Then
                    IMRPBindingSource.RemoveCurrent()
                    IMRPTableAdapter.Update(ImrpDataSet.IMRP)
                End If

                ' TABLAS DE TAXONESMUESTRAS
                ' DIATOMEAS

                ' CONEXION A LA TABLA DE TAXONES
                Dim diatomeascon As New OleDb.OleDbConnection
                Dim diatomeasds As New DataSet
                Dim diatomeasSQL As String
                diatomeascon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
                diatomeascon.Open()
                diatomeasSQL = "SELECT * FROM Diats WHERE IdMuestra = '" & idmuestraborrar & "'"
                Dim diatomeasda = New OleDb.OleDbDataAdapter(diatomeasSQL, diatomeascon)
                diatomeasda.Fill(diatomeasds, "Tabladiatomeas")

                If diatomeasds.Tables("Tabladiatomeas").Rows.Count <> 0 Then
                    diatomeasds.Tables("Tabladiatomeas").Rows(0).Delete()
                    Dim cb As New OleDb.OleDbCommandBuilder(diatomeasda)
                    diatomeasda.Update(diatomeasds, "Tabladiatomeas")
                End If
                diatomeascon.Close()

                ' TABLAS DE TAXONESMUESTRAS
                ' MACROINVERTEBRADOS

                ' CONEXION A LA TABLA DE TAXONES
                Dim Macroinvcon As New OleDb.OleDbConnection
                Dim Macroinvds As New DataSet
                Dim MacroinvSQL As String
                Macroinvcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
                Macroinvcon.Open()
                MacroinvSQL = "SELECT * FROM macroinvs WHERE IdMuestra = '" & idmuestraborrar & "'"
                Dim Macroinvda = New OleDb.OleDbDataAdapter(MacroinvSQL, Macroinvcon)
                Macroinvda.Fill(Macroinvds, "TablaMacroInv")

                If Macroinvds.Tables("TablaMacroInv").Rows.Count <> 0 Then
                    Macroinvds.Tables("TablaMacroInv").Rows(0).Delete()
                    Dim cb As New OleDb.OleDbCommandBuilder(Macroinvda)
                    Macroinvda.Update(Macroinvds, "TablaMacroInv")
                End If
                Macroinvcon.Close()

            End If
        Else
            MsgBox("No hay muestras en este proyecto")
        End If

        MsgBox("Muestra " & idmuestraborrar & " borrada")
    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   GRABAR MUESTRAS
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Public Sub GrabarMuestra()
        'If BindingNavigatorMoveLastItem.Enabled = True Then
        '    idproyecto = Convert.ToInt32(IdProyectoTextBox.Text)
        '    MuestrasBindingSource.EndEdit()
        '    Me.MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)
        'Else
        '    IdProyectoTextBox.Text = idproyecto
        '    Me.MuestrasBindingSource.EndEdit()
        '    Me.MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

        '    'Recarga el adaptador Muestra y Mueve al ultimo registro (recien creado)
        '    Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
        '    MuestrasDataGridView.CurrentCell = MuestrasDataGridView(0, MuestrasDataGridView.Rows.Count - 1)
        'End If
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MANEJO DE SITIOS Y SUS COORDENADAS
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    ' CAMBIA EL CODIGO DE SITIO EN TABLA MUESTRAS POR LO QUE HAY EN EL COMBO SITIOS
    Private Sub CodigoSitioComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.Visible = True Then
            CodigoSitioTextBox.Text = CodigoSitioComboBox.Text
            CoordLATTextBox1.Text = CoordLATTextBox.Text
            CoordLONGTextBox1.Text = CoordLONGTextBox.Text
        End If
    End Sub

    Private Sub btnEditarSitios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarSitios.Click
        frmSitios.ShowDialog()
    End Sub


    Private Sub btnCambiarSitio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarSitio.Click

        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        ' SI NO HAY DATOS PREVIOS PARA LA MUESTRA, HACE UNOS NUEVOS Y HABILITA EL GRUP. 
        'SINO DIRECTAMENTE HABILITA EL GRUPO.

        If SitiosMuestrasID.Text = String.Empty Then
            SitiosMuestrasBindingSource.AddNew()
            SitiosMuestrasIdmuestra.Text = idmuestra
            SitiosMuestrasIdProyecto.Text = idproyecto
            CodigoSitioComboBox.Visible = True
            CodigoSitioTextBox.Visible = False
            btnGuardarSitio.Visible = True
            btnLimpiarSitio.Visible = True
            btnCambiarSitio.Visible = False
            btnEditarSitios.Visible = False
            CoordLATTextBox.Visible = True
            CoordLONGTextBox.Visible = True
        Else
            CodigoSitioComboBox.Visible = True
            CodigoSitioTextBox.Visible = False
            btnGuardarSitio.Visible = True
            btnLimpiarSitio.Visible = True
            btnCambiarSitio.Visible = False
            btnEditarSitios.Visible = False
            CoordLATTextBox.Visible = True
            CoordLONGTextBox.Visible = True
        End If
    End Sub

    Private Sub btnGuardarSitio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarSitio.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        SitiosMuestrasIdmuestra.Text = idmuestra
        SitiosMuestrasBindingSource.EndEdit()
        SitiosMuestrasTableAdapter.Update(SitiosDataSet.SitiosMuestras)

        CodigoSitioComboBox.Visible = False
        CoordLATTextBox.Visible = False
        CoordLONGTextBox.Visible = False
        CodigoSitioTextBox.Visible = True
        btnGuardarSitio.Visible = False
        btnLimpiarSitio.Visible = False
        btnCambiarSitio.Visible = True
        btnEditarSitios.Visible = True

        'Recarga el adaptador 
        SitiosMuestrasTableAdapter.qrySitioByMuestra(SitiosDataSet.SitiosMuestras, idmuestra)
    End Sub

    Private Sub btnLimpiarSitio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarSitio.Click
        CodigoSitioTextBox.Text = ""
        CoordLATTextBox1.Text = ""
        CoordLONGTextBox1.Text = ""
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        SitiosMuestrasBindingSource.EndEdit()
        SitiosMuestrasTableAdapter.Update(SitiosDataSet.SitiosMuestras)

        CodigoSitioComboBox.Visible = False
        CoordLATTextBox.Visible = False
        CoordLONGTextBox.Visible = False
        CodigoSitioTextBox.Visible = True
        btnGuardarSitio.Visible = False
        btnLimpiarSitio.Visible = False
        btnCambiarSitio.Visible = True
        btnEditarSitios.Visible = True

        'Recarga el adaptador 
        SitiosMuestrasTableAdapter.qrySitioByMuestra(SitiosDataSet.SitiosMuestras, idmuestra)

    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MANEJO DE TABS
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////


    '//////// TAB DE INFO
    '///////////////////////
    '///////////////////////

    Private Sub btnEditarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarDatos.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        grpInfoMuestra.Enabled = True
        grpSitio.Enabled = True
        ' carga los posibles sitios
        Me.SitiosTableAdapter.Fill(Me.SitiosDataSet.Sitios)

    End Sub

    Private Sub btnGuardarInfoMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarInfoMuestra.Click
        grpInfoMuestra.Enabled = False
        grpSitio.Enabled = False
        GrabarMuestra()
    End Sub


    '//////// TAB DE CAUCE
    '///////////////////////
    '///////////////////////
    Private Sub btnEditarDatosCauce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarDatosCauce.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)

        ' SI NO HAY DATOS PREVIOS PARA LA MUESTRA, HACE UNOS NUEVOS Y HABILITA EL GRUP. 
        'SINO DIRECTAMENTE HABILITA EL GRUPO.

        If CauceId.Text = String.Empty Then
            ParametrosCauceBindingSource.AddNew()
            CauceIdMuestra.Text = idmuestra
            CauceIdProyecto.Text = idproyecto
            grpCauceInner.Enabled = True
            btnEditarDatosCauce.Enabled = False
            btnGuardarDatosCauce.Enabled = True
        Else
            grpCauceInner.Enabled = True
            btnEditarDatosCauce.Enabled = False
            btnGuardarDatosCauce.Enabled = True
        End If
    End Sub

    Private Sub btnGuardarDatosCauce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDatosCauce.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        ParametrosCauceBindingSource.EndEdit()
        ParametrosCauceTableAdapter.Update(CauceDataSet.ParametrosCauce)
        btnEditarDatosCauce.Enabled = True
        grpCauceInner.Enabled = False

        'Recarga el adaptador de cauce
        ParametrosCauceTableAdapter.qryParametrosCaucebyIdMuestra(CauceDataSet.ParametrosCauce, idmuestra)
    End Sub
    '//////// TAB DE COMUNIDADES
    '///////////////////////
    '///////////////////////

    Private Sub btnMacroInvertebrados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatosMacroInvertebrados.Click

        Dim tipoproyecto As String = "ArroyoPamp"
        Dim idmuestraactual As Integer = Convert.ToInt32(IdMuestraTextBox.Text)
        Dim idproyectoactual As Integer = idproyecto


        frmMacroinvertebrados.Show()
    End Sub

    Private Sub btnDatosDiatomeas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatosDiatomeas.Click
        Dim tipoproyecto As String = "ArroyoPamp"

        Dim idmuestraactual As Integer = Convert.ToInt32(IdMuestraTextBox.Text)
        Dim idproyectoactual As Integer = idproyecto
        frmDiatomeas.RecibirVariables(tipoproyecto, idproyectoactual, idmuestraactual)
        frmDiatomeas.Show()
    End Sub

    '//////// TAB DE HABITAT
    '///////////////////////
    '///////////////////////

    Private Sub btnEditarHabitat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarHabitat.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)

        ' SI NO HAY DATOS PREVIOS PARA LA MUESTRA, HACE UNOS NUEVOS Y HABILITA EL GRP. SINO DIRECTAMENTE HABILITA EL GRP.
        If HabitatId.Text = String.Empty Then
            ParametrosHabitatBindingSource.AddNew()
            HabitatIdMuestra.Text = idmuestra
            HabitatIdProyecto.Text = idproyecto
            grpHabitatInner.Enabled = True
            btnEditarHabitat.Enabled = False
            btnGuardarDatosHabitat.Enabled = True
        Else
            grpHabitatInner.Enabled = True
            btnEditarHabitat.Enabled = False
            btnGuardarDatosHabitat.Enabled = True
        End If
    End Sub

    Private Sub btnGuardarDatosHabitat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDatosHabitat.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        ParametrosHabitatBindingSource.EndEdit()
        ParametrosHabitatTableAdapter.Update(HabitatDataSet.ParametrosHabitat)
        btnEditarHabitat.Enabled = True
        grpHabitatInner.Enabled = False

        'Recarga el adaptador de habitat
        ParametrosHabitatTableAdapter.qryParametrosHabitatbyIdMuestra(HabitatDataSet.ParametrosHabitat, idmuestra)
    End Sub
    '//////// TAB DE FQ
    '///////////////////////
    '///////////////////////


    Private Sub btnDatosFQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarFQ.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)

        ' SI NO HAY DATOS PREVIOS PARA LA MUESTRA, HACE UNOS NUEVOS Y HABILITA EL GRP. SINO DIRECTAMENTE HABILITA EL GRP.
        If FQId.Text = String.Empty Then
            ParametrosFQBindingSource.AddNew()
            FQIdMuestra.Text = idmuestra
            FQIdProyecto.Text = idproyecto
            grpFQInner.Enabled = True
            btnEditarFQ.Enabled = False
            btnGuardarFQ.Enabled = True
        Else
            grpFQInner.Enabled = True
            btnEditarFQ.Enabled = False
            btnGuardarFQ.Enabled = True
        End If
    End Sub

    Private Sub btnGuardarFQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarFQ.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        ParametrosFQBindingSource.EndEdit()
        ParametrosFQTableAdapter.Update(FqDataSet.ParametrosFQ)
        btnEditarFQ.Enabled = True
        grpFQInner.Enabled = False

        'Recarga el adaptador de FQ
        ParametrosFQTableAdapter.qryFQbyIdMuestra(FqDataSet.ParametrosFQ, idmuestra)

    End Sub

    '//////// TAB DE OTROS DATOS
    '///////////////////////
    '///////////////////////

    Private Sub btnEditarOtrosdatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarOtrosdatos.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)

        ' SI NO HAY DATOS PREVIOS PARA LA MUESTRA, HACE UNOS NUEVOS Y HABILITA EL GRP. SINO DIRECTAMENTE HABILITA EL GRP.
        If OtrosdatosId.Text = String.Empty Then
            OtrosdatosBindingSource.AddNew()
            OtrosdatosIdMuestra.Text = idmuestra
            OtrosdatosIdProyecto.Text = idproyecto
            grpOtrosDatosInner.Enabled = True
            btnEditarOtrosdatos.Enabled = False
            btnGuardarOtrosDatos.Enabled = True
        Else
            grpOtrosDatosInner.Enabled = True
            btnEditarOtrosdatos.Enabled = False
            btnGuardarOtrosDatos.Enabled = True
        End If
    End Sub
    Private Sub btnGuardarOtrosDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtrosDatos.Click
        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        OtrosdatosBindingSource.EndEdit()
        OtrosdatosTableAdapter.Update(OtrosDataSet.Otrosdatos)
        btnEditarOtrosdatos.Enabled = True
        grpOtrosDatosInner.Enabled = False

        'Recarga el adaptador de otros datos
        OtrosdatosTableAdapter.qryOtrosDatosbyIdMuestra(OtrosDataSet.Otrosdatos, idmuestra)

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   CHEQUEO DE SIGNIFICADO DE INDICES
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub InterpretacionIndices()
        'REVISA PARA IDP
        If IDPTextBox.Text = "" Then
            IDPSignifica.Text = ""
            IDPSignifica.BackColor = Color.LightGray
        Else
            IDPSignificado()
        End If

        'REVISA PARA IMRP
        If IMRPTextBox.Text = "" Then
            IMRPSignifica.Text = ""
            IMRPSignifica.BackColor = Color.LightGray
        Else
            IMRPSignificado()
        End If

        'REVISA PARA IBPAMP
        If IBPAMPTextBox.Text = "" Then
            IBPAMPSignifica.Text = ""
            IBPAMPSignifica.BackColor = Color.LightGray
        Else
            IBPAMPSignificado()
        End If

    End Sub

    Private Sub IDPSignificado()
        Dim varidp As Double
        varidp = Val(IDPTextBox.Text)
        IDPSignifica.Text = ""
        IDPSignifica.BackColor = Color.LightGray
        If varidp <= 0.5 And varidp > 0 Then
            IDPSignifica.Text = "Muy bueno"
            IDPSignifica.BackColor = Color.Blue
        End If
        If varidp <= 1.5 And varidp > 0.5 Then
            IDPSignifica.Text = "Bueno"
            IDPSignifica.BackColor = Color.Green
        End If
        If varidp <= 2 And varidp > 1.5 Then
            IDPSignifica.Text = "Aceptable"
            IDPSignifica.BackColor = Color.Yellow
        End If
        If varidp <= 3 And varidp > 2 Then
            IDPSignifica.Text = "Malo"
            IDPSignifica.BackColor = Color.Orange
        End If
        If varidp <= 4 And varidp > 3 Then
            IDPSignifica.Text = "Muy Malo"
            IDPSignifica.BackColor = Color.Red
        End If
    End Sub

    Private Sub IMRPSignificado()
        Dim indicecolor As Integer
        If IMRPTextBox.Text <> "" Then
            indicecolor = Val(IMRPTextBox.Text)
        Else
            IMRPSignifica.Text = ""
            IMRPSignifica.BackColor = Color.Gray
        End If
        If indicecolor >= 0 And indicecolor <= 1 Then
            IMRPSignifica.Text = "Muy fuerte"
            IMRPSignifica.BackColor = Color.Red
        End If
        If indicecolor > 1 And indicecolor <= 2.5 Then
            IMRPSignifica.Text = "Fuerte"
            IMRPSignifica.BackColor = Color.OrangeRed
        End If
        If indicecolor > 2.5 And indicecolor < 4 Then
            IMRPSignifica.Text = "Moderada"
            IMRPSignifica.BackColor = Color.Orange
        End If
        If indicecolor >= 4 And indicecolor < 8 Then
            IMRPSignifica.Text = "Débil"
            IMRPSignifica.BackColor = Color.Yellow
        End If
        If indicecolor >= 8 And indicecolor <= 12 Then
            IMRPSignifica.Text = "Escasa"
            IMRPSignifica.BackColor = Color.Green
        End If
        If indicecolor > 12 Then
            IMRPSignifica.Text = "Nula"
            IMRPSignifica.BackColor = Color.Blue
        End If
    End Sub
    Private Sub IBPAMPSignificado()
        Dim indicecolor As Integer
        If IBPAMPTextBox.Text <> "---" Then
            indicecolor = Val(IBPAMPTextBox.Text)
        Else
            IBPAMPSignifica.Text = "---"
            IBPAMPSignifica.BackColor = Color.Gray
        End If

        If indicecolor >= 1 And indicecolor <= 3 Then
            IBPAMPSignifica.Text = "Clase V"
            IBPAMPSignifica.BackColor = Color.Red
        End If
        If indicecolor >= 4 And indicecolor <= 5 Then
            IBPAMPSignifica.Text = "Clase IIII"
            IBPAMPSignifica.BackColor = Color.Orange
        End If
        If indicecolor >= 6 And indicecolor <= 7 Then
            IBPAMPSignifica.Text = "Clase III"
            IBPAMPSignifica.BackColor = Color.Yellow
        End If
        If indicecolor >= 8 And indicecolor <= 9 Then
            IBPAMPSignifica.Text = "Clase II"
            IBPAMPSignifica.BackColor = Color.Green
        End If
        If indicecolor >= 10 Then
            IBPAMPSignifica.Text = "Clase I"
            IBPAMPSignifica.BackColor = Color.Blue
        End If
    End Sub

    Private Sub EutrofizacionSignifica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        ClorofilaaTextBox.BackColor = Color.Firebrick
    End Sub

    Private Sub EutrofizacionSignifica_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        ClorofilaaTextBox.BackColor = Color.White
    End Sub

    Private Sub IBPAMPSignifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IBPAMPSignifica.Click
        If IBPAMPSignifica.Text = "Clase V" Then
            MsgBox("Muy fuertemente poluído")
        End If
        If IBPAMPSignifica.Text = "Clase IIII" Then
            MsgBox("Fuertemente poluído")
        End If
        If IBPAMPSignifica.Text = "Clase III" Then
            MsgBox("Moderadamente poluído")
        End If
        If IBPAMPSignifica.Text = "Clase II" Then
            MsgBox("Suavemente poluído")
        End If
        If IBPAMPSignifica.Text = "Clase I" Then
            MsgBox("No poluído")
        End If
    End Sub

    Private Sub btnIMRP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIMRP.Click
        Dim formorigen As String
        formorigen = "frmAPampeano"
        'CalcularIMRP(formorigen, idmuestra, idproyecto, TaxonesPresentesMacroinvertebrados)
        Me.IMRPTableAdapter.qryIMRPbyIdMuestra(Me.ImrpDataSet.IMRP, idmuestra)
    End Sub

    Private Sub btnIBPAMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIBPAMP.Click
        Dim formorigen As String
        formorigen = "frmAPampeano"
        'CalcularIBPAMP(formorigen, idmuestra, idproyecto, TaxonesPresentesMacroinvertebrados)
        Me.IBPAMPTableAdapter.qryIBPAMPByIdMuestra(Me.IbpampDataSet.IBPAMP, idmuestra)
    End Sub

    Private Sub btnIDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIDP.Click
        Dim formorigen As String
        formorigen = "frmAPampeano"
        'CalcularIDP(formorigen, idmuestra, idproyecto, TaxonesPresentesDiatomeas)
        Me.IDPTableAdapter.qryIDPbyIdMuestra(Me.IdpDataSet.IDP, idmuestra)
    End Sub

    Private Sub btnBMPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBMPS.Click
        Dim formorigen As String
        formorigen = "frmAMontana"
        'CalcularBMPS(formorigen, idmuestra, idproyecto, TaxonesPresentesMacroinvertebrados)
    End Sub

    Private Sub VelocidadcuantiTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If VelocidadcuantiTextBox.Text < 0.1 Then
            VelocidadcualiTextBox.Text = "Muy lento"
        End If
        If VelocidadcuantiTextBox.Text < 0.2 And VelocidadcuantiTextBox.Text >= 0.1 Then
            VelocidadcualiTextBox.Text = "Lento"
        End If
        If VelocidadcuantiTextBox.Text < 0.3 And VelocidadcuantiTextBox.Text >= 0.2 Then
            VelocidadcualiTextBox.Text = "Moderado"
        End If
        If VelocidadcuantiTextBox.Text < 0.4 And VelocidadcuantiTextBox.Text >= 0.3 Then
            VelocidadcualiTextBox.Text = "Rápido"
        End If
        If VelocidadcuantiTextBox.Text >= 0.4 Then
            VelocidadcualiTextBox.Text = "Muy rápido"
        End If
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   MENU DE NAVEGACION
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub CambiarProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Manda a decir que tipo de proyecto es 
        frmProyectos.RecibirVariables(tipoproyecto)
        frmProyectos.Show()
        Me.Close()
    End Sub

    Private Sub SalirAWindowsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub EnciclopediaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEnciclopedia.Show()
    End Sub

End Class