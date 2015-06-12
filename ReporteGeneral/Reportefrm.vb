Imports System.Collections
Public Class Reportefrm
    Public Datos As New Collections.Generic.List(Of ReporteGeneral.DatosResumenCls)

    Private Sub Reportefrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Datos.Clear()
    End Sub
    Private Sub Reportefrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DatosResumenClsBindingSource.DataSource = Datos
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class