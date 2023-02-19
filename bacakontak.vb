Public Class bacakontak
    Private Sub bacakontak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim jml As Integer = readini(namafile, "Kode", "No", 0)
        For i As Integer = 1 To jml
            Dim kode As Integer = readini(namafile, "Kontak" & i, "Kode", 0)
            If kode <> 0 Then
                Dim nama As String = readini(namafile, "Kontak" & i, "Nama", "")
                Dim nomor As String = readini(namafile, "Kontak" & i, "Nomor", "")
                lstKontak.Items.Add(kode & " - " & nama & " (" & nomor & ") ")
            End If
        Next i
    End Sub

    Private Sub lstKontak_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKontak.SelectedIndexChanged

    End Sub
End Class