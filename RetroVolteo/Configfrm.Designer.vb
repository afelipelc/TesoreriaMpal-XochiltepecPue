<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configfrm
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
        Me.NoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrabajodeClm = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Descripcionclm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoClm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.EditarChk = New System.Windows.Forms.CheckBox
        Me.Nuevobtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
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
        Me.DatosDtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoClm, Me.TrabajodeClm, Me.Descripcionclm, Me.CostoClm})
        Me.DatosDtg.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DatosDtg.Location = New System.Drawing.Point(7, 31)
        Me.DatosDtg.Margin = New System.Windows.Forms.Padding(5)
        Me.DatosDtg.MultiSelect = False
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.Size = New System.Drawing.Size(335, 165)
        Me.DatosDtg.TabIndex = 1
        '
        'NoClm
        '
        Me.NoClm.HeaderText = "No."
        Me.NoClm.Name = "NoClm"
        Me.NoClm.Width = 40
        '
        'TrabajodeClm
        '
        Me.TrabajodeClm.HeaderText = "TrabajoDe"
        Me.TrabajodeClm.Items.AddRange(New Object() {"Retro", "Volteo"})
        Me.TrabajodeClm.Name = "TrabajodeClm"
        Me.TrabajodeClm.Width = 80
        '
        'Descripcionclm
        '
        Me.Descripcionclm.HeaderText = "Descripcion"
        Me.Descripcionclm.Name = "Descripcionclm"
        Me.Descripcionclm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcionclm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descripcionclm.Width = 120
        '
        'CostoClm
        '
        Me.CostoClm.HeaderText = "Costo"
        Me.CostoClm.Name = "CostoClm"
        Me.CostoClm.Width = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lista de Conceptos y Costo"
        '
        'EditarChk
        '
        Me.EditarChk.AutoSize = True
        Me.EditarChk.Location = New System.Drawing.Point(7, 207)
        Me.EditarChk.Name = "EditarChk"
        Me.EditarChk.Size = New System.Drawing.Size(64, 21)
        Me.EditarChk.TabIndex = 3
        Me.EditarChk.Text = "Editar"
        Me.EditarChk.UseVisualStyleBackColor = True
        '
        'Nuevobtn
        '
        Me.Nuevobtn.Enabled = False
        Me.Nuevobtn.Location = New System.Drawing.Point(81, 204)
        Me.Nuevobtn.Name = "Nuevobtn"
        Me.Nuevobtn.Size = New System.Drawing.Size(61, 24)
        Me.Nuevobtn.TabIndex = 4
        Me.Nuevobtn.Text = "Nuevo"
        Me.Nuevobtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Enabled = False
        Me.EliminarBtn.Location = New System.Drawing.Point(148, 204)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(73, 24)
        Me.EliminarBtn.TabIndex = 4
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Location = New System.Drawing.Point(278, 204)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(64, 24)
        Me.CerrarBtn.TabIndex = 4
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'Configfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(350, 234)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.EliminarBtn)
        Me.Controls.Add(Me.Nuevobtn)
        Me.Controls.Add(Me.EditarChk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DatosDtg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(358, 268)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(358, 268)
        Me.Name = "Configfrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de costos"
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EditarChk As System.Windows.Forms.CheckBox
    Friend WithEvents Nuevobtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents NoClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrabajodeClm As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Descripcionclm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoClm As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
