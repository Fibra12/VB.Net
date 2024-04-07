Public Class frComboBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedItem = "Tambah") Then
            TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        ElseIf (ComboBox1.SelectedItem = "Kurang") Then
            TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        ElseIf (ComboBox1.SelectedItem = "Kali") Then
            TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        ElseIf (ComboBox1.SelectedItem = "Bagi") Then
            TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        Else
            TextBox3.Text = "masukkan operasi yang benar"
        End If
    End Sub
End Class