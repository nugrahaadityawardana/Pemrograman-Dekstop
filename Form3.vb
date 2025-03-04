Public Class Form3

    Private Sub Txtnama_TextChanged(sender As Object, e As EventArgs) Handles Txtnama.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxFakultas.SelectedIndexChanged

    End Sub

    Private Sub Btnprocess_Click(sender As Object, e As EventArgs) Handles Btnprocess.Click
        Dim NIP As String = TxtNIP.Text
        Dim nama As String = Txtnama.Text
        Dim fakultas As String = CmbBoxFakultas.SelectedItem
        Dim jurusan As String = CmmbBoxJurusan.SelectedItem
        MessageBox.Show("Hai: " + nama + vbCrLf + "NIP: " + NIP + vbCrLf + "Fakultas: " + fakultas + vbCrLf + "Jurusan: " + jurusan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class