Imports MySql.Data.MySqlClient
Public Class CostoRegistrofrm
    Dim RegCosto As Boolean
    Private Sub CostoRegistrofrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CostoTxt.Focus()
        RegCosto = False
        SQL = "SELECT costoregistro from configagua limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.CostoTxt.Text = Val(DatosMDR!costoregistro)
            RegCosto = True
        Else
            Me.CostoTxt.Text = 0
            RegCosto = False
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If RegCosto = True Then
            SQL = "UPDATE configagua SET costoregistro=" & Me.CostoTxt.Text & ""
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMCmd.ExecuteNonQuery()
        Else
            SQL = "INSERT INTO configagua(costoregistro) values(" & Me.CostoTxt.Text & ")"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMCmd.ExecuteNonQuery()
        End If
        Me.Close()
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.CostoTxt.Text = ""
        Me.Close()
    End Sub
End Class