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
                MessageBox.Show("No se encontro la toma número: " & IdToma, "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            SQL = "SELECT costo, apar_mes, apar_ano from detarifagua where id_tarifa=" & Tarifa & " order by apar_ano desc"
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

            'recorrer la lista de tomas de agua
            Dim PInicio, PFin As String
            'obtener el mes y año pagado
            Dim PMes, PAno As Short

            'variables que almacenan el mes y año que esta pagado
            Dim PagoDec As Boolean
            PMes = 0
            PAno = 0
            PMes = Val(Mid(Me.PagoDesdeTxt.Text, 1, 2)) - 1
            PAno = Val(Mid(Me.PagoDesdeTxt.Text, 4, 4))
            If PMes = 0 Then
                PMes = 12
                PAno -= 1
            End If
            If PMes = 12 Then
                PagoDec = True
            End If
            'verificar si es igual o mayor que la fecha actual "pago al corriente o adelantado"
            If PAno <= Now.Year Then
                'Dim reverse As Short
                'reverse = Detalles + 1
                Dim CostoTar As Short

                Paso = False
                For d = 1 To Detalles 'recorrer los detalles
                    '   reverse += 1
                    'obtener el inicio del periodo
                    If Paso = False Then
                        'si año pagado > ano de la cuota actual o si ultimo mes pagado fue diciembre, pasa
                        If PAno >= apar_ano(d) Or PagoDec = True Then
                            PagoDec = False
                            'aqui comprueba que no haya otra cuota mas abajo
                            If Detalles > d Then
                                'comprobar el mes para ver si le toca la tarifa antigua o nueva tarifa
                                If PAno = apar_ano(d) And PMes < apar_mes(d) Then
                                    'SI AHI OTRA TARIFA MAS ABajo y el ano = al ano de la tarifa y el mespagado es menor que el mes de la tarifa de este ano
                                    CostoTar = costo(d + 1) 'tomar el costo de la taria anterior
                                Else
                                    CostoTar = costo(d)
                                End If
                            Else
                                CostoTar = costo(d)
                            End If
                            'marcar periodo de inicio
                            If PMes < 10 Then 'comprobar que el mes pagado no sea menor que 10, sino agregarle un 0 --> 200805
                                PInicio = PAno & "0" & PMes
                            Else
                                PInicio = PAno & PMes
                            End If
                            'buscar fin del periodo
                            If d > 1 Then
                                'entonces no es la unica tarifa
                                'tomar el rango hasta ese periodo en el que la nueva tarifa inicia
                                If apar_mes(d - 1) = 1 Then
                                    'si el mes de la siguiente tarifa es enero
                                    If apar_mes(d - 1) = 1 Then
                                        'poner como fin del periodo hasta diciembre antes de entrar a enero par auq eno cuente la nueva tarifa
                                        PFin = apar_ano(d - 1) - 1 & "12"
                                        PMes = 12
                                        PAno = apar_ano(d - 1) - 1
                                        PagoDec = True
                                    End If
                                    'PFin = apar_ano(d - 1) & "0" & apar_mes(d - 1)
                                Else
                                    PFin = apar_ano(d - 1) & apar_mes(d - 1) - 1
                                    PMes = apar_mes(d - 1) - 1
                                    PAno = apar_ano(d - 1)
                                End If
                                d = d - 2
                            Else
                                'si la toma esta cancelada o usupendida
                                'calcular el adeudo que tiene

                                If Me.Estadolbl.Text = "Cancelada" Or Me.Estadolbl.Text = "Suspendida" Then
                                    'aqui el fin del periodo de pago se obtiene hasta el mes que se cancelo
                                    PMes = Val(Mid(Me.FechaCancel.Text, 4, 2))
                                    PAno = Val(Mid(Me.FechaCancel.Text, 7, 4))
                                    If PMes < 10 Then
                                        PFin = PAno & "0" & PMes
                                    Else
                                        PFin = PAno & PMes
                                    End If

                                    PAno = Now.Year
                                    If Now.Day >= DiaCobroMes Then
                                        PMes = Now.Month
                                    Else
                                        PMes = Now.Month - 1
                                    End If
                                    If PMes < 10 Then
                                        PFin = PAno & "0" & PMes
                                    Else
                                        PFin = PAno & PMes
                                    End If
                                    Paso = True


                                Else

                                    If PFinPer <> "" Then
                                        PMes = Mid(PFinPer, 1, 2)
                                        PAno = Mid(PFinPer, 4, 4)
                                        If PMes < 10 Then
                                            PFin = PAno & "0" & PMes
                                        Else
                                            PFin = PAno & PMes
                                        End If
                                        Paso = True
                                    Else
                                        PAno = Now.Year
                                        If Now.Day >= DiaCobroMes Then
                                            PMes = Now.Month
                                        Else
                                            PMes = Now.Month - 1
                                            'aqui ocurre un error cuando el mes es enero porque se volvera a 0 y contara como añomes -> 200900
                                            'PARA EVITARLO
                                            If PMes = 0 Then
                                                PMes = 12
                                                PAno = Now.Year - 1
                                            End If
                                        End If
                                        If PMes < 10 Then
                                            PFin = PAno & "0" & PMes
                                        Else
                                            PFin = PAno & PMes
                                        End If
                                        Paso = True
                                    End If
                                End If
                            End If
                            'aqui se genera el importe por los meses con el costo de tarifa seleccionado
                            'obtener la diferencia entre meses
                            SQL = "SELECT PERIOD_DIFF(" & PFin & "," & PInicio & ") as meses"
                            DatosMCmd = New MySqlCommand
                            DatosMCmd.CommandText = SQL
                            DatosMCmd.Connection = SQLCnn
                            DatosMDR = DatosMCmd.ExecuteReader
                            If DatosMDR.HasRows = True Then
                                DatosMDR.Read()
                                Dim Total As Short
                                Total = (Val(DatosMDR!meses) * CostoTar) * Val(Me.NoTomasTxt.Text)
                                'obtener el mes de inicio
                                Dim Mes, Ano As Short
                                Mes = Mid(PInicio, 5, 2)
                                If Mes = 12 Then
                                    Mes = 0
                                    Ano = Val(Mid(PInicio, 1, 4)) + 1
                                Else
                                    Ano = Val(Mid(PInicio, 1, 4))
                                End If
                                'agregar a la lista de detalles
                                Dim Mesini, MesFin As String
                                Mesini = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Mes)

                                Mes = Mid(PFin, 5, 2)
                                'If Mes = 12 Then
                                Mes = Mes - 1
                                'End If
                                MesFin = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Mes)

                                Me.DetallesDtg.Rows.Add(Mesini & "-" & Ano & " : " & MesFin & "-" & Mid(PFin, 1, 4), CostoTar, Val(DatosMDR!meses), Total)
                                Me.PagoHastaTxt.Text = Mid(PFin, 5, 2) & "-" & Mid(PFin, 1, 4)
                                'Me.DatosDtg.Item(9, r).Value = Val(Me.DatosDtg.Item(9, r).Value.ToString) + (Total * Val(Me.DatosDtg.Item(1, r).Value.ToString))

                            End If
                            DatosMDR.Close()
                            'Me.DatosDtg.Item(9, r).Value = Val(Me.DatosDtg.Item(9, r).Value.ToString) + (((Val(PFin) - Val(PInicio)) * costo(Detalles)) * Val(Me.DatosDtg.Item(1, r).Value.ToString))
                        End If
                    End If
            'comprobar si esxiste otra tarifa
            'next

                Next
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
                MessageBox.Show("No se encontro ningún pago realizado de la toma No. " & IdToma, "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            If MessageBox.Show("¿Confima Registrar el Pago de agua?", "Cobro de agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                        MessageBox.Show(Err.Message, "ERROR: No se encuentra el modulo de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    DescConcep = "pago de agua potable de " & Me.DetallesDtg.Item(0, r).Value.ToString & ControlChars.CrLf & ControlChars.CrLf & "Toma Numero: " & Me.IdTomatxt.Text 'aqui se forma la descripcion del concepto"
                    lineas = DescConcep.Length / 25
                    '                    If ((DescConcep.Length / 25) - Int(DescConcep.Length / 25)) > 0 Then
                    lineas = DescConcep.Length Mod 25
                    If (DescConcep.Length Mod 25) > 0 Then
                        I = Int(DescConcep.Length / 25) + 1
                    Else
                        I = Int(DescConcep.Length / 25)
                    End If
                    ImprimirFactura.CantidStr += Me.DetallesDtg.Item(2, r).Value.ToString & ControlChars.CrLf 'cantidades
                    ImprimirFactura.Contenido += DescConcep & ControlChars.CrLf 'descripcion del concepto
                    'ImprimirFactura.PUnit += Format(CStr(Val(Me.DetallesDtg.Item(1, r).Value)), "Currency").ToString & ControlChars.CrLf 'precio unitario
                    ImprimirFactura.PUnit += String.Format("{0:c}", Val(Me.DetallesDtg.Item(1, r).Value)) & ControlChars.CrLf
                    'ImprimirFactura.Totals += Format(CStr(Val(Me.DetallesDtg.Item(3, r).Value)), "Currency").ToString & ControlChars.CrLf 'aqui va el subtotal
                    ImprimirFactura.Totals += String.Format("{0:c}", Val(Me.DetallesDtg.Item(3, r).Value)) & ControlChars.CrLf
                    For l = 1 To I - 1 ' aqui se agregan las nuevas lineas
                        ImprimirFactura.CantidStr += ControlChars.CrLf
                        ImprimirFactura.PUnit += ControlChars.CrLf
                        ImprimirFactura.Totals += ControlChars.CrLf
                    Next
                Next
                ' si tiene observaciones, las imprime
                If Me.ObservacionesTxt.Text <> "" Then
                    ImprimirFactura.Contenido += ControlChars.CrLf & Me.ObservacionesTxt.Text
                End If

                ImprimirFactura.TotNeto = Val(Me.AdeudoNetoTxt.Text) ' aqui va el total neto
                ImprimirFactura.Imprimir = True
                ImprimirFactura.Show()
                'aqui pregruntar si salio bien la factura
                If MessageBox.Show("SELECCIONE SI PARA TERMINAR" & Chr(13) & "SELECCIONE NO PARA REIMPRIMIR", "¿LA FACTURA FUE IMPRESA CORRECTAMENTE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
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
            If MessageBox.Show("¿Desea salir sin realizar el cobro?", "Cobro de agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
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
                If MessageBox.Show("No se ha ingresado un porcentaje de recargo" & Chr(13) & "¿Desea desactivar el recargo?", "Cobro de agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                If MessageBox.Show("No se ha ingresado un porcentaje de descuento" & Chr(13) & "¿Desea desactivar el descuento?", "Cobro de aguapotable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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