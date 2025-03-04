<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Lbljurusan = New System.Windows.Forms.Label()
        Me.Lblfakultas = New System.Windows.Forms.Label()
        Me.Lblnama = New System.Windows.Forms.Label()
        Me.Txtnama = New System.Windows.Forms.TextBox()
        Me.TxtNIP = New System.Windows.Forms.TextBox()
        Me.CmbBoxFakultas = New System.Windows.Forms.ComboBox()
        Me.CmmbBoxJurusan = New System.Windows.Forms.ComboBox()
        Me.Btnprocess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNIP
        '
        Me.LblNIP.AutoSize = True
        Me.LblNIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNIP.Location = New System.Drawing.Point(34, 28)
        Me.LblNIP.Name = "LblNIP"
        Me.LblNIP.Size = New System.Drawing.Size(56, 29)
        Me.LblNIP.TabIndex = 1
        Me.LblNIP.Text = "NIP"
        '
        'Lbljurusan
        '
        Me.Lbljurusan.AutoSize = True
        Me.Lbljurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbljurusan.Location = New System.Drawing.Point(34, 174)
        Me.Lbljurusan.Name = "Lbljurusan"
        Me.Lbljurusan.Size = New System.Drawing.Size(104, 29)
        Me.Lbljurusan.TabIndex = 2
        Me.Lbljurusan.Text = "Jurusan"
        '
        'Lblfakultas
        '
        Me.Lblfakultas.AutoSize = True
        Me.Lblfakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfakultas.Location = New System.Drawing.Point(34, 122)
        Me.Lblfakultas.Name = "Lblfakultas"
        Me.Lblfakultas.Size = New System.Drawing.Size(111, 29)
        Me.Lblfakultas.TabIndex = 3
        Me.Lblfakultas.Text = "Fakultas"
        '
        'Lblnama
        '
        Me.Lblnama.AutoSize = True
        Me.Lblnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnama.Location = New System.Drawing.Point(34, 73)
        Me.Lblnama.Name = "Lblnama"
        Me.Lblnama.Size = New System.Drawing.Size(81, 29)
        Me.Lblnama.TabIndex = 4
        Me.Lblnama.Text = "Nama"
        '
        'Txtnama
        '
        Me.Txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnama.Location = New System.Drawing.Point(190, 68)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(342, 34)
        Me.Txtnama.TabIndex = 5
        '
        'TxtNIP
        '
        Me.TxtNIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNIP.Location = New System.Drawing.Point(190, 23)
        Me.TxtNIP.Name = "TxtNIP"
        Me.TxtNIP.Size = New System.Drawing.Size(342, 34)
        Me.TxtNIP.TabIndex = 6
        '
        'CmbBoxFakultas
        '
        Me.CmbBoxFakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBoxFakultas.FormattingEnabled = True
        Me.CmbBoxFakultas.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.CmbBoxFakultas.Location = New System.Drawing.Point(190, 114)
        Me.CmbBoxFakultas.Name = "CmbBoxFakultas"
        Me.CmbBoxFakultas.Size = New System.Drawing.Size(342, 37)
        Me.CmbBoxFakultas.TabIndex = 7
        Me.CmbBoxFakultas.Text = "FMIPA"
        '
        'CmmbBoxJurusan
        '
        Me.CmmbBoxJurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmmbBoxJurusan.FormattingEnabled = True
        Me.CmmbBoxJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.CmmbBoxJurusan.Location = New System.Drawing.Point(190, 166)
        Me.CmmbBoxJurusan.Name = "CmmbBoxJurusan"
        Me.CmmbBoxJurusan.Size = New System.Drawing.Size(342, 37)
        Me.CmmbBoxJurusan.TabIndex = 8
        Me.CmmbBoxJurusan.Text = "Matematika"
        '
        'Btnprocess
        '
        Me.Btnprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprocess.Location = New System.Drawing.Point(251, 247)
        Me.Btnprocess.Name = "Btnprocess"
        Me.Btnprocess.Size = New System.Drawing.Size(138, 36)
        Me.Btnprocess.TabIndex = 9
        Me.Btnprocess.Text = "Process"
        Me.Btnprocess.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 428)
        Me.Controls.Add(Me.Btnprocess)
        Me.Controls.Add(Me.CmmbBoxJurusan)
        Me.Controls.Add(Me.CmbBoxFakultas)
        Me.Controls.Add(Me.TxtNIP)
        Me.Controls.Add(Me.Txtnama)
        Me.Controls.Add(Me.Lblnama)
        Me.Controls.Add(Me.Lblfakultas)
        Me.Controls.Add(Me.Lbljurusan)
        Me.Controls.Add(Me.LblNIP)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNIP As System.Windows.Forms.Label
    Friend WithEvents Lbljurusan As System.Windows.Forms.Label
    Friend WithEvents Lblfakultas As System.Windows.Forms.Label
    Friend WithEvents Lblnama As System.Windows.Forms.Label
    Friend WithEvents Txtnama As System.Windows.Forms.TextBox
    Friend WithEvents TxtNIP As System.Windows.Forms.TextBox
    Friend WithEvents CmbBoxFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents CmmbBoxJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Btnprocess As System.Windows.Forms.Button
End Class
