<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarFacturafrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarFacturafrm))
        Me.LocalizarFactGpb = New System.Windows.Forms.GroupBox
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.IngresoDeCmb = New System.Windows.Forms.ComboBox
        Me.NoFacturaTxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ConceptoTxt = New System.Windows.Forms.TextBox
        Me.DatosFactGpb = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.NombreTxt = New System.Windows.Forms.TextBox
        Me.ImporteTxt = New System.Windows.Forms.TextBox
        Me.ObservacionesTxt = New System.Windows.Forms.TextBox
        Me.FechaLbl = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CambiarBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.OtraBtn = New System.Windows.Forms.Button
        Me.LocalizarFactGpb.SuspendLayout()
        Me.DatosFactGpb.SuspendLayout()
        Me.SuspendLayout()
        '
        'LocalizarFactGpb
        '
        Me.LocalizarFactGpb.Controls.Add(Me.BuscarBtn)
        Me.LocalizarFactGpb.Controls.Add(Me.IngresoDeCmb)
        Me.LocalizarFactGpb.Controls.Add(Me.NoFacturaTxt)
        Me.LocalizarFactGpb.Controls.Add(Me.Label2)
        Me.LocalizarFactGpb.Controls.Add(Me.Label1)
        Me.LocalizarFactGpb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalizarFactGpb.Location = New System.Drawing.Point(8, 7)
        Me.LocalizarFactGpb.Margin = New System.Windows.Forms.Padding(4)
        Me.LocalizarFactGpb.Name = "LocalizarFactGpb"
        Me.LocalizarFactGpb.Padding = New System.Windows.Forms.Padding(4)
        Me.LocalizarFactGpb.Size = New System.Drawing.Size(275, 89)
        Me.LocalizarFactGpb.TabIndex = 0
        Me.LocalizarFactGpb.TabStop = False
        Me.LocalizarFactGpb.Text = "Localizar factura"
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(195, 23)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(68, 24)
        Me.BuscarBtn.TabIndex = 2
        Me.BuscarBtn.Text = "Buscar"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'IngresoDeCmb
        '
        Me.IngresoDeCmb.FormattingEnabled = True
        Me.IngresoDeCmb.Items.AddRange(New Object() {"Agua Potable", "Retro y volteo", "Registro Civil", "Tortilleria", "Otros Ingresos"})
        Me.IngresoDeCmb.Location = New System.Drawing.Point(96, 55)
        Me.IngresoDeCmb.Name = "IngresoDeCmb"
        Me.IngresoDeCmb.Size = New System.Drawing.Size(167, 24)
        Me.IngresoDeCmb.TabIndex = 1
        '
        'NoFacturaTxt
        '
        Me.NoFacturaTxt.Location = New System.Drawing.Point(96, 26)
        Me.NoFacturaTxt.Name = "NoFacturaTxt"
        Me.NoFacturaTxt.Size = New System.Drawing.Size(78, 23)
        Me.NoFacturaTxt.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingreso de:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Concepto:"
        '
        'ConceptoTxt
        '
        Me.ConceptoTxt.Location = New System.Drawing.Point(84, 55)
        Me.ConceptoTxt.Name = "ConceptoTxt"
        Me.ConceptoTxt.ReadOnly = True
        Me.ConceptoTxt.Size = New System.Drawing.Size(179, 23)
        Me.ConceptoTxt.TabIndex = 4
        '
        'DatosFactGpb
        '
        Me.DatosFactGpb.Controls.Add(Me.Label4)
        Me.DatosFactGpb.Controls.Add(Me.NombreTxt)
        Me.DatosFactGpb.Controls.Add(Me.ImporteTxt)
        Me.DatosFactGpb.Controls.Add(Me.ObservacionesTxt)
        Me.DatosFactGpb.Controls.Add(Me.ConceptoTxt)
        Me.DatosFactGpb.Controls.Add(Me.FechaLbl)
        Me.DatosFactGpb.Controls.Add(Me.Label6)
        Me.DatosFactGpb.Controls.Add(Me.Label7)
        Me.DatosFactGpb.Controls.Add(Me.Label5)
        Me.DatosFactGpb.Controls.Add(Me.Label3)
        Me.DatosFactGpb.Location = New System.Drawing.Point(8, 103)
        Me.DatosFactGpb.Name = "DatosFactGpb"
        Me.DatosFactGpb.Size = New System.Drawing.Size(275, 167)
        Me.DatosFactGpb.TabIndex = 3
        Me.DatosFactGpb.TabStop = False
        Me.DatosFactGpb.Text = "Datos de factura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre:"
        '
        'NombreTxt
        '
        Me.NombreTxt.Location = New System.Drawing.Point(84, 26)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.ReadOnly = True
        Me.NombreTxt.Size = New System.Drawing.Size(179, 23)
        Me.NombreTxt.TabIndex = 3
        '
        'ImporteTxt
        '
        Me.ImporteTxt.Location = New System.Drawing.Point(84, 113)
        Me.ImporteTxt.Name = "ImporteTxt"
        Me.ImporteTxt.Size = New System.Drawing.Size(99, 23)
        Me.ImporteTxt.TabIndex = 5
        '
        'ObservacionesTxt
        '
        Me.ObservacionesTxt.Location = New System.Drawing.Point(84, 84)
        Me.ObservacionesTxt.Name = "ObservacionesTxt"
        Me.ObservacionesTxt.Size = New System.Drawing.Size(179, 23)
        Me.ObservacionesTxt.TabIndex = 4
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLbl.Location = New System.Drawing.Point(81, 142)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(92, 17)
        Me.FechaLbl.TabIndex = 1
        Me.FechaLbl.Text = "dd/mm/yyyy"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Observ..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Importe:"
        '
        'CambiarBtn
        '
        Me.CambiarBtn.Enabled = False
        Me.CambiarBtn.Location = New System.Drawing.Point(121, 279)
        Me.CambiarBtn.Name = "CambiarBtn"
        Me.CambiarBtn.Size = New System.Drawing.Size(68, 28)
        Me.CambiarBtn.TabIndex = 6
        Me.CambiarBtn.Text = "Cambiar"
        Me.CambiarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Location = New System.Drawing.Point(195, 279)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(76, 28)
        Me.CancelarBtn.TabIndex = 8
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'OtraBtn
        '
        Me.OtraBtn.Location = New System.Drawing.Point(25, 279)
        Me.OtraBtn.Name = "OtraBtn"
        Me.OtraBtn.Size = New System.Drawing.Size(53, 28)
        Me.OtraBtn.TabIndex = 7
        Me.OtraBtn.Text = "Otra"
        Me.OtraBtn.UseVisualStyleBackColor = True
        '
        'ModificarFacturafrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(294, 312)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.OtraBtn)
        Me.Controls.Add(Me.CambiarBtn)
        Me.Controls.Add(Me.DatosFactGpb)
        Me.Controls.Add(Me.LocalizarFactGpb)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(302, 346)
        Me.MinimumSize = New System.Drawing.Size(302, 346)
        Me.Name = "ModificarFacturafrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Facturas"
        Me.LocalizarFactGpb.ResumeLayout(False)
        Me.LocalizarFactGpb.PerformLayout()
        Me.DatosFactGpb.ResumeLayout(False)
        Me.DatosFactGpb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LocalizarFactGpb As System.Windows.Forms.GroupBox
    Friend WithEvents NoFacturaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IngresoDeCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ConceptoTxt As System.Windows.Forms.TextBox
    Friend WithEvents DatosFactGpb As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents ImporteTxt As System.Windows.Forms.TextBox
    Friend WithEvents FechaLbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CambiarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents OtraBtn As System.Windows.Forms.Button
    Friend WithEvents ObservacionesTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
