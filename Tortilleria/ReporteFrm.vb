Public Class ReporteFrm
    Public Datos As New Collections.Generic.List(Of Tortilleria.DatosTortilleriaCls)
    Private Sub ReporteFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Datos.Clear()
    End Sub
    Private Sub ReporteFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DatosTortilleriaClsBindingSource.DataSource = Datos
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class