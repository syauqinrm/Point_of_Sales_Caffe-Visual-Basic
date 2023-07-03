Imports MySql.Data.MySqlClient
Public Class Inventory
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Delete"
        Call koneksi()
        da = New MySqlDataAdapter("Select * From tb_barang", conn)
        ds = New DataSet
        da.Fill(ds, "tb_barang")
        DataGridView1.DataSource = ds.Tables("tb_barang")
        DataGridView1.ReadOnly = True

    End Sub
    Sub siapisi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        ComboBox1.Enabled = True

    End Sub
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Save"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Cancel"
            Call siapisi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Isi Semua Kolom")
            Else
                Call koneksi()
                Dim InputData As String = "insert into tb_barang values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "')"
                cmd = New MySqlCommand(InputData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Cancel"
            Call siapisi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = " " Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Isi semua kolom")
            Else
                Call koneksi()
                Dim UpdateData As String = "Update tb_barang set id_barang='" & TextBox2.Text & "', harga_barang= '" & TextBox3.Text & "', jumlah_barang='" & TextBox4.Text & "', unit_barang='" & ComboBox1.Text & "' where id_barang='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(UpdateData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Delete" Then
            Button3.Text = "Delete"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Cancel"
            Call siapisi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Isi Semua Kolom")
            Else
                Call koneksi()
                Dim HapusData As String = "Delete from tb_barang where id_barang='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(HapusData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Close" Then
            Me.Close()
        Else
            Call kondisiawal()
        End If
    End Sub
End Class