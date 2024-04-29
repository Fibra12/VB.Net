Public Class frPegawai
    Private Sub frPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DsPegawai1)

    End Sub

End Class