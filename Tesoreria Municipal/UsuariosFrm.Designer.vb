<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosFrm))
        Me.UsuariosDtg = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.ColNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.usuarioClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClaveClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.NuevoBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        CType(Me.UsuariosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuariosDtg
        '
        Me.UsuariosDtg.AllowDrop = True
        Me.UsuariosDtg.AllowUserToAddRows = False
        Me.UsuariosDtg.AllowUserToDeleteRows = False
        Me.UsuariosDtg.BackgroundColor = System.Drawing.Color.White
        Me.UsuariosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNo, Me.usuarioClm, Me.ClaveClm})
        Me.UsuariosDtg.GridColor = System.Drawing.Color.SteelBlue
        Me.UsuariosDtg.Location = New System.Drawing.Point(12, 29)
        Me.UsuariosDtg.Name = "UsuariosDtg"
        Me.UsuariosDtg.RowHeadersVisible = False
        Me.UsuariosDtg.Size = New System.Drawing.Size(290, 107)
        Me.UsuariosDtg.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuarios del sistema"
        '
        'ColNo
        '
        Me.ColNo.HeaderText = "No."
        Me.ColNo.Name = "ColNo"
        Me.ColNo.ReadOnly = True
        Me.ColNo.Width = 40
        '
        'usuarioClm
        '
        Me.usuarioClm.HeaderText = "Usuario"
        Me.usuarioClm.Name = "usuarioClm"
        Me.usuarioClm.Width = 110
        '
        'ClaveClm
        '
        Me.ClaveClm.HeaderText = "Clave"
        Me.ClaveClm.Name = "ClaveClm"
        Me.ClaveClm.Width = 110
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Location = New System.Drawing.Point(233, 142)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(69, 25)
        Me.CerrarBtn.TabIndex = 2
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'NuevoBtn
        '
        Me.NuevoBtn.Location = New System.Drawing.Point(15, 142)
        Me.NuevoBtn.Name = "NuevoBtn"
        Me.NuevoBtn.Size = New System.Drawing.Size(57, 25)
        Me.NuevoBtn.TabIndex = 2
        Me.NuevoBtn.Text = "Nuevo"
        Me.NuevoBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Location = New System.Drawing.Point(78, 142)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(69, 25)
        Me.EliminarBtn.TabIndex = 2
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'UsuariosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(315, 176)
        Me.Controls.Add(Me.EliminarBtn)
        Me.Controls.Add(Me.NuevoBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsuariosDtg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(323, 210)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(323, 210)
        Me.Name = "UsuariosFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Usuarios"
        CType(Me.UsuariosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuariosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuarioClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaveClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents NuevoBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
End Class
