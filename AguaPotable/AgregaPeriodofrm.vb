Imports MySql.Data.MySqlClient
Public Class AgregaPeriodofrm
    Public Mespagado, AnoPagado, Tarifa As Short 'le pasan el no. del mes hasta cuando pago
    Public Comando As String
    Public cancelado As Boolean
    Private Sub CerrarBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBrn.Click
        If Comando = "Historial" Then
            If MessageBox.Show("¿Registrar la nueva toma sin historial?", "Registro de nueva toma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Now.Month < 10 Then
                    NuevaTomafrm.UltimoPago = Now.Year & "-0" & Now.Month
                    NuevaTomafrm.PagHasta = "0" & Now.Month & "-" & Now.Year
                Else
                    NuevaTomafrm.UltimoPago = Now.Year & "-" & Now.Month
                    NuevaTomafrm.PagHasta = Now.Month & Now.Year
                End If
                If Now.Day < 10 Then
                    NuevaTomafrm.UltimoPago = NuevaTomafrm.UltimoPago & "-0" & Now.Day
                Else
                    NuevaTomafrm.UltimoPago = NuevaTomafrm.UltimoPago & "-" & Now.Day
                End If
            Else
                Exit Sub
            End If
        End If
        cancelado = True
        Me.Close()
    End Sub

    Private Sub AceptarBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBrn.Click
        ObtenNMes(Me.MesCmb.Text)
        PagHasta()
        Registro()
        If Comando = "Nuevo" Then
            If Me.MesCmb.Text <> "" And Me.AnoCmb.Text <> "" Then
                'comprobar que no repita cobro
                If Val(NoMes) <= Mespagado And Val(Me.AnoCmb.Text) <= AnoPagado Then
                    MessageBox.Show("El periodo que intenta agregar, es inferior a la fecha actual", "Cobro de agua Potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'ConectaServer()
                Dim PagHasta, PagApart As String
                Dim Pinicio, Pfin As String
                'ObtenNMes(Me.MesCmb.Text)
                PagHasta = NoMes & "-" & Me.AnoCmb.Text
                If Mespagado = 12 Then
                    PagApart = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(0)
                Else
                    'el mes pagado da como resultado un mes mas, /e pago mes 11 , devilvera mes diciembre al obtener nombre
                    PagApart = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Mespagado)
                End If

                If AnoPagado > 0 Then
                    If Mespagado < 10 Then
                        'Pinicio = Now.Year & "0" & Mespagado
                        Pinicio = AnoPagado & "0" & Mespagado
                    Else
                        Pinicio = AnoPagado & Mespagado
                    End If

                Else
                    If Mespagado < 10 Then
                        Pinicio = Now.Year & "0" & Mespagado
                    Else
                        Pinicio = Now.Year & Mespagado
                    End If
                End If

                Pfin = Val(Me.AnoCmb.Text) & NoMes


                'calcular periodo
                SQL = "SELECT PERIOD_DIFF(" & Pfin & "," & Pinicio & ") as meses"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                If DatosMDR.HasRows = True Then
                    DatosMDR.Read()
                    Dim Total As Short
                    Total = (Val(DatosMDR!meses) * Val(CobrarAguafrm.DetallesDtg.Item(1, CobrarAguafrm.DetallesDtg.Rows.Count - 1).Value.ToString) * Val(CobrarAguafrm.NoTomasTxt.Text))
                    'obtener el mes de inicio
                    Dim Mes, Ano As Short
                    Mes = Mespagado
                    If Mes = 12 Then
                        Mes = 0
                        Ano = Val(Mid(Pinicio, 1, 4)) + 1
                    Else
                        Ano = Val(Mid(Pinicio, 1, 4))
                    End If
                    'agregar a la lista de detalles
                    Dim Mesini, MesFin As String
                    Mesini = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Mes)
                    Mes = Mid(Pfin, 5, 2)
                    'If Mes = 12 Then
                    Mes = Mes - 1
                    'End If
                    MesFin = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Mes)
                    CobrarAguafrm.DetallesDtg.Rows.Add(Mesini & "-" & Ano & " : " & MesFin & "-" & Mid(Pfin, 1, 4), Val(CobrarAguafrm.DetallesDtg.Item(1, CobrarAguafrm.DetallesDtg.Rows.Count - 1).Value.ToString), Val(DatosMDR!meses), Total)
                    CobrarAguafrm.PagoHastaTxt.Text = Mid(Pfin, 5, 2) & "-" & Mid(Pfin, 1, 4)
                    'Me.DatosDtg.Item(9, r).Value = Val(Me.DatosDtg.Item(9, r).Value.ToString) + (Total * Val(Me.DatosDtg.Item(1, r).Value.ToString))

                    'Informar del posible caso si hy una tarifa mas reciente
                    MessageBox.Show("El importe del nuevo periodo agregado, se calculo en base al P.U. del ultimo periodo mostrado." & Chr(13) & "Si hay otra cuota mas reciente, salga sin cobrar y reingrese a cobrar sin elegir un limite de pago *Pago Hasta*", "Cobro de Agua Potable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                Me.MesCmb.SelectedValue = ""
                DatosMDR.Close()
                'SQLCnn.Close()
                cancelado = False
                Me.Close()
            Else
                cancelado = True
                If MessageBox.Show("No ha seleccionado un mes y el año" & Chr(13) & "¿Desea cancelar esta opción?", "Pagar por adelantado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Me.Close()
                End If
                'MessageBox.Show("Seleccione un mes y un año", "Pagar hasta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Sub Registro()
        If Comando = "Historial" Then
            If Me.MesCmb.Text <> "" And Me.AnoCmb.Text <> "" Then
                'cargar la primera cuota de la tarifa
                SQL = "SELECT apar_mes, apar_ano from detarifagua where id_tarifa =" & Tarifa & " order by id_tarifa desc limit 1"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                'comprobar que si ahi datos de configuracion
                Dim Mes, Ano As Short
                Mes = 0
                Ano = 0
                While DatosMDR.Read()
                    Mes = DatosMDR!apar_mes
                    Ano = DatosMDR!apar_ano
                End While
                DatosMDR.Close()

                'verificar que exista una cuota para ese periodo
                If Val(Me.AnoCmb.Text) < Ano Then
                    If Val(Me.AnoCmb.Text) + 1 = Ano Then
                        If Mes = 1 And Val(NoMes) = 12 Then
                            'permitira que se registre
                        Else
                            MessageBox.Show("No existe ninguna cuota para este periodo", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("No existe ninguna cuota para este periodo", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If

                If Val(Me.AnoCmb.Text) = Ano And Val(NoMes) < Mes Then
                    MessageBox.Show("No existe ninguna cuota para este periodo", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                NuevaTomafrm.UltimoPago = Me.AnoCmb.Text & "-" & NoMes & "-" & Date.DaysInMonth(Me.AnoCmb.Text, NoMes)
                NuevaTomafrm.PagHasta = NoMes & "-" & Me.AnoCmb.Text
                Me.Close()
            Else
                If MessageBox.Show("¿Registrar la nueva toma sin historial?", "Registro de nueva toma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'NuevaTomafrm.UltimoPago = Me.MesCmb.Text & "-" & Me.AnoCmb.Text
                    If Now.Month < 10 Then
                        NuevaTomafrm.UltimoPago = Now.Year & "-0" & Now.Month
                        NuevaTomafrm.PagHasta = "0" & Now.Month & "-" & Now.Year
                    Else
                        NuevaTomafrm.UltimoPago = Now.Year & "-" & Now.Month
                        NuevaTomafrm.PagHasta = Now.Month & Now.Year
                    End If
                    If Now.Day < 10 Then
                        NuevaTomafrm.UltimoPago = NuevaTomafrm.UltimoPago & "-0" & Now.Day
                    Else
                        NuevaTomafrm.UltimoPago = NuevaTomafrm.UltimoPago & "-" & Now.Day
                    End If
                    Me.Close()
                End If
            End If
        End If
    End Sub
    Sub PagHasta()
        If Comando = "PagHasta" Then
            If Me.MesCmb.Text <> "" And Me.AnoCmb.Text <> "" Then
                ObtenNMes(Me.MesCmb.Text)
                If Val(NoMes) > Now.Month And Val(Me.AnoCmb.Text) = Now.Year Then
                    MessageBox.Show("El mes elegido es superior al actual", "Seleccionar fecha de pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Now.Month < 10 Then
                        CobrarAguafrm.PFinPer = "0" & Now.Month
                    Else
                        CobrarAguafrm.PFinPer = Now.Month
                    End If
                    CobrarAguafrm.PFinPer = CobrarAguafrm.PFinPer & "-" & Now.Year
                Else

                    If Val(NoMes) = Now.Month And Now.Day < DiaCobroMes And Val(AnoCmb.Text) = Now.Year Then
                        If Val(NoMes - 1) < 10 Then
                            CobrarAguafrm.PFinPer = "0" & Val(NoMes) - 1
                        Else
                            CobrarAguafrm.PFinPer = Val(NoMes) - 1 'aqui no recuerdo que hace
                        End If
                    Else
                        CobrarAguafrm.PFinPer = NoMes
                    End If
                    CobrarAguafrm.PFinPer = CobrarAguafrm.PFinPer & "-" & Me.AnoCmb.Text
                End If
                Me.Close()
            Else
                MessageBox.Show("Seleccione un mes y un año")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub AgregaPeriodofrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cancelado = True
        Me.AnoCmb.Items.Clear()
        Me.AnoCmb.Text = ""
        Me.MesCmb.SelectedValue = ""
        Me.MesCmb.SelectedItem = Nothing
        Me.MesCmb.Text = ""
        Dim i As Short
        If Comando = "" Then
            Exit Sub
            Me.Close()
        End If
        If Comando = "PagHasta" Then
            Dim c As Short
            c = 4
            For i = CobrarAguafrm.AnoPagado To Now.Year
                Me.AnoCmb.Items.Add(i)
                '                c -= 1
            Next
            Dim MesM As String
            'auxiliar para nuevo año, ayuda si es enero de nuevo año
            Dim auxanonv As Boolean
            auxanonv = False
            If Now.Day >= DiaCobroMes Then
                MesM = Now.Month
            Else
                'aqui genera un error si el mes es enero porque el indice es 0, y al restarle uno para evitar que el mes sea enero, deberia volverse a 12 y un año anterior
                MesM = Now.Month - 1
                If MesM = 0 Then
                    MesM = 12
                    auxanonv = True
                End If
            End If
            Me.MesCmb.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(MesM - 1).ToLower
            If auxanonv = True Then
                Me.AnoCmb.Text = Now.Year - 1
            Else
                Me.AnoCmb.Text = Now.Year
            End If

            Me.MesCmb.Focus()
            Exit Sub
        End If
        If Comando = "Historial" Then
            Dim c As Short
            c = 4
            For i = 1 To 4
                Me.AnoCmb.Items.Add(Now.Year - c)
                c -= 1
            Next
        End If
        For i = 0 To 3
            Me.AnoCmb.Items.Add(Now.Year + i)
        Next

    End Sub

    Private Sub MesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MesCmb.SelectedIndexChanged
        Me.MesCmb.Text = Me.MesCmb.SelectedItem
    End Sub

    Private Sub AnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnoCmb.SelectedIndexChanged
        Me.AnoCmb.Text = Me.AnoCmb.SelectedItem
    End Sub

    Private Sub MesCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MesCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub AnoCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AnoCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class