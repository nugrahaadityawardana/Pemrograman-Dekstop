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

        Dim tugas As Double = 0
        Dim uts As Double = 0
        Dim uas As Double = 0
        Dim nilaiAkhir As Double
        Dim grade As String = " "


        If Double.TryParse(TxtTugas.Text, tugas) AndAlso Double.TryParse(TxtUTS.Text, uts) AndAlso Double.TryParse(TxtUAS.Text, uas) Then
        End If

        nilaiAkhir = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)


        If nilaiAkhir >= 78 Then
            grade = "A"
        ElseIf nilaiAkhir >= 65 Then
            grade = "B"
        ElseIf nilaiAkhir >= 50 Then
            grade = "C"
        ElseIf nilaiAkhir >= 40 Then
            grade = "D"
        Else
            grade = "E"
        End If


        If MessageBox.Show("Hai: " + nama + vbCrLf + "NIP: " + nip + vbCrLf + "Fakultas: " + fakultas + vbCrLf + "Jurusan: " + jurusan + vbCrLf + "Jenis Kelamin: " + kelamin + vbCrLf + "Nilai Akhir: " + nilaiAkhir.ToString("0.00") + vbCrLf + "Grade: " + grade, "Informasi: ", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
        Else : MessageBox.Show("Harap masukkan nilai yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

  
End Class