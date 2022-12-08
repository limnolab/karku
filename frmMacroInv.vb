Public Class frmMacroInv
    Dim idmuestra As Integer
    Dim idproyecto As Integer
    Dim pathimagen As String = My.Application.Info.DirectoryPath & "\fotosespecies\imrp\"

    Public Sub SetReceive(ByVal Value As Integer, ByVal Value2 As Integer)
        'RECIBO NUMERO DE MUESTRAS Y DEL PROYECTO DEL FORM ANTERIOR
        idmuestra = Value
        idproyecto = Value2
    End Sub

    Private Sub frmMacroInv_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GuardarTodo()
    End Sub

    Private Sub frmMacroInv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SitiosDataSet.Sitios' Puede moverla o quitarla según sea necesario.
        Me.SitiosTableAdapter.Fill(Me.SitiosDataSet.Sitios)
        'CARGO TODAS LAS MUESTRAS PERTENECIENTES AL PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
        'CARGA DE ADAPTADORES RELACIONADOS CON LOS INDICES
        CargaAdaptadores()
        InterpretacionIndices()

    End Sub

    Private Sub GuardarTodo()
        'CIERRA MUESTRAS
        Me.MuestrasBindingSource.EndEdit()

        'GUARDA MUESTRAS
        Me.MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

        'CIERRA MACROINV (lista de taxones con indices) <-- POR LAS DUDAS, NO ES NECESARIO
        Me.MacroInvBindingSource.EndEdit()

        'GUARDA MACROINV (lista de taxones con indices) <-- POR LAS DUDAS, NO ES NECESARIO
        Me.MacroInvTableAdapter.Update(IndicesDataSet.MacroInv)

        'CIERRA CARACTERISTICAS DE TAXONES <-- POR LAS DUDAS, NO ES NECESARIO
        Me.CaracMacroinvIBPAMPBindingSource.EndEdit()
        Me.CaracMacroinvIMRPBindingSource.EndEdit()

        'GUARDA CARACTERÍSTICAS DE TAXONES <-- POR LAS DUDAS, NO ES NECESARIO
        Me.CaracMacroinvIMRPTableAdapter.Update(ImrpDataSet.CaracMacroinvIMRP)
        Me.CaracMacroinvIBPAMPTableAdapter.Update(IbpampDataSet.CaracMacroinvIBPAMP)

        'CIERRA LISTAS DE TAXONES POR MUESTRA
        Me.MacroinvSpIMRPBindingSource2.EndEdit()
        Me.MacroinvSpIBPAMPBindingSource.EndEdit()

        'GUARDA LISTAS DE TAXONES POR MUESTRA
        Me.MacroinvSpIMRPTableAdapter.Update(ImrpDataSet.MacroinvSpIMRP)
        Me.MacroinvSpIBPAMPTableAdapter.Update(IbpampDataSet.MacroinvSpIBPAMP)

        'CIERRA VALORES FINALES DE INDICES POR MUESTRA
        Me.IBPAMPBindingSource.EndEdit()
        Me.IMRPBindingSource.EndEdit()

        'GUARDA VALORES FINALES DE ÍNDICES POR MUESTRA
        Me.IMRPTableAdapter.Update(ImrpDataSet.IMRP)
        Me.IBPAMPTableAdapter.Update(IbpampDataSet.IBPAMP)

        'RECARGA ADAPTADORES DEL FRMMUESTRASARROYOSPAMP
        frmAPampeano.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
    End Sub
    Private Sub CargaAdaptadores()

        'CARGO LOS TAXONES PRESENTES EN LA MUESTRA SELECCIONADA
        Me.MacroinvSpIBPAMPTableAdapter.qryMacroinvSpIBPAMPbyIdMuestra(Me.IbpampDataSet.MacroinvSpIBPAMP, idmuestra)
        Me.MacroinvSpIMRPTableAdapter.qryMacroinvSpIMRPbyIdMuestra(Me.ImrpDataSet.MacroinvSpIMRP, idmuestra)

        'CARGO LOS VALORES FINALES DE LOS ÍNDICES EN LA MUESTRA SELECCIONADA
        Me.IMRPTableAdapter.qryIMRPbyIdMuestra(Me.ImrpDataSet.IMRP, idmuestra)
        Me.IBPAMPTableAdapter.qryIBPAMPByIdMuestra(Me.IbpampDataSet.IBPAMP, idmuestra)

        ' ELIJE SÓLO LOS ÍNDICES PARA EL AMBIENTE SELECCIONADO
        Me.MacroInvTableAdapter.qryIndicesArroyoPamp(Me.IndicesDataSet.MacroInv)

        ' CARGA LAS CARACTERÍSTICAS DE LOS TAXONES PARA EL IMRP
        Me.CaracMacroinvIMRPTableAdapter.Fill(Me.ImrpDataSet.CaracMacroinvIMRP)

        ' CARGA LAS CARACTERÍSTICAS DE LOS TAXONES PARA EL IBPAMP
        Me.CaracMacroinvIBPAMPTableAdapter.Fill(Me.IbpampDataSet.CaracMacroinvIBPAMP)

        'BUSCO LA MUESTRA SELECCIONADA
        Dim i As Integer
        For i = 0 To MuestrasDataGridView.RowCount - 1
            If MuestrasDataGridView.Item(0, i).Value = idmuestra Then
                MuestrasDataGridView.CurrentCell = MuestrasDataGridView.Item(0, i)
            End If
        Next
        ' SI LA MUESTRA YA TIENE DATOS CARGADOS DE ÍNDICES, LOS MUESTRO EN LAS GRILLAS
        VerIBPAMP()
        VerIMRP()
    End Sub

    '//// ACTUALIZA ADAPTADORES CUANDO CAMBIO DE MUESTRA

    Private Sub MuestrasBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuestrasBindingSource.PositionChanged
        If Not idmuestra.ToString = String.Empty Then
            If Not IdMuestraTextBox.Text = String.Empty Then
                'SE FIJA LA MUESTRA ACTUAL
                idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
                'RECARGA LOS ADAPTADORES DE ESA MUESTRA PARA LOS INDICES
                Me.IBPAMPTableAdapter.qryIBPAMPByIdMuestra(Me.IbpampDataSet.IBPAMP, idmuestra)
                Me.IMRPTableAdapter.qryIMRPbyIdMuestra(Me.ImrpDataSet.IMRP, idmuestra)
                Me.MacroinvSpIBPAMPTableAdapter.qryMacroinvSpIBPAMPbyIdMuestra(Me.IbpampDataSet.MacroinvSpIBPAMP, idmuestra)
                Me.MacroinvSpIMRPTableAdapter.qryMacroinvSpIMRPbyIdMuestra(Me.ImrpDataSet.MacroinvSpIMRP, idmuestra)

                ' SI LA MUESTRA YA TIENE DATOS CARGADOS DE ÍNDICES, LOS MUESTRO EN LAS GRILLAS
                VerIBPAMP()
                VerIMRP()
            End If
        End If
        InterpretacionIndices()
    End Sub


    '//// BARRA DE NAVEGACION DE MUESTRAS
    Private Sub EditTootStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditTootStripButton.Click
        ' CUANDO APRIETO EDITAR ACTIVA Y DESACTIVA CONTROLES
        grpMuestra.Enabled = True
        grpMuestra.BackColor = Color.LightSteelBlue
        grpTaxon.Enabled = False
        grpIBPAMP.Enabled = False
        grpIMRP.Enabled = False
        btnCalcularIndices.Enabled = False
        EditTootStripButton.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False
        IdProyectoTextBox.Text = idproyecto
    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        ' CUANDO APRIETO NUEVA MUESTRA ACTIVA Y DESACTIVA CONTROLES
        grpMuestra.Enabled = True
        grpMuestra.BackColor = Color.LightSteelBlue
        grpTaxon.Enabled = False
        grpTaxon.BackColor = Color.White
        grpIBPAMP.Enabled = False
        grpIBPAMP.BackColor = Color.White
        grpIMRP.Enabled = False
        grpIMRP.BackColor = Color.White
        btnCalcularIndices.Enabled = False
        EditTootStripButton.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        IdProyectoTextBox.Text = idproyecto
        grpMuestra.Enabled = False
        grpMuestra.BackColor = Color.White
        grpTaxon.Enabled = True
        grpTaxon.BackColor = Color.LightSteelBlue
        grpIBPAMP.Enabled = True
        grpIBPAMP.BackColor = Color.LightSteelBlue
        grpIMRP.Enabled = True
        grpIMRP.BackColor = Color.LightSteelBlue
        btnCalcularIndices.Enabled = True
        EditTootStripButton.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorDeleteItem.Enabled = True

        If BindingNavigatorMoveLastItem.Enabled = True Then
            idmuestra = IdMuestraTextBox.Text
            GuardarTodo()
            CargaAdaptadores()
        Else
            GuardarTodo()
            CargaAdaptadores()
            MuestrasDataGridView.CurrentCell = MuestrasDataGridView(0, MuestrasDataGridView.Rows.Count - 1)
        End If

    End Sub


    '///// -------- CARGA DE TAXONES Y SELECCIÓN DE INDICES -----------------

    '///// ESTE SUB SIRVE PARA VER LA INFO DE CADA TAXON ANTES DE AGREGARLO A LOS ÍNDICES, CON EL PRIMER CLICK

    Private Sub MacroInvDataGridView_CellClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MacroInvDataGridView.CellClick

        'BUSCA QUE INDICES ESTAN HABILITADOS PARA ESE TAXON
        'EL VALOR DE j ES LA COLUMNA DE CADA INDICE. j=1 ES EL IMRP, j=2 EL IBPAMP, ETC
        Dim i, j As Integer
        i = MacroInvDataGridView.CurrentRow.Index

        'SACA EL NOMBRE DEL TAXON
        Dim nombretaxon As String
        nombretaxon = MacroInvDataGridView.Item(0, i).Value.ToString
        NombreTextBox.Text = nombretaxon

        'BUSCA IMRP
        Dim imrpsino As String = ""
        j = 1
        imrpsino = MacroInvDataGridView.Item(j, i).Value.ToString
        If imrpsino = "1" Then
            CaracMacroinvIMRPTableAdapter.qryCaracMacroinvIMRPbyNombre(ImrpDataSet.CaracMacroinvIMRP, nombretaxon)
            PictureBox1.ImageLocation = pathimagen & nombretaxon & ".jpg"
        End If

        'BUSCA IBPAMP
        Dim ibpampsino As String = ""
        j = 2
        ibpampsino = MacroInvDataGridView.Item(j, i).Value.ToString
        If ibpampsino <> "" Then
            CaracMacroinvIBPAMPTableAdapter.qryCaracMacroinvIBPAMPbyNombre(IbpampDataSet.CaracMacroinvIBPAMP, nombretaxon)
            CategoriaIBPAMPTextBox.Text = ibpampsino
            PictureBox1.ImageLocation = pathimagen & nombretaxon & ".jpg"
        Else
            CategoriaIBPAMPTextBox.Text = "No det."
        End If

    End Sub

    Private Sub MacroInvDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MacroInvDataGridView.CellContentDoubleClick
        ' SI HAY DOBLE CLICK SOBRE LA GRILLA DE TAXONES, COMIENZA LA SELECCION DE INDICES
        SeleccionarIndices()
    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ' SI HAY CLICK SOBRE EL BOTON AGREGAR, COMIENZA LA SELECCION DE INDICES
        SeleccionarIndices()
    End Sub


    Private Sub SeleccionarIndices()
        'A PARTIR DE ACA, BUSCA QUE INDICES ESTAN HABILITADOS PARA ESE TAXON
        'EL VALOR DE j ES LA COLUMNA DE CADA INDICE. j=1 ES EL IMRP, j=2 EL IBPAMP, ETC

        Dim i, j As Integer
        i = MacroInvDataGridView.CurrentRow.Index

        'PRIMERO SACA EL NOMBRE DEL TAXON
        Dim nombretaxon As String
        nombretaxon = MacroInvDataGridView.Item(j, i).Value.ToString

        'BUSCA IMRP
        Dim imrpsino As String
        j = 1
        imrpsino = MacroInvDataGridView.Item(j, i).Value.ToString
        If imrpsino = "1" Then
            If chkIMRP.Checked = True Then
                'BUSCA POR NOMBRE EL VALOR DE VX
                CaracMacroinvIMRPTableAdapter.qryCaracMacroinvIMRPbyNombre(ImrpDataSet.CaracMacroinvIMRP, nombretaxon)
                AgregarIMRP()
            End If
        End If

        'BUSCA IBPAMP
        Dim ibpampsino As String
        j = 2
        ibpampsino = MacroInvDataGridView.Item(j, i).Value.ToString
        If ibpampsino <> "" Then
            If chkIBPAMP.Checked = True Then
                'BUSCA POR NOMBRE LA CATEGORIA (IBPAMP)
                CaracMacroinvIBPAMPTableAdapter.qryCaracMacroinvIBPAMPbyNombre(IbpampDataSet.CaracMacroinvIBPAMP, nombretaxon)
                AgregarIBPAMP()
            End If
        End If
    End Sub
    '///// -------- FIN CARGA DE TAXONES Y SELECCIÓN DE INDICES -----------------


    '//// ----------- IMRP  ------------------
    '//// ----------- IMRP  ------------------
    '//// ----------- IMRP  ------------------

    Private Sub AgregarIMRP()
        'ESTE SUB AGREGA EL TAXON SELECCIONADO DE LA LISTA A LA SECCION IMRP
        'Saca nombre del taxon
        Dim i, j As Integer
        i = MacroInvDataGridView.CurrentRow.Index
        j = 0
        Dim nombretaxon As String
        nombretaxon = MacroInvDataGridView.Item(j, i).Value.ToString

        'BUSCA POR NOMBRE EL VALOR DE VX Y MUESTRA SU INFO Y PIC
        CaracMacroinvIMRPTableAdapter.qryCaracMacroinvIMRPbyNombre(ImrpDataSet.CaracMacroinvIMRP, nombretaxon)
        PictureBox1.ImageLocation = pathimagen & nombretaxon & ".jpg"

        'SE FIJA SI LA MUESTRA YA TIENE VALORES PREVIOS
        If imrpTaxaGrid.RowCount = 0 Then
            'no hay valores previos para la muestra
            MacroinvSpIMRPBindingSource2.AddNew()
        ElseIf imrpTaxaGrid.RowCount = 1 Then
            'hay valores previos para la muestra
        End If

        'BUSCA EL VALOR DE VX
        Dim valorvx As String
        valorvx = ValorTextBox.Text

        'RECORRE LA TABLA IMRP Y AGREGA EL VALOR DE VX AL CAMPO QUE CORRESPONDE
        For Each dc As C1.Win.C1TrueDBGrid.C1DisplayColumn In Me.imrpTaxaGrid.Splits(0).DisplayColumns
            If dc.DataColumn.DataField = nombretaxon Then
                imrpTaxaGrid.Item(0, "IdProyecto") = idproyecto
                imrpTaxaGrid.Item(0, "IdMuestra") = idmuestra
                imrpTaxaGrid.Item(0, nombretaxon) = valorvx
            End If
        Next

        'Update las grids sin grabar
        imrpTaxaGrid.Update()
        imrpTaxaGrid.Refresh()

        'MUESTRA EN LA GRILLA LOS TAXONES CARGADOS
        VerIMRP()
    End Sub

    '//// MOSTRAR LOS TAXONES YA INGRESADOS EN IBPAMP
    Private Sub VerIMRP()
        ' Este procedimiento pasa los valores no nulos de la base de datos a la MostrarDatosGrid para que el usuario
        ' vea lo que esta cargado en esa muestra, solo lo distinto de NULL y lo distinto de ZERO

        Dim k As Integer
        Dim valorimrp As String
        Dim nombretaxon2 As String
        MostrarDatosIMRP.Rows.Clear()
        For k = 3 To imrpTaxaGrid.Columns.Count - 1
            If Not imrpTaxaGrid.Item(0, k).ToString = String.Empty Then
                If Not imrpTaxaGrid.Item(0, k).ToString = "0" Then
                    nombretaxon2 = imrpTaxaGrid.Columns(k).ToString
                    valorimrp = imrpTaxaGrid.Item(0, k).ToString
                    'muestra todo en  la tabla de resultados 
                    MostrarDatosIMRP.Rows.Add(nombretaxon2, valorimrp)
                End If
            End If
        Next
    End Sub

    '//// BORRAR UN TAXÓN YA INGRESADO EN IMRP

    Private Sub btnBorrarSpIMRP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarSpIMRP.Click
        If MostrarDatosIMRP.RowCount <> 0 Then
            MostrarDatosIMRP.Rows.Remove(MostrarDatosIMRP.CurrentRow)

            ' SACO EL NOMBRE DEL TAXON
            Dim k As Integer = MostrarDatosIMRP.CurrentCell.RowIndex
            Dim nombretaxon As String = MostrarDatosIMRP.Item(0, k).Value.ToString

            'RECORRE LA TABLA IMRP Y AGREGA EL VALOR DE VX AL CAMPO QUE CORRESPONDE
            For Each dc As C1.Win.C1TrueDBGrid.C1DisplayColumn In Me.imrpTaxaGrid.Splits(0).DisplayColumns
                If dc.DataColumn.DataField = nombretaxon Then
                    imrpTaxaGrid.Item(0, "IdProyecto") = idproyecto
                    imrpTaxaGrid.Item(0, "IdMuestra") = idmuestra
                    imrpTaxaGrid.Item(0, nombretaxon) = ""
                End If
            Next
        Else
            MsgBox("No ha agregado especies a la muestra todavia")
        End If
    End Sub
    '//// ----------- FIN IMRP  ------------------
    '//// ----------- FIN IMRP  ------------------
    '//// ----------- FIN IMRP  ------------------

    '////----------------------------------------------------------------------------------

    '//// ----------- IBPAMP ------------------
    '//// ----------- IBPAMP ------------------
    '//// ----------- IBPAMP ------------------
    '//// ----------- IBPAMP ------------------


    Private Sub AgregarIBPAMP()
        '//// ESTE SUB AGREGA EL TAXON SELECCIONADO DE LA LISTA A LA SECCION IBPAMP
        'Saca categoria a la que pertenece el taxon
        Dim i, j As Integer
        i = MacroInvDataGridView.CurrentRow.Index
        j = 0
        Dim nombretaxon As String

        nombretaxon = MacroInvDataGridView.Item(j, i).Value.ToString

        'BUSCA POR NOMBRE LA CATEGORIA DEL TAXON
        'CaracMacroinvIBPAMPTableAdapter.qryCaracMacroinvIBPAMPbyNombre(IbpampDataSet.CaracMacroinvIBPAMP, nombretaxon)

        'SE FIJA SI LA MUESTRA YA TIENE VALORES PREVIOS
        If ibpampTaxaGrid.RowCount = 0 Then
            'no hay valores previos para la muestra de ibpamp
            MacroinvSpIBPAMPBindingSource.AddNew()
        ElseIf ibpampTaxaGrid.RowCount = 1 Then
            'hay valores previos para la muestra de ibpamp
        End If

        'Pregunta cuantas Unidades sistematicas hay del taxon
        Dim valorUS As String
        valorUS = USTextBox.Text
        If valorUS = "" Then
            valorUS = "1"
        End If

        'RECORRE LA TABLA IBMAMP Y AGREGA EL VALOR DE US AL TAXON QUE CORRESPONDE
        For Each dc As C1.Win.C1TrueDBGrid.C1DisplayColumn In Me.ibpampTaxaGrid.Splits(0).DisplayColumns
            If dc.DataColumn.DataField = nombretaxon Then
                ibpampTaxaGrid.Item(0, "IdProyecto") = idproyecto
                ibpampTaxaGrid.Item(0, "IdMuestra") = idmuestra
                ibpampTaxaGrid.Item(0, nombretaxon) = valorUS
            End If
        Next

        'Update las grids sin grabar
        ibpampTaxaGrid.Update()
        ibpampTaxaGrid.Refresh()
        'MUESTRA EN LA GRILLA LOS TAXONES CARGADOS
        VerIBPAMP()

    End Sub

    '//// MOSTRAR LOS TAXONES YA INGRESADOS EN IBPAMP
    Private Sub VerIBPAMP()
        ' Este procedimiento pasa los valores no nulos de la base de datos a la MostrarDatosGrid para que el usuario
        ' vea lo que esta cargado en esa muestra, solo lo distinto de NULL y lo distinto de ZERO

        Dim k As Integer
        Dim valoribpamp As String
        Dim nombretaxon2 As String
        Dim categoriataxon As String

        MostrarDatosIBPAMP.Rows.Clear()
        For k = 3 To ibpampTaxaGrid.Columns.Count - 2
            If Not ibpampTaxaGrid.Item(0, k).ToString = String.Empty Then
                If Not ibpampTaxaGrid.Item(0, k).ToString = "0" Then
                    nombretaxon2 = ibpampTaxaGrid.Columns(k).ToString
                    valoribpamp = ibpampTaxaGrid.Item(0, k).ToString

                    'Busca taxon por nombre en la tabla de categorías
                    CaracMacroinvIBPAMPTableAdapter.qryCaracMacroinvIBPAMPbyNombre(IbpampDataSet.CaracMacroinvIBPAMP, nombretaxon2)
                    categoriataxon = CaracIBPAMPDataGridView.Item(3, 0).Value.ToString()

                    'muestra todo en  la tabla de resultados 
                    MostrarDatosIBPAMP.Rows.Add(nombretaxon2, valoribpamp, categoriataxon)
                End If
            End If
        Next
    End Sub

    '//// BORRAR UN TAXÓN YA INGRESADO EN IBPAMP

    Private Sub btnBorrarSpIBPAMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarSpIBPAMP.Click
        If MostrarDatosIBPAMP.RowCount <> 0 Then

            ' SACO EL NOMBRE DEL TAXON
            Dim k As Integer = MostrarDatosIBPAMP.CurrentCell.RowIndex
            Dim nombretaxon As String = MostrarDatosIBPAMP.Item(0, k).Value.ToString

            ' BORRO EL TAXON DE LA LISTA VISIBLE
            MostrarDatosIBPAMP.Rows.Remove(MostrarDatosIBPAMP.CurrentRow)

            'RECORRE LA TABLA IBPMAMP Y SACA EL TAXON POR NOMBRE
            For Each dc As C1.Win.C1TrueDBGrid.C1DisplayColumn In Me.ibpampTaxaGrid.Splits(0).DisplayColumns
                If dc.DataColumn.DataField = nombretaxon Then
                    ibpampTaxaGrid.Item(0, "IdProyecto") = idproyecto
                    ibpampTaxaGrid.Item(0, "IdMuestra") = idmuestra
                    ibpampTaxaGrid.Item(0, nombretaxon) = ""
                End If
            Next
        Else
            MsgBox("No ha agregado especies a la muestra todavia")
        End If

        'Update las grids sin grabar
        ibpampTaxaGrid.Update()
        ibpampTaxaGrid.Refresh()
        'MUESTRA EN LA GRILLA LOS TAXONES CARGADOS
        VerIBPAMP()

    End Sub

    '//// CAMBIAR LAS US DE UN TAXÓN YA INGRESADO EN IBPAMP

    Private Sub MostrarDatosIBPAMP_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MostrarDatosIBPAMP.CellContentDoubleClick
        Dim taxonfila As String
        Dim i As Integer
        Dim nuevoUS As String
        i = MostrarDatosIBPAMP.CurrentCell.RowIndex
        taxonfila = MostrarDatosIBPAMP.Item(0, i).Value.ToString()

        nuevoUS = InputBox("Cuantas US hay de este taxón?", "Ingrese la nueva cantidad de US")
        ' Si el usuario hace click en cancelar, que le agrege por default 1 US
        If nuevoUS = "" Then nuevoUS = "1"

        'RECORRE LA TABLA IBPAMP Y CAMBIA EL VALOR EXISTENTE
        For Each dc As C1.Win.C1TrueDBGrid.C1DisplayColumn In Me.ibpampTaxaGrid.Splits(0).DisplayColumns
            If dc.DataColumn.DataField = taxonfila Then
                ibpampTaxaGrid.Item(0, "IdProyecto") = idproyecto
                ibpampTaxaGrid.Item(0, "IdMuestra") = idmuestra
                ibpampTaxaGrid.Item(0, taxonfila) = nuevoUS
            End If
        Next
        VerIBPAMP()
    End Sub

    '//// ----------- FIN IBPAMP ------------------
    '//// ----------- FIN IBPAMP ------------------
    '//// ----------- FIN IBPAMP ------------------


    '//// BOTONES DE CALCULO DE INDICES
    '////
    '////
    Private Sub btnCalcularIndices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularIndices.Click
        'Validacion IMRP
        If chkIMRP.Checked = True Then
            CalcularIMRP()
            ' TENGO QUE FIJARME SI ESTA ACTIVO EL INDICE SIGUIENTE A CALCULAR. SINO, QUE GUARDE.
        End If


        'Validacion IBPAMP
        If chkIBPAMP.Checked = True Then
            If txtUStotales.Text = "" Then
                MsgBox("Tiene que ingresar las unidades sistemáticas totales en su muestra para calcular el IBPAMP")
                Exit Sub
            Else
                If Not IsNumeric(txtUStotales.Text) Then
                    MsgBox("Las unidades sistemáticas totales del IBPAMP deben ser numéricas")
                    Exit Sub
                Else
                    ibpampTaxaGrid.Item(0, "USTotales") = txtUStotales.Text
                    ibpampTaxaGrid.Refresh()
                    CalcularIBPAMP()
                End If
            End If
        End If
        idmuestra = IdMuestraTextBox.Text
        GuardarTodo()
        CargaAdaptadores()
    End Sub

    '/////////// CALCULADORES DE INDICES //////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////


    '/////////// CALCULA IMRP//////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub CalcularIMRP()
        Dim imrpvaluetotal As Double = 0
        Dim imrpvalue As Double
        Dim imrpvalueredondeado As String
        Dim i As Integer

        'Calculo abundancia total
        For i = 0 To MostrarDatosIMRP.RowCount - 1
            imrpvalue = Val(MostrarDatosIMRP.Rows(i).Cells("Vx").Value)
            imrpvaluetotal += imrpvalue
        Next

        'redondeo imrptotal y lo paso al textbox de la db
        imrpvalueredondeado = Math.Round(imrpvaluetotal, 2)
        Dim value2 As String = imrpvalueredondeado.Replace(",", ".")
        'MsgBox(imrpvalueredondeado)
        'GRABA EL VALOR DE IMRP A LA TABLA IMRP
        If ValorIMRP.Text = "" Then
            idmuestra = IdMuestraTextBox.Text
            idproyecto = IdProyectoTextBox.Text
            IMRPBindingSource.AddNew()
            IMRPIdMuestra.Text = idmuestra
            IMRPIdProyecto.Text = idproyecto
            ValorIMRP.Text = imrpvalueredondeado
        Else
            ValorIMRP.Text = imrpvalueredondeado
        End If
        idmuestra = IdMuestraTextBox.Text
    End Sub



    '/////////// CALCULA IBPAMP////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub CalcularIBPAMP()

        ' colecto valores de la tabla

        Dim k As Integer
        Dim valoribpamp As String
        Dim nombretaxon As String
        Dim categoriataxon As String

        Cat1TextBox.Text = ""
        Cat2TextBox.Text = ""
        Cat3TextBox.Text = ""
        Cat4TextBox.Text = ""
        Cat5TextBox.Text = ""
        Cat6TextBox.Text = ""
        Cat7TextBox.Text = ""

        For k = 0 To MostrarDatosIBPAMP.Rows.Count - 1
            If Not MostrarDatosIBPAMP.Item(1, k).Value.ToString = String.Empty Then
                If Not MostrarDatosIBPAMP.Item(1, 0).Value.ToString = "0" Then
                    nombretaxon = MostrarDatosIBPAMP.Item(0, k).Value.ToString
                    valoribpamp = MostrarDatosIBPAMP.Item(1, k).Value.ToString
                    categoriataxon = MostrarDatosIBPAMP.Item(2, k).Value.ToString

                    ' Pasa los valores de la Datagridview a las textboxes para el calculo
                    If categoriataxon = "1" Then
                        Cat1TextBox.Text = Val(Cat1TextBox.Text) + Val(valoribpamp)
                    End If
                    If categoriataxon = "2" Then
                        Cat2TextBox.Text = Val(Cat2TextBox.Text) + Val(valoribpamp)
                    End If
                    If categoriataxon = "3" Then
                        Cat3TextBox.Text = Val(Cat3TextBox.Text) + Val(valoribpamp)
                    End If
                    If categoriataxon = "4" Then
                        Cat4TextBox.Text = Val(Cat4TextBox.Text) + Val(valoribpamp)
                    End If
                    If categoriataxon = "5" Then
                        Cat5TextBox.Text = Val(Cat5TextBox.Text) + Val(valoribpamp)
                    End If
                    If categoriataxon = "6" Then
                        Cat6TextBox.Text = Val(Cat6TextBox.Text) + Val(valoribpamp)
                    End If
                    If categoriataxon = "7" Then
                        Cat7TextBox.Text = Val(Cat7TextBox.Text) + Val(valoribpamp)
                    End If
                End If
            End If
        Next

        'validacion de los datos ingresados en el formulario, conversion de blanks a ceros
        If Cat1TextBox.Text = "" Then
            Cat1TextBox.Text = "0"
        End If
        If Cat2TextBox.Text = "" Then
            Cat2TextBox.Text = "0"
        End If
        If Cat3TextBox.Text = "" Then
            Cat3TextBox.Text = "0"
        End If
        If Cat4TextBox.Text = "" Then
            Cat4TextBox.Text = "0"
        End If
        If Cat5TextBox.Text = "" Then
            Cat5TextBox.Text = "0"
        End If
        If Cat6TextBox.Text = "" Then
            Cat6TextBox.Text = "0"
        End If
        If Cat7TextBox.Text = "" Then
            Cat7TextBox.Text = "0"
        End If

        Dim cat1 As Double = Val(Cat1TextBox.Text)
        Dim cat2 As Double = Val(Cat2TextBox.Text)
        Dim cat3 As Double = Val(Cat3TextBox.Text)
        Dim cat4 As Double = Val(Cat4TextBox.Text)
        Dim cat5 As Double = Val(Cat5TextBox.Text)
        Dim cat6 As Double = Val(Cat6TextBox.Text)
        Dim cat7 As Double = Val(Cat7TextBox.Text)

        If cat1 > 0 Then
            CalculoCat1()
        Else
            If cat2 > 0 Then
                CalculoCat2()
            Else
                If cat3 > 0 Then
                    CalculoCat3()
                Else
                    If cat4 > 0 Then
                        CalculoCat4()
                    Else
                        If cat5 > 0 Then
                            CalculoCat5()
                        Else
                            If cat6 > 0 Then
                                CalculoCat6()
                            Else
                                If cat7 > 0 Then
                                    CalculoCat7()
                                Else
                                    MsgBox("No hay Unidades Sistemáticas presentes de ninguna categoría. No se puede calcular el IBPAMP")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub CalculoCat1()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(ibpampTaxaGrid.Item(0, "USTotales"))
        Dim cat1 As Double = Val(Cat1TextBox.Text)
        Dim ibpampfinal As String

        ' Si US > 1
        If cat1 > 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "9"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "10"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "11"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "12"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "13"
            End If
            ' Si US = 1
        ElseIf cat1 = 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "8"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "9"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "10"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "11"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "12"
            End If
        End If

        'GRABA EL VALOR DE IBPAMP A LA TABLA IBPAMP
        If ValorIBPAMP.Text = "" Then
            idmuestra = IdMuestraTextBox.Text
            idproyecto = IdProyectoTextBox.Text
            IBPAMPBindingSource.AddNew()
            IBPAMPIdMuestra.Text = idmuestra
            IBPAMPIdProyecto.Text = idproyecto
            ValorIBPAMP.Text = ibpampfinal
        Else
            ValorIBPAMP.Text = ibpampfinal
        End If
    End Sub
    Private Sub CalculoCat2()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(ibpampTaxaGrid.Item(0, "USTotales"))
        Dim cat2 As Double = Val(Cat2TextBox.Text)
        Dim ibpampfinal As String

        ' Si US > 1
        If cat2 > 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "6"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "7"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "8"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "9"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "10"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "11"
            End If
            ' Si US = 1
        ElseIf cat2 = 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "5"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "6"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "7"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "8"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "9"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "10"
            End If
        End If

        'GRABA EL VALOR DE IBPAMP A LA TABLA IBPAMP
        If ValorIBPAMP.Text = "" Then
            idmuestra = IdMuestraTextBox.Text
            idproyecto = IdProyectoTextBox.Text
            IBPAMPBindingSource.AddNew()
            IBPAMPIdMuestra.Text = idmuestra
            IBPAMPIdProyecto.Text = idproyecto
            ValorIBPAMP.Text = ibpampfinal
        Else
            ValorIBPAMP.Text = ibpampfinal
        End If
    End Sub
    Private Sub CalculoCat3()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(ibpampTaxaGrid.Item(0, "USTotales"))
        Dim cat3 As Double = Val(Cat3TextBox.Text)
        Dim ibpampfinal As String

        ' Si US > 1
        If cat3 > 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "4"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "5"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "6"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "7"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "8"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "9"
            End If
            ' Si US = 1
        ElseIf cat3 = 1 Then
            If ibpampvaluetotal <= 1 Then
                ibpampfinal = "---"
            ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
                ibpampfinal = "3"
            ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
                ibpampfinal = "4"
            ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
                ibpampfinal = "5"
            ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
                ibpampfinal = "6"
            ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
                ibpampfinal = "7"
            ElseIf ibpampvaluetotal >= 26 Then
                ibpampfinal = "8"
            End If
        End If

        'GRABA EL VALOR DE IBPAMP A LA TABLA IBPAMP
        If ValorIBPAMP.Text = "" Then
            idmuestra = IdMuestraTextBox.Text
            idproyecto = IdProyectoTextBox.Text
            IBPAMPBindingSource.AddNew()
            IBPAMPIdMuestra.Text = idmuestra
            IBPAMPIdProyecto.Text = idproyecto
            ValorIBPAMP.Text = ibpampfinal
        Else
            ValorIBPAMP.Text = ibpampfinal
        End If
    End Sub
    Private Sub CalculoCat4()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(ibpampTaxaGrid.Item(0, "USTotales"))
        Dim cat4 As Double = Val(Cat4TextBox.Text)
        Dim ibpampfinal As String

        If ibpampvaluetotal <= 1 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
            ibpampfinal = "3"
        ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
            ibpampfinal = "4"
        ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
            ibpampfinal = "5"
        ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
            ibpampfinal = "6"
        ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
            ibpampfinal = "7"
        ElseIf ibpampvaluetotal >= 26 Then
            ibpampfinal = "---"
        End If

        'GRABA EL VALOR DE IBPAMP A LA TABLA IBPAMP
        If ValorIBPAMP.Text = "" Then
            idmuestra = IdMuestraTextBox.Text
            idproyecto = IdProyectoTextBox.Text
            IBPAMPBindingSource.AddNew()
            IBPAMPIdMuestra.Text = idmuestra
            IBPAMPIdProyecto.Text = idproyecto
            ValorIBPAMP.Text = ibpampfinal
        Else
            ValorIBPAMP.Text = ibpampfinal
        End If
    End Sub
    Private Sub CalculoCat5()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(ibpampTaxaGrid.Item(0, "USTotales"))
        Dim cat5 As Double = Val(Cat5TextBox.Text)
        Dim ibpampfinal As String

        If ibpampvaluetotal <= 1 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
            ibpampfinal = "2"
        ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
            ibpampfinal = "3"
        ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
            ibpampfinal = "4"
        ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
            ibpampfinal = "5"
        ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal >= 26 Then
            ibpampfinal = "---"
        End If

        'GRABA EL VALOR DE IBPAMP A LA TABLA IBPAMP
        If ValorIBPAMP.Text = "" Then
            idmuestra = IdMuestraTextBox.Text
            idproyecto = IdProyectoTextBox.Text
            IBPAMPBindingSource.AddNew()
            IBPAMPIdMuestra.Text = idmuestra
            IBPAMPIdProyecto.Text = idproyecto
            ValorIBPAMP.Text = ibpampfinal
        Else
            ValorIBPAMP.Text = ibpampfinal
        End If
    End Sub
    Private Sub CalculoCat6()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(ibpampTaxaGrid.Item(0, "USTotales"))
        Dim cat6 As Double = Val(Cat6TextBox.Text)
        Dim ibpampfinal As String

        If ibpampvaluetotal <= 1 Then
            ibpampfinal = "1"
        ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
            ibpampfinal = "1"
        ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
            ibpampfinal = "2"
        ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
            ibpampfinal = "3"
        ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal >= 26 Then
            ibpampfinal = "---"
        End If

        'GRABA EL VALOR DE IBPAMP A LA TABLA IBPAMP
        If ValorIBPAMP.Text = "" Then
            idmuestra = IdMuestraTextBox.Text
            idproyecto = IdProyectoTextBox.Text
            IBPAMPBindingSource.AddNew()
            IBPAMPIdMuestra.Text = idmuestra
            IBPAMPIdProyecto.Text = idproyecto
            ValorIBPAMP.Text = ibpampfinal
        Else
            ValorIBPAMP.Text = ibpampfinal
        End If
    End Sub
    Private Sub CalculoCat7()
        ' colecto valores de la form
        Dim ibpampvaluetotal As Double = Val(ibpampTaxaGrid.Item(0, "USTotales"))
        Dim cat7 As Double = Val(Cat7TextBox.Text)
        Dim ibpampfinal As String

        If ibpampvaluetotal <= 1 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 5 And ibpampvaluetotal >= 2 Then
            ibpampfinal = "0"
        ElseIf ibpampvaluetotal <= 10 And ibpampvaluetotal >= 6 Then
            ibpampfinal = "1"
        ElseIf ibpampvaluetotal <= 15 And ibpampvaluetotal >= 11 Then
            ibpampfinal = "2"
        ElseIf ibpampvaluetotal <= 20 And ibpampvaluetotal >= 16 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal <= 25 And ibpampvaluetotal >= 21 Then
            ibpampfinal = "---"
        ElseIf ibpampvaluetotal >= 26 Then
            ibpampfinal = "---"
        End If

        'GRABA EL VALOR DE IBPAMP A LA TABLA IBPAMP
        If ValorIBPAMP.Text = "" Then
            idmuestra = IdMuestraTextBox.Text
            idproyecto = IdProyectoTextBox.Text
            IBPAMPBindingSource.AddNew()
            IBPAMPIdMuestra.Text = idmuestra
            IBPAMPIdProyecto.Text = idproyecto
            ValorIBPAMP.Text = ibpampfinal
        Else
            ValorIBPAMP.Text = ibpampfinal
        End If
    End Sub

    '//////// INTERPRETACIÓN DE ÍNDICES
    '//////// INTERPRETACIÓN DE ÍNDICES
    '//////// INTERPRETACIÓN DE ÍNDICES
    '//////// INTERPRETACIÓN DE ÍNDICES
    '//////// INTERPRETACIÓN DE ÍNDICES
    '//////// INTERPRETACIÓN DE ÍNDICES
    '//////// INTERPRETACIÓN DE ÍNDICES
    '//////// INTERPRETACIÓN DE ÍNDICES
    '//////// INTERPRETACIÓN DE ÍNDICES


    Private Sub InterpretacionIndices()
        'REVISA PARA IMRP
        If ValorIMRP.Text = "" Then
            IMRPSignifica.Text = ""
            IMRPSignifica.BackColor = Color.LightGray
        Else
            IMRPSignificado()
        End If

        'REVISA PARA IBPAMP
        If ValorIBPAMP.Text = "" Then
            IBPAMPSignifica.Text = ""
            IBPAMPSignifica.BackColor = Color.LightGray
        Else
            IBPAMPSignificado()
        End If

    End Sub


    Private Sub IMRPSignificado()
        Dim indicecolor As Integer
        If ValorIMRP.Text <> "" Then
            indicecolor = Val(ValorIMRP.Text)
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
        If ValorIBPAMP.Text <> "---" Then
            indicecolor = Val(ValorIBPAMP.Text)
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

    Private Sub CodigoSitioComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoSitioComboBox.SelectedIndexChanged
        CodigoSitioTextBox.Text = CodigoSitioComboBox.Text

    End Sub

    Private Sub btnEditarSitios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarSitios.Click
        frmSitios.ShowDialog()
    End Sub

End Class