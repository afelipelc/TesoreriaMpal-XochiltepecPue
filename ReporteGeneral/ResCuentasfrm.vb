Imports MySql.Data.MySqlClient
Public Class ResCuentasfrm

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.Close()
    End Sub

    Private Sub ResCuentasfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DatosDtg.Rows.Clear()
        SQL = "SELECT * from cuentas"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        While DatosMDR.Read
            Me.DatosDtg.Rows.Add(DatosMDR!id, DatosMDR!nombrecta, DatosMDR!numero, DatosMDR!descripcion, DatosMDR!depositado, DatosMDR!retirado, DatosMDR!saldo)
        End While
        DatosMDR.Close()
        Dim Depositado, Retirado, Saldo As Double
        Dim i As Short
        For i = 0 To Me.DatosDtg.Rows.Count - 1
            Depositado = Depositado + Val(Me.DatosDtg.Item(4, i).Value.ToString)
            Retirado = Retirado + Val(Me.DatosDtg.Item(5, i).Value.ToString)
            Saldo = Saldo + Val(Me.DatosDtg.Item(6, i).Value.ToString)
        Next
        Me.DatosDtg.Rows.Add(" ", " ", " ", "TOTALES:", Format(CStr(Depositado), "Currency"), Format(CStr(Retirado), "Currency"), Format(CStr(Saldo), "Currency"))
    End Sub
End Class