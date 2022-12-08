Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Public Class frmImportar
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim excelpath As String
    'VARIABLES para importar parametros
    Dim dsParametros As New DataSet
    Dim daParametros As New OleDb.OleDbDataAdapter
    Dim conParametros As New OleDb.OleDbConnection
    Dim changesParametros As DataSet
    Dim sqlParametros As String

    'VARIABLES para cargar parametros
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim changes As DataSet
    'VARIABLES para el excel
    Dim w As Workbook

    'VARIABLES de CONFIG de modulos
    Dim nombremodulo As String
    Dim codigomodulo As String
    Dim tipomodulo As String


    Private Sub ProyectosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProyectosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Scilla10DataSet)
    End Sub

    Private Sub frmImportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ModulosTableAdapter.Fill(Me.ConfigDataSet.Modulos)
        Me.MuestrasTableAdapter.Fill(Me.Scilla10DataSet.Muestras)
        Me.ProyectosTableAdapter.Fill(Me.Scilla10DataSet.Proyectos)

    End Sub


    Private Sub cargarColumnasDatosSimples(databasename As String, tabladatos As String, outputGrid As DataGridView)
        ' CONECTA A LA TABLA DE PARAMETROS
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim sql As String
        con.Close()
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & databasename & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tabladatos
        Dim da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Tabla")

        'CARGA LA OUTPUTGRID Y EL COMBOBOX
        outputGrid.DataSource = ds.Tables("Tabla")

        'ESCONDE LOS CAMPOS QUE NO SIRVEN
        For i As Integer = 0 To outputGrid.ColumnCount - 1
            If outputGrid.Columns(i).HeaderText <> "NombreParametro" AndAlso outputGrid.Columns(i).HeaderText <> "TipoCampo" AndAlso outputGrid.Columns(i).HeaderText <> "Unidades" Then
                outputGrid.Columns(i).Visible = False
            End If
        Next
        con.Close()
    End Sub

    Private Sub cargarColumnasComunidades(databasename As String, tabladatos As String, outputgrid As DataGridView)
        ' CONECTA A LA TABLA DE TAXONES
        Dim conTaxones As New OleDb.OleDbConnection
        Dim dsTaxones As New DataSet
        Dim sqlTaxones As String
        conTaxones.Close()
        conTaxones.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & databasename & ".mdb"
        conTaxones.Open()
        sqlTaxones = "SELECT * FROM " & tabladatos
        Dim daTaxones = New OleDb.OleDbDataAdapter(sqlTaxones, conTaxones)
        daTaxones.Fill(dsTaxones, "Tabla")

        'CARGA LA OUTPUTGRID
        outputgrid.DataSource = dsTaxones.Tables("Tabla")
        'ESCONDE LOS CAMPOS QUE NO SIRVEN
        For i As Integer = 0 To outputgrid.ColumnCount - 1
            If outputgrid.Columns(i).HeaderText <> "IdTaxon" AndAlso outputgrid.Columns(i).HeaderText <> "Nombre" AndAlso outputgrid.Columns(i).HeaderText <> "Acronimo" Then
                outputgrid.Columns(i).Visible = False
            End If
        Next
        conTaxones.Close()
    End Sub

    Private Sub btnAbrirExcel_Click(sender As Object, e As EventArgs) Handles btnAbrirExcel.Click
        seleccionarExcel()
    End Sub

    Private Sub cmbSheets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSheets.SelectedIndexChanged
        abrirExcel(cmbSheets.SelectedIndex + 1)
    End Sub

    'ESTO ABRE EL DIALOGO PARA SELECCIONAR EL EXCEL
    Private Sub seleccionarExcel()
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim fi As New FileInfo(OpenFileDialog.FileName)
            Dim FileName As String = OpenFileDialog.FileName
            excelpath = fi.FullName
            abrirExcel(1)
        Else
            Exit Sub
        End If
    End Sub

    'ESTO ABRE EL EXCEL EN LA HOJA SELECCIONADA
    Private Sub abrirExcel(selectedsheet As Integer)
        ' Create new Application.
        Dim excel As Application = New Application
        w = excel.Workbooks.Open(excelpath)

        ' LIMPIO TODO ANTES DE ARRANCAR
        cmbSheets.Items.Clear()
        dgvInputSamples.Rows.Clear()
        dgvInputSamples.Columns.Clear()
        dgvInputColumns.DataSource = Nothing
        dgvInputColumns.Rows.Clear()
        dgvInputColumns.Columns.Clear()
        dgvComenzar.DataSource = Nothing
        dgvComenzar.Rows.Clear()

        For i As Integer = 1 To w.Sheets.Count
            Dim Sheet1 As Excel.Worksheet = w.Sheets(i)
            cmbSheets.Items.Add(Sheet1.Name)
        Next

        Dim sheet As Worksheet = w.Sheets(selectedsheet)
        ' Get range.
        Dim r As Range = sheet.UsedRange
        ' Load all cells into 2d array.
        Dim array(,) As Object = r.Value(XlRangeValueDataType.xlRangeValueDefault)
        ' Scan the cells.
        If array IsNot Nothing Then
            Console.WriteLine("Length: {0}", array.Length)
            'SACA LOS DATOS, SIN LOS NOMBRES DE LAS MUESTRAS
            Dim bound0 As Integer = array.GetUpperBound(0)
            Dim bound1 As Integer = array.GetUpperBound(1)

            Dim table As New System.Data.DataTable
            For col As Integer = 1 To bound1
                table.Columns.Add()
            Next
            ' Loop over all elements.
            For j As Integer = 1 To bound0
                Dim dr As DataRow = table.NewRow()
                For x As Integer = 1 To bound1
                    Dim s1 As String = array(j, x)
                    dr(x - 1) = array(j, x)
                Next
                table.Rows.Add(dr)
            Next

            grpPreviewInput.Visible = True
            dgvComenzar.Visible = True
            dgvComenzar.BringToFront()
            lblArchivoEntrada.Text = excelpath
            btnAbrirExcel.BringToFront()
            lblArchivoEntrada.ForeColor = Color.Black

            grpDestino.Visible = True


            'CARGO EL ARCHIVO A LA dgvCOMENZAR
            dgvComenzar.DataSource = table
            dgvComenzar.Columns(0).DefaultCellStyle.BackColor = Color.LightGreen
            dgvComenzar.Columns(0).Width = 148
            dgvComenzar.Rows(0).DefaultCellStyle.BackColor = Color.Khaki
        End If
        w.Close()
    End Sub

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        'VALIDACION PREVIA
        If dgvComenzar.Visible = False Then
            MsgBox("Debe seleccionar un archivo para importar")
            Exit Sub
        End If
        If cmbProyecto.Text = "" Then
            MsgBox("Debe seleccionar en que proyecto se estan importando los datos, en el campo 'Proyecto'")
            Exit Sub
        End If
        If cmbTipoDatos.Text = "" Then
            MsgBox("Debe seleccionar que tipo de datos se está importando, en el campo de 'Destino'")
            Exit Sub
        End If

        ''''---------------------------------------------
        ''''  ACOMODA DGVOUTPUTSAMPLES
        ''''---------------------------------------------
        codigomodulo = cmbTipoDatos.SelectedValue.ToString
        For i As Integer = 0 To ConfigDataSet.Tables("Modulos").Rows.Count - 1
            If ConfigDataSet.Tables("Modulos").Rows(i).Item("codigo").ToString = codigomodulo Then
                If ConfigDataSet.Tables("Modulos").Rows(i).Item("tipo").ToString = "DatosSimples" Then
                    tipomodulo = "DatosSimples"
                    cargarColumnasDatosSimples(codigomodulo, "CaracParametros", dgvOutputColumns)
                ElseIf ConfigDataSet.Tables("Modulos").Rows(i).Item("tipo").ToString.Contains("DatosTaxones") Then
                    Dim tipomoduloarray As String() = ConfigDataSet.Tables("Modulos").Rows(i).Item("tipo").ToString.Split(";")
                    Dim dbname As String = tipomoduloarray(1)
                    Dim tablaname As String = tipomoduloarray(2)
                    tipomodulo = dbname
                    cargarColumnasComunidades(tipomodulo, "Taxones", dgvOutputColumns)
                End If
            End If
        Next


        ''''---------------------------------------------
        ''''  ACOMODA DGVINPUTSAMPLES
        ''''---------------------------------------------
        'VACIA TODO
        dgvInputColumns.Rows.Clear()
        dgvInputColumns.Columns.Clear()
        dgvInputSamples.Rows.Clear()
        dgvInputSamples.Rows.Clear()


        'PRIMERO COPIA TODO LO QUE HAY EN dgvComenzar a dgvInputColumns
        For Each Col As DataGridViewColumn In dgvComenzar.Columns
            dgvInputColumns.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next
        For Each row As DataGridViewRow In dgvComenzar.Rows
            dgvInputColumns.Rows.Add(row.Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        Next

        'DESPUES TRABAJA DIRECTAMENTE SOBRE dgvInputColumns
        'PONE HEADERS A LAS COLUMNAS DE LA PRIMERA FILA, Y BORRA LA PRIMERA FILA
        For i As Integer = 0 To dgvInputColumns.Columns.Count - 1
            dgvInputColumns.Columns(i).HeaderText = dgvInputColumns.Item(i, 0).Value.ToString
        Next

        dgvInputColumns.Rows.Remove(dgvInputColumns.Rows(0))

        'SACA LOS NOMBRES DE LAS MUESTRAS
        dgvInputSamples.ColumnCount = 1
        dgvInputSamples.Columns(0).HeaderText = "Muestras"
        Dim nombremuestra As String
        For x As Integer = 0 To dgvInputColumns.RowCount - 1
            nombremuestra = dgvInputColumns.Item(0, x).Value.ToString()
            dgvInputSamples.Rows.Add(nombremuestra)
        Next
        Dim columnname As String = dgvInputColumns.Columns(0).Name
        dgvInputColumns.Columns.Remove(columnname)

        'Y PASA A LA SIGUIENTE TAB

        TabControl1.SelectedTab = TabParametros

        Autocompletar("Nombre")

    End Sub


    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        cmbTipoDatos.Enabled = False
        Dim columnindexInput As Integer = dgvInputColumns.CurrentCell.ColumnIndex
        Dim rowindexOutput As Integer = dgvOutputColumns.CurrentCell.RowIndex

        If tipomodulo = "DatosSimples" Then
            Dim inputnombre As String = dgvInputColumns.Columns(columnindexInput).HeaderText
            Dim outputnombre As String = dgvOutputColumns.Item("NombreParametro", rowindexOutput).Value.ToString
            Dim inputId As String = dgvInputColumns.CurrentCell.ColumnIndex
            Dim outputId As String = dgvOutputColumns.Item("Id", rowindexOutput).Value.ToString

            If dgvInputColumns.Columns(columnindexInput).DefaultCellStyle.BackColor = Color.LightGreen Then
                MsgBox("Esa columna del archivo de Origen ya esta relacionada con un parámetro de la base de datos de Destino")

            ElseIf dgvOutputColumns.Rows(rowindexOutput).DefaultCellStyle.BackColor = Color.LightGreen Then
                MsgBox("Ese parámetro de la base de datos de Destino ya esta relacionada con una columna del archivo de Origen")
            Else

                Dim rowcontent As String() = {inputId, inputnombre, outputId, outputnombre}
                dgvEquivalencias.Rows.Add(rowcontent)
                'PINTA LAS COLUMNAS YA ASIGNADAS
                dgvInputColumns.Columns(columnindexInput).DefaultCellStyle.BackColor = Color.LightGreen
                dgvOutputColumns.Rows(rowindexOutput).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Else
            Dim inputnombre As String = dgvInputColumns.Columns(columnindexInput).HeaderText
            Dim outputnombre As String = dgvOutputColumns.Item("nombre", rowindexOutput).Value.ToString
            Dim inputId As String = dgvInputColumns.CurrentCell.ColumnIndex
            Dim outputId As String = dgvOutputColumns.Item("IdTaxon", rowindexOutput).Value.ToString

            If dgvInputColumns.Columns(columnindexInput).DefaultCellStyle.BackColor = Color.LightGreen Then
                MsgBox("Esa columna del archivo de Origen ya esta relacionada con un parámetro de la base de datos de Destino")
            ElseIf dgvOutputColumns.Rows(rowindexOutput).DefaultCellStyle.BackColor = Color.LightGreen Then
                MsgBox("Ese parámetro de la base de datos de Destino ya esta relacionada con una columna del archivo de Origen")
            Else
                Dim rowcontent As String() = {inputId, inputnombre, outputId, outputnombre}
                dgvEquivalencias.Rows.Add(rowcontent)
                'PINTA LAS COLUMNAS YA ASIGNADAS
                dgvInputColumns.Columns(columnindexInput).DefaultCellStyle.BackColor = Color.LightGreen
                dgvOutputColumns.Rows(rowindexOutput).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        End If
    End Sub

    Private Sub btnAutorelacionarParametros_Click(sender As Object, e As EventArgs) Handles btnAutorelacionarParametros.Click
        'LIMPIA LAS RELACIONES YA ESTABLECIDAS
        If dgvEquivalencias.Rows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Si utiliza la Autorelación, se borrarán las relaciones ya establecidas manualmente", "Cuidado!", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                Exit Sub
            ElseIf result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                dgvEquivalencias.Rows.Clear()
                For i As Integer = 0 To dgvInputColumns.Rows.Count - 1
                    dgvInputColumns.Rows(i).DefaultCellStyle.BackColor = Color.White
                Next
                For i = 0 To dgvOutputColumns.Rows.Count - 1
                    dgvOutputColumns.Rows(i).DefaultCellStyle.BackColor = Color.White
                Next
            End If
        End If

        'ESTABLECE LAS NUEVAS POR NOMBRE
        For i As Integer = 0 To dgvInputColumns.Columns.Count - 1
            Dim inputname As String = dgvInputColumns.Columns(i).HeaderText
            For j As Integer = 0 To dgvOutputColumns.Rows.Count - 1
                If dgvOutputColumns.Rows(j).Cells("Nombre").Value.ToString.Contains(inputname) = True Then
                    Dim inputId As String = dgvInputColumns.Columns(i).Index
                    Dim outputnombre As String = dgvOutputColumns.Item("Nombre", j).Value.ToString
                    Dim outputId As String = dgvOutputColumns.Item("IdTaxon", j).Value.ToString

                    If dgvInputColumns.Columns(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                        MsgBox("Esa columna del archivo de Origen ya esta relacionada con un parámetro de la base de datos de Destino")
                    ElseIf dgvOutputColumns.Rows(j).DefaultCellStyle.BackColor = Color.LightGreen Then
                        MsgBox("Ese parámetro de la base de datos de Destino ya esta relacionada con una columna del archivo de Origen")
                    Else
                        Dim rowcontent As String() = {inputId, inputname, outputId, outputnombre}
                        dgvEquivalencias.Rows.Add(rowcontent)
                        'PINTA LAS COLUMNAS YA ASIGNADAS
                        dgvInputColumns.Columns(i).DefaultCellStyle.BackColor = Color.LightGreen
                        dgvOutputColumns.Rows(j).DefaultCellStyle.BackColor = Color.LightGreen
                    End If
                    Exit For
                End If
            Next
        Next

    End Sub

    Private Sub btnAsignarMuestras_Click(sender As Object, e As EventArgs) Handles btnAsignarMuestras.Click
        cmbProyecto.Enabled = False

        Dim inputId As String = dgvInputSamples.CurrentRow.Index
        Dim input As String = dgvInputSamples.CurrentRow.Cells(0).Value.ToString
        Dim output As String = MuestrasDataGridView.CurrentRow.Cells("Nombre").Value.ToString
        Dim outputId As String = MuestrasDataGridView.CurrentRow.Cells("IdMuestra").Value.ToString

        Dim rowindexInput As Integer = dgvInputSamples.CurrentCell.RowIndex
        Dim rowindexOutput As Integer = MuestrasDataGridView.CurrentCell.RowIndex

        If dgvInputSamples.Rows(rowindexInput).DefaultCellStyle.BackColor = Color.LightGreen Then
            MsgBox("Esa fila del archivo de Origen ya esta relacionada a una muestra de la base de datos de Destino")
        ElseIf MuestrasDataGridView.Rows(rowindexOutput).DefaultCellStyle.BackColor = Color.LightGreen Then
            MsgBox("Esa muestra de la base de datos de Destino ya esta relacionada con una fila del archivo de Origen")
        Else
            Dim rowcontent As String() = {inputId, input, outputId, output}
            dgvEquivalenciasSamples.Rows.Add(rowcontent)
            'PINTA LAS FILAS YA ASIGNADAS
            dgvInputSamples.Rows(rowindexInput).DefaultCellStyle.BackColor = Color.LightGreen
            MuestrasDataGridView.Rows(rowindexOutput).DefaultCellStyle.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub btnAutorelacionarMuestras_Click(sender As Object, e As EventArgs) Handles btnAutorelacionarMuestras.Click
        cmbProyecto.Enabled = False
        'LIMPIA LAS RELACIONES YA ESTABLECIDAS
        If dgvEquivalenciasSamples.Rows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Si utiliza la Autorelación, se borrarán las relaciones ya establecidas manualmente", "Cuidado!", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                Exit Sub
            ElseIf result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                dgvEquivalenciasSamples.Rows.Clear()
                For i As Integer = 0 To dgvInputSamples.Rows.Count - 1
                    dgvInputSamples.Rows(i).DefaultCellStyle.BackColor = Color.White
                Next
                For i = 0 To MuestrasDataGridView.Rows.Count - 1
                    MuestrasDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.White
                Next
            End If
        End If

        'ESTABLECE LAS NUEVAS POR NOMBRE

        For i = 0 To dgvInputSamples.Rows.Count - 1
            Dim inputname As String = dgvInputSamples.Rows(i).Cells(0).Value.ToString
            For j As Integer = 0 To MuestrasDataGridView.Rows.Count - 1
                If MuestrasDataGridView.Item("Nombre", j).Value.ToString.Contains(inputname) Then

                    Dim inputId As String = dgvInputSamples.Rows(i).Index
                    Dim input As String = dgvInputSamples.Rows(i).Cells(0).Value.ToString
                    Dim output As String = MuestrasDataGridView.Rows(j).Cells("Nombre").Value.ToString
                    Dim outputId As String = MuestrasDataGridView.Rows(j).Cells("IdMuestra").Value.ToString

                    If dgvInputSamples.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                        MsgBox("Esa fila del archivo de Origen ya esta relacionada a una muestra de la base de datos de Destino")
                    ElseIf MuestrasDataGridView.Rows(j).DefaultCellStyle.BackColor = Color.LightGreen Then
                        MsgBox("Esa muestra de la base de datos de Destino ya esta relacionada con una fila del archivo de Origen")
                    Else
                        Dim rowcontent As String() = {inputId, input, outputId, output}
                        dgvEquivalenciasSamples.Rows.Add(rowcontent)
                        'PINTA LAS FILAS YA ASIGNADAS
                        dgvInputSamples.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                        MuestrasDataGridView.Rows(j).DefaultCellStyle.BackColor = Color.LightGreen
                    End If
                    Exit For
                End If
            Next
        Next

    End Sub

    Private Sub CheckDatosExistentes()
        Dim i, j As Integer
        Dim databasename, tablaparametros As String
        Dim idmuestraabuscar As String
        conParametros.Close()
        dgvDatos.Refresh()
        dgvDatos.DataSource = Nothing
        dsParametros.Clear()

        If tipomodulo = "DatosSimples" Then
            databasename = codigomodulo
            tablaparametros = "Parametros" & codigomodulo

            'CONECTA A LA BASE DE DATOS 
            conParametros.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & databasename & ".mdb"
            conParametros.Open()
            sqlParametros = "SELECT * FROM " & tablaparametros & " WHERE IdProyecto = '" & IdProyectoLabel.Text & "'"
            daParametros = New OleDb.OleDbDataAdapter(sqlParametros, conParametros)
            daParametros.Fill(dsParametros, "TablaParametros")
            BindingSource1.DataSource = dsParametros.Tables("TablaParametros")
            dgvDatos.DataSource = BindingSource1


            For i = 0 To dgvEquivalenciasSamples.Rows.Count - 1
                For j = 0 To dsParametros.Tables("TablaParametros").Rows.Count - 1
                    idmuestraabuscar = dgvEquivalenciasSamples.Item("SalidaId", i).Value.ToString
                    If dsParametros.Tables("TablaParametros").Rows(j).Item("IdMuestra").ToString = idmuestraabuscar Then
                        Dim result As Integer = MessageBox.Show("La muestra con ID=" & idmuestraabuscar & "ya posee algunos datos. Desea sobreescribirlos?", "Datos existentes datos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                        If result = DialogResult.Cancel Then
                            Exit Sub
                        ElseIf result = DialogResult.No Then
                            dgvEquivalenciasSamples.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
                        ElseIf result = DialogResult.Yes Then
                            dgvEquivalenciasSamples.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
                        End If
                    End If
                Next
            Next
            conParametros.Close()
        Else
            databasename = "taxonesmuestras"
            tablaparametros = codigomodulo

            'CONECTA A LA BASE DE DATOS 
            conParametros.Close()
            conParametros.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & databasename & ".mdb"
            conParametros.Open()
            sqlParametros = "SELECT * FROM " & tablaparametros & " WHERE IdProyecto = '" & IdProyectoLabel.Text & "'"
            daParametros = New OleDb.OleDbDataAdapter(sqlParametros, conParametros)
            daParametros.Fill(dsParametros, "TablaParametros")
            BindingSource1.DataSource = dsParametros.Tables("TablaParametros")
            dgvDatos.DataSource = BindingSource1

            For i = 0 To dgvEquivalenciasSamples.Rows.Count - 1
                For j = 0 To dsParametros.Tables("TablaParametros").Rows.Count - 1
                    idmuestraabuscar = dgvEquivalenciasSamples.Item("SalidaId", i).Value.ToString
                    If dsParametros.Tables("TablaParametros").Rows(j).Item("IdMuestra").ToString = idmuestraabuscar Then
                        Dim result As Integer = MessageBox.Show("La muestra con ID=" & idmuestraabuscar & "ya posee algunos datos. Desea sobreescribirlos?", "Datos existentes datos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                        If result = DialogResult.Cancel Then
                            Exit Sub
                        ElseIf result = DialogResult.No Then
                            dgvEquivalenciasSamples.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
                            Continue For
                        ElseIf result = DialogResult.Yes Then
                            dgvEquivalenciasSamples.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
                            Continue For
                        End If
                    End If
                Next
            Next
            conParametros.Close()
        End If
    End Sub

    Private Sub ImportarDatos()
        Dim IdInputParametro As String
        Dim IdOutputParametro As String
        Dim IdInputMuestra As String
        Dim IdOutputMuestra As String
        Dim valornuevo As String


        'Primero busca en el listado de muestras, si no existe la agrega
        For rowmuestras As Integer = 0 To dgvEquivalenciasSamples.Rows.Count - 1
            IdOutputMuestra = dgvEquivalenciasSamples.Item("SalidaId", rowmuestras).Value.ToString
            Dim encontromuestra As Boolean = False
            For rowdgvDatos As Integer = 0 To dgvDatos.Rows.Count - 2
                If dgvDatos.Item("IdMuestra", rowdgvDatos).Value.ToString = IdOutputMuestra Then
                    encontromuestra = True
                    Exit For
                End If
            Next
            If encontromuestra = False Then
                'MsgBox("No se encontro muestra " & IdOutputMuestra)
                Dim dsNewRow As DataRow
                dsNewRow = dsParametros.Tables("TablaParametros").NewRow
                With dsNewRow
                    .Item("IdMuestra") = IdOutputMuestra
                    .Item("IdProyecto") = CInt(IdProyectoLabel.Text)
                End With
                dsParametros.Tables("TablaParametros").Rows.Add(dsNewRow)
                Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(daParametros)
                'Agrega las rows al DA y lo recarga
                daParametros.InsertCommand = oledbCmdBuilder.GetInsertCommand()
                daParametros.Update(dsParametros.Tables("TablaParametros"))
                dsParametros.Tables("TablaParametros").AcceptChanges()
                dsParametros.Clear()
                daParametros.Fill(dsParametros, "TablaParametros")
                BindingSource1.DataSource = dsParametros.Tables("TablaParametros")
                dgvDatos.DataSource = BindingSource1
            End If
        Next

        If tipomodulo = "DatosSimples" Then
            ' Fija en la primera row de dgvEquivalencias, que seria el 1er parametro a importar
            ' Y retiene sus IDs
            For rowParametro As Integer = 0 To dgvEquivalencias.Rows.Count - 1
                IdInputParametro = dgvEquivalencias.Item("IdEntrada", rowParametro).Value.ToString
                IdOutputParametro = dgvEquivalencias.Item("IdSalida", rowParametro).Value.ToString
                ' Una vez q tiene los IDs, recorre las rows en la dgvEquivalenciasSamples, que indicaria que
                ' muestras se tienen q importar para el parametro
                For rowSample As Integer = 0 To dgvEquivalenciasSamples.Rows.Count - 1
                    'Si esta pintada de rojo, la saltea
                    If dgvEquivalenciasSamples.Rows(rowSample).DefaultCellStyle.BackColor = Color.IndianRed Then
                        Exit For
                    End If
                    IdInputMuestra = dgvEquivalenciasSamples.Item("EntradaId", rowSample).Value.ToString
                    IdOutputMuestra = dgvEquivalenciasSamples.Item("SalidaId", rowSample).Value.ToString
                    ' Buscar el valor nuevo para esa muestra en ese parametro
                    valornuevo = dgvInputColumns.Item(CInt(IdInputParametro), CInt(IdInputMuestra)).Value.ToString

                    ' Y ahora recorre dgvDatos y reemplaza valornuevo por el valor existente
                    For rowdgvDatos As Integer = 0 To dgvDatos.Rows.Count - 1
                        If dgvDatos.Item("IdMuestra", rowdgvDatos).Value.ToString = IdOutputMuestra Then
                            dgvDatos.Item("p" & IdOutputParametro, rowdgvDatos).Value = valornuevo
                            Exit For
                        End If
                    Next
                Next
            Next
        Else
            'PARAMETRO=TAXON
            'PROCEDIMIENTO PARA CARGA DE DENISDADES DE TAXONES


            For rowSample As Integer = 0 To dgvEquivalenciasSamples.Rows.Count - 1
                'Si esta pintada de rojo, la saltea
                If dgvEquivalenciasSamples.Rows(rowSample).DefaultCellStyle.BackColor = Color.IndianRed Then
                    Continue For
                End If
                IdInputMuestra = dgvEquivalenciasSamples.Item("EntradaId", rowSample).Value.ToString
                IdOutputMuestra = dgvEquivalenciasSamples.Item("SalidaId", rowSample).Value.ToString

                Dim taxondensidades As String
                '' Buscar el valor nuevo para esa muestra en ese parametro
                For i As Integer = 0 To dgvEquivalencias.Rows.Count - 1
                    Dim colequivalencias As Integer = CInt(dgvEquivalencias.Item("IdEntrada", i).Value)
                    taxondensidades = taxondensidades & dgvInputColumns.Item(colequivalencias, CInt(IdInputMuestra)).Value.ToString & "#"
                Next

                Dim taxonids As String
                For rowtaxon As Integer = 0 To dgvEquivalencias.Rows.Count - 1
                    IdInputParametro = dgvEquivalencias.Item("IdEntrada", rowtaxon).Value.ToString
                    IdOutputParametro = dgvEquivalencias.Item("IdSalida", rowtaxon).Value.ToString
                    taxonids = taxonids & IdOutputParametro & "#"
                Next

                'DEBERIA PARTIR LAS ARRAYS EN 3 PEDAZOS
                Dim taxondensidadesarray As String() = Split(taxondensidades, "#")
                Dim taxonidsarray As String() = Split(taxonids, "#")
                Dim taxa1, taxa2, taxa3 As String
                Dim densidad1, densidad2, densidad3 As String

                If taxondensidades.Length < 6400 Then
                    densidad1 = taxondensidades
                    taxa1 = taxonids

                ElseIf taxondensidades.Length > 6400 And taxondensidades.Length < 12800 Then
                    densidad1 = taxondensidades.Remove(0, 6400)
                    densidad2 = taxondensidades.Remove(6400, taxondensidades.Length - 1)
                    taxa1 = taxonids.Remove(0, 6400)
                    taxa2 = taxonids.Remove(6400, taxonids.Length - 1)
                ElseIf taxondensidades.Length > 12800 Then
                    densidad1 = taxondensidades.Remove(0, 6400)
                    densidad2 = taxondensidades.Remove(6400, 12800)
                    densidad3 = taxondensidades.Remove(12800, taxondensidades.Length - 1)
                    taxa1 = taxonids.Remove(0, 6400)
                    taxa2 = taxonids.Remove(6400, 12800)
                    taxa3 = taxonids.Remove(12800, taxonids.Length - 1)
                End If

                ' Y ahora recorre dgvDatos y reemplaza valornuevo por el valor existente
                For rowdgvDatos As Integer = 0 To dgvDatos.Rows.Count - 1
                    If dgvDatos.Item("IdMuestra", rowdgvDatos).Value.ToString = IdOutputMuestra Then
                        dgvDatos.Item("taxa1", rowdgvDatos).Value = taxa1
                        dgvDatos.Item("taxa2", rowdgvDatos).Value = taxa2
                        dgvDatos.Item("taxa3", rowdgvDatos).Value = taxa3
                        dgvDatos.Item("densidad1", rowdgvDatos).Value = densidad1
                        dgvDatos.Item("densidad2", rowdgvDatos).Value = densidad2
                        dgvDatos.Item("densidad3", rowdgvDatos).Value = densidad3
                        Exit For
                    End If
                Next
                taxonids = ""
                taxondensidades = ""

            Next
        End If



    End Sub

    Private Sub TraducirResultados()
        Dim tabladatos As String = "CaracParametros"
        Dim databasename As String = codigomodulo



        ' CONECTA A LA TABLA DE CARACPARAMETROS
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim sql As String
        con.Close()
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & databasename & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tabladatos
        Dim da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Tabla")


        ' CAMBIA LOS HEADERS DE DGVDATOS POR LOS NOMBRES EN LA TABLA CARACPARAMETROS
        For i As Integer = 0 To dgvDatos.ColumnCount - 1
            For j As Integer = 0 To ds.Tables("Tabla").Rows.Count - 1
                If dgvDatos.Columns(i).HeaderText = "p" & ds.Tables("Tabla").Rows(j).Item("Id").ToString Then
                    dgvDatos.Columns(i).HeaderText = ds.Tables("Tabla").Rows(j).Item("NombreParametro").ToString
                End If
            Next
        Next
        ' ESCONDE LAS COLUMNAS QUE NO SIRVEN
        dgvDatos.Columns("Id").Visible = False
        dgvDatos.Columns("IdProyecto").Visible = False

        'ESCONDE LAS COLUMNAS QUE TENGAN EL FORMATO "p#"
        For i As Integer = 0 To dgvDatos.ColumnCount - 1
            If dgvDatos.Columns(i).HeaderText.ToString.StartsWith("p") Then
                For j As Integer = 0 To dgvDatos.Columns(i).HeaderText.ToString.Length - 1
                    If Not Char.IsLetter(dgvDatos.Columns(i).HeaderText.ToString.Chars(j)) Then
                        dgvDatos.Columns(i).Visible = False
                    End If
                Next
            End If
        Next
        con.Close()

    End Sub

    Private Sub btnSiguiente1_Click(sender As Object, e As EventArgs) Handles btnSiguiente1.Click
        If dgvEquivalencias.Rows.Count = 0 Then
            MsgBox("No hay equivalencias entre ninguna de las columnas del archivo de entrada y las de la base de datos. Seleccione las equivalencias")
            Exit Sub
        End If
        TabControl1.SelectedTab = TabMuestras
    End Sub

    Private Sub btnSiguiente2_Click(sender As Object, e As EventArgs) Handles btnSiguiente2.Click
        If dgvEquivalenciasSamples.Rows.Count = 0 Then
            MsgBox("No hay equivalencias entre ninguna de las muestras del archivo de entrada y las de la base de datos. Seleccione las equivalencias antes de proseguir")
            Exit Sub
        End If

        'SUB que chequea si cada muestra ya tiene datos, y pregunta si sobreescribe o no
        CheckDatosExistentes()

        'SUB que finalmente importa cada dato 
        ImportarDatos()

        btnImportacionCorrecta.Enabled = True

        TabControl1.SelectedTab = TabResultados

        If tipomodulo = "DatosSimples" Then
            TraducirResultados()
        End If
    End Sub

    Private Sub btnImportacionCorrecta_Click(sender As Object, e As EventArgs) Handles btnImportacionCorrecta.Click
        conParametros.Open()
        BindingSource1.EndEdit()
        Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(daParametros)
        daParametros.InsertCommand = oledbCmdBuilder.GetInsertCommand()

        dgvDatos.ReadOnly = True
        Try
            changesParametros = dsParametros.GetChanges()
            If changesParametros IsNot Nothing Then
                daParametros.Update(dsParametros.Tables("TablaParametros"))
            End If
            ds.AcceptChanges()
            MsgBox("Datos importados correctamente!")
            dgvDatos.ReadOnly = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conParametros.Close()
    End Sub

    Private Sub btnAgregarProyecto_Click(sender As Object, e As EventArgs) Handles btnAgregarProyecto.Click
        Dim nombreProyecto As String

        nombreProyecto = InputBox("Ingrese el nombre del Proyecto", , "Proyecto ")

        If nombreProyecto <> "" Then
            ' AGREGA MUESTRA
            ProyectosTableAdapter.Insert(nombreProyecto, "", "", "", "")

            ' GUARDA
            ProyectosBindingSource.EndEdit()
            ProyectosTableAdapter.Update(Scilla10DataSet.Proyectos)
            Me.ProyectosTableAdapter.Fill(Me.Scilla10DataSet.Proyectos)

        Else
            'CANCELA EL INPUT
            Exit Sub
        End If
    End Sub

    Private Sub btnAgregarMuestra_Click(sender As Object, e As EventArgs) Handles btnAgregarMuestra.Click
        Dim nombremuestra As String

        nombremuestra = InputBox("Ingrese el nombre de la muestra", , "Muestra ")

        If nombremuestra <> "" Then
            ' AGREGA MUESTRA
            MuestrasBindingSource.AddNew()

            MuestrasDataGridView.Enabled = False
            MuestrasDataGridView.CurrentRow.Cells.Item("Nombre").Value = nombremuestra
            MuestrasDataGridView.CurrentRow.Cells.Item("IdProyecto").Value = IdProyectoLabel.Text

            ' GUARDA
            MuestrasBindingSource.EndEdit()
            MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

            'RECARGA ADAPTADOR MUESTRAS
            MuestrasTableAdapter.qryMuestrasByProyecto(Scilla10DataSet.Muestras, IdProyectoLabel.Text)
            MuestrasDataGridView.Refresh()

            'ESCONDE BOTONES
            MuestrasDataGridView.Enabled = True

        Else
            'CANCELA EL INPUT
            Exit Sub
        End If
    End Sub

    Private Sub btnImportacionIncorrecta_Click(sender As Object, e As EventArgs) Handles btnImportacionIncorrecta.Click
        Dim f2 As New frmImportar
        f2.Show()
        Me.Close()
    End Sub


    Private Sub btnTransponer_Click(sender As Object, e As EventArgs) Handles btnTransponer.Click
        'Crea una tabla virtual y copia las rows como cols, y las cols como rows
        Dim table As New System.Data.DataTable

        For Each row As DataGridViewRow In dgvComenzar.Rows
            Dim dc As New DataGridViewColumn
            table.Columns.Add()
        Next

        For Each Col As DataGridViewColumn In dgvComenzar.Columns
            table.Rows.Add()
        Next
        For i As Integer = 0 To table.Rows.Count - 1
            For j As Integer = 0 To table.Columns.Count - 1

                table.Rows(i).Item(j) = dgvComenzar.Item(i, j).Value
            Next
        Next
        'y recarga desde la virtual
        dgvComenzar.DataSource = Nothing
        dgvComenzar.DataSource = table
        dgvComenzar.Columns(0).DefaultCellStyle.BackColor = Color.LightGreen
        dgvComenzar.Columns(0).Width = 148
        dgvComenzar.Rows(0).DefaultCellStyle.BackColor = Color.Khaki
    End Sub

    Private Sub Autocompletar(campoabuscar As String)
        Dim col As New AutoCompleteStringCollection
        Dim m As Integer
        For m = 0 To dgvOutputColumns.Rows.Count - 1
            col.Add(dgvOutputColumns.Item(campoabuscar, m).Value.ToString)
        Next
        txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSearch.AutoCompleteCustomSource = col
        txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        Dim taxonabuscar As String = txtSearch.Text
        Dim i As Integer
        dgvOutputColumns.ClearSelection()

        For i = 0 To dgvOutputColumns.RowCount - 1
            If dgvOutputColumns.Item("Nombre", i).Value.ToString = taxonabuscar Then
                dgvOutputColumns.CurrentCell = dgvOutputColumns.Rows(i).Cells(1)
                dgvOutputColumns.Rows(i).Selected = True
            End If
        Next i
    End Sub
    'ACA VAN LOS CONTROLADORES DE LAS DGV DE EQUIVALENCIAS, PARA QUE SEA MAS VISUAL EL MANEJO

    Private Sub dgvEquivalencias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquivalencias.CellContentClick
        Dim identrada As String = dgvEquivalencias.CurrentRow.Cells("IdEntrada").Value
        Dim idtaxonsalida As String = dgvEquivalencias.CurrentRow.Cells("IdSalida").Value
        Dim idsalida As String

        For i As Integer = 0 To dgvOutputColumns.Rows.Count - 1
            If dgvOutputColumns.Item("IdTaxon", i).Value = idtaxonsalida Then
                idsalida = dgvOutputColumns.Item("IdTaxon", i).RowIndex
            End If

        Next
        dgvInputColumns.ClearSelection()
        dgvOutputColumns.ClearSelection()

        dgvInputColumns.Columns(CInt(identrada)).Selected = True
        dgvInputColumns.CurrentCell = dgvInputColumns.Item(CInt(identrada), 0)

        dgvOutputColumns.Rows(CInt(idsalida)).Selected = True
        dgvOutputColumns.CurrentCell = dgvOutputColumns.Item("IdTaxon", CInt(idsalida))

    End Sub

    Private Sub dgvEquivalenciasSamples_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquivalenciasSamples.CellContentClick
        Dim identrada As String = dgvEquivalenciasSamples.CurrentRow.Cells("EntradaId").Value
        Dim idtaxonsalida As String = dgvEquivalenciasSamples.CurrentRow.Cells("SalidaId").Value
        Dim idsalida As String

        For i As Integer = 0 To MuestrasDataGridView.Rows.Count - 1
            If MuestrasDataGridView.Item("IdMuestra", i).Value = idtaxonsalida Then
                idsalida = MuestrasDataGridView.Item("IdMuestra", i).RowIndex
            End If
        Next

        dgvInputSamples.ClearSelection()
        MuestrasDataGridView.ClearSelection()

        dgvInputSamples.Rows(CInt(identrada)).Selected = True
        dgvInputSamples.CurrentCell = dgvInputSamples.Item(0, CInt(identrada))

        MuestrasDataGridView.Rows(CInt(idsalida)).Selected = True
        MuestrasDataGridView.CurrentCell = MuestrasDataGridView.Item("IdMuestra", CInt(idsalida))

    End Sub

    'ELIMINAR RELACIONES EN LAS DGV EQUIVALENCIAS
    Private Sub btnEliminarRelacionParametros_Click(sender As Object, e As EventArgs) Handles btnEliminarRelacionParametros.Click
        ' SACA LOS IDS PARA CAMBIAR LOS COLORES DE VERDE A BLANCO EN LAS ORIGINALES
        Dim identrada As String = dgvEquivalencias.CurrentRow.Cells("IdEntrada").Value
        Dim idtaxonsalida As String = dgvEquivalencias.CurrentRow.Cells("IdSalida").Value
        Dim idsalida As String

        For i As Integer = 0 To dgvOutputColumns.Rows.Count - 1
            If dgvOutputColumns.Item("IdTaxon", i).Value = idtaxonsalida Then
                idsalida = dgvOutputColumns.Item("IdTaxon", i).RowIndex
            End If
        Next
        dgvInputColumns.ClearSelection()
        dgvOutputColumns.ClearSelection()

        dgvInputColumns.Columns(CInt(identrada)).DefaultCellStyle.BackColor = Color.White
        dgvOutputColumns.Rows(CInt(idsalida)).DefaultCellStyle.BackColor = Color.White

        'ELIMINA LA ROW DE LA TABLA EQUIVALENCIAS
        Dim selectedrowequivalencia As Integer = dgvEquivalencias.CurrentRow.Index
        dgvEquivalencias.Rows.RemoveAt(selectedrowequivalencia)
    End Sub

    Private Sub btnEliminarTodasRelacionParametros_Click(sender As Object, e As EventArgs) Handles btnEliminarTodasRelacionParametros.Click
        For i As Integer = 0 To dgvInputColumns.Columns.Count - 1
            dgvInputColumns.Columns(i).DefaultCellStyle.BackColor = Color.White
        Next
        For i = 0 To dgvOutputColumns.Rows.Count - 1
            dgvOutputColumns.Rows(i).DefaultCellStyle.BackColor = Color.White
        Next
        dgvEquivalencias.Rows.Clear()
    End Sub

    Private Sub btnEliminarRelacionMuestras_Click(sender As Object, e As EventArgs) Handles btnEliminarRelacionMuestras.Click
        ' SACA LOS IDS PARA CAMBIAR LOS COLORES DE VERDE A BLANCO EN LAS ORIGINALES
        Dim identrada As String = dgvEquivalenciasSamples.CurrentRow.Cells("EntradaId").Value
        Dim idtaxonsalida As String = dgvEquivalenciasSamples.CurrentRow.Cells("SalidaId").Value
        Dim idsalida As String

        For i As Integer = 0 To MuestrasDataGridView.Rows.Count - 1
            If MuestrasDataGridView.Item("IdMuestra", i).Value = idtaxonsalida Then
                idsalida = MuestrasDataGridView.Item("IdMuestra", i).RowIndex
            End If
        Next
        dgvInputSamples.ClearSelection()
        MuestrasDataGridView.ClearSelection()
        dgvInputSamples.Rows(CInt(identrada)).DefaultCellStyle.BackColor = Color.White
        MuestrasDataGridView.Rows(CInt(idsalida)).DefaultCellStyle.BackColor = Color.White

        'ELIMINA LA ROW DE LA TABLA EQUIVALENCIAS
        Dim selectedrowequivalencia As Integer = dgvEquivalenciasSamples.CurrentRow.Index
        dgvEquivalenciasSamples.Rows.RemoveAt(selectedrowequivalencia)
    End Sub

    Private Sub btnEliminarTodasRelacionMuestras_Click(sender As Object, e As EventArgs) Handles btnEliminarTodasRelacionMuestras.Click
        For i As Integer = 0 To MuestrasDataGridView.Rows.Count - 1
            MuestrasDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.White
        Next
        For i = 0 To dgvInputSamples.Rows.Count - 1
            dgvInputSamples.Rows(i).DefaultCellStyle.BackColor = Color.White
        Next
        dgvEquivalenciasSamples.Rows.Clear()
    End Sub
End Class