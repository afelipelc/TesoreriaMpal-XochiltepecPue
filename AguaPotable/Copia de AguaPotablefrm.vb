Imports System
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.Collections

Public Class AguaPotablefrm
    Public Mostrados As String
    'Public SQL As String
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    Dim DetaTarMDR As MySqlDataReader
    Dim DetaTarMCMD As MySqlCommand
    Dim Adeudo As Decimal
    Public Cobrado As Boolean
    Private Sub ConfigBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigBtn.Click
        Tarifasfrm.ShowDialog()
    End Sub

    Private Sub AguaPotablefrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ConectaServer()
        'cargar datos del ayutnamiento
        'cargar localidades y calles
        Me.LocalidadesCmb.Items.Clear()
        Me.CallesCmb.Items.Clear()
        ConectaServer()
        CargarLocalidades()
        CargarConfig()
        'SQLCnn.Close()
        Me.Text += Ayuntamiento
        Me.Titulolbl.Text = "TOMAS DE AGUA POTABLE DEL MUNICIPIO DE " & Ayuntamiento.ToUpper

        'cargar los años de los que se encuentra la info almacenada
        Me.PagDelAnoCmb.Items.Clear()
        Dim i, DatAno As Short
        DatAno = Now.Year - DatosAno
        For i = 0 To DatAno
            Me.PagDelAnoCmb.Items.Add(DatosAno + i)
        Next

    End Sub
    Sub CargarLocalidades()
        SQL = "SELECT * from localidades"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        While DatosMDR.Read
            Me.LocalidadesCmb.Items.Add(DatosMDR!nombre)
        End While
        Me.LocalidadesCmb.Items.Add("Todas")
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub
    Sub CargarCalles(ByVal Localidad As String)
        SQL = "SELECT nombre from calles where localidad='" & Localidad & "'"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        While DatosMDR.Read
            Me.CallesCmb.Items.Add(DatosMDR!nombre)
        End While
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub
    Sub CalculaTotal()
        If Me.DatosDtg.Rows.Count > 0 Then
            Dim i As Short
            Dim AdeudoTot As Double
            AdeudoTot = 0
            For i = 0 To Me.DatosDtg.Rows.Count - 1
                If Me.DatosDtg.Columns.Count > 11 Then
                    AdeudoTot += Me.DatosDtg.Item(11, i).Value
                Else
                    AdeudoTot += Me.DatosDtg.Item(9, i).Value
                End If
            Next
            Me.TotalPagosLbl.Text = Format(CStr(AdeudoTot), "Currency")
        End If
    End Sub

    Private Sub EstadoTsp_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles EstadoTsp.Opening
        If Me.DatosDtg.Rows.Count > 0 Then
            EstadoTsp.Enabled = True
            Select Case Mostrados
                Case "Activas"
                    Me.EstadoTsp.Items(0).Enabled = False
                    Me.EstadoTsp.Items(1).Enabled = True
                    Me.EstadoTsp.Items(2).Enabled = True

                Case "Canceladas"
                    Me.EstadoTsp.Items(0).Enabled = True
                    Me.EstadoTsp.Items(1).Enabled = False
                    Me.EstadoTsp.Items(2).Enabled = False

                Case "Suspendidas"
                    Me.EstadoTsp.Items(0).Enabled = True
                    Me.EstadoTsp.Items(1).Enabled = False
                    Me.EstadoTsp.Items(2).Enabled = True
                Case "CancelSusp"
                    Me.EstadoTsp.Items(0).Enabled = True
                    Me.EstadoTsp.Items(1).Enabled = False
                    Me.EstadoTsp.Items(2).Enabled = False

                Case "Buscar"
                    Me.EstadoTsp.Items(0).Enabled = False
                    Me.EstadoTsp.Items(1).Enabled = True
                    Me.EstadoTsp.Items(2).Enabled = True
                Case ""
                    EstadoTsp.Enabled = False
                Case "Todas"
                    EstadoTsp.Enabled = False
                Case "Pagos"
                    EstadoTsp.Enabled = False
            End Select
        Else
            EstadoTsp.Enabled = False
        End If
    End Sub

    Private Sub TodasBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodasBtn.Click
        Mostrados = "Todas"
        Me.Titulolbl.Text = "Todas las tomas de agua registradas, incluyendo canceladas y suspendidas"
        SQL = "SELECT * FROM aguapotable order by id_tarifa,id_toma asc"
        'ConectaServer()
        CargarDatos()
        If Me.DatosDtg.Rows.Count > 0 Then
            'ConectaServer()
            CargarAdeudos()
            'SQLCnn.Close()
            CalculaTotal()
        End If
        'SQLCnn.Close()

    End Sub

    Private Sub NContribBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NContribBtn.Click
        NuevaTomafrm.Comando = "Nueva"
        NuevaTomafrm.ShowDialog()
        'ConectaServer()
    End Sub

    Private Sub BuscarTomaBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarTomaBtn.Click
        BuscarTomafrm.BuscarEn = "nombre"
        BuscarTomafrm.ShowDialog()
        BuscarTomafrm.BuscaBombreTxt.Focus()
        If Me.DatosDtg.Rows.Count > 0 Then
            'ConectaServer()
            CargarAdeudos()
            'SQLCnn.Close()
            CalculaTotal()
        End If
    End Sub

    Private Sub PorNombreBtni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorNumBtni.Click
        BuscarTomafrm.BuscarEn = "id_toma"

        BuscarTomafrm.ShowDialog()
        If Me.DatosDtg.Rows.Count > 0 Then
            'ConectaServer()
            CargarAdeudos()
            'SQLCnn.Close()
            CalculaTotal()
        End If
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        SQLCnn.Close()
        Me.Close()
        'CargarAguafrm.Close()
    End Sub

    Private Sub AguaPotablefrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
        CargarAguafrm.Dispose()
    End Sub
    Public Sub CargarDatos()
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "aguapotable")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "aguapotable"
        'Dim c As Short
        Me.TotalTomaslbl.Text = Me.DatosDtg.Rows.Count
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        Me.DescripcionLbl.Text = "Total de Tomas: "
        Me.TituloTotalLbl.Visible = True
        Me.TotalPagosLbl.Visible = True
        Me.TituloTotalLbl.Text = "Adeudo Total:"
        Me.ImprimirBrn.Enabled = False
        Me.CobrarBtn.Enabled = True
        Me.AdelantadoBtni.Enabled = True
        'SQLCnn.Close()
    End Sub
    Private Sub CancelSuspBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSuspBtn.Click
        Mostrados = "CancelSusp"
        SQL = "SELECT * FROM aguapotable where estado='Suspendida' or estado='Cancelada'"
        'ConectaServer()
        CargarDatos()
        'If Me.DatosDtg.Rows.Count > 0 Then
        'ConectaServer()
        'CargarAdeudos()
        'SQLCnn.Close()
        'End If
        CalculaTotal()
        Me.Titulolbl.Text = "Todas las tomas Canceladas y Suspendidas"
    End Sub

    Private Sub CanceladasBtni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanceladasBtni.Click
        Mostrados = "Canceladas"
        SQL = "SELECT * FROM aguapotable where estado='Cancelada'"
        'ConectaServer()
        CargarDatos()
        'If Me.DatosDtg.Rows.Count > 0 Then
        'ConectaServer()
        'CargarAdeudos()
        'SQLCnn.Close()
        'End If
        CalculaTotal()
        Me.Titulolbl.Text = "Todas las tomas Canceladas"
    End Sub

    Private Sub SuspendidasBtni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspendidasBtni.Click
        Mostrados = "Suspendidas"
        SQL = "SELECT * FROM aguapotable where estado='Suspendida'"
        'ConectaServer()
        CargarDatos()
        'If Me.DatosDtg.Rows.Count > 0 Then
        'ConectaServer()
        'CargarAdeudos()
        'SQLCnn.Close()
        'End If
        CalculaTotal()
        Me.Titulolbl.Text = "Todas las tomas Suspendidas"
    End Sub

    Private Sub TActivasBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TActivasBtn.Click
        Mostrados = "Activas"
        SQL = "SELECT id_toma, tomas, id_tarifa as tarifa, nombre, localidad, calle, numero, ultimopago, pagohasta, adeudo, observaciones FROM aguapotable where estado='Activa' order by id_tarifa,id_toma asc"
        'SQL = "SELECT * FROM aguapotable where estado='Activa' order by id_tarifa,id_toma asc"
        'ConectaServer()
        CargarDatos()
        If Me.DatosDtg.Rows.Count > 0 Then
            'ConectaServer()
            CargarAdeudos()
            'SQLCnn.Close()
            CalculaTotal()
        End If
        Me.Titulolbl.Text = "Todas las tomas Activas"
    End Sub

    Sub CargarAdeudos()
        Try
            SQL = "SELECT id_tarifa from tarifasagua order by id_tarifa asc"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            Dim Tarifas(0)
            Dim Tarifa, nTarifas As Short

            While DatosMDR.Read
                nTarifas += 1
                ReDim Preserve Tarifas(nTarifas)
                Tarifas(nTarifas) = DatosMDR!id_tarifa
            End While
            DatosMDR.Close()
            Dim i As Short
            For i = 1 To nTarifas
                Dim Paso As Boolean
                Tarifa = Tarifas(i)
                SQL = "SELECT costo, apar_mes, apar_ano from detarifagua where id_tarifa=" & Tarifa & " order by apar_ano desc"
                DetaTarMCMD = New MySqlCommand
                DetaTarMCMD.CommandText = SQL
                DetaTarMCMD.Connection = SQLCnn
                DetaTarMDR = DetaTarMCMD.ExecuteReader
                'cargar los detalles a la memoria
                Dim costo(0), apar_ano(0), apar_mes(0) As Short
                Dim Detalles As Short
                While DetaTarMDR.Read
                    Detalles += 1
                    ReDim Preserve costo(Detalles)
                    ReDim Preserve apar_mes(Detalles)
                    ReDim Preserve apar_ano(Detalles)
                    costo(Detalles) = DetaTarMDR!costo
                    apar_mes(Detalles) = DetaTarMDR!apar_mes
                    apar_ano(Detalles) = DetaTarMDR!apar_ano
                End While
                DetaTarMDR.Close()

                'recorrer la lista de tomas de agua
                Dim r, d As Short
                Dim PInicio, PFin As String
                For r = 0 To Me.DatosDtg.Rows.Count - 1
                    'comprobar si el estado es cancelado o suspendida, para no calcular el adeudo
                    If Mostrados = "Todas" Or Mostrados = "Canceladas" Or Mostrados = "Suspendidas" Or Mostrados = "CancelSusp" Or Mostrados = "Buscar" Then
                        'aqui el fin del periodo de pago se obtiene hasta el mes que se cancelo
                        If Me.DatosDtg.Item(9, r).Value = "Cancelada" Or Me.DatosDtg.Item(9, r).Value = "Suspendida" Or Me.DatosDtg.Item(9, r).Value = "CancelSusp" Then
                            GoTo Siguiente
                        End If
                    End If


                    'obtener el mes y año pagado
                    Dim PMes, PAno As Short
                    If Val(Me.DatosDtg.Item(2, r).Value.ToString) = Tarifa Then
                        'variables que almacenan el mes y año que esta pagado
                        Dim PagoDec As Boolean
                        PMes = 0
                        PAno = 0
                        PMes = Val(Mid(Me.DatosDtg.Item(8, r).Value.ToString, 1, 2))
                        PAno = Val(Mid(Me.DatosDtg.Item(8, r).Value.ToString, 4, 4))
                        'If PMes = 0 Then
                        ' PMes = 12
                        ' PAno -= 1
                        'End If
                        If PMes = 12 Then
                            PagoDec = True
                        End If
                        'verificar si es igual o mayor que la fecha actual "pago al corriente o adelantado"
                        If PAno >= Now.Year And PMes >= Now.Month Then
                            Paso = True
                            GoTo Siguiente
                        End If

                        If PAno <= Now.Year Then
                            'Dim reverse As Short
                            'reverse = Detalles + 1
                            Dim CostoTar As Short

                            Paso = False
                            For d = 1 To Detalles 'recorrer los detalles
                                '   reverse += 1
                                'obtener el inicio del periodo
                                If Paso = False Then
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
                                            'tomar el rango de ese periodo
                                            If apar_mes(d - 1) = 1 Then ' se la tarifa de este año comienza a partir de enero
                                                If apar_mes(d - 1) = 1 Then
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
                                            'si la toma esta cancelada o suspendida
                                            'calcular el adeudo que tiene
                                            If Mostrados = "Todas" Or Mostrados = "Canceladas" Or Mostrados = "Suspendidas" Or Mostrados = "CancelSusp" Then
                                                'aqui el fin del periodo de pago se obtiene hasta el mes que se cancelo
                                                If Me.DatosDtg.Item(9, r).Value = "Cancelada" Or Me.DatosDtg.Item(9, r).Value = "Suspendida" Or Me.DatosDtg.Item(9, r).Value = "CancelSusp" Then
                                                    PMes = Val(Mid(Me.DatosDtg.Item(10, r).Value.ToString, 4, 2))
                                                    PAno = Val(Mid(Me.DatosDtg.Item(10, r).Value.ToString, 7, 4))
                                                    If PMes < 10 Then
                                                        PFin = PAno & "0" & PMes
                                                    Else
                                                        PFin = PAno & PMes
                                                    End If
                                                Else
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

                                                End If
                                            Else
                                                PAno = Now.Year
                                                If Now.Day >= DiaCobroMes Then
                                                    PMes = Now.Month
                                                Else
                                                    'aqui genera un error si el mes es enero
                                                    PMes = Now.Month - 1
                                                    'debe restaurarse para que cambie a un año anterior
                                                    
                                                End If
                                                If PMes < 10 Then
                                                    PFin = PAno & "0" & PMes
                                                Else
                                                    PFin = PAno & PMes
                                                End If
                                                Paso = True
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
                                            Dim MesesTo As Short
                                            MesesTo = DatosMDR!meses
                                            Total = MesesTo * CostoTar
                                            If Mostrados = "Todas" Or Mostrados = "Canceladas" Or Mostrados = "Suspendidas" Or Mostrados = "CancelSusp" Or Mostrados = "Buscar" Then
                                                Me.DatosDtg.Item(11, r).Value = Val(Me.DatosDtg.Item(11, r).Value.ToString) + (Total * Val(Me.DatosDtg.Item(1, r).Value.ToString))
                                            Else
                                                Me.DatosDtg.Item(9, r).Value = Val(Me.DatosDtg.Item(9, r).Value.ToString) + (Total * Val(Me.DatosDtg.Item(1, r).Value.ToString))
                                            End If
                                        End If
                                        DatosMDR.Close()
                                        'Me.DatosDtg.Item(9, r).Value = Val(Me.DatosDtg.Item(9, r).Value.ToString) + (((Val(PFin) - Val(PInicio)) * costo(Detalles)) * Val(Me.DatosDtg.Item(1, r).Value.ToString))
                                    End If
                                End If
                                'comprobar si esxiste otra tarifa
                                'next
                            Next
                        End If
                    Else
                        Exit For
                    End If
Siguiente:
                Next

            Next
            DatosMDR.Close()

        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
        End Try
    End Sub

    Private Sub DatosDtg_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosDtg.CellDoubleClick
        'si con tomas canceladas o suspendidad, no puede modificar los datos
        If Mostrados = "CancelSusp" Or Mostrados = "Canceladas" Or Mostrados = "Suspendidas" Then
            MessageBox.Show("No se pueden modificar los datos de la toma porque esta esta suspendida o cancelada", "Tomas de agua portable", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Mostrados = "Todas" Then
            If Me.DatosDtg.Item(9, DatosDtg.CurrentRow.Index).Value.ToString = "Suspendida" Or Me.DatosDtg.Item(9, DatosDtg.CurrentRow.Index).Value.ToString = "Cancelada" Then
                MessageBox.Show("No se pueden modificar los datos de la toma porque esta esta suspendida o cancelada", "Tomas de agua portable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        NuevaTomafrm.Indice = DatosDtg.CurrentRow.Index
        NuevaTomafrm.NoToma = Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value
        NuevaTomafrm.Comando = "Editar"
        NuevaTomafrm.ShowDialog()
    End Sub

    Private Sub LocalidadesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadesCmb.SelectedIndexChanged
        If Me.LocalidadesCmb.Text <> "Todas" Then
            SQL = "SELECT id_toma, tomas, id_tarifa as tarifa, nombre, localidad, calle, numero, ultimopago, pagohasta, adeudo, observaciones FROM aguapotable where estado='Activa' and localidad='" & Me.LocalidadesCmb.Text & "' order by id_tarifa,id_toma asc"
            'ConectaServer()
            CargarDatos()
            Me.CallesCmb.Enabled = True
            Me.CallesCmb.Items.Clear()
            'ConectaServer()
            Me.CargarCalles(Me.LocalidadesCmb.Text)
            'SQLCnn.Close()
        Else
            SQL = "SELECT id_toma, tomas, id_tarifa as tarifa, nombre, localidad, calle, numero, ultimopago, pagohasta, adeudo, observaciones FROM aguapotable where estado='Activa' order by id_tarifa,id_toma asc"
            'ConectaServer()
            CargarDatos()
            Me.CallesCmb.Enabled = False
        End If
        Mostrados = "Activas"
        
        If Me.DatosDtg.Rows.Count > 0 Then
            'ConectaServer()
            CargarAdeudos()
            'SQLCnn.Close()
            CalculaTotal()
        End If
        Me.Titulolbl.Text = "Todas las tomas Activas de la licalidad: " & Me.LocalidadesCmb.Text
    End Sub

    Private Sub CallesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CallesCmb.SelectedIndexChanged
        SQL = "SELECT id_toma, tomas, id_tarifa as tarifa, nombre, localidad, calle, numero, ultimopago, pagohasta, adeudo, observaciones FROM aguapotable where estado='Activa' and localidad='" & Me.LocalidadesCmb.Text & "' and calle='" & Me.CallesCmb.Text & "' order by id_tarifa,id_toma asc"
        Mostrados = "Activas"
        'ConectaServer()
        CargarDatos()
        If Me.DatosDtg.Rows.Count > 0 Then
            'ConectaServer()
            CargarAdeudos()
            'SQLCnn.Close()
            CalculaTotal()
        End If
        Me.Titulolbl.Text = "Todas las tomas Activas de la calle: " & Me.CallesCmb.Text & ", de la localidad de: " & Me.CallesCmb.Text
    End Sub

    Private Sub CobrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobrarBtn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            Dim MesPag, AnoPag As Short

            MesPag = Mid(Me.DatosDtg.Item(8, DatosDtg.CurrentRow.Index).Value.ToString, 1, 2)
            AnoPag = Mid(Me.DatosDtg.Item(8, DatosDtg.CurrentRow.Index).Value.ToString, 4, 4)
            'aqui deberia obtener el adeudo de la toma, desde la columna adeudo
            ObtenAdeudoToma()
            'If Me.DatosDtg.Item(11, DatosDtg.CurrentRow.Index).Value = 0 Then
            If Adeudo = 0 Then
                'si el adeudo esta en 0 y el mes y ano pagado es igual al actual
                If AnoPag = Now.Year And MesPag = Now.Month Then
                    If MessageBox.Show("La toma numero: " & Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString & ", No presenta adeudos" & Chr(13) & "¿Desea abrir el último pago realizado de esta toma?", "Agua Potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        CobrarAguafrm.IdToma = Val(Me.DatosDtg(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
                        CobrarAguafrm.AnoPagado = AnoPag
                        CobrarAguafrm.Comando = "Abrir"
                        CobrarAguafrm.Otrocom = ""
                        CobrarAguafrm.ShowDialog()
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If

                'comparar con el dia actual del mes y el dia a partir del que se empieza a cobrar
                If Now.Day >= DiaCobroMes Then
                    CobrarAguafrm.IdToma = Val(Me.DatosDtg(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
                    CobrarAguafrm.Comando = "Nuevo"
                    CobrarAguafrm.Otrocom = ""
                    CobrarAguafrm.ShowDialog()
                    'SQLCnn.Close()
                    If Cobrado = True Then
                        Me.DatosDtg.DataSource = Nothing
                        Me.DatosDtg.Rows.Clear()
                    End If
                    Exit Sub
                Else
                    If MessageBox.Show("La toma numero: " & Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString & ", No presenta adeudos" & Chr(13) & "¿Desea abrir el último pago realizado de esta toma?", "Agua Potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        CobrarAguafrm.IdToma = Val(Me.DatosDtg(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
                        CobrarAguafrm.AnoPagado = AnoPag
                        CobrarAguafrm.Comando = "Abrir"
                        CobrarAguafrm.Otrocom = ""
                        CobrarAguafrm.ShowDialog()
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            End If
            If AnoPag >= Now.Year And MesPag >= Now.Month Then
                If MessageBox.Show("La toma numero: " & Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString & ", No presenta adeudos" & Chr(13) & "¿Desea abrir el último pago realizado de esta toma?", "Agua Potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    CobrarAguafrm.IdToma = Val(Me.DatosDtg(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
                    CobrarAguafrm.AnoPagado = AnoPag
                    CobrarAguafrm.Comando = "Abrir"
                    CobrarAguafrm.Otrocom = ""
                    CobrarAguafrm.ShowDialog()
                    Exit Sub
                Else
                    Exit Sub
                End If
            Else
                CobrarAguafrm.IdToma = Val(Me.DatosDtg(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
                CobrarAguafrm.Comando = "Nuevo"
                CobrarAguafrm.Otrocom = ""
                CobrarAguafrm.ShowDialog()
                'SQLCnn.Close()
                If Cobrado = True Then
                    Me.DatosDtg.DataSource = Nothing
                    Me.DatosDtg.Rows.Clear()
                End If
                Exit Sub
            End If

        Else
            MessageBox.Show("No se encuentra ninguna toma en la lista", "Seleccionar toma", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AdelantadoBtni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdelantadoBtni.Click
        If Me.DatosDtg.Rows.Count > 0 And Val(Me.DatosDtg(11, Me.DatosDtg.CurrentRow.Index).Value.ToString) <= 0 Then
            CobrarAguafrm.IdToma = Val(Me.DatosDtg(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
            CobrarAguafrm.Comando = "Nuevo" 'para que no carge el formulario
            CobrarAguafrm.Otrocom = "Adelantado"
            CobrarAguafrm.ShowDialog()
            'SQLCnn.Close()
            If Cobrado = True Then
                Me.DatosDtg.DataSource = Nothing
                Me.DatosDtg.Rows.Clear()
            End If
            Exit Sub
        Else
            MessageBox.Show("No se puede cobrar, es posible que tenga adeudo" & Chr(13) & "Consulte la toma y vuelva a intentarlo o realize el cobro normal", "Agua potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub PagoMesesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagoMesesCmb.SelectedIndexChanged
        Me.PagoMesesCmb.Text = Me.PagoMesesCmb.SelectedItem
        'sSQL = "Select * from SolicExtractostbl where Fecha_Entregado Between #" & Mes & "/01/" & Now.Year & "# And #" & Mes & "/" & Dias & "/" & Now.Year & "# and Estado='Entregado'"
        If Me.PagoMesesCmb.Text <> "" Then
            Mostrados = "Pagos"

            If Me.PagoMesesCmb.Text = "Todos" Then
                SQL = "SELECT * FROM cobroagua where fechapago like '%" & Now.Year & "%'"
                CargarPagos()
                Me.Titulolbl.Text = "TODOS LOS PAGOS DE AGUA POTABLE REALIZADOS EN EL AÑO " & Now.Year
            Else
                ObtenNMes(Me.PagoMesesCmb.Text)
                Dim DiasMes As String

                DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
                SQL = "SELECT * FROM cobroagua where fechapago Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fechapago asc"
                CargarPagos()
                Me.Titulolbl.Text = "TODOS LOS PAGOS DE AGUA POTABLE REALIZADOS EN EL MES DE " & Me.PagoMesesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
            End If

            'CARGAR TOTALES

        End If
        
        'ConectaServer()
        'CargarDatos()

    End Sub
    Public Sub CargarPagos()
        Try
            Me.DatosDtg.DataSource = Nothing
            'crear una nueva instancia del dataset
            CargaDatos = New DataSet
            'cargar los datos en el mysqldataadapter
            DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
            'rellenar el dataset con los datos cargados
            DatosAdapter.Fill(CargaDatos, "cobroagua")
            'asignar la fuente de datos al datagrid de detalles
            Me.DatosDtg.DataSource = CargaDatos
            'asignar la tabla que debe mostrar el datagrid
            Me.DatosDtg.DataMember = "cobroagua"
            'Dim c As Short
            Me.TotalPagosLbl.Text = Me.DatosDtg.Rows.Count
            'Ajustar ancho de columnas actomaticamente
            Dim c As Integer
            For c = 0 To Me.DatosDtg.Columns.Count - 1
                Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            Dim TotalIng As Double
            For c = 0 To Me.DatosDtg.Rows.Count - 1
                TotalIng += Val(Me.DatosDtg.Item(12, c).Value.ToString)
            Next
            'SQLCnn.Close()
            Me.TotalTomaslbl.Text = Format(CStr(TotalIng), "Currency")
            Me.DescripcionLbl.Text = "Imgreso Total: "
            Me.TituloTotalLbl.Text = "Total de pagos:"
            Me.TituloTotalLbl.Visible = True
            Me.TotalPagosLbl.Visible = True
            Me.ImprimirBrn.Enabled = True
            Me.CobrarBtn.Enabled = False
            Me.AdelantadoBtni.Enabled = False
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message, "Error: " & Ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PagosDiaDtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosDiaDtp.ValueChanged
        Mostrados = "Pagos"
        SQL = "SELECT * FROM cobroagua where fechapago ='" & Me.PagosDiaDtp.Value.Year & "-" & Me.PagosDiaDtp.Value.Month & "-" & Me.PagosDiaDtp.Value.Day & "' order by id_cobro asc"
        CargarPagos()
        Me.Titulolbl.Text = "TODOS LOS PAGOS DE AGUA POTABLE REALIZADOS EL DIA " & Me.PagosDiaDtp.Value.ToLongDateString.ToUpper
    End Sub

    Private Sub TomaActivaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TomaActivaToolStripMenuItem.Click
        If MessageBox.Show("Si no ha realizado el cobro del adeudo de esta toma," & Chr(13) & "el adeudo se calculara apartir del ultimo pago realizado." & Chr(13) & "Si no tiene adeudos, se tomará como pagado el mes actual" & Chr(13) & Chr(13) & "¿Confirma cambiar el estado de la toma No. " & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " a ACTIVA?", "Tomas de agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ObtenAdeudoToma()
            If Adeudo > 0 Then
                SQL = "UPDATE aguapotable SET estado='Activa', fechacancel=' ', adeudo=0 where id_toma=" & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " limit 1"
            Else
                Dim AuxMes As String
                If Now.Month < 10 Then
                    AuxMes = "0" & Now.Month
                Else
                    AuxMes = Now.Month
                End If
                SQL = "UPDATE aguapotable SET pagohasta='" & AuxMes & "-" & Now.Year & "', estado='Activa',  fechacancel=' ' where id_toma=" & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " limit 1"
            End If
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMCmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub SuspenderTomaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspenderTomaToolStripMenuItem.Click
        If Mostrados = "Buscar" Then
            Dim Estado As String
            Estado = Me.DatosDtg.Item(9, Me.DatosDtg.CurrentRow.Index).Value.ToString
            If Estado = "Cancelada" Or Estado = "Suspendida" Then
                MessageBox.Show("No se puede cambiar estado de la toma No. " & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " a SUSPENDIDA?", "Tomas de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If MessageBox.Show("¿Confirma cambiar el estado de la toma No. " & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " a SUSPENDIDA?", "Tomas de agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ObtenAdeudoToma()
            SQL = "UPDATE aguapotable SET estado='Suspendida', fechacancel='" & Now.Day & "/" & Now.Month & "/" & Now.Year & "', adeudo=" & Adeudo & " where id_toma=" & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " limit 1"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMCmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub CancelarTomaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarTomaToolStripMenuItem.Click
        If Mostrados = "Buscar" Then
            Dim Estado As String
            Estado = Me.DatosDtg.Item(9, Me.DatosDtg.CurrentRow.Index).Value.ToString
            If Estado = "Cancelada" Or Estado = "Suspendida" Then
                MessageBox.Show("No se puede cambiar estado de la toma No. " & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " a CANCELADA?", "Tomas de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If MessageBox.Show("¿Confirma cambiar el estado de la toma No. " & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " a CANCELADA?", "Tomas de agua potable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ObtenAdeudoToma()
            SQL = "UPDATE aguapotable SET estado='Cancelada', fechacancel='" & Now.Day & "/" & Now.Month & "/" & Now.Year & "', adeudo=" & Adeudo & " where id_toma=" & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString & " limit 1"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMCmd.ExecuteNonQuery()
        End If
    End Sub

    Sub ObtenAdeudoToma()
        Adeudo = 0
        If Mostrados = "Todas" Or Mostrados = "Buscar" Or Mostrados = "Suspendidas" Or Mostrados = "Canceladas" Or Mostrados = "CancelSusp" Then
            Adeudo = Val(Me.DatosDtg.Item(11, Me.DatosDtg.CurrentRow.Index).Value.ToString)
        Else
            Adeudo = Val(Me.DatosDtg.Item(9, Me.DatosDtg.CurrentRow.Index).Value.ToString)
        End If
    End Sub

    Private Sub ConfigNotiBrni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigNotiBrni.Click
        ConfigNotificFrm.ShowDialog()
    End Sub

    Private Sub ImprimirBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBrn.Click
        If Mostrados = "Pagos" And Me.DatosDtg.Rows.Count > 0 Then
            ReporteFrm.Datos.Clear()
            Dim i As Integer
            For i = 0 To Me.DatosDtg.Rows.Count - 1
                ReporteFrm.Datos.Add(New DatosReporteCls(Me.DatosDtg.Item(1, i).Value, Me.DatosDtg.Item(2, i).Value, Me.DatosDtg.Item(3, i).Value, Me.DatosDtg.Item(10, i).Value, Me.DatosDtg.Item(4, i).Value.ToString, Me.DatosDtg.Item(6, i).Value.ToString & "" & Me.DatosDtg.Item(7, i).Value.ToString & ", " & Me.DatosDtg.Item(6, i).Value.ToString, Me.DatosDtg.Item(8, i).Value.ToString, Me.DatosDtg.Item(9, i).Value.ToString, Me.DatosDtg.Item(11, i).Value, Me.DatosDtg.Item(12, i).Value, Mid(Me.DatosDtg.Item(13, i).Value.ToString, 1, 10)))
                'MessageBox.Show(Me.DatosDtg.Item(1, i).Value.ToString)
            Next
            ReporteFrm.Show()
        Else
            MessageBox.Show("No se encontro nada que imprimir", "Sistema de Agua Potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PagDelAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagDelAnoCmb.SelectedIndexChanged
        SQL = "SELECT * FROM cobroagua where fechapago like '%" & Me.PagDelAnoCmb.Text & "%'"
        Me.Titulolbl.Text = "TODOS LOS PAGOS DE AGUA POTABLE REALIZADOS EN EL AÑO " & Me.PagDelAnoCmb.Text
        CargarPagos()
        Mostrados = "Pagos"
    End Sub

    Private Sub PagosTodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosTodosBtn.Click
        SQL = "SELECT * FROM cobroagua"
        Me.Titulolbl.Text = "TODOS LOS PAGOS DE AGUA POTABLE REGISTRADOS"
        CargarPagos()
        Mostrados = "Pagos"
    End Sub

    Private Sub LocalidadesCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LocalidadesCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CostoRegSBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostoRegSBtn.Click
        CostoRegistrofrm.ShowDialog()
    End Sub

    Private Sub SancionBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SancionBtn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            Multafrm.NoTomaTxt.Text = Val(Me.DatosDtg(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
            Multafrm.ShowDialog()
        End If
    End Sub
End Class