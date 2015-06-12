Imports MySql.Data.MySqlClient
Public Class UsuariosFrm

    Private Sub UsuariosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsuariosDtg.Rows.Clear()
        ConectaServer()
        CargarUsuarios()
    End Sub
    Sub CargarUsuarios()
        SQL = "SELECT * from usuarios"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        While DatosMDR.Read
            Me.UsuariosDtg.Rows.Add(DatosMDR!id, DatosMDR!nombre, "******")
        End While
        DatosMDR.Close()
    End Sub

    Private Sub NuevoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoBtn.Click
        'agregar el usuario
        SQL = "INSERT INTO usuarios (nombre,clave) values('Nombre',MD5('suclave'))"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMCmd.ExecuteNonQuery()
        Me.UsuariosDtg.Rows.Clear()
        CargarUsuarios()
    End Sub

    Private Sub EliminarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBtn.Click
        If Me.UsuariosDtg.Rows.Count > 0 Then
            If MessageBox.Show("¿Confirma eliminar el usuario : " & Me.UsuariosDtg.CurrentRow.Cells(1).Value.ToString & " ?", "Administración de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                SQL = "DELETE FROM  usuarios where id=" & Me.UsuariosDtg.CurrentRow.Cells(0).Value.ToString & " limit 1"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()
                Me.UsuariosDtg.Rows.Clear()
                CargarUsuarios()
            End If
        End If
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub

    Private Sub UsuariosDtg_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UsuariosDtg.CellEndEdit
        SQL = "UPDATE usuarios set nombre='" & Me.UsuariosDtg.Item(1, UsuariosDtg.CurrentRow.Index).Value.ToString & "', clave=MD5('" & Me.UsuariosDtg.Item(2, UsuariosDtg.CurrentRow.Index).Value.ToString & "') where id=" & Me.UsuariosDtg.Item(0, UsuariosDtg.CurrentRow.Index).Value.ToString
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMCmd.ExecuteNonQuery()
    End Sub
End Class