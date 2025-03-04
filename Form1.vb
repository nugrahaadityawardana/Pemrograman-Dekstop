Public Class btn_Bagi

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lbl_Nilai1.Click

    End Sub

    Private Sub btn_Perkalian_Click(sender As Object, e As EventArgs) Handles btn_Perkalian.Click
        Dim nilai1 As Integer = CInt(TxtNilai1.Text)
        Dim nilai2 As Integer = CInt(TxtNilai2.Text)
        Dim hasil As Integer = nilai1 * nilai2
        Txthasil.Text = hasil
    End Sub

    Private Sub btn_Pembagian_Click(sender As Object, e As EventArgs) Handles btn_Pembagian.Click
        Dim nilai1 As Integer = CInt(Txtnilai1.Text)
        Dim nilai2 As Integer = CInt(Txtnilai2.Text)
        Dim hasil As Integer = nilai1 / nilai2
        Txthasil.Text = hasil
    End Sub

    Private Sub btn_Pengurangan_Click(sender As Object, e As EventArgs) Handles btn_Pengurangan.Click
        Dim nilai1 As Integer = CInt(Txtnilai1.Text)
        Dim nilai2 As Integer = CInt(Txtnilai2.Text)
        Dim hasil As Integer = nilai1 - nilai2
        Txthasil.Text = hasil
    End Sub

    Private Sub btn_Penambahan_Click(sender As Object, e As EventArgs) Handles btn_Penambahan.Click
        Dim nilai1 As Integer = CInt(Txtnilai1.Text)
        Dim nilai2 As Integer = CInt(Txtnilai2.Text)
        Dim hasil As Integer = nilai1 - nilai2
        Txthasil.Text = hasil
    End Sub
End Class
