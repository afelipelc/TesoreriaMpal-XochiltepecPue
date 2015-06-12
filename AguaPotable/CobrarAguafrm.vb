Imports System.String
Imports System
Imports MySql.Data.MySqlClient
Imports ImprimirFactura
Public Class CobrarAguafrm
    Public IdToma As Integer
    Dim Tarifa As Short
    Public AnoPagado, Mespagado As Short
    Dim Encontrado, Cerrar As Boolean
    Public Comando, Otrocom As String
    Public PFinPer As String
    Dim ImprimirFactura As ImprimirFactura.Imprimirfrm
    Private Sub CobrarAguafrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If IdToma > 0 Then
                AguaPotablefrm.Cobrado = False
                Me.OtroPeriodoBtn.Enabled = False
                Me.AceptarBtn.Enabled = False
                Me.NotificacionBtn.Enabled = False
                Me.SuPagoTxt.Enabled = False
                Me.SuCambioTxt.Enabled = False
                Me.RecargoChk.Enabled = False
                Me.DescuentoChk.Enabled = False
                Me.RecargoTxt.Enabled = False
                Me.Descuentotxt.Enabled = False
                Me.RecargoChk.Checked = False
                Me.DescuentoChk.Checked = False
                Me.ObservacionesTxt.ReadOnly = True
                Cerrar = False
                'si le enviaron numero de toma, cargar todos los datos
                'ConectaServer()
                Select Case Comando

                    Case "Nuevo"
                        CargarToma()
                        'Me.AceptarBtn.Enabled = False
                        PFinPer = ""
                        AgregaPeriodofrm.Comando = "PagHasta"
                        AgregaPeriodofrm.ShowDialog()
                        Me.NotificacionBtn.Enabled = True
                        If Now.Month < 10 Then
                            Me.FechaLbl.Text = Now.Year & "-0" & Now.Month
                        Else
                            Me.FechaLbl.Text = Now.Year & "-" & Now.Month
                        End If

                        If Now.Day < 10 Then
                            Me.FechaLbl.Text += "-0" & Now.Day
                        Else
                            Me.FechaLbl.Text += "-" & Now.Day
                        End If

                        If Encontrado = True Then
                            'CargarAdeudo(Me.TomaIdTxtn.Value)
                            CargarAdeudos()
                           
                            CalculaDatos()
                            'aqui comprobar si el adeudo es 0, no poner nada
                            If Val(Me.AdeuTotTxt.Text) <= 0 Then
                                Me.PagoHastaTxt.Text = PagoDesdeTxt.Text
                            End If
                            Me.AdeudoNetoTxt.Text = Me.AdeuTotTxt.Text
                            UltimoPago()
                            UltimaFactura()
                            Me.OtroPeriodoBtn.Enabled = True
                        End If
                        Me.OtroPeriodoBtn.Enabled = True
                        Me.SuPagoTxt.Enabled = True
                        Me.SuCambioTxt.Enabled = True
                        Me.RecargoChk.Enabled = True
                        Me.DescuentoChk.Enabled = True
                        Me.ObservacionesTxt.ReadOnly = False
                        Me.SuPagoTxt.Focus()
                    Case "Abrir"
                        'Cargar Ultimo Pago realizado de la toma
                        TomaUltimoPago()
                End Select
                'cargar el numero del ultimo pago realizado

                'UltimoPago()
                'cargar la ultima factura expedida

                'SQLCnn.Close()

                'SQLCnn.Close()
            Else
                Me.Close()
            End If
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
        End Try
    End Sub
    Sub CalculaDatos()
        If Me.DetallesDtg.Rows.Count > 0 Then
            Me.TotalMesesTxt.Text = ""
            Me.AdeuTotTxt.Text = ""
            Me.Conceptostxt.Text = ""

            Dim c As Integer
            For c = 0 To Me.DetallesDtg.Columns.Count - 1
                Me.DetallesDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            Me.Conceptostxt.Text = Me.DetallesDtg.Rows.Count

            For c = 0 To Me.DetallesDtg.Rows.Count - 1
                Me.TotalMesesTxt.Text = Val(Me.TotalMesesTxt.Text) + Val(Me.DetallesDtg.Item(2, c).Value.ToString)
                Me.AdeuTotTxt.Text = Val(Me.AdeuTotTxt.Text) + Val(Me.DetallesDtg.Item(3, c).Value.ToString)
            Next
        End If
    End Sub

    Sub CargarToma()
        Try
            SQL = "SELECT * from aguapotable where id_toma='" & IdToma & "'"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                DatosMDR.Read()
                Me.Nombrecmb.Text = DatosMDR!nombre
                Me.LocalidadTxt.Text = DatosMDR!localidad
                Me.CalleTxt.Text = DatosMDR!calle
                Me.Numerotxt.Text = DatosMDR!numero
                Me.NoTomasTxt.Text = DatosMDR!tomas
                Me.Estadolbl.Text = DatosMDR!estado
                Me.FechaCancel.Text = DatosMDR!fechacancel
                Me.IdTomatxt.Text = IdToma
                Me.TaridaIdTxt.Text = DatosMDR!id_tarifa
                Dim PaMes, PaAno As Short
                PaMes = Val(Mid(DatosMDR!pagohasta.ToString, 1, 2))
                PaAno = Val(Mid(DatosMDR!pagohasta.ToString, 4, 7))
                AnoPagado = PaAno
                Mespagado = PaMes
                If PaMes = 12 Then
                    PaMes = 1
                    PaAno += 1
                Else
                    PaMes += 1
                End If
                If PaMes < 10 Then
                    Me.PagoDesdeTxt.Text = "0" & PaMes & "-" & PaAno
                Else
                    Me.PagoDesdeTxt.Text = PaMes & "-" & PaAno
                End If
                
                Tarifa = DatosMDR!id_tarifa
                'mostrar el estado de la toma
                If Me.Estadolbl.Text = "Suspendida" Or Me.Estadolbl.Text = "Cancelada" Then
                    Me.TitTomalbl.Visible = True
                    Me.Estadolbl.Visible = True
                    Me.TitEllbl.Visible = True
                    Me.FechaCancel.Visible = True
                Else
                    Me.TitTomalbl.Visible = False
                    Me.Estadolbl.Visible = False
                    Me.TitEllbl.Visible = False
                    Me.FechaCancel.Visible = False
                End If
                Encontrado = True
            Else

                Encontrado = False
                'IdContr = DatosMDR!pagohasta
            End If
            DatosMDR.Close()
            'cargar nombre de la tarifa
            If Encontrado = True Then
                NombreTarifa()
                'cargar adeudos
            Else
                MessageBox.Show("No se encontro la toma n�mero: " & IdToma, "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'SQLCnn.Close()
                Me.Dispose()
            End If
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
            'DatosMDR.Close()
        End Try
    End Sub

    Sub NombreTarifa()
        SQL = "SELECT nombre from tarifasagua where id_tarifa='" & Me.TaridaIdTxt.Text & "'"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.NombreTarifaTxt.Text = DatosMDR!nombre
        End If
        DatosMDR.Close()
    End Sub
    Sub CargarAdeudos()
        Try
            Dim Paso As Boolean
            SQL = "SELECT costo, apar_mes, apar_ano from detarifagua where id_tarifa=" & Tarifa & " order by apar_ano asc"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'cargar los detalles a la memoria
            Dim costo(0), apar_ano(0), apar_mes(0) As Short
            Dim Detalles, d As Short
            While DatosMDR.Read
                Detalles += 1
                ReDim Preserve costo(Detalles)
                ReDim Preserve apar_mes(Detalles)
                ReDim Preserve apar_ano(Detalles)
                costo(Detalles) = DatosMDR!costo
                apar_mes(Detalles) = DatosMDR!apar_mes
                apar_ano(Detalles) = DatosMDR!apar_ano
            End While
            DatosMDR.Close()

            'variables que auxilian al calculo
            Dim PInicio, PFin As String
            Dim PMes, PAno, FinMes, FinAno As Short
            Dim Mesini, MesFin As String
            Dim Mes, Ano As Short
            Dim Abortar, Tope As Boolean
            PMes = 0
            PAno = 0
            PMes = Val(Mid(Me.PagoDesdeTxt.Text, 1, 2)) - 1
            PAno = Val(Mid(Me.PagoDesdeTxt.Text, 4, 4))
            If PMes = 0 Then
                PMes = 12
                PAno -= 1
            End If

            If PMes < 10 Then 'comprobar que el mes pagado no sea menor que 10, sino agregarle un 0 --> 200805
                PInicio = PAno & "0" & PMes
            Else
                PInicio = PAno & PMes
            End If

            '#Aqui va la nueva forma de calcular
            If PAno <= Now.Year Then ''verificar si es igual o mayor que la fecha actual "pago al corriente o adelantado"
                'aqui se puede almacenar el periodo inicial

                '###### comprobar
                If Me.Estadolbl.Text = "Cancelada" Or Me.Estadolbl.Text = "Suspendida" Then
                    'si la toma est cancelada o suspendida
                    Dim nFecha As Date
                    nFecha = Me.FechaCancel.Text
                    FinMes = Val(Mid(nFecha.ToShortDateString, 4, 2))
                    FinAno = Val(Mid(nFecha.ToShortDateString, 7, 4))
                    Tope = True 'autoriza bortar despues de calcular
                Else
                    If PFinPer <> "" Then 'si el usuario eligio pagar hasta
                        FinMes = Mid(PFinPer, 1, 2)
                        FinAno = Mid(PFinPer, 4, 4)
                        Tope = True
                    Else 'sino el fin es el mes y a�o actual si llego el dia de cobro
                        FinAno = Now.Year 'a�o actual
                        If Now.Day >= DiaCobroMes Then 'comprobar si ya se puede cobrar a partir de este dia como mes completo
                            FinMes = Now.Month
                        Else
                            FinMes = Now.Month - 1
                        End If
                    End If

                End If
                '########## fin comprobar
                For d = 1 To Detalles 'recorrer los detalles
                    If Detalles > d Then 'si los detalles son mas del detalle actual
                        'comprobar si se debe abortar el proceso por toma cancelada o pago hasta
                        If Abortar = True Then
                            Exit For
                        End If
                        'obtener el periodo final antes de la siguiente tarifa
                        'comprobar que sea menor o igual al mes y ano elegidos como final
                        If FinAno <= apar_ano(d + 1) And apar_mes(d + 1) < FinMes Then 'si el a�o final es menor del de la tarifa o si es igual y el mes es igual o menor del mes final

                            If FinMes < 10 Then 'comprobar que el mes no sea menor que 10, sino agregarle un 0 --> 200805
                                PFin = FinAno & "0" & FinMes
                            Else
                                PFin = FinAno & FinMes
                            End If
                            'comprobar si la siguiente tarifa es mayor del periodo final, enonces abortar
                            'si el tope final viene de pago hasta o toma cancelada, entonces abortar
                            If Tope = True Or FinAno <= apar_ano(d + 1) And apar_mes(d + 1) < FinMes Then
                                Abortar = True
                            End If
                        Else
                            'comparar si el mes y ano de la nueva tarifa no es igual al periodo final calculado

                            'sino calcular el periodo final con el de la tarifa
                            If apar_mes(d + 1) = 1 Then 'si el mes de la siguiente tarifa es enero, entonces la tarifa actual termina en diciembre del a�o anterior
                                PFin = apar_ano(d + 1) - 1 & "12"
                            Else 'sino tomar como fin de la taria hasta el mes anterior del inicio de la nueva tarifa
                                If apar_mes(d + 1) - 1 < 10 Then 'comprobar que el mes no sea menor que 10, sino agregarle un 0 --> 200805
                                    PFin = apar_ano(d + 1) & "0" & apar_mes(d + 1) - 1 'tomar como fin hasta el mes anterior
                                Else
                                    PFin = apar_ano(d + 1) & apar_mes(d + 1) - 1
                                End If
                            End If
                        End If 'fin si el a�o de la tarifa es menor que el a�o final
                        'calcular la diferencia de meses y el importe
                        SQL = "SELECT PERIOD_DIFF(" & PFin & "," & PInicio & ") as meses"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMDR = DatosMCmd.ExecuteReader
                        If DatosMDR.HasRows = True Then
                            DatosMDR.Read()
                            'TotalMeses = TotalMeses + DatosMDR!meses 'sumar los meses de adeudo
                            'AdeudoToma = AdeudoToma + ((DatosMDR!meses * costo(d)) * Val(Me.NoTomasTxt.Text)) 'sumar el adeudo mas el nuevo adeudo de otra tarifa * el numero de tomas

                            'aqui se puede agregar el periodo a los detalles
                            'agregar a la lista de detalles el periodo inicial
                            'obtener el mes de inicio
                            Mes = Mid(PInicio, 5, 2)
                            If Mes = 12 Then
                                Mes = 0
                                Ano = Val(Mid(PInicio, 1, 4)) + 1
                            Else
                                Ano = Val(Mid(PInicio, 1, 4))
                            End If
                            Mesini = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Mes)
                            Mes = Mid(PFin, 5, 2)
                            Mes = Mes - 1
                            MesFin = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Mes)

                            Me.DetallesDtg.Rows.Add(Mesini & "-" & Ano & " : " & MesFin & "-" & Mid(PFin, 1, 4), costo(d), Val(DatosMDR!meses), ((DatosMDR!meses * costo(d)) * Val(Me.NoTomasTxt.Text)))
                            Me.PagoHastaTxt.Text = Mid(PFin, 5, 2) & "-" & Mid(PFin, 1, 4)
                            '#### fin agregar periodos
                        End If
                        DatosMDR.Close()

                        'se crea el nuevo perido de inicio
                        If apar_mes(d + 1) = 1 Then 'si el mes de la siguiente tarifa es enero, entonces la tarifa actual termina en diciembre del a�o anterior
                            PInicio = apar_ano(d + 1) - 1 & "12"
                        Else
                            If apar_mes(d + 1) - 1 < 10 Then 'comprobar que el mes no sea menor que 10, sino agregarle un 0 --> 200805
                                PInicio = apar_ano(d + 1) & "0" & apar_mes(d + 1) - 1 'tomar como fin hasta el mes anterior
                            Else
                                PInicio = apar_ano(d + 1) & apar_mes(d + 1) - 1
                            End If
                        End If
                    Else 'si es el ultimo detalle o el unico
                        'comprobar si se debe abortar el proceso por toma cancelada o pago hasta
                        If Abortar = True Then
                            Exit For
                        End If
                        '## generar el nuevo periodo final
                        'Aqui debemos comprobar si la toma esta cancelada o suspendida, si el usuario eligio pagar hasta, sino hay que tomar el mes y a�o actual
                        If FinMes < 10 Then
                            PFin = FinAno & "0" & FinMes
                        Else
                            PFin = FinAno & FinMes
                        End If
                        '## fin generar el nuevo final
                        'calcular la diferencia de meses y el importe
                        SQL = "SELECT PERIOD_DIFF(" & PFin & "," & PInicio & ") as meses"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMDR = DatosMCmd.ExecuteReader
                        If DatosMDR.HasRows = True Then
                            DatosMDR.Read()
                            'TotalMeses = TotalMeses + DatosMDR!meses 'sumar los meses de adeudo
                            'AdeudoToma = AdeudoToma + ((DatosMDR!meses * costo(d)) * Val(Me.NoTomasTxt.Text)) 'sumar el adeudo mas el nuevo adeudo de otra tarifa
                            'aqui se puede agregar el periodo a los detalles
                            'agregar a la lista de detalles el periodo inicial
                            'obtener el mes de inicio
                            Mes = Mid(PInicio, 5, 2)
                            If Mes = 12 Then
                                Mes = 0
                                Ano = Val(Mid(PInicio, 1, 4)) + 1
                            Else
                                Ano = Val(Mid(PInicio, 1, 4))
                            End If
                            Mesini = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Mes)
                            Mes = Mid(PFin, 5, 2)
                            Mes = Mes - 1
                            MesFin = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Mes)

                            Me.DetallesDtg.Rows.Add(Mesini & "-" & Ano & " : " & MesFin & "-" & Mid(PFin, 1, 4), costo(d), Val(DatosMDR!meses), ((DatosMDR!meses * costo(d)) * Val(Me.NoTomasTxt.Text)))
                            Me.PagoHastaTxt.Text = Mid(PFin, 5, 2) & "-" & Mid(PFin, 1, 4)
                            '#### fin agregar periodos

                        End If
                        DatosMDR.Close()

                    End If

                Next
                Abortar = False 'volver a falso por serguridad
            End If

            DatosMDR.Close()

        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
        End Try
    End Sub
    Sub TomaUltimoPago()
        Try
            SQL = "SELECT *  from cobroagua where id_toma= " & IdToma & " order by id_cobro desc limit 1"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                DatosMDR.Read()
                Me.IdTomatxt.Text = IdToma
                Me.NoFacturaTxt.Text = DatosMDR!nofactura.ToString
                Me.Nombrecmb.Text = DatosMDR!nombre.ToString
                Me.LocalidadTxt.Text = DatosMDR!localidad.ToString
                Me.CalleTxt.Text = DatosMDR!calle.ToString
                Me.Numerotxt.Text = DatosMDR!numero.ToString
                Me.TaridaIdTxt.Text = DatosMDR!id_tarifa
                Me.PagoDesdeTxt.Text = DatosMDR!pagodesde
                Me.PagoHastaTxt.Text = DatosMDR!pagohasta
                Me.NoTomasTxt.Text = DatosMDR!tomas
                Me.FechaLbl.Text = DatosMDR!fechapago
                Me.NoCobrotxt.Text = DatosMDR!id_cobro
                Me.AdeudoNetoTxt.Text = DatosMDR!importe
                Me.ObservacionesTxt.Text = DatosMDR!observaciones.ToString
                '.Text = DatosMDR!id_toma + 1
                DatosMDR.Close()
                NombreTarifa()

                'cargar los detalles
                SQL = "SELECT * from detcobagua where id_cobro= " & Me.NoCobrotxt.Text & " order by id_det asc"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                While DatosMDR.Read
                    Me.DetallesDtg.Rows.Add(DatosMDR!periodo, DatosMDR!p_unit, DatosMDR!totalmeses, DatosMDR!importe)
                End While
                DatosMDR.Close()
                CalculaDatos()
            Else
                MessageBox.Show("No se encontro ning�n pago realizado de la toma No. " & IdToma, "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'SQLCnn.Close()
                DatosMDR.Close()
                Me.Close()
            End If
            'DatosMCmd.Dispose()
            DatosMDR.Close()
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message, Ex.Number.ToString)
        End Try
    End Sub
    Sub UltimoPago()
        SQL = "SELECT id_cobro from cobroagua order by id_cobro desc limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.NoCobrotxt.Text = DatosMDR!id_cobro + 1
            '.Text = DatosMDR!id_toma + 1
        Else
            Me.NoCobrotxt.Text = 1
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub
    Sub UltimaFactura()
        SQL = "SELECT ultimafactura from configuracion limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.NoFacturaTxt.Text = DatosMDR!ultimafactura + 1
            '.Text = DatosMDR!id_toma + 1
        Else
            Me.NoFacturaTxt.Text = 1
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub
    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        'aqui se registra el cobro de agua
        If Comando = "Nuevo" And Val(Me.AdeudoNetoTxt.Text) > 0 Then

            'agregar las observaciones si no se especificaron
            If Me.RecargoTxt.Text <> "" And Me.ObservacionesTxt.Text = "" Then
                Me.ObservacionesTxt.Text = Me.ObservacionesTxt.Text + " Se aplico un recargo de " & Me.RecargoTxt.Text & " % igual a " & Me.RecargoLbl.Text
            End If

            If Me.Descuentotxt.Text <> "" And Me.ObservacionesTxt.Text = "" Then
                Me.ObservacionesTxt.Text = Me.ObservacionesTxt.Text + " Se aplico un descuento de " & Me.Descuentotxt.Text & " % igual a " & Me.DescuentoLbl.Text
            End If

            'conectar al servidor y registrar el pago de agua
            If MessageBox.Show("�Confima Registrar el Pago de agua?", "Cobro de agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    'ConectaServer()
                    SQL = "insert into cobroagua values(" & Me.NoCobrotxt.Text & "," & Me.NoFacturaTxt.Text & "," & Me.IdTomatxt.Text & "," & Me.TaridaIdTxt.Text & ",'" & _
                                        Me.Nombrecmb.Text & "','" & Me.LocalidadTxt.Text & "','" & Me.CalleTxt.Text & "','" & Me.Numerotxt.Text & "','" & Me.PagoDesdeTxt.Text & "','" & Me.PagoHastaTxt.Text & "'," & _
                                        Me.NoTomasTxt.Text & "," & Me.TotalMesesTxt.Text & "," & Me.AdeudoNetoTxt.Text & ",'" & Me.FechaLbl.Text & "','" & Me.ObservacionesTxt.Text.ToString & "')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()

                    'registrar los detalles
                    'obtener el ultimo detalle insertado
                    Dim UltimoDetalle As Integer
                    SQL = "SELECT id_det from detcobagua order by id_det desc limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        UltimoDetalle = DatosMDR!id_det
                        '.Text = DatosMDR!id_toma + 1
                    Else
                        UltimoDetalle = 0
                    End If
                    'DatosMCmd.Dispose()
                    DatosMDR.Close()

                    Dim i As Short
                    For i = 0 To Me.DetallesDtg.Rows.Count - 1
                        UltimoDetalle += 1
                        SQL = "insert into detcobagua values(" & UltimoDetalle & "," & Me.NoCobrotxt.Text & ",'" & _
                            Me.DetallesDtg.Item(0, i).Value.ToString & "'," & Me.DetallesDtg.Item(1, i).Value.ToString & "," & Me.DetallesDtg.Item(2, i).Value.ToString & "," & Me.DetallesDtg.Item(3, i).Value.ToString & ")"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        'ejecutar consulta
                        DatosMCmd.ExecuteNonQuery()
                    Next

                    'actualizar los datos de la toma
                    SQL = "UPDATE aguapotable set ultimopago='" & Me.FechaLbl.Text & "', pagohasta='" & Me.PagoHastaTxt.Text & "', adeudo=0 where id_toma=" & Me.IdTomatxt.Text
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMCmd.ExecuteNonQuery()


                    'Agregar ingreso a la tabla de ingresos

                    'Dim MesAct, DiaAct As String
                    'If Now.Month < 10 Then
                    ' MesAct = "0" & Now.Month
                    ' Else
                    ' MesAct = Now.Month
                    ' End If

                    'If Now.Day < 10 Then
                    ' DiaAct = "0" & Now.Day
                    ' Else
                    ' DiaAct = Now.Day
                    ' End If

                    'comprobar si ya se registro un ingreso el dia de hoy
                    Dim NoIngreso As Integer
                    SQL = "SELECT * from ingpropios where concepto='Agua Potable' and fecha='" & Me.FechaLbl.Text & "' order by fecha desc limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    If DatosMDR.HasRows = True Then 'pregunta si devolvio filas
                        'entonces actualiza el ingreso

                        DatosMDR.Read()
                        NoIngreso = DatosMDR!id_ing
                        DatosMDR.Close()
                        SQL = "UPDATE ingpropios set ingreso= ingreso + " & Me.AdeudoNetoTxt.Text & " where id_ing=" & NoIngreso & " and fecha='" & Me.FechaLbl.Text & "' limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()

                    Else
                        DatosMDR.Close()
                        'registrar el ingreso de hoy como nuevo
                        'aqui se registra el ingreso
                        SQL = "INSERT INTO ingpropios (fecha,concepto,ingreso) values('" & Me.FechaLbl.Text & "','Agua Potable'," & Me.AdeudoNetoTxt.Text & ")"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()

                    End If

                    '###########################################
                    'actualizar la tabla general de ingresos propios

                    SQL = "SELECT * from ingpropiosres limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Close()
                        SQL = "UPDATE ingpropiosres set ingresos= ingresos + " & Me.AdeudoNetoTxt.Text & ", encaja= encaja + " & Me.AdeudoNetoTxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    Else
                        DatosMDR.Close()
                        SQL = "INSERT INTO ingpropiosres (ingresos,encaja) values(" & Me.AdeudoNetoTxt.Text & "," & Me.AdeudoNetoTxt.Text & ")"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    End If

                    'actualizar la ultima factura
                    SQL = "UPDATE configuracion set ultimafactura = ultimafactura + 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMCmd.ExecuteNonQuery()

                    'avisar de que se registro el pago de la toma
                    MessageBox.Show("El registro del pago de la toma No. " & Me.IdTomatxt.Text & Chr(13) & "Ha sido realizado con exito", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        Imprimir()
                    Catch Err As Exception
                        MessageBox.Show(Err.Message, "ERROR: No se encuentra el modulo de impresi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Catch Ex As MySqlException
                    MessageBox.Show(Ex.Message, Ex.Number.ToString)
                    DatosMDR.Close()
                End Try
                    AguaPotablefrm.Cobrado = True

            End If
        Else
            MessageBox.Show("El adeudo es 0, No se puede cobrar", "Pago de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Close()
    End Sub

    Sub Imprimir()
        Try
            ' AQUI SE GENERA LA INFORMACION A IMPRIMIR
            Dim stringFormat As New StringFormat()
            Dim tabStops As Single() = {50.0F, 50.0F, 50.0F, 50.0F}
            stringFormat.SetTabStops(0.0F, tabStops)
            Dim Imprime As Boolean
            Imprime = True
            'SE PUEDE REIMPRIMIR EN CASO DE QUE LA IMPRESION FALLE
            While Imprime = True
                ImprimirFactura = New ImprimirFactura.Imprimirfrm
                'ImprimirFactura.Show()
                ImprimirFactura.Contrib = Me.Nombrecmb.Text.ToUpper & ControlChars.CrLf & Me.CalleTxt.Text.ToUpper & " " & Me.Numerotxt.Text.ToString & ControlChars.CrLf & Me.LocalidadTxt.Text.ToUpper
                Dim r, l As Short
                Dim I, lineas As Decimal ' auxiliares para incrementar el numero de lineas a dejar en sao de que el contenido sea largo
                Dim DescConcep As String
                For r = 0 To Me.DetallesDtg.Rows.Count - 1
                    'I = Me.DetallesDtg.Item(0, r).Value.ToString.Length / 25 'obtiene el numero de lineas que tiene la descripcion 'REEMPLAZAR CONTENIDO POR LA DESCRIPCION ORIGINAL
                    DescConcep = "Meses de agua potable de " & Me.DetallesDtg.Item(0, r).Value.ToString & ControlChars.CrLf 'aqui se forma la descripcion del concepto"
                    lineas = DescConcep.Length / 25
                    '                    If ((DescConcep.Length / 25) - Int(DescConcep.Length / 25)) > 0 Then
                    lineas = DescConcep.Length Mod 25
                    If (DescConcep.Length Mod 25) > 0 Then
                        I = Int(DescConcep.Length / 25) + 1
                    Else
                        I = Int(DescConcep.Length / 25)
                    End If
                    ImprimirFactura.CantidStr += Me.DetallesDtg.Item(2, r).Value.ToString & ControlChars.CrLf & ControlChars.CrLf 'cantidades
                    ImprimirFactura.Contenido += DescConcep & ControlChars.CrLf 'descripcion del concepto
                    'ImprimirFactura.PUnit += Format(CStr(Val(Me.DetallesDtg.Item(1, r).Value)), "Currency").ToString & ControlChars.CrLf 'precio unitario
                    ImprimirFactura.PUnit += String.Format("{0:c}", Val(Me.DetallesDtg.Item(1, r).Value)) & ControlChars.CrLf & ControlChars.CrLf
                    'ImprimirFactura.Totals += Format(CStr(Val(Me.DetallesDtg.Item(3, r).Value)), "Currency").ToString & ControlChars.CrLf 'aqui va el subtotal
                    ImprimirFactura.Totals += String.Format("{0:c}", Val(Me.DetallesDtg.Item(3, r).Value)) & ControlChars.CrLf & ControlChars.CrLf
                    For l = 1 To I - 1 ' aqui se agregan las nuevas lineas
                        ImprimirFactura.CantidStr += ControlChars.CrLf
                        ImprimirFactura.PUnit += ControlChars.CrLf
                        ImprimirFactura.Totals += ControlChars.CrLf
                    Next
                Next
                'imprimir el numero de toma una vez que termino de imprimirse los detalles
                ImprimirFactura.Contenido += "Toma Numero: " & Me.IdTomatxt.Text
                ' si tiene observaciones, las imprime
                If Me.ObservacionesTxt.Text <> "" Then
                    ImprimirFactura.Contenido += ControlChars.CrLf & Me.ObservacionesTxt.Text
                End If

                ImprimirFactura.TotNeto = Val(Me.AdeudoNetoTxt.Text) ' aqui va el total neto
                ImprimirFactura.Imprimir = True
                ImprimirFactura.Show()
                'aqui pregruntar si salio bien la factura
                If MessageBox.Show("SELECCIONE SI PARA TERMINAR" & Chr(13) & "SELECCIONE NO PARA REIMPRIMIR", "�LA FACTURA FUE IMPRESA CORRECTAMENTE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    'SELECCINO no
                    'PREGUNTAR SI  CONFIRMA LA REIMPRESION
                    If MessageBox.Show("CONFIRMA LA REIMPRESION DE LA FACTURA", "REIMPRESION DE FACTURA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'SE VUELVE A IMPRIMIR LA FACTURA Y SE TIENE QUE MODIFICAR EL NO. DE FACTURA Y AGREGAR LA FACTURA QUE FALLO A CANCELADAS
                        SQL = "update cobroagua set nofactura=nofactura+1 where id_cobro=" & Me.NoCobrotxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        'ejecutar consulta
                        DatosMCmd.ExecuteNonQuery()

                        'registrar la factura cancelada
                        SQL = "INSERT INTO factcancel (factura,anombrede,descripcion,fecha) values(" & Me.NoFacturaTxt.Text & ",'" & Me.Nombrecmb.Text & "','Fallo de impresion - Agua Potable','" & Me.FechaLbl.Text & "')"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()

                        'actualizar la ultima factura
                        SQL = "UPDATE configuracion set ultimafactura = ultimafactura + 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                        Me.NoFacturaTxt.Text = Val(Me.NoFacturaTxt.Text) + 1
                    Else
                        Imprime = False ' sale del ciclo
                        Exit While
                    End If
                Else
                    Imprime = False
                    Exit While
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LimpiarDatos()
        Me.DetallesDtg.Rows.Clear()
        Me.IdTomatxt.Text = ""
        Me.NoFacturaTxt.Text = ""
        Me.Nombrecmb.Text = ""
        Me.LocalidadTxt.Text = ""
        Me.CalleTxt.Text = ""
        Me.Numerotxt.Text = ""
        Me.TaridaIdTxt.Text = ""
        Me.NombreTarifaTxt.Text = ""
        Me.NoTomasTxt.Text = ""
        Me.PagoDesdeTxt.Text = ""
        Me.PagoHastaTxt.Text = ""
        Me.NoCobrotxt.Text = ""
        Me.Conceptostxt.Text = ""
        Me.AdeuTotTxt.Text = ""
        Me.TotalMesesTxt.Text = ""
        Me.AceptarBtn.Enabled = True
        Me.SuPagoTxt.Text = ""
        Me.SuCambioTxt.Text = ""
        Me.ObservacionesTxt.Text = ""
        Me.RecargoTxt.Text = ""
        Me.RecargoLbl.Text = "$0.0"
        Me.Descuentotxt.Text = ""
        Me.DescuentoLbl.Text = "$0.0"
        
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        'preguntar si sale
        If Comando = "Nuevo" Then
            If MessageBox.Show("�Desea salir sin realizar el cobro?", "Cobro de agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                AguaPotablefrm.Cobrado = False
                Me.Close()
            Else
                Exit Sub
            End If
        Else
            Me.Close()
            AguaPotablefrm.Cobrado = False
        End If
        'LimpiarDatos()
    End Sub

    Private Sub OtroPeriodoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtroPeriodoBtn.Click
        If Otrocom = "" Then
            AgregaPeriodofrm.Mespagado = Val(Mid(Me.PagoHastaTxt.Text, 1, 2))
            AgregaPeriodofrm.AnoPagado = Val(Mid(Me.PagoHastaTxt.Text, 4, 4))
        Else
            AgregaPeriodofrm.Mespagado = Mespagado 'Val(Mid(Me.PagoHastaTxt.Text, 1, 2))
            AgregaPeriodofrm.AnoPagado = AnoPagado 'Val(Mid(Me.PagoHastaTxt.Text, 4, 4))
        End If
        AgregaPeriodofrm.Comando = "Nuevo"
        AgregaPeriodofrm.ShowDialog()
        'aqui verificar que el periodo anterior sea >0 sino, eliminarlo
        If AgregaPeriodofrm.cancelado = False Then
            If Me.DetallesDtg.Item(3, DetallesDtg.Rows.Count - 2).Value <= 0 Then
                Me.DetallesDtg.Rows.Remove(Me.DetallesDtg.Rows(Me.DetallesDtg.Rows.Count - 2))
            End If
        End If
        CalculaDatos()
        Me.AdeudoNetoTxt.Text = Me.AdeuTotTxt.Text
        Me.RecargoChk.Checked = False
        Me.DescuentoChk.Checked = False
        Me.SuPagoTxt.Text = ""
        Me.SuCambioTxt.Text = ""
        Me.SuPagoTxt.Focus()
    End Sub

    Private Sub CobrarAguafrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Cerrar = True
        LimpiarDatos()
    End Sub

    Private Sub SuPagoTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SuPagoTxt.KeyPress
        If Val(Me.AdeudoNetoTxt.Text) > 0 Then
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(SoloNumeros(KeyAscii))
            'si presiona enter
            If KeyAscii = 13 Then
                'calcular su cambio
                If Val(Me.SuPagoTxt.Text) >= Val(Me.AdeudoNetoTxt.Text) Then
                    Me.SuCambioTxt.Text = Format(CStr(Val(Me.SuPagoTxt.Text) - Val(Me.AdeudoNetoTxt.Text)), "Currency")
                    Me.AceptarBtn.Enabled = True
                    Me.AceptarBtn.Focus()
                Else
                    MessageBox.Show("El pago del contribuyente no cubre el adeudo neto", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.SuPagoTxt.Text = ""
                    Me.AceptarBtn.Enabled = False
                    Me.SuPagoTxt.Focus()
                End If
            End If
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub NotificacionBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotificacionBtn.Click
        Dim Notificacion As New NotificacionFrm
        Notificacion.ShowDialog()
        Notificacion.Dispose()
    End Sub

    Private Sub RecargoChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecargoChk.CheckedChanged
        If Me.RecargoChk.Checked = True Then
            If Me.DescuentoChk.Checked = True Then
                MessageBox.Show("No puede elegir recargo y descuento al mismo tiempo", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.RecargoChk.Checked = False
            Else
                Me.RecargoTxt.Enabled = True
                MessageBox.Show("Ingrese el porcentaje de recargo y presione Enter", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.RecargoTxt.Focus()
            End If
        Else
            Me.RecargoTxt.Text = ""
            Me.RecargoTxt.Enabled = False
            'Me.RecargoLbl.Text = "$0.0"
            'Me.ObservacionesTxt.Text = ""
        End If
    End Sub

    Private Sub DescuentoChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescuentoChk.CheckedChanged
        If Me.DescuentoChk.Checked = True Then
            If Me.RecargoChk.Checked = True Then
                MessageBox.Show("No puede elegir descuento y recargo al mismo tiempo", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DescuentoChk.Checked = False
            Else
                Me.Descuentotxt.Enabled = True
                MessageBox.Show("Ingrese el porcentaje de descuento y presione Enter", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Descuentotxt.Focus()
            End If
        Else
            Me.Descuentotxt.Text = ""
            Me.Descuentotxt.Enabled = False
            'Me.RecargoLbl.Text = "$0.0"
            'Me.ObservacionesTxt.Text = ""
        End If
    End Sub

    Private Sub RecargoTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RecargoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        NumeroDec(e, Me.RecargoTxt)

        If KeyAscii = 13 Then
            Me.ObservacionesTxt.Text = "Se aplico un recargo de " & Me.RecargoTxt.Text & " % igual a " & Me.RecargoLbl.Text
            Me.SuPagoTxt.Focus()
            Exit Sub
        End If

        If KeyAscii = 0 Then
            e.Handled = True
        Else
            If Me.RecargoTxt.Text <> "" Then 'si el campo cantidad No esta en blanco: PU *lo que ahi en el campo y el numero presionado eje: 250 * "1"  que ya estaba & "2" que se presiono -> 12 -->250*12
                Me.AdeudoNetoTxt.Text = Val(Me.AdeuTotTxt.Text) + (Val(Me.AdeuTotTxt.Text) * (Val(Me.RecargoTxt.Text & Chr(KeyAscii)) / 100))
                Me.RecargoLbl.Text = "$ " & Val(Me.AdeuTotTxt.Text) * (Val(Me.RecargoTxt.Text & Chr(KeyAscii)) / 100)
            Else
                Me.AdeudoNetoTxt.Text = Val(Me.AdeuTotTxt.Text) + (Val(Me.AdeuTotTxt.Text) * (Val(Chr(KeyAscii)) / 100))
                Me.RecargoLbl.Text = "$ " & Val(Me.AdeuTotTxt.Text) * (Val(Chr(KeyAscii)) / 100)
            End If
        End If
    End Sub

    Private Sub Descuentotxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Descuentotxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        NumeroDec(e, Me.Descuentotxt)

        If KeyAscii = 13 Then
            Me.ObservacionesTxt.Text = "Se aplico un descuento de " & Me.Descuentotxt.Text & " % igual a " & Me.DescuentoLbl.Text
            Me.SuPagoTxt.Focus()
            Exit Sub
        End If

        If KeyAscii = 0 Then
            e.Handled = True
        Else
            If Me.Descuentotxt.Text <> "" Then 'si el campo cantidad No esta en blanco: PU *lo que ahi en el campo y el numero presionado eje: 250 * "1"  que ya estaba & "2" que se presiono -> 12 -->250*12
                Me.AdeudoNetoTxt.Text = Val(Me.AdeuTotTxt.Text) - (Val(Me.AdeuTotTxt.Text) * (Val(Me.Descuentotxt.Text & Chr(KeyAscii)) / 100))
                Me.DescuentoLbl.Text = "$ " & Val(Me.AdeuTotTxt.Text) * (Val(Me.Descuentotxt.Text & Chr(KeyAscii)) / 100)
            Else
                Me.AdeudoNetoTxt.Text = Val(Me.AdeuTotTxt.Text) - (Val(Me.AdeuTotTxt.Text) * (Val(Chr(KeyAscii)) / 100))
                Me.DescuentoLbl.Text = "$ " & Val(Me.AdeuTotTxt.Text) * (Val(Chr(KeyAscii)) / 100)
            End If
        End If
    End Sub

    Private Sub RecargoTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecargoTxt.TextChanged
        If Cerrar = False Then
            If Me.RecargoTxt.Text = "" Then
                If MessageBox.Show("No se ha ingresado un porcentaje de recargo" & Chr(13) & "�Desea desactivar el recargo?", "Cobro de agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Me.ObservacionesTxt.Text = ""
                    Me.RecargoLbl.Text = "$0.0"
                    Me.AdeudoNetoTxt.Text = Me.AdeuTotTxt.Text
                    Me.RecargoChk.Checked = False
                    Me.SuPagoTxt.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Descuentotxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descuentotxt.TextChanged
        If Cerrar = False Then
            If Me.Descuentotxt.Text = "" Then
                If MessageBox.Show("No se ha ingresado un porcentaje de descuento" & Chr(13) & "�Desea desactivar el descuento?", "Cobro de aguapotable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Me.ObservacionesTxt.Text = ""
                    Me.DescuentoLbl.Text = "$0.0"
                    Me.AdeudoNetoTxt.Text = Me.AdeuTotTxt.Text
                    Me.DescuentoChk.Checked = False
                    Me.SuPagoTxt.Focus()
                End If
            End If
        End If
    End Sub
End Class