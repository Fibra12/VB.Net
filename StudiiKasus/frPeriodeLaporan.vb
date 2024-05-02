Public Class frPeriodeLaporan

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frRpt As New frRpPenjualan
        Dim par_tgl_awal As Date ' variable parameter
        Dim par_tgl_akhir As Date ' variable parameter

        par_tgl_awal = DateTimePicker1.Value.Date
        par_tgl_akhir = DateTimePicker2.Value.Date ' seharusnya ini DateTimePicker2, bukan DateTimePicker1

        frRpt.CrystalReportViewer1.SelectionFormula =
            "{TRANSAKSI.TGL_TRANSAKSI} >= DateTime(" &
            par_tgl_awal.Year & "," &
            par_tgl_awal.Month & "," &
            par_tgl_awal.Day & ", 0, 0, 0) AND " &
            "{TRANSAKSI.TGL_TRANSAKSI} <= DateTime(" &
            par_tgl_akhir.Year & "," &
            par_tgl_akhir.Month & "," &
            par_tgl_akhir.Day & ", 0, 0, 0)"

        ' Format tanggal Crystal Report = DateTime(YYYY, MM, DD, 0, 0, 0)
        ' Perhatikan bahwa parameter DateTime di atas harus berupa nilai numerik.

        frRpt.Label2.Text = par_tgl_awal.ToString("d/MM/yyyy")
        frRpt.Label4.Text = par_tgl_akhir.ToString("d/MM/yyyy")

        frRpt.Show()
    End Sub
End Class
