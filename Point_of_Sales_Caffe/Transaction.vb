Imports MySql.Data.MySqlClient
Public Class Transaction
    Sub KondisiAwal()
        LblTanggal.Text = Today
        LblItem.Text = 0
        LblTotal.Text = ""
        TxtBayar.Text = ""
        LblKembalian.Text = ""
        TxtNamaPembeli.Text = ""
        Call BuatKolom()
        Call IdOtomatis()
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("IdBarang", "Id Barang")
        DataGridView1.Columns.Add("NamaBarang", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("SubTotal", "SubTotal")
    End Sub
    Sub IdOtomatis()
        Call koneksi()
        cmd = New MySqlCommand("Select * from tbl_datapenjualan where idtransaksi in (select max(idtransaksi) from tbl_datapenjualan)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            UrutanKode = "A" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 9) + 1
            UrutanKode = "A" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LblIdJual.Text = UrutanKode
    End Sub

    Sub HitungItem()
        Dim Hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Hitung = Hitung + DataGridView1.Rows(i).Cells(3).Value
            LblItem.Text = Hitung
        Next
    End Sub

    Sub RumusSubTotal()
        Dim Hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Hitung = Hitung + DataGridView1.Rows(i).Cells(4).Value
            LblTotal.Text = Hitung
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = TimeOfDay
    End Sub

    Private Sub TxtIdBrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdBrg.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New MySqlCommand("select * from tb_barang where id_barang='" & TxtIdBrg.Text & "' ", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                TxtIdBrg.Text = dr.Item("id_barang")
                TxtIdBrg.Enabled = False
                LblNama.Text = dr.Item("nama_barang")
                LblHarga.Text = dr.Item("harga_barang")
            Else
                MsgBox("Barang Tidak Ada")
            End If
        End If
    End Sub

    Private Sub TxtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If TxtIdBrg.Text = "" Or LblNama.Text = "" And LblHarga.Text = "" Then
            MsgBox("Silahkan Masukkan Kode")
        Else
            Call koneksi()
            cmd = New MySqlCommand("select * from tb_barang where id_barang='" & TxtIdBrg.Text & "' ", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If TxtQty.Text = "" Then
                    MsgBox("Silahkan Masukan jumlah_barang dengan benar")

                ElseIf TxtQty.Text = 0 Then
                    MsgBox("Silahkan Masukan jumlah_barang dengan benar")

                ElseIf dr.Item("jumlah_barang") = 0 Then
                    MsgBox("Barang Kosong")

                Else
                    If TxtQty.Text <= dr.Item("jumlah_barang") Then
                        DataGridView1.Rows.Add(New String() {TxtIdBrg.Text, LblNama.Text, LblHarga.Text, TxtQty.Text, Val(LblHarga.Text) * Val(TxtQty.Text)})
                        Call RumusSubTotal()
                        TxtIdBrg.Enabled = True
                        TxtIdBrg.Text = ""
                        TxtQty.Text = ""
                        LblNama.Text = ""
                        LblHarga.Text = ""
                        Call HitungItem()
                    Else
                        MsgBox("Jumlah Barang Kurang")
                    End If
                End If
            Else
                MsgBox("Barang Tidak Ada")
            End If
        End If
    End Sub

    Private Sub TxtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            If Val(LblTotal.Text) <= Val(TxtBayar.Text) Then
                LblKembalian.Text = Val(TxtBayar.Text) - Val(LblTotal.Text)
            Else
                MsgBox("Pembayaran Kurang")
            End If
        End If
    End Sub

    Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles BtnBayar.Click
        If LblItem.Text = 0 Or LblKembalian.Text = "" Or TxtNamaPembeli.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silahkan Lakukan Transaksi Terlebih Dahulu")
        Else
            Call koneksi()
            Dim tanggalMySQL As String = Format(Today, "yyyy-MM-dd")
            Dim simpanjual As String = "insert into tbl_datapenjualan values('" & LblIdJual.Text & "', '" & tanggalMySQL & "', '" & TxtNamaPembeli.Text & "' , '" & LblTotal.Text & "', '" & TxtBayar.Text & "', '" & LblKembalian.Text & "')"
            cmd = New MySqlCommand(simpanjual, conn)
            cmd.ExecuteNonQuery()
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                koneksi()
                Dim simpandetail As String = "insert into tbl_dtlpenjualan values('" & LblIdJual.Text & "', '" & DataGridView1.Rows(i).Cells(0).Value & "', '" & DataGridView1.Rows(i).Cells(1).Value & "', '" & DataGridView1.Rows(i).Cells(3).Value & "', '" & DataGridView1.Rows(i).Cells(2).Value & "', '" & DataGridView1.Rows(i).Cells(4).Value & "')"
                cmd = New MySqlCommand(simpandetail, conn)
                cmd.ExecuteNonQuery()
                cmd = New MySqlCommand("select * from tb_barang where id_barang='" & DataGridView1.Rows(i).Cells(0).Value & "' ", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                koneksi()
                Dim kurangistok As String = "update tb_barang set jumlah_barang='" & dr.Item("jumlah_barang") - DataGridView1.Rows(i).Cells(3).Value & "' where id_barang='" & DataGridView1.Rows(i).Cells(0).Value & "'"
                cmd = New MySqlCommand(kurangistok, conn)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Barang Berhasil Dibayar")
            conn.Close()
            Call KondisiAwal()
        End If

    End Sub

    Private Sub BtnBatalPesan_Click(sender As Object, e As EventArgs) Handles BtnBatalPesan.Click
        Call KondisiAwal()
    End Sub

    Private Sub BtnBatalTambah_Click(sender As Object, e As EventArgs) Handles BtnBatalTambah.Click
        TxtIdBrg.Enabled = True
        TxtIdBrg.Text = ""
        LblNama.Text = ""
        LblHarga.Text = ""
        TxtQty.Text = ""
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.RemoveAt(row.Index)
        Next
    End Sub

    Private Sub LblTanggal_Click(sender As Object, e As EventArgs) Handles LblTanggal.Click

    End Sub
End Class