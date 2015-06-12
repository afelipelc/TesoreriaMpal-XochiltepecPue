Imports System
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.Collections
Public Class RegistroCivilfrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    'Dim DetaTarMDR As MySqlDataReader
    'Dim DetaTarMCMD As MySqlCommand
    Public Cobrado, Resumen As Boolean
    Dim Condicion As String

    Private Sub RegistroCivilfrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
        CargaRegCivilFrm.Dispose()
    End Sub

    Private Sub RegistroCivilfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConectaServer()
        CargarConfig()
        Me.Text += Ayuntamiento & " : REGISTRO CIVIL"
        'cargar los años de los que se encuentra la info almacenada
        Me.PagDelAnoCmb.Items.Clear()
        Dim i, DatAno As Short
        DatAno = Now.Year - DatosAno
        For i = 0 To DatAno
            Me.PagDelAnoCmb.Items.Add(DatosAno + i)
        Next
    End Sub

    Private Sub ConfigBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigBtn.Click
        ConfiRegCivilfrm.ShowDialog()
    End Sub

    Public Sub CargarPagos()
        Me.IngresoTotalLbl.Text = ""
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "cobroregcivil")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "cobroregcivil"
        'Dim c As Short
        Me.ConceptosTotallbl.Text = Me.DatosDtg.Rows.Count
        Me.ConceptosTituloLbl.Text = "Total de Pagos:"
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        'For c = 0 To Me.DatosDtg.Columns.Count - 1
        ' Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'Next
        For c = 0 To Me.DatosDtg.Rows.Count - 1
            Me.IngresoTotalLbl.Text = Val(Me.IngresoTotalLbl.Text) + Val(Me.DatosDtg.Item(8, c).Value.ToString)
        Next
        Me.IngresoTotalLbl.Text = Format(CStr(Val(Me.IngresoTotalLbl.Text)), "Currency")
        Me.ImprimirBrn.Enabled = True
        Me.VerPagoBtn.Enabled = True
        'SQLCnn.Close()
    End Sub

    Public Sub CargarDetalles()
        Me.IngresoTotalLbl.Text = ""
        Me.ConceptosTotallbl.Text = ""
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "detallesregcivil")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "detallesregcivil"
        'Dim c As Short
        Me.ConceptosTituloLbl.Text = "Total de Conceptos:"
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        For c = 0 To Me.DatosDtg.Rows.Count - 1
            If Resumen = True Then
                Me.IngresoTotalLbl.Text = Val(Me.IngresoTotalLbl.Text) + Val(Me.DatosDtg.Item(3, c).Value.ToString)
                Me.ConceptosTotallbl.Text = Val(Me.ConceptosTotallbl.Text) + Val(Me.DatosDtg.Item(2, c).Value.ToString)
            Else
                Me.IngresoTotalLbl.Text = Val(Me.IngresoTotalLbl.Text) + Val(Me.DatosDtg.Item(5, c).Value.ToString)
            End If
        Next
        If Resumen = False Then
            Me.ConceptosTotallbl.Text = Me.DatosDtg.Rows.Count
        End If

        Me.ImprimirBrn.Enabled = False
        Me.VerPagoBtn.Enabled = False
        'SQLCnn.Close()
    End Sub

    Private Sub PagosTodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosTodosBtn.Click
        SQL = "SELECT * FROM cobroregcivil"
        Condicion = ""
        Me.TituloLbl.Text = "TODOS LOS INGRESOS DEL REGISTRO CIVIL REGISTRADOS"
        CargarPagos()
    End Sub

    Private Sub PagosMesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosMesCmb.SelectedIndexChanged
        Me.PagosMesCmb.Text = Me.PagosMesCmb.SelectedItem
        'sSQL = "Select * from SolicExtractostbl where Fecha_Entregado Between #" & Mes & "/01/" & Now.Year & "# And #" & Mes & "/" & Dias & "/" & Now.Year & "# and Estado='Entregado'"
        If Me.PagosMesCmb.Text <> "" Then
            ObtenNMes(Me.PagosMesCmb.Text)
            Dim DiasMes As String

            DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
            SQL = "SELECT * FROM cobroregcivil where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
            Condicion = " where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "'"
            CargarPagos()
            Me.TituloLbl.Text = "TODOS LOS INGRESOS DEL REGISTRO CIVIL REGISTRADOS EN EL MES DE " & Me.PagosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
            'CARGAR TOTALES
        End If
    End Sub

    Private Sub PagoMesFiltroCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagoMesFiltroCmb.SelectedIndexChanged
        If Me.PagosMesCmb.Text <> "" Then
            Me.PagoMesFiltroCmb.Text = Me.PagoMesFiltroCmb.SelectedItem
            ObtenNMes(Me.PagosMesCmb.Text)
            Dim DiasMes As String
            Resumen = False
            DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
            'aqui se hace el filtro por mes
            'Registros
            'Extractos
            'Resumen
            'Todos
            Select Case Me.PagoMesFiltroCmb.Text
                Case "Todos"
                    SQL = "SELECT * FROM cobroregcivil where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
                    Me.TituloLbl.Text = "TODOS LOS INGRESOS DEL REGISTRO CIVIL REGISTRADOS EN EL MES DE " & Me.PagosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    CargarPagos()
                Case "Registros"
                    SQL = "SELECT * FROM detallesregcivil where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and tipo='Registro' order by fecha asc"
                    Me.TituloLbl.Text = "REGISTROS REALIZADOS EN EL MES DE " & Me.PagosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    CargarDetalles()
                Case "Extractos"
                    SQL = "SELECT * FROM detallesregcivil where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and tipo='Extracto' order by fecha asc"
                    Me.TituloLbl.Text = "EXTRACTOS EXPEDIDOS EN EL MES DE " & Me.PagosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    CargarDetalles()
                Case "Resumen"
                    'SELECT Extracto_de, Count(Extracto_de) as Cantidad, SUM(Costo) AS Total  FROM SolicExtractostbl Where Estado='Entregado' and Fecha_Entregado Between #" & Mesde & "/" & Diade & "/" & Me.aPartirDeDtp.Value.Year & "# And #" & Mesa & "/" & Diaa & "/" & Me.HastaDtp.Value.Year & "# GROUP BY Extracto_de"
                    SQL = "select tipo, nombre, Count(nombre) as Cantidad, SUM(costo) AS Total FROM detallesregcivil where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' GROUP BY tipo,nombre" ' WITH ROLLUP"
                    Me.TituloLbl.Text = "RESUMEN DE INGRESOS DEL REGISTRO CIVIL DEL MES DE " & Me.PagosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    Resumen = True
                    CargarDetalles()
            End Select
            Condicion = " where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "'" ' WITH ROLLUP"
            'CargarPagos()
        End If
    End Sub

    Private Sub PagosDiaDtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosDiaDtp.ValueChanged
        SQL = "SELECT * FROM cobroregcivil where fecha ='" & Me.PagosDiaDtp.Value.Year & "-" & Me.PagosDiaDtp.Value.Month & "-" & Me.PagosDiaDtp.Value.Day & "' order by id_reg asc"
        CargarPagos()
        Me.TituloLbl.Text = "TODOS LOS INGRESOS DEL REGISTRO CIVIL REGISTRADOS EL DIA " & Me.PagosDiaDtp.Value.ToLongDateString.ToUpper
    End Sub

    Private Sub PagosDiaCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosDiaCmb.SelectedIndexChanged

        Me.PagosDiaCmb.Text = Me.PagosDiaCmb.SelectedItem
        Select Case Me.PagosDiaCmb.Text
            Case "Todos"
                SQL = "SELECT * FROM cobroregcivil where fecha='" & Me.PagosDiaDtp.Value.Year & "-" & Me.PagosDiaDtp.Value.Month & "-" & Me.PagosDiaDtp.Value.Day & "' order by fecha asc"
                Me.TituloLbl.Text = "TODOS LOS INGRESOS DEL REGISTRO CIVIL REGISTRADOS EL DIA " & Me.PagosDiaDtp.Value.ToLongDateString.ToUpper
                CargarPagos()
            Case "Registros"
                SQL = "SELECT * FROM detallesregcivil where fecha='" & Me.PagosDiaDtp.Value.Year & "-" & Me.PagosDiaDtp.Value.Month & "-" & Me.PagosDiaDtp.Value.Day & "' and tipo='Registro' order by fecha asc"
                Me.TituloLbl.Text = "REGISTROS REALIZADOS EL DIA " & Me.PagosDiaDtp.Value.ToLongDateString.ToUpper
                CargarDetalles()
            Case "Extractos"
                SQL = "SELECT * FROM detallesregcivil where fecha='" & Me.PagosDiaDtp.Value.Year & "-" & Me.PagosDiaDtp.Value.Month & "-" & Me.PagosDiaDtp.Value.Day & "' and tipo='Extracto' order by fecha asc"
                Me.TituloLbl.Text = "EXTRACTOS EXPEDIDOS EL DIA " & Me.PagosDiaDtp.Value.ToLongDateString.ToUpper
                CargarDetalles()
            Case "Resumen"
                'SELECT Extracto_de, Count(Extracto_de) as Cantidad, SUM(Costo) AS Total  FROM SolicExtractostbl Where Estado='Entregado' and Fecha_Entregado Between #" & Mesde & "/" & Diade & "/" & Me.aPartirDeDtp.Value.Year & "# And #" & Mesa & "/" & Diaa & "/" & Me.HastaDtp.Value.Year & "# GROUP BY Extracto_de"
                SQL = "select tipo, nombre, Count(nombre) as Cantidad, SUM(costo) AS Total FROM detallesregcivil where fecha='" & Me.PagosDiaDtp.Value.Year & "-" & Me.PagosDiaDtp.Value.Month & "-" & Me.PagosDiaDtp.Value.Day & "' GROUP BY tipo,nombre" ' WITH ROLLUP"
                Me.TituloLbl.Text = "RESUMEN DE INGRESOS DEL REGISTRO CIVIL DEL DIA " & Me.PagosDiaDtp.Value.ToLongDateString.ToUpper
                Resumen = True
                CargarDetalles()
        End Select
        Condicion = " where fecha='" & Me.PagosDiaDtp.Value.Year & "-" & Me.PagosDiaDtp.Value.Month & "-" & Me.PagosDiaDtp.Value.Day & "'" ' WITH ROLLUP"
        'CargarPagos()

    End Sub

    Private Sub PagDelAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagDelAnoCmb.SelectedIndexChanged
        SQL = "SELECT * FROM cobroregcivil where fecha like '%" & Me.PagDelAnoCmb.Text & "%'"
        Me.TituloLbl.Text = "TODOS LOS INGRESOS DEL REGISTRO CIVIL REGISTRADOS EN EL AÑO " & Me.PagDelAnoCmb.Text
        CargarPagos()
    End Sub

    Private Sub PagosAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosAnoCmb.SelectedIndexChanged
        Me.PagosAnoCmb.Text = Me.PagosAnoCmb.SelectedItem
        Select Case Me.PagosAnoCmb.Text
            Case "Todos"
                SQL = "SELECT * FROM cobroregcivil where fecha like '%" & Me.PagDelAnoCmb.Text & "%'"
                Me.TituloLbl.Text = "TODOS LOS INGRESOS DEL REGISTRO CIVIL REGISTRADOS EN EL AÑO " & Me.PagDelAnoCmb.Text
                CargarPagos()
            Case "Registros"
                SQL = "SELECT * FROM detallesregcivil where fecha like '%" & Me.PagDelAnoCmb.Text & "%' and tipo='Registro' order by fecha asc"
                Me.TituloLbl.Text = "REGISTROS REALIZADOS EN EL AÑO " & Me.PagDelAnoCmb.Text
                CargarDetalles()
            Case "Extractos"
                SQL = "SELECT * FROM detallesregcivil where fecha like '%" & Me.PagDelAnoCmb.Text & "%' and tipo='Extracto' order by fecha asc"
                Me.TituloLbl.Text = "EXTRACTOS EXPEDIDOS EN EL AÑO " & Me.PagDelAnoCmb.Text
                CargarDetalles()
            Case "Resumen"
                'SELECT Extracto_de, Count(Extracto_de) as Cantidad, SUM(Costo) AS Total  FROM SolicExtractostbl Where Estado='Entregado' and Fecha_Entregado Between #" & Mesde & "/" & Diade & "/" & Me.aPartirDeDtp.Value.Year & "# And #" & Mesa & "/" & Diaa & "/" & Me.HastaDtp.Value.Year & "# GROUP BY Extracto_de"
                SQL = "select tipo, nombre, Count(nombre) as Cantidad, SUM(costo) AS Total FROM detallesregcivil where fecha like '%" & Me.PagDelAnoCmb.Text & "%' GROUP BY tipo,nombre" ' WITH ROLLUP"
                Me.TituloLbl.Text = "RESUMEN DE INGRESOS DEL REGISTRO CIVIL DEL AÑO " & Me.PagDelAnoCmb.Text
                Resumen = True
                CargarDetalles()
        End Select
        Condicion = " where fecha like '%" & Me.PagDelAnoCmb.Text & "%'"
        'CargarPagos()
    End Sub

    Private Sub NPagoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NPagoBtn.Click
        NuevoIngresoFrm.Comando = "Nuevo"
        NuevoIngresoFrm.ShowDialog()
    End Sub

    Private Sub VerPagoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerPagoBtn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            NuevoIngresoFrm.IdPago = Val(Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
            NuevoIngresoFrm.Comando = "Abrir"
            NuevoIngresoFrm.ShowDialog()
        End If
    End Sub

    Private Sub ImprimirBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBrn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            Reportefrm.DatosResumen.Clear()
            Reportefrm.DatosDetalle.Clear()
            SQL = "select tipo, nombre, Count(nombre) as Cantidad, SUM(costo) AS Total FROM detallesregcivil" & Condicion & " GROUP BY tipo,nombre"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'cargar los detalles a la tabla de datos
            While DatosMDR.Read
                Reportefrm.DatosResumen.Add(New DatosResumecls(DatosMDR!tipo.ToString, DatosMDR!nombre.ToString, DatosMDR!Cantidad, DatosMDR!Total))
            End While
            DatosMDR.Close()

            'agregar todos los detalles a la tabla de detalles
            Dim i As Integer
            For i = 0 To Me.DatosDtg.Rows.Count - 1
                Reportefrm.DatosDetalle.Add(New DatosPagosCls(Me.DatosDtg.Item(1, i).Value.ToString, Me.DatosDtg.Item(2, i).Value.ToString, Me.DatosDtg.Item(4, i).Value.ToString & " " & Me.DatosDtg.Item(5, i).Value.ToString & ", " & Me.DatosDtg.Item(3, i).Value.ToString, Me.DatosDtg.Item(6, i).Value.ToString, Me.DatosDtg.Item(7, i).Value, Me.DatosDtg.Item(8, i).Value, Me.DatosDtg.Item(10, i).Value.ToString, Mid(Me.DatosDtg.Item(9, i).Value.ToString, 1, 10)))
            Next
            Reportefrm.Show()
        Else
            MessageBox.Show("No se encontro nada que imprimir", "Registro Civil", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PagosMesCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PagosMesCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PagDelAnoCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PagDelAnoCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub
End Class