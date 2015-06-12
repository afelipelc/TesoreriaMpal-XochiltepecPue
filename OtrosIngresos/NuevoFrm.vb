Imports MySql.Data.MySqlClient
Imports Contribuyentes
Imports System.String
Imports ImprimirFactura
Public Class NuevoFrm
    Dim auto As Boolean
    Dim IdContr As Integer
    Dim ImprimirFactura As ImprimirFactura.Imprimirfrm

    Sub LimpiarDatos()
        Me.NoFacturaTxt.Text = ""
        Me.Nombrecmb.Items.Clear()
        Me.Nombrecmb.Text = ""
        Me.MpioTxt.Text = ""
        Me.DireccionTxt.Text = ""
        Me.ImporteTxt.Text = ""
        Me.ConceptoTxt.Text = ""
    End Sub
    Private Sub NuevoFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LimpiarDatos()
        e.Cancel = False
    End Sub
    Private Sub NuevoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UltimaFactura()
        Me.FechaLbl.Text = Now.Year & "-" & Now.Month & "-" & Now.Day
        Me.Nombrecmb.Focus()
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
        Me.ImporteTxt.Focus()
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Private Sub ImporteTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ImporteTxt.KeyPress
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
        If Me.Nombrecmb.Text <> "" And Me.ConceptoTxt.Text <> "" And Me.ImporteTxt.Text <> "" Then
            If MessageBox.Show("¿Confirma registrar el ingreso?", "Otros Ingresos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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

                    SQL = "INSERT INTO otrosing (nofactura,nombre,domicilio,concepto,importe,fecha) values(" & Me.NoFacturaTxt.Text & ",'" & Me.Nombrecmb.Text & "','" & Me.DireccionTxt.Text & "','" & Me.ConceptoTxt.Text & "'," & Me.ImporteTxt.Text & ",'" & Fecha & "')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMCmd.ExecuteNonQuery()

                    '################################################
                    'Agregar ingreso a la tabla de ingresos
                    'comprobar si ya se registro un ingreso el dia de hoy
                    Dim NoIngreso As Integer
                    SQL = "SELECT * from ingpropios where concepto='Otros Ingresos' and fecha='" & Fecha & "' order by fecha desc limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    If DatosMDR.HasRows = True Then 'pregunta si devolvio filas
                        'entonces actualiza el ingreso
                        DatosMDR.Read()
                        NoIngreso = DatosMDR!id_ing
                        DatosMDR.Close()
                        SQL = "UPDATE ingpropios set ingreso= ingreso + " & Me.ImporteTxt.Text & " where id_ing=" & NoIngreso & " and fecha='" & Fecha & "' limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()

                    Else
                        DatosMDR.Close()
                        'registrar el ingreso de hoy como nuevo
                        'aqui se registra el ingreso
                        SQL = "INSERT INTO ingpropios (fecha,concepto,ingreso) values('" & Fecha & "','Otros Ingresos'," & Me.ImporteTxt.Text & ")"
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
                        SQL = "UPDATE ingpropiosres set ingresos= ingresos + " & Me.ImporteTxt.Text & ", encaja= encaja + " & Me.ImporteTxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    Else
                        DatosMDR.Close()
                        SQL = "INSERT INTO ingpropiosres (ingresos,encaja) values(" & Me.ImporteTxt.Text & "," & Me.ImporteTxt.Text & ")" 'values(" & Me.ImporteTxt.Text & ",0,0,0,0)"
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
                    MessageBox.Show("El registro del ingreso ha sido realizado con éxito", "Otros Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            MessageBox.Show("Ingrese el Nombre, Concepto e Importe", "Otros Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                ImprimirFactura.Contrib = Me.Nombrecmb.Text.ToUpper & ControlChars.CrLf & Me.DireccionTxt.Text.ToUpper & ControlChars.CrLf & Me.MpioTxt.Text.ToUpper
                
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
                        SQL = "update otrosing set nofactura=nofactura+1 where nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        'ejecutar consulta
                        DatosMCmd.ExecuteNonQuery()

                        'registrar la factura cancelada
                        SQL = "INSERT INTO factcancel (factura,anombrede,descripcion,fecha) values(" & Me.NoFacturaTxt.Text & ",'" & Me.Nombrecmb.Text & "','Fallo de impresion - Otros Ingresos','" & Me.FechaLbl.Text & "')"
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

    Private Sub Nombrecmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombrecmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'si presiona espacio
        IdContr = 0
        If KeyAscii = 32 And auto = False Then
            'cargar consulta "%like%" de nombres
            Try
                SQL = "SELECT nombre from contribuyente where nombre like '%" & Me.Nombrecmb.Text & "%'"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                'comprobar que si ahi datos de configuracion
                While DatosMDR.Read()
                    Me.Nombrecmb.Items.Add(DatosMDR!nombre)
                End While
                DatosMDR.Close()
                auto = True
            Catch Ex As MySqlException
                MessageBox.Show(Ex.Message)
                'DatosMDR.Close()
            End Try
        End If
    End Sub

    Private Sub Nombrecmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nombrecmb.SelectedIndexChanged
        Me.Nombrecmb.Text = Me.Nombrecmb.SelectedItem
        'hacer consulta y rellenar los datos automaticamente
        Try
            SQL = "SELECT * from contribuyente where nombre='" & Me.Nombrecmb.Text & "'"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                DatosMDR.Read()

                Me.DireccionTxt.Text = DatosMDR!calle & " " & DatosMDR!numero
                Me.MpioTxt.Text = DatosMDR!localidad
                Me.Nombrecmb.Text = DatosMDR!nombre
                IdContr = DatosMDR!id
                DatosMDR.Close()
                Me.ConceptoTxt.Focus()
                Exit Sub
            Else
                Me.DireccionTxt.Text = ""
            End If
            'DatosMCmd.Dispose()
            DatosMDR.Close()
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
            DatosMDR.Close()
        End Try
    End Sub

    Private Sub Nombrecmb_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nombrecmb.TextChanged
        If Me.Nombrecmb.Text.Length = 0 Then
            Me.Nombrecmb.Items.Clear()
            auto = False
            Me.DireccionTxt.Text = ""
        End If
    End Sub

    Private Sub DatosContribBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosContribBtn.Click
        Dim Contribuyente As Contribuyentes.DatosContribuyentefrm
        Contribuyente = New Contribuyentes.DatosContribuyentefrm

        If Me.Nombrecmb.Text = "" Or IdContr = 0 Then
            Contribuyente.Comando = "Nuevo"
        Else
            Contribuyente.IdContr = IdContr
            Contribuyente.Comando = "Editar"
        End If
        Me.Nombrecmb.Text = ""
        Contribuyente.ShowDialog()
        'ConectaServer()
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        LimpiarDatos()
        Me.Close()
    End Sub

    Private Sub CantidadTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 13 Then
            Me.ImporteTxt.Focus()
            Exit Sub
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class