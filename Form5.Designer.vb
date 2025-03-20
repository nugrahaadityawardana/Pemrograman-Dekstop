<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.LblNIP = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNip = New System.Windows.Forms.TextBox()
        Me.RBtn_Laki = New System.Windows.Forms.RadioButton()
        Me.RBtn_Perempuan = New System.Windows.Forms.RadioButton()
        Me.LblJurusan = New System.Windows.Forms.Label()
        Me.LblNilai = New System.Windows.Forms.Label()
        Me.LblTugas = New System.Windows.Forms.Label()
        Me.TxtTugas = New System.Windows.Forms.TextBox()
        Me.LblUTS = New System.Windows.Forms.Label()
        Me.LblUAS = New System.Windows.Forms.Label()
        Me.TxtUTS = New System.Windows.Forms.TextBox()
        Me.TxtUAS = New System.Windows.Forms.TextBox()
        Me.TxtGRADE = New System.Windows.Forms.TextBox()
        Me.BtnNEW = New System.Windows.Forms.Button()
        Me.BtnSAVE = New System.Windows.Forms.Button()
        Me.BtnDELETE = New System.Windows.Forms.Button()
        Me.BtnCLOSE = New System.Windows.Forms.Button()
        Me.CbJurusan = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LblMatakuliah = New System.Windows.Forms.Label()
        Me.CbMatakuliah = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNIP
        '
        Me.LblNIP.AutoSize = True
        Me.LblNIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNIP.Location = New System.Drawing.Point(12, 9)
        Me.LblNIP.Name = "LblNIP"
        Me.LblNIP.Size = New System.Drawing.Size(56, 29)
        Me.LblNIP.TabIndex = 3
        Me.LblNIP.Text = "NIP"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(12, 54)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(81, 29)
        Me.LblNama.TabIndex = 4
        Me.LblNama.Text = "Nama"
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNama.Location = New System.Drawing.Point(145, 54)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(342, 34)
        Me.TxtNama.TabIndex = 8
        '
        'TxtNip
        '
        Me.TxtNip.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNip.Location = New System.Drawing.Point(145, 6)
        Me.TxtNip.Name = "TxtNip"
        Me.TxtNip.Size = New System.Drawing.Size(342, 34)
        Me.TxtNip.TabIndex = 9
        '
        'RBtn_Laki
        '
        Me.RBtn_Laki.AutoSize = True
        Me.RBtn_Laki.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtn_Laki.Location = New System.Drawing.Point(168, 111)
        Me.RBtn_Laki.Name = "RBtn_Laki"
        Me.RBtn_Laki.Size = New System.Drawing.Size(92, 24)
        Me.RBtn_Laki.TabIndex = 11
        Me.RBtn_Laki.TabStop = True
        Me.RBtn_Laki.Text = "Laki-laki"
        Me.RBtn_Laki.UseVisualStyleBackColor = True
        '
        'RBtn_Perempuan
        '
        Me.RBtn_Perempuan.AutoSize = True
        Me.RBtn_Perempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtn_Perempuan.Location = New System.Drawing.Point(341, 111)
        Me.RBtn_Perempuan.Name = "RBtn_Perempuan"
        Me.RBtn_Perempuan.Size = New System.Drawing.Size(115, 24)
        Me.RBtn_Perempuan.TabIndex = 12
        Me.RBtn_Perempuan.TabStop = True
        Me.RBtn_Perempuan.Text = "Perempuan"
        Me.RBtn_Perempuan.UseVisualStyleBackColor = True
        '
        'LblJurusan
        '
        Me.LblJurusan.AutoSize = True
        Me.LblJurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJurusan.Location = New System.Drawing.Point(12, 173)
        Me.LblJurusan.Name = "LblJurusan"
        Me.LblJurusan.Size = New System.Drawing.Size(104, 29)
        Me.LblJurusan.TabIndex = 17
        Me.LblJurusan.Text = "Jurusan"
        '
        'LblNilai
        '
        Me.LblNilai.AutoSize = True
        Me.LblNilai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNilai.Location = New System.Drawing.Point(14, 295)
        Me.LblNilai.Name = "LblNilai"
        Me.LblNilai.Size = New System.Drawing.Size(54, 25)
        Me.LblNilai.TabIndex = 19
        Me.LblNilai.Text = "Nilai"
        '
        'LblTugas
        '
        Me.LblTugas.AutoSize = True
        Me.LblTugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTugas.Location = New System.Drawing.Point(93, 295)
        Me.LblTugas.Name = "LblTugas"
        Me.LblTugas.Size = New System.Drawing.Size(73, 25)
        Me.LblTugas.TabIndex = 20
        Me.LblTugas.Text = "Tugas"
        '
        'TxtTugas
        '
        Me.TxtTugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTugas.Location = New System.Drawing.Point(168, 289)
        Me.TxtTugas.Name = "TxtTugas"
        Me.TxtTugas.Size = New System.Drawing.Size(118, 34)
        Me.TxtTugas.TabIndex = 21
        '
        'LblUTS
        '
        Me.LblUTS.AutoSize = True
        Me.LblUTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUTS.Location = New System.Drawing.Point(301, 295)
        Me.LblUTS.Name = "LblUTS"
        Me.LblUTS.Size = New System.Drawing.Size(56, 25)
        Me.LblUTS.TabIndex = 22
        Me.LblUTS.Text = "UTS"
        '
        'LblUAS
        '
        Me.LblUAS.AutoSize = True
        Me.LblUAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUAS.Location = New System.Drawing.Point(504, 295)
        Me.LblUAS.Name = "LblUAS"
        Me.LblUAS.Size = New System.Drawing.Size(57, 25)
        Me.LblUAS.TabIndex = 23
        Me.LblUAS.Text = "UAS"
        '
        'TxtUTS
        '
        Me.TxtUTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUTS.Location = New System.Drawing.Point(363, 289)
        Me.TxtUTS.Name = "TxtUTS"
        Me.TxtUTS.Size = New System.Drawing.Size(118, 34)
        Me.TxtUTS.TabIndex = 24
        '
        'TxtUAS
        '
        Me.TxtUAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUAS.Location = New System.Drawing.Point(583, 289)
        Me.TxtUAS.Name = "TxtUAS"
        Me.TxtUAS.Size = New System.Drawing.Size(118, 34)
        Me.TxtUAS.TabIndex = 25
        '
        'TxtGRADE
        '
        Me.TxtGRADE.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGRADE.Location = New System.Drawing.Point(793, 289)
        Me.TxtGRADE.Name = "TxtGRADE"
        Me.TxtGRADE.Size = New System.Drawing.Size(118, 34)
        Me.TxtGRADE.TabIndex = 26
        Me.TxtGRADE.Text = " -GRADE-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnNEW
        '
        Me.BtnNEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNEW.Location = New System.Drawing.Point(22, 365)
        Me.BtnNEW.Name = "BtnNEW"
        Me.BtnNEW.Size = New System.Drawing.Size(101, 40)
        Me.BtnNEW.TabIndex = 27
        Me.BtnNEW.Text = "NEW"
        Me.BtnNEW.UseVisualStyleBackColor = True
        '
        'BtnSAVE
        '
        Me.BtnSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSAVE.Location = New System.Drawing.Point(185, 365)
        Me.BtnSAVE.Name = "BtnSAVE"
        Me.BtnSAVE.Size = New System.Drawing.Size(101, 40)
        Me.BtnSAVE.TabIndex = 28
        Me.BtnSAVE.Text = "SAVE"
        Me.BtnSAVE.UseVisualStyleBackColor = True
        '
        'BtnDELETE
        '
        Me.BtnDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDELETE.Location = New System.Drawing.Point(341, 365)
        Me.BtnDELETE.Name = "BtnDELETE"
        Me.BtnDELETE.Size = New System.Drawing.Size(195, 40)
        Me.BtnDELETE.TabIndex = 29
        Me.BtnDELETE.Text = "DELETE"
        Me.BtnDELETE.UseVisualStyleBackColor = True
        '
        'BtnCLOSE
        '
        Me.BtnCLOSE.BackColor = System.Drawing.Color.Red
        Me.BtnCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCLOSE.Location = New System.Drawing.Point(583, 365)
        Me.BtnCLOSE.Name = "BtnCLOSE"
        Me.BtnCLOSE.Size = New System.Drawing.Size(373, 40)
        Me.BtnCLOSE.TabIndex = 30
        Me.BtnCLOSE.Text = "CLOSE"
        Me.BtnCLOSE.UseVisualStyleBackColor = False
        '
        'CbJurusan
        '
        Me.CbJurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbJurusan.FormattingEnabled = True
        Me.CbJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.CbJurusan.Location = New System.Drawing.Point(145, 165)
        Me.CbJurusan.Name = "CbJurusan"
        Me.CbJurusan.Size = New System.Drawing.Size(342, 37)
        Me.CbJurusan.TabIndex = 31
        Me.CbJurusan.Text = "Matematika"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 411)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1169, 250)
        Me.DataGridView1.TabIndex = 32
        '
        'LblMatakuliah
        '
        Me.LblMatakuliah.AutoSize = True
        Me.LblMatakuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMatakuliah.Location = New System.Drawing.Point(-2, 224)
        Me.LblMatakuliah.Name = "LblMatakuliah"
        Me.LblMatakuliah.Size = New System.Drawing.Size(142, 29)
        Me.LblMatakuliah.TabIndex = 33
        Me.LblMatakuliah.Text = "MataKuliah"
        '
        'CbMatakuliah
        '
        Me.CbMatakuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMatakuliah.FormattingEnabled = True
        Me.CbMatakuliah.Location = New System.Drawing.Point(146, 216)
        Me.CbMatakuliah.Name = "CbMatakuliah"
        Me.CbMatakuliah.Size = New System.Drawing.Size(342, 37)
        Me.CbMatakuliah.TabIndex = 34
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 660)
        Me.Controls.Add(Me.CbMatakuliah)
        Me.Controls.Add(Me.LblMatakuliah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CbJurusan)
        Me.Controls.Add(Me.BtnCLOSE)
        Me.Controls.Add(Me.BtnDELETE)
        Me.Controls.Add(Me.BtnSAVE)
        Me.Controls.Add(Me.BtnNEW)
        Me.Controls.Add(Me.TxtGRADE)
        Me.Controls.Add(Me.TxtUAS)
        Me.Controls.Add(Me.TxtUTS)
        Me.Controls.Add(Me.LblUAS)
        Me.Controls.Add(Me.LblUTS)
        Me.Controls.Add(Me.TxtTugas)
        Me.Controls.Add(Me.LblTugas)
        Me.Controls.Add(Me.LblNilai)
        Me.Controls.Add(Me.LblJurusan)
        Me.Controls.Add(Me.RBtn_Perempuan)
        Me.Controls.Add(Me.RBtn_Laki)
        Me.Controls.Add(Me.TxtNip)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblNIP)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNIP As System.Windows.Forms.Label
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtNip As System.Windows.Forms.TextBox
    Friend WithEvents RBtn_Laki As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn_Perempuan As System.Windows.Forms.RadioButton
    Friend WithEvents LblJurusan As System.Windows.Forms.Label
    Friend WithEvents LblNilai As System.Windows.Forms.Label
    Friend WithEvents LblTugas As System.Windows.Forms.Label
    Friend WithEvents TxtTugas As System.Windows.Forms.TextBox
    Friend WithEvents LblUTS As System.Windows.Forms.Label
    Friend WithEvents LblUAS As System.Windows.Forms.Label
    Friend WithEvents TxtUTS As System.Windows.Forms.TextBox
    Friend WithEvents TxtUAS As System.Windows.Forms.TextBox
    Friend WithEvents TxtGRADE As System.Windows.Forms.TextBox
    Friend WithEvents BtnNEW As System.Windows.Forms.Button
    Friend WithEvents BtnSAVE As System.Windows.Forms.Button
    Friend WithEvents BtnDELETE As System.Windows.Forms.Button
    Friend WithEvents BtnCLOSE As System.Windows.Forms.Button
    Friend WithEvents CbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LblMatakuliah As System.Windows.Forms.Label
    Friend WithEvents CbMatakuliah As System.Windows.Forms.ComboBox
End Class
