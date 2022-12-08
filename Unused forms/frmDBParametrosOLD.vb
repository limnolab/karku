Public Class frmDBParametrosOLD
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim sql As String
    Dim da = New OleDb.OleDbDataAdapter
    Dim changes As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Close()
        dgvParametros.Refresh()
        dgvParametros.DataSource = Nothing
        ds.Clear()

        Dim tablaparametros As String = "CaracParametros"
        Dim databasename As String

        If cmFuente.Text = "Físico-químicos" Then
            databasename = "fq"
        ElseIf cmFuente.Text = "Hábitat" Then
            databasename = "habitat"
        ElseIf cmFuente.Text = "Cauce" Then
            databasename = "cauce"
        ElseIf cmFuente.Text = "Otros" Then
            databasename = "otros"
        End If

        ' CONECTA A LA TABLA DE PARAMETROS

        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\" & databasename & ".mdb"
        con.Open()
        sql = "SELECT * FROM " & tablaparametros
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Tabla")

        BindingSource1.DataSource = ds.Tables("Tabla")
        BindingNavigatorParametros.BindingSource = BindingSource1
        dgvParametros.DataSource = BindingSource1
        dgvParametros.Columns("Id").Visible = False

        SaveToolStripButton.Enabled = True
        con.Close()

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
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
End Class