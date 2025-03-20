Public Class Form5


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan kolom ke DataGridView
        DataGridView1.Columns.Add("NIP", "NIP")
        DataGridView1.Columns.Add("Nama", "Nama")
        DataGridView1.Columns.Add("JenisKelamin", "Jenis Kelamin")
        DataGridView1.Columns.Add("Jurusan", "Jurusan")
        DataGridView1.Columns.Add("MataKuliah", "Mata Kuliah")
        DataGridView1.Columns.Add("GRADE", "GRADE")
    End Sub

    ' Tombol "New" untuk membersihkan inputan
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNEW.Click
        TxtNIP.Clear()
        TxtNama.Clear()
        CbJurusan.SelectedIndex = -1
        CbMatakuliah.SelectedIndex = -1
        TxtTugas.Clear()
        TxtUTS.Clear()
        TxtUAS.Clear()
        TxtGRADE.Text = "GRADE"
        TxtNIP.Enabled = True
        TxtNIP.Focus()
    End Sub

    
   

    Private Function HitungGrade(tugas As Double, uts As Double, uas As Double) As String
        Dim nilaiAkhir As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)
        Select Case nilaiAkhir
            Case Is >= 78 : Return "A"
            Case Is >= 65 : Return "B"
            Case Is >= 50 : Return "C"
            Case Is >= 40 : Return "D"
            Case Else : Return "E"
        End Select
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSAVE.Click
        Dim tugas, uts, uas As Double
        If Not (Double.TryParse(TxtTugas.Text, tugas) AndAlso Double.TryParse(TxtUTS.Text, uts) AndAlso Double.TryParse(TxtUAS.Text, uas)) Then
            MessageBox.Show("Harap masukkan nilai yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim grade As String = HitungGrade(tugas, uts, uas)
        TxtGRADE.Text = grade

        If TxtNip.Enabled Then
            DataGridView1.Rows.Add(TxtNip.Text, TxtNama.Text, If(RBtn_Laki.Checked, "Laki-laki", "Perempuan"), CbJurusan.Text, CbMatakuliah.Text, grade)
        Else
            Dim row As DataGridViewRow = DataGridView1.CurrentRow
            row.SetValues(TxtNip.Text, TxtNama.Text, If(RBtn_Laki.Checked, "Laki-laki", "Perempuan"), CbJurusan.Text, CbMatakuliah.Text, grade)
        End If
        BtnNEW.PerformClick()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TxtNip.Text = row.Cells(0).Value.ToString()
            TxtNama.Text = row.Cells(1).Value.ToString()
            If row.Cells(2).Value.ToString() = "Laki-laki" Then RBtn_Laki.Checked = True Else RBtn_Perempuan.Checked = True
            CbJurusan.Text = row.Cells(3).Value.ToString()
            CbMatakuliah.Text = row.Cells(4).Value.ToString()
            TxtGRADE.Text = row.Cells(5).Value.ToString()
            TxtNIP.Enabled = False
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDELETE.Click
        If DataGridView1.SelectedRows.Count > 0 AndAlso MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            BtnNew.PerformClick()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnCLOSE.Click
        Me.Close()
    End Sub

    Private Sub CbJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbJurusan.SelectedIndexChanged
        Dim jurusan As String = CbJurusan.SelectedItem
        CbMatakuliah.Items.Clear()
        Select Case (jurusan)
            Case "Matematika"
                CbMatakuliah.Items.Add("Matematika Dasar")
                CbMatakuliah.Items.Add("Matematika Diskrit")
                CbMatakuliah.Items.Add("Aljabar Linear")
            Case "Kimia"
                CbMatakuliah.Items.Add("Kimia Dasar")
                CbMatakuliah.Items.Add("Kimia Standar")
                CbMatakuliah.Items.Add("Kimia Exstream")
            Case "Biologi"
                CbMatakuliah.Items.Add("Biologi Dasar")
                CbMatakuliah.Items.Add("Biologi Menengah")
                CbMatakuliah.Items.Add("Salah Siapa Biologi ")
            Case "Fisika"
                CbMatakuliah.Items.Add("Fisika Dasar")
                CbMatakuliah.Items.Add("Fisika Aenstain")
                CbMatakuliah.Items.Add("Fisika Ruwet")
            Case "Ilmu Komputer"
                CbMatakuliah.Items.Add("Kecerdasan Buatan")
                CbMatakuliah.Items.Add("IOT")
                CbMatakuliah.Items.Add("Robotika")
        End Select
    End Sub
End Class