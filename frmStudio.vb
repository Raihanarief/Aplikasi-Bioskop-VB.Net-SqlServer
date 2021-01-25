Public Class frmStudio
    Private Property da As SqlClient.SqlDataAdapter

    Private Property ds As DataSet

    Private Sub TampilStudio()
        txtid_studio.Text = oStudio_baru.id_studio
        txtNamaStudio.Text = oStudio_baru.nama_studio
    End Sub

    Private Sub SimpanDataStudio()
        oStudio_baru.id_studio = txtid_studio.Text
        oStudio_baru.nama_studio = txtNamaStudio.Text
        oStudio_baru.Simpan()
        Reload()
        If (oStudio_baru.InsertState = True) Then
            MessageBox.Show("Data Berhasil Disimpan")
        ElseIf (oStudio_baru.UpdateState = True) Then
            MessageBox.Show("Data berhasil diubah")
        Else
            MessageBox.Show("Data gagal disimpan")
        End If
    End Sub

    Private Sub ClearEntry()
        txtid_studio.Focus()
        txtNamaStudio.Clear()
    End Sub

    Private Sub TampilData()
        DBConnect()

        Try
            da = New SqlClient.SqlDataAdapter("Select * from dbo.studio order by 'id_studio' ", conn)
            ds = New DataSet

            da.Fill(ds, "dbo.studio")
            DataStudio.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub Reload()
        TampilData()
    End Sub

    Private Sub Hapus()
        If (studio_baru = False And txtid_studio.Text <> "") Then
            oStudio_baru.Hapus(txtid_studio.Text)
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("Id Studio tidak boleh kosong!")
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If (txtid_studio.Text <> "" And txtNamaStudio.Text <> "") Then
            SimpanDataStudio()
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

    Private Sub txtid_studio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtid_studio.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oStudio_baru.CariStudio(txtid_studio.Text)
            If (studio_baru = False) Then
                TampilStudio()
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        Reload()
    End Sub

    Private Sub frmStudio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Reload()
    End Sub
End Class