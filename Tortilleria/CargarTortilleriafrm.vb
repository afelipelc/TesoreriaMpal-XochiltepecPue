Public Class CargarTortilleriaFrm
    Public Login As Boolean
    Private Sub CargarTortilleriaFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Login = True Then
            Tortilleriafrm.Show()
        Else
            MessageBox.Show("Utilize el Panel de Control", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If
    End Sub
End Class
