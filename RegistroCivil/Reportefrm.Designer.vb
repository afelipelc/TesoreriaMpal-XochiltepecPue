<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportefrm
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.DatosPagosClsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosResumeclsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DatosPagosClsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosResumeclsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "RegistroCivil_DatosPagosCls"
        ReportDataSource1.Value = Me.DatosPagosClsBindingSource
        ReportDataSource2.Name = "RegistroCivil_DatosResumecls"
        ReportDataSource2.Value = Me.DatosResumeclsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RegistroCivil.ReporteRegCivRpt.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(547, 442)
        Me.ReportViewer1.TabIndex = 0
        '
        'DatosPagosClsBindingSource
        '
        Me.DatosPagosClsBindingSource.DataSource = GetType(RegistroCivil.DatosPagosCls)
        '
        'DatosResumeclsBindingSource
        '
        Me.DatosResumeclsBindingSource.DataSource = GetType(RegistroCivil.DatosResumecls)
        '
        'Reportefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 442)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reportefrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Ingresos del Registro Civil"
        CType(Me.DatosPagosClsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosResumeclsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DatosPagosClsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatosResumeclsBindingSource As System.Windows.Forms.BindingSource
End Class
