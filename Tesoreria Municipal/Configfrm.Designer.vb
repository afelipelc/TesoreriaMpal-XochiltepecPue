<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configfrm
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
        Me.MunicipioTxt = New System.Windows.Forms.TextBox
        Me.PresidenteTxt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TesoreroTxt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.FacturaLbl = New System.Windows.Forms.Label
        Me.FacturaInicialTxt = New System.Windows.Forms.TextBox
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.DiaCobroTxt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.MarcaFacLbl = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Municipio:"
        '
        'MunicipioTxt
        '
        Me.MunicipioTxt.Location = New System.Drawing.Point(168, 12)
        Me.MunicipioTxt.MaxLength = 92
        Me.MunicipioTxt.Name = "MunicipioTxt"
        Me.MunicipioTxt.Size = New System.Drawing.Size(266, 23)
        Me.MunicipioTxt.TabIndex = 0
        '
        'PresidenteTxt
        '
        Me.PresidenteTxt.Location = New System.Drawing.Point(168, 41)
        Me.PresidenteTxt.MaxLength = 48
        Me.PresidenteTxt.Name = "PresidenteTxt"
        Me.PresidenteTxt.Size = New System.Drawing.Size(266, 23)
        Me.PresidenteTxt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre del Presidente:"
        '
        'TesoreroTxt
        '
        Me.TesoreroTxt.Location = New System.Drawing.Point(168, 70)
        Me.TesoreroTxt.MaxLength = 48
        Me.TesoreroTxt.Name = "TesoreroTxt"
        Me.TesoreroTxt.Size = New System.Drawing.Size(266, 23)
        Me.TesoreroTxt.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre del Tesorero:"
        '
        'FacturaLbl
        '
        Me.FacturaLbl.AutoSize = True
        Me.FacturaLbl.Location = New System.Drawing.Point(62, 133)
        Me.FacturaLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FacturaLbl.Name = "FacturaLbl"
        Me.FacturaLbl.Size = New System.Drawing.Size(99, 17)
        Me.FacturaLbl.TabIndex = 0
        Me.FacturaLbl.Text = "Factura Inicial:"
        '
        'FacturaInicialTxt
        '
        Me.FacturaInicialTxt.Location = New System.Drawing.Point(168, 130)
        Me.FacturaInicialTxt.MaxLength = 5
        Me.FacturaInicialTxt.Name = "FacturaInicialTxt"
        Me.FacturaInicialTxt.Size = New System.Drawing.Size(60, 23)
        Me.FacturaInicialTxt.TabIndex = 5
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(292, 128)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(69, 27)
        Me.AceptarBtn.TabIndex = 6
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'DiaCobroTxt
        '
        Me.DiaCobroTxt.Location = New System.Drawing.Point(168, 99)
        Me.DiaCobroTxt.MaxLength = 5
        Me.DiaCobroTxt.Name = "DiaCobroTxt"
        Me.DiaCobroTxt.Size = New System.Drawing.Size(60, 23)
        Me.DiaCobroTxt.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 34)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cobro de agua potable a partir del dia:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "de cada mes  *"
        '
        'MarcaFacLbl
        '
        Me.MarcaFacLbl.AutoSize = True
        Me.MarcaFacLbl.Location = New System.Drawing.Point(235, 133)
        Me.MarcaFacLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MarcaFacLbl.Name = "MarcaFacLbl"
        Me.MarcaFacLbl.Size = New System.Drawing.Size(13, 17)
        Me.MarcaFacLbl.TabIndex = 0
        Me.MarcaFacLbl.Text = "*"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Location = New System.Drawing.Point(367, 128)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(69, 27)
        Me.CerrarBtn.TabIndex = 6
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'Configfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(448, 159)
        Me.ControlBox = False
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.TesoreroTxt)
        Me.Controls.Add(Me.PresidenteTxt)
        Me.Controls.Add(Me.DiaCobroTxt)
        Me.Controls.Add(Me.FacturaInicialTxt)
        Me.Controls.Add(Me.MunicipioTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MarcaFacLbl)
        Me.Controls.Add(Me.FacturaLbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(456, 193)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(456, 193)
        Me.Name = "Configfrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONFIGURACIÓN DE DATOS GENERALES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MunicipioTxt As System.Windows.Forms.TextBox
    Friend WithEvents PresidenteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TesoreroTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FacturaLbl As System.Windows.Forms.Label
    Friend WithEvents FacturaInicialTxt As System.Windows.Forms.TextBox
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents DiaCobroTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MarcaFacLbl As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
End Class
