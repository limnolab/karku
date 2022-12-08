Public Class frmProyectos
    Dim tipoproyecto As String
    Dim idproyecto As Integer
    Dim frmWorkingDialog As New frmWorkingDialog
    Dim pathapp As String = My.Application.Info.DirectoryPath


    Public Sub RecibirVariables(ByVal tipo As String)
        'RECIBO TIPO DE PROYECTO DE FRMMAIN
        tipoproyecto = tipo
    End Sub

    Private Sub frmProyectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaAdaptadores()
    End Sub

    Private Sub CargaAdaptadores()

        'CARGA DATOS DE PROYECTOS
        Me.ConfigTableAdapter.Fill(Me.ConfigDataSet.Config)
        Me.ProyectosTableAdapter.qryProyectosByAmbiente(Me.Scilla10DataSet.Proyectos, tipoproyecto)
        Me.MuestrasTableAdapter.Fill(Me.Scilla10DataSet.Muestras)
    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   NAVIGATION BAR
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub SalirAWindowsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirAWindowsToolStripMenuItem1.Click

    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   NUEVO PROYECTO
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub btnNuevoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProyecto.Click
        Dim nombreproyecto As String
        Dim autorproyecto As String
        nombreproyecto = InputBox("Ingrese el nombre del proyecto", , "Proyecto ")

        If nombreproyecto <> "" Then
            autorproyecto = InputBox("Ingrese el autor del proyecto", , "Autor")
            If autorproyecto <> "" Then
                ' AGREGA PROYECTO
                ProyectosBindingSource.AddNew()

                'AGREGA EL NOMBRE Y AUTOR DE LOS INPUTS
                NombreTextBox.Text = nombreproyecto
                AutorTextBox.Text = autorproyecto

                'GUARDA EL NUEVO PROYECTO
                AmbienteTextBox.Text = tipoproyecto

                ProyectosBindingSource.EndEdit()
                ProyectosTableAdapter.Update(Scilla10DataSet.Proyectos)

                'RECARGA ADAPTADORES, SINO NO PASA BIEN EL IDPROYECTO AL SIGUIENTE FORM
                CargaAdaptadores()
                ProyectosBindingSource.MoveLast()

            Else
                'CANCELA EL INPUT AUTOR DEL PROYECTO
                Exit Sub
            End If
        Else
            ' CANCELA EL INPUT NOMBRE DEL PROYECTO
            Exit Sub
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   GUARDAR PROYECTO
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub btnGuardarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarProyecto.Click
        'GUARDA EL NUEVO PROYECTO
        AmbienteTextBox.Text = tipoproyecto

        ProyectosBindingSource.EndEdit()
        ProyectosTableAdapter.Update(Scilla10DataSet.Proyectos)

        ' ESCONDE BOTONES INNECESARIOS Y MUESTRA NECESARIOS
        btnNuevoProyecto.Visible = True
        btnEditarProyecto.Visible = True
        btnAbrirProyecto.Visible = True
        btnBorrarProyecto.Visible = True
        btnGuardarProyecto.Visible = False
        NombreTextBox.Enabled = False
        AutorTextBox.Enabled = False
        DescripcionTextBox.Enabled = False


        'RECARGA ADAPTADORES, SINO NO PASA BIEN EL IDPROYECTO AL SIGUIENTE FORM
        CargaAdaptadores()
        ProyectosBindingSource.MoveLast()

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   BORRAR PROYECTO
    '////                   necesita recorrer todas las subtablas y borrar cada record relacionado
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub btnBorrarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarProyecto.Click
        Dim idmuestraborrar As Integer
        Dim i As Integer


        If Not ProyectosDataGridView.RowCount = 0 Then
            If MessageBox.Show("Esta seguro de borrar este proyecto?", "Cuidado!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If Not MuestrasDataGridView.RowCount = 0 Then
                    For i = 0 To MuestrasDataGridView.RowCount - 1
                        idmuestraborrar = MuestrasDataGridView.Item(0, i).Value
                        MsgBox("Borrando muestra " & idmuestraborrar)

                        ' TABLA DE SITIOS
                        frmAPampeano.SitiosMuestrasTableAdapter.qrySitioByMuestra(frmAPampeano.SitiosDataSet.SitiosMuestras, idmuestraborrar)
                        If frmAPampeano.SitiosMuestrasBindingSource.Count <> 0 Then
                            frmAPampeano.SitiosMuestrasBindingSource.RemoveCurrent()
                            frmAPampeano.SitiosMuestrasTableAdapter.Update(frmAPampeano.SitiosDataSet.SitiosMuestras)
                        End If

                        ' TABLA DE CAUCE
                        frmAPampeano.ParametrosCauceTableAdapter.qryParametrosCaucebyIdMuestra(frmAPampeano.CauceDataSet.ParametrosCauce, idmuestraborrar)
                        If frmAPampeano.ParametrosCauceBindingSource.Count <> 0 Then
                            frmAPampeano.ParametrosCauceBindingSource.RemoveCurrent()
                            frmAPampeano.ParametrosCauceTableAdapter.Update(frmAPampeano.CauceDataSet.ParametrosCauce)
                        End If

                        ' TABLA DE FQ
                        frmAPampeano.ParametrosFQTableAdapter.qryFQbyIdMuestra(frmAPampeano.FqDataSet.ParametrosFQ, idmuestraborrar)
                        If frmAPampeano.ParametrosFQBindingSource.Count <> 0 Then
                            frmAPampeano.ParametrosFQBindingSource.RemoveCurrent()
                            frmAPampeano.ParametrosFQTableAdapter.Update(frmAPampeano.FqDataSet.ParametrosFQ)
                        End If

                        ' TABLA DE HABITAT
                        frmAPampeano.ParametrosHabitatTableAdapter.qryParametrosHabitatbyIdMuestra(frmAPampeano.HabitatDataSet.ParametrosHabitat, idmuestraborrar)
                        If frmAPampeano.ParametrosHabitatBindingSource.Count <> 0 Then
                            frmAPampeano.ParametrosHabitatBindingSource.RemoveCurrent()
                            frmAPampeano.ParametrosHabitatTableAdapter.Update(frmAPampeano.HabitatDataSet.ParametrosHabitat)
                        End If

                        ' TABLA DE OTROS
                        frmAPampeano.OtrosdatosTableAdapter.qryOtrosDatosbyIdMuestra(frmAPampeano.OtrosDataSet.Otrosdatos, idmuestraborrar)
                        If frmAPampeano.OtrosdatosBindingSource.Count <> 0 Then
                            frmAPampeano.OtrosdatosBindingSource.RemoveCurrent()
                            frmAPampeano.OtrosdatosTableAdapter.Update(frmAPampeano.OtrosDataSet.Otrosdatos)
                        End If

                        ' TABLA DE IBMAMP
                        frmAPampeano.IBPAMPTableAdapter.qryIBPAMPByIdMuestra(frmAPampeano.IbpampDataSet.IBPAMP, idmuestraborrar)
                        If frmAPampeano.IBPAMPBindingSource.Count <> 0 Then
                            frmAPampeano.IBPAMPBindingSource.RemoveCurrent()
                            frmAPampeano.IBPAMPTableAdapter.Update(frmAPampeano.IbpampDataSet.IBPAMP)
                        End If

                        ' TABLA DE IDP
                        frmAPampeano.IDPTableAdapter.qryIDPbyIdMuestra(frmAPampeano.IdpDataSet.IDP, idmuestraborrar)
                        If frmAPampeano.IDPBindingSource.Count <> 0 Then
                            frmAPampeano.IDPBindingSource.RemoveCurrent()
                            frmAPampeano.IDPTableAdapter.Update(frmAPampeano.IdpDataSet.IDP)
                        End If

                        ' TABLA DE IMRP
                        frmAPampeano.IMRPTableAdapter.qryIMRPbyIdMuestra(frmAPampeano.ImrpDataSet.IMRP, idmuestraborrar)
                        If frmAPampeano.IMRPBindingSource.Count <> 0 Then
                            frmAPampeano.IMRPBindingSource.RemoveCurrent()
                            frmAPampeano.IMRPTableAdapter.Update(frmAPampeano.ImrpDataSet.IMRP)
                        End If

                        ' TABLAS DE TAXONESMUESTRAS
                        ' DIATOMEAS
                        Dim diatomeascon As New OleDb.OleDbConnection
                        Dim diatomeasds As New DataSet
                        Dim diatomeasSQL As String
                        diatomeascon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
                        diatomeascon.Open()
                        diatomeasSQL = "SELECT * FROM diats WHERE IdMuestra = '" & idmuestraborrar & "'"
                        Dim diatomeasda = New OleDb.OleDbDataAdapter(diatomeasSQL, diatomeascon)
                        diatomeasda.Fill(diatomeasds, "Tabladiatomeas")

                        If diatomeasds.Tables("Tabladiatomeas").Rows.Count <> 0 Then
                            diatomeasds.Tables("Tabladiatomeas").Rows(0).Delete()
                            Dim cb As New OleDb.OleDbCommandBuilder(diatomeasda)
                            diatomeasda.Update(diatomeasds, "Tabladiatomeas")
                        End If
                        diatomeascon.Close()


                        ' TABLAS DE TAXONESMUESTRAS
                        ' MACROINVERTEBRADOS

                        ' CONEXION A LA TABLA DE TAXONES
                        Dim Macroinvcon As New OleDb.OleDbConnection
                        Dim Macroinvds As New DataSet
                        Dim MacroinvSQL As String
                        Macroinvcon.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & pathapp & "\taxonesmuestras.mdb"
                        Macroinvcon.Open()
                        MacroinvSQL = "SELECT * FROM macroinvs WHERE IdMuestra = '" & idmuestraborrar & "'"
                        Dim Macroinvda = New OleDb.OleDbDataAdapter(MacroinvSQL, Macroinvcon)
                        Macroinvda.Fill(Macroinvds, "TablaMacroInv")

                        If Macroinvds.Tables("TablaMacroInv").Rows.Count <> 0 Then
                            Macroinvds.Tables("TablaMacroInv").Rows(0).Delete()
                            Dim cb As New OleDb.OleDbCommandBuilder(Macroinvda)
                            Macroinvda.Update(Macroinvds, "TablaMacroInv")
                        End If
                        Macroinvcon.Close()



                    Next i
                    For i = 0 To MuestrasDataGridView.RowCount - 1
                        ' TABLA DE MUESTRAS
                        MuestrasTableAdapter.qryMuestrasByMuestra(frmAPampeano.Scilla10DataSet.Muestras, idmuestraborrar)
                        If MuestrasBindingSource.Count <> 0 Then
                            MuestrasBindingSource.RemoveCurrent()
                            MuestrasTableAdapter.Update(frmAPampeano.Scilla10DataSet.Muestras)
                        End If
                    Next

                    'BORRA EL PROYECTO DE LA TABLA PROYECTOS
                    ProyectosBindingSource.RemoveCurrent()
                    ProyectosTableAdapter.Update(Scilla10DataSet.Proyectos)
                End If
            Else
                MsgBox("El proyecto no tiene muestras")
            End If
        Else
            MsgBox("No hay proyectos cargados")
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   ABRIR PROYECTO
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub btnAbrirProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirProyecto.Click
        'Me.Opacity = 0
        Dim objPlsWait As New clsWorkingDialog
        objPlsWait.ShowWaitScreen("Emprolijando el proyecto!")

        'busca tipo de proyecto y abre el frm correspondiente
        If tipoproyecto = "ArroyoPamp" Then
            Dim idproyecto As Integer = Convert.ToInt32(IdProyectoTextBox.Text)
            Dim nombreproyecto As String = NombreTextBox.Text
            frmAPampeano.RecibirVariables(idproyecto, tipoproyecto, nombreproyecto, 0)
            frmAPampeano.Show()

            'CIERRO EL CARTEL DE ESPERE
            objPlsWait.CloseWaitScreen()
            objPlsWait = Nothing
            'Me.Close()
        End If

    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////                   
    '////                   EDITAR PROYECTO
    '////                   
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub btnEditarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarProyecto.Click

        ' ESCONDE BOTONES INNECESARIOS Y MUESTRA NECESARIOS
        btnNuevoProyecto.Visible = False
        btnAbrirProyecto.Visible = False
        btnGuardarProyecto.Visible = True
        btnEditarProyecto.Visible = False
        btnBorrarProyecto.Visible = False
        NombreTextBox.Enabled = True
        AutorTextBox.Enabled = True
        DescripcionTextBox.Enabled = True

    End Sub

End Class