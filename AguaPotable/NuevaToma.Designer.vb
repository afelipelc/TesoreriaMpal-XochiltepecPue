<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaTomafrm
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
        Me.TomaIdTxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Nombrecmb = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Numerotxt = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NoTomasTxt = New System.Windows.Forms.TextBox
        Me.LocalidadesCmb = New System.Windows.Forms.TextBox
        Me.CallesCmb = New System.Windows.Forms.TextBox
        Me.DatosContribBtn = New System.Windows.Forms.Button
        Me.TarifasBtn = New System.Windows.Forms.Button
        Me.ComentarioTxt = New System.Windows.Forms.TextBox
        Me.NombreTarifaTxt = New System.Windows.Forms.TextBox
        Me.PagoHastaTxt = New System.Windows.Forms.TextBox
        Me.IdTarifaTxt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.DetallesTarBtn = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NoFacturaTxt = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.ImporteRegistroTxt = New System.Windows.Forms.TextBox
        Me.RegistrarPagoRegChk = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Toma ID:"
        '
        'TomaIdTxt
        '
        Me.TomaIdTxt.Location = New System.Drawing.Point(107, 23)
        Me.TomaIdTxt.Name = "TomaIdTxt"
        Me.TomaIdTxt.ReadOnly = True
        Me.TomaIdTxt.Size = New System.Drawing.Size(75, 23)
        Me.TomaIdTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "A Nombre de:"
        '
        'Nombrecmb
        '
        Me.Nombrecmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Nombrecmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Nombrecmb.FormattingEnabled = True
        Me.Nombrecmb.Location = New System.Drawing.Point(107, 52)
        Me.Nombrecmb.Name = "Nombrecmb"
        Me.Nombrecmb.Size = New System.Drawing.Size(190, 24)
        Me.Nombrecmb.Sorted = True
        Me.Nombrecmb.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Localidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Calle:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Número:"
        '
        'Numerotxt
        '
        Me.Numerotxt.Location = New System.Drawing.Point(289, 112)
        Me.Numerotxt.Name = "Numerotxt"
        Me.Numerotxt.Size = New System.Drawing.Size(31, 23)
        Me.Numerotxt.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DetallesTarBtn)
        Me.GroupBox1.Controls.Add(Me.NoTomasTxt)
        Me.GroupBox1.Controls.Add(Me.LocalidadesCmb)
        Me.GroupBox1.Controls.Add(Me.CallesCmb)
        Me.GroupBox1.Controls.Add(Me.DatosContribBtn)
        Me.GroupBox1.Controls.Add(Me.TarifasBtn)
        Me.GroupBox1.Controls.Add(Me.ComentarioTxt)
        Me.GroupBox1.Controls.Add(Me.NombreTarifaTxt)
        Me.GroupBox1.Controls.Add(Me.PagoHastaTxt)
        Me.GroupBox1.Controls.Add(Me.IdTarifaTxt)
        Me.GroupBox1.Controls.Add(Me.TomaIdTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Numerotxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Nombrecmb)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 269)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'NoTomasTxt
        '
        Me.NoTomasTxt.Location = New System.Drawing.Point(289, 145)
        Me.NoTomasTxt.Name = "NoTomasTxt"
        Me.NoTomasTxt.Size = New System.Drawing.Size(31, 23)
        Me.NoTomasTxt.TabIndex = 4
        '
        'LocalidadesCmb
        '
        Me.LocalidadesCmb.Location = New System.Drawing.Point(107, 82)
        Me.LocalidadesCmb.Name = "LocalidadesCmb"
        Me.LocalidadesCmb.Size = New System.Drawing.Size(140, 23)
        Me.LocalidadesCmb.TabIndex = 1
        '
        'CallesCmb
        '
        Me.CallesCmb.Location = New System.Drawing.Point(107, 112)
        Me.CallesCmb.Name = "CallesCmb"
        Me.CallesCmb.Size = New System.Drawing.Size(119, 23)
        Me.CallesCmb.TabIndex = 2
        '
        'DatosContribBtn
        '
        Me.DatosContribBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DatosContribBtn.Location = New System.Drawing.Point(298, 53)
        Me.DatosContribBtn.Name = "DatosContribBtn"
        Me.DatosContribBtn.Size = New System.Drawing.Size(26, 21)
        Me.DatosContribBtn.TabIndex = 8
        Me.DatosContribBtn.Text = "..."
        Me.DatosContribBtn.UseVisualStyleBackColor = True
        '
        'TarifasBtn
        '
        Me.TarifasBtn.Location = New System.Drawing.Point(169, 148)
        Me.TarifasBtn.Name = "TarifasBtn"
        Me.TarifasBtn.Size = New System.Drawing.Size(28, 24)
        Me.TarifasBtn.TabIndex = 5
        Me.TarifasBtn.Text = "..."
        Me.TarifasBtn.UseVisualStyleBackColor = True
        '
        'ComentarioTxt
        '
        Me.ComentarioTxt.Location = New System.Drawing.Point(107, 238)
        Me.ComentarioTxt.MaxLength = 128
        Me.ComentarioTxt.Name = "ComentarioTxt"
        Me.ComentarioTxt.Size = New System.Drawing.Size(213, 23)
        Me.ComentarioTxt.TabIndex = 1
        '
        'NombreTarifaTxt
        '
        Me.NombreTarifaTxt.Location = New System.Drawing.Point(107, 180)
        Me.NombreTarifaTxt.Name = "NombreTarifaTxt"
        Me.NombreTarifaTxt.ReadOnly = True
        Me.NombreTarifaTxt.Size = New System.Drawing.Size(213, 23)
        Me.NombreTarifaTxt.TabIndex = 1
        '
        'PagoHastaTxt
        '
        Me.PagoHastaTxt.Location = New System.Drawing.Point(107, 209)
        Me.PagoHastaTxt.Name = "PagoHastaTxt"
        Me.PagoHastaTxt.Size = New System.Drawing.Size(75, 23)
        Me.PagoHastaTxt.TabIndex = 1
        '
        'IdTarifaTxt
        '
        Me.IdTarifaTxt.Location = New System.Drawing.Point(107, 146)
        Me.IdTarifaTxt.Name = "IdTarifaTxt"
        Me.IdTarifaTxt.ReadOnly = True
        Me.IdTarifaTxt.Size = New System.Drawing.Size(56, 23)
        Me.IdTarifaTxt.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 183)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nomb. Tarifa:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 241)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Comentario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 215)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Pag Hasta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 148)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "No. Tarifa:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(203, 148)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 17)
        Me.Label8.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(208, 148)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "No. Tomas:"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBtn.Location = New System.Drawing.Point(269, 365)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(63, 30)
        Me.CerrarBtn.TabIndex = 9
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(190, 365)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(73, 30)
        Me.AceptarBtn.TabIndex = 7
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'DetallesTarBtn
        '
        Me.DetallesTarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetallesTarBtn.Location = New System.Drawing.Point(209, 210)
        Me.DetallesTarBtn.Name = "DetallesTarBtn"
        Me.DetallesTarBtn.Size = New System.Drawing.Size(111, 20)
        Me.DetallesTarBtn.TabIndex = 6
        Me.DetallesTarBtn.Text = "Detalles de Tarifa"
        Me.DetallesTarBtn.UseVisualStyleBackColor = True
        Me.DetallesTarBtn.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Factura No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RegistrarPagoRegChk)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.NoFacturaTxt)
        Me.GroupBox2.Controls.Add(Me.ImporteRegistroTxt)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 82)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Pago de registro"
        '
        'NoFacturaTxt
        '
        Me.NoFacturaTxt.Location = New System.Drawing.Point(95, 24)
        Me.NoFacturaTxt.Name = "NoFacturaTxt"
        Me.NoFacturaTxt.ReadOnly = True
        Me.NoFacturaTxt.Size = New System.Drawing.Size(75, 23)
        Me.NoFacturaTxt.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(176, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Importe:"
        '
        'ImporteRegistroTxt
        '
        Me.ImporteRegistroTxt.Location = New System.Drawing.Point(236, 24)
        Me.ImporteRegistroTxt.Name = "ImporteRegistroTxt"
        Me.ImporteRegistroTxt.Size = New System.Drawing.Size(80, 23)
        Me.ImporteRegistroTxt.TabIndex = 3
        '
        'RegistrarPagoRegChk
        '
        Me.RegistrarPagoRegChk.AutoSize = True
        Me.RegistrarPagoRegChk.Checked = True
        Me.RegistrarPagoRegChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RegistrarPagoRegChk.ForeColor = System.Drawing.Color.Maroon
        Me.RegistrarPagoRegChk.Location = New System.Drawing.Point(25, 55)
        Me.RegistrarPagoRegChk.Name = "RegistrarPagoRegChk"
        Me.RegistrarPagoRegChk.Size = New System.Drawing.Size(295, 21)
        Me.RegistrarPagoRegChk.TabIndex = 11
        Me.RegistrarPagoRegChk.Text = "Registrar pago de registro de nueva toma."
        Me.RegistrarPagoRegChk.UseVisualStyleBackColor = True
        '
        'NuevaTomafrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.CerrarBtn
        Me.ClientSize = New System.Drawing.Size(344, 401)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(352, 433)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(352, 433)
        Me.Name = "NuevaTomafrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de Toma de Agua Potable..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TomaIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombrecmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Numerotxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TarifasBtn As System.Windows.Forms.Button
    Friend WithEvents NombreTarifaTxt As System.Windows.Forms.TextBox
    Friend WithEvents IdTarifaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents DetallesTarBtn As System.Windows.Forms.Button
    Friend WithEvents DatosContribBtn As System.Windows.Forms.Button
    Friend WithEvents CallesCmb As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadesCmb As System.Windows.Forms.TextBox
    ' Friend WithEvents NoTomasTxtn As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NoTomasTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PagoHastaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComentarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NoFacturaTxt As System.Windows.Forms.TextBox
    Friend WithEvents ImporteRegistroTxt As System.Windows.Forms.TextBox
    Friend WithEvents RegistrarPagoRegChk As System.Windows.Forms.CheckBox
End Class
