<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleTarifasfrm
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
        Me.IdLbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Nombrelbl = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.NuevaBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        Me.CerrarBrn = New System.Windows.Forms.Button
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tarifa ID:"
        '
        'IdLbl
        '
        Me.IdLbl.AutoSize = True
        Me.IdLbl.Location = New System.Drawing.Point(85, 8)
        Me.IdLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IdLbl.Name = "IdLbl"
        Me.IdLbl.Size = New System.Drawing.Size(87, 17)
        Me.IdLbl.TabIndex = 0
        Me.IdLbl.Text = "No de Tarifa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        '
        'Nombrelbl
        '
        Me.Nombrelbl.AutoSize = True
        Me.Nombrelbl.Location = New System.Drawing.Point(85, 25)
        Me.Nombrelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Nombrelbl.Name = "Nombrelbl"
        Me.Nombrelbl.Size = New System.Drawing.Size(138, 17)
        Me.Nombrelbl.TabIndex = 0
        Me.Nombrelbl.Text = "Nombre  de la Tarifa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(301, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = ": : : : : : : : : : : : C U O T A S  : : : : : : : :"
        '
        'DatosDtg
        '
        Me.DatosDtg.AllowDrop = True
        Me.DatosDtg.AllowUserToAddRows = False
        Me.DatosDtg.AllowUserToDeleteRows = False
        Me.DatosDtg.BackgroundColor = System.Drawing.Color.White
        Me.DatosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDtg.GridColor = System.Drawing.Color.SteelBlue
        Me.DatosDtg.Location = New System.Drawing.Point(4, 68)
        Me.DatosDtg.MultiSelect = False
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.ReadOnly = True
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatosDtg.Size = New System.Drawing.Size(300, 148)
        Me.DatosDtg.TabIndex = 1
        '
        'NuevaBtn
        '
        Me.NuevaBtn.Location = New System.Drawing.Point(4, 222)
        Me.NuevaBtn.Name = "NuevaBtn"
        Me.NuevaBtn.Size = New System.Drawing.Size(73, 29)
        Me.NuevaBtn.TabIndex = 2
        Me.NuevaBtn.Text = "Agregar"
        Me.NuevaBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Location = New System.Drawing.Point(83, 223)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(73, 28)
        Me.EliminarBtn.TabIndex = 2
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'CerrarBrn
        '
        Me.CerrarBrn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBrn.Location = New System.Drawing.Point(231, 223)
        Me.CerrarBrn.Name = "CerrarBrn"
        Me.CerrarBrn.Size = New System.Drawing.Size(73, 28)
        Me.CerrarBrn.TabIndex = 2
        Me.CerrarBrn.Text = "Cerrar"
        Me.CerrarBrn.UseVisualStyleBackColor = True
        '
        'DetalleTarifasfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.CerrarBrn
        Me.ClientSize = New System.Drawing.Size(314, 258)
        Me.Controls.Add(Me.CerrarBrn)
        Me.Controls.Add(Me.EliminarBtn)
        Me.Controls.Add(Me.NuevaBtn)
        Me.Controls.Add(Me.DatosDtg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Nombrelbl)
        Me.Controls.Add(Me.IdLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(322, 292)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(322, 292)
        Me.Name = "DetalleTarifasfrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuotas de Tarifas"
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nombrelbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents NuevaBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents CerrarBrn As System.Windows.Forms.Button
End Class
