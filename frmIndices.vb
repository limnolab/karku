Public Class frmIndices

    Dim idmuestra = Convert.ToInt32(frmMuestrasRLP.IdMuestraTextBox.Text)
    Dim idproyecto = Convert.ToInt32(frmMuestrasRLP.IdProyectoTextBox.Text)

    Private Sub frmIndices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MuestrasTableAdapter.Fill(Me.Scilla10DataSet.Muestras)
        'CARGA MUESTRA
        Me.MuestrasTableAdapter.qryMuestrasByMuestra(Me.Scilla10DataSet.Muestras, idmuestra)
        Me.MuestrasDataGridView.Refresh()

        CargaIDP()
        CargaIMRP()
        CargaEutrofizacion()
        If frmMuestrasRLP.IEcoPlataSignifica.Text <> "No se calculará" Then
            CargaIECOPlata()
        End If
        Cierroventana()

    End Sub

    Private Sub CargaIECOPlata()
        ' CARGA EL RECORD DE LA BASE DE DATOS IECOPLATA
        IMRPlataTableAdapter.qryIMRPlataByMuestras(Scilla10DataSet.IMRPlata, idmuestra)
        IMRPlataDataGridView.Refresh()

        ' SE FIJA QUE HAYA YA HECHO UN RECORD, SINO LO CREA
        If IMRPlataDataGridView.RowCount = 1 Then
            IMRPlataBindingSource.AddNew()
            IdMuestraTextBox.Text = idmuestra
            IdProyectoTextBox.Text = frmMuestrasRLP.IdProyectoTextBox.Text
            CalculoIECOPlata()
            'UPDATE THE DATABASE
            IMRPlataBindingSource.EndEdit()
            IMRPlataTableAdapter.Update(Scilla10DataSet.IMRPlata)
        Else
            'MsgBox("Calculando IECOplata!")
            CalculoIECOPlata()
        End If
    End Sub
    Private Sub CalculoIECOPlata()
        'Chequeo que el usuario haya puesto valores en frmMuestrasRLP
        'OJO! cambie "VAL" por "Convert.ToInt32" a ver si toma los decimales! y parece funcionar!
        Dim no3 As Double = Val(frmMuestrasRLP.FQNitratosTextBox.Text)
        Dim no2 As Double = Val(frmMuestrasRLP.FQNitritosTextBox.Text)
        Dim nh4 As Double = Val(frmMuestrasRLP.FQAmonioTextBox.Text)
        Dim din As Double
        Dim habfisico As Double = Val(frmMuestrasRLP.ConectividadComboBox.Text)
        Dim vegripariana As Double = Val(frmMuestrasRLP.NaturalidadComboBox.Text)
        Dim od As Double = Val(frmMuestrasRLP.FQODTextBox.Text)
        Dim po4 As Double = Val(frmMuestrasRLP.FQFosfatoTextBox.Text)
        Dim bod As Double = Val(frmMuestrasRLP.FQBODTextBox.Text)
        Dim cla As Double = Val(frmMuestrasRLP.ClorofilaATextBox.Text)
        Dim cyano As Double = Val(frmMuestrasRLP.CianoDensidadTextBox.Text)
        Dim dmt As Double = Val(frmMuestrasRLP.DiatoDensidadTextBox.Text)
        Dim imrpvalor As Double = Val(ValorTextBox1.Text)
        din = no3 + no2 + nh4
        Dim iecoplatavalor As Double
        Dim iecoplatavalorredondeado As String

        iecoplatavalor = (((habfisico + vegripariana) / 3) + ((od + din + po4 + bod) / 4) + ((cla + cyano + dmt + imrpvalor) / 4)) / 3
        'MsgBox(iecoplatavalor)
        iecoplatavalorredondeado = Math.Round(iecoplatavalor, 2)
        Dim value2 As String = iecoplatavalorredondeado.Replace(",", ".")
        IndiceTextBox.Text = value2.ToString
        IMRPlataBindingSource.EndEdit()
        IMRPlataTableAdapter.Update(Scilla10DataSet.IMRPlata)
    End Sub
    Private Sub CargaIDP()
        ' CARGA EL RECORD DE LA BASE DE DATOS IDP
        IDPTableAdapter.qryIDPByMuestra(Scilla10DataSet.IDP, idmuestra)
        IDPDataGridView.Refresh()

        ' SE FIJA QUE HAYA YA HECHO UN RECORD, SINO LO CREA
        If IDPDataGridView.RowCount = 1 Then
            IDPBindingSource.AddNew()
            IdMuestraTextBox1.Text = idmuestra
            IdProyectoTextBox1.Text = frmMuestrasRLP.IdProyectoTextBox.Text
            'ESTA LINEA ES BORRABLE
            ValorTextBox.Text = ""
            'CalculoIDP()
            'UPDATE THE DATABASE
            IDPBindingSource.EndEdit()
            IDPTableAdapter.Update(Scilla10DataSet.IDP)
        Else
            'MsgBox("Calculando IDP!")
            CalculoIDP()
        End If
    End Sub
    Private Sub CalculoIDP()
        ''ACA DEBERIA LLEVARME A OTRO FORM A CALCULAR EL IDP
    End Sub
    Private Sub CargaIMRP()
        ' CARGA EL RECORD DE LA BASE DE DATOS IMRP
        IMRPTableAdapter.qryIMRPByMuestra(Scilla10DataSet.IMRP, idmuestra)
        IMRPDataGridView.Refresh()

        ' SE FIJA QUE HAYA YA HECHO UN RECORD, SINO LO CREA
        If IMRPDataGridView.RowCount = 1 Then
            IMRPBindingSource.AddNew()
            IdMuestraTextBox2.Text = idmuestra
            IdProyectoTextBox2.Text = frmMuestrasRLP.IdProyectoTextBox.Text
            'ESTA LINEA ES BORRABLE
            ValorTextBox1.Text = ""
            'CalculoIMRP()
            'UPDATE THE DATABASE
            IMRPBindingSource.EndEdit()
            IMRPTableAdapter.Update(Scilla10DataSet.IMRP)
        Else
            'MsgBox("Calculando IMRP!")
            CalculoIMRP()
        End If
    End Sub
    Private Sub CalculoIMRP()
        'ACA DEBERIA LLEVARME A OTRO FORM A CALCULAR EL IMRP

    End Sub
    Private Sub CargaEutrofizacion()
        ' CARGA EL RECORD DE LA BASE DE DATOS IDP
        EutrofizacionTableAdapter.qryEutrofizacionByMuestra(Scilla10DataSet.Eutrofizacion, idmuestra)
        EutrofizacionDataGridView.Refresh()

        ' SE FIJA QUE HAYA YA HECHO UN RECORD, SINO LO CREA
        If EutrofizacionDataGridView.RowCount = 1 Then
            EutrofizacionBindingSource.AddNew()
            IdMuestraTextBox3.Text = idmuestra
            IdProyectoTextBox3.Text = frmMuestrasRLP.IdProyectoTextBox.Text
            CalculoEutrofizacion()
            'UPDATE THE DATABASE
            EutrofizacionBindingSource.EndEdit()
            EutrofizacionTableAdapter.Update(Scilla10DataSet.Eutrofizacion)
        Else
            'MsgBox("Calculando Eutrofizacion!")
            CalculoEutrofizacion()
        End If
    End Sub
    Private Sub CalculoEutrofizacion()
        Dim valorclorofila As String
        Dim valorclorofila1 As Double
        valorclorofila = frmMuestrasRLP.ClorofilaATextBox.Text
        valorclorofila1 = Val(frmMuestrasRLP.ClorofilaATextBox.Text)

        If valorclorofila = "" Then
            MsgBox("No se calculará Eutrofización porque falta clorofila")
        Else
            If valorclorofila <= 1 Then
                ValorTextBox2.Text = "1"
            Else
                If valorclorofila > 1 Then
                    ValorTextBox2.Text = "2"
                    If valorclorofila >= 2.5 Then
                        ValorTextBox2.Text = "3"
                        If valorclorofila > 7.9 Then
                            ValorTextBox2.Text = "4"
                            If valorclorofila >= 25 Then
                                ValorTextBox2.Text = "5"
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Cierroventana()
        ' GRABO IMRPlata
        Me.Validate()
        Me.IMRPlataBindingSource.EndEdit()
        IMRPlataTableAdapter.Update(Scilla10DataSet.IMRPlata)

        ' GRABO IDP
        Me.Validate()
        Me.IDPBindingSource.EndEdit()
        IDPTableAdapter.Update(Scilla10DataSet.IDP)

        ' GRABO IMRP
        Me.Validate()
        Me.IMRPBindingSource.EndEdit()
        IMRPTableAdapter.Update(Scilla10DataSet.IMRP)

        ' GRABO Eutrofizacion
        Me.Validate()
        Me.EutrofizacionBindingSource.EndEdit()
        EutrofizacionTableAdapter.Update(Scilla10DataSet.Eutrofizacion)

        ' Copio los valores obtenidos a la tabla Muestras para el reporte
        Dim valoridp As String
        Dim valorimrp As String
        Dim valoreutrofizacion As String
        Dim valorimrplata As String
        valoridp = ValorTextBox.Text
        valorimrp = ValorTextBox1.Text
        valoreutrofizacion = ValorTextBox2.Text
        valorimrplata = IndiceTextBox.Text

        MuestrasDataGridView.Item(0, "IDP") = valoridp
        MuestrasDataGridView.Item(0, "IMRP") = valorimrp
        MuestrasDataGridView.Item(0, "Eutrofizacion") = valoreutrofizacion
        MuestrasDataGridView.Item(0, "IMRplata") = valorimrplata

        'GRABO Muestras
        Me.MuestrasBindingSource.EndEdit()
        Me.MuestrasTableAdapter.Update(Scilla10DataSet.Muestras)

        'Recarga los adaptadores en frmMuestrasRLP
        frmMuestrasRLP.IMRPlataTableAdapter.Fill(frmMuestrasRLP.Scilla10DataSet.IMRPlata)
        frmMuestrasRLP.IDPTableAdapter.Fill(frmMuestrasRLP.Scilla10DataSet.IDP)
        frmMuestrasRLP.IMRPTableAdapter.Fill(frmMuestrasRLP.Scilla10DataSet.IMRP)
        frmMuestrasRLP.EutrofizacionTableAdapter.Fill(frmMuestrasRLP.Scilla10DataSet.Eutrofizacion)
        'Recargo las muestras de todo el proyecto y muevo el binding source a la muestra en la que estaba
        frmMuestrasRLP.MuestrasTableAdapter.qryMuestrasByProyecto(frmMuestrasRLP.Scilla10DataSet.Muestras, idproyecto)
        frmMuestrasRLP.MuestrasBindingSource.Position = frmMuestrasRLP.MuestrasBindingSource.Find("IdMuestra", idmuestra)
        'Cierro
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cierroventana()
    End Sub

End Class