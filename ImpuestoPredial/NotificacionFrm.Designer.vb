<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificacionFrm
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
        Me.NotificacionPpv = New System.Windows.Forms.PrintPreviewControl
        Me.NotificacionPD = New System.Drawing.Printing.PrintDocument
        Me.ImprimirPDlg = New System.Windows.Forms.PrintDialog
        Me.Imprimirbrn = New System.Windows.Forms.Button
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'NotificacionPpv
        '
        Me.NotificacionPpv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotificacionPpv.AutoZoom = False
        Me.NotificacionPpv.Document = Me.NotificacionPD
        Me.NotificacionPpv.Location = New System.Drawing.Point(0, 0)
        Me.NotificacionPpv.Name = "NotificacionPpv"
        Me.NotificacionPpv.Size = New System.Drawing.Size(859, 486)
        Me.NotificacionPpv.TabIndex = 0
        Me.NotificacionPpv.Zoom = 1
        '
        'NotificacionPD
        '
        '
        'ImprimirPDlg
        '
        Me.ImprimirPDlg.UseEXDialog = True
        '
        'Imprimirbrn
        '
        Me.Imprimirbrn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Imprimirbrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimirbrn.Location = New System.Drawing.Point(707, 492)
        Me.Imprimirbrn.Name = "Imprimirbrn"
        Me.Imprimirbrn.Size = New System.Drawing.Size(67, 28)
        Me.Imprimirbrn.TabIndex = 3
        Me.Imprimirbrn.Text = "Imprimir"
        Me.Imprimirbrn.UseVisualStyleBackColor = True
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarBtn.Location = New System.Drawing.Point(780, 492)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(67, 28)
        Me.CerrarBtn.TabIndex = 2
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'NotificacionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 528)
        Me.Controls.Add(Me.Imprimirbrn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.NotificacionPpv)
        Me.Name = "NotificacionFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOTIFICACIÓN DE ADEUDO DE IMPUESTO PREDIAL"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotificacionPpv As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents NotificacionPD As System.Drawing.Printing.PrintDocument
    Friend WithEvents ImprimirPDlg As System.Windows.Forms.PrintDialog
    Friend WithEvents Imprimirbrn As System.Windows.Forms.Button
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
End Class
