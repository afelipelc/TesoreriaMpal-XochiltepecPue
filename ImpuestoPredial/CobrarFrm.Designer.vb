<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CobrarFrm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.IdTxt = New System.Windows.Forms.TextBox
        Me.NombreTxt = New System.Windows.Forms.TextBox
        Me.UbicacionTxt = New System.Windows.Forms.TextBox
        Me.DomicilioTxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TipoTxt = New System.Windows.Forms.TextBox
        Me.NoCuentaTxt = New System.Windows.Forms.TextBox
        Me.ImpuestosDtg = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DescuentoChk = New System.Windows.Forms.CheckBox
        Me.RecargoChk = New System.Windows.Forms.CheckBox
        Me.FechaLbl = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.ObservacionesTxt = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.AdeutoNetoTxt = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.AdeuTotTxt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Descuentotxt = New System.Windows.Forms.TextBox
        Me.RecargoTxt = New System.Windows.Forms.TextBox
        Me.AnosPagTxt = New System.Windows.Forms.TextBox
        Me.NoCobrotxt = New System.Windows.Forms.TextBox
        Me.DescuentoLbl = New System.Windows.Forms.Label
        Me.RecargoLbl = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.NotificacionBtn = New System.Windows.Forms.Button
        Me.SuCambioTxt = New System.Windows.Forms.TextBox
        Me.SuPagoTxt = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImpuestosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.IdTxt)
        Me.GroupBox1.Controls.Add(Me.NombreTxt)
        Me.GroupBox1.Controls.Add(Me.UbicacionTxt)
        Me.GroupBox1.Controls.Add(Me.DomicilioTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TipoTxt)
        Me.GroupBox1.Controls.Add(Me.NoCuentaTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(465, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Inmueble"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "A nombre de:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ubicación:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(206, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Domicilio:"
        '
        'IdTxt
        '
        Me.IdTxt.BackColor = System.Drawing.Color.White
        Me.IdTxt.Location = New System.Drawing.Point(96, 23)
        Me.IdTxt.Name = "IdTxt"
        Me.IdTxt.ReadOnly = True
        Me.IdTxt.Size = New System.Drawing.Size(73, 23)
        Me.IdTxt.TabIndex = 8
        '
        'NombreTxt
        '
        Me.NombreTxt.BackColor = System.Drawing.Color.White
        Me.NombreTxt.Location = New System.Drawing.Point(274, 23)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.ReadOnly = True
        Me.NombreTxt.Size = New System.Drawing.Size(179, 23)
        Me.NombreTxt.TabIndex = 9
        '
        'UbicacionTxt
        '
        Me.UbicacionTxt.BackColor = System.Drawing.Color.White
        Me.UbicacionTxt.Location = New System.Drawing.Point(274, 82)
        Me.UbicacionTxt.Name = "UbicacionTxt"
        Me.UbicacionTxt.ReadOnly = True
        Me.UbicacionTxt.Size = New System.Drawing.Size(179, 23)
        Me.UbicacionTxt.TabIndex = 13
        '
        'DomicilioTxt
        '
        Me.DomicilioTxt.BackColor = System.Drawing.Color.White
        Me.DomicilioTxt.Location = New System.Drawing.Point(274, 53)
        Me.DomicilioTxt.Name = "DomicilioTxt"
        Me.DomicilioTxt.ReadOnly = True
        Me.DomicilioTxt.Size = New System.Drawing.Size(179, 23)
        Me.DomicilioTxt.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. Cuenta:"
        '
        'TipoTxt
        '
        Me.TipoTxt.BackColor = System.Drawing.Color.White
        Me.TipoTxt.Location = New System.Drawing.Point(96, 82)
        Me.TipoTxt.Name = "TipoTxt"
        Me.TipoTxt.ReadOnly = True
        Me.TipoTxt.Size = New System.Drawing.Size(73, 23)
        Me.TipoTxt.TabIndex = 12
        '
        'NoCuentaTxt
        '
        Me.NoCuentaTxt.BackColor = System.Drawing.Color.White
        Me.NoCuentaTxt.Location = New System.Drawing.Point(96, 53)
        Me.NoCuentaTxt.Name = "NoCuentaTxt"
        Me.NoCuentaTxt.ReadOnly = True
        Me.NoCuentaTxt.Size = New System.Drawing.Size(73, 23)
        Me.NoCuentaTxt.TabIndex = 10
        '
        'ImpuestosDtg
        '
        Me.ImpuestosDtg.AllowUserToAddRows = False
        Me.ImpuestosDtg.AllowUserToDeleteRows = False
        Me.ImpuestosDtg.BackgroundColor = System.Drawing.Color.White
        Me.ImpuestosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ImpuestosDtg.GridColor = System.Drawing.Color.SteelBlue
        Me.ImpuestosDtg.Location = New System.Drawing.Point(8, 151)
        Me.ImpuestosDtg.Name = "ImpuestosDtg"
        Me.ImpuestosDtg.ReadOnly = True
        Me.ImpuestosDtg.RowHeadersVisible = False
        Me.ImpuestosDtg.Size = New System.Drawing.Size(453, 68)
        Me.ImpuestosDtg.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Detalles del adeudo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DescuentoChk)
        Me.GroupBox2.Controls.Add(Me.RecargoChk)
        Me.GroupBox2.Controls.Add(Me.FechaLbl)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.ObservacionesTxt)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.AdeutoNetoTxt)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.AdeuTotTxt)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Descuentotxt)
        Me.GroupBox2.Controls.Add(Me.RecargoTxt)
        Me.GroupBox2.Controls.Add(Me.AnosPagTxt)
        Me.GroupBox2.Controls.Add(Me.NoCobrotxt)
        Me.GroupBox2.Controls.Add(Me.DescuentoLbl)
        Me.GroupBox2.Controls.Add(Me.RecargoLbl)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 148)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cobro"
        '
        'DescuentoChk
        '
        Me.DescuentoChk.AutoSize = True
        Me.DescuentoChk.Location = New System.Drawing.Point(4, 120)
        Me.DescuentoChk.Name = "DescuentoChk"
        Me.DescuentoChk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DescuentoChk.Size = New System.Drawing.Size(95, 21)
        Me.DescuentoChk.TabIndex = 3
        Me.DescuentoChk.Text = "Descuento"
        Me.DescuentoChk.UseVisualStyleBackColor = True
        '
        'RecargoChk
        '
        Me.RecargoChk.AutoSize = True
        Me.RecargoChk.Location = New System.Drawing.Point(18, 90)
        Me.RecargoChk.Name = "RecargoChk"
        Me.RecargoChk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RecargoChk.Size = New System.Drawing.Size(81, 21)
        Me.RecargoChk.TabIndex = 1
        Me.RecargoChk.Text = "Recargo"
        Me.RecargoChk.UseVisualStyleBackColor = True
        '
        'FechaLbl
        '
        Me.FechaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLbl.Location = New System.Drawing.Point(125, 57)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(118, 21)
        Me.FechaLbl.TabIndex = 16
        Me.FechaLbl.Text = "yyyy-mm-dd"
        Me.FechaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(231, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 44)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Observa-ciones:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ObservacionesTxt
        '
        Me.ObservacionesTxt.BackColor = System.Drawing.Color.White
        Me.ObservacionesTxt.Location = New System.Drawing.Point(299, 92)
        Me.ObservacionesTxt.Multiline = True
        Me.ObservacionesTxt.Name = "ObservacionesTxt"
        Me.ObservacionesTxt.Size = New System.Drawing.Size(151, 50)
        Me.ObservacionesTxt.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Fecha de Cobro:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(142, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "%"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(141, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "%"
        '
        'AdeutoNetoTxt
        '
        Me.AdeutoNetoTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.AdeutoNetoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdeutoNetoTxt.ForeColor = System.Drawing.Color.Maroon
        Me.AdeutoNetoTxt.Location = New System.Drawing.Point(340, 51)
        Me.AdeutoNetoTxt.Name = "AdeutoNetoTxt"
        Me.AdeutoNetoTxt.ReadOnly = True
        Me.AdeutoNetoTxt.Size = New System.Drawing.Size(110, 35)
        Me.AdeutoNetoTxt.TabIndex = 18
        Me.AdeutoNetoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(260, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 35)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "TOTAL A PAGAR:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AdeuTotTxt
        '
        Me.AdeuTotTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.AdeuTotTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdeuTotTxt.ForeColor = System.Drawing.Color.Maroon
        Me.AdeuTotTxt.Location = New System.Drawing.Point(340, 13)
        Me.AdeuTotTxt.Name = "AdeuTotTxt"
        Me.AdeuTotTxt.ReadOnly = True
        Me.AdeuTotTxt.Size = New System.Drawing.Size(110, 32)
        Me.AdeuTotTxt.TabIndex = 18
        Me.AdeuTotTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(269, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "SubTotal:"
        '
        'Descuentotxt
        '
        Me.Descuentotxt.BackColor = System.Drawing.Color.White
        Me.Descuentotxt.Location = New System.Drawing.Point(105, 118)
        Me.Descuentotxt.Name = "Descuentotxt"
        Me.Descuentotxt.Size = New System.Drawing.Size(36, 23)
        Me.Descuentotxt.TabIndex = 4
        '
        'RecargoTxt
        '
        Me.RecargoTxt.BackColor = System.Drawing.Color.White
        Me.RecargoTxt.Location = New System.Drawing.Point(105, 88)
        Me.RecargoTxt.Name = "RecargoTxt"
        Me.RecargoTxt.Size = New System.Drawing.Size(36, 23)
        Me.RecargoTxt.TabIndex = 2
        '
        'AnosPagTxt
        '
        Me.AnosPagTxt.BackColor = System.Drawing.Color.White
        Me.AnosPagTxt.Location = New System.Drawing.Point(208, 20)
        Me.AnosPagTxt.Name = "AnosPagTxt"
        Me.AnosPagTxt.ReadOnly = True
        Me.AnosPagTxt.Size = New System.Drawing.Size(48, 23)
        Me.AnosPagTxt.TabIndex = 16
        '
        'NoCobrotxt
        '
        Me.NoCobrotxt.BackColor = System.Drawing.Color.White
        Me.NoCobrotxt.Location = New System.Drawing.Point(86, 20)
        Me.NoCobrotxt.Name = "NoCobrotxt"
        Me.NoCobrotxt.ReadOnly = True
        Me.NoCobrotxt.Size = New System.Drawing.Size(66, 23)
        Me.NoCobrotxt.TabIndex = 15
        '
        'DescuentoLbl
        '
        Me.DescuentoLbl.AutoSize = True
        Me.DescuentoLbl.Location = New System.Drawing.Point(164, 121)
        Me.DescuentoLbl.Name = "DescuentoLbl"
        Me.DescuentoLbl.Size = New System.Drawing.Size(36, 17)
        Me.DescuentoLbl.TabIndex = 12
        Me.DescuentoLbl.Text = "$0.0"
        '
        'RecargoLbl
        '
        Me.RecargoLbl.AutoSize = True
        Me.RecargoLbl.Location = New System.Drawing.Point(164, 91)
        Me.RecargoLbl.Name = "RecargoLbl"
        Me.RecargoLbl.Size = New System.Drawing.Size(36, 17)
        Me.RecargoLbl.TabIndex = 12
        Me.RecargoLbl.Text = "$0.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(164, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Años:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Cobro No."
        '
        'NotificacionBtn
        '
        Me.NotificacionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotificacionBtn.Location = New System.Drawing.Point(344, 127)
        Me.NotificacionBtn.Name = "NotificacionBtn"
        Me.NotificacionBtn.Size = New System.Drawing.Size(119, 21)
        Me.NotificacionBtn.TabIndex = 14
        Me.NotificacionBtn.Text = "Imprimir Notificación"
        Me.NotificacionBtn.UseVisualStyleBackColor = True
        '
        'SuCambioTxt
        '
        Me.SuCambioTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.SuCambioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuCambioTxt.ForeColor = System.Drawing.Color.Maroon
        Me.SuCambioTxt.Location = New System.Drawing.Point(236, 381)
        Me.SuCambioTxt.Name = "SuCambioTxt"
        Me.SuCambioTxt.ReadOnly = True
        Me.SuCambioTxt.Size = New System.Drawing.Size(62, 29)
        Me.SuCambioTxt.TabIndex = 13
        Me.SuCambioTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SuPagoTxt
        '
        Me.SuPagoTxt.BackColor = System.Drawing.Color.White
        Me.SuPagoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuPagoTxt.Location = New System.Drawing.Point(72, 380)
        Me.SuPagoTxt.Name = "SuPagoTxt"
        Me.SuPagoTxt.Size = New System.Drawing.Size(75, 29)
        Me.SuPagoTxt.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(158, 388)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 17)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Su Cambio:"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(6, 384)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 20)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Su pago:"
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(323, 384)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(66, 26)
        Me.AceptarBtn.TabIndex = 7
        Me.AceptarBtn.Text = "Cobrar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Location = New System.Drawing.Point(395, 384)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(66, 26)
        Me.CerrarBtn.TabIndex = 8
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'CobrarFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 417)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.NotificacionBtn)
        Me.Controls.Add(Me.SuCambioTxt)
        Me.Controls.Add(Me.SuPagoTxt)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ImpuestosDtg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(484, 451)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(484, 451)
        Me.Name = "CobrarFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobro de Impuesto Predial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImpuestosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NoCuentaTxt As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DomicilioTxt As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UbicacionTxt As System.Windows.Forms.TextBox
    Friend WithEvents TipoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ImpuestosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NoCobrotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AnosPagTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FechaLbl As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AdeuTotTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SuCambioTxt As System.Windows.Forms.TextBox
    Friend WithEvents SuPagoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents NotificacionBtn As System.Windows.Forms.Button
    Friend WithEvents DescuentoChk As System.Windows.Forms.CheckBox
    Friend WithEvents RecargoChk As System.Windows.Forms.CheckBox
    Friend WithEvents Descuentotxt As System.Windows.Forms.TextBox
    Friend WithEvents RecargoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AdeutoNetoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ObservacionesTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescuentoLbl As System.Windows.Forms.Label
    Friend WithEvents RecargoLbl As System.Windows.Forms.Label
End Class
