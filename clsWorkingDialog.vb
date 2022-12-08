Public Class clsWorkingDialog
    Dim Thread1 As System.Threading.Thread

    Public Sub ShowWaitScreen(ByVal strMessage As String)
        Thread1 = New System.Threading.Thread(AddressOf MakeItHappen)
        Thread1.Name = strMessage
        Thread1.Start()
    End Sub


    Private Sub MakeItHappen(ByVal strMsg As String)
        Dim objPlsWait As New frmWorkingDialog
        Try
            objPlsWait.SetMessage(System.Threading.Thread.CurrentThread.Name)
            objPlsWait.ShowDialog()
        Catch ex As Exception
            ' Do nothing supress error.
        Finally
            If objPlsWait IsNot Nothing Then objPlsWait.Dispose() : objPlsWait = Nothing
        End Try
    End Sub

    Public Sub CloseWaitScreen()
        Thread1.Abort(Nothing) ' Cierra la form
    End Sub

End Class
