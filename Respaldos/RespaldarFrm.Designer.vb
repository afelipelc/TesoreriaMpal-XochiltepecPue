<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RespaldarFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RespaldarFrm))
        Me.SelecCarpBtn = New System.Windows.Forms.Button
        Me.RespaldarBtn = New System.Windows.Forms.Button
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.RutaLbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SelecCarptFbd = New System.Windows.Forms.FolderBrowserDialog
        Me.SuspendLayout()
        '
        'SelecCarpBtn
        '
        Me.SelecCarpBtn.Location = New System.Drawing.Point(71, 12)
        Me.SelecCarpBtn.Name = "SelecCarpBtn"
        Me.SelecCarpBtn.Size = New System.Drawing.Size(152, 28)
        Me.SelecCarpBtn.TabIndex = 1
        Me.SelecCarpBtn.Text = "Seleccionar Carpeta"
        Me.SelecCarpBtn.UseVisualStyleBackColor = True
        '
        'RespaldarBtn
        '
        Me.RespaldarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespaldarBtn.Location = New System.Drawing.Point(129, 123)
        Me.RespaldarBtn.Name = "RespaldarBtn"
        Me.RespaldarBtn.Size = New System.Drawing.Size(80, 25)
        Me.RespaldarBtn.TabIndex = 2
        Me.RespaldarBtn.Text = "Respaldar"
        Me.RespaldarBtn.UseVisualStyleBackColor = True
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarBtn.Location = New System.Drawing.Point(215, 123)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(57, 25)
        Me.CerrarBtn.TabIndex = 2
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'RutaLbl
        '
        Me.RutaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RutaLbl.Location = New System.Drawing.Point(8, 60)
        Me.RutaLbl.Name = "RutaLbl"
        Me.RutaLbl.Size = New System.Drawing.Size(264, 60)
        Me.RutaLbl.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "La Ruta: No debe tener espacios"
        '
        'SelecCarptFbd
        '
        Me.SelecCarptFbd.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'RespaldarFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 153)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.RespaldarBtn)
        Me.Controls.Add(Me.SelecCarpBtn)
        Me.Controls.Add(Me.RutaLbl)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(292, 187)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(292, 187)
        Me.Name = "RespaldarFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Respaldar Base de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelecCarpBtn As System.Windows.Forms.Button
    Friend WithEvents RespaldarBtn As System.Windows.Forms.Button
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents RutaLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SelecCarptFbd As System.Windows.Forms.FolderBrowserDialog

End Class
