<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrarDatosFrm
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
        Me.RespaldarBtn = New System.Windows.Forms.Button
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.BorrarTodoBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Antes de Eliminar toda la información se recomienda que realize un respaldo de la" & _
            " base de datos. Podria utilizar la información posteriormente."
        '
        'RespaldarBtn
        '
        Me.RespaldarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespaldarBtn.Location = New System.Drawing.Point(11, 83)
        Me.RespaldarBtn.Name = "RespaldarBtn"
        Me.RespaldarBtn.Size = New System.Drawing.Size(75, 23)
        Me.RespaldarBtn.TabIndex = 1
        Me.RespaldarBtn.Text = "Respaldar"
        Me.RespaldarBtn.UseVisualStyleBackColor = True
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarBtn.Location = New System.Drawing.Point(202, 140)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(60, 23)
        Me.CerrarBtn.TabIndex = 1
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'BorrarTodoBtn
        '
        Me.BorrarTodoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrarTodoBtn.Location = New System.Drawing.Point(35, 131)
        Me.BorrarTodoBtn.Name = "BorrarTodoBtn"
        Me.BorrarTodoBtn.Size = New System.Drawing.Size(158, 40)
        Me.BorrarTodoBtn.TabIndex = 1
        Me.BorrarTodoBtn.Text = "Eliminar todos los datos de ingresos propios"
        Me.BorrarTodoBtn.UseVisualStyleBackColor = True
        '
        'BorrarDatosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(271, 178)
        Me.Controls.Add(Me.BorrarTodoBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.RespaldarBtn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BorrarDatosFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrar Datos de Ingresos Propios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RespaldarBtn As System.Windows.Forms.Button
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents BorrarTodoBtn As System.Windows.Forms.Button
End Class
