Imports System.String
Imports Contribuyentes
Imports MySql.Data.MySqlClient
Imports ImprimirFactura
Public Class NuevoIngresoFrm
    Public Comando As String
    Public IdContr, IdPago As Integer
    Dim auto As Boolean
    Dim ImprimirFactura As ImprimirFactura.Imprimirfrm

    Private Sub NuevoIngresoFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LimpiarDatos()
        e.Cancel = False
    End Sub
    Private Sub NuevoIngresoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.FechaLbl.Text = Now.Date.ToShortDateString
        'cargar la ultima factura y el ultimo cobro
        RegistroCivilfrm.Cobrado = False
        Me.AceptarBtn.Enabled = False
        Me.DatosContribBtn.Enabled = False
        Me.SuPagoTxt.Enabled = False
        Me.AgregarBtn.Enabled = False
        Me.EliminarBtn.Enabled = False
        Me.Nombrecmb.Enabled = False
        Me.LocalidadCmb.ReadOnly = True
        Me.Numerotxt.ReadOnly = True
        Me.CallesCmb.ReadOnly = True
        Select Case Comando
            Case "Nuevo"
                Me.AceptarBtn.Enabled = False
                Me.DatosContribBtn.Enabled = True
                Me.AgregarBtn.Enabled = True
                Me.EliminarBtn.Enabled = True
                Me.Nombrecmb.Enabled = True
                Me.LocalidadCmb.ReadOnly = False
                Me.CallesCmb.ReadOnly = False
                Me.Numerotxt.ReadOnly = False
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
                UltimaFactura()

                Me.Nombrecmb.Focus()
            Case "Abrir"
                'Cargar Ultimo Pago realizado de la toma
                CargarPago()
                Me.CerrarBtn.Focus()
        End Select
    End Sub
    Sub UltimoPago()
        SQL = "SELECT id_reg from cobroregcivil order by id_reg desc limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.NoCobrotxt.Text = DatosMDR!id_reg + 1
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
                'Me.CallesCmb.Items.Clear()
                Me.CallesCmb.Text = DatosMDR!calle
                'Me.LocalidadesCmb.Items.Clear()
                Me.LocalidadCmb.Text = DatosMDR!localidad
                Me.Numerotxt.Text = DatosMDR!numero
                Me.Nombrecmb.Text = DatosMDR!nombre
                IdContr = DatosMDR!id
                DatosMDR.Close()
                Me.AgregarBtn.Focus()
                Exit Sub
            Else
                Me.CallesCmb.Text = ""
                Me.LocalidadCmb.Text = ""
                Me.Numerotxt.Text = ""
            End If
            'DatosMCmd.Dispose()
            DatosMDR.Close()
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
            'DatosMDR.Close()
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

    Private Sub Nombrecmb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nombrecmb.TextChanged
        If Me.Nombrecmb.Text.Length = 0 Then
            Me.Nombrecmb.Items.Clear()
            auto = False
            Me.LocalidadCmb.Text = ""
            Me.CallesCmb.Text = ""
            Me.Numerotxt.Text = ""
        End If
    End Sub

    Private Sub AgregarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarBtn.Click
        AgregaConceptoFrm.ShowDialog()
        Me.SuPagoTxt.Focus()
        'calcular total
        CargarTotales()
        If Me.DetallesDtg.Rows.Count > 0 Then
            Me.SuPagoTxt.Enabled = True
        Else
            Me.SuCambioTxt.Enabled = False
            Me.AceptarBtn.Enabled = False
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

    Private Sub EliminarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBtn.Click
        Me.DetallesDtg.Rows.Remove(Me.DetallesDtg.Rows(Me.DetallesDtg.CurrentRow.Index))
        'cargar totales
        CargarTotales()
        If Val(Me.ImporteTxt.Text) > 0 Then
            Me.SuPagoTxt.Enabled = True
        Else
            Me.SuPagoTxt.Enabled = False
            Me.AceptarBtn.Enabled = False
        End If
    End Sub
    Sub CargarTotales()
        If Me.DetallesDtg.Rows.Count > 0 Then
            Me.ImporteTxt.Text = ""
            Me.ConceptosTxt.Text = Me.DetallesDtg.Rows.Count
            Dim i As Short
            For i = 0 To Me.DetallesDtg.Rows.Count - 1
                Me.ImporteTxt.Text = Val(Me.ImporteTxt.Text) + Val(Me.DetallesDtg.Item(3, i).Value.ToString)
            Next
        Else
            Me.ImporteTxt.Text = ""
            Me.ConceptosTxt.Text = ""
        End If
    End Sub

    Sub CargarPago()
        Try
            SQL = "SELECT *  from cobroregcivil where id_reg= " & IdPago & " order by id_reg desc limit 1"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                DatosMDR.Read()
                Me.NoCobrotxt.Text = IdPago
                Me.Nombrecmb.Text = DatosMDR!nombre
                Me.LocalidadCmb.Text = DatosMDR!localidad
                Me.CallesCmb.Text = DatosMDR!calle
                Me.Numerotxt.Text = DatosMDR!numero
                Me.ConceptosTxt.Text = DatosMDR!conceptos
                Me.ImporteTxt.Text = DatosMDR!importe
                Me.NoFacturaTxt.Text = DatosMDR!nofactura
                Me.FechaLbl.Text = DatosMDR!fecha
                '.Text = DatosMDR!id_toma + 1
                DatosMDR.Close()


                'cargar los detalles
                SQL = "SELECT * from detallesregcivil where id_reg= " & Me.NoCobrotxt.Text & " order by id_detalle asc"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                While DatosMDR.Read
                    Me.DetallesDtg.Rows.Add(DatosMDR!tipo, DatosMDR!nombre, DatosMDR!folio, DatosMDR!costo, DatosMDR!comentario)
                End While
                DatosMDR.Close()

            Else
                MessageBox.Show("No se encontraron los detalles del pago No. " & IdPago, "Registro Civil", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'SQLCnn.Close()
                DatosMDR.Close()
                Me.Close()
            End If
            'DatosMCmd.Dispose()
            DatosMDR.Close()
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message, Ex.Number.ToString)
            DatosMDR.Close()
        End Try
    End Sub
    Sub LimpiarDatos()
        Me.Nombrecmb.Text = ""
        Me.Nombrecmb.Items.Clear()
        Me.LocalidadCmb.Text = ""
        Me.CallesCmb.Text = ""
        Me.Numerotxt.Text = ""
        Me.SuPagoTxt.Text = ""
        Me.SuCambioTxt.Text = ""
        Me.NoFacturaTxt.Text = ""
        Me.NoCobrotxt.Text = ""
        Me.ConceptosTxt.Text = ""
        Me.ImporteTxt.Text = ""
        Me.DetallesDtg.Rows.Clear()
    End Sub

    Private Sub SuPagoTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SuPagoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 13 Then
            'calcular su cambio
            If Val(Me.SuPagoTxt.Text) >= (Me.ImporteTxt.Text) Then
                Me.SuCambioTxt.Text = Format(CStr(Val(Me.SuPagoTxt.Text) - Val(Me.ImporteTxt.Text)), "Currency")
                Me.AceptarBtn.Enabled = True
                Me.AceptarBtn.Focus()
            Else
                MessageBox.Show("El pago del contribuyente no cubre el adeudo total", "Cobro de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.SuPagoTxt.Text = ""
                Me.AceptarBtn.Enabled = False
                Me.SuPagoTxt.Focus()
            End If
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        'preguntar si sale
        LimpiarDatos()
        If Comando = "Nuevo" Then
            If MessageBox.Show("¿Desea salir sin realizar el cobro?", "Registro Civil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                RegistroCivilfrm.Cobrado = False
                Me.Close()
            Else
                Exit Sub
            End If
        Else
            RegistroCivilfrm.Cobrado = False
            Me.Close()
        End If
        'LimpiarDatos()
    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Comando = "Nuevo" And Me.DetallesDtg.Rows.Count > 0 And Me.Nombrecmb.Text <> "" Then
            Dim i As Short
            Dim Descripcion, Comentario As String
            Descripcion = ""
            Comentario = ""
            For i = 0 To Me.DetallesDtg.Rows.Count - 1
                Descripcion += "1 " & Me.DetallesDtg.Item(0, i).Value.ToString & " de " & Me.DetallesDtg.Item(1, i).Value.ToString & " - "
                Comentario += Me.DetallesDtg.Item(4, i).Value.ToString & "- "
            Next
            If MessageBox.Show("¿Confima Registrar el Pago?", "Registro Civil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    SQL = "insert into cobroregcivil values(" & Me.NoCobrotxt.Text & "," & Me.NoFacturaTxt.Text & ",'" & Me.Nombrecmb.Text & "','" & _
                    Me.LocalidadCmb.Text & "','" & Me.CallesCmb.Text & "','" & Me.Numerotxt.Text & "','" & Descripcion & "'," & Me.ConceptosTxt.Text & "," & _
                    Me.ImporteTxt.Text & ",'" & Me.FechaLbl.Text & "','" & Comentario & "')"

                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()

                    'registrar los detalles
                    'obtener el ultimo detalle insertado
                    Dim UltimoDetalle As Integer
                    SQL = "SELECT id_detalle from detallesregcivil order by id_detalle desc limit 1"

                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        UltimoDetalle = DatosMDR!id_detalle
                        '.Text = DatosMDR!id_toma + 1
                    Else
                        UltimoDetalle = 0
                    End If
                    'DatosMCmd.Dispose()
                    DatosMDR.Close()

                    For i = 0 To Me.DetallesDtg.Rows.Count - 1
                        UltimoDetalle += 1
                        SQL = "insert into detallesregcivil values(" & UltimoDetalle & "," & Me.NoCobrotxt.Text & ",'" & _
                            Me.DetallesDtg.Item(0, i).Value.ToString & "','" & Me.DetallesDtg.Item(1, i).Value.ToString & "','" & _
                            Me.DetallesDtg.Item(2, i).Value.ToString & "'," & Me.DetallesDtg.Item(3, i).Value.ToString & ",'" & _
                            Me.FechaLbl.Text & "','" & Me.DetallesDtg.Item(4, i).Value.ToString & "')"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        'ejecutar consulta
                        DatosMCmd.ExecuteNonQuery()
                    Next


                    '##################################################
                    'Agregar ingreso a la tabla de ingresos


                    'comprobar si ya se registro un ingreso el dia de hoy
                    Dim NoIngreso As Integer
                    SQL = "SELECT * from ingpropios where concepto='Registro Civil' and fecha='" & Me.FechaLbl.Text & "' order by fecha desc limit 1"
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
                        SQL = "INSERT INTO ingpropios (fecha,concepto,ingreso) values('" & Me.FechaLbl.Text & "','Registro Civil'," & Me.ImporteTxt.Text & ")"
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

                    'avisar de que se registro el pago de la toma
                    MessageBox.Show("El registro del pago ha sido realizado con exito", "Registro Civil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        Imprimir()
                    Catch Err As Exception
                        MessageBox.Show(Err.Message, "ERROR: No se encuentra el modulo de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Catch Ex As MySqlException
                    MessageBox.Show(Ex.Message, Ex.Number.ToString)
                    DatosMDR.Close()
                End Try
                RegistroCivilfrm.Cobrado = True
            End If
        Else
            MessageBox.Show("El adeudo No se puede cobrar", "Registro Civil", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                ImprimirFactura.Contrib = Me.Nombrecmb.Text.ToUpper & ControlChars.CrLf & Me.CallesCmb.Text.ToUpper & " " & Me.Numerotxt.Text.ToString & ControlChars.CrLf & Me.LocalidadCmb.Text.ToUpper
                Dim r, l As Short
                Dim I, lineas As Decimal ' auxiliares para incrementar el numero de lineas a dejar en sao de que el contenido sea largo
                Dim DescConcep As String
                For r = 0 To Me.DetallesDtg.Rows.Count - 1
                    'I = Me.DetallesDtg.Item(0, r).Value.ToString.Length / 25 'obtiene el numero de lineas que tiene la descripcion 'REEMPLAZAR CONTENIDO POR LA DESCRIPCION ORIGINAL
                    'aqui se forma la descripcion del concepto
                    DescConcep = Me.DetallesDtg.Item(0, r).Value.ToString & " de " & Me.DetallesDtg.Item(1, r).Value.ToString & ". "
                    If Me.DetallesDtg.Item(2, r).Value.ToString <> "" Then ''folio
                        DescConcep += "Folio: " & Me.DetallesDtg.Item(2, r).Value.ToString
                    End If
                    If Me.DetallesDtg.Item(4, r).Value.ToString <> "" Then
                        DescConcep += "; " & Me.DetallesDtg.Item(4, r).Value.ToString 'Comentario
                    End If

                    lineas = DescConcep.Length / 25
                    '                    If ((DescConcep.Length / 25) - Int(DescConcep.Length / 25)) > 0 Then
                    lineas = DescConcep.Length Mod 25
                    If (DescConcep.Length Mod 25) > 0 Then
                        I = Int(DescConcep.Length / 25) + 1
                    Else
                        I = Int(DescConcep.Length / 25)
                    End If
                    ImprimirFactura.CantidStr += "1" & ControlChars.CrLf 'cantidades
                    ImprimirFactura.Contenido += DescConcep & ControlChars.CrLf 'descripcion del concepto
                    'ImprimirFactura.PUnit += Format(CStr(Val(Me.DetallesDtg.Item(1, r).Value)), "Currency").ToString & ControlChars.CrLf 'precio unitario
                    ImprimirFactura.PUnit += String.Format("{0:c}", Val(Me.DetallesDtg.Item(3, r).Value)) & ControlChars.CrLf
                    'ImprimirFactura.Totals += Format(CStr(Val(Me.DetallesDtg.Item(3, r).Value)), "Currency").ToString & ControlChars.CrLf 'aqui va el subtotal
                    ImprimirFactura.Totals += String.Format("{0:c}", Val(Me.DetallesDtg.Item(3, r).Value)) & ControlChars.CrLf
                    For l = 1 To I - 1 ' aqui se agregan las nuevas lineas
                        ImprimirFactura.CantidStr += ControlChars.CrLf
                        ImprimirFactura.PUnit += ControlChars.CrLf
                        ImprimirFactura.Totals += ControlChars.CrLf
                    Next
                Next
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
                        SQL = "update cobroregcivil set nofactura=nofactura+1 where id_reg=" & Me.NoCobrotxt.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        'ejecutar consulta
                        DatosMCmd.ExecuteNonQuery()

                        'registrar la factura cancelada
                        SQL = "INSERT INTO factcancel (factura,anombrede,descripcion,fecha) values(" & Me.NoFacturaTxt.Text & ",'" & Me.Nombrecmb.Text & "','Fallo de impresion - Registro Civil','" & Me.FechaLbl.Text & "')"
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