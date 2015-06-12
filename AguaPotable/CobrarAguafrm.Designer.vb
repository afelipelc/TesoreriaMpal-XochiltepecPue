<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CobrarAguafrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CobrarAguafrm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.IdTomatxt = New System.Windows.Forms.TextBox
        Me.TaridaIdTxt = New System.Windows.Forms.TextBox
        Me.Nombrecmb = New System.Windows.Forms.TextBox
        Me.NombreTarifaTxt = New System.Windows.Forms.TextBox
        Me.LocalidadTxt = New System.Windows.Forms.TextBox
        Me.CalleTxt = New System.Windows.Forms.TextBox
        Me.Numerotxt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AdeudoGpb = New System.Windows.Forms.GroupBox
        Me.DetallesDtg = New System.Windows.Forms.DataGridView
        Me.PeriodoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PuClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MesesClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label12 = New System.Windows.Forms.Label
        Me.NoTomasTxt = New System.Windows.Forms.TextBox
        Me.PagoHastaTxt = New System.Windows.Forms.TextBox
        Me.PagoDesdeTxt = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DescuentoChk = New System.Windows.Forms.CheckBox
        Me.RecargoChk = New System.Windows.Forms.CheckBox
        Me.ObservacionesTxt = New System.Windows.Forms.TextBox
        Me.Descuentotxt = New System.Windows.Forms.TextBox
        Me.RecargoTxt = New System.Windows.Forms.TextBox
        Me.DescuentoLbl = New System.Windows.Forms.Label
        Me.RecargoLbl = New System.Windows.Forms.Label
        Me.NotificacionBtn = New System.Windows.Forms.Button
        Me.FechaLbl = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.OtroPeriodoBtn = New System.Windows.Forms.Button
        Me.AdeudoNetoTxt = New System.Windows.Forms.TextBox
        Me.AdeuTotTxt = New System.Windows.Forms.TextBox
        Me.TotalMesesTxt = New System.Windows.Forms.TextBox
        Me.Conceptostxt = New System.Windows.Forms.TextBox
        Me.NoFacturaTxt = New System.Windows.Forms.TextBox
        Me.NoCobrotxt = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.TitTomalbl = New System.Windows.Forms.Label
        Me.Estadolbl = New System.Windows.Forms.Label
        Me.TitEllbl = New System.Windows.Forms.Label
        Me.FechaCancel = New System.Windows.Forms.Label
        Me.SuPagoTxt = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.SuCambioTxt = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.AdeudoGpb.SuspendLayout()
        CType(Me.DetallesDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdTomatxt)
        Me.GroupBox1.Controls.Add(Me.TaridaIdTxt)
        Me.GroupBox1.Controls.Add(Me.Nombrecmb)
        Me.GroupBox1.Controls.Add(Me.NombreTarifaTxt)
        Me.GroupBox1.Controls.Add(Me.LocalidadTxt)
        Me.GroupBox1.Controls.Add(Me.CalleTxt)
        Me.GroupBox1.Controls.Add(Me.Numerotxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(500, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de toma"
        '
        'IdTomatxt
        '
        Me.IdTomatxt.BackColor = System.Drawing.Color.White
        Me.IdTomatxt.Location = New System.Drawing.Point(77, 20)
        Me.IdTomatxt.Name = "IdTomatxt"
        Me.IdTomatxt.ReadOnly = True
        Me.IdTomatxt.Size = New System.Drawing.Size(78, 23)
        Me.IdTomatxt.TabIndex = 11
        '
        'TaridaIdTxt
        '
        Me.TaridaIdTxt.BackColor = System.Drawing.Color.White
        Me.TaridaIdTxt.Location = New System.Drawing.Point(77, 78)
        Me.TaridaIdTxt.Name = "TaridaIdTxt"
        Me.TaridaIdTxt.ReadOnly = True
        Me.TaridaIdTxt.Size = New System.Drawing.Size(78, 23)
        Me.TaridaIdTxt.TabIndex = 10
        '
        'Nombrecmb
        '
        Me.Nombrecmb.BackColor = System.Drawing.Color.White
        Me.Nombrecmb.Location = New System.Drawing.Point(265, 20)
        Me.Nombrecmb.Name = "Nombrecmb"
        Me.Nombrecmb.ReadOnly = True
        Me.Nombrecmb.Size = New System.Drawing.Size(224, 23)
        Me.Nombrecmb.TabIndex = 10
        '
        'NombreTarifaTxt
        '
        Me.NombreTarifaTxt.BackColor = System.Drawing.Color.White
        Me.NombreTarifaTxt.Location = New System.Drawing.Point(265, 78)
        Me.NombreTarifaTxt.Name = "NombreTarifaTxt"
        Me.NombreTarifaTxt.ReadOnly = True
        Me.NombreTarifaTxt.Size = New System.Drawing.Size(224, 23)
        Me.NombreTarifaTxt.TabIndex = 10
        '
        'LocalidadTxt
        '
        Me.LocalidadTxt.BackColor = System.Drawing.Color.White
        Me.LocalidadTxt.Location = New System.Drawing.Point(77, 49)
        Me.LocalidadTxt.Name = "LocalidadTxt"
        Me.LocalidadTxt.ReadOnly = True
        Me.LocalidadTxt.Size = New System.Drawing.Size(123, 23)
        Me.LocalidadTxt.TabIndex = 10
        '
        'CalleTxt
        '
        Me.CalleTxt.BackColor = System.Drawing.Color.White
        Me.CalleTxt.Location = New System.Drawing.Point(265, 49)
        Me.CalleTxt.Name = "CalleTxt"
        Me.CalleTxt.ReadOnly = True
        Me.CalleTxt.Size = New System.Drawing.Size(116, 23)
        Me.CalleTxt.TabIndex = 10
        '
        'Numerotxt
        '
        Me.Numerotxt.BackColor = System.Drawing.Color.White
        Me.Numerotxt.Location = New System.Drawing.Point(451, 49)
        Me.Numerotxt.Name = "Numerotxt"
        Me.Numerotxt.ReadOnly = True
        Me.Numerotxt.Size = New System.Drawing.Size(38, 23)
        Me.Numerotxt.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Localidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Calle:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(393, 52)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Número:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tarifa ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre tarifa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "A nombre de:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Toma ID:"
        '
        'AdeudoGpb
        '
        Me.AdeudoGpb.Controls.Add(Me.DetallesDtg)
        Me.AdeudoGpb.Controls.Add(Me.Label12)
        Me.AdeudoGpb.Controls.Add(Me.NoTomasTxt)
        Me.AdeudoGpb.Controls.Add(Me.PagoHastaTxt)
        Me.AdeudoGpb.Controls.Add(Me.PagoDesdeTxt)
        Me.AdeudoGpb.Controls.Add(Me.Label13)
        Me.AdeudoGpb.Controls.Add(Me.Label15)
        Me.AdeudoGpb.Location = New System.Drawing.Point(10, 123)
        Me.AdeudoGpb.Name = "AdeudoGpb"
        Me.AdeudoGpb.Size = New System.Drawing.Size(500, 140)
        Me.AdeudoGpb.TabIndex = 1
        Me.AdeudoGpb.TabStop = False
        Me.AdeudoGpb.Text = "Detalles del adeudo"
        '
        'DetallesDtg
        '
        Me.DetallesDtg.AllowUserToAddRows = False
        Me.DetallesDtg.AllowUserToDeleteRows = False
        Me.DetallesDtg.BackgroundColor = System.Drawing.Color.White
        Me.DetallesDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetallesDtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PeriodoClm, Me.PuClm, Me.MesesClm, Me.ImporteClm})
        Me.DetallesDtg.GridColor = System.Drawing.Color.CornflowerBlue
        Me.DetallesDtg.Location = New System.Drawing.Point(8, 22)
        Me.DetallesDtg.MultiSelect = False
        Me.DetallesDtg.Name = "DetallesDtg"
        Me.DetallesDtg.ReadOnly = True
        Me.DetallesDtg.RowHeadersVisible = False
        Me.DetallesDtg.Size = New System.Drawing.Size(373, 111)
        Me.DetallesDtg.TabIndex = 0
        '
        'PeriodoClm
        '
        Me.PeriodoClm.HeaderText = "Periodo"
        Me.PeriodoClm.Name = "PeriodoClm"
        Me.PeriodoClm.ReadOnly = True
        Me.PeriodoClm.Width = 160
        '
        'PuClm
        '
        Me.PuClm.HeaderText = "P.U."
        Me.PuClm.Name = "PuClm"
        Me.PuClm.ReadOnly = True
        Me.PuClm.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PuClm.Width = 50
        '
        'MesesClm
        '
        Me.MesesClm.HeaderText = "Meses"
        Me.MesesClm.Name = "MesesClm"
        Me.MesesClm.ReadOnly = True
        Me.MesesClm.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MesesClm.Width = 55
        '
        'ImporteClm
        '
        Me.ImporteClm.HeaderText = "Importe"
        Me.ImporteClm.Name = "ImporteClm"
        Me.ImporteClm.ReadOnly = True
        Me.ImporteClm.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ImporteClm.Width = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(394, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cobro Desde:"
        '
        'NoTomasTxt
        '
        Me.NoTomasTxt.BackColor = System.Drawing.Color.White
        Me.NoTomasTxt.Location = New System.Drawing.Point(467, 110)
        Me.NoTomasTxt.Name = "NoTomasTxt"
        Me.NoTomasTxt.ReadOnly = True
        Me.NoTomasTxt.Size = New System.Drawing.Size(22, 23)
        Me.NoTomasTxt.TabIndex = 10
        '
        'PagoHastaTxt
        '
        Me.PagoHastaTxt.BackColor = System.Drawing.Color.White
        Me.PagoHastaTxt.Location = New System.Drawing.Point(401, 81)
        Me.PagoHastaTxt.Name = "PagoHastaTxt"
        Me.PagoHastaTxt.ReadOnly = True
        Me.PagoHastaTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PagoHastaTxt.Size = New System.Drawing.Size(88, 23)
        Me.PagoHastaTxt.TabIndex = 10
        '
        'PagoDesdeTxt
        '
        Me.PagoDesdeTxt.BackColor = System.Drawing.Color.White
        Me.PagoDesdeTxt.Location = New System.Drawing.Point(397, 35)
        Me.PagoDesdeTxt.Name = "PagoDesdeTxt"
        Me.PagoDesdeTxt.ReadOnly = True
        Me.PagoDesdeTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PagoDesdeTxt.Size = New System.Drawing.Size(92, 23)
        Me.PagoDesdeTxt.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(398, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Cobro Hasta:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(383, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "No. de Tomas:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DescuentoChk)
        Me.GroupBox2.Controls.Add(Me.RecargoChk)
        Me.GroupBox2.Controls.Add(Me.ObservacionesTxt)
        Me.GroupBox2.Controls.Add(Me.Descuentotxt)
        Me.GroupBox2.Controls.Add(Me.RecargoTxt)
        Me.GroupBox2.Controls.Add(Me.DescuentoLbl)
        Me.GroupBox2.Controls.Add(Me.RecargoLbl)
        Me.GroupBox2.Controls.Add(Me.NotificacionBtn)
        Me.GroupBox2.Controls.Add(Me.FechaLbl)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.OtroPeriodoBtn)
        Me.GroupBox2.Controls.Add(Me.AdeudoNetoTxt)
        Me.GroupBox2.Controls.Add(Me.AdeuTotTxt)
        Me.GroupBox2.Controls.Add(Me.TotalMesesTxt)
        Me.GroupBox2.Controls.Add(Me.Conceptostxt)
        Me.GroupBox2.Controls.Add(Me.NoFacturaTxt)
        Me.GroupBox2.Controls.Add(Me.NoCobrotxt)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 171)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Cobro"
        '
        'DescuentoChk
        '
        Me.DescuentoChk.AutoSize = True
        Me.DescuentoChk.Location = New System.Drawing.Point(3, 114)
        Me.DescuentoChk.Name = "DescuentoChk"
        Me.DescuentoChk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DescuentoChk.Size = New System.Drawing.Size(95, 21)
        Me.DescuentoChk.TabIndex = 15
        Me.DescuentoChk.Text = "Descuento"
        Me.DescuentoChk.UseVisualStyleBackColor = True
        '
        'RecargoChk
        '
        Me.RecargoChk.AutoSize = True
        Me.RecargoChk.Location = New System.Drawing.Point(17, 84)
        Me.RecargoChk.Name = "RecargoChk"
        Me.RecargoChk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RecargoChk.Size = New System.Drawing.Size(81, 21)
        Me.RecargoChk.TabIndex = 13
        Me.RecargoChk.Text = "Recargo"
        Me.RecargoChk.UseVisualStyleBackColor = True
        '
        'ObservacionesTxt
        '
        Me.ObservacionesTxt.BackColor = System.Drawing.Color.White
        Me.ObservacionesTxt.Location = New System.Drawing.Point(108, 142)
        Me.ObservacionesTxt.Name = "ObservacionesTxt"
        Me.ObservacionesTxt.Size = New System.Drawing.Size(381, 23)
        Me.ObservacionesTxt.TabIndex = 17
        '
        'Descuentotxt
        '
        Me.Descuentotxt.BackColor = System.Drawing.Color.White
        Me.Descuentotxt.Location = New System.Drawing.Point(103, 112)
        Me.Descuentotxt.Name = "Descuentotxt"
        Me.Descuentotxt.Size = New System.Drawing.Size(36, 23)
        Me.Descuentotxt.TabIndex = 16
        '
        'RecargoTxt
        '
        Me.RecargoTxt.BackColor = System.Drawing.Color.White
        Me.RecargoTxt.Location = New System.Drawing.Point(103, 82)
        Me.RecargoTxt.Name = "RecargoTxt"
        Me.RecargoTxt.Size = New System.Drawing.Size(36, 23)
        Me.RecargoTxt.TabIndex = 14
        '
        'DescuentoLbl
        '
        Me.DescuentoLbl.AutoSize = True
        Me.DescuentoLbl.Location = New System.Drawing.Point(157, 115)
        Me.DescuentoLbl.Name = "DescuentoLbl"
        Me.DescuentoLbl.Size = New System.Drawing.Size(36, 17)
        Me.DescuentoLbl.TabIndex = 18
        Me.DescuentoLbl.Text = "$0.0"
        '
        'RecargoLbl
        '
        Me.RecargoLbl.AutoSize = True
        Me.RecargoLbl.Location = New System.Drawing.Point(157, 85)
        Me.RecargoLbl.Name = "RecargoLbl"
        Me.RecargoLbl.Size = New System.Drawing.Size(36, 17)
        Me.RecargoLbl.TabIndex = 17
        Me.RecargoLbl.Text = "$0.0"
        '
        'NotificacionBtn
        '
        Me.NotificacionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotificacionBtn.Location = New System.Drawing.Point(404, 51)
        Me.NotificacionBtn.Name = "NotificacionBtn"
        Me.NotificacionBtn.Size = New System.Drawing.Size(85, 38)
        Me.NotificacionBtn.TabIndex = 11
        Me.NotificacionBtn.Text = "Imprimir Notificación"
        Me.NotificacionBtn.UseVisualStyleBackColor = True
        '
        'FechaLbl
        '
        Me.FechaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLbl.Location = New System.Drawing.Point(379, 111)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FechaLbl.Size = New System.Drawing.Size(110, 23)
        Me.FechaLbl.TabIndex = 4
        Me.FechaLbl.Text = "yyyy-mm-dd"
        Me.FechaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(379, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Fecha de Cobro:"
        '
        'OtroPeriodoBtn
        '
        Me.OtroPeriodoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.OtroPeriodoBtn.FlatAppearance.BorderSize = 0
        Me.OtroPeriodoBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OtroPeriodoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtroPeriodoBtn.Location = New System.Drawing.Point(144, 52)
        Me.OtroPeriodoBtn.Name = "OtroPeriodoBtn"
        Me.OtroPeriodoBtn.Size = New System.Drawing.Size(21, 20)
        Me.OtroPeriodoBtn.TabIndex = 11
        Me.OtroPeriodoBtn.Text = "+"
        Me.OtroPeriodoBtn.UseVisualStyleBackColor = True
        '
        'AdeudoNetoTxt
        '
        Me.AdeudoNetoTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.AdeudoNetoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdeudoNetoTxt.ForeColor = System.Drawing.Color.Maroon
        Me.AdeudoNetoTxt.Location = New System.Drawing.Point(280, 93)
        Me.AdeudoNetoTxt.Name = "AdeudoNetoTxt"
        Me.AdeudoNetoTxt.ReadOnly = True
        Me.AdeudoNetoTxt.Size = New System.Drawing.Size(97, 32)
        Me.AdeudoNetoTxt.TabIndex = 10
        Me.AdeudoNetoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AdeuTotTxt
        '
        Me.AdeuTotTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.AdeuTotTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdeuTotTxt.ForeColor = System.Drawing.Color.Maroon
        Me.AdeuTotTxt.Location = New System.Drawing.Point(280, 51)
        Me.AdeuTotTxt.Name = "AdeuTotTxt"
        Me.AdeuTotTxt.ReadOnly = True
        Me.AdeuTotTxt.Size = New System.Drawing.Size(97, 29)
        Me.AdeuTotTxt.TabIndex = 10
        Me.AdeuTotTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalMesesTxt
        '
        Me.TotalMesesTxt.BackColor = System.Drawing.Color.White
        Me.TotalMesesTxt.Location = New System.Drawing.Point(437, 22)
        Me.TotalMesesTxt.Name = "TotalMesesTxt"
        Me.TotalMesesTxt.ReadOnly = True
        Me.TotalMesesTxt.Size = New System.Drawing.Size(52, 23)
        Me.TotalMesesTxt.TabIndex = 10
        '
        'Conceptostxt
        '
        Me.Conceptostxt.BackColor = System.Drawing.Color.White
        Me.Conceptostxt.Location = New System.Drawing.Point(96, 50)
        Me.Conceptostxt.Name = "Conceptostxt"
        Me.Conceptostxt.ReadOnly = True
        Me.Conceptostxt.Size = New System.Drawing.Size(42, 23)
        Me.Conceptostxt.TabIndex = 10
        '
        'NoFacturaTxt
        '
        Me.NoFacturaTxt.BackColor = System.Drawing.Color.White
        Me.NoFacturaTxt.Location = New System.Drawing.Point(96, 22)
        Me.NoFacturaTxt.Name = "NoFacturaTxt"
        Me.NoFacturaTxt.ReadOnly = True
        Me.NoFacturaTxt.Size = New System.Drawing.Size(71, 23)
        Me.NoFacturaTxt.TabIndex = 10
        '
        'NoCobrotxt
        '
        Me.NoCobrotxt.BackColor = System.Drawing.Color.White
        Me.NoCobrotxt.Location = New System.Drawing.Point(280, 22)
        Me.NoCobrotxt.Name = "NoCobrotxt"
        Me.NoCobrotxt.ReadOnly = True
        Me.NoCobrotxt.Size = New System.Drawing.Size(69, 23)
        Me.NoCobrotxt.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(212, 91)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label21.Size = New System.Drawing.Size(67, 44)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Adeudo NETO:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 145)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(107, 17)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Observaciones:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(197, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "SubTOTAL:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(388, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Meses:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Periodos:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Factura No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(183, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "No. de Cobro:"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(137, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 20)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "%"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(136, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 20)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "%"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Location = New System.Drawing.Point(419, 477)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(80, 26)
        Me.CerrarBtn.TabIndex = 13
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(333, 477)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(80, 26)
        Me.AceptarBtn.TabIndex = 19
        Me.AceptarBtn.Text = "Cobrar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'TitTomalbl
        '
        Me.TitTomalbl.AutoSize = True
        Me.TitTomalbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitTomalbl.ForeColor = System.Drawing.Color.Maroon
        Me.TitTomalbl.Location = New System.Drawing.Point(8, 482)
        Me.TitTomalbl.Name = "TitTomalbl"
        Me.TitTomalbl.Size = New System.Drawing.Size(44, 17)
        Me.TitTomalbl.TabIndex = 0
        Me.TitTomalbl.Text = "Toma"
        Me.TitTomalbl.Visible = False
        '
        'Estadolbl
        '
        Me.Estadolbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estadolbl.ForeColor = System.Drawing.Color.Maroon
        Me.Estadolbl.Location = New System.Drawing.Point(50, 482)
        Me.Estadolbl.Name = "Estadolbl"
        Me.Estadolbl.Size = New System.Drawing.Size(86, 17)
        Me.Estadolbl.TabIndex = 0
        Me.Estadolbl.Text = "Suspendida"
        Me.Estadolbl.Visible = False
        '
        'TitEllbl
        '
        Me.TitEllbl.AutoSize = True
        Me.TitEllbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitEllbl.ForeColor = System.Drawing.Color.Maroon
        Me.TitEllbl.Location = New System.Drawing.Point(134, 482)
        Me.TitEllbl.Name = "TitEllbl"
        Me.TitEllbl.Size = New System.Drawing.Size(19, 17)
        Me.TitEllbl.TabIndex = 0
        Me.TitEllbl.Text = "el"
        Me.TitEllbl.Visible = False
        '
        'FechaCancel
        '
        Me.FechaCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaCancel.ForeColor = System.Drawing.Color.Maroon
        Me.FechaCancel.Location = New System.Drawing.Point(153, 482)
        Me.FechaCancel.Name = "FechaCancel"
        Me.FechaCancel.Size = New System.Drawing.Size(86, 17)
        Me.FechaCancel.TabIndex = 0
        Me.FechaCancel.Text = "05/08/2008"
        Me.FechaCancel.Visible = False
        '
        'SuPagoTxt
        '
        Me.SuPagoTxt.BackColor = System.Drawing.Color.White
        Me.SuPagoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuPagoTxt.Location = New System.Drawing.Point(184, 444)
        Me.SuPagoTxt.Name = "SuPagoTxt"
        Me.SuPagoTxt.Size = New System.Drawing.Size(80, 29)
        Me.SuPagoTxt.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(25, 453)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(158, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Pago del contribuyente:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(307, 453)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Su Cambio:"
        '
        'SuCambioTxt
        '
        Me.SuCambioTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.SuCambioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuCambioTxt.ForeColor = System.Drawing.Color.Maroon
        Me.SuCambioTxt.Location = New System.Drawing.Point(393, 444)
        Me.SuCambioTxt.Name = "SuCambioTxt"
        Me.SuCambioTxt.ReadOnly = True
        Me.SuCambioTxt.Size = New System.Drawing.Size(106, 29)
        Me.SuCambioTxt.TabIndex = 10
        Me.SuCambioTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CobrarAguafrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 511)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SuCambioTxt)
        Me.Controls.Add(Me.AdeudoGpb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FechaCancel)
        Me.Controls.Add(Me.SuPagoTxt)
        Me.Controls.Add(Me.Estadolbl)
        Me.Controls.Add(Me.TitEllbl)
        Me.Controls.Add(Me.TitTomalbl)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(528, 543)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(528, 543)
        Me.Name = "CobrarAguafrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobro de Agua Potable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.AdeudoGpb.ResumeLayout(False)
        Me.AdeudoGpb.PerformLayout()
        CType(Me.DetallesDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LocalidadTxt As System.Windows.Forms.TextBox
    Friend WithEvents Numerotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CalleTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TaridaIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents NombreTarifaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AdeudoGpb As System.Windows.Forms.GroupBox
    Friend WithEvents DetallesDtg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NoCobrotxt As System.Windows.Forms.TextBox
    Friend WithEvents Conceptostxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AdeuTotTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FechaLbl As System.Windows.Forms.Label
    Friend WithEvents OtroPeriodoBtn As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PagoDesdeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PagoHastaTxt As System.Windows.Forms.TextBox
    Friend WithEvents TitTomalbl As System.Windows.Forms.Label
    Friend WithEvents TotalMesesTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents IdTomatxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NoTomasTxt As System.Windows.Forms.TextBox
    Friend WithEvents Estadolbl As System.Windows.Forms.Label
    Friend WithEvents TitEllbl As System.Windows.Forms.Label
    Friend WithEvents FechaCancel As System.Windows.Forms.Label
    Friend WithEvents Nombrecmb As System.Windows.Forms.TextBox
    Friend WithEvents NoFacturaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SuPagoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SuCambioTxt As System.Windows.Forms.TextBox
    Friend WithEvents NotificacionBtn As System.Windows.Forms.Button
    Friend WithEvents DescuentoChk As System.Windows.Forms.CheckBox
    Friend WithEvents RecargoChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Descuentotxt As System.Windows.Forms.TextBox
    Friend WithEvents RecargoTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescuentoLbl As System.Windows.Forms.Label
    Friend WithEvents RecargoLbl As System.Windows.Forms.Label
    Friend WithEvents AdeudoNetoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ObservacionesTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PeriodoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PuClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesesClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteClm As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
