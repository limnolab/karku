Module ArbolMacroinv
    Dim nombrepadre As String
    Dim nombrehijo As String
    Dim taxonyaesta As Boolean

    Public Sub ArmarArbol(ByVal treeview As TreeView, ByVal dt As DataTable)

        'SACO EL NUMERO TOTAL DE TAXONES Y NODOS
        Dim numerotaxones As Integer = 0
        numerotaxones = dt.Rows.Count
        Dim numeronodos As Integer = 0

        ' Agrego un nodo base
        Dim mainNode As New TreeNode()
        mainNode.Name = "mainNode"
        mainNode.Text = "Taxones"
        treeview.Nodes.Add(mainNode)

        'AGREGA PADRES
        For Each row As DataRow In dt.Rows
            If row.Item("NivelPadre").ToString = "" Then
                Dim node As New TreeNode()
                node.Text = row.Item("Nombre").ToString()
                node.Name = row.Item("Nombre").ToString()
                mainNode.Nodes.Add(node)
            End If
        Next

        ' AGREGA HIJOS 
        ' HASTA Q EL NUMERO DE NODOS EN EL ARBOL
        ' SEA IGUAL AL NUMERO DE TAXONES TOTALES EN LA DB
        numeronodos = treeview.GetNodeCount(True)
        Do Until numeronodos >= numerotaxones
            AgregarHijos(treeview, dt)
            numeronodos = treeview.GetNodeCount(True)
        Loop

    End Sub

    Private Sub AgregarHijos(ByVal treeview As TreeView, ByVal dt As DataTable)
        Dim trv As TreeView = treeview

        For Each row As DataRow In dt.Rows
            If row.Item("NivelPadre").ToString <> "" Then
                nombrepadre = row.Item("NivelPadre").ToString
                nombrehijo = row.Item("Nombre").ToString

                'BUSCA HIJO EN EL ARBOL
                'SI EL HIJO YA ESTA, NO LO VUELVE A AGREGAR

                Dim tn() As TreeNode = treeview.Nodes(0).Nodes.Find(nombrehijo, True)
                If tn.Length = 0 Then
                    ' EL HIJO NO ESTA EN EL ARBOL
                    BuscarTaxon(nombrepadre, nombrehijo, True, treeview)
                End If
            End If
        Next
    End Sub

    Private Sub BuscarTaxon(ByVal taxonabuscar As String, ByVal taxonaagregar As String, ByVal debeagregarsino As Boolean, ByVal treeview As TreeView)
        Try
            ' BUSCA EL TAXON POR NOMBRE EN EL ARBOL
            Dim tn() As TreeNode = treeview.Nodes(0).Nodes.Find(taxonabuscar, True)
            Dim i As Integer = 0
            If tn.Length <> 0 Then
                If debeagregarsino = True Then
                    ' AGREGO EL TAXON HIJO AL NODO ENCONTRADO
                    treeview.SelectedNode = tn(i)
                    Dim subnode = New TreeNode()
                    subnode.Text = taxonaagregar
                    subnode.Name = taxonaagregar
                    treeview.SelectedNode.Nodes.Add(subnode)
                End If
            End If
        Catch
            'do nothing
        End Try
    End Sub
End Module
