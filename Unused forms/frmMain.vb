Public Class frmMain
    Dim pathfisico As String = My.Application.Info.DirectoryPath & "\htmls\"
    Dim destino As Form
    Dim destinostring As String

    Private Sub C1Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEnciclopedia.Show()
    End Sub

    Private Sub btnRLP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRLP.Click
        webDescripcion.Navigate(pathfisico & "descripcion-estuarioRLP.html")
        destino = frmRLP
        btnComenzarProyecto.Visible = True
        btnComenzarProyecto.Text = "Comenzar proyecto: Estuario"
    End Sub

    Private Sub btnarroyopamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarroyopamp.Click
        webDescripcion.Navigate(pathfisico & "descripcion-arroyopamp.html")
        destinostring = "frmAPampeano"
        btnComenzarProyecto.Visible = True
        btnComenzarProyecto.Text = "Comenzar proyecto: Arroyo Pampeano"
    End Sub

    Private Sub btnComenzarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComenzarProyecto.Click
        If destinostring = "frmAPampeano" Then

            'Manda a decir que muestra es 
            Dim tipoproyecto As String = "ArroyoPamp"
            frmProyectos.RecibirVariables(tipoproyecto)
            frmProyectos.Show()
        End If

        Me.Close()
    End Sub

    Private Sub btnarroyomont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarroyomont.Click
        'webDescripcion.Navigate(pathfisico & "descripcion-arroyomont.html")
        'destino = frmArroyoMont
        'btnComenzarProyecto.Visible = True
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLenitico.Click
        'webDescripcion.Navigate(pathfisico & "descripcion-lenitico.html")
        'destino = frmLenitico
        'btnComenzarProyecto.Visible = True
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConfigDataSet.Config' table. You can move, or remove it, as needed.
        ConfigTableAdapter.qryConfigById(Me.ConfigDataSet.Config, 1)
        Dim logopath As String = LogotipoTextBox.Text
        PictureBox1.ImageLocation = logopath

    End Sub

    Private Sub btnComenzarIndice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        destino.Show()
    End Sub

    Private Sub btnEnciclopedia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEnciclopedia.Show()
    End Sub

    Private Sub SalirAWindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirAWindowsToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EnciclopediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnciclopediaToolStripMenuItem.Click
        frmEnciclopedia.Show()
    End Sub

    Private Sub PerfilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerfilToolStripMenuItem.Click
        frmConfigPerfil.ShowDialog()
    End Sub

    Private Sub MacroinvertebradosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MacroinvertebradosToolStripMenuItem.Click
        Dim objPlsWait As New clsWorkingDialog
        objPlsWait.ShowWaitScreen("Accediendo a la base de datos!")

        frmDBMacroInvertebrados.Show()
        frmDBMacroInvertebrados.Opacity = 0

        'CIERRO EL CARTEL DE ESPERE
        objPlsWait.CloseWaitScreen()
        objPlsWait = Nothing
        frmDBMacroInvertebrados.Opacity = 100
    End Sub

    Private Sub DiatomeasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiatomeasToolStripMenuItem.Click
        frmDBDiatomeas.Show()

    End Sub
End Class