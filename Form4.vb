Public Class Form4

    Private Sub Btnprocess_Click(sender As Object, e As EventArgs) Handles Btnprocess.Click
        Dim nip As String = TxtNIP.Text
        Dim nama As String = Txtnama.Text
        Dim fakultas As String = CmbBoxFakultas.SelectedItem
        Dim jurusan As String = CmmbBoxJurusan.SelectedItem
        Dim kelamin As String = " "
        If RBtn_Laki.Checked Then
            kelamin = "Laki-laki"
        ElseIf RBtn_Perempuan.Checked Then
            kelamin = "Perempuan"
        End If
        MessageBox.Show("Hai: " + nama + vbCrLf + "NIP: " + nip + vbCrLf + "Fakultas: " + fakultas + vbCrLf + "Jurusan: " + jurusan + vbCrLf + "Jenis Kelamin: " + kelamin, "Informasi: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RBtn_Laki_CheckedChanged(sender As Object, e As EventArgs) Handles RBtn_Laki.CheckedChanged
      
    End Sub

    Private Sub RBtn_Perempuan_CheckedChanged(sender As Object, e As EventArgs) Handles RBtn_Perempuan.CheckedChanged
       
    End Sub
End Class