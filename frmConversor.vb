Public Class frmConversor

    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim tipodatos As String
    Dim UnitConvVal As Double

    Private Sub frmConversor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ModulosTableAdapter.Fill(Me.ConfigDataSet.Modulos)
        Me.MuestrasTableAdapter.Fill(Me.Scilla10DataSet.Muestras)
        Me.ProyectosTableAdapter.Fill(Me.Scilla10DataSet.Proyectos)
        CargarFactores("CargarCategoria")
    End Sub



    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////////
    '////////////////// Cargar Factores del txt
    '//////////////////
    Public Sub CargarFactores(ByVal Switch As String)

        Dim tfLines() As String = System.IO.File.ReadAllLines("factoresconversion.txt")
        For Each line As String In tfLines
            Dim field As String() = line.Split(";"c)

            Select Case Switch
                Case "CargarCategoria"
                    If field(0) = "Categoria" Then
                        cboCategory.Items.Add(field(1))
                        cboCategory.SelectedIndex = 0
                    End If

                Case "CargarConversiones"
                    If field(0) = CStr(cboCategory.SelectedItem) Then
                        cboConvertTo.Items.Add(field(1))
                        cboConvertTo.SelectedIndex = 0
                    End If

                Case "CargarFactores"
                    If field(1) = CStr(cboConvertTo.SelectedItem) Then
                        UnitConvVal = CDbl(field(2))
                        txtFactorConversion.Text = UnitConvVal
                    End If
            End Select
        Next

    End Sub
    Private Sub cboConvertTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConvertTo.SelectedIndexChanged
        CargarFactores("CargarFactores")
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        cboConvertTo.Items.Clear()
        CargarFactores("CargarConversiones")
    End Sub


    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim idproyectocol As New DataGridViewTextBoxColumn
        Dim idmuestracol As New DataGridViewTextBoxColumn
        Dim idproyectocol1 As New DataGridViewTextBoxColumn
        Dim idmuestracol1 As New DataGridViewTextBoxColumn

        If dgvDatosActuales.Columns.Contains("IdProyecto") Then
            dgvDatosActuales.Columns.Remove("IdProyecto")
            dgvDatosActuales.Columns.Remove("IdMuestra")
            dgvDatosConvertidos.Columns.Remove("IdProyecto")
            dgvDatosConvertidos.Columns.Remove("IdMuestra")
        End If

        idproyectocol.Name = "IdProyecto"
        idproyectocol.HeaderText = "IdProyecto"
        idproyectocol.Visible = False
        idmuestracol.Name = "IdMuestra"
        idmuestracol.HeaderText = "IdMuestra"

        idproyectocol1.Name = "IdProyecto"
        idproyectocol1.Visible = False
        idproyectocol1.HeaderText = "IdProyecto"
        idmuestracol1.Name = "IdMuestra"
        idmuestracol1.HeaderText = "IdMuestra"
        'agrega las columnas a las dos dgvs
        dgvDatosActuales.Columns.Add(idproyectocol)
        dgvDatosActuales.Columns.Add(idmuestracol)

        dgvDatosConvertidos.Columns.Add(idproyectocol1)
        dgvDatosConvertidos.Columns.Add(idmuestracol1)

        For i As Integer = 0 To MuestrasDataGridView.SelectedRows.Count - 1
            Dim idmuestradd As String = MuestrasDataGridView.SelectedRows(i).Cells("IdMuestra").Value.ToString
            Dim idproyectoadd As String = MuestrasDataGridView.SelectedRows(i).Cells("IdProyecto").Value.ToString
            dgvDatosActuales.Rows.Add(idproyectoadd, idmuestradd)
            dgvDatosConvertidos.Rows.Add(idproyectoadd, idmuestradd)
        Next
    End Sub

    Private Sub MuestrasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MuestrasDataGridView.CellClick
        Dim indexrow As Integer = MuestrasDataGridView.CurrentRow.Index
        MuestrasDataGridView.Rows(indexrow).Selected = True

    End Sub

    Private Sub cargarVariablesCombo(codigomodulo As String, tablaname As String, combodestino As ComboBox)
        ' CONECTA A LA TABLA DE DATOS
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim sql As String
        con.Close()
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & codigomodulo & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablaname
        Dim da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Tabla")

        With combodestino
            .DataSource = ds.Tables("Tabla")
            .ValueMember = ds.Tables("Tabla").Columns("CodParametro").ToString
            .DisplayMember = ds.Tables("Tabla").Columns("NombreParametro").ToString
        End With
    End Sub

    'Private Sub cargarTaxonesCombo(codigomodulo As String, tablaname As String, combodestino As ComboBox)
    '    ' CONECTA A LA TABLA DE DATOS
    '    Dim con As New OleDb.OleDbConnection
    '    Dim ds As New DataSet
    '    Dim sql As String
    '    con.Close()
    '    con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & codigomodulo & ".mdb"
    '    con.Open()
    '    sql = "SELECT * FROM " & tablaname
    '    Dim da = New OleDb.OleDbDataAdapter(sql, con)
    '    da.Fill(ds, "Tabla")

    '    With combodestino
    '        .DataSource = ds.Tables("Tabla")
    '        .ValueMember = ds.Tables("Tabla").Columns("taxa1").ToString
    '        .DisplayMember = ds.Tables("Tabla").Columns("densidad1").ToString
    '    End With
    'End Sub


    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        If Not IsNumeric(txtFactorConversion.Text) Then
            MsgBox("Debe seleccionar un factor de conversión numérico")
            Exit Sub
        End If
        If Not dgvDatosActuales.Columns.Contains("IdProyecto") Then
            MsgBox("No ha seleccionado muestras")
            Exit Sub
        End If
        If Not dgvDatosActuales.Columns.Contains("variable") Then
            MsgBox("No ha seleccionado una variable a convertir")
            Exit Sub
        End If


        If tipodatos = "DatosSimples" Then
            'CONVIERTE LOS DATOS POR EL FACTOR
            Dim datoactual As Double
            Dim datonuevo As String
            For i As Integer = 0 To dgvDatosActuales.Rows.Count - 1
                If dgvDatosActuales.Item("variable", i).Value IsNot Nothing And dgvDatosActuales.Item("variable", i).Value <> "" And IsNumeric(dgvDatosActuales.Item("variable", i).Value) = True Then
                    datoactual = CDbl(dgvDatosActuales.Item("variable", i).Value.ToString)
                    datonuevo = datoactual * CDbl(txtFactorConversion.Text)
                    dgvDatosConvertidos.Item("variable", i).Value = datonuevo
                End If
            Next

        End If

    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////////
    '////////////////// Seleccion de proyecto
    '//////////////////

    Private Sub NombreComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreComboBox.SelectedIndexChanged
        Dim idproyectoausar As String = NombreComboBox.SelectedValue
        MuestrasTableAdapter.qryMuestrasByProyecto(Me.Scilla10DataSet.Muestras, idproyectoausar)

    End Sub
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////////
    '////////////////// Seleccion de modulo
    '//////////////////
    Private Sub cmbModulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModulo.SelectedIndexChanged
        Dim nombremodulo As String = cmbModulo.SelectedText
        Dim codigomodulo As String = cmbModulo.SelectedValue

        For i As Integer = 0 To ConfigDataSet.Tables("Modulos").Rows.Count - 1
            If ConfigDataSet.Tables("Modulos").Rows(i).Item("codigo").ToString = codigomodulo Then
                tipodatos = ConfigDataSet.Tables("Modulos").Rows(i).Item("tipo").ToString
            End If
        Next

        If tipodatos = "DatosSimples" Then
            cmbVariable.Enabled = True
            cargarVariablesCombo(codigomodulo, "CaracParametros", cmbVariable)
        ElseIf tipodatos.Contains("DatosTaxones") Then
            cmbVariable.Text = "Densidad - NO DISPONIBLE"
            cmbVariable.Enabled = False
            MsgBox("La conversión de datos de taxones aún no está disponible. Disculpe la molestias!")
        End If
    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////////
    '////////////////// Seleccion de variable
    '//////////////////

    Private Sub cmbVariable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVariable.SelectedIndexChanged
       
        If tipodatos = "DatosSimples" Then
            Dim codigomodulo As String = cmbModulo.SelectedValue
            Dim idvariable As String = "p" & cmbVariable.SelectedIndex + 1
            Dim variablecodigo As String = cmbVariable.SelectedValue.ToString

            If dgvDatosActuales.Columns.Contains("variable") Then
                dgvDatosActuales.Columns.Remove("variable")
                dgvDatosConvertidos.Columns.Remove("variable")
            End If

            Dim newcol As New DataGridViewTextBoxColumn
            Dim newcol1 As New DataGridViewTextBoxColumn
            newcol.Name = "variable"
            newcol.HeaderText = cmbVariable.Text
            newcol1.Name = "variable"
            newcol1.HeaderText = cmbVariable.Text
            dgvDatosActuales.Columns.Add(newcol)
            dgvDatosConvertidos.Columns.Add(newcol1)

            Dim con As New OleDb.OleDbConnection
            Dim ds As New DataSet
            Dim sql As String
            con.Close()

            ' CONECTA A LA TABLA DE DATOS Y BUSCA LOS DATOS PARA CADA MUESTRA
            Dim tablaname As String = "Parametros" & codigomodulo
            con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & codigomodulo & ".mdb"
            con.Open()

            For i As Integer = 0 To dgvDatosActuales.Rows.Count - 1
                Dim idmuestractual = dgvDatosActuales.Rows(i).Cells("IdMuestra").Value
                Sql = "SELECT * FROM " & tablaname & " WHERE IdMuestra='" & idmuestractual & "'"
                Dim da = New OleDb.OleDbDataAdapter(Sql, con)
                da.Fill(ds, "Tabla")
                If ds.Tables("Tabla").Rows.Count > 0 Then
                    dgvDatosActuales.Item("variable", i).Value = ds.Tables("Tabla").Rows(0).Item(idvariable).ToString
                    ds.Clear()
                End If
            Next
        End If
    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////////
    '////////////////// Guardar conversión
    '//////////////////

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' CONECTA A LA TABLA DE DATOS Y BUSCA LOS DATOS PARA CADA MUESTRA, Y ACTUALIZA
        Dim codigomodulo As String = cmbModulo.SelectedValue
        Dim idvariable As String = "p" & cmbVariable.SelectedIndex + 1
        Dim variablecodigo As String = cmbVariable.SelectedValue

        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim sql As String
        con.Close()
        Dim tablaname As String = "Parametros" & codigomodulo
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & codigomodulo & ".mdb"
        con.Open()

        For i As Integer = 0 To dgvDatosConvertidos.Rows.Count - 2
            Dim idmuestractual = dgvDatosConvertidos.Rows(i).Cells("IdMuestra").Value
            sql = "SELECT * FROM " & tablaname & " WHERE IdMuestra='" & idmuestractual & "'"
            Dim da = New OleDb.OleDbDataAdapter(sql, con)
            Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(da)
            da.Fill(ds, "Tabla")
            If ds.Tables("Tabla").Rows.Count > 0 Then
                If dgvDatosConvertidos.Rows(i).Cells("variable").Value.ToString <> "" And dgvDatosConvertidos.Rows(i).Cells("variable").Value IsNot Nothing And IsNumeric(dgvDatosConvertidos.Item("variable", i).Value) = True Then
                    ds.Tables("Tabla").Rows(0).Item(idvariable) = dgvDatosConvertidos.Item("variable", i).Value.ToString
                    da.Update(ds.Tables("Tabla"))
                End If
            End If
            ds.Clear()
        Next
    End Sub

    Private Sub btnSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarTodo.Click
        For i As Integer = 0 To MuestrasDataGridView.Rows.Count - 1
            MuestrasDataGridView.Rows(i).Selected = True
        Next
    End Sub

    Private Sub btnDeseleccionarTodo_Click(sender As Object, e As EventArgs) Handles btnDeseleccionarTodo.Click
        For i As Integer = 0 To MuestrasDataGridView.Rows.Count - 1
            MuestrasDataGridView.Rows(i).Selected = False
        Next
    End Sub


End Class