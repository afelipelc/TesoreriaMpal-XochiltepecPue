Imports MySql.Data.MySqlClient
Public Class Loginfrm

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        'Shell("taskkill.exe /S localhost /F /IM mysqld.exe", AppWinStyle.MinimizedNoFocus) 'kill mysql server
        Shell(Application.StartupPath & "\mysql\bin\mysqladmin --password=accessdenied --user=root shutdown", AppWinStyle.MinimizedNoFocus) 'shutdown mysql server
        Me.Close()
    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        'conprobar login de usuario
        ConectaServer()
        If Me.NombreUsuarioTxt.Text <> "" And Me.ContrasenaTxt.Text <> "" Then
            SQL = "SELECT * from usuarios where nombre='" & Me.NombreUsuarioTxt.Text & "' and clave=MD5('" & Me.ContrasenaTxt.Text & "')"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                DatosMCmd.Dispose()
                DatosMDR.Close()
                SQLCnn.Close()
                Me.TopMost = False
                Me.Hide()
                ControlPanelFrm.Show()
                'DatosMDR.Read()
                'ExtractoNo = DatosMDR!ExtractoNo
                'End While
                'DatosMDR.Close()
            Else
                MessageBox.Show("Nombre de usuario y contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.NombreUsuarioTxt.Text = ""
                Me.ContrasenaTxt.Text = ""
                DatosMCmd.Dispose()
                DatosMDR.Close()
                Me.NombreUsuarioTxt.Focus()
            End If

        Else
            MessageBox.Show("Ingrese Nombre de usuario y contraseña", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        SQLCnn.Close()
    End Sub
    Private Sub Loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show("Ingrese Nombre de usuario y contraseña", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Me.TopMost = True
        Me.NombreUsuarioTxt.Focus()
    End Sub
End Class
