<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiRegCivilfrm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CerrarBtn = New System.Windows.Forms.Button
        Me.EditarChk = New System.Windows.Forms.CheckBox
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosDtg
        '
        Me.DatosDtg.AllowUserToAddRows = False
        Me.DatosDtg.AllowUserToDeleteRows = False
        Me.DatosDtg.BackgroundColor = System.Drawing.Color.White
        Me.DatosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDtg.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DatosDtg.Location = New System.Drawing.Point(11, 30)
        Me.DatosDtg.Margin = New System.Windows.Forms.Padding(4)
        Me.DatosDtg.MultiSelect = False
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.Size = New System.Drawing.Size(450, 182)
        Me.DatosDtg.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Text = "Hola"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COSTOS DE ACTAS DEL REGISTRO CIVIL"
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CerrarBtn As System.Windows.Forms.Button
    Friend WithEvents EditarChk As System.Windows.Forms.CheckBox
End Class
