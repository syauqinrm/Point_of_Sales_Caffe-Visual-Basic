<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TbldatapenjualanBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TbldtlpenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblrekapBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbldatapenjualanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbldatapenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_poscaffeDataSet = New Point_of_Sales_Caffe.db_poscaffeDataSet()
        Me.TbldatapenjualanBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_datapenjualanTableAdapter = New Point_of_Sales_Caffe.db_poscaffeDataSetTableAdapters.tbl_datapenjualanTableAdapter()
        Me.IdtransaksiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapelangganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalhargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DibayarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KembalianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Db_poscaffeDataSet1 = New Point_of_Sales_Caffe.db_poscaffeDataSet1()
        Me.TbldtlpenjualanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_dtlpenjualanTableAdapter = New Point_of_Sales_Caffe.db_poscaffeDataSet1TableAdapters.tbl_dtlpenjualanTableAdapter()
        Me.IdtransaksiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdbarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahbarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargabarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldatapenjualanBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldtlpenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblrekapBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldatapenjualanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldatapenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_poscaffeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldatapenjualanBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_poscaffeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldtlpenjualanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtransaksiDataGridViewTextBoxColumn1, Me.IdbarangDataGridViewTextBoxColumn, Me.NamabarangDataGridViewTextBoxColumn, Me.JumlahbarangDataGridViewTextBoxColumn, Me.HargabarangDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TbldtlpenjualanBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(13, 339)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(953, 274)
        Me.DataGridView2.TabIndex = 7
        '
        'TbldatapenjualanBindingSource2
        '
        Me.TbldatapenjualanBindingSource2.DataMember = "tbl_datapenjualan"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtransaksiDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn, Me.NamapelangganDataGridViewTextBoxColumn, Me.TotalhargaDataGridViewTextBoxColumn, Me.DibayarDataGridViewTextBoxColumn, Me.KembalianDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbldatapenjualanBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(13, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(953, 288)
        Me.DataGridView1.TabIndex = 6
        '
        'TbldtlpenjualanBindingSource
        '
        Me.TbldtlpenjualanBindingSource.DataMember = "tbl_dtlpenjualan"
        '
        'TblrekapBindingSource
        '
        Me.TblrekapBindingSource.DataMember = "tbl_rekap"
        '
        'TbldatapenjualanBindingSource1
        '
        Me.TbldatapenjualanBindingSource1.DataMember = "tbl_datapenjualan"
        '
        'TbldatapenjualanBindingSource
        '
        Me.TbldatapenjualanBindingSource.DataMember = "tbl_datapenjualan"
        '
        'Db_poscaffeDataSet
        '
        Me.Db_poscaffeDataSet.DataSetName = "db_poscaffeDataSet"
        Me.Db_poscaffeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbldatapenjualanBindingSource3
        '
        Me.TbldatapenjualanBindingSource3.DataMember = "tbl_datapenjualan"
        Me.TbldatapenjualanBindingSource3.DataSource = Me.Db_poscaffeDataSet
        '
        'Tbl_datapenjualanTableAdapter
        '
        Me.Tbl_datapenjualanTableAdapter.ClearBeforeFill = True
        '
        'IdtransaksiDataGridViewTextBoxColumn
        '
        Me.IdtransaksiDataGridViewTextBoxColumn.DataPropertyName = "idtransaksi"
        Me.IdtransaksiDataGridViewTextBoxColumn.HeaderText = "idtransaksi"
        Me.IdtransaksiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdtransaksiDataGridViewTextBoxColumn.Name = "IdtransaksiDataGridViewTextBoxColumn"
        Me.IdtransaksiDataGridViewTextBoxColumn.Width = 150
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        Me.TanggalDataGridViewTextBoxColumn.Width = 150
        '
        'NamapelangganDataGridViewTextBoxColumn
        '
        Me.NamapelangganDataGridViewTextBoxColumn.DataPropertyName = "namapelanggan"
        Me.NamapelangganDataGridViewTextBoxColumn.HeaderText = "namapelanggan"
        Me.NamapelangganDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamapelangganDataGridViewTextBoxColumn.Name = "NamapelangganDataGridViewTextBoxColumn"
        Me.NamapelangganDataGridViewTextBoxColumn.Width = 150
        '
        'TotalhargaDataGridViewTextBoxColumn
        '
        Me.TotalhargaDataGridViewTextBoxColumn.DataPropertyName = "totalharga"
        Me.TotalhargaDataGridViewTextBoxColumn.HeaderText = "totalharga"
        Me.TotalhargaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalhargaDataGridViewTextBoxColumn.Name = "TotalhargaDataGridViewTextBoxColumn"
        Me.TotalhargaDataGridViewTextBoxColumn.Width = 150
        '
        'DibayarDataGridViewTextBoxColumn
        '
        Me.DibayarDataGridViewTextBoxColumn.DataPropertyName = "dibayar"
        Me.DibayarDataGridViewTextBoxColumn.HeaderText = "dibayar"
        Me.DibayarDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DibayarDataGridViewTextBoxColumn.Name = "DibayarDataGridViewTextBoxColumn"
        Me.DibayarDataGridViewTextBoxColumn.Width = 150
        '
        'KembalianDataGridViewTextBoxColumn
        '
        Me.KembalianDataGridViewTextBoxColumn.DataPropertyName = "kembalian"
        Me.KembalianDataGridViewTextBoxColumn.HeaderText = "kembalian"
        Me.KembalianDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.KembalianDataGridViewTextBoxColumn.Name = "KembalianDataGridViewTextBoxColumn"
        Me.KembalianDataGridViewTextBoxColumn.Width = 150
        '
        'Db_poscaffeDataSet1
        '
        Me.Db_poscaffeDataSet1.DataSetName = "db_poscaffeDataSet1"
        Me.Db_poscaffeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbldtlpenjualanBindingSource1
        '
        Me.TbldtlpenjualanBindingSource1.DataMember = "tbl_dtlpenjualan"
        Me.TbldtlpenjualanBindingSource1.DataSource = Me.Db_poscaffeDataSet1
        '
        'Tbl_dtlpenjualanTableAdapter
        '
        Me.Tbl_dtlpenjualanTableAdapter.ClearBeforeFill = True
        '
        'IdtransaksiDataGridViewTextBoxColumn1
        '
        Me.IdtransaksiDataGridViewTextBoxColumn1.DataPropertyName = "idtransaksi"
        Me.IdtransaksiDataGridViewTextBoxColumn1.HeaderText = "idtransaksi"
        Me.IdtransaksiDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.IdtransaksiDataGridViewTextBoxColumn1.Name = "IdtransaksiDataGridViewTextBoxColumn1"
        Me.IdtransaksiDataGridViewTextBoxColumn1.Width = 150
        '
        'IdbarangDataGridViewTextBoxColumn
        '
        Me.IdbarangDataGridViewTextBoxColumn.DataPropertyName = "idbarang"
        Me.IdbarangDataGridViewTextBoxColumn.HeaderText = "idbarang"
        Me.IdbarangDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdbarangDataGridViewTextBoxColumn.Name = "IdbarangDataGridViewTextBoxColumn"
        Me.IdbarangDataGridViewTextBoxColumn.Width = 150
        '
        'NamabarangDataGridViewTextBoxColumn
        '
        Me.NamabarangDataGridViewTextBoxColumn.DataPropertyName = "namabarang"
        Me.NamabarangDataGridViewTextBoxColumn.HeaderText = "namabarang"
        Me.NamabarangDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamabarangDataGridViewTextBoxColumn.Name = "NamabarangDataGridViewTextBoxColumn"
        Me.NamabarangDataGridViewTextBoxColumn.Width = 150
        '
        'JumlahbarangDataGridViewTextBoxColumn
        '
        Me.JumlahbarangDataGridViewTextBoxColumn.DataPropertyName = "jumlahbarang"
        Me.JumlahbarangDataGridViewTextBoxColumn.HeaderText = "jumlahbarang"
        Me.JumlahbarangDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JumlahbarangDataGridViewTextBoxColumn.Name = "JumlahbarangDataGridViewTextBoxColumn"
        Me.JumlahbarangDataGridViewTextBoxColumn.Width = 150
        '
        'HargabarangDataGridViewTextBoxColumn
        '
        Me.HargabarangDataGridViewTextBoxColumn.DataPropertyName = "hargabarang"
        Me.HargabarangDataGridViewTextBoxColumn.HeaderText = "hargabarang"
        Me.HargabarangDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HargabarangDataGridViewTextBoxColumn.Name = "HargabarangDataGridViewTextBoxColumn"
        Me.HargabarangDataGridViewTextBoxColumn.Width = 150
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.Width = 150
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 628)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldatapenjualanBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldtlpenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblrekapBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldatapenjualanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldatapenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_poscaffeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldatapenjualanBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_poscaffeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldtlpenjualanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TblrekapBindingSource As BindingSource
    Friend WithEvents TbldatapenjualanBindingSource1 As BindingSource
    Friend WithEvents TbldatapenjualanBindingSource2 As BindingSource
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TbldtlpenjualanBindingSource As BindingSource
    Friend WithEvents TbldatapenjualanBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Db_poscaffeDataSet As db_poscaffeDataSet
    Friend WithEvents TbldatapenjualanBindingSource3 As BindingSource
    Friend WithEvents Tbl_datapenjualanTableAdapter As db_poscaffeDataSetTableAdapters.tbl_datapenjualanTableAdapter
    Friend WithEvents IdtransaksiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamapelangganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalhargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DibayarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KembalianDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Db_poscaffeDataSet1 As db_poscaffeDataSet1
    Friend WithEvents TbldtlpenjualanBindingSource1 As BindingSource
    Friend WithEvents Tbl_dtlpenjualanTableAdapter As db_poscaffeDataSet1TableAdapters.tbl_dtlpenjualanTableAdapter
    Friend WithEvents IdtransaksiDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdbarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamabarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahbarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargabarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
