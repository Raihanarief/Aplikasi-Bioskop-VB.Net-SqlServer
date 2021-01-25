Imports System.Data.SqlClient

Public Class frmJadwal
    Private Property da As SqlClient.SqlDataAdapter

    Private Property ds As DataSet

    Private Property cmd As SqlCommand

    Private Property rd As SqlDataReader

    Private Sub TampilJadwal()
        Dim waktutxt

        waktutxt = txtHH.Text & " : " & txtMM.Text

        txtId_jadwal.Text = oJadwal_baru.id_jadwal
        waktutxt = oJadwal_baru.waktu
        cbFilm.Text = oJadwal_baru.id_film
        cbStudio.Text = oJadwal_baru.id_studio
    End Sub

    Private Sub SimpanDataJadwal()
        Dim waktutxt

        waktutxt = txtHH.Text & " : " & txtMM.Text

        oJadwal_baru.id_jadwal = txtId_jadwal.Text
        oJadwal_baru.waktu = waktutxt
        oJadwal_baru.id_film = cbFilm.Text
        oJadwal_baru.id_studio = cbStudio.Text
        oJadwal_baru.Simpan()
        Reload()
        If (oJadwal_baru.InsertState = True) Then
            MessageBox.Show("Data Berhasil Disimpan")
        ElseIf (oJadwal_baru.UpdateState = True) Then
            MessageBox.Show("Data berhasil diubah")
        Else
            MessageBox.Show("Data gagal disimpan")
        End If
    End Sub

    Private Sub ClearEntry()
        txtId_jadwal.Focus()
        cbStudio.ResetText()
        cbFilm.ResetText()
        txtHH.Clear()
        txtMM.Clear()
    End Sub

    Private Sub TampilData()
        DBConnect()

        Try
            da = New SqlClient.SqlDataAdapter("Select * from dbo.jadwal order by 'id_jadwal' ", conn)
            ds = New DataSet

            da.Fill(ds, "dbo.jadwal")
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub isiComboBoxFilm()
        DBConnect()
        Dim str As String

        str = "select id_film from film"
        cmd = New SqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            While rd.Read
                cbFilm.Items.Add(rd("id_film"))
            End While
        Else

        End If

    End Sub

    Private Sub isiComboBoxStudio()
        DBConnect()
        Dim str As String
        str = "select id_studio from studio"
        cmd = New SqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            While rd.Read
                cbStudio.Items.Add(rd("id_studio"))
            End While
        Else

        End If
    End Sub

    Private Sub Reload()
        isiComboBoxFilm()
        isiComboBoxStudio()
        TampilData()
    End Sub

    Private Sub Hapus()
        If (jadwal_baru = False And txtId_jadwal.Text <> "") Then
            oJadwal_baru.Hapus(txtId_jadwal.Text)
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("Id Jadwal tidak boleh kosong!")
        End If
    End Sub



    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        Dim waktutxt
        waktutxt = txtHH.Text & " : " & txtMM.Text

        If (txtId_jadwal.Text <> "" And waktutxt <> "") Then
            SimpanDataJadwal()
            ClearEntry()
            Reload()
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearEntry()
        cbFilm.ResetText()
        cbStudio.ResetText()
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

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        Reload()
    End Sub

    Private Sub txtId_jadwal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtId_jadwal.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oJadwal_baru.Carijadwal(txtId_jadwal.Text)
            If (jadwal_baru = False) Then
                TampilJadwal()
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub frmJadwal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub cbFilm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbFilm.SelectedIndexChanged
        DBConnect()

        cmd = New SqlClient.SqlCommand("SELECT judul from film where id_film='" & cbFilm.Text & "'", conn)

        DR = cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            lblFilm.Text = DR.Item(0)

        End If
    End Sub

    Private Sub cbStudio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbStudio.SelectedIndexChanged
        DBConnect()

        cmd = New SqlClient.SqlCommand("SELECT nama_studio from studio where id_studio='" & cbStudio.Text & "'", conn)

        DR = cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            lblStudio.Text = DR.Item(0)

        End If
    End Sub
End Class