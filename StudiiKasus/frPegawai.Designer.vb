<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frPegawai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frPegawai))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DsPegawai1 = New StudiiKasus.dsPegawai()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPegawai1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 373)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(742, 344)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Input Data Pegawai"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Masukkan Data Pegawai"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGrid1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(742, 344)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cari, Ubah, Hapus Data Pegawai"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = "PEGAWAI"
        Me.DataGrid1.DataSource = Me.DsPegawai1
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(18, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(702, 313)
        Me.DataGrid1.TabIndex = 0
        '
        'DsPegawai1
        '
        Me.DsPegawai1.DataSetName = "dsPegawai"
        Me.DsPegawai1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLI10;Data Source=FIBRA\SQLEXPRESSSERVER;Integrated Security=SSPI;In" &
    "itial Catalog=inventori_temp"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT NIP, NAMA_PGW AS [nama Pegawai], TGL_LAHIR_PGW AS [Tanggal Lahir], JK_PGW " &
    "AS [Jenis Kelamin], ALAMAT_PGW AS Alamat, TELP_PGW AS Telepon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     dbo.PEGA" &
    "WAI"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""inventori_temp"".""dbo"".""PEGAWAI"" (""NIP"", ""NAMA_PGW"", ""TGL_LAHIR_PGW""," &
    " ""JK_PGW"", ""ALAMAT_PGW"", ""TELP_PGW"") VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NIP", System.Data.OleDb.OleDbType.VarChar, 0, "NIP"), New System.Data.OleDb.OleDbParameter("nama_Pegawai", System.Data.OleDb.OleDbType.VarChar, 0, "nama Pegawai"), New System.Data.OleDb.OleDbParameter("Tanggal_Lahir", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "Tanggal Lahir"), New System.Data.OleDb.OleDbParameter("Jenis_Kelamin", System.Data.OleDb.OleDbType.[Char], 0, "Jenis Kelamin"), New System.Data.OleDb.OleDbParameter("Alamat", System.Data.OleDb.OleDbType.VarChar, 0, "Alamat"), New System.Data.OleDb.OleDbParameter("Telepon", System.Data.OleDb.OleDbType.VarChar, 0, "Telepon")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NIP", System.Data.OleDb.OleDbType.VarChar, 0, "NIP"), New System.Data.OleDb.OleDbParameter("nama_Pegawai", System.Data.OleDb.OleDbType.VarChar, 0, "nama Pegawai"), New System.Data.OleDb.OleDbParameter("Tanggal_Lahir", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "Tanggal Lahir"), New System.Data.OleDb.OleDbParameter("Jenis_Kelamin", System.Data.OleDb.OleDbType.[Char], 0, "Jenis Kelamin"), New System.Data.OleDb.OleDbParameter("Alamat", System.Data.OleDb.OleDbType.VarChar, 0, "Alamat"), New System.Data.OleDb.OleDbParameter("Telepon", System.Data.OleDb.OleDbType.VarChar, 0, "Telepon"), New System.Data.OleDb.OleDbParameter("Original_NIP", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NIP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_nama_Pegawai", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nama Pegawai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Tanggal_Lahir", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tanggal Lahir", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Jenis_Kelamin", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Jenis Kelamin", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Alamat", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Alamat", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Telepon", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telepon", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ""inventori_temp"".""dbo"".""PEGAWAI"" WHERE ((""NIP"" = ?) AND (""NAMA_PGW"" =" &
    " ?) AND (""TGL_LAHIR_PGW"" = ?) AND (""JK_PGW"" = ?) AND (""ALAMAT_PGW"" = ?) AND (""TE" &
    "LP_PGW"" = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_NIP", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NIP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_nama_Pegawai", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nama Pegawai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Tanggal_Lahir", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tanggal Lahir", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Jenis_Kelamin", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Jenis Kelamin", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Alamat", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Alamat", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Telepon", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telepon", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PEGAWAI", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NIP", "NIP"), New System.Data.Common.DataColumnMapping("nama Pegawai", "nama Pegawai"), New System.Data.Common.DataColumnMapping("Tanggal Lahir", "Tanggal Lahir"), New System.Data.Common.DataColumnMapping("Jenis Kelamin", "Jenis Kelamin"), New System.Data.Common.DataColumnMapping("Alamat", "Alamat"), New System.Data.Common.DataColumnMapping("Telepon", "Telepon")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'frPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frPegawai"
        Me.Text = "Data Pegawai"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPegawai1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGrid1 As DataGrid
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents DsPegawai1 As dsPegawai
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
End Class
