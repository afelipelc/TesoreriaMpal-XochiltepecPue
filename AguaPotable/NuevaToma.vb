Imports System
Imports System.Threading
Imports Contribuyentes
Imports MySql.Data.MySqlClient
Imports System.Text
Imports ImprimirFactura
Public Class NuevaTomafrm
    Public Comando As String
    Public NoToma, Indice, IdContr As Integer
    Public UltimoPago, PagHasta As String
    Dim auto As Boolean
    Dim ImprimirFactura As ImprimirFactura.Imprimirfrm
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
            Me.LocalidadesCmb.Text = ""
            Me.CallesCmb.Text = ""
            Me.Numerotxt.Text = ""
            'Me.LocalidadesCmb.Items.Clear()
            'Me.CallesCmb.Items.Clear()
            'CargarLocalidades()
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
                'Me.CallesCmb.Items.Clear()
                Me.CallesCmb.Text = DatosMDR!calle
                'Me.LocalidadesCmb.Items.Clear()
                Me.LocalidadesCmb.Text = DatosMDR!localidad
                Me.Numerotxt.Text = DatosMDR!numero
                Me.Nombrecmb.Text = DatosMDR!nombre
                IdContr = DatosMDR!id
                DatosMDR.Close()
                Me.NoTomasTxt.Focus()
                Exit Sub
            Else
                Me.CallesCmb.Text = ""
                Me.LocalidadesCmb.Text = ""
            End If
            'DatosMCmd.Dispose()
            DatosMDR.Close()
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
            'DatosMDR.Close()
        End Try
    End Sub

    Private Sub NuevaTomafrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ConectaServer()
        Me.NoFacturaTxt.Text = ""
        Me.ImporteRegistroTxt.Text = ""
        If Comando = "Nueva" Then
            'obtener el numero de ultima toma
            UltimaToma()
            Me.Nombrecmb.Focus()
            Me.PagoHastaTxt.ReadOnly = True
            Me.ImporteRegistroTxt.ReadOnly = False
            Me.RegistrarPagoRegChk.Enabled = True
            Me.RegistrarPagoRegChk.Checked = True
            UltimaFactura()
            CostoRegistro()
        End If
        If Comando = "Editar" Then 'si se va a modificar los datos de la toma
            'cargar datos de la toma por consulta
            Me.PagoHastaTxt.ReadOnly = False
            CargarToma()
            Me.DetallesTarBtn.Visible = True
            Me.ImporteRegistroTxt.ReadOnly = True
            Me.RegistrarPagoRegChk.Enabled = False
            'IdContr = 1
        End If
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
    Sub CostoRegistro()
        SQL = "SELECT costoregistro from configagua limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.ImporteRegistroTxt.Text = Val(DatosMDR!costoregistro)
        Else
            Me.ImporteRegistroTxt.Text = 0
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Me.Nombrecmb.Text.Length = 0 Or Me.IdTarifaTxt.Text.Length = 0 Or Me.NoTomasTxt.Text.Length = 0 Then
            MessageBox.Show("A_Nombre_de, No_Tarifa y No_Tomsa. no pueden quedar vacios", "Tomas de Agua Potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'If IdContr = 0 Then
        ' MessageBox.Show("El contribuyente no se encuentra Registrado", "Toma de Agua Potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Me.CallesCmb.Text = ""
        ' Me.Numerotxt.Text = ""
        ' Me.LocalidadesCmb.Text = ""
        'Me.TomaIdTxt.Text = ""
        'Me.NombreTarifaTxt.Text = ""
        ' Exit Sub
        ' Else
        Try
            Select Case Comando

                Case "Nueva"
                    'aqui se registra la nueva toma
                    UltimoPago = ""
                    PagHasta = ""
                    AgregaPeriodofrm.Comando = "Historial"
                    AgregaPeriodofrm.Tarifa = Val(Me.IdTarifaTxt.Text)
                    AgregaPeriodofrm.ShowDialog()
                    SQL = "insert into aguapotable values(" & Me.TomaIdTxt.Text & "," & Me.NoTomasTxt.Text & "," & Me.IdTarifaTxt.Text & ",'" & _
                    Me.Nombrecmb.Text & "','" & Me.LocalidadesCmb.Text & "','" & Me.CallesCmb.Text & "','" & Me.Numerotxt.Text & "','" & UltimoPago & "','" & PagHasta & "','Activa',' ',0,'" & Me.ComentarioTxt.Text & " ')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()

                    'AQUI SE REGISTRA EL PAGO SI NO ESTA REGISTRADO
                    If Me.RegistrarPagoRegChk.Checked = True Then
                        If MessageBox.Show("¿Confirma registrar el pago de registro de nueva toma?", "Nueva Toma de Agua Potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            'registrar el ingreso
                            SQL = "insert into cobroagua(nofactura,id_toma,id_tarifa,nombre,localidad,calle,numero,pagodesde,pagohasta,tomas,meses,importe,fechapago,observaciones) values(" & Me.NoFacturaTxt.Text & "," & Me.TomaIdTxt.Text & "," & Me.IdTarifaTxt.Text & ",'" & _
                                        Me.Nombrecmb.Text & "','" & Me.LocalidadesCmb.Text & "','" & Me.CallesCmb.Text & "','" & Me.Numerotxt.Text & "','Registro','Registro'," & Me.NoTomasTxt.Text & ",0," _
                                        & Me.ImporteRegistroTxt.Text & ",now(),'" & Me.ComentarioTxt.Text.ToString & "')"
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
                                SQL = "UPDATE ingpropios set ingreso= ingreso + " & Me.ImporteRegistroTxt.Text & " where id_ing=" & NoIngreso & " and fecha='" & Now.Date.ToString("yyyy/MM/dd") & "' limit 1"
                                DatosMCmd = New MySqlCommand
                                DatosMCmd.CommandText = SQL
                                DatosMCmd.Connection = SQLCnn
                                DatosMCmd.ExecuteNonQuery()

                            Else
                                DatosMDR.Close()
                                'registrar el ingreso de hoy como nuevo
                                'aqui se registra el ingreso
                                SQL = "INSERT INTO ingpropios (fecha,concepto,ingreso) values('" & Now.Date.ToString("yyyy/MM/dd") & "','Agua Potable'," & Me.ImporteRegistroTxt.Text & ")"
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
                                SQL = "UPDATE ingpropiosres set ingresos= ingresos + " & Me.ImporteRegistroTxt.Text & ", encaja= encaja + " & Me.ImporteRegistroTxt.Text & " limit 1"
                                DatosMCmd = New MySqlCommand
                                DatosMCmd.CommandText = SQL
                                DatosMCmd.Connection = SQLCnn
                                DatosMCmd.ExecuteNonQuery()
                            Else
                                DatosMDR.Close()
                                SQL = "INSERT INTO ingpropiosres (ingresos,encaja) values(" & Me.ImporteRegistroTxt.Text & "," & Me.ImporteRegistroTxt.Text & ")"
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

                            'imprimir la factura
                            Try
                                Imprimir()
                            Catch Err As Exception
                                MessageBox.Show(Err.Message, "ERROR: No se encuentra el modulo de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try

                        End If
                    Else
                        MessageBox.Show("El pago de registro de nueva toma no fue registrado", "Nueva Toma de Agua Potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Case "Editar"
                    If MessageBox.Show("¿Confirma Actualizar los datos de la toma de agua potable?", "Tomas de Agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        'aqui se actualiza la toma
                        SQL = "UPDATE aguapotable set tomas=" & Me.NoTomasTxt.Text & ", nombre ='" & Me.Nombrecmb.Text & "', localidad='" & Me.LocalidadesCmb.Text & "', calle='" & Me.CallesCmb.Text & "', numero='" & Me.Numerotxt.Text & "', id_tarifa=" & Me.IdTarifaTxt.Text & ", pagohasta='" & Me.PagoHastaTxt.Text.ToString & "', observaciones='" & Me.ComentarioTxt.Text.ToString & "' where id_toma=" & Me.TomaIdTxt.Text
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                    End If
            End Select
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message, "Error: " & Ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'SQLCnn.Close()
        Me.CallesCmb.Text = ""
        Me.Numerotxt.Text = ""
        Me.TomaIdTxt.Text = ""
        Me.IdTarifaTxt.Text = ""
        Me.NombreTarifaTxt.Text = ""
        Me.NoTomasTxt.Text = ""
        Me.Nombrecmb.Text = ""
        Me.PagoHastaTxt.Text = ""
        Me.ComentarioTxt.Text = ""

        IdContr = 0
        Me.Close()
        'End If
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
                ImprimirFactura.Contrib = Me.Nombrecmb.Text.ToUpper & ControlChars.CrLf & Me.CallesCmb.Text.ToUpper & " " & Me.Numerotxt.Text.ToString & ControlChars.CrLf & Me.LocalidadesCmb.Text.ToUpper
                Dim r, l As Short
                Dim I, lineas As Decimal ' auxiliares para incrementar el numero de lineas a dejar en sao de que el contenido sea largo
                Dim DescConcep As String

                'I = Me.DetallesDtg.Item(0, r).Value.ToString.Length / 25 'obtiene el numero de lineas que tiene la descripcion 'REEMPLAZAR CONTENIDO POR LA DESCRIPCION ORIGINAL
                DescConcep = "pago de registro de nueva toma de agua potable numero: " & Me.TomaIdTxt.Text 'aqui se forma la descripcion del concepto

                ImprimirFactura.CantidStr += "1" & ControlChars.CrLf 'cantidades
                ImprimirFactura.Contenido += DescConcep & ControlChars.CrLf 'descripcion del concepto
                'ImprimirFactura.PUnit += Format(CStr(Val(Me.DetallesDtg.Item(1, r).Value)), "Currency").ToString & ControlChars.CrLf 'precio unitario
                ImprimirFactura.PUnit += String.Format("{0:c}", Val(Me.ImporteRegistroTxt.Text)) & ControlChars.CrLf
                'ImprimirFactura.Totals += Format(CStr(Val(Me.DetallesDtg.Item(3, r).Value)), "Currency").ToString & ControlChars.CrLf 'aqui va el subtotal
                ImprimirFactura.Totals += String.Format("{0:c}", Val(Me.ImporteRegistroTxt.Text)) & ControlChars.CrLf


                ' si tiene observaciones, las imprime
                If Me.ComentarioTxt.Text <> "" Then
                    ImprimirFactura.Contenido += ControlChars.CrLf & Me.ComentarioTxt.Text
                End If

                ImprimirFactura.TotNeto = Val(Me.ImporteRegistroTxt.Text) ' aqui va el total neto
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
                        SQL = "INSERT INTO factcancel (factura,anombrede,descripcion,fecha) values(" & Me.NoFacturaTxt.Text & ",'" & Me.Nombrecmb.Text & "','Fallo de impresion - Agua Potable','" & Now.Date.ToString("yyyy/MM/dd") & "')"
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

    Private Sub TarifasBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarifasBtn.Click
        'mostrar lista de tarifas
        MuestraTarifasfrm.ShowDialog()
        If Me.IdTarifaTxt.Text <> "" Then
            Me.TarifasBtn.Visible = True
        End If
    End Sub

    Private Sub DetallesTarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetallesTarBtn.Click
        DetalleTarifasfrm.IdTarifa = Val(Me.IdTarifaTxt.Text)
        DetalleTarifasfrm.Nombretar = Me.NombreTarifaTxt.Text
        DetalleTarifasfrm.ShowDialog()
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        'SQLCnn.Close()
        Me.IdTarifaTxt.Text = ""
        'Me.Nombrecmb.Text = ""
        Me.CallesCmb.Text = ""
        Me.LocalidadesCmb.Text = ""
        Me.Numerotxt.Text = ""
        Me.TomaIdTxt.Text = ""
        Me.NombreTarifaTxt.Text = ""
        Me.NoTomasTxt.Text = ""
        Me.Nombrecmb.Text = ""
        Me.PagoHastaTxt.Text = ""
        Me.ComentarioTxt.Text = ""
        IdContr = 0
        Comando = ""
        Me.Close()
        'CargarAguafrm.Close()
    End Sub

    Sub UltimaToma()
        SQL = "SELECT id_toma from aguapotable order by id_toma desc limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.TomaIdTxt.Text = DatosMDR!id_toma + 1
        Else
            Me.TomaIdTxt.Text = 1
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub
    Sub CargarToma()
        Try
            SQL = "SELECT * from aguapotable where id_toma='" & NoToma & "'"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                DatosMDR.Read()
                Me.Nombrecmb.Text = DatosMDR!nombre
                Me.CallesCmb.Text = DatosMDR!calle
                Me.Numerotxt.Text = DatosMDR!numero
                Me.LocalidadesCmb.Text = DatosMDR!localidad
                Me.TomaIdTxt.Text = NoToma
                Me.NoTomasTxt.Text = DatosMDR!tomas
                Me.IdTarifaTxt.Text = DatosMDR!id_tarifa
                Me.PagoHastaTxt.Text = DatosMDR!pagohasta
                Me.ComentarioTxt.Text = DatosMDR!observaciones
                IdContr = 1
            End If
            DatosMDR.Close()
            SQL = "SELECT nombre from tarifasagua where id_tarifa='" & Me.IdTarifaTxt.Text & "'"
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
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
            'DatosMDR.Close()
        End Try
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

    End Sub

    Private Sub NoTomasTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NoTomasTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 13 Then
            'saltar al otro txt
            Me.TarifasBtn.Focus()
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ImporteRegistroTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ImporteRegistroTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        NumeroDec(e, Me.ImporteRegistroTxt)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class