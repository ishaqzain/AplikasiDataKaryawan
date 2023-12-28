<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKaryawan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKaryawan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNoHandphone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.CbDepartemen = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdKaryawan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgDataKaryawan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgDataKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNoHandphone)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DtTanggalLahir)
        Me.GroupBox1.Controls.Add(Me.CbDepartemen)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtAlamat)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNamaKaryawan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtIdKaryawan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 411)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'TxtNoHandphone
        '
        Me.TxtNoHandphone.Location = New System.Drawing.Point(219, 343)
        Me.TxtNoHandphone.Name = "TxtNoHandphone"
        Me.TxtNoHandphone.Size = New System.Drawing.Size(257, 31)
        Me.TxtNoHandphone.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 25)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "No Handphone"
        '
        'DtTanggalLahir
        '
        Me.DtTanggalLahir.Location = New System.Drawing.Point(219, 296)
        Me.DtTanggalLahir.Name = "DtTanggalLahir"
        Me.DtTanggalLahir.Size = New System.Drawing.Size(257, 31)
        Me.DtTanggalLahir.TabIndex = 75
        '
        'CbDepartemen
        '
        Me.CbDepartemen.FormattingEnabled = True
        Me.CbDepartemen.Location = New System.Drawing.Point(219, 245)
        Me.CbDepartemen.Name = "CbDepartemen"
        Me.CbDepartemen.Size = New System.Drawing.Size(257, 33)
        Me.CbDepartemen.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 25)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Departemen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 25)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Tanggal Lahir"
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(219, 144)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(257, 79)
        Me.TxtAlamat.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Alamat"
        '
        'TxtNamaKaryawan
        '
        Me.TxtNamaKaryawan.Location = New System.Drawing.Point(219, 97)
        Me.TxtNamaKaryawan.Name = "TxtNamaKaryawan"
        Me.TxtNamaKaryawan.Size = New System.Drawing.Size(257, 31)
        Me.TxtNamaKaryawan.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 25)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Nama Karyawan"
        '
        'TxtIdKaryawan
        '
        Me.TxtIdKaryawan.Location = New System.Drawing.Point(219, 55)
        Me.TxtIdKaryawan.Name = "TxtIdKaryawan"
        Me.TxtIdKaryawan.Size = New System.Drawing.Size(200, 31)
        Me.TxtIdKaryawan.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 25)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Karyawan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnTutup)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnUbah)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(576, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(650, 168)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTutup.Location = New System.Drawing.Point(517, 37)
        Me.BtnTutup.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(112, 104)
        Me.BtnTutup.TabIndex = 65
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBatal.Location = New System.Drawing.Point(393, 37)
        Me.BtnBatal.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(112, 104)
        Me.BtnBatal.TabIndex = 64
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnHapus.Location = New System.Drawing.Point(269, 37)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 104)
        Me.BtnHapus.TabIndex = 63
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUbah.Location = New System.Drawing.Point(145, 37)
        Me.BtnUbah.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(112, 104)
        Me.BtnUbah.TabIndex = 62
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSimpan.Location = New System.Drawing.Point(21, 37)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(112, 104)
        Me.BtnSimpan.TabIndex = 61
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgDataKaryawan)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 598)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1443, 350)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DataKaryawan"
        '
        'DgDataKaryawan
        '
        Me.DgDataKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgDataKaryawan.Location = New System.Drawing.Point(19, 41)
        Me.DgDataKaryawan.Name = "DgDataKaryawan"
        Me.DgDataKaryawan.RowHeadersWidth = 82
        Me.DgDataKaryawan.RowTemplate.Height = 33
        Me.DgDataKaryawan.Size = New System.Drawing.Size(1401, 288)
        Me.DgDataKaryawan.TabIndex = 0
        '
        'FrmKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1580, 977)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmKaryawan"
        Me.Text = "Karyawan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgDataKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNoHandphone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DtTanggalLahir As DateTimePicker
    Friend WithEvents CbDepartemen As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNamaKaryawan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdKaryawan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgDataKaryawan As DataGridView
End Class
