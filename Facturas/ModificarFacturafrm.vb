Imports System
Imports MySql.Data.MySqlClient
Public Class ModificarFacturafrm
    Dim Importe As Double
    Private Sub ModificarFacturafrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IngresoDeCmb.SelectedValue = ""
        Me.IngresoDeCmb.SelectedItem = Nothing
        Me.IngresoDeCmb.Text = ""
        Importe = 0
        ConectaServer()
        Me.DatosFactGpb.Enabled = False
    End Sub
    Private Sub BuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBtn.Click
        If Me.NoFacturaTxt.Text = "" Or Me.IngresoDeCmb.Text = "" Then
            MessageBox.Show("Ingrese el numero de factura y el origen del ingreso", "Cambiar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Encontrado As Boolean
            'AQUI LOCALIZA LA FACTURA
            Select Case Me.IngresoDeCmb.Text

                Case "Agua Potable"
                    SQL = "SELECT nombre, pagodesde, pagohasta, importe, fechapago, observaciones from cobroagua where nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        Me.NombreTxt.Text = DatosMDR!nombre.ToString
                        Me.ConceptoTxt.Text = "Pago de agua potable de: " & DatosMDR!pagodesde.ToString & " a " & DatosMDR!pagohasta.ToString
                        Me.ObservacionesTxt.Text = DatosMDR!observaciones.ToString
                        Me.ImporteTxt.Text = DatosMDR!importe
                        Importe = DatosMDR!importe
                        Me.FechaLbl.Text = DatosMDR!fechapago
                        Encontrado = True
                    End If
                    DatosMDR.Close()

                Case "Retro y volteo"
                    SQL = "SELECT nombre, descripcion, importe, fecha, comentario from cobromaquina where nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        Me.NombreTxt.Text = DatosMDR!nombre.ToString
                        Me.ConceptoTxt.Text = DatosMDR!descripcion.ToString
                        Me.ObservacionesTxt.Text = DatosMDR!comentario.ToString
                        Me.ImporteTxt.Text = DatosMDR!importe
                        Importe = DatosMDR!importe
                        Me.FechaLbl.Text = DatosMDR!fecha
                        Encontrado = True
                    End If
                    DatosMDR.Close()

                Case "Registro Civil"
                    SQL = "SELECT nombre, descripcion, importe, fecha, comentario from cobroregcivil where nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        Me.NombreTxt.Text = DatosMDR!nombre.ToString
                        Me.ConceptoTxt.Text = DatosMDR!descripcion.ToString
                        Me.ObservacionesTxt.Text = DatosMDR!comentario.ToString
                        Me.ImporteTxt.Text = DatosMDR!importe
                        Importe = DatosMDR!importe
                        Me.FechaLbl.Text = DatosMDR!fecha
                        Encontrado = True
                    End If
                    DatosMDR.Close()

                Case "Tortilleria"
                    SQL = "SELECT periodo, importe, fecha from tortilleria where nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        Me.NombreTxt.Text = "Tortilleria Municipal"
                        Me.ConceptoTxt.Text = "Ingreso de " & DatosMDR!periodo.ToString
                        Me.ObservacionesTxt.Text = ""
                        Me.ImporteTxt.Text = DatosMDR!importe
                        Importe = DatosMDR!importe
                        Me.FechaLbl.Text = DatosMDR!fecha
                        Encontrado = True
                    End If
                    DatosMDR.Close()

                Case "Otros Ingresos"
                    SQL = "SELECT nombre, concepto, importe, fecha from otrosing where nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        Me.NombreTxt.Text = DatosMDR!nombre
                        Me.ConceptoTxt.Text = DatosMDR!concepto.ToString
                        Me.ObservacionesTxt.Text = ""
                        Me.ImporteTxt.Text = DatosMDR!importe
                        Importe = DatosMDR!importe
                        Me.FechaLbl.Text = DatosMDR!fecha
                        Encontrado = True
                    End If
                    DatosMDR.Close()
            End Select
            If Encontrado = False Then
                MessageBox.Show("No se encontro la factura en " & Me.IngresoDeCmb.Text, "Cambiar factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.DatosFactGpb.Enabled = True
                Me.LocalizarFactGpb.Enabled = False
                Me.CambiarBtn.Enabled = True
            End If
        End If
    End Sub

    Private Sub NoFacturaTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NoFacturaTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 13 Then
            'saltar al otro txt
            Me.IngresoDeCmb.Focus()
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub IngresoDeCmb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IngresoDeCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            Me.BuscarBtn.Focus()
            'impedir que ingrese datos
        Else
            KeyAscii = 0
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub IngresoDeCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoDeCmb.SelectedIndexChanged
        Me.IngresoDeCmb.Text = Me.IngresoDeCmb.SelectedItem
    End Sub
    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub

    Private Sub ImporteTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ImporteTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        NumeroDec(e, Me.ImporteTxt)

        If KeyAscii = 13 Then
            Me.CambiarBtn.Focus()
            Exit Sub
        End If

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CambiarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarBtn.Click
        If MessageBox.Show("¿Confirma cambiar el importe de la factura?", "Cambiar factura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                'AQUI SE ACTUALIZA EL IMPORTE DE LA FACTURA
                Dim Fecha As Date
                Fecha = Me.FechaLbl.Text
                Select Case Me.IngresoDeCmb.Text
                    Case "Agua Potable"
                        SQL = "UPDATE  cobroagua SET importe=" & Me.ImporteTxt.Text & ", observaciones='" & Me.ObservacionesTxt.Text & "'  where nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                        EjecutaConsulta()
                        'RESTAR EL MPORTE ANTERIO A LOS INGRESOS
                        SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " - " & Importe & " where concepto='Agua Potable' and fecha='" & Fecha.Date.ToString("yyyy-MM-dd") & "' limit 1"
                        EjecutaConsulta()
                        'sumar el nuevo importe modificado
                        'SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " where concepto='Agua Potable' and fecha='" & Me.FechaLbl.Text.ToString("yyyy/MM/dd") & "' limit 1"
                        'EjecutaConsulta()
                    Case "Retro y volteo"
                        SQL = "UPDATE cobromaquina SET importe=" & Me.ImporteTxt.Text & ", comentario='" & Me.ObservacionesTxt.Text & "' WHERE nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                        EjecutaConsulta()
                        'RESTAR EL MPORTE ANTERIO A LOS INGRESOS
                        SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " - " & Importe & " where concepto='Retro y Volteo' and fecha='" & Fecha.Date.ToString("yyyy-MM-dd") & "' limit 1"
                        EjecutaConsulta()
                        'sumar el nuevo importe modificado
                        'SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " where concepto='Retro y Volteo' and fecha='" & Me.FechaLbl.Text.ToString("yyyy/MM/dd") & "' limit 1"
                        'EjecutaConsulta()

                    Case "Registro Civil"
                        SQL = "UPDATE cobroregcivil SET importe=" & Me.ImporteTxt.Text & ", comentario='" & Me.ObservacionesTxt.Text & "' WHERE nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                        EjecutaConsulta()
                        'RESTAR EL MPORTE ANTERIO A LOS INGRESOS
                        SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " - " & Importe & " where concepto='Registro Civil' and fecha='" & Fecha.Date.ToString("yyyy-MM-dd") & "' limit 1"
                        EjecutaConsulta()
                        'sumar el nuevo importe modificado
                        'SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " where concepto='Registro Civil' and fecha='" & Me.FechaLbl.Text.ToString("yyyy/MM/dd") & "' limit 1"
                        'EjecutaConsulta()

                    Case "Tortilleria"
                        SQL = "UPDATE tortilleria SET importe=" & Me.ImporteTxt.Text & " WHERE nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                        EjecutaConsulta()
                        'RESTAR EL MPORTE ANTERIO A LOS INGRESOS
                        SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " - " & Importe & " where concepto='Tortilleria' and fecha='" & Fecha.Date.ToString("yyyy-MM-dd") & "' limit 1"
                        EjecutaConsulta()
                        'sumar el nuevo importe modificado
                        'SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " where concepto='Tortilleria' and fecha='" & Me.FechaLbl.Text.ToString("yyyy/MM/dd") & "' limit 1"
                        'EjecutaConsulta()

                    Case "Otros Ingresos"
                        SQL = "UPDATE otrosing SET importe=" & Me.ImporteTxt.Text & " WHERE nofactura=" & Me.NoFacturaTxt.Text & " limit 1"
                        EjecutaConsulta()
                        'RESTAR EL MPORTE ANTERIO A LOS INGRESOS
                        SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " - " & Importe & " where concepto='Otros Ingresos' and fecha='" & Fecha.Date.ToString("yyyy-MM-dd") & "' limit 1"
                        EjecutaConsulta()
                        'sumar el nuevo importe modificado
                        'SQL = "UPDATE ingpropios SET ingreso= ingreso + " & Me.ImporteTxt.Text & " where concepto='Otros Ingresos' and fecha='" & Me.FechaLbl.Text.ToString("yyyy/MM/dd") & "' limit 1"
                        'EjecutaConsulta()
                End Select
                SQL = "UPDATE ingpropiosres set ingresos= ingresos + " & Me.ImporteTxt.Text & " - " & Importe & ", encaja= encaja + " & Me.ImporteTxt.Text & " - " & Importe & " limit 1"
                EjecutaConsulta()
                MessageBox.Show("La factura ha sido acualizada", "Actualizar factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Otra()
            Catch Ex As MySqlException
                MessageBox.Show(Ex.Message, "Error: " & Ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Sub EjecutaConsulta()
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMCmd.ExecuteNonQuery()
    End Sub

    Private Sub OtraBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtraBtn.Click
        'limpiar los datos de la factura y habilitar nueva busqueda
        Otra()
    End Sub
    Sub Otra()
        Importe = 0
        Me.NoFacturaTxt.Text = ""
        Me.IngresoDeCmb.SelectedValue = ""
        Me.IngresoDeCmb.SelectedItem = Nothing
        Me.IngresoDeCmb.Text = ""
        Me.NombreTxt.Text = ""
        Me.ConceptoTxt.Text = ""
        Me.ObservacionesTxt.Text = ""
        Me.ImporteTxt.Text = ""
        Me.CambiarBtn.Enabled = False
        Me.DatosFactGpb.Enabled = False
        Me.LocalizarFactGpb.Enabled = True
        Me.NoFacturaTxt.Focus()
    End Sub

    Private Sub ObservacionesTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ObservacionesTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            Me.ImporteTxt.Focus()
        End If
    End Sub
End Class