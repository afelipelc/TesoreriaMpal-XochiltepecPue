<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Canceladasfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Canceladasfrm))
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.TodasBtn = New System.Windows.Forms.Button
        Me.AgregarBtn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TotalCancelLbl = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosDtg
        '
        Me.DatosDtg.AllowUserToAddRows = False
        Me.DatosDtg.AllowUserToDeleteRows = False
        Me.DatosDtg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosDtg.BackgroundColor = System.Drawing.Color.White
        Me.DatosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDtg.GridColor = System.Drawing.Color.CornflowerBlue
        Me.DatosDtg.Location = New System.Drawing.Point(3, 1)
        Me.DatosDtg.Margin = New System.Windows.Forms.Padding(4)
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.ReadOnly = True
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.Size = New System.Drawing.Size(488, 355)
        Me.DatosDtg.TabIndex = 0
        '
        'TodasBtn
        '
        Me.TodasBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TodasBtn.Location = New System.Drawing.Point(503, 70)
        Me.TodasBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.TodasBtn.Name = "TodasBtn"
        Me.TodasBtn.Size = New System.Drawing.Size(81, 32)
        Me.TodasBtn.TabIndex = 1
        Me.TodasBtn.Text = "Todas"
        Me.TodasBtn.UseVisualStyleBackColor = True
        '
        'AgregarBtn
        '
        Me.AgregarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgregarBtn.Location = New System.Drawing.Point(503, 30)
        Me.AgregarBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.Size = New System.Drawing.Size(81, 32)
        Me.AgregarBtn.TabIndex = 1
        Me.AgregarBtn.Text = "Agregar"
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TOTAL DE FACTURAS CANCELADAS:"
        '
        'TotalCancelLbl
        '
        Me.TotalCancelLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalCancelLbl.AutoSize = True
        Me.TotalCancelLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCancelLbl.Location = New System.Drawing.Point(271, 360)
        Me.TotalCancelLbl.Name = "TotalCancelLbl"
        Me.TotalCancelLbl.Size = New System.Drawing.Size(17, 17)
        Me.TotalCancelLbl.TabIndex = 2
        Me.TotalCancelLbl.Text = "0"
        '
        'CerrarBtn
        '
        Me.CerrarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CerrarBtn.Location = New System.Drawing.Point(503, 345)
        Me.CerrarBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(81, 32)
        Me.CerrarBtn.TabIndex = 1
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'Canceladasfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(593, 386)
        Me.Controls.Add(Me.CerrarBtn)
        Me.Controls.Add(Me.TotalCancelLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AgregarBtn)
        Me.Controls.Add(Me.TodasBtn)
        Me.Controls.Add(Me.DatosDtg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Canceladasfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESUMEN DE FACTURAS CANCELADAS"
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents TodasBtn As System.Windows.Forms.Button
    Friend WithEvents AgregarBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TotalCancelLbl As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
End Class
