Imports MySql.Data.MySqlClient
Public Class ResumenGeneralFrm
    Dim EnCaja, EnBanco As Double
    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        Me.Close()
    End Sub

    Private Sub ResumenGeneralFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'comprobar todo lo que ahi
        SQL = "SELECT * from ingpropiosres limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            EnCaja = DatosMDR!encaja
            EnBanco = DatosMDR!enbanco
            Me.IngresosLbl.Text = Format(CStr(DatosMDR!ingresos), "Currency")
            Me.EgresosLbl.Text = Format(CStr(DatosMDR!egresos), "Currency")
            Me.DepositadoLbl.Text = Format(CStr(DatosMDR!depositado), "Currency")
            Me.RetiradoLbl.Text = Format(CStr(DatosMDR!retirado), "Currency")
            Me.EnCajaLbl.Text = Format(CStr(EnCaja), "Currency")
            Me.EnBancoLbl.Text = Format(CStr(EnBanco), "Currency")
            Me.TotalLbl.Text = Format(CStr(EnCaja + EnBanco), "Currency")
        End If
        DatosMDR.Close()
    End Sub
End Class