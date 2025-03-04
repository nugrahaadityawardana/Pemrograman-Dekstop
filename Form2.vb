Public Class Form2

    Private Sub Btnprocess_Click(sender As Object, e As EventArgs) Handles Btnprocess.Click
        Dim nama As String = Txtnama.Text
        Dim jurusan As String = Txtjurusan.Text
        Dim matakuliah As String = Txtmatakuliah.Text
        MessageBox.Show("Hallo " + nama + vbCrLf + "Anda mengambil jurusan " + jurusan + vbCrLf + "Matakuliah " + matakuliah, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Txtnama_TextChanged(sender As Object, e As EventArgs) Handles Txtnama.TextChanged

    End Sub

    Private Sub Lblnama_Click(sender As Object, e As EventArgs) Handles Lblnama.Click

    End Sub
End Class