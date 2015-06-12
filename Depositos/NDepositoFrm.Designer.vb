<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NDepositoFrm
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
        Me.CantidadTxt = New System.Windows.Forms.TextBox
        Me.FechaLbl = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.NoFichaTxt = New System.Windows.Forms.TextBox
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.EnCajaLbl = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CuentasCmb = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.NumeroCtaLbl = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CantidadTxt
        '
        Me.CantidadTxt.Location = New System.Drawing.Point(77, 161)
        Me.CantidadTxt.Name = "CantidadTxt"
        Me.CantidadTxt.Size = New System.Drawing.Size(91, 23)
        Me.CantidadTxt.TabIndex = 1
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLbl.Location = New System.Drawing.Point(63, 28)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(94, 17)
        Me.FechaLbl.TabIndex = 4
        Me.FechaLbl.Text = "yyyy-mm-dd"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "No. Ficha:"
        '
        'NoFichaTxt
        '
        Me.NoFichaTxt.Location = New System.Drawing.Point(77, 132)
        Me.NoFichaTxt.Name = "NoFichaTxt"
        Me.NoFichaTxt.Size = New System.Drawing.Size(91, 23)
        Me.NoFichaTxt.TabIndex = 0
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Location = New System.Drawing.Point(89, 190)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(79, 26)
        Me.CancelarBtn.TabIndex = 3
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(14, 190)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(69, 26)
        Me.AceptarBtn.TabIndex = 2
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'EnCajaLbl
        '
        Me.EnCajaLbl.AutoSize = True
        Me.EnCajaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnCajaLbl.Location = New System.Drawing.Point(63, 6)
        Me.EnCajaLbl.Name = "EnCajaLbl"
        Me.EnCajaLbl.Size = New System.Drawing.Size(45, 17)
        Me.EnCajaLbl.TabIndex = 12
        Me.EnCajaLbl.Text = "$ 0.0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "En Caja:"
        '
        'CuentasCmb
        '
        Me.CuentasCmb.FormattingEnabled = True
        Me.CuentasCmb.Location = New System.Drawing.Point(7, 73)
        Me.CuentasCmb.Name = "CuentasCmb"
        Me.CuentasCmb.Size = New System.Drawing.Size(161, 24)
        Me.CuentasCmb.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuenta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "No. de Cta:"
        '
        'NumeroCtaLbl
        '
        Me.NumeroCtaLbl.AutoSize = True
        Me.NumeroCtaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroCtaLbl.Location = New System.Drawing.Point(65, 104)
        Me.NumeroCtaLbl.Name = "NumeroCtaLbl"
        Me.NumeroCtaLbl.Size = New System.Drawing.Size(57, 20)
        Me.NumeroCtaLbl.TabIndex = 2
        Me.NumeroCtaLbl.Text = "--------"
        '
        'NDepositoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(181, 222)
        Me.Controls.Add(Me.CuentasCmb)
        Me.Controls.Add(Me.EnCajaLbl)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NoFichaTxt)
        Me.Controls.Add(Me.CantidadTxt)
        Me.Controls.Add(Me.FechaLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumeroCtaLbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(189, 254)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(189, 254)
        Me.Name = "NDepositoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Deposito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CantidadTxt As System.Windows.Forms.TextBox
    Friend WithEvents FechaLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NoFichaTxt As System.Windows.Forms.TextBox
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents EnCajaLbl As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CuentasCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumeroCtaLbl As System.Windows.Forms.Label
End Class
