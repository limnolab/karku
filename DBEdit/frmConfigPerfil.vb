Public Class frmConfigPerfil
    Dim pathapp As String = My.Application.Info.DirectoryPath
    Dim newimagefullpath As String
    Dim newimagefilename As String

    Private Sub frmPerfil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AdminTableAdapter.Fill(Me.ConfigDataSet.Admin)
        Me.ConfigTableAdapter.Fill(Me.ConfigDataSet.Config)


        'los logos van en la carpeta images\logo
        Dim logoname As String = ConfigDataSet.Tables("Config").Rows(0).Item("logotipo").ToString
        Dim pathlogo As String = pathapp & "\images\logo\" & logoname
        If logoname <> "" Then
            PictureBox1.BackgroundImage = Image.FromFile(pathlogo)
            PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'COPIA EL NUEVO ARCHIVO DE IMAGEN A LA CARPETA DEL KARKU
        Dim FileToCopy As String
        Dim NewCopy As String

        FileToCopy = newimagefullpath
        NewCopy = pathapp & "\images\logo\" & newimagefilename

        If System.IO.File.Exists(FileToCopy) = True Then
            System.IO.File.Copy(FileToCopy, NewCopy, True)
        End If

        UsuarioTextBox.Enabled = False
        PassTextBox.Enabled = False
        EmpresaTextBox.Enabled = False
        Me.AdminBindingSource.EndEdit()
        Me.AdminTableAdapter.Update(Me.ConfigDataSet.Admin)
        Me.ConfigBindingSource.EndEdit()
        Me.ConfigTableAdapter.Update(Me.ConfigDataSet.Config)
    End Sub

    Private Sub frmPerfil_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.ConfigTableAdapter.qryConfigById(frmMain.ConfigDataSet.Config, 1)
    End Sub

    Private Sub btnCambiarLogo_Click(sender As Object, e As EventArgs) Handles btnCambiarLogo.Click
        EmpresaTextBox.Enabled = True
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            If (OpenFileDialog.FileName IsNot Nothing) Or (OpenFileDialog.FileName <> String.Empty) Then
                newimagefullpath = OpenFileDialog.FileName
                newimagefilename = OpenFileDialog.SafeFileName
                PictureBox1.BackgroundImage = Image.FromFile(newimagefullpath)
                PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
                ConfigDataSet.Tables("Config").Rows(0).Item("logotipo") = newimagefilename
            End If
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnCambiarUser_Click(sender As Object, e As EventArgs) Handles btnCambiarUser.Click
        UsuarioTextBox.Enabled = True
        PassTextBox.Enabled = True
    End Sub
End Class
