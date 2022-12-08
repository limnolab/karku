Public Class frmDBParametros
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim sql As String
    Dim da = New OleDb.OleDbDataAdapter
    Dim changes As DataSet
    Dim tipodatosactuales As String

    '
    ' ABRIR FUENTE DE DATOS
    '

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        dgvParametros.DataSource = Nothing
        BindingSource1.DataSource = Nothing
        ds.Tables.Clear()
        dgvParametros.Refresh()

        Dim dbname As String = cmFuente.SelectedValue
        Dim tablename As String

        'Se fija si son datos simples o datos de taxones, y cambia el nombre de la tabla acorde
        For i As Integer = 0 To ConfigDataSet.Tables("Modulos").Rows.Count - 1
            If ConfigDataSet.Tables("Modulos").Rows(i).Item("codigo").ToString = dbname Then
                If ConfigDataSet.Tables("Modulos").Rows(i).Item("Tipo").ToString.Contains("DatosSimples") Then
                    tablename = "CaracParametros"
                    tipodatosactuales = "Simples"
                    grpTaxon.Visible = False
                    grpSimples.Visible = True
                ElseIf ConfigDataSet.Tables("Modulos").Rows(i).Item("Tipo").ToString.Contains("DatosTaxones") Then
                    Dim tipodatos As String() = ConfigDataSet.Tables("Modulos").Rows(i).Item("Tipo").ToString.Split(";")
                    tablename = "Taxones"
                    dbname = tipodatos(1)
                    tipodatosactuales = "Taxones"
                    grpTaxon.Visible = True
                    grpSimples.Visible = False
                End If
            End If
        Next

        ' CONECTA A LA TABLA DE PARAMETROS

        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & dbname & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablename
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Tabla")

        BindingSource1.DataSource = ds.Tables("Tabla")
        dgvParametros.DataSource = BindingSource1
        dgvParametros.Columns("Id").Visible = False
        con.Close()

        'autocompletar nombre y acronimo
        Autocompletar("Nombre", txtSearch)
        Autocompletar("NombreParametro", txtSearch)

    End Sub

    'AUTOCOMPLETAR
    Private Sub Autocompletar(ByVal idcolumnaabuscar As String, ByVal textbox As TextBox)
        Dim col As New AutoCompleteStringCollection
        textbox.AutoCompleteSource = AutoCompleteSource.None
        If ds.Tables("Tabla").Columns.Contains(idcolumnaabuscar) Then
            For m As Integer = 0 To ds.Tables("Tabla").Rows.Count - 1
                col.Add(ds.Tables("Tabla").Rows(m).Item(idcolumnaabuscar).ToString)
            Next
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource
            textbox.AutoCompleteCustomSource = col
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End If
    End Sub

    Private Sub GuardarCambios()
        con.Open()

        dgvParametros.ReadOnly = True

        BindingSource1.EndEdit()

        Dim oledbCmdBuilder = New OleDb.OleDbCommandBuilder(da)
        changes = ds.GetChanges()
        If changes IsNot Nothing Then
            da.Update(ds.Tables("Tabla"))
        End If
        ds.AcceptChanges()
        dgvParametros.ReadOnly = False
        con.Close()
    End Sub

    Private Sub frmDBParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConfigDataSet.Modulos' table. You can move, or remove it, as needed.
        Me.ModulosTableAdapter.Fill(Me.ConfigDataSet.Modulos)

    End Sub

    '////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////// CARGAR DATOS O TAXONES
    '////////////////////////////////////////////////////////////////////////////////

    Private Sub dgvParametros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametros.CellClick
        'Carga los datos del taxon seleccionado
        If tipodatosactuales = "Taxones" Then
            'carga la imagen
            Dim imgname As String = dgvParametros.CurrentRow.Cells("foto").Value.ToString
            Dim pathlogo As String = pathapp & "\images\species\" & imgname
            If imgname <> "" Then
                If My.Computer.FileSystem.FileExists(pathlogo) Then
                    PictureBox1.BackgroundImage = Image.FromFile(pathlogo)
                    PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If

            'carga los textboxes
            IdTaxonTextBox.Text = dgvParametros.CurrentRow.Cells("IdTaxon").Value.ToString
            NombreTextBox.Text = dgvParametros.CurrentRow.Cells("Nombre").Value.ToString
            AutorTextBox.Text = dgvParametros.CurrentRow.Cells("Autor").Value.ToString
            AcronimoTextBox.Text = dgvParametros.CurrentRow.Cells("Acronimo").Value.ToString
            NivelTaxonomicoTextBox.Text = dgvParametros.CurrentRow.Cells("NivelTaxonomico").Value.ToString
            CategoriaPadreTextBox.Text = dgvParametros.CurrentRow.Cells("NivelPadre").Value.ToString

        ElseIf tipodatosactuales = "Simples" Then
            'Se fija los ambientes que estan seleccionados
            Dim ambientesarray As String() = dgvParametros.CurrentRow.Cells("TipoAmbiente").Value.ToString.Split(";")
            For i As Integer = 0 To chkAmbientes.Items.Count - 1
                chkAmbientes.SetItemChecked(i, False)
            Next
            If ambientesarray.Contains("ArroyoPamp") Then
                chkAmbientes.SetItemChecked(0, True)
            End If
            If ambientesarray.Contains("Apatagonico") Then
                chkAmbientes.SetItemChecked(1, True)
            End If
            If ambientesarray.Contains("Amontana") Then
                chkAmbientes.SetItemChecked(2, True)
            End If
            If ambientesarray.Contains("RLP") Then
                chkAmbientes.SetItemChecked(3, True)
            End If
            If ambientesarray.Contains("Lentico") Then
                chkAmbientes.SetItemChecked(4, True)
            End If
            'Se fija el tipo de campo que esta seleccionado, texto o combo
            Dim tipocampoarray As String() = dgvParametros.CurrentRow.Cells("TipoCampo").Value.ToString.Split(";")
            If tipocampoarray.Contains("Texto") Then
                rdTexto.Checked = True
                rdCombo.Checked = False
                rdComboTextbox.Text = ""
            Else
                rdTexto.Checked = False
                rdCombo.Checked = True
                Dim tipocampolines As String
                For i As Integer = 0 To tipocampoarray.Length - 1
                    tipocampolines = tipocampolines & tipocampoarray(i).TrimStart() & vbCrLf
                Next
                rdComboTextbox.Text = tipocampolines
                rdComboTextbox.Enabled = False
            End If

        End If
    End Sub
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' //////////////////////////////////////// EDITAR Y GUARDAR TAXON
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////

    Private Sub btnEditarTaxon_Click(sender As Object, e As EventArgs) Handles btnEditarTaxon.Click
        IdTaxonTextBox.Enabled = False
        NombreTextBox.Enabled = True
        AutorTextBox.Enabled = True
        AcronimoTextBox.Enabled = True
        NivelTaxonomicoTextBox.Enabled = True
        btnCambiarPadre.Enabled = True
        dgvParametros.ReadOnly = False
        dgvParametros.Columns("IdTaxon").ReadOnly = True
    End Sub

    Private Sub btnGuardarTaxon_Click(sender As Object, e As EventArgs) Handles btnGuardarTaxon.Click
        IdTaxonTextBox.Enabled = False
        NombreTextBox.Enabled = False
        AutorTextBox.Enabled = False
        AcronimoTextBox.Enabled = False
        NivelTaxonomicoTextBox.Enabled = False
        btnCambiarPadre.Enabled = False
        dgvParametros.CurrentRow.Cells("IdTaxon").Value = IdTaxonTextBox.Text
        dgvParametros.CurrentRow.Cells("Nombre").Value = NombreTextBox.Text
        dgvParametros.CurrentRow.Cells("Autor").Value = AutorTextBox.Text
        dgvParametros.CurrentRow.Cells("Acronimo").Value = AcronimoTextBox.Text
        dgvParametros.CurrentRow.Cells("NivelTaxonomico").Value = NivelTaxonomicoTextBox.Text
        dgvParametros.CurrentRow.Cells("NivelPadre").Value = CategoriaPadreTextBox.Text
        GuardarCambios()
        dgvParametros.ReadOnly = True
    End Sub

    ' ////////////////////////////////////////////////////////////////////////////////
    ' //////////////////////////////////////// CAMBIO DE PADRE DE TAXON
    '////////////////////////////////////////////////////////////////////////////////
    '
    Private Sub btnCambiarPadre_Click(sender As Object, e As EventArgs) Handles btnCambiarPadre.Click
        For i As Integer = 0 To dgvParametros.Rows.Count - 1
            CategoriaPadreComboBox.Items.Add(dgvParametros.Rows(i).Cells("Nombre").Value.ToString)
        Next
        CategoriaPadreComboBox.Visible = True
        btnLimpiarPadre.Visible = True
        btnCambiarPadre.Visible = False
        btnGuardarPadre.Visible = True
    End Sub


    Private Sub btnLimpiarPadre_Click(sender As Object, e As EventArgs) Handles btnLimpiarPadre.Click
        CategoriaPadreTextBox.Text = ""
        CategoriaPadreComboBox.Visible = False
        CategoriaPadreTextBox.Visible = True
        btnCambiarPadre.Visible = True
        btnLimpiarPadre.Visible = False
    End Sub

    Private Sub btnGuardarPadre_Click(sender As Object, e As EventArgs) Handles btnGuardarPadre.Click
        CategoriaPadreTextBox.Text = CategoriaPadreComboBox.Text
        CategoriaPadreComboBox.Visible = False
        btnLimpiarPadre.Visible = False
        btnCambiarPadre.Visible = True
        btnGuardarPadre.Visible = False
    End Sub

    'CAMBIO DE FOTO
    Dim newimagefullpath As String
    Dim newimagefilename As String

    Private Sub btnCambiarFoto_Click(sender As Object, e As EventArgs) Handles btnCambiarFoto.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = pathapp & "\images\species\"

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            If (OpenFileDialog.FileName IsNot Nothing) Or (OpenFileDialog.FileName <> String.Empty) Then
                newimagefullpath = OpenFileDialog.FileName
                newimagefilename = OpenFileDialog.SafeFileName
                PictureBox1.BackgroundImage = Image.FromFile(newimagefullpath)
                PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
                dgvParametros.CurrentRow.Cells("foto").Value = newimagefilename
            End If
        Else
            Exit Sub
        End If

        'COPIA EL NUEVO ARCHIVO DE IMAGEN A LA CARPETA DEL KARKU
        Dim FileToCopy As String
        Dim NewCopy As String

        FileToCopy = newimagefullpath
        NewCopy = pathapp & "\images\species\" & newimagefilename

        If System.IO.File.Exists(FileToCopy) = True Then
            System.IO.File.Copy(FileToCopy, NewCopy, True)
        End If

    End Sub

    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' //////////////////////////////////////// EDITAR Y GUARDAR PARAMETRO
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////

    Private Sub btnEditarParametro_Click(sender As Object, e As EventArgs) Handles btnEditarParametro.Click
        chkAmbientes.Enabled = True
        dgvParametros.Enabled = True
        rdTexto.Enabled = True
        rdCombo.Enabled = True
        dgvParametros.ReadOnly = False
        dgvParametros.Columns("codparametro").ReadOnly = True

        If rdCombo.Checked = True Then
            rdComboTextbox.Enabled = True
        Else
            rdComboTextbox.Enabled = False
        End If

    End Sub

    Private Sub rdCombo_CheckedChanged(sender As Object, e As EventArgs) Handles rdCombo.CheckedChanged
        rdComboTextbox.Enabled = True
    End Sub

    Private Sub rdTexto_CheckedChanged(sender As Object, e As EventArgs) Handles rdTexto.CheckedChanged
        rdComboTextbox.Enabled = False
    End Sub

    Private Sub btnGuardarParametro_Click(sender As Object, e As EventArgs) Handles btnGuardarParametro.Click

        'Convierte el tipo de ambiente
        Dim tipoambiente As String = ""
        For i As Integer = 0 To chkAmbientes.CheckedItems.Count - 1
            If chkAmbientes.CheckedItems.Item(i) = "Arroyos Pampeanos" Then
                tipoambiente = tipoambiente & "ArroyoPamp;"
            ElseIf chkAmbientes.CheckedItems.Item(i) = "Arroyos Patagónicos" Then
                tipoambiente = tipoambiente & "Apatagonico;"
            ElseIf chkAmbientes.CheckedItems.Item(i) = "Arroyos de montaña" Then
                tipoambiente = tipoambiente & "Amontana;"
            ElseIf chkAmbientes.CheckedItems.Item(i) = "Estuarios" Then
                tipoambiente = tipoambiente & "RLP;"
            ElseIf chkAmbientes.CheckedItems.Item(i) = "Lenticos" Then
                tipoambiente = tipoambiente & "Lentico;"
            End If
        Next

        'Convierte el tipo de campo
        Dim tipocampo As String = ""
        If rdTexto.Checked = True Then
            tipocampo = "Texto"
        ElseIf rdCombo.Checked = True Then
            If rdComboTextbox.Lines.Count = 0 Then
                MsgBox("No hay opciones para el tipo de campo 'combo'. Agregue opciones en el campo de texto (una línea por opción), o cambie el tipo de campo")
                Exit Sub
            End If
            For i As Integer = 0 To rdComboTextbox.Lines.Count - 1
                If rdComboTextbox.Lines(i).ToString <> "" Then
                    tipocampo = tipocampo & rdComboTextbox.Lines(i).ToString & ";"
                End If
            Next
        End If

        chkAmbientes.Enabled = False
        rdTexto.Enabled = False
        rdCombo.Enabled = False

        dgvParametros.CurrentRow.Cells("TipoAmbiente").Value = tipoambiente
        dgvParametros.CurrentRow.Cells("TipoCampo").Value = tipocampo

        GuardarCambios()
        dgvParametros.ReadOnly = True
        dgvParametros.Columns("codparametro").ReadOnly = True
    End Sub

End Class