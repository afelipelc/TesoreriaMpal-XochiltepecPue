<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuestraTarifasfrm
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
        Me.TarifasDtg = New System.Windows.Forms.DataGridView
        Me.CerrarBtn = New System.Windows.Forms.Button
        CType(Me.TarifasDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TarifasDtg
        '
        Me.TarifasDtg.AllowDrop = True
        Me.TarifasDtg.AllowUserToAddRows = False
        Me.TarifasDtg.AllowUserToDeleteRows = False
        Me.TarifasDtg.BackgroundColor = System.Drawing.Color.White
        Me.TarifasDtg.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.TarifasDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TarifasDtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TarifasDtg.GridColor = System.Drawing.Color.SteelBlue
        Me.TarifasDtg.Location = New System.Drawing.Point(0, 0)
        Me.TarifasDtg.MultiSelect = False
        Me.TarifasDtg.Name = "TarifasDtg"
        Me.TarifasDtg.ReadOnly = True
        Me.TarifasDtg.RowHeadersVisible = False
        Me.TarifasDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TarifasDtg.Size = New System.Drawing.Size(293, 109)
        Me.TarifasDtg.TabIndex = 0
        '
        'CerrarBtn
        '
        Me.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarBtn.Location = New System.Drawing.Point(226, 25)
        Me.CerrarBtn.Name = "CerrarBtn"
        Me.CerrarBtn.Size = New System.Drawing.Size(66, 28)
        Me.CerrarBtn.TabIndex = 1
        Me.CerrarBtn.Text = "Cerrar"
        Me.CerrarBtn.UseVisualStyleBackColor = True
        '
        'MuestraTarifasfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CerrarBtn
        Me.ClientSize = New System.Drawing.Size(293, 109)
        Me.Controls.Add(Me.TarifasDtg)
        Me.Controls.Add(Me.CerrarBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(299, 133)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(299, 133)
        Me.Name = "MuestraTarifasfrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Tarifa de Agua Potable"
        CType(Me.TarifasDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TarifasDtg As System.Windows.Forms.DataGridView
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
End Class
