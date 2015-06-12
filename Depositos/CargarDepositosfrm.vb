Public Class CargarDepositosfrm
    Public Login As Boolean

    Private Sub CargarDepositosfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Login = True Then
            DepositosFrm.Show()
        Else
            MessageBox.Show("Utilize el Panel de Control", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If
    End Sub
End Class
