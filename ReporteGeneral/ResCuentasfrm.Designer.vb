<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResCuentasfrm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.NoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Numeroclm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcionclm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Despositadoclm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Retiradoclm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Saldoclm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CerrarBtn = New System.Windows.Forms.Button
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosDtg
        '
        Me.DatosDtg.AllowUserToAddRows = False
        Me.DatosDtg.AllowUserToDeleteRows = False
        Me.DatosDtg.BackgroundColor = System.Drawing.Color.White
        Me.DatosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoClm, Me.CostoClm, Me.Numeroclm, Me.Descripcionclm, Me.Despositadoclm, Me.Retiradoclm, Me.Saldoclm})
        Me.DatosDtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatosDtg.GridColor = System.Drawing.Color.SteelBlue
        Me.DatosDtg.Location = New System.Drawing.Point(0, 0)
        Me.DatosDtg.Margin = New System.Windows.Forms.Padding(5)
        Me.DatosDtg.MultiSelect = False
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.ReadOnly = True
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.Size = New System.Drawing.Size(619, 198)
        Me.DatosDtg.TabIndex = 3
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
        Me.CostoClm.ReadOnly = True
        '
        'Numeroclm
        '
        Me.Numeroclm.HeaderText = "Numero"
        Me.Numeroclm.Name = "Numeroclm"
        Me.Numeroclm.ReadOnly = True
        '
        'Descripcionclm
        '
        Me.Descripcionclm.HeaderText = "Descripcion"
        Me.Descripcionclm.Name = "Descripcionclm"
        Me.Descripcionclm.ReadOnly = True
        Me.Descripcionclm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcionclm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descripcionclm.Width = 120
        '
        'Despositadoclm
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Despositadoclm.DefaultCellStyle = DataGridViewCellStyle4
        Me.Despositadoclm.HeaderText = "Despositado"
        Me.Despositadoclm.Name = "Despositadoclm"
        Me.Despositadoclm.ReadOnly = True
        Me.Despositadoclm.Width = 80
        '
        'Retiradoclm
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Retiradoclm.DefaultCellStyle = DataGridViewCellStyle5
        Me.Retiradoclm.HeaderText = "Retirado"
        Me.Retiradoclm.Name = "Retiradoclm"
        Me.Retiradoclm.ReadOnly = True
        Me.Retiradoclm.Width = 80
        '
        'Saldoclm
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saldoclm.DefaultCellStyle = DataGridViewCellStyle6
        Me.Saldoclm.HeaderText = "Saldo"
        Me.Saldoclm.Name = "Saldoclm"
        Me.Saldoclm.ReadOnly = True
        Me.Saldoclm.Width = 80
        '
        'CerrarBtn
        '
        Me.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBtn.Location = New System.Drawing.Point(549, 138)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(58, 24)
        Me.CerrarBtn.TabIndex = 5
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'ResCuentasfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.CerrarBtn
        Me.ClientSize = New System.Drawing.Size(619, 198)
        Me.Controls.Add(Me.DatosDtg)
        Me.Controls.Add(Me.CerrarBtn)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(627, 230)
        Me.Name = "ResCuentasfrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESUMEN GENERAL DE CUENTAS DISPONIBLES"
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents NoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numeroclm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcionclm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Despositadoclm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Retiradoclm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldoclm As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
