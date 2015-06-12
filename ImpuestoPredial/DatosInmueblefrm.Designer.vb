<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosInmueblefrm
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
        Me.IdTxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TipoCmb = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.NoCuentaTxt = New System.Windows.Forms.TextBox
        Me.UbicacionLbl = New System.Windows.Forms.Label
        Me.UbicacionCmb = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DatosContribBtn = New System.Windows.Forms.Button
        Me.Nombrecmb = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DomicilioTxt = New System.Windows.Forms.TextBox
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Ultimopagotitlbl = New System.Windows.Forms.Label
        Me.UltimoPagoLbl = New System.Windows.Forms.Label
        Me.AnoPagadoCmb = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ImpuestosGpb = New System.Windows.Forms.GroupBox
        Me.ObservacionesTxt = New System.Windows.Forms.TextBox
        Me.ImpuestosDtg = New System.Windows.Forms.DataGridView
        Me.AdeudoTotalLbl = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.CambiarAnoChk = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.ImpuestosGpb.SuspendLayout()
        CType(Me.ImpuestosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id:"
        '
        'IdTxt
        '
        Me.IdTxt.BackColor = System.Drawing.Color.White
        Me.IdTxt.Location = New System.Drawing.Point(92, 22)
        Me.IdTxt.Name = "IdTxt"
        Me.IdTxt.ReadOnly = True
        Me.IdTxt.Size = New System.Drawing.Size(73, 23)
        Me.IdTxt.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo:"
        '
        'TipoCmb
        '
        Me.TipoCmb.FormattingEnabled = True
        Me.TipoCmb.Items.AddRange(New Object() {"Rustico", "Urbano"})
        Me.TipoCmb.Location = New System.Drawing.Point(92, 81)
        Me.TipoCmb.Name = "TipoCmb"
        Me.TipoCmb.Size = New System.Drawing.Size(89, 24)
        Me.TipoCmb.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No. Cuenta:"
        '
        'NoCuentaTxt
        '
        Me.NoCuentaTxt.BackColor = System.Drawing.Color.White
        Me.NoCuentaTxt.Location = New System.Drawing.Point(92, 52)
        Me.NoCuentaTxt.Name = "NoCuentaTxt"
        Me.NoCuentaTxt.Size = New System.Drawing.Size(73, 23)
        Me.NoCuentaTxt.TabIndex = 3
        '
        'UbicacionLbl
        '
        Me.UbicacionLbl.AutoSize = True
        Me.UbicacionLbl.Location = New System.Drawing.Point(204, 84)
        Me.UbicacionLbl.Name = "UbicacionLbl"
        Me.UbicacionLbl.Size = New System.Drawing.Size(74, 17)
        Me.UbicacionLbl.TabIndex = 0
        Me.UbicacionLbl.Text = "Ubicación:"
        '
        'UbicacionCmb
        '
        Me.UbicacionCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.UbicacionCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UbicacionCmb.Location = New System.Drawing.Point(280, 81)
        Me.UbicacionCmb.Name = "UbicacionCmb"
        Me.UbicacionCmb.Size = New System.Drawing.Size(179, 24)
        Me.UbicacionCmb.Sorted = True
        Me.UbicacionCmb.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(185, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "A nombre de:"
        '
        'DatosContribBtn
        '
        Me.DatosContribBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DatosContribBtn.Location = New System.Drawing.Point(466, 23)
        Me.DatosContribBtn.Name = "DatosContribBtn"
        Me.DatosContribBtn.Size = New System.Drawing.Size(26, 21)
        Me.DatosContribBtn.TabIndex = 2
        Me.DatosContribBtn.Text = "..."
        Me.DatosContribBtn.UseVisualStyleBackColor = True
        '
        'Nombrecmb
        '
        Me.Nombrecmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Nombrecmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Nombrecmb.FormattingEnabled = True
        Me.Nombrecmb.Location = New System.Drawing.Point(280, 22)
        Me.Nombrecmb.Name = "Nombrecmb"
        Me.Nombrecmb.Size = New System.Drawing.Size(179, 24)
        Me.Nombrecmb.Sorted = True
        Me.Nombrecmb.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Domicilio:"
        '
        'DomicilioTxt
        '
        Me.DomicilioTxt.BackColor = System.Drawing.Color.White
        Me.DomicilioTxt.Location = New System.Drawing.Point(280, 52)
        Me.DomicilioTxt.Name = "DomicilioTxt"
        Me.DomicilioTxt.Size = New System.Drawing.Size(179, 23)
        Me.DomicilioTxt.TabIndex = 4
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CerrarBtn.Location = New System.Drawing.Point(440, 283)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(65, 26)
        Me.CerrarBtn.TabIndex = 10
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AceptarBtn.Location = New System.Drawing.Point(363, 284)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(70, 26)
        Me.AceptarBtn.TabIndex = 9
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ultimopagotitlbl)
        Me.GroupBox1.Controls.Add(Me.IdTxt)
        Me.GroupBox1.Controls.Add(Me.UltimoPagoLbl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DatosContribBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Nombrecmb)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.UbicacionCmb)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.AnoPagadoCmb)
        Me.GroupBox1.Controls.Add(Me.TipoCmb)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DomicilioTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.UbicacionLbl)
        Me.GroupBox1.Controls.Add(Me.NoCuentaTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 147)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Inmueble"
        '
        'Ultimopagotitlbl
        '
        Me.Ultimopagotitlbl.AutoSize = True
        Me.Ultimopagotitlbl.Location = New System.Drawing.Point(190, 113)
        Me.Ultimopagotitlbl.Name = "Ultimopagotitlbl"
        Me.Ultimopagotitlbl.Size = New System.Drawing.Size(88, 17)
        Me.Ultimopagotitlbl.TabIndex = 0
        Me.Ultimopagotitlbl.Text = "Ultimo Pago:"
        '
        'UltimoPagoLbl
        '
        Me.UltimoPagoLbl.AutoSize = True
        Me.UltimoPagoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltimoPagoLbl.Location = New System.Drawing.Point(281, 111)
        Me.UltimoPagoLbl.Name = "UltimoPagoLbl"
        Me.UltimoPagoLbl.Size = New System.Drawing.Size(86, 18)
        Me.UltimoPagoLbl.TabIndex = 0
        Me.UltimoPagoLbl.Text = "yyyy/mm/dd"
        '
        'AnoPagadoCmb
        '
        Me.AnoPagadoCmb.FormattingEnabled = True
        Me.AnoPagadoCmb.Location = New System.Drawing.Point(92, 110)
        Me.AnoPagadoCmb.Name = "AnoPagadoCmb"
        Me.AnoPagadoCmb.Size = New System.Drawing.Size(89, 24)
        Me.AnoPagadoCmb.Sorted = True
        Me.AnoPagadoCmb.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Año Pagado:"
        '
        'ImpuestosGpb
        '
        Me.ImpuestosGpb.Controls.Add(Me.ObservacionesTxt)
        Me.ImpuestosGpb.Controls.Add(Me.ImpuestosDtg)
        Me.ImpuestosGpb.Controls.Add(Me.AdeudoTotalLbl)
        Me.ImpuestosGpb.Controls.Add(Me.Label4)
        Me.ImpuestosGpb.Controls.Add(Me.Label9)
        Me.ImpuestosGpb.Enabled = False
        Me.ImpuestosGpb.Location = New System.Drawing.Point(8, 156)
        Me.ImpuestosGpb.Name = "ImpuestosGpb"
        Me.ImpuestosGpb.Size = New System.Drawing.Size(506, 124)
        Me.ImpuestosGpb.TabIndex = 20
        Me.ImpuestosGpb.TabStop = False
        Me.ImpuestosGpb.Text = "Impuestos anuales"
        Me.ImpuestosGpb.Visible = False
        '
        'ObservacionesTxt
        '
        Me.ObservacionesTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservacionesTxt.Location = New System.Drawing.Point(229, 95)
        Me.ObservacionesTxt.Name = "ObservacionesTxt"
        Me.ObservacionesTxt.Size = New System.Drawing.Size(265, 20)
        Me.ObservacionesTxt.TabIndex = 8
        '
        'ImpuestosDtg
        '
        Me.ImpuestosDtg.AllowUserToAddRows = False
        Me.ImpuestosDtg.AllowUserToDeleteRows = False
        Me.ImpuestosDtg.BackgroundColor = System.Drawing.Color.White
        Me.ImpuestosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ImpuestosDtg.GridColor = System.Drawing.Color.SteelBlue
        Me.ImpuestosDtg.Location = New System.Drawing.Point(8, 22)
        Me.ImpuestosDtg.Name = "ImpuestosDtg"
        Me.ImpuestosDtg.RowHeadersVisible = False
        Me.ImpuestosDtg.Size = New System.Drawing.Size(486, 70)
        Me.ImpuestosDtg.TabIndex = 8
        '
        'AdeudoTotalLbl
        '
        Me.AdeudoTotalLbl.AutoSize = True
        Me.AdeudoTotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdeudoTotalLbl.Location = New System.Drawing.Point(110, 95)
        Me.AdeudoTotalLbl.Name = "AdeudoTotalLbl"
        Me.AdeudoTotalLbl.Size = New System.Drawing.Size(31, 17)
        Me.AdeudoTotalLbl.TabIndex = 0
        Me.AdeudoTotalLbl.Text = "0.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(147, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Observaciones:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Adeudo Total:"
        '
        'CambiarAnoChk
        '
        Me.CambiarAnoChk.AutoSize = True
        Me.CambiarAnoChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CambiarAnoChk.Location = New System.Drawing.Point(18, 286)
        Me.CambiarAnoChk.Name = "CambiarAnoChk"
        Me.CambiarAnoChk.Size = New System.Drawing.Size(124, 17)
        Me.CambiarAnoChk.TabIndex = 11
        Me.CambiarAnoChk.Text = "Cambiar año pagado"
        Me.CambiarAnoChk.UseVisualStyleBackColor = True
        '
        'DatosInmueblefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(523, 313)
        Me.Controls.Add(Me.CambiarAnoChk)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ImpuestosGpb)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(531, 347)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(531, 226)
        Me.Name = "DatosInmueblefrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Inmueble"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ImpuestosGpb.ResumeLayout(False)
        Me.ImpuestosGpb.PerformLayout()
        CType(Me.ImpuestosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TipoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NoCuentaTxt As System.Windows.Forms.TextBox
    Friend WithEvents UbicacionLbl As System.Windows.Forms.Label
    Friend WithEvents UbicacionCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DatosContribBtn As System.Windows.Forms.Button
    Friend WithEvents Nombrecmb As System.Windows.Forms.ComboBox
    Friend WithEvents DomicilioTxt As System.Windows.Forms.TextBox
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AnoPagadoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Ultimopagotitlbl As System.Windows.Forms.Label
    Friend WithEvents ImpuestosGpb As System.Windows.Forms.GroupBox
    Friend WithEvents ImpuestosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents AdeudoTotalLbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UltimoPagoLbl As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ObservacionesTxt As System.Windows.Forms.TextBox
    Friend WithEvents CambiarAnoChk As System.Windows.Forms.CheckBox
End Class
