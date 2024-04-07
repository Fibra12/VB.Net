Public Class frRadioButton
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then
            Label3.Text = RadioButton1.Text
        ElseIf (RadioButton2.Checked = True) Then
            Label3.Text = RadioButton2.Text
        ElseIf (RadioButton3.Checked = True) Then
            Label3.Text = RadioButton3.Text
        Else
            Label3.Text = RadioButton4.Text
        End If
    End Sub
End Class