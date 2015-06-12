Imports MySql.Data.MySqlClient
Public Class CobrarFrm
    Public IdInmueble As Integer
    Public Comando As String
    Dim cerrar As Boolean
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter

    Private Sub CobrarFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrar = True
        LimpiarDatos()
    End Sub
    Private Sub CobrarFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AceptarBtn.Enabled = False
        Me.NotificacionBtn.Enabled = False
        Me.SuPagoTxt.Enabled = False
        Me.SuCambioTxt.Enabled = False
        Me.RecargoChk.Enabled = False
        Me.DescuentoChk.Enabled = False
        Me.RecargoChk.Checked = False
        Me.DescuentoChk.Checked = False
        Me.RecargoTxt.Enabled = False
        Me.Descuentotxt.Enabled = False
        Me.ObservacionesTxt.ReadOnly = True
        cerrar = False
        Select Case Comando
            Case "Nuevo"
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

                UltimoPago()
                CargarInmueble()
                CalculaTot()
                Me.AdeutoNetoTxt.Text = Me.AdeuTotTxt.Text
                Me.SuPagoTxt.Enabled = True
                Me.SuCambioTxt.Enabled = True
                Me.RecargoChk.Enabled = True
                Me.DescuentoChk.Enabled = True
                Me.ObservacionesTxt.ReadOnly = False
                Me.SuPagoTxt.Focus()
            Case "Abrir"
                'cargar los datos del cobro
                CargarPago()
                Me.CerrarBtn.Focus()
        End Select

    End Sub
    Sub CargarInmueble()
        Dim AnoPagado As Short
        SQL = "SELECT * from inmuebles  where id_inmueble=" & IdInmueble
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        If DatosMDR.HasRows Then
            DatosMDR.Read()
            Me.IdTxt.Text = DatosMDR!id_inmueble
            Me.NoCuentaTxt.Text = DatosMDR!cuenta
            Me.TipoTxt.Text = DatosMDR!tipo.ToString
            Me.UbicacionTxt.Text = DatosMDR!ubicacion.ToString
            Me.NombreTxt.Text = DatosMDR!propietario.ToString
            Me.DomicilioTxt.Text = DatosMDR!direccion.ToString
            AnoPagado = DatosMDR!pagadohasta
        End If
        DatosMDR.Close()
        'cargar los impuestos
        CargaImpuestos(Val(Me.IdTxt.Text), AnoPagado + 1)
    End Sub
    Sub CargaImpuestos(ByVal IdInmueble As Short, ByVal ApaAno As Short)
        Dim i As Short
        SQL = "SELECT "
        
        For i = ApaAno To Now.Year
            If i = Now.Year Then
                SQL += "imp" & i & " "
            Else
                SQL += "imp" & i & ", "
            End If
        Next
        SQL += " from impuestospred where id_inmueble=" & IdInmueble & " limit 1"
        CargarImpuestos()

    End Sub

    Sub CargarImpuestos()
        Me.ImpuestosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "impuestospred")
        'asignar la fuente de datos al datagrid de detalles
        Me.ImpuestosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.ImpuestosDtg.DataMember = "impuestospred"

        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.ImpuestosDtg.Columns.Count - 1
            Me.ImpuestosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Sub CalculaTot()
        Dim c As Short
        Me.AdeuTotTxt.Text = ""
        For c = 0 To Me.ImpuestosDtg.Columns.Count - 1
            Me.AdeuTotTxt.Text = Val(Me.AdeuTotTxt.Text) + Val(Me.ImpuestosDtg.Item(c, 0).Value.ToString)
        Next
        Me.AnosPagTxt.Text = Me.ImpuestosDtg.Columns.Count
    End Sub

    Sub CargarPago()
        Try
            SQL = "SELECT *  from cobropredios where id_inmueble= " & IdInmueble & " order by id_cobro desc limit 1"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            If DatosMDR.HasRows = True Then
                'si encontro el pago, llenar los datos
                DatosMDR.Read()
                Me.NoCobrotxt.Text = DatosMDR!id_cobro
                Me.IdTxt.Text = DatosMDR!id_inmueble
                Me.NoCuentaTxt.Text = DatosMDR!cuenta
                Me.TipoTxt.Text = DatosMDR!tipo
                Me.UbicacionTxt.Text = DatosMDR!ubicacion
                Me.NombreTxt.Text = DatosMDR!propietario
                Me.DomicilioTxt.Text = DatosMDR!direccion
                Me.AnosPagTxt.Text = DatosMDR!anoscobrados
                Me.ObservacionesTxt.Text = DatosMDR!observaciones
                CalculaTot()
                Me.AdeutoNetoTxt.Text = DatosMDR!importe
                Me.FechaLbl.Text = DatosMDR!fecha
                DatosMDR.Close()

                'cargar los impuestos pagados

                SQL = "SELECT anopagado, impuesto  from detcobropredios where id_cobro= " & Me.NoCobrotxt.Text & " order by id_det asc"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                Dim i As Short
                i = 0
                'Me.ImpuestosDtg.Rows.Add()
                While DatosMDR.Read
                    Me.ImpuestosDtg.Columns.Add("clm" & DatosMDR!anopagado, DatosMDR!anopagado)
                    If Me.ImpuestosDtg.Columns.Count = 1 Then
                        Me.ImpuestosDtg.Rows.Add()
                    End If
                    Me.ImpuestosDtg.Item(i, 0).Value = DatosMDR!impuesto
                    i += 1
                End While
                CalculaTot()
                Me.AnosPagTxt.Text = Me.ImpuestosDtg.Columns.Count

                DatosMDR.Close()

                'While DatosMDR.Read
                ' Me.ImpuestosDtg.Item(i, 0).Value = DatosMDR!impuesto
                ' i += 1
                ' End While

            Else
                MessageBox.Show("No se encontro ningún pago realizado del inmueble No. " & IdInmueble, "Cobro de impuesto predial", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'SQLCnn.Close()
                DatosMDR.Close()
                Me.Close()
            End If
            'DatosMCmd.Dispose()

        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
            DatosMDR.Close()
        End Try

    End Sub

    Sub UltimoPago()
        SQL = "SELECT id_cobro from cobropredios order by id_cobro desc limit 1"
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
    Private Sub SuPagoTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SuPagoTxt.KeyPress
        If Val(Me.AdeutoNetoTxt.Text) > 0 Then
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(SoloNumeros(KeyAscii))
            'si presiona enter
            If KeyAscii = 13 Then
                'calcular su cambio
                If Val(Me.SuPagoTxt.Text) >= Val(Me.AdeutoNetoTxt.Text) Then
                    Me.SuCambioTxt.Text = Format(CStr(Val(Me.SuPagoTxt.Text) - Val(Me.AdeutoNetoTxt.Text)), "Currency")
                    Me.AceptarBtn.Enabled = True
                    Me.AceptarBtn.Focus()
                Else
                    MessageBox.Show("El pago del contribuyente no cubre el adeudo neto", "Cobro de impuesto predial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Comando = "Nuevo" And Val(Me.AdeuTotTxt.Text) > 0 Then
            'agregar las observaciones si no se especificaron
            If Me.RecargoTxt.Text <> "" And Me.ObservacionesTxt.Text = "" Then
                Me.ObservacionesTxt.Text = Me.ObservacionesTxt.Text + " Se aplico un recargo de " & Me.RecargoTxt.Text & " % igual a " & Me.RecargoLbl.Text
            End If

            If Me.Descuentotxt.Text <> "" And Me.ObservacionesTxt.Text = "" Then
                Me.ObservacionesTxt.Text = Me.ObservacionesTxt.Text + " Se aplico un descuento de " & Me.Descuentotxt.Text & " % igual a " & Me.DescuentoLbl.Text
            End If

            If MessageBox.Show("¿Confirma registrar el pago de impuesto predial?", "Cobro de Impuesto Predial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim Anos As String
                    Anos = ""
                    Dim c As Short
                    For c = 0 To Me.ImpuestosDtg.Columns.Count - 1
                        Anos += Mid(Me.ImpuestosDtg.Columns(c).HeaderText.ToString, 4, 4) & ", "
                    Next
                    SQL = "insert into cobropredios values(" & Me.NoCobrotxt.Text & "," & Me.IdTxt.Text & "," & Me.NoCuentaTxt.Text & ",'" & _
                                            Me.UbicacionTxt.Text & "','" & Me.TipoTxt.Text & "','" & Me.NombreTxt.Text & "','" & Me.DomicilioTxt.Text & "','" & Anos & "'," & Me.AdeutoNetoTxt.Text & ",'" & Me.ObservacionesTxt.Text.ToString & "','" & _
                                            Me.FechaLbl.Text & "')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()

                    For c = 0 To Me.ImpuestosDtg.Columns.Count - 1
                        SQL = "INSERT INTO detcobropredios (id_cobro,anopagado,impuesto) VALUES (" & Me.NoCobrotxt.Text & ",'" & Me.ImpuestosDtg.Columns(c).HeaderText.ToString & "'," & Me.ImpuestosDtg.Item(c, 0).Value.ToString & ")"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        'ejecutar consulta
                        DatosMCmd.ExecuteNonQuery()
                    Next
                    'ACTUALIZAR EN LA TABLA DE INMUEBLES
                    SQL = "UPDATE inmuebles set  pagadohasta=" & Now.Year & ", ultimopago='" & Me.FechaLbl.Text & "', adeudo=0 where id_inmueble=" & Me.IdTxt.Text
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()


                    '##################################################
                    'Agregar ingreso a la tabla de ingresos


                    'comprobar si ya se registro un ingreso el dia de hoy
                    Dim NoIngreso As Integer
                    SQL = "SELECT * from ingpropios where concepto='Impuesto Predial' and fecha='" & Me.FechaLbl.Text & "' order by fecha desc limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    If DatosMDR.HasRows = True Then 'pregunta si devolvio filas
                        'entonces actualiza el ingreso
                        DatosMDR.Read()
                        NoIngreso = DatosMDR!id_ing
                        DatosMDR.Close()
                        SQL = "UPDATE ingpropios set ingreso= ingreso + " & Me.AdeutoNetoTxt.Text & " where id_ing=" & NoIngreso & " and fecha='" & Me.FechaLbl.Text & "' limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()

                    Else
                        DatosMDR.Close()
                        'registrar el ingreso de hoy como nuevo
                        'aqui se registra el ingreso
                        SQL = "INSERT INTO ingpropios (fecha,concepto,ingreso) values('" & Me.FechaLbl.Text & "','Impuesto Predial'," & Me.AdeutoNetoTxt.Text & ")"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    End If

                    'actualizar la tabla general de ingresos propios

                    SQL = "SELECT * from ingpropiosres limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Close()
                        SQL = "UPDATE ingpropiosres set ingresos= ingresos + " & Me.AdeutoNetoTxt.Text & ", encaja= encaja + " & Me.AdeutoNetoTxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    Else
                        DatosMDR.Close()
                        SQL = "INSERT INTO ingpropiosres (ingresos,encaja) values(" & Me.AdeutoNetoTxt.Text & "," & Me.AdeutoNetoTxt.Text & ")"
                        'SQL = "INSERT INTO ingpropiosres values(" & Me.AdeuTotTxt.Text & ",0,0,0,0)"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    End If

                    'avisar de que se registro el pago de la toma
                    MessageBox.Show("El registro del pago ha sido realizado con exito", "Impuesto Predial", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ImpuestoPredialFrm.Cobrado = True

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                End Try
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("El adeudo es 0, No se puede cobrar", "Pago de impuesto predial", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
            Me.Close()
    End Sub
    Sub LimpiarDatos()
        Me.ImpuestosDtg.DataSource = Nothing
        Me.ImpuestosDtg.Rows.Clear()
        Me.ImpuestosDtg.Columns.Clear()
        Me.IdTxt.Text = ""
        Me.NombreTxt.Text = ""
        Me.DomicilioTxt.Text = ""
        Me.NoCuentaTxt.Text = ""
        Me.TipoTxt.Text = ""
        Me.UbicacionTxt.Text = ""
        Me.AnosPagTxt.Text = ""
        Me.NoCobrotxt.Text = ""
        Me.AdeuTotTxt.Text = ""
        Me.AceptarBtn.Enabled = False
        Me.SuPagoTxt.Text = ""
        Me.SuCambioTxt.Text = ""
        Me.ObservacionesTxt.Text = ""
        Me.RecargoTxt.Text = ""
        Me.RecargoLbl.Text = "$0.0"
        Me.Descuentotxt.Text = ""
        Me.DescuentoLbl.Text = "$0.0"
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.Close()
    End Sub

    Private Sub NotificacionBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotificacionBtn.Click
        Dim Notificacion As New NotificacionFrm
        Notificacion.ShowDialog()
        Notificacion.Dispose()
    End Sub

    Private Sub RecargoChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecargoChk.CheckedChanged
        If Me.RecargoChk.Checked = True Then
            If Me.DescuentoChk.Checked = True Then
                MessageBox.Show("No puede elegir recargo y descuento al mismo tiempo", "Cobro de impuesto predial", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.RecargoChk.Checked = False
            Else
                Me.RecargoTxt.Enabled = True
                MessageBox.Show("Ingrese el porcentaje de recargo y presione Enter", "Cobro de impuesto predial", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MessageBox.Show("No puede elegir descuento y recargo al mismo tiempo", "Cobro de impuesto predial", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DescuentoChk.Checked = False
            Else
                Me.Descuentotxt.Enabled = True
                MessageBox.Show("Ingrese el porcentaje de descuento y presione Enter", "Cobro de impuesto predial", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                Me.AdeutoNetoTxt.Text = Val(Me.AdeuTotTxt.Text) + (Val(Me.AdeuTotTxt.Text) * (Val(Me.RecargoTxt.Text & Chr(KeyAscii)) / 100))
                Me.RecargoLbl.Text = "$ " & Val(Me.AdeuTotTxt.Text) * (Val(Me.RecargoTxt.Text & Chr(KeyAscii)) / 100)
            Else
                Me.AdeutoNetoTxt.Text = Val(Me.AdeuTotTxt.Text) + (Val(Me.AdeuTotTxt.Text) * (Val(Chr(KeyAscii)) / 100))
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
                Me.AdeutoNetoTxt.Text = Val(Me.AdeuTotTxt.Text) - (Val(Me.AdeuTotTxt.Text) * (Val(Me.Descuentotxt.Text & Chr(KeyAscii)) / 100))
                Me.DescuentoLbl.Text = "$ " & Val(Me.AdeuTotTxt.Text) * (Val(Me.Descuentotxt.Text & Chr(KeyAscii)) / 100)
            Else
                Me.AdeutoNetoTxt.Text = Val(Me.AdeuTotTxt.Text) - (Val(Me.AdeuTotTxt.Text) * (Val(Chr(KeyAscii)) / 100))
                Me.DescuentoLbl.Text = "$ " & Val(Me.AdeuTotTxt.Text) * (Val(Chr(KeyAscii)) / 100)
            End If
        End If
    End Sub

    Private Sub RecargoTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecargoTxt.TextChanged
        If cerrar = False Then
            If Me.RecargoTxt.Text = "" Then
                If MessageBox.Show("No se ha ingresado un porcentaje de recargo" & Chr(13) & "¿Desea desactivar el recargo?", "Cobro de impuesto predial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Me.ObservacionesTxt.Text = ""
                    Me.RecargoLbl.Text = "$0.0"
                    Me.AdeutoNetoTxt.Text = Me.AdeuTotTxt.Text
                    Me.RecargoChk.Checked = False
                    Me.SuPagoTxt.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Descuentotxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descuentotxt.TextChanged
        If cerrar = False Then
            If Me.Descuentotxt.Text = "" Then
                If MessageBox.Show("No se ha ingresado un porcentaje de descuento" & Chr(13) & "¿Desea desactivar el descuento?", "Cobro de impuesto predial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Me.ObservacionesTxt.Text = ""
                    Me.DescuentoLbl.Text = "$0.0"
                    Me.AdeutoNetoTxt.Text = Me.AdeuTotTxt.Text
                    Me.DescuentoChk.Checked = False
                    Me.SuPagoTxt.Focus()
                End If
            End If
        End If
    End Sub
End Class