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
        Me.TrabDelbl = New System.Windows.Forms.Label
        Me.TrabdeCmb = New System.Windows.Forms.ComboBox
        Me.ConceptosCmb = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PUTxt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CantidadTxt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ImporteTxt = New System.Windows.Forms.TextBox
        Me.AceptarBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TrabDelbl
        '
        Me.TrabDelbl.AutoSize = True
        Me.TrabDelbl.Location = New System.Drawing.Point(12, 9)
        Me.TrabDelbl.Name = "TrabDelbl"
        Me.TrabDelbl.Size = New System.Drawing.Size(81, 17)
        Me.TrabDelbl.TabIndex = 0
        Me.TrabDelbl.Text = "Trabajo de:"
        '
        'TrabdeCmb
        '
        Me.TrabdeCmb.FormattingEnabled = True
        Me.TrabdeCmb.Items.AddRange(New Object() {"Retro", "Volteo"})
        Me.TrabdeCmb.Location = New System.Drawing.Point(95, 6)
        Me.TrabdeCmb.Name = "TrabdeCmb"
        Me.TrabdeCmb.Size = New System.Drawing.Size(93, 24)
        Me.TrabdeCmb.TabIndex = 0
        '
        'ConceptosCmb
        '
        Me.ConceptosCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConceptosCmb.FormattingEnabled = True
        Me.ConceptosCmb.Location = New System.Drawing.Point(95, 36)
        Me.ConceptosCmb.Name = "ConceptosCmb"
        Me.ConceptosCmb.Size = New System.Drawing.Size(157, 23)
        Me.ConceptosCmb.Sorted = True
        Me.ConceptosCmb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Concepto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio Unit:"
        '
        'PUTxt
        '
        Me.PUTxt.BackColor = System.Drawing.Color.White
        Me.PUTxt.Location = New System.Drawing.Point(95, 66)
        Me.PUTxt.Name = "PUTxt"
        Me.PUTxt.ReadOnly = True
        Me.PUTxt.Size = New System.Drawing.Size(93, 23)
        Me.PUTxt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad:"
        '
        'CantidadTxt
        '
        Me.CantidadTxt.Location = New System.Drawing.Point(95, 95)
        Me.CantidadTxt.Name = "CantidadTxt"
        Me.CantidadTxt.Size = New System.Drawing.Size(93, 23)
        Me.CantidadTxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Importe:"
        '
        'ImporteTxt
        '
        Me.ImporteTxt.Location = New System.Drawing.Point(95, 124)
        Me.ImporteTxt.Name = "ImporteTxt"
        Me.ImporteTxt.Size = New System.Drawing.Size(93, 23)
        Me.ImporteTxt.TabIndex = 4
        '
        'AceptarBtn
        '
        Me.AceptarBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AceptarBtn.Location = New System.Drawing.Point(89, 153)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(69, 24)
        Me.AceptarBtn.TabIndex = 5
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelarBtn.Location = New System.Drawing.Point(171, 153)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(78, 24)
        Me.CancelarBtn.TabIndex = 6
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'AgregaConceptoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.CancelarBtn
        Me.ClientSize = New System.Drawing.Size(261, 182)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.ImporteTxt)
        Me.Controls.Add(Me.CantidadTxt)
        Me.Controls.Add(Me.PUTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConceptosCmb)
        Me.Controls.Add(Me.TrabdeCmb)
        Me.Controls.Add(Me.TrabDelbl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(269, 216)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(269, 216)
        Me.Name = "AgregaConceptoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Concepto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrabDelbl As System.Windows.Forms.Label
    Friend WithEvents TrabdeCmb As System.Windows.Forms.ComboBox
    Friend WithEvents ConceptosCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PUTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CantidadTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImporteTxt As System.Windows.Forms.TextBox
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
End Class
