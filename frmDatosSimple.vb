Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmDatosSimple
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim tipodatos As String
    Dim modulonombre As String
    Dim idproyecto As Integer
    Dim idmuestra As String
    Dim tipoproyecto As String
    Dim nombreproyecto As String
    Dim idmuestraactual As String
    Dim isnuevamuestra As Boolean
    Dim loadtime As Boolean

    ' CONEXION A LA DB DE DATOS de PARAMETROS
    Dim con As New OleDb.OleDbConnection
    Dim sql As String
    Dim databasename As String
    Dim tablaname As String
    Dim da = New OleDb.OleDbDataAdapter
    Dim changesParametros As DataSet

    Public Sub RecibirVariables(ByVal datos As String, modulonombrelindo As String, ByVal id As Integer, ByVal tipo As String, ByVal nombre As String, ByVal muestrainicial As String)
        'RECIBO TIPO Y NUMERO DE PROYECTO DE FRMMAIN
        idproyecto = id
        tipodatos = datos
        tipoproyecto = tipo
        nombreproyecto = nombre
        idmuestra = muestrainicial
        modulonombre = modulonombrelindo
    End Sub

    Private Sub frmDatosSimple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadtime = True
        'CARGA MUESTRAS POR PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
        databasename = tipodatos
        Me.Text = modulonombre
        tablaname = "Parametros" & tipodatos

        'CARGA DATOS DE PARAMETROS 
        cargarDatos()
        'LINKEA LA DATAGRIDVIEW A ESOS DATOS CARGADOS
        BindingSource1.DataSource = DataSet1.Tables("TablaParametros")
        DataGridView1.DataSource = BindingSource1
        'Y GENERA LOS TEXTBOXES DE ESA DATAGRIDVIEW
        GenerarTextos(tipoproyecto, databasename, "CaracParametros", Me, DataGridView1)
        IrMuestra(idmuestra)
        loadtime = False
    End Sub

    Public Sub cargarDatos()

        ' CARGA DATOS
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source = " & pathapp & "\" & databasename & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablaname & " WHERE IdProyecto='" & idproyecto & "'"

        'LIMPIA EL DATASET Y RECARGA DATOS
        DataSet1.Clear()
        Dim da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(DataSet1, "TablaParametros")
        con.Close()
    End Sub

    Private Sub IrMuestra(idmuestra As String)
        Dim pos As Integer = BindingSource1.Find("IdMuestra", idmuestra)
        Dim posm As Integer = MuestrasBindingSource.Find("IdMuestra", idmuestra)
        BindingSource1.Position = pos
        MuestrasBindingSource.Position = posm


        If isnuevamuestra = True Then
            Exit Sub
        End If
        If pos = "-1" Then
            BindingSource1.AddNew()
            'Dim result As Integer = MessageBox.Show("Esta muestra aún no tiene datos de " & Me.Text & ", desea agregarlos?", "Agregar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            'If result = DialogResult.Cancel Then
            '    Exit Sub
            'ElseIf result = DialogResult.No Then
            '    Exit Sub
            'ElseIf result = DialogResult.Yes Then
            '    BindingSource1.AddNew()
            'End If
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
        'no lo ejecuta cuando esta abriendo el form por primera vez
        If loadtime = True Then
            Exit Sub
        End If


        Dim nombremuestra As String = ""
        If isnuevamuestra = False Then
            If MuestrasDataGridView.Rows.Count > 1 And IdMuestraTextBox.Text <> "" Then
                idmuestra = IdMuestraTextBox.Text
                nombremuestra = lblNombreMuestra.Text
                lblMuestraenDatos.Text = nombremuestra
                MuestrasProgressBar.Maximum = MuestrasDataGridView.RowCount - 1
                MuestrasProgressBar.Value = CInt(BindingNavigatorPositionItem.Text) - 1
                IrMuestra(idmuestra)
            End If
        End If
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

    Private Sub AddMuestra()
        Dim nombremuestra As String
        nombremuestra = InputBox("Ingrese el nombre de la muestra", , "Muestra ")

        If nombremuestra <> "" Then
            ' AGREGA MUESTRA
            'isnuevamuestra previene que pregunte si deseo agregar Datos a esa muestra, hasta que se grabe y le asigne un ID correcto
            isnuevamuestra = True

            MuestrasBindingSource.AddNew()
            MuestrasDataGridView.Item("colIdProyecto", MuestrasDataGridView.CurrentRow.Index).Value = idproyecto
            MuestrasDataGridView.Item("Nombre", MuestrasDataGridView.CurrentRow.Index).Value = nombremuestra

            ' GRABO MUESTRAS
            MuestrasBindingSource.EndEdit()
            MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

            ' RECARGA ADAPTADORES
            Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)

            'isnuevamuestra previene que pregunte si deseo agregar datos a esa muestra, hasta que se grabe y le asigne un ID correcto
            'Reseteo isnuevamuestra y me voy a la nueva muestra agregada

            isnuevamuestra = False
            MuestrasBindingSource.MoveLast()
        Else
            'CANCELA EL INPUT
            Exit Sub
        End If
    End Sub

    Private Sub DeleteMuestra()
        Dim idmuestraborrar As String

        If Not MuestrasDataGridView.RowCount = 1 Then
            If MessageBox.Show("Esta seguro de eliminar esta muestra? Eliminaria todos los datos asociados con esta muestra.", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                isnuevamuestra = True
                idmuestraborrar = MuestrasDataGridView.CurrentRow.Cells.Item(0).Value.ToString
                MsgBox("Borrando muestra " & idmuestraborrar)

                ' BORRA MUESTRA CON IDMUESTRA = IDMUESTRABORRAR 
                ' EN EL RESTO DE LAS LAS TABLAS

                ' TABLA DE MUESTRA 
                MuestrasBindingSource.RemoveCurrent()
                MuestrasTableAdapter.Update(Me.Scilla10DataSet.Muestras)

                ' TABLA DE datos
                If DataGridView1.RowCount = 1 Then
                    DirectCast(BindingSource1.Current, DataRowView).Delete()
                    GuardarDatos(idmuestra)
                End If
                isnuevamuestra = False
                MuestrasBindingSource.MoveFirst()
            End If
        Else
            MsgBox("No hay muestras en este proyecto")
        End If
        MsgBox("Muestra " & idmuestraborrar & " borrada")
    End Sub

    Private Sub GrabarMuestra()
        ' SI ES UNA NUEVA MUESTRA, GRABO LA MUESTRA, MUEVO EL RECORDSET AL FINAL
        ' Y HAGO UN DATO NUEVO

        If isnuevamuestra = True Then
            ' GRABO MUESTRAS
            MuestrasBindingSource.EndEdit()
            MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

            ' RECARGA ADAPTADORES
            Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
            MuestrasBindingSource.MoveLast()
        Else
            MuestrasBindingSource.EndEdit()
            MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

            'RECARGA ADAPTADORES
            Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
        End If
    End Sub

    Private Sub GuardarDatos(idmuestra As String)

        ' CARGA DA
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source = " & pathapp & "\" & databasename & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablaname & " WHERE Idmuestra='" & idmuestra & "'"
        Dim da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(DataSet1, "tablaparametros")

        'GUARDA
        BindingSource1.EndEdit()
        Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(da)
        da.InsertCommand = oledbCmdBuilder.GetInsertCommand()
        da.DeleteCommand = oledbCmdBuilder.GetDeleteCommand()

        changesParametros = DataSet1.GetChanges()
        If changesParametros IsNot Nothing Then
            da.Update(DataSet1.Tables("TablaParametros"))
        End If
        DataSet1.AcceptChanges()
        'MsgBox("Datos guardados correctamente!")
        con.Close()

        'VUELVE A RECARGAR TODO EL PROYECTO
        cargarDatos()
        IrMuestra(idmuestra)
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

    Private Sub btnEliminarDatos_Click(sender As Object, e As EventArgs) Handles btnEliminarDatos.Click
        isnuevamuestra = True
        DataGridView1.Delete(DataGridView1.Row)
        GuardarDatos(idmuestra)
        DataGridView1.Row = 0
        idmuestraactual = DataGridView1.Item(0, "IdMuestra").ToString
        IrMuestra(idmuestraactual)
        isnuevamuestra = False

    End Sub

    Private Sub btnGuardarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDatos.Click
        DataGridView1.Item(DataGridView1.Row, "IdMuestra") = idmuestra
        DataGridView1.Item(DataGridView1.Row, "IdProyecto") = idproyecto
        'Recarga el adaptador de Datos
        GuardarDatos(idmuestra)
    End Sub

    Private Sub EliminarActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarActualToolStripMenuItem.Click
        DeleteMuestra()
    End Sub

    Private Sub SalirAWindowsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EnciclopediaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnciclopediaToolStripMenuItem1.Click
        frmEnciclopedia.Show()
    End Sub

    Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click
        frmImportar.Show()
        frmImportar.cmbTipoDatos.SelectedValue = tipodatos
        frmImportar.cmbProyecto.SelectedValue = nombreproyecto
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        AddMuestra()
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   CARGA AVANZADA DE DATOS
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub btnCargaAvanzada_Click(sender As Object, e As EventArgs) Handles btnCargaAvanzada.Click
        'CAGA LA LISTA DE MUESTRAS EN EL PROYECTO AL COSTADO DE LA FORM
        Dim muestrasavanzada As New BindingSource
        muestrasavanzada.DataSource = Scilla10DataSet
        muestrasavanzada.DataMember = "Muestras"
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)
        dgvMuestras.DataSource = muestrasavanzada

        ' CARGA DATOS
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source = " & pathapp & "\" & databasename & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablaname & " WHERE IdProyecto='" & idproyecto & "'"

        'LIMPIA EL DATASET Y RECARGA DATOS
        DataSet1.Clear()
        Dim da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(DataSet1, "TablaParametros")
        con.Close()

        'ESCONDE ITEMS DE LA BARRA QUE NO SIRVEN Y ESTILA
        btnCargaAvanzada.Visible = False
        btnCargaBasica.Visible = True
        ComboBox1.Visible = False
        ToolStripLabel1.Visible = False
        BindingNavigatorCountItem.Visible = False
        BindingNavigatorMoveFirstItem.Visible = False
        BindingNavigatorMoveLastItem.Visible = False
        BindingNavigatorMoveNextItem.Visible = False
        BindingNavigatorMovePreviousItem.Visible = False
        BindingNavigatorPositionItem.Visible = False
        ToolStripSeparator2.Visible = False
        BindingNavigatorSeparator2.Visible = False
        MuestrasProgressBar.Visible = False
        btnGuardarAvanzado.Visible = True
        btnAgregarAvanzado.Location = New Point(5, 27)
        grpMuestras.Visible = True
        dgvMuestras.Visible = True
        btnAbrirenExcel.Visible = True
        grpMuestras.BringToFront()
        lblMuestraenDatos.BringToFront()

        'REEMPLAZA LOS HEADERS DE LA DATAGRID POR SUS NOMBRES DE PARAMETROS
        'conecta a db parametros
        Dim con1 As New OleDb.OleDbConnection
        Dim ds1 As New DataSet
        Dim sql1 As String
        con1.Close()
        con1.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & databasename & ".mdb"
        con1.Open()
        sql1 = "SELECT * FROM CaracParametros"
        Dim da1 = New OleDb.OleDbDataAdapter(sql1, con1)
        da1.Fill(ds1, "TablaCarac")

        'Pinta de azul las primeras tres columnas
        DataGridView1.Splits(0).DisplayColumns.Item(0).HeadingStyle.ForeColor = Color.Blue
        DataGridView1.Splits(0).DisplayColumns.Item(1).HeadingStyle.ForeColor = Color.Blue
        DataGridView1.Splits(0).DisplayColumns.Item(2).HeadingStyle.ForeColor = Color.Blue
        DataGridView1.Splits(0).DisplayColumns.Item(2).Visible = False
        DataGridView1.Splits(0).DisplayColumns.Item(0).Visible = False

        'Recorre la datagrid, compara el header con el de la tabla CaracParametros
        For i As Integer = 3 To DataGridView1.Columns.Count - 1
            For j As Integer = 0 To ds1.Tables("TablaCarac").Rows.Count - 1
                If "p" & ds1.Tables("TablaCarac").Rows(j).Item(0).ToString = DataGridView1.Columns(i).Caption Then
                    DataGridView1.Splits(0).DisplayColumns.Item(i).HeadingStyle.ForeColor = Color.Blue
                    DataGridView1.Columns(i).Caption = ds1.Tables("TablaCarac").Rows(j).Item("NombreParametro").ToString
                    Exit For
                End If
            Next
        Next

        'esconde las columnas que no estan pintadas de azul (que no tienen un caracparametro correspondiente)
        For i = 0 To DataGridView1.Columns.Count - 1
            If DataGridView1.Splits(0).DisplayColumns.Item(i).HeadingStyle.ForeColor <> Color.Blue Then
                DataGridView1.Splits(0).DisplayColumns.Item(i).Visible = False
            End If
        Next

        'vuelve a pintar las columnas que sobran de negro
        For i = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Splits(0).DisplayColumns.Item(i).HeadingStyle.ForeColor = Color.Black
        Next

        'STYLE LA GRID UN POCO
        For i = 0 To DataGridView1.Columns.Count - 1
            Dim myfont As New Font("Sans Serif", 10, FontStyle.Regular)
            DataGridView1.Splits(0).DisplayColumns.Item(i).HeadingStyle.Font = myfont
            DataGridView1.Splits(0).ColumnCaptionHeight = 50
        Next
        DataGridView1.Splits(0).DisplayColumns.Item(0).Width = 20
        DataGridView1.Splits(0).DisplayColumns.Item(1).Width = 50

        ' Mueve la DataGridView a posicion
        DataGridView1.Visible = True
        DataGridView1.Dock = DockStyle.Fill
        grpMuestras.Dock = DockStyle.Left
        DataGridView1.BringToFront()

        'ESTILO DE LA TABLA DE MUESTRAS
        dgvMuestras.Columns("IdProyecto").Visible = False
        dgvMuestras.Columns("IdMuestra").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        dgvMuestras.RowHeadersVisible = False
        For i = 3 To dgvMuestras.Columns.Count - 1
            dgvMuestras.Columns(i).Visible = False
        Next
        'dgvMuestras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvMuestras.Columns("Nombre").Width = 150
        grpMuestras.Width = dgvMuestras.Columns("IdMuestra").Width + dgvMuestras.Columns("Nombre").Width + 20

    End Sub


    Private Sub btnCargaBasica_Click(sender As Object, e As EventArgs) Handles btnCargaBasica.Click

        'ESCONDE ITEMS DE LA BARRA QUE NO SIRVEN Y ESTILA
        btnCargaAvanzada.Visible = True
        btnCargaBasica.Visible = False
        ComboBox1.Visible = True
        ToolStripLabel1.Visible = True
        BindingNavigatorCountItem.Visible = True
        BindingNavigatorMoveFirstItem.Visible = True
        BindingNavigatorMoveLastItem.Visible = True
        BindingNavigatorMoveNextItem.Visible = True
        BindingNavigatorMovePreviousItem.Visible = True
        BindingNavigatorPositionItem.Visible = True
        ToolStripSeparator2.Visible = True
        BindingNavigatorSeparator2.Visible = True
        MuestrasProgressBar.Visible = True
        btnGuardarAvanzado.Visible = False
        grpMuestras.Visible = False
        dgvMuestras.Visible = False
        btnAbrirenExcel.Visible = False

        'CARGA MUESTRAS POR PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)

        DataGridView1.DataSource = Nothing
        BindingSource1.DataSource = DataSet1.Tables("TablaParametros")
        DataGridView1.DataSource = BindingSource1
        DataGridView1.Visible = False
    End Sub


    Private Sub btnGuardarAvanzado_Click(sender As Object, e As EventArgs) Handles btnGuardarAvanzado.Click
        DataGridView1.Item(DataGridView1.Row, "IdMuestra") = idmuestra
        DataGridView1.Item(DataGridView1.Row, "IdProyecto") = idproyecto

        ' CARGA DA
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source = " & pathapp & "\" & databasename & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablaname & " WHERE Idmuestra='" & idmuestra & "'"
        Dim da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(DataSet1, "tablaparametros")

        'GUARDA
        BindingSource1.EndEdit()
        Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(da)
        da.InsertCommand = oledbCmdBuilder.GetInsertCommand()
        da.DeleteCommand = oledbCmdBuilder.GetDeleteCommand()

        changesParametros = DataSet1.GetChanges()
        If changesParametros IsNot Nothing Then
            da.Update(DataSet1.Tables("TablaParametros"))
        End If
        DataSet1.AcceptChanges()
        'MsgBox("Datos guardados correctamente!")
        con.Close()

        'CARGA TODAS LAS MUESTRAS DEL PROYECTO
        Me.MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyecto)

        ' CARGA DATOS
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source = " & pathapp & "\" & databasename & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablaname & " WHERE IdProyecto='" & idproyecto & "'"

        'LIMPIA EL DATASET Y RECARGA DATOS
        DataSet1.Clear()
        Dim da1 = New OleDb.OleDbDataAdapter(sql, con)
        da1.Fill(DataSet1, "TablaParametros")
        con.Close()
    End Sub

    Private Sub btnAgregarAvanzado_Click(sender As Object, e As EventArgs) Handles btnAgregarAvanzado.Click
        Dim idmuestraagregar As String = dgvMuestras.CurrentRow.Cells(0).Value.ToString
        Dim muestranueva As Boolean = False

        'SE FIJA SI YA HAY DATOS PARA LA MUESTRA
        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim idmuestraactual As String = DataGridView1.Item(i, "IdMuestra").ToString
            If idmuestraactual = idmuestraagregar Then
                MsgBox("La muestra ya tiene datos. Editelos desde la grilla principal")
                muestranueva = False
                Exit For
            Else
                muestranueva = True
            End If
        Next

        'SI NO HAY UNA MUESTRA NUEVA YA
        If muestranueva = True Then
            lblMuestraenDatos.Text = "Agregando datos para la muestra " & idmuestraagregar
            BindingSource1.AddNew()
            DataGridView1.Item(DataGridView1.RowCount - 1, "IdMuestra") = dgvMuestras.CurrentRow.Cells(0).Value.ToString
            DataGridView1.Item(DataGridView1.RowCount - 1, "IdProyecto") = idproyecto
        End If

    End Sub


    Private Sub dgvMuestras_Click(sender As Object, e As EventArgs) Handles dgvMuestras.Click
        Dim idmuestraactual As String = dgvMuestras.CurrentRow.Cells(0).Value.ToString
        lblMuestraenDatos.Text = dgvMuestras.CurrentRow.Cells(2).Value.ToString
        Dim muestranueva As Boolean = False
        DataGridView1.SelectedRows.Clear()
        btnAgregarAvanzado.Visible = False

        'SE FIJA SI YA HAY DATOS PARA LA MUESTRA
        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim idmuestrabuscar As String = DataGridView1.Item(i, "IdMuestra").ToString
            If idmuestraactual = idmuestrabuscar Then
                DataGridView1.SelectedRows.Add(i)
                muestranueva = False
                Exit For
            Else
                muestranueva = True
            End If
        Next
        'SI NO HAY UNA MUESTRA NUEVA YA
        If muestranueva = True Then
            lblMuestraenDatos.Text = "La muestra no tiene datos todavía"
            btnAgregarAvanzado.Visible = True
        End If
    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   EXPORTAR A EXCEL
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub btnAbrirenExcel_Click(sender As Object, e As EventArgs) Handles btnAbrirenExcel.Click
        'Copia la DataGridView1 a dgvConvertida, con valores y estilos, para convertir de una C1 a una DGV comun
        Dim dgvConvertida As New DataGridView

        For i As Integer = 0 To DataGridView1.Splits(0).DisplayColumns.Count - 1
            Dim newcol As New DataGridViewTextBoxColumn
            dgvConvertida.Columns.Add(newcol)
        Next

        'agrega headers a la dgvconvertida
        dgvConvertida.Rows.Add()

        For i = 0 To DataGridView1.Splits(0).DisplayColumns.Count - 1
            If DataGridView1.Splits(0).DisplayColumns.Item(i).Visible = True Then
                dgvConvertida.Item(i, 0).Value = DataGridView1.Splits(0).DisplayColumns.Item(i).Name
            End If
        Next

        For i As Integer = 0 To DataGridView1.RowCount - 1
            dgvConvertida.Rows.Add()
        Next

        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.Splits(0).DisplayColumns.Count - 1
                If DataGridView1.Splits(0).DisplayColumns.Item(j).Visible = True Then
                    dgvConvertida.Item(j, i + 1).Value = DataGridView1.Item(i, j)
                End If
            Next
        Next

        ExportarDGVaXLS(dgvConvertida, tipodatos)

    End Sub

    Private Sub CerrarVentanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class