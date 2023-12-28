Public Class FrmKaryawan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim TblKaryawan As DataTable

    Sub Data_Record()
        TblKaryawan = Proses.ExecuteQuery("Select * From TblKaryawan order by id_karyawan asc")
        DgDataKaryawan.DataSource = TblKaryawan
        DgDataKaryawan.Columns(1).Width = 150
        DgDataKaryawan.Columns(2).Width = 435
    End Sub

    Sub Departemen()
        TblKaryawan = Proses.ExecuteQuery("Select * From TblDepartemen order by id_departemen asc")
        If TblKaryawan.Rows.Count = 0 Then
        Else
            CbDepartemen.Items.Clear()
            With TblKaryawan.Columns(1)
                For a = 0 To TblKaryawan.Rows.Count - 1
                    CbDepartemen.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Kode_Otomatis()
        TblKaryawan = Proses.ExecuteQuery("Select * From TblKaryawan order by id_karyawan desc")
        If TblKaryawan.Rows.Count = 0 Then
            TxtIdKaryawan.Text = "IK-001"
        Else
            With TblKaryawan.Rows(0)
                TxtIdKaryawan.Text = .Item("id_karyawan")
                TxtIdKaryawan.Focus()
            End With
            TxtIdKaryawan.Text = Val(Microsoft.VisualBasic.Mid(TxtIdKaryawan.Text, 4, 3)) + 1
            If Len(TxtIdKaryawan.Text) = 1 Then
                TxtIdKaryawan.Text = "IK-00" & TxtIdKaryawan.Text & ""
            ElseIf Len(TxtIdKaryawan.Text) = 2 Then
                TxtIdKaryawan.Text = "IK-0" & TxtIdKaryawan.Text & ""
            ElseIf Len(TxtIdKaryawan.Text) = 3 Then
                TxtIdKaryawan.Text = "IK-" & TxtIdKaryawan.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        TxtIdKaryawan.Enabled = False
        TxtNamaKaryawan.Text = ""
        TxtAlamat.Text = ""
        TxtNoHandphone.Text = ""
        CbDepartemen.Text = ""
        DtTanggalLahir.Text = ""
        TxtNamaKaryawan.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
        Call Departemen()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
    End Sub

    Private Sub FrmKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtNamaKaryawan.Text = "" Then
            TxtNamaKaryawan.Focus()
            Exit Sub
        End If
        If TxtAlamat.Text = "" Then
            TxtAlamat.Focus()
            Exit Sub
        End If
        If TxtNoHandphone.Text = "" Then
            TxtNoHandphone.Focus()
            Exit Sub
        End If
        If DtTanggalLahir.Text = "" Then
            DtTanggalLahir.Focus()
            Exit Sub
        End If
        If CbDepartemen.Text = "" Then
            CbDepartemen.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblKaryawan values ('" & TxtIdKaryawan.Text & "','" & TxtNamaKaryawan.Text & "','" & TxtAlamat.Text & "','" & Val(CbDepartemen.Text) & "','" & DtTanggalLahir.Text & "','" &
TxtNoHandphone.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If TxtNamaKaryawan.Text = "" Then
            TxtNamaKaryawan.Focus()
            Exit Sub
        End If
        If TxtAlamat.Text = "" Then
            TxtAlamat.Focus()
            Exit Sub
        End If
        If TxtNoHandphone.Text = "" Then
            TxtNoHandphone.Focus()
            Exit Sub
        End If
        If DtTanggalLahir.Text = "" Then
            DtTanggalLahir.Focus()
            Exit Sub
        End If
        If CbDepartemen.Text = "" Then
            CbDepartemen.Focus()
            Exit Sub
        End If

        SQL = "Update TblKaryawan set Nama = '" & TxtNamaKaryawan.Text & "',Alamat = '" & TxtAlamat.Text & "',Departemen = '" & Val(CbDepartemen.Text) & "',Tanggal_lahir ='" & DtTanggalLahir.Text & "',No_Handphone = '" & TxtNoHandphone.Text & "' Where Id_Karyawan = '" & TxtIdKaryawan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Berhasil dirubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub



    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        SQL = "Delete From TblKaryawan Where Id_Karyawan = '" & TxtIdKaryawan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Bersih()
        TxtIdKaryawan.Focus()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub DgDataKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgDataKaryawan.CellClick
        Dim i As Integer
        With DgDataKaryawan
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                TxtIdKaryawan.Text = .Rows(i).Cells("Id_Karyawan").Value.ToString
                TxtNamaKaryawan.Text = .Rows(i).Cells("Nama").Value.ToString
                TxtAlamat.Text = .Rows(i).Cells("Alamat").Value.ToString
                CbDepartemen.Text = .Rows(i).Cells("Departemen").Value.ToString
                DtTanggalLahir.Text = .Rows(i).Cells("Tanggal_Lahir").Value.ToString
                TxtNoHandphone.Text = .Rows(i).Cells("No_Handphone").Value.ToString
                BtnUbah.Enabled = True
                BtnHapus.Enabled = True
                BtnSimpan.Enabled = False
            End If
        End With
    End Sub
End Class
