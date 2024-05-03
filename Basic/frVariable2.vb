Public Class frVariable2

    Private tulisan As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tulisan = "Febri"
        Label1.Text = tulisan

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tulisan = "teguh"
        Label1.Text = tulisan
    End Sub
End Class