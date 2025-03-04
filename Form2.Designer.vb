<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Lblnama = New System.Windows.Forms.Label()
        Me.Lblmatakuliah = New System.Windows.Forms.Label()
        Me.Lbljurusan = New System.Windows.Forms.Label()
        Me.Txtnama = New System.Windows.Forms.TextBox()
        Me.Txtmatakuliah = New System.Windows.Forms.TextBox()
        Me.Txtjurusan = New System.Windows.Forms.TextBox()
        Me.Btnprocess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lblnama
        '
        Me.Lblnama.AutoSize = True
        Me.Lblnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnama.Location = New System.Drawing.Point(100, 36)
        Me.Lblnama.Name = "Lblnama"
        Me.Lblnama.Size = New System.Drawing.Size(81, 29)
        Me.Lblnama.TabIndex = 0
        Me.Lblnama.Text = "Nama"
        '
        'Lblmatakuliah
        '
        Me.Lblmatakuliah.AutoSize = True
        Me.Lblmatakuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmatakuliah.Location = New System.Drawing.Point(32, 165)
        Me.Lblmatakuliah.Name = "Lblmatakuliah"
        Me.Lblmatakuliah.Size = New System.Drawing.Size(149, 29)
        Me.Lblmatakuliah.TabIndex = 1
        Me.Lblmatakuliah.Text = "Mata Kuliah"
        '
        'Lbljurusan
        '
        Me.Lbljurusan.AutoSize = True
        Me.Lbljurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbljurusan.Location = New System.Drawing.Point(77, 100)
        Me.Lbljurusan.Name = "Lbljurusan"
        Me.Lbljurusan.Size = New System.Drawing.Size(104, 29)
        Me.Lbljurusan.TabIndex = 2
        Me.Lbljurusan.Text = "Jurusan"
        '
        'Txtnama
        '
        Me.Txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnama.Location = New System.Drawing.Point(198, 31)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(342, 34)
        Me.Txtnama.TabIndex = 3
        '
        'Txtmatakuliah
        '
        Me.Txtmatakuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmatakuliah.Location = New System.Drawing.Point(198, 160)
        Me.Txtmatakuliah.Name = "Txtmatakuliah"
        Me.Txtmatakuliah.Size = New System.Drawing.Size(342, 34)
        Me.Txtmatakuliah.TabIndex = 4
        '
        'Txtjurusan
        '
        Me.Txtjurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtjurusan.Location = New System.Drawing.Point(198, 95)
        Me.Txtjurusan.Name = "Txtjurusan"
        Me.Txtjurusan.Size = New System.Drawing.Size(342, 34)
        Me.Txtjurusan.TabIndex = 5
        '
        'Btnprocess
        '
        Me.Btnprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprocess.Location = New System.Drawing.Point(276, 253)
        Me.Btnprocess.Name = "Btnprocess"
        Me.Btnprocess.Size = New System.Drawing.Size(138, 36)
        Me.Btnprocess.TabIndex = 6
        Me.Btnprocess.Text = "Process"
        Me.Btnprocess.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 508)
        Me.Controls.Add(Me.Btnprocess)
        Me.Controls.Add(Me.Txtjurusan)
        Me.Controls.Add(Me.Txtmatakuliah)
        Me.Controls.Add(Me.Txtnama)
        Me.Controls.Add(Me.Lbljurusan)
        Me.Controls.Add(Me.Lblmatakuliah)
        Me.Controls.Add(Me.Lblnama)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblnama As System.Windows.Forms.Label
    Friend WithEvents Lblmatakuliah As System.Windows.Forms.Label
    Friend WithEvents Lbljurusan As System.Windows.Forms.Label
    Friend WithEvents Txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Txtmatakuliah As System.Windows.Forms.TextBox
    Friend WithEvents Txtjurusan As System.Windows.Forms.TextBox
    Friend WithEvents Btnprocess As System.Windows.Forms.Button
End Class
