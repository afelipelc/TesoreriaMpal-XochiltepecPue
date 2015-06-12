Imports MySql.Data.MySqlClient
Imports System.String
Imports ImprimirFactura
Public Class Nuevofrm
    Dim ImprimirFactura As ImprimirFactura.Imprimirfrm
    Private Sub Nuevofrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UltimaFactura()
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
        Me.IngresoTxt.Focus()
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Private Sub IngresoTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IngresoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Val(Me.IngresoTxt.Text) > 0 Then
            If MessageBox.Show("¿Confirma registrar el ingreso?", "Tortilleria Municipal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                    SQL = "INSERT INTO tortilleria (nofactura,periodo,importe,fecha) values(" & Me.NoFacturaTxt.Text & ",'Del " & Me.DeDtp.Value.ToShortDateString & " al " & Me.ADtp.Value.ToShortDateString & "'," & Me.IngresoTxt.Text & ",'" & Fecha & "')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMCmd.ExecuteNonQuery()

                    '################################################
                    'Agregar ingreso a la tabla de ingresos
                    'comprobar si ya se registro un ingreso el dia de hoy

                    Dim NoIngreso As Integer
                    SQL = "SELECT * from ingpropios where concepto='Tortilleria' and fecha='" & Fecha & "' order by fecha desc limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    If DatosMDR.HasRows = True Then 'pregunta si devolvio filas
                        'entonces actualiza el ingreso
                        DatosMDR.Read()
                        NoIngreso = DatosMDR!id_ing
                        DatosMDR.Close()
                        SQL = "UPDATE ingpropios set ingreso= ingreso + " & Me.IngresoTxt.Text & " where id_ing=" & NoIngreso & " and fecha='" & Fecha & "' limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()

                    Else
                        DatosMDR.Close()
                        'registrar el ingreso de hoy como nuevo
                        'aqui se registra el ingreso
                        SQL = "INSERT INTO ingpropios (fecha,concepto,ingreso) values('" & Fecha & "','Tortilleria'," & Me.IngresoTxt.Text & ")"
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
                        SQL = "UPDATE ingpropiosres set ingresos= ingresos + " & Me.IngresoTxt.Text & ", encaja= encaja + " & Me.IngresoTxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    Else
                        DatosMDR.Close()
                        SQL = "INSERT INTO ingpropiosres (ingresos,encaja) values(" & Me.IngresoTxt.Text & "," & Me.IngresoTxt.Text & ")" 'values(" & Me.ImporteTxt.Text & ",0,0,0,0)"
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
                    MessageBox.Show("El registro del ingreso ha sido realizado con éxito", "Tortilleria Municipal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        Imprimir()
                    Catch Err As Exception
                        MessageBox.Show(Err.Message, "ERROR: No se encuentra el modulo de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    Me.NoFacturaTxt.Text = ""
                    Me.IngresoTxt.Text = ""
                    Me.DeDtp.Value = Now.Date
                    Me.ADtp.Value = Now.Date
                    Me.Close()
                Catch Ex As MySqlException
                    MessageBox.Show(Ex.Message)
                End Try
            End If

        End If
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
                ImprimirFactura.Contrib = "TORTILLERIA MUNICIPAL" & ControlChars.CrLf & ControlChars.CrLf & "XOCHILTEPEC, PUE."

                Dim DescConcep As String

                'I = Me.DetallesDtg.Item(0, r).Value.ToString.Length / 25 'obtiene el numero de lineas que tiene la descripcion 'REEMPLAZAR CONTENIDO POR LA DESCRIPCION ORIGINAL
                DescConcep = "Ingreso de la tortilleria Mpal. del " & Me.DeDtp.Value.ToShortDateString & " al " & Me.ADtp.Value.ToShortDateString 'aqui se forma la descripcion del concepto

                ImprimirFactura.CantidStr += "1" & ControlChars.CrLf 'cantidades
                ImprimirFactura.Contenido += DescConcep & ControlChars.CrLf 'descripcion del concepto
                'ImprimirFactura.PUnit += Format(CStr(Val(Me.DetallesDtg.Item(1, r).Value)), "Currency").ToString & ControlChars.CrLf 'precio unitario
                ImprimirFactura.PUnit += String.Format("{0:c}", Val(Me.IngresoTxt.Text)) & ControlChars.CrLf
                'ImprimirFactura.Totals += Format(CStr(Val(Me.DetallesDtg.Item(3, r).Value)), "Currency").ToString & ControlChars.CrLf 'aqui va el subtotal
                ImprimirFactura.Totals += String.Format("{0:c}", Val(Me.IngresoTxt.Text)) & ControlChars.CrLf

                ' si tiene observaciones, las imprime
                ImprimirFactura.TotNeto = Val(Me.IngresoTxt.Text) ' aqui va el total neto
                ImprimirFactura.Imprimir = True
                ImprimirFactura.Show()
                'aqui pregruntar si salio bien la factura
                If MessageBox.Show("SELECCIONE SI PARA TERMINAR" & Chr(13) & "SELECCIONE NO PARA REIMPRIMIR", "¿LA FACTURA FUE IMPRESA CORRECTAMENTE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    'SELECCINO no
                    'PREGUNTAR SI  CONFIRMA LA REIMPRESION
                    If MessageBox.Show("CONFIRMA LA REIMPRESION DE LA FACTURA", "REIMPRESION DE FACTURA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'SE VUELVE A IMPRIMIR LA FACTURA Y SE TIENE QUE MODIFICAR EL NO. DE FACTURA Y AGREGAR LA FACTURA QUE FALLO A CANCELADAS
                        SQL = "update tortilleria set nofactura=nofactura+1 where nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        'ejecutar consulta
                        DatosMCmd.ExecuteNonQuery()

                        'registrar la factura cancelada
                        SQL = "INSERT INTO factcancel (factura,anombrede,descripcion,fecha) values(" & Me.NoFacturaTxt.Text & ",'Tortilleria Mpal.','Fallo de impresion - Tortilleria',now())"
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
End Class