Imports MySql.Data.MySqlClient
Public Class ConfigNotificFrm

    Private Sub ConfigNotificFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQL = "SELECT municipio, tesorero, textoagua from configuracion"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.Label5.Text = DatosMDR!municipio.ToString & " A " & Now.Date.ToLongDateString
            Me.TesoreroTxt.Text = DatosMDR!tesorero.ToString
            Me.TextoTxt.Text = DatosMDR!textoagua.ToString
            DatosMDR.Close()
        End If
        DatosMDR.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        If Me.TesoreroTxt.Text <> "" And Me.TextoTxt.Text <> "" Then
            SQL = "UPDATE configuracion set tesorero = '" & Me.TesoreroTxt.Text & "', textoagua='" & Me.TextoTxt.Text & "'"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMCmd.ExecuteNonQuery()
            Me.Close()
        Else
            MessageBox.Show("Escriba el texto que aparecerá en la notificación de adeudos", "Sistema de Agua Potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class