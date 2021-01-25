Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports DevComponents.DotNetBar

Module MyMod
    Public mycommand As New System.Data.SqlClient.SqlCommand
    Public myadapter As New System.Data.SqlClient.SqlDataAdapter
    Public mydata As New DataTable
    Public DR As System.Data.SqlClient.SqlDataReader
    Public SQL As String
    Public conn As New SqlConnection
    Public cn As New Connection

    Public cldTransaksi As New frmTransaksi()
    Public cldLaporan As New frmLaporan()
    Public cldDataFilm As New frmDataFilm()
    Public cldJadwal As New frmJadwal()
    Public cldStudio As New frmStudio()

    Public menu_transaksi As Boolean
    Public menu_laporan As Boolean
    Public menu_data_film As Boolean
    Public menu_jadwal As Boolean
    Public menu_studio As Boolean


    Public TotalTab As Integer = 0
    Public x As Integer

    Public Function getTabIndex(ByVal mytab As TabControl, ByVal sCari As String)
        Dim i As Integer
        For i = 0 To TotalTab - 1
            If (mytab.Tabs(i).Text = sCari) Then

                Exit For
            End If
        Next
        getTabIndex = i
    End Function

    Public Sub BikinMenu(ByVal Child As Form, ByVal mytab As TabControl, ByVal sTitle As String)

        Dim newTab As DevComponents.DotNetBar.TabItem = mytab.CreateTab(sTitle)
        Dim panel As DevComponents.DotNetBar.TabControlPanel = DirectCast(newTab.AttachedControl, Panel)


        Child.TopLevel = False
        Child.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Child.Dock = DockStyle.Fill
        Child.Show()
        panel.Controls.Add(Child)

    End Sub


    'Tabel User
    '--------------------------------
    Public user_baru As Boolean
    Public oUser As New User
    '--------------------------------

    'Tabel Film
    '-------------------------------
    Public film_baru As Boolean
    Public oFilm_baru As New classDataFilm
    '--------------------------------

    'Tabel Jadwal
    '-------------------------------
    Public jadwal_baru As Boolean
    Public oJadwal_baru As New classJadwal
    '--------------------------------

    'Tabel Studio
    '-------------------------------
    Public studio_baru As Boolean
    Public oStudio_baru As New classStudio
    '--------------------------------

    'Tabel Transaksi
    '-------------------------------
    Public transaksi_baru As Boolean
    Public oTransaksi_baru As New classTransaksi
    '--------------------------------

    Public kode_tiket As Double
    Public R As Random = New Random

    Public login_valid As Boolean

    Public Sub DBConnect()
        cn.DataSource = "DESKTOP-S246S5Q\SQLEXPRESS"
        cn.DatabaseName = "rcinema18"
        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub

    Public Function getKode_tiket()
        Dim res As Double
        res = R.Next(1000000, 9999999)
        Return res
    End Function

    Public Function getMD5Hash(ByVal strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        Dim b As Byte
        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function
End Module