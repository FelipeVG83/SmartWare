Public Class Configuracoes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sfd As New SaveFileDialog
        sfd.ShowDialog()
        Dim qualquer As New System.IO.StreamWriter(sfd.FileName)

    End Sub
End Class