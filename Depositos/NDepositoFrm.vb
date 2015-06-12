Imports MySql.Data.MySqlClient
Public Class NDepositoFrm
    Dim EnCaja As Double

    Private Sub NDepositoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EnCajaLbl.Text = "$0.0"
        Me.NumeroCtaLbl.Text = "------"
        EnCaja = 0
        Me.NoFichaTxt.Text = ""
        Me.CantidadTxt.Text = ""
        Me.NoFichaTxt.Enabled = False
        Me.CantidadTxt.Enabled = False

        Me.CuentasCmb.Items.Clear()
        Me.CuentasCmb.SelectedValue = ""
        Me.CuentasCmb.SelectedItem = Nothing
        Me.CuentasCmb.Text = ""

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
        End If
        DatosMDR.Close()
        Me.EnCajaLbl.Text = Format(CStr(EnCaja), "Currency")
        Me.NoFichaTxt.Focus()
    End Sub
    Private Sub CantidadTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        NumeroDec(e, Me.CantidadTxt)
        If KeyAscii = 13 Then
            Me.AceptarBtn.Focus()
            Exit Sub
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Me.NoFichaTxt.Text <> "" And Val(Me.CantidadTxt.Text) > 0 Then
            If MessageBox.Show("¿Confirma registrar el Deposito?", "Registro de Depositos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    If Val(Me.CantidadTxt.Text) <= EnCaja Then
                        'verificar que el numero de ficha no exista
                        'comprobar si ahi fondos para registrar el egreso
                        SQL = "SELECT * from depositosip where ficha='" & Me.NoFichaTxt.Text & "' limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMDR = DatosMCmd.ExecuteReader
                        'comprobar que si encontro el numero de ficha
                        If DatosMDR.HasRows = True Then
                            MessageBox.Show("El numero de ficha: " & Me.NoFichaTxt.Text & ". Ya se encuentra registrado", "Registro de nuevo Deposito", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            DatosMDR.Close()
                            Exit Sub
                        End If
                        DatosMDR.Close()

                        'aqui se registra el egreso
                        SQL = "INSERT INTO depositosip (nombrecta,ficha,cantidad,fecha) values('" & Me.CuentasCmb.Text.ToString & "','" & Me.NoFichaTxt.Text & "'," & Me.CantidadTxt.Text & ",'" & Me.FechaLbl.Text & "')"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()

                        'actualizar lo depositado en la cuenta
                        SQL = "UPDATE cuentas set depositado= depositado + " & Me.CantidadTxt.Text.ToString & ", saldo= saldo + " & Me.CantidadTxt.Text.ToString & " where nombrecta='" & Me.CuentasCmb.Text.ToString & "' limit 1"
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
                            SQL = "UPDATE ingpropiosres set depositado= depositado + " & Me.CantidadTxt.Text & ", encaja= encaja - " & Me.CantidadTxt.Text & ", enbanco= enbanco + " & Me.CantidadTxt.Text & " limit 1"
                            DatosMCmd = New MySqlCommand
                            DatosMCmd.CommandText = SQL
                            DatosMCmd.Connection = SQLCnn
                            DatosMCmd.ExecuteNonQuery()
                        End If
                        MessageBox.Show("El registro del Deposito ha sido realizado con éxito", "Registro de Depositos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("El fondo en caja, no cubre la cantidad del deposito", "Registro de deposito", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Los campos son obligatorios", "Registro de Deposito", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub

    Private Sub CuentasCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasCmb.SelectedIndexChanged
        Me.CuentasCmb.Text = Me.CuentasCmb.SelectedItem
        SQL = "SELECT numero from cuentas where nombrecta='" & Me.CuentasCmb.Text & "' limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.NumeroCtaLbl.Text = DatosMDR!numero.ToString
            Me.NoFichaTxt.Enabled = True
            Me.CantidadTxt.Enabled = True
            Me.NoFichaTxt.Focus()
        Else
            MessageBox.Show("Compruebe que la cuenta exista", "Nuevo deposito", MessageBoxButtons.OK, MessageBoxIcon.Error)
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