Imports System.Reflection
Public Class frmDBIndices
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim sql As String
    Dim da = New OleDb.OleDbDataAdapter
    Dim changes As DataSet
    Dim tipodatosactuales As String

    ' conexion para db de taxones
    Dim conTaxones As New OleDb.OleDbConnection
    Dim dsTaxones As New DataSet
    Dim sqlTaxones As String
    Dim changesTaxones As DataSet
    Dim daTaxones = New OleDb.OleDbDataAdapter


    '
    ' ABRIR FUENTE DE DATOS
    '

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        'limpia todos los databindings
        IdTaxonTextBox.DataBindings.Clear()
        NombreTextBox.DataBindings.Clear()
        AutorTextBox.DataBindings.Clear()
        AcronimoTextBox.DataBindings.Clear()
        txtValor.DataBindings.Clear()
        txtNotas.DataBindings.Clear()
        txtCategoriaParametro.DataBindings.Clear()
        txtCodigoParametro.DataBindings.Clear()
        txtVariableParametro.DataBindings.Clear()
        dgvParametros.DataSource = Nothing
        BindingSource1.DataSource = Nothing
        BindingSourceTaxones.DataSource = Nothing

        'esconde todos los textboxes
        IdTaxonTextBox.Enabled = False
        NombreTextBox.Enabled = False
        AcronimoTextBox.Enabled = False
        AutorTextBox.Enabled = False
        txtValor.Enabled = False
        txtCategoriaParametro.Enabled = False
        txtCodigoParametro.Enabled = False
        txtVariableParametro.Enabled = False

        ds.Tables.Clear()
        dsTaxones.Tables.Clear()
        dgvParametros.Refresh()

        Dim dbname As String = cmFuente.SelectedValue
        Dim tablename As String = "Carac" & cmFuente.SelectedValue.ToString.ToUpper

        ' CONECTA A LA TABLA DE PARAMETROS

        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\" & dbname & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablename
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Tabla")

        BindingSource1.DataSource = ds.Tables("Tabla")
        dgvParametros.DataSource = BindingSource1

        'CIERRA LAS CONEXIONES
        con.Close()

        ' Se fija si es de taxones y bindea
        If dgvParametros.Columns.Contains("IdTaxon") Then
            Dim mType As Type = Type.GetType("Scila7." & dbname)
            Dim mMethod As MethodInfo = mType.GetMethod("DefineTaxones" & dbname.ToUpper)
            Dim mValue As Object = mMethod.Invoke(mType, New Object() {"dummyparameter"})

            conTaxones.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & mValue & ".mdb"
            conTaxones.Open()
            sqlTaxones = "SELECT * FROM Taxones"
            daTaxones = New OleDb.OleDbDataAdapter(sqlTaxones, conTaxones)
            daTaxones.Fill(dsTaxones, "TablaTaxones")

            BindingSourceTaxones.DataSource = dsTaxones.Tables("TablaTaxones")
            IdTaxonTextBox.DataBindings.Add("Text", BindingSourceTaxones, "IdTaxon")
            NombreTextBox.DataBindings.Add("Text", BindingSourceTaxones, "Nombre")
            AutorTextBox.DataBindings.Add("Text", BindingSourceTaxones, "Autor")
            AcronimoTextBox.DataBindings.Add("Text", BindingSourceTaxones, "Acronimo")

            AcronimoTextBox.Enabled = True
            NombreTextBox.Enabled = True
            conTaxones.Close()
        Else
            ' Si no es de taxones, bindea en nombre
            NombreTextBox.DataBindings.Add("Text", BindingSource1, "Nombre")
            conTaxones.Close()
        End If

        ' esconde todas las columnas
        For i = 0 To dgvParametros.Columns.Count - 1
            dgvParametros.Columns(i).Visible = False
        Next
        'y hace visibles las columnas que sirven si es un taxon

        If dgvParametros.Columns.Contains("IdTaxon") Then
            dgvParametros.Columns("IdTaxon").Visible = True
            IdTaxonTextBox.Enabled = False
        End If
        If dgvParametros.Columns.Contains("Valor") Then
            dgvParametros.Columns("Valor").Visible = True
            txtValor.DataBindings.Add("Text", BindingSource1, "Valor")
            txtValor.Enabled = True
        End If
        If dgvParametros.Columns.Contains("Notas") Then
            dgvParametros.Columns("Notas").Visible = True
            txtNotas.DataBindings.Add("Text", BindingSource1, "Notas")
            txtNotas.Enabled = True
        End If

        If dgvParametros.Columns.Contains("Nombre") Then
            dgvParametros.Columns("Nombre").Visible = True
            NombreTextBox.Enabled = True
        End If

        'o las de los parametros
        If dgvParametros.Columns.Contains("categoria") Then
            dgvParametros.Columns("categoria").Visible = True
            txtCategoriaParametro.DataBindings.Add("Text", BindingSource1, "Categoria")
            txtCategoriaParametro.Enabled = True
        End If
        If dgvParametros.Columns.Contains("variable") Then
            dgvParametros.Columns("variable").Visible = True
            txtVariableParametro.DataBindings.Add("Text", BindingSource1, "variable")
            txtVariableParametro.Enabled = True
        End If
        If dgvParametros.Columns.Contains("Codigo") Then
            dgvParametros.Columns("Codigo").Visible = True
            txtCodigoParametro.DataBindings.Add("Text", BindingSource1, "Codigo")
            txtCodigoParametro.Enabled = True
        End If
    End Sub

    Private Sub frmDBParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CalculosTableAdapter.Fill(Me.ConfigDataSet.Calculos)
        Me.ModulosTableAdapter.Fill(Me.ConfigDataSet.Modulos)
    End Sub

    '////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////// CARGAR DATOS O TAXONES
    '////////////////////////////////////////////////////////////////////////////////

    Private Sub dgvParametros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametros.CellClick
        ' Se fija si es de taxones
        If dgvParametros.Columns.Contains("IdTaxon") Then
            Dim idtaxonselected As String = dgvParametros.CurrentRow.Cells("IdTaxon").Value.ToString
            Dim itemFound As Integer = BindingSourceTaxones.Find("IdTaxon", idtaxonselected)
            BindingSourceTaxones.Position = itemFound
        End If
    End Sub

    '////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////// EDITAR DATOS O TAXONES
    '////////////////////////////////////////////////////////////////////////////////

    Private Sub btnEditarParametro_Click(sender As Object, e As EventArgs) Handles btnEditarParametro.Click
        grpTaxon.Enabled = True
        dgvParametros.Enabled = True
        dgvParametros.ReadOnly = False
    End Sub

    '////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////// GUARDAR DATOS O TAXONES
    '////////////////////////////////////////////////////////////////////////////////

    Private Sub btnGuardarParametro_Click(sender As Object, e As EventArgs) Handles btnGuardarParametro.Click

        'dgvParametros.CurrentRow.Cells("TipoAmbiente").Value = tipoambiente
        'dgvParametros.CurrentRow.Cells("TipoCampo").Value = tipocampo
        GuardarCambios()
        grpTaxon.Enabled = False
        dgvParametros.ReadOnly = True

    End Sub

    Private Sub GuardarCambios()
        con.Open()
        BindingSource1.EndEdit()
        BindingSourceParametros.EndEdit()

        Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(da)
        changes = ds.GetChanges()
        If changes IsNot Nothing Then
            da.Update(ds.Tables("Tabla"))
        End If
        ds.AcceptChanges()
        con.Close()

        'conTaxones.Open()
        Dim oledbCmdBuilder1 = New OleDb.OleDbCommandBuilder(da)
        changesTaxones = dsTaxones.GetChanges()
        If changesTaxones IsNot Nothing Then
            daTaxones.Update(dsTaxones.Tables("TablaTaxones"))
        End If
        dsTaxones.AcceptChanges()
        conTaxones.Close()

    End Sub

End Class