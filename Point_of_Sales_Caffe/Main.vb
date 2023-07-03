Public Class Main
    Sub Terkunci()
        LogInToolStripMenuItem.Enabled = True
        LogOutToolStripMenuItem.Enabled = False
        InventoryToolStripMenuItem.Enabled = False
        TransToolStripMenuItem.Enabled = False
        ReportToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub StokBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokBarangToolStripMenuItem.Click
        Inventory.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Transaction.ShowDialog()
    End Sub

    Private Sub RekapPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekapPenjualanToolStripMenuItem.Click
        Report.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class