Public Class frPeriodeLaporan

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frAnak As New frLaporan
        frAnak.Label2.Text = Format(DateTimePicker1.Value.Date, "d MMM yyyy")
        frAnak.Label4.Text = Format(DateTimePicker2.Value.Date, "d MMM yyyy")
        frAnak.Show()
    End Sub
End Class