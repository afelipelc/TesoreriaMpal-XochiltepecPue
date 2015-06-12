<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenGeneralFrm
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.IngresosLbl = New System.Windows.Forms.Label
        Me.EgresosLbl = New System.Windows.Forms.Label
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.DepositadoLbl = New System.Windows.Forms.Label
        Me.RetiradoLbl = New System.Windows.Forms.Label
        Me.EnCajaLbl = New System.Windows.Forms.Label
        Me.EnBancoLbl = New System.Windows.Forms.Label
        Me.TotalLbl = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Egreso Total:"
        '
        'IngresosLbl
        '
        Me.IngresosLbl.AutoSize = True
        Me.IngresosLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresosLbl.Location = New System.Drawing.Point(150, 9)
        Me.IngresosLbl.Name = "IngresosLbl"
        Me.IngresosLbl.Size = New System.Drawing.Size(49, 20)
        Me.IngresosLbl.TabIndex = 0
        Me.IngresosLbl.Text = "$ 0.0"
        '
        'EgresosLbl
        '
        Me.EgresosLbl.AutoSize = True
        Me.EgresosLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EgresosLbl.Location = New System.Drawing.Point(150, 39)
        Me.EgresosLbl.Name = "EgresosLbl"
        Me.EgresosLbl.Size = New System.Drawing.Size(49, 20)
        Me.EgresosLbl.TabIndex = 0
        Me.EgresosLbl.Text = "$ 0.0"
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarBtn.Location = New System.Drawing.Point(236, 238)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(71, 25)
        Me.AceptarBtn.TabIndex = 1
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'DepositadoLbl
        '
        Me.DepositadoLbl.AutoSize = True
        Me.DepositadoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepositadoLbl.Location = New System.Drawing.Point(150, 69)
        Me.DepositadoLbl.Name = "DepositadoLbl"
        Me.DepositadoLbl.Size = New System.Drawing.Size(49, 20)
        Me.DepositadoLbl.TabIndex = 0
        Me.DepositadoLbl.Text = "$ 0.0"
        '
        'RetiradoLbl
        '
        Me.RetiradoLbl.AutoSize = True
        Me.RetiradoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetiradoLbl.Location = New System.Drawing.Point(150, 99)
        Me.RetiradoLbl.Name = "RetiradoLbl"
        Me.RetiradoLbl.Size = New System.Drawing.Size(49, 20)
        Me.RetiradoLbl.TabIndex = 0
        Me.RetiradoLbl.Text = "$ 0.0"
        '
        'EnCajaLbl
        '
        Me.EnCajaLbl.AutoSize = True
        Me.EnCajaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnCajaLbl.ForeColor = System.Drawing.Color.Maroon
        Me.EnCajaLbl.Location = New System.Drawing.Point(150, 130)
        Me.EnCajaLbl.Name = "EnCajaLbl"
        Me.EnCajaLbl.Size = New System.Drawing.Size(49, 20)
        Me.EnCajaLbl.TabIndex = 0
        Me.EnCajaLbl.Text = "$ 0.0"
        '
        'EnBancoLbl
        '
        Me.EnBancoLbl.AutoSize = True
        Me.EnBancoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnBancoLbl.ForeColor = System.Drawing.Color.Maroon
        Me.EnBancoLbl.Location = New System.Drawing.Point(150, 163)
        Me.EnBancoLbl.Name = "EnBancoLbl"
        Me.EnBancoLbl.Size = New System.Drawing.Size(49, 20)
        Me.EnBancoLbl.TabIndex = 0
        Me.EnBancoLbl.Text = "$ 0.0"
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TotalLbl.Location = New System.Drawing.Point(150, 205)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(55, 24)
        Me.TotalLbl.TabIndex = 0
        Me.TotalLbl.Text = "$ 0.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Depositado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Retirado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fondo En Caja:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fondo En Banco:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(11, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 42)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Recurso total disponible:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ResumenGeneralFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(315, 270)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TotalLbl)
        Me.Controls.Add(Me.EnBancoLbl)
        Me.Controls.Add(Me.EnCajaLbl)
        Me.Controls.Add(Me.RetiradoLbl)
        Me.Controls.Add(Me.DepositadoLbl)
        Me.Controls.Add(Me.EgresosLbl)
        Me.Controls.Add(Me.IngresosLbl)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(323, 304)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(323, 304)
        Me.Name = "ResumenGeneralFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen General de Ingreso Propios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IngresosLbl As System.Windows.Forms.Label
    Friend WithEvents EgresosLbl As System.Windows.Forms.Label
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents DepositadoLbl As System.Windows.Forms.Label
    Friend WithEvents RetiradoLbl As System.Windows.Forms.Label
    Friend WithEvents EnCajaLbl As System.Windows.Forms.Label
    Friend WithEvents EnBancoLbl As System.Windows.Forms.Label
    Friend WithEvents TotalLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
