Public Class frKonstanta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const PPN As Single = 0.1
        Dim harga As Single

        harga = TextBox1.Text
        TextBox2.Text = CInt(harga * PPN)
    End Sub
End Class