<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.TxtNIP = New System.Windows.Forms.TextBox()
        Me.Lblnama = New System.Windows.Forms.Label()
        Me.Txtnama = New System.Windows.Forms.TextBox()
        Me.RBtn_Laki = New System.Windows.Forms.RadioButton()
        Me.RBtn_Perempuan = New System.Windows.Forms.RadioButton()
        Me.Lblfakultas = New System.Windows.Forms.Label()
        Me.Lbljurusan = New System.Windows.Forms.Label()
        Me.CmbBoxFakultas = New System.Windows.Forms.ComboBox()
        Me.CmmbBoxJurusan = New System.Windows.Forms.ComboBox()
        Me.Btnprocess = New System.Windows.Forms.Button()
        Me.LblNilai = New System.Windows.Forms.Label()
        Me.TxtTugas = New System.Windows.Forms.TextBox()
        Me.LblTugas = New System.Windows.Forms.Label()
        Me.LblUAS = New System.Windows.Forms.Label()
        Me.LblUTS = New System.Windows.Forms.Label()
        Me.TxtUAS = New System.Windows.Forms.TextBox()
        Me.TxtUTS = New System.Windows.Forms.TextBox()
        Me.TxtGRADE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblNIP
        '
        Me.LblNIP.AutoSize = True
        Me.LblNIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNIP.Location = New System.Drawing.Point(40, 30)
        Me.LblNIP.Name = "LblNIP"
        Me.LblNIP.Size = New System.Drawing.Size(56, 29)
        Me.LblNIP.TabIndex = 2
        Me.LblNIP.Text = "NIP"
        '
        'TxtNIP
        '
        Me.TxtNIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNIP.Location = New System.Drawing.Point(157, 30)
        Me.TxtNIP.Name = "TxtNIP"
        Me.TxtNIP.Size = New System.Drawing.Size(342, 34)
        Me.TxtNIP.TabIndex = 7
        '
        'Lblnama
        '
        Me.Lblnama.AutoSize = True
        Me.Lblnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnama.Location = New System.Drawing.Point(40, 92)
        Me.Lblnama.Name = "Lblnama"
        Me.Lblnama.Size = New System.Drawing.Size(81, 29)
        Me.Lblnama.TabIndex = 8
        Me.Lblnama.Text = "Nama"
        '
        'Txtnama
        '
        Me.Txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnama.Location = New System.Drawing.Point(157, 92)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(342, 34)
        Me.Txtnama.TabIndex = 9
        '
        'RBtn_Laki
        '
        Me.RBtn_Laki.AutoSize = True
        Me.RBtn_Laki.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtn_Laki.Location = New System.Drawing.Point(157, 171)
        Me.RBtn_Laki.Name = "RBtn_Laki"
        Me.RBtn_Laki.Size = New System.Drawing.Size(92, 24)
        Me.RBtn_Laki.TabIndex = 10
        Me.RBtn_Laki.TabStop = True
        Me.RBtn_Laki.Text = "Laki-laki"
        Me.RBtn_Laki.UseVisualStyleBackColor = True
        '
        'RBtn_Perempuan
        '
        Me.RBtn_Perempuan.AutoSize = True
        Me.RBtn_Perempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtn_Perempuan.Location = New System.Drawing.Point(374, 171)
        Me.RBtn_Perempuan.Name = "RBtn_Perempuan"
        Me.RBtn_Perempuan.Size = New System.Drawing.Size(115, 24)
        Me.RBtn_Perempuan.TabIndex = 11
        Me.RBtn_Perempuan.TabStop = True
        Me.RBtn_Perempuan.Text = "Perempuan"
        Me.RBtn_Perempuan.UseVisualStyleBackColor = True
        '
        'Lblfakultas
        '
        Me.Lblfakultas.AutoSize = True
        Me.Lblfakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfakultas.Location = New System.Drawing.Point(40, 250)
        Me.Lblfakultas.Name = "Lblfakultas"
        Me.Lblfakultas.Size = New System.Drawing.Size(111, 29)
        Me.Lblfakultas.TabIndex = 12
        Me.Lblfakultas.Text = "Fakultas"
        '
        'Lbljurusan
        '
        Me.Lbljurusan.AutoSize = True
        Me.Lbljurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbljurusan.Location = New System.Drawing.Point(40, 308)
        Me.Lbljurusan.Name = "Lbljurusan"
        Me.Lbljurusan.Size = New System.Drawing.Size(104, 29)
        Me.Lbljurusan.TabIndex = 13
        Me.Lbljurusan.Text = "Jurusan"
        '
        'CmbBoxFakultas
        '
        Me.CmbBoxFakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBoxFakultas.FormattingEnabled = True
        Me.CmbBoxFakultas.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.CmbBoxFakultas.Location = New System.Drawing.Point(157, 250)
        Me.CmbBoxFakultas.Name = "CmbBoxFakultas"
        Me.CmbBoxFakultas.Size = New System.Drawing.Size(342, 37)
        Me.CmbBoxFakultas.TabIndex = 14
        Me.CmbBoxFakultas.Text = "FMIPA"
        '
        'CmmbBoxJurusan
        '
        Me.CmmbBoxJurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmmbBoxJurusan.FormattingEnabled = True
        Me.CmmbBoxJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.CmmbBoxJurusan.Location = New System.Drawing.Point(157, 308)
        Me.CmmbBoxJurusan.Name = "CmmbBoxJurusan"
        Me.CmmbBoxJurusan.Size = New System.Drawing.Size(342, 37)
        Me.CmmbBoxJurusan.TabIndex = 15
        Me.CmmbBoxJurusan.Text = "Matematika"
        '
        'Btnprocess
        '
        Me.Btnprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprocess.Location = New System.Drawing.Point(6, 457)
        Me.Btnprocess.Name = "Btnprocess"
        Me.Btnprocess.Size = New System.Drawing.Size(138, 36)
        Me.Btnprocess.TabIndex = 16
        Me.Btnprocess.Text = "Process"
        Me.Btnprocess.UseVisualStyleBackColor = True
        '
        'LblNilai
        '
        Me.LblNilai.AutoSize = True
        Me.LblNilai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNilai.Location = New System.Drawing.Point(45, 388)
        Me.LblNilai.Name = "LblNilai"
        Me.LblNilai.Size = New System.Drawing.Size(54, 25)
        Me.LblNilai.TabIndex = 17
        Me.LblNilai.Text = "Nilai"
        '
        'TxtTugas
        '
        Me.TxtTugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTugas.Location = New System.Drawing.Point(211, 379)
        Me.TxtTugas.Name = "TxtTugas"
        Me.TxtTugas.Size = New System.Drawing.Size(118, 34)
        Me.TxtTugas.TabIndex = 18
        '
        'LblTugas
        '
        Me.LblTugas.AutoSize = True
        Me.LblTugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTugas.Location = New System.Drawing.Point(132, 385)
        Me.LblTugas.Name = "LblTugas"
        Me.LblTugas.Size = New System.Drawing.Size(73, 25)
        Me.LblTugas.TabIndex = 19
        Me.LblTugas.Text = "Tugas"
        '
        'LblUAS
        '
        Me.LblUAS.AutoSize = True
        Me.LblUAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUAS.Location = New System.Drawing.Point(576, 385)
        Me.LblUAS.Name = "LblUAS"
        Me.LblUAS.Size = New System.Drawing.Size(57, 25)
        Me.LblUAS.TabIndex = 20
        Me.LblUAS.Text = "UAS"
        '
        'LblUTS
        '
        Me.LblUTS.AutoSize = True
        Me.LblUTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUTS.Location = New System.Drawing.Point(353, 385)
        Me.LblUTS.Name = "LblUTS"
        Me.LblUTS.Size = New System.Drawing.Size(56, 25)
        Me.LblUTS.TabIndex = 21
        Me.LblUTS.Text = "UTS"
        '
        'TxtUAS
        '
        Me.TxtUAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUAS.Location = New System.Drawing.Point(655, 379)
        Me.TxtUAS.Name = "TxtUAS"
        Me.TxtUAS.Size = New System.Drawing.Size(118, 34)
        Me.TxtUAS.TabIndex = 22
        '
        'TxtUTS
        '
        Me.TxtUTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUTS.Location = New System.Drawing.Point(432, 379)
        Me.TxtUTS.Name = "TxtUTS"
        Me.TxtUTS.Size = New System.Drawing.Size(118, 34)
        Me.TxtUTS.TabIndex = 23
        '
        'TxtGRADE
        '
        Me.TxtGRADE.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGRADE.Location = New System.Drawing.Point(812, 379)
        Me.TxtGRADE.Name = "TxtGRADE"
        Me.TxtGRADE.Size = New System.Drawing.Size(118, 34)
        Me.TxtGRADE.TabIndex = 24
        Me.TxtGRADE.Text = " -GRADE-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 505)
        Me.Controls.Add(Me.TxtGRADE)
        Me.Controls.Add(Me.TxtUTS)
        Me.Controls.Add(Me.TxtUAS)
        Me.Controls.Add(Me.LblUTS)
        Me.Controls.Add(Me.LblUAS)
        Me.Controls.Add(Me.LblTugas)
        Me.Controls.Add(Me.TxtTugas)
        Me.Controls.Add(Me.LblNilai)
        Me.Controls.Add(Me.Btnprocess)
        Me.Controls.Add(Me.CmmbBoxJurusan)
        Me.Controls.Add(Me.CmbBoxFakultas)
        Me.Controls.Add(Me.Lbljurusan)
        Me.Controls.Add(Me.Lblfakultas)
        Me.Controls.Add(Me.RBtn_Perempuan)
        Me.Controls.Add(Me.RBtn_Laki)
        Me.Controls.Add(Me.Txtnama)
        Me.Controls.Add(Me.Lblnama)
        Me.Controls.Add(Me.TxtNIP)
        Me.Controls.Add(Me.LblNIP)
        Me.Name = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNIP As System.Windows.Forms.Label
    Friend WithEvents TxtNIP As System.Windows.Forms.TextBox
    Friend WithEvents Lblnama As System.Windows.Forms.Label
    Friend WithEvents Txtnama As System.Windows.Forms.TextBox
    Friend WithEvents RBtn_Laki As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn_Perempuan As System.Windows.Forms.RadioButton
    Friend WithEvents Lblfakultas As System.Windows.Forms.Label
    Friend WithEvents Lbljurusan As System.Windows.Forms.Label
    Friend WithEvents CmbBoxFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents CmmbBoxJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Btnprocess As System.Windows.Forms.Button
    Friend WithEvents LblNilai As System.Windows.Forms.Label
    Friend WithEvents TxtTugas As System.Windows.Forms.TextBox
    Friend WithEvents LblTugas As System.Windows.Forms.Label
    Friend WithEvents LblUAS As System.Windows.Forms.Label
    Friend WithEvents LblUTS As System.Windows.Forms.Label
    Friend WithEvents TxtUAS As System.Windows.Forms.TextBox
    Friend WithEvents TxtUTS As System.Windows.Forms.TextBox
    Friend WithEvents TxtGRADE As System.Windows.Forms.TextBox
End Class
