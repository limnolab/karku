Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text
Imports System.IO


Public Class frmResultadosCalcular
    Dim idproyecto As String
    Dim tipoproyecto As String
    Dim nombreproyecto As String
    Dim pathapp As String = My.Application.Info.DirectoryPath

    Public Sub RecibirVariables(ByVal idproy As Integer, ByVal tipoproy As String, ByVal nombreproy As String, datagridentrada As DataGridView)
        idproyecto = idproy
        tipoproyecto = tipoproy
        nombreproyecto = nombreproy
        dgvResultadosCalcular.Columns.Clear()


        'Copia la datagridentrada a dgvResultadosCalcular, con valores y estilos
        For Each Col As DataGridViewColumn In datagridentrada.Columns
            dgvResultadosCalcular.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next

        For i As Integer = 0 To datagridentrada.Rows.Count - 2
            Dim row As DataGridViewRow
            row = CType(datagridentrada.Rows(i).Clone(), DataGridViewRow)
            For index As Int32 = 0 To datagridentrada.Rows(i).Cells.Count - 1
                row.Cells(index).Value = datagridentrada.Rows(i).Cells(index).Value
            Next
            dgvResultadosCalcular.Rows.Add(row)
        Next

        ' agrega una nueva col con el link para la muestra
        Dim colvermuestra As New DataGridViewLinkColumn
        colvermuestra.HeaderText = "Detalles"
        colvermuestra.Name = "Detalles"
        colvermuestra.LinkColor = Color.DarkCyan
        colvermuestra.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        dgvResultadosCalcular.Columns.Add(colvermuestra)
        colvermuestra.DisplayIndex = 0
        colvermuestra.UseColumnTextForLinkValue = False

        For i As Integer = 0 To dgvResultadosCalcular.Rows.Count - 1
            dgvResultadosCalcular.Item("Detalles", i).Value = "Mas..."
            dgvResultadosCalcular.Item("Detalles", i).ToolTipText = "Mas..."
        Next

        dgvResultadosCalcular.Columns("IdMuestra").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvResultadosCalcular.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub


    Private Sub frmResultadosCalcular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'traduce las variables que contienen el caracter "_", es decir aquellas que tienen una variable_comunidad (eutrofizacion_diatomeas, saprobiedad_diatomeas,etc)
        TraducirCategorias()
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////
    '//////////////////// ESTE SCRIPT TRADUCE CATEGORIAS
    '////////////////////
    'traduce las variables que contienen el caracter "_", es decir aquellas que tienen una variable_comunidad (eutrofizacion_diatomeas, saprobiedad_diatomeas,etc)

    Private Sub TraducirCategorias()
        For i As Integer = 0 To dgvResultadosCalcular.ColumnCount - 1
            If dgvResultadosCalcular.Columns(i).Name.Contains("_") Then
                Dim nombrecolentero As String() = dgvResultadosCalcular.Columns(i).HeaderText.ToString.Split(" -")
                Dim categoriatraducir = nombrecolentero(2).Trim("-")
                Dim nombredbcomunidad As String = dgvResultadosCalcular.Columns(i).ToolTipText.Remove(0, 8).ToLower

                ' CONEXION A LA TABLA
                Dim TABLAcon As New OleDb.OleDbConnection
                Dim TABLAds As New DataSet
                Dim TABLASQL As String
                TABLAcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\dbcalculos\" & nombredbcomunidad & ".mdb"
                TABLAcon.Open()
                TABLASQL = "SELECT * FROM Traducir" & nombrecolentero(0).ToUpper & " WHERE Valor='" & categoriatraducir & "'"
                Dim TABLAda = New OleDb.OleDbDataAdapter(TABLASQL, TABLAcon)
                TABLAda.Fill(TABLAds, "TablaTraducir")

                Dim categoriatraducida As String = TABLAds.Tables("TablaTraducir").Rows(0).Item("Traduccion").ToString

                Dim nombrenuevocol As String = nombrecolentero(1).Trim(")")
                nombrenuevocol = nombrenuevocol.Trim("(")
                dgvResultadosCalcular.Columns(i).HeaderText = nombrenuevocol & " " & categoriatraducida
            End If
        Next
    End Sub

    Private Sub btnGraficarResultados_Click(sender As Object, e As EventArgs) Handles btnGraficarResultados.Click
        frmGraficar.RecibirVariables(idproyecto, tipoproyecto, nombreproyecto, dgvResultadosCalcular)
        frmGraficar.Show()
    End Sub

    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////
    '////////       EXPORTAR
    '////////
    '////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////


    Private Sub ATextoDelimitadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATextoDelimitadoToolStripMenuItem.Click
        ExportarDGVaCSV(dgvResultadosCalcular, "Resultados")
    End Sub

    Private Sub AExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AExcelToolStripMenuItem.Click
        ExportarDGVaXLS(dgvResultadosCalcular, "Resultados")
    End Sub

    Private Sub btnInterpretacion_Click(sender As Object, e As EventArgs) Handles btnInterpretacion.Click
        TraducirIndices(dgvResultadosCalcular)
    End Sub

    ' TRADUCIR Y VER MAS DETALLES
    Dim valorestraducidos As Boolean = False
    Private Sub TraducirIndices(datagridviewinput As DataGridView)
        For i As Integer = 2 To datagridviewinput.Columns.Count - 1
            For j As Integer = 0 To datagridviewinput.Rows.Count - 1
                If Not datagridviewinput.Item(i, j).ToolTipText = Nothing Then
                    If Not datagridviewinput.Item(i, j).ToolTipText.ToString = "Sin datos" Then
                        Dim valororiginal As String = datagridviewinput.Item(i, j).Value
                        datagridviewinput.Item(i, j).Value = datagridviewinput.Item(i, j).ToolTipText
                        datagridviewinput.Item(i, j).ToolTipText = valororiginal
                    Else
                        Dim valororiginal As String = datagridviewinput.Item(i, j).Value
                        datagridviewinput.Item(i, j).Value = Nothing
                        datagridviewinput.Item(i, j).ToolTipText = "Sin datos"
                    End If
                End If
            Next
        Next
        If valorestraducidos = False Then
            valorestraducidos = True
        Else
            valorestraducidos = False
        End If
    End Sub

    Private Sub dgvResultadosCalcular_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultadosCalcular.CellContentClick

        If valorestraducidos = True Then
            TraducirIndices(dgvResultadosCalcular)
            Dim idmuestraactual As Integer = dgvResultadosCalcular.CurrentRow.Index
            frmInterpretacion.RecibirVariables(idproyecto, tipoproyecto, nombreproyecto, dgvResultadosCalcular)
            frmInterpretacion.Show()
            frmInterpretacion.CargaMuestra(idmuestraactual)
            TraducirIndices(dgvResultadosCalcular)
        Else
            Dim idmuestraactual As Integer = dgvResultadosCalcular.CurrentRow.Index
            frmInterpretacion.RecibirVariables(idproyecto, tipoproyecto, nombreproyecto, dgvResultadosCalcular)
            frmInterpretacion.Show()
            frmInterpretacion.CargaMuestra(idmuestraactual)
        End If



    End Sub


End Class