<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multafrm
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
        Me.NoTomaTxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.NombreTxt = New System.Windows.Forms.TextBox
        Me.DomicilioTxt = New System.Windows.Forms.TextBox
        Me.DescripcionTxt = New System.Windows.Forms.TextBox
        Me.ImporteTxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.NoFacturaTxt = New System.Windows.Forms.TextBox
        Me.CobrarBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.NoTomasLbl = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'NoTomaTxt
        '
        Me.NoTomaTxt.Location = New System.Drawing.Point(100, 7)
        Me.NoTomaTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.NoTomaTxt.Name = "NoTomaTxt"
        Me.NoTomaTxt.ReadOnly = True
        Me.NoTomaTxt.Size = New System.Drawing.Size(73, 23)
        Me.NoTomaTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. de Toma:"
        '
        'NombreTxt
        '
        Me.NombreTxt.Location = New System.Drawing.Point(100, 38)
        Me.NombreTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(135, 23)
        Me.NombreTxt.TabIndex = 0
        '
        'DomicilioTxt
        '
        Me.DomicilioTxt.Location = New System.Drawing.Point(100, 69)
        Me.DomicilioTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.DomicilioTxt.Name = "DomicilioTxt"
        Me.DomicilioTxt.Size = New System.Drawing.Size(135, 23)
        Me.DomicilioTxt.TabIndex = 0
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Location = New System.Drawing.Point(100, 100)
        Me.DescripcionTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.DescripcionTxt.Multiline = True
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(135, 37)
        Me.DescripcionTxt.TabIndex = 0
        '
        'ImporteTxt
        '
        Me.ImporteTxt.Location = New System.Drawing.Point(100, 145)
        Me.ImporteTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ImporteTxt.Name = "ImporteTxt"
        Me.ImporteTxt.Size = New System.Drawing.Size(73, 23)
        Me.ImporteTxt.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A Nombre de:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Domicilio:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 42)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Descripción del pago:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 148)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Importe:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(14, 179)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "No. Factura:"
        '
        'NoFacturaTxt
        '
        Me.NoFacturaTxt.Location = New System.Drawing.Point(100, 176)
        Me.NoFacturaTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.NoFacturaTxt.Name = "NoFacturaTxt"
        Me.NoFacturaTxt.ReadOnly = True
        Me.NoFacturaTxt.Size = New System.Drawing.Size(73, 23)
        Me.NoFacturaTxt.TabIndex = 0
        '
        'CobrarBtn
        '
        Me.CobrarBtn.Location = New System.Drawing.Point(85, 206)
        Me.CobrarBtn.Name = "CobrarBtn"
        Me.CobrarBtn.Size = New System.Drawing.Size(68, 28)
        Me.CobrarBtn.TabIndex = 2
        Me.CobrarBtn.Text = "Cobrar"
        Me.CobrarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Location = New System.Drawing.Point(159, 206)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(76, 28)
        Me.CancelarBtn.TabIndex = 2
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "x"
        '
        'NoTomasLbl
        '
        Me.NoTomasLbl.AutoSize = True
        Me.NoTomasLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTomasLbl.Location = New System.Drawing.Point(192, 9)
        Me.NoTomasLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NoTomasLbl.Name = "NoTomasLbl"
        Me.NoTomasLbl.Size = New System.Drawing.Size(18, 20)
        Me.NoTomasLbl.TabIndex = 1
        Me.NoTomasLbl.Text = "#"
        '
        'Multafrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(243, 240)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.CobrarBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NoTomasLbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NoFacturaTxt)
        Me.Controls.Add(Me.ImporteTxt)
        Me.Controls.Add(Me.DescripcionTxt)
        Me.Controls.Add(Me.DomicilioTxt)
        Me.Controls.Add(Me.NombreTxt)
        Me.Controls.Add(Me.NoTomaTxt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Multafrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OTRO PAGO - Agua Potable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NoTomaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents DomicilioTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents ImporteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NoFacturaTxt As System.Windows.Forms.TextBox
    Friend WithEvents CobrarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NoTomasLbl As System.Windows.Forms.Label
End Class
