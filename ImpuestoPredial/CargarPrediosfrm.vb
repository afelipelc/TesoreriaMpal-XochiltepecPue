Imports System
Imports System.Threading
Public Class CargarPrediosFrm
    Public Login As Boolean
    Private Sub CargarPrediosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Login = True Then
            ImpuestoPredialFrm.Show()
        Else
            MessageBox.Show("Utilize el Panel de Control", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If
    End Sub
End Class
