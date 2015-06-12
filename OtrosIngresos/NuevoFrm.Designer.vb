<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoFrm
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.NoFacturaTxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ConceptoTxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImporteTxt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.FechaLbl = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MpioTxt = New System.Windows.Forms.TextBox
        Me.DireccionTxt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DatosContribBtn = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Nombrecmb = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CantidadTxt = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Factura:"
        '
        'NoFacturaTxt
        '
        Me.NoFacturaTxt.BackColor = System.Drawing.Color.White
        Me.NoFacturaTxt.Location = New System.Drawing.Point(77, 22)
        Me.NoFacturaTxt.Name = "NoFacturaTxt"
        Me.NoFacturaTxt.ReadOnly = True
        Me.NoFacturaTxt.Size = New System.Drawing.Size(66, 23)
        Me.NoFacturaTxt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Concepto:"
        '
        'ConceptoTxt
        '
        Me.ConceptoTxt.Location = New System.Drawing.Point(77, 51)
        Me.ConceptoTxt.MaxLength = 96
        Me.ConceptoTxt.Name = "ConceptoTxt"
        Me.ConceptoTxt.Size = New System.Drawing.Size(210, 23)
        Me.ConceptoTxt.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Importe:"
        '
        'ImporteTxt
        '
        Me.ImporteTxt.Location = New System.Drawing.Point(197, 80)
        Me.ImporteTxt.Name = "ImporteTxt"
        Me.ImporteTxt.Size = New System.Drawing.Size(90, 23)
        Me.ImporteTxt.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha:"
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.Location = New System.Drawing.Point(203, 25)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(84, 17)
        Me.FechaLbl.TabIndex = 5
        Me.FechaLbl.Text = "yyyy-mm-dd"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarBtn.Location = New System.Drawing.Point(215, 244)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(76, 29)
        Me.CerrarBtn.TabIndex = 9
        Me.CerrarBtn.Text = "Cancelar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarBtn.Location = New System.Drawing.Point(140, 244)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(70, 29)
        Me.AceptarBtn.TabIndex = 8
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MpioTxt)
        Me.GroupBox1.Controls.Add(Me.DireccionTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DatosContribBtn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Nombrecmb)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 116)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contribuyente"
        '
        'MpioTxt
        '
        Me.MpioTxt.Location = New System.Drawing.Point(80, 81)
        Me.MpioTxt.Name = "MpioTxt"
        Me.MpioTxt.Size = New System.Drawing.Size(207, 23)
        Me.MpioTxt.TabIndex = 3
        '
        'DireccionTxt
        '
        Me.DireccionTxt.Location = New System.Drawing.Point(80, 52)
        Me.DireccionTxt.Name = "DireccionTxt"
        Me.DireccionTxt.Size = New System.Drawing.Size(207, 23)
        Me.DireccionTxt.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 84)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Municipio:"
        '
        'DatosContribBtn
        '
        Me.DatosContribBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DatosContribBtn.Location = New System.Drawing.Point(263, 23)
        Me.DatosContribBtn.Name = "DatosContribBtn"
        Me.DatosContribBtn.Size = New System.Drawing.Size(26, 21)
        Me.DatosContribBtn.TabIndex = 1
        Me.DatosContribBtn.Text = "..."
        Me.DatosContribBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Dirección:"
        '
        'Nombrecmb
        '
        Me.Nombrecmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Nombrecmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Nombrecmb.FormattingEnabled = True
        Me.Nombrecmb.Location = New System.Drawing.Point(80, 22)
        Me.Nombrecmb.Name = "Nombrecmb"
        Me.Nombrecmb.Size = New System.Drawing.Size(175, 24)
        Me.Nombrecmb.Sorted = True
        Me.Nombrecmb.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NoFacturaTxt)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.FechaLbl)
        Me.GroupBox2.Controls.Add(Me.CantidadTxt)
        Me.GroupBox2.Controls.Add(Me.ImporteTxt)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ConceptoTxt)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 110)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cobro"
        '
        'CantidadTxt
        '
        Me.CantidadTxt.Location = New System.Drawing.Point(77, 80)
        Me.CantidadTxt.Name = "CantidadTxt"
        Me.CantidadTxt.Size = New System.Drawing.Size(45, 23)
        Me.CantidadTxt.TabIndex = 6
        Me.CantidadTxt.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Cantidad:"
        '
        'NuevoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(315, 277)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(323, 311)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(323, 311)
        Me.Name = "NuevoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Ingreso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NoFacturaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ConceptoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImporteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FechaLbl As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DireccionTxt As System.Windows.Forms.TextBox
    Friend WithEvents DatosContribBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nombrecmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MpioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CantidadTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
