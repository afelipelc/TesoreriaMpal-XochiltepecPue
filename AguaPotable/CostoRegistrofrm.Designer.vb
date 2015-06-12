<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostoRegistrofrm
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
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CostoTxt = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(47, 51)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(58, 24)
        Me.AceptarBtn.TabIndex = 2
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CerrarBtn
        '
        Me.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBtn.Location = New System.Drawing.Point(111, 51)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(58, 24)
        Me.CerrarBtn.TabIndex = 3
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Costo de Registro de nueva toma"
        '
        'CostoTxt
        '
        Me.CostoTxt.Location = New System.Drawing.Point(47, 25)
        Me.CostoTxt.Name = "CostoTxt"
        Me.CostoTxt.Size = New System.Drawing.Size(122, 20)
        Me.CostoTxt.TabIndex = 0
        Me.CostoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoRegistrofrm
        '
        Me.AcceptButton = Me.AceptarBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CerrarBtn
        Me.ClientSize = New System.Drawing.Size(178, 84)
        Me.Controls.Add(Me.CostoTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.AceptarBtn)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(186, 116)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(186, 116)
        Me.Name = "CostoRegistrofrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config Registros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CostoTxt As System.Windows.Forms.TextBox
End Class
