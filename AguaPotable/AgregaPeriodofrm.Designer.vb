<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregaPeriodofrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.MesCmb = New System.Windows.Forms.ComboBox
        Me.AnoCmb = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.AceptarBrn = New System.Windows.Forms.Button
        Me.CerrarBrn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pago Hasta"
        '
        'MesCmb
        '
        Me.MesCmb.FormattingEnabled = True
        Me.MesCmb.Items.AddRange(New Object() {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"})
        Me.MesCmb.Location = New System.Drawing.Point(11, 23)
        Me.MesCmb.Name = "MesCmb"
        Me.MesCmb.Size = New System.Drawing.Size(108, 24)
        Me.MesCmb.TabIndex = 0
        '
        'AnoCmb
        '
        Me.AnoCmb.FormattingEnabled = True
        Me.AnoCmb.Location = New System.Drawing.Point(11, 76)
        Me.AnoCmb.Name = "AnoCmb"
        Me.AnoCmb.Size = New System.Drawing.Size(108, 24)
        Me.AnoCmb.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "De"
        '
        'AceptarBrn
        '
        Me.AceptarBrn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AceptarBrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarBrn.Location = New System.Drawing.Point(9, 108)
        Me.AceptarBrn.Name = "AceptarBrn"
        Me.AceptarBrn.Size = New System.Drawing.Size(51, 25)
        Me.AceptarBrn.TabIndex = 2
        Me.AceptarBrn.Text = "OK"
        Me.AceptarBrn.UseVisualStyleBackColor = True
        '
        'CerrarBrn
        '
        Me.CerrarBrn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CerrarBrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarBrn.Location = New System.Drawing.Point(66, 108)
        Me.CerrarBrn.Name = "CerrarBrn"
        Me.CerrarBrn.Size = New System.Drawing.Size(53, 25)
        Me.CerrarBrn.TabIndex = 3
        Me.CerrarBrn.Text = "Cancel"
        Me.CerrarBrn.UseVisualStyleBackColor = True
        '
        'AgregaPeriodofrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(126, 142)
        Me.Controls.Add(Me.AceptarBrn)
        Me.Controls.Add(Me.AnoCmb)
        Me.Controls.Add(Me.MesCmb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CerrarBrn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AgregaPeriodofrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents AnoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AceptarBrn As System.Windows.Forms.Button
    Friend WithEvents CerrarBrn As System.Windows.Forms.Button
End Class
