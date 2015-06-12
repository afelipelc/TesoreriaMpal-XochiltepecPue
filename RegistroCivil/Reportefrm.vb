Imports System.Collections
Public Class Reportefrm
    Public DatosDetalle As New System.Collections.Generic.List(Of RegistroCivil.DatosPagosCls)
    Public DatosResumen As New System.Collections.Generic.List(Of RegistroCivil.DatosResumecls)
    Private Sub Reportefrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DatosDetalle.Clear()
        Me.DatosResumen.Clear()
    End Sub

    Private Sub Reportefrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DatosPagosClsBindingSource.DataSource = DatosDetalle
        Me.DatosResumeclsBindingSource.DataSource = DatosResumen
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class