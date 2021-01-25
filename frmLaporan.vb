Public Class frmLaporan

    Private Sub frmLaporan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'rcinema18DataSet.transaksi' table. You can move, or remove it, as needed.
        Me.transaksiTableAdapter.Fill(Me.rcinema18DataSet.transaksi)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class