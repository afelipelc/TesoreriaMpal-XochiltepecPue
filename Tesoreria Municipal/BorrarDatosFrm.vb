Imports MySql.Data.MySqlClient
Imports Respaldos
Public Class BorrarDatosFrm

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub

    Private Sub RespaldarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RespaldarBtn.Click
        Dim Respaldar As Respaldos.RespaldarFrm
        Respaldar = New Respaldos.RespaldarFrm
        Respaldar.ShowDialog()
    End Sub

    Private Sub BorrarTodoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarTodoBtn.Click
        If MessageBox.Show("¿Confirma eliminar todos los datos de Ingresos Propios?", "Eliminar Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                'aqui empieza a eliminar
                'eliminar cobro de agua
                SQL = "DELETE FROM detcobagua"
              Ejecuta()

                SQL = "DELETE FROM  cobroagua"
                Ejecuta()

                'Borrar Reg Civil
                SQL = "DELETE FROM detallesregcivil"
               Ejecuta()

                SQL = "DELETE FROM cobroregcivil"
                Ejecuta()

                'Borrar Maquina y volteo
                SQL = "DELETE FROM detcobromaq"
                Ejecuta()

                SQL = "DELETE FROM cobromaquina"
                Ejecuta()

                SQL = "DELETE FROM configmaquina"
                Ejecuta()

                'impuesto predial
                SQL = "DELETE FROM detcobropredios"
                Ejecuta()

                SQL = "DELETE FROM cobropredios"
              Ejecuta()

                'tortilleria
                SQL = "DELETE FROM tortilleria"
                Ejecuta()

                'otros
                SQL = "DELETE FROM otrosing"
           Ejecuta()

                'depositos
                SQL = "DELETE FROM depositosip"
               Ejecuta()

                'lista de ingresos
                SQL = "DELETE FROM ingpropios"
               Ejecuta()

                'resumen de ingreso
                SQL = "DELETE FROM ingpropiosres"
               Ejecuta()

                'egresos
                SQL = "DELETE FROM egresosip"
                Ejecuta()

                'cuentas
                SQL = "DELETE FROM cuentas"
                Ejecuta()

                MessageBox.Show("Toda la informacion de ingresos propios ha sido eliminada correctamente." & Chr(13) & "Debe volver a iniciar el sistema", "Eliminar datos de Ingresos Propios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                ControlPanelFrm.Close()
            Catch Ex As MySqlException
                MessageBox.Show(Ex.Message, "Ocurrio un error al Eliminar la información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Sub Ejecuta()
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMCmd.ExecuteNonQuery()
    End Sub


    Private Sub BorrarDatosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConectaServer()
    End Sub
End Class