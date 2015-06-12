Imports MySql.Data.MySqlClient
Public Class NuevoEgresoFrm
    Dim Origen As String
    Dim EnCaja, EnBanco, Saldo As Double
    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Me.CantidadTxt.Text <> "" And Me.AnombreDeTxt.Text <> "" And Me.DestinoTxt.Text <> "" And Origen <> "" Then
            If Origen = "Retiro" And Me.NoChequeTxt.Text = "" Then
                MessageBox.Show("Si el Origen es Retiro, debe ingresar el Numero de cheque", "Registro de Egreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.NoChequeTxt.Focus()
                Exit Sub
            End If
            Select Case Origen
                Case "Retiro"
                    If Val(Me.CantidadTxt.Text) > Saldo Then
                        MessageBox.Show("El saldo en la cuenta seleccionada no cubre el importe del egreso", "Registro de Egreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.CantidadTxt.Focus()
                        Exit Sub
                    End If
                Case "De_Caja"
                    If Val(Me.CantidadTxt.Text) > EnCaja Then
                        MessageBox.Show("El ahorro en Caja no cubre el importe del egreso", "Registro de Egreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.CantidadTxt.Focus()
                        Exit Sub
                    End If
            End Select
            If MessageBox.Show("¿Confirma registrar el egreso?", "Registro de Egresos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    'aqui se registra el egreso
                    SQL = "INSERT INTO egresosip (nombrecta,fecha,cantidad,origen,cheque,destino,anombrede,cargo) values('" & Me.CuentasCmb.Text & "','" & Me.FechaLbl.Text & "'," & Me.CantidadTxt.Text & ",'" & Origen & "','" & Me.NoChequeTxt.Text & "','" & Me.DestinoTxt.Text & "','" & Me.AnombreDeTxt.Text & "','" & Me.CargoTxt.Text & "')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMCmd.ExecuteNonQuery()

                    'actualizar los retiros de la cuenta seleccinada
                    SQL = "UPDATE cuentas set retirado= retirado + " & Me.CantidadTxt.Text.ToString & ", saldo= saldo - " & Me.CantidadTxt.Text.ToString & " limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMCmd.ExecuteNonQuery()

                    'actualizar la el resumen de ingresos
                    'actualizar la tabla general de ingresos propios

                    SQL = "SELECT * from ingpropiosres limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion

                    If DatosMDR.HasRows = True Then
                        DatosMDR.Close()
                        Select Case Origen
                            Case "Retiro"
                                SQL = "UPDATE ingpropiosres set egresos= egresos + " & Me.CantidadTxt.Text & ", retirado= retirado + " & Me.CantidadTxt.Text & ", enbanco= enbanco - " & Me.CantidadTxt.Text & " limit 1"
                            Case "De_Caja"
                                SQL = "UPDATE ingpropiosres set egresos= egresos + " & Me.CantidadTxt.Text & ", encaja= encaja - " & Me.CantidadTxt.Text & " limit 1"
                        End Select
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    End If

                    MessageBox.Show("El registro del Egreso ha sido realizado con éxito", "Registro de Egreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch Ex As MySqlException
                    MessageBox.Show(Ex.Message)
                    DatosMDR.Close()
                End Try
            End If
        Else
            MessageBox.Show("Cantidad, Origen, Destino y A nombre de; Son obligatorios", "Registro de Egreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub NuevoEgresoFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LimpiarDatos()
        e.Cancel = False
    End Sub
    Sub LimpiarDatos()
        Me.AnombreDeTxt.Text = ""
        Me.CantidadTxt.Text = ""
        Me.NoChequeTxt.Text = ""
        Me.DestinoTxt.Text = ""
        Me.CargoTxt.Text = ""
        Me.ECajaRbtn.Checked = False
        Me.ERetRbtn.Checked = False
        Me.CuentasCmb.Items.Clear()
        Me.CuentasCmb.SelectedValue = ""
        Me.CuentasCmb.SelectedItem = Nothing
        Me.CuentasCmb.Text = ""
        Me.NumeroCtaLbl.Text = "------"
        Me.SaldoLbl.Text = "$0.0"
    End Sub
    Private Sub NuevoEgresoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Origen = ""
        EnCaja = 0
        EnBanco = 0
        Saldo = 0
        'cargar los nombres de cuentas
        SQL = "SELECT nombrecta from cuentas"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        While DatosMDR.Read
            Me.CuentasCmb.Items.Add(DatosMDR!nombrecta.ToString)
        End While
        DatosMDR.Close()

        Me.CuentasCmb.Enabled = False
        Me.NumeroCtaLbl.Text = "-------"

        Me.NoChequeTxt.ReadOnly = True
        If Now.Month < 10 Then
            Me.FechaLbl.Text = Now.Year & "-0" & Now.Month
        Else
            FechaLbl.Text = Now.Year & "-" & Now.Month
        End If

        If Now.Day < 10 Then
            FechaLbl.Text += "-0" & Now.Day
        Else
            FechaLbl.Text += "-" & Now.Day
        End If

        'comprobar si ahi fondos para registrar el egreso
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
        End If
        DatosMDR.Close()
        Me.EnCajaLbl.Text = Format(CStr(EnCaja), "Currency")
        Me.EnBancoLbl.Text = Format(CStr(EnBanco), "Currency")
        Me.CantidadTxt.Focus()
    End Sub

    Private Sub ECajaRbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECajaRbtn.CheckedChanged
        Origen = "De_Caja"
        Me.NoChequeTxt.Text = " "
        Me.CuentasCmb.SelectedValue = ""
        Me.CuentasCmb.SelectedItem = Nothing
        Me.CuentasCmb.Text = ""
        Me.CuentasCmb.Enabled = False
        Me.NumeroCtaLbl.Text = "-------"
        Saldo = 0
        Me.NoChequeTxt.ReadOnly = True
        Me.DestinoTxt.Focus()
    End Sub

    Private Sub ERetRbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ERetRbtn.CheckedChanged
        Origen = "Retiro"
        Me.NoChequeTxt.Text = ""
        Me.CuentasCmb.Enabled = True
    End Sub

    Private Sub CantidadTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        NumeroDec(e, Me.CantidadTxt)
        If KeyAscii = 13 Then
            Me.DestinoTxt.Focus()
            Exit Sub
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub

    Private Sub CuentasCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasCmb.SelectedIndexChanged
        Me.CuentasCmb.Text = Me.CuentasCmb.SelectedItem
        SQL = "SELECT numero, saldo from cuentas where nombrecta='" & Me.CuentasCmb.Text & "' limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.NumeroCtaLbl.Text = DatosMDR!numero.ToString
            Saldo = Val(DatosMDR!saldo.ToString)
            Me.SaldoLbl.Text = Format(CStr(Saldo), "Currency")
            Me.NoChequeTxt.ReadOnly = False
            Me.NoChequeTxt.Focus()
        Else
            MessageBox.Show("Compruebe que la cuenta exista", "Nuevo egreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        DatosMDR.Close()
    End Sub
    Private Sub CuentasCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CuentasCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        'si presiona enter
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class