Public Class frPegawai
    Private Sub frPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DsPegawai1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        OleDbConnection1.Open()
        sql = "INSERT INTO PEGAWAI VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', " & DateValue(DateTimePicker1.Value) & ", '" & ComboBox1.SelectedItem & "', " & " '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
        OleDbDataAdapter1.InsertCommand.CommandText = sql
        OleDbDataAdapter1.InsertCommand.ExecuteNonQuery()
        OleDbConnection1.Close()
        MessageBox.Show("Data berhasil dimasukkan", "Konffirmasi berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim sql As String
            sql = "SELECT NIP, NAMA_PGW AS nama_Pegawai, TGL_LAHIR_PGW AS Tanggal_Lahir, JK_PGW AS Jenis_Kelamin, ALAMAT_PGW AS Alamat, TELP_PGW AS Telepon FROM PEGAWAI"

            OleDbDataAdapter1.SelectCommand.CommandText = sql
            DsPegawai1.Clear()
            OleDbDataAdapter1.Fill(DsPegawai1, "PEGAWAI")
            DataGrid1.SetDataBinding(DsPegawai1, "PEGAWAI")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String

        sql = "SELECT NIP, NAMA_PGW AS nama_Pegawai, TGL_LAHIR_PGW AS Tanggal_Lahir, JK_PGW AS Jenis_Kelamin, ALAMAT_PGW AS Alamat, TELP_PGW AS Telepon FROM PEGAWAI WHERE NAMA_PGW LIKE '%" & TextBox5.Text & "%'"


        OleDbDataAdapter1.SelectCommand.CommandText = sql
        DsPegawai1.Clear()
        OleDbDataAdapter1.Fill(DsPegawai1, "PEGAWAI")
        DataGrid1.SetDataBinding(DsPegawai1, "PEGAWAI")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OleDbDataAdapter1.Update(DsPegawai1)
        MessageBox.Show("Data Berhasil Diubah", "Konfirmasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql As String
        Dim selectedCell As System.Windows.Forms.DataGridCell
        Dim selectedItem As Object
        Dim result As System.Windows.Forms.DialogResult

        selectedCell = DataGrid1.CurrentCell
        selectedItem = DataGrid1.Item(selectedCell.RowNumber, selectedCell.ColumnNumber)

        result = MessageBox.Show("Yakin Pegawai Dengan NIP" & selectedItem & "Akan Dihapus?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If result = System.Windows.Forms.DialogResult.OK Then
            OleDbConnection1.Open()
            sql = "DELETE FROM PEGAWAI WHERE NIP = '" & selectedItem & "'"
            OleDbDataAdapter1.DeleteCommand.CommandText = sql
            OleDbDataAdapter1.DeleteCommand.ExecuteNonQuery()

            Call Button2_Click(sender, e)
            OleDbConnection1.Close()
        End If

    End Sub
End Class