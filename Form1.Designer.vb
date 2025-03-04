<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btn_Bagi
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
        Me.Lbl_Nilai1 = New System.Windows.Forms.Label()
        Me.Lbl_Nilai2 = New System.Windows.Forms.Label()
        Me.Txtnilai1 = New System.Windows.Forms.TextBox()
        Me.Txtnilai2 = New System.Windows.Forms.TextBox()
        Me.btn_Perkalian = New System.Windows.Forms.Button()
        Me.btn_Pembagian = New System.Windows.Forms.Button()
        Me.btn_Pengurangan = New System.Windows.Forms.Button()
        Me.btn_Penambahan = New System.Windows.Forms.Button()
        Me.Lbl_Hasil = New System.Windows.Forms.Label()
        Me.Txthasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl_Nilai1
        '
        Me.Lbl_Nilai1.AutoSize = True
        Me.Lbl_Nilai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nilai1.Location = New System.Drawing.Point(51, 100)
        Me.Lbl_Nilai1.Name = "Lbl_Nilai1"
        Me.Lbl_Nilai1.Size = New System.Drawing.Size(81, 29)
        Me.Lbl_Nilai1.TabIndex = 0
        Me.Lbl_Nilai1.Text = "Nilai 1"
        '
        'Lbl_Nilai2
        '
        Me.Lbl_Nilai2.AutoSize = True
        Me.Lbl_Nilai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nilai2.Location = New System.Drawing.Point(51, 147)
        Me.Lbl_Nilai2.Name = "Lbl_Nilai2"
        Me.Lbl_Nilai2.Size = New System.Drawing.Size(81, 29)
        Me.Lbl_Nilai2.TabIndex = 1
        Me.Lbl_Nilai2.Text = "Nilai 2"
        '
        'Txtnilai1
        '
        Me.Txtnilai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnilai1.Location = New System.Drawing.Point(164, 100)
        Me.Txtnilai1.Name = "Txtnilai1"
        Me.Txtnilai1.Size = New System.Drawing.Size(401, 34)
        Me.Txtnilai1.TabIndex = 2
        '
        'Txtnilai2
        '
        Me.Txtnilai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnilai2.Location = New System.Drawing.Point(164, 154)
        Me.Txtnilai2.Name = "Txtnilai2"
        Me.Txtnilai2.Size = New System.Drawing.Size(401, 34)
        Me.Txtnilai2.TabIndex = 3
        '
        'btn_Perkalian
        '
        Me.btn_Perkalian.AccessibleName = ""
        Me.btn_Perkalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Perkalian.Location = New System.Drawing.Point(164, 238)
        Me.btn_Perkalian.Name = "btn_Perkalian"
        Me.btn_Perkalian.Size = New System.Drawing.Size(75, 49)
        Me.btn_Perkalian.TabIndex = 4
        Me.btn_Perkalian.Text = "X"
        Me.btn_Perkalian.UseVisualStyleBackColor = True
        '
        'btn_Pembagian
        '
        Me.btn_Pembagian.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pembagian.Location = New System.Drawing.Point(267, 238)
        Me.btn_Pembagian.Name = "btn_Pembagian"
        Me.btn_Pembagian.Size = New System.Drawing.Size(75, 49)
        Me.btn_Pembagian.TabIndex = 5
        Me.btn_Pembagian.Text = "/"
        Me.btn_Pembagian.UseVisualStyleBackColor = True
        '
        'btn_Pengurangan
        '
        Me.btn_Pengurangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pengurangan.Location = New System.Drawing.Point(362, 238)
        Me.btn_Pengurangan.Name = "btn_Pengurangan"
        Me.btn_Pengurangan.Size = New System.Drawing.Size(75, 49)
        Me.btn_Pengurangan.TabIndex = 6
        Me.btn_Pengurangan.Text = "-"
        Me.btn_Pengurangan.UseVisualStyleBackColor = True
        '
        'btn_Penambahan
        '
        Me.btn_Penambahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Penambahan.Location = New System.Drawing.Point(455, 238)
        Me.btn_Penambahan.Name = "btn_Penambahan"
        Me.btn_Penambahan.Size = New System.Drawing.Size(75, 49)
        Me.btn_Penambahan.TabIndex = 7
        Me.btn_Penambahan.Text = "+"
        Me.btn_Penambahan.UseVisualStyleBackColor = True
        '
        'Lbl_Hasil
        '
        Me.Lbl_Hasil.AutoSize = True
        Me.Lbl_Hasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Hasil.Location = New System.Drawing.Point(51, 333)
        Me.Lbl_Hasil.Name = "Lbl_Hasil"
        Me.Lbl_Hasil.Size = New System.Drawing.Size(80, 29)
        Me.Lbl_Hasil.TabIndex = 8
        Me.Lbl_Hasil.Text = "HASIL"
        '
        'Txthasil
        '
        Me.Txthasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txthasil.Location = New System.Drawing.Point(164, 333)
        Me.Txthasil.Name = "Txthasil"
        Me.Txthasil.Size = New System.Drawing.Size(401, 34)
        Me.Txthasil.TabIndex = 9
        '
        'btn_Bagi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 569)
        Me.Controls.Add(Me.Txthasil)
        Me.Controls.Add(Me.Lbl_Hasil)
        Me.Controls.Add(Me.btn_Penambahan)
        Me.Controls.Add(Me.btn_Pengurangan)
        Me.Controls.Add(Me.btn_Pembagian)
        Me.Controls.Add(Me.btn_Perkalian)
        Me.Controls.Add(Me.Txtnilai2)
        Me.Controls.Add(Me.Txtnilai1)
        Me.Controls.Add(Me.Lbl_Nilai2)
        Me.Controls.Add(Me.Lbl_Nilai1)
        Me.Name = "btn_Bagi"
        Me.Text = "/"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Nilai1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nilai2 As System.Windows.Forms.Label
    Friend WithEvents Txtnilai1 As System.Windows.Forms.TextBox
    Friend WithEvents Txtnilai2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Perkalian As System.Windows.Forms.Button
    Friend WithEvents btn_Pembagian As System.Windows.Forms.Button
    Friend WithEvents btn_Pengurangan As System.Windows.Forms.Button
    Friend WithEvents btn_Penambahan As System.Windows.Forms.Button
    Friend WithEvents Lbl_Hasil As System.Windows.Forms.Label
    Friend WithEvents Txthasil As System.Windows.Forms.TextBox

End Class
