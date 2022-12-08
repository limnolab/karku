Public Class frmIDP
    Dim idmuestra As Integer
    Dim idproyecto As Integer
    Dim pathimagen As String = My.Application.Info.DirectoryPath & "\fotosespecies\"

    Public Sub SetReceive(ByVal Value As Integer, ByVal Value2 As Integer)
        idmuestra = Value
        idproyecto = Value2
    End Sub

    Private Sub frmIDP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SitiosDataSet.Sitios' Puede moverla o quitarla según sea necesario.
        Me.SitiosTableAdapter.Fill(Me.SitiosDataSet.Sitios)
        'CARGO TODAS LAS MUESTRAS PERTENECIENTES AL PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
        'CARGA DE ADAPTADORES RELACIONADOS CON LOS INDICES
        CargaAdaptadores()

        'Deshabilita/habilita el boton de calcular
        If MostrarDatosGrid.RowCount <> 0 Then
            btnCalcularIDP.Enabled = True
        End If

        If IDPTextBox.Text = "" Then
            IDPSignifica.Text = ""
            IDPSignifica.BackColor = Color.LightGray
        Else
            IDPSignificado()
        End If
    End Sub

    Private Sub frmIDP_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        GuardarTodo()
    End Sub

    Private Sub GuardarTodo()

        ' GRABO DIATOMEAS
        Me.DiatomeasSpParte2BindingSource1.EndEdit()
        Me.DiatomeasSpBindingSource.EndEdit()
        DiatomeasSpTableAdapter.Update(IdpDataSet.DiatomeasSp)
        DiatomeasSpParte2TableAdapter.Update(IdpDataSet.DiatomeasSpParte2)

        ' GRABO IDP
        Me.IDPBindingSource.EndEdit()
        IDPTableAdapter.Update(IdpDataSet.IDP)

        'GRABO MUESTRAS
        Me.MuestrasBindingSource.EndEdit()
        Me.MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

        'Recarga los adaptadores en frmMuestrasArroyoPamp
        frmAPampeano.MuestrasTableAdapter.qryMuestrasByMuestra(Scilla10DataSet.Muestras, idmuestra)
        frmAPampeano.IDPTableAdapter.qryIDPbyIdMuestra(frmAPampeano.IdpDataSet.IDP, idmuestra)
        frmAPampeano.GrabarMuestra()
    End Sub

    Private Sub CargaAdaptadores()
        'BUSCO LA MUESTRA SELECCIONADA
        Dim i As Integer

        For i = 0 To MuestrasDataGridView.RowCount
            If MuestrasDataGridView.Item(0, i).Value = idmuestra Then
                MuestrasDataGridView.CurrentCell = MuestrasDataGridView.Item(0, i)
            End If
        Next

        If Not idmuestra.ToString = String.Empty Then
            'RECARGA LOS ADAPTADORES DE ESA MUESTRA PARA LOS INDICES
            Me.IDPTableAdapter.qryIDPbyIdMuestra(Me.IdpDataSet.IDP, idmuestra)
            Me.DiatomeasSpTableAdapter.qryDiatomeasSpByIdMuestras(Me.IdpDataSet.DiatomeasSp, idmuestra)
            Me.DiatomeasSpParte2TableAdapter.qryDiatomeasSpParte2ByIdMuestras(Me.IdpDataSet.DiatomeasSpParte2, idmuestra)

            ' SI LA MUESTRA YA TIENE DATOS CARGADOS DE ÍNDICES, LOS MUESTRO EN LAS GRILLAS
            MostrarDatos()
        End If

        ' CARGA LAS CARACTERÍSTICAS DE LOS TAXONES PARA EL IDP
        Me.CaracDiatomeasTableAdapter.Fill(Me.IdpDataSet.CaracIDP)
    End Sub

    '///////////// BARRA DE NAVEGACION DE MUESTRAS
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        ' CUANDO APRIETO NUEVA MUESTRA ACTIVA Y DESACTIVA CONTROLES
        grpMuestra.Enabled = True
        grpMuestra.BackColor = Color.LightSteelBlue
        grpBuscarEspecie.Enabled = False
        grpBuscarEspecie.BackColor = Color.White
        grpResultadoEspecie.Enabled = False
        grpResultadoEspecie.BackColor = Color.White
        grpCalcularIDP.Enabled = False
        grpCalcularIDP.BackColor = Color.White
        btnCalcularIDP.Enabled = False
        EditTootStripButton.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub EditTootStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditTootStripButton.Click
        ' CUANDO APRIETO EDITAR ACTIVA Y DESACTIVA CONTROLES
        grpMuestra.Enabled = True
        grpMuestra.BackColor = Color.LightSteelBlue
        grpBuscarEspecie.Enabled = False
        grpResultadoEspecie.Enabled = False
        grpCalcularIDP.Enabled = False
        btnCalcularIDP.Enabled = False
        EditTootStripButton.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False
        IdProyectoTextBox.Text = idproyecto
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        IdProyectoTextBox.Text = idproyecto
        grpMuestra.Enabled = False
        grpMuestra.BackColor = Color.White
        grpBuscarEspecie.Enabled = True
        grpBuscarEspecie.BackColor = Color.LightSteelBlue
        grpResultadoEspecie.Enabled = True
        grpResultadoEspecie.BackColor = Color.LightSteelBlue
        grpCalcularIDP.Enabled = True
        grpCalcularIDP.BackColor = Color.LightSteelBlue
        btnCalcularIDP.Enabled = True
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
    '/// ACTUALIZA INDICES CUANDO CAMBIO DE MUESTRA
    Private Sub MuestrasBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuestrasBindingSource.PositionChanged
        If Not idmuestra.ToString = String.Empty Then
            If Not IdMuestraTextBox.Text = String.Empty Then
                'SE FIJA LA MUESTRA ACTUAL
                idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
                'RECARGA LOS ADAPTADORES DE ESA MUESTRA PARA LOS INDICES
                Me.IDPTableAdapter.qryIDPbyIdMuestra(Me.IdpDataSet.IDP, idmuestra)
                Me.DiatomeasSpTableAdapter.qryDiatomeasSpByIdMuestras(Me.IdpDataSet.DiatomeasSp, idmuestra)
                Me.DiatomeasSpParte2TableAdapter.qryDiatomeasSpParte2ByIdMuestras(Me.IdpDataSet.DiatomeasSpParte2, idmuestra)

                ' SI LA MUESTRA YA TIENE DATOS CARGADOS DE ÍNDICES, LOS MUESTRO EN LAS GRILLAS
                MostrarDatos()
            End If
        End If
    End Sub

    Private Sub Modificardensidad()
        Dim densidadnueva As String
        densidadnueva = DensidadTextBox.Text

        'Chequea en que tabla esta la especie y agrega la densidad nueva
        'Tabla 1
        For Each dc As C1.Win.C1TrueDBGrid.C1DisplayColumn In Me.DiatomeasSpDataGridView1.Splits(0).DisplayColumns
            If dc.DataColumn.DataField = AcronimoTextBox.Text Then
                DiatomeasSpDataGridView1.Item(0, "IdMuestras") = idmuestra
                DiatomeasSpParte2DataGridView1.Item(0, "IdMuestras") = idmuestra
                DiatomeasSpDataGridView1.Item(0, AcronimoTextBox.Text) = densidadnueva
            End If
        Next
        'Tabla 2
        For Each dc As C1.Win.C1TrueDBGrid.C1DisplayColumn In Me.DiatomeasSpParte2DataGridView1.Splits(0).DisplayColumns
            If dc.DataColumn.DataField = AcronimoTextBox.Text Then
                DiatomeasSpDataGridView1.Item(0, "IdMuestras") = idmuestra
                DiatomeasSpParte2DataGridView1.Item(0, "IdMuestras") = idmuestra
                DiatomeasSpParte2DataGridView1.Item(0, AcronimoTextBox.Text) = densidadnueva
            End If
        Next

        MostrarDatos()

    End Sub

    Private Sub btnCalcularIDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularIDP.Click
        CalcularIDP()
    End Sub
    Private Sub MostrarDatos()
        ' Este procedimiento pasa los valores no nulos de la base de datos a la MostrarDatosGrid para que el usuario
        ' vea lo que esta cargado en esa muestra, solo lo distinto de NULL y lo distinto de ZERO

        Dim i As Integer
        Dim nombreespecie As String
        Dim densidadespecie As String
        Dim valoridp As String
        MostrarDatosGrid.Rows.Clear()
        For i = 1 To DiatomeasSpDataGridView1.Columns.Count - 1
            If Not DiatomeasSpDataGridView1.Item(0, i).ToString = String.Empty Then
                If Not DiatomeasSpDataGridView1.Item(0, i).ToString = "0" Then
                    nombreespecie = DiatomeasSpDataGridView1.Columns(i).ToString
                    densidadespecie = DiatomeasSpDataGridView1.Item(0, i).ToString

                    'busca el nombre de la especie en la base de datos de caracteristicas
                    Me.CaracDiatomeasTableAdapter.qryCaracDiatomeasByAcronimo(Me.IdpDataSet.CaracIDP, nombreespecie)
                    valoridp = IDPTextBox.Text
                    'muestra todo en  la tabla de resultados 
                    MostrarDatosGrid.Rows.Add(nombreespecie, densidadespecie, valoridp)
                End If
            End If
        Next
        For i = 1 To DiatomeasSpParte2DataGridView1.Columns.Count - 1
            If Not DiatomeasSpParte2DataGridView1.Item(0, i).ToString = String.Empty Then
                If Not DiatomeasSpParte2DataGridView1.Item(0, i).ToString = "0" Then
                    nombreespecie = DiatomeasSpParte2DataGridView1.Columns(i).ToString
                    densidadespecie = DiatomeasSpParte2DataGridView1.Item(0, i).ToString

                    'busca el nombre de la especie en la base de datos de caracteristicas
                    Me.CaracDiatomeasTableAdapter.qryCaracDiatomeasByAcronimo(Me.IdpDataSet.CaracIDP, nombreespecie)
                    valoridp = IDPTextBox.Text
                    'muestra todo en  la tabla de resultados 
                    MostrarDatosGrid.Rows.Add(nombreespecie, densidadespecie, valoridp)
                End If
            End If
        Next
    End Sub

    Private Sub SearchTextBox_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.LostFocus
        'Controla si la especie existe
        Dim acronimovar As String
        acronimovar = SearchTextBox.Text
        Me.CaracDiatomeasTableAdapter.qryCaracDiatomeasByAcronimo(Me.IdpDataSet.CaracIDP, acronimovar)

        If AcronimoTextBox.Text = "" Then
            Searchbynamecmb.SelectedIndex = 0
            NombreTextBox.Text = "ESPECIE NO ENCONTRADA"
            btnAgregar.Enabled = False
            btnCalcularIDP.Enabled = False
        Else
            Searchbynamecmb.Text = NombreTextBox.Text
        End If

        'Carga la foto de la especie
        PictureBox1.ImageLocation = pathimagen & AcronimoTextBox.Text & ".jpg"

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        '----- Control de datos
        If SearchTextBox.Text = "" Then
            MsgBox("Debe ingresar una especie")
            Exit Sub
        End If
        If DensidadTextBox.Text = "" Then
            MsgBox("Debe ingresar una densidad de la especie")
            Exit Sub
        End If

        If Not IsNumeric(DensidadTextBox.Text) Then
            MessageBox.Show("La densidad de la especie debe ser numerica")
            Exit Sub
        End If

        ' SE FIJA QUE HAYA YA HECHO UN RECORD, SINO LO CREA

        If IDPDataGridView.RowCount = 1 Then
            IDPBindingSource.AddNew()
            DiatomeasSpBindingSource.AddNew()
            DiatomeasSpParte2BindingSource1.AddNew()

        Else
            idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
            idproyecto = Convert.ToInt32(IdProyectoTextBox.Text)

        End If

        Modificardensidad()

        SearchTextBox.Text = ""
        DensidadTextBox.Text = ""
        btnCalcularIDP.Enabled = True
        btnAgregar.Enabled = False
    End Sub
    Private Sub CalcularIDP()
        Dim abundanciatotal As Double = 0
        Dim idptotal As Double
        Dim idptotalredondeado As String
        Dim idpsp As Double
        Dim abundaciasp As Double
        Dim idpparcial
        Dim i As Integer

        idmuestra = Convert.ToInt32(IdMuestraTextBox.Text)
        idproyecto = Convert.ToInt32(IdProyectoTextBox.Text)

        'Setea el numero de muestra y graba
        DiatomeasSpDataGridView1.Item(0, "IdMuestras") = idmuestra
        DiatomeasSpParte2DataGridView1.Item(0, "IdMuestras") = idmuestra

        'Calculo abundancia total
        For i = 0 To MostrarDatosGrid.RowCount - 1
            abundanciatotal += MostrarDatosGrid.Rows(i).Cells("Densidad").Value
        Next

        'Calculo el IDP parcial para cada sp y los voy sumando a idptotal
        For i = 0 To MostrarDatosGrid.RowCount - 1
            idpsp = MostrarDatosGrid.Rows(i).Cells("IDP").Value
            abundaciasp = MostrarDatosGrid.Rows(i).Cells("Densidad").Value
            idpparcial = (idpsp * abundaciasp) / abundanciatotal
            idptotal += idpparcial
        Next
        'redondeo idptotal y lo paso al textbox de la db
        idptotalredondeado = Math.Round(idptotal, 2)
        Dim value2 As String = idptotalredondeado.Replace(",", ".")
        ValorTextBox.Text = value2


        IdMuestraTextBox1.Text = idmuestra
        IdProyectoTextBox1.Text = idproyecto
        ValorTextBox1.Text = value2

        'grabo
        IDPBindingSource.EndEdit()
        IDPTableAdapter.Update(IdpDataSet.IDP)

        MuestrasBindingSource.EndEdit()
        MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

        DiatomeasSpBindingSource.EndEdit()
        DiatomeasSpTableAdapter.Update(IdpDataSet.DiatomeasSp)
        DiatomeasSpParte2BindingSource1.EndEdit()
        DiatomeasSpParte2TableAdapter.Update(IdpDataSet.DiatomeasSpParte2)

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Searchbynamecmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Searchbynamecmb.SelectedIndexChanged
        Dim nombretaxon As String
        nombretaxon = Searchbynamecmb.Text
        CaracDiatomeasTableAdapter.qryCaracDiatomeasByNombre(IdpDataSet.CaracIDP, nombretaxon)
        SearchTextBox.Text = AcronimoTextBox.Text
        PictureBox1.ImageLocation = pathimagen & AcronimoTextBox.Text & ".jpg"
    End Sub

    Private Sub DensidadTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DensidadTextBox.TextChanged
        If NombreTextBox.Text <> "ESPECIE NO ENCONTRADA" Then
            btnAgregar.Enabled = True
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

    Private Sub CodigoSitioComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoSitioComboBox.SelectedIndexChanged
        CodigoSitioTextBox.Text = CodigoSitioComboBox.Text
    End Sub

    Private Sub btnEditarSitios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarSitios.Click
        frmSitios.ShowDialog()
    End Sub

End Class
