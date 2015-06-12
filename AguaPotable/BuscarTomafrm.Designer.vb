<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarTomafrm
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
        Me.TituloLbl = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.BuscaBombreTxt = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TituloLbl
        '
        Me.TituloLbl.Location = New System.Drawing.Point(5, 3)
        Me.TituloLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TituloLbl.Name = "TituloLbl"
        Me.TituloLbl.Size = New System.Drawing.Size(217, 20)
        Me.TituloLbl.TabIndex = 0
        Me.TituloLbl.Text = "Nombre de Titular"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBtn.Location = New System.Drawing.Point(153, 4)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(28, 19)
        Me.CerrarBtn.TabIndex = 2
        Me.CerrarBtn.Text = "x"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'BuscaBombreTxt
        '
        Me.BuscaBombreTxt.Location = New System.Drawing.Point(7, 29)
        Me.BuscaBombreTxt.Name = "BuscaBombreTxt"
        Me.BuscaBombreTxt.Size = New System.Drawing.Size(215, 26)
        Me.BuscaBombreTxt.TabIndex = 3
        '
        'BuscarTomafrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.CerrarBtn
        Me.ClientSize = New System.Drawing.Size(229, 65)
        Me.Controls.Add(Me.BuscaBombreTxt)
        Me.Controls.Add(Me.TituloLbl)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "BuscarTomafrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarToma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TituloLbl As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents BuscaBombreTxt As System.Windows.Forms.TextBox
    'Friend WithEvents BuscaNumTxtn As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
