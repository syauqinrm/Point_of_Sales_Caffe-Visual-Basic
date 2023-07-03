Imports MySql.Data.MySqlClient
Public Class Report
    Sub tampildatagridjual()
        Call koneksi()
        da = New MySqlDataAdapter("Select * From tbl_datapenjualan", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_datapenjualan")
        DataGridView1.DataSource = ds.Tables("tbl_datapenjualan")
        DataGridView1.ReadOnly = True
    End Sub

    Sub tampildatagriddtljual()
        Call koneksi()
        da = New MySqlDataAdapter("Select * From tbl_dtlpenjualan", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_dtlpenjualan")
        DataGridView2.DataSource = ds.Tables("tbl_dtlpenjualan")
        DataGridView2.ReadOnly = True
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_poscaffeDataSet1.tbl_dtlpenjualan' table. You can move, or remove it, as needed.
        Me.Tbl_dtlpenjualanTableAdapter.Fill(Me.Db_poscaffeDataSet1.tbl_dtlpenjualan)
        'TODO: This line of code loads data into the 'Db_poscaffeDataSet.tbl_datapenjualan' table. You can move, or remove it, as needed.
        Me.Tbl_datapenjualanTableAdapter.Fill(Me.Db_poscaffeDataSet.tbl_datapenjualan)
        Call tampildatagriddtljual()
        Call tampildatagridjual()
    End Sub
End Class