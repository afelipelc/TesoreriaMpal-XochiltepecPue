Imports System.Collections
Public Class ReporteFrm
    'Public Datos As New System.Collections.Generic.List(Of ExtractosRegistroCivil.DatosExtractoscls)
    Public Datos As New System.Collections.Generic.List(Of AguaPotable.DatosReporteCls)
    Private Sub ReporteFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Datos.Clear()
    End Sub

    Private Sub ReporteFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DatosReporteClsBindingSource.DataSource = Datos
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class