<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudio
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtid_studio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaStudio = New System.Windows.Forms.TextBox()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.DataStudio = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.DataStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "id_Studio"
        '
        'txtid_studio
        '
        Me.txtid_studio.Location = New System.Drawing.Point(97, 59)
        Me.txtid_studio.Name = "txtid_studio"
        Me.txtid_studio.Size = New System.Drawing.Size(149, 20)
        Me.txtid_studio.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama Studio"
        '
        'txtNamaStudio
        '
        Me.txtNamaStudio.Location = New System.Drawing.Point(97, 85)
        Me.txtNamaStudio.Name = "txtNamaStudio"
        Me.txtNamaStudio.Size = New System.Drawing.Size(149, 20)
        Me.txtNamaStudio.TabIndex = 14
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(392, 168)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(75, 23)
        Me.btnReload.TabIndex = 20
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(554, 168)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 19
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(473, 168)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 18
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'DataStudio
        '
        Me.DataStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataStudio.Location = New System.Drawing.Point(260, 12)
        Me.DataStudio.Name = "DataStudio"
        Me.DataStudio.Size = New System.Drawing.Size(369, 150)
        Me.DataStudio.TabIndex = 21
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(260, 168)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 209)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.DataStudio)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtid_studio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamaStudio)
        Me.Name = "frmStudio"
        Me.Text = "frmStudio"
        CType(Me.DataStudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtid_studio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamaStudio As System.Windows.Forms.TextBox
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents DataStudio As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
