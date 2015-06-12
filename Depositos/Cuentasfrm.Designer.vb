<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuentasfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuentasfrm))
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.NoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Numeroclm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcionclm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        Me.Nuevobtn = New System.Windows.Forms.Button
        Me.EditarChk = New System.Windows.Forms.CheckBox
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosDtg
        '
        Me.DatosDtg.AllowUserToAddRows = False
        Me.DatosDtg.AllowUserToDeleteRows = False
        Me.DatosDtg.BackgroundColor = System.Drawing.Color.White
        Me.DatosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoClm, Me.CostoClm, Me.Numeroclm, Me.Descripcionclm})
        Me.DatosDtg.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DatosDtg.Location = New System.Drawing.Point(8, 28)
        Me.DatosDtg.Margin = New System.Windows.Forms.Padding(5)
        Me.DatosDtg.MultiSelect = False
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.Size = New System.Drawing.Size(379, 143)
        Me.DatosDtg.TabIndex = 2
        '
        'NoClm
        '
        Me.NoClm.HeaderText = "No."
        Me.NoClm.Name = "NoClm"
        Me.NoClm.ReadOnly = True
        Me.NoClm.Width = 40
        '
        'CostoClm
        '
        Me.CostoClm.HeaderText = "Nombre"
        Me.CostoClm.Name = "CostoClm"
        '
        'Numeroclm
        '
        Me.Numeroclm.HeaderText = "Numero"
        Me.Numeroclm.Name = "Numeroclm"
        '
        'Descripcionclm
        '
        Me.Descripcionclm.HeaderText = "Descripcion"
        Me.Descripcionclm.Name = "Descripcionclm"
        Me.Descripcionclm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcionclm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descripcionclm.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cuentas de depositos de ingresos propios"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Location = New System.Drawing.Point(319, 179)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(64, 24)
        Me.CerrarBtn.TabIndex = 6
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Enabled = False
        Me.EliminarBtn.Location = New System.Drawing.Point(144, 179)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(73, 24)
        Me.EliminarBtn.TabIndex = 8
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'Nuevobtn
        '
        Me.Nuevobtn.Enabled = False
        Me.Nuevobtn.Location = New System.Drawing.Point(77, 179)
        Me.Nuevobtn.Name = "Nuevobtn"
        Me.Nuevobtn.Size = New System.Drawing.Size(61, 24)
        Me.Nuevobtn.TabIndex = 7
        Me.Nuevobtn.Text = "Nuevo"
        Me.Nuevobtn.UseVisualStyleBackColor = True
        '
        'EditarChk
        '
        Me.EditarChk.AutoSize = True
        Me.EditarChk.Location = New System.Drawing.Point(8, 184)
        Me.EditarChk.Name = "EditarChk"
        Me.EditarChk.Size = New System.Drawing.Size(53, 17)
        Me.EditarChk.TabIndex = 5
        Me.EditarChk.Text = "Editar"
        Me.EditarChk.UseVisualStyleBackColor = True
        '
        'Cuentasfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(395, 209)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.EliminarBtn)
        Me.Controls.Add(Me.Nuevobtn)
        Me.Controls.Add(Me.EditarChk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DatosDtg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(403, 243)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(403, 243)
        Me.Name = "Cuentasfrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion de Cuentas"
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents NoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numeroclm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcionclm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents Nuevobtn As System.Windows.Forms.Button
    Friend WithEvents EditarChk As System.Windows.Forms.CheckBox
End Class
