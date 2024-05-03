Public Class frLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frAnak As New frUtama
        If (TextBox1.Text = "Feb") And (TextBox2.Text = "123") Then
            MessageBox.Show("Selamat " & TextBox1.Text & "! Anda Berhasil Masuk", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frAnak.Show()
        End If
    End Sub
End Class