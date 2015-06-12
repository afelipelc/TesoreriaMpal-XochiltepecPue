Imports MySql.Data.MySqlClient
Imports Contribuyentes
Imports System.String
Imports ImprimirFactura
Public Class OtroCobrofrm
    Dim ImprimirFactura As ImprimirFactura.Imprimirfrm
    Public id_inmueble, cuenta As Integer
    Dim id_cobro As Short
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
        Me.ImporteTxt.Focus()
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub
    Sub BuscarCuenta()
        SQL = "SELECT id_inmueble,tipo,ubicacion,propietario,direccion,observaciones from inmuebles where cuenta=" & cuenta & " limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            id_inmueble = DatosMDR!id_inmueble
            Me.NombreTxt.Text = DatosMDR!propietario
            Me.DireccionTxt.Text = DatosMDR!direccion
            'formar el detalle de concepto si cobrara boleta que no llego
            Me.ConceptoTxt.Text = "Imp. Pred. Cta: " & Me.CuentaTxt.Text & ", Tipo: " & DatosMDR!tipo & ", Ubic. " & DatosMDR!ubicacion
            'habilitar el boton de cobro
            Me.AceptarBtn.Enabled = True
            Me.ImporteTxt.Focus()
        Else
            MessageBox.Show("El predio con la cuenta " & Me.CuentaTxt.Text & " no esta registrado" & Chr(13) & "Registre el inmueble y vuela a intentarlo." & Chr(13) & "Puede registrar el inmueble con adeudo de 0 pesos en el año actual", "Cobro de impuesto predial con factura.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.AceptarBtn.Enabled = False
        End If
        Me.ImporteTxt.Focus()
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub
    Sub LimpiarDatos()
        Me.CuentaTxt.Text = ""
        Me.NoFacturaTxt.Text = ""
        Me.NombreTxt.Text = ""
        Me.MpioTxt.Text = ""
        Me.DireccionTxt.Text = ""
        Me.ImporteTxt.Text = ""
        Me.ConceptoTxt.Text = ""
        Me.AceptarBtn.Enabled = False
        Me.CantidadTxt.Text = 1
        id_inmueble = 0
        id_cobro = 0
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
                ImprimirFactura.Contrib = Me.NombreTxt.Text.ToUpper & ControlChars.CrLf & Me.DireccionTxt.Text.ToUpper & ControlChars.CrLf & Me.MpioTxt.Text.ToUpper

                Dim DescConcep As String

                'I = Me.DetallesDtg.Item(0, r).Value.ToString.Length / 25 'obtiene el numero de lineas que tiene la descripcion 'REEMPLAZAR CONTENIDO POR LA DESCRIPCION ORIGINAL
                DescConcep = Me.ConceptoTxt.Text 'aqui se forma la descripcion del concepto

                ImprimirFactura.CantidStr += Me.CantidadTxt.Text & ControlChars.CrLf 'cantidades
                ImprimirFactura.Contenido += DescConcep & ControlChars.CrLf 'descripcion del concepto
                'ImprimirFactura.PUnit += Format(CStr(Val(Me.DetallesDtg.Item(1, r).Value)), "Currency").ToString & ControlChars.CrLf 'precio unitario
                ImprimirFactura.PUnit += String.Format("{0:c}", Val(Me.ImporteTxt.Text)) & ControlChars.CrLf
                'ImprimirFactura.Totals += Format(CStr(Val(Me.DetallesDtg.Item(3, r).Value)), "Currency").ToString & ControlChars.CrLf 'aqui va el subtotal
                ImprimirFactura.Totals += String.Format("{0:c}", Val(Me.ImporteTxt.Text)) & ControlChars.CrLf

                ' si tiene observaciones, las imprime
                ImprimirFactura.TotNeto = Val(Me.ImporteTxt.Text) ' aqui va el total neto
                ImprimirFactura.Imprimir = True
                ImprimirFactura.Show()
                'aqui pregruntar si salio bien la factura
                If MessageBox.Show("SELECCIONE SI PARA TERMINAR" & Chr(13) & "SELECCIONE NO PARA REIMPRIMIR", "¿LA FACTURA FUE IMPRESA CORRECTAMENTE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    'SELECCINO no
                    'PREGUNTAR SI  CONFIRMA LA REIMPRESION
                    If MessageBox.Show("CONFIRMA LA REIMPRESION DE LA FACTURA", "REIMPRESION DE FACTURA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'SE VUELVE A IMPRIMIR LA FACTURA Y SE TIENE QUE MODIFICAR EL NO. DE FACTURA Y AGREGAR LA FACTURA QUE FALLO A CANCELADAS
                        SQL = "update cobropredios set observaciones='Factura: " & Val(Me.NoFacturaTxt.Text) + 1 & "' where id_cobro=" & id_cobro & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        'ejecutar consulta
                        DatosMCmd.ExecuteNonQuery()

                        'registrar la factura cancelada
                        SQL = "INSERT INTO factcancel (factura,anombrede,descripcion,fecha) values(" & Me.NoFacturaTxt.Text & ",'" & Me.NombreTxt.Text & "','Fallo de impresion - Impuesto Predial','" & Me.FechaLbl.Text & "')"
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

    Private Sub OtroCobrofrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CuentaTxt.Text = cuenta
        UltimaFactura()
        Me.FechaLbl.Text = Now.Year & "-" & Now.Month & "-" & Now.Day
        BuscarCuenta()
        Me.ImporteTxt.Focus()
    End Sub

    Private Sub CuentaTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CuentaTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 13 Then
            'llamar la funcion que busque la cuenta
            BuscarCuenta()
            Me.NombreTxt.Focus()
            Exit Sub
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ImporteTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ImporteTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        NumeroDec(e, Me.ImporteTxt)
        If KeyAscii = 13 Then
            Me.AceptarBtn.Focus()
            Exit Sub
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Me.NombreTxt.Text <> "" And Me.ConceptoTxt.Text <> "" Then
            If MessageBox.Show("¿Confirma registrar el pago de impuesto predial?", "Impuesto Predial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim Fecha As String
                    If Now.Month < 10 Then
                        Fecha = Now.Year & "-0" & Now.Month
                    Else
                        Fecha = Now.Year & "-" & Now.Month
                    End If

                    If Now.Day < 10 Then
                        Fecha += "-0" & Now.Day
                    Else
                        Fecha += "-" & Now.Day
                    End If
                    '/////////////rgistrar el cobro
                    SQL = "insert into cobropredios(id_inmueble,cuenta,ubicacion,propietario,importe,observaciones,fecha) values(" & id_inmueble & "," & Me.CuentaTxt.Text & ",'" & Me.DireccionTxt.Text & "','" & _
                                            Me.NombreTxt.Text & "'," & Me.ImporteTxt.Text & ",'Factura: " & Me.NoFacturaTxt.Text.ToString & "','" & _
                                            Me.FechaLbl.Text & "')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()

                    '///obtener el id de cobro registrado
                    SQL = "SELECT LAST_INSERT_ID() as ultimocobro FROM cobropredios"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        id_cobro = DatosMDR!ultimocobro
                    Else
                        id_cobro = 0
                    End If
                    DatosMDR.Close()

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
                        SQL = "UPDATE ingpropios set ingreso= ingreso + " & Me.ImporteTxt.Text & " where id_ing=" & NoIngreso & " and fecha='" & Me.FechaLbl.Text & "' limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()

                    Else
                        DatosMDR.Close()
                        'registrar el ingreso de hoy como nuevo
                        'aqui se registra el ingreso
                        SQL = "INSERT INTO ingpropios (fecha,concepto,ingreso) values('" & Me.FechaLbl.Text & "','Impuesto Predial'," & Me.ImporteTxt.Text & ")"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    End If


                    '////actualizar la tabla general de ingresos propios
                    SQL = "SELECT * from ingpropiosres limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Close()
                        SQL = "UPDATE ingpropiosres set ingresos= ingresos + " & Me.ImporteTxt.Text & ", encaja= encaja + " & Me.ImporteTxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    Else
                        DatosMDR.Close()
                        SQL = "INSERT INTO ingpropiosres (ingresos,encaja) values(" & Me.ImporteTxt.Text & "," & Me.ImporteTxt.Text & ")"
                        'SQL = "INSERT INTO ingpropiosres values(" & Me.AdeuTotTxt.Text & ",0,0,0,0)"
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

                    'Me.NoFacturaTxt.Text = ""
                    'Me.ImporteTxt.Text = ""

                    'avisar de que se registro el pago de la toma
                    MessageBox.Show("El registro del pago ha sido realizado con exito", "Impuesto Predial", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    '/// enviar impresion
                    Try
                        Imprimir()
                    Catch Err As Exception
                        MessageBox.Show(Err.Message, "ERROR: No se encuentra el modulo de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    'poner en 1 la cantidad por default
                    Me.CantidadTxt.Text = 1

                    Me.Close()
                Catch Ex As MySqlException
                    MessageBox.Show(Ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Ingrese el Nombre y el Concepto", "Otros Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub OtroCobrofrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        LimpiarDatos()
        e.Cancel = False
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        LimpiarDatos()
        Me.Close()
    End Sub
End Class