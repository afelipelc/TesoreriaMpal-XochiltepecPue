<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tarifasfrm
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
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.NuevaTBtn = New System.Windows.Forms.Button
        Me.DetallesBtn = New System.Windows.Forms.Button
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosDtg
        '
        Me.DatosDtg.AllowUserToAddRows = False
        Me.DatosDtg.AllowUserToDeleteRows = False
        Me.DatosDtg.BackgroundColor = System.Drawing.Color.White
        Me.DatosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDtg.GridColor = System.Drawing.Color.CornflowerBlue
        Me.DatosDtg.Location = New System.Drawing.Point(5, 7)
        Me.DatosDtg.MultiSelect = False
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DatosDtg.Size = New System.Drawing.Size(286, 148)
        Me.DatosDtg.TabIndex = 0
        '
        'NuevaTBtn
        '
        Me.NuevaTBtn.Location = New System.Drawing.Point(297, 12)
        Me.NuevaTBtn.Name = "NuevaTBtn"
        Me.NuevaTBtn.Size = New System.Drawing.Size(81, 23)
        Me.NuevaTBtn.TabIndex = 1
        Me.NuevaTBtn.Text = "Nueva Tarifa"
        Me.NuevaTBtn.UseVisualStyleBackColor = True
        '
        'DetallesBtn
        '
        Me.DetallesBtn.Location = New System.Drawing.Point(297, 70)
        Me.DetallesBtn.Name = "DetallesBtn"
        Me.DetallesBtn.Size = New System.Drawing.Size(81, 23)
        Me.DetallesBtn.TabIndex = 1
        Me.DetallesBtn.Text = "Cuotas"
        Me.DetallesBtn.UseVisualStyleBackColor = True
        '
        'CerrarBtn
        '
        Me.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBtn.Location = New System.Drawing.Point(323, 132)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(55, 23)
        Me.CerrarBtn.TabIndex = 1
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Location = New System.Drawing.Point(297, 41)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(81, 23)
        Me.EliminarBtn.TabIndex = 1
        Me.EliminarBtn.Text = "Eliminar Tarifa"
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'Tarifasfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.CerrarBtn
        Me.ClientSize = New System.Drawing.Size(390, 163)
        Me.Controls.Add(Me.DetallesBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.EliminarBtn)
        Me.Controls.Add(Me.NuevaTBtn)
        Me.Controls.Add(Me.DatosDtg)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(398, 197)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(398, 197)
        Me.Name = "Tarifasfrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas de Agua Potable"
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents NuevaTBtn As System.Windows.Forms.Button
    Friend WithEvents DetallesBtn As System.Windows.Forms.Button
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
End Class
