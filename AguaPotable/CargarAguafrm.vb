Imports System
Imports System.Threading
Public Class CargarAguafrm
    Public login As Boolean
    Private Sub CargarAguafrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If login = True Then
            AguaPotablefrm.Show()
        Else
            MessageBox.Show("Utilize el Panel de Control", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If
    End Sub
End Class
