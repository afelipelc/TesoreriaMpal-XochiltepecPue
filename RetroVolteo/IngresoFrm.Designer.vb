<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoFrm
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
        Me.DireccionTxt = New System.Windows.Forms.TextBox
        Me.DatosContribBtn = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Nombrecmb = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.EliminarBtn = New System.Windows.Forms.Button
        Me.AgregarBtn = New System.Windows.Forms.Button
        Me.DetallesDtg = New System.Windows.Forms.DataGridView
        Me.ConceptoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComentarioTxt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SuCambioTxt = New System.Windows.Forms.TextBox
        Me.SuPagoTxt = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.ImporteTxt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.NoFacturaTxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ConceptosTxt = New System.Windows.Forms.TextBox
        Me.NoCobrotxt = New System.Windows.Forms.TextBox
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.FechaLbl = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DetallesDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DireccionTxt)
        Me.GroupBox1.Controls.Add(Me.DatosContribBtn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Nombrecmb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 60)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contribuyente"
        '
        'DireccionTxt
        '
        Me.DireccionTxt.Location = New System.Drawing.Point(342, 25)
        Me.DireccionTxt.Name = "DireccionTxt"
        Me.DireccionTxt.Size = New System.Drawing.Size(158, 23)
        Me.DireccionTxt.TabIndex = 14
        '
        'DatosContribBtn
        '
        Me.DatosContribBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DatosContribBtn.Location = New System.Drawing.Point(232, 26)
        Me.DatosContribBtn.Name = "DatosContribBtn"
        Me.DatosContribBtn.Size = New System.Drawing.Size(26, 21)
        Me.DatosContribBtn.TabIndex = 15
        Me.DatosContribBtn.Text = "..."
        Me.DatosContribBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 28)
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
        Me.Nombrecmb.Location = New System.Drawing.Point(69, 25)
        Me.Nombrecmb.Name = "Nombrecmb"
        Me.Nombrecmb.Size = New System.Drawing.Size(156, 24)
        Me.Nombrecmb.Sorted = True
        Me.Nombrecmb.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EliminarBtn)
        Me.GroupBox2.Controls.Add(Me.AgregarBtn)
        Me.GroupBox2.Controls.Add(Me.DetallesDtg)
        Me.GroupBox2.Controls.Add(Me.ComentarioTxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 162)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles del Pago"
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarBtn.Location = New System.Drawing.Point(435, 52)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(54, 24)
        Me.EliminarBtn.TabIndex = 1
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'AgregarBtn
        '
        Me.AgregarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarBtn.Location = New System.Drawing.Point(435, 22)
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.Size = New System.Drawing.Size(54, 24)
        Me.AgregarBtn.TabIndex = 1
        Me.AgregarBtn.Text = "Agregar"
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'DetallesDtg
        '
        Me.DetallesDtg.AllowUserToAddRows = False
        Me.DetallesDtg.AllowUserToDeleteRows = False
        Me.DetallesDtg.BackgroundColor = System.Drawing.Color.White
        Me.DetallesDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetallesDtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ConceptoClm, Me.CantidadClm, Me.CostoClm, Me.ImporteClm})
        Me.DetallesDtg.GridColor = System.Drawing.Color.SteelBlue
        Me.DetallesDtg.Location = New System.Drawing.Point(6, 22)
        Me.DetallesDtg.MultiSelect = False
        Me.DetallesDtg.Name = "DetallesDtg"
        Me.DetallesDtg.ReadOnly = True
        Me.DetallesDtg.RowHeadersVisible = False
        Me.DetallesDtg.Size = New System.Drawing.Size(415, 105)
        Me.DetallesDtg.TabIndex = 0
        '
        'ConceptoClm
        '
        Me.ConceptoClm.HeaderText = "Concepto"
        Me.ConceptoClm.Name = "ConceptoClm"
        Me.ConceptoClm.ReadOnly = True
        Me.ConceptoClm.Width = 180
        '
        'CantidadClm
        '
        Me.CantidadClm.HeaderText = "Cantidad"
        Me.CantidadClm.Name = "CantidadClm"
        Me.CantidadClm.ReadOnly = True
        Me.CantidadClm.Width = 70
        '
        'CostoClm
        '
        Me.CostoClm.HeaderText = "P.U."
        Me.CostoClm.Name = "CostoClm"
        Me.CostoClm.ReadOnly = True
        Me.CostoClm.Width = 60
        '
        'ImporteClm
        '
        Me.ImporteClm.HeaderText = "Importe"
        Me.ImporteClm.Name = "ImporteClm"
        Me.ImporteClm.ReadOnly = True
        Me.ImporteClm.Width = 80
        '
        'ComentarioTxt
        '
        Me.ComentarioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComentarioTxt.Location = New System.Drawing.Point(89, 133)
        Me.ComentarioTxt.MaxLength = 48
        Me.ComentarioTxt.Name = "ComentarioTxt"
        Me.ComentarioTxt.Size = New System.Drawing.Size(332, 20)
        Me.ComentarioTxt.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Comentario:"
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
        Me.GroupBox3.Location = New System.Drawing.Point(11, 243)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(506, 86)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Cobro"
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
        'SuPagoTxt
        '
        Me.SuPagoTxt.BackColor = System.Drawing.Color.White
        Me.SuPagoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuPagoTxt.Location = New System.Drawing.Point(260, 51)
        Me.SuPagoTxt.Name = "SuPagoTxt"
        Me.SuPagoTxt.Size = New System.Drawing.Size(80, 29)
        Me.SuPagoTxt.TabIndex = 23
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(193, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 17)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Su Pago:"
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Importe:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Conceptos:"
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 17)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Factura No."
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
        'NoCobrotxt
        '
        Me.NoCobrotxt.BackColor = System.Drawing.Color.White
        Me.NoCobrotxt.Location = New System.Drawing.Point(259, 22)
        Me.NoCobrotxt.Name = "NoCobrotxt"
        Me.NoCobrotxt.ReadOnly = True
        Me.NoCobrotxt.Size = New System.Drawing.Size(62, 23)
        Me.NoCobrotxt.TabIndex = 14
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(350, 339)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(80, 26)
        Me.AceptarBtn.TabIndex = 23
        Me.AceptarBtn.Text = "Cobrar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Location = New System.Drawing.Point(436, 339)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(80, 26)
        Me.CerrarBtn.TabIndex = 22
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.Location = New System.Drawing.Point(93, 342)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(84, 17)
        Me.FechaLbl.TabIndex = 20
        Me.FechaLbl.Text = "yyyy-mm-dd"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "De fecha:"
        '
        'IngresoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 370)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.FechaLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IngresoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Retro y Volteo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DetallesDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DireccionTxt As System.Windows.Forms.TextBox
    Friend WithEvents DatosContribBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nombrecmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents AgregarBtn As System.Windows.Forms.Button
    Friend WithEvents DetallesDtg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SuCambioTxt As System.Windows.Forms.TextBox
    Friend WithEvents SuPagoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ImporteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NoFacturaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ConceptosTxt As System.Windows.Forms.TextBox
    Friend WithEvents NoCobrotxt As System.Windows.Forms.TextBox
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents FechaLbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ConceptoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
