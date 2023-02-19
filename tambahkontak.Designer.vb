<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambahkontak
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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.lblKontak = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Location = New System.Drawing.Point(250, 35)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(346, 26)
        Me.txtNama.TabIndex = 3
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(83, 46)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(55, 20)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'txtNomor
        '
        Me.txtNomor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomor.Location = New System.Drawing.Point(250, 94)
        Me.txtNomor.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(196, 26)
        Me.txtNomor.TabIndex = 5
        '
        'lblKontak
        '
        Me.lblKontak.AutoSize = True
        Me.lblKontak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKontak.Location = New System.Drawing.Point(83, 104)
        Me.lblKontak.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblKontak.Name = "lblKontak"
        Me.lblKontak.Size = New System.Drawing.Size(122, 20)
        Me.lblKontak.TabIndex = 4
        Me.lblKontak.Text = "Nomor Kontak"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(513, 143)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(83, 30)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'tambahkontak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 204)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtNomor)
        Me.Controls.Add(Me.lblKontak)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblNama)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "tambahkontak"
        Me.Text = "Tambah Kontak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents lblKontak As Label
    Friend WithEvents btnSimpan As Button
End Class
