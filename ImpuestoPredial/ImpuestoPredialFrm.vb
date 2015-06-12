Imports System.Collections
Imports MySql.Data.MySqlClient
Public Class ImpuestoPredialFrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    Dim Mostrados As String
    Public Cobrado As Boolean
    Private Sub ImpuestoPredialFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
        CargarPrediosFrm.Dispose()
    End Sub

    Private Sub ImpuestoPredialFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConectaServer()
        CargarConfig()
        Me.Text += "  " & Ayuntamiento
        'cargar los años de los que se encuentra la info almacenada
        'Me.PagDelAnoCmb.Items.Clear()
        Dim i, DatAno As Short
        DatAno = Now.Year - DatosAno
        For i = 0 To DatAno
            Me.PagDelAnoCmb.Items.Add(DatosAno + i)
        Next
        CargarUbicaciones()
    End Sub

    Private Sub NuevoInmueble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoInmueble.Click
        Try
            DatosInmueblefrm.Comando = "Nuevo"
            DatosInmueblefrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub
    Sub CargarUbicaciones()
        SQL = "SELECT nombre from ubicrusticos"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        While DatosMDR.Read
            Me.UbicacionCmb.Items.Add(DatosMDR!nombre.ToString)
        End While
        DatosMDR.Close()
    End Sub
    Sub CalculaTotal()
        If Me.DatosDtg.Rows.Count > 0 Then
            Dim i As Short
            Dim AdeudoTot As Double
            AdeudoTot = 0
            For i = 0 To Me.DatosDtg.Rows.Count - 1
                AdeudoTot += Me.DatosDtg.Item(8, i).Value
            Next
            Me.IngresoTotalLbl.Text = Format(CStr(AdeudoTot), "Currency")
        End If
    End Sub
    Public Sub CargarPredios()
        'Me.IngresoTotalLbl.Text = ""
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "inmuebles")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "inmuebles"
        'Dim c As Short
        Me.TotalImnLbl.Text = Me.DatosDtg.Rows.Count
        Me.TotalConcepLbl.Text = "Total inmuebles:"
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        'For c = 0 To Me.DatosDtg.Rows.Count - 1
        ' Me.IngresoTotalLbl.Text = Val(Me.IngresoTotalLbl.Text) + Val(Me.DatosDtg.Item(8, c).Value.ToString)
        ' Next
        Me.ImprimirBrn.Enabled = False
        Me.CobrarBtn.Enabled = True
        Me.IngresoTotalLbl.Visible = True
        Me.TotIngresoTitLbl.Visible = True
        Me.TotIngresoTitLbl.Text = "Adeudo total:"
        Mostrados = "Inmuebles"
        'SQLCnn.Close()
    End Sub

    Private Sub TodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodosBtn.Click
        SQL = "SELECT * FROM inmuebles"
        Me.TituloLbl.Text = "TODOS LOS INMUEBLES REGISTRADOS"
        CargarPredios()
        CalculaTotal()
    End Sub

    Private Sub PorTipoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorTipoCmb.SelectedIndexChanged
        Me.PorTipoCmb.Text = Me.PorTipoCmb.SelectedItem
        SQL = "SELECT * FROM inmuebles where tipo='" & Me.PorTipoCmb.Text & "'"
        Me.TituloLbl.Text = "TODOS LOS INMUEBLES TE TIPO " & Me.PorTipoCmb.Text.ToUpper
        CargarPredios()
        CalculaTotal()
    End Sub

    Private Sub UbicacionCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbicacionCmb.SelectedIndexChanged
        Me.UbicacionCmb.Text = Me.UbicacionCmb.SelectedItem
        SQL = "SELECT * FROM inmuebles where ubicacion='" & Me.UbicacionCmb.Text & "'"
        Me.TituloLbl.Text = "TODOS LOS INMUEBLES UBICADOS EN " & Me.UbicacionCmb.Text.ToUpper
        CargarPredios()
        CalculaTotal()
    End Sub

    Private Sub CobrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobrarBtn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            Dim AnoPagado As Short
            AnoPagado = Val(Me.DatosDtg.Item(6, Me.DatosDtg.CurrentRow.Index).Value.ToString)
            If AnoPagado = Now.Year Then
                If MessageBox.Show("El inmueble No. " & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " no tiene adeudos" & Chr(13) & "¿Desea abrir el último pago realizado?", "Impuesto predial", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    'aqui abre el ultimo pago
                    CobrarFrm.IdInmueble = Val(Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
                    CobrarFrm.Comando = "Abrir"
                    CobrarFrm.ShowDialog()
                Else
                    Exit Sub
                End If
            Else
                'aqui abre el formulario de cobro
                CobrarFrm.IdInmueble = Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value
                CobrarFrm.Comando = "Nuevo"
                CobrarFrm.ShowDialog()
                If Cobrado = True Then
                    Me.DatosDtg.DataSource = Nothing
                    Me.DatosDtg.Rows.Clear()
                End If
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PorTipoCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PorTipoCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub UbicacionCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UbicacionCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BusInmuBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusInmuBtn.Click
        BuscarFrm.Buscar = "propietario"
        BuscarFrm.ShowDialog()
        BuscarFrm.BuscarTxt.Focus()
        CalculaTotal()
    End Sub

    Private Sub PorCuentaBtni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorCuentaBtni.Click
        BuscarFrm.Buscar = "cuenta"
        BuscarFrm.ShowDialog()
        BuscarFrm.BuscarTxt.Focus()
        CalculaTotal()
    End Sub

    Private Sub DatosDtg_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosDtg.CellDoubleClick
        If Mostrados = "Inmuebles" Then
            DatosInmueblefrm.IdInmueble = DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value
            DatosInmueblefrm.Comando = "Abrir"
            DatosInmueblefrm.ShowDialog()
        End If
    End Sub
    Public Sub CargarPagos()
        'Me.IngresoTotalLbl.Text = ""
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "cobropredios")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "cobropredios"
        'Dim c As Short
        Me.TotalImnLbl.Text = Me.DatosDtg.Rows.Count
        Me.TotalConcepLbl.Text = "Total de Pagos:"
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        Me.IngresoTotalLbl.Visible = True
        Me.TotIngresoTitLbl.Visible = True
        Me.TotIngresoTitLbl.Text = "Ingreso Total:"
        Dim TotalIng As Double

        For c = 0 To Me.DatosDtg.Rows.Count - 1
            TotalIng += +Val(Me.DatosDtg.Item(9, c).Value.ToString)
        Next
        Me.IngresoTotalLbl.Text = Format(CStr(TotalIng), "Currency")
        Me.ImprimirBrn.Enabled = True
        Me.CobrarBtn.Enabled = False

        Mostrados = "Pagos"
        'SQLCnn.Close()
    End Sub
    Private Sub PagosTodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosTodosBtn.Click
        SQL = "SELECT * FROM cobropredios"
        Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL REGISTRADOS"
        CargarPagos()
    End Sub

    Private Sub PagoMesesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagoMesesCmb.SelectedIndexChanged
        Me.PagoMesesCmb.Text = Me.PagoMesesCmb.SelectedItem
        'sSQL = "Select * from SolicExtractostbl where Fecha_Entregado Between #" & Mes & "/01/" & Now.Year & "# And #" & Mes & "/" & Dias & "/" & Now.Year & "# and Estado='Entregado'"
        If Me.PagoMesesCmb.Text <> "" Then
            If Me.PagoMesesCmb.Text = "Todos" Then
                SQL = "SELECT * FROM cobropredios where fecha like '%" & Now.Year & "%'"
                CargarPagos()
                Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL REALIZADOS EN EL AÑO " & Now.Year
            Else
                ObtenNMes(Me.PagoMesesCmb.Text)
                Dim DiasMes As String

                DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
                SQL = "SELECT * FROM cobropredios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
                CargarPagos()
                Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL REALIZADOS EN EL MES DE " & Me.PagoMesesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
            End If

            'CARGAR TOTALES

        End If
    End Sub
    Private Sub FiltroMesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltroMesCmb.SelectedIndexChanged
        If Me.PagoMesesCmb.Text = "" Or Me.PagoMesesCmb.Text = "Todos" Then
            MessageBox.Show("Seleccione un mes", "Impuesto Predial", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ObtenNMes(Me.PagoMesesCmb.Text)
            Dim DiasMes As String
            DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
            'SQL = "SELECT * FROM cobropredios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
            Select Case Me.FiltroMesCmb.Text
                Case "R"
                    SQL = "SELECT * FROM cobropredios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and tipo='Rustico' order by fecha asc"
                    Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL (RUSTICOS) REALIZADOS EN EL MES DE " & Me.PagoMesesCmb.Text
                Case "U"
                    SQL = "SELECT * FROM cobropredios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and tipo='Urbano' order by fecha asc"
                    'SQL = "SELECT * FROM cobropredios where fecha like '%" & Now.Year & "%' and tipo='Urbano'"
                    Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL (URBANOS) REALIZADOS EN EL MES DE " & Me.PagoMesesCmb.Text

                Case "Todos"
                    SQL = "SELECT * FROM cobropredios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
                    Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL REALIZADOS EN EL MES DE " & Me.PagoMesesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
            End Select
            CargarPagos()
        End If
    End Sub

    Private Sub PagosDiaDtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosDiaDtp.ValueChanged
        SQL = "SELECT * FROM cobropredios where fecha ='" & Me.PagosDiaDtp.Value.Year & "-" & Me.PagosDiaDtp.Value.Month & "-" & Me.PagosDiaDtp.Value.Day & "' order by id_cobro asc"
        CargarPagos()
        Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL REALIZADOS EL DIA " & Me.PagosDiaDtp.Value.ToLongDateString.ToUpper
    End Sub

    Private Sub PagDelAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagDelAnoCmb.SelectedIndexChanged
        SQL = "SELECT * FROM cobropredios where fecha like '%" & Me.PagDelAnoCmb.Text & "%' order by fecha asc"
        Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL REALIZADOS EN EL AÑO " & Me.PagDelAnoCmb.Text
        CargarPagos()
    End Sub
    Private Sub FiltroAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltroAnoCmb.SelectedIndexChanged
        If Me.PagDelAnoCmb.Text = "" Then
            MessageBox.Show("Seleccione un año", "Impuesto Predial", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case Me.FiltroAnoCmb.Text
                Case "R"
                    SQL = "SELECT * FROM cobropredios where fecha like '%" & Me.PagDelAnoCmb.Text & "%' and tipo='Rustico' order by fecha asc"
                    Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL (RUSTICOS) REALIZADOS EN EL AÑO DE " & Me.PagDelAnoCmb.Text.ToUpper

                Case "U"
                    'Rustico
                    'Urbano
                    SQL = "SELECT * FROM cobropredios where fecha like '%" & Me.PagDelAnoCmb.Text & "%' and tipo='Urbano' order by fecha asc"
                    Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL (URBANOS) REALIZADOS EN EL AÑO DE " & Me.PagDelAnoCmb.Text.ToUpper
                Case "Todos"
                    SQL = "SELECT * FROM cobropredios where fecha like '%" & Me.PagDelAnoCmb.Text & "%' order by fecha asc"
                    Me.TituloLbl.Text = "TODOS LOS PAGOS DE IMPUESTO PREDIAL REALIZADOS EN EL AÑO " & Me.PagDelAnoCmb.Text
            End Select
            CargarPagos()
        End If
    End Sub

    Private Sub ImprimirBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBrn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            ReporteFrm.Datos.Clear()
            Dim i As Integer
            For i = 0 To Me.DatosDtg.Rows.Count - 1
                ReporteFrm.Datos.Add(New DatosPrediosCls(Me.DatosDtg.Item(1, i).Value, Me.DatosDtg.Item(2, i).Value, Me.DatosDtg.Item(3, i).Value, Me.DatosDtg.Item(5, i).Value.ToString, Me.DatosDtg.Item(6, i).Value.ToString, Me.DatosDtg.Item(7, i).Value.ToString, Me.DatosDtg.Item(8, i).Value.ToString, Mid(Me.DatosDtg.Item(9, i).Value.ToString, 1, 10)))
            Next
            ReporteFrm.Show()
        Else
            MessageBox.Show("No se encontro nada que imprimir", "Impuesto Predial", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ConfiguraNotifBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraNotifBtn.Click
        ConfigNotificFrm.ShowDialog()
    End Sub

    Private Sub EliminarInmBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarInmBtn.Click
        If Me.DatosDtg.Rows.Count > 0 And Mostrados = "Inmuebles" Then
            If MessageBox.Show("¿Confirma eliminar los datos del inmueble No. " & Val(Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString) & "?", "Impuesto predial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim InmuebleN As Integer
                InmuebleN = Val(Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)

                SQL = "DELETE FROM impuestospred where id_inmueble=" & InmuebleN & " limit 1"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()

                SQL = "DELETE FROM inmuebles where id_inmueble=" & InmuebleN & " limit 1"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()
                MessageBox.Show("El inmueble No. " & InmuebleN & ", fue eliminado", "Impuesto predial", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DatosDtg.DataSource = Nothing
                Me.DatosDtg.Rows.Clear()
            End If
        End If
    End Sub

    Private Sub OtroCobroBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtroCobroBtn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            OtroCobrofrm.cuenta = Val(Me.DatosDtg.Item(1, Me.DatosDtg.CurrentRow.Index).Value.ToString)
            OtroCobrofrm.ShowDialog()
        End If
    End Sub
End Class