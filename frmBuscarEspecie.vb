Imports System.Reflection
Imports Google.API.Search
Imports System.IO
Imports System.Threading

Public Class frmBuscarEspecie
    Dim organismo As String
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim sql As String
    Dim da = New OleDb.OleDbDataAdapter
    Dim changes As DataSet
    Dim tipodatosactuales As String

    ' defino una dgv para la lista de taxones
    Dim TaxonesDataGridView As New DataGridView

    Public Sub RecibirVariables(ByVal organismos As String)
        organismo = organismos
    End Sub


    Private Sub frmBuscarEspecie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Conectar a modulos de taxones
        Me.ModulosTableAdapter.FillByDatosTaxones(Me.ConfigDataSet.Modulos)

        txtNombre.DataSource = Nothing
        txtAutor.DataSource = Nothing

        dgvParametros.DataSource = Nothing
        BindingSource1.DataSource = Nothing
        ds.Tables.Clear()
        dgvParametros.Refresh()

        Dim dbname As String = organismo.ToLower
        Dim tablename As String = "Taxones"
        tipodatosactuales = organismo.ToLower

        ' CONECTA A LA TABLA DE TAXONES, EL LISTADO COMPLETO

        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & dbname & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablename
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "TablaTaxones")

        BindingSource1.DataSource = ds.Tables("TablaTaxones")
        dgvParametros.DataSource = BindingSource1

        For i As Integer = 0 To dgvParametros.ColumnCount - 1
            If dgvParametros.Columns(i).Name <> "Nombre" And dgvParametros.Columns(i).Name <> "IdTaxon" Then
                dgvParametros.Columns(i).Visible = False
            End If
        Next
        dgvParametros.Columns("IdTaxon").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        dgvParametros.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        txtNombre.DataSource = dgvParametros.DataSource
        txtNombre.DataField = "Nombre"
        txtAutor.DataSource = dgvParametros.DataSource
        txtAutor.DataField = "Autor"
        con.Close()

        'autocompletar nombre y acronimo
        txtSearch.Enabled = True
        txtSearchAcronimo.Enabled = True

        Autocompletar("Nombre", txtSearch)
        Autocompletar("Acronimo", txtSearchAcronimo)


    End Sub


    'AUTOCOMPLETAR
    Private Sub Autocompletar(ByVal idcolumnaabuscar As String, ByVal textbox As TextBox)
        Dim col As New AutoCompleteStringCollection
        textbox.AutoCompleteSource = AutoCompleteSource.None
        If ds.Tables("TablaTaxones").Columns.Contains(idcolumnaabuscar) Then
            For m As Integer = 0 To ds.Tables("TablaTaxones").Rows.Count - 1
                col.Add(ds.Tables("TablaTaxones").Rows(m).Item(idcolumnaabuscar).ToString)
            Next
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource
            textbox.AutoCompleteCustomSource = col
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End If
    End Sub


    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        Dim taxonabuscar As String = txtSearch.Text
        Dim i As Integer

        If taxonabuscar = "" Then
            Exit Sub
        End If

        dgvParametros.ClearSelection()
        For i = 0 To dgvParametros.RowCount - 1
            If dgvParametros.Item("Nombre", i).Value.ToString = taxonabuscar Then
                dgvParametros.CurrentCell = dgvParametros.Rows(i).Cells(1)
                txtSearchAcronimo.Text = dgvParametros.Item("Acronimo", i).Value.ToString
                dgvParametros.Rows(i).Selected = True
                CargarFoto()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub txtSearchAcronimo_LostFocus(sender As Object, e As EventArgs) Handles txtSearchAcronimo.LostFocus
        'Controla si la especie existe
        Dim nametaxon As String
        Dim acronimovar As String
        Dim j As Integer
        acronimovar = txtSearchAcronimo.Text
        dgvParametros.ClearSelection()
        If Not txtSearchAcronimo.Text = "" Then
            For j = 0 To dgvParametros.RowCount - 1
                If dgvParametros.Item("Acronimo", j).Value.ToString = acronimovar Then
                    dgvParametros.CurrentCell = dgvParametros.Rows(j).Cells(1)
                    nametaxon = dgvParametros.Item("Nombre", j).Value.ToString
                    txtSearch.Text = nametaxon
                    dgvParametros.Rows(j).Selected = True
                    CargarFoto()
                    Exit Sub
                End If
            Next j
        End If
    End Sub

    Private Sub FillByDatosTaxonesToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ModulosTableAdapter.FillByDatosTaxones(Me.ConfigDataSet.Modulos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvParametros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametros.CellClick
        CargarFoto()
    End Sub

    'CARGA LA FOTO DESDE EL ARCHIVO, CIERRA LA THREAD 2RIA

    Private Sub CargarFoto()
        If trd IsNot Nothing Then
            If trd.ThreadState = ThreadState.Running Or trd.ThreadState = ThreadState.Background Then
                trd.Abort()
            End If
        End If

        fototaxon.Image = Nothing
        btnSiguiente.Visible = False
        If results1 IsNot Nothing Then
            results1.Clear()
        End If

        Dim idtaxonabuscar As String = dgvParametros.CurrentRow.Cells("IdTaxon").Value.ToString
        DatosTaxon(idtaxonabuscar, organismo.ToLower, DataGridView1)

        'Carga la foto offline
        Try

            Dim logoname As String = dgvParametros.CurrentRow.Cells("Foto").Value.ToString
            Dim pathlogo As String = pathapp & "\fotosespecies\" & logoname
            If logoname <> "" Then
                fototaxon.Image = Image.FromFile(pathlogo)
                fototaxon.SizeMode = PictureBoxSizeMode.Zoom
            Else
                fototaxon.Image = My.Resources.logoKerku1
                'fototaxon.Image = Nothing
            End If
        Catch ex As Exception
            fototaxon.Image = My.Resources.logoKerku1
        End Try

    End Sub

    'CARGA DE FOTO ONLINE

    Dim results1 As IList(Of IImageResult)
    Dim currentresult As Integer
    Dim trd As Thread

    'BUSCA LA SP EN GOOGLE IMAGES, 5 RESULTADOS
    Private Sub btnSearchGoogle_Click(sender As Object, e As EventArgs) Handles btnSearchGoogle.Click
        ' carga la foto online 

        Dim client As New GimageSearchClient("http://images.google.com")
        results1 = client.Search(txtNombre.Text, 5)
        currentresult = 1

        trd = New Thread(AddressOf CargarFotoOnline)
        trd.IsBackground = True
        trd.Start()
        btnSiguiente.Visible = True
    End Sub

    Private Sub CargarFotoOnline(numerofoto As Integer)
        If numerofoto <> 0 Then
            fototaxon.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(results1(numerofoto).Url)))
        End If

    End Sub

    'BOTON DE SIGUIENTE IMAGEN DE GOOGLE IMAGES
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If results1 IsNot Nothing And results1.Count > 0 Then
            If trd IsNot Nothing Then
                CargarFotoOnline(currentresult)
                If currentresult = results1.Count - 1 Then
                    currentresult = 0
                Else
                    currentresult = currentresult + 1
                End If
            End If
        End If

    End Sub
End Class