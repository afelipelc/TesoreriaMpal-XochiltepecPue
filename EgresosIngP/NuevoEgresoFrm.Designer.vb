<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoEgresoFrm
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
        Me.FechaLbl = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CantidadTxt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ECajaRbtn = New System.Windows.Forms.RadioButton
        Me.ERetRbtn = New System.Windows.Forms.RadioButton
        Me.NoChequeTxt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DestinoTxt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.AnombreDeTxt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CargoTxt = New System.Windows.Forms.TextBox
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.EnBancoLbl = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.EnCajaLbl = New System.Windows.Forms.Label
        Me.CuentasCmb = New System.Windows.Forms.ComboBox
        Me.NumeroCtaLbl = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.SaldoLbl = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLbl.Location = New System.Drawing.Point(102, 58)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(94, 17)
        Me.FechaLbl.TabIndex = 0
        Me.FechaLbl.Text = "yyyy-mm-dd"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cantidad:"
        '
        'CantidadTxt
        '
        Me.CantidadTxt.Location = New System.Drawing.Point(103, 222)
        Me.CantidadTxt.Name = "CantidadTxt"
        Me.CantidadTxt.Size = New System.Drawing.Size(91, 23)
        Me.CantidadTxt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Origen:"
        '
        'ECajaRbtn
        '
        Me.ECajaRbtn.AutoSize = True
        Me.ECajaRbtn.Location = New System.Drawing.Point(103, 82)
        Me.ECajaRbtn.Name = "ECajaRbtn"
        Me.ECajaRbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ECajaRbtn.Size = New System.Drawing.Size(80, 21)
        Me.ECajaRbtn.TabIndex = 0
        Me.ECajaRbtn.TabStop = True
        Me.ECajaRbtn.Text = "De_Caja"
        Me.ECajaRbtn.UseVisualStyleBackColor = True
        '
        'ERetRbtn
        '
        Me.ERetRbtn.AutoSize = True
        Me.ERetRbtn.Location = New System.Drawing.Point(192, 82)
        Me.ERetRbtn.Name = "ERetRbtn"
        Me.ERetRbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ERetRbtn.Size = New System.Drawing.Size(64, 21)
        Me.ERetRbtn.TabIndex = 1
        Me.ERetRbtn.TabStop = True
        Me.ERetRbtn.Text = "Retiro"
        Me.ERetRbtn.UseVisualStyleBackColor = True
        '
        'NoChequeTxt
        '
        Me.NoChequeTxt.Location = New System.Drawing.Point(103, 193)
        Me.NoChequeTxt.Name = "NoChequeTxt"
        Me.NoChequeTxt.Size = New System.Drawing.Size(93, 23)
        Me.NoChequeTxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cuenta:"
        '
        'DestinoTxt
        '
        Me.DestinoTxt.Location = New System.Drawing.Point(103, 251)
        Me.DestinoTxt.Multiline = True
        Me.DestinoTxt.Name = "DestinoTxt"
        Me.DestinoTxt.Size = New System.Drawing.Size(178, 49)
        Me.DestinoTxt.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 43)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Destino del gasto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnombreDeTxt
        '
        Me.AnombreDeTxt.Location = New System.Drawing.Point(103, 306)
        Me.AnombreDeTxt.Name = "AnombreDeTxt"
        Me.AnombreDeTxt.Size = New System.Drawing.Size(178, 23)
        Me.AnombreDeTxt.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "A Nombre de:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Cargo:"
        '
        'CargoTxt
        '
        Me.CargoTxt.Location = New System.Drawing.Point(103, 335)
        Me.CargoTxt.Name = "CargoTxt"
        Me.CargoTxt.Size = New System.Drawing.Size(178, 23)
        Me.CargoTxt.TabIndex = 7
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(127, 370)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(69, 26)
        Me.AceptarBtn.TabIndex = 8
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Location = New System.Drawing.Point(202, 370)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(79, 26)
        Me.CancelarBtn.TabIndex = 9
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total en Banco:"
        '
        'EnBancoLbl
        '
        Me.EnBancoLbl.AutoSize = True
        Me.EnBancoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnBancoLbl.Location = New System.Drawing.Point(138, 32)
        Me.EnBancoLbl.Name = "EnBancoLbl"
        Me.EnBancoLbl.Size = New System.Drawing.Size(45, 17)
        Me.EnBancoLbl.TabIndex = 0
        Me.EnBancoLbl.Text = "$ 0.0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total en Caja:"
        '
        'EnCajaLbl
        '
        Me.EnCajaLbl.AutoSize = True
        Me.EnCajaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnCajaLbl.Location = New System.Drawing.Point(138, 8)
        Me.EnCajaLbl.Name = "EnCajaLbl"
        Me.EnCajaLbl.Size = New System.Drawing.Size(45, 17)
        Me.EnCajaLbl.TabIndex = 0
        Me.EnCajaLbl.Text = "$ 0.0"
        '
        'CuentasCmb
        '
        Me.CuentasCmb.FormattingEnabled = True
        Me.CuentasCmb.Location = New System.Drawing.Point(78, 109)
        Me.CuentasCmb.Name = "CuentasCmb"
        Me.CuentasCmb.Size = New System.Drawing.Size(178, 24)
        Me.CuentasCmb.TabIndex = 2
        '
        'NumeroCtaLbl
        '
        Me.NumeroCtaLbl.AutoSize = True
        Me.NumeroCtaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroCtaLbl.Location = New System.Drawing.Point(74, 138)
        Me.NumeroCtaLbl.Name = "NumeroCtaLbl"
        Me.NumeroCtaLbl.Size = New System.Drawing.Size(57, 20)
        Me.NumeroCtaLbl.TabIndex = 15
        Me.NumeroCtaLbl.Text = "--------"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "No. Cta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "No. Cheque:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Saldo:"
        '
        'SaldoLbl
        '
        Me.SaldoLbl.AutoSize = True
        Me.SaldoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoLbl.Location = New System.Drawing.Point(75, 165)
        Me.SaldoLbl.Name = "SaldoLbl"
        Me.SaldoLbl.Size = New System.Drawing.Size(45, 17)
        Me.SaldoLbl.TabIndex = 0
        Me.SaldoLbl.Text = "$ 0.0"
        '
        'NuevoEgresoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(293, 400)
        Me.Controls.Add(Me.SaldoLbl)
        Me.Controls.Add(Me.CuentasCmb)
        Me.Controls.Add(Me.NumeroCtaLbl)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.ERetRbtn)
        Me.Controls.Add(Me.ECajaRbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DestinoTxt)
        Me.Controls.Add(Me.CargoTxt)
        Me.Controls.Add(Me.AnombreDeTxt)
        Me.Controls.Add(Me.NoChequeTxt)
        Me.Controls.Add(Me.CantidadTxt)
        Me.Controls.Add(Me.EnCajaLbl)
        Me.Controls.Add(Me.EnBancoLbl)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FechaLbl)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(301, 432)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(301, 432)
        Me.Name = "NuevoEgresoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Egreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FechaLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CantidadTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ECajaRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents ERetRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents NoChequeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DestinoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AnombreDeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CargoTxt As System.Windows.Forms.TextBox
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EnBancoLbl As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents EnCajaLbl As System.Windows.Forms.Label
    Friend WithEvents CuentasCmb As System.Windows.Forms.ComboBox
    Friend WithEvents NumeroCtaLbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SaldoLbl As System.Windows.Forms.Label
End Class
