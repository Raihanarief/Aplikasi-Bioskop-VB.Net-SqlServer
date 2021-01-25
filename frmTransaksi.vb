Public Class frmTransaksi

    Private Property rd As Object

    Private Property cmd As Object

    Private Property da As SqlClient.SqlDataAdapter

    Private Property ds As DataSet

    Private Sub TampilTransaksi()
        txtKodeTiket.Text = oTransaksi_baru.kode_tiket
        txtJumlahTiket.Text = oTransaksi_baru.jumlah
        txtTotalHarga.Text = oTransaksi_baru.total_harga
        cbIdjadwal.Text = oTransaksi_baru.id_jadwal
        dtpTgl_pesan.Text = oTransaksi_baru.tgl_pesan


    End Sub

    Private Sub SimpanData()
        If (txtBayar.Text >= txtTotalHarga.Text) Then
            oTransaksi_baru.id_transaksi = txtId_transaksi.Text
            oTransaksi_baru.kode_tiket = txtKodeTiket.Text
            oTransaksi_baru.jumlah = txtJumlahTiket.Text
            oTransaksi_baru.total_harga = txtTotalHarga.Text
            oTransaksi_baru.tgl_pesan = dtpTgl_pesan.Text
            oTransaksi_baru.id_jadwal = cbIdjadwal.Text
            oTransaksi_baru.kursi = txtKursi.Text
            oTransaksi_baru.Simpan()
            Reload()

            If (oTransaksi_baru.InsertState = True) Then
                MessageBox.Show("Transaksi Sukses")
            ElseIf (oTransaksi_baru.UpdateState = True) Then
                MessageBox.Show("Data berhasil diubah")
            Else
                MessageBox.Show("Transaksi Gagal")
            End If
        Else
            MessageBox.Show("Uang Kurang")
        End If
    End Sub

    Private Sub ClearEntry()
        txtKodeTiket.Focus()
    End Sub


    Private Sub isiComboBoxIDJadwal()
        DBConnect()
        Dim str As String

        str = "select id_jadwal from jadwal"
        cmd = New SqlClient.SqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                cbIdjadwal.Items.Add(rd("id_jadwal"))
            Loop
        Else

        End If

    End Sub

    Private Sub Reload()
        kode_tiket = getKode_tiket()
        txtKodeTiket.Text = kode_tiket
    End Sub

    Private Sub cbIdjadwal_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbIdjadwal.SelectedIndexChanged
        DBConnect()

        cmd = New SqlClient.SqlCommand("SELECT film.judul,studio.nama_studio,jadwal.waktu FROM jadwal INNER JOIN film ON jadwal.id_film = film.id_film INNER JOIN studio ON jadwal.id_studio = studio.id_studio where jadwal.id_jadwal='" & cbIdjadwal.Text & "'", conn)

        DR = cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtFilm.Text = DR.Item(0)
            txtStudio.Text = DR.Item(1)
            txtWaktu.Text = DR.Item(2)

        End If

    End Sub

    Private Sub frmTransaksi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        isiComboBoxIDJadwal()
        cbIdjadwal.ResetText()
        Reload()
    End Sub

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        isiComboBoxIDJadwal()
    End Sub


    Private Sub btnCekHarga_Click(sender As System.Object, e As System.EventArgs) Handles btnCekHarga.Click
        If (txtJumlahTiket.Text = 0) Then
            MessageBox.Show("Jumlah Tiket Kosong")
        ElseIf (txtJumlahTiket.Text > 0) Then
            txtTotalHarga.Text = 35000 * txtJumlahTiket.Text
        End If

    End Sub

    Private Sub btnCek_Click(sender As System.Object, e As System.EventArgs) Handles btnCek.Click
        txtKursi.Text = cbA.Text & "" & cbB.Text
    End Sub

    Private Sub btnBayar_Click(sender As System.Object, e As System.EventArgs) Handles btnBayar.Click
        If (txtId_transaksi.Text <> "") Then
            SimpanData()
            ClearEntry()
            Reload()
        End If
    End Sub

    Private Sub txtId_transaksi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtId_transaksi.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oTransaksi_baru.CariTransaksi(txtId_transaksi.Text)
            If (transaksi_baru = False) Then
                TampilTransaksi()
                Reload()
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If
        End If
    End Sub
End Class