<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoIngresoFrm
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
        Me.Numerotxt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LocalidadCmb = New System.Windows.Forms.TextBox
        Me.CallesCmb = New System.Windows.Forms.TextBox
        Me.DatosContribBtn = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Nombrecmb = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DetallesDtg = New System.Windows.Forms.DataGridView
        Me.TipoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombreclm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComentarioClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgregarBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NoCobrotxt = New System.Windows.Forms.TextBox
        Me.ConceptosTxt = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NoFacturaTxt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ImporteTxt = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.SuPagoTxt = New System.Windows.Forms.TextBox
        Me.SuCambioTxt = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.FechaLbl = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DetallesDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Numerotxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LocalidadCmb)
        Me.GroupBox1.Controls.Add(Me.CallesCmb)
        Me.GroupBox1.Controls.Add(Me.DatosContribBtn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Nombrecmb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 90)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contribuyente"
        '
        'Numerotxt
        '
        Me.Numerotxt.Location = New System.Drawing.Point(388, 56)
        Me.Numerotxt.Name = "Numerotxt"
        Me.Numerotxt.Size = New System.Drawing.Size(61, 23)
        Me.Numerotxt.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Número:"
        '
        'LocalidadCmb
        '
        Me.LocalidadCmb.Location = New System.Drawing.Point(388, 23)
        Me.LocalidadCmb.Name = "LocalidadCmb"
        Me.LocalidadCmb.Size = New System.Drawing.Size(109, 23)
        Me.LocalidadCmb.TabIndex = 1
        '
        'CallesCmb
        '
        Me.CallesCmb.Location = New System.Drawing.Point(97, 56)
        Me.CallesCmb.Name = "CallesCmb"
        Me.CallesCmb.Size = New System.Drawing.Size(169, 23)
        Me.CallesCmb.TabIndex = 2
        '
        'DatosContribBtn
        '
        Me.DatosContribBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DatosContribBtn.Location = New System.Drawing.Point(272, 26)
        Me.DatosContribBtn.Name = "DatosContribBtn"
        Me.DatosContribBtn.Size = New System.Drawing.Size(26, 21)
        Me.DatosContribBtn.TabIndex = 4
        Me.DatosContribBtn.Text = "..."
        Me.DatosContribBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(314, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Localidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Calle:"
        '
        'Nombrecmb
        '
        Me.Nombrecmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Nombrecmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Nombrecmb.FormattingEnabled = True
        Me.Nombrecmb.Location = New System.Drawing.Point(97, 23)
        Me.Nombrecmb.Name = "Nombrecmb"
        Me.Nombrecmb.Size = New System.Drawing.Size(169, 24)
        Me.Nombrecmb.Sorted = True
        Me.Nombrecmb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A nombre de:"
        '
        'DetallesDtg
        '
        Me.DetallesDtg.AllowUserToAddRows = False
        Me.DetallesDtg.AllowUserToDeleteRows = False
        Me.DetallesDtg.BackgroundColor = System.Drawing.Color.White
        Me.DetallesDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetallesDtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoClm, Me.Nombreclm, Me.FolioClm, Me.CostoClm, Me.ComentarioClm})
        Me.DetallesDtg.GridColor = System.Drawing.Color.SteelBlue
        Me.DetallesDtg.Location = New System.Drawing.Point(6, 22)
        Me.DetallesDtg.MultiSelect = False
        Me.DetallesDtg.Name = "DetallesDtg"
        Me.DetallesDtg.ReadOnly = True
        Me.DetallesDtg.RowHeadersVisible = False
        Me.DetallesDtg.Size = New System.Drawing.Size(436, 105)
        Me.DetallesDtg.TabIndex = 6
        '
        'TipoClm
        '
        Me.TipoClm.HeaderText = "Tipo"
        Me.TipoClm.Name = "TipoClm"
        Me.TipoClm.ReadOnly = True
        Me.TipoClm.Width = 85
        '
        'Nombreclm
        '
        Me.Nombreclm.HeaderText = "Nombre"
        Me.Nombreclm.Name = "Nombreclm"
        Me.Nombreclm.ReadOnly = True
        '
        'FolioClm
        '
        Me.FolioClm.HeaderText = "Folio"
        Me.FolioClm.Name = "FolioClm"
        Me.FolioClm.ReadOnly = True
        Me.FolioClm.Width = 60
        '
        'CostoClm
        '
        Me.CostoClm.HeaderText = "Costo"
        Me.CostoClm.Name = "CostoClm"
        Me.CostoClm.ReadOnly = True
        Me.CostoClm.Width = 60
        '
        'ComentarioClm
        '
        Me.ComentarioClm.HeaderText = "Comentario"
        Me.ComentarioClm.Name = "ComentarioClm"
        Me.ComentarioClm.ReadOnly = True
        '
        'AgregarBtn
        '
        Me.AgregarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarBtn.Location = New System.Drawing.Point(448, 22)
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.Size = New System.Drawing.Size(54, 24)
        Me.AgregarBtn.TabIndex = 5
        Me.AgregarBtn.Text = "Agregar"
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarBtn.Location = New System.Drawing.Point(448, 52)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(54, 24)
        Me.EliminarBtn.TabIndex = 7
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EliminarBtn)
        Me.GroupBox2.Controls.Add(Me.AgregarBtn)
        Me.GroupBox2.Controls.Add(Me.DetallesDtg)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 136)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles del Pago"
        '
        'NoCobrotxt
        '
        Me.NoCobrotxt.BackColor = System.Drawing.Color.White
        Me.NoCobrotxt.Location = New System.Drawing.Point(259, 22)
        Me.NoCobrotxt.Name = "NoCobrotxt"
        Me.NoCobrotxt.ReadOnly = True
        Me.NoCobrotxt.Size = New System.Drawing.Size(62, 23)
        Me.NoCobrotxt.TabIndex = 14
        '
        'ConceptosTxt
        '
        Me.ConceptosTxt.BackColor = System.Drawing.Color.White
        Me.ConceptosTxt.Location = New System.Drawing.Point(435, 22)
        Me.ConceptosTxt.Name = "ConceptosTxt"
        Me.ConceptosTxt.ReadOnly = True
        Me.ConceptosTxt.Size = New System.Drawing.Size(62, 23)
        Me.ConceptosTxt.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 17)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Factura No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "No. de Cobro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Conceptos:"
        '
        'NoFacturaTxt
        '
        Me.NoFacturaTxt.BackColor = System.Drawing.Color.White
        Me.NoFacturaTxt.Location = New System.Drawing.Point(91, 21)
        Me.NoFacturaTxt.Name = "NoFacturaTxt"
        Me.NoFacturaTxt.ReadOnly = True
        Me.NoFacturaTxt.Size = New System.Drawing.Size(52, 23)
        Me.NoFacturaTxt.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Importe:"
        '
        'ImporteTxt
        '
        Me.ImporteTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.ImporteTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImporteTxt.ForeColor = System.Drawing.Color.Maroon
        Me.ImporteTxt.Location = New System.Drawing.Point(91, 50)
        Me.ImporteTxt.Name = "ImporteTxt"
        Me.ImporteTxt.ReadOnly = True
        Me.ImporteTxt.Size = New System.Drawing.Size(96, 29)
        Me.ImporteTxt.TabIndex = 19
        Me.ImporteTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(193, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 17)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Su Pago:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(352, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 17)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Su Cambio:"
        '
        'SuPagoTxt
        '
        Me.SuPagoTxt.BackColor = System.Drawing.Color.White
        Me.SuPagoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuPagoTxt.Location = New System.Drawing.Point(260, 51)
        Me.SuPagoTxt.Name = "SuPagoTxt"
        Me.SuPagoTxt.Size = New System.Drawing.Size(80, 29)
        Me.SuPagoTxt.TabIndex = 8
        '
        'SuCambioTxt
        '
        Me.SuCambioTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.SuCambioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuCambioTxt.ForeColor = System.Drawing.Color.Maroon
        Me.SuCambioTxt.Location = New System.Drawing.Point(435, 51)
        Me.SuCambioTxt.Name = "SuCambioTxt"
        Me.SuCambioTxt.ReadOnly = True
        Me.SuCambioTxt.Size = New System.Drawing.Size(62, 29)
        Me.SuCambioTxt.TabIndex = 22
        Me.SuCambioTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SuCambioTxt)
        Me.GroupBox3.Controls.Add(Me.SuPagoTxt)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.ImporteTxt)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.NoFacturaTxt)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.ConceptosTxt)
        Me.GroupBox3.Controls.Add(Me.NoCobrotxt)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 247)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(506, 86)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Cobro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "De fecha:"
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.Location = New System.Drawing.Point(84, 343)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(84, 17)
        Me.FechaLbl.TabIndex = 0
        Me.FechaLbl.Text = "yyyy-mm-dd"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Location = New System.Drawing.Point(427, 340)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(80, 26)
        Me.CerrarBtn.TabIndex = 10
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(341, 340)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(80, 26)
        Me.AceptarBtn.TabIndex = 9
        Me.AceptarBtn.Text = "Cobrar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'NuevoIngresoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 371)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FechaLbl)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NuevoIngresoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago del Registro Civil"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DetallesDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LocalidadCmb As System.Windows.Forms.TextBox
    Friend WithEvents CallesCmb As System.Windows.Forms.TextBox
    Friend WithEvents DatosContribBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nombrecmb As System.Windows.Forms.ComboBox
    Friend WithEvents Numerotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DetallesDtg As System.Windows.Forms.DataGridView
    Friend WithEvents TipoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombreclm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentarioClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgregarBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NoCobrotxt As System.Windows.Forms.TextBox
    Friend WithEvents ConceptosTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NoFacturaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ImporteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SuPagoTxt As System.Windows.Forms.TextBox
    Friend WithEvents SuCambioTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FechaLbl As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
End Class
