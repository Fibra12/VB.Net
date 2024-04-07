Public Class frUtama
    Private Sub frUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub
End Class