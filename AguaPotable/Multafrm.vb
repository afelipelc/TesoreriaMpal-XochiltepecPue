Imports MySql.Data.MySqlClient
Imports ImprimirFactura
Imports System.String
Public Class Multafrm
    Dim Encontrado As Boolean
    Dim Tarifa As Short
    Dim Localidad, Calle, Numero As String
    Dim ImprimirFactura As ImprimirFactura.Imprimirfrm
    Private Sub Multafrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.NombreTxt.Text = ""
        Me.DomicilioTxt.Text = ""
        Me.DescripcionTxt.Text = ""
        Me.ImporteTxt.Text = ""
        Me.NoFacturaTxt.Text = ""
        CargarToma()
        UltimaFactura()
    End Sub
    Sub CargarToma()
        Try
            Dim Estado, FechaCancel As String
            SQL = "SELECT * from aguapotable where id_toma='" & Me.NoTomaTxt.Text & "'"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                DatosMDR.Read()
                Me.NombreTxt.Text = DatosMDR!nombre
                Me.DomicilioTxt.Text = DatosMDR!calle & " " & DatosMDR!numero & " " & DatosMDR!localidad
                Calle = DatosMDR!calle
                Localidad = DatosMDR!localidad
                Numero = DatosMDR!numero
                Estado = DatosMDR!estado
                Me.NoTomasLbl.Text = DatosMDR!tomas
                FechaCancel = DatosMDR!fechacancel
                Tarifa = DatosMDR!id_tarifa

                'mostrar el estado de la toma
                If Estado = "Suspendida" Or Estado = "Cancelada" Then
                    MessageBox.Show("La toma se encuentra " & Estado, "Multa de toma de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Encontrado = True
            Else

                Encontrado = False
                'IdContr = DatosMDR!pagohasta
            End If
            DatosMDR.Close()
            'cargar nombre de la tarifa
            If Encontrado = False Then

                MessageBox.Show("No se encontro la toma número: " & Me.NoTomaTxt.Text, "Cobro de multas de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'SQLCnn.Close()
                Me.Close()
            End If
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
            'DatosMDR.Close()
        End Try
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
        Else
            Me.NoFacturaTxt.Text = 1
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Private Sub CobrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobrarBtn.Click
        If MessageBox.Show("¿Confirma registrar la multa de la toma " & Me.NoTomaTxt.Text & "?", "Multas de tomas de Agua Potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Me.DescripcionTxt.Text <> "" And Me.ImporteTxt.Text <> "" Then
                'AQUI REGISTRAR EL INGRESO
                SQL = "insert into cobroagua(nofactura,id_toma,id_tarifa,nombre,localidad,calle,numero,pagodesde,pagohasta,tomas,meses,importe,fechapago,observaciones) values(" & Me.NoFacturaTxt.Text & "," & Me.NoTomaTxt.Text & "," & Tarifa & ",'" & _
                Me.NombreTxt.Text & "','" & Localidad & "','" & Calle & "','" & Numero & "','Multa','Multa'," & Me.NoTomasLbl.Text & ",0," _
                & Me.ImporteTxt.Text & ",now(),'" & Me.DescripcionTxt.Text.ToString & "')"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                'ejecutar consulta
                DatosMCmd.ExecuteNonQuery()

                Dim NoIngreso As Integer
                SQL = "SELECT * from ingpropios where concepto='Agua Potable' and fecha='" & Now.Date.ToString("yyyy/MM/dd") & "' order by fecha desc limit 1"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                If DatosMDR.HasRows = True Then 'pregunta si devolvio filas
                    'entonces actualiza el ingreso

                    DatosMDR.Read()
                    NoIngreso = DatosMDR!id_ing
                    DatosMDR.Close()
                    SQL = "UPDATE ingpropios set ingreso= ingreso + " & Me.ImporteTxt.Text & " where id_ing=" & NoIngreso & " and fecha='" & Now.Date.ToString("yyyy/MM/dd") & "' limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMCmd.ExecuteNonQuery()

                Else
                    DatosMDR.Close()
                    'registrar el ingreso de hoy como nuevo
                    'aqui se registra el ingreso
                    SQL = "INSERT INTO ingpropios (fecha,concepto,ingreso) values('" & Now.Date.ToString("yyyy/MM/dd") & "','Agua Potable'," & Me.ImporteTxt.Text & ")"
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
                    SQL = "UPDATE ingpropiosres set ingresos= ingresos + " & Me.ImporteTxt.Text & ", encaja= encaja + " & Me.ImporteTxt.Text & " limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMCmd.ExecuteNonQuery()
                Else
                    DatosMDR.Close()
                    SQL = "INSERT INTO ingpropiosres (ingresos,encaja) values(" & Me.ImporteTxt.Text & "," & Me.ImporteTxt.Text & ")"
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
                Try
                    Imprimir()
                Catch Err As Exception
                    MessageBox.Show(Err.Message, "ERROR: No se encuentra el modulo de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Ingrese la descripcion del motivo de la multa y el importe", "Multas de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Close()
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
                ImprimirFactura.Contrib = Me.NombreTxt.Text.ToUpper & ControlChars.CrLf & Calle.ToUpper & " " & Numero.ToString & ControlChars.CrLf & Localidad.ToUpper
                Dim r, l As Short
                Dim I, lineas As Decimal ' auxiliares para incrementar el numero de lineas a dejar en sao de que el contenido sea largo
                Dim DescConcep As String

                'I = Me.DetallesDtg.Item(0, r).Value.ToString.Length / 25 'obtiene el numero de lineas que tiene la descripcion 'REEMPLAZAR CONTENIDO POR LA DESCRIPCION ORIGINAL
                DescConcep = "pago de MULTA de toma de agua potable numero: " & Me.NoTomaTxt.Text 'aqui se forma la descripcion del concepto

                ImprimirFactura.CantidStr += "1" & ControlChars.CrLf 'cantidades
                ImprimirFactura.Contenido += DescConcep & ControlChars.CrLf 'descripcion del concepto
                'ImprimirFactura.PUnit += Format(CStr(Val(Me.DetallesDtg.Item(1, r).Value)), "Currency").ToString & ControlChars.CrLf 'precio unitario
                ImprimirFactura.PUnit += String.Format("{0:c}", Val(Me.ImporteTxt.Text)) & ControlChars.CrLf
                'ImprimirFactura.Totals += Format(CStr(Val(Me.DetallesDtg.Item(3, r).Value)), "Currency").ToString & ControlChars.CrLf 'aqui va el subtotal
                ImprimirFactura.Totals += String.Format("{0:c}", Val(Me.ImporteTxt.Text)) & ControlChars.CrLf


                ' si tiene observaciones, las imprime
                If Me.DescripcionTxt.Text <> "" Then
                    ImprimirFactura.Contenido += ControlChars.CrLf & Me.DescripcionTxt.Text
                End If

                ImprimirFactura.TotNeto = Val(Me.ImporteTxt.Text) ' aqui va el total neto
                ImprimirFactura.Imprimir = True
                ImprimirFactura.Show()
                'aqui pregruntar si salio bien la factura
                If MessageBox.Show("SELECCIONE SI PARA TERMINAR" & Chr(13) & "SELECCIONE NO PARA REIMPRIMIR", "¿LA FACTURA FUE IMPRESA CORRECTAMENTE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    'SELECCINO no
                    'PREGUNTAR SI  CONFIRMA LA REIMPRESION
                    If MessageBox.Show("CONFIRMA LA REIMPRESION DE LA FACTURA", "REIMPRESION DE FACTURA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'SE VUELVE A IMPRIMIR LA FACTURA Y SE TIENE QUE MODIFICAR EL NO. DE FACTURA Y AGREGAR LA FACTURA QUE FALLO A CANCELADAS
                        SQL = "update cobroagua set nofactura=nofactura+1 where nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        'ejecutar consulta
                        DatosMCmd.ExecuteNonQuery()

                        'registrar la factura cancelada
                        SQL = "INSERT INTO factcancel (factura,anombrede,descripcion,fecha) values(" & Me.NoFacturaTxt.Text & ",'" & Me.NombreTxt.Text & "','Fallo de impresion - Agua Potable','" & Now.Date.ToString("yyyy/MM/dd") & "')"
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

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub

    Private Sub ImporteTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ImporteTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        NumeroDec(e, Me.ImporteTxt)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class