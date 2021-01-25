Public Class frmDataFilm

    Private Property da As SqlClient.SqlDataAdapter

    Private Property ds As DataSet

    Private Sub TampilFilm()
        txtid_film.Text = oFilm_baru.id_film
        txtJudul.Text = oFilm_baru.judul
        cbKategori.Text = oFilm_baru.kategori
        txtSinopsis.Text = oFilm_baru.sinopsis
    End Sub

    Private Sub SimpanDataFilm()
        oFilm_baru.id_film = txtid_film.Text
        oFilm_baru.judul = txtJudul.Text
        oFilm_baru.kategori = cbKategori.Text
        oFilm_baru.sinopsis = txtSinopsis.Text
        oFilm_baru.Simpan()
        Reload()
        If (oFilm_baru.InsertState = True) Then
            MessageBox.Show("Data Berhasil Disimpan")
        ElseIf (oFilm_baru.UpdateState = True) Then
            MessageBox.Show("Data berhasil diubah")
        Else
            MessageBox.Show("Data gagal disimpan")
        End If
    End Sub

    Private Sub ClearEntry()
        txtid_film.Focus()
        txtJudul.Clear()
        txtSinopsis.Clear()
    End Sub

    Private Sub TampilData()
        DBConnect()

        Try
            da = New SqlClient.SqlDataAdapter("Select * from dbo.film order by 'id_film' ", conn)
            ds = New DataSet

            da.Fill(ds, "dbo.film")
            DataFilm1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub Reload()
        TampilData()
    End Sub

    Private Sub Hapus()
        If (film_baru = False And txtid_film.Text <> "") Then
            oFilm_baru.Hapus(txtid_film.Text)
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("Kode Id Film dan Judul tidak boleh kosong!")
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If (txtid_film.Text <> "" And txtJudul.Text <> "") Then
            SimpanDataFilm()
            ClearEntry()
            Reload()
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearEntry()
    End Sub


    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnHapus.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah Data akan dihapus", "Confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
        Else
            MessageBox.Show("Data batal dihapus")
        End If
    End Sub

    Private Sub txtid_film_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtid_film.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oFilm_baru.CariFilm(txtid_film.Text)
            If (film_baru = False) Then
                TampilFilm()
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        Reload()
    End Sub

    Private Sub frmDataFilm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Reload()
    End Sub
End Class