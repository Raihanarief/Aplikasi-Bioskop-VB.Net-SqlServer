<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJadwal
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
        Me.txtId_jadwal = New System.Windows.Forms.TextBox()
        Me.txtHH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbFilm = New System.Windows.Forms.ComboBox()
        Me.cbStudio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.lblFilm = New System.Windows.Forms.Label()
        Me.lblStudio = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Jadwal"
        '
        'txtId_jadwal
        '
        Me.txtId_jadwal.Location = New System.Drawing.Point(73, 25)
        Me.txtId_jadwal.Name = "txtId_jadwal"
        Me.txtId_jadwal.Size = New System.Drawing.Size(100, 20)
        Me.txtId_jadwal.TabIndex = 2
        '
        'txtHH
        '
        Me.txtHH.Location = New System.Drawing.Point(73, 51)
        Me.txtHH.Name = "txtHH"
        Me.txtHH.Size = New System.Drawing.Size(32, 20)
        Me.txtHH.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Waktu"
        '
        'txtMM
        '
        Me.txtMM.Location = New System.Drawing.Point(111, 51)
        Me.txtMM.Name = "txtMM"
        Me.txtMM.Size = New System.Drawing.Size(32, 20)
        Me.txtMM.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "hh:mm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Film"
        '
        'cbFilm
        '
        Me.cbFilm.FormattingEnabled = True
        Me.cbFilm.Location = New System.Drawing.Point(72, 80)
        Me.cbFilm.Name = "cbFilm"
        Me.cbFilm.Size = New System.Drawing.Size(121, 21)
        Me.cbFilm.TabIndex = 8
        '
        'cbStudio
        '
        Me.cbStudio.FormattingEnabled = True
        Me.cbStudio.Location = New System.Drawing.Point(73, 130)
        Me.cbStudio.Name = "cbStudio"
        Me.cbStudio.Size = New System.Drawing.Size(121, 21)
        Me.cbStudio.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Studio"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(229, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(535, 155)
        Me.DataGridView1.TabIndex = 11
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(72, 186)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(525, 186)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(75, 23)
        Me.btnReload.TabIndex = 25
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(687, 186)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(606, 186)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 23
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'lblFilm
        '
        Me.lblFilm.AutoSize = True
        Me.lblFilm.Location = New System.Drawing.Point(70, 104)
        Me.lblFilm.Name = "lblFilm"
        Me.lblFilm.Size = New System.Drawing.Size(16, 13)
        Me.lblFilm.TabIndex = 27
        Me.lblFilm.Text = "..."
        '
        'lblStudio
        '
        Me.lblStudio.AutoSize = True
        Me.lblStudio.Location = New System.Drawing.Point(70, 154)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(16, 13)
        Me.lblStudio.TabIndex = 28
        Me.lblStudio.Text = "..."
        '
        'frmJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 223)
        Me.Controls.Add(Me.lblStudio)
        Me.Controls.Add(Me.lblFilm)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbStudio)
        Me.Controls.Add(Me.cbFilm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMM)
        Me.Controls.Add(Me.txtHH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtId_jadwal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmJadwal"
        Me.Text = "frmJadwal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId_jadwal As System.Windows.Forms.TextBox
    Friend WithEvents txtHH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbFilm As System.Windows.Forms.ComboBox
    Friend WithEvents cbStudio As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents lblFilm As System.Windows.Forms.Label
    Friend WithEvents lblStudio As System.Windows.Forms.Label
End Class
