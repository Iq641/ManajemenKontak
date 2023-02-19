Public Class tambahkontak
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim nomor As Integer = readini(namafile, "Kode", "No", 0)
        If nomor = 0 Then
            writeini(namafile, "Kode", "No", nomor)
        End If
        If txtNama.Text = "" Then
            MsgBox("Nama Harus diisi")
            txtNama.Focus()
            Return
        End If
        If txtNomor.Text = "" Then
            MsgBox("Nomor Harus diisi")
            txtNomor.Focus()
            Return
        End If
        nomor = nomor + 1
        writeini(namafile, "Kontak" & nomor, "Kode", nomor)
        writeini(namafile, "Kontak" & nomor, "Nama", txtNama.Text.ToUpper)
        writeini(namafile, "Kontak" & nomor, "Nomor", txtNomor.Text)
        writeini(namafile, "Kode", "No", nomor)
        MsgBox("Nama Kontak: " & txtNama.Text.ToUpper & ", Berhasil Disimpan")
        txtNama.Text = ""
        txtNomor.Text = ""
    End Sub


End Class