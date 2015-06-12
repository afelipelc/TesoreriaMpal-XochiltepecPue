<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurarFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurarFrm))
        Me.Button1 = New System.Windows.Forms.Button
        Me.RutaLbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.RestaurarBtn = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Seleccionar Respaldo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RutaLbl
        '
        Me.RutaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RutaLbl.Location = New System.Drawing.Point(10, 44)
        Me.RutaLbl.Name = "RutaLbl"
        Me.RutaLbl.Size = New System.Drawing.Size(194, 51)
        Me.RutaLbl.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Se recomienda que realize un respaldo de la base de datos antes de restaurar, par" & _
            "a que cuente con sus datos actuales"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarBtn.Location = New System.Drawing.Point(147, 165)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(57, 25)
        Me.CerrarBtn.TabIndex = 3
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'RestaurarBtn
        '
        Me.RestaurarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestaurarBtn.Location = New System.Drawing.Point(61, 165)
        Me.RestaurarBtn.Name = "RestaurarBtn"
        Me.RestaurarBtn.Size = New System.Drawing.Size(80, 25)
        Me.RestaurarBtn.TabIndex = 3
        Me.RestaurarBtn.Text = "Restaurar"
        Me.RestaurarBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RestaurarFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(216, 196)
        Me.Controls.Add(Me.RestaurarBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RutaLbl)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(224, 230)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(224, 230)
        Me.Name = "RestaurarFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurar Base de Datos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RutaLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents RestaurarBtn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
