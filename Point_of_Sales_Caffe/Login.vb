Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Sub Terbuka()
        Main.LogInToolStripMenuItem.Enabled = False
        Main.LogOutToolStripMenuItem.Enabled = True
        Main.InventoryToolStripMenuItem.Enabled = True
        Main.TransToolStripMenuItem.Enabled = True
        Main.ReportToolStripMenuItem.Enabled = True
    End Sub
    Sub KondisiAwal()
        TextBox1.Text() = ""
        TextBox2.Text() = ""

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Masukkan Username dan Password")
        Else
            Call koneksi()
            cmd = New MySqlCommand("select * from tb_user where id_user='" & TextBox1.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Me.Close()
                Call Terbuka()
            Else
                MsgBox("ID User atau Password salah!")
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
End Class