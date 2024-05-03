Public Class frVariable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Angka As Integer
        Angka = Val(TextBox1.Text)
        Label1.Text = Angka

    End Sub
End Class