Public Class frHari
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Pesan As String
        Pesan = TextBox1.Text

        ' Deklarasi variabel hari-hari
        Dim Senin As String = "Senin"
        Dim Selasa As String = "Selasa"
        Dim Rabu As String = "Rabu"
        Dim Kamis As String = "Kamis"
        Dim Jumat As String = "Jumat"
        Dim Sabtu As String = "Sabtu"
        Dim Minggu As String = "Minggu"

        ' Pengecekan pesan dengan Select Case
        Select Case Pesan
            Case Sabtu, Minggu
                Label2.Text = "Hore akhirnya weekend"
            Case Senin, Selasa, Rabu
                Label2.Text = "Ayo semangat!"
            Case Kamis, Jumat
                Label2.Text = "Weekend ngapain ya?"
            Case Else
                Label2.Text = "Hari tidak valid"
        End Select

        MsgBox(Label2.Text)
    End Sub
End Class
