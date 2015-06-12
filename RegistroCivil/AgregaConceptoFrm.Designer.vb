<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregaConceptoFrm
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
        Me.CostoTxt = New System.Windows.Forms.TextBox
        Me.TipoCmb = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.NombreCmb = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CertificacionChk = New System.Windows.Forms.CheckBox
        Me.ComentarioTxt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.FolioTxt = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'CostoTxt
        '
        Me.CostoTxt.Location = New System.Drawing.Point(74, 72)
        Me.CostoTxt.Name = "CostoTxt"
        Me.CostoTxt.Size = New System.Drawing.Size(54, 23)
        Me.CostoTxt.TabIndex = 2
        '
        'TipoCmb
        '
        Me.TipoCmb.FormattingEnabled = True
        Me.TipoCmb.Items.AddRange(New Object() {"Registro", "Extracto", "Constancia"})
        Me.TipoCmb.Location = New System.Drawing.Point(74, 12)
        Me.TipoCmb.Name = "TipoCmb"
        Me.TipoCmb.Size = New System.Drawing.Size(136, 24)
        Me.TipoCmb.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'NombreCmb
        '
        Me.NombreCmb.FormattingEnabled = True
        Me.NombreCmb.Location = New System.Drawing.Point(74, 42)
        Me.NombreCmb.Name = "NombreCmb"
        Me.NombreCmb.Size = New System.Drawing.Size(136, 24)
        Me.NombreCmb.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Costo:"
        '
        'CertificacionChk
        '
        Me.CertificacionChk.AutoSize = True
        Me.CertificacionChk.Enabled = False
        Me.CertificacionChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CertificacionChk.Location = New System.Drawing.Point(134, 78)
        Me.CertificacionChk.Name = "CertificacionChk"
        Me.CertificacionChk.Size = New System.Drawing.Size(84, 17)
        Me.CertificacionChk.TabIndex = 3
        Me.CertificacionChk.Text = "Certificación"
        Me.CertificacionChk.UseVisualStyleBackColor = True
        '
        'ComentarioTxt
        '
        Me.ComentarioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComentarioTxt.Location = New System.Drawing.Point(74, 130)
        Me.ComentarioTxt.MaxLength = 64
        Me.ComentarioTxt.Multiline = True
        Me.ComentarioTxt.Name = "ComentarioTxt"
        Me.ComentarioTxt.Size = New System.Drawing.Size(136, 36)
        Me.ComentarioTxt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Comentario:"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CerrarBtn.Location = New System.Drawing.Point(154, 172)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(56, 23)
        Me.CerrarBtn.TabIndex = 7
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AceptarBtn.Location = New System.Drawing.Point(84, 172)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(64, 23)
        Me.AceptarBtn.TabIndex = 6
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Folio:"
        '
        'FolioTxt
        '
        Me.FolioTxt.Location = New System.Drawing.Point(74, 101)
        Me.FolioTxt.Name = "FolioTxt"
        Me.FolioTxt.Size = New System.Drawing.Size(74, 23)
        Me.FolioTxt.TabIndex = 4
        '
        'AgregaConceptoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.CerrarBtn
        Me.ClientSize = New System.Drawing.Size(221, 203)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.CertificacionChk)
        Me.Controls.Add(Me.NombreCmb)
        Me.Controls.Add(Me.TipoCmb)
        Me.Controls.Add(Me.ComentarioTxt)
        Me.Controls.Add(Me.FolioTxt)
        Me.Controls.Add(Me.CostoTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregaConceptoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Conceptos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CostoTxt As System.Windows.Forms.TextBox
    Friend WithEvents TipoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NombreCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CertificacionChk As System.Windows.Forms.CheckBox
    Friend WithEvents ComentarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FolioTxt As System.Windows.Forms.TextBox
End Class
