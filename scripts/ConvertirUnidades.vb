Module ConvertirUnidades

    Dim pathapp As String = My.Application.Info.DirectoryPath


    Public Sub ConvertirUnidades(databasename As String, tabladatos As String, idproyecto As String)
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


    End Sub
End Module
