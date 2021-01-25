<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTgl_pesan = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJumlahTiket = New System.Windows.Forms.TextBox()
        Me.txtKodeTiket = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudio = New System.Windows.Forms.TextBox()
        Me.txtWaktu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbA = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbB = New System.Windows.Forms.ComboBox()
        Me.cbIdjadwal = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFilm = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCekHarga = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnCek = New System.Windows.Forms.Button()
        Me.txtKursi = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtId_transaksi = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal Pemesanan"
        '
        'dtpTgl_pesan
        '
        Me.dtpTgl_pesan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTgl_pesan.Location = New System.Drawing.Point(133, 160)
        Me.dtpTgl_pesan.Name = "dtpTgl_pesan"
        Me.dtpTgl_pesan.Size = New System.Drawing.Size(121, 20)
        Me.dtpTgl_pesan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jumlah Tiket"
        '
        'txtJumlahTiket
        '
        Me.txtJumlahTiket.Location = New System.Drawing.Point(133, 101)
        Me.txtJumlahTiket.Name = "txtJumlahTiket"
        Me.txtJumlahTiket.Size = New System.Drawing.Size(121, 20)
        Me.txtJumlahTiket.TabIndex = 3
        '
        'txtKodeTiket
        '
        Me.txtKodeTiket.Location = New System.Drawing.Point(133, 70)
        Me.txtKodeTiket.Name = "txtKodeTiket"
        Me.txtKodeTiket.Size = New System.Drawing.Size(121, 20)
        Me.txtKodeTiket.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kode Tiket"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Film"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Studio"
        '
        'txtStudio
        '
        Me.txtStudio.Location = New System.Drawing.Point(133, 243)
        Me.txtStudio.Name = "txtStudio"
        Me.txtStudio.Size = New System.Drawing.Size(121, 20)
        Me.txtStudio.TabIndex = 18
        '
        'txtWaktu
        '
        Me.txtWaktu.Location = New System.Drawing.Point(133, 274)
        Me.txtWaktu.Name = "txtWaktu"
        Me.txtWaktu.Size = New System.Drawing.Size(121, 20)
        Me.txtWaktu.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Waktu"
        '
        'cbA
        '
        Me.cbA.FormattingEnabled = True
        Me.cbA.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L"})
        Me.cbA.Location = New System.Drawing.Point(133, 304)
        Me.cbA.Name = "cbA"
        Me.cbA.Size = New System.Drawing.Size(34, 21)
        Me.cbA.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Kursi"
        '
        'cbB
        '
        Me.cbB.FormattingEnabled = True
        Me.cbB.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbB.Location = New System.Drawing.Point(173, 304)
        Me.cbB.Name = "cbB"
        Me.cbB.Size = New System.Drawing.Size(34, 21)
        Me.cbB.TabIndex = 23
        '
        'cbIdjadwal
        '
        Me.cbIdjadwal.FormattingEnabled = True
        Me.cbIdjadwal.Location = New System.Drawing.Point(133, 186)
        Me.cbIdjadwal.Name = "cbIdjadwal"
        Me.cbIdjadwal.Size = New System.Drawing.Size(121, 21)
        Me.cbIdjadwal.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Id Jadwal"
        '
        'txtFilm
        '
        Me.txtFilm.Location = New System.Drawing.Point(133, 213)
        Me.txtFilm.Name = "txtFilm"
        Me.txtFilm.Size = New System.Drawing.Size(121, 20)
        Me.txtFilm.TabIndex = 26
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(14, 369)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(95, 369)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(75, 23)
        Me.btnReload.TabIndex = 27
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Location = New System.Drawing.Point(133, 129)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Size = New System.Drawing.Size(121, 20)
        Me.txtTotalHarga.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Total Harga"
        '
        'btnCekHarga
        '
        Me.btnCekHarga.Location = New System.Drawing.Point(260, 127)
        Me.btnCekHarga.Name = "btnCekHarga"
        Me.btnCekHarga.Size = New System.Drawing.Size(75, 23)
        Me.btnCekHarga.TabIndex = 31
        Me.btnCekHarga.Text = "Cek Harga"
        Me.btnCekHarga.UseVisualStyleBackColor = True
        '
        'btnBayar
        '
        Me.btnBayar.Location = New System.Drawing.Point(179, 369)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(75, 23)
        Me.btnBayar.TabIndex = 32
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(260, 304)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(75, 23)
        Me.btnCek.TabIndex = 33
        Me.btnCek.Text = "Cek Kursi"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'txtKursi
        '
        Me.txtKursi.Location = New System.Drawing.Point(213, 304)
        Me.txtKursi.Name = "txtKursi"
        Me.txtKursi.Size = New System.Drawing.Size(40, 20)
        Me.txtKursi.TabIndex = 34
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(132, 331)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(121, 20)
        Me.txtBayar.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Bayar"
        '
        'txtId_transaksi
        '
        Me.txtId_transaksi.Location = New System.Drawing.Point(133, 12)
        Me.txtId_transaksi.Name = "txtId_transaksi"
        Me.txtId_transaksi.Size = New System.Drawing.Size(121, 20)
        Me.txtId_transaksi.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Id Transaksi"
        '
        'frmTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 404)
        Me.Controls.Add(Me.txtId_transaksi)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtKursi)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.btnCekHarga)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.txtFilm)
        Me.Controls.Add(Me.cbIdjadwal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbB)
        Me.Controls.Add(Me.cbA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtWaktu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStudio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKodeTiket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJumlahTiket)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTgl_pesan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTransaksi"
        Me.Text = "frmTransaksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTgl_pesan As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahTiket As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeTiket As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStudio As System.Windows.Forms.TextBox
    Friend WithEvents txtWaktu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbA As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbB As System.Windows.Forms.ComboBox
    Friend WithEvents cbIdjadwal As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFilm As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents txtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCekHarga As System.Windows.Forms.Button
    Friend WithEvents btnBayar As System.Windows.Forms.Button
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents txtKursi As System.Windows.Forms.TextBox
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtId_transaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
